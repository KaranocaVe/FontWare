using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using FontWare.GUI.ViewModels;

namespace FontWare.GUI.Views
{
    public partial class FontLibrary3 : UserControl
    {
        public FontLibrary3()
        {
            InitializeComponent();
            DataContext = new DataGridDebugViewModel();
        }
    }
}
