using COMP3951_Controls;

/// Will Otterbein
/// March 14, 2025
/// Testing application
namespace COMP3951_Lab6
{
    /// <summary>
    /// Define the saved statuses.
    /// </summary>
    enum SavedStatus
    {
        UNSAVED = 1,
        SAVED = 2
    }

    /// <summary>
    /// Testing application form.
    /// </summary>
    public partial class TestingApplication : Form
    {
        public TestingApplication()
        {
            InitializeComponent();
        }

        /// <summary>
        /// For the UI.
        /// </summary>
        internal static Dictionary<SavedStatus, string> savedStatusStrings = new ()
        {
            { SavedStatus.SAVED, "Saved" },
            { SavedStatus.UNSAVED, "Unsaved" }
        };

        /// <summary>
        /// Testing event handler for the Will Button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void willButton1_WillEvent(object sender, EventArgs e)
        {
            MessageBox.Show($"Will event was fired.\n\n");
        }

        /// <summary>
        /// Event handler for the color changed event raised by the custom color selector control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colorSelectorControl1_ColorChanged(object sender, ColorChangedEventArgs e)
        {
            RedValueCapture.Text = e.RedValue.ToString();
            GreenValueCapture.Text = e.GreenValue.ToString();
            BlueValueCapture.Text = e.BlueValue.ToString();
        }

        /// <summary>
        /// Event handler for the ontextchanged event raised by the markdown editor control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void willBestNoteSampleControl1_OnTextChanged(object sender, EventArgs e)
        {
            // Update the status to be unsaved by default
            // For the testing label
            if (savedStatus.Text !=  savedStatusStrings[SavedStatus.UNSAVED])
                savedStatus.Text = savedStatusStrings[SavedStatus.UNSAVED];
        }

        /// <summary>
        /// Event handler for the on text saved event raised by the custom markdown editor control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void willBestNoteSampleControl1_OnTextSaved(object sender, EventArgs e)
        {
            // Update the saved status of the control to be saved
            // For the testing label
            savedStatus.Text = savedStatusStrings[SavedStatus.SAVED];
            if (savedStatus.Text != savedStatusStrings[SavedStatus.SAVED])
                savedStatus.Text = savedStatusStrings[SavedStatus.SAVED];
        }
    
        /// <summary>
        /// Event handler for the on font changed event raised by the custom markdown editor control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void willBestNoteSampleControl1_OnFontChanghed(object sender, FontSwitchedEventArgs e)
        {
            // Show the font in the font preview
            // Modify the size to fit in the preview box
            // Some additional processing
            Font newFont = new Font(e.NewFont?.Name, 9, FontStyle.Regular);
            FontPreview.Font = newFont ?? e.NewFont;
        }

        /// <summary>
        /// Event handler for the on background changed event raised by the custom markdown editor control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void willBestNoteSampleControl1_OnBackgroundChanged(object sender, BackgroundColorSwitchedEventArgs e)
        {
            // Change the color in the color selector control
            colorSelectorControl1.ColorValue = e.NewColor;
        }
    }
}
