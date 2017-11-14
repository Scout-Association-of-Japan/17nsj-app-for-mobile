using _17NSJ;
using _17NSJ.iOS;
using _17NSJ.Views;
using Xamarin.Forms.Platform.iOS;

[assembly: Xamarin.Forms.ExportRenderer(typeof(TabBaseView), typeof(TabbedPageCustom))]
namespace _17NSJ.iOS
{
    public class TabbedPageCustom : TabbedRenderer
    {
        public TabbedPageCustom()
        {
            TabBar.UnselectedItemTintColor = new UIKit.UIColor(0.70f, 0.70f, 0.70f, 1.0f);
            TabBar.TintColor = UIKit.UIColor.White;
            TabBar.BarTintColor = new UIKit.UIColor(0.00f, 0.44f, 0.74f, 1.0f);
        }
    }
}
