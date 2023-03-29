using System.Windows;
using System.Windows.Controls;

namespace Kakao1.LayoutSupport.UI.Units.Views
{
    public class TaskBarButton : Control
    {
        static TaskBarButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TaskBarButton), new FrameworkPropertyMetadata(typeof(TaskBarButton)));
        }
    }
}
