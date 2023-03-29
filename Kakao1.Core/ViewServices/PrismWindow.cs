using Prism.Mvvm;
using System.Windows;

namespace Kakao1.Core.ViewServices
{
    public class PrismWindow : Window
    {
        private bool _isFirstLoad = true;
        public PrismWindow()
        {
            ViewModelLocationProvider.AutoWireViewModelChanged(this, OnAutoWireViewModelChanged);
            Loaded += PrismWindow_Loaded;
        }

        private void PrismWindow_Loaded(object sender, RoutedEventArgs e)
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