using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using _17NSJ.Constants;
using _17NSJ.Exceptions;
using _17NSJ.Models;
using _17NSJ.Services;
using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;
using XamForms.Controls;

namespace _17NSJ.Views
{
    public partial class ScheduleView : ContentPage
    {
        ObservableCollection<ScheduleModel> ScheList = new ObservableCollection<ScheduleModel>();
        ObservableCollection<ScheduleModel> empty = new ObservableCollection<ScheduleModel>();
        int count = 0;

        public ScheduleView()
        {
            // トラッキングコード
            Analytics.TrackEvent("View", new Dictionary<string, string> { { "View", "ScheduleView" } });

            InitializeComponent();

            empty.Add(new ScheduleModel() { Title = "スケジュールはありません", HasRange = false, Color="#00000000" });

            GetSchedulesAsync();
        }

        private async void GetSchedulesAsync()
        {
            this.error.IsVisible = false;
            this.calendar.IsVisible = true;
            this.list.IsVisible = true;
            this.indicator.IsVisible = true;

            var service = new AppDataService();

            try
            {
                ScheList = await service.GetSchedulesAsync();
            }
            catch (OutOfServiceException)
            {
                this.error.IsVisible = true;
                this.calendar.IsVisible = false;
                this.list.IsVisible = false;
                this.indicator.IsVisible = false;
                return;
            }

            var hadScheduleDateList = ScheList.Select(x => x.Start.Date).Distinct();

            foreach (var hadScheduleDate in hadScheduleDateList)
            {
                this.calendar.SpecialDates.Add(new SpecialDate(hadScheduleDate) { BackgroundColor = Color.FromHex("#389de0"), TextColor = Color.White, Selectable = true});
            }

            calendar.RaiseSpecialDatesChanged();
            calendar.SelectedDate = DateTime.Today;
            ChangeSchedulesList(DateTime.Today);
            this.indicator.IsVisible = false;
        }

        private void DateClicked(object sender, XamForms.Controls.DateTimeEventArgs e)
        {
            ChangeSchedulesList(e.DateTime.Date);

            if (e.DateTime.Date == DateTime.Parse("1857/7/24 00:00:00").Date)
            {
                Navigation.PushAsync(new SecretView("special_sg.png"));
            }

            if (e.DateTime.Month == 4 && e.DateTime.Day == 13)
            {
                count++;
                if (count == 10)
                {
                    count = 0;
                    Navigation.PushAsync(new SecretView("special_100.jpg"));
                }
            }
        }

        void ReloadTapped(object sender, System.EventArgs e)
        {
            GetSchedulesAsync();
        }

        private void ChangeSchedulesList(DateTime date)
        {   
            var filterdList = ScheList.Where(x => x.Start.Date == date.Date).OrderBy(x => x.HasRange).ThenBy(x => x.Start).ToList();

            if(filterdList.Count == 0)
            {
                this.list.ItemsSource = empty;
            }
            else
            {
                this.list.ItemsSource = filterdList;
            }
        }

        protected override bool OnBackButtonPressed()
        {
            Application.Current.MainPage = new TopView();
            return true;
        }
    }
}
