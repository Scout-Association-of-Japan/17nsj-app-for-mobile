using System;

using Xamarin.Forms;

namespace _17NSJ.Models
{
    public class NewsInfo : NotificationObject
    {
        private string thumbnailURL;
        public string ThumbnailURL
        {
            get
            {
                return this.thumbnailURL;
            }

            set
            {
                if (this.thumbnailURL != value)
                {
                    this.thumbnailURL = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        private string serialId;
        public string SerialId
        {
            get
            {
                return this.serialId;
            }

            set
            {
                if (this.serialId != value)
                {
                    this.serialId = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        private DateTime createdAt;
        public DateTime CreatedAt
        {
            get
            {
                return this.createdAt;
            }

            set
            {
                if (this.createdAt != value)
                {
                    this.createdAt = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        private string author;
        public string Author
        {
            get
            {
                return this.author;
            }

            set
            {
                if (this.author != value)
                {
                    this.author = value;
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

        private string color;
        public string Color
        {
            get
            {
                return this.color;
            }

            set
            {
                if (this.color != value)
                {
                    this.color = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        private string mediaURL;
        public string MediaURL
        {
            get
            {
                return this.mediaURL;
            }

            set
            {
                if (this.mediaURL != value)
                {
                    this.mediaURL = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        private string outline;
        public string Outline
        {
            get
            {
                return this.outline;
            }

            set
            {
                if (this.outline != value)
                {
                    this.outline = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        private string category;
        public string Category
        {
            get
            {
                return this.category;
            }

            set
            {
                if (this.category != value)
                {
                    this.category = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        private string relationalURL;
        public string RelationalURL
        {
            get
            {
                return this.relationalURL;
            }

            set
            {
                if (this.relationalURL != value)
                {
                    this.relationalURL = value;
                    this.RaisePropertyChanged();
                }
            }
        }
    }
}

