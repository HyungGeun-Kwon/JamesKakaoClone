using Kakao1.Core.ViewServices;
using System.Windows;

namespace Kakao1.Login.UI.Views
{
    public class LoginContent : PrismContent
    {
        static LoginContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LoginContent), new FrameworkPropertyMetadata(typeof(LoginContent)));
        }
    }
}
