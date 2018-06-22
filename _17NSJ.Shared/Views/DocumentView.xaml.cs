using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using _17NSJ.Exceptions;
using _17NSJ.Models;
using _17NSJ.Services;
using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;

namespace _17NSJ.Views
{
    public partial class DocumentView : ContentPage
    {
        public DocumentView()
        {
            // トラッキングコード
            Analytics.TrackEvent("View", new Dictionary<string, string> { { "View", "DocumentView" } });

            InitializeComponent();
            GetDocumentsAsync();
        }

        private async void GetDocumentsAsync()
        {
            this.error.IsVisible = false;
            this.documentList.IsVisible = true;
            this.indicator.IsVisible = true;

            ObservableCollection<DocumentModel> docsList;

            try
            {
                docsList = await AppDataService.GetDocumentsAsync();
            }
            catch (OutOfServiceException)
            {
                this.error.IsVisible = true;
                this.documentList.IsVisible = false;
                this.documentList.ItemsSource = null;
                this.documentList.SeparatorVisibility = SeparatorVisibility.None;
                this.documentList.EndRefresh();
                this.indicator.IsVisible = false;
                return;
            }

            this.documentList.ItemsSource = docsList;
            this.documentList.EndRefresh();
            this.indicator.IsVisible = false;
        }

        private void ListPulled(object sender, System.EventArgs e)
        {
            GetDocumentsAsync();
        }

        private void ItemSelected(object sender, ItemTappedEventArgs e)
        {
            this.documentList.SelectedItem = null;
            var doc = e.Item as DocumentModel;

            if (doc != null)
            {
                Device.OpenUri(new Uri(doc.URL));
            }
        }

        void ReloadTapped(object sender, System.EventArgs e)
        {
            GetDocumentsAsync();
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
