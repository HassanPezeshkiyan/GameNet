using GameNet.App.Shoping;
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

namespace GameNet.App
{
    public partial class ShopFrm : Form
    {
        public int roleId;
        public ShopFrm()
        {
            InitializeComponent();

        }

        private void addShopBtn_Click(object sender, EventArgs e)
        {
            addShopFrm shopform = new addShopFrm();
            shopform.ShowDialog();
        }
        void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvShop.AutoGenerateColumns = false;
                dgvShop.DataSource = db.ShopRepository.GetAllFood();
            }
        }
        private void ShopFrm_Load(object sender, EventArgs e)
        {
            BindGrid();
            if (roleId == 2)
            {
                addShopBtn.Enabled = false;
                deleteShopBtn.Enabled = false;
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void editShopBtn_Click(object sender, EventArgs e)
        {
            if (dgvShop.CurrentRow != null)
            {
                int shopingId = int.Parse(dgvShop.CurrentRow.Cells[0].Value.ToString());
                editShopFrm shopFrm = new editShopFrm();
                shopFrm.roleId = roleId;
                shopFrm.shopId = shopingId;
                if (shopFrm.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }
            }

        }

        private void deleteShopBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    if (dgvShop.CurrentRow != null)
                    {
                        int shopingId = int.Parse(dgvShop.CurrentRow.Cells[0].Value.ToString());
                        var local = db.ShopRepository.GetShopById(shopingId);

                        if (MessageBox.Show($"آیا از حذف {local.Name} مطمئن هستید ؟", "توجه", MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            db.ShopRepository.DeleteFood(shopingId);
                            db.Save();
                        }
                    }
                }
                BindGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}


