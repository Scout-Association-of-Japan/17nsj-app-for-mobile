using System;
using _17NSJ.Models;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace _17NSJ.Util
{
    public static class MapFactory
    {
        public static Pin CreatePin(MapPinModel pinObj)
        {
            Pin pin = new Pin();

            if (string.IsNullOrEmpty(pinObj.IconName))
            {
                pin.Type = PinType.Place;
            }
            else
            {
                pin.Icon = BitmapDescriptorFactory.FromBundle(pinObj.IconName);
            }

            pin.Label = pinObj.Label;
            pin.Position = new Position(pinObj.Position[1], pinObj.Position[0]);

            return pin;
        }

        public static Polygon CreatePolygon(MapPolygonModel polygonObj)
        {
            Polygon polygon = new Polygon();
            polygon.Tag = polygonObj.Tag;
            polygon.StrokeWidth = polygonObj.StrokeWidth;
            polygon.StrokeColor = Color.FromHex(polygonObj.StrokeColor);
            polygon.FillColor = Color.FromHex(polygonObj.FillColor);

            foreach (var point in polygonObj.Points)
            {
                polygon.Positions.Add(new Position(point[1], point[0]));
            }

            return polygon;
        }
    }
}
