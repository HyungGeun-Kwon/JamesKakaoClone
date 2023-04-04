using Kakao1.Core.Names;
using Kakao1.Core.ViewServices;
using Prism.Commands;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Regions;
using System.Windows;
using System.Windows.Input;

namespace Kakao1.Friends.Local.ViewModels
{
    public class FriendsContentViewModel : BindableBase, ILoadable
    {
        private IRegionManager _regionManager;
        private IContainerProvider _containerProvider;

        public FriendsContentViewModel(IRegionManager regionManager, IContainerProvider containerProvider)
        {
            _regionManager = regionManager;
            _containerProvider = containerProvider;
        }

        public void OnLoaded(FrameworkElement prismContent, bool isFirst) { }
    }
}
