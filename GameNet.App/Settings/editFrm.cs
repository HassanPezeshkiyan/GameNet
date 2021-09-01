﻿using GameNet.DataLayer;
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

namespace GameNet.App.Settings
{
    public partial class editConsoleFrm : Form
    {
        public int consoleId;
        public readonly UnitOfWork db = new UnitOfWork();
        public editConsoleFrm() {
            InitializeComponent();
        }

        private void editFrm_Load(object sender, EventArgs e) {
            using (db) {

                var console = db.Console.GetAll().Where(n => n.Id == consoleId).FirstOrDefault();
                consoleGroupBox.Text = "دستگاه شماره :" + consoleId.ToString();
                quantityPriceTxt.Text = console.QuantityPriceController.ToString();
                timePriceTxt.Text = console.TimePriceController.ToString();
                typeCombo.Text = console.ConsoleType.ToString();                                
            }

        }

        private void closeBtn_Click(object sender, EventArgs e) {
            Close();
        }

        private void saveBtn_Click(object sender, EventArgs e) {
            
        }
    }
}
