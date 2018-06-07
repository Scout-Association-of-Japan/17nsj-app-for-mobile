using System;
using System.Collections.Generic;
using System.Linq;
using _17NSJ.Constants;
using CarouselView.FormsPlugin.iOS;
using Foundation;
using Lottie.Forms.iOS.Renderers;
using UIKit;

namespace _17NSJ.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override UIWindow Window { get; set; }

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ja-JP");

            // Code for starting up the Xamarin Test Cloud Agent
            #if ENABLE_TEST_CLOUD
                Xamarin.Calabash.Start();
            #endif

            if (Window == null)
            {
                Window = new UIWindow(frame: UIScreen.MainScreen.Bounds);
                var initialViewController = new SplashViewController();
                Window.RootViewController = initialViewController;
                Window.MakeKeyAndVisible();

                return true;
            }
            else
            {
                global::Xamarin.Forms.Forms.Init();
                AnimationViewRenderer.Init();
                XamForms.Controls.iOS.Calendar.Init();
                CarouselViewRenderer.Init();
                Xamarin.FormsGoogleMaps.Init(SecretConstants.iOSGoogleMapAPIKey);
                LoadApplication(new App());
                return base.FinishedLaunching(app, options);
            }
        }

        public override void OnActivated(UIApplication uiApplication)
        {
            base.OnActivated(uiApplication);
            uiApplication.ApplicationIconBadgeNumber = 0;
        }
    }
}
