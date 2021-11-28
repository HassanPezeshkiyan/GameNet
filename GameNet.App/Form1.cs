using GameNet.App.Login;
using GameNet.App.Settings;
using GameNet.App.Shoping;
using GameNet.App.StartConsole;
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

namespace GameNet.App
{
    public partial class mainFrm : Form
    {
        //readonly public UnitOfWork db = new UnitOfWork();

        /// <summary>
        /// چک کردن خرید ثبت شده 1 
        /// </summary>
        public bool Shoping1;

        /// <summary>
        /// چک کردن خرید ثبت شده 2 
        /// </summary>
        public bool Shoping2;

        /// <summary>
        /// چک کردن خرید ثبت شده 3 
        /// </summary>
        public bool Shoping3;

        /// <summary>
        /// چک کردن خرید ثبت شده 4 
        /// </summary>
        public bool Shoping4;

        /// <summary>
        /// چک کردن خرید ثبت شده 5 
        /// </summary>
        public bool Shoping5;

        /// <summary>
        /// چک کردن خرید ثبت شده 6 
        /// </summary>
        public bool Shoping6;
        int userId = 0;
        int roleId;
        public mainFrm()
        {
            InitializeComponent();
            panelReports.Visible = false;
        }

        private void mainFrm_Load(object sender, EventArgs e)
        {


            this.Hide();
            LoginFrm frmLogin = new LoginFrm();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                roleId = frmLogin.roleId;
                this.Show();
                if (roleId == 2)
                {
                    reportsBtn.Enabled = false;
                    settingBtn.Enabled = false;
                }
            }
            else
            {
                Application.Exit();
            }

            labelUserName.Text = frmLogin.userName;
            userId = frmLogin.userId;
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm, Panel panel, DockStyle dockStyle)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = dockStyle;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void shopSettingBtn_Click(object sender, EventArgs e)
        {
            ShopFrm shopFrm = new ShopFrm();
            shopFrm.roleId = roleId;
            openChildForm(shopFrm, panelContainer, DockStyle.Fill);

        }
        private void settingBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new settingFrm(), panelContainer, DockStyle.Fill);

        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            EditInfoFrm editform = new EditInfoFrm();
            editform.userId = userId;
            editform.ShowDialog();

        }


        private void btnStartConsole_Click(object sender, EventArgs e)
        {
            FrmStart frmStart = new FrmStart();
            frmStart.Show();
        }

        private void reportsBtn_Click(object sender, EventArgs e)
        {
            panelReports.Visible = !panelReports.Visible;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            List<invoice_View_creationDate> reports = new List<invoice_View_creationDate>();
            using (UnitOfWork db = new UnitOfWork())
            {
                //if ( || )
                //{
                //    reports = db.InvoiceReports
                //    .GetAll()
                //    .Where(n => n.NCreationDate
                //    .Contains(maskedTextBoxStartDate.Text) ||
                //    n.NCreationDate
                //    .Contains(maskedTextBoxEndDate.Text))
                //    .ToList();

                //}
                //else
                //{
                //    reports = db.InvoiceReports
                //    .GetAll()
                //    .ToList();
                //}
                if (maskedTextBoxStartDate.Text != "    /  /")
                {
                    reports = db.InvoiceReports.GetAllByFilter(maskedTextBoxStartDate.Text, maskedTextBoxEndDate.Text);
                }
                if (maskedTextBoxEndDate.Text != "    /  /")
                {
                    reports = db.InvoiceReports.GetAllByFilter(maskedTextBoxStartDate.Text, maskedTextBoxEndDate.Text);
                }
                else
                {
                    reports = db.InvoiceReports.GetAll().ToList();
                }
                dataGridViewReports.AutoGenerateColumns = false;
                dataGridViewReports.DataSource = reports;
            }
        }
    }
}


