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
    public partial class addShopFrm : Form
    {
        readonly UnitOfWork db = new UnitOfWork();
        public addShopFrm()
        {
            InitializeComponent();
        }

        private void addShopBtn_Click(object sender, EventArgs e)
        {


            using (db)
            {
                Shop shop = new Shop()
                {
                    Quantity = quantityCounter.Value,
                    Name = nameShop.Text,
                    SellCost = Convert.ToDecimal(sellCostTxt.Text),
                    BuyCost = Convert.ToDecimal(buyCostTxt.Text),
                };
                db.ShopRepository.InsertFood(shop);
                db.Save();
            }
            DialogResult = DialogResult.OK;
        
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addShopFrm_Load(object sender, EventArgs e)
        {

        }
    }
}

