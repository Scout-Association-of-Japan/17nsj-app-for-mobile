using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace _17NSJ.Controls
{
    public partial class KeyValueCell : ViewCell
    {
        public KeyValueCell()
        {
            InitializeComponent();
        }

        public string Key
        {
            get { return this.key.Text; }
            set { this.key.Text = value; }
        }

        public string Value
        {
            get { return this.value.Text; }
            set { this.value.Text = value;}
        }
    }
}
