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
            FontPreview = new RichTextBox();
            SuspendLayout();
            // 
            // willButton1
            // 
            willButton1.ButtonPrimary = Color.Gray;
            willButton1.ButtonPrimaryAlpha = 64;
            willButton1.ButtonSecondary = Color.DarkGray;
            willButton1.ButtonSecondaryAlpha = 64;
            willButton1.ButtonStyle = System.Drawing.Drawing2D.HatchStyle.DarkVertical;
            willButton1.Location = new Point(57, 82);
            willButton1.Name = "willButton1";
            willButton1.Size = new Size(110, 42);
            willButton1.TabIndex = 2;
            willButton1.Text = "My New Button";
            willButton1.UseVisualStyleBackColor = true;
            willButton1.WillButtonEvent += willButton1_WillEvent;
            // 
            // colorSelectorControl1
            // 
            colorSelectorControl1.ColorValue = Color.FromArgb(150, 0, 0);
            colorSelectorControl1.Location = new Point(286, 12);
            colorSelectorControl1.Margin = new Padding(5, 6, 5, 6);
            colorSelectorControl1.Name = "colorSelectorControl1";
            colorSelectorControl1.Size = new Size(356, 202);
            colorSelectorControl1.TabIndex = 3;
            colorSelectorControl1.ColorChanged += colorSelectorControl1_ColorChanged;
            // 
            // RedValueCapture
            // 
            RedValueCapture.Location = new Point(255, 35);
            RedValueCapture.Name = "RedValueCapture";
            RedValueCapture.ReadOnly = true;
            RedValueCapture.Size = new Size(38, 23);
            RedValueCapture.TabIndex = 4;
            RedValueCapture.Text = "0";
            // 
            // GreenValueCapture
            // 
            GreenValueCapture.Location = new Point(255, 93);
            GreenValueCapture.Name = "GreenValueCapture";
            GreenValueCapture.ReadOnly = true;
            GreenValueCapture.Size = new Size(38, 23);
            GreenValueCapture.TabIndex = 5;
            GreenValueCapture.Text = "0";
            // 
            // BlueValueCapture
            // 
            BlueValueCapture.Location = new Point(255, 157);
            BlueValueCapture.Name = "BlueValueCapture";
            BlueValueCapture.ReadOnly = true;
            BlueValueCapture.Size = new Size(38, 23);
            BlueValueCapture.TabIndex = 6;
            BlueValueCapture.Text = "0";
            // 
            // willBestNoteSampleControl1
            // 
            willBestNoteSampleControl1.Location = new Point(12, 236);
            willBestNoteSampleControl1.Margin = new Padding(1);
            willBestNoteSampleControl1.MarkdownEditorBackColor = Color.FromArgb(255, 192, 192);
            willBestNoteSampleControl1.MarkdownEditorFont = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            willBestNoteSampleControl1.Name = "willBestNoteSampleControl1";
            willBestNoteSampleControl1.Size = new Size(634, 422);
            willBestNoteSampleControl1.TabIndex = 7;
            willBestNoteSampleControl1.WillTextChanged += willBestNoteSampleControl1_OnTextChanged;
            willBestNoteSampleControl1.WillTextSaved += willBestNoteSampleControl1_OnTextSaved;
            willBestNoteSampleControl1.WillFontChanged += willBestNoteSampleControl1_OnFontChanghed;
            willBestNoteSampleControl1.WillBackgroundColorChanged += willBestNoteSampleControl1_OnBackgroundChanged;
            // 
            // savedStatus
            // 
            savedStatus.AutoSize = true;
            savedStatus.Location = new Point(12, 203);
            savedStatus.Margin = new Padding(2, 0, 2, 0);
            savedStatus.Name = "savedStatus";
            savedStatus.Size = new Size(38, 15);
            savedStatus.TabIndex = 8;
            savedStatus.Text = "label1";
            // 
            // FontPreview
            // 
            FontPreview.Location = new Point(255, 203);
            FontPreview.MaxLength = 24;
            FontPreview.Name = "FontPreview";
            FontPreview.ReadOnly = true;
            FontPreview.ScrollBars = RichTextBoxScrollBars.None;
            FontPreview.Size = new Size(93, 29);
            FontPreview.TabIndex = 9;
            FontPreview.Text = "Font Preview";
            // 
            // TestingApplication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 668);
            Controls.Add(FontPreview);
            Controls.Add(savedStatus);
            Controls.Add(willBestNoteSampleControl1);
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
        private COMP3951_Controls.WillBestNoteSampleControl willBestNoteSampleControl1;
        private Label savedStatus;
        private RichTextBox FontPreview;
    }
}
