using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orders_app
{
    public partial class Add_new_orderForm : Form
    {
        private bool isOrderExists = false;
        private int orderID = -1;

        public Add_new_orderForm()
        {
            InitializeComponent();
            ActiveControl = this.label_newPosition;
            if (Global.GlobalVar != -1)
            {
                Data_Base db = new Data_Base();
                MySqlDataReader dataReader;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();
                db.openConnection();
                MySqlCommand getName = new MySqlCommand("SELECT `CUST_FULL_NAME` FROM `orders` WHERE `ID` = @oID", db.getConnection());
                getName.Parameters.Add("@oID", MySqlDbType.Int32).Value = Global.GlobalVar;
                adapter.SelectCommand = getName;
                adapter.Fill(table);

                dataReader = getName.ExecuteReader();
                while (dataReader.Read())
                {
                    customer_name_field.Text = dataReader.GetValue(0).ToString();
                }
                db.closeConnection();
                isOrderExists = true;
                customer_name_field.Enabled = false;
                orderID = Global.GlobalVar;
            }
        }

        #region FillData
        private void customer_name_field_Enter(object sender, EventArgs e)
        {
            if (customer_name_field.Text == "Enter the client's full name")
            {
                customer_name_field.Text = "";
                customer_name_field.ForeColor = Color.Black;
            }
        }

        private void good_name_field_Enter(object sender, EventArgs e)
        {
            if (good_name_field.Text == "Enter product name")
            {
                good_name_field.Text = "";
                good_name_field.ForeColor = Color.Black;
            }
        }

        private void cost_field_Enter(object sender, EventArgs e)
        {
            if (cost_field.Text == "Enter the price per item")
            {
                cost_field.Text = "";
                cost_field.ForeColor = Color.Black;
            }
        }

        private void amount_field_Enter(object sender, EventArgs e)
        {
            if (amount_field.Text == "Enter quantity")
            {
                amount_field.Text = "";
                amount_field.ForeColor = Color.Black;
            }
        }

        private void customer_name_field_Leave(object sender, EventArgs e)
        {
            if (customer_name_field.Text == "")
            {
                customer_name_field.ForeColor = Color.Silver;
                customer_name_field.Text = "Enter the client's full name";
            }
        }

        private void good_name_field_Leave(object sender, EventArgs e)
        {
            if (good_name_field.Text == "")
            {
                good_name_field.ForeColor = Color.Silver;
                good_name_field.Text = "Enter product name";
            }
        }

        private void cost_field_Leave(object sender, EventArgs e)
        {
            if (cost_field.Text == "")
            {
                cost_field.ForeColor = Color.Silver;
                cost_field.Text = "Enter the price per item";
            }
        }

        private void amount_field_Leave(object sender, EventArgs e)
        {
            if (amount_field.Text == "")
            {
                amount_field.ForeColor = Color.Silver;
                amount_field.Text = "Enter quantity";
            }
        }

        #endregion

        private void button_AddPosition_Click(object sender, EventArgs e)
        {
            if (customer_name_field.Text == "Enter the client's full name")
            {
                MessageBox.Show("Incorrect client name entry");
                return;
            }

            if (customer_name_field.Text.Length >= 50)
            {
                MessageBox.Show("Name must be less than 50 characters");
                return;
            }

            if (good_name_field.Text == "Enter product name")
            {
                MessageBox.Show("Incorrect product name entry");
                return;
            }

            if (good_name_field.Text.Length >= 50)
            {
                MessageBox.Show("Product name must be less than 50 characters");
                return;
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(cost_field.Text, "[^0-9,0-9]"))
            {
                MessageBox.Show("Incorrect price entry. Please check if you use comma ',' instead of dot '.'");
                return;
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(amount_field.Text, "[^0-9]"))
            {
                MessageBox.Show("Incorrect entry of quantity");
                return;
            }


            if (isOrderExists == false)
            {
                Data_Base db = new Data_Base();
                MySqlCommand insertOrder = new MySqlCommand("INSERT INTO `orders` (`_DATE`, `CUST_FULL_NAME`, `ORDER_COST`) VALUES (@DATE, @NAME, @COST)", db.getConnection());
                insertOrder.Parameters.Add("@DATE", MySqlDbType.Date).Value = DateTime.Now;
                insertOrder.Parameters.Add("@NAME", MySqlDbType.VarChar).Value = customer_name_field.Text;
                float orderCost = float.Parse(cost_field.Text) * float.Parse(amount_field.Text);
                insertOrder.Parameters.Add("@COST", MySqlDbType.Float).Value = orderCost;
                isOrderExists = true;
                customer_name_field.Enabled = false;
                db.openConnection();
                if (insertOrder.ExecuteNonQuery() == 1)
                {
                    db.closeConnection();
                    MessageBox.Show("The order has been generated");
                }


                MySqlDataReader dataReader;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();
                db.openConnection();
                MySqlCommand maxID = new MySqlCommand("SELECT MAX(`ID`) FROM `orders`", db.getConnection());
                adapter.SelectCommand = maxID;
                adapter.Fill(table);
                int size = table.Rows.Count;
                dataReader = maxID.ExecuteReader();
                while (dataReader.Read())
                {
                    orderID = int.Parse(dataReader.GetValue(0).ToString());
                }
                db.closeConnection();


                MySqlCommand insertPosition = new MySqlCommand("INSERT INTO `positions` (`GOOD_NAME`, `GOOD_PRICE`, `AMOUNT`, `POSITION_COST`, `ORDER_ID`) " +
                    "VALUES (@gNAME, @gPRICE, @gAMOUNT, @pCOST, @oID)", db.getConnection());
                insertPosition.Parameters.Add("@gNAME", MySqlDbType.VarChar).Value = good_name_field.Text;
                insertPosition.Parameters.Add("@gPRICE", MySqlDbType.Float).Value = float.Parse(cost_field.Text);
                insertPosition.Parameters.Add("@gAMOUNT", MySqlDbType.Int32).Value = amount_field.Text;
                insertPosition.Parameters.Add("@pCOST", MySqlDbType.Float).Value = orderCost;
                insertPosition.Parameters.Add("@oID", MySqlDbType.Int32).Value = orderID;
                db.openConnection();
                if (insertPosition.ExecuteNonQuery() == 1)
                {
                    db.closeConnection();
                    MessageBox.Show("A new position has been added");
                }
            }






            else if (isOrderExists == true)
            {
                Data_Base db = new Data_Base();
                float orderCost = float.Parse(cost_field.Text) * float.Parse(amount_field.Text);
                MySqlCommand insertPosition = new MySqlCommand("INSERT INTO `positions` (`GOOD_NAME`, `GOOD_PRICE`, `AMOUNT`, `POSITION_COST`, `ORDER_ID`) " +
                    "VALUES (@gNAME, @gPRICE, @gAMOUNT, @pCOST, @oID)", db.getConnection());
                insertPosition.Parameters.Add("@gNAME", MySqlDbType.VarChar).Value = good_name_field.Text;
                insertPosition.Parameters.Add("@gPRICE", MySqlDbType.Float).Value = float.Parse(cost_field.Text);
                insertPosition.Parameters.Add("@gAMOUNT", MySqlDbType.Int32).Value = amount_field.Text;
                insertPosition.Parameters.Add("@pCOST", MySqlDbType.Float).Value = orderCost;
                insertPosition.Parameters.Add("@oID", MySqlDbType.Int32).Value = orderID;
                db.openConnection();
                if (insertPosition.ExecuteNonQuery() == 1)
                {
                    db.closeConnection();
                    MessageBox.Show("A new position has been added");
                }


                float tempOrderCost = 0;
                MySqlDataReader dataReader;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();
                db.openConnection();
                MySqlCommand getOrderCost = new MySqlCommand("SELECT `ORDER_COST` FROM `orders` WHERE `ID` = @oID", db.getConnection());
                getOrderCost.Prepare();
                getOrderCost.Parameters.Add("@oID", MySqlDbType.Int32).Value = orderID;
                adapter.SelectCommand = getOrderCost;
                adapter.Fill(table);
                dataReader = getOrderCost.ExecuteReader();
                while (dataReader.Read())
                {
                    tempOrderCost = float.Parse(dataReader.GetValue(0).ToString());
                }
                db.closeConnection();

                tempOrderCost += orderCost;
                MySqlDataAdapter adapter_new = new MySqlDataAdapter();
                db.openConnection();
                MySqlCommand setOrderCost = new MySqlCommand("UPDATE `orders` SET `ORDER_COST` = @nOC WHERE `ID` = @oID", db.getConnection());
                setOrderCost.Prepare();
                setOrderCost.Parameters.Add("@nOC", MySqlDbType.Float).Value = tempOrderCost;
                setOrderCost.Parameters.Add("@oID", MySqlDbType.Int32).Value = orderID;
                adapter_new.SelectCommand = setOrderCost;

                if (setOrderCost.ExecuteNonQuery() == 1)
                {
                    db.closeConnection();
                    MessageBox.Show("Order amount updated");
                }
                Global.GlobalVar = -1;
            }
        }

        private void Add_new_orderForm_Load(object sender, EventArgs e)
        {

        }
    }
}
