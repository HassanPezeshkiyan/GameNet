using GameNet.App.Login;
using GameNet.App.Settings;
using GameNet.App.Shoping;
using GameNet.App.StartConsole;
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
        int userId = 0;
        public mainFrm() {
            InitializeComponent();

        }

        private void mainFrm_Load(object sender, EventArgs e) {
            
            //deletShop1Btn.Enabled = false;
            //deletShop2Btn.Enabled = false;
            //deletShop3Btn.Enabled = false;
            //deletShop4Btn.Enabled = false;
            //deletShop5Btn.Enabled = false;
            //deletShop6Btn.Enabled = false;
            this.Hide();
            LoginFrm frmLogin = new LoginFrm();
            if (frmLogin.ShowDialog() == DialogResult.OK) {
                this.Show();
            }
            else {
                Application.Exit();
            }

            labelUserName.Text = frmLogin.userName;
            userId = frmLogin.userId;
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm, Panel panel, DockStyle dockStyle) {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = dockStyle;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        //private void openChildFormConsoles(Form childForm, Panel panel, DockStyle dockStyle) {
        //    childForm.TopLevel = false;
        //    childForm.FormBorderStyle = FormBorderStyle.None;
        //    childForm.Dock = dockStyle;
        //    panel.Controls.Add(childForm);
        //    panel.Tag = childForm;
        //    childForm.Show();

        //}
        private void shopSettingBtn_Click(object sender, EventArgs e) {

            openChildForm(new ShopFrm(), panelContainer, DockStyle.Fill);
        }

        /// <summary>
        /// دکمه افزودن خوراکی
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void shop1Btn_Click(object sender, EventArgs e) {
        //    const int shopId = 1;
        //    shopViewFrm shopVwFrm = new shopViewFrm();
        //    shopVwFrm.shopId = shopId;
        //    shopVwFrm.ShowDialog();
        //    if (shopVwFrm.orderChecked == 1) {
        //        using (UnitOfWork db = new UnitOfWork()) {
        //            var order = db.OrderRepository.Get().Where(n => n.userId == shopId).LastOrDefault();
        //            var shop = db.ShopRepository.GetShopById((int)order.ShopId);
        //            shopCostLbl1.Text = order.amount.ToString() + " " + "تومان";
        //            shop1NameLbl.Text = shop.Name.ToString() + " " + order.quantity;
        //        }
        //        Shoping1 = true;
        //        deletShop1Btn.Enabled = true;
        //    }
        //}
        //private void shop2Btn_Click(object sender, EventArgs e) {
        //    const int shopId = 2;
        //    shopViewFrm shopVwFrm = new shopViewFrm();
        //    shopVwFrm.shopId = shopId;
        //    shopVwFrm.ShowDialog();
        //    if (shopVwFrm.orderChecked == 1) {
        //        using (UnitOfWork db = new UnitOfWork()) {
        //            var order = db.OrderRepository.Get().Where(n => n.userId == shopId).LastOrDefault();
        //            var shop = db.ShopRepository.GetShopById((int)order.ShopId);
        //            shopCostLbl2.Text = order.amount.ToString() + " " + "تومان";
        //            shop2NameLbl.Text = shop.Name.ToString() + " " + order.quantity;
        //        }
        //        Shoping2 = true;
        //        deletShop2Btn.Enabled = true;
        //    }
        //}
        //private void shop3Btn_Click(object sender, EventArgs e) {
        //    const int shopId = 3;
        //    shopViewFrm shopVwFrm = new shopViewFrm();
        //    shopVwFrm.shopId = shopId;
        //    shopVwFrm.ShowDialog();
        //    if (shopVwFrm.orderChecked == 1) {
        //        using (UnitOfWork db = new UnitOfWork()) {
        //            var order = db.OrderRepository.Get().Where(n => n.userId == shopId).LastOrDefault();
        //            var shop = db.ShopRepository.GetShopById((int)order.ShopId);
        //            shopCostLbl3.Text = order.amount.ToString() + " " + "تومان";
        //            shop3NameLbl.Text = shop.Name.ToString() + " " + order.quantity;
        //        }
        //        Shoping3 = true;
        //        deletShop3Btn.Enabled = true;
        //    }
        //}
        //private void shop4Btn_Click(object sender, EventArgs e) {
        //    const int shopId = 4;
        //    shopViewFrm shopVwFrm = new shopViewFrm();
        //    shopVwFrm.shopId = shopId;
        //    shopVwFrm.ShowDialog();

        //    if (shopVwFrm.orderChecked == 1) {
        //        using (UnitOfWork db = new UnitOfWork()) {
        //            var order = db.OrderRepository.Get().Where(n => n.userId == shopId).LastOrDefault();
        //            var shop = db.ShopRepository.GetShopById((int)order.ShopId);
        //            shopCostLbl4.Text = order.amount.ToString() + " " + "تومان";
        //            shop4NameLbl.Text = shop.Name.ToString() + " " + order.quantity;
        //        }
        //        Shoping4 = true;
        //        deletShop4Btn.Enabled = true;
        //    }
        //}
        //private void shop5Btn_Click(object sender, EventArgs e) {
        //    const int shopId = 5;
        //    shopViewFrm shopVwFrm = new shopViewFrm();
        //    shopVwFrm.shopId = shopId;
        //    shopVwFrm.ShowDialog();
        //    if (shopVwFrm.orderChecked == 1) {
        //        using (UnitOfWork db = new UnitOfWork()) {
        //            var order = db.OrderRepository.Get().Where(n => n.userId == shopId).LastOrDefault();
        //            var shop = db.ShopRepository.GetShopById((int)order.ShopId);
        //            shopCostLbl5.Text = order.amount.ToString() + " " + "تومان";
        //            shop5NameLbl.Text = shop.Name.ToString() + " " + order.quantity;
        //        }
        //        Shoping5 = true;
        //        deletShop5Btn.Enabled = true;
        //    }
        //}
        //private void shop6Btn_Click(object sender, EventArgs e) {
        //    const int shopId = 6;
        //    shopViewFrm shopVwFrm = new shopViewFrm();
        //    shopVwFrm.shopId = shopId;
        //    shopVwFrm.ShowDialog();
        //    if (shopVwFrm.orderChecked == 1) {
        //        using (UnitOfWork db = new UnitOfWork()) {
        //            var order = db.OrderRepository.Get().Where(n => n.userId == shopId).LastOrDefault();
        //            var shop = db.ShopRepository.GetShopById((int)order.ShopId);
        //            shopCostLbl6.Text = order.amount.ToString() + " " + "تومان";
        //            shop6NameLbl.Text = shop.Name.ToString() + " " + order.quantity;
        //        }
        //        Shoping6 = true;
        //        deletShop6Btn.Enabled = true;
        //    }
        //}


        /// <summary>
        /// دکمه حذف بوفه
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void deletShop1Btn_Click(object sender, EventArgs e) {

        //    using (UnitOfWork db = new UnitOfWork()) {
        //        var order = db.OrderRepository.Get().Where(n => n.userId == 1).LastOrDefault();
        //        var shop = db.ShopRepository.GetShopById((int)order.ShopId);
        //        if (order != null && Shoping1 == true && MessageBox.Show($"آیا از حذف {shop.Name} مطمئن هستید ؟", "توجه", MessageBoxButtons.YesNo,
        //                         MessageBoxIcon.Warning) == DialogResult.Yes) {
        //            db.OrderRepository.Delete(order);
        //            shop.Quantity += order.quantity;
        //            db.Save();
        //        }
        //    }
        //    deletShop1Btn.Enabled = false;
        //    shopCostLbl1.Text = "";
        //    shop1NameLbl.Text = "";
        //}

        //private void deletShop2Btn_Click_1(object sender, EventArgs e) {
        //    using (UnitOfWork db = new UnitOfWork()) {
        //        var order = db.OrderRepository.Get().Where(n => n.userId == 2).LastOrDefault();
        //        var shop = db.ShopRepository.GetShopById((int)order.ShopId);
        //        if (order != null && Shoping2 == true && MessageBox.Show($"آیا از حذف {shop.Name} مطمئن هستید ؟", "توجه", MessageBoxButtons.YesNo,
        //                         MessageBoxIcon.Warning) == DialogResult.Yes) {
        //            db.OrderRepository.Delete(order);
        //            shop.Quantity += order.quantity;
        //            db.Save();
        //        }
        //    }
        //    deletShop2Btn.Enabled = false;
        //    shopCostLbl2.Text = "";
        //    shop2NameLbl.Text = "";
        //}

        //private void deletShop3Btn_Click_1(object sender, EventArgs e) {
        //    using (UnitOfWork db = new UnitOfWork()) {
        //        var order = db.OrderRepository.Get().Where(n => n.userId == 3).LastOrDefault();
        //        var shop = db.ShopRepository.GetShopById((int)order.ShopId);
        //        if (order != null && Shoping3 == true && MessageBox.Show($"آیا از حذف {shop.Name} مطمئن هستید ؟", "توجه", MessageBoxButtons.YesNo,
        //                         MessageBoxIcon.Warning) == DialogResult.Yes) {
        //            db.OrderRepository.Delete(order);
        //            shop.Quantity += order.quantity;
        //            db.Save();
        //        }
        //    }
        //    deletShop3Btn.Enabled = false;
        //    shopCostLbl3.Text = "";
        //    shop3NameLbl.Text = "";
        //}

        //private void deletShop4Btn_Click_1(object sender, EventArgs e) {
        //    using (UnitOfWork db = new UnitOfWork()) {
        //        var order = db.OrderRepository.Get().Where(n => n.userId == 4).LastOrDefault();
        //        var shop = db.ShopRepository.GetShopById((int)order.ShopId);
        //        if (order != null && Shoping4 == true && MessageBox.Show($"آیا از حذف {shop.Name} مطمئن هستید ؟", "توجه", MessageBoxButtons.YesNo,
        //                         MessageBoxIcon.Warning) == DialogResult.Yes) {
        //            db.OrderRepository.Delete(order);
        //            shop.Quantity += order.quantity;
        //            db.Save();
        //        }
        //    }
        //    deletShop4Btn.Enabled = false;
        //    shopCostLbl4.Text = "";
        //    shop4NameLbl.Text = "";
        //}

        //private void deletShop5Btn_Click_1(object sender, EventArgs e) {
        //    using (UnitOfWork db = new UnitOfWork()) {
        //        var order = db.OrderRepository.Get().Where(n => n.userId == 5).LastOrDefault();
        //        var shop = db.ShopRepository.GetShopById((int)order.ShopId);
        //        if (order != null && Shoping5 == true && MessageBox.Show($"آیا از حذف {shop.Name} مطمئن هستید ؟", "توجه", MessageBoxButtons.YesNo,
        //                         MessageBoxIcon.Warning) == DialogResult.Yes) {
        //            db.OrderRepository.Delete(order);
        //            shop.Quantity += order.quantity;
        //            db.Save();
        //        }
        //    }
        //    deletShop5Btn.Enabled = false;
        //    shopCostLbl5.Text = "";
        //    shop5NameLbl.Text = "";
        //}

        //private void deletShop6Btn_Click_1(object sender, EventArgs e) {
        //    using (UnitOfWork db = new UnitOfWork()) {
        //        var order = db.OrderRepository.Get().Where(n => n.userId == 6).LastOrDefault();
        //        var shop = db.ShopRepository.GetShopById((int)order.ShopId);
        //        if (order != null && Shoping6 == true && MessageBox.Show($"آیا از حذف {shop.Name} مطمئن هستید ؟", "توجه", MessageBoxButtons.YesNo,
        //                         MessageBoxIcon.Warning) == DialogResult.Yes) {
        //            db.OrderRepository.Delete(order);
        //            shop.Quantity += order.quantity;
        //            db.Save();
        //        }

        //    }
        //    deletShop6Btn.Enabled = false;
        //    shopCostLbl6.Text = "";
        //    shop6NameLbl.Text = "";
        //}


        private void settingBtn_Click(object sender, EventArgs e) {
            openChildForm(new settingFrm(), panelContainer, DockStyle.Fill);

        }

        private void btnEditProfile_Click(object sender, EventArgs e) {
            EditInfoFrm editform = new EditInfoFrm();
            editform.userId = userId;
            editform.ShowDialog();

        }

        private void btnClose_Click(object sender, EventArgs e) {
            Application.Exit();
        }

       

        private void btnStart_Click(object sender, EventArgs e) {
            FrmStart frmStart = new FrmStart();
            frmStart.Show();
        }
    }
}


