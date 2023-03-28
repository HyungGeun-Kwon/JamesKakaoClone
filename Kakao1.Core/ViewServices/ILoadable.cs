using System.Windows;

namespace Kakao1.Core.ViewServices
{
    public interface ILoadable
    {
        void OnLoaded(FrameworkElement prismContent, bool isFirst);
    }
}
