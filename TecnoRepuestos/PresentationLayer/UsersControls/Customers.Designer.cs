namespace PresentationLayer.UsersControls
{
    partial class Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            groupBox1 = new GroupBox();
            EmailTextBox = new TextBox();
            TelephoneTextBox = new TextBox();
            NRCTextBox = new TextBox();
            label7 = new Label();
            label6 = new Label();
            groupBox2 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            AddSupplierButton = new Button();
            DuiTextBox = new TextBox();
            AddressTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            NameTextBox = new TextBox();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            CustomersDgv = new DataGridView();
            pictureBox4 = new PictureBox();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomersDgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox7);
            groupBox1.Controls.Add(pictureBox6);
            groupBox1.Controls.Add(pictureBox5);
            groupBox1.Controls.Add(AddressTextBox);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(EmailTextBox);
            groupBox1.Controls.Add(TelephoneTextBox);
            groupBox1.Controls.Add(NRCTextBox);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(DuiTextBox);
            groupBox1.Controls.Add(LastNameTextBox);
            groupBox1.Controls.Add(NameTextBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(17, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1475, 392);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // EmailTextBox
            // 
            EmailTextBox.BorderStyle = BorderStyle.None;
            EmailTextBox.Font = new Font("Segoe UI", 10F);
            EmailTextBox.Location = new Point(206, 147);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(851, 23);
            EmailTextBox.TabIndex = 20;
            // 
            // TelephoneTextBox
            // 
            TelephoneTextBox.BorderStyle = BorderStyle.None;
            TelephoneTextBox.Font = new Font("Segoe UI", 10F);
            TelephoneTextBox.Location = new Point(200, 291);
            TelephoneTextBox.Name = "TelephoneTextBox";
            TelephoneTextBox.Size = new Size(342, 23);
            TelephoneTextBox.TabIndex = 19;
            // 
            // NRCTextBox
            // 
            NRCTextBox.BorderStyle = BorderStyle.None;
            NRCTextBox.Font = new Font("Segoe UI", 10F);
            NRCTextBox.Location = new Point(703, 240);
            NRCTextBox.Name = "NRCTextBox";
            NRCTextBox.Size = new Size(353, 23);
            NRCTextBox.TabIndex = 18;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe Fluent Icons", 13.8F, FontStyle.Bold);
            label7.Location = new Point(94, 286);
            label7.Name = "label7";
            label7.Size = new Size(109, 33);
            label7.TabIndex = 17;
            label7.Text = "Telefono:";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe Fluent Icons", 13.8F, FontStyle.Bold);
            label6.Location = new Point(633, 235);
            label6.Name = "label6";
            label6.Size = new Size(80, 33);
            label6.TabIndex = 16;
            label6.Text = "NRC:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(AddSupplierButton);
            groupBox2.Location = new Point(1194, 39);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(210, 317);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "acciones";
            // 
            // button3
            // 
            button3.BackColor = Color.DarkRed;
            button3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(50, 226);
            button3.Name = "button3";
            button3.Size = new Size(126, 37);
            button3.TabIndex = 2;
            button3.Text = "eliminar";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ScrollBar;
            button2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            button2.Location = new Point(50, 144);
            button2.Name = "button2";
            button2.Size = new Size(126, 37);
            button2.TabIndex = 1;
            button2.Text = "editar";
            button2.UseVisualStyleBackColor = false;
            // 
            // AddSupplierButton
            // 
            AddSupplierButton.BackColor = SystemColors.ActiveCaption;
            AddSupplierButton.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            AddSupplierButton.ForeColor = SystemColors.WindowText;
            AddSupplierButton.Location = new Point(50, 72);
            AddSupplierButton.Name = "AddSupplierButton";
            AddSupplierButton.Size = new Size(126, 37);
            AddSupplierButton.TabIndex = 0;
            AddSupplierButton.Text = "agregar";
            AddSupplierButton.UseVisualStyleBackColor = false;
            AddSupplierButton.Click += AddSupplierButton_Click;
            // 
            // DuiTextBox
            // 
            DuiTextBox.BorderStyle = BorderStyle.None;
            DuiTextBox.Font = new Font("Segoe UI", 10F);
            DuiTextBox.Location = new Point(200, 240);
            DuiTextBox.Name = "DuiTextBox";
            DuiTextBox.Size = new Size(342, 23);
            DuiTextBox.TabIndex = 11;
            // 
            // AddressTextBox
            // 
            AddressTextBox.BorderStyle = BorderStyle.None;
            AddressTextBox.Font = new Font("Segoe UI", 10F);
            AddressTextBox.Location = new Point(207, 194);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(849, 23);
            AddressTextBox.TabIndex = 10;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.BorderStyle = BorderStyle.None;
            LastNameTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LastNameTextBox.Location = new Point(703, 97);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(337, 23);
            LastNameTextBox.TabIndex = 9;
            // 
            // NameTextBox
            // 
            NameTextBox.BorderStyle = BorderStyle.None;
            NameTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameTextBox.Location = new Point(203, 100);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(339, 23);
            NameTextBox.TabIndex = 8;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe Fluent Icons", 13.8F, FontStyle.Bold);
            label8.Location = new Point(123, 141);
            label8.Name = "label8";
            label8.Size = new Size(88, 33);
            label8.TabIndex = 7;
            label8.Text = "Email:";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe Fluent Icons", 13.8F, FontStyle.Bold);
            label5.Location = new Point(135, 233);
            label5.Name = "label5";
            label5.Size = new Size(76, 33);
            label5.TabIndex = 4;
            label5.Text = "DUI:";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe Fluent Icons", 13.8F, FontStyle.Bold);
            label4.Location = new Point(90, 189);
            label4.Name = "label4";
            label4.Size = new Size(112, 33);
            label4.TabIndex = 3;
            label4.Text = "Direccion:";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe Fluent Icons", 13.8F, FontStyle.Bold);
            label3.Location = new Point(607, 92);
            label3.Name = "label3";
            label3.Size = new Size(106, 33);
            label3.TabIndex = 2;
            label3.Text = "Apellido:";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe Fluent Icons", 13.8F, FontStyle.Bold);
            label2.Location = new Point(105, 92);
            label2.Name = "label2";
            label2.Size = new Size(103, 33);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe Fluent Icons", 13.8F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(69, 107, 157);
            label1.Location = new Point(474, 23);
            label1.Name = "label1";
            label1.Size = new Size(146, 36);
            label1.TabIndex = 0;
            label1.Text = "Agregar cliente";
            // 
            // CustomersDgv
            // 
            CustomersDgv.AllowUserToAddRows = false;
            CustomersDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CustomersDgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            CustomersDgv.BorderStyle = BorderStyle.Fixed3D;
            CustomersDgv.ColumnHeadersHeight = 29;
            CustomersDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            CustomersDgv.Location = new Point(19, 429);
            CustomersDgv.Name = "CustomersDgv";
            CustomersDgv.RowHeadersWidth = 51;
            CustomersDgv.Size = new Size(1472, 669);
            CustomersDgv.TabIndex = 3;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Blue_and_White_Illustrative_Education_Badge_Logo__1_;
            pictureBox4.Location = new Point(188, 92);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(365, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 34;
            pictureBox4.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(69, 107, 157);
            label9.Location = new Point(-3, 16);
            label9.Name = "label9";
            label9.Size = new Size(1521, 20);
            label9.TabIndex = 35;
            label9.Text = resources.GetString("label9.Text");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Blue_and_White_Illustrative_Education_Badge_Logo__1_;
            pictureBox1.Location = new Point(692, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(376, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Blue_and_White_Illustrative_Education_Badge_Logo__1_;
            pictureBox2.Location = new Point(188, 142);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(880, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 37;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Blue_and_White_Illustrative_Education_Badge_Logo__1_;
            pictureBox3.Location = new Point(188, 190);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(880, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 38;
            pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Blue_and_White_Illustrative_Education_Badge_Logo__1_;
            pictureBox5.Location = new Point(188, 236);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(365, 32);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 39;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Blue_and_White_Illustrative_Education_Badge_Logo__1_;
            pictureBox6.Location = new Point(692, 236);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(376, 32);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 40;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.Blue_and_White_Illustrative_Education_Badge_Logo__1_;
            pictureBox7.Location = new Point(188, 287);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(365, 32);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 41;
            pictureBox7.TabStop = false;
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CustomersDgv);
            Controls.Add(groupBox1);
            Name = "Customers";
            Size = new Size(1507, 1125);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CustomersDgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox EmailTextBox;
        private TextBox TelephoneTextBox;
        private TextBox NRCTextBox;
        private Label label7;
        private Label label6;
        private GroupBox groupBox2;
        private Button button3;
        private Button button2;
        private Button AddSupplierButton;
        private TextBox DuiTextBox;
        private TextBox AddressTextBox;
        private TextBox LastNameTextBox;
        private TextBox NameTextBox;
        private Label label8;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView CustomersDgv;
        private PictureBox pictureBox4;
        private Label label9;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
    }
}
