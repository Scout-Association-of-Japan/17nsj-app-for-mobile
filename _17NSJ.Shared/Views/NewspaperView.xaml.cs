using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using _17NSJ.Exceptions;
using _17NSJ.Models;
using _17NSJ.Services;
using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;

namespace _17NSJ.Views
{
    public partial class NewspaperView : ContentPage
    {
        public NewspaperView()
        {
            // トラッキングコード
            Analytics.TrackEvent("View", new Dictionary<string, string> { { "View", "NewspaperView" } });
            
            InitializeComponent();
            GetNewspapersAsync();
        }

        private async void GetNewspapersAsync()
        {
            this.error.IsVisible = false;
            this.newspaperList.IsVisible = true;
            this.indicator.IsVisible = true;

            try
            {
                var newspaperlist = await AppDataService.GetNewspapersAsync();
                this.newspaperList.ItemsSource = newspaperlist.OrderByDescending(e => e.Id).ToList();
            }
            catch(OutOfServiceException)
            {
                this.error.IsVisible = true;
                this.newspaperList.IsVisible = false;
                this.newspaperList.ItemsSource = null;
                this.newspaperList.SeparatorVisibility = SeparatorVisibility.None;
                this.newspaperList.EndRefresh();
                this.indicator.IsVisible = false;
                return;
            }


            this.newspaperList.EndRefresh();
            this.indicator.IsVisible = false;
        }

        private void ListPulled(object sender, System.EventArgs e)
        {
            GetNewspapersAsync();
        }

        private void ItemSelected(object sender, ItemTappedEventArgs e)
        {
            this.newspaperList.SelectedItem = null;
            var newspaper = e.Item as NewspaperModel;

            if (newspaper != null)
            {
                Device.OpenUri(new Uri(newspaper.URL));
            }
        }

        private void ReloadTapped(object sender, System.EventArgs e)
        {
            GetNewspapersAsync();
        }

        protected override bool OnBackButtonPressed()
        {
            Application.Current.MainPage = new TopView();
            return true;
        }
    }
}
