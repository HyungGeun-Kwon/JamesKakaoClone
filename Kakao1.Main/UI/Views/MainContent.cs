using Kakao1.Core.ViewServices;
using System.Windows;

namespace Kakao1.Main.UI.Views
{
    public class MainContent : PrismContent
    {
        static MainContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MainContent), new FrameworkPropertyMetadata(typeof(MainContent)));
        }
    }
}