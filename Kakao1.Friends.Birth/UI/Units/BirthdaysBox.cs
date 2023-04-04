using Kakao1.LayoutSupport.UI.Units;
using System.Windows;

namespace Kakao1.Friends.Birth.UI.Units
{
    public class BirthdaysBox : FriendsBox
    {
        protected override DependencyObject GetContainerForItemOverride()
        {
            return new BirthdaysBoxItem();
        }
    }
}
