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
    public partial class shopViewFrm : Form
    {

        /// <summary>
        /// شماره دستگاه ثبت کننده بوفه
        /// </summary>
        public int consoleId;
        public int customerId;
        /// <summary>
        /// وضعیت ثبت / عدم ثبت خرید بوفه
        /// </summary>
        public int orderChecked = 0;
        public shopViewFrm() {
            InitializeComponent();

        }

        private void exitBtn_Click(object sender, EventArgs e) {
            Close();
        }
        void BindGrid() {
            using (UnitOfWork db = new UnitOfWork()) {
                dgvViewShop.AutoGenerateColumns = false;
                dgvViewShop.DataSource = db.ShopRepository.GetAllFood();
            }
        }

        private void shopViewFrm_Load(object sender, EventArgs e) {
            BindGrid();

        }

        private void saveShop_Click(object sender, EventArgs e) {

            DialogResult = DialogResult.OK;
        }

        Dictionary<int, string> orderListBox = new Dictionary<int, string>();
        private void addShop_Click(object sender, EventArgs e) {
            if (orderQuantity.Value > 0) {
                using (UnitOfWork db = new UnitOfWork()) {
                    var shop = db.ShopRepository.GetShopById(int.Parse(dgvViewShop.CurrentRow.Cells[0].Value.ToString()));
                    if (shop.Quantity >= orderQuantity.Value) {
                        Order order = new Order()
                        {
                            ShopId = shop.Id,
                            quantity = (int)orderQuantity.Value,
                            cost = shop.SellCost,
                            ConsoleId = consoleId,
                            CustomerId = customerId
                        };
                        order.amount = order.cost * order.quantity;
                        shop.Quantity = (int)shop.Quantity - order.quantity;
                        db.OrderRepository.Insert(order);
                        db.Save();
                        orderChecked = 1;
                        orderListBox[order.Id] = shop.Name;
                        listBoxOrder.DataSource = new BindingSource(orderListBox, null);
                        listBoxOrder.DisplayMember = "value";
                        listBoxOrder.ValueMember = "key";
                    }
                    else {
                        MessageBox.Show($"!تعداد انتخابی بیش از موجودی است ", "توجه", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        MessageBox.Show($"تعداد موجودی: {shop.Quantity}", "!اطلاع", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else {
                MessageBox.Show($"!موردی را انتخاب کنید", "توجه", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
            }
        }

        private void deleteShopBtn_Click(object sender, EventArgs e) {
            using (UnitOfWork db = new UnitOfWork()) {
                var orderId = listBoxOrder.SelectedValue;
                if (MessageBox.Show("از حذف خوراکی مطمئن هستید؟", "اخطار", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    db.OrderRepository.Delete(orderId);
                    db.Save();
                    orderListBox.Remove((int)orderId);
                    listBoxOrder.Items.Remove(orderId);
                    listBoxOrder.DataSource = new BindingSource(orderListBox, null);
                }

            }
        }
    }

}




