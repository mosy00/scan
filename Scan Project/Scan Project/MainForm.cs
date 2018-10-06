using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Scan_Project
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        public MainForm()
        {
            InitializeComponent();
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
    }
}
