using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using _17NSJ.Constants;
using _17NSJ.Models;
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

            if(Device.RuntimePlatform == Device.iOS)
            {
                this.licenseList.ItemsSource = iOSLicenseList.List;
            }
            else if(Device.RuntimePlatform == Device.Android)
            {
                this.licenseList.ItemsSource = DroidLicenseList.List;
            }
        }

        private void ItemSelected(object sender, ItemTappedEventArgs e)
        {
            this.licenseList.SelectedItem = null;
            var license = e.Item as LicenseModel;

            if (license != null)
            {
                Navigation.PushAsync(new LicenseDetailView(license.LicenseFileName));
            }
        }
    }
}
