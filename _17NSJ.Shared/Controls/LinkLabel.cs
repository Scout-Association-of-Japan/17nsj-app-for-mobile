using System;
using Xamarin.Forms;

namespace _17NSJ.Controls
{
    public class LinkLabel : Label
    {
        public string Uri { get; set; }

        public LinkLabel() : base()
        {
            this.TextColor = Color.FromHex("#5ebcd7");

            var tgr = new TapGestureRecognizer();
            tgr.Tapped += (sender, e) => OnClicked(sender, e);
            this.GestureRecognizers.Add(tgr);
        }

        private void OnClicked(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(Uri))
            {
                Device.OpenUri(new Uri(Uri));
            }
        }
    }
}
