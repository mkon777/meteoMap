using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoMap
{
    namespace CustomTypes
    {
        class Point
        {
            public float latitude, longtitude;

            public Point(float lat, float lng)
            {
                latitude   = lat;
                longtitude = lng;
            }
        }
    }
}
