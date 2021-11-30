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

namespace GameNet.App.Shoping
{
    public partial class DeleteShopFrm : Form
    {
        public DeleteShopFrm()
        {
            InitializeComponent();
        }
        public IEnumerable<OrderItems> orders;

        void BindListBox()
        {
            foreach (var order in orders)
            {
                listBoxShopItems.Items.Add(order.ShopName);
            }
        }
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            var listedOrders = orders.ToList();
            var index = listBoxShopItems.SelectedIndex;
            var customerId = listedOrders[index].CustomerId;

            try
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var shop = db.Shop.Get().Where(n => n.Name == listedOrders[index].ShopName).First();
                    var customerOrders = db.OrderRepository.Get().Where(n => n.CustomerId == customerId);
                    var selectedOrder = customerOrders.Where(n => n.ShopName == listedOrders[index].ShopName).First();
                    db.OrderRepository.Delete(selectedOrder);
                    shop.Quantity += selectedOrder.quantity;
                    db.Save();
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteShopFrm_Load(object sender, EventArgs e)
        {
            BindListBox();
        }
    }
}
