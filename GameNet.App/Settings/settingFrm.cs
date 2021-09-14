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
    public partial class settingFrm : Form
    {

        public settingFrm() {
            InitializeComponent();
        }

        private void settingFrm_Load(object sender, EventArgs e) {
            BindGrid();
            editConsoleBtn.Enabled = false;
        }
        void BindGrid() {
            using (UnitOfWork db = new UnitOfWork()) {
                dgvConsole.AutoGenerateColumns = false;
                dgvConsole.DataSource = db.Console.GetAll();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e) {
            BindGrid();
        }

        private void editConsoleBtn_Click(object sender, EventArgs e) {
            if (dgvConsole.CurrentRow != null) {
                int consoleId = int.Parse(dgvConsole.CurrentRow.Cells[0].Value.ToString());
                editConsoleFrm edit = new editConsoleFrm();
                edit.consoleId = consoleId;
                if (edit.ShowDialog() == DialogResult.OK) {
                    BindGrid();
                }
            }
        }
    }
}
