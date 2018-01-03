using System;
using System.Collections.Generic;
using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;

namespace _17NSJ.Views
{
    public partial class WeatherView : ContentPage
    {
        public WeatherView()
        {
            // トラッキングコード
            Analytics.TrackEvent("View", new Dictionary<string, string> { { "View", "WeatherView" } });

            InitializeComponent();
        }

        void siteLoaded(object sender, WebNavigatedEventArgs e)
        {
            indicator.IsVisible = false;
        }
    }
}
