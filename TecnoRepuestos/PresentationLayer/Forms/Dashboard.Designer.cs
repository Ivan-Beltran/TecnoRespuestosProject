namespace PresentationLayer.Forms
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            label1 = new Label();
            button8 = new Button();
            pictureBox1 = new PictureBox();
            button9 = new Button();
            SuppliersBtn = new Button();
            button7 = new Button();
            panel2 = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            ContainerPanel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(239, 239, 242);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(SuppliersBtn);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 0, 10);
            panel1.Size = new Size(276, 1125);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 225);
            label1.Name = "label1";
            label1.Size = new Size(244, 31);
            label1.TabIndex = 0;
            label1.Text = "--------MENU--------";
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(69, 107, 157);
            button8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button8.ForeColor = Color.White;
            button8.Location = new Point(36, 839);
            button8.Name = "button8";
            button8.Size = new Size(183, 35);
            button8.TabIndex = 11;
            button8.Text = "clientes";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-31, -7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(304, 249);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(69, 107, 157);
            button9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button9.ForeColor = Color.White;
            button9.Location = new Point(36, 770);
            button9.Name = "button9";
            button9.Size = new Size(183, 35);
            button9.TabIndex = 10;
            button9.Text = "resumen diario";
            button9.UseVisualStyleBackColor = false;
            // 
            // SuppliersBtn
            // 
            SuppliersBtn.BackColor = Color.FromArgb(69, 107, 157);
            SuppliersBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            SuppliersBtn.ForeColor = Color.White;
            SuppliersBtn.Location = new Point(36, 631);
            SuppliersBtn.Name = "SuppliersBtn";
            SuppliersBtn.Size = new Size(183, 35);
            SuppliersBtn.TabIndex = 9;
            SuppliersBtn.Text = "proveedores";
            SuppliersBtn.UseVisualStyleBackColor = false;
            SuppliersBtn.Click += SuppliersBtn_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(69, 107, 157);
            button7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button7.ForeColor = Color.White;
            button7.Location = new Point(36, 701);
            button7.Name = "button7";
            button7.Size = new Size(183, 35);
            button7.TabIndex = 8;
            button7.Text = "devoluciones";
            button7.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Location = new Point(262, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 1125);
            panel2.TabIndex = 7;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(69, 107, 157);
            button6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button6.ForeColor = Color.White;
            button6.Location = new Point(35, 911);
            button6.Name = "button6";
            button6.Size = new Size(184, 35);
            button6.TabIndex = 5;
            button6.Text = "balances";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(69, 107, 157);
            button5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Location = new Point(36, 492);
            button5.Name = "button5";
            button5.Size = new Size(183, 35);
            button5.TabIndex = 4;
            button5.Text = "cuentas por pagar";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(69, 107, 157);
            button4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(36, 423);
            button4.Name = "button4";
            button4.Size = new Size(183, 35);
            button4.TabIndex = 3;
            button4.Text = "registrar compras";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(69, 107, 157);
            button3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(36, 356);
            button3.Name = "button3";
            button3.Size = new Size(183, 35);
            button3.TabIndex = 2;
            button3.Text = "productos";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(69, 107, 157);
            button2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(36, 289);
            button2.Name = "button2";
            button2.Size = new Size(183, 35);
            button2.TabIndex = 1;
            button2.Text = "vender";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(69, 107, 157);
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(36, 562);
            button1.Name = "button1";
            button1.Size = new Size(183, 35);
            button1.TabIndex = 0;
            button1.Text = "cuentas por cobrar";
            button1.UseVisualStyleBackColor = false;
            // 
            // ContainerPanel
            // 
            ContainerPanel.BackColor = Color.FromArgb(239, 239, 242);
            ContainerPanel.Dock = DockStyle.Fill;
            ContainerPanel.Location = new Point(276, 0);
            ContainerPanel.Name = "ContainerPanel";
            ContainerPanel.Size = new Size(1507, 1125);
            ContainerPanel.TabIndex = 1;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1783, 1125);
            Controls.Add(ContainerPanel);
            Controls.Add(panel1);
            Name = "Dashboard";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button6;
        private Panel ContainerPanel;
        private Button button9;
        private Button SuppliersBtn;
        private Button button7;
        private Button button8;
        private Panel panel2;
        private Button button2;
        private Label label1;
    }
}