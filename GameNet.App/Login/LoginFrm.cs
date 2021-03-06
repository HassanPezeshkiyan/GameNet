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

namespace GameNet.App.Login
{
    public partial class LoginFrm : Form
    {
        public string userName = null;
        public int userId = 0;
        public int roleId;
        UnitOfWork db = new UnitOfWork();
        public LoginFrm() {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            try
            {
                var user = db.Users.GetUserByUserName(textBoxUserName.Text.ToString());
                if (user != null && textBoxPassword.Text == user.PassWord.TrimEnd())
                {
                    DialogResult = DialogResult.OK;
                    userName = user.FullName;
                    userId = user.Id;
                    if (user.Role.TrimEnd() == "Admin")
                    {
                        roleId = 1;
                    }
                    else
                    {
                        roleId = 2;
                    }
                    db.Dispose();
                }
                else
                {
                    var result = MessageBox.Show("نام کاربری یا رمز عبور اشتباه است", "اخطار", MessageBoxButtons.RetryCancel);
                    if (result == DialogResult.Retry)
                        textBoxUserName.Text = "";
                    textBoxPassword.Text = "";
                    textBoxUserName.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
