using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace _17NSJ.UITests
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void WelcomeTextIsDisplayed2()
        {
            app.Screenshot("Welcome screen.");
        }

        /// <summary>
        /// 初期起動時い表示される同意画面の各画面をテストします。
        /// </summary>
        [Test]
        public void AgreementView()
        {
            app.WaitForElement("InitAgreementView.Agreement");
            app.Screenshot("InitialAgreementView");
            app.Tap("InitAgreementView.Agreement");
            app.Screenshot("AgreementView");
            app.Back();
            app.Tap("InitAgreementView.Policy");
            app.Screenshot("PolicyView");
        }

        /// <summary>
        /// TopViewから各Viewへの繊維をテストします
        /// </summary>
        [Test]
        public async Task TopToEachViewAsync()
        {
            //同意画面に同意
            app.WaitForElement("InitAgreementView.Agreement");
            app.Tap("InitAgreementView.Agree");

            //TopViewの保存
            app.Screenshot("TopView");

            //NewsInfoView
            app.Tap("TopView.NewsInfo");
            app.WaitForNoElement(x => x.Marked("NewsInfoView.Indicator"), timeout: TimeSpan.FromSeconds(30));
            await Task.Delay(3000);
            app.Screenshot("NewsInfoView");
            TapHamburger();
            TapMasterItem("ホーム");

            //ScheduleView
            app.Tap("TopView.Schedule");
            app.WaitForNoElement(x => x.Marked("ScheduleView.Indicator"), timeout: TimeSpan.FromSeconds(30));
            await Task.Delay(3000);
            app.Screenshot("ScheduleView");
            TapHamburger();
            TapMasterItem("ホーム");

            //MapView
            app.Tap("TopView.Map");
            app.WaitForNoElement(x => x.Marked("MapView.Indicator"), timeout: TimeSpan.FromSeconds(30));
            await Task.Delay(3000);
            app.Screenshot("MapView");
            TapHamburger();
            TapMasterItem("ホーム");

            //AvtivityView
            app.Tap("TopView.Activity");
            app.WaitForNoElement(x => x.Marked("ActivityView.Indicator"), timeout: TimeSpan.FromSeconds(30));
            await Task.Delay(3000);
            app.Screenshot("ActivityView");
            TapHamburger();
            TapMasterItem("ホーム");

            //WeatherView
            app.Tap("TopView.Weather");
            app.WaitForNoElement(x => x.Marked("WeatherView.Indicator"), timeout: TimeSpan.FromSeconds(30));
            await Task.Delay(3000);
            app.Screenshot("WeatherView");
            TapHamburger();
            TapMasterItem("ホーム");

            //SocialView
            app.Tap("TopView.Social");
            app.Screenshot("SocialView");
            TapHamburger();
            TapMasterItem("ホーム");

            //MovieView
            app.Tap("TopView.Movie");
            app.WaitForNoElement(x => x.Marked("MovieView.Indicator"), timeout: TimeSpan.FromSeconds(30));
            await Task.Delay(3000);
            app.Screenshot("MovieView");
            TapHamburger();
            TapMasterItem("ホーム");

            //FriendshipView
            app.Tap("TopView.Friendship");
            app.Screenshot("FriendshipView");
            TapHamburger();
            TapMasterItem("ホーム");

            //DocumentView
            app.Tap("TopView.Document");
            app.WaitForNoElement(x => x.Marked("DocumentView.Indicator"), timeout: TimeSpan.FromSeconds(30));
            await Task.Delay(3000);
            app.Screenshot("DocumentView");
            TapHamburger();
            TapMasterItem("ホーム");

            //OutlineView
            app.Tap("TopView.Outline");
            app.Screenshot("OutlineView");
            TapHamburger();
            TapMasterItem("ホーム");

            //SettingView
            app.Tap("TopView.Setting");
            app.Screenshot("SettingView");
            TapHamburger();
            TapMasterItem("ホーム");
        }

        //ハンバーガーメニューをタップします。
        private void TapHamburger()
        {
            if (platform == Platform.Android)
            {
                app.Tap(x => x.Class("AppCompatImageButton").Marked("OK"));
            }
            else if (platform == Platform.iOS)
            {
                app.Tap(x => x.Marked("hamburger")); // Tap control marked with icon name
            }
        }

        /// <summary>
        /// MasterDetailViewで指定されたラベルのアイテムをタップします。
        /// </summary>
        /// <param name="MasterItemText">タップするアイテムのラベル</param>
        private void TapMasterItem(string MasterItemText)
        {           
            app.Tap(x => x.Marked("MasterDetailView.MasterItemLabel").Text(MasterItemText));
        }
    }
}
