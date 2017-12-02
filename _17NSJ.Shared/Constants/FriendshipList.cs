using System;
using System.Collections.ObjectModel;
using _17NSJ.Models;

namespace _17NSJ.Constants
{
    public static class FriendshipList
    {
        static FriendshipList()
        {
            ObservableCollection<FriendshipModel> list = new ObservableCollection<FriendshipModel>();
            list.Add(new FriendshipModel() { Title = "大会全般", HashTag = "#17NSJ", ImagePath = "friendship_twitter.png", Url = "https://twitter.com/search?f=tweets&vertical=default&q=%2317NSJ&src=typd" });
            list.Add(new FriendshipModel() { Title = "交流会など", HashTag = "#17NSJ_Friendship", ImagePath = "friendship_twitter.png", Url = "https://twitter.com/search?f=tweets&q=%2317NSJ_Friendship&src=typd" });
            List = list;
        }

        public static readonly ObservableCollection<FriendshipModel> List;

    }
}
