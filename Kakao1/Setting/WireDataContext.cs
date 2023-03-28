using Kakao1.Chats.Local.ViewModels;
using Kakao1.Chats.UI.Views;
using Kakao1.Forms.Local.ViewModels;
using Kakao1.Forms.Views;
using Kakao1.Friends.Local.ViewModels;
using Kakao1.Friends.UI.Views;
using Kakao1.Helper;
using Kakao1.Login.Local.ViewModels;
using Kakao1.Login.UI.Views;
using Kakao1.Main.Local.ViewModels;
using Kakao1.Main.UI.Views;
using Kakao1.More.Local.ViewModels;
using Kakao1.More.UI.Views;
using Prism.Mvvm;

namespace Kakao1.Setting
{
    internal class WireDataContext : IViewViewModelWire
    {
        public void WireVVM()
        {
            ViewModelLocationProvider.Register<Kakao1Window, Kakao1ViewModel>();
            ViewModelLocationProvider.Register<LoginContent, LoginContentViewModel>();
            ViewModelLocationProvider.Register<MainContent, MainContentViewModel>();
            ViewModelLocationProvider.Register<MoreContent, MoreContentViewModel>();
            ViewModelLocationProvider.Register<FriendsContent, FriendsContentViewModel>();
            ViewModelLocationProvider.Register<ChatsContent, ChatsContentViewModel>();
        }
    }
}
