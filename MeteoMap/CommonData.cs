using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoMap
{
    public enum DataMode
    {
        NONE,
        VALUE,
        VALUE_DATE,
        VALUE_TIME,
        VALUE_DATE_TIME,
        DATE,
        DATE_TIME,
        TIME
    };

    enum DataType
    {
        LONGTITUDE,
        LATITUDE,
        PRESSURE,
        LIGHT,
        HUMIDITY,
        TEMPERATURE
    };

    class CommonData
    {
        public static DataMode dataMode = DataMode.NONE;
        public static DataType dataType = DataType.TEMPERATURE;
        public static double pointSize = 20;

        public class Filters
        {
            public static DateTime maxDateTime = new DateTime(1800, 1, 1, 0, 0, 1),
                     minDateTime = new DateTime(7777, 12, 31, 11, 59, 59);
        }

        public class Min
        {
            public static float longtitude = 0,
                         latitude = 0;
            public static int pressure = 0,
                       light = 0,
                       humidity = 0,
                       temperature = 0;

            public static float GetForColor()
            {
                switch (dataType)
                {
                    case DataType.HUMIDITY:
                        return 0; // 100% humi
                    case DataType.LIGHT:
                        return 0; // 100000lx, full sunligt
                    case DataType.PRESSURE:
                        return 860;
                    case DataType.TEMPERATURE:
                        return -40;
                }
                return float.NaN;
            }

            public static float Get()
            {
                switch (dataType)
                {
                    case DataType.HUMIDITY:
                        return humidity;
                    case DataType.LATITUDE:
                        return latitude;
                    case DataType.LIGHT:
                        return light;
                    case DataType.LONGTITUDE:
                        return longtitude;
                    case DataType.PRESSURE:
                        return pressure;
                    case DataType.TEMPERATURE:
                        return temperature;
                }

                return float.NaN;
            }
        }

        public class Max
        {
            public static float longtitude = 0,
                         latitude = 0;
            public static int pressure = 0,
                       light = 0,
                       humidity = 0,
                       temperature = 0;

            public static float GetForColor()
            {
                switch (dataType)
                {
                    case DataType.HUMIDITY:
                        return 100; // 100% humi
                    case DataType.LIGHT:
                        return 100000; // 100000lx, full sunligt
                    case DataType.PRESSURE:
                        return 1090;
                    case DataType.TEMPERATURE:
                        return 60;
                }
                return float.NaN;
            }

            public static float Get()
            {
                switch (dataType)
                {
                    case DataType.HUMIDITY:
                        return humidity;
                    case DataType.LATITUDE:
                        return latitude;
                    case DataType.LIGHT:
                        return light;
                    case DataType.LONGTITUDE:
                        return longtitude;
                    case DataType.PRESSURE:
                        return pressure;
                    case DataType.TEMPERATURE:
                        return temperature;
                }

                return float.NaN;
            }
        }

        public class Mid
        {
            public static float longtitude = 0,
                         latitude = 0;
            public static int pressure = 0,
                       light = 0,
                       humidity = 0,
                       temperature = 0;

            public static float GetForColor()
            {
                switch (dataType)
                {
                    case DataType.HUMIDITY:
                        return (100 + 0) / 2; // 100% humi
                    case DataType.LIGHT:
                        return 10000; // 10000lx, day light (not direct sunlight)
                    case DataType.PRESSURE:
                        return (1090 + 860) / 2;
                    case DataType.TEMPERATURE:
                        return (60 - 40) / 2;
                }
                return float.NaN;
            }

            public static float Get()
            {
                switch (dataType)
                {
                    case DataType.HUMIDITY:
                        return humidity;
                    case DataType.LATITUDE:
                        return latitude;
                    case DataType.LIGHT:
                        return light;
                    case DataType.LONGTITUDE:
                        return longtitude;
                    case DataType.PRESSURE:
                        return pressure;
                    case DataType.TEMPERATURE:
                        return temperature;
                }

                return float.NaN;
            }
        }
        public static float GetPointValue(CSVData item)
        {
            switch (dataType)
            {
                case DataType.HUMIDITY:
                    return item.humidity;
                case DataType.LATITUDE:
                    return item.latitude;
                case DataType.LIGHT:
                    return item.light;
                case DataType.LONGTITUDE:
                    return item.longtitude;
                case DataType.PRESSURE:
                    return item.pressure;
                case DataType.TEMPERATURE:
                    return item.temperature;
            }

            return float.NaN;
        }

        public static Color PrepareColor(float val)
        {
            int r = 0, g = 0, b = 0;
            float mid = CommonData.Mid.GetForColor();
            float min = CommonData.Min.GetForColor();
            float max = CommonData.Max.GetForColor();

            if (val >= mid)
            {
                r = (int)Math.Round(255 * (val - mid) / (max - mid));
                g = (int)Math.Round(255 * (max - val) / (max - mid));
            }
            if (val < mid)
            {
                g = (int)Math.Round(255 * (val - min) / (mid - min));
                b = (int)Math.Round(255 * (mid - val) / (mid - min));
            }

            return Color.FromArgb(255, r, g, b);
        }

        public static DateTime GetDateTime(CSVData entry)
        {
            return new DateTime(
                entry.date.Year,
                entry.date.Month,
                entry.date.Day,
                entry.time.Hour,
                entry.time.Minute,
                entry.time.Second);
        }
        
        /// <summary>
        /// Pobieranie centrum zgodnego z danymi i filtrami
        /// </summary>
        /// <returns>para lat-long</returns>
        public static CustomTypes.Point GetCenter()
        {
            return new CustomTypes.Point(Mid.latitude, Mid.longtitude);
        }

        public static string GetUnitName()
        {
            switch (dataType)
            {
                case DataType.HUMIDITY:
                    return "%";
                case DataType.LIGHT:
                    return "lx";
                case DataType.PRESSURE:
                    return "hPa";
                case DataType.TEMPERATURE:
                    return "°C";
            }

            return "";
        }
    }
}
