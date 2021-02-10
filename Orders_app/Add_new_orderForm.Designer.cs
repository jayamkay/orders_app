
namespace Orders_app
{
    partial class Add_new_orderForm
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
            this.amount_field = new System.Windows.Forms.TextBox();
            this.cost_field = new System.Windows.Forms.TextBox();
            this.good_name_field = new System.Windows.Forms.TextBox();
            this.customer_name_field = new System.Windows.Forms.TextBox();
            this.label_newPosition = new System.Windows.Forms.Label();
            this.button_AddPosition = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // amount_field
            // 
            this.amount_field.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amount_field.ForeColor = System.Drawing.Color.Silver;
            this.amount_field.Location = new System.Drawing.Point(33, 119);
            this.amount_field.Name = "amount_field";
            this.amount_field.Size = new System.Drawing.Size(259, 32);
            this.amount_field.TabIndex = 4;
            this.amount_field.Text = "Enter quantity";
            this.amount_field.Enter += new System.EventHandler(this.amount_field_Enter);
            this.amount_field.Leave += new System.EventHandler(this.amount_field_Leave);
            // 
            // cost_field
            // 
            this.cost_field.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cost_field.ForeColor = System.Drawing.Color.Silver;
            this.cost_field.Location = new System.Drawing.Point(33, 69);
            this.cost_field.Name = "cost_field";
            this.cost_field.Size = new System.Drawing.Size(259, 32);
            this.cost_field.TabIndex = 3;
            this.cost_field.Text = "Enter the price per item";
            this.cost_field.Enter += new System.EventHandler(this.cost_field_Enter);
            this.cost_field.Leave += new System.EventHandler(this.cost_field_Leave);
            // 
            // good_name_field
            // 
            this.good_name_field.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.good_name_field.ForeColor = System.Drawing.Color.Silver;
            this.good_name_field.Location = new System.Drawing.Point(33, 19);
            this.good_name_field.Name = "good_name_field";
            this.good_name_field.Size = new System.Drawing.Size(259, 32);
            this.good_name_field.TabIndex = 2;
            this.good_name_field.Text = "Enter product name";
            this.good_name_field.Enter += new System.EventHandler(this.good_name_field_Enter);
            this.good_name_field.Leave += new System.EventHandler(this.good_name_field_Leave);
            // 
            // customer_name_field
            // 
            this.customer_name_field.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customer_name_field.ForeColor = System.Drawing.Color.Silver;
            this.customer_name_field.Location = new System.Drawing.Point(33, 12);
            this.customer_name_field.Name = "customer_name_field";
            this.customer_name_field.Size = new System.Drawing.Size(259, 32);
            this.customer_name_field.TabIndex = 1;
            this.customer_name_field.Text = "Enter the client\'s full name";
            this.customer_name_field.Enter += new System.EventHandler(this.customer_name_field_Enter);
            this.customer_name_field.Leave += new System.EventHandler(this.customer_name_field_Leave);
            // 
            // label_newPosition
            // 
            this.label_newPosition.AutoSize = true;
            this.label_newPosition.Font = new System.Drawing.Font("Segoe UI Symbol", 16F);
            this.label_newPosition.ForeColor = System.Drawing.Color.White;
            this.label_newPosition.Location = new System.Drawing.Point(22, 60);
            this.label_newPosition.Name = "label_newPosition";
            this.label_newPosition.Size = new System.Drawing.Size(291, 30);
            this.label_newPosition.TabIndex = 36;
            this.label_newPosition.Text = "Add a position for this order:";
            // 
            // button_AddPosition
            // 
            this.button_AddPosition.Font = new System.Drawing.Font("Segoe UI Symbol", 16F);
            this.button_AddPosition.Location = new System.Drawing.Point(94, 303);
            this.button_AddPosition.Name = "button_AddPosition";
            this.button_AddPosition.Size = new System.Drawing.Size(127, 56);
            this.button_AddPosition.TabIndex = 5;
            this.button_AddPosition.Text = "Confirm";
            this.button_AddPosition.UseVisualStyleBackColor = true;
            this.button_AddPosition.Click += new System.EventHandler(this.button_AddPosition_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.customer_name_field);
            this.panel1.Controls.Add(this.label_newPosition);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 110);
            this.panel1.TabIndex = 37;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.cost_field);
            this.panel2.Controls.Add(this.good_name_field);
            this.panel2.Controls.Add(this.amount_field);
            this.panel2.Location = new System.Drawing.Point(0, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 170);
            this.panel2.TabIndex = 38;
            // 
            // Add_new_orderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 392);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_AddPosition);
            this.MinimizeBox = false;
            this.Name = "Add_new_orderForm";
            this.Text = "Add new order";
            this.Load += new System.EventHandler(this.Add_new_orderForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox amount_field;
        private System.Windows.Forms.TextBox cost_field;
        private System.Windows.Forms.TextBox good_name_field;
        private System.Windows.Forms.TextBox customer_name_field;
        private System.Windows.Forms.Label label_newPosition;
        private System.Windows.Forms.Button button_AddPosition;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}