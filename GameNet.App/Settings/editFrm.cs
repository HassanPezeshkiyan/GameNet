using GameNet.DataLayer;
using GameNet.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameNet.App.Settings
{
    public partial class editConsoleFrm : Form
    {
        public int consoleId;

        public editConsoleFrm()
        {
            InitializeComponent();
        }

        private void editFrm_Load(object sender, EventArgs e)
        {
            try
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var console = db.Console.GetById(consoleId);
                    consoleGroupBox.Text = "دستگاه شماره :" + consoleId.ToString();
                    quantityPriceTxt.Text = console.QuantityPriceController.ToString();
                    timePriceTxt.Text = console.TimePriceController.ToString();
                    typeCombo.Text = console.ConsoleType.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }




        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            try
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    DataLayer.Console console = new DataLayer.Console()
                    {
                        ConsoleType = typeCombo.Text,
                        QuantityPriceController = Convert.ToDecimal(quantityPriceTxt.Text),
                        TimePriceController = Convert.ToDecimal(timePriceTxt.Text),
                    };
                    console.Id = consoleId;
                    db.Console.Update(console);
                    db.Save();
                }

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
