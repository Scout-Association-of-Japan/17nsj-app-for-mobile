using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace _17NSJ.Views
{
    public partial class SettingView : ContentPage
    {
        public SettingView()
        {
            InitializeComponent();
        }

        void AgreementTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Agreement());
        }

        void PolicyTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Policy());
        }

        void LicenseTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new License());
        }

        void AppInfoTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AppInfo());
        }
    }
}
