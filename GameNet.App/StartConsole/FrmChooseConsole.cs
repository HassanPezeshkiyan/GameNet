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
        public FrmChooseConsole()
        {
            InitializeComponent();
        }
        public int selectedConsole;
        public List<int> indexselected = new List<int>() { 0};

        
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            selectedConsole = int.Parse(numericUpDownConsole.Value.ToString());
            bool test = indexselected.Contains(selectedConsole);
            if (!test)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    Customer customer = new Customer()
                    {
                        ConsoleId = selectedConsole
                    };
                    try
                    {
                        db.Customer.Insert(customer);
                        db.Save();
                        DialogResult = DialogResult.OK;
                    }
                    catch (Exception ex)
                    {


                    }
                }
            }
            else
            {
                MessageBox.Show("");
            }
        }



        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmChooseConsole_Load(object sender, EventArgs e)
        {

        }
    }
}
