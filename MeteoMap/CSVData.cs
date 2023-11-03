using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoMap
{
    class CSVData
    {
        public DateTime date { get; set; }
        public DateTime time { get; set; }
        public float longtitude { get; set; }
        public float latitude { get; set; }
        public int pressure { get; set; }
        public int light { get; set; }
        public int humidity { get; set; }
        public int temperature { get; set; }
    }
}
