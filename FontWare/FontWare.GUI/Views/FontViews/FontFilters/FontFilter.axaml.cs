using Avalonia.Controls;
using FontWare.GUI.ViewModels;

namespace FontWare.GUI.Views.FontViews.FontFilters
{
    public partial class FontFilter : UserControl
    {
        public FontFilter()
        {
            InitializeComponent();
            DataContext = new FontFilterViewModel();
        }
    }
}
