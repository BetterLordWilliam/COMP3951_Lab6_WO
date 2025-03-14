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
    }
}
