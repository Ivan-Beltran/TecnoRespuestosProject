namespace PresentationLayer.Forms
{
    partial class SelectSupplier
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
            SuppliersDgv = new DataGridView();
            AddSupplierButton = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)SuppliersDgv).BeginInit();
            SuspendLayout();
            // 
            // SuppliersDgv
            // 
            SuppliersDgv.AllowUserToAddRows = false;
            SuppliersDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SuppliersDgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            SuppliersDgv.BorderStyle = BorderStyle.Fixed3D;
            SuppliersDgv.ColumnHeadersHeight = 29;
            SuppliersDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            SuppliersDgv.Location = new Point(15, 34);
            SuppliersDgv.Name = "SuppliersDgv";
            SuppliersDgv.RowHeadersWidth = 51;
            SuppliersDgv.Size = new Size(1262, 393);
            SuppliersDgv.TabIndex = 2;
            // 
            // AddSupplierButton
            // 
            AddSupplierButton.Location = new Point(15, 484);
            AddSupplierButton.Name = "AddSupplierButton";
            AddSupplierButton.Size = new Size(134, 29);
            AddSupplierButton.TabIndex = 3;
            AddSupplierButton.Text = "seleccionar";
            AddSupplierButton.UseVisualStyleBackColor = true;
            AddSupplierButton.Click += AddSupplierButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(232, 484);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // SelectSupplier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1288, 656);
            Controls.Add(button1);
            Controls.Add(AddSupplierButton);
            Controls.Add(SuppliersDgv);
            Name = "SelectSupplier";
            Text = "SelectSupplier";
            ((System.ComponentModel.ISupportInitialize)SuppliersDgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView SuppliersDgv;
        private Button AddSupplierButton;
        private Button button1;
    }
}