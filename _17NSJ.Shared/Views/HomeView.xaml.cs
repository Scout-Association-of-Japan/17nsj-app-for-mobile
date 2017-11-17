using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace _17NSJ.Views
{
    public partial class HomeView : ContentPage
    {
        public HomeView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        void DocumentClicked(object sender, System.EventArgs e)
        {
        }

        void SocialClicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SocialView(), true);
        }
    }
}
