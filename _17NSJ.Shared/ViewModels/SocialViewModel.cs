using System;
using System.Collections.ObjectModel;
using _17NSJ.Models;

namespace _17NSJ.ViewModels
{
    public class SocialViewModel : ViewModelBase
    {
        public SocialViewModel()
        {
            ObservableCollection<Social> list = new ObservableCollection<Social>();
            list.Add(new Social() { Title = "Official Site", ImagePath = "https://abs.twimg.com/icons/apple-touch-icon-192x192.png", Url = "hhtp" });
            list.Add(new Social() { Title = "Facebook", ImagePath = "https://www.facebook.com/images/fb_icon_325x325.png", Url = "hhtp" });
            list.Add(new Social() { Title = "Twitter", ImagePath = "https://abs.twimg.com/icons/apple-touch-icon-192x192.png", Url = "hhtp" });
            list.Add(new Social() { Title = "Youtube", ImagePath = "https://lh3.googleusercontent.com/Ned_Tu_ge6GgJZ_lIO_5mieIEmjDpq9kfgD05wapmvzcInvT4qQMxhxq_hEazf8ZsqA=w300", Url = "hhtp" });
            list.Add(new Social() { Title = "Instagram", ImagePath = "https://lh3.googleusercontent.com/aYbdIM1abwyVSUZLDKoE0CDZGRhlkpsaPOg9tNnBktUQYsXflwknnOn2Ge1Yr7rImGk=w300", Url = "hhtp" });
            list.Add(new Social() { Title = "flickr", ImagePath = "https://pbs.twimg.com/profile_images/666413114489831424/aJZNErvd.png", Url = "hhtp" });
            this.socialList = list;
        }

        private ObservableCollection<Social> socialList;

        public ObservableCollection<Social> SocialList
        {
            get
            {
                return this.socialList;
            }
        }
    }
}
