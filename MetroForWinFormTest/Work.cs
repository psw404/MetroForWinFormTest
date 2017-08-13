using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MetroForWinFormTest
{
    public class Work
    {
        public BackgroundWorker bg;
        private static int count = 0;

        public Work()
        {
            bg = new BackgroundWorker();
        }

        private void bgDoWork(object sender, DoWorkEventArgs e)
        {
            Thread.CurrentThread.Name = "bgworker";
            while (true)
            {
                if ((count++ % 10) == 0)
                {
                    bg.ReportProgress(count);
                }
                Thread.Sleep(500);
            }
        }

        public void BgStart()
        {
            bg.WorkerReportsProgress = true;
            bg.DoWork += new DoWorkEventHandler(bgDoWork);
            bg.ProgressChanged += new ProgressChangedEventHandler(bg_ProgressChanged);
            bg.RunWorkerAsync();
        }

        delegate void InvokeMethod(object obj);
        private void bg_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ErrorForm errForm = ErrorForm.GetInstance( );
            errForm.Show();
            errForm.TopMost = true;
            errForm.Invoke(new InvokeMethod(errForm.doWork),count);
        }
    }
}
