using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// Will Otterbein
/// March 13, 2025
/// `Invalidate()` used to refresh the design view and all controls inside -- Tom Welch.
/// 
namespace COMP3951_Controls
{
    /// <summary>
    /// Will's custom button.
    /// </summary>
    [DesignerCategory("Will Control")]
    public partial class WillButton: Button
    {
        /// <summary>
        /// WillButton custom control with properties and a new event to override onclick.
        /// </summary>
        public WillButton()
        {
            InitializeComponent();
        }

        private Color _buttonPrimary = Color.Gray;
        private Color _buttonSecondary = Color.DarkGray;
        private int _buttonPrimaryAlpha = 64;
        private int _buttonSecondaryAlpha = 64;
        private HatchStyle _customHatchStyle = HatchStyle.DarkVertical;

        /// <summary>
        /// Custom event handler declared as a delegate.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void WillButtonEventHandler(object sender, EventArgs e);

        /// <summary>
        /// Property for the button style.
        /// </summary>
        [Category("Will Properties"),
        Description("Button Pattern Style")]
        public HatchStyle ButtonStyle
        {
            get => _customHatchStyle;
            set { _customHatchStyle = value; Invalidate(); }
        }

        /// <summary>
        /// Button Secondary property.
        /// </summary>
        [Category("Will Properties"),
        Description("Button Primary Color")]
        public Color ButtonPrimary
        {
            get => _buttonPrimary;
            set { _buttonPrimary = value; Invalidate(); }
        }

        /// <summary>
        /// Button secondary property.
        /// </summary>
        [Category("Will Properties"),
        Description("Button Secondary Color")]
        public Color ButtonSecondary
        {
            get => _buttonSecondary;
            set { _buttonSecondary = value; Invalidate(); }
        }

        /// <summary>
        /// Button primary transparency property.
        /// </summary>
        [Category("Will Properties"),
        Description("Button Primary Color Transparency")]
        public int ButtonPrimaryAlpha
        {
            get => _buttonPrimaryAlpha;
            set { _buttonPrimaryAlpha = value; Invalidate(); }
        }

        /// <summary>
        /// Button secondary transparency property.
        /// </summary>
        [Category("Will Properties"),
        Description("Button Secondary Color Transparency")]
        public int ButtonSecondaryAlpha
        {
            get => _buttonSecondaryAlpha;
            set { _buttonSecondaryAlpha = value; Invalidate(); }
        }

        /// <summary>
        /// Override the existing Text property.
        /// </summary>
        [Category("Will Properties"),
        Browsable(true),
        Description("Set the text that appears on the button"),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get => base.Text;
            set { base.Text = value; Invalidate(); }
        }

        /// <summary>
        /// Declare the event from the delegate type and add it to the property window.
        /// </summary>
        [Category("Action"),
        Description("Will Custom Click Event")]
        public event WillButtonEventHandler? WillButtonEvent;

        protected virtual void OnWillButtonEvent(EventArgs e)
        {
            // Only invoke the event if it is not null
            // Do nothing by default
            if (WillButtonEvent is null)
                return;
            WillButtonEvent(this, e);
        }

        /// <summary>
        /// override the mouse button click event.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseClick(MouseEventArgs e)
        {
            OnWillButtonEvent(e);
            Invalidate();
        }

        /// <summary>
        /// WillButton control paint.
        /// </summary>
        /// <param name="pe"></param>
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            try
            {
                // Pain the button using the two colors & transparencies
                Color c1 = Color.FromArgb(_buttonPrimaryAlpha, _buttonPrimary);
                Color c2 = Color.FromArgb(_buttonSecondaryAlpha, _buttonSecondary);
                using HatchBrush b = new (_customHatchStyle, c1, c2);
                    pe.Graphics.FillRectangle(b, ClientRectangle);
            }
            catch (Exception ex)
            {
                // Show error message
                MessageBox.Show($"There was an error drawing the custom component {nameof(WillButton)}\n\n{ex.Message}");
            }
        }
    }
}
