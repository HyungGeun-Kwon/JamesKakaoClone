using Kakao1.LayoutSupport.UI.Units;
using System.Windows;

namespace Kakao1.Friends.Favorites.UI.Units
{
    public class FavoriteBox : FriendsBox
    {
        protected override DependencyObject GetContainerForItemOverride()
        {
            return new FavoriteBoxItem();
        }
    }
}
