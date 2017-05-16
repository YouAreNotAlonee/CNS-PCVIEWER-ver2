using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace MetroUI_ver2
{
    public unsafe partial class convert_ctr : UserControl
    {
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
       

        public convert_ctr()
        {
            InitializeComponent();
        }
    }
}
