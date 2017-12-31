using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace _17NSJ.Views
{
    public partial class License : ContentPage
    {
        public License()
        {
            InitializeComponent();
            ObservableCollection<string> list = new ObservableCollection<string>();
            list.Add("Xamarin.Forms");
            list.Add("Newtonsoft.Json");
            list.Add("AiForms.Layouts");
            list.Add("Com.Airbnb.Xamarin.Forms.Lottie");
            this.licenseList.ItemsSource = list;
        }
    }
}
