using System;
using System.Collections.ObjectModel;
using _17NSJ.Models;

namespace _17NSJ.Constants
{
    public static class SocialList
    {
        static SocialList()
        {
            ObservableCollection<Social> list = new ObservableCollection<Social>();
            list.Add(new Social() { Title = "Official Site", ImagePath = "social_17nsj.png", Url = "https://www.scout.or.jp/17nsj/" });
            list.Add(new Social() { Title = "Facebook", ImagePath = "social_facebook.png", Url = "https://www.facebook.com/scout.or.jp/" });
            list.Add(new Social() { Title = "Twitter", ImagePath = "social_twitter.png", Url = "https://twitter.com/ScoutingJapan" });
            list.Add(new Social() { Title = "Youtube", ImagePath = "social_youtube.png", Url = "https://www.youtube.com/user/ScoutingJapan" });
            list.Add(new Social() { Title = "Instagram", ImagePath = "social_instagram.png", Url = "https://www.instagram.com/scout_association_of_japan/" });
            list.Add(new Social() { Title = "flickr", ImagePath = "social_flickr.png", Url = "https://www.flickr.com/photos/scout_associaton_of_japan/" });
            List = list;
        }

        public static readonly ObservableCollection<Social> List;

    }
}
