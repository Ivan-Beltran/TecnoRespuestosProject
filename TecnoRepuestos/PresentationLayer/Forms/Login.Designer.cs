namespace PresentationLayer.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            LateralPanle = new Panel();
            LogoPBX = new PictureBox();
            SubtitleLabel = new Label();
            TitleLabel = new Label();
            CloseButton = new Button();
            LoginTitleLabel = new Label();
            panel1 = new Panel();
            UserNametextBox = new TextBox();
            UsernameLabel = new Label();
            UserIconpictureBox = new PictureBox();
            panel2 = new Panel();
            PasswordTextBox = new TextBox();
            PasswordLabel = new Label();
            CandadoIconpictureBox = new PictureBox();
            LoginButton = new Button();
            LateralPanle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPBX).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserIconpictureBox).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CandadoIconpictureBox).BeginInit();
            SuspendLayout();
            // 
            // LateralPanle
            // 
            LateralPanle.BackColor = SystemColors.HotTrack;
            LateralPanle.Controls.Add(LogoPBX);
            LateralPanle.Controls.Add(SubtitleLabel);
            LateralPanle.Controls.Add(TitleLabel);
            LateralPanle.Location = new Point(-2, 0);
            LateralPanle.Name = "LateralPanle";
            LateralPanle.Size = new Size(377, 537);
            LateralPanle.TabIndex = 0;
            // 
            // LogoPBX
            // 
            LogoPBX.Image = (Image)resources.GetObject("LogoPBX.Image");
            LogoPBX.Location = new Point(85, 44);
            LogoPBX.Name = "LogoPBX";
            LogoPBX.Size = new Size(198, 206);
            LogoPBX.SizeMode = PictureBoxSizeMode.Zoom;
            LogoPBX.TabIndex = 2;
            LogoPBX.TabStop = false;
            // 
            // SubtitleLabel
            // 
            SubtitleLabel.AutoSize = true;
            SubtitleLabel.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubtitleLabel.ForeColor = Color.White;
            SubtitleLabel.Location = new Point(85, 344);
            SubtitleLabel.Name = "SubtitleLabel";
            SubtitleLabel.Size = new Size(208, 35);
            SubtitleLabel.TabIndex = 1;
            SubtitleLabel.Text = " en un solo lugar";
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.ForeColor = Color.White;
            TitleLabel.Location = new Point(0, 295);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(380, 35);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Todo lo que tu equipo necesitas";
            // 
            // CloseButton
            // 
            CloseButton.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseButton.ForeColor = SystemColors.HotTrack;
            CloseButton.Location = new Point(972, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(53, 49);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "X";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // LoginTitleLabel
            // 
            LoginTitleLabel.AutoSize = true;
            LoginTitleLabel.Font = new Font("Segoe UI", 15F);
            LoginTitleLabel.ForeColor = Color.FromArgb(41, 128, 145);
            LoginTitleLabel.Location = new Point(542, 80);
            LoginTitleLabel.Name = "LoginTitleLabel";
            LoginTitleLabel.Size = new Size(343, 35);
            LoginTitleLabel.TabIndex = 2;
            LoginTitleLabel.Text = "Bienvenido a TecnoRepuestos";
            // 
            // panel1
            // 
            panel1.Controls.Add(UserNametextBox);
            panel1.Controls.Add(UsernameLabel);
            panel1.Controls.Add(UserIconpictureBox);
            panel1.Location = new Point(381, 182);
            panel1.Name = "panel1";
            panel1.Size = new Size(608, 85);
            panel1.TabIndex = 3;
            // 
            // UserNametextBox
            // 
            UserNametextBox.Location = new Point(200, 41);
            UserNametextBox.Name = "UserNametextBox";
            UserNametextBox.Size = new Size(304, 27);
            UserNametextBox.TabIndex = 2;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UsernameLabel.ForeColor = Color.FromArgb(41, 128, 145);
            UsernameLabel.Location = new Point(285, 7);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(81, 28);
            UsernameLabel.TabIndex = 1;
            UsernameLabel.Text = "Usuario";
            // 
            // UserIconpictureBox
            // 
            UserIconpictureBox.Image = (Image)resources.GetObject("UserIconpictureBox.Image");
            UserIconpictureBox.InitialImage = null;
            UserIconpictureBox.Location = new Point(54, 13);
            UserIconpictureBox.Name = "UserIconpictureBox";
            UserIconpictureBox.Size = new Size(50, 50);
            UserIconpictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            UserIconpictureBox.TabIndex = 0;
            UserIconpictureBox.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(PasswordTextBox);
            panel2.Controls.Add(PasswordLabel);
            panel2.Controls.Add(CandadoIconpictureBox);
            panel2.Location = new Point(381, 276);
            panel2.Name = "panel2";
            panel2.Size = new Size(608, 82);
            panel2.TabIndex = 4;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(200, 46);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(304, 27);
            PasswordTextBox.TabIndex = 2;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasswordLabel.ForeColor = Color.FromArgb(41, 128, 145);
            PasswordLabel.Location = new Point(275, 6);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(114, 28);
            PasswordLabel.TabIndex = 1;
            PasswordLabel.Text = "Contraseña";
            // 
            // CandadoIconpictureBox
            // 
            CandadoIconpictureBox.Image = (Image)resources.GetObject("CandadoIconpictureBox.Image");
            CandadoIconpictureBox.Location = new Point(54, 19);
            CandadoIconpictureBox.Name = "CandadoIconpictureBox";
            CandadoIconpictureBox.Size = new Size(50, 50);
            CandadoIconpictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            CandadoIconpictureBox.TabIndex = 0;
            CandadoIconpictureBox.TabStop = false;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(41, 128, 145);
            LoginButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginButton.ForeColor = SystemColors.Control;
            LoginButton.Location = new Point(641, 408);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(168, 43);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "iniciar Session";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 537);
            Controls.Add(LoginButton);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(LoginTitleLabel);
            Controls.Add(CloseButton);
            Controls.Add(LateralPanle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            LateralPanle.ResumeLayout(false);
            LateralPanle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPBX).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserIconpictureBox).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CandadoIconpictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel LateralPanle;
        private Label TitleLabel;
        private Label SubtitleLabel;
        private Button CloseButton;
        private Label LoginTitleLabel;
        private Panel panel1;
        private PictureBox UserIconpictureBox;
        private Panel panel2;
        private PictureBox CandadoIconpictureBox;
        private PictureBox LogoPBX;
        private TextBox UserNametextBox;
        private Label UsernameLabel;
        private TextBox PasswordTextBox;
        private Label PasswordLabel;
        private Button LoginButton;
    }
}