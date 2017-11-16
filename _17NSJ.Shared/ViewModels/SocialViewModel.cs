using System;
using System.Collections.ObjectModel;
using _17NSJ.Models;

namespace _17NSJ.ViewModels
{
    public class SocialViewModel : ViewModelBase
    {
        private ObservableCollection<Social> socialList;

        public ObservableCollection<Social> SocialList
        {
            get
            {
                return this.socialList;
            }

            set
            {
                if (this.socialList != value)
                {
                    this.socialList = value;
                    this.RaisePropertyChanged();
                }
            }
        }
    }
}
