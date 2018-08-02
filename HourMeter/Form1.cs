using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
        /// 实现窗体总是置于窗体的最上层；  ETA： 8/5/2018
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        Timer time = new Timer();
        Stopwatch sw;
        TimeSpan ts;       
        string startTime;
        string endTime;
        
        private void Start_Click(object sender, EventArgs e)
        {
            //开始计时，记录开始时间
            startTime = DateTime.Now.ToString();
            //启用stop和record功能
            Stop.Enabled = true;
            Record.Enabled = true;
            Stop.Text = "Pause";           
            sw = new Stopwatch();
            time.Tick += new EventHandler(time_Tick);
            time.Interval = 1;
            sw.Start();
            time.Start();
        }

        void time_Tick(object sender, EventArgs e)
        {
            ts = sw.Elapsed;
            texResult.Text = string.Format("{0}:{1}:{2}:{3}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //加载窗体时，禁用stop和record功能
            Stop.Enabled = false;
            Record.Enabled = false;
        }

        private void Record_Click(object sender, EventArgs e)
        {
            //完成一次计时，记录时间，包括起始时间，结束时间，总共时长，中间是否暂停时间，真正记录时长；
            //MessageBox的用法；
            MessageBox.Show("开始时间：" + startTime + "\r\n" + "结束时间：" + endTime, "Result");

            #region  发送邮件功能关闭
            //实例化一个发送邮件类。
            //MailMessage mailMessage = new MailMessage();
            //发件人邮箱地址，方法重载不同，可以根据需求自行选择。
            //mailMessage.From = new MailAddress("v-shid@microsoft.com");
            //收件人邮箱地址。
            //mailMessage.To.Add(new MailAddress("1554670709@qq.com"));
            //mailMessage.To.Add(new MailAddress("1554670709@qq.com"));
            //邮件标题。
            //mailMessage.Subject = "记录时间";
            //邮件内容。
            //mailMessage.Body = "开始时间：" + startTime + "\r\n" + "结束时间：" + endTime;


            //实例化一个SmtpClient类。
            //SmtpClient client = new SmtpClient();
            //在这里我使用的是qq邮箱，所以是smtp.qq.com，如果你使用的是126邮箱，那么就是smtp.126.com。
            //client.Host = "smtp.qq.com";
            //使用安全加密连接。
            //client.EnableSsl = true;
            //不和请求一块发送。
            //client.UseDefaultCredentials = false;
            //验证发件人身份(发件人的邮箱，邮箱里的生成授权码);
            //client.Credentials = new NetworkCredential("123456@qq.com", "fnsedjxib");
            //发送
            //client.Send(mailMessage);
            //Context.Response.Write("发送成功");
            #endregion


        }

    }
}
