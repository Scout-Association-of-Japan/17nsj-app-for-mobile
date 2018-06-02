using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using _17NSJ.Models;
using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;

namespace _17NSJ.Views
{
    public partial class JamGoodsView : ContentPage
    {
        public event Action<object> ActionHandler;

        public JamGoodsView()
        {
            // トラッキングコード
            Analytics.TrackEvent("View", new Dictionary<string, string> { { "View", "JamGoodsView" } });

            InitializeComponent();

            ActionHandler += this.ItemSelected;
            this.jamGoodsList.ItemTapCommand = new Command(ActionHandler);

            GetGoodsAsync();
        }

        private void GetGoodsAsync()
        {
            this.error.IsVisible = false;
            this.indicator.IsVisible = true;

            ObservableCollection<JamGoodsModel> list = new ObservableCollection<JamGoodsModel>();

            for (int i = 0; i < 10;i++)
            {
                var model = new JamGoodsModel();
                model.ID = i.ToString();
                model.Name = "品名" + i.ToString();
                model.Price = 100 * i;
                model.Size = "H 50mm * W 50mm" + i.ToString();
                model.Description = "説明説明説明説明説明説明説明説明説明説明説明説明説明説明説明説明説明説明説明説明説明説明説明説明" + i.ToString();
                model.Image = "https://placehold.jp/320x320.png";
                model.DisplayNumber = i;
                model.Stock = null;
                model.StockUpdatedAt = DateTime.Now;

                list.Add(model);
            }
            list[2].Stock = true;
            list[3].Stock = false;


            this.jamGoodsList.ItemsSource = list;

            this.indicator.IsVisible = false;
        }

        private void ItemSelected(object JamGoods)
        {
            var goods = JamGoods as JamGoodsModel;

            if (goods != null)
            {
                Navigation.PushAsync(new JamGoodsDetailView(goods));
            }
        }

        void ReloadTapped(object sender, System.EventArgs e)
        {
            GetGoodsAsync();
        }
    }
}
