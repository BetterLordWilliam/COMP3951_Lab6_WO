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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(85, 147);
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
            willButton1.Location = new Point(85, 99);
            willButton1.Name = "willButton1";
            willButton1.Size = new Size(110, 42);
            willButton1.TabIndex = 2;
            willButton1.Text = "My New Button";
            willButton1.UseVisualStyleBackColor = true;
            willButton1.WillButtonEvent += willButton1_WillEvent;
            // 
            // TestingApplication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 225);
            Controls.Add(willButton1);
            Controls.Add(button1);
            Margin = new Padding(2);
            Name = "TestingApplication";
            Text = "TestingApplication";
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private COMP3951_Controls.WillButton willButton1;
    }
}
