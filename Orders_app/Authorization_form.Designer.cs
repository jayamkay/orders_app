
namespace Orders_app
{
    partial class Authorization_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization_form));
            this.panel_label = new System.Windows.Forms.Panel();
            this.Label_autho = new System.Windows.Forms.Label();
            this.panel_fields = new System.Windows.Forms.Panel();
            this.checkBoxPass = new System.Windows.Forms.CheckBox();
            this.password_field = new System.Windows.Forms.TextBox();
            this.login_field = new System.Windows.Forms.TextBox();
            this.picture_password = new System.Windows.Forms.PictureBox();
            this.picture_login = new System.Windows.Forms.PictureBox();
            this.panel_buttons = new System.Windows.Forms.Panel();
            this.button_Entry = new System.Windows.Forms.Button();
            this.label_toRegister = new System.Windows.Forms.Label();
            this.panel_label.SuspendLayout();
            this.panel_fields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_login)).BeginInit();
            this.panel_buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_label
            // 
            this.panel_label.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.panel_label.Controls.Add(this.Label_autho);
            this.panel_label.Location = new System.Drawing.Point(0, 0);
            this.panel_label.Name = "panel_label";
            this.panel_label.Size = new System.Drawing.Size(314, 58);
            this.panel_label.TabIndex = 1;
            // 
            // Label_autho
            // 
            this.Label_autho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_autho.Font = new System.Drawing.Font("Segoe UI Symbol", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_autho.ForeColor = System.Drawing.Color.White;
            this.Label_autho.Location = new System.Drawing.Point(0, 0);
            this.Label_autho.Name = "Label_autho";
            this.Label_autho.Size = new System.Drawing.Size(314, 58);
            this.Label_autho.TabIndex = 0;
            this.Label_autho.Text = "Please, log in";
            this.Label_autho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_autho.Click += new System.EventHandler(this.Label_autho_Click);
            this.Label_autho.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label_autho_MouseDown);
            this.Label_autho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label_autho_MouseMove);
            // 
            // panel_fields
            // 
            this.panel_fields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.panel_fields.Controls.Add(this.checkBoxPass);
            this.panel_fields.Controls.Add(this.password_field);
            this.panel_fields.Controls.Add(this.login_field);
            this.panel_fields.Controls.Add(this.picture_password);
            this.panel_fields.Controls.Add(this.picture_login);
            this.panel_fields.Location = new System.Drawing.Point(0, 57);
            this.panel_fields.Name = "panel_fields";
            this.panel_fields.Size = new System.Drawing.Size(314, 173);
            this.panel_fields.TabIndex = 2;
            this.panel_fields.Click += new System.EventHandler(this.panel_fields_Click);
            this.panel_fields.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_fields_MouseDown);
            this.panel_fields.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_fields_MouseMove);
            // 
            // checkBoxPass
            // 
            this.checkBoxPass.AutoSize = true;
            this.checkBoxPass.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxPass.Checked = true;
            this.checkBoxPass.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPass.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkBoxPass.Location = new System.Drawing.Point(203, 141);
            this.checkBoxPass.Name = "checkBoxPass";
            this.checkBoxPass.Size = new System.Drawing.Size(98, 18);
            this.checkBoxPass.TabIndex = 3;
            this.checkBoxPass.Text = "Hide password";
            this.checkBoxPass.UseCompatibleTextRendering = true;
            this.checkBoxPass.UseVisualStyleBackColor = true;
            this.checkBoxPass.CheckStateChanged += new System.EventHandler(this.checkBoxPass_CheckStateChanged);
            // 
            // password_field
            // 
            this.password_field.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_field.ForeColor = System.Drawing.Color.Silver;
            this.password_field.Location = new System.Drawing.Point(68, 103);
            this.password_field.Name = "password_field";
            this.password_field.Size = new System.Drawing.Size(233, 32);
            this.password_field.TabIndex = 2;
            this.password_field.Text = "Password";
            this.password_field.Enter += new System.EventHandler(this.password_field_Enter);
            this.password_field.Leave += new System.EventHandler(this.password_field_Leave);
            // 
            // login_field
            // 
            this.login_field.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_field.ForeColor = System.Drawing.Color.Silver;
            this.login_field.Location = new System.Drawing.Point(68, 35);
            this.login_field.Name = "login_field";
            this.login_field.Size = new System.Drawing.Size(233, 32);
            this.login_field.TabIndex = 1;
            this.login_field.Text = "Login";
            this.login_field.Enter += new System.EventHandler(this.login_field_Enter);
            this.login_field.Leave += new System.EventHandler(this.login_field_Leave);
            // 
            // picture_password
            // 
            this.picture_password.Image = ((System.Drawing.Image)(resources.GetObject("picture_password.Image")));
            this.picture_password.Location = new System.Drawing.Point(12, 94);
            this.picture_password.Name = "picture_password";
            this.picture_password.Size = new System.Drawing.Size(50, 50);
            this.picture_password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_password.TabIndex = 1;
            this.picture_password.TabStop = false;
            this.picture_password.Click += new System.EventHandler(this.picture_password_Click);
            this.picture_password.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picture_password_MouseDown);
            this.picture_password.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picture_password_MouseMove);
            // 
            // picture_login
            // 
            this.picture_login.Image = ((System.Drawing.Image)(resources.GetObject("picture_login.Image")));
            this.picture_login.Location = new System.Drawing.Point(12, 26);
            this.picture_login.Name = "picture_login";
            this.picture_login.Size = new System.Drawing.Size(50, 50);
            this.picture_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_login.TabIndex = 0;
            this.picture_login.TabStop = false;
            this.picture_login.Click += new System.EventHandler(this.picture_login_Click);
            this.picture_login.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picture_login_MouseDown);
            this.picture_login.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picture_login_MouseMove);
            // 
            // panel_buttons
            // 
            this.panel_buttons.BackColor = System.Drawing.Color.White;
            this.panel_buttons.Controls.Add(this.button_Entry);
            this.panel_buttons.Controls.Add(this.label_toRegister);
            this.panel_buttons.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.panel_buttons.Location = new System.Drawing.Point(0, 227);
            this.panel_buttons.Name = "panel_buttons";
            this.panel_buttons.Size = new System.Drawing.Size(314, 166);
            this.panel_buttons.TabIndex = 3;
            this.panel_buttons.Click += new System.EventHandler(this.panel_buttons_Click);
            this.panel_buttons.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_buttons_MouseDown);
            this.panel_buttons.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_buttons_MouseMove);
            // 
            // button_Entry
            // 
            this.button_Entry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Entry.BackgroundImage")));
            this.button_Entry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Entry.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Entry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_Entry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_Entry.Location = new System.Drawing.Point(120, 9);
            this.button_Entry.Name = "button_Entry";
            this.button_Entry.Size = new System.Drawing.Size(77, 97);
            this.button_Entry.TabIndex = 4;
            this.button_Entry.UseVisualStyleBackColor = true;
            this.button_Entry.Click += new System.EventHandler(this.button_Entry_Click);
            // 
            // label_toRegister
            // 
            this.label_toRegister.AutoSize = true;
            this.label_toRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_toRegister.Font = new System.Drawing.Font("Segoe UI Symbol", 10F);
            this.label_toRegister.ForeColor = System.Drawing.Color.Black;
            this.label_toRegister.Location = new System.Drawing.Point(97, 109);
            this.label_toRegister.Name = "label_toRegister";
            this.label_toRegister.Size = new System.Drawing.Size(127, 19);
            this.label_toRegister.TabIndex = 1;
            this.label_toRegister.Text = "Not a member yet?";
            this.label_toRegister.Click += new System.EventHandler(this.label_toRegister_Click);
            this.label_toRegister.MouseEnter += new System.EventHandler(this.label_toRegister_MouseEnter);
            this.label_toRegister.MouseLeave += new System.EventHandler(this.label_toRegister_MouseLeave);
            // 
            // Authorization_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 391);
            this.Controls.Add(this.panel_buttons);
            this.Controls.Add(this.panel_fields);
            this.Controls.Add(this.panel_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Authorization_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorization";
            this.Load += new System.EventHandler(this.Authorization_form_Load);
            this.panel_label.ResumeLayout(false);
            this.panel_fields.ResumeLayout(false);
            this.panel_fields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_login)).EndInit();
            this.panel_buttons.ResumeLayout(false);
            this.panel_buttons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_label;
        private System.Windows.Forms.Panel panel_fields;
        private System.Windows.Forms.Panel panel_buttons;
        private System.Windows.Forms.PictureBox picture_password;
        private System.Windows.Forms.PictureBox picture_login;
        private System.Windows.Forms.TextBox login_field;
        private System.Windows.Forms.TextBox password_field;
        private System.Windows.Forms.Label label_toRegister;
        private System.Windows.Forms.Button button_Entry;
        private System.Windows.Forms.CheckBox checkBoxPass;
        private System.Windows.Forms.Label Label_autho;
    }
}