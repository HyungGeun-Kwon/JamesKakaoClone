using Kakao1.Core.Names;
using Kakao1.Core.ViewServices;
using Prism.Commands;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Regions;
using System.Windows;
using System.Windows.Input;

namespace Kakao1.Login.Local.ViewModels
{
    public class LoginContentViewModel : BindableBase, ILoadable
    {
        private IRegionManager _regionManager;
        private IContainerProvider _containerProvider;

        public ICommand BtnLoginClickCommand => new DelegateCommand(OnBtnLoginClick);

        public LoginContentViewModel(IRegionManager regionManager, IContainerProvider containerProvider)
        {
            _regionManager = regionManager;
            _containerProvider = containerProvider;
        }

        public void OnLoaded(FrameworkElement prismContent, bool isFirst) { }

        private void OnBtnLoginClick()
        {
            IRegion region = _regionManager.Regions[RegionNameManager.MainRegion];
            IViewable content = _containerProvider.Resolve<IViewable>(ContentNameManager.MainContent);

            if (!region.Views.Contains(content))
            {
                region.Add(content);
            }
            region.Activate(content);
        }
    }
}
