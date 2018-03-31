using System;
using System.Collections.Generic;
using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;

namespace _17NSJ.Views
{
    public partial class CreditPage : ContentPage
    {
        int count = 0;

        public CreditPage()
        {
            Analytics.TrackEvent("View", new Dictionary<string, string> { { "View", "CreditView" } });

            InitializeComponent();
        }

        void Handle_Tapped(object sender, System.EventArgs e)
        {
            count++;
            if (count == 10)
            {
                count = 0;
                Navigation.PushAsync(new SecretView("special_bp.png"));
            }
        }
    }
}
