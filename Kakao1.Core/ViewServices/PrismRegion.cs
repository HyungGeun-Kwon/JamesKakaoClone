using Prism.Regions;
using System.Windows;
using System.Windows.Controls;

namespace Kakao1.Core.ViewServices
{
    public class PrismRegion : ContentControl
    {
        public static readonly DependencyProperty RegionNameProperty =
            DependencyProperty.Register(
                "RegionName",
                typeof(string),
                typeof(PrismRegion),
                new PropertyMetadata(string.Empty, OnRegionNameChanged));

        public string RegionName
        {
            get { return (string)GetValue(RegionNameProperty); }
            set { SetValue(RegionNameProperty, value); }
        }

        private static void OnRegionNameChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            string newRegionName = e.NewValue as string;
            if (!(d is PrismRegion)) { return; }
            if (string.IsNullOrEmpty(newRegionName)) { return; }

            IRegionManager regionMan = RegionManager.GetRegionManager(Application.Current.MainWindow);
            RegionManager.SetRegionName((PrismRegion)d, newRegionName);
            RegionManager.SetRegionManager(d, regionMan);
        }

    }
}
