using _17NSJ.iOS.Renderer;
using _17NSJ.Controls;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomIndicatorWebView), typeof(CustomIndicatorWebViewRenderer))]
namespace _17NSJ.iOS.Renderer
{
    public class CustomIndicatorWebViewRenderer : WebViewRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            // 背景を透過
            this.Opaque = false;
            this.BackgroundColor = UIColor.Clear;
        }
    }
}
