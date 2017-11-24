using System;
using System.Collections.ObjectModel;
using _17NSJ.Models;
using _17NSJ.Views;

namespace _17NSJ.Constants
{
    public static class MasterMenu
    {
        static MasterMenu()
        {
            MasterMenuList = new ObservableCollection<MasterItem>()
            {
                new MasterItem() {Title = "Home", IconSource="master_home.png" ,TargetType = typeof(TopView)},
                new MasterItem() {Title = "NEWS&INFO", IconSource="master_newsinfo.png" ,TargetType = typeof(NewsInfoView)},
                new MasterItem() {Title = "SCHEDULE", IconSource="master_schedule.png" ,TargetType = typeof(ScheduleView)},
                new MasterItem() {Title = "MAP", IconSource="master_map.png" ,TargetType = typeof(MapView)},
                new MasterItem() {Title = "ACTIVITY", IconSource="master_activity.png" ,TargetType = typeof(ActivityView)},
                new MasterItem() {Title = "WEATHER", IconSource="master_weather.png" ,TargetType = typeof(WeatherView)},
                new MasterItem() {Title = "SOCIAL", IconSource="master_social.png" ,TargetType = typeof(SocialView)},
                new MasterItem() {Title = "MOVIE", IconSource="master_movie.png" ,TargetType = typeof(MovieView)},
                new MasterItem() {Title = "NEWSPAPER", IconSource="master_newspaper.png" ,TargetType = typeof(NewspaperView)},
                new MasterItem() {Title = "FRIENDSHIP", IconSource="master_friendship.png" ,TargetType = typeof(FriendShipView)},
                new MasterItem() {Title = "SHOP INFO", IconSource="master_shop.png" ,TargetType = typeof(ShopInfoView)},
                new MasterItem() {Title = "DOCUMENT", IconSource="master_document.png" ,TargetType = typeof(DocumentView)},
                new MasterItem() {Title = "DAY VISITOR", IconSource="master_visitor.png" ,TargetType = typeof(DayVisitorView)},
                new MasterItem() {Title = "OUTLINE", IconSource="master_outline.png" ,TargetType = typeof(OutlineView)},
                new MasterItem() {Title = "SETTING", IconSource="master_setting.png" ,TargetType = typeof(SettingView)}
            };
        }


        public static readonly ObservableCollection<MasterItem> MasterMenuList;
    }
}
