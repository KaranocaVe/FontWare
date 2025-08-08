using System.Reactive.Linq;
using ReactiveUI;
using Avalonia.ReactiveUI;
using Avalonia;

namespace FontWare.GUI.ViewModels
{
    public class FontFilterViewModel: ViewModelBase
    {
        private Rect _bounds;
        private ObservableAsPropertyHelper<bool> _showLong;
        private ObservableAsPropertyHelper<bool> _showShort;

        #region Properties
        public Rect Bounds
        {
            get => _bounds;
            set => this.RaiseAndSetIfChanged(ref _bounds, value);
        }

        public bool ShowLong => _showLong.Value;
        public bool ShowShort => _showShort.Value;

        #endregion

        #region Constructor

        public FontFilterViewModel()
        {
            var widthObservable = this.WhenAnyValue(x => x.Bounds.Width)
                .Select(width => width > 520);

            widthObservable.ToProperty(this, x => x.ShowLong, out _showLong);

            widthObservable.Select(showLong => !showLong)
                .ToProperty(this, x => x.ShowShort, out _showShort);
        }

        #endregion
    }
}
