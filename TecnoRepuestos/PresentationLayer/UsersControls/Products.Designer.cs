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
            label6 = new Label();
            pictureBox6 = new PictureBox();
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
            ProductosDgv = new DataGridView();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductosDgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(CategoryCbx);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(ModelTextBox);
            groupBox1.Controls.Add(BrandTextBox);
            groupBox1.Controls.Add(CodeTextBox);
            groupBox1.Controls.Add(NameTextBox);
            groupBox1.Controls.Add(pictureBox6);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(17, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1469, 392);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe Fluent Icons", 13.8F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(69, 107, 157);
            label6.Location = new Point(182, -9);
            label6.Name = "label6";
            label6.Size = new Size(173, 36);
            label6.TabIndex = 42;
            label6.Text = "Agregar Productos";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Blue_and_White_Illustrative_Education_Badge_Logo__1_;
            pictureBox6.Location = new Point(171, 59);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(634, 32);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 41;
            pictureBox6.TabStop = false;
            // 
            // CategoryCbx
            // 
            CategoryCbx.FlatStyle = FlatStyle.Flat;
            CategoryCbx.FormattingEnabled = true;
            CategoryCbx.Location = new Point(171, 130);
            CategoryCbx.Name = "CategoryCbx";
            CategoryCbx.Size = new Size(593, 28);
            CategoryCbx.TabIndex = 15;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(AddSupplierButton);
            groupBox2.Location = new Point(1213, 39);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(210, 317);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "acciones";
            // 
            // button3
            // 
            button3.BackColor = Color.Firebrick;
            button3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(51, 226);
            button3.Name = "button3";
            button3.Size = new Size(112, 42);
            button3.TabIndex = 2;
            button3.Text = "eliminar";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.InactiveCaption;
            button2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            button2.Location = new Point(51, 144);
            button2.Name = "button2";
            button2.Size = new Size(112, 42);
            button2.TabIndex = 1;
            button2.Text = "editar";
            button2.UseVisualStyleBackColor = false;
            // 
            // AddSupplierButton
            // 
            AddSupplierButton.BackColor = SystemColors.ActiveCaption;
            AddSupplierButton.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            AddSupplierButton.Location = new Point(51, 66);
            AddSupplierButton.Name = "AddSupplierButton";
            AddSupplierButton.Size = new Size(112, 42);
            AddSupplierButton.TabIndex = 0;
            AddSupplierButton.Text = "agregar";
            AddSupplierButton.UseVisualStyleBackColor = false;
            AddSupplierButton.Click += AddSupplierButton_Click;
            // 
            // ModelTextBox
            // 
            ModelTextBox.BorderStyle = BorderStyle.None;
            ModelTextBox.Location = new Point(747, 271);
            ModelTextBox.Name = "ModelTextBox";
            ModelTextBox.Size = new Size(379, 20);
            ModelTextBox.TabIndex = 11;
            // 
            // BrandTextBox
            // 
            BrandTextBox.BorderStyle = BorderStyle.None;
            BrandTextBox.Location = new Point(178, 271);
            BrandTextBox.Name = "BrandTextBox";
            BrandTextBox.Size = new Size(453, 20);
            BrandTextBox.TabIndex = 10;
            // 
            // CodeTextBox
            // 
            CodeTextBox.BorderStyle = BorderStyle.None;
            CodeTextBox.Location = new Point(917, 66);
            CodeTextBox.Name = "CodeTextBox";
            CodeTextBox.Size = new Size(217, 20);
            CodeTextBox.TabIndex = 9;
            // 
            // NameTextBox
            // 
            NameTextBox.BorderStyle = BorderStyle.None;
            NameTextBox.Location = new Point(183, 65);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(606, 20);
            NameTextBox.TabIndex = 8;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe Fluent Icons", 13.8F, FontStyle.Bold);
            label8.Location = new Point(66, 128);
            label8.Name = "label8";
            label8.Size = new Size(107, 43);
            label8.TabIndex = 7;
            label8.Text = "Categoria:";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe Fluent Icons", 13.8F, FontStyle.Bold);
            label5.Location = new Point(662, 265);
            label5.Name = "label5";
            label5.Size = new Size(96, 43);
            label5.TabIndex = 4;
            label5.Text = "Modelo:";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe Fluent Icons", 13.8F, FontStyle.Bold);
            label4.Location = new Point(98, 265);
            label4.Name = "label4";
            label4.Size = new Size(85, 43);
            label4.TabIndex = 3;
            label4.Text = "Marca:";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe Fluent Icons", 13.8F, FontStyle.Bold);
            label3.Location = new Point(825, 59);
            label3.Name = "label3";
            label3.Size = new Size(91, 43);
            label3.TabIndex = 2;
            label3.Text = "Codigo:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe Fluent Icons", 13.8F, FontStyle.Bold);
            label2.Location = new Point(87, 55);
            label2.Name = "label2";
            label2.Size = new Size(96, 43);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
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
            ProductosDgv.Size = new Size(1452, 657);
            ProductosDgv.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Blue_and_White_Illustrative_Education_Badge_Logo__1_;
            pictureBox1.Location = new Point(904, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(238, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Blue_and_White_Illustrative_Education_Badge_Logo__1_;
            pictureBox2.Location = new Point(171, 265);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(465, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 44;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Blue_and_White_Illustrative_Education_Badge_Logo__1_;
            pictureBox3.Location = new Point(738, 265);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(404, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 45;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Blue_and_White_Illustrative_Education_Badge_Logo__1_;
            pictureBox4.Location = new Point(162, 128);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(614, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 46;
            pictureBox4.TabStop = false;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ProductosDgv);
            Controls.Add(groupBox1);
            Name = "Products";
            Size = new Size(1507, 1125);
            Load += Products_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProductosDgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
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
        private DataGridView ProductosDgv;
        private PictureBox pictureBox6;
        private Label label6;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
    }
}
