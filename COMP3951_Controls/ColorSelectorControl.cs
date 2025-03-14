using System.Runtime.Serialization;

/// Will Otterbein
/// March 13 2025
/// Custom Color selector control
namespace COMP3951_Controls
{
    /// <summary>
    /// Color selector control definition.
    /// </summary>
    public partial class ColorSelectorControl : UserControl
    {
        /// <summary>
        /// Declare the event handler that will be used for this event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void ColorSelectorControlScrolled(object sender, EventArgs e);

        public ColorSelectorControl()
        {
            InitializeComponent();
            ColorPanel.BackColor = Color.FromArgb(RedTrackBar.Value, GreenTrackBar.Value, BlueTrackBar.Value);
        }

        /// <summary>
        /// Event handler for the color scroll bars, update the color of the panel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnColorTaskBarScrolled(object sender, EventArgs e)
        {
            try
            {
                ColorPanel.BackColor = Color.FromArgb(RedTrackBar.Value, GreenTrackBar.Value, BlueTrackBar.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error setting the color.");
            }
        }
    }
}
