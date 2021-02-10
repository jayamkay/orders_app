
using static System.Net.Mime.MediaTypeNames;

namespace Orders_app
{
    partial class MainForm
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
            this.Order_List = new System.Windows.Forms.DataGridView();
            this.label_showPositions = new System.Windows.Forms.Label();
            this.textBox_showPositions = new System.Windows.Forms.TextBox();
            this.button_showPositions = new System.Windows.Forms.Button();
            this.Position_List = new System.Windows.Forms.DataGridView();
            this.dateTimePicker_From = new System.Windows.Forms.DateTimePicker();
            this.label_From = new System.Windows.Forms.Label();
            this.label_To = new System.Windows.Forms.Label();
            this.dateTimePicker_To = new System.Windows.Forms.DateTimePicker();
            this.button_Period = new System.Windows.Forms.Button();
            this.button_addNewOrder = new System.Windows.Forms.Button();
            this.button_eraseOrder = new System.Windows.Forms.Button();
            this.textBox_eraseOrder = new System.Windows.Forms.TextBox();
            this.label_eraseOrder = new System.Windows.Forms.Label();
            this.label_changeOrderName = new System.Windows.Forms.Label();
            this.textBox_changeOrderName = new System.Windows.Forms.TextBox();
            this.button_chandeOrderName = new System.Windows.Forms.Button();
            this.customer_name_field = new System.Windows.Forms.TextBox();
            this.button_confirmChange = new System.Windows.Forms.Button();
            this.button__addPosition = new System.Windows.Forms.Button();
            this.textBox_addPosition = new System.Windows.Forms.TextBox();
            this.label_addPosition = new System.Windows.Forms.Label();
            this.label_erasePosition = new System.Windows.Forms.Label();
            this.button_erasePosition = new System.Windows.Forms.Button();
            this.textBox_erasePosition = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Order_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Position_List)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Order_List
            // 
            this.Order_List.AllowUserToAddRows = false;
            this.Order_List.AllowUserToDeleteRows = false;
            this.Order_List.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Order_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Order_List.Location = new System.Drawing.Point(18, 51);
            this.Order_List.Name = "Order_List";
            this.Order_List.ReadOnly = true;
            this.Order_List.Size = new System.Drawing.Size(644, 268);
            this.Order_List.TabIndex = 0;
            // 
            // label_showPositions
            // 
            this.label_showPositions.AutoSize = true;
            this.label_showPositions.Font = new System.Drawing.Font("Segoe UI Symbol", 12.5F);
            this.label_showPositions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_showPositions.Location = new System.Drawing.Point(29, 350);
            this.label_showPositions.Name = "label_showPositions";
            this.label_showPositions.Size = new System.Drawing.Size(360, 23);
            this.label_showPositions.TabIndex = 1;
            this.label_showPositions.Text = "Enter the order number to open its positions: ";
            // 
            // textBox_showPositions
            // 
            this.textBox_showPositions.Location = new System.Drawing.Point(451, 353);
            this.textBox_showPositions.Name = "textBox_showPositions";
            this.textBox_showPositions.Size = new System.Drawing.Size(55, 20);
            this.textBox_showPositions.TabIndex = 2;
            // 
            // button_showPositions
            // 
            this.button_showPositions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_showPositions.Location = new System.Drawing.Point(530, 345);
            this.button_showPositions.Name = "button_showPositions";
            this.button_showPositions.Size = new System.Drawing.Size(91, 31);
            this.button_showPositions.TabIndex = 3;
            this.button_showPositions.Text = "OK";
            this.button_showPositions.UseVisualStyleBackColor = true;
            this.button_showPositions.Click += new System.EventHandler(this.button_showPositions_Click);
            // 
            // Position_List
            // 
            this.Position_List.AllowUserToAddRows = false;
            this.Position_List.AllowUserToDeleteRows = false;
            this.Position_List.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Position_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Position_List.Location = new System.Drawing.Point(18, 392);
            this.Position_List.Name = "Position_List";
            this.Position_List.ReadOnly = true;
            this.Position_List.Size = new System.Drawing.Size(644, 159);
            this.Position_List.TabIndex = 4;
            // 
            // dateTimePicker_From
            // 
            this.dateTimePicker_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_From.Location = new System.Drawing.Point(71, 11);
            this.dateTimePicker_From.Name = "dateTimePicker_From";
            this.dateTimePicker_From.Size = new System.Drawing.Size(188, 20);
            this.dateTimePicker_From.TabIndex = 6;
            // 
            // label_From
            // 
            this.label_From.AutoSize = true;
            this.label_From.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.label_From.ForeColor = System.Drawing.Color.White;
            this.label_From.Location = new System.Drawing.Point(16, 10);
            this.label_From.Name = "label_From";
            this.label_From.Size = new System.Drawing.Size(47, 21);
            this.label_From.TabIndex = 7;
            this.label_From.Text = "From";
            // 
            // label_To
            // 
            this.label_To.AutoSize = true;
            this.label_To.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.label_To.ForeColor = System.Drawing.Color.White;
            this.label_To.Location = new System.Drawing.Point(291, 8);
            this.label_To.Name = "label_To";
            this.label_To.Size = new System.Drawing.Size(27, 21);
            this.label_To.TabIndex = 8;
            this.label_To.Text = "To";
            // 
            // dateTimePicker_To
            // 
            this.dateTimePicker_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_To.Location = new System.Drawing.Point(346, 11);
            this.dateTimePicker_To.Name = "dateTimePicker_To";
            this.dateTimePicker_To.Size = new System.Drawing.Size(188, 20);
            this.dateTimePicker_To.TabIndex = 9;
            // 
            // button_Period
            // 
            this.button_Period.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_Period.Location = new System.Drawing.Point(560, 7);
            this.button_Period.Name = "button_Period";
            this.button_Period.Size = new System.Drawing.Size(102, 28);
            this.button_Period.TabIndex = 10;
            this.button_Period.Text = "OK";
            this.button_Period.UseVisualStyleBackColor = true;
            this.button_Period.Click += new System.EventHandler(this.button_Period_Click);
            // 
            // button_addNewOrder
            // 
            this.button_addNewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_addNewOrder.Location = new System.Drawing.Point(28, 12);
            this.button_addNewOrder.Name = "button_addNewOrder";
            this.button_addNewOrder.Size = new System.Drawing.Size(204, 52);
            this.button_addNewOrder.TabIndex = 11;
            this.button_addNewOrder.Text = "Add order";
            this.button_addNewOrder.UseVisualStyleBackColor = true;
            this.button_addNewOrder.Click += new System.EventHandler(this.button_addNewOrder_Click);
            // 
            // button_eraseOrder
            // 
            this.button_eraseOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_eraseOrder.Location = new System.Drawing.Point(156, 107);
            this.button_eraseOrder.Name = "button_eraseOrder";
            this.button_eraseOrder.Size = new System.Drawing.Size(76, 31);
            this.button_eraseOrder.TabIndex = 14;
            this.button_eraseOrder.Text = "Delete";
            this.button_eraseOrder.UseVisualStyleBackColor = true;
            this.button_eraseOrder.Click += new System.EventHandler(this.button_eraseOrder_Click);
            // 
            // textBox_eraseOrder
            // 
            this.textBox_eraseOrder.Location = new System.Drawing.Point(192, 81);
            this.textBox_eraseOrder.Name = "textBox_eraseOrder";
            this.textBox_eraseOrder.Size = new System.Drawing.Size(40, 20);
            this.textBox_eraseOrder.TabIndex = 13;
            // 
            // label_eraseOrder
            // 
            this.label_eraseOrder.AutoSize = true;
            this.label_eraseOrder.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.label_eraseOrder.Location = new System.Drawing.Point(8, 83);
            this.label_eraseOrder.Name = "label_eraseOrder";
            this.label_eraseOrder.Size = new System.Drawing.Size(162, 21);
            this.label_eraseOrder.TabIndex = 12;
            this.label_eraseOrder.Text = "Delete order number: ";
            // 
            // label_changeOrderName
            // 
            this.label_changeOrderName.AutoSize = true;
            this.label_changeOrderName.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.label_changeOrderName.Location = new System.Drawing.Point(8, 163);
            this.label_changeOrderName.Name = "label_changeOrderName";
            this.label_changeOrderName.Size = new System.Drawing.Size(179, 21);
            this.label_changeOrderName.TabIndex = 15;
            this.label_changeOrderName.Text = "Change name for order: ";
            // 
            // textBox_changeOrderName
            // 
            this.textBox_changeOrderName.Location = new System.Drawing.Point(192, 166);
            this.textBox_changeOrderName.Name = "textBox_changeOrderName";
            this.textBox_changeOrderName.Size = new System.Drawing.Size(41, 20);
            this.textBox_changeOrderName.TabIndex = 16;
            // 
            // button_chandeOrderName
            // 
            this.button_chandeOrderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_chandeOrderName.Location = new System.Drawing.Point(156, 192);
            this.button_chandeOrderName.Name = "button_chandeOrderName";
            this.button_chandeOrderName.Size = new System.Drawing.Size(77, 31);
            this.button_chandeOrderName.TabIndex = 17;
            this.button_chandeOrderName.Text = "ОК";
            this.button_chandeOrderName.UseVisualStyleBackColor = true;
            this.button_chandeOrderName.Click += new System.EventHandler(this.button1_Click);
            // 
            // customer_name_field
            // 
            this.customer_name_field.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customer_name_field.ForeColor = System.Drawing.Color.Black;
            this.customer_name_field.Location = new System.Drawing.Point(12, 239);
            this.customer_name_field.Name = "customer_name_field";
            this.customer_name_field.Size = new System.Drawing.Size(224, 32);
            this.customer_name_field.TabIndex = 18;
            // 
            // button_confirmChange
            // 
            this.button_confirmChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_confirmChange.Location = new System.Drawing.Point(12, 288);
            this.button_confirmChange.Name = "button_confirmChange";
            this.button_confirmChange.Size = new System.Drawing.Size(224, 31);
            this.button_confirmChange.TabIndex = 19;
            this.button_confirmChange.Text = "Change the client\'s name";
            this.button_confirmChange.UseVisualStyleBackColor = true;
            this.button_confirmChange.Click += new System.EventHandler(this.button_confirmChange_Click);
            // 
            // button__addPosition
            // 
            this.button__addPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button__addPosition.Location = new System.Drawing.Point(543, 577);
            this.button__addPosition.Name = "button__addPosition";
            this.button__addPosition.Size = new System.Drawing.Size(91, 31);
            this.button__addPosition.TabIndex = 22;
            this.button__addPosition.Text = "OK";
            this.button__addPosition.UseVisualStyleBackColor = true;
            this.button__addPosition.Click += new System.EventHandler(this.button__addPosition_Click);
            // 
            // textBox_addPosition
            // 
            this.textBox_addPosition.Location = new System.Drawing.Point(469, 584);
            this.textBox_addPosition.Name = "textBox_addPosition";
            this.textBox_addPosition.Size = new System.Drawing.Size(55, 20);
            this.textBox_addPosition.TabIndex = 21;
            // 
            // label_addPosition
            // 
            this.label_addPosition.AutoSize = true;
            this.label_addPosition.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.label_addPosition.Location = new System.Drawing.Point(29, 582);
            this.label_addPosition.Name = "label_addPosition";
            this.label_addPosition.Size = new System.Drawing.Size(319, 21);
            this.label_addPosition.TabIndex = 20;
            this.label_addPosition.Text = "Enter the order number to add position to it: ";
            // 
            // label_erasePosition
            // 
            this.label_erasePosition.AutoSize = true;
            this.label_erasePosition.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.label_erasePosition.Location = new System.Drawing.Point(29, 624);
            this.label_erasePosition.Name = "label_erasePosition";
            this.label_erasePosition.Size = new System.Drawing.Size(434, 21);
            this.label_erasePosition.TabIndex = 23;
            this.label_erasePosition.Text = "Enter the position number to delete it from the chosen order: ";
            // 
            // button_erasePosition
            // 
            this.button_erasePosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_erasePosition.Location = new System.Drawing.Point(543, 620);
            this.button_erasePosition.Name = "button_erasePosition";
            this.button_erasePosition.Size = new System.Drawing.Size(91, 31);
            this.button_erasePosition.TabIndex = 25;
            this.button_erasePosition.Text = "OK";
            this.button_erasePosition.UseVisualStyleBackColor = true;
            this.button_erasePosition.Click += new System.EventHandler(this.button_erasePosition_Click);
            // 
            // textBox_erasePosition
            // 
            this.textBox_erasePosition.Location = new System.Drawing.Point(469, 625);
            this.textBox_erasePosition.Name = "textBox_erasePosition";
            this.textBox_erasePosition.Size = new System.Drawing.Size(55, 20);
            this.textBox_erasePosition.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.Order_List);
            this.panel1.Controls.Add(this.dateTimePicker_From);
            this.panel1.Controls.Add(this.button_Period);
            this.panel1.Controls.Add(this.label_From);
            this.panel1.Controls.Add(this.dateTimePicker_To);
            this.panel1.Controls.Add(this.label_To);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 332);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.button_addNewOrder);
            this.panel2.Controls.Add(this.label_eraseOrder);
            this.panel2.Controls.Add(this.button_eraseOrder);
            this.panel2.Controls.Add(this.textBox_eraseOrder);
            this.panel2.Controls.Add(this.label_changeOrderName);
            this.panel2.Controls.Add(this.textBox_changeOrderName);
            this.panel2.Controls.Add(this.button_chandeOrderName);
            this.panel2.Controls.Add(this.customer_name_field);
            this.panel2.Controls.Add(this.button_confirmChange);
            this.panel2.Location = new System.Drawing.Point(684, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 332);
            this.panel2.TabIndex = 27;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 665);
            this.Controls.Add(this.label_showPositions);
            this.Controls.Add(this.textBox_showPositions);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button_showPositions);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_erasePosition);
            this.Controls.Add(this.textBox_erasePosition);
            this.Controls.Add(this.label_erasePosition);
            this.Controls.Add(this.button__addPosition);
            this.Controls.Add(this.textBox_addPosition);
            this.Controls.Add(this.label_addPosition);
            this.Controls.Add(this.Position_List);
            this.Name = "MainForm";
            this.Text = "Orders table";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Order_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Position_List)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Order_List;
        private System.Windows.Forms.Label label_showPositions;
        private System.Windows.Forms.TextBox textBox_showPositions;
        private System.Windows.Forms.Button button_showPositions;
        private System.Windows.Forms.DataGridView Position_List;
        private System.Windows.Forms.DateTimePicker dateTimePicker_From;
        private System.Windows.Forms.Label label_From;
        private System.Windows.Forms.Label label_To;
        private System.Windows.Forms.DateTimePicker dateTimePicker_To;
        private System.Windows.Forms.Button button_Period;
        private System.Windows.Forms.Button button_addNewOrder;
        private System.Windows.Forms.Button button_eraseOrder;
        private System.Windows.Forms.TextBox textBox_eraseOrder;
        private System.Windows.Forms.Label label_eraseOrder;
        private System.Windows.Forms.Label label_changeOrderName;
        private System.Windows.Forms.TextBox textBox_changeOrderName;
        private System.Windows.Forms.Button button_chandeOrderName;
        private System.Windows.Forms.TextBox customer_name_field;
        private System.Windows.Forms.Button button_confirmChange;
        private System.Windows.Forms.Button button__addPosition;
        private System.Windows.Forms.TextBox textBox_addPosition;
        private System.Windows.Forms.Label label_addPosition;
        private System.Windows.Forms.Label label_erasePosition;
        private System.Windows.Forms.Button button_erasePosition;
        private System.Windows.Forms.TextBox textBox_erasePosition;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

