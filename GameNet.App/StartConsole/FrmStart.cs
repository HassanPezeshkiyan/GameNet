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
        Stopwatch stopWatch1;
        Stopwatch stopWatch2;
        Stopwatch stopWatch3;
        Stopwatch stopWatch4;
        Stopwatch stopWatch5;
        Stopwatch stopWatch6;
        public FrmStart() {
            InitializeComponent();
            groupBoxConsole1.Visible = false;
            groupBoxConsole2.Visible = false;
            groupBoxConsole3.Visible = false;
            groupBoxConsole4.Visible = false;
            groupBoxConsole5.Visible = false;
            groupBoxConsole6.Visible = false;

        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Visible = false;
        }

        private void FrmStart_Load(object sender, EventArgs e) {
            stopWatch1 = new Stopwatch();
            stopWatch2 = new Stopwatch();
            stopWatch3 = new Stopwatch();
            stopWatch4 = new Stopwatch();
            stopWatch5 = new Stopwatch();
            stopWatch6 = new Stopwatch();

        }

        private void timer1_Tick(object sender, EventArgs e) {
            time1Txt.Text = string.Format("{0:hh\\:mm\\:ss}", stopWatch1.Elapsed);

        }

        private void buttonSelectConsole_Click(object sender, EventArgs e) {
            FrmChooseConsole frmChoose = new FrmChooseConsole();
            frmChoose.ShowDialog();
            if (DialogResult == DialogResult.OK) {
                frmChoose.Close();
            }
            switch (frmChoose.selectedConsole) {
                default:
                    break;
                case 1:
                    groupBoxConsole1.Visible = true;
                    break;
                case 2:
                    groupBoxConsole2.Visible = true;
                    break;
                case 3:
                    groupBoxConsole3.Visible = true;
                    break;
                case 4:
                    groupBoxConsole4.Visible = true;
                    break;
                case 5:
                    groupBoxConsole5.Visible = true;
                    break;
                case 6:
                    groupBoxConsole6.Visible = true;
                    break;

            }
        }

        private void start1Timer_Click(object sender, EventArgs e) {
            stopWatch1.Start();
        }

        private void stop1Timer_Click(object sender, EventArgs e) {
            stopWatch1.Stop();
        }

        private void reset1Timer_Click(object sender, EventArgs e) {
            stopWatch1.Reset();
        }

        private void reset2Timer_Click(object sender, EventArgs e) {
            stopWatch2.Reset();
        }

        private void stop2Timer_Click(object sender, EventArgs e) {
            stopWatch2.Stop();
        }

        private void start2Timer_Click(object sender, EventArgs e) {
            stopWatch2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e) {
            time2Txt.Text = string.Format("{0:hh\\:mm\\:ss}", stopWatch2.Elapsed);
        }

        void getHouer(string time) {

        }

        private void pay1Btn_Click(object sender, EventArgs e) {
            stopWatch1.Stop();
            string[] timeValue = time1Txt.Text.Split(':');
        }
    }
}
