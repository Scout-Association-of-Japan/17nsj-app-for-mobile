using System;
using System.Collections.Generic;
using _17NSJ.Interfaces;
using _17NSJ.Models;
using _17NSJ.Services;
using _17NSJ.Exceptions;
using Xamarin.Forms;
using Microsoft.AppCenter.Analytics;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace _17NSJ.Views
{
    public partial class TopView : ContentPage
    {
        public TopView()
        {
            // iOS用のSetUseSafeArea設定
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
            
            // トラッキングコード
            Analytics.TrackEvent("View", new Dictionary<string, string> { { "View", "TopView" } });

            InitializeComponent();
            CheckUpdateAsync();

            Xamarin.Forms.NavigationPage.SetHasNavigationBar(this, false);


        }

         async void CheckUpdateAsync()
        {
            MobileAppConfigModel config;
            try
            {
                config = await new AppDataService().GetAppConfigAsync();
            }
            catch(OutOfServiceException)
            {
                // サービス停止中の場合、何もしない
                return;
            }
            catch
            {
                await DisplayAlert("", "エラーが発生しました。しばらく経ってからもう一度お試しください。", "OK");
                return;
            }

            if (config.ForceUpdate)
            {
                if(Device.RuntimePlatform == Device.iOS)
                {
                    if (config.iOSVersion != DependencyService.Get<IAssemblyService>().GetVersionName())
                    {
                        await DisplayAlert("アップデートがあります。", "アプリを最新バージョンにアップデートしてください。", "ストアを開く");
                        Device.OpenUri(new Uri(config.iOSStoreURL));
                    }
                }

                if (Device.RuntimePlatform == Device.Android)
                {
                    if (config.DroidVersion != DependencyService.Get<IAssemblyService>().GetVersionName())
                    {
                        await DisplayAlert("アップデートがあります。", "アプリを最新バージョンにアップデートしてください。", "ストアを開く");
                        Device.OpenUri(new Uri(config.DroidStoreURL));
                    }
                }
            }
        }

        //1段目
        void NewsInfoClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MasterDetailView(typeof(ShopInfoView));
        }

        void ScheduleClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MasterDetailView(typeof(ScheduleView));
        }

        void MapClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MasterDetailView(typeof(MapView));
        }

        //2段目
        void ActivityClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MasterDetailView(typeof(ActivityView));
        }

        void WeatherClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MasterDetailView(typeof(WeatherView));
        }

        void SocialClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MasterDetailView(typeof(SocialView));
        }

        //3段目
        void MovieClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MasterDetailView(typeof(MovieView));
        }

        void NewspaperClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MasterDetailView(typeof(NewspaperView));
        }

        void FriendShipClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MasterDetailView(typeof(FriendShipView));
        }


        //4段目
        void ShopClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MasterDetailView(typeof(ShopInfoView));
        }

        void DocumentClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MasterDetailView(typeof(DocumentView));
        }

        void DayVisitorClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MasterDetailView(typeof(DayVisitorView));
        }

        //5段目
        void SponsorClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MasterDetailView(typeof(SponsorView));
        }

        void OutlineClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MasterDetailView(typeof(OutlineView));
        }

        void SettingClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MasterDetailView(typeof(SettingView));
        }
    }
}
