using Kakao1.Chats.UI.Views;
using Kakao1.Core.Names;
using Kakao1.Core.ViewServices;
using Kakao1.Friends.UI.Views;
using Kakao1.Login.UI.Views;
using Kakao1.Main.UI.Views;
using Kakao1.More.UI.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace Kakao1.Setting
{
    internal class ViewModules : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IViewable, LoginContent>(ContentNameManager.LoginContent);
            containerRegistry.RegisterSingleton<IViewable, MainContent>(ContentNameManager.MainContent);
            containerRegistry.RegisterSingleton<IViewable, MoreContent>(ContentNameManager.MoreContent);
            containerRegistry.RegisterSingleton<IViewable, FriendsContent>(ContentNameManager.FriendsContent);
            containerRegistry.RegisterSingleton<IViewable, ChatsContent>(ContentNameManager.ChatsContent);
        }
    }
}
