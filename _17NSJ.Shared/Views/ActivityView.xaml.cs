using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _17NSJ.Models;
using _17NSJ.Services;
using Xamarin.Forms;

namespace _17NSJ.Views
{
    public partial class ActivityView : ContentPage
    {
        public ActivityView()
        {
            InitializeComponent();
            GetActivitiesAsync();
        }

        private async void GetActivitiesAsync()
        {
            this.indicator.IsVisible = true;

            var service = new AppDataService();
            var categories = await service.GetActivityCategoriesAsync();
            var actList = await service.GetActivitiesAsync();

            foreach (var act in actList)
            {
                var category = categories.Where(e => act.Category == e.Category).FirstOrDefault();
                act.Color = category.Color;
                act.CategoryName = category.CategoryName;

                //個別のサムネイルがなければカテゴリーごとのサムネイル
                if (string.IsNullOrEmpty(act.ThumbnailURL))
                {
                    act.ThumbnailURL = category.ThumbnailURL;
                }

                //待機可能であり、クローズしていなければ
                if(act.CanWaitable && !act.IsClosed)
                {
                    act.WaitingInfoBackgroundColor = "#F7931E";
                    act.WaitingInfoState = $"待ち時間：{act.WaitingTime}分";
                }

                //待機可能であり、クローズしているとき
                else if (act.CanWaitable && act.IsClosed)
                {
                    act.WaitingInfoBackgroundColor = "#CBCBCB";
                    act.WaitingInfoState = $"クローズ";
                }

                //待機可能ではない時、見えないがNullにならないために入れる
                else
                {
                    act.WaitingInfoBackgroundColor = "#F7931E";
                }
            }

            this.categoryList.ItemsSource = categories;
            this.activityList.ItemsSource = actList;
            this.activityList.EndRefresh();
            this.indicator.IsVisible = false;
        }

        private void ListPulled(object sender, System.EventArgs e)
        {
            GetActivitiesAsync();
        }

        private void ItemSelected(object sender, ItemTappedEventArgs e)
        {
            this.activityList.SelectedItem = null;
            var act = e.Item as ActivityModel;

            if (act != null)
            {
                Navigation.PushAsync(new ActivityDetailView(act));
            }
        }
    }
}
