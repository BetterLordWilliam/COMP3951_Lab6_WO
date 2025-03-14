namespace COMP3951_Controls
{
    partial class ColorSelectorControl
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
            ColorPanel = new Panel();
            RedTrackBar = new TrackBar();
            GreenTrackBar = new TrackBar();
            BlueTrackBar = new TrackBar();
            BlueTrackBarLabel = new Label();
            GreenTrackBarLabel = new Label();
            RedTrackBarLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)RedTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GreenTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BlueTrackBar).BeginInit();
            SuspendLayout();
            // 
            // ColorPanel
            // 
            ColorPanel.BorderStyle = BorderStyle.Fixed3D;
            ColorPanel.Location = new Point(248, 3);
            ColorPanel.Name = "ColorPanel";
            ColorPanel.Size = new Size(105, 196);
            ColorPanel.TabIndex = 0;
            // 
            // RedTrackBar
            // 
            RedTrackBar.LargeChange = 4;
            RedTrackBar.Location = new Point(3, 25);
            RedTrackBar.Maximum = 255;
            RedTrackBar.Name = "RedTrackBar";
            RedTrackBar.Size = new Size(239, 45);
            RedTrackBar.TabIndex = 1;
            RedTrackBar.TickFrequency = 4;
            RedTrackBar.Scroll += OnColorTaskBarScrolled;
            // 
            // GreenTrackBar
            // 
            GreenTrackBar.LargeChange = 4;
            GreenTrackBar.Location = new Point(3, 82);
            GreenTrackBar.Maximum = 255;
            GreenTrackBar.Name = "GreenTrackBar";
            GreenTrackBar.Size = new Size(239, 45);
            GreenTrackBar.TabIndex = 2;
            GreenTrackBar.TickFrequency = 4;
            GreenTrackBar.Scroll += OnColorTaskBarScrolled;
            // 
            // BlueTrackBar
            // 
            BlueTrackBar.LargeChange = 4;
            BlueTrackBar.Location = new Point(3, 146);
            BlueTrackBar.Maximum = 255;
            BlueTrackBar.Name = "BlueTrackBar";
            BlueTrackBar.Size = new Size(239, 45);
            BlueTrackBar.TabIndex = 3;
            BlueTrackBar.TickFrequency = 4;
            BlueTrackBar.Scroll += OnColorTaskBarScrolled;
            // 
            // BlueTrackBarLabel
            // 
            BlueTrackBarLabel.AutoSize = true;
            BlueTrackBarLabel.Location = new Point(11, 128);
            BlueTrackBarLabel.Name = "BlueTrackBarLabel";
            BlueTrackBarLabel.Size = new Size(30, 15);
            BlueTrackBarLabel.TabIndex = 4;
            BlueTrackBarLabel.Text = "Blue";
            // 
            // GreenTrackBarLabel
            // 
            GreenTrackBarLabel.AutoSize = true;
            GreenTrackBarLabel.Location = new Point(11, 64);
            GreenTrackBarLabel.Name = "GreenTrackBarLabel";
            GreenTrackBarLabel.Size = new Size(38, 15);
            GreenTrackBarLabel.TabIndex = 5;
            GreenTrackBarLabel.Text = "Green";
            // 
            // RedTrackBarLabel
            // 
            RedTrackBarLabel.AutoSize = true;
            RedTrackBarLabel.Location = new Point(11, 7);
            RedTrackBarLabel.Name = "RedTrackBarLabel";
            RedTrackBarLabel.Size = new Size(27, 15);
            RedTrackBarLabel.TabIndex = 6;
            RedTrackBarLabel.Text = "Red";
            // 
            // ColorSelectorControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RedTrackBarLabel);
            Controls.Add(GreenTrackBarLabel);
            Controls.Add(BlueTrackBarLabel);
            Controls.Add(BlueTrackBar);
            Controls.Add(GreenTrackBar);
            Controls.Add(RedTrackBar);
            Controls.Add(ColorPanel);
            Name = "ColorSelectorControl";
            Size = new Size(356, 202);
            ((System.ComponentModel.ISupportInitialize)RedTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)GreenTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BlueTrackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel ColorPanel;
        private TrackBar RedTrackBar;
        private TrackBar GreenTrackBar;
        private TrackBar BlueTrackBar;
        private Label BlueTrackBarLabel;
        private Label GreenTrackBarLabel;
        private Label RedTrackBarLabel;
    }
}
