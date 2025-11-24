namespace PresentationLayer.Forms
{
    partial class SelectProducts
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
            ProductsDgv = new DataGridView();
            groupBox2 = new GroupBox();
            AddProductButton = new Button();
            UnitPriceTextBox = new TextBox();
            QuantityTextBox = new TextBox();
            UnitCostTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)ProductsDgv).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // ProductsDgv
            // 
            ProductsDgv.AllowUserToAddRows = false;
            ProductsDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductsDgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ProductsDgv.BorderStyle = BorderStyle.Fixed3D;
            ProductsDgv.ColumnHeadersHeight = 29;
            ProductsDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ProductsDgv.Location = new Point(12, 12);
            ProductsDgv.Name = "ProductsDgv";
            ProductsDgv.RowHeadersWidth = 51;
            ProductsDgv.Size = new Size(1017, 588);
            ProductsDgv.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(AddProductButton);
            groupBox2.Controls.Add(UnitPriceTextBox);
            groupBox2.Controls.Add(QuantityTextBox);
            groupBox2.Controls.Add(UnitCostTextBox);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(1060, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(210, 458);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "acciones";
            // 
            // AddProductButton
            // 
            AddProductButton.Location = new Point(64, 370);
            AddProductButton.Name = "AddProductButton";
            AddProductButton.Size = new Size(94, 29);
            AddProductButton.TabIndex = 7;
            AddProductButton.Text = "agregar";
            AddProductButton.UseVisualStyleBackColor = true;
            AddProductButton.Click += AddSupplierButton_Click;
            // 
            // UnitPriceTextBox
            // 
            UnitPriceTextBox.Location = new Point(14, 255);
            UnitPriceTextBox.Name = "UnitPriceTextBox";
            UnitPriceTextBox.Size = new Size(125, 27);
            UnitPriceTextBox.TabIndex = 6;
            // 
            // QuantityTextBox
            // 
            QuantityTextBox.Location = new Point(14, 68);
            QuantityTextBox.Name = "QuantityTextBox";
            QuantityTextBox.Size = new Size(125, 27);
            QuantityTextBox.TabIndex = 5;
            // 
            // UnitCostTextBox
            // 
            UnitCostTextBox.Location = new Point(14, 161);
            UnitCostTextBox.Name = "UnitCostTextBox";
            UnitCostTextBox.Size = new Size(125, 27);
            UnitCostTextBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 115);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 3;
            label4.Text = "costo unitario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 212);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 2;
            label3.Text = "precio unitario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 35);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "cantidad";
            // 
            // SelectProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 659);
            Controls.Add(groupBox2);
            Controls.Add(ProductsDgv);
            Name = "SelectProducts";
            Text = "SelectProducts";
            ((System.ComponentModel.ISupportInitialize)ProductsDgv).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ProductsDgv;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox UnitPriceTextBox;
        private TextBox QuantityTextBox;
        private TextBox UnitCostTextBox;
        private Button AddProductButton;
    }
}