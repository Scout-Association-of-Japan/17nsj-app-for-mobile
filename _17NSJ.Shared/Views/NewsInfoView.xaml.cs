using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using _17NSJ.Models;

using Xamarin.Forms;

namespace _17NSJ.Views
{
    public partial class NewsInfoView : ContentPage
    {
        public NewsInfoView()
        {
            InitializeComponent();

            var list = new ObservableCollection<NewsInfo>
            {
                new NewsInfo() { Color="#2e8b57", Title="タイトルこんにちはタイトルこんにちはああ", ThumbnailURL="https://pbs.twimg.com/profile_images/898696996814376960/9ObeFpCx_400x400.jpg", Outline="アウトラインアウトラインアウトラインアウトラインアウトラインアウトラインアウトラインアウトラインアウトラインアウトライン"},
                new NewsInfo() { Color="#00008b", Title="タイトル2", ThumbnailURL="https://pbs.twimg.com/profile_images/898696996814376960/9ObeFpCx_400x400.jpg", Outline="アウトラインアウトラインアウトラインアウトラインアウトラインアウトラインアウトラインアウトラインアウトラインアウトライン"},
                new NewsInfo() { Color="#ff0000", Title="タイトル3", ThumbnailURL="https://pbs.twimg.com/profile_images/898696996814376960/9ObeFpCx_400x400.jpg", Outline="アウトラインアウトラインアウトラインアウトラインアウトラインアウトラインアウトラインアウトラインアウトラインアウトライン"},
                new NewsInfo() { Color="#32cd32", Title="タイトル4", ThumbnailURL="https://pbs.twimg.com/profile_images/898696996814376960/9ObeFpCx_400x400.jpg", Outline="アウトラインアウトラインアウトラインアウトラインアウトラインアウトラインアウトラインアウトラインアウトラインアウトライン"}
            };

            this.newsInfoList.ItemsSource = list;
        }

        void ItemSelected(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as Social;

            if (item != null)
            {
                Device.OpenUri(new Uri(item.Url));
            }
        }
    }
}
