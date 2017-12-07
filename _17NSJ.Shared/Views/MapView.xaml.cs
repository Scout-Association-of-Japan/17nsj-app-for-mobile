using System;
using System.Collections.Generic;
using _17NSJ.Constants;
using Xamarin.Forms;

namespace _17NSJ.Views
{
    public partial class MapView : ContentPage
    {
        public MapView()
        {
            InitializeComponent();
            mapView.Source = SecretConstants.MapUrl;
        }

        void mapLoaded(object sender, Xamarin.Forms.WebNavigatedEventArgs e)
        {
            indicator.IsVisible = false;
        }
    }
}
