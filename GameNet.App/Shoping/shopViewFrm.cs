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
        public int shopId;

        /// <summary>
        /// وضعیت ثبت / عدم ثبت خرید بوفه
        /// </summary>
        public int orderChecked = 0;

        public shopViewFrm() {
            InitializeComponent();
        }
        public shopViewFrm(int shopBtnId) {
            InitializeComponent();
            shopId = shopBtnId;
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
            using (UnitOfWork db = new UnitOfWork()) {
                var shop = db.ShopRepository.GetShopById(int.Parse(dgvViewShop.CurrentRow.Cells[0].Value.ToString()));
                if (orderQuantity.Value > 0) {
                    Order order = new Order()
                    {
                        ShopId = shop.Id,
                        quantity = (int)orderQuantity.Value,
                        cost = shop.SellCost,
                        userId = shopId
                    };
                    order.amount = order.cost * order.quantity;
                    if (order.quantity <= shop.Quantity) {
                        shop.Quantity = (int)shop.Quantity - order.quantity;
                        db.OrderRepository.Insert(order);
                        db.Save();
                        orderChecked = 1;
                    }
                    else {
                        MessageBox.Show($"!تعداد انتخابی بیش از موجودی است ", "توجه", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        MessageBox.Show($"تعداد موجودی: {shop.Quantity}", "!اطلاع", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                MessageBox.Show($"!موردی را انتخاب کنید", "توجه", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);

            }
            DialogResult = DialogResult.OK;
        }
    }
}
