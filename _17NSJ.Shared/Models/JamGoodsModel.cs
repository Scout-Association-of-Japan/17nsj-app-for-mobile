using System;
using Newtonsoft.Json;

namespace _17NSJ.Models
{
    public class JamGoodsModel
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Size { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int DisplayNumber { get; set; }
        public bool? Stock { get; set; }
        public DateTime StockUpdatedAt { get; set; }
    }
}
