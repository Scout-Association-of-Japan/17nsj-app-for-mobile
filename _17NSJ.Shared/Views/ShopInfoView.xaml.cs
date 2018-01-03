using System;
using System.Collections.Generic;
using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;

namespace _17NSJ.Views
{
    public partial class ShopInfoView : ContentPage
    {
        public ShopInfoView()
        {
            // トラッキングコード
            Analytics.TrackEvent("View", new Dictionary<string, string> { { "View", "ShopInfoView" } });

            InitializeComponent();
        }
    }
}
