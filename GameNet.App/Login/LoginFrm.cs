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

        UnitOfWork db = new UnitOfWork();
        public LoginFrm() {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            using (db) {
                try {
                    var user = db.Users.GetUserByUserName(textBoxUserName.Text.ToString());
                    userName = user.FullName;
                    if (textBoxPassword.Text == user.PassWord.TrimEnd()) {
                        DialogResult = DialogResult.OK;
                    }
                }

                catch {

                    MessageBox.Show("نام کاربری یا رمز عبور اشتباه است", "اخطار", MessageBoxButtons.RetryCancel);
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
