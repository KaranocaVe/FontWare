using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace FontWare.GUI.ViewModels
{
    public class DataGridDebugViewModel : ViewModelBase
    {
        public class Font
        {
            public string Typeface { get; set; }
            public List<string> Styles { get; set; }
            public int StylesCount
            {
                get => Styles?.Count ?? 0;
            }
            public string Format { get; set; }
            public bool IsLocked { get; set; }
            public bool IsDownloadable { get; set; }
        }

        public ObservableCollection<Font> Fonts { get; set; }

        public DataGridDebugViewModel()
        {
            Fonts = new ObservableCollection<Font>
            {
                new()
                {
                    Typeface = "Arial",
                    Styles = new List<string>
                    {
                        "Regular",
                        "Bold",
                        "Italic"
                    },
                    Format = "TrueType",
                    IsLocked = false,
                    IsDownloadable = true
                },
                new()
                {
                    Typeface = "Times New Roman",
                    Styles = new List<string>
                    {
                        "Regular",
                        "Bold"
                    },
                    Format = "OpenType",
                    IsLocked = true,
                    IsDownloadable = false
                },
                new()
                {
                    Typeface = "Courier New",
                    Styles = new List<string>
                    {
                        "Regular"
                    },
                    Format = "TrueType",
                    IsLocked = false,
                    IsDownloadable = true
                },
                new()
                {
                    Typeface = "Verdana",
                    Styles = new List<string>
                    {
                        "Regular",
                        "Bold",
                        "Italic",
                        "Bold Italic"
                    },
                    Format = "OpenType",
                    IsLocked = false,
                    IsDownloadable = true
                },
                new()
                {
                    Typeface = "Tahoma",
                    Styles = new List<string>
                    {
                        "Regular",
                        "Bold"
                    },
                    Format = "TrueType",
                    IsLocked = true,
                    IsDownloadable = false
                },
                new()
                {
                    Typeface = "Georgia",
                    Styles = new List<string>
                    {
                        "Regular",
                        "Bold",
                        "Italic"
                    },
                    Format = "OpenType",
                    IsLocked = false,
                    IsDownloadable = true
                }
            };
        }
    }
}
