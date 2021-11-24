
using GameNet.App.infra;
using GameNet.DataLayer;
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

namespace GameNet.App.Invoicing
{
    public partial class InvoiceFrm : Form
    {
        public InvoiceFrm()
        {
            InitializeComponent();

        }
        public int customerId;
        public string chargeValue;
        public string timeValue;
        public int controllerCount;
        public int consoleId;
        public int orderId;
        public Order customerOrder;

        private void InvoiceFrm_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                customerOrder = db.Order.GetById(orderId);
            }
            chargeCost.Text = chargeValue;
            timeTxt.Text = timeValue;
            cntrlCount.Value = controllerCount;
            shopCostLbl.Text = customerOrder.FinalCost.ToString();
        }

        string PersianDate(DateTime datetime)
        {
            return datetime.ToPersianDateString();
        }

        private void PayBtn_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var console = db.Console.GetById(consoleId);
                var shopCost = customerOrder.FinalCost;
                Invoice invoice = new Invoice()
                {
                    ChargeValue = decimal.Parse(chargeValue),
                    ConsoleId = consoleId,
                    CustomerId = customerId,
                    OrderId = orderId,
                    Time = timeValue,
                    CreationDate = DateTime.Now,
                    ControllerQuantity = controllerCount
                };
                invoice.NCreationDate = PersianDate(invoice.CreationDate);
                var splitedTime = timeValue.Split(':');
                var hour = int.Parse(splitedTime[1]);
                var min = int.Parse(splitedTime[2]);
                decimal timeCost = 0;
                if (min >= 50)
                {
                    hour += 1;
                }
                if (hour > 0 && min > 0)
                {
                    timeCost = (hour * console.TimePriceController) + (console.TimePriceController / 60);
                }
                if (min > 0 && hour == 0)
                {
                    timeCost = (min * (console.TimePriceController / 60));
                }
                if (hour > 0 && min == 0)
                {
                    timeCost = (hour * console.TimePriceController);
                }
                invoice.Amount = shopCost + Math.Round(timeCost);
                try
                {
                    db.Invoice.Insert(invoice);
                    db.Save();
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
