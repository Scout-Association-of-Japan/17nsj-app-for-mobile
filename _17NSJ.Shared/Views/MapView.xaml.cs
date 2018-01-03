using System;
using System.Collections.Generic;
using _17NSJ.Constants;
using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;

namespace _17NSJ.Views
{
    public partial class MapView : ContentPage
    {
        public MapView()
        {
            // トラッキングコード
            Analytics.TrackEvent("View", new Dictionary<string, string> { { "View", "MapView" } });

            InitializeComponent();
            mapView.Source = SecretConstants.MapUrl;
        }

        void mapLoaded(object sender, Xamarin.Forms.WebNavigatedEventArgs e)
        {
            indicator.IsVisible = false;
        }
    }
}
