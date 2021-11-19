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
        public IEnumerable<Order> customerOrder;

        private void InvoiceFrm_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                customerOrder = db.Order.Get().Where(n => n.CustomerId == customerId);
            }
            chargeCost.Text = chargeValue;
            timeTxt.Text = timeValue;
            cntrlCount.Value = controllerCount;
            shopCostLbl.Text = customerOrder.Select(n => n.FinalCost).First().ToString();
        }

        private void PayBtn_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                try
                {
                    Invoice invoice = new Invoice()
                    {

                        ConsoleId = consoleId,
                        ControllerQuantity = int.Parse(cntrlCount.Value.ToString()),
                        CreationDate = DateTime.Now,
                        CustomerId = customerId,
                        OrderId = customerOrder.Select(n => n.Id).Single(),
                        Time = timeTxt.Text
                    };
                    var shopAmount = customerOrder.Select(n => n.FinalCost).Single();
                    var controller = db.Console.Get().Where(n => n.Id == consoleId);
                    var controllerQuantityPrice = controller.Select(n => n.QuantityPriceController).Single();
                    var controllerPrice = controllerQuantityPrice * cntrlCount.Value;
                    var controllerTimePrice = controller.Select(n => n.TimePriceController).Single();
                    string[] time = timeTxt.ToString().Split(':');
                    int hour = int.Parse(time[1]);
                    int min = int.Parse(time[2]);
                    decimal timePrice;
                    if (min > 50)
                    {
                        hour += 1;
                    }
                    if (hour >= 1)
                    {
                        timePrice = hour * controllerTimePrice + (controllerTimePrice / min);
                    }
                    else
                    {
                        timePrice = (controllerTimePrice * min / 60);
                    }
                    invoice.Amount = controllerPrice + shopAmount + timePrice;
                    decimal chargeValue = decimal.Parse(chargeCost.Text);
                    if (chargeValue > invoice.Amount)
                    {
                        MessageBox.Show($"مبلغ بستانکاری: {chargeValue - invoice.Amount}", "بستانکار");
                    }
                    else
                    {
                        MessageBox.Show($"مبلغ بدهکاری: {invoice.Amount - chargeValue}", "بدهکار");
                    }
                    invoice.ChargeValue = chargeValue;
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
