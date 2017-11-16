using System;
namespace _17NSJ.Models
{
    public class Social:NotificationObject
    {
        private string imagePath;
        public string ImagePath
        {
            get
            {
                return this.imagePath;
            }

            set
            {
                if (this.imagePath != value)
                {
                    this.imagePath = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        private string title;
        public string Title
        {
            get
            {
                return this.title;
            }

            set
            {
                if (this.title != value)
                {
                    this.title = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        private string url;
        public string Url
        {
            get
            {
                return this.url;
            }

            set
            {
                if (this.url != value)
                {
                    this.url = value;
                    this.RaisePropertyChanged();
                }
            }
        }
    }
}
