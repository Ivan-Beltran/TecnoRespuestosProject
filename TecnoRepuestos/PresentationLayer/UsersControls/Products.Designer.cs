namespace PresentationLayer.UsersControls
{
    partial class Products
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
            CategoryCbx = new ComboBox();
            groupBox2 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            AddSupplierButton = new Button();
            ModelTextBox = new TextBox();
            BrandTextBox = new TextBox();
            CodeTextBox = new TextBox();
            NameTextBox = new TextBox();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ProductosDgv = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductosDgv).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CategoryCbx);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(ModelTextBox);
            groupBox1.Controls.Add(BrandTextBox);
            groupBox1.Controls.Add(CodeTextBox);
            groupBox1.Controls.Add(NameTextBox);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1262, 392);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // CategoryCbx
            // 
            CategoryCbx.FormattingEnabled = true;
            CategoryCbx.Location = new Point(674, 105);
            CategoryCbx.Name = "CategoryCbx";
            CategoryCbx.Size = new Size(243, 28);
            CategoryCbx.TabIndex = 15;
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
            AddSupplierButton.Text = "agregar";
            AddSupplierButton.UseVisualStyleBackColor = true;
            AddSupplierButton.Click += AddSupplierButton_Click;
            // 
            // ModelTextBox
            // 
            ModelTextBox.Location = new Point(189, 265);
            ModelTextBox.Name = "ModelTextBox";
            ModelTextBox.Size = new Size(279, 27);
            ModelTextBox.TabIndex = 11;
            // 
            // BrandTextBox
            // 
            BrandTextBox.Location = new Point(189, 215);
            BrandTextBox.Name = "BrandTextBox";
            BrandTextBox.Size = new Size(279, 27);
            BrandTextBox.TabIndex = 10;
            // 
            // CodeTextBox
            // 
            CodeTextBox.Location = new Point(189, 157);
            CodeTextBox.Name = "CodeTextBox";
            CodeTextBox.Size = new Size(279, 27);
            CodeTextBox.TabIndex = 9;
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
            label8.Location = new Point(553, 108);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 7;
            label8.Text = "categoria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(110, 269);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 4;
            label5.Text = "modelo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(116, 215);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 3;
            label4.Text = "marca";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(110, 157);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 2;
            label3.Text = "codigo";
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
            label1.Size = new Size(126, 20);
            label1.TabIndex = 0;
            label1.Text = "agregar producto";
            // 
            // ProductosDgv
            // 
            ProductosDgv.AllowUserToAddRows = false;
            ProductosDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductosDgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ProductosDgv.BorderStyle = BorderStyle.Fixed3D;
            ProductosDgv.ColumnHeadersHeight = 29;
            ProductosDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ProductosDgv.Location = new Point(16, 440);
            ProductosDgv.Name = "ProductosDgv";
            ProductosDgv.RowHeadersWidth = 51;
            ProductosDgv.Size = new Size(1262, 588);
            ProductosDgv.TabIndex = 2;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ProductosDgv);
            Controls.Add(groupBox1);
            Name = "Products";
            Size = new Size(1281, 1074);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProductosDgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox CategoryCbx;
        private GroupBox groupBox2;
        private Button button3;
        private Button button2;
        private Button AddSupplierButton;
        private TextBox ModelTextBox;
        private TextBox BrandTextBox;
        private TextBox CodeTextBox;
        private TextBox NameTextBox;
        private Label label8;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView ProductosDgv;
    }
}
