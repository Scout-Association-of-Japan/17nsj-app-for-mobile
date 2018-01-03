using System;
using System.Collections.Generic;
using _17NSJ.Constants;
using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;

namespace _17NSJ.Views
{
    public partial class AgreementView : ContentPage
    {
        public AgreementView()
        {
            // トラッキングコード
            Analytics.TrackEvent("View", new Dictionary<string, string> { { "View", "Agreement" } });

            InitializeComponent();
            this.BeforeArticle.Text = AgreementArticles.BeforeArticle;
            this.Article1.Text = AgreementArticles.Article1;
            this.Article2.Text = AgreementArticles.Article2;
            this.Article3.Text = AgreementArticles.Article3;
            this.Article4.Text = AgreementArticles.Article4;
            this.Article5.Text = AgreementArticles.Article5;
            this.Article6.Text = AgreementArticles.Article6;
            this.Article7.Text = AgreementArticles.Article7;
            this.Article8.Text = AgreementArticles.Article8;
            this.Article9.Text = AgreementArticles.Article9;
            this.Article10.Text = AgreementArticles.Article10;
        }
    }
}
