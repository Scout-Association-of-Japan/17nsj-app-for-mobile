using _17NSJ.Models;
using _17NSJ.Views;
using System.Collections.ObjectModel;

namespace _17NSJ.Constants
{
    public class MasterMenu
    {
        static MasterMenu()
        {
            MasterMenuList = new ObservableCollection<MasterItem>()
            {
                new MasterItem() {Title = "HOME", IconSource="master_home.png", IsLineVisible=true ,TargetType = typeof(TopView)},
                new MasterItem() {Title = "NEWS＆INFO",IconSource="master_newsinfo.png", IsLineVisible=false  ,TargetType = typeof(NewsInfoView)},
                new MasterItem() {Title = "SCHEDULE",IconSource="master_schedule.png", IsLineVisible=false  ,TargetType = typeof(ScheduleView)},
                new MasterItem() {Title = "MAP",IconSource="master_map.png", IsLineVisible=false  ,TargetType = typeof(MapView)},
                new MasterItem() {Title = "ACTIVITY",IconSource="master_activity.png", IsLineVisible=true  ,TargetType = typeof(ActivityView)},
                new MasterItem() {Title = "WEATHER",IconSource="master_weather.png", IsLineVisible=false  ,TargetType = typeof(WeatherView)},
                new MasterItem() {Title = "SOCIAL",IconSource="master_social.png", IsLineVisible=false  ,TargetType = typeof(SocialView)},
                new MasterItem() {Title = "MOVIE",IconSource="master_movie.png", IsLineVisible=false  ,TargetType = typeof(MovieView)},
                new MasterItem() {Title = "NEWSPAPER",IconSource="master_newspaper.png", IsLineVisible=false  ,TargetType = typeof(NewspaperView)},
                new MasterItem() {Title = "FRIENDSHIP",IconSource="master_friendship.png", IsLineVisible=false  ,TargetType = typeof(FriendShipView)},
                new MasterItem() {Title = "SHOP INFO",IconSource="master_shop.png", IsLineVisible=false  ,TargetType = typeof(ShopInfoView)},
                new MasterItem() {Title = "DOCUMENT",IconSource="master_document.png", IsLineVisible=false  ,TargetType = typeof(DocumentView)},
                new MasterItem() {Title = "DAY VISITOR",IconSource="master_visitor.png", IsLineVisible=true  ,TargetType = typeof(DayVisitorView)},
                new MasterItem() {Title = "OUTLINE",IconSource="master_outline.png", IsLineVisible=true  ,TargetType = typeof(OutlineView)},
                new MasterItem() {Title = "SETTING",IconSource="master_setting.png", IsLineVisible=false  ,TargetType = typeof(SettingView)}
            };
        }


        public static readonly ObservableCollection<MasterItem> MasterMenuList;
    }
}