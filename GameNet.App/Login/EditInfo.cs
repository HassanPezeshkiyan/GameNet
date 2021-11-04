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
    public partial class EditInfoFrm : Form
    {
        public EditInfoFrm() {
            InitializeComponent();
        }


        public int userId = 0;
        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void EditInfo_Load(object sender, EventArgs e) {
            using (UnitOfWork db = new UnitOfWork()) {
                var user = db.User.GetById(userId);
                textBoxFullName.Text = user.FullName.Trim();
                textBoxUserName.Text = user.UserName.Trim();
            }
        }

        private void btnSaveInfo_Click(object sender, EventArgs e) {
            using (UnitOfWork db = new UnitOfWork()) {
                var user = db.User.GetById(userId);

                user.FullName = textBoxFullName.Text.Trim();
                user.UserName = textBoxUserName.Text.Trim();

                if (textBoxPassword.Text.Trim() == textBoxConfirmPassword.Text.Trim()) {
                    user.PassWord = textBoxPassword.Text.Trim();
                }
                else {
                    MessageBox.Show("تکرار رمز عبور اشتباه است", "اخطار", MessageBoxButtons.OK);
                }
                db.User.Update(user);
                db.Save();
            }
            this.Close();
            Application.Restart();
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e) {
            if (textBoxPassword.UseSystemPasswordChar) {
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxConfirmPassword.UseSystemPasswordChar = false;
            }
            else {
                textBoxPassword.UseSystemPasswordChar = true;
                textBoxConfirmPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
