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
            button1 = new Button();
            willButton1 = new COMP3951_Controls.WillButton();
            colorSelectorControl1 = new COMP3951_Controls.ColorSelectorControl();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 60);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Button";
            button1.UseVisualStyleBackColor = true;
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
            colorSelectorControl1.Location = new Point(159, 12);
            colorSelectorControl1.Name = "colorSelectorControl1";
            colorSelectorControl1.Size = new Size(356, 202);
            colorSelectorControl1.TabIndex = 3;
            // 
            // TestingApplication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 225);
            Controls.Add(colorSelectorControl1);
            Controls.Add(willButton1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "TestingApplication";
            Text = "TestingApplication";
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private COMP3951_Controls.WillButton willButton1;
        private COMP3951_Controls.ColorSelectorControl colorSelectorControl1;
    }
}
