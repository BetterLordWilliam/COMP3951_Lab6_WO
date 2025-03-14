using COMP3951_Controls;

namespace COMP3951_Lab6
{
    public partial class TestingApplication : Form
    {
        public TestingApplication()
        {
            InitializeComponent();
        }

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
    }
}
