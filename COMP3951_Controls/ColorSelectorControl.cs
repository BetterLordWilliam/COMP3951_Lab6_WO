﻿using System.ComponentModel;
using System.Configuration;
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
        /// Custom color selector control constructor.
        /// </summary>
        public ColorSelectorControl()
        {
            InitializeComponent();
            _colorValue = Color.FromArgb(RedTrackBar.Value, GreenTrackBar.Value, BlueTrackBar.Value);
            ColorPanel.BackColor = _colorValue;
        }

        private Color _colorValue;

        /// <summary>
        /// Color value property.
        /// </summary>
        public Color ColorValue
        {
            get => _colorValue;
            set
            {
                _colorValue = value;
                // Set trackbars
                RedTrackBar.Value = value.R;
                GreenTrackBar.Value = value.G;
                BlueTrackBar.Value = value.B;
                // Set the panel color
                ColorPanel.BackColor = value;
                // Raise color changed event
                OnColorChanges(new ColorChangedEventArgs()
                {
                    NewColor = value,
                    RedValue = value.R,
                    GreenValue = value.G,
                    BlueValue = value.B
                });
                Invalidate();
            }
        }

        /// <summary>
        /// Custom delegate for the on color changed function.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void OnColorChanged(object sender, ColorChangedEventArgs e);

        /// <summary>
        /// Color changed event handler.
        /// </summary>
        [Category("Will Events")]
        [Description("Event handler to handle color changing")]
        public event OnColorChanged? ColorChanged;

        /// <summary>
        /// Color changes event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public virtual void OnColorChanges(ColorChangedEventArgs e)
        {
            ColorChanged?.Invoke(this, e);
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
                // Determine color from trackbar values
                Color mixedColor = Color.FromArgb(RedTrackBar.Value, GreenTrackBar.Value, BlueTrackBar.Value);
                ColorPanel.BackColor = mixedColor;
                ColorValue = mixedColor;
                OnColorChanges(new ColorChangedEventArgs()
                {
                    NewColor = mixedColor,
                    RedValue = RedTrackBar.Value,
                    GreenValue = GreenTrackBar.Value,
                    BlueValue = BlueTrackBar.Value
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error setting the color.");
            }
        }
    }

    /// <summary>
    /// Event args class, use this instead of casting.
    /// </summary>
    public class ColorChangedEventArgs : EventArgs
    {
        public Color NewColor { get; set; }
        public int RedValue { get; set; }
        public int GreenValue { get; set; }
        public int BlueValue { get; set; }
    }
}
