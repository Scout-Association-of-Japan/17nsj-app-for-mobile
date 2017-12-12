using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using _17NSJ.Models;
using _17NSJ.Services;
using Xamarin.Forms;

namespace _17NSJ.Views
{
    public partial class MovieView : ContentPage
    {
        public MovieView()
        {
            InitializeComponent();
            GetMoviesAsync();
        }

        private async void GetMoviesAsync()
        {
            this.indicator.IsVisible = true;

            var service = new AppDataService();
            var moviesList = await service.GetMoviesAsync();

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
            var movie = e.Item as MovieModel;

            if (movie != null)
            {
                Device.OpenUri(new Uri(movie.URL));
            }
        }

    }
}
