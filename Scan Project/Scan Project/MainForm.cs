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

namespace Scan_Project
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
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
            gvAddDocs.Columns.Add("docSubmitDate", "تاریخ بارگذاری سند");
            gvAddDocs.Columns.Add("docSrc", "آدرس فایل سند");

            gvAddDocs.Columns[1].Width = gvAddDocs.Columns[2].Width = gvAddDocs.Columns[3].Width = gvAddDocs.Columns[4].Width = 120;
        }

        void CleanNewDocPage()
        {
            txtAddDocSrc.Text = txtAddDocSubmitDate.Text = txtAddItem1.Text = txtAddItem2.Text = txtAddItem3.Text = string.Empty;
            openFileDialog1.Reset();
            docPicture.Image = null;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //LoginForm lf = new LoginForm();
            //if (lf.ShowDialog() != DialogResult.OK)
            //    Application.ExitThread();

            ProjectForm pf = new ProjectForm();
            if (pf.ShowDialog() != DialogResult.OK)
                Application.ExitThread();

            lblProjectName.Text = "نام پروژه: " + Properties.Settings.Default.projectName;

            dbConnections db = new dbConnections();
            DataTable itemNames;
            itemNames = db.GetItems();
            lblItem1.Text = itemNames.Rows[0][2].ToString();
            lblItem2.Text = itemNames.Rows[1][2].ToString();
            lblItem3.Text = itemNames.Rows[2][2].ToString();
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
            if (gvAddDocs.CurrentRow != null)
            {
                gvAddDocs.CurrentRow.Cells[0].Value = Image.FromFile(openFileDialog1.FileName);
                gvAddDocs.CurrentRow.Cells[1].Value = txtAddItem1.Text;
                gvAddDocs.CurrentRow.Cells[2].Value = txtAddItem2.Text;
                gvAddDocs.CurrentRow.Cells[3].Value = txtAddItem3.Text;
                gvAddDocs.CurrentRow.Cells[4].Value = txtAddDocSubmitDate.Text;
                gvAddDocs.CurrentRow.Cells[5].Value = openFileDialog1.FileName;
            }
            else
            {
                if (gvAddDocs.Rows.Count == 0)
                    InitializeAddDocsGrid();

                gvAddDocs.Rows.Add(Image.FromFile(openFileDialog1.FileName),
                                    txtAddItem1.Text, txtAddItem2.Text, txtAddItem3.Text, txtAddDocSubmitDate.Text, openFileDialog1.FileName);

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
                txtAddDocSubmitDate.Text = e.CurrentRow.Cells[4].Value.ToString();
                txtAddDocSrc.Text = openFileDialog1.FileName = e.CurrentRow.Cells[5].Value.ToString();

                docPicture.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnSubmitDocs_Click(object sender, EventArgs e)
        {

        }
    }
}
