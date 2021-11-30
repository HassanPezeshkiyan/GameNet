using GameNet.App.infra;
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
                var query = db.InvoiceReports.GetAll();
                if (comboBoxShopOrConsole.SelectedIndex == 0)
                {
                    query = query.Where(n => n.ConsoleId == 0);
                }
                else
                {
                    query = query.Where(n => n.ConsoleId != 0);
                }
                reports = query.ToList();
                if (maskedTextBoxStartDate.Text != "    /  /")
                {
                    var startDate = Convert.ToDateTime(maskedTextBoxStartDate.Text);
                    startDate = MyDateExtension.ToMiladi(startDate);
                    query = query.Where(n => n.CreationDate >= startDate);
                    reports = query.Where(n => n.CreationDate >= startDate).ToList();
                }
                if (maskedTextBoxEndDate.Text != "    /  /")
                {
                    var EndDate = Convert.ToDateTime(maskedTextBoxEndDate.Text);
                    EndDate = MyDateExtension.ToMiladi(EndDate);
                    query = query.Where(n => n.CreationDate <= EndDate);
                    reports = query.Where(n => n.CreationDate <= EndDate).ToList();
                }
                if (maskedTextBoxStartTime.Text != "  :")
                {
                    var startTime = Convert.ToDateTime((maskedTextBoxStartDate.Text) + " " + (maskedTextBoxStartTime.Text));
                    startTime = MyDateExtension.ToMiladi(startTime);
                    query = query.Where(n => n.CreationDate >= startTime);
                    reports = query.Where(n => n.CreationDate >= startTime).ToList();
                }
                if (maskedTextBoxEndTime.Text != "  :")
                {
                    var endTime = Convert.ToDateTime((maskedTextBoxEndDate.Text) + " " + (maskedTextBoxEndTime.Text));
                    endTime = MyDateExtension.ToMiladi(endTime);
                    query = query.Where(n => n.CreationDate <= endTime);
                    reports = query.Where(n => n.CreationDate <= endTime).ToList();
                }

                dataGridViewReports.AutoGenerateColumns = false;
                dataGridViewReports.DataSource = reports;
                if (query.Count()>0)
                {
                    var amounts = query.Select(n => n.Amount);
                    textBoxSumAmount.Text = amounts.Sum().ToString();
                }
                else
                {
                    textBoxSumAmount.Text = "0";
                }
            }
        }
    }
}


