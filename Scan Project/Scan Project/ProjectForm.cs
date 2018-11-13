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
    public partial class ProjectForm : Telerik.WinControls.UI.RadForm
    {
        public ProjectForm()
        {
            InitializeComponent();
        }

        private void ProjectForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                //گرفتن جدول کل پروژه ها
                dbConnections db = new dbConnections();
                dt = db.GetProjects();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            projectList.Items.Clear();
            //حلقه برای پر کردن دراپ داون لیست پروژه ها
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Telerik.WinControls.UI.RadListDataItem radListDataItem = new Telerik.WinControls.UI.RadListDataItem();
                radListDataItem.Value = dt.Rows[i][0];
                radListDataItem.Text = dt.Rows[i][1].ToString();
                projectList.Items.Add(radListDataItem);
            }
            if (projectList.Items.Count > 0)
                projectList.SelectedValue = Properties.Settings.Default.projectID;
            else
                btnOK.Enabled = false;

            if (Properties.Settings.Default.userRole == 3)
            {
                txtNewProject.Enabled = btnCreate.Enabled = false;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (projectList.SelectedItem == null)
            {
                DialogResult = DialogResult.None;
                RadMessageBox.ThemeName = "TelerikMetro";
                RadMessageBox.Show(null, "لطفا یک پروژه انتخاب کنید.", "اخطار", MessageBoxButtons.OK,
                    RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1, RightToLeft.Yes);
                return;
            }

            //متغیر آی دی پروژه را با توجه به پروژه جدید عوض میکند
            //از این 
            //projectID
            //در ادامه برنامه برای فهمیدن پروژه فعلی استفاده می‌شود.
            Properties.Settings.Default.projectID = Convert.ToInt32(projectList.SelectedItem.Value.ToString());
            Properties.Settings.Default.projectName = projectList.SelectedItem.Text;            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {            
            if (string.IsNullOrWhiteSpace(txtNewProject.Text))
            {
                RadMessageBox.ThemeName = "TelerikMetro";
                RadMessageBox.Show(null, "لطفا نام پروژه را بنویسید.", "خطا", MessageBoxButtons.OK,
                    RadMessageIcon.None, MessageBoxDefaultButton.Button1, RightToLeft.Yes);
                return;
            }
            try
            {
                //ثبت یک پروژه جدید در دیتابیس
                dbConnections db = new dbConnections();
                db.InsertProjects(txtNewProject.Text.Trim());

                RadMessageBox.ThemeName = "TelerikMetro";
                RadMessageBox.Show(null, "پروژه جدید با موفقیت اضافه شد.", "ثبت موفق", MessageBoxButtons.OK,
                    RadMessageIcon.None, MessageBoxDefaultButton.Button1, RightToLeft.Yes);
                btnOK.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            

            txtNewProject.Text = string.Empty;
            ProjectForm_Load(null, null);
        }
    }
}
