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
            list.Add(new FriendshipModel() { Title = "交流会募集", HashTag = "#17NSJ_Friendship", ImagePath = "friendship_twitter.png", Url = "https://twitter.com/search?f=tweets&q=%2317NSJ_Friendship&src=typd" });
            list.Add(new FriendshipModel() { Title = "プログラム待ち時間共有", HashTag = "#17NSJ_WaitingTime", ImagePath = "friendship_twitter.png", Url = "https://twitter.com/search?f=tweets&q=%2317NSJ_WaitingTime&src=typd" });
            list.Add(new FriendshipModel() { Title = "広報部への取材依頼", HashTag = "#17NSJ_PR", ImagePath = "friendship_twitter.png", Url = "https://twitter.com/search?f=tweets&q=%2317NSJ_PR&src=typd" });
            list.Add(new FriendshipModel() { Title = "スカウト通信員が発信中", HashTag = "#スカウト通信員", ImagePath = "friendship_twitter.png", Url = "https://twitter.com/search?f=tweets&q=%23%E3%82%B9%E3%82%AB%E3%82%A6%E3%83%88%E9%80%9A%E4%BF%A1%E5%93%A1&src=typd" });
            List = list;
        }

        public static readonly ObservableCollection<FriendshipModel> List;

    }
}
