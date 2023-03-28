using System.Windows;
using System.Windows.Controls;

namespace Kakao1.Main.UI.Units
{
    public class VerticalMenumListItem : ListBoxItem
    {
        static VerticalMenumListItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(VerticalMenumListItem), new FrameworkPropertyMetadata(typeof(VerticalMenumListItem)));
        }
    }
}
