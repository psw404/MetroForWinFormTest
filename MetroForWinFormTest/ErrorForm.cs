using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetroForWinFormTest
{
    public partial class ErrorForm : Form
    {
        public ErrorForm()
        {
            InitializeComponent();
        }
        private static object obj=new object();
        private static ErrorForm instance;

        public static ErrorForm GetInstance()
        {
            if (instance == null)
            {
                lock (obj)
                {
                    if (instance == null)
                    {
                        instance = new ErrorForm();
                    }
                }
            }

            return instance;
        }

        private void ErrorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        public void doWork(object obj)
        {
            metroLabel1.Text = obj.ToString();
        }
    }
}
