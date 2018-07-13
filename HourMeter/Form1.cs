using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HourMeter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Timer time = new Timer();
        Stopwatch sw;
        TimeSpan ts;
        //static int count = 1;

        private void Start_Click(object sender, EventArgs e)
        {
            //开始按键：
            Continue.Enabled = true;
            Stop.Enabled = true;
            if (Continue.Text == "Continue")
                Continue.Text = "Pause";
            sw = new Stopwatch();
            time.Tick += new EventHandler(time_Tick);
            time.Interval = 1;
            sw.Start();
            time.Start();
        }

        void time_Tick(object sender, EventArgs e)
        {
            ts = sw.Elapsed;
            Lab_Time.Text = string.Format("{0}:{1}:{2}:{3}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            //停止时间按钮
            sw.Stop();
            time.Stop();
            Lab_Time.Text = string.Format("{0}:{1}:{2}:{3}", 0, 0, 0, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Continue.Enabled = false;
            Stop.Enabled = false;
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            if (Continue.Text == "Pause")
            {
                //暂停事件按钮
                Continue.Text = "Continue";
                sw.Stop();
                time.Stop();
            }
            else if (Continue.Text == "Continue")
            {
                //继续事件
                Continue.Text = "Pause";
                sw.Start();
                time.Start();
            }
        }
    }
}
