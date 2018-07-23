namespace HourMeter
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Start = new System.Windows.Forms.Button();
            this.texHour = new System.Windows.Forms.TextBox();
            this.texMin = new System.Windows.Forms.TextBox();
            this.texSec = new System.Windows.Forms.TextBox();
            this.Stop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.texMinSec = new System.Windows.Forms.TextBox();
            this.Lab_Time = new System.Windows.Forms.Label();
            this.Record = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(31, 55);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // texHour
            // 
            this.texHour.Location = new System.Drawing.Point(12, 17);
            this.texHour.Multiline = true;
            this.texHour.Name = "texHour";
            this.texHour.Size = new System.Drawing.Size(64, 19);
            this.texHour.TabIndex = 2;
            // 
            // texMin
            // 
            this.texMin.Location = new System.Drawing.Point(92, 17);
            this.texMin.Multiline = true;
            this.texMin.Name = "texMin";
            this.texMin.Size = new System.Drawing.Size(64, 19);
            this.texMin.TabIndex = 3;
            // 
            // texSec
            // 
            this.texSec.Location = new System.Drawing.Point(171, 17);
            this.texSec.Multiline = true;
            this.texSec.Name = "texSec";
            this.texSec.Size = new System.Drawing.Size(64, 19);
            this.texSec.TabIndex = 4;
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(202, 56);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 23);
            this.Stop.TabIndex = 5;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // texMinSec
            // 
            this.texMinSec.Location = new System.Drawing.Point(256, 17);
            this.texMinSec.Multiline = true;
            this.texMinSec.Name = "texMinSec";
            this.texMinSec.Size = new System.Drawing.Size(64, 19);
            this.texMinSec.TabIndex = 6;
            // 
            // Lab_Time
            // 
            this.Lab_Time.AutoSize = true;
            this.Lab_Time.Location = new System.Drawing.Point(40, 113);
            this.Lab_Time.Name = "Lab_Time";
            this.Lab_Time.Size = new System.Drawing.Size(0, 13);
            this.Lab_Time.TabIndex = 7;
            // 
            // Record
            // 
            this.Record.Location = new System.Drawing.Point(375, 55);
            this.Record.Name = "Record";
            this.Record.Size = new System.Drawing.Size(75, 23);
            this.Record.TabIndex = 8;
            this.Record.Text = "Record";
            this.Record.UseVisualStyleBackColor = true;
            this.Record.Click += new System.EventHandler(this.Record_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 362);
            this.Controls.Add(this.Record);
            this.Controls.Add(this.Lab_Time);
            this.Controls.Add(this.texMinSec);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.texSec);
            this.Controls.Add(this.texMin);
            this.Controls.Add(this.texHour);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.Text = "HourMeter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox texHour;
        private System.Windows.Forms.TextBox texMin;
        private System.Windows.Forms.TextBox texSec;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox texMinSec;
        private System.Windows.Forms.Label Lab_Time;
        private System.Windows.Forms.Button Record;
    }
}

