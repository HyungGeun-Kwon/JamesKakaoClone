using Kakao1.Core.Models;
using Kakao1.Core.Names;
using Kakao1.Core.ViewServices;
using Prism.Commands;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Regions;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace Kakao1.Main.Local.ViewModels
{
    public class MainContentViewModel : BindableBase, ILoadable
    {
        #region Fields For Property
        private List<MenuModel> _menus;
        private MenuModel _menu;
        #endregion

        private readonly IRegionManager _regionManager;
        private readonly IContainerProvider _containerProvider;

        public List<MenuModel> Menus { get => _menus; set => SetProperty(ref _menus, value); }

        public ICommand BtnLogoutClickCommand => new DelegateCommand(OnBtnLogoutClick);

        public MenuModel Menu
        {
            get => _menu;
            set { SetProperty(ref _menu, value); OnMenuChanged(value); }
        }

        public MainContentViewModel(IRegionManager regionManager, IContainerProvider containerProvider)
        {
            _regionManager = regionManager;
            _containerProvider = containerProvider;

            Menus = GetMenus();
        }

        public void OnLoaded(FrameworkElement prismContent, bool isFirst) { }

        private List<MenuModel> GetMenus()
        {
            return new List<MenuModel>()
            {
                new MenuModel().DataGetn(ContentNameManager.FriendsContent),
                new MenuModel().DataGetn(ContentNameManager.ChatsContent),
                new MenuModel().DataGetn(ContentNameManager.MoreContent),
            };
        }

        private void IViewableChange(string regionName, string contentName)
        {
            IRegion contentRegion = _regionManager.Regions[regionName];
            IViewable content = _containerProvider.Resolve<IViewable>(contentName);

            if (!contentRegion.Views.Contains(content))
            {
                contentRegion.Add(content);
            }

            contentRegion.Activate(content);
        }

        private void OnMenuChanged(MenuModel value)
        {
            IViewableChange(RegionNameManager.ContentRegion, value.Id);
        }

        private void OnBtnLogoutClick()
        {
            IViewableChange(RegionNameManager.MainRegion, ContentNameManager.LoginContent);
        }
    }
}
