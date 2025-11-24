namespace PresentationLayer.UsersControls
{
    partial class PurchaseRegister
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
            label4 = new Label();
            SupplierName = new Label();
            button4 = new Button();
            button1 = new Button();
            PaymentTypeComboBox = new ComboBox();
            label3 = new Label();
            InvoiceTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            PurcahseDataGridView = new DataGridView();
            groupBox2 = new GroupBox();
            button3 = new Button();
            AddPurchaseButton = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PurcahseDataGridView).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(SupplierName);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(PaymentTypeComboBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(InvoiceTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1262, 291);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 169);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 27;
            label4.Text = "Proveedor :";
            // 
            // SupplierName
            // 
            SupplierName.AutoSize = true;
            SupplierName.Location = new Point(174, 169);
            SupplierName.Name = "SupplierName";
            SupplierName.Size = new Size(117, 20);
            SupplierName.TabIndex = 26;
            SupplierName.Text = "no seleccionado";
            // 
            // button4
            // 
            button4.Location = new Point(84, 213);
            button4.Name = "button4";
            button4.Size = new Size(203, 29);
            button4.TabIndex = 4;
            button4.Text = "seleccionar un proveedor";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnBuscarProveedor_Click;
            // 
            // button1
            // 
            button1.Location = new Point(754, 169);
            button1.Name = "button1";
            button1.Size = new Size(275, 29);
            button1.TabIndex = 24;
            button1.Text = "seleccionar un producto existente";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PaymentTypeComboBox
            // 
            PaymentTypeComboBox.FormattingEnabled = true;
            PaymentTypeComboBox.Location = new Point(877, 105);
            PaymentTypeComboBox.Name = "PaymentTypeComboBox";
            PaymentTypeComboBox.Size = new Size(191, 28);
            PaymentTypeComboBox.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(697, 105);
            label3.Name = "label3";
            label3.Size = new Size(122, 20);
            label3.TabIndex = 22;
            label3.Text = "metodo de pago";
            // 
            // InvoiceTextBox
            // 
            InvoiceTextBox.Location = new Point(242, 108);
            InvoiceTextBox.Name = "InvoiceTextBox";
            InvoiceTextBox.Size = new Size(226, 27);
            InvoiceTextBox.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 108);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 1;
            label2.Text = "numero de factura";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(547, 39);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 0;
            label1.Text = "agregar producto";
            // 
            // PurcahseDataGridView
            // 
            PurcahseDataGridView.AllowUserToAddRows = false;
            PurcahseDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PurcahseDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            PurcahseDataGridView.BorderStyle = BorderStyle.Fixed3D;
            PurcahseDataGridView.ColumnHeadersHeight = 29;
            PurcahseDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            PurcahseDataGridView.Location = new Point(24, 375);
            PurcahseDataGridView.Name = "PurcahseDataGridView";
            PurcahseDataGridView.RowHeadersWidth = 51;
            PurcahseDataGridView.Size = new Size(1008, 456);
            PurcahseDataGridView.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(AddPurchaseButton);
            groupBox2.Location = new Point(1055, 375);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(210, 317);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "acciones";
            // 
            // button3
            // 
            button3.Location = new Point(23, 43);
            button3.Name = "button3";
            button3.Size = new Size(158, 29);
            button3.TabIndex = 2;
            button3.Text = "eliminar Item";
            button3.UseVisualStyleBackColor = true;
            // 
            // AddPurchaseButton
            // 
            AddPurchaseButton.Location = new Point(23, 146);
            AddPurchaseButton.Name = "AddPurchaseButton";
            AddPurchaseButton.Size = new Size(158, 29);
            AddPurchaseButton.TabIndex = 0;
            AddPurchaseButton.Text = "Confirmar compra";
            AddPurchaseButton.UseVisualStyleBackColor = true;
            AddPurchaseButton.Click += AddPurchaseButton_Click;
            // 
            // PurchaseRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(PurcahseDataGridView);
            Controls.Add(groupBox1);
            Name = "PurchaseRegister";
            Size = new Size(1281, 1074);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PurcahseDataGridView).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox InvoiceTextBox;
        private Label label2;
        private Label label1;
        private ComboBox PaymentTypeComboBox;
        private Label label3;
        private Button button4;
        private Button button1;
        private DataGridView PurcahseDataGridView;
        private GroupBox groupBox2;
        private Button button3;
        private Button AddPurchaseButton;
        private Label SupplierName;
        private Label label4;
    }
}
