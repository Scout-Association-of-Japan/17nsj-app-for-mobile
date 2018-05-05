using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;

namespace _17NSJ.Views
{
    public partial class LicenseView : ContentPage
    {
        public LicenseView()
        {
            // トラッキングコード
            Analytics.TrackEvent("View", new Dictionary<string, string> { { "View", "LicenseView" } });

            InitializeComponent();
            ObservableCollection<string> list = new ObservableCollection<string>();
            list.Add("Xamarin.Forms");
            list.Add("Newtonsoft.Json");
            list.Add("AiForms.Layouts");
            list.Add("Com.Airbnb.Xamarin.Forms.Lottie");
            list.Add("XamForms.Controls.Calendar");
            list.Add("Xamarin.Forms.GoogleMaps");
            list.Add("Xam.Plugin.Geolocator");
            this.licenseList.ItemsSource = list;
        }
    }
}
