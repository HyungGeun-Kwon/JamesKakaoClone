using Kakao1.Core.ViewServices;
using Kakao1.LayoutSupport.UI.Units;
using System.Windows;
using System.Windows.Controls;

namespace Kakao1.Friends.Birth.UI.Units
{
    public class BirthdaysBoxItem : ListBoxItem
    {
        static BirthdaysBoxItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(BirthdaysBoxItem), new FrameworkPropertyMetadata(typeof(BirthdaysBoxItem)));
        }
    }
}
