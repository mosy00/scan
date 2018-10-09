using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Scan_Project
{
    public partial class UserForm : Telerik.WinControls.UI.RadForm
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                RadMessageBox.ThemeName = "TelerikMetro";
                RadMessageBox.Show(null, "لطفا نام کاربری و رمز عبور را وارد کنید.", "خطا!", MessageBoxButtons.OK,
                    RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1, RightToLeft.Yes);
                return;
            }
            dbConnections db = new dbConnections();
            try
            {
                db.InsertNewUser(txtUserName.Text, txtPassword.Text, rbIsAdmin.IsChecked);

                RadMessageBox.ThemeName = "TelerikMetro";
                RadMessageBox.Show(null, "کاربر جدید با موفقیت ثبت شد.", "ثبت موفق", MessageBoxButtons.OK,
                    RadMessageIcon.None, MessageBoxDefaultButton.Button1, RightToLeft.Yes);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
