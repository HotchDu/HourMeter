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
        /// <summary>
        /// 实现计时功能 时间格局：小时，分钟，秒数，毫秒数； ETA:7/16/2018
        /// 实现记录功能：写入XML文件； ETA: 7/18/2018
        /// 实现发送邮件功能； ETA： 7/21/2018
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        Timer time = new Timer();
        Stopwatch sw;
        TimeSpan ts;
        //static int count = 1;
        string startTime;
        string endTime;
        
        private void Start_Click(object sender, EventArgs e)
        {
            //if (Start.Text == "Continue")
            //    Start.Text = "Start";
            //开始按键：
            //Continue.Enabled = true;
            startTime = DateTime.Now.ToString();
            Stop.Enabled = true;
            Stop.Text = "Pause";
            //if (Continue.Text == "Continue")
            //    Continue.Text = "Pause";
            sw = new Stopwatch();
            time.Tick += new EventHandler(time_Tick);
            time.Interval = 1;
            sw.Start();
            time.Start();
        }

        void time_Tick(object sender, EventArgs e)
        {
            Lab_Time.Visible = true;
            ts = sw.Elapsed;
            texHour.Text = string.Format("{0}", ts.Hours);
            texMin.Text = string.Format("{0}", ts.Minutes);
            texSec.Text = string.Format("{0}", ts.Seconds);
            texMinSec.Text = string.Format("{0}", ts.Milliseconds / 10);

            Lab_Time.Text = string.Format("{0}:{1}:{2}:{3}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            Start.Enabled = false; //禁用start按键
            //实现暂停功能
            if (Stop.Text == "Pause")
            {
                Stop.Text = "Continue";
                sw.Stop();
                time.Stop();
                endTime = DateTime.Now.ToString();
            }
            //实现继续功能            
            else if(Stop.Text == "Continue")
            {
                Stop.Enabled = true;
                Stop.Text = "Pause";
                time.Tick += new EventHandler(time_Tick);
                time.Interval = 1;
                sw.Start();
                time.Start();
                
            }
            //Start.Text = "Continue";



            //停止时间按钮
            //sw.Stop();
            //time.Stop();
            //Lab_Time.Text = string.Format("{0}:{1}:{2}:{3}", 0, 0, 0, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Continue.Enabled = false;
            Stop.Enabled = false;
        }

        private void Record_Click(object sender, EventArgs e)
        {
            //完成一次计时，记录时间，包括起始时间，结束时间，总共时长，中间是否暂停时间，真正记录时长；
            //MessageBox的用法；
            MessageBox.Show("开始时间：" + startTime + "\r\n" + "结束时间：" + endTime, "Result");
            
        }

        /// <summary>
        /// 继续按钮，移植其功能到Stop按键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void Continue_Click(object sender, EventArgs e)
        //{
        //    if (Continue.Text == "Pause")
        //    {
        //        //暂停事件按钮
        //        Continue.Text = "Continue";
        //        sw.Stop();
        //        time.Stop();
        //    }
        //    else if (Continue.Text == "Continue")
        //    {
        //        //继续事件
        //        Continue.Text = "Pause";
        //        sw.Start();
        //        time.Start();
        //    }
        //}
    }
}
