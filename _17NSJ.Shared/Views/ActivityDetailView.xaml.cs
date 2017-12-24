using System;
using System.Collections.Generic;
using _17NSJ.Models;
using Xamarin.Forms;

namespace _17NSJ.Views
{
    public partial class ActivityDetailView : ContentPage
    {
        public ActivityDetailView(ActivityModel act)
        {
            InitializeComponent();
            this.image.Source = act.MediaURL;
            this.title.Text = act.Title;
            this.waitingInfo.IsVisible = act.CanWaitable;

            //待機可能であり、クローズしていなければ
            if (act.CanWaitable && !act.IsClosed)
            {
                waitingInfo.BackgroundColor = Color.Orange;
                waitingInfoState.Text = $"待ち時間：{act.WaitingTime}分";
            }

            //待機可能であり、クローズしているとき
            else if (act.CanWaitable && act.IsClosed)
            {
                waitingInfo.BackgroundColor = Color.LightGray;
                waitingInfoState.Text = $"クローズ";
            }

            this.WaitingInfoUpdatedAt.Text = act.WaitingInfoUpdatedAt.ToString("yyyy/MM/dd HH:mm");
            this.outline.Text = act.Outline;
            this.category.Text = "区分：" + act.CategoryName;
            this.term.Text = "日時：" + act.Term;
            this.location.Text = "場所：" + act.Location;
            this.map.Source = @"https://www.google.co.jp/maps/@37.4387465,137.3275352,18.65z";
        }
    }
}
