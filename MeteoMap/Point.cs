using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoMap
{
    class Point
    {
        private Color color;
        private String value;
        private String date;
        private String time;
        private CustomTypes.Point location;
        public int Size {get; set;}
        

        public Point(
            Color aColor, 
            String aValue, 
            String aDate, 
            String aTime, 
            CustomTypes.Point aLocation)
        {
            color = aColor;
            value = aValue;
            date = aDate;
            time = aTime;
            location = aLocation;
            Size = Convert.ToInt32(CommonData.pointSize);
        }

        public GMapMarker GetMarker(DataMode mode)
        {
            GMapMarker marker = new GMarkerGoogle(
                new PointLatLng(location.latitude, location.longtitude), 
                CreateBrush());

            SetShowedInfo(marker, mode);

            if (marker.ToolTipText != "")
            {
                marker.ToolTip.Fill = Brushes.Transparent;
                marker.ToolTip.Foreground = Brushes.Black;
                marker.ToolTip.Stroke = Pens.Transparent;
                marker.ToolTip.TextPadding = new Size(1, 1);
                marker.ToolTip.Font = new Font(
                    marker.ToolTip.Font.Name,
                    marker.ToolTip.Font.Size,
                    FontStyle.Bold,
                    marker.ToolTip.Font.Unit);

                marker.ToolTipMode = MarkerTooltipMode.Always;
            }

            return marker;
        }

        /// <summary>
        /// Tworzenie wizualizacji punktu
        /// </summary>
        /// <returns>Bitmapa - punkt</returns>
        private Bitmap CreateBrush()
        {
            Bitmap btm = new Bitmap(Size, Size);
            using (Graphics grf = Graphics.FromImage(btm))
            {
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(0, 0, Size, Size);
                PathGradientBrush pthGrBrush = new PathGradientBrush(path);
                pthGrBrush.CenterColor = color;
                Color[] colors = { Color.FromArgb(0, 0, 0, 0) };
                pthGrBrush.SurroundColors = colors;
                grf.FillEllipse(pthGrBrush, 0, 0, Size, Size);
            }

            return btm;
        }

        /// <summary>
        /// Ustawianie wyświetlanych informacji o punkcie
        /// </summary>
        /// <param name="marker">marker punktu</param>
        /// <param name="mode">tryb informacji</param>
        private void SetShowedInfo(GMapMarker marker, DataMode mode)
        {
            switch(mode)
            {
                case DataMode.DATE:
                    marker.ToolTipText = date;
                    break;
                case DataMode.DATE_TIME:
                    marker.ToolTipText = date + " " + time;
                    break;
                case DataMode.TIME:
                    marker.ToolTipText = time;
                    break;
                case DataMode.VALUE:
                    marker.ToolTipText = value;
                    break;
                case DataMode.VALUE_DATE:
                    marker.ToolTipText = value + "\n" + date;
                    break;
                case DataMode.VALUE_DATE_TIME:
                    marker.ToolTipText = value + "\n" + date + " " + time;
                    break;
                case DataMode.VALUE_TIME:
                    marker.ToolTipText = value + "\n" + time;
                    break;
                case DataMode.NONE:
                    marker.ToolTipText = "";
                    break;
            }
        }
    }
}
