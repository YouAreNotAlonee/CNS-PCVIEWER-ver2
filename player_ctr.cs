using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Forms.DataVisualization.Charting;
using OpenCvSharp;
using OpenCvSharp.CPlusPlus;
using OpenCvSharp.UserInterface;
using OpenCvSharp.Extensions;

namespace MetroUI_ver2
{
    unsafe public partial class player_ctr : UserControl
    {
        public enum screenMode
        {
            front = 0, //전방
            rear = 1 //후방
        }
        //
        public struct FILE_INFO
        {//name fps, header
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 40)]
            public string name;
            public uint pos;
            public uint fcode;
            public byte video;
            public byte audio;
            public byte header_size;
            public byte etc1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] //public string fps;
            public byte[] fps;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] //public string fps;
            public ushort[] frame;                //한파일의 비디오 프래임의 합. 
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]// public short frame;
            public uint[] size;             //한파일의 비디오+ audio size 합. audio 는 Ch0에만 함산됨. 
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] //public int size;
            public ushort[] height;               //녹화 해상도 1280*702   1280 	
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] //public int size;
            public ushort[] width;
            public uint start_tt;                 // 녹화 시작 시간 
            public uint stop_tt;                  // 녹화 종료 시간 
            public uint gsen_pos;
            public uint gsen_size;
            public char gps;       //해당 파일의  시작 GPS점 및 종료 GPS 데이타 
            public uint user_pos;                 //Tail Data pos  for ESV	
            public uint user_size;                    //Tail Data size for ESV	
            public uint audio_sample;
            public byte audio_bit;
            public byte audio_ch;
            public byte obd;
            public byte reserv;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 120)]
            public string header;
            public uint findex;
        }
        //
        [DllImport("TATLib.dll")]
        public static extern int TAT_Create();

        [DllImport("TATLib.dll")]
        public static extern void TAT_Delete(int handle);

        [DllImport("TATLib.dll")]
        public static extern int TAT_Open(int handle, byte* device);

        [DllImport("TATLib.dll")]
        public static extern void TAT_Close(int handle, int fp);

        [DllImport("TATLib.dll")]
        public static extern uint TAT_Read(int handle, int fp, uint pos, string data, uint size);//

        [DllImport("TATLib.dll")]
        public static extern uint TAT_Write(int handle, int fp, uint pos, uint bytes, string data, uint size);

        [DllImport("TATLib.dll")]
        public static extern int TAT_Format(int handle);

        [DllImport("TATLib.dll")]
        public static extern int TAT_Check_Tat_Device(int handle, string device);

        [DllImport("TATLib.dll")]
        public static extern int TAT_Check_Version(int handle);

        [DllImport("TATLib.dll")]
        public static extern int TAT_Get_File_Frame_Cnt(int handle, Byte mode, string fname, string front, string rear);//unsigned char pointer??????????

        [DllImport("TATLib.dll")]
        public static extern int TAT_Get_File_Index_Info(int handle, byte mode, string fname, ref FILE_INFO f_info);

        [DllImport("TATLib.dll")]
        public static extern int TAT_Get_File_Cnt(int handle, char mode);

        [DllImport("TATLib.dll")]
        public static extern int TAT_Get_File_List(int handle, char mode, int list_cnt, string fname, uint* findex, uint* fsize);

        [DllImport("TATLib.dll")]
        public static extern int TAT_Get_File_List_tt(int handle, char mode, int list_cnt, byte[] fname, uint[] findex, uint[] fsize, uint[] ftime);

        [DllImport("TATLib.dll")]
        public static extern int TAT_Get_File_Flag(int handle, string Eevent, string Nnormal, string Pparking, string Rreserv);

        [DllImport("TATLib.dll")]
        public static extern Byte TAT_Find_Start_Stop(int handle, int fp, uint* mode, uint* start, uint* stop, uint* last_pos);

        [DllImport("TATLib.dll")]
        public static extern uint TAT_Get_PB_Pos(int handle, byte mode, string file);

        [DllImport("TATLib.dll")]
        public static extern int TAT_Get_Seek_Pos(int handle, Byte seek, Byte total);

        [DllImport("TATLib.dll")]
        public static extern int TAT_Set_PcFolder(int handle, string folder);

        [DllImport("TATLib.dll")]
        public static extern void TAT_PB_Init(int handle);

        [DllImport("TATLib.dll")]
        public static extern void TAT_PB_DeInit(int handle);

        [DllImport("TATLib.dll")]
        public static extern void TAT_PB_Start(int handle, byte mode, Byte ch, uint pb_pos);//int char char int

        [DllImport("TATLib.dll")]
        public static extern void TAT_PB_Stop(int handle);

        [DllImport("TATLib.dll")]
        public static extern void TAT_FAT_PB_Start(int handle, string file, uint* frame_cnt);

        [DllImport("TATLib.dll")]
        public static extern void TAT_FAT_PB_Stop(int handle);

        [DllImport("TATLib.dll")]
        public static extern uint TAT_Read_Frame(int handle, ref Byte ch, ref Byte f_type, ref Byte p_type, ref uint size, byte[] data, ref uint timestamp);

        [DllImport("TATLib.dll")]
        public static extern uint TAT_Make_Avi_File(int handle, string fname);

        [DllImport("TATLib.dll")]
        public static extern uint TAT_Make_Play_File(int handle, string fname, string Gsensor, string Gps);//TATLib에 없음

        [DllImport("TATLib.dll")]
        public static extern uint TAT_Make_Tat_File(int handle, string fname);

        [DllImport("TATLib.dll")]
        public static extern uint TAT_Make_Data_File(int handle, string fname, uint* frame_cnt, string gps_data, char tat, Byte fps, uint width, uint height, string bGsen, string obd);

        [DllImport("TATLib.dll")]
        public static extern int TAT_Set_Config_Data(int handle, string data, uint* size);

        [DllImport("TATLib.dll")]
        public static extern int TAT_Get_Config_Data(int handle, string data, uint* size);

        [DllImport("TATLib.dll")]
        public static extern void TAT_Get_Device_Name(int handle, string dname);

        [DllImport("TATLib.dll")]
        public static extern int TAT_Make_Picture_File(int handle, string fname, uint* pictrue_size, string picture_data);//TATLib에 없음

        public char[] m_rdata = new char[1024 * 1024];
        int hour, minute, second, VideoDuration, VideoPosition, handle = 0, file_sum = 0;
        string Video_Time, Video_Path = "C:\\TEST\\";
        bool Video_Timer_Enable = false, Mute_Mode = false, ScrollEnable = false;
        bool P_check = true, E_check = true, N_check = true, M_check = true;//리스트 뷰 위 체크박스 플래그 //parking Event Normal
        static int mode_0 = 254, mode_1 = 254, mode_2 = 254, mode_3 = 254, mode = 254, file_num = 1, file_cnt;

        IplImage imgSrc = new IplImage(640, 480, BitDepth.U8, 3);

        // 상하 좌우반전 플래그
        bool toggleFlag_X; 
        bool toggleFlag_Y;

        //chart관련 변수
        double cursor_x = 0.0, xVal, yVal, zVal; //커서의 x값과 그 x에서의 각각 축의 값
        List<List<double>> GsensorVal = new List<List<double>>(); //센서값 저장할 리스트
        int i = 0;

        // brightness 조절 변수
        double brightnessRatio;
        bool brightnessFlag = false;

        //contrast 조절 변수
        double contrastRatio;
        bool contrastFlag = false;

        // white balance 조절 변수
        bool WBFlag = false;

        // 전후방 조절 변수
        bool FrontRearFlag = true; //true면 전방, false면 후방

        //재생 변수
        VideoCapture vc_front;
        VideoCapture vc_rear;
        int posFrame = 1;

        private void metroButton2_Click(object sender, EventArgs e)
        {
            VideoCapture vc = new VideoCapture("drop.avi");
            int sleepTime = (int)Math.Round(1000 / vc.Fps);
            Mat img = new Mat();
            img.Size(pictureBoxIpl1.Width);
            while (true)
            {
                vc.XI_AutoWB = 100000.0;
                vc.Read(img);


                if (img.Empty())
                {
                    vc.Release();
                    break;
                }
                pictureBoxIpl1.ImageIpl = (IplImage)img;

                Delay(sleepTime);

                //Cv2.WaitKey(sleepTime);

                //vc.Release(); // 조건 추가해서 해제할것!!! 종료이벤트나 재생중 종료할때


                /*
                capture = CvCapture.FromFile(temp_name);

                timer1.Interval = (int)(1000 / capture.Fps);

                timer1.Enabled = true;
                */
            }
        }

        // 상하 좌우반전 플래그

        //Gsensor차트그리기
        private void timer1_Tick(object sender, EventArgs e)
        {
            if ( (i + 1) == GsensorVal[0].Count)
                timer1.Stop();
            chart_Gsensor.ChartAreas[0].CursorX.LineWidth = 1;
            chart_Gsensor.ChartAreas[0].CursorX.LineDashStyle = ChartDashStyle.Solid;
            chart_Gsensor.ChartAreas[0].CursorX.LineColor = Color.Red;

            chart_Gsensor.ChartAreas[0].CursorX.Interval = 0;
            

            //chart1.ChartAreas[0].CursorX.SetCursorPixelPosition(pointf, true);
            chart_Gsensor.ChartAreas[0].CursorX.SetCursorPosition(GsensorVal[0][i]);

            
            label_sec.Text = GsensorVal[0][i].ToString();

            label_X.Text = GsensorVal[1][i].ToString("N3");
            label_Y.Text = GsensorVal[2][i].ToString("N3");
            label_Z.Text = GsensorVal[3][i].ToString("N3");
            i++;

            //트랙바
            metroTrackBar2.Value = vc_front.PosFrames;
            string codec_string = vc_front.FourCC;
            metroLabel1.Text =TimeSpan.FromMilliseconds(vc_front.PosMsec).ToString();


        }
        
        private void ListView_tatList_DoubleClick(object sender, EventArgs e)
        {
            string fname;
            timer1.Stop();
            fname = ListView_tatList.FocusedItem.SubItems[0].Text;
            string ftime = ListView_tatList.FocusedItem.SubItems[2].Text;
                      
            if(posFrame <= 1) //재생중 이벤트발생시
            {
                posFrame = 1;
                chart_Gsensor.Series[0].Points.Clear();// Gsensor X축 값 초기화
                chart_Gsensor.Series[1].Points.Clear();// Gsensor Y축 값 초기화
                chart_Gsensor.Series[2].Points.Clear();// Gsensor Z축 값 초기화
            }  
           
            vDownLoadFile(fname,ftime);
            fname = "";
            chart_Gsensor.Series[0].Points.Clear();// Gsensor X축 값 초기화
            chart_Gsensor.Series[1].Points.Clear();// Gsensor Y축 값 초기화
            chart_Gsensor.Series[2].Points.Clear();// Gsensor Z축 값 초기화
            posFrame = 1;
        }



        private void TrackBar_Brightness_ValueChanged(object sender, EventArgs e)
        {
            this.brightnessRatio = TrackBar_Brightness.Value * 20.0;
            brightnessFlag = true;
        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroToggle1.Checked == true) //좌우반전일어남
                toggleFlag_Y = true;
            else
                toggleFlag_Y = false;
        }


        private void metroToggle2_CheckedChanged(object sender, EventArgs e)
        {
            if (metroToggle2.Checked == true) //상하반전 일어남
                toggleFlag_X = true;
            else
                toggleFlag_X = false;
        }

        private void Button_HistoEQ_Click(object sender, EventArgs e)
        {
            contrastFlag = true;
        }

        private void metroTrackBar4_ValueChanged(object sender, EventArgs e)
        {
            contrastFlag = true;
            contrastRatio = this.metroTrackBar4.Value * 1.1;
        }

        private void RadioButton_WB_Auto_CheckedChanged(object sender, EventArgs e)
        {
            WBFlag = true;
        }

        private void metroToggle3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.metroToggle3.Checked == false)//전방
                FrontRearFlag = true;
            else //후방
                FrontRearFlag = false;
        }

        private void player_ctr_Load(object sender, EventArgs e)
        {
            int threshold = 10;
            
            int res = Cv.CreateTrackbar("thr:", "display", ref threshold, 1000,null);
        }

        private void metroTrackBar2_Scroll(object sender, ScrollEventArgs e)
        {
            vc_front.PosFrames = metroTrackBar2.Value;
            posFrame = metroTrackBar2.Value;
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            button_play.Visible = true;
            button_play.Enabled = true;
            button_stop.Enabled = false;
            button_stop.Visible = false;

            vc_front.Release();
            timer1.Stop();
        }

        string[] name = new string[mode_0];
        string[] Only_name = new string[mode_0];
        string[] name1 = new string[mode_1 + 1];
        string[] Only_name1 = new string[mode_1 + 1];
        string[] name2 = new string[file_cnt];
        string[] Only_name2 = new string[file_cnt];
        string[] name3 = new string[file_cnt];
        string[] Only_name3 = new string[file_cnt];
        string Eevent = "", Nnormal = "", Pparking = "", Rreserve = "";
        //TAT_Info tat;
        public player_ctr()
        {
            InitializeComponent();

            this.ListView_tatList.View = View.Details;
            this.ListView_tatList.Columns.Add("파일이름", 80, HorizontalAlignment.Center);
            this.ListView_tatList.Columns.Add("파일크기", 50, HorizontalAlignment.Center);
            this.ListView_tatList.Columns.Add("재생시간", 50, HorizontalAlignment.Center);
            this.ListView_tatList.Columns.Add("상대경로", 80, HorizontalAlignment.Center);
            //tat = new TAT_Info();
            GSensor_Chart();
        }
        
        unsafe private void TAT_showlist()
        {
            string temp = "";
            int tt = 0;
            int nPos = 0, ePos = 0, pPos = 0, mPos = 0;
            int EfileCnt = 0, NfileCnt = 0, PfileCnt = 0, MfileCnt = 0;
            uint EfileSize = 0, NfileSize = 0, PfileSize = 0, MfileSize = 0;
            ListView_tatList.Items.Clear();

            tt=TAT_Get_File_Flag(handle, Eevent, Nnormal, Pparking, Rreserve);

            mode_0 = TAT_Get_File_Cnt(handle, (char)0);
            mode_1 = TAT_Get_File_Cnt(handle, (char)1);
            mode_2 = TAT_Get_File_Cnt(handle, (char)2);
            mode_3 = TAT_Get_File_Cnt(handle, (char)3);
            file_cnt = mode_0 + mode_1 + mode_2 + mode_3;

            /*
            char[] list_name = new char[40*file_cnt];
            System.Array.Clear(list_name, 0, list_name.Length);

            UInt32[] list_index = new UInt32[sizeof(UInt32) * file_cnt];
            System.Array.Clear(list_index, 0, list_index.Length);

            UInt32[] list_size = new UInt32[sizeof(UInt32) * file_cnt];
            System.Array.Clear(list_size, 0, list_size.Length);

            UInt32[] list_time = new UInt32[sizeof(UInt32) * file_cnt];
            System.Array.Clear(list_time, 0, list_time.Length);
            */

            char[] list_name_0 = new char[1000 * mode_0];
            byte[] list_name_temp_0 = new byte[45 * mode_0];
            uint[] list_index_0 = new uint[sizeof(uint) * mode_0];
            uint[] list_size_0 = new uint[sizeof(uint) * mode_0];
            uint[] list_time_0 = new uint[sizeof(uint) * mode_0];
            string[] name_0 = new string[mode_0];

            char[] list_name_1 = new char[1000 * mode_1];
            byte[] list_name_temp_1 = new byte[45 * mode_1];
            uint[] list_index_1 = new uint[sizeof(uint) * mode_1];
            uint[] list_size_1 = new uint[sizeof(uint) * mode_1];
            uint[] list_time_1 = new uint[sizeof(uint) * mode_1];
            string[] name_1 = new string[mode_1];

            char[] list_name_2 = new char[1000 * mode_2];
            byte[] list_name_temp_2 = new byte[45 * mode_2];
            uint[] list_index_2 = new uint[sizeof(uint) * mode_2];
            uint[] list_size_2 = new uint[sizeof(uint) * mode_2];
            uint[] list_time_2 = new uint[sizeof(uint) * mode_2];
            string[] name_2 = new string[mode_2];

            char[] list_name_3 = new char[1000 * mode_3];
            byte[] list_name_temp_3 = new byte[45 * mode_3];
            uint[] list_index_3 = new uint[sizeof(uint) * mode_3];
            uint[] list_size_3 = new uint[sizeof(uint) * mode_3];
            uint[] list_time_3 = new uint[sizeof(uint) * mode_3];
            string[] name_3 = new string[mode_3];

            file_sum += TAT_Get_File_List_tt(handle, (char)0, mode_0, list_name_temp_0, list_index_0, list_size_0, list_time_0);
            file_sum += TAT_Get_File_List_tt(handle, (char)1, mode_1, list_name_temp_1, list_index_1, list_size_1, list_time_1);
            file_sum += TAT_Get_File_List_tt(handle, (char)2, mode_2, list_name_temp_2, list_index_2, list_size_2, list_time_2);
            file_sum += TAT_Get_File_List_tt(handle, (char)3, mode_3, list_name_temp_3, list_index_3, list_size_3, list_time_3);

            for (int i = 0; i < 40 * mode_0; i++)
                list_name_0[i] = (char)list_name_temp_0[i];
            for (int i = 0; i < 40 * mode_1; i++)
                list_name_1[i] = (char)list_name_temp_1[i];
            for (int i = 0; i < 40 * mode_2; i++)
                list_name_2[i] = (char)list_name_temp_2[i];
            for (int i = 0; i < 40 * mode_3; i++)
                list_name_3[i] = (char)list_name_temp_3[i];
            

            for (int j = 0; j < name_0.Length; j++)
            {
                for (int i = j * 20; i < j * 20 + 21; i++)
                    temp += list_name_0[j * 20 + i].ToString();
                int size = int.Parse(list_size_0[j].ToString());
                size /= (1024 * 1024);
                ListViewItem lvi = new ListViewItem(temp);
                lvi.SubItems.Add(size.ToString() + "MB");
                lvi.SubItems.Add(list_time_0[j].ToString() + "초");
                ListView_tatList.Items.Add(lvi);
                ePos++;
                EfileCnt++;
                EfileSize += list_size_0[j];
                temp = "";
            }
            for (int j = 0; j < name_1.Length; j++)
            {
                for (int i = j * 20; i < j * 20 + 21; i++)
                    temp += list_name_1[j * 20 + i].ToString();
                int size = int.Parse(list_size_1[j].ToString());
                size /= (1024 * 1024);
                ListViewItem lvi = new ListViewItem(temp);
                lvi.SubItems.Add(size.ToString() + "MB");
                lvi.SubItems.Add(list_time_1[j].ToString() + "초");
                ListView_tatList.Items.Add(lvi);
                nPos++;
                NfileCnt++;
                NfileSize += list_size_1[j];
                temp = "";
            }
            for (int j = 0; j < name_2.Length; j++)
            {
                for (int i = j * 40 + 0; i < j * 40 + 21; i++)
                    temp += list_name_2[j * 40 + i].ToString();
                int size = int.Parse(list_size_2[j].ToString());
                size /= (1024 * 1024);
                ListViewItem lvi = new ListViewItem(temp);
                lvi.SubItems.Add(size.ToString() + "MB");
                lvi.SubItems.Add(list_time_2[j].ToString() + "초");
                ListView_tatList.Items.Add(lvi);
                mPos++;
                MfileCnt++;
                MfileSize += list_size_2[j];
            }

            for (int j = 0; j < name_3.Length; j++)
            {
                for (int i = j * 40 + 0; i < j * 40 + 21; i++)
                    temp += list_name_3[j * 40 + i].ToString();
                int size = int.Parse(list_size_3[j].ToString());
                size /= (1024 * 1024);
                ListViewItem lvi = new ListViewItem(temp);
                lvi.SubItems.Add(size.ToString() + "MB");
                lvi.SubItems.Add(list_time_3[j].ToString() + "초");
                ListView_tatList.Items.Add(lvi);
                pPos++;
                PfileCnt++;
                PfileSize += list_size_3[j];
            }
            ListView_tatList.Update();
            ListView_tatList.EndUpdate();
            //ListView_tatList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
        public int TAT_device()
        {
            int result = 0;
            string device = "";
            string path = null;
            handle = TAT_Create();
            result = TAT_Check_Tat_Device(handle, device);

            if (device.Equals("2"))
                path = "D\\: 에 TAT파일이 있습니다.";
            else if (device.Equals("3"))
                path = "E\\: 에 TAT파일이 있습니다.";
            else if (device.Equals("4"))
                path = "F\\: 에 TAT파일이 있습니다.";
            Console.WriteLine(path);
            path = "path";
            return handle;

        }
        unsafe public void vDownLoadFile(string sFileName, string ftime)
        {
            string temp_name = "";
            string fname_front = "";
            string fname_rear = "";
            if (!sFileName.Equals(""))
            {

                managedTAT.TATWrap[] obj = new managedTAT.TATWrap[3];
                for (int i = 0; i < 3; i++)
                    obj[i] = new managedTAT.TATWrap();
                FILE_INFO f_info = new FILE_INFO();
                f_info.audio = 0;
                f_info.audio_bit = 0;
                f_info.audio_ch = 0;
                f_info.audio_sample = 0;

                char[] VSet = new char[5];
                char[] t_name = new char[100];
                byte[] f_name = new byte[100];
                byte[] t_data = new byte[1024 * 1024];
                //      char ii, V2Ch, mode;
                byte test = 0;
                uint rtn, size = 0, timestamp = 0, pb_pos;
                //        int gps_tt = 0, frame_index = 0;
                byte ch = 0, f_type = 0, p_type = 0;
                char[] a = sFileName.ToCharArray();
                char[] temp = new char[40];
                char[] nam = sFileName.ToCharArray();
                char* charPointer = stackalloc char[100];

                for (int i = 0; i < a.Length; i++)
                    f_name[i] = (byte)a[i];

                if (f_name[16] == 'E')
                {
                    mode = '0';
                    test = 0;
                }
                else if (f_name[16] == 'I')
                {
                    mode = '1';
                    test = 1;
                }
                else if (f_name[16] == 'P')
                {
                    mode = '2';
                    test = 2;
                }
                else if (f_name[16] == 'J')
                {
                    mode = '3';
                    test = 3;
                }
                else if (f_name[16] == 'C')
                {
                    mode = '4';
                    test = 4;
                }
                else return;

                for (int i = 0; i < 100; i++)
                    charPointer[i] = (char)f_name[i];
                int ttemp = 255;
                ttemp = TAT_Get_File_Index_Info(handle, test, sFileName, ref f_info);
                TAT_PB_Init(handle);
                pb_pos = TAT_Get_PB_Pos(handle, test, sFileName);//제조사확인 에러 뜨는곳
                TAT_PB_Start(handle, test, 0, pb_pos);
                name[0] = Video_Path + t_name.ToString();
                name[1] = Video_Path + t_name.ToString();
                name[2] = Video_Path + t_name.ToString();

                for (int i = 0; i < 3; i++)
                    VSet[i] = '0';

                int index = 1;
                while (true)
                {
                    rtn = TAT_Read_Frame(handle, ref ch, ref f_type, ref p_type, ref size, t_data, ref timestamp);
                    if ((rtn == 1) || (rtn == 2) || (rtn == 3))
                        break;

                    if (VSet[ch].Equals('0') && (ch < 3))
                    {
                        if ((t_data[0] == 0) && (t_data[1] == 0) && (t_data[2] == 0) && (t_data[3] == 1) && (p_type == 1) && (f_type == 2))
                        {
                            VSet[ch] = '1';
                            obj[ch].SetDim(0, f_info.width[ch], f_info.height[ch]);
                            obj[ch].SetAudioSampleRate(8000);
                            obj[ch].SetFPS(0, f_info.fps[ch]);
                            obj[ch].UseVideo2(false);
                            
                            if (ch.ToString() == "0") //전방
                            {
                                fname_front = Video_Path + ch.ToString() + sFileName;
                                temp_name = fname_front;
                            }

                            else //후방
                            {
                                fname_rear = Video_Path + ch.ToString() + sFileName;
                                temp_name = fname_rear;
                            }

                            byte[] bytes = Encoding.ASCII.GetBytes(temp_name);

                            unsafe
                            {
                                fixed (byte* p = bytes)
                                {
                                    sbyte* sp = (sbyte*)p;
                                    obj[ch].Create(sp);
                                }
                            }
                        }
                    }

                    if (!(VSet[ch].Equals('0')) || (ch == '3') || (ch == '2'))
                    {
                        switch (f_type)
                        {
                            case 2:
                                {
                                    if (!VSet[ch].Equals('0'))
                                    {
                                        if (ch == 0)
                                        {
                                            unsafe
                                            {
                                                fixed (byte* pp = t_data)
                                                {
                                                    sbyte* spp = (sbyte*)pp;
                                                    obj[ch].AddData(spp, (int)size, 0);
                                                }
                                            }
                                        }
                                        else if (ch == 1)
                                        {
                                            unsafe
                                            {
                                                fixed (byte* pp = t_data)
                                                {
                                                    sbyte* spp = (sbyte*)pp;
                                                    obj[ch].AddData(spp, (int)size, 0);
                                                }
                                            }
                                        }
                                        else if (ch == 2)
                                        {
                                            unsafe
                                            {
                                                fixed (byte* pp = t_data)
                                                {
                                                    sbyte* spp = (sbyte*)pp;
                                                    obj[ch].AddData(spp, (int)size, 0);
                                                }
                                            }
                                        }
                                    }
                                }
                                break;
                            case 1:
                                {
                                    if (VSet[0].Equals('1'))
                                    {
                                        unsafe
                                        {
                                            fixed (byte* pp = t_data)
                                            {
                                                sbyte* spp = (sbyte*)pp;
                                                obj[0].AddData(spp, (int)size, 2);
                                            }
                                        }
                                    }
                                    if (VSet[1].Equals('1'))
                                    {
                                        unsafe
                                        {
                                            fixed (byte* pp = t_data)
                                            {
                                                sbyte* spp = (sbyte*)pp;
                                                obj[1].AddData(spp, (int)size, 2);
                                            }
                                        }
                                    }
                                    if (VSet[2].Equals('1'))
                                    {
                                        unsafe
                                        {
                                            fixed (byte* pp = t_data)
                                            {
                                                sbyte* spp = (sbyte*)pp;
                                                obj[2].AddData(spp, (int)size, 2);
                                            }
                                        }
                                    }
                                }
                                break;
                            case 3://GSENSOR
                                {
                                    float[] floats = new float[3];
                                    for (int i = 0; i < floats.Length; i++)
                                        floats[i] = BitConverter.ToSingle(t_data, i * 4);

                                    //데이터 포인트 저장
                                    GsensorVal[0].Add((double)index);
                                    GsensorVal[1].Add(Convert.ToDouble(floats[0]));
                                    GsensorVal[2].Add(Convert.ToDouble(floats[1]));
                                    GsensorVal[3].Add(Convert.ToDouble(floats[2]));
                                    
                                    index++;
                                    /*
                                    Console.Write("X = ");
                                    Console.Write(floats[0].ToString("N3"));
                                    Console.Write("Y = ");
                                    Console.Write(floats[1].ToString("N3"));
                                    Console.Write("Z = ");
                                    Console.Write(floats[2].ToString("N3"));
                                    Console.WriteLine();
                                    */
                                }
                                break;
                            case 4://GPS
                                {
                                    Console.WriteLine(t_data[0].ToString()); //
                                }
                                break;
                        }
                    }
                }
                if (!VSet[0].Equals('0'))
                    obj[0].Close(null, 0);
                if (!VSet[1].Equals('0'))
                    obj[1].Close(null, 0);
                if (!VSet[2].Equals('0'))
                    obj[2].Close(null, 0);
            }

            //데이터바인딩
            chart_Gsensor.Series[0].Points.DataBindY(GsensorVal[1], "x값");
            chart_Gsensor.Series[1].Points.DataBindY(GsensorVal[2], "y값");
            chart_Gsensor.Series[2].Points.DataBindY(GsensorVal[3], "Z값");
            chart_Gsensor.ChartAreas[0].AxisX.Maximum = GsensorVal[0].Count;
            timer1.Interval =1000*Convert.ToInt32(ftime.Remove(ftime.Length - 1, 1)) / GsensorVal[0].Count;

            //버튼 표시
            button_play.Visible = false;
            button_play.Enabled = false;
            button_stop.Visible = true;
            button_stop.Enabled = true;

            //재생
            VideoPlay(fname_front, fname_rear);
            
        }
        private void VideoPlay(string fname_front, string fname_rear)
        {
            vc_front = new VideoCapture(fname_front);
            vc_rear = new VideoCapture(fname_rear);

            //트랙바 초기화
            metroTrackBar2.Minimum = 0;
            metroTrackBar2.Maximum = vc_front.FrameCount;

            //재생버튼이 일시정지로 바뀌어야 함

            //재생설정 초기화
            int sleepTime = 1000 *19 / vc_front.FrameCount; //(int)Math.Round(1000 / vc_front.Fps);
            Mat img = new Mat();
            timer1.Enabled = true;
            //timer1.Interval = GsensorVal[0].Count / (int)vc_front.Fps;
            timer1.Start();
             //현재재생프레임이 저장될 변수

            while (true)
            {
                if (FrontRearFlag == true) //전방
                {
                    //vc_front.XI_AutoWB = 100000.0;
                    if( posFrame - vc_front.PosFrames > 1) //화면전환 일어난 시점에서만 최신 posframe 대입  
                        vc_front.PosFrames = posFrame;

                    vc_front.Read(img); //프레임읽기
                    IplImage tmp = new IplImage();
                    tmp = img.ToIplImage();

                    if (img.Empty())
                    {
                        vc_front.Release();
                        timer1.Stop();
                        break;
                    }
                    if (brightnessFlag == true || contrastFlag == true) //밝기,명암 조절
                    {
                        tmp = brightnessChanged(img.ToIplImage());
                        tmp = contrastChanged(tmp);

                    }

                    pictureBoxIpl1.ImageIpl = tmp;
                    posFrame = vc_front.PosFrames;
                    Delay(sleepTime);
                }
                else
                {
                    //vc_rear.XI_AutoWB = 100000.0;
                    if (posFrame - vc_rear.PosFrames > 1) //화면전환 일어난 시점에서만 최신 posframe 대입  
                        vc_rear.PosFrames = posFrame;

                    vc_rear.Read(img);
                    IplImage tmp = new IplImage();
                    tmp = img.ToIplImage();

                    if (img.Empty())
                    {
                        vc_rear.Release();
                        timer1.Stop();
                        break;
                    }
                    if (brightnessFlag == true || contrastFlag == true) //밝기,명암 조절
                    {
                        tmp = brightnessChanged(img.ToIplImage());
                        tmp = contrastChanged(tmp);

                    }

                    pictureBoxIpl1.ImageIpl = screenContrast(tmp);
                    posFrame = vc_rear.PosFrames;
                    Delay(sleepTime);
                }
                
                //Cv2.WaitKey(sleepTime);

                //vc.Release(); // 조건 추가해서 해제할것!!! 종료이벤트나 재생중 종료할때


                /*
                capture = CvCapture.FromFile(temp_name);

                timer1.Interval = (int)(1000 / capture.Fps);

                timer1.Enabled = true;
                */
            }
            
            ////////////////////////////////////////////////////////////////////////////////////할당 해제
        }

        private IplImage screenContrast(IplImage imgSrc)// 화면반전 검사후 이미지 반환
        {
            if (toggleFlag_X == true && toggleFlag_Y == true) //상하,좌우반전 일어남
            {     
                Cv.Flip(imgSrc, null, FlipMode.XY);
            }
            if (toggleFlag_X == true && toggleFlag_Y == false)//상하반전 일어남
            {
                Cv.Flip(imgSrc, null, FlipMode.X);
            }
            if (toggleFlag_X == false && toggleFlag_Y == true)//좌우반전 일어남
            {
                Cv.Flip(imgSrc, null, FlipMode.Y);
            }

            return imgSrc;
        }
        // 재생할때 프레임단위로 딜레이해줌
        private static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);
            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }
            return DateTime.Now;
        }


        private void metroButton3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Convert.ToString(tat.TAT_device()));
            TAT_device();
            TAT_showlist();            
        }

        private void ListView_tatList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void GSensor_Chart()
        {
            chart_Gsensor.Series[0].ChartArea = "Gsensor";

            chart_Gsensor.Series[1].ChartArea = "Gsensor";

            chart_Gsensor.Series[2].ChartArea = "Gsensor";


            ////////////////////////////////////////////////////////////////////////////////////////////////chart
            for (int i = 0; i < 4; i++) //[0][]째: 시간(개수), [1][]: X축 값, [2][]: y축 값, [3][]: z축 값
            {
                GsensorVal.Add(new List<double>());
            }

            //Series 객체는 도시할 그래프를 구성하는 점의 집합이다
            //ChartArea 객체는 그래프를 보여줄 영역이다

           // chart_Gsensor.Series.Clear(); // default series를 삭제한다.

            chart_Gsensor.ChartAreas[0].AxisX.Maximum = 100;




            //for X axis line
            chart_Gsensor.ChartAreas[0].CursorX.LineWidth = 1;
            chart_Gsensor.ChartAreas[0].CursorX.LineDashStyle = ChartDashStyle.Solid;
            chart_Gsensor.ChartAreas[0].CursorX.LineColor = Color.Red;

            chart_Gsensor.ChartAreas[0].CursorX.Interval = 0;

            //chart1.ChartAreas[0].CursorX.SetCursorPixelPosition(pointf, true);
            chart_Gsensor.ChartAreas[0].CursorX.SetCursorPosition(cursor_x);


        }
        private IplImage brightnessChanged(IplImage imgSrc)
        {
            if (brightnessRatio > 0) //밝기 증가
            {
                CvScalar cs = new CvScalar(brightnessRatio, brightnessRatio, brightnessRatio);
                imgSrc.AddS(cs, imgSrc);
            }
            else //밝기 감소
            {
                CvScalar cs = new CvScalar(brightnessRatio, brightnessRatio, brightnessRatio);
                imgSrc.AddS(cs, imgSrc);
            }
            return imgSrc;
        }
        private IplImage contrastChanged(IplImage imgSrc)
        {

            if (contrastRatio > 0) //명암 증가
            {
                CvScalar cs = new CvScalar(contrastRatio, contrastRatio, contrastRatio);
                IplImage img = new IplImage(imgSrc.Size, BitDepth.U8, 3);
                img.AddS(cs, img);

                imgSrc.Mul(img, imgSrc);
            }
            else if(contrastRatio<0)//명암 감소
            {
                CvScalar cs = new CvScalar((-1)*contrastRatio, (-1) * contrastRatio, (-1) * contrastRatio);
                IplImage img = new IplImage(imgSrc.Size, BitDepth.U8, 3);
                img.AddS(cs, img);

                imgSrc.Div(img, imgSrc);
            }
         
            return imgSrc;
        }

    }
}
