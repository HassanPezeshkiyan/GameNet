﻿using System;
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
    public partial class FrmStart : Form
    {
        public FrmStart() {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
