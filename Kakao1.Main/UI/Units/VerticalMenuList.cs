using System.Windows;
using System.Windows.Controls;

namespace Kakao1.Main.UI.Units
{
    public class VerticalMenuList : ListBox
    {
        static VerticalMenuList()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(VerticalMenuList), new FrameworkPropertyMetadata(typeof(VerticalMenuList)));
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new VerticalMenumListItem();
        }
    }
}
