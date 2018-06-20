using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Xamarin.Forms;

namespace _17NSJ.Models
{
    public class GoodsByCategory
    {
        public string CategoryName { get; set; }
        public List<JamGoodsModel> Goods { set; get; }
        public Command Tapped { get; set;  }
    }
}
