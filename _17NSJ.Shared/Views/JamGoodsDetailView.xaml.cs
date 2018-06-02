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
            Analytics.TrackEvent("JamGoods", new Dictionary<string, string> { { "ID", $"{goods.ID}" } });

            InitializeComponent();
            this.image.Source = goods.Image;
            this.name.Text = goods.Name;

            if(goods.Stock == null)
            {
                
            }
            else if ((bool)goods.Stock)
            {
                this.stockImage.Source = "shop_instock.png";
            }
            else
            {
                this.stockImage.Source = "shop_outofstock.png";
            }

            this.stockUpdatedAt.Text = goods.StockUpdatedAt.ToString() + "現在";
            this.price.Text = "価格：" + goods.Price;
            this.id.Text = "品番：" + goods.ID;
            this.size.Text = "サイズ：" + goods.Size;
            this.description.Text = goods.Description;
        }
    }
}
