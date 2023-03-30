using Kakao1.Core.ViewServices;
using System.Windows;
using System.Windows.Controls;

namespace Kakao1.Login5.UI.Views
{
    public class TaskBarButton : Control
    {
        static TaskBarButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TaskBarButton), new FrameworkPropertyMetadata(typeof(TaskBarButton)));
        }
    }
}
