using System;
using System.Collections.Generic;
using _17NSJ.Constants;
using _17NSJ.Models;
using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;

namespace _17NSJ.Views
{
    public partial class ActivityDetailView : ContentPage
    {
        public ActivityDetailView(ActivityModel act)
        {
            // トラッキングコード
            Analytics.TrackEvent("ActivityDetail", new Dictionary<string, string> { { "ID", $"{act.Category}-{act.Id}" } });

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

            if (!string.IsNullOrEmpty(act.MapURL))
            {
                this.map.Source = act.MapURL;
            }
            else
            {
                this.map.Source = SecretConstants.MapUrl;
            }
        }
    }
}
