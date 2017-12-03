using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using _17NSJ.Constants;
using _17NSJ.Models;
using _17NSJ.Services;
using Xamarin.Forms;

namespace _17NSJ.Views
{
    public partial class NewsInfoView : ContentPage
    {
        public NewsInfoView()
        {
            InitializeComponent();
            GetNewsAsync();
        }

        private async void GetNewsAsync()
        {
            this.indicator.IsVisible = true;

            var service = new AppDataService();
            var categories = await service.GetNewsCategoriesAsync();
            var newslist = await service.GetNewsAsync();

            foreach(var news in newslist)
            {
                var category = categories.Where(e=>  news.Category == e.Category).FirstOrDefault();
                news.Color = category.Color;
                news.CategoryName = category.CategoryName;

                if(string.IsNullOrEmpty(news.ThumbnailURL))
                {
                    news.ThumbnailURL = category.ThumbnailURL;
                }
            }

            //TODO リリース時削除
            await Task.Delay(2000);

            this.categoryList.ItemsSource = categories;
            this.newsInfoList.ItemsSource = newslist;

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
    }
}
