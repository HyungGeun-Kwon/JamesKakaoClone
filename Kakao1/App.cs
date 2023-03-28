using Kakao1.Forms.Views;
using Kakao1.Helper;
using Prism.Ioc;
using System.Windows;

namespace Kakao1
{
    internal class App : PrismApplicationHelper
    {
        protected override Window CreateShell()
        {
            return new Kakao1Window();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}
