using System;
using System.Collections.Generic;
using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;

namespace _17NSJ.Views
{
    public partial class SettingView : ContentPage
    {
        public SettingView()
        {
            // トラッキングコード
            Analytics.TrackEvent("View", new Dictionary<string, string> { { "View", "SettingView" } });

            InitializeComponent();
        }

        void AgreementTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AgreementView());
        }

        void PolicyTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PolicyView());
        }

        void LicenseTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LicenseView());
        }

        void AppInfoTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AppInfoView());
        }

        protected override bool OnBackButtonPressed()
        {
            var p = this.Parent.Parent as MasterDetailView;

            if (p != null)
            {
                p.Detail = new TopView();
            }

            return true;
        }
    }
}
