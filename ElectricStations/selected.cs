using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Windows.Devices.Geolocation;
namespace WindowsFormsApp1
{
    public partial class selected : Form
    {
        int id;
        int Zoom;
        double lat;
        double lng;
        List<RootObject> myObj;
        GMapOverlay routeOverlay;
        public selected(table sl)
        {
            InitializeComponent();
            id = sl.id;
            myObj = sl.myObj;
        }

        private void Selected_Load(object sender, EventArgs e)
        {
            GMapOverlay overlay = new GMapOverlay();
            lng = myObj.ElementAt(id).Cells.geoData.coordinates.ElementAt(0);
            lat = myObj.ElementAt(id).Cells.geoData.coordinates.ElementAt(1);
            var gMarker = new GMarkerGoogle(new GMap.NET.PointLatLng(lat, lng), GMarkerGoogleType.green);
            overlay.Markers.Add(gMarker);
            gMapControl1.Overlays.Add(overlay);
            getGeo();
            RefreshMap();
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

            gMapControl1.MapProvider =
            GMap.NET.MapProviders.GMapProviders.GoogleMap;
            GMap.NET.GMaps.Instance.Mode =
                GMap.NET.AccessMode.ServerOnly;

            gMapControl1.IgnoreMarkerOnMouseWheel = true;

            GMap.NET.MapProviders.GMapProvider.WebProxy =
                System.Net.WebRequest.GetSystemWebProxy();
            GMap.NET.MapProviders.GMapProvider.WebProxy.Credentials =
                System.Net.CredentialCache.DefaultCredentials;

            Zoom = (int)gMapControl1.Zoom;
            gMapControl1.Position = new GMap.NET.PointLatLng(55.75393, 37.620795);

            gMapControl1.OnMarkerDoubleClick += GMapControl1_OnMarkerDoubleClick;
            gMapControl1.MouseWheel += GMapControl1_MouseWheel;
        }

        private void GMapControl1_MouseWheel(object sender, MouseEventArgs e)
        {
            Zoom = (int)this.gMapControl1.Zoom;
        }

        private void GMapControl1_OnMarkerDoubleClick(GMapMarker item, MouseEventArgs e)
        {
            routeOverlay = new GMapOverlay();
            routeOverlay.Clear();
            var myGeo = new GMap.NET.PointLatLng(lat, lng);
            var route = GMap.NET.MapProviders.OpenStreetMapProvider.Instance.GetRoute(myGeo, item.Position, false, false, Zoom);
            var r = new GMapRoute(route);
            r.Stroke.Width = 3;
            r.Stroke.Color = Color.Red;
            routeOverlay.Routes.Add(r);
            gMapControl1.Overlays.Add(routeOverlay);
            RefreshMap();
        }

        public async void getGeo()
        {
            var locator = new Geolocator();
            var location = await locator.GetGeopositionAsync();
            lat = location.Coordinate.Point.Position.Latitude;
            lng = location.Coordinate.Point.Position.Longitude;
            GMapOverlay mOverlay = new GMapOverlay();
            var myGeo = new GMarkerGoogle(new GMap.NET.PointLatLng(lat, lng), GMarkerGoogleType.lightblue_dot);
            mOverlay.Markers.Add(myGeo);
            gMapControl1.Overlays.Add(mOverlay);
            RefreshMap();
        }
        public void RefreshMap()
        {
            gMapControl1.Zoom = Zoom - 1;
            gMapControl1.Zoom = Zoom + 1;
        }
    }
}
