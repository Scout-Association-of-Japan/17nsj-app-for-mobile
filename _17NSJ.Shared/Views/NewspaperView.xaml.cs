using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using _17NSJ.Models;
using _17NSJ.Services;
using Xamarin.Forms;

namespace _17NSJ.Views
{
    public partial class NewspaperView : ContentPage
    {
        public NewspaperView()
        {
            InitializeComponent();
            GetNewspapersAsync();
        }

        private async void GetNewspapersAsync()
        {
            this.indicator.IsVisible = true;

            var service = new AppDataService();
            var newspaperlist = await service.GetNewspapersAsync();

            //TODO リリース時削除
            await Task.Delay(2000);

            this.newspaperList.ItemsSource = newspaperlist.OrderByDescending(e => e.Id).ToList();

            this.newspaperList.EndRefresh();
            this.indicator.IsVisible = false;
        }

        private void ListPulled(object sender, System.EventArgs e)
        {
            GetNewspapersAsync();
        }

        private void ItemSelected(object sender, ItemTappedEventArgs e)
        {
            var newspaper = e.Item as NewspaperModel;

            if (newspaper != null)
            {
                Device.OpenUri(new Uri(newspaper.URL));
            }
        }
    }
}
