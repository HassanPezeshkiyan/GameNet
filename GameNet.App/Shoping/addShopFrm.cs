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

            try
            {

            using (db)
            {
                Shop shop = new Shop()
                {
                    Quantity = (int)quantityCounter.Value,
                    Name = nameShop.Text,
                    SellCost = Convert.ToDecimal(sellCostTxt.Text),
                    BuyCost = Convert.ToDecimal(buyCostTxt.Text),
                };
                db.ShopRepository.InsertFood(shop);
                db.Save();
            }
            DialogResult = DialogResult.OK;
        
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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

