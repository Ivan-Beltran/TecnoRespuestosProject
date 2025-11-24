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
            CustomerLabel = new Label();
            label3 = new Label();
            label4 = new Label();
            SelectCustomerButton = new Button();
            button1 = new Button();
            PaymentTypeComboBox = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            SalesDataGridView = new DataGridView();
            groupBox2 = new GroupBox();
            button3 = new Button();
            AddPurchaseButton = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SalesDataGridView).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CustomerLabel);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(SelectCustomerButton);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(PaymentTypeComboBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1262, 291);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // CustomerLabel
            // 
            CustomerLabel.AutoSize = true;
            CustomerLabel.Location = new Point(117, 105);
            CustomerLabel.Name = "CustomerLabel";
            CustomerLabel.Size = new Size(89, 20);
            CustomerLabel.TabIndex = 28;
            CustomerLabel.Text = "clienteLabel";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(666, 184);
            label3.Name = "label3";
            label3.Size = new Size(122, 20);
            label3.TabIndex = 22;
            label3.Text = "metodo de pago";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 105);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 27;
            label4.Text = "cliente: ";
            // 
            // SelectCustomerButton
            // 
            SelectCustomerButton.Location = new Point(27, 157);
            SelectCustomerButton.Name = "SelectCustomerButton";
            SelectCustomerButton.Size = new Size(203, 29);
            SelectCustomerButton.TabIndex = 4;
            SelectCustomerButton.Text = "seleccionar un cliente";
            SelectCustomerButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(745, 101);
            button1.Name = "button1";
            button1.Size = new Size(275, 29);
            button1.TabIndex = 24;
            button1.Text = "seleccionar un producto existente";
            button1.UseVisualStyleBackColor = true;
            // 
            // PaymentTypeComboBox
            // 
            PaymentTypeComboBox.FormattingEnabled = true;
            PaymentTypeComboBox.Location = new Point(807, 176);
            PaymentTypeComboBox.Name = "PaymentTypeComboBox";
            PaymentTypeComboBox.Size = new Size(191, 28);
            PaymentTypeComboBox.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 23);
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
            label1.Size = new Size(125, 20);
            label1.TabIndex = 0;
            label1.Text = "vender productos";
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
            SalesDataGridView.Size = new Size(1008, 456);
            SalesDataGridView.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(AddPurchaseButton);
            groupBox2.Location = new Point(1055, 325);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(210, 317);
            groupBox2.TabIndex = 7;
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
            // 
            // AddSales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(SalesDataGridView);
            Controls.Add(groupBox1);
            Name = "AddSales";
            Size = new Size(1281, 1074);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
    }
}
