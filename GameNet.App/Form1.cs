using GameNet.App.Shoping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameNet.App
{
    public partial class mainFrm : Form
    {
        
        public mainFrm()
        {
            InitializeComponent();
            //groupBox1.BackColor = Color.Transparent;
            //groupBox2.BackColor = Color.Transparent;
            //groupBox3.BackColor = Color.Transparent;
            //groupBox4.BackColor = Color.Transparent;
            //groupBox5.BackColor = Color.Transparent;
            //groupBox6.BackColor = Color.Transparent;
        }

        private void mainFrm_Load(object sender, EventArgs e)
        {
            datetimeLbl.Text = "زمان ورود :" + " " + DateTime.Now.ToShortTimeString();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
           
            Close();
        }

        private void shopSettingBtn_Click(object sender, EventArgs e)
        {
            ShopFrm shopFrm = new ShopFrm();
            shopFrm.ShowDialog();
        }

        private void shop1Btn_Click(object sender, EventArgs e)
        {
            shopViewFrm shopVwFrm = new shopViewFrm();
            shopVwFrm.ShowDialog();
        }
    }
}
