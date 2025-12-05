namespace PresentationLayer.UsersControls
{
    partial class AddSales
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
            label6 = new Label();
            pictureBox5 = new PictureBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            CustomerLabel = new Label();
            label3 = new Label();
            label4 = new Label();
            SelectCustomerButton = new Button();
            button1 = new Button();
            PaymentTypeComboBox = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            SalesDataGridView = new DataGridView();
            groupBox2 = new GroupBox();
            button3 = new Button();
            AddPurchaseButton = new Button();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SalesDataGridView).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(pictureBox5);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(CustomerLabel);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(SelectCustomerButton);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(PaymentTypeComboBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Location = new Point(3, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1488, 291);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ImageAlign = ContentAlignment.MiddleRight;
            label6.Location = new Point(1067, 16);
            label6.Name = "label6";
            label6.Size = new Size(218, 120);
            label6.TabIndex = 35;
            label6.Text = "Nombre:\r\nTECNOREPUESTOS\r\nNCR: 366392-3\r\nNIT: 06678693-1\r\nActividad economica:\r\nVenta de repuestos automotriz";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Logotencorepuestos;
            pictureBox5.Location = new Point(1286, 13);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(196, 167);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 34;
            pictureBox5.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Fluent Icons", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 180);
            label5.Name = "label5";
            label5.Size = new Size(215, 23);
            label5.TabIndex = 31;
            label5.Text = "Selección de producto: ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Blue_and_White_Illustrative_Education_Badge_Logo__1_;
            pictureBox1.Location = new Point(132, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // CustomerLabel
            // 
            CustomerLabel.AutoSize = true;
            CustomerLabel.BackColor = Color.White;
            CustomerLabel.Font = new Font("Segoe Fluent Icons", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CustomerLabel.Location = new Point(29, 117);
            CustomerLabel.Name = "CustomerLabel";
            CustomerLabel.Size = new Size(100, 23);
            CustomerLabel.TabIndex = 28;
            CustomerLabel.Text = "clienteLabel";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe Fluent Icons", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(671, 173);
            label3.Name = "label3";
            label3.Size = new Size(153, 30);
            label3.TabIndex = 22;
            label3.Text = "Metodo de pago:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Fluent Icons", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 88);
            label4.Name = "label4";
            label4.Size = new Size(83, 23);
            label4.TabIndex = 27;
            label4.Text = "Cliente: ";
            // 
            // SelectCustomerButton
            // 
            SelectCustomerButton.Location = new Point(671, 111);
            SelectCustomerButton.Name = "SelectCustomerButton";
            SelectCustomerButton.Size = new Size(203, 29);
            SelectCustomerButton.TabIndex = 4;
            SelectCustomerButton.Text = "seleccionar un cliente";
            SelectCustomerButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(29, 206);
            button1.Name = "button1";
            button1.Size = new Size(572, 29);
            button1.TabIndex = 24;
            button1.Text = "seleccionar un producto existente";
            button1.UseVisualStyleBackColor = false;
            // 
            // PaymentTypeComboBox
            // 
            PaymentTypeComboBox.FlatStyle = FlatStyle.Flat;
            PaymentTypeComboBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PaymentTypeComboBox.FormattingEnabled = true;
            PaymentTypeComboBox.Location = new Point(671, 208);
            PaymentTypeComboBox.Name = "PaymentTypeComboBox";
            PaymentTypeComboBox.Size = new Size(336, 28);
            PaymentTypeComboBox.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Fluent Icons", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(12, 29);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 1;
            label2.Text = "N° de factura:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(554, 29);
            label1.Name = "label1";
            label1.Size = new Size(173, 28);
            label1.TabIndex = 0;
            label1.Text = "vender productos";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Blue_and_White_Illustrative_Education_Badge_Logo__1_;
            pictureBox2.Location = new Point(12, 114);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(604, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Blue_and_White_Illustrative_Education_Badge_Logo__1_;
            pictureBox3.Location = new Point(18, 204);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(598, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 32;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Blue_and_White_Illustrative_Education_Badge_Logo__1_;
            pictureBox4.Location = new Point(655, 206);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(365, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 33;
            pictureBox4.TabStop = false;
            // 
            // SalesDataGridView
            // 
            SalesDataGridView.AllowUserToAddRows = false;
            SalesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SalesDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            SalesDataGridView.BorderStyle = BorderStyle.Fixed3D;
            SalesDataGridView.ColumnHeadersHeight = 29;
            SalesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            SalesDataGridView.Location = new Point(15, 325);
            SalesDataGridView.Name = "SalesDataGridView";
            SalesDataGridView.RowHeadersWidth = 51;
            SalesDataGridView.Size = new Size(1223, 657);
            SalesDataGridView.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(AddPurchaseButton);
            groupBox2.Location = new Point(1281, 325);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(210, 317);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "acciones";
            // 
            // button3
            // 
            button3.BackColor = Color.Silver;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(23, 43);
            button3.Name = "button3";
            button3.Size = new Size(158, 29);
            button3.TabIndex = 2;
            button3.Text = "eliminar Item";
            button3.UseVisualStyleBackColor = false;
            // 
            // AddPurchaseButton
            // 
            AddPurchaseButton.BackColor = Color.LightBlue;
            AddPurchaseButton.Cursor = Cursors.Hand;
            AddPurchaseButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            AddPurchaseButton.Location = new Point(23, 146);
            AddPurchaseButton.Name = "AddPurchaseButton";
            AddPurchaseButton.Size = new Size(158, 29);
            AddPurchaseButton.TabIndex = 0;
            AddPurchaseButton.Text = "Confirmar compra";
            AddPurchaseButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Location = new Point(0, 1023);
            panel1.Name = "panel1";
            panel1.Size = new Size(1507, 99);
            panel1.TabIndex = 8;
            // 
            // AddSales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(SalesDataGridView);
            Controls.Add(groupBox1);
            Name = "AddSales";
            Size = new Size(1507, 1125);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)SalesDataGridView).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label SupplierName;
        private Button SelectCustomerButton;
        private Button button1;
        private ComboBox PaymentTypeComboBox;
        private Label label3;
        private TextBox InvoiceTextBox;
        private Label label2;
        private Label label1;
        private Label CustomerLabel;
        private DataGridView SalesDataGridView;
        private GroupBox groupBox2;
        private Button button3;
        private Button AddPurchaseButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Panel panel1;
        private Label label6;
    }
}
