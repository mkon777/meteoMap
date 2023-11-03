using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeteoMap
{
    class DataManager
    {
        private static DataManager instance = null;
        public List<CSVData> data { get; private set; }

        public static DataManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataManager();
                }
                return instance;
            }
        }

        private void SetDate(CSVData dataEntry)
        {
            DateTime dt = CommonData.GetDateTime(dataEntry);

            CommonData.Filters.minDateTime = new[] { dt, CommonData.Filters.minDateTime }.Min();
            CommonData.Filters.maxDateTime = new[] { dt, CommonData.Filters.maxDateTime }.Max();
        }

        /// <summary>
        /// Wczytywanie danych
        /// </summary>
        public void LoadData(Stream stream)
        {
            var reader = new CsvReader(new StreamReader(stream));
            reader.Configuration.Delimiter = ";";
            data = reader.GetRecords<CSVData>().ToList();

            foreach (var entry in data)
            {
                SetDate(entry);
            }

            SetMinMax();
        }

        public void SetMinMax()
        {
            bool first = true;

            foreach (var entry in data)
            {
                DateTime dt = CommonData.GetDateTime(entry);

                if (dt > CommonData.Filters.maxDateTime ||
                    dt < CommonData.Filters.minDateTime)
                {
                    continue;
                }

                if (first)
                {
                    first = false;

                    CommonData.Min.humidity    = entry.humidity;
                    CommonData.Min.light       = entry.light;
                    CommonData.Min.pressure    = entry.pressure;
                    CommonData.Min.temperature = entry.temperature;
                    CommonData.Min.latitude    = entry.latitude;
                    CommonData.Min.longtitude  = entry.longtitude;

                    CommonData.Max.humidity = entry.humidity;
                    CommonData.Max.light = entry.light;
                    CommonData.Max.pressure = entry.pressure;
                    CommonData.Max.temperature = entry.temperature;
                    CommonData.Max.latitude = entry.latitude;
                    CommonData.Max.longtitude = entry.longtitude;

                    continue;
                }

                CommonData.Min.humidity    = Math.Min(entry.humidity,    CommonData.Min.humidity);
                CommonData.Min.light       = Math.Min(entry.light,       CommonData.Min.light);
                CommonData.Min.pressure    = Math.Min(entry.pressure,    CommonData.Min.pressure);
                CommonData.Min.temperature = Math.Min(entry.temperature, CommonData.Min.temperature);
                CommonData.Min.latitude    = Math.Min(entry.latitude,    CommonData.Min.latitude);
                CommonData.Min.longtitude  = Math.Min(entry.longtitude,  CommonData.Min.longtitude);

                CommonData.Max.humidity    = Math.Max(entry.humidity,    CommonData.Max.humidity);
                CommonData.Max.light       = Math.Max(entry.light,       CommonData.Max.light);
                CommonData.Max.pressure    = Math.Max(entry.pressure,    CommonData.Max.pressure);
                CommonData.Max.temperature = Math.Max(entry.temperature, CommonData.Max.temperature);
                CommonData.Max.latitude    = Math.Max(entry.latitude,    CommonData.Max.latitude);
                CommonData.Max.longtitude  = Math.Max(entry.longtitude,  CommonData.Max.longtitude);
            }

            CommonData.Mid.humidity    = (CommonData.Min.humidity    + CommonData.Max.humidity)    / 2;
            CommonData.Mid.light       = (CommonData.Min.light       + CommonData.Max.light)       / 2;
            CommonData.Mid.pressure    = (CommonData.Min.pressure    + CommonData.Max.pressure)    / 2;
            CommonData.Mid.temperature = (CommonData.Min.temperature + CommonData.Max.temperature) / 2;
            CommonData.Mid.latitude    = (CommonData.Min.latitude    + CommonData.Max.latitude)    / 2;
            CommonData.Mid.longtitude  = (CommonData.Min.longtitude  + CommonData.Max.longtitude)  / 2;
        }
    }
}
