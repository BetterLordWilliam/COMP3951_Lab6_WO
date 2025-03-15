namespace COMP3951_Controls
{
    partial class WillBestNoteSampleControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MarkDownEditorBox = new RichTextBox();
            ControlSavedStatusIndicator = new Label();
            MarkdownEditorSaveText = new Button();
            button1 = new Button();
            button2 = new Button();
            markdownFont = new FontDialog();
            SuspendLayout();
            // 
            // MarkDownEditorBox
            // 
            MarkDownEditorBox.Location = new Point(2, 22);
            MarkDownEditorBox.Margin = new Padding(2);
            MarkDownEditorBox.Name = "MarkDownEditorBox";
            MarkDownEditorBox.Size = new Size(635, 396);
            MarkDownEditorBox.TabIndex = 0;
            MarkDownEditorBox.Text = "";
            MarkDownEditorBox.TextChanged += OnTextChanged;
            // 
            // ControlSavedStatusIndicator
            // 
            ControlSavedStatusIndicator.AutoSize = true;
            ControlSavedStatusIndicator.Location = new Point(2, 6);
            ControlSavedStatusIndicator.Margin = new Padding(2, 0, 2, 0);
            ControlSavedStatusIndicator.Name = "ControlSavedStatusIndicator";
            ControlSavedStatusIndicator.Size = new Size(0, 15);
            ControlSavedStatusIndicator.TabIndex = 1;
            // 
            // MarkdownEditorSaveText
            // 
            MarkdownEditorSaveText.Location = new Point(2, 1);
            MarkdownEditorSaveText.Margin = new Padding(2);
            MarkdownEditorSaveText.Name = "MarkdownEditorSaveText";
            MarkdownEditorSaveText.Size = new Size(76, 20);
            MarkdownEditorSaveText.TabIndex = 2;
            MarkdownEditorSaveText.Text = "Save Text";
            MarkdownEditorSaveText.UseVisualStyleBackColor = true;
            MarkdownEditorSaveText.Click += OnSavedButtonClicked;
            // 
            // button1
            // 
            button1.Location = new Point(83, 1);
            button1.Name = "button1";
            button1.Size = new Size(156, 20);
            button1.TabIndex = 3;
            button1.Text = "Switch Background Color";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(245, 0);
            button2.Name = "button2";
            button2.Size = new Size(82, 21);
            button2.TabIndex = 4;
            button2.Text = "Switch Font";
            button2.UseVisualStyleBackColor = true;
            button2.Click += OnSwitchFontClicked;
            // 
            // WillBestNoteSampleControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(MarkdownEditorSaveText);
            Controls.Add(ControlSavedStatusIndicator);
            Controls.Add(MarkDownEditorBox);
            Margin = new Padding(2);
            Name = "WillBestNoteSampleControl";
            Size = new Size(637, 418);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox MarkDownEditorBox;
        private Label ControlSavedStatusIndicator;
        private Button MarkdownEditorSaveText;
        private Button button1;
        private Button button2;
        private FontDialog markdownFont;
    }
}
