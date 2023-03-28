using Kakao1.Core.Names;
using Kakao1.Core.ViewServices;
using Prism.Commands;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Regions;
using System.Windows;

namespace Kakao1.Forms.Local.ViewModels
{
    public class Kakao1ViewModel : BindableBase, ILoadable
    {
        private bool _isLoginView = true;
        private readonly IRegionManager _regionManager;
        private readonly IContainerProvider _containerProvider;

        public DelegateCommand BtnViewChangeClickCommand => new DelegateCommand(OnBtnViewChangeClick);

        public Kakao1ViewModel(IRegionManager regionManager, IContainerProvider containerProvider)
        {
            _regionManager = regionManager;
            _containerProvider = containerProvider;
        }

        public void OnLoaded(FrameworkElement content, bool isFirst)
        {
            ActivateContent(RegionNameManager.MainRegion, ContentNameManager.LoginContent);
            _isLoginView = true;
        }

        private void OnBtnViewChangeClick()
        {
            string contentName = _isLoginView ? ContentNameManager.MainContent : ContentNameManager.LoginContent;
            ActivateContent(RegionNameManager.MainRegion, contentName);
            _isLoginView = !_isLoginView;
        }
        private void ActivateContent(string regionName, string contentName)
        {
            IRegion region = _regionManager.Regions[regionName];
            IViewable content = _containerProvider.Resolve<IViewable>(contentName);

            if (!region.Views.Contains(content))
            {
                region.Add(content);
            }
            region.Activate(content);
        }
    }
}
