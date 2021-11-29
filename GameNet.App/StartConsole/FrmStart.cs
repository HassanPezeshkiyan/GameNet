using GameNet.App.Invoicing;
using GameNet.App.Shoping;
using GameNet.DataLayer;
using GameNet.DataLayer.Context;
using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
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
        Stopwatch stopWatch7;
        Stopwatch stopWatch8;
        Stopwatch stopWatch9;


        public FrmStart()
        {
            InitializeComponent();

            #region groupbox visible
            groupBoxConsole1.Visible = false;
            groupBoxConsole2.Visible = false;
            groupBoxConsole3.Visible = false;
            groupBoxConsole4.Visible = false;
            groupBoxConsole5.Visible = false;
            groupBoxConsole6.Visible = false;
            groupBoxConsole7.Visible = false;
            groupBoxConsole8.Visible = false;
            groupBoxConsole9.Visible = false;
            #endregion
        }
        public FrmChooseConsole frmChoose = new FrmChooseConsole();

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void FrmStart_Load(object sender, EventArgs e)
        {
            stopWatch1 = new Stopwatch();
            stopWatch2 = new Stopwatch();
            stopWatch3 = new Stopwatch();
            stopWatch4 = new Stopwatch();
            stopWatch5 = new Stopwatch();
            stopWatch6 = new Stopwatch();
            stopWatch7 = new Stopwatch();
            stopWatch8 = new Stopwatch();
            stopWatch9 = new Stopwatch();


        }
        private void FrmStart_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show(@"
آیا از خروج مطمئن هستید؟
در صورت خروج اطلاعات ذخیره نمی شوند

", "اخطار", MessageBoxButtons.OKCancel);
        }

        private void buttonSelectConsole_Click(object sender, EventArgs e)
        {

            frmChoose.ShowDialog();
            frmChoose.indexselected.Add(frmChoose.selectedConsole);
            if (frmChoose.DialogResult == DialogResult.OK)
            {
                frmChoose.Hide();
                switch (frmChoose.selectedConsole)
                {
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
                    case 7:
                        groupBoxConsole7.Visible = true;
                        break;
                    case 8:
                        groupBoxConsole8.Visible = true;
                        break;
                    case 9:
                        groupBoxConsole9.Visible = true;
                        break;

                }
            }


        }

        #region timercontroller
        private void timer1_Tick(object sender, EventArgs e)
        {
            time1Txt.Text = string.Format("{0:hh\\:mm\\:ss}", stopWatch1.Elapsed);
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            time2Txt.Text = string.Format("{0:hh\\:mm\\:ss}", stopWatch2.Elapsed);
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            time3Txt.Text = string.Format("{0:hh\\:mm\\:ss}", stopWatch3.Elapsed);
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            time4Txt.Text = string.Format("{0:hh\\:mm\\:ss}", stopWatch4.Elapsed);
        }
        private void timer5_Tick(object sender, EventArgs e)
        {
            time5Txt.Text = string.Format("{0:hh\\:mm\\:ss}", stopWatch5.Elapsed);
        }
        private void timer6_Tick(object sender, EventArgs e)
        {
            time6Txt.Text = string.Format("{0:hh\\:mm\\:ss}", stopWatch6.Elapsed);
        }
        private void timer7_Tick(object sender, EventArgs e)
        {
            time7Txt.Text = string.Format("{0:hh\\:mm\\:ss}", stopWatch7.Elapsed);
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            time8Txt.Text = string.Format("{0:hh\\:mm\\:ss}", stopWatch8.Elapsed);
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            time9Txt.Text = string.Format("{0:hh\\:mm\\:ss}", stopWatch9.Elapsed);
        }
        #endregion

        #region starttimer
        private void start1Timer_Click(object sender, EventArgs e)
        {
            stopWatch1.Start();

        }
        private void start2Timer_Click(object sender, EventArgs e)
        {
            stopWatch2.Start();
        }
        private void start3Timer_Click(object sender, EventArgs e)
        {
            stopWatch3.Start();
        }
        private void start4Timer_Click(object sender, EventArgs e)
        {
            stopWatch4.Start();
        }
        private void start5Timer_Click(object sender, EventArgs e)
        {
            stopWatch5.Start();
        }
        private void start6Timer_Click(object sender, EventArgs e)
        {
            stopWatch6.Start();
        }
        private void start7Timer_Click(object sender, EventArgs e)
        {
            stopWatch7.Start();
        }

        private void start8Timer_Click(object sender, EventArgs e)
        {
            stopWatch8.Start();
        }

        private void start9Timer_Click(object sender, EventArgs e)
        {
            stopWatch9.Start();
        }
        #endregion

        #region stoptimer
        private void stop1Timer_Click(object sender, EventArgs e)
        {
            stopWatch1.Stop();
        }
        private void stop2Timer_Click(object sender, EventArgs e)
        {
            stopWatch2.Stop();
        }
        private void stop3Timer_Click(object sender, EventArgs e)
        {
            stopWatch3.Stop();
        }
        private void stop4Timer_Click(object sender, EventArgs e)
        {
            stopWatch4.Stop();
        }
        private void stop5Timer_Click(object sender, EventArgs e)
        {
            stopWatch5.Stop();
        }
        private void stop6Timer_Click(object sender, EventArgs e)
        {
            stopWatch6.Stop();
        }
        private void stop7Timer_Click(object sender, EventArgs e)
        {
            stopWatch7.Stop();
        }

        private void stop8Timer_Click(object sender, EventArgs e)
        {
            stopWatch8.Stop();
        }

        private void stop9Timer_Click(object sender, EventArgs e)
        {
            stopWatch9.Stop();
        }
        #endregion

        #region resettimer
        private void reset1Timer_Click(object sender, EventArgs e)
        {
            stopWatch1.Reset();
        }
        private void reset2Timer_Click(object sender, EventArgs e)
        {
            stopWatch2.Reset();
        }
        private void reset3Timer_Click(object sender, EventArgs e)
        {
            stopWatch3.Reset();
        }
        private void reset4Timer_Click(object sender, EventArgs e)
        {
            stopWatch4.Reset();
        }
        private void reset5Timer_Click(object sender, EventArgs e)
        {
            stopWatch5.Reset();
        }
        private void reset6Timer_Click(object sender, EventArgs e)
        {
            stopWatch6.Reset();
        }
        private void reset7Timer_Click(object sender, EventArgs e)
        {
            stopWatch7.Reset();
        }

        private void reset8Timer_Click(object sender, EventArgs e)
        {
            stopWatch8.Reset();
        }

        private void reset9Timer_Click(object sender, EventArgs e)
        {
            stopWatch9.Reset();
        }
        #endregion

        #region shoping
        private void shop1Btn_Click(object sender, EventArgs e)
        {
            shopViewFrm shopForm = new shopViewFrm();
            shopForm.consoleId = 1;
            try
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var id = db.Customer.Get().Where(n => n.ConsoleId == shopForm.consoleId).Select(n => n.Id).Last();
                    shopForm.customerId = id;
                    shopForm.ShowDialog();
                    if (shopForm.DialogResult == DialogResult.OK)
                    {
                        var order = db.OrderRepository.Get()
                            .Where(n => n.CustomerId == id);
                        var orderCost = order.Select(n => n.amount).Sum();
                        shopCostLbl1.Text = orderCost.ToString();
                        var shopIds = order.Select(n => n.ShopId);
                        foreach (var item in shopIds)
                        {
                            var shop = db.ShopRepository.GetShopById((int)item);
                            shop1NameLbl.Text += "," + shop.Name;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void shop2Btn_Click(object sender, EventArgs e)
        {
            shopViewFrm shopForm = new shopViewFrm();
            shopForm.consoleId = 2;
            try
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var id = db.Customer.Get().Where(n => n.ConsoleId == shopForm.consoleId).Select(n => n.Id).Last();
                    shopForm.customerId = id;
                    shopForm.ShowDialog();
                    if (shopForm.DialogResult == DialogResult.OK)
                    {
                        var order = db.OrderRepository.Get()
                            .Where(n => n.CustomerId == id);
                        var orderCost = order.Select(n => n.amount).Sum();
                        shopCostLbl2.Text = orderCost.ToString();
                        var shopIds = order.Select(n => n.ShopId);
                        foreach (var item in shopIds)
                        {
                            var shop = db.ShopRepository.GetShopById((int)item);
                            shop2NameLbl.Text += "," + shop.Name;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void shop3Btn_Click(object sender, EventArgs e)
        {
            shopViewFrm shopForm = new shopViewFrm();
            shopForm.consoleId = 3;
            try
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var id = db.Customer.Get().Where(n => n.ConsoleId == shopForm.consoleId).Select(n => n.Id).Last();
                    shopForm.customerId = id;
                    shopForm.ShowDialog();
                    if (shopForm.DialogResult == DialogResult.OK)
                    {
                        var order = db.OrderRepository.Get()
                            .Where(n => n.CustomerId == id);
                        var orderCost = order.Select(n => n.amount).Sum();
                        shopCostLbl3.Text = orderCost.ToString();
                        var shopIds = order.Select(n => n.ShopId);
                        foreach (var item in shopIds)
                        {
                            var shop = db.ShopRepository.GetShopById((int)item);
                            shop3NameLbl.Text += "," + shop.Name;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void shop4Btn_Click(object sender, EventArgs e)
        {
            shopViewFrm shopForm = new shopViewFrm();
            shopForm.consoleId = 4;
            try
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var id = db.Customer.Get().Where(n => n.ConsoleId == shopForm.consoleId).Select(n => n.Id).Last();
                    shopForm.customerId = id;
                    shopForm.ShowDialog();
                    if (shopForm.DialogResult == DialogResult.OK)
                    {
                        var order = db.OrderRepository.Get()
                            .Where(n => n.CustomerId == id);
                        var orderCost = order.Select(n => n.amount).Sum();
                        shopCostLbl4.Text = orderCost.ToString();
                        var shopIds = order.Select(n => n.ShopId);
                        foreach (var item in shopIds)
                        {
                            var shop = db.ShopRepository.GetShopById((int)item);
                            shop4NameLbl.Text += "," + shop.Name;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void shop5Btn_Click(object sender, EventArgs e)
        {
            shopViewFrm shopForm = new shopViewFrm();
            shopForm.consoleId = 5;
            try
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var id = db.Customer.Get().Where(n => n.ConsoleId == shopForm.consoleId).Select(n => n.Id).Last();
                    shopForm.customerId = id;
                    shopForm.ShowDialog();
                    if (shopForm.DialogResult == DialogResult.OK)
                    {
                        var order = db.OrderRepository.Get()
                            .Where(n => n.CustomerId == id);
                        var orderCost = order.Select(n => n.amount).Sum();
                        shopCostLbl5.Text = orderCost.ToString();
                        var shopIds = order.Select(n => n.ShopId);
                        foreach (var item in shopIds)
                        {
                            var shop = db.ShopRepository.GetShopById((int)item);
                            shop5NameLbl.Text += "," + shop.Name;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void shop6Btn_Click(object sender, EventArgs e)
        {
            shopViewFrm shopForm = new shopViewFrm();
            shopForm.consoleId = 6;
            try
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var id = db.Customer.Get().Where(n => n.ConsoleId == shopForm.consoleId).Select(n => n.Id).Last();
                    shopForm.customerId = id;
                    shopForm.ShowDialog();
                    if (shopForm.DialogResult == DialogResult.OK)
                    {
                        var order = db.OrderRepository.Get()
                            .Where(n => n.CustomerId == id);
                        var orderCost = order.Select(n => n.amount).Sum();
                        shopCostLbl6.Text = orderCost.ToString();
                        var shopIds = order.Select(n => n.ShopId);
                        foreach (var item in shopIds)
                        {
                            var shop = db.ShopRepository.GetShopById((int)item);
                            shop6NameLbl.Text += "," + shop.Name;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void shop7Btn_Click(object sender, EventArgs e)
        {
            shopViewFrm shopForm = new shopViewFrm();
            shopForm.consoleId = 7;
            try
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var id = db.Customer.Get().Where(n => n.ConsoleId == shopForm.consoleId).Select(n => n.Id).Last();
                    shopForm.customerId = id;
                    shopForm.ShowDialog();
                    if (shopForm.DialogResult == DialogResult.OK)
                    {
                        var order = db.OrderRepository.Get()
                            .Where(n => n.CustomerId == id);
                        var orderCost = order.Select(n => n.amount).Sum();
                        shopCostLbl7.Text = orderCost.ToString();
                        var shopIds = order.Select(n => n.ShopId);
                        foreach (var item in shopIds)
                        {
                            var shop = db.ShopRepository.GetShopById((int)item);
                            shop7NameLbl.Text += "," + shop.Name;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void shop8Btn_Click(object sender, EventArgs e)
        {
            shopViewFrm shopForm = new shopViewFrm();
            shopForm.consoleId = 8;
            try
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var id = db.Customer.Get().Where(n => n.ConsoleId == shopForm.consoleId).Select(n => n.Id).Last();
                    shopForm.customerId = id;
                    shopForm.ShowDialog();
                    if (shopForm.DialogResult == DialogResult.OK)
                    {
                        var order = db.OrderRepository.Get()
                            .Where(n => n.CustomerId == id);
                        var orderCost = order.Select(n => n.amount).Sum();
                        shopCostLbl8.Text = orderCost.ToString();
                        var shopIds = order.Select(n => n.ShopId);
                        foreach (var item in shopIds)
                        {
                            var shop = db.ShopRepository.GetShopById((int)item);
                            shop8NameLbl.Text += "," + shop.Name;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void shop9Btn_Click(object sender, EventArgs e)
        {
            shopViewFrm shopForm = new shopViewFrm();
            shopForm.consoleId = 9;
            try
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var id = db.Customer.Get().Where(n => n.ConsoleId == shopForm.consoleId).Select(n => n.Id).Last();
                    shopForm.customerId = id;
                    shopForm.ShowDialog();
                    if (shopForm.DialogResult == DialogResult.OK)
                    {
                        var order = db.OrderRepository.Get()
                            .Where(n => n.CustomerId == id);
                        var orderCost = order.Select(n => n.amount).Sum();
                        shopCostLbl9.Text = orderCost.ToString();
                        var shopIds = order.Select(n => n.ShopId);
                        foreach (var item in shopIds)
                        {
                            var shop = db.ShopRepository.GetShopById((int)item);
                            shop9NameLbl.Text += "," + shop.Name;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region deleteshop
        private void deletShop1Btn_Click(object sender, EventArgs e)
        {
            DeleteShopFrm deleteShopFrm = new DeleteShopFrm();
            try
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var id = db.Customer.Get()
                        .Where(n => n.ConsoleId == 1)
                        .Select(n => n.Id)
                        .Last();
                    var order = db.OrderRepository
                        .Get()
                        .Where(n => n.CustomerId == id);
                    deleteShopFrm.orders = order;
                }
                deleteShopFrm.ShowDialog();
                if (deleteShopFrm.DialogResult == DialogResult.OK)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {

                        var id = db.Customer.Get()
                            .Where(n => n.ConsoleId == 1)
                            .Select(n => n.Id)
                            .Last();
                        var order = db.OrderRepository
                            .Get()
                            .Where(n => n.CustomerId == id);
                        {
                            shop1NameLbl.Text = "";
                            foreach (var or in order)
                            {
                                shop1NameLbl.Text += or.ShopName + " ";
                            }
                        }
                        shopCostLbl1.Text = order.Select(n => n.amount).Sum().ToString();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void deletShop2Btn_Click(object sender, EventArgs e)
        {
            DeleteShopFrm deleteShopFrm = new DeleteShopFrm();
            try
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var id = db.Customer.Get()
                        .Where(n => n.ConsoleId == 2)
                        .Select(n => n.Id)
                        .Last();
                    var order = db.OrderRepository
                        .Get()
                        .Where(n => n.CustomerId == id);
                    deleteShopFrm.orders = order;
                }
                deleteShopFrm.ShowDialog();
                if (deleteShopFrm.DialogResult == DialogResult.OK)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {

                        var id = db.Customer.Get()
                            .Where(n => n.ConsoleId == 2)
                            .Select(n => n.Id)
                            .Last();
                        var order = db.OrderRepository
                            .Get()
                            .Where(n => n.CustomerId == id);
                        {
                            shop2NameLbl.Text = "";
                            foreach (var or in order)
                            {
                                shop2NameLbl.Text += or.ShopName + " ";
                            }
                        }
                        shopCostLbl2.Text = order.Select(n => n.amount).Sum().ToString();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void deletShop3Btn_Click(object sender, EventArgs e)
        {
            DeleteShopFrm deleteShopFrm = new DeleteShopFrm();
            try
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var id = db.Customer.Get()
                        .Where(n => n.ConsoleId == 3)
                        .Select(n => n.Id)
                        .Last();
                    var order = db.OrderRepository
                        .Get()
                        .Where(n => n.CustomerId == id);
                    deleteShopFrm.orders = order;
                }
                deleteShopFrm.ShowDialog();
                if (deleteShopFrm.DialogResult == DialogResult.OK)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {

                        var id = db.Customer.Get()
                            .Where(n => n.ConsoleId == 3)
                            .Select(n => n.Id)
                            .Last();
                        var order = db.OrderRepository
                            .Get()
                            .Where(n => n.CustomerId == id);
                        {
                            shop3NameLbl.Text = "";
                            foreach (var or in order)
                            {
                                shop3NameLbl.Text += or.ShopName + " ";
                            }
                        }
                        shopCostLbl3.Text = order.Select(n => n.amount).Sum().ToString();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void deletShop4Btn_Click(object sender, EventArgs e)
        {
            DeleteShopFrm deleteShopFrm = new DeleteShopFrm();
            try
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var id = db.Customer.Get()
                        .Where(n => n.ConsoleId == 4)
                        .Select(n => n.Id)
                        .Last();
                    var order = db.OrderRepository
                        .Get()
                        .Where(n => n.CustomerId == id);
                    deleteShopFrm.orders = order;
                }
                deleteShopFrm.ShowDialog();
                if (deleteShopFrm.DialogResult == DialogResult.OK)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {

                        var id = db.Customer.Get()
                            .Where(n => n.ConsoleId == 4)
                            .Select(n => n.Id)
                            .Last();
                        var order = db.OrderRepository
                            .Get()
                            .Where(n => n.CustomerId == id);
                        {
                            shop4NameLbl.Text = "";
                            foreach (var or in order)
                            {
                                shop4NameLbl.Text += or.ShopName + " ";
                            }
                        }
                        shopCostLbl4.Text = order.Select(n => n.amount).Sum().ToString();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void deletShop5Btn_Click(object sender, EventArgs e)
        {
            DeleteShopFrm deleteShopFrm = new DeleteShopFrm();
            try
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var id = db.Customer.Get()
                        .Where(n => n.ConsoleId == 5)
                        .Select(n => n.Id)
                        .Last();
                    var order = db.OrderRepository
                        .Get()
                        .Where(n => n.CustomerId == id);
                    deleteShopFrm.orders = order;
                }
                deleteShopFrm.ShowDialog();
                if (deleteShopFrm.DialogResult == DialogResult.OK)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {

                        var id = db.Customer.Get()
                            .Where(n => n.ConsoleId == 5)
                            .Select(n => n.Id)
                            .Last();
                        var order = db.OrderRepository
                            .Get()
                            .Where(n => n.CustomerId == id);
                        {
                            shop5NameLbl.Text = "";
                            foreach (var or in order)
                            {
                                shop5NameLbl.Text += or.ShopName + " ";
                            }
                        }
                        shopCostLbl5.Text = order.Select(n => n.amount).Sum().ToString();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void deletShop6Btn_Click(object sender, EventArgs e)
        {
            DeleteShopFrm deleteShopFrm = new DeleteShopFrm();
            try
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var id = db.Customer.Get()
                        .Where(n => n.ConsoleId == 6)
                        .Select(n => n.Id)
                        .Last();
                    var order = db.OrderRepository
                        .Get()
                        .Where(n => n.CustomerId == id);
                    deleteShopFrm.orders = order;
                }
                deleteShopFrm.ShowDialog();
                if (deleteShopFrm.DialogResult == DialogResult.OK)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {

                        var id = db.Customer.Get()
                            .Where(n => n.ConsoleId == 6)
                            .Select(n => n.Id)
                            .Last();
                        var order = db.OrderRepository
                            .Get()
                            .Where(n => n.CustomerId == id);
                        {
                            shop6NameLbl.Text = "";
                            foreach (var or in order)
                            {
                                shop6NameLbl.Text += or.ShopName + " ";
                            }
                        }
                        shopCostLbl6.Text = order.Select(n => n.amount).Sum().ToString();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void deletShop7Btn_Click(object sender, EventArgs e)
        {
            DeleteShopFrm deleteShopFrm = new DeleteShopFrm();
            try
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var id = db.Customer.Get()
                        .Where(n => n.ConsoleId == 7)
                        .Select(n => n.Id)
                        .Last();
                    var order = db.OrderRepository
                        .Get()
                        .Where(n => n.CustomerId == id);
                    deleteShopFrm.orders = order;
                }
                deleteShopFrm.ShowDialog();
                if (deleteShopFrm.DialogResult == DialogResult.OK)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {

                        var id = db.Customer.Get()
                            .Where(n => n.ConsoleId == 7)
                            .Select(n => n.Id)
                            .Last();
                        var order = db.OrderRepository
                            .Get()
                            .Where(n => n.CustomerId == id);
                        {
                            shop7NameLbl.Text = "";
                            foreach (var or in order)
                            {
                                shop7NameLbl.Text += or.ShopName + " ";
                            }
                        }
                        shopCostLbl7.Text = order.Select(n => n.amount).Sum().ToString();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void deletShop8Btn_Click(object sender, EventArgs e)
        {
            DeleteShopFrm deleteShopFrm = new DeleteShopFrm();
            try
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var id = db.Customer.Get()
                        .Where(n => n.ConsoleId == 8)
                        .Select(n => n.Id)
                        .Last();
                    var order = db.OrderRepository
                        .Get()
                        .Where(n => n.CustomerId == id);
                    deleteShopFrm.orders = order;
                }
                deleteShopFrm.ShowDialog();
                if (deleteShopFrm.DialogResult == DialogResult.OK)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {

                        var id = db.Customer.Get()
                            .Where(n => n.ConsoleId == 8)
                            .Select(n => n.Id)
                            .Last();
                        var order = db.OrderRepository
                            .Get()
                            .Where(n => n.CustomerId == id);
                        {
                            shop8NameLbl.Text = "";
                            foreach (var or in order)
                            {
                                shop8NameLbl.Text += or.ShopName + " ";
                            }
                        }
                        shopCostLbl8.Text = order.Select(n => n.amount).Sum().ToString();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void deletShop9Btn_Click(object sender, EventArgs e)
        {
            DeleteShopFrm deleteShopFrm = new DeleteShopFrm();
            try
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var id = db.Customer.Get()
                        .Where(n => n.ConsoleId == 9)
                        .Select(n => n.Id)
                        .Last();
                    var order = db.OrderRepository
                        .Get()
                        .Where(n => n.CustomerId == id);
                    deleteShopFrm.orders = order;
                }
                deleteShopFrm.ShowDialog();
                if (deleteShopFrm.DialogResult == DialogResult.OK)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {

                        var id = db.Customer.Get()
                            .Where(n => n.ConsoleId == 9)
                            .Select(n => n.Id)
                            .Last();
                        var order = db.OrderRepository
                            .Get()
                            .Where(n => n.CustomerId == id);
                        {
                            shop9NameLbl.Text = "";
                            foreach (var or in order)
                            {
                                shop9NameLbl.Text += or.ShopName + " ";
                            }
                        }
                        shopCostLbl9.Text = order.Select(n => n.amount).Sum().ToString();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region pay
        private void pay1Btn_Click(object sender, EventArgs e)
        {
            int consoleId = 1;
            int customerId;
            int orderId;
            bool failedInvoice = false;
            InvoiceFrm invoiceFrm = new InvoiceFrm();
            using (UnitOfWork db = new UnitOfWork())
            {
                customerId = db.Customer.Get().Where(n => n.ConsoleId == consoleId).Select(n => n.Id).Last();
                var orders = db.OrderRepository.Get().Where(n => n.CustomerId == customerId);
                var finalCostOfShop = orders.Select(n => n.amount).Sum();
                Order order = new Order()
                {
                    CustomerId = customerId,
                    FinalCost = finalCostOfShop
                };
                db.Order.Insert(order);
                db.Save();
                orderId = order.Id;
            }
            stopWatch1.Stop();
            string timeValue = time1Txt.Text;
            groupBoxConsole1.Visible = false;
            if (!failedInvoice)
            {
                invoiceFrm.customerId = customerId;
                invoiceFrm.timeValue = timeValue;
                invoiceFrm.chargeValue = charge1Cost.Text;
                invoiceFrm.consoleId = consoleId;
                invoiceFrm.orderId = orderId;
                invoiceFrm.controllerCount = int.Parse(cntrl1Count.Value.ToString());
                invoiceFrm.ShowDialog();
            }
        checkdialog:
            if (invoiceFrm.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("فاکتور با موفقیت ثبت شد");
                var item = frmChoose.indexselected.Find(i => i == consoleId);
                frmChoose.indexselected.Remove(item);
                time1Txt.Text = "";
                charge1Cost.Text = "";
                cntrl1Count.Value = 1;
                failedInvoice = false;
                groupBoxConsole1.Visible = false;
            }
            else
            {
                groupBoxConsole1.Visible = true;
                failedInvoice = true;
                invoiceFrm.ShowDialog();
                goto checkdialog;
            }

        }

        private void pay2Btn_Click(object sender, EventArgs e)
        {
            int consoleId = 2;
            int customerId;
            int orderId;
            bool failedInvoice = false;
            InvoiceFrm invoiceFrm = new InvoiceFrm();
            using (UnitOfWork db = new UnitOfWork())
            {
                customerId = db.Customer.Get().Where(n => n.ConsoleId == consoleId).Select(n => n.Id).Last();
                var orders = db.OrderRepository.Get().Where(n => n.CustomerId == customerId);
                var finalCostOfShop = orders.Select(n => n.amount).Sum();
                Order order = new Order()
                {
                    CustomerId = customerId,
                    FinalCost = finalCostOfShop
                };
                db.Order.Insert(order);
                db.Save();
                orderId = order.Id;
            }
            stopWatch2.Stop();
            string timeValue = time2Txt.Text;
            groupBoxConsole2.Visible = false;
            if (!failedInvoice)
            {
                invoiceFrm.customerId = customerId;
                invoiceFrm.timeValue = timeValue;
                invoiceFrm.chargeValue = charge2Cost.Text;
                invoiceFrm.consoleId = consoleId;
                invoiceFrm.orderId = orderId;
                invoiceFrm.controllerCount = int.Parse(cntrl2Count.Value.ToString());
                invoiceFrm.ShowDialog();
            }
        checkdialog:
            if (invoiceFrm.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("فاکتور با موفقیت ثبت شد");
                var item = frmChoose.indexselected.Find(i => i == consoleId);
                frmChoose.indexselected.Remove(item);
                time2Txt.Text = "";
                charge2Cost.Text = "";
                cntrl2Count.Value = 1;
                failedInvoice = false;
                groupBoxConsole2.Visible = false;
            }
            else
            {
                groupBoxConsole2.Visible = true;
                failedInvoice = true;
                invoiceFrm.ShowDialog();
                goto checkdialog;
            }


        }

        private void pay3Btn_Click(object sender, EventArgs e)
        {
            int consoleId = 3;
            int customerId;
            int orderId;
            bool failedInvoice = false;
            InvoiceFrm invoiceFrm = new InvoiceFrm();
            using (UnitOfWork db = new UnitOfWork())
            {
                customerId = db.Customer.Get().Where(n => n.ConsoleId == consoleId).Select(n => n.Id).Last();
                var orders = db.OrderRepository.Get().Where(n => n.CustomerId == customerId);
                var finalCostOfShop = orders.Select(n => n.amount).Sum();
                Order order = new Order()
                {
                    CustomerId = customerId,
                    FinalCost = finalCostOfShop
                };
                db.Order.Insert(order);
                db.Save();
                orderId = order.Id;
            }
            stopWatch3.Stop();
            string timeValue = time3Txt.Text;
            groupBoxConsole3.Visible = false;
            if (!failedInvoice)
            {
                invoiceFrm.customerId = customerId;
                invoiceFrm.timeValue = timeValue;
                invoiceFrm.chargeValue = charge3Cost.Text;
                invoiceFrm.consoleId = consoleId;
                invoiceFrm.orderId = orderId;
                invoiceFrm.controllerCount = int.Parse(cntrl3Count.Value.ToString());
                invoiceFrm.ShowDialog();
            }
        checkdialog:
            if (invoiceFrm.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("فاکتور با موفقیت ثبت شد");
                var item = frmChoose.indexselected.Find(i => i == consoleId);
                frmChoose.indexselected.Remove(item);
                time3Txt.Text = "";
                charge3Cost.Text = "";
                cntrl3Count.Value = 1;
                failedInvoice = false;
                groupBoxConsole3.Visible = false;
            }
            else
            {
                groupBoxConsole3.Visible = true;
                failedInvoice = true;
                invoiceFrm.ShowDialog();
                goto checkdialog;
            }


        }

        private void pay4Btn_Click(object sender, EventArgs e)
        {
            int consoleId = 4;
            int customerId;
            int orderId;
            bool failedInvoice = false;
            InvoiceFrm invoiceFrm = new InvoiceFrm();
            using (UnitOfWork db = new UnitOfWork())
            {
                customerId = db.Customer.Get().Where(n => n.ConsoleId == consoleId).Select(n => n.Id).Last();
                var orders = db.OrderRepository.Get().Where(n => n.CustomerId == customerId);
                var finalCostOfShop = orders.Select(n => n.amount).Sum();
                Order order = new Order()
                {
                    CustomerId = customerId,
                    FinalCost = finalCostOfShop
                };
                db.Order.Insert(order);
                db.Save();
                orderId = order.Id;
            }
            stopWatch4.Stop();
            string timeValue = time4Txt.Text;
            groupBoxConsole4.Visible = false;
            if (!failedInvoice)
            {
                invoiceFrm.customerId = customerId;
                invoiceFrm.timeValue = timeValue;
                invoiceFrm.chargeValue = charge4Cost.Text;
                invoiceFrm.consoleId = consoleId;
                invoiceFrm.orderId = orderId;
                invoiceFrm.controllerCount = int.Parse(cntrl4Count.Value.ToString());
                invoiceFrm.ShowDialog();
            }
        checkdialog:
            if (invoiceFrm.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("فاکتور با موفقیت ثبت شد");
                var item = frmChoose.indexselected.Find(i => i == consoleId);
                frmChoose.indexselected.Remove(item);
                time4Txt.Text = "";
                charge4Cost.Text = "";
                cntrl4Count.Value = 1;
                failedInvoice = false;
                groupBoxConsole4.Visible = false;
            }
            else
            {
                groupBoxConsole4.Visible = true;
                failedInvoice = true;
                invoiceFrm.ShowDialog();
                goto checkdialog;
            }

        }

        private void pay5Btn_Click(object sender, EventArgs e)
        {
            int consoleId = 5;
            int customerId;
            int orderId;
            bool failedInvoice = false;
            InvoiceFrm invoiceFrm = new InvoiceFrm();
            using (UnitOfWork db = new UnitOfWork())
            {
                customerId = db.Customer.Get().Where(n => n.ConsoleId == consoleId).Select(n => n.Id).Last();
                var orders = db.OrderRepository.Get().Where(n => n.CustomerId == customerId);
                var finalCostOfShop = orders.Select(n => n.amount).Sum();
                Order order = new Order()
                {
                    CustomerId = customerId,
                    FinalCost = finalCostOfShop
                };
                db.Order.Insert(order);
                db.Save();
                orderId = order.Id;
            }
            stopWatch5.Stop();
            string timeValue = time5Txt.Text;
            groupBoxConsole5.Visible = false;
            if (!failedInvoice)
            {
                invoiceFrm.customerId = customerId;
                invoiceFrm.timeValue = timeValue;
                invoiceFrm.chargeValue = charge5Cost.Text;
                invoiceFrm.consoleId = consoleId;
                invoiceFrm.orderId = orderId;
                invoiceFrm.controllerCount = int.Parse(cntrl5Count.Value.ToString());
                invoiceFrm.ShowDialog();
            }
        checkdialog:
            if (invoiceFrm.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("فاکتور با موفقیت ثبت شد");
                var item = frmChoose.indexselected.Find(i => i == consoleId);
                frmChoose.indexselected.Remove(item);
                time5Txt.Text = "";
                charge5Cost.Text = "";
                cntrl5Count.Value = 1;
                failedInvoice = false;
                groupBoxConsole5.Visible = false;
            }
            else
            {
                groupBoxConsole5.Visible = true;
                failedInvoice = true;
                invoiceFrm.ShowDialog();
                goto checkdialog;
            }


        }

        private void pay6Btn_Click(object sender, EventArgs e)
        {
            int consoleId = 6;
            int customerId;
            int orderId;
            bool failedInvoice = false;
            InvoiceFrm invoiceFrm = new InvoiceFrm();
            using (UnitOfWork db = new UnitOfWork())
            {
                customerId = db.Customer.Get().Where(n => n.ConsoleId == consoleId).Select(n => n.Id).Last();
                var orders = db.OrderRepository.Get().Where(n => n.CustomerId == customerId);
                var finalCostOfShop = orders.Select(n => n.amount).Sum();
                Order order = new Order()
                {
                    CustomerId = customerId,
                    FinalCost = finalCostOfShop
                };
                db.Order.Insert(order);
                db.Save();
                orderId = order.Id;
            }
            stopWatch6.Stop();
            string timeValue = time6Txt.Text;
            groupBoxConsole6.Visible = false;
            if (!failedInvoice)
            {
                invoiceFrm.customerId = customerId;
                invoiceFrm.timeValue = timeValue;
                invoiceFrm.chargeValue = charge6Cost.Text;
                invoiceFrm.consoleId = consoleId;
                invoiceFrm.orderId = orderId;
                invoiceFrm.controllerCount = int.Parse(cntrl6Count.Value.ToString());
                invoiceFrm.ShowDialog();
            }
        checkdialog:
            if (invoiceFrm.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("فاکتور با موفقیت ثبت شد");
                var item = frmChoose.indexselected.Find(i => i == consoleId);
                frmChoose.indexselected.Remove(item);
                time6Txt.Text = "";
                charge6Cost.Text = "";
                cntrl6Count.Value = 1;
                failedInvoice = false;
                groupBoxConsole6.Visible = false;
            }
            else
            {
                groupBoxConsole6.Visible = true;
                failedInvoice = true;
                invoiceFrm.ShowDialog();
                goto checkdialog;
            }


        }

        private void pay7Btn_Click(object sender, EventArgs e)
        {
            int consoleId = 7;
            int customerId;
            int orderId;
            bool failedInvoice = false;
            InvoiceFrm invoiceFrm = new InvoiceFrm();
            using (UnitOfWork db = new UnitOfWork())
            {
                customerId = db.Customer.Get().Where(n => n.ConsoleId == consoleId).Select(n => n.Id).Last();
                var orders = db.OrderRepository.Get().Where(n => n.CustomerId == customerId);
                var finalCostOfShop = orders.Select(n => n.amount).Sum();
                Order order = new Order()
                {
                    CustomerId = customerId,
                    FinalCost = finalCostOfShop
                };
                db.Order.Insert(order);
                db.Save();
                orderId = order.Id;
            }
            stopWatch7.Stop();
            string timeValue = time7Txt.Text;
            groupBoxConsole7.Visible = false;
            if (!failedInvoice)
            {
                invoiceFrm.customerId = customerId;
                invoiceFrm.timeValue = timeValue;
                invoiceFrm.chargeValue = charge7Cost.Text;
                invoiceFrm.consoleId = consoleId;
                invoiceFrm.orderId = orderId;
                invoiceFrm.controllerCount = int.Parse(cntrl7Count.Value.ToString());
                invoiceFrm.ShowDialog();
            }
        checkdialog:
            if (invoiceFrm.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("فاکتور با موفقیت ثبت شد");
                var item = frmChoose.indexselected.Find(i => i == consoleId);
                frmChoose.indexselected.Remove(item);
                time7Txt.Text = "";
                charge7Cost.Text = "";
                cntrl7Count.Value = 1;
                failedInvoice = false;
                groupBoxConsole7.Visible = false;
            }
            else
            {
                groupBoxConsole7.Visible = true;
                failedInvoice = true;
                invoiceFrm.ShowDialog();
                goto checkdialog;
            }
        }

        private void pay8Btn_Click(object sender, EventArgs e)
        {
            int consoleId = 8;
            int customerId;
            int orderId;
            bool failedInvoice = false;
            InvoiceFrm invoiceFrm = new InvoiceFrm();
            using (UnitOfWork db = new UnitOfWork())
            {
                customerId = db.Customer.Get().Where(n => n.ConsoleId == consoleId).Select(n => n.Id).Last();
                var orders = db.OrderRepository.Get().Where(n => n.CustomerId == customerId);
                var finalCostOfShop = orders.Select(n => n.amount).Sum();
                Order order = new Order()
                {
                    CustomerId = customerId,
                    FinalCost = finalCostOfShop
                };
                db.Order.Insert(order);
                db.Save();
                orderId = order.Id;
            }
            stopWatch8.Stop();
            string timeValue = time8Txt.Text;
            groupBoxConsole8.Visible = false;
            if (!failedInvoice)
            {
                invoiceFrm.customerId = customerId;
                invoiceFrm.timeValue = timeValue;
                invoiceFrm.chargeValue = charge8Cost.Text;
                invoiceFrm.consoleId = consoleId;
                invoiceFrm.orderId = orderId;
                invoiceFrm.controllerCount = int.Parse(cntrl8Count.Value.ToString());
                invoiceFrm.ShowDialog();
            }
        checkdialog:
            if (invoiceFrm.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("فاکتور با موفقیت ثبت شد");
                var item = frmChoose.indexselected.Find(i => i == consoleId);
                frmChoose.indexselected.Remove(item);
                time8Txt.Text = "";
                charge8Cost.Text = "";
                cntrl1Count.Value = 1;
                failedInvoice = false;
                groupBoxConsole8.Visible = false;
            }
            else
            {
                groupBoxConsole8.Visible = true;
                failedInvoice = true;
                invoiceFrm.ShowDialog();
                goto checkdialog;
            }
        }

        private void pay9Btn_Click(object sender, EventArgs e)
        {
            int consoleId = 9;
            int customerId;
            int orderId;
            bool failedInvoice = false;
            InvoiceFrm invoiceFrm = new InvoiceFrm();
            using (UnitOfWork db = new UnitOfWork())
            {
                customerId = db.Customer.Get().Where(n => n.ConsoleId == consoleId).Select(n => n.Id).Last();
                var orders = db.OrderRepository.Get().Where(n => n.CustomerId == customerId);
                var finalCostOfShop = orders.Select(n => n.amount).Sum();
                Order order = new Order()
                {
                    CustomerId = customerId,
                    FinalCost = finalCostOfShop
                };
                db.Order.Insert(order);
                db.Save();
                orderId = order.Id;
            }
            stopWatch9.Stop();
            string timeValue = time9Txt.Text;
            groupBoxConsole9.Visible = false;
            if (!failedInvoice)
            {
                invoiceFrm.customerId = customerId;
                invoiceFrm.timeValue = timeValue;
                invoiceFrm.chargeValue = charge9Cost.Text;
                invoiceFrm.consoleId = consoleId;
                invoiceFrm.orderId = orderId;
                invoiceFrm.controllerCount = int.Parse(cntrl9Count.Value.ToString());
                invoiceFrm.ShowDialog();
            }
        checkdialog:
            if (invoiceFrm.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("فاکتور با موفقیت ثبت شد");
                var item = frmChoose.indexselected.Find(i => i == consoleId);
                frmChoose.indexselected.Remove(item);
                time9Txt.Text = "";
                charge9Cost.Text = "";
                cntrl9Count.Value = 1;
                failedInvoice = false;
                groupBoxConsole9.Visible = false;
            }
            else
            {
                groupBoxConsole9.Visible = true;
                failedInvoice = true;
                invoiceFrm.ShowDialog();
                goto checkdialog;
            }
        }

        #endregion
    
    }
}
