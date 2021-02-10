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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Order_List.DataSource = Get_Order_List();
            customer_name_field.Enabled = false;
        }

        private DataTable Get_Order_List()
        {
            Data_Base db = new Data_Base();
            MySqlDataReader dataReader;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            try
            {
                db.openConnection();
                MySqlCommand command = new MySqlCommand("SELECT `ID` AS 'Order number', `_DATE` AS 'Date', `CUST_FULL_NAME` AS 'Full name', " +
                    "`ORDER_COST` AS 'Total order sum' FROM `orders`", db.getConnection());
                adapter.SelectCommand = command;
                dataReader = command.ExecuteReader();
                table.Load(dataReader);
                db.closeConnection();
            }

            catch (MySqlConnector.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return table;
        }

        private void button_showPositions_Click(object sender, EventArgs e)
        {
            string order_ID = textBox_showPositions.Text;
            Data_Base db = new Data_Base();
            MySqlDataReader dataReader;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            try
            {
                if (order_ID == "")
                {
                    throw new MyException();
                }

                db.openConnection();
                MySqlCommand command = new MySqlCommand("SELECT `ID` AS 'Position number', `GOOD_NAME` AS 'Product name', " +
                    "`GOOD_PRICE` AS 'Price', `AMOUNT` AS 'Amount', `POSITION_COST` AS 'Cost' FROM `positions` WHERE `ORDER_ID` = @ID", db.getConnection());
                adapter.SelectCommand = command;
                command.Parameters.Add("@ID", MySqlDbType.Int32).Value = order_ID;
                dataReader = command.ExecuteReader();
                table.Load(dataReader);
                db.closeConnection();
                Position_List.DataSource = table;
            }
            catch (MyException myEx)
            {
                MessageBox.Show(myEx.ShowMessage);
            }
            catch (MySqlConnector.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button_Period_Click(object sender, EventArgs e)
        {

            string from = dateTimePicker_From.Value.Date.ToString("yyyy-MM-dd");
            string to = dateTimePicker_To.Value.Date.ToString("yyyy-MM-dd");

            Data_Base db = new Data_Base();
            MySqlDataReader dataReader;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            try
            {
                db.openConnection();
                MySqlCommand command = new MySqlCommand("SELECT `ID` AS 'Order number', `_DATE` AS 'Date', `CUST_FULL_NAME` AS 'Full name', " +
                    "`ORDER_COST` AS 'Total order sum' FROM `orders` WHERE `_DATE` >= @FROM AND `_DATE` <= @TO", db.getConnection());
                adapter.SelectCommand = command;
                command.Parameters.Add("@FROM", MySqlDbType.Date).Value = from;
                command.Parameters.Add("@TO", MySqlDbType.Date).Value = to;
                dataReader = command.ExecuteReader();
                table.Load(dataReader);
                db.closeConnection();
                Order_List.DataSource = table;
            }
            catch (MySqlConnector.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_addNewOrder_Click(object sender, EventArgs e)
        {
            Add_new_orderForm _New_OrderForm = new Add_new_orderForm();
            this.Enabled = false;
            _New_OrderForm.ShowDialog();
            this.Enabled = true;
        }

        private void button_eraseOrder_Click(object sender, EventArgs e)
        {
            string order_ID = textBox_eraseOrder.Text;
            Data_Base db = new Data_Base();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlDataReader MyReader;
            try
            {
                if (order_ID == "")
                {
                    throw new MyException();
                }

                db.openConnection();
                MySqlCommand _command = new MySqlCommand("DELETE FROM `positions` WHERE `ORDER_ID` = @oID", db.getConnection());
                _command.Parameters.Add("@oID", MySqlDbType.Int32).Value = order_ID;
                MyReader = _command.ExecuteReader();
                db.closeConnection();

                db.openConnection();
                MySqlCommand command = new MySqlCommand("DELETE FROM `orders` WHERE `ID` = @ID", db.getConnection());
                command.Parameters.Add("@ID", MySqlDbType.Int32).Value = order_ID;
                MyReader = command.ExecuteReader();
                db.closeConnection();
                MessageBox.Show("Order has been deleted. Please, reload the list of the orders");
            }
            catch (MyException myEx)
            {
                MessageBox.Show(myEx.ShowMessage);
            }
            catch (MySqlConnector.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string order_ID = textBox_changeOrderName.Text;
            try
            {
                if (order_ID == "")
                {
                    throw new MyException();
                }
                Data_Base db = new Data_Base();
                MySqlDataReader dataReader;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();
                db.openConnection();
                MySqlCommand findName = new MySqlCommand("SELECT `CUST_FULL_NAME` FROM `orders` WHERE `ID` = @oID", db.getConnection());
                findName.Parameters.Add("@oID", MySqlDbType.Int32).Value = order_ID;
                adapter.SelectCommand = findName;
                adapter.Fill(table);
                int size = table.Rows.Count;
                dataReader = findName.ExecuteReader();
                while (dataReader.Read())
                {
                    customer_name_field.Text = dataReader.GetValue(0).ToString();
                }
                db.closeConnection();
                customer_name_field.Enabled = true;


            }
            catch (MyException myEx)
            {
                MessageBox.Show(myEx.ShowMessage);
            }
        }

        private void button_confirmChange_Click(object sender, EventArgs e)
        {
            if (customer_name_field.Text == "")
            {
                MessageBox.Show("Order isn't chosen yet");
                return;
            }
            Data_Base db = new Data_Base();
            MySqlDataAdapter adapter_new = new MySqlDataAdapter();
            db.openConnection();
            MySqlCommand setOrderName = new MySqlCommand("UPDATE `orders` SET `CUST_FULL_NAME` = @NAME WHERE `ID` = @oID", db.getConnection());
            setOrderName.Prepare();
            setOrderName.Parameters.Add("@NAME", MySqlDbType.String).Value = customer_name_field.Text;
            setOrderName.Parameters.Add("@oID", MySqlDbType.Int32).Value = int.Parse(textBox_changeOrderName.Text);
            adapter_new.SelectCommand = setOrderName;

            if (setOrderName.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                MessageBox.Show("Name for order has been changed");
            }
        }

        private void button__addPosition_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_addPosition.Text == "")
                {
                    throw new MyException();
                }
                Global.GlobalVar = int.Parse(textBox_addPosition.Text);

                Add_new_orderForm _New_OrderForm = new Add_new_orderForm();
                this.Enabled = false;
                _New_OrderForm.ShowDialog();
                this.Enabled = true;
            }
            catch (MyException myEx)
            {
                MessageBox.Show(myEx.ShowMessage);
            }
        }

        private void button_erasePosition_Click(object sender, EventArgs e)
        {
            if (textBox_erasePosition.Text == "")
            {
                MessageBox.Show("You have not entered a position number .");
                return;
            }

            float positionCost = 0;
            Data_Base db = new Data_Base();
            MySqlDataReader dataReader;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            db.openConnection();
            MySqlCommand getPosCost = new MySqlCommand("SELECT `POSITION_COST` FROM `positions` WHERE `ID` = @oID", db.getConnection());
            getPosCost.Prepare();
            getPosCost.Parameters.Add("@oID", MySqlDbType.Int32).Value = int.Parse(textBox_erasePosition.Text);
            adapter.SelectCommand = getPosCost;
            adapter.Fill(table);
            dataReader = getPosCost.ExecuteReader();
            while (dataReader.Read())
            {
                positionCost = float.Parse(dataReader.GetValue(0).ToString());
            }
            db.closeConnection();



            int orderID = -1;
            db.openConnection();
            MySqlCommand getOrderID = new MySqlCommand("SELECT `ORDER_ID` FROM `positions` WHERE `ID` = @orderID", db.getConnection());
            getOrderID.Prepare();
            getOrderID.Parameters.Add("@orderID", MySqlDbType.Int32).Value = int.Parse(textBox_erasePosition.Text);
            adapter.SelectCommand = getOrderID;
            adapter.Fill(table);
            dataReader = getOrderID.ExecuteReader();
            while (dataReader.Read())
            {
                orderID = int.Parse(dataReader.GetValue(0).ToString());
            }
            db.closeConnection();




            MySqlDataReader MyReader;
            db.openConnection();
            MySqlCommand deleteCommand = new MySqlCommand("DELETE FROM `positions` WHERE `ID` = @oID", db.getConnection());
            deleteCommand.Parameters.Add("@oID", MySqlDbType.Int32).Value = int.Parse(textBox_erasePosition.Text);
            MyReader = deleteCommand.ExecuteReader();
            db.closeConnection();

            float tempOrderCost = 0;
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

            db.openConnection();
            tempOrderCost -= positionCost;
            MySqlCommand setOrderCost = new MySqlCommand("UPDATE `orders` SET `ORDER_COST` = @nOC WHERE `ID` = @oID", db.getConnection());
            setOrderCost.Prepare();
            setOrderCost.Parameters.Add("@nOC", MySqlDbType.Float).Value = tempOrderCost;
            setOrderCost.Parameters.Add("@oID", MySqlDbType.Int32).Value = orderID;
            adapter.SelectCommand = setOrderCost;

            if (setOrderCost.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                MessageBox.Show("Order amount updated ");
            }
        }
    }
}
