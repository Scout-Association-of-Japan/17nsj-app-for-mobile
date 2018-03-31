using System;
using System.Collections.Generic;
using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;

namespace _17NSJ.Views
{
    public partial class SecretView : ContentPage
    {
        public SecretView(string imgName)
        {
            Analytics.TrackEvent("View", new Dictionary<string, string> { { "View", "SecretView" } });

            InitializeComponent();
            this.img.Source = imgName;
        }
    }
}
