﻿using GameNet.App.Invoicing;
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


        public FrmStart()
        {
            InitializeComponent();
            groupBoxConsole1.Visible = false;
            groupBoxConsole2.Visible = false;
            groupBoxConsole3.Visible = false;
            groupBoxConsole4.Visible = false;
            groupBoxConsole5.Visible = false;
            groupBoxConsole6.Visible = false;

        }

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
            FrmChooseConsole frmChoose = new FrmChooseConsole();
            frmChoose.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                frmChoose.Close();
            }
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

            }

        }


        /// <summary>
        /// timer controller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// end of timer controller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ///

        /////////////////////////////////////////

        /// <summary>
        /// clock start
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// end of clock start
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        //////////////////////////////////////////


        /// <summary>
        /// clock stop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// end of clock stop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        /////////////////////////////////////////


        /// <summary>
        /// clock reset
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// end of clock reset
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        ////////////////////////////////////////


        /// <summary>
        /// pay button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pay1Btn_Click(object sender, EventArgs e)
        {
            int consoleId = 1;
            int customerId;
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

            }
            stopWatch1.Stop();
            string timeValue = time1Txt.Text;
            groupBoxConsole1.Visible = false;
            InvoiceFrm invoiceFrm = new InvoiceFrm();
            invoiceFrm.customerId = customerId;
            invoiceFrm.timeValue = timeValue;
            invoiceFrm.chargeValue = charge1Cost.Text;
            invoiceFrm.consoleId = consoleId;
            invoiceFrm.controllerCount = int.Parse(cntrl1Count.Value.ToString());
            invoiceFrm.ShowDialog();
            if (invoiceFrm.DialogResult == DialogResult.OK)
            {

            }
            else
            {
                groupBoxConsole1.Visible = true;
            }

        }

        /// <summary>
        /// shoping
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

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
            
        }

        private void shop3Btn_Click(object sender, EventArgs e)
        {

        }

        private void shop4Btn_Click(object sender, EventArgs e)
        {

        }

        private void shop5Btn_Click(object sender, EventArgs e)
        {

        }

        private void shop6Btn_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// end shoping
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

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
    }
}
