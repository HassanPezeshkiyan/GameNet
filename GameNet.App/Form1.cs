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
        //readonly public UnitOfWork db = new UnitOfWork();

        /// <summary>
        /// چک کردن خرید ثبت شده 1 
        /// </summary>
        public bool Shoping1;

        /// <summary>
        /// چک کردن خرید ثبت شده 2 
        /// </summary>
        public bool Shoping2;

        /// <summary>
        /// چک کردن خرید ثبت شده 3 
        /// </summary>
        public bool Shoping3;

        /// <summary>
        /// چک کردن خرید ثبت شده 4 
        /// </summary>
        public bool Shoping4;

        /// <summary>
        /// چک کردن خرید ثبت شده 5 
        /// </summary>
        public bool Shoping5;

        /// <summary>
        /// چک کردن خرید ثبت شده 6 
        /// </summary>
        public bool Shoping6;

        public mainFrm()
        {
            InitializeComponent();
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


        /// <summary>
        /// دکمه افزودن خوراکی
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void shop1Btn_Click(object sender, EventArgs e)
        {
            const int shopId = 1;
            shopViewFrm shopVwFrm = new shopViewFrm(shopId);
            shopVwFrm.ShowDialog();
            if (shopVwFrm.orderChecked == 1)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var order = db.OrderRepository.Get().Where(n => n.userId == shopId).LastOrDefault();
                    shopCostLbl1.Text = order.amount.ToString() + " " + "تومان";
                }

                deletShop1Btn.Enabled = true;
            }
            Shoping1 = true;
        }
        private void shop2Btn_Click(object sender, EventArgs e)
        {
            const int shopId = 2;
            shopViewFrm shopVwFrm = new shopViewFrm(shopId);
            shopVwFrm.ShowDialog();
            if (shopVwFrm.orderChecked == 1)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var order = db.OrderRepository.Get().Where(n => n.userId == shopId).LastOrDefault();
                    shopCostLbl2.Text = order.amount.ToString() + " " + "تومان";
                }
                deletShop2Btn.Enabled = true;
            }
            Shoping2 = true;
        }
        private void shop3Btn_Click(object sender, EventArgs e)
        {
            const int shopId = 3;
            shopViewFrm shopVwFrm = new shopViewFrm(shopId);
            shopVwFrm.ShowDialog();
            if (shopVwFrm.orderChecked == 1)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var order = db.OrderRepository.Get().Where(n => n.userId == shopId).LastOrDefault();
                    shopCostLbl3.Text = order.amount.ToString() + " " + "تومان";
                }
                deletShop3Btn.Enabled = true;
            }
            Shoping3 = true;
        }
        private void shop4Btn_Click(object sender, EventArgs e)
        {
            const int shopId = 4;
            shopViewFrm shopVwFrm = new shopViewFrm(shopId);
            shopVwFrm.ShowDialog();

            if (shopVwFrm.orderChecked == 1)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var order = db.OrderRepository.Get().Where(n => n.userId == shopId).LastOrDefault();
                    shopCostLbl4.Text = order.amount.ToString() + " " + "تومان";
                }
                deletShop4Btn.Enabled = true;
            }
            Shoping4 = true;
        }
        private void shop5Btn_Click(object sender, EventArgs e)
        {
            const int shopId = 5;
            shopViewFrm shopVwFrm = new shopViewFrm(shopId);
            shopVwFrm.ShowDialog();
            if (shopVwFrm.orderChecked == 1)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var order = db.OrderRepository.Get().Where(n => n.userId == shopId).LastOrDefault();
                    shopCostLbl5.Text = order.amount.ToString() + " " + "تومان";
                }
                deletShop5Btn.Enabled = true;
            }
            Shoping5 = true;
        }
        private void shop6Btn_Click(object sender, EventArgs e)
        {
            const int shopId = 6;
            shopViewFrm shopVwFrm = new shopViewFrm(shopId);
            shopVwFrm.ShowDialog();
            if (shopVwFrm.orderChecked == 1)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var order = db.OrderRepository.Get().Where(n => n.userId == shopId).LastOrDefault();
                    shopCostLbl6.Text = order.amount.ToString() + " " + "تومان";
                }
                deletShop6Btn.Enabled = true;
            }
            Shoping6 = true;
        }


        /// <summary>
        /// دکمه حذف بوفه
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deletShop1Btn_Click(object sender, EventArgs e)
        {

            using (UnitOfWork db = new UnitOfWork())
            {
                var order = db.OrderRepository.Get().Where(n => n.userId == 1).LastOrDefault();

                if (order != null && Shoping1 == true && MessageBox.Show($"آیا از حذف {order.amount} مطمئن هستید ؟", "توجه", MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.OrderRepository.Delete(order);
                    db.Save();
                }
            }
            deletShop1Btn.Enabled = false;
            shopCostLbl1.Text = "";
        }

        private void deletShop2Btn_Click_1(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var order = db.OrderRepository.Get().Where(n => n.userId == 2).LastOrDefault();

                if (order != null && Shoping2 == true && MessageBox.Show($"آیا از حذف {order.amount} مطمئن هستید ؟", "توجه", MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.OrderRepository.Delete(order);
                    db.Save();
                }
            }
            deletShop2Btn.Enabled = false;
            shopCostLbl2.Text = "";
        }

        private void deletShop3Btn_Click_1(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var order = db.OrderRepository.Get().Where(n => n.userId == 3).LastOrDefault();

                if (order != null && Shoping3 == true && MessageBox.Show($"آیا از حذف {order.amount} مطمئن هستید ؟", "توجه", MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.OrderRepository.Delete(order);
                    db.Save();
                }
            }
            deletShop3Btn.Enabled = false;
            shopCostLbl3.Text = "";
        }

        private void deletShop4Btn_Click_1(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var order = db.OrderRepository.Get().Where(n => n.userId == 4).LastOrDefault();

                if (order != null && Shoping4 == true && MessageBox.Show($"آیا از حذف {order.amount} مطمئن هستید ؟", "توجه", MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.OrderRepository.Delete(order);
                    db.Save();
                }
            }
            deletShop4Btn.Enabled = false;
            shopCostLbl4.Text = "";
        }

        private void deletShop5Btn_Click_1(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var order = db.OrderRepository.Get().Where(n => n.userId == 5).LastOrDefault();

                if (order != null && Shoping5 == true && MessageBox.Show($"آیا از حذف {order.amount} مطمئن هستید ؟", "توجه", MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.OrderRepository.Delete(order);
                    db.Save();
                }
            }
            deletShop5Btn.Enabled = false;
            shopCostLbl5.Text = "";
        }

        private void deletShop6Btn_Click_1(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var order = db.OrderRepository.Get().Where(n => n.userId == 6).LastOrDefault();

                if (order != null && Shoping6 == true && MessageBox.Show($"آیا از حذف {order.amount} مطمئن هستید ؟", "توجه", MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.OrderRepository.Delete(order);
                    db.Save();
                }
            }
            deletShop6Btn.Enabled = false;
            shopCostLbl6.Text = "";
        }
    }
}


