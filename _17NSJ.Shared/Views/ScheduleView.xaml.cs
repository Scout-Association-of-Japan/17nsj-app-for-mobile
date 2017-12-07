using System;
using System.Collections.Generic;
using _17NSJ.Constants;
using Xamarin.Forms;

namespace _17NSJ.Views
{
    public partial class ScheduleView : ContentPage
    {
        public ScheduleView()
        {
            InitializeComponent();
            scheduleView.Source = SecretConstants.ScheduleUrl;
        }

        void calLoaded(object sender, Xamarin.Forms.WebNavigatedEventArgs e)
        {
            indicator.IsVisible = false;
        }
    }
}
