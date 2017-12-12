using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using _17NSJ.Models;
using _17NSJ.Services;
using Xamarin.Forms;

namespace _17NSJ.Views
{
    public partial class ActivityView : ContentPage
    {
        public ActivityView()
        {
            InitializeComponent();
            GetActivitiesAsync();
        }

        private async void GetActivitiesAsync()
        {
            this.indicator.IsVisible = true;

            var service = new AppDataService();
            var actList = await service.GetActivitiesAsync();

            //TODO リリース時削除
            await Task.Delay(2000);

            this.activityList.ItemsSource = actList;

            this.activityList.EndRefresh();
            this.indicator.IsVisible = false;
        }

        private void ListPulled(object sender, System.EventArgs e)
        {
            GetActivitiesAsync();
        }

        private void ItemSelected(object sender, ItemTappedEventArgs e)
        {
            var act = e.Item as ActivityModel;

            if (act != null)
            {
                
            }
        }
    }
}
