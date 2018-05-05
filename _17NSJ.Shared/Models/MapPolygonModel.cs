using System;
using System.Collections.Generic;

namespace _17NSJ.Models
{
    public class MapPolygonModel
    {
        public string Tag { get; set; }
        public float StrokeWidth { get; set; }
        public string StrokeColor { get; set; }
        public string FillColor { get; set; }
        public List<List<double>> Points { get; set; }
    }
}
