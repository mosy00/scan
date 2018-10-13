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
    public partial class ItemsForm : Telerik.WinControls.UI.RadForm
    {
        public ItemsForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            dbConnections db = new dbConnections();
            try
            {
                db.InsertItems(txtItem1.Text, txtItem2.Text, txtItem3.Text);

                RadMessageBox.ThemeName = "TelerikMetro";
                RadMessageBox.Show(null, "شاخص‌های جدید با موفقیت اضافه شدند.", "ثبت موفق", MessageBoxButtons.OK,
                    RadMessageIcon.None, MessageBoxDefaultButton.Button1, RightToLeft.Yes);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void ItemsForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                //گرفتن جدول کل پروژه ها
                dbConnections db = new dbConnections();
                dt = db.GetItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (dt.Rows.Count > 0)
            {
                txtItem1.Text = dt.Rows[0][2].ToString();
                txtItem2.Text = dt.Rows[1][2].ToString();
                txtItem3.Text = dt.Rows[2][2].ToString();

                txtItem1.Enabled = false;
                txtItem2.Enabled = false;
                txtItem3.Enabled = false;

                btnOK.Enabled = false;
            }            
        }
    }
}
