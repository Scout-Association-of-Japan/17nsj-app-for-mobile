using System;
using System.Collections.Generic;
using System.Linq;
using _17NSJ.Constants;
using Xamarin.Forms;

namespace _17NSJ.Views
{
    public partial class MasterDetailView : MasterDetailPage
    {
        public MasterDetailView(Type initPage)
        {
            InitializeComponent();

            //初期画面を表示
            Page displayPage = Activator.CreateInstance(initPage) as Page;

            if (displayPage != null)
            {
                var detail = new NavigationPage(displayPage)
                {
                    BarBackgroundColor = new Color(0.00, 0.44, 0.74),
                    BarTextColor = Color.White
                };

                this.Detail = detail;
            }
        }

        void HomeTapped(object sender, EventArgs e)
        {
            Handle_ItemSelected(typeof(TopView));
        }

        void NewsInfoTapped(object sender, EventArgs e)
        {
            Handle_ItemSelected(typeof(NewsInfoView));
        }

        void ScheduleTapped(object sender, EventArgs e)
        {
            Handle_ItemSelected(typeof(ScheduleView));
        }

        void MapTapped(object sender, EventArgs e)
        {
            Handle_ItemSelected(typeof(MapView));
        }

        void ActivityTapped(object sender, EventArgs e)
        {
            Handle_ItemSelected(typeof(ActivityView));
        }

        void WeatherTapped(object sender, EventArgs e)
        {
            Handle_ItemSelected(typeof(WeatherView));
        }

        void SocialTapped(object sender, EventArgs e)
        {
            Handle_ItemSelected(typeof(SocialView));
        }

        void MovieTapped(object sender, EventArgs e)
        {
            Handle_ItemSelected(typeof(MovieView));
        }

        void NewspaperTapped(object sender, EventArgs e)
        {
            Handle_ItemSelected(typeof(NewspaperView));
        }

        void FriendshipTapped(object sender, EventArgs e)
        {
            Handle_ItemSelected(typeof(FriendShipView));
        }

        void ShopTapped(object sender, EventArgs e)
        {
            Handle_ItemSelected(typeof(ShopInfoView));
        }

        void DocumentTapped(object sender, EventArgs e)
        {
            Handle_ItemSelected(typeof(DocumentView));
        }

        void VisitorTapped(object sender, EventArgs e)
        {
            Handle_ItemSelected(typeof(DayVisitorView));
        }

        void OutlineTapped(object sender, EventArgs e)
        {
            Handle_ItemSelected(typeof(OutlineView));
        }

        void SettingTapped(object sender, EventArgs e)
        {
            Handle_ItemSelected(typeof(SettingView));
        }

        private void Handle_ItemSelected(Type targetType)
        {
            // HOMEなら別遷移
            if (targetType == typeof(TopView))
            {
                Application.Current.MainPage.Navigation.PopModalAsync();
            }

            //選択されたページをインスタンス化してNavigationPageを作成し、画面を遷移する
            Page displayPage = Activator.CreateInstance(targetType) as Page;

            if (displayPage != null)
            {
                var detail = new NavigationPage(displayPage)
                {
                    BarBackgroundColor = new Color(0.00, 0.44, 0.74),
                    BarTextColor = Color.White
                };

                this.Detail = detail;

                // Detail Pageに戻る
                this.IsPresented = false;
            }
        }
    }
}
