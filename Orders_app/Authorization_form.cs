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
    public partial class Authorization_form : Form
    {
        //Initialization
        Registration_form reg_Form = new Registration_form();
        public static Point lastPoint;
        public Authorization_form()
        {
            InitializeComponent();
            ActiveControl = Label_autho;
        }
        //Initialization

        #region Change_Form_Location
        public static Point getPoint()
        {
            return lastPoint;
        }

        private void Label_autho_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void Label_autho_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel_fields_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void panel_fields_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void picture_login_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void picture_login_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void picture_password_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void picture_password_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel_buttons_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void panel_buttons_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        #endregion

        #region Reaching_Register_Form
        private void label_toRegister_Click(object sender, EventArgs e)
        {
            ActiveControl = label_toRegister;
            this.Hide();
            reg_Form.Location = this.Location;
            reg_Form.ShowDialog();
            this.Location = reg_Form.Location;
            this.Show();
        }

        private void label_toRegister_MouseEnter(object sender, EventArgs e)
        {
            label_toRegister.ForeColor = Color.Red;
        }

        private void label_toRegister_MouseLeave(object sender, EventArgs e)
        {
            label_toRegister.ForeColor = Color.Black;
        }
        #endregion

        #region Disable_ActiveControl_For_TextBoxes
        private void Label_autho_Click(object sender, EventArgs e) => ActiveControl = panel_label;

        private void panel_fields_Click(object sender, EventArgs e)
        {
            ActiveControl = panel_label;
        }

        private void picture_login_Click(object sender, EventArgs e)
        {
            ActiveControl = panel_label;
        }

        private void picture_password_Click(object sender, EventArgs e)
        {
            ActiveControl = panel_label;
        }

        private void panel_buttons_Click(object sender, EventArgs e)
        {
            ActiveControl = panel_label;
        }
        #endregion

        #region Fill_TextBoxes
        private void login_field_Enter(object sender, EventArgs e)
        {
            if (login_field.Text == "Login")
            {
                login_field.Text = "";
                login_field.ForeColor = Color.Black;
            }
        }

        private void login_field_Leave(object sender, EventArgs e)
        {
            if (login_field.Text == "Login" || login_field.Text == "")
            {
                login_field.Text = "Login";
                login_field.ForeColor = Color.Silver;
            }
        }

        private void password_field_Enter(object sender, EventArgs e)
        {
            if (password_field.Text == "Password")
            {
                if (checkBoxPass.Checked == true)
                {
                    password_field.UseSystemPasswordChar = true;
                }
                password_field.Text = "";
                password_field.ForeColor = Color.Black;
            }
        }

        private void password_field_Leave(object sender, EventArgs e)
        {
            if (password_field.Text == "")
            {
                password_field.Text = "Password";
                password_field.ForeColor = Color.Silver;
                password_field.UseSystemPasswordChar = false;
                ActiveControl = panel_fields;
                ActiveControl = checkBoxPass;
            }
        }

        private void checkBoxPass_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxPass.Checked == true && password_field.Text != "Password")
            {
                password_field.UseSystemPasswordChar = true;
            }
            if (checkBoxPass.Checked == false)
            {
                password_field.UseSystemPasswordChar = false;
            }
        }
        #endregion

        private void button_Entry_Click(object sender, EventArgs e)
        {
            string loginUser = login_field.Text;
            string passUser = password_field.Text;
            Data_Base db = new Data_Base();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            try
            {
                db.openConnection();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE BINARY `login` = @uL and binary `password` = @uP", db.getConnection());
                command.Prepare();

                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
                command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                command.ExecuteNonQuery();
                db.closeConnection();

                if (table.Rows.Count == 1)
                {
                    this.Hide();
                    MainForm programForm = new MainForm();
                    programForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Enter correct login and password.");
                    return;
                }
            }
            catch (MySqlConnector.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Authorization_form_Load(object sender, EventArgs e)
        {

        }
    }
}
