using Kakao1.Core.ViewServices;
using System.Windows;

namespace Kakao1.Forms.Views
{
    public class Kakao1Window : PrismWindow
    {
        static Kakao1Window()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Kakao1Window), new FrameworkPropertyMetadata(typeof(Kakao1Window)));
        }
    }
}
