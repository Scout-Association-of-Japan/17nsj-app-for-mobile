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
                new MasterItem() {Title = "Home", IconSource="icon.png" ,TargetType = typeof(TopView)}
            };
        }


        public static readonly ObservableCollection<MasterItem> MasterMenuList;
    }
}
