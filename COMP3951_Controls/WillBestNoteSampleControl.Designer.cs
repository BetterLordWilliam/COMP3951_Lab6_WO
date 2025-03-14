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
            SuspendLayout();
            // 
            // MarkDownEditorBox
            // 
            MarkDownEditorBox.Location = new Point(3, 45);
            MarkDownEditorBox.Name = "MarkDownEditorBox";
            MarkDownEditorBox.Size = new Size(1086, 788);
            MarkDownEditorBox.TabIndex = 0;
            MarkDownEditorBox.Text = "";
            MarkDownEditorBox.TextChanged += OnTextChanged;
            // 
            // ControlSavedStatusIndicator
            // 
            ControlSavedStatusIndicator.AutoSize = true;
            ControlSavedStatusIndicator.Location = new Point(3, 12);
            ControlSavedStatusIndicator.Name = "ControlSavedStatusIndicator";
            ControlSavedStatusIndicator.Size = new Size(0, 30);
            ControlSavedStatusIndicator.TabIndex = 1;
            // 
            // MarkdownEditorSaveText
            // 
            MarkdownEditorSaveText.Location = new Point(3, 2);
            MarkdownEditorSaveText.Name = "MarkdownEditorSaveText";
            MarkdownEditorSaveText.Size = new Size(131, 40);
            MarkdownEditorSaveText.TabIndex = 2;
            MarkdownEditorSaveText.Text = "Save Text";
            MarkdownEditorSaveText.UseVisualStyleBackColor = true;
            MarkdownEditorSaveText.Click += OnSavedButtonClicked;
            // 
            // WillBestNoteSampleControl
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MarkdownEditorSaveText);
            Controls.Add(ControlSavedStatusIndicator);
            Controls.Add(MarkDownEditorBox);
            Name = "WillBestNoteSampleControl";
            Size = new Size(1092, 836);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox MarkDownEditorBox;
        private Label ControlSavedStatusIndicator;
        private Button MarkdownEditorSaveText;
    }
}
