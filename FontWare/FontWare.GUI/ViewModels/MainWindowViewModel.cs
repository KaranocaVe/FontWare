using System.Collections.ObjectModel;
using FluentIcons.Avalonia;
using FluentIcons.Common;
using FontWare.GUI.Views;
using ReactiveUI;
using SukiUI.Controls;

namespace FontWare.GUI.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<SukiSideMenuItem> _menuItems;
        public ObservableCollection<SukiSideMenuItem> MenuItems
        {
            get => _menuItems;
            set => this.RaiseAndSetIfChanged(ref _menuItems, value);
        }
        public MainWindowViewModel()
        {
            _menuItems =
            [
                new SukiSideMenuItem
                {
                    Header = "Font Library1",
                    Icon = new FluentIcon
                    {
                        Icon = Icon.Grid,
                        IconVariant = IconVariant.Regular
                    },
                    PageContent = new FontLibrary()
                },
                new SukiSideMenuItem
                {
                    Header = "Font Library2",
                    Icon = new FluentIcon
                    {
                        Icon = Icon.Grid,
                        IconVariant = IconVariant.Regular
                    },
                    PageContent = new FontLibrary2()
                },
                new SukiSideMenuItem
                {
                    Header = "Font Library3",
                    Icon = new FluentIcon
                    {
                        Icon = Icon.Grid,
                        IconVariant = IconVariant.Regular
                    },
                    PageContent = new FontLibrary3()
                },

                new SukiSideMenuItem
                {
                    Header = "Settings",
                    Icon = new FluentIcon
                    {
                        Icon = Icon.Settings,
                        IconVariant = IconVariant.Regular
                    },
                    PageContent = new Settings()
                }
            ];
        }
    }
}
