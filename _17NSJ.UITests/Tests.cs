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

        /// <summary>
        /// 初期起動時に表示される同意画面の各画面をテストします。
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
            app.Back();
            app.Tap("InitAgreementView.Agree");

            //TopViewの保存
            app.Screenshot("TopView");
        }

        /// <summary>
        /// TopViewからNewsInfoViewへの遷移をテストします
        /// </summary>
        [Test]
        public async Task TopToNewsInfo()
        {
            //同意画面に同意
            app.WaitForElement("InitAgreementView.Agreement");
            app.Tap("InitAgreementView.Agree");

            app.Tap("TopView.NewsInfo");
            app.WaitForNoElement(x => x.Marked("NewsInfoView.Indicator"), timeout: TimeSpan.FromSeconds(30));
            await Task.Delay(3000);
            app.Screenshot("NewsInfoView");
            app.EnterText(x => x.Marked("NewsInfoView.SearchBar"), "テ");
            app.PressEnter();
            app.Screenshot("NewsInfoViewFiltered");
            app.Tap(x => x.Marked("NewsInfoView.ListView").Child(0));
            app.Screenshot("NewsInfoDetailView");
            app.Back();
            TapHamburger();
            TapMasterItem("ホーム");
        }

        /// <summary>
        /// TopViewからScheduleViewへの遷移をテストします
        /// </summary>
        [Test]
        public async Task TopToSchedule()
        {
            //同意画面に同意
            app.WaitForElement("InitAgreementView.Agreement");
            app.Tap("InitAgreementView.Agree");

            app.Tap("TopView.Schedule");
            app.WaitForNoElement(x => x.Marked("ScheduleView.Indicator"), timeout: TimeSpan.FromSeconds(30));
            await Task.Delay(3000);
            app.Screenshot("ScheduleView");
            TapHamburger();
            TapMasterItem("ホーム");
        }

        /// <summary>
        /// TopViewからMapViewへの遷移をテストします
        /// </summary>
        [Test]
        public async Task TopToMap()
        {
            //同意画面に同意
            app.WaitForElement("InitAgreementView.Agreement");
            app.Tap("InitAgreementView.Agree");

            app.Tap("TopView.Map");
            app.WaitForNoElement(x => x.Marked("MapView.Indicator"), timeout: TimeSpan.FromSeconds(30));
            await Task.Delay(3000);
            app.Screenshot("MapView");
            TapHamburger();
            TapMasterItem("ホーム");
        }

        /// <summary>
        /// TopViewからActivityViewへの遷移をテストします
        /// </summary>
        [Test]
        public async Task TopToActivity()
        {
            //同意画面に同意
            app.WaitForElement("InitAgreementView.Agreement");
            app.Tap("InitAgreementView.Agree");

            app.Tap("TopView.Activity");
            app.WaitForNoElement(x => x.Marked("ActivityView.Indicator"), timeout: TimeSpan.FromSeconds(30));
            await Task.Delay(3000);
            app.Screenshot("ActivityView");
            app.EnterText(x => x.Marked("ActivityView.SearchBar"), "K");
            app.PressEnter();
            app.Screenshot("ActivityViewFiltered");
            app.Tap(x => x.Marked("ActivityView.ListView").Child(0));
            app.Screenshot("ActivityDetailView");
            app.Back();
            TapHamburger();
            TapMasterItem("ホーム");
        }

        /// <summary>
        /// TopViewからWeatherViewへの遷移をテストします
        /// </summary>
        [Test]
        public async Task TopToWeather()
        {
            //同意画面に同意
            app.WaitForElement("InitAgreementView.Agreement");
            app.Tap("InitAgreementView.Agree");

            app.Tap("TopView.Weather");
            app.WaitForNoElement(x => x.Marked("WeatherView.Indicator"), timeout: TimeSpan.FromSeconds(30));
            await Task.Delay(3000);
            app.Screenshot("WeatherView");
            TapHamburger();
            TapMasterItem("ホーム");
        }

        /// <summary>
        /// TopViewからSocialViewへの遷移をテストします
        /// </summary>
        [Test]
        public void TopToSocial()
        {
            //同意画面に同意
            app.WaitForElement("InitAgreementView.Agreement");
            app.Tap("InitAgreementView.Agree");

            app.Tap("TopView.Social");
            app.Screenshot("SocialView");
            TapHamburger();
            TapMasterItem("ホーム");
        }

        /// <summary>
        /// TopViewからMovieViewへの遷移をテストします
        /// </summary>
        [Test]
        public async Task TopToMovie()
        {
            //同意画面に同意
            app.WaitForElement("InitAgreementView.Agreement");
            app.Tap("InitAgreementView.Agree");

            app.Tap("TopView.Movie");
            app.WaitForNoElement(x => x.Marked("MovieView.Indicator"), timeout: TimeSpan.FromSeconds(30));
            await Task.Delay(3000);
            app.Screenshot("MovieView");
            TapHamburger();
            TapMasterItem("ホーム");
        }

        /// <summary>
        /// TopViewからFriendshipViewへの遷移をテストします
        /// </summary>
        [Test]
        public void TopToFriendship()
        {
            //同意画面に同意
            app.WaitForElement("InitAgreementView.Agreement");
            app.Tap("InitAgreementView.Agree");

            app.Tap("TopView.Friendship");
            app.Screenshot("FriendshipView");
            TapHamburger();
            TapMasterItem("ホーム");
        }

        /// <summary>
        /// TopViewからDocumentViewへの遷移をテストします
        /// </summary>
        [Test]
        public async Task TopToDocument()
        {
            //同意画面に同意
            app.WaitForElement("InitAgreementView.Agreement");
            app.Tap("InitAgreementView.Agree");

            app.Tap("TopView.Document");
            app.WaitForNoElement(x => x.Marked("DocumentView.Indicator"), timeout: TimeSpan.FromSeconds(30));
            await Task.Delay(3000);
            app.Screenshot("DocumentView");
            TapHamburger();
            TapMasterItem("ホーム");
        }

        /// <summary>
        /// TopViewからOutlineViewへの遷移をテストします
        /// </summary>
        [Test]
        public void TopToOutline()
        {
            //同意画面に同意
            app.WaitForElement("InitAgreementView.Agreement");
            app.Tap("InitAgreementView.Agree");

            app.Tap("TopView.Outline");
            app.Screenshot("OutlineView");
            TapHamburger();
            TapMasterItem("ホーム");
        }

        /// <summary>
        /// TopViewからSettingViewへの遷移をテストします
        /// </summary>
        [Test]
        public void TopToSetting()
        {
            //同意画面に同意
            app.WaitForElement("InitAgreementView.Agreement");
            app.Tap("InitAgreementView.Agree");

            //SettingView
            app.Tap("TopView.Setting");
            app.Screenshot("SettingView");
            app.Tap(x => x.Marked("ライセンス"));
            app.Screenshot("LicenseView");
            app.Back();
            app.Tap(x => x.Marked("アプリケーション情報"));
            app.Screenshot("AppInfoView");
            app.Tap(x => x.Marked("クレジット"));
            app.Screenshot("CreditView");
            app.Back();
            app.Back();
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
