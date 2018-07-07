using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using _17NSJ.Exceptions;
using _17NSJ.Models;
using _17NSJ.Services;
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

            GetGoodsAsync();
        }

        private async void GetGoodsAsync()
        {
            this.error.IsVisible = false;
            this.jamGoodsList.IsVisible = true;
            this.indicator.IsVisible = true;

            var list = new List<GoodsByCategory>();
            ObservableCollection<JamGoodsCategoryModel> categories;
            ObservableCollection<JamGoodsModel> originalGoodsList;

            try
            {
                categories = await AppDataService.GetJamGoodsCategoriesAsync();
                originalGoodsList = await AppDataService.GetJamGoodsAsync();
            }
            catch (OutOfServiceException)
            {
                this.error.IsVisible = true;
                this.jamGoodsList.IsVisible = false;
                this.jamGoodsList.ItemsSource = null;
                this.indicator.IsVisible = false;
                return;
            }

            this.finalUpdatedAt.Text = "最終更新：" + (originalGoodsList.Select(X =>X.StockUpdatedAt).Max()).ToLocalTime().ToString("yyyy/MM/dd HH:mm");

            foreach(var item in originalGoodsList)
            {
                switch(item.Stock)
                {
                    case 0:
                    case 1:
                        item.PriceText = "¥" + item.Price;
                        item.PriceTextColor = "#95989A";
                        break;
                    case 2:
                        item.PriceText = "¥" + item.Price + " △";
                        item.PriceTextColor = "Orange";
                        break;
                    case 3:
                        item.PriceText = "¥" + item.Price + " X";
                        item.PriceTextColor = "Red";
                        break;
                    default:
                        break;
                }
            }

            foreach(var item in categories.OrderBy(X => X.DisplayOrder))
            {
                var goods = originalGoodsList.Where(x => x.Category == item.Category).OrderBy(X => X.DisplayOrder).ToList();
                list.Add(new GoodsByCategory(){ CategoryName = item.CategoryName, Goods = goods, Tapped=new Command(ActionHandler)});                                         
            }


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

        private void ReloadTapped(object sender, System.EventArgs e)
        {
            GetGoodsAsync();
        }
    }
}
