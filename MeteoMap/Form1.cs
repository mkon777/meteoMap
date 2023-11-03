using CsvHelper;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using System.Linq;

namespace MeteoMap
{
    public partial class MeteoMap : Form
    {
        private Dictionary<DataType, string> comboEnum;

        public MeteoMap()
        {
            InitializeComponent();

            comboEnum = new Dictionary<DataType, string>();
            comboEnum.Add(DataType.TEMPERATURE, "Temperatura");
            comboEnum.Add(DataType.PRESSURE, "Ciśnienie");
            comboEnum.Add(DataType.LIGHT, "Oświetlenie");
            comboEnum.Add(DataType.HUMIDITY, "Wilgotność");
            comboBoxValue.DataSource = new BindingSource(comboEnum, null);
            comboBoxValue.DisplayMember = "Value";
            comboBoxValue.ValueMember = "Key";

            CommonData.dataType = DataType.TEMPERATURE;

            comboBoxMapType.Items.Add(GMap.NET.MapProviders.OpenStreetMapProvider.Instance);
            comboBoxMapType.Items.Add(GMap.NET.MapProviders.GoogleMapProvider.Instance);
            comboBoxMapType.Items.Add(GMap.NET.MapProviders.OpenCycleMapProvider.Instance);
            comboBoxMapType.Items.Add(GMap.NET.MapProviders.BingMapProvider.Instance);
            comboBoxMapType.Items.Add(GMap.NET.MapProviders.ArcGIS_World_Topo_MapProvider.Instance);
            comboBoxMapType.Items.Add(GMap.NET.MapProviders.ArcGIS_World_Street_MapProvider.Instance);

            dateTimePickerFrom.Format = DateTimePickerFormat.Custom;
            dateTimePickerFrom.CustomFormat = "dd.MM.yyyy";
            dateTimePickerTo.Format = DateTimePickerFormat.Custom;
            dateTimePickerTo.CustomFormat = "dd.MM.yyyy";

        }

        /// <summary>
        /// Ładowanie mapy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gmcMap_Load(object sender, EventArgs e)
        {
            gmcMap.MapProvider = GMap.NET.MapProviders.OpenStreetMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmcMap.Zoom = 12;
            gmcMap.SetPositionByKeywords("Wrzeszcz, Gdańsk, Poland");
            gmcMap.ShowCenter = false;

            toolStripStatusLabelMapType.Text = gmcMap.MapProvider.ToString();
            comboBoxMapType.SelectedItem = gmcMap.MapProvider;

            CommonData.pointSize = gmcMap.Zoom * gmcMap.Zoom;
        }

        /// <summary>
        /// Rysowanie mapy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gmcMap_Paint(object sender, PaintEventArgs e)
        {
            PointManager.Instance.Redraw(gmcMap);
        }

        /// <summary>
        /// Zamknięcie okna z menu plik
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Ładowanie pliku csv z menu plik
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream stream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((stream = openFileDialog.OpenFile()) != null)
                    {
                        DataManager.Instance.LoadData(stream);
                        PointManager.Instance.Load(DataManager.Instance.data);

                        dateTimePickerFrom.Value = CommonData.Filters.minDateTime;
                        dateTimePickerTo.Value = CommonData.Filters.maxDateTime;

                        UpdateInfo();
                        SetCurrentView();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nie można odczytać pliku:\n " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Informacje z menu pomoc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Marlena Kondrat, 137312", "Autor",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
        }

        /// <summary>
        /// Ustawianie widoku na podstawie podanych punktów
        /// </summary>
        private void SetCurrentView()
        {
            gmcMap.Position = new PointLatLng(
                CommonData.GetCenter().latitude, 
                CommonData.GetCenter().longtitude);
        }

        private void comboBoxMapType_SelectedIndexChanged(object sender, EventArgs e)
        {
            gmcMap.MapProvider = (GMap.NET.MapProviders.GMapProvider)comboBoxMapType.SelectedItem;
            toolStripStatusLabelMapType.Text = gmcMap.MapProvider.ToString();
        }

        private void UpdateInfo()
        {
            toolStripStatusLabelDateTime.Text = 
                CommonData.Filters.minDateTime.ToString("dd.MM.yyyy HH:mm") + " - " + 
                CommonData.Filters.maxDateTime.ToString("dd.MM.yyyy HH:mm");
            toolStripStatusLabelPoints.Text = "Punktów: " + PointManager.Instance.GetPointsNumber();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {

            CommonData.Filters.minDateTime = dateTimePickerFrom.Value;
            CommonData.Filters.maxDateTime = dateTimePickerTo.Value;

            CommonData.dataType = comboEnum.FirstOrDefault(x => x.Value == comboBoxValue.Text).Key;

            SetDataMode();
            PointManager.Instance.Redraw(gmcMap);
            UpdateInfo();
        }

        public void SetDataMode()
        {
            if (checkBoxShowValue.Checked && checkBoxShowDate.Checked && checkBoxShowTime.Checked)
            {
                CommonData.dataMode = DataMode.VALUE_DATE_TIME;
            }
            else if (checkBoxShowValue.Checked && checkBoxShowDate.Checked)
            {
                CommonData.dataMode = DataMode.VALUE_DATE;
            }
            else if (checkBoxShowValue.Checked && checkBoxShowTime.Checked)
            {
                CommonData.dataMode = DataMode.VALUE_TIME;
            }
            else if (checkBoxShowTime.Checked && checkBoxShowDate.Checked)
            {
                CommonData.dataMode = DataMode.DATE_TIME;
            }
            else if (checkBoxShowValue.Checked)
            {
                CommonData.dataMode = DataMode.VALUE;
            }
            else if (checkBoxShowTime.Checked)
            {
                CommonData.dataMode = DataMode.TIME;
            }
            else if (checkBoxShowDate.Checked)
            {
                CommonData.dataMode = DataMode.DATE;
            }
            else
            {
                CommonData.dataMode = DataMode.NONE;
            }
        }

        private void gmcMap_OnMapZoomChanged()
        {
            CommonData.pointSize = gmcMap.Zoom * gmcMap.Zoom;
            PointManager.Instance.Redraw(gmcMap);
        }

    }
}
