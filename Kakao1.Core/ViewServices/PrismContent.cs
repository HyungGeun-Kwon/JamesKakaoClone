using Prism.Mvvm;
using System.Windows;
using System.Windows.Controls;

namespace Kakao1.Core.ViewServices
{
    public class PrismContent : ContentControl, IViewable
    {
        private bool _isFirstLoad = true;

        public FrameworkElement View { get; set; }

        public PrismContent()
        {
            View = this;
            ViewModelLocationProvider.AutoWireViewModelChanged(this, OnAutoWireViewModelChanged);
            Loaded += PrismContent_Loaded;
        }

        private void PrismContent_Loaded(object sender, RoutedEventArgs e)
        {
            if (DataContext is ILoadable loadable)
            {
                loadable.OnLoaded(this, _isFirstLoad);
                _isFirstLoad = false;
            }
        }

        private void OnAutoWireViewModelChanged(object arg1, object arg2)
        {
            if (arg1 is FrameworkElement fe)
            {
                fe.DataContext = arg2;
            }
        }
    }
}