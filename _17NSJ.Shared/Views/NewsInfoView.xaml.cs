using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using _17NSJ.Constants;
using _17NSJ.Exceptions;
using _17NSJ.Models;
using _17NSJ.Services;
using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;

namespace _17NSJ.Views
{
    public partial class NewsInfoView : ContentPage
    {
        ObservableCollection<NewsInfoModel> originalNewsInfoList;

        public NewsInfoView()
        {
            // トラッキングコード
            Analytics.TrackEvent("View", new Dictionary<string, string> { { "View", "NewsInfoView" } });
            
            InitializeComponent();
            GetNewsAsync();
        }

        private async void GetNewsAsync()
        {
            this.error.IsVisible = false;
            this.indicator.IsVisible = true;

            var service = new AppDataService();
            ObservableCollection<NewsInfoCategoryModel> categories;

            try
            {
                categories = await service.GetNewsCategoriesAsync();
                originalNewsInfoList = await service.GetNewsAsync();
            }
            catch(OutOfServiceException)
            {
                this.error.IsVisible = true;
                this.categoryList.ItemsSource = null;
                this.newsInfoList.ItemsSource = null;
                this.newsInfoList.SeparatorVisibility = SeparatorVisibility.None;
                this.newsInfoList.EndRefresh();
                this.indicator.IsVisible = false;
                return;
            }


            foreach(var news in originalNewsInfoList)
            {
                var category = categories.Where(e=>  news.Category == e.Category).FirstOrDefault();
                news.Color = category.Color;
                news.CategoryName = category.CategoryName;

                if(string.IsNullOrEmpty(news.ThumbnailURL))
                {
                    news.ThumbnailURL = category.ThumbnailURL;
                }
            }

            this.categoryList.ItemsSource = categories;
            this.newsInfoList.ItemsSource = FilterList(this.searchBar.Text);          
            this.newsInfoList.EndRefresh();
            this.indicator.IsVisible = false;
        }

        private void ListPulled(object sender, System.EventArgs e)
        {
            GetNewsAsync();
        }

        private void ItemSelected(object sender, ItemTappedEventArgs e)
        {
            var news = e.Item as NewsInfoModel;

            if (news != null)
            {
                Navigation.PushAsync(new NewsInfoDetailView(news));
            }
        }

        void SearchTextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            var control = sender as SearchBar;
            this.newsInfoList.ItemsSource  = FilterList(control.Text);
        }

        void ReloadTapped(object sender, System.EventArgs e)
        {
           GetNewsAsync();
        }

        private ObservableCollection<NewsInfoModel> FilterList(string query)
        {
            // クエリ文字がなければオリジナルのリストをすべて返す
            if(string.IsNullOrEmpty(query))
            {
                return originalNewsInfoList;
            }

            // タイトルか本文にクエリ文字が含まれるものを返す（本文はnullの可能性があるので最初にnullチェック)
            var filterdList = originalNewsInfoList.Where(x => x.Title.Contains(query) || (x.Outline != null &&x.Outline.Contains(query))).ToList();
            return new ObservableCollection<NewsInfoModel>(filterdList);
        }
    }
}
