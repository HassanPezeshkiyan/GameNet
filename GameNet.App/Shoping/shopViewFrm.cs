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
        public shopViewFrm()
        {
            InitializeComponent();
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
    }
}
