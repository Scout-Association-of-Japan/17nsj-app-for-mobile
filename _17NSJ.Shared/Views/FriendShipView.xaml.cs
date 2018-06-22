using System;
using System.Collections.Generic;
using _17NSJ.Constants;
using _17NSJ.Models;
using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;

namespace _17NSJ.Views
{
    public partial class FriendShipView : ContentPage
    {
        public FriendShipView()
        {
            // トラッキングコード
            Analytics.TrackEvent("View", new Dictionary<string, string> { { "View", "FriendShipView" } });

            InitializeComponent();
            this.friendshiplList.ItemsSource = FriendshipList.List;
        }

        void ItemSelected(object sender, ItemTappedEventArgs e)
        {
            this.friendshiplList.SelectedItem = null;
            var item = e.Item as FriendshipModel;

            if(item != null)
            {
                Device.OpenUri(new Uri(item.Url));
            }
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
