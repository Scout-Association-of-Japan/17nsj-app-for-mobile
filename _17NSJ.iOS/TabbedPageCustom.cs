using _17NSJ;
using _17NSJ.iOS;
using _17NSJ.Views;
using UIKit;
using Xamarin.Forms.Platform.iOS;

[assembly: Xamarin.Forms.ExportRenderer(typeof(TabBaseView), typeof(TabbedPageCustom))]
namespace _17NSJ.iOS
{
    public class TabbedPageCustom : TabbedRenderer
    {
        public TabbedPageCustom()
        {
            TabBar.UnselectedItemTintColor = UIKit.UIColor.White;
            TabBar.TintColor = new UIKit.UIColor(0.97f, 0.58f, 0.12f, 1.0f);
            TabBar.BarTintColor = new UIKit.UIColor(0.00f, 0.44f, 0.74f, 1.0f);

            if (TabBar.Items != null)
            {
                foreach (var t in TabBar.Items)
                {
                    var fontSize = new UITextAttributes() { Font = UIFont.BoldSystemFontOfSize(15)  };
                    t.SetTitleTextAttributes(fontSize, UIControlState.Normal);
                }
            }
        }
    }
}
