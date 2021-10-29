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

namespace GameNet.App.StartConsole
{
    public partial class FrmStart : Form
    {
        Stopwatch stopWatch;
        public FrmStart() {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Visible = false;
        }

        private void FrmStart_Load(object sender, EventArgs e) {
            stopWatch = new Stopwatch();
        }

        private void btnReset_Click(object sender, EventArgs e) {
            stopWatch.Reset();
        }

        private void startTimer_Click(object sender, EventArgs e) {
            stopWatch.Start();
        }

        private void stopTimer_Click(object sender, EventArgs e) {
            stopWatch.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            time1Txt.Text = string.Format("{0:hh\\:mm\\:ss}",stopWatch.Elapsed);
        }
    }
}
