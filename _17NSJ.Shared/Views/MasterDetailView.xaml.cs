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

            //Masterに項目を追加
            listView.ItemsSource = MasterMenu.MasterMenuList;

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



        private void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            // 選択された画面を抽出      
            var nextView = MasterMenu.MasterMenuList.Where(a => a == e.SelectedItem).FirstOrDefault();

            // HOMEなら別遷移
            if (nextView.TargetType == typeof(TopView))
            {
                Application.Current.MainPage.Navigation.PopModalAsync();
            }

            //選択されたページをインスタンス化してNavigationPageを作成し、画面を遷移する
            Page displayPage = Activator.CreateInstance(nextView.TargetType) as Page;

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
