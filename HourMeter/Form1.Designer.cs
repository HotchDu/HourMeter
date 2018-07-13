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
            this.Continue = new System.Windows.Forms.Button();
            this.Lab_Time = new System.Windows.Forms.Label();
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
            this.texHour.Location = new System.Drawing.Point(31, 17);
            this.texHour.Multiline = true;
            this.texHour.Name = "texHour";
            this.texHour.Size = new System.Drawing.Size(64, 19);
            this.texHour.TabIndex = 2;
            // 
            // texMin
            // 
            this.texMin.Location = new System.Drawing.Point(117, 17);
            this.texMin.Multiline = true;
            this.texMin.Name = "texMin";
            this.texMin.Size = new System.Drawing.Size(64, 19);
            this.texMin.TabIndex = 3;
            // 
            // texSec
            // 
            this.texSec.Location = new System.Drawing.Point(202, 17);
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
            // Continue
            // 
            this.Continue.Location = new System.Drawing.Point(117, 55);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(75, 23);
            this.Continue.TabIndex = 6;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = true;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // Lab_Time
            // 
            this.Lab_Time.AutoSize = true;
            this.Lab_Time.Location = new System.Drawing.Point(45, 98);
            this.Lab_Time.Name = "Lab_Time";
            this.Lab_Time.Size = new System.Drawing.Size(0, 13);
            this.Lab_Time.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 138);
            this.Controls.Add(this.Lab_Time);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.texSec);
            this.Controls.Add(this.texMin);
            this.Controls.Add(this.texHour);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.Label Lab_Time;
    }
}

