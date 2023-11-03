namespace MeteoMap
{
    partial class MeteoMap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMapType = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelPoints = new System.Windows.Forms.ToolStripStatusLabel();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scContainer = new System.Windows.Forms.SplitContainer();
            this.gmcMap = new GMap.NET.WindowsForms.GMapControl();
            this.btnApply = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.comboBoxMapType = new System.Windows.Forms.ComboBox();
            this.checkBoxShowTime = new System.Windows.Forms.CheckBox();
            this.checkBoxShowDate = new System.Windows.Forms.CheckBox();
            this.checkBoxShowValue = new System.Windows.Forms.CheckBox();
            this.labelValue = new System.Windows.Forms.Label();
            this.comboBoxValue = new System.Windows.Forms.ComboBox();
            this.statusStrip1.SuspendLayout();
            this.msMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scContainer)).BeginInit();
            this.scContainer.Panel1.SuspendLayout();
            this.scContainer.Panel2.SuspendLayout();
            this.scContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMapType,
            this.toolStripStatusLabelDateTime,
            this.toolStripStatusLabelPoints});
            this.statusStrip1.Location = new System.Drawing.Point(0, 557);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1031, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "ssStatus";
            // 
            // toolStripStatusLabelMapType
            // 
            this.toolStripStatusLabelMapType.Name = "toolStripStatusLabelMapType";
            this.toolStripStatusLabelMapType.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabelDateTime
            // 
            this.toolStripStatusLabelDateTime.Name = "toolStripStatusLabelDateTime";
            this.toolStripStatusLabelDateTime.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabelPoints
            // 
            this.toolStripStatusLabelPoints.Name = "toolStripStatusLabelPoints";
            this.toolStripStatusLabelPoints.Size = new System.Drawing.Size(0, 17);
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(1031, 24);
            this.msMenu.TabIndex = 2;
            this.msMenu.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.loadToolStripMenuItem.Text = "Wczytaj";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.closeToolStripMenuItem.Text = "Zamknij";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.aboutToolStripMenuItem.Text = "O programie";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // scContainer
            // 
            this.scContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scContainer.Location = new System.Drawing.Point(0, 24);
            this.scContainer.Name = "scContainer";
            // 
            // scContainer.Panel1
            // 
            this.scContainer.Panel1.Controls.Add(this.gmcMap);
            // 
            // scContainer.Panel2
            // 
            this.scContainer.Panel2.Controls.Add(this.btnApply);
            this.scContainer.Panel2.Controls.Add(this.label2);
            this.scContainer.Panel2.Controls.Add(this.label1);
            this.scContainer.Panel2.Controls.Add(this.dateTimePickerTo);
            this.scContainer.Panel2.Controls.Add(this.dateTimePickerFrom);
            this.scContainer.Panel2.Controls.Add(this.comboBoxMapType);
            this.scContainer.Panel2.Controls.Add(this.checkBoxShowTime);
            this.scContainer.Panel2.Controls.Add(this.checkBoxShowDate);
            this.scContainer.Panel2.Controls.Add(this.checkBoxShowValue);
            this.scContainer.Panel2.Controls.Add(this.labelValue);
            this.scContainer.Panel2.Controls.Add(this.comboBoxValue);
            this.scContainer.Size = new System.Drawing.Size(1031, 533);
            this.scContainer.SplitterDistance = 830;
            this.scContainer.TabIndex = 3;
            // 
            // gmcMap
            // 
            this.gmcMap.Bearing = 0F;
            this.gmcMap.CanDragMap = true;
            this.gmcMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gmcMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmcMap.GrayScaleMode = false;
            this.gmcMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmcMap.LevelsKeepInMemmory = 5;
            this.gmcMap.Location = new System.Drawing.Point(0, 0);
            this.gmcMap.MarkersEnabled = true;
            this.gmcMap.MaxZoom = 18;
            this.gmcMap.MinZoom = 2;
            this.gmcMap.MouseWheelZoomEnabled = true;
            this.gmcMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            this.gmcMap.Name = "gmcMap";
            this.gmcMap.NegativeMode = false;
            this.gmcMap.PolygonsEnabled = true;
            this.gmcMap.RetryLoadTile = 0;
            this.gmcMap.RoutesEnabled = true;
            this.gmcMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Fractional;
            this.gmcMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmcMap.ShowTileGridLines = false;
            this.gmcMap.Size = new System.Drawing.Size(830, 533);
            this.gmcMap.TabIndex = 0;
            this.gmcMap.Zoom = 0D;
            this.gmcMap.OnMapZoomChanged += new GMap.NET.MapZoomChanged(this.gmcMap_OnMapZoomChanged);
            this.gmcMap.Load += new System.EventHandler(this.gmcMap_Load);
            this.gmcMap.Paint += new System.Windows.Forms.PaintEventHandler(this.gmcMap_Paint);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(110, 271);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 10;
            this.btnApply.Text = "Zastosuj";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Do";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Od";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(21, 211);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(164, 20);
            this.dateTimePickerTo.TabIndex = 7;
            this.dateTimePickerTo.Value = new System.DateTime(9998, 12, 30, 5, 46, 0, 0);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(21, 169);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(164, 20);
            this.dateTimePickerFrom.TabIndex = 6;
            this.dateTimePickerFrom.Value = new System.DateTime(1753, 1, 1, 5, 46, 0, 0);
            // 
            // comboBoxMapType
            // 
            this.comboBoxMapType.FormattingEnabled = true;
            this.comboBoxMapType.Location = new System.Drawing.Point(21, 495);
            this.comboBoxMapType.Name = "comboBoxMapType";
            this.comboBoxMapType.Size = new System.Drawing.Size(164, 21);
            this.comboBoxMapType.TabIndex = 5;
            this.comboBoxMapType.SelectedIndexChanged += new System.EventHandler(this.comboBoxMapType_SelectedIndexChanged);
            // 
            // checkBoxShowTime
            // 
            this.checkBoxShowTime.AutoSize = true;
            this.checkBoxShowTime.Location = new System.Drawing.Point(21, 117);
            this.checkBoxShowTime.Name = "checkBoxShowTime";
            this.checkBoxShowTime.Size = new System.Drawing.Size(81, 17);
            this.checkBoxShowTime.TabIndex = 4;
            this.checkBoxShowTime.Text = "Pokaż czas";
            this.checkBoxShowTime.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowDate
            // 
            this.checkBoxShowDate.AutoSize = true;
            this.checkBoxShowDate.Location = new System.Drawing.Point(21, 94);
            this.checkBoxShowDate.Name = "checkBoxShowDate";
            this.checkBoxShowDate.Size = new System.Drawing.Size(80, 17);
            this.checkBoxShowDate.TabIndex = 3;
            this.checkBoxShowDate.Text = "Pokaż datę";
            this.checkBoxShowDate.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowValue
            // 
            this.checkBoxShowValue.AutoSize = true;
            this.checkBoxShowValue.Location = new System.Drawing.Point(21, 71);
            this.checkBoxShowValue.Name = "checkBoxShowValue";
            this.checkBoxShowValue.Size = new System.Drawing.Size(96, 17);
            this.checkBoxShowValue.TabIndex = 2;
            this.checkBoxShowValue.Text = "Pokaż wartość";
            this.checkBoxShowValue.UseVisualStyleBackColor = true;
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(18, 14);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(87, 13);
            this.labelValue.TabIndex = 1;
            this.labelValue.Text = "Obecne wartości";
            // 
            // comboBoxValue
            // 
            this.comboBoxValue.FormattingEnabled = true;
            this.comboBoxValue.Location = new System.Drawing.Point(21, 35);
            this.comboBoxValue.Name = "comboBoxValue";
            this.comboBoxValue.Size = new System.Drawing.Size(164, 21);
            this.comboBoxValue.TabIndex = 0;
            // 
            // MeteoMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 579);
            this.Controls.Add(this.scContainer);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.msMenu);
            this.Name = "MeteoMap";
            this.Text = "MeteoMap";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.scContainer.Panel1.ResumeLayout(false);
            this.scContainer.Panel2.ResumeLayout(false);
            this.scContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scContainer)).EndInit();
            this.scContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.SplitContainer scContainer;
        private GMap.NET.WindowsForms.GMapControl gmcMap;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxShowValue;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.ComboBox comboBoxValue;
        private System.Windows.Forms.ComboBox comboBoxMapType;
        private System.Windows.Forms.CheckBox checkBoxShowTime;
        private System.Windows.Forms.CheckBox checkBoxShowDate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMapType;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDateTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPoints;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Button btnApply;
    }
}

