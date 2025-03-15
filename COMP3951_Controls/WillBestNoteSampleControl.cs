using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// Will Otterbein
/// March 14, 2025
/// BestNote markdown editor custom control idea
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
        [Description("Set the fond of the markdown editor")]
        public Font MarkdownEditorFont
        {
            get => MarkDownEditorBox.Font;
            set { MarkDownEditorBox.Font = value; Invalidate(); }
        }

        /// <summary>
        /// Change the background color of the markdown editor.
        /// </summary>
        [Category("Will Custom Properties")]
        [Description("Set the background of the markdown editor")]
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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void WillOnFontChanged(object sender, FontSwitchedEventArgs e);

        public delegate void WillOnBackgroundChanged(object sender, BackgroundColorSwitchedEventArgs e);

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
        /// Font changed custom event.
        /// </summary>
        [Category("Will Events")]
        [Description("Event handler to handle the font changed event")]
        public event WillOnFontChanged? WillFontChanged;

        /// <summary>
        /// Font changed custom event.
        /// </summary>
        [Category("Will Events")]
        [Description("Event handler to handle the background changed event")]
        public event WillOnBackgroundChanged? WillBackgroundColorChanged;

        /// <summary>
        /// Will text changed custom event.
        /// </summary>
        /// <param name="e"></param>
        public virtual void WillOnTextChangedHandler(EventArgs e)
        {
            WillTextChanged?.Invoke(this, e);
        }

        /// <summary>
        /// Will text saved custom event.
        /// </summary>
        /// <param name="e"></param>
        public virtual void WillOnTextSavedHandler(EventArgs e)
        {
            // Invoke the event handler for the custom event
            WillTextSaved?.Invoke(this, e);
        }

        /// <summary>
        /// Will font changed event.
        /// </summary>
        /// <param name="e"></param>
        public virtual void WillOnFontChangedHandler(FontSwitchedEventArgs e)
        {
            WillFontChanged?.Invoke(this, e);
        }

        /// <summary>
        /// Will background color changed event.
        /// </summary>
        /// <param name="e"></param>
        public virtual void WillOnBackgroundColorChangedHandler(BackgroundColorSwitchedEventArgs e)
        {
            WillBackgroundColorChanged?.Invoke(this, e);
        }

        /// <summary>
        /// Override -- hide -- the default on text changed event.
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

        /// <summary>
        /// Event handler for the font switched button being clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnSwitchFontClicked(object sender, EventArgs e)
        {
            if (markdownFont.ShowDialog() == DialogResult.OK)
            {
                // Set the new font
                MarkDownEditorBox.Font = markdownFont.Font;
                // Invoke the event
                WillOnFontChangedHandler(new FontSwitchedEventArgs()
                {
                    NewFont = markdownFont.Font
                });
            }
        }

        /// <summary>
        /// Event handler for the background color switched button being clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnBackgroundColroChanged(object sender, EventArgs e)
        {
            if (markdownBackgroundColor.ShowDialog() == DialogResult.OK)
            {
                // Set the new background color
                MarkDownEditorBox.BackColor = markdownBackgroundColor.Color;
                // Invoke the event
                WillOnBackgroundColorChangedHandler(new BackgroundColorSwitchedEventArgs()
                {
                    NewColor = markdownBackgroundColor.Color
                });
            }
        }
    }

    /// <summary>
    /// Event args for Font switched event args.
    /// </summary>
    public class FontSwitchedEventArgs : EventArgs
    {
        public Font? NewFont { get; set; }
    }

    /// <summary>
    /// Event args for BackgroundColor switched event args.
    /// </summary>
    public class BackgroundColorSwitchedEventArgs : EventArgs
    {
        public Color NewColor { get; set; }
    }
}
