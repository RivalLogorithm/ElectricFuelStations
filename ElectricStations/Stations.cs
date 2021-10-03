using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class GeoData
    {
        public string type { get; set; }
        public List<double> coordinates { get; set; }
    }

    public class Cells
    {
        public int global_id { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public GeoData geoData { get; set; }
    }

    public class RootObject
    {
        public int global_id { get; set; }
        public int Number { get; set; }
        public Cells Cells { get; set; }
    }
}
