using System;
using System.Collections.Generic;
using _17NSJ.Constants;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Push;
using Xamarin.Forms;

namespace _17NSJ.Views
{
    public partial class InitAgreementView : ContentPage
    {
        public InitAgreementView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        void AgreeButtonClicked(object sender, System.EventArgs e)
        {
            Application.Current.Properties["IsAgreed"] = true;
            Application.Current.SavePropertiesAsync();

            AppCenter.Start($"ios={SecretConstants.AppCenteriOS};" + $"android={SecretConstants.AppCenterDroid}", typeof(Analytics), typeof(Crashes), typeof(Push));
            Application.Current.MainPage = new NavigationPage(new TopView())
            {
                BarBackgroundColor = new Color(0.00, 0.44, 0.74),
                BarTextColor = Color.White
            };
        }

        void ViewAgreementClicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AgreementView());
        }

        void ViewPolicyClicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new PolicyView());
        }
    }
}
