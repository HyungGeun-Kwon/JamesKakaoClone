using Kakao1.Core.ViewServices;
using System.Windows;

namespace Kakao1.Chats.UI.Views
{
    public class ChatsContent : PrismContent
    {
        static ChatsContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ChatsContent), new FrameworkPropertyMetadata(typeof(ChatsContent)));
        }
    }
}
