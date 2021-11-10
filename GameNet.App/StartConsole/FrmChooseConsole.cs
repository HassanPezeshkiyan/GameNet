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

namespace GameNet.App.StartConsole
{
    public partial class FrmChooseConsole : Form
    {
        public FrmChooseConsole() {
            InitializeComponent();
        }
        public int selectedConsole = 0;
        UnitOfWork db = new UnitOfWork();
        private void buttonSelect_Click(object sender, EventArgs e) {
            selectedConsole = int.Parse(numericUpDownConsole.Value.ToString());
            using (db) {
                Customer customer = new Customer()
                {
                    ConsoleId = selectedConsole
                };
                try {
                    db.Customer.Insert(customer);
                    db.Save();
                    DialogResult = DialogResult.OK;
                }
                catch {


                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
