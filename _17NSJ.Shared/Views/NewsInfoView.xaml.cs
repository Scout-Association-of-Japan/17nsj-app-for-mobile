using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
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

                if(string.IsNullOrEmpty(news.ThumbnailURL))
                {
                    news.ThumbnailURL = category.ThumbnailURL;
                }
            }

            //TODO リリース時削除
            await Task.Delay(3000);

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
            var item = e.Item as SocialModel;

            if (item != null)
            {
                Device.OpenUri(new Uri(item.Url));
            }
        }
    }
}
