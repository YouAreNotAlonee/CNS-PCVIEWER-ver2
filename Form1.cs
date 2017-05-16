using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.DirectX.AudioVideoPlayback;
using System.Runtime.InteropServices;
using System.IO;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using OpenCvSharp;
using System.Collections.Generic;
using managedCTAT;
using System.Windows.Forms.DataVisualization.Charting;

namespace MetroUI_ver2
{
    public unsafe partial class Form1 : MetroFramework.Forms.MetroForm
    {
        TAT_Info t1;
        string device;
        public Form1()
        {
            
            InitializeComponent();
                    }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            home_ctr1.Visible = true;
            player_ctr1.Visible = false;
            setting_ctr1.Visible = false;
            convert_ctr1.Visible = false;
            statistics_ctr1.Visible = false;
        }

        private void playerBtn_Click(object sender, EventArgs e)
        {
            home_ctr1.Visible = false;
            player_ctr1.Visible = true;
            setting_ctr1.Visible = false;
            convert_ctr1.Visible = false;
            statistics_ctr1.Visible = false;
        }

        private void converBtn_Click(object sender, EventArgs e)
        {
            home_ctr1.Visible = false;
            player_ctr1.Visible = false;
            setting_ctr1.Visible = false;
            convert_ctr1.Visible = true;
            statistics_ctr1.Visible = false;
        }

        private void statisticsBtn_Click(object sender, EventArgs e)
        {
            home_ctr1.Visible = false;
            player_ctr1.Visible = false;
            setting_ctr1.Visible = false;
            convert_ctr1.Visible = false;
            statistics_ctr1.Visible = true;
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            home_ctr1.Visible = false;
            player_ctr1.Visible = false;
            setting_ctr1.Visible = true;
            convert_ctr1.Visible = false;
            statistics_ctr1.Visible = false;
        }

        /////////////////////////////////////////////////////////////////////////////////////////
        



    }
}
