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
    public partial class ChangePass : Telerik.WinControls.UI.RadForm
    {
        public ChangePass()
        {
            InitializeComponent();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (!(newPassword.Text.Equals(reNewPassword.Text)))
            {
                RadMessageBox.ThemeName = "TelerikMetro";
                RadMessageBox.Show(null, "رمز عبور جدید با تکرار رمز عبور مطابقت ندارد!", "خطا!", MessageBoxButtons.OK,
                    RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1, RightToLeft.Yes);
                return;
            }

            dbConnections db = new dbConnections();
            bool r = db.ChangePassword(oldPassword.Text, newPassword.Text);
            if (!r)
            {
                RadMessageBox.ThemeName = "TelerikMetro";
                RadMessageBox.Show(null, "رمز عبور سابق اشتباه است!", "خطا!", MessageBoxButtons.OK,
                    RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1, RightToLeft.Yes);
                return;
            }
            else
            {
                RadMessageBox.ThemeName = "TelerikMetro";
                RadMessageBox.Show(null, "رمز عبور با موفقیت تغییر داده شد.", "ثبت موفق", MessageBoxButtons.OK,
                    RadMessageIcon.None, MessageBoxDefaultButton.Button1, RightToLeft.Yes);
                DialogResult = DialogResult.OK;
            }
        }
    }
}
