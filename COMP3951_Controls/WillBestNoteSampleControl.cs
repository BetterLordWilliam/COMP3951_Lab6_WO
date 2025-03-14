using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP3951_Controls
{
    /// <summary>
    /// Markdown editor user control.
    /// </summary>
    public partial class WillBestNoteSampleControl : UserControl
    {
        public WillBestNoteSampleControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Change the font of the markdown editor.
        /// </summary>
        [Category("Will Custom Properties")]
        public Font MarkdownEditorFont
        {
            get => MarkDownEditorBox.Font;
            set { MarkDownEditorBox.Font = value; Invalidate(); }
        }

        /// <summary>
        /// Change the background color of the markdown editor.
        /// </summary>
        [Category("Will Custom Properties")]
        public Color MarkdownEditorBackColor
        {
            get => MarkDownEditorBox.BackColor;
            set { MarkDownEditorBox.BackColor = value; Invalidate(); }
        }

        /// <summary>
        /// Delegate to define the custom on text changed event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void WillOnTextChanged(object sender, EventArgs e);

        /// <summary>
        /// Delegate to define a custom event for on text saved event, hotkey combination.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void WillOnTextSaved(object sender, EventArgs e);

        /// <summary>
        /// Text changed custom event.
        /// </summary>
        [Category("Will Events")]
        [Description("Event handler to handle text written")]
        public event WillOnTextChanged? WillTextChanged;

        /// <summary>
        /// Text changed custom event.
        /// </summary>
        [Category("Will Events")]
        [Description("Event handler to handle text saved hotkey")]
        public event WillOnTextChanged? WillTextSaved;

        /// <summary>
        /// Will text changed custom event.
        /// </summary>
        /// <param name="e"></param>
        public virtual void WillOnTextChangedHandler(EventArgs e)
        {
            WillTextChanged?.Invoke(this, e);
        }

        /// <summary>
        /// Will text saved custom event/
        /// </summary>
        /// <param name="e"></param>
        public virtual void WillOnTextSavedHandler(EventArgs e)
        {
            // Invoke the event handler for the custom event
            WillTextSaved?.Invoke(this, e);
        }

        /// <summary>
        /// Override the defautl on text changed event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnTextChanged(object sender, EventArgs e)
        {
            // Invoke the event handler for the custom event
            WillOnTextChangedHandler(e);
        }

        /// <summary>
        /// Event handler for the save button being clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnSavedButtonClicked(object sender, EventArgs e)
        {
            WillOnTextSavedHandler(e);
        }
    }
}
