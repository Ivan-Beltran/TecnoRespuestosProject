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
            button8 = new Button();
            button9 = new Button();
            SuppliersBtn = new Button();
            button7 = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
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
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(SuppliersBtn);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
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
            panel1.Size = new Size(256, 721);
            panel1.TabIndex = 0;
            // 
            // button8
            // 
            button8.Location = new Point(29, 534);
            button8.Name = "button8";
            button8.Size = new Size(184, 29);
            button8.TabIndex = 11;
            button8.Text = "clientes";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(30, 499);
            button9.Name = "button9";
            button9.Size = new Size(184, 29);
            button9.TabIndex = 10;
            button9.Text = "resumen diario";
            button9.UseVisualStyleBackColor = true;
            // 
            // SuppliersBtn
            // 
            SuppliersBtn.Location = new Point(30, 406);
            SuppliersBtn.Name = "SuppliersBtn";
            SuppliersBtn.Size = new Size(184, 29);
            SuppliersBtn.TabIndex = 9;
            SuppliersBtn.Text = "proveedores";
            SuppliersBtn.UseVisualStyleBackColor = true;
            SuppliersBtn.Click += SuppliersBtn_Click;
            // 
            // button7
            // 
            button7.Location = new Point(30, 452);
            button7.Name = "button7";
            button7.Size = new Size(184, 29);
            button7.TabIndex = 8;
            button7.Text = "devoluciones";
            button7.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Location = new Point(2, 176);
            panel2.Name = "panel2";
            panel2.Size = new Size(251, 11);
            panel2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // button6
            // 
            button6.Location = new Point(29, 585);
            button6.Name = "button6";
            button6.Size = new Size(185, 29);
            button6.TabIndex = 5;
            button6.Text = "balances";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(30, 326);
            button5.Name = "button5";
            button5.Size = new Size(184, 29);
            button5.TabIndex = 4;
            button5.Text = "cuentas por pagar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(30, 291);
            button4.Name = "button4";
            button4.Size = new Size(184, 29);
            button4.TabIndex = 3;
            button4.Text = "registrar compras";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(30, 247);
            button3.Name = "button3";
            button3.Size = new Size(184, 29);
            button3.TabIndex = 2;
            button3.Text = "productos";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(30, 203);
            button2.Name = "button2";
            button2.Size = new Size(184, 29);
            button2.TabIndex = 1;
            button2.Text = "vender";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(31, 371);
            button1.Name = "button1";
            button1.Size = new Size(184, 29);
            button1.TabIndex = 0;
            button1.Text = "cuentas por cobrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // ContainerPanel
            // 
            ContainerPanel.BackColor = SystemColors.ActiveBorder;
            ContainerPanel.Dock = DockStyle.Fill;
            ContainerPanel.Location = new Point(256, 0);
            ContainerPanel.Name = "ContainerPanel";
            ContainerPanel.Size = new Size(1092, 721);
            ContainerPanel.TabIndex = 1;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 721);
            Controls.Add(ContainerPanel);
            Controls.Add(panel1);
            Name = "Dashboard";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button6;
        private Panel panel2;
        private Panel ContainerPanel;
        private Button button9;
        private Button SuppliersBtn;
        private Button button7;
        private Button button8;
    }
}