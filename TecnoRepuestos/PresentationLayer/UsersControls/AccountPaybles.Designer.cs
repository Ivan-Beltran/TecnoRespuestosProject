namespace PresentationLayer.UsersControls
{
    partial class AccountPaybles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountPaybles));
            AccountsPayblesDataGridView = new DataGridView();
            groupBox2 = new GroupBox();
            MountTextBox = new TextBox();
            label1 = new Label();
            AddPurchaseButton = new Button();
            label2 = new Label();
            AccountsPaydataGridView = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)AccountsPayblesDataGridView).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AccountsPaydataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // AccountsPayblesDataGridView
            // 
            AccountsPayblesDataGridView.AllowUserToAddRows = false;
            AccountsPayblesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AccountsPayblesDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            AccountsPayblesDataGridView.BorderStyle = BorderStyle.Fixed3D;
            AccountsPayblesDataGridView.ColumnHeadersHeight = 29;
            AccountsPayblesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            AccountsPayblesDataGridView.Location = new Point(28, 172);
            AccountsPayblesDataGridView.Name = "AccountsPayblesDataGridView";
            AccountsPayblesDataGridView.RowHeadersWidth = 51;
            AccountsPayblesDataGridView.Size = new Size(1128, 351);
            AccountsPayblesDataGridView.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(MountTextBox);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(AddPurchaseButton);
            groupBox2.Controls.Add(pictureBox4);
            groupBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(1217, 172);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(230, 351);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "acciones";
            // 
            // MountTextBox
            // 
            MountTextBox.BorderStyle = BorderStyle.None;
            MountTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MountTextBox.Location = new Point(20, 87);
            MountTextBox.Name = "MountTextBox";
            MountTextBox.Size = new Size(176, 23);
            MountTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(27, 118);
            label1.Name = "label1";
            label1.Size = new Size(188, 20);
            label1.TabIndex = 1;
            label1.Text = "(Ingresar monto abonado)";
            // 
            // AddPurchaseButton
            // 
            AddPurchaseButton.BackColor = SystemColors.ActiveCaption;
            AddPurchaseButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddPurchaseButton.ForeColor = SystemColors.ActiveCaptionText;
            AddPurchaseButton.Location = new Point(38, 274);
            AddPurchaseButton.Name = "AddPurchaseButton";
            AddPurchaseButton.Size = new Size(158, 38);
            AddPurchaseButton.TabIndex = 0;
            AddPurchaseButton.Text = "Confirmar abono";
            AddPurchaseButton.UseVisualStyleBackColor = false;
            AddPurchaseButton.Click += AddPurchaseButton_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe Fluent Icons", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(69, 107, 157);
            label2.Location = new Point(78, 608);
            label2.Name = "label2";
            label2.Size = new Size(162, 34);
            label2.TabIndex = 8;
            label2.Text = "Cuentas pagadas";
            // 
            // AccountsPaydataGridView
            // 
            AccountsPaydataGridView.AllowUserToAddRows = false;
            AccountsPaydataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AccountsPaydataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            AccountsPaydataGridView.BorderStyle = BorderStyle.Fixed3D;
            AccountsPaydataGridView.ColumnHeadersHeight = 29;
            AccountsPaydataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            AccountsPaydataGridView.Location = new Point(28, 656);
            AccountsPaydataGridView.Name = "AccountsPaydataGridView";
            AccountsPaydataGridView.RowHeadersWidth = 51;
            AccountsPaydataGridView.Size = new Size(1419, 428);
            AccountsPaydataGridView.TabIndex = 9;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe Fluent Icons", 13.8F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(69, 107, 157);
            label3.Location = new Point(78, 130);
            label3.Name = "label3";
            label3.Size = new Size(185, 29);
            label3.TabIndex = 10;
            label3.Text = "Cuentas por pagar";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe Fluent Icons", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(651, 31);
            label4.Name = "label4";
            label4.Size = new Size(236, 36);
            label4.TabIndex = 11;
            label4.Text = "Control de Creditos";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Blue_and_White_Illustrative_Education_Badge_Logo__1_;
            pictureBox4.Location = new Point(10, 82);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(203, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 34;
            pictureBox4.TabStop = false;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe Fluent Icons", 13.8F, FontStyle.Bold);
            label5.Location = new Point(10, 50);
            label5.Name = "label5";
            label5.Size = new Size(88, 29);
            label5.TabIndex = 12;
            label5.Text = "Abono:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaption;
            label6.Location = new Point(28, 130);
            label6.Name = "label6";
            label6.Size = new Size(1131, 20);
            label6.TabIndex = 12;
            label6.Text = "___________________________________________________________________________________________________________________________________________________________________________________________";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ActiveCaption;
            label7.Location = new Point(28, 608);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(69, 107, 157);
            label8.Location = new Point(28, 609);
            label8.Name = "label8";
            label8.Size = new Size(1425, 20);
            label8.TabIndex = 14;
            label8.Text = resources.GetString("label8.Text");
            // 
            // AccountPaybles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(AccountsPaydataGridView);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(AccountsPayblesDataGridView);
            Controls.Add(label6);
            Controls.Add(label8);
            Name = "AccountPaybles";
            Size = new Size(1507, 1125);
            ((System.ComponentModel.ISupportInitialize)AccountsPayblesDataGridView).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AccountsPaydataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView AccountsPayblesDataGridView;
        private GroupBox groupBox2;
        private Button AddPurchaseButton;
        private TextBox MountTextBox;
        private Label label1;
        private Label label2;
        private DataGridView AccountsPaydataGridView;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
