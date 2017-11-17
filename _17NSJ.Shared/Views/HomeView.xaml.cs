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

        void DocumentClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DocumentView(), true);
        }

        void SocialClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SocialView(), true);
        }

        void DayVisitorClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DayVisitorView(), true);
        }

        void MovieClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MovieView(), true);
        }

        void ShopClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ShopInfoView(), true);
        }

        void SponsorClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SponsorView(), true);
        }

        void NewspaperClicked(object sender, EventArgs e)
        {
        }

        void FriendShipClicked(object sender, EventArgs e)
        {
        }

        void SettingClicked(object sender, EventArgs e)
        {
        }
    }
}