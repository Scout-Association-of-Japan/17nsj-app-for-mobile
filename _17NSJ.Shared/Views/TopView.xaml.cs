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

        private async void CheckUpdateAsync()
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
        private void NewsInfoClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MasterDetailView(typeof(NewsInfoView));
        }

        private void ScheduleClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MasterDetailView(typeof(ScheduleView));
        }

        private void MapClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MasterDetailView(typeof(MapView));
        }

        //2段目
        private void ActivityClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MasterDetailView(typeof(ActivityView));
        }

        private void WeatherClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MasterDetailView(typeof(WeatherView));
        }

        private void SocialClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MasterDetailView(typeof(SocialView));
        }

        //3段目
        private void MovieClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MasterDetailView(typeof(MovieView));
        }

        private void NewspaperClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MasterDetailView(typeof(NewspaperView));
        }

        private void FriendShipClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MasterDetailView(typeof(FriendShipView));
        }


        //4段目
        private void ShopClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MasterDetailView(typeof(ShopInfoView));
        }

        private void DocumentClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MasterDetailView(typeof(DocumentView));
        }

        private void DayVisitorClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MasterDetailView(typeof(DayVisitorView));
        }

        //5段目
        private void SponsorClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MasterDetailView(typeof(SponsorView));
        }

        private void OutlineClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MasterDetailView(typeof(OutlineView));
        }

        private void SettingClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MasterDetailView(typeof(SettingView));
        }
    }
}
