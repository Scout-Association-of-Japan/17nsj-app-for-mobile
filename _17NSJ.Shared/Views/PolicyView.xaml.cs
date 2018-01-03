using System;
using System.Collections.Generic;
using _17NSJ.Constants;
using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;

namespace _17NSJ.Views
{
    public partial class PolicyView : ContentPage
    {
        public PolicyView()
        {
            // トラッキングコード
            Analytics.TrackEvent("View", new Dictionary<string, string> { { "View", "PolicyView" } });

            InitializeComponent();
            this.Article1.Text = PolicyArticles.Article1;
            this.Article2.Text = PolicyArticles.Article2;
            this.Article3.Text = PolicyArticles.Article3;
            this.Article4.Text = PolicyArticles.Article4;
            this.Article5.Text = PolicyArticles.Article5;
            this.Article6.Text = PolicyArticles.Article6;
            this.Article7.Text = PolicyArticles.Article7;
            this.Article8.Text = PolicyArticles.Article8;
            this.Article9.Text = PolicyArticles.Article9;
            this.Article10.Text = PolicyArticles.Article10;
            this.Article11.Text = PolicyArticles.Article11;
            this.Article12.Text = PolicyArticles.Article12;
        }
    }
}
