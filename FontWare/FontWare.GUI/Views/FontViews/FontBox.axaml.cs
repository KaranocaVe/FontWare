using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Styling;

namespace FontWare.GUI.Views
{
    public partial class FontBox : UserControl
    {
        public FontBox()
        {
            InitializeComponent();
        }

        protected override void OnAttachedToVisualTree(VisualTreeAttachmentEventArgs e)
        {
            base.OnAttachedToVisualTree(e);

            if (Application.Current != null)
            {
                Application.Current.ActualThemeVariantChanged += OnThemeChanged;
            }

            UpdateShadowColor();
        }

        protected override void OnDetachedFromVisualTree(VisualTreeAttachmentEventArgs e)
        {
            base.OnDetachedFromVisualTree(e);

            if (Application.Current != null)
            {
                Application.Current.ActualThemeVariantChanged -= OnThemeChanged;
            }
        }

        private void OnThemeChanged(object? sender, EventArgs e)
        {
            UpdateShadowColor();
        }

        private void UpdateShadowColor()
        {
            if (Application.Current is null) return;

            Color lightThemeColor = Colors.Gray;
            Color darkThemeColor = Colors.DimGray;

            ThemeVariant currentTheme = Application.Current.ActualThemeVariant;

            Color shadowColor = currentTheme == ThemeVariant.Dark ? darkThemeColor : lightThemeColor;

            BoxShadows newShadows = new(new BoxShadow
            {
                OffsetX = 0,
                OffsetY = 0.15,
                Blur = 8,
                Spread = -2,
                Color = shadowColor
            });

            RootPanel.BoxShadow = newShadows;
        }
    }
}
