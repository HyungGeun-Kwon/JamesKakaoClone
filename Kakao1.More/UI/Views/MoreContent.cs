using Kakao1.Core.ViewServices;
using System.Windows;

namespace Kakao1.More.UI.Views
{
    public class MoreContent : PrismContent
    {
        static MoreContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MoreContent), new FrameworkPropertyMetadata(typeof(MoreContent)));
        }
    }
}
