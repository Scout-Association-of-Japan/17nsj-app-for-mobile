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

            if (!act.CanWaitable)
            {
                this.waitingInfo.IsVisible = false;
            }

            this.waitingTime.Text = act.WaitingTime;
            this.updatedAt.Text = act.UpdatedAt.ToString("yyyy/MM/dd HH:mm");
            this.outline.Text = act.Outline;
            this.location.Source = @"https://www.google.co.jp/maps/@37.4387465,137.3275352,18.65z";
        }
    }
}
