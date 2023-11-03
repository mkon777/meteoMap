using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeteoMap
{
    class PointManager
    {
        private static PointManager instance = null;
        private static GMapOverlay markersOverlay;
        private static List<CSVData> data;

        public static PointManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PointManager();
                    markersOverlay = new GMapOverlay("markers");
                }
                return instance;
            }
        }

        public void Clear(GMapControl mapControl)
        {
            mapControl.Overlays.Clear();
            markersOverlay.Clear(); 
        }
        
        public void Load(List<CSVData> aData)
        {
            data = aData;

            try
            {
                foreach (var entry in data)
                {
                    DateTime dt = CommonData.GetDateTime(entry);
                    
                    if (dt > CommonData.Filters.maxDateTime ||
                        dt < CommonData.Filters.minDateTime)
                    {
                        continue;
                    }

                    float value = CommonData.GetPointValue(entry);
                    Point point = new Point(
                        CommonData.PrepareColor(value),
                        value.ToString() + CommonData.GetUnitName(),
                        entry.date.ToString("dd.MM.yyyy"),
                        entry.time.ToString("HH:mm"),
                        new CustomTypes.Point(entry.latitude, entry.longtitude));

                    markersOverlay.Markers.Add(point.GetMarker(CommonData.dataMode));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        public void Draw(GMapControl mapControl)
        {
            mapControl.Overlays.Add(markersOverlay);
        }

        public void Redraw(GMapControl mapControl)
        {
            if (data != null && data.Count > 0)
            {
                Clear(mapControl);
                Load(data);
                Draw(mapControl);
            }
        }

        public int GetPointsNumber()
        {
            return markersOverlay.Markers.Count;
        }        
    }
}
