using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace _17NSJ.Views
{
    public partial class WeatherView : ContentPage
    {
        public WeatherView()
        {
            InitializeComponent();
        }

        void siteLoaded(object sender, WebNavigatedEventArgs e)
        {
            indicator.IsVisible = false;
        }
    }
}
