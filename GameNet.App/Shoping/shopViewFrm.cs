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
        public int shopId;
        public shopViewFrm()
        {
            InitializeComponent();
        }
        public shopViewFrm(int shopBtnId)
        {
            InitializeComponent();
            shopId = shopBtnId;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvViewShop.AutoGenerateColumns = false;
                dgvViewShop.DataSource = db.ShopRepository.GetAllFood();
            }
        }
        private void shopViewFrm_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void saveShop_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var shop = db.ShopRepository.GetShopById(int.Parse(dgvViewShop.CurrentRow.Cells[0].Value.ToString()));
                Order order = new Order()
                {
                    quantity = (int)orderQuantity.Value,
                    cost = shop.SellCost,
                    userId = shopId
                };
                order.amount = order.cost * order.quantity;
                db.OrderRepository.Insert(order);
                db.Save();
            }
            DialogResult = DialogResult.OK;
        }
    }
}
