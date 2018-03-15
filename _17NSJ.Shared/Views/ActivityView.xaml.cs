using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using _17NSJ.Exceptions;
using _17NSJ.Models;
using _17NSJ.Services;
using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;

namespace _17NSJ.Views
{
    public partial class ActivityView : ContentPage
    {
        ObservableCollection<ActivityModel> originalActivityList;

        public ActivityView()
        {
            // トラッキングコード
            Analytics.TrackEvent("View", new Dictionary<string, string> { { "View", "ActivityView" } });

            InitializeComponent();
            GetActivitiesAsync();
        }

        private async void GetActivitiesAsync()
        {
            this.error.IsVisible = false;
            this.activityList.IsVisible = true;
            this.indicator.IsVisible = true;

            var service = new AppDataService();
            ObservableCollection<ActivityCategoryModel> categories;

            try
            {
                categories = await service.GetActivityCategoriesAsync();
                originalActivityList = await service.GetActivitiesAsync();
            }
            catch (OutOfServiceException)
            {
                this.error.IsVisible = true;
                this.activityList.IsVisible = false;
                this.categoryList.ItemsSource = null;
                this.activityList.ItemsSource = null;
                this.activityList.SeparatorVisibility = SeparatorVisibility.None;
                this.activityList.EndRefresh();
                this.indicator.IsVisible = false;
                return;
            }

            foreach (var act in originalActivityList)
            {
                var category = categories.Where(e => act.Category == e.Category).FirstOrDefault();
                act.Color = category.Color;
                act.CategoryName = category.CategoryName;

                //個別のサムネイルがなければカテゴリーごとのサムネイル
                if (string.IsNullOrEmpty(act.ThumbnailURL))
                {
                    act.ThumbnailURL = category.ThumbnailURL;
                }

                //待機可能であり、クローズしていなければ
                if(act.CanWaitable && !act.IsClosed)
                {
                    act.WaitingInfoBackgroundColor = "#F7931E";
                    act.WaitingInfoState = $"待ち時間：{act.WaitingTime}分";
                }

                //待機可能であり、クローズしているとき
                else if (act.CanWaitable && act.IsClosed)
                {
                    act.WaitingInfoBackgroundColor = "#CBCBCB";
                    act.WaitingInfoState = $"クローズ";
                }

                //待機可能ではない時、見えないがNullにならないために入れる
                else
                {
                    act.WaitingInfoBackgroundColor = "#F7931E";
                }
            }

            this.categoryList.ItemsSource = categories;
            this.activityList.ItemsSource = FilterList(this.searchBar.Text); 
            this.activityList.EndRefresh();
            this.indicator.IsVisible = false;
        }

        private void ListPulled(object sender, System.EventArgs e)
        {
            GetActivitiesAsync();
        }

        void SearchTextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            var control = sender as SearchBar;
            this.activityList.ItemsSource = FilterList(control.Text);
        }

        private void ItemSelected(object sender, ItemTappedEventArgs e)
        {
            this.activityList.SelectedItem = null;
            var act = e.Item as ActivityModel;

            if (act != null)
            {
                Navigation.PushAsync(new ActivityDetailView(act));
            }
        }

        void ReloadTapped(object sender, System.EventArgs e)
        {
            GetActivitiesAsync();
        }

        private ObservableCollection<ActivityModel> FilterList(string query)
        {
            // クエリ文字がなければオリジナルのリストをすべて返す
            if (string.IsNullOrEmpty(query))
            {
                return originalActivityList;
            }

            // タイトルか本文にクエリ文字が含まれるものを返す（本文はnullの可能性があるので最初にnullチェック)
            var filterdList = originalActivityList.Where(x => x.Title.Contains(query) || (x.Outline != null && x.Outline.Contains(query))).ToList();
            return new ObservableCollection<ActivityModel>(filterdList);
        }

        protected override bool OnBackButtonPressed()
        {
            Application.Current.MainPage = new TopView();
            return true;
        }
    }
}
