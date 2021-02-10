using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orders_app
{
    public partial class Registration_form : Form
    {
        //Initialization
        public static Point lastPoint;
        public Registration_form()
        {
            InitializeComponent();
            ActiveControl = panel_Label;
        }
        //Initialization

        #region Change_Form_Location
        public static Point getPoint()
        {
            return lastPoint;
        }

        private void label_Register_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void label_Register_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel_Fields_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void panel_Fields_MouseDown(object sender, MouseEventArgs e)
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

        #region Disable_ActiveControl_For_TextBoxes
        private void label_Register_Click(object sender, EventArgs e)
        {
            ActiveControl = panel_Label;
        }

        private void panel_Fields_Click(object sender, EventArgs e)
        {
            ActiveControl = panel_Label;
        }

        private void panel_buttons_Click(object sender, EventArgs e)
        {
            ActiveControl = panel_Label;
        }
        #endregion

        #region Fill_TextBoxes
        private void name_field_Enter(object sender, EventArgs e)
        {
            if (name_field.Text == "Enter first name")
            {
                name_field.Text = "";
                name_field.ForeColor = Color.Black;
            }
        }

        private void name_field_Leave(object sender, EventArgs e)
        {
            if (name_field.Text == "Enter first name" || name_field.Text == "")
            {
                name_field.Text = "Enter first name";
                name_field.ForeColor = Color.Silver;
            }
        }

        private void surname_field_Enter(object sender, EventArgs e)
        {
            if (surname_field.Text == "Enter last name")
            {
                surname_field.Text = "";
                surname_field.ForeColor = Color.Black;
            }
        }

        private void surname_field_Leave(object sender, EventArgs e)
        {
            if (surname_field.Text == "Enter last name" || surname_field.Text == "")
            {
                surname_field.Text = "Enter last name";
                surname_field.ForeColor = Color.Silver;
            }
        }

        private void login_field_Enter(object sender, EventArgs e)
        {
            if (login_field.Text == "Enter preferable login")
            {
                login_field.Text = "";
                login_field.ForeColor = Color.Black;
            }
        }

        private void login_field_Leave(object sender, EventArgs e)
        {
            if (login_field.Text == "Enter preferable login" || login_field.Text == "")
            {
                login_field.Text = "Enter preferable login";
                login_field.ForeColor = Color.Silver;
            }
        }

        private void password_field_Enter(object sender, EventArgs e)
        {
            if (password_field.Text == "Enter password")
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
                password_field.Text = "Enter password";
                password_field.ForeColor = Color.Silver;
                password_field.UseSystemPasswordChar = false;
                ActiveControl = panel_Fields;
                ActiveControl = confirm_field;
            }
        }

        private void confirm_field_Enter(object sender, EventArgs e)
        {
            if (confirm_field.Text == "Confirm password")
            {
                if (checkBoxPass.Checked == true)
                {
                    confirm_field.UseSystemPasswordChar = true;
                }
                confirm_field.Text = "";
                confirm_field.ForeColor = Color.Black;
            }
        }

        private void confirm_field_Leave(object sender, EventArgs e)
        {
            if (confirm_field.Text == "")
            {
                confirm_field.Text = "Confirm password";
                confirm_field.ForeColor = Color.Silver;
                confirm_field.UseSystemPasswordChar = false;
                ActiveControl = panel_Fields;
                ActiveControl = checkBoxPass;
            }
        }

        private void checkBoxPass_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxPass.Checked == true && password_field.Text != "Enter password")
            {
                password_field.UseSystemPasswordChar = true;
            }
            if (checkBoxPass.Checked == false)
            {
                password_field.UseSystemPasswordChar = false;
            }

            if (checkBoxPass.Checked == true && confirm_field.Text != "Confirm password")
            {
                confirm_field.UseSystemPasswordChar = true;
            }
            if (checkBoxPass.Checked == false)
            {
                confirm_field.UseSystemPasswordChar = false;
            }
        }



        #endregion

        #region ToolTip
        private void picture_q_1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("   Use either Latin(A-Z, a-z) or Cyrillic(А-Я, а-я) characters", picture_q_1);
        }

        private void picture_q_2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("   Use either Latin(A-Z, a-z) or Cyrillic(А-Я, а-я) characters,\n   the same as for your name", picture_q_2);
        }

        private void picture_q_3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("   Login may include Latin(A-Z, a-z) characters, and digits(0-9)", picture_q_3);
        }

        private void picture_q_4_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("   The password has to consist Latin(A-Z, a-z) characters, digits(0-9),\n   and at least one special character, such as (! ? _ % & * etc.)", picture_q_4);
        }

        private void picture_q_5_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("   Confirm the password", picture_q_5);
        }
        #endregion

        bool checkFields()
        {
            if (name_field.Text == "Enter first name" || surname_field.Text == "Enter last name" ||
                login_field.Text == "Enter preferable login" || password_field.Text == "Enter password" || confirm_field.Text == "Confirm password")
            {
                MessageBox.Show("Please, fill in all the fields.");
                return false;
            }

            if (name_field.Text.Length > 20 || surname_field.Text.Length > 20 ||
                login_field.Text.Length > 20 || password_field.Text.Length > 20 || confirm_field.Text.Length > 20)
            {
                MessageBox.Show("Each field shouldn't consist more than 20 characters.");
                return false;
            }

            foreach (var item in name_field.Text)
            {
                if (!Char.IsLetter(item))
                {
                    name_field.ForeColor = Color.Red;
                    MessageBox.Show("Use either Latin(A-Z, a-z) or Cyrillic(А-Я, а-я) characters");
                    name_field.ForeColor = Color.Black;
                    ActiveControl = name_field;
                    return false;
                }
            }

            foreach (var item in surname_field.Text)
            {
                if (!Char.IsLetter(item))
                {
                    surname_field.ForeColor = Color.Red;
                    MessageBox.Show("Use either Latin(A-Z, a-z) or Cyrillic(А-Я, а-я) characters");
                    surname_field.ForeColor = Color.Black;
                    ActiveControl = surname_field;
                    return false;
                }
            }

            foreach (var item in login_field.Text)
            {
                if (!Char.IsLetterOrDigit(item))
                {
                    login_field.ForeColor = Color.Red;
                    MessageBox.Show("Login may include Latin(A-Z, a-z) or digits(0-9)");
                    login_field.ForeColor = Color.Black;
                    ActiveControl = login_field;
                    return false;
                }
            }

            string pattern = @"\p{IsCyrillic}";
            if (Regex.Matches(login_field.Text, pattern).Count > 0)
            {
                login_field.ForeColor = Color.Red;
                MessageBox.Show("Login may include Latin(A-Z, a-z) characters, and digits(0-9)");
                login_field.ForeColor = Color.Black;
                ActiveControl = login_field;
                return false;
            }

            int counter = 0;
            foreach (var item in password_field.Text)
            {
                if (!Char.IsLetterOrDigit(item)) { counter++; }
            }
            if (counter == 0)
            {
                password_field.ForeColor = Color.Red;
                MessageBox.Show("The password has to consist Latin(A-Z, a-z) characters, digits(0-9),\nand at least one special character, such as (! ? _ % & * etc.)");
                password_field.ForeColor = Color.Black;
                ActiveControl = password_field;
                return false;
            }

            if (Regex.Matches(password_field.Text, pattern).Count > 0)
            {
                password_field.ForeColor = Color.Red;
                MessageBox.Show("The password has to consist Latin(A-Z, a-z) characters, digits(0-9),\nand at least one special character, such as (! ? _ % & * etc.)");
                password_field.ForeColor = Color.Black;
                ActiveControl = password_field;
                return false;
            }

            if (!password_field.Text.Equals(confirm_field.Text))
            {
                confirm_field.ForeColor = Color.Red;
                MessageBox.Show("Please, confirm the password");
                confirm_field.ForeColor = Color.Black;
                ActiveControl = confirm_field;
                return false;
            }
            return true;
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            if (checkFields() == true)
            {
                Data_Base db = new Data_Base();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                try
                {
                    db.openConnection();
                    MySqlCommand check = new MySqlCommand("SELECT * FROM `users` WHERE BINARY `login` = @uL", db.getConnection());
                    check.Prepare();

                    check.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login_field.Text;
                    adapter.SelectCommand = check;
                    adapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        MessageBox.Show("This login already exists. Choose another.");
                        db.closeConnection();
                        return;
                    }
                    check.ExecuteNonQuery();

                    char[] tempName = name_field.Text.ToCharArray();
                    tempName[0] = Char.ToUpper(tempName[0]);
                    for (int i = 1; i < tempName.Length; i++)
                    {
                        tempName[i] = Char.ToLower(tempName[i]);
                    }
                    string name = new string(tempName);
                    char[] tempSurname = surname_field.Text.ToCharArray();
                    tempSurname[0] = Char.ToUpper(tempSurname[0]);
                    for (int i = 1; i < tempSurname.Length; i++)
                    {
                        tempSurname[i] = Char.ToLower(tempSurname[i]);
                    }
                    string surname = new string(tempSurname);

                    MySqlCommand insert = new MySqlCommand("INSERT INTO `users` (`first_name`, `last_name`, `login`, `password`) VALUES (@uN, @uS, @uL, @uP)", db.getConnection());
                    insert.Prepare();
                    insert.Parameters.Add("@uN", MySqlDbType.VarChar).Value = name;
                    insert.Parameters.Add("@uS", MySqlDbType.VarChar).Value = surname;
                    insert.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login_field.Text;
                    insert.Parameters.Add("@uP", MySqlDbType.VarChar).Value = confirm_field.Text;

                    if (insert.ExecuteNonQuery() == 1)
                    {
                        db.closeConnection();
                        MessageBox.Show("The account has been created.");
                        name_field.Text = "Enter first name";
                        name_field.ForeColor = Color.Silver;
                        surname_field.Text = "Enter last name";
                        surname_field.ForeColor = Color.Silver;
                        login_field.Text = "Enter preferable login";
                        login_field.ForeColor = Color.Silver;
                        password_field.Text = "Enter password";
                        password_field.ForeColor = Color.Silver;
                        password_field.UseSystemPasswordChar = false;
                        confirm_field.Text = "Confirm password";
                        confirm_field.ForeColor = Color.Silver;
                        confirm_field.UseSystemPasswordChar = false;
                        ActiveControl = panel_Fields;
                        this.Close();
                    }
                    db.closeConnection();
                }
                catch (MySqlConnector.MySqlException ex)
                {
                    MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Registration_form_Load(object sender, EventArgs e)
        {

        }
    }
}



