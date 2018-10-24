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
    public partial class EditDocsForm : Telerik.WinControls.UI.RadForm
    {
        string docID;
        public EditDocsForm(string documentID)
        {
            InitializeComponent();
            docID = documentID;
        }

        private void EditDocsForm_Load(object sender, EventArgs e)
        {
            dbConnections db = new dbConnections();
            DataTable dt, itemNames;

            dt = db.GetDocs(out itemNames, docID);

            lblItem1.Text = itemNames.Rows[0][2].ToString();
            lblItem2.Text = itemNames.Rows[1][2].ToString();
            lblItem3.Text = itemNames.Rows[2][2].ToString();

            txtItem1.Text = dt.Rows[0][1].ToString();
            txtItem2.Text = dt.Rows[0][2].ToString();
            txtItem3.Text = dt.Rows[0][3].ToString();
        }

        private void btnEditDoc_Click(object sender, EventArgs e)
        {
            try
            {
                dbConnections db = new dbConnections();
                db.UpdateDoc(txtItem1.Text, txtItem2.Text, txtItem3.Text, docID);

                RadMessageBox.ThemeName = "TelerikMetro";
                RadMessageBox.Show(null, "تغییرات با موفقیت ثبت شد.", "ثبت موفق", MessageBoxButtons.OK,
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
