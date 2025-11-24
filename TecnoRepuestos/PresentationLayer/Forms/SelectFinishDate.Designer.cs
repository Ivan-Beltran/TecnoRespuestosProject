namespace PresentationLayer.Forms
{
    partial class SelectFinishDate
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
            label1 = new Label();
            PaydateTimePicker = new DateTimePicker();
            Confirmbutton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 45);
            label1.Name = "label1";
            label1.Size = new Size(159, 20);
            label1.TabIndex = 0;
            label1.Text = "fecha de fin de credito";
            // 
            // PaydateTimePicker
            // 
            PaydateTimePicker.Format = DateTimePickerFormat.Short;
            PaydateTimePicker.Location = new Point(243, 40);
            PaydateTimePicker.Name = "PaydateTimePicker";
            PaydateTimePicker.Size = new Size(250, 27);
            PaydateTimePicker.TabIndex = 1;
            // 
            // Confirmbutton
            // 
            Confirmbutton.Location = new Point(601, 36);
            Confirmbutton.Name = "Confirmbutton";
            Confirmbutton.Size = new Size(94, 29);
            Confirmbutton.TabIndex = 2;
            Confirmbutton.Text = "aceptar";
            Confirmbutton.UseVisualStyleBackColor = true;
            Confirmbutton.Click += Confirmbutton_Click;
            // 
            // SelectFinishDate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 189);
            Controls.Add(Confirmbutton);
            Controls.Add(PaydateTimePicker);
            Controls.Add(label1);
            Name = "SelectFinishDate";
            Text = "SelectFinishDate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker PaydateTimePicker;
        private Button Confirmbutton;
    }
}