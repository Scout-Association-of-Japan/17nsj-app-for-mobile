using System;
using System.Collections.Generic;
using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;

namespace _17NSJ.Views
{
    public partial class DayVisitorView : ContentPage
    {
        public DayVisitorView()
        {
            // トラッキングコード
            Analytics.TrackEvent("View", new Dictionary<string, string> { { "View", "DayVisitorView" } });

            InitializeComponent();
        }

        void RegisterTapped(object sender, System.EventArgs e)
        {
            Device.OpenUri(new Uri("https://17nsj-dayvisitor.peatix.com/"));
        }
    }
}
