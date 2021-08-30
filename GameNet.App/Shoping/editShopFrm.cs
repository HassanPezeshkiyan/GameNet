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
    public partial class editShopFrm : Form
    {
        readonly UnitOfWork db = new UnitOfWork();
        public editShopFrm()
        {
            InitializeComponent();
        }
        public int shopId = 0;
        private void editShopFrm_Load(object sender, EventArgs e)
        {

            var shop = db.ShopRepository.GetShopById(shopId);
            nameShop.Text = shop.Name;
            buyCostTxt.Text = shop.BuyCost.ToString();
            sellCostTxt.Text = shop.SellCost.ToString();
            quantityCounter.Value = shop.Quantity.Value;



        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void editShopBtn_Click(object sender, EventArgs e)
        {

            using (db)
            {

                Shop shoping = new Shop()
                {
                    Name = nameShop.Text,
                    SellCost = Convert.ToDecimal(sellCostTxt.Text),
                    BuyCost = Convert.ToDecimal(buyCostTxt.Text),
                    Quantity = (int)quantityCounter.Value
                };
                shoping.Id = shopId;
                db.ShopRepository.UpdateFood(shoping);
                db.Save();
            }

            DialogResult = DialogResult.OK;
        }

    }
}

