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
    public partial class MovieView : ContentPage
    {
        public MovieView()
        {
            // トラッキングコード
            Analytics.TrackEvent("View", new Dictionary<string, string> { { "View", "MovieView" } });

            InitializeComponent();
            GetMoviesAsync();
        }

        private async void GetMoviesAsync()
        {
            this.error.IsVisible = false;
            this.movieList.IsVisible = true;
            this.indicator.IsVisible = true;

            ObservableCollection<MovieModel> moviesList;

            try
            {
                moviesList = await AppDataService.GetMoviesAsync();
            }
            catch(OutOfServiceException)
            {
                this.error.IsVisible = true;
                this.movieList.IsVisible = false;
                this.movieList.ItemsSource = null;
                this.movieList.SeparatorVisibility = SeparatorVisibility.None;
                this.movieList.EndRefresh();
                this.indicator.IsVisible = false;
                return;
            }

            this.movieList.ItemsSource = moviesList;
            this.movieList.EndRefresh();
            this.indicator.IsVisible = false;
        }

        private void ListPulled(object sender, System.EventArgs e)
        {
            GetMoviesAsync();
        }

        private void ItemSelected(object sender, ItemTappedEventArgs e)
        {
            this.movieList.SelectedItem = null;
            var movie = e.Item as MovieModel;

            if (movie != null)
            {
                Device.OpenUri(new Uri(movie.URL));
            }
        }

        void ReloadTapped(object sender, System.EventArgs e)
        {
            GetMoviesAsync();
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
