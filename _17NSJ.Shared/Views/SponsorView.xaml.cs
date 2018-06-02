using System;
using System.Collections.Generic;
using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;

namespace _17NSJ.Views
{
    public partial class SponsorView : ContentPage
    {
        public SponsorView()
        {
            // トラッキングコード
            Analytics.TrackEvent("View", new Dictionary<string, string> { { "View", "SponsorView" } });

            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            Application.Current.MainPage = new TopView();
            return true;
        }
    }
}
