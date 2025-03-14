namespace COMP3951_Lab6
{
    partial class TestingApplication
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            willButton1 = new COMP3951_Controls.WillButton();
            colorSelectorControl1 = new COMP3951_Controls.ColorSelectorControl();
            RedValueCapture = new TextBox();
            GreenValueCapture = new TextBox();
            BlueValueCapture = new TextBox();
            willBestNoteSampleControl1 = new COMP3951_Controls.WillBestNoteSampleControl();
            savedStatus = new Label();
            SuspendLayout();
            // 
            // willButton1
            // 
            willButton1.ButtonPrimary = Color.Gray;
            willButton1.ButtonPrimaryAlpha = 64;
            willButton1.ButtonSecondary = Color.DarkGray;
            willButton1.ButtonSecondaryAlpha = 64;
            willButton1.ButtonStyle = System.Drawing.Drawing2D.HatchStyle.DarkVertical;
            willButton1.Location = new Point(21, 24);
            willButton1.Margin = new Padding(5, 6, 5, 6);
            willButton1.Name = "willButton1";
            willButton1.Size = new Size(189, 84);
            willButton1.TabIndex = 2;
            willButton1.Text = "My New Button";
            willButton1.UseVisualStyleBackColor = true;
            willButton1.WillButtonEvent += willButton1_WillEvent;
            // 
            // colorSelectorControl1
            // 
            colorSelectorControl1.ColorValue = Color.FromArgb(0, 0, 0);
            colorSelectorControl1.Location = new Point(273, 24);
            colorSelectorControl1.Margin = new Padding(9, 12, 9, 12);
            colorSelectorControl1.Name = "colorSelectorControl1";
            colorSelectorControl1.Size = new Size(610, 404);
            colorSelectorControl1.TabIndex = 3;
            colorSelectorControl1.ColorChanged += colorSelectorControl1_ColorChanged;
            // 
            // RedValueCapture
            // 
            RedValueCapture.Location = new Point(219, 70);
            RedValueCapture.Margin = new Padding(5, 6, 5, 6);
            RedValueCapture.Name = "RedValueCapture";
            RedValueCapture.ReadOnly = true;
            RedValueCapture.Size = new Size(62, 35);
            RedValueCapture.TabIndex = 4;
            RedValueCapture.Text = "0";
            // 
            // GreenValueCapture
            // 
            GreenValueCapture.Location = new Point(219, 186);
            GreenValueCapture.Margin = new Padding(5, 6, 5, 6);
            GreenValueCapture.Name = "GreenValueCapture";
            GreenValueCapture.ReadOnly = true;
            GreenValueCapture.Size = new Size(62, 35);
            GreenValueCapture.TabIndex = 5;
            GreenValueCapture.Text = "0";
            // 
            // BlueValueCapture
            // 
            BlueValueCapture.Location = new Point(219, 314);
            BlueValueCapture.Margin = new Padding(5, 6, 5, 6);
            BlueValueCapture.Name = "BlueValueCapture";
            BlueValueCapture.ReadOnly = true;
            BlueValueCapture.Size = new Size(62, 35);
            BlueValueCapture.TabIndex = 6;
            BlueValueCapture.Text = "0";
            // 
            // willBestNoteSampleControl1
            // 
            willBestNoteSampleControl1.Location = new Point(21, 443);
            willBestNoteSampleControl1.MarkdownEditorBackColor = Color.FromArgb(255, 192, 192);
            willBestNoteSampleControl1.MarkdownEditorFont = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            willBestNoteSampleControl1.Name = "willBestNoteSampleControl1";
            willBestNoteSampleControl1.Size = new Size(1096, 844);
            willBestNoteSampleControl1.TabIndex = 7;
            willBestNoteSampleControl1.WillTextChanged += willBestNoteSampleControl1_OnTextChanged;
            willBestNoteSampleControl1.WillTextSaved += willBestNoteSampleControl1_OnTextSaved;
            // 
            // savedStatus
            // 
            savedStatus.AutoSize = true;
            savedStatus.Location = new Point(21, 398);
            savedStatus.Name = "savedStatus";
            savedStatus.Size = new Size(68, 30);
            savedStatus.TabIndex = 8;
            savedStatus.Text = "label1";
            // 
            // TestingApplication
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 1292);
            Controls.Add(savedStatus);
            Controls.Add(willBestNoteSampleControl1);
            Controls.Add(BlueValueCapture);
            Controls.Add(GreenValueCapture);
            Controls.Add(RedValueCapture);
            Controls.Add(colorSelectorControl1);
            Controls.Add(willButton1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "TestingApplication";
            Text = "TestingApplication";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private COMP3951_Controls.WillButton willButton1;
        private COMP3951_Controls.ColorSelectorControl colorSelectorControl1;
        private TextBox RedValueCapture;
        private TextBox GreenValueCapture;
        private TextBox BlueValueCapture;
        private COMP3951_Controls.BestFileResourceViewControl bestFileResourceViewControl1;
        private COMP3951_Controls.WillBestNoteSampleControl willBestNoteSampleControl1;
        private Label savedStatus;
    }
}
