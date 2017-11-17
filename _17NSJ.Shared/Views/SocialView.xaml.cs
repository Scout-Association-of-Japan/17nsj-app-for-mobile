using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using _17NSJ.Models;
using _17NSJ.ViewModels;
using Xamarin.Forms;

namespace _17NSJ.Views
{
    public partial class SocialView : ContentPage
    {
        public SocialView()
        {
            InitializeComponent();
            this.BindingContext = new SocialViewModel();
        }
    }
}
