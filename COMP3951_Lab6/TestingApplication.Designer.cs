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
            bestFileResourceViewControl1 = new COMP3951_Controls.BestFileResourceViewControl();
            SuspendLayout();
            // 
            // willButton1
            // 
            willButton1.ButtonPrimary = Color.Gray;
            willButton1.ButtonPrimaryAlpha = 64;
            willButton1.ButtonSecondary = Color.DarkGray;
            willButton1.ButtonSecondaryAlpha = 64;
            willButton1.ButtonStyle = System.Drawing.Drawing2D.HatchStyle.DarkVertical;
            willButton1.Location = new Point(12, 12);
            willButton1.Name = "willButton1";
            willButton1.Size = new Size(110, 42);
            willButton1.TabIndex = 2;
            willButton1.Text = "My New Button";
            willButton1.UseVisualStyleBackColor = true;
            willButton1.WillButtonEvent += willButton1_WillEvent;
            // 
            // colorSelectorControl1
            // 
            colorSelectorControl1.ColorValue = Color.FromArgb(0, 0, 0);
            colorSelectorControl1.Location = new Point(159, 12);
            colorSelectorControl1.Name = "colorSelectorControl1";
            colorSelectorControl1.Size = new Size(356, 202);
            colorSelectorControl1.TabIndex = 3;
            colorSelectorControl1.ColorChanged += colorSelectorControl1_ColorChanged;
            // 
            // RedValueCapture
            // 
            RedValueCapture.Location = new Point(128, 35);
            RedValueCapture.Name = "RedValueCapture";
            RedValueCapture.ReadOnly = true;
            RedValueCapture.Size = new Size(38, 23);
            RedValueCapture.TabIndex = 4;
            RedValueCapture.Text = "0";
            // 
            // GreenValueCapture
            // 
            GreenValueCapture.Location = new Point(128, 93);
            GreenValueCapture.Name = "GreenValueCapture";
            GreenValueCapture.ReadOnly = true;
            GreenValueCapture.Size = new Size(38, 23);
            GreenValueCapture.TabIndex = 5;
            GreenValueCapture.Text = "0";
            // 
            // BlueValueCapture
            // 
            BlueValueCapture.Location = new Point(128, 157);
            BlueValueCapture.Name = "BlueValueCapture";
            BlueValueCapture.ReadOnly = true;
            BlueValueCapture.Size = new Size(38, 23);
            BlueValueCapture.TabIndex = 6;
            BlueValueCapture.Text = "0";
            // 
            // bestFileResourceViewControl1
            // 
            bestFileResourceViewControl1.FormattingEnabled = true;
            bestFileResourceViewControl1.Location = new Point(12, 60);
            bestFileResourceViewControl1.Name = "bestFileResourceViewControl1";
            bestFileResourceViewControl1.Size = new Size(110, 23);
            bestFileResourceViewControl1.TabIndex = 7;
            // 
            // TestingApplication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 225);
            Controls.Add(bestFileResourceViewControl1);
            Controls.Add(BlueValueCapture);
            Controls.Add(GreenValueCapture);
            Controls.Add(RedValueCapture);
            Controls.Add(colorSelectorControl1);
            Controls.Add(willButton1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
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
    }
}
