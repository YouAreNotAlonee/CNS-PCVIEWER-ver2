namespace MetroUI_ver2
{
    partial class player_ctr
    {

        #region 구성 요소 디자이너에서 생성한 코드

        #endregion
        private MetroFramework.Controls.MetroTrackBar metroTrackBar1;
        private MetroFramework.Controls.MetroTrackBar metroTrackBar2;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private MetroFramework.Controls.MetroToggle metroToggle2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton mapBtn;
        private MetroFramework.Controls.MetroButton updownBtn;
        private MetroFramework.Controls.MetroButton leftrightBtn;
        private MetroFramework.Controls.MetroButton fowardBtn;
        private MetroFramework.Controls.MetroButton stopBtn;
        private MetroFramework.Controls.MetroButton button_play;
        private MetroFramework.Controls.MetroButton backBtn;
        private MetroFramework.Controls.MetroTabControl Tab;
        private MetroFramework.Controls.MetroTabPage listTab;
        private MetroFramework.Controls.MetroListView ListView_tatList;
        private MetroFramework.Controls.MetroTabPage mapTab;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.IContainer components;

        
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.metroTrackBar1 = new MetroFramework.Controls.MetroTrackBar();
            this.metroTrackBar2 = new MetroFramework.Controls.MetroTrackBar();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.metroToggle2 = new MetroFramework.Controls.MetroToggle();
            this.Tab = new MetroFramework.Controls.MetroTabControl();
            this.listTab = new MetroFramework.Controls.MetroTabPage();
            this.ListView_tatList = new MetroFramework.Controls.MetroListView();
            this.mapTab = new MetroFramework.Controls.MetroTabPage();
            this.settingsTab = new MetroFramework.Controls.MetroTabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroRadioButton7 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton6 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton5 = new MetroFramework.Controls.MetroRadioButton();
            this.RadioButton_WB_Auto = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton4 = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.metroTrackBar4 = new MetroFramework.Controls.MetroTrackBar();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TrackBar_Brightness = new MetroFramework.Controls.MetroTrackBar();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart_Gsensor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroToggle3 = new MetroFramework.Controls.MetroToggle();
            this.label_sec = new MetroFramework.Controls.MetroLabel();
            this.label_X = new MetroFramework.Controls.MetroLabel();
            this.label_Y = new MetroFramework.Controls.MetroLabel();
            this.label_Z = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.button_stop = new MetroFramework.Controls.MetroButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.pictureBoxIpl1 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.mapBtn = new MetroFramework.Controls.MetroButton();
            this.updownBtn = new MetroFramework.Controls.MetroButton();
            this.leftrightBtn = new MetroFramework.Controls.MetroButton();
            this.fowardBtn = new MetroFramework.Controls.MetroButton();
            this.stopBtn = new MetroFramework.Controls.MetroButton();
            this.button_play = new MetroFramework.Controls.MetroButton();
            this.backBtn = new MetroFramework.Controls.MetroButton();
            this.Tab.SuspendLayout();
            this.listTab.SuspendLayout();
            this.mapTab.SuspendLayout();
            this.settingsTab.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Gsensor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTrackBar1
            // 
            this.metroTrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBar1.Location = new System.Drawing.Point(-15, -15);
            this.metroTrackBar1.Name = "metroTrackBar1";
            this.metroTrackBar1.Size = new System.Drawing.Size(75, 23);
            this.metroTrackBar1.TabIndex = 1;
            this.metroTrackBar1.Text = "metroTrackBar1";
            // 
            // metroTrackBar2
            // 
            this.metroTrackBar2.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBar2.Location = new System.Drawing.Point(12, 370);
            this.metroTrackBar2.Name = "metroTrackBar2";
            this.metroTrackBar2.Size = new System.Drawing.Size(700, 23);
            this.metroTrackBar2.TabIndex = 2;
            this.metroTrackBar2.Text = "metroTrackBar2";
            this.metroTrackBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroTrackBar2_Scroll);
            // 
            // metroToggle1
            // 
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.Location = new System.Drawing.Point(628, 407);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(80, 16);
            this.metroToggle1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroToggle1.TabIndex = 12;
            this.metroToggle1.Text = "Off";
            this.metroToggle1.UseSelectable = true;
            this.metroToggle1.CheckedChanged += new System.EventHandler(this.metroToggle1_CheckedChanged);
            // 
            // metroToggle2
            // 
            this.metroToggle2.AutoSize = true;
            this.metroToggle2.Location = new System.Drawing.Point(506, 407);
            this.metroToggle2.Name = "metroToggle2";
            this.metroToggle2.Size = new System.Drawing.Size(80, 16);
            this.metroToggle2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroToggle2.TabIndex = 13;
            this.metroToggle2.Text = "Off";
            this.metroToggle2.UseSelectable = true;
            this.metroToggle2.CheckedChanged += new System.EventHandler(this.metroToggle2_CheckedChanged);
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.listTab);
            this.Tab.Controls.Add(this.mapTab);
            this.Tab.Controls.Add(this.settingsTab);
            this.Tab.Location = new System.Drawing.Point(718, 16);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 2;
            this.Tab.Size = new System.Drawing.Size(275, 523);
            this.Tab.Style = MetroFramework.MetroColorStyle.Black;
            this.Tab.TabIndex = 17;
            this.Tab.UseSelectable = true;
            // 
            // listTab
            // 
            this.listTab.Controls.Add(this.ListView_tatList);
            this.listTab.Controls.Add(this.metroButton3);
            this.listTab.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listTab.HorizontalScrollbarBarColor = true;
            this.listTab.HorizontalScrollbarHighlightOnWheel = false;
            this.listTab.HorizontalScrollbarSize = 10;
            this.listTab.Location = new System.Drawing.Point(4, 38);
            this.listTab.Name = "listTab";
            this.listTab.Size = new System.Drawing.Size(267, 481);
            this.listTab.Style = MetroFramework.MetroColorStyle.Black;
            this.listTab.TabIndex = 0;
            this.listTab.Text = "PlayLists";
            this.listTab.VerticalScrollbarBarColor = true;
            this.listTab.VerticalScrollbarHighlightOnWheel = false;
            this.listTab.VerticalScrollbarSize = 10;
            // 
            // ListView_tatList
            // 
            this.ListView_tatList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ListView_tatList.FullRowSelect = true;
            this.ListView_tatList.Location = new System.Drawing.Point(3, 66);
            this.ListView_tatList.Name = "ListView_tatList";
            this.ListView_tatList.OwnerDraw = true;
            this.ListView_tatList.Size = new System.Drawing.Size(261, 412);
            this.ListView_tatList.Style = MetroFramework.MetroColorStyle.Black;
            this.ListView_tatList.TabIndex = 16;
            this.ListView_tatList.UseCompatibleStateImageBehavior = false;
            this.ListView_tatList.UseSelectable = true;
            this.ListView_tatList.View = System.Windows.Forms.View.Details;
            this.ListView_tatList.SelectedIndexChanged += new System.EventHandler(this.ListView_tatList_SelectedIndexChanged);
            this.ListView_tatList.DoubleClick += new System.EventHandler(this.ListView_tatList_DoubleClick);
            // 
            // mapTab
            // 
            this.mapTab.Controls.Add(this.webBrowser1);
            this.mapTab.Controls.Add(this.mapBtn);
            this.mapTab.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mapTab.HorizontalScrollbarBarColor = true;
            this.mapTab.HorizontalScrollbarHighlightOnWheel = false;
            this.mapTab.HorizontalScrollbarSize = 10;
            this.mapTab.Location = new System.Drawing.Point(4, 38);
            this.mapTab.Name = "mapTab";
            this.mapTab.Size = new System.Drawing.Size(267, 481);
            this.mapTab.Style = MetroFramework.MetroColorStyle.Black;
            this.mapTab.TabIndex = 1;
            this.mapTab.Text = "Map";
            this.mapTab.VerticalScrollbarBarColor = true;
            this.mapTab.VerticalScrollbarHighlightOnWheel = false;
            this.mapTab.VerticalScrollbarSize = 10;
            // 
            // settingsTab
            // 
            this.settingsTab.Controls.Add(this.panel2);
            this.settingsTab.Controls.Add(this.panel5);
            this.settingsTab.Controls.Add(this.panel4);
            this.settingsTab.HorizontalScrollbarBarColor = true;
            this.settingsTab.HorizontalScrollbarHighlightOnWheel = false;
            this.settingsTab.HorizontalScrollbarSize = 8;
            this.settingsTab.Location = new System.Drawing.Point(4, 38);
            this.settingsTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Size = new System.Drawing.Size(267, 481);
            this.settingsTab.TabIndex = 2;
            this.settingsTab.Text = "Settings";
            this.settingsTab.VerticalScrollbarBarColor = true;
            this.settingsTab.VerticalScrollbarHighlightOnWheel = false;
            this.settingsTab.VerticalScrollbarSize = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.metroRadioButton7);
            this.panel2.Controls.Add(this.metroRadioButton6);
            this.panel2.Controls.Add(this.metroRadioButton5);
            this.panel2.Controls.Add(this.RadioButton_WB_Auto);
            this.panel2.Controls.Add(this.metroRadioButton4);
            this.panel2.Controls.Add(this.metroLabel2);
            this.panel2.Location = new System.Drawing.Point(1, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 85);
            this.panel2.TabIndex = 20;
            // 
            // metroRadioButton7
            // 
            this.metroRadioButton7.AutoSize = true;
            this.metroRadioButton7.Location = new System.Drawing.Point(80, 62);
            this.metroRadioButton7.Name = "metroRadioButton7";
            this.metroRadioButton7.Size = new System.Drawing.Size(47, 15);
            this.metroRadioButton7.TabIndex = 8;
            this.metroRadioButton7.Text = "흐림";
            this.metroRadioButton7.UseSelectable = true;
            // 
            // metroRadioButton6
            // 
            this.metroRadioButton6.AutoSize = true;
            this.metroRadioButton6.Location = new System.Drawing.Point(17, 62);
            this.metroRadioButton6.Name = "metroRadioButton6";
            this.metroRadioButton6.Size = new System.Drawing.Size(47, 15);
            this.metroRadioButton6.TabIndex = 7;
            this.metroRadioButton6.Text = "맑음";
            this.metroRadioButton6.UseSelectable = true;
            // 
            // metroRadioButton5
            // 
            this.metroRadioButton5.AutoSize = true;
            this.metroRadioButton5.Location = new System.Drawing.Point(157, 42);
            this.metroRadioButton5.Name = "metroRadioButton5";
            this.metroRadioButton5.Size = new System.Drawing.Size(59, 15);
            this.metroRadioButton5.TabIndex = 6;
            this.metroRadioButton5.Text = "형광등";
            this.metroRadioButton5.UseSelectable = true;
            // 
            // RadioButton_WB_Auto
            // 
            this.RadioButton_WB_Auto.AutoSize = true;
            this.RadioButton_WB_Auto.Location = new System.Drawing.Point(17, 42);
            this.RadioButton_WB_Auto.Name = "RadioButton_WB_Auto";
            this.RadioButton_WB_Auto.Size = new System.Drawing.Size(47, 15);
            this.RadioButton_WB_Auto.TabIndex = 5;
            this.RadioButton_WB_Auto.Text = "자동";
            this.RadioButton_WB_Auto.UseSelectable = true;
            this.RadioButton_WB_Auto.CheckedChanged += new System.EventHandler(this.RadioButton_WB_Auto_CheckedChanged);
            // 
            // metroRadioButton4
            // 
            this.metroRadioButton4.AutoSize = true;
            this.metroRadioButton4.Location = new System.Drawing.Point(81, 42);
            this.metroRadioButton4.Name = "metroRadioButton4";
            this.metroRadioButton4.Size = new System.Drawing.Size(59, 15);
            this.metroRadioButton4.TabIndex = 3;
            this.metroRadioButton4.Text = "백열등";
            this.metroRadioButton4.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(17, 14);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(93, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "화이트밸런스";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Controls.Add(this.metroTrackBar4);
            this.panel5.Controls.Add(this.metroLabel5);
            this.panel5.Location = new System.Drawing.Point(3, 218);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(255, 76);
            this.panel5.TabIndex = 11;
            // 
            // metroTrackBar4
            // 
            this.metroTrackBar4.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBar4.Location = new System.Drawing.Point(14, 43);
            this.metroTrackBar4.Maximum = 4;
            this.metroTrackBar4.Minimum = -4;
            this.metroTrackBar4.Name = "metroTrackBar4";
            this.metroTrackBar4.Size = new System.Drawing.Size(223, 23);
            this.metroTrackBar4.TabIndex = 7;
            this.metroTrackBar4.Text = "metroTrackBar4";
            this.metroTrackBar4.Value = 0;
            this.metroTrackBar4.ValueChanged += new System.EventHandler(this.metroTrackBar4_ValueChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(17, 12);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(37, 19);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "명암";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Controls.Add(this.TrackBar_Brightness);
            this.panel4.Controls.Add(this.metroLabel4);
            this.panel4.Location = new System.Drawing.Point(0, 120);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(255, 76);
            this.panel4.TabIndex = 10;
            // 
            // TrackBar_Brightness
            // 
            this.TrackBar_Brightness.BackColor = System.Drawing.Color.Transparent;
            this.TrackBar_Brightness.Location = new System.Drawing.Point(17, 38);
            this.TrackBar_Brightness.Maximum = 4;
            this.TrackBar_Brightness.Minimum = -4;
            this.TrackBar_Brightness.Name = "TrackBar_Brightness";
            this.TrackBar_Brightness.Size = new System.Drawing.Size(223, 23);
            this.TrackBar_Brightness.TabIndex = 6;
            this.TrackBar_Brightness.Text = "metroTrackBar5";
            this.TrackBar_Brightness.Value = 0;
            this.TrackBar_Brightness.ValueChanged += new System.EventHandler(this.TrackBar_Brightness_ValueChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(17, 12);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(37, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "밝기";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chart_Gsensor
            // 
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.Maximum = 500D;
            chartArea1.AxisY.Interval = 2D;
            chartArea1.AxisY.Maximum = 4D;
            chartArea1.AxisY.Minimum = -4D;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "Gsensor";
            this.chart_Gsensor.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_Gsensor.Legends.Add(legend1);
            this.chart_Gsensor.Location = new System.Drawing.Point(12, 440);
            this.chart_Gsensor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart_Gsensor.Name = "chart_Gsensor";
            series1.ChartArea = "Gsensor";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "X";
            series2.ChartArea = "Gsensor";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Y";
            series3.ChartArea = "Gsensor";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Z";
            this.chart_Gsensor.Series.Add(series1);
            this.chart_Gsensor.Series.Add(series2);
            this.chart_Gsensor.Series.Add(series3);
            this.chart_Gsensor.Size = new System.Drawing.Size(696, 99);
            this.chart_Gsensor.TabIndex = 19;
            this.chart_Gsensor.Text = "chart1";
            // 
            // metroToggle3
            // 
            this.metroToggle3.AutoSize = true;
            this.metroToggle3.Location = new System.Drawing.Point(362, 407);
            this.metroToggle3.Name = "metroToggle3";
            this.metroToggle3.Size = new System.Drawing.Size(80, 16);
            this.metroToggle3.Style = MetroFramework.MetroColorStyle.Black;
            this.metroToggle3.TabIndex = 20;
            this.metroToggle3.Text = "Off";
            this.metroToggle3.UseSelectable = true;
            this.metroToggle3.CheckedChanged += new System.EventHandler(this.metroToggle3_CheckedChanged);
            // 
            // label_sec
            // 
            this.label_sec.AutoSize = true;
            this.label_sec.Location = new System.Drawing.Point(202, 429);
            this.label_sec.Name = "label_sec";
            this.label_sec.Size = new System.Drawing.Size(0, 0);
            this.label_sec.TabIndex = 22;
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.Location = new System.Drawing.Point(281, 429);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(0, 0);
            this.label_X.TabIndex = 23;
            // 
            // label_Y
            // 
            this.label_Y.AutoSize = true;
            this.label_Y.Location = new System.Drawing.Point(362, 428);
            this.label_Y.Name = "label_Y";
            this.label_Y.Size = new System.Drawing.Size(0, 0);
            this.label_Y.TabIndex = 24;
            // 
            // label_Z
            // 
            this.label_Z.AutoSize = true;
            this.label_Z.Location = new System.Drawing.Point(444, 429);
            this.label_Z.Name = "label_Z";
            this.label_Z.Size = new System.Drawing.Size(0, 0);
            this.label_Z.TabIndex = 25;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(247, 429);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 19);
            this.metroLabel1.TabIndex = 26;
            this.metroLabel1.Text = "metroLabel1";
            // 
            // button_stop
            // 
            this.button_stop.Enabled = false;
            this.button_stop.Location = new System.Drawing.Point(52, 399);
            this.button_stop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(51, 35);
            this.button_stop.TabIndex = 27;
            this.button_stop.Text = "일시정지";
            this.button_stop.UseSelectable = true;
            this.button_stop.Visible = false;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(14, 78);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(250, 337);
            this.webBrowser1.TabIndex = 15;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.White;
            this.metroButton1.BackgroundImage = global::MetroUI_ver2.Properties.Resources.camera;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton1.Location = new System.Drawing.Point(321, 399);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(35, 35);
            this.metroButton1.TabIndex = 28;
            this.metroButton1.UseSelectable = true;
            // 
            // pictureBoxIpl1
            // 
            this.pictureBoxIpl1.Location = new System.Drawing.Point(3, 2);
            this.pictureBoxIpl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxIpl1.Name = "pictureBoxIpl1";
            this.pictureBoxIpl1.Size = new System.Drawing.Size(710, 362);
            this.pictureBoxIpl1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIpl1.TabIndex = 21;
            this.pictureBoxIpl1.TabStop = false;
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.Color.White;
            this.metroButton3.BackgroundImage = global::MetroUI_ver2.Properties.Resources.folder;
            this.metroButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroButton3.Location = new System.Drawing.Point(86, 25);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(83, 35);
            this.metroButton3.TabIndex = 15;
            this.metroButton3.Text = "불러오기";
            this.metroButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // mapBtn
            // 
            this.mapBtn.BackColor = System.Drawing.Color.White;
            this.mapBtn.BackgroundImage = global::MetroUI_ver2.Properties.Resources.location_point;
            this.mapBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mapBtn.Location = new System.Drawing.Point(80, 21);
            this.mapBtn.Name = "mapBtn";
            this.mapBtn.Size = new System.Drawing.Size(82, 35);
            this.mapBtn.TabIndex = 14;
            this.mapBtn.Text = "연결하기";
            this.mapBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mapBtn.UseSelectable = true;
            // 
            // updownBtn
            // 
            this.updownBtn.BackgroundImage = global::MetroUI_ver2.Properties.Resources.updown;
            this.updownBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.updownBtn.Location = new System.Drawing.Point(470, 397);
            this.updownBtn.Name = "updownBtn";
            this.updownBtn.Size = new System.Drawing.Size(35, 35);
            this.updownBtn.TabIndex = 11;
            this.updownBtn.UseSelectable = true;
            // 
            // leftrightBtn
            // 
            this.leftrightBtn.BackgroundImage = global::MetroUI_ver2.Properties.Resources.leftright;
            this.leftrightBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.leftrightBtn.Location = new System.Drawing.Point(592, 399);
            this.leftrightBtn.Name = "leftrightBtn";
            this.leftrightBtn.Size = new System.Drawing.Size(35, 35);
            this.leftrightBtn.TabIndex = 10;
            this.leftrightBtn.UseSelectable = true;
            // 
            // fowardBtn
            // 
            this.fowardBtn.BackgroundImage = global::MetroUI_ver2.Properties.Resources.fast_forward_arrows_button;
            this.fowardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fowardBtn.Location = new System.Drawing.Point(150, 399);
            this.fowardBtn.Name = "fowardBtn";
            this.fowardBtn.Size = new System.Drawing.Size(35, 35);
            this.fowardBtn.TabIndex = 6;
            this.fowardBtn.UseSelectable = true;
            // 
            // stopBtn
            // 
            this.stopBtn.BackgroundImage = global::MetroUI_ver2.Properties.Resources.stop_button;
            this.stopBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.stopBtn.Location = new System.Drawing.Point(104, 399);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(35, 35);
            this.stopBtn.TabIndex = 5;
            this.stopBtn.UseSelectable = true;
            // 
            // button_play
            // 
            this.button_play.BackgroundImage = global::MetroUI_ver2.Properties.Resources.play_button__1_;
            this.button_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_play.Location = new System.Drawing.Point(58, 399);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(35, 35);
            this.button_play.TabIndex = 4;
            this.button_play.UseSelectable = true;
            // 
            // backBtn
            // 
            this.backBtn.BackgroundImage = global::MetroUI_ver2.Properties.Resources.previous;
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backBtn.Location = new System.Drawing.Point(12, 399);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(35, 35);
            this.backBtn.TabIndex = 3;
            this.backBtn.UseSelectable = true;
            // 
            // player_ctr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.label_Z);
            this.Controls.Add(this.label_Y);
            this.Controls.Add(this.label_X);
            this.Controls.Add(this.label_sec);
            this.Controls.Add(this.pictureBoxIpl1);
            this.Controls.Add(this.metroToggle3);
            this.Controls.Add(this.chart_Gsensor);
            this.Controls.Add(this.Tab);
            this.Controls.Add(this.metroToggle2);
            this.Controls.Add(this.metroToggle1);
            this.Controls.Add(this.updownBtn);
            this.Controls.Add(this.leftrightBtn);
            this.Controls.Add(this.fowardBtn);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.metroTrackBar2);
            this.Controls.Add(this.metroTrackBar1);
            this.Controls.Add(this.button_stop);
            this.Name = "player_ctr";
            this.Size = new System.Drawing.Size(1000, 550);
            this.Load += new System.EventHandler(this.player_ctr_Load);
            this.Tab.ResumeLayout(false);
            this.listTab.ResumeLayout(false);
            this.mapTab.ResumeLayout(false);
            this.settingsTab.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Gsensor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Gsensor;
        private MetroFramework.Controls.MetroTabPage settingsTab;
        private System.Windows.Forms.Panel panel5;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.Panel panel4;
        private MetroFramework.Controls.MetroTrackBar TrackBar_Brightness;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTrackBar metroTrackBar4;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton7;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton6;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton5;
        private MetroFramework.Controls.MetroRadioButton RadioButton_WB_Auto;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroToggle metroToggle3;
        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl1;
        private MetroFramework.Controls.MetroLabel label_sec;
        private MetroFramework.Controls.MetroLabel label_X;
        private MetroFramework.Controls.MetroLabel label_Y;
        private MetroFramework.Controls.MetroLabel label_Z;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton button_stop;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}
