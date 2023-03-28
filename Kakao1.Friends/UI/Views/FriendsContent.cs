using Kakao1.Core.ViewServices;
using System.Windows;

namespace Kakao1.Friends.UI.Views
{
    public class FriendsContent : PrismContent
    {
        static FriendsContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FriendsContent), new FrameworkPropertyMetadata(typeof(FriendsContent)));
        }
    }
}
