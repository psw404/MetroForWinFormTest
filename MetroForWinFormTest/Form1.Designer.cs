namespace MetroForWinFormTest
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
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.tbx0 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbx1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tbx2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnStart = new MetroFramework.Controls.MetroButton();
            this.btnStop = new MetroFramework.Controls.MetroButton();
            this.btnRead = new MetroFramework.Controls.MetroButton();
            this.btnKeepRead = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(435, 332);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(123, 96);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "playSound";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(578, 405);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "stopSound";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Location = new System.Drawing.Point(343, 332);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(67, 70);
            this.metroProgressSpinner1.TabIndex = 5;
            // 
            // tbx0
            // 
            this.tbx0.Location = new System.Drawing.Point(110, 146);
            this.tbx0.Name = "tbx0";
            this.tbx0.Size = new System.Drawing.Size(101, 23);
            this.tbx0.TabIndex = 6;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 150);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(44, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "通道0";
            // 
            // tbx1
            // 
            this.tbx1.Location = new System.Drawing.Point(110, 187);
            this.tbx1.Name = "tbx1";
            this.tbx1.Size = new System.Drawing.Size(101, 23);
            this.tbx1.TabIndex = 6;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 191);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(42, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "通道1";
            // 
            // tbx2
            // 
            this.tbx2.Location = new System.Drawing.Point(110, 229);
            this.tbx2.Name = "tbx2";
            this.tbx2.Size = new System.Drawing.Size(101, 23);
            this.tbx2.TabIndex = 6;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 233);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(44, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "通道2";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(23, 98);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(136, 98);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "stop";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(256, 97);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 10;
            this.btnRead.Text = "read";
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnKeepRead
            // 
            this.btnKeepRead.Location = new System.Drawing.Point(360, 97);
            this.btnKeepRead.Name = "btnKeepRead";
            this.btnKeepRead.Size = new System.Drawing.Size(75, 23);
            this.btnKeepRead.TabIndex = 11;
            this.btnKeepRead.Text = "keepRead";
            this.btnKeepRead.Click += new System.EventHandler(this.btnKeepRead_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(256, 405);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 12;
            this.metroButton2.Text = "生成Excel";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(145, 405);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(75, 23);
            this.metroButton3.TabIndex = 13;
            this.metroButton3.Text = "生成密码";
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(23, 405);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(94, 23);
            this.metroButton4.TabIndex = 14;
            this.metroButton4.Text = "打开新窗体";
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 451);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.btnKeepRead);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.tbx2);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.tbx1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tbx0);
            this.Controls.Add(this.metroProgressSpinner1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTile1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private MetroFramework.Controls.MetroTextBox tbx0;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbx1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tbx2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnStart;
        private MetroFramework.Controls.MetroButton btnStop;
        private MetroFramework.Controls.MetroButton btnRead;
        private MetroFramework.Controls.MetroButton btnKeepRead;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;
    }
}

