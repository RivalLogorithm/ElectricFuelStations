using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Windows.Devices.Geolocation;
using GMap.NET.MapProviders;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string url = "https://apidata.mos.ru/v1/datasets/2985/rows?api_key=c4276baf1a898907807621899e9d579d&$top=10000";
        string json = "";
        List<RootObject> myObj;
        List<string> adm = new List<string>();
        List<string> dist = new List<string>();
        int Zoom;
        GMapMarker gMarker;
        GMapMarker myGeo;
        GMapOverlay geoOverlay;
        // Bitmap bitMarker = (Bitmap)Image.FromFile("car.png");
        double x;
        double y;
        double lat;
        double lng;
        bool fl1 = false;
        GMapOverlay routeOverlay = new GMapOverlay();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            UrlToText();
            Deserialization();
            foreach (var el in myObj)
            {
                if (!adm.Contains(el.Cells.AdmArea))
                    adm.Add(el.Cells.AdmArea);
            }
            foreach (var el in adm)
            {
                comboAdm.Items.Add(el);
            }
            foreach (var el in myObj)
            {
                if (!dist.Contains(el.Cells.District))
                    dist.Add(el.Cells.District);
            }
            foreach (var el in dist)
            {
                comboDist.Items.Add(el);
            }
            getGeo();
            MessageBox.Show("Вас приветствует ChargeStation v.1.0., чтобы получить информацию о маркере " +
                "нажмите на него левой кнопкой мыши, чтобы проложить к нему маршрут нажмите на него дважды");
            comboBox1.Items.AddRange(new string[] { "Уличные", "Спутниковые", "Гибридные" });
            comboBox1.Text = "Уличные";
            setMarkers();
        }

        private void GMapControl1_Load(object sender, EventArgs e)
        {
            gMapControl1.Bearing = 0;

            gMapControl1.ShowCenter = false;

            gMapControl1.CanDragMap = true;

            gMapControl1.DragButton = MouseButtons.Left;

            gMapControl1.GrayScaleMode = true;

            gMapControl1.MarkersEnabled = true;

            gMapControl1.MaxZoom = 18;

            gMapControl1.MinZoom = 2;

            gMapControl1.MouseWheelZoomType =
                GMap.NET.MouseWheelZoomType.MousePositionAndCenter;

            gMapControl1.NegativeMode = false;

            gMapControl1.PolygonsEnabled = true;

            gMapControl1.RoutesEnabled = true;

            gMapControl1.ShowTileGridLines = false;

            gMapControl1.Zoom = 12;

            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            GMapProviders.GoogleMap.ApiKey = "your_api_key"; // Для работы маршрутов, здесь необходимо указать API ключ для GoogleMaps
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;

            gMapControl1.IgnoreMarkerOnMouseWheel = true;

            GMapProvider.WebProxy = WebRequest.GetSystemWebProxy();
            GMapProvider.WebProxy.Credentials = CredentialCache.DefaultCredentials;

            Zoom = (int)gMapControl1.Zoom;
            gMapControl1.Position = new GMap.NET.PointLatLng(55.75393, 37.620795);

            gMapControl1.OnMarkerClick += GMapControl1_OnMarkerClick;
            gMapControl1.OnMarkerDoubleClick += GMapControl1_OnMarkerDoubleClick;
            gMapControl1.MouseWheel += GMapControl1_MouseWheel;
        }

        private void GMapControl1_MouseWheel(object sender, MouseEventArgs e)
        {
            Zoom = (int)this.gMapControl1.Zoom;
        }

        private void GMapControl1_OnMarkerDoubleClick(GMapMarker item, MouseEventArgs e)
        {
            routeOverlay.Clear();
            var myGeo = new GMap.NET.PointLatLng(lat, lng);
            var route = GoogleMapProvider.Instance.GetRoute(myGeo, item.Position, false, false, Zoom);
            var r = new GMapRoute(route);
            r.Stroke.Width = 3;
            r.Stroke.Color = Color.Red;
            routeOverlay.Routes.Add(r);
            gMapControl1.Overlays.Add(routeOverlay);
            RefreshMap();
        }

        private void GMapControl1_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            foreach (var el in myObj)
            {
                if (item.Position.Lng == el.Cells.geoData.coordinates.ElementAt(0)
                    && item.Position.Lat == el.Cells.geoData.coordinates.ElementAt(1))
                {
                    textBox_mInfo.Text = "Административный округ: " + el.Cells.AdmArea + "\r\n\r\n" +
                        "Район: " + el.Cells.District + "\r\n\r\n" + "Адрес: " + el.Cells.Address + "\r\n\r\n" + "Название: " + el.Cells.Name;
                }
            }
        }


        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text=="Уличные")
            {
                gMapControl1.MapProvider = GMapProviders.GoogleMap;
            }
            else if(comboBox1.Text=="Спутниковые")
            {
                gMapControl1.MapProvider = GMapProviders.GoogleSatelliteMap;
            }
            else if(comboBox1.Text=="Гибридные")
            {
                gMapControl1.MapProvider = GMapProviders.GoogleHybridMap;
            }
        }

        public void Deserialization()
        {
            myObj = JsonConvert.DeserializeObject<List<RootObject>>(json);
        }

        public void UrlToText()
        {
            WebClient web = new WebClient();
            web.Encoding = Encoding.UTF8;
            web.Proxy = new WebProxy();
            json = web.DownloadString(url);
        }

        public void setMarkers()
        {
            GMapOverlay overlay = new GMapOverlay();
            foreach (var el in myObj)
            {
                x = el.Cells.geoData.coordinates.ElementAt(0);
                y = el.Cells.geoData.coordinates.ElementAt(1);
                gMarker = new GMarkerGoogle(new GMap.NET.PointLatLng(y,x), GMarkerGoogleType.green);
                overlay.Markers.Add(gMarker);
            }
            gMapControl1.Overlays.Add(overlay);
            RefreshMap();
        }

        private void Button_accept_Click(object sender, EventArgs e)
        {
            List<RootObject> cache = myObj;
            List<RootObject> buf = new List<RootObject>();
            GMapOverlay filterOverlay = new GMapOverlay();
            if (fl1 == false)
            {
                gMapControl1.Overlays.Clear();
                if (comboAdm.SelectedIndex > -1)
                {
                    foreach (var el in cache)
                    {
                        if (el.Cells.AdmArea == comboAdm.Text)
                        {
                            buf.Add(el);
                        }
                    }
                    cache = buf.ToList();
                    buf.Clear();
                }
                if (comboDist.SelectedIndex > -1)
                {
                    foreach (var el in cache)
                    {
                        if (el.Cells.District == comboDist.Text)
                        {
                            buf.Add(el);
                        }
                    }
                    cache = buf.ToList();
                    buf.Clear();
                }
                foreach (var el in cache)
                {
                    x = el.Cells.geoData.coordinates.ElementAt(0);
                    y = el.Cells.geoData.coordinates.ElementAt(1);
                    GMapMarker gMap = new GMarkerGoogle(new GMap.NET.PointLatLng(y, x), GMarkerGoogleType.green);
                    filterOverlay.Markers.Add(gMap);
                }
                gMapControl1.Overlays.Add(filterOverlay);
                gMapControl1.Overlays.Add(geoOverlay);
                RefreshMap();
                fl1 = true;
            }
            else
            {
                MessageBox.Show("Сбросьте фильтр");
                return;
            }
        }

        private void Button_reload_Click(object sender, EventArgs e)
        {
            if (fl1 == true)
            {
                gMapControl1.Overlays.Clear();
                setMarkers();
                gMapControl1.Overlays.Add(geoOverlay);
                comboAdm.SelectedIndex = -1;
                comboAdm.Text = "Выберите";
                comboDist.SelectedIndex = -1;
                comboDist.Text = "Выберите";
                fl1 = false;
            }
            else if(comboAdm.SelectedIndex > -1 || comboDist.SelectedIndex > -1)
            {
                comboAdm.SelectedIndex = -1;
                comboAdm.Text = "Выберите";
                comboDist.SelectedIndex = -1;
                comboDist.Text = "Выберите";
            }
            else
            {
                MessageBox.Show("Фильтр уже сброшен");
                return;
            }
            RefreshMap();
        }

        private void Button_showInfo_Click(object sender, EventArgs e)
        {
            info info = new info();
            info.ShowDialog();
        }

        public async void getGeo()
        {
            var locator = new Geolocator();
            var location = await locator.GetGeopositionAsync();
            lat = location.Coordinate.Point.Position.Latitude;
            lng = location.Coordinate.Point.Position.Longitude;
            geoOverlay = new GMapOverlay();
            myGeo = new GMarkerGoogle(new GMap.NET.PointLatLng(lat, lng), GMarkerGoogleType.lightblue_dot);
            geoOverlay.Markers.Add(myGeo);
            gMapControl1.Overlays.Add(geoOverlay);
            RefreshMap();
        }
        public void RefreshMap()
        {
            gMapControl1.Zoom = Zoom - 1;
            gMapControl1.Zoom = Zoom + 1;
        }

        private void Button_clearRoutes_Click(object sender, EventArgs e)
        {
            routeOverlay.Clear();
        }

        private void Button_nearRoute_Click(object sender, EventArgs e)
        {
            routeOverlay.Clear();
            
            double dist;
            var nObj = new RootObject();
            GMap.NET.MapRoute shortestRoute = new GMap.NET.MapRoute("shortest");
            var myGeo = new GMap.NET.PointLatLng(lat, lng);
            var tmproute = GoogleMapProvider.Instance.GetRoute(myGeo, (new GMap.NET.PointLatLng(myObj.ElementAt(0).Cells.geoData.coordinates.ElementAt(1),
                myObj.ElementAt(0).Cells.geoData.coordinates.ElementAt(0))), false, false, Zoom);
            double tmp = tmproute.Distance;
            foreach (var el in myObj)
            {
                var item = new GMap.NET.PointLatLng(el.Cells.geoData.coordinates.ElementAt(1), el.Cells.geoData.coordinates.ElementAt(0));
                var route = GoogleMapProvider.Instance.GetRoute(myGeo, item, false, false, Zoom);
                dist = route.Distance;
                if (dist < tmp)
                {
                    tmp = dist;
                    shortestRoute = route;
                    nObj = el;
                }
            }
            var r = new GMapRoute(shortestRoute);
            r.Stroke.Color = Color.Red;
            r.Stroke.Width = 3;
            routeOverlay.Routes.Add(r);
            gMapControl1.Overlays.Add(routeOverlay);
            RefreshMap();
            textBox_mInfo.Text = "Административный округ: " + nObj.Cells.AdmArea + "\r\n\r\n" +
                       "Район: " + nObj.Cells.District + "\r\n\r\n" + "Адрес: " + nObj.Cells.Address + "\r\n\r\n" + "Название: " + nObj.Cells.Name;
        }

        private void Button_table_Click(object sender, EventArgs e)
        {
            table t = new table(myObj);
            t.ShowDialog();
        }
    }

}
