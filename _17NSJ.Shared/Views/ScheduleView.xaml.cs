using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace _17NSJ.Views
{
    public partial class ScheduleView : ContentPage
    {
        public ScheduleView()
        {
            InitializeComponent();
        }

        void calLoaded(object sender, Xamarin.Forms.WebNavigatedEventArgs e)
        {
            indicator.IsVisible = false;
        }
    }
}
