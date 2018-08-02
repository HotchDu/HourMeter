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
            this.texResult = new System.Windows.Forms.TextBox();
            this.Stop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Record = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(12, 56);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // texResult
            // 
            this.texResult.Location = new System.Drawing.Point(109, 12);
            this.texResult.Multiline = true;
            this.texResult.Name = "texResult";
            this.texResult.Size = new System.Drawing.Size(64, 19);
            this.texResult.TabIndex = 2;
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(109, 55);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 23);
            this.Stop.TabIndex = 5;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Record
            // 
            this.Record.Location = new System.Drawing.Point(205, 56);
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
            this.ClientSize = new System.Drawing.Size(318, 111);
            this.Controls.Add(this.Record);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.texResult);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.Text = "HourMeter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox texResult;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Record;
    }
}

