using System;
using System.Collections.Generic;
using _17NSJ.Models;
using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;

namespace _17NSJ.Views
{
    public partial class JamGoodsDetailView : ContentPage
    {
        public JamGoodsDetailView(JamGoodsModel goods)
        {
            // トラッキングコード
            Analytics.TrackEvent("JamGoods", new Dictionary<string, string> { { "ID", $"{goods.Id}" } });

            InitializeComponent();
            this.image.Source = goods.DetailImageURL;
            this.name.Text = goods.GoodsName;

            if (goods.Stock == 1)
            {
                this.stockImage.Source = "shop_instock.png";
            }
            else if (goods.Stock == 2)
            {
                this.stockImage.Source = "shop_fewinstock.png";
            }
            else if (goods.Stock == 3)
            {
                this.stockImage.Source = "shop_outofstock.png";
            }
            else
            {
                this.stockImage.Source = "shop_unknown.png";
            }

            this.stockUpdatedAt.Text = goods.StockUpdatedAt.ToLocalTime().ToString("yyyy/MM/dd HH:mm") + "現在";
            this.price.Text = "価格：¥" + goods.Price;
            this.partsNumber.Text = "品番：" + goods.PartsNumber;
            this.size.Text = "サイズ：" + goods.Size;
            this.description.Text = goods.Description;
        }
    }
}
