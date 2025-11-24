namespace PresentationLayer.UsersControls
{
    partial class Suppliers
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            AddSupplierButton = new Button();
            AddressTextBox = new TextBox();
            MailTextBox = new TextBox();
            PhoneTextBox = new TextBox();
            NRCTextBox = new TextBox();
            NITTextBox = new TextBox();
            ContacTextBox = new TextBox();
            NameTextBox = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuppliersDgv = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SuppliersDgv).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(AddressTextBox);
            groupBox1.Controls.Add(MailTextBox);
            groupBox1.Controls.Add(PhoneTextBox);
            groupBox1.Controls.Add(NRCTextBox);
            groupBox1.Controls.Add(NITTextBox);
            groupBox1.Controls.Add(ContacTextBox);
            groupBox1.Controls.Add(NameTextBox);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(6, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1262, 392);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(AddSupplierButton);
            groupBox2.Location = new Point(1032, 39);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(210, 317);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "acciones";
            // 
            // button3
            // 
            button3.Location = new Point(63, 226);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "eliminar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(63, 144);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "editar";
            button2.UseVisualStyleBackColor = true;
            // 
            // AddSupplierButton
            // 
            AddSupplierButton.Location = new Point(63, 72);
            AddSupplierButton.Name = "AddSupplierButton";
            AddSupplierButton.Size = new Size(94, 29);
            AddSupplierButton.TabIndex = 0;
            AddSupplierButton.Text = "7";
            AddSupplierButton.UseVisualStyleBackColor = true;
            AddSupplierButton.Click += AddSupplierButton_Click;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(647, 215);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(349, 27);
            AddressTextBox.TabIndex = 14;
            // 
            // MailTextBox
            // 
            MailTextBox.Location = new Point(647, 161);
            MailTextBox.Name = "MailTextBox";
            MailTextBox.Size = new Size(349, 27);
            MailTextBox.TabIndex = 13;
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(647, 108);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(349, 27);
            PhoneTextBox.TabIndex = 12;
            // 
            // NRCTextBox
            // 
            NRCTextBox.Location = new Point(189, 265);
            NRCTextBox.Name = "NRCTextBox";
            NRCTextBox.Size = new Size(279, 27);
            NRCTextBox.TabIndex = 11;
            // 
            // NITTextBox
            // 
            NITTextBox.Location = new Point(189, 215);
            NITTextBox.Name = "NITTextBox";
            NITTextBox.Size = new Size(279, 27);
            NITTextBox.TabIndex = 10;
            // 
            // ContacTextBox
            // 
            ContacTextBox.Location = new Point(189, 161);
            ContacTextBox.Name = "ContacTextBox";
            ContacTextBox.Size = new Size(279, 27);
            ContacTextBox.TabIndex = 9;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(189, 108);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(279, 27);
            NameTextBox.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(578, 111);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 7;
            label8.Text = "telefono";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(578, 164);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 6;
            label7.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(571, 218);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 5;
            label6.Text = "direccion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(128, 268);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 4;
            label5.Text = "NRC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(134, 215);
            label4.Name = "label4";
            label4.Size = new Size(32, 20);
            label4.TabIndex = 3;
            label4.Text = "NIT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 164);
            label3.Name = "label3";
            label3.Size = new Size(144, 20);
            label3.TabIndex = 2;
            label3.Text = "nombre de contacto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 108);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 1;
            label2.Text = "nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(547, 39);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 0;
            label1.Text = "agregar proveedor";
            // 
            // SuppliersDgv
            // 
            SuppliersDgv.AllowUserToAddRows = false;
            SuppliersDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SuppliersDgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            SuppliersDgv.BorderStyle = BorderStyle.Fixed3D;
            SuppliersDgv.ColumnHeadersHeight = 29;
            SuppliersDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            SuppliersDgv.Location = new Point(6, 451);
            SuppliersDgv.Name = "SuppliersDgv";
            SuppliersDgv.RowHeadersWidth = 51;
            SuppliersDgv.Size = new Size(1262, 588);
            SuppliersDgv.TabIndex = 1;
            // 
            // Suppliers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SuppliersDgv);
            Controls.Add(groupBox1);
            Name = "Suppliers";
            Size = new Size(1281, 1074);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SuppliersDgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox ContacTextBox;
        private TextBox NameTextBox;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button button3;
        private Button button2;
        private Button AddSupplierButton;
        private TextBox AddressTextBox;
        private TextBox MailTextBox;
        private TextBox PhoneTextBox;
        private TextBox NRCTextBox;
        private TextBox NITTextBox;
        private DataGridView SuppliersDgv;
    }
}
