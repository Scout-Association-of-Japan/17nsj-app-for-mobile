using System;
using System.Collections.Generic;
using _17NSJ.Constants;
using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;

namespace _17NSJ.Views
{
    public partial class ScheduleView : ContentPage
    {
        public ScheduleView()
        {
            // トラッキングコード
            Analytics.TrackEvent("View", new Dictionary<string, string> { { "View", "ScheduleView" } });

            InitializeComponent();
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            var html = new HtmlWebViewSource
            {
                Html = $@"<html><body><iframe src=""{SecretConstants.ScheduleUrl}"" style=""border-width:0"" width=""{width - 5}"" height=""{height - 10}"" frameborder=""0"" scrolling=""no""></iframe></body></html>",
            };

            scheduleView.Source = html;
        }

        void calLoaded(object sender, Xamarin.Forms.WebNavigatedEventArgs e)
        {
            indicator.IsVisible = false;
        }
    }
}
