using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class MainFrm : Form
    {

        public MainFrm()
        {
            InitializeComponent();
        }

        private void startTaskBtn_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(ThreadProc);
            t.IsBackground = true;
            t.Start();
        }

        private void ThreadProc()
        {
            for (var i = 0; i < 100; ++i)
            {
                taskStatuslbl.Invoke(new Action(() => taskStatuslbl.Text=string.Format("Work Done {0}%", i)));
                Thread.Sleep(1000);
            }
        }

    }
}
