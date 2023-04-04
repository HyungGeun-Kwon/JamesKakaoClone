using Kakao1.Core.ViewServices;
using Kakao1.LayoutSupport.UI.Units;
using System.Windows;
using System.Windows.Controls;

namespace Kakao1.Friends.Favorites.UI.Units
{
    public class FavoriteBoxItem : ListBoxItem
    {
        static FavoriteBoxItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FavoriteBoxItem), new FrameworkPropertyMetadata(typeof(FavoriteBoxItem)));
        }
    }
}
