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
            AccountsPayblesDataGridView = new DataGridView();
            groupBox2 = new GroupBox();
            MountTextBox = new TextBox();
            label1 = new Label();
            AddPurchaseButton = new Button();
            label2 = new Label();
            AccountsPaydataGridView = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)AccountsPayblesDataGridView).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AccountsPaydataGridView).BeginInit();
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
            AccountsPayblesDataGridView.Location = new Point(28, 67);
            AccountsPayblesDataGridView.Name = "AccountsPayblesDataGridView";
            AccountsPayblesDataGridView.RowHeadersWidth = 51;
            AccountsPayblesDataGridView.Size = new Size(953, 351);
            AccountsPayblesDataGridView.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(MountTextBox);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(AddPurchaseButton);
            groupBox2.Location = new Point(1012, 67);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(230, 351);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "acciones";
            // 
            // MountTextBox
            // 
            MountTextBox.Location = new Point(43, 105);
            MountTextBox.Name = "MountTextBox";
            MountTextBox.Size = new Size(125, 27);
            MountTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 54);
            label1.Name = "label1";
            label1.Size = new Size(174, 20);
            label1.TabIndex = 1;
            label1.Text = "ingresar monto abonado";
            // 
            // AddPurchaseButton
            // 
            AddPurchaseButton.Location = new Point(27, 232);
            AddPurchaseButton.Name = "AddPurchaseButton";
            AddPurchaseButton.Size = new Size(158, 29);
            AddPurchaseButton.TabIndex = 0;
            AddPurchaseButton.Text = "Confirmar abono";
            AddPurchaseButton.UseVisualStyleBackColor = true;
            AddPurchaseButton.Click += AddPurchaseButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(513, 460);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 8;
            label2.Text = "cuentas pagadas";
            // 
            // AccountsPaydataGridView
            // 
            AccountsPaydataGridView.AllowUserToAddRows = false;
            AccountsPaydataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AccountsPaydataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            AccountsPaydataGridView.BorderStyle = BorderStyle.Fixed3D;
            AccountsPaydataGridView.ColumnHeadersHeight = 29;
            AccountsPaydataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            AccountsPaydataGridView.Location = new Point(28, 498);
            AccountsPaydataGridView.Name = "AccountsPaydataGridView";
            AccountsPaydataGridView.RowHeadersWidth = 51;
            AccountsPaydataGridView.Size = new Size(953, 351);
            AccountsPaydataGridView.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(487, 18);
            label3.Name = "label3";
            label3.Size = new Size(129, 20);
            label3.TabIndex = 10;
            label3.Text = "cuentas por pagar";
            // 
            // AccountPaybles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(AccountsPaydataGridView);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(AccountsPayblesDataGridView);
            Name = "AccountPaybles";
            Size = new Size(1281, 1074);
            ((System.ComponentModel.ISupportInitialize)AccountsPayblesDataGridView).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AccountsPaydataGridView).EndInit();
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
    }
}
