using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace Scan_Project
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        System.Globalization.CultureInfo m_culture;

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// درست کردن ستون های جدول اضافه کردن مدرک
        /// </summary>
        void InitializeAddDocsGrid()
        {
            dbConnections db = new dbConnections();
            DataTable itemNames;
            itemNames = db.GetItems();

            GridViewImageColumn imageColumn = new GridViewImageColumn();
            imageColumn.Name = "imageSrc";
            imageColumn.Width = 100;
            imageColumn.HeaderText = "تصویر سند";
            imageColumn.ImageLayout = ImageLayout.Zoom;

            gvAddDocs.Columns.Insert(0, imageColumn);

            gvAddDocs.Columns.Add("item1", itemNames.Rows[0][2].ToString());
            gvAddDocs.Columns.Add("item2", itemNames.Rows[1][2].ToString());
            gvAddDocs.Columns.Add("item3", itemNames.Rows[2][2].ToString());
            gvAddDocs.Columns.Add("docSrc", "آدرس فایل سند");

            gvAddDocs.Columns[1].Width = gvAddDocs.Columns[2].Width = gvAddDocs.Columns[3].Width = gvAddDocs.Columns[4].Width = 120;
        }

        void InitializeSearchDocsGrid()
        {
            dbConnections db = new dbConnections();
            DataTable itemNames;
            itemNames = db.GetItems();

            GridViewImageColumn imageColumn = new GridViewImageColumn();
            imageColumn.Name = "imageSrc";
            imageColumn.Width = 100;
            imageColumn.HeaderText = "تصویر سند";
            imageColumn.ImageLayout = ImageLayout.Zoom;

            gvSearchDocs.Columns.Insert(0, imageColumn);

            gvSearchDocs.Columns.Add("item1", itemNames.Rows[0][2].ToString());
            gvSearchDocs.Columns.Add("item2", itemNames.Rows[1][2].ToString());
            gvSearchDocs.Columns.Add("item3", itemNames.Rows[2][2].ToString());
            gvSearchDocs.Columns.Add("docSubmitDate", "تاریخ ثبت سند");
            gvSearchDocs.Columns.Add("docSrc", "آدرس فایل سند");

            gvSearchDocs.Columns[1].Width = gvSearchDocs.Columns[2].Width = gvSearchDocs.Columns[3].Width = gvSearchDocs.Columns[4].Width = 120;
        }

        void CleanNewDocPage()
        {
            txtAddDocSrc.Text = txtAddItem1.Text = txtAddItem2.Text = txtAddItem3.Text = string.Empty;
            openFileDialog1.Reset();
            docPicture.Image = null;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            if (lf.ShowDialog() != DialogResult.OK)
                Application.ExitThread();

            ProjectForm pf = new ProjectForm();
            if (pf.ShowDialog() != DialogResult.OK)
                Application.ExitThread();

            lblProjectName.Text = "نام پروژه: " + Properties.Settings.Default.projectName;

            if (!Properties.Settings.Default.userIsAdmin)
            {
                btnOpenUserForm.Enabled = false;
            }


            dbConnections db = new dbConnections();
            DataTable itemNames;
            itemNames = db.GetItems();

            if (itemNames.Rows.Count == 0)
            {
                ItemsForm itemForm = new ItemsForm();
                if (itemForm.ShowDialog() != DialogResult.OK)
                    Application.ExitThread();
            }

            itemNames = db.GetItems();
            lblItem1.Text = lblSearchItem1.Text = itemNames.Rows[0][2].ToString();
            lblItem2.Text = lblSearchItem2.Text = itemNames.Rows[1][2].ToString();
            lblItem3.Text = lblSearchItem3.Text = itemNames.Rows[2][2].ToString();

            InitializeSearchDocsGrid();

            try
            {
                m_culture = FixPersianLocale.PersianCultureHelper.FixPersianCulture(null, FixPersianLocale.FixCultureOptions.foptCalendarInDateFormatInfo);
                txtSearchSubmitFromDate.Culture = txtSearchSubmitToDate.Culture = m_culture;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOpenProjectForm_Click(object sender, EventArgs e)
        {
            ProjectForm pf = new ProjectForm();
            pf.ShowDialog();
            lblProjectName.Text = "نام پروژه: " + Properties.Settings.Default.projectName;
        }

        private void btnOpenItemForm_Click(object sender, EventArgs e)
        {
            ItemsForm itemsForm = new ItemsForm();
            itemsForm.ShowDialog();

        }

        private void btnOpenUserForm_Click(object sender, EventArgs e)
        {
            UserForm uf = new UserForm();
            uf.ShowDialog();
        }

        private void btnAddNewDoc_Click(object sender, EventArgs e)
        {
            CleanNewDocPage();
            gvAddDocs.CurrentRow = null;
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtAddDocSrc.Text = openFileDialog1.FileName;
                docPicture.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnEditDoc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddItem1.Text) || string.IsNullOrWhiteSpace(txtAddItem2.Text) || 
                string.IsNullOrWhiteSpace(txtAddItem3.Text) || string.IsNullOrWhiteSpace(txtAddDocSrc.Text))
            {
                RadMessageBox.ThemeName = "TelerikMetro";
                RadMessageBox.Show(null, "لطفا تمامی مقادیر را وارد کنید.", "خطا", MessageBoxButtons.OK,
                    RadMessageIcon.Info, MessageBoxDefaultButton.Button1, RightToLeft.Yes);
                return;
            }

            if (gvAddDocs.CurrentRow != null)
            {
                gvAddDocs.CurrentRow.Cells[0].Value = Image.FromFile(openFileDialog1.FileName);
                gvAddDocs.CurrentRow.Cells[1].Value = txtAddItem1.Text;
                gvAddDocs.CurrentRow.Cells[2].Value = txtAddItem2.Text;
                gvAddDocs.CurrentRow.Cells[3].Value = txtAddItem3.Text;
                gvAddDocs.CurrentRow.Cells[4].Value = openFileDialog1.FileName;
            }
            else
            {
                if (gvAddDocs.Rows.Count == 0)
                    InitializeAddDocsGrid();

                gvAddDocs.Rows.Add(Image.FromFile(openFileDialog1.FileName),
                                    txtAddItem1.Text, txtAddItem2.Text, txtAddItem3.Text, openFileDialog1.FileName);

                gvAddDocs.Rows[gvAddDocs.Rows.Count - 1].Height = 100;

                btnAddNewDoc.Enabled = true;
                btnSubmitDocs.Enabled = true;
            }
        }

        private void gvAddDocs_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            if (e.CurrentRow != null)
            {
                txtAddItem1.Text = e.CurrentRow.Cells[1].Value.ToString();
                txtAddItem2.Text = e.CurrentRow.Cells[2].Value.ToString();
                txtAddItem3.Text = e.CurrentRow.Cells[3].Value.ToString();
                txtAddDocSrc.Text = openFileDialog1.FileName = e.CurrentRow.Cells[4].Value.ToString();

                docPicture.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnSubmitDocs_Click(object sender, EventArgs e)
        {
            if (gvAddDocs.Rows.Count == 0)
                return;

            //چک کردن این که آدرس فایل ها در مدارک انتخابی درست باشند.
            for (int i = 0; i < gvAddDocs.Rows.Count; i++)
            {
                if (!System.IO.File.Exists(gvAddDocs.Rows[i].Cells[4].Value.ToString()))
                {
                    RadMessageBox.ThemeName = "TelerikMetro";
                    RadMessageBox.Show(null, "مدرک سطر " + i + ": فایل انتخابی وجود ندارد. لطفا فایل این مدرک را دوباره انتخاب کنید.", "خطا", MessageBoxButtons.OK,
                        RadMessageIcon.None, MessageBoxDefaultButton.Button1, RightToLeft.Yes);
                    return;
                }                
            }

            string relativePath = "\\Files\\" + Properties.Settings.Default.projectID.ToString() + "\\";
            string docsPath = Application.StartupPath + relativePath;
            if (!System.IO.Directory.Exists(docsPath))
            {
                System.IO.Directory.CreateDirectory(docsPath);
            }

            for (int i = 0; i < gvAddDocs.Rows.Count; i++)
            {
                string item1 = gvAddDocs.Rows[i].Cells[1].Value.ToString();
                string item2 = gvAddDocs.Rows[i].Cells[2].Value.ToString();
                string item3 = gvAddDocs.Rows[i].Cells[3].Value.ToString();
                string docSrcFile = gvAddDocs.Rows[i].Cells[4].Value.ToString();

                string newPath = item1 + "-" + item2 + "-" + item3 + "-" + DateTime.Now.ToFileTime() + System.IO.Path.GetExtension(docSrcFile);
                string newFile = System.IO.Path.Combine(docsPath, newPath);

                try
                {
                    System.IO.File.Copy(docSrcFile, newFile);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    continue;
                }

                try
                {
                    dbConnections db = new dbConnections();
                    db.InsertDocs(item1, item2, item3, relativePath + newPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    System.IO.File.Delete(newFile);
                }
            }

            RadMessageBox.ThemeName = "TelerikMetro";
            RadMessageBox.Show(null, "مدارک با موفقیت ثبت شدند.", "ثبت موفق", MessageBoxButtons.OK,
                RadMessageIcon.None, MessageBoxDefaultButton.Button1, RightToLeft.Yes);

            gvAddDocs.Rows.Clear();
            CleanNewDocPage();
            btnSubmitDocs.Enabled = false;
        }

        private void btnSearchDocs_Click(object sender, EventArgs e)
        {
            if (!cbIsSearchByDate.Checked && string.IsNullOrWhiteSpace(txtSearchItem1.Text + txtSearchItem2.Text + txtSearchItem3.Text))
            {
                RadMessageBox.ThemeName = "TelerikMetro";
                RadMessageBox.Show(null, "برای سرچ کردن باید حداقل یکی از مقادیر بالا را وارد کنید.", "خطا", MessageBoxButtons.OK,
                    RadMessageIcon.Info, MessageBoxDefaultButton.Button1, RightToLeft.Yes);
                return;
            }
            gvSearchDocs.Rows.Clear();
            
            dbConnections db = new dbConnections();

            DataTable dt, itemNames;
            dt = db.GetDocs(out itemNames, txtSearchItem1.Text, txtSearchItem2.Text, txtSearchItem3.Text,
                cbIsSearchByDate.Checked ? txtSearchSubmitFromDate.Value.ToString() : "",
                cbIsSearchByDate.Checked ? txtSearchSubmitToDate.Value.ToString() : "");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Image docPicture = null;
                try
                {
                    docPicture = Image.FromFile(Application.StartupPath + dt.Rows[i][5].ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                gvSearchDocs.Rows.Add(docPicture, dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(),
                                        dt.Rows[i][3].ToString(), dt.Rows[i][6].ToString(), Application.StartupPath + dt.Rows[i][5].ToString());
                gvSearchDocs.Rows[gvSearchDocs.Rows.Count - 1].Height = 100;
            }
        }

        private void btnShowAllDocs_Click(object sender, EventArgs e)
        {
            gvSearchDocs.Rows.Clear();
            dbConnections db = new dbConnections();

            DataTable itemNames, dt;
            dt = db.GetDocs(out itemNames);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Image docPicture = null;
                try
                {
                    docPicture = Image.FromFile(Application.StartupPath + dt.Rows[i][5].ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                gvSearchDocs.Rows.Add(docPicture, dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(),
                                        dt.Rows[i][3].ToString(), dt.Rows[i][6].ToString(), Application.StartupPath + dt.Rows[i][5].ToString());
                gvSearchDocs.Rows[gvSearchDocs.Rows.Count - 1].Height = 100;
            }
        }

        private void txtAddDocSrc_Click(object sender, EventArgs e)
        {
            btnBrowseFile_Click(null, null);
        }

        private void cbIsSearchByDate_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (cbIsSearchByDate.Checked)
                txtSearchSubmitToDate.Enabled = txtSearchSubmitFromDate.Enabled = true;
            else
                txtSearchSubmitToDate.Enabled = txtSearchSubmitFromDate.Enabled = false;
        }

        private void gvSearchDocs_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            string file = e.Row.Cells[5].Value.ToString();

            System.Diagnostics.Process.Start(file);
        }

        private void btnOpenAboutBox_Click(object sender, EventArgs e)
        {
            AboutForm af = new AboutForm();
            af.Show();
        }
    }
}
