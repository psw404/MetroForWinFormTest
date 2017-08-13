using System;
using System.Media;
using log4net;
using System.Reflection;
using System.Windows.Forms;
using PSW2AdamTeach;
using System.Data;
using PSW2NPOI;
using System.IO;
using MetroForWinFormTest.Util;
using System.ComponentModel;

namespace MetroForWinFormTest
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private SoundPlayer player;
        private static ILog log;
        AdamHelper adamhelper;

        public Form1()
        {
            InitializeComponent();
            string ip = "192.168.1.3";
            AdamType series = AdamType.Adam6200; 
            Adam6000Type type = Adam6000Type.Adam6217;
            adamhelper = new AdamHelper(ip, series, type);
            adamhelper.OnReady(); 


        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            player = new SoundPlayer();
            player.SoundLocation = @"..\..\audio\7270.wav";
            player.Load();
            player.Play();
            //player.PlayLooping();
            string str = "hello";

            string name = MethodBase.GetCurrentMethod().Name;
            Type type = MethodBase.GetCurrentMethod().DeclaringType;

            log = LogManager.GetLogger(type);
            log.Info(str);
            log.Warn(str);
            log.Error(str);
            log.Fatal(str);
            log.Debug("this is first to use logger");
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            player.Stop();
            SystemSounds.Exclamation.Play();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            adamhelper.OnReady();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            adamhelper.modbusStart = adamhelper.Disconnect();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string[] list = adamhelper.Read();
            tbx0.Text = list[0];
            tbx1.Text = list[1];
            tbx2.Text = list[2];
        }

        private void btnKeepRead_Click(object sender, EventArgs e)
        {
            string[] list = adamhelper.Read();
            tbx0.Text = list[0];
            tbx1.Text = list[1];
            tbx2.Text = list[2];
        }

        private void CreateExcelTest()
        {
            NPOIHelper npoi = new NPOIHelper();
            DataTable dt = CreateDataTable();

            try
            {
                npoi.ConvertTableToExcel(dt);

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel文件|*.xls";
                saveFileDialog.FileName = ConvertToString(DateTime.Now);
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create);
                    npoi.WriteToFile(fs);
                    MessageBox.Show("表" + dt.TableName + "生成成功");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string ConvertToString(DateTime dateTime)
        {
            return dateTime.ToString("yyyy-MM-dd HH-mm-ss ");
        }

        private DataTable CreateDataTable()
        {
            DataTable dt = new DataTable("test");

            for (int i = 0; i < 10; i++)
            {
                dt.Columns.Add(new DataColumn("第" + i.ToString() + "列"));
            }

            for (int j = 0; j < 100; j++)
            {
                DataRow dr = dt.NewRow();
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    dr[i] = j + ",你好," + i;
                }
                dt.Rows.Add(dr);

            }
            return dt;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            CreateExcelTest();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            string str = "psw";
            string pw = Encrypt.Encode(str);
            MessageBox.Show(pw);
            MessageBox.Show(Encrypt.Decode(pw));
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            Work work = new Work();
            work.BgStart();
        }
    }
}
