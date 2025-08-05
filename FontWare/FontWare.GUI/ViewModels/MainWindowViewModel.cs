using System.Collections.Generic;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using FluentIcons.Avalonia;
using FluentIcons.Common;
using FontWare.GUI.Views;
using SukiUI.Controls;

namespace FontWare.GUI.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    ObservableCollection<SukiSideMenuItem> _menuItems;
    public MainWindowViewModel()
    {
        _menuItems =
        [
            new SukiSideMenuItem
            {
                Header = "Font Library",
                Icon = new FluentIcon
                {
                    Icon = Icon.Grid,
                    IconVariant = IconVariant.Regular
                },
                PageContent = new FontLibrary()
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
