using Kakao1.Setting;
using System;

namespace Kakao1
{
    public class Starter
    {
        [STAThread]
        public static void Main(string[] args)
        {
            _ = new App()
                .AddInversionModule<ViewModules>()
                .WireViewViewModel<WireDataContext>()
                .Run();
        }
    }
}
