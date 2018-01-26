using Xamarin.Forms;
using _17NSJ.Views;
using _17NSJ.Services;
using _17NSJ.Interfaces;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Push;
using _17NSJ.Constants;
using System.Linq;

namespace _17NSJ
{
    public partial class App : Application
    {

        static App()
        {
            Push.PushNotificationReceived += OnPushNotificationReceived;
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new TopView())
            {
                BarBackgroundColor = new Color(0.00, 0.44, 0.74),
                BarTextColor = Color.White
            };
        }

        //使うときは(Application.Current as App).Token
        public string Token { get; set; }

        protected override void OnStart()
        {
            // App Centerのイニシャライズ
            AppCenter.Start($"ios={SecretConstants.AppCenteriOS};" + $"android={SecretConstants.AppCenterDroid}", typeof(Analytics), typeof(Crashes), typeof(Push));

            // TODO: プッシュ通知の活性・不活性
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        static void OnPushNotificationReceived(object sender, PushNotificationReceivedEventArgs e)
        {
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() =>
            {
                var message = e.Message;
                if (e.CustomData != null && e.CustomData.Count > 0)
                {
                    message += "\nCustom data = {" + string.Join(",", e.CustomData.Select(kv => kv.Key + "=" + kv.Value)) + "}";
                }
                Current.MainPage.DisplayAlert(e.Title, message, "OK");
            });
        }
    }
}
