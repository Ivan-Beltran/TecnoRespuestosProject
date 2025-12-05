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
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)ProductsDgv).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            ProductsDgv.Location = new Point(12, 150);
            ProductsDgv.Name = "ProductsDgv";
            ProductsDgv.RowHeadersWidth = 51;
            ProductsDgv.Size = new Size(1017, 839);
            ProductsDgv.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(AddProductButton);
            groupBox2.Controls.Add(UnitPriceTextBox);
            groupBox2.Controls.Add(QuantityTextBox);
            groupBox2.Controls.Add(UnitCostTextBox);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Location = new Point(1060, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(417, 1054);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // AddProductButton
            // 
            AddProductButton.BackColor = Color.LightSteelBlue;
            AddProductButton.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddProductButton.Location = new Point(280, 574);
            AddProductButton.Name = "AddProductButton";
            AddProductButton.Size = new Size(131, 47);
            AddProductButton.TabIndex = 7;
            AddProductButton.Text = "agregar";
            AddProductButton.UseVisualStyleBackColor = false;
            AddProductButton.Click += AddSupplierButton_Click;
            // 
            // UnitPriceTextBox
            // 
            UnitPriceTextBox.BorderStyle = BorderStyle.None;
            UnitPriceTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UnitPriceTextBox.Location = new Point(70, 489);
            UnitPriceTextBox.Name = "UnitPriceTextBox";
            UnitPriceTextBox.Size = new Size(251, 31);
            UnitPriceTextBox.TabIndex = 6;
            // 
            // QuantityTextBox
            // 
            QuantityTextBox.BorderStyle = BorderStyle.None;
            QuantityTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QuantityTextBox.Location = new Point(70, 179);
            QuantityTextBox.Name = "QuantityTextBox";
            QuantityTextBox.Size = new Size(251, 31);
            QuantityTextBox.TabIndex = 5;
            // 
            // UnitCostTextBox
            // 
            UnitCostTextBox.BorderStyle = BorderStyle.None;
            UnitCostTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UnitCostTextBox.Location = new Point(67, 327);
            UnitCostTextBox.Name = "UnitCostTextBox";
            UnitCostTextBox.Size = new Size(254, 31);
            UnitCostTextBox.TabIndex = 4;
            UnitCostTextBox.TextChanged += UnitCostTextBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Fluent Icons", 18F);
            label4.Location = new Point(24, 284);
            label4.Name = "label4";
            label4.Size = new Size(150, 30);
            label4.TabIndex = 3;
            label4.Text = "Costo unitario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Fluent Icons", 18F);
            label3.Location = new Point(24, 455);
            label3.Name = "label3";
            label3.Size = new Size(155, 30);
            label3.TabIndex = 2;
            label3.Text = "Precio unitario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Fluent Icons", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 144);
            label1.Name = "label1";
            label1.Size = new Size(100, 30);
            label1.TabIndex = 0;
            label1.Text = "Cantidad";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Blue_and_White_Illustrative_Education_Badge_Logo__1_;
            pictureBox1.Location = new Point(56, 177);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(274, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Blue_and_White_Illustrative_Education_Badge_Logo__1_;
            pictureBox3.Location = new Point(56, 326);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(274, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Blue_and_White_Illustrative_Education_Badge_Logo__1_;
            pictureBox2.Location = new Point(56, 488);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(274, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(300, 70);
            label2.Name = "label2";
            label2.Size = new Size(384, 31);
            label2.TabIndex = 8;
            label2.Text = "Selecciona un producto existente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(143, 52);
            label5.Name = "label5";
            label5.Size = new Size(127, 37);
            label5.TabIndex = 11;
            label5.Text = "Acciones";
            // 
            // SelectProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1489, 1078);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(ProductsDgv);
            Name = "SelectProducts";
            Text = "SelectProducts";
            ((System.ComponentModel.ISupportInitialize)ProductsDgv).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label5;
    }
}