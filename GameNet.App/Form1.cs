using GameNet.App.Shoping;
using GameNet.DataLayer.Context;
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
        readonly public UnitOfWork db = new UnitOfWork();
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
            const int shopId = 1;
            shopViewFrm shopVwFrm = new shopViewFrm(shopId);
            shopVwFrm.ShowDialog();
            var order = db.OrderRepository.Get().Where(n => n.userId == shopId).LastOrDefault();
            shopCostLbl1.Text = order.amount.ToString() + " " + "تومان";
        }


        private void shop2Btn_Click(object sender, EventArgs e)
        {
            const int shopId = 2;
            shopViewFrm shopVwFrm = new shopViewFrm(shopId);
            shopVwFrm.ShowDialog();
            var order = db.OrderRepository.Get().Where(n => n.userId == shopId).LastOrDefault();
            shopCostLbl2.Text = order.amount.ToString() + " " + "تومان";
        }

        private void shop3Btn_Click(object sender, EventArgs e)
        {
            const int shopId = 3;
            shopViewFrm shopVwFrm = new shopViewFrm(shopId);
            shopVwFrm.ShowDialog();
            var order = db.OrderRepository.Get().Where(n => n.userId == shopId).LastOrDefault();
            shopCostLbl3.Text = order.amount.ToString() + " " + "تومان";
        }

        private void shop4Btn_Click(object sender, EventArgs e)
        {
            const int shopId = 4;
            shopViewFrm shopVwFrm = new shopViewFrm(shopId);
            shopVwFrm.ShowDialog();
            var order = db.OrderRepository.Get().Where(n => n.userId == shopId).LastOrDefault();
            shopCostLbl4.Text = order.amount.ToString() + " " + "تومان";
        }

        private void shop5Btn_Click(object sender, EventArgs e)
        {
            const int shopId = 5;
            shopViewFrm shopVwFrm = new shopViewFrm(shopId);
            shopVwFrm.ShowDialog();
            var order = db.OrderRepository.Get().Where(n => n.userId == shopId).LastOrDefault();
            shopCostLbl5.Text = order.amount.ToString() + " " + "تومان";
        }

        private void shop6Btn_Click(object sender, EventArgs e)
        {
            const int shopId = 6;
            shopViewFrm shopVwFrm = new shopViewFrm(shopId);
            shopVwFrm.ShowDialog();
            var order = db.OrderRepository.Get().Where(n => n.userId == shopId).LastOrDefault();
            shopCostLbl6.Text = order.amount.ToString() + " " + "تومان";
        }
    }
}

