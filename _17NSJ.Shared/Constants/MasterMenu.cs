using _17NSJ.Models;
using _17NSJ.Views;
using System.Collections.ObjectModel;

namespace _17NSJ.Constants
{
    public class MasterMenu
    {
        static MasterMenu()
        {
            MasterMenuList = new ObservableCollection<MasterItemModel>()
            {
                new MasterItemModel() {Title = "ホーム", IconSource="master_home.png", IsLineVisible=true, TargetType = typeof(TopView)},
                new MasterItemModel() {Title = "NEWS＆INFO",IconSource="master_newsinfo.png", IsLineVisible=false, TargetType = typeof(NewsInfoView)},
                new MasterItemModel() {Title = "スケジュール",IconSource="master_schedule.png", IsLineVisible=false, TargetType = typeof(ScheduleView)},
                new MasterItemModel() {Title = "マップ",IconSource="master_map.png", IsLineVisible=false, TargetType = typeof(MapView)},
                new MasterItemModel() {Title = "プログラム",IconSource="master_activity.png", IsLineVisible=true, TargetType = typeof(ActivityView)},
                new MasterItemModel() {Title = "天気",IconSource="master_weather.png", IsLineVisible=false, TargetType = typeof(WeatherView)},
                new MasterItemModel() {Title = "ジャンボリー新聞",IconSource="master_newspaper.png", IsLineVisible=false, TargetType = typeof(NewspaperView)},
                new MasterItemModel() {Title = "公式アカウント",IconSource="master_social.png", IsLineVisible=false, TargetType = typeof(SocialView)},
                new MasterItemModel() {Title = "ムービー",IconSource="master_movie.png", IsLineVisible=false, TargetType = typeof(MovieView)},
                new MasterItemModel() {Title = "フレンドシップ",IconSource="master_friendship.png", IsLineVisible=false, TargetType = typeof(FriendShipView)},
                new MasterItemModel() {Title = "プラザ",IconSource="master_shop.png", IsLineVisible=false, TargetType = typeof(ShopInfoView)},
                new MasterItemModel() {Title = "スポンサー",IconSource="master_sponsor.png", IsLineVisible=false, TargetType = typeof(SponsorView)},
                new MasterItemModel() {Title = "各種資料",IconSource="master_document.png", IsLineVisible=false, TargetType = typeof(DocumentView)},
                new MasterItemModel() {Title = "見学情報",IconSource="master_visitor.png", IsLineVisible=true, TargetType = typeof(DayVisitorView)},
                new MasterItemModel() {Title = "概要",IconSource="master_outline.png", IsLineVisible=true, TargetType = typeof(OutlineView)},
                new MasterItemModel() {Title = "その他",IconSource="master_setting.png", IsLineVisible=false, TargetType = typeof(SettingView)}
            };
        }

        public static readonly ObservableCollection<MasterItemModel> MasterMenuList;
    }
}