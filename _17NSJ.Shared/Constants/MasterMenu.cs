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
                new MasterItemModel() {Title = "HOME", IconSource="master_home.png", IsLineVisible=true, TargetType = typeof(TopView)},
                new MasterItemModel() {Title = "NEWS＆INFO",IconSource="master_newsinfo.png", IsLineVisible=false, TargetType = typeof(NewsInfoView)},
                new MasterItemModel() {Title = "SCHEDULE",IconSource="master_schedule.png", IsLineVisible=false, TargetType = typeof(ScheduleView)},
                new MasterItemModel() {Title = "MAP",IconSource="master_map.png", IsLineVisible=false, TargetType = typeof(MapView)},
                new MasterItemModel() {Title = "ACTIVITY",IconSource="master_activity.png", IsLineVisible=true, TargetType = typeof(ActivityView)},
                new MasterItemModel() {Title = "WEATHER",IconSource="master_weather.png", IsLineVisible=false, TargetType = typeof(WeatherView)},
                new MasterItemModel() {Title = "SOCIAL",IconSource="master_social.png", IsLineVisible=false, TargetType = typeof(SocialView)},
                new MasterItemModel() {Title = "MOVIE",IconSource="master_movie.png", IsLineVisible=false, TargetType = typeof(MovieView)},
                //new MasterItemModel() {Title = "NEWSPAPER",IconSource="master_newspaper.png", IsLineVisible=false, TargetType = typeof(NewspaperView)},
                new MasterItemModel() {Title = "FRIENDSHIP",IconSource="master_friendship.png", IsLineVisible=false, TargetType = typeof(FriendShipView)},
                //new MasterItemModel() {Title = "SHOP INFO",IconSource="master_shop.png", IsLineVisible=false, TargetType = typeof(ShopInfoView)},
                new MasterItemModel() {Title = "DOCUMENT",IconSource="master_document.png", IsLineVisible=false, TargetType = typeof(DocumentView)},
                //new MasterItemModel() {Title = "DAY VISITOR",IconSource="master_visitor.png", IsLineVisible=true, TargetType = typeof(DayVisitorView)},
                new MasterItemModel() {Title = "OUTLINE",IconSource="master_outline.png", IsLineVisible=true, TargetType = typeof(OutlineView)},
                //new MasterItemModel() {Title = "SPONSOR",IconSource="master_sponsor.png", IsLineVisible=true, TargetType = typeof(SponsorView)},
                new MasterItemModel() {Title = "SETTING",IconSource="master_setting.png", IsLineVisible=false, TargetType = typeof(SettingView)}
            };
        }


        public static readonly ObservableCollection<MasterItemModel> MasterMenuList;
    }
}