using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using _17NSJ.Constants;
using _17NSJ.Models;
using _17NSJ.Util;
using Microsoft.AppCenter.Analytics;
using Newtonsoft.Json;
using Plugin.Geolocator;
using Plugin.Geolocator.Abstractions;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace _17NSJ.Views
{
    public partial class MapView : ContentPage
    {
        private List<Polygon> BaseAreaList;
        private List<Polygon> ProgramAreaList;
        private List<Polygon> SubCampAreaList;
        private List<Polygon> LifeFacilityAreaList;
        private List<Polygon> JamFacilityAreaList;
        private List<Pin> BasePinList;
        private List<Pin> ProgramPinList;
        private List<Pin> SubCampPinList;
        private List<Pin> LifeFacilityPinList;
        private List<Pin> JamFacilityPinList;

        private double? latitude = null;
        private double? longitude = null;

        private const string programLayerProp = "programLayer";
        private const string subCampLayerProp = "subCampLayer";
        private const string lifeFacilityLayerProp = "lifeFacilityLayer";
        private const string jamFacilityLayerProp = "jamFacilityLayer";

        public MapView(double latitude, double longitude)
        {
            InitializeView();

            this.latitude = latitude;
            this.longitude = longitude;
            DrawDistinationPin();
            this.map.InitialCameraUpdate = CameraUpdateFactory.NewPositionZoom(new Xamarin.Forms.GoogleMaps.Position(latitude, longitude), 17);
            indicator.IsVisible = false;
        }

        public MapView()
        {
            InitializeView();

            this.map.InitialCameraUpdate = CameraUpdateFactory.NewPositionZoom(new Xamarin.Forms.GoogleMaps.Position(37.4450000, 137.3256000), 15);
            indicator.IsVisible = false;
        }

        private void LayerVisibleClicked(object sender, System.EventArgs e)
        {
            this.categoryLayer.IsVisible = true;
        }

        private void LayerChangeClicked(object sender, System.EventArgs e)
        {
            this.map.Polygons.Clear();
            this.map.Pins.Clear();

            //Basicレイヤは必ず表示
            DrawPolygons(BaseAreaList);
            DrawPins(BasePinList);

            if (programLayerSwt.IsToggled)
            {
                DrawPolygons(ProgramAreaList);
                DrawPins(ProgramPinList);
            }

            if(subcampLayerSwt.IsToggled)
            {
                DrawPolygons(SubCampAreaList);
                DrawPins(SubCampPinList);
            }


            if (LifeFacilityLayerSwt.IsToggled)
            {
                DrawPolygons(LifeFacilityAreaList);
                DrawPins(LifeFacilityPinList);
            }

            if (JamFacilityLayerSwt.IsToggled)
            {
                DrawPolygons(JamFacilityAreaList);
                DrawPins(JamFacilityPinList);
            }

            //目的地座標がある場合はピンを描画
            if (this.latitude != null && this.longitude != null)
            {
                DrawDistinationPin();
            }

            //レイヤー状態を保持
            Application.Current.Properties[programLayerProp] = programLayerSwt.IsToggled;
            Application.Current.Properties[subCampLayerProp] = subcampLayerSwt.IsToggled;
            Application.Current.Properties[lifeFacilityLayerProp] = LifeFacilityLayerSwt.IsToggled;
            Application.Current.Properties[jamFacilityLayerProp] = JamFacilityLayerSwt.IsToggled;
            Application.Current.SavePropertiesAsync();

            this.categoryLayer.IsVisible = false;
        }

        private async void MyLocationClicked(object sender, System.EventArgs e)
        {
            if (CrossGeolocator.Current.IsListening)
            {
                await CrossGeolocator.Current.StartListeningAsync(TimeSpan.FromSeconds(5), 10, true);
            }

            IGeolocator locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 50;

            try
            {
                var position = await locator.GetLastKnownLocationAsync();

                if (position == null)
                {
                    position = await locator.GetPositionAsync(new TimeSpan(0, 0, 0, 10));
                }

                if (position is null) throw new Exception();

                if (37.444204 <= position.Latitude && position.Latitude <= 37.444350 &&  137.320980 <= position.Longitude && position.Longitude <=137.321402)
                {
                    this.easterBtn.IsVisible = true;
                }
                else
                {
                    this.easterBtn.IsVisible = false;
                }

                var cu = CameraUpdateFactory.NewPosition(new Xamarin.Forms.GoogleMaps.Position(position.Latitude, position.Longitude));
                await map.AnimateCamera(cu);
            }
            catch(Exception ex)
            {
                await DisplayAlert("位置情報を取得できません。"+ex.ToString(), "位置情報の使用許可を確認してください。", "OK");
            }
        }

        void MapClicked(object sender, MapClickedEventArgs e)
        {
            this.areaNameBox.IsVisible = false;
        }

        private void AreaCliked(object sender, System.EventArgs e)
        {
            this.areaNameBox.IsVisible = true;
            Polygon area = sender as Polygon;
            if (area != null) this.areaName.Text = area.Tag.ToString();
        }


        void EasterClicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SecretView("special_mt.png"));
        }

        private void InitializeView()
        {
            // トラッキングコード
            Analytics.TrackEvent("View", new Dictionary<string, string> { { "View", "MapView" } });

            InitializeComponent();
            this.map.MyLocationEnabled = true;
            this.map.UiSettings.ZoomControlsEnabled = false;

            InitLoadMapData();
        }

        private void InitLoadMapData()
        {
            //リストを作成
            BaseAreaList = GetPolygonList("_17NSJ.MapData.BaseArea.json");
            ProgramAreaList = GetPolygonList("_17NSJ.MapData.ProgramArea.json");
            SubCampAreaList = GetPolygonList("_17NSJ.MapData.SubCampArea.json");
            LifeFacilityAreaList = GetPolygonList("_17NSJ.MapData.LifeFacilityArea.json");
            JamFacilityAreaList = GetPolygonList("_17NSJ.MapData.JamFacilityArea.json");

            BasePinList = GetPinList("_17NSJ.MapData.BasePin.json");
            ProgramPinList = GetPinList("_17NSJ.MapData.ProgramPin.json");
            SubCampPinList = GetPinList("_17NSJ.MapData.SubCampPin.json");
            LifeFacilityPinList = GetPinList("_17NSJ.MapData.LifeFacilityPin.json");
            JamFacilityPinList = GetPinList("_17NSJ.MapData.JamFacilityPin.json");

            //初期表示用レイヤ選択
            bool? programLayer = null;
            bool? subCampLayer = null;
            bool? lifeFacilityLayer = null;
            bool? jamFacilityLayer = null;

            if (Application.Current.Properties.ContainsKey(programLayerProp))
            {
                programLayer = Application.Current.Properties[programLayerProp] as bool?;
            }

            if (Application.Current.Properties.ContainsKey(subCampLayerProp))
            {
                subCampLayer = Application.Current.Properties[subCampLayerProp] as bool?;
            }

            if (Application.Current.Properties.ContainsKey(lifeFacilityLayerProp))
            {
                lifeFacilityLayer = Application.Current.Properties[lifeFacilityLayerProp] as bool?;
            }

            if (Application.Current.Properties.ContainsKey(jamFacilityLayerProp))
            {
                jamFacilityLayer = Application.Current.Properties[jamFacilityLayerProp] as bool?;
            }

            //表示
            DrawPolygons(BaseAreaList);
            DrawPins(BasePinList);

            if ((programLayer is null) || ((bool)programLayer) == true)
            {
                DrawPolygons(ProgramAreaList);
                DrawPins(ProgramPinList);
                programLayerSwt.IsToggled = true;
            }

            if ((subCampLayer is null) || ((bool)subCampLayer) == true)
            {
                DrawPolygons(SubCampAreaList);
                DrawPins(SubCampPinList);
                subcampLayerSwt.IsToggled = true;
            }

            if ((lifeFacilityLayer is null) || ((bool)lifeFacilityLayer) == true)
            {
                DrawPolygons(LifeFacilityAreaList);
                DrawPins(LifeFacilityPinList);
                LifeFacilityLayerSwt.IsToggled = true;
            }

            if ((jamFacilityLayer is null) || ((bool)jamFacilityLayer) == true)
            {
                DrawPolygons(JamFacilityAreaList);
                DrawPins(JamFacilityPinList);
                JamFacilityLayerSwt.IsToggled = true;
            }
        }

        private List<Polygon> GetPolygonList(string fileName)
        {
            List<Polygon> list = new List<Polygon>();
            var assembly = typeof(MapView).GetTypeInfo().Assembly;
            System.IO.Stream polygonstream = assembly.GetManifestResourceStream(fileName);
            List<MapPolygonModel> polygons;

            using (var reader = new System.IO.StreamReader(polygonstream))
            {
                var json = reader.ReadToEnd();
                polygons = JsonConvert.DeserializeObject<List<MapPolygonModel>>(json);
            }

            foreach (var polygon in polygons)
            {
                list.Add(MapFactory.CreatePolygon(polygon, this.AreaCliked));
            }

            return list;
        }

        private List<Pin> GetPinList(string fileName)
        {
            List<Pin> list = new List<Pin>();
            var assembly = typeof(MapView).GetTypeInfo().Assembly;
            System.IO.Stream pinstream = assembly.GetManifestResourceStream(fileName);
            List<MapPinModel> pins;

            using (var reader = new System.IO.StreamReader(pinstream))
            {
                var json = reader.ReadToEnd();
                pins = JsonConvert.DeserializeObject<List<MapPinModel>>(json);
            }

            foreach (var pin in pins)
            {
                list.Add(MapFactory.CreatePin(pin));
            }

            return list;
        }

        private void DrawPolygons(List<Polygon> list)
        {
            foreach(Polygon item in list)
            {
                this.map.Polygons.Add(item);
            }
        }

        private void DrawPins(List<Pin> list)
        {
            foreach (Pin item in list)
            {
                this.map.Pins.Add(item);
            }
        }

        private void DrawDistinationPin()
        {
            Pin pin = new Pin();
            pin.Icon = BitmapDescriptorFactory.FromBundle("map_pin.png");
            pin.Label = "目的地";
            pin.ZIndex = int.MaxValue;
            pin.Position = new Xamarin.Forms.GoogleMaps.Position((double)this.latitude, (double)this.longitude);
            this.map.Pins.Add(pin);
        }

        protected override bool OnBackButtonPressed()
        {
            var p = this.Parent.Parent as MasterDetailView;

            if (p != null)
            {
                p.Detail = new TopView();
            }

            return true;
        }
    }
}
