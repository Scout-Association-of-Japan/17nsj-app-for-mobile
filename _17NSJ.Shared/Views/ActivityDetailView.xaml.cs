using System;
using System.Collections.Generic;
using _17NSJ.Constants;
using _17NSJ.Models;
using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace _17NSJ.Views
{
    public partial class ActivityDetailView : ContentPage
    {
        private ActivityModel Act;

        public ActivityDetailView(ActivityModel act)
        {
            // トラッキングコード
            Analytics.TrackEvent("ActivityDetail", new Dictionary<string, string> { { "ID", $"{act.Category}-{act.Id}" } });

            InitializeComponent();
            Act = act;
            this.colorBar.BackgroundColor = Color.FromHex(act.Color);
            this.serialId.Text = act.Category + "-" + act.Id;
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

            if (act.Latitude == null || act.Longitude == null)
            {
                this.mapGrid.IsVisible = false;
            }
            else
            {
                Pin pin = new Pin();
                pin.Icon = BitmapDescriptorFactory.FromBundle("map_pin.png");
                pin.Label = "目的地";
                pin.Position = new Xamarin.Forms.GoogleMaps.Position((double)act.Latitude, (double)act.Longitude);
                this.map.Pins.Add(pin); 
                this.map.InitialCameraUpdate = CameraUpdateFactory.NewPositionZoom(new Xamarin.Forms.GoogleMaps.Position((double)act.Latitude, (double)act.Longitude), 17);
            }
        }

        private void MapClicked(object sender, Xamarin.Forms.GoogleMaps.MapClickedEventArgs e)
        {
            Navigation.PushAsync(new MapView((double)Act.Latitude, (double)Act.Longitude));
        }
    }
}
