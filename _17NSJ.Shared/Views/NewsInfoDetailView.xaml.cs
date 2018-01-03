using System;
using System.Collections.Generic;
using _17NSJ.Models;
using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;

namespace _17NSJ.Views
{
    public partial class NewsInfoDetailView : ContentPage
    {
        public NewsInfoDetailView(NewsInfoModel news)
        {
            // トラッキングコード
            Analytics.TrackEvent("NewsInfo", new Dictionary<string, string> { { "ID", $"{news.Category}-{news.Id}" } });

            InitializeComponent();
            this.colorBar.BackgroundColor = Color.FromHex(news.Color);
            this.serialId.Text = news.Category + "-" + news.Id;
            this.createdAt.Text = "配信日："+news.CreatedAt.ToLocalTime().ToString("yyyy/MM/dd HH:mm");
            this.updatedAt.Text = "最終更新日："+news.UpdatedAt.ToLocalTime().ToString("yyyy/MM/dd HH:mm");
            this.author.Text = "取材：" + news.Author;
            this.title.Text = news.Title;
            this.media.Source = news.MediaURL;
            this.outline.Text = news.Outline;
            this.category.Text = "カテゴリー：" + news.CategoryName;
        }
    }
}
