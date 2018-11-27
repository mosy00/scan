using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using System.Security.Cryptography;
using Telerik.Charting;
using System.IO;
using System.Threading;

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
            if (gvAddDocs.Columns.Count > 0)
            {
                gvAddDocs.Rows.Clear();
                return;
            }

            dbConnections db = new dbConnections();
            DataTable itemNames;
            itemNames = db.GetItems();

            //GridViewImageColumn imageColumn = new GridViewImageColumn();
            //imageColumn.Name = "imageSrc";
            //imageColumn.Width = 100;
            //imageColumn.HeaderText = "تصویر سند";
            //imageColumn.ImageLayout = ImageLayout.Zoom;

            //gvAddDocs.Columns.Insert(0, imageColumn);

            gvAddDocs.Columns.Add("item1", itemNames.Rows[0][2].ToString());
            gvAddDocs.Columns.Add("item2", itemNames.Rows[1][2].ToString());
            gvAddDocs.Columns.Add("item3", itemNames.Rows[2][2].ToString());
            gvAddDocs.Columns.Add("docSrc", "آدرس فایل سند");

            gvAddDocs.Columns[0].Width = gvAddDocs.Columns[1].Width = gvAddDocs.Columns[2].Width = gvAddDocs.Columns[3].Width = 120;
            gvAddDocs.TableElement.RowHeaderColumnWidth = 50;
        }

        /// <summary>
        /// درست کردن ستون های جدول سرچ مدارک
        /// </summary>
        void InitializeSearchDocsGrid()
        {
            if (gvSearchDocs.Columns.Count > 0)
            {
                gvSearchDocs.Rows.Clear();
                return;
            }

            dbConnections db = new dbConnections();
            DataTable itemNames;
            itemNames = db.GetItems();

            //GridViewImageColumn imageColumn = new GridViewImageColumn();
            //imageColumn.Name = "imageSrc";
            //imageColumn.Width = 100;
            //imageColumn.HeaderText = "تصویر سند";
            //imageColumn.ImageLayout = ImageLayout.Zoom;

            //gvSearchDocs.Columns.Insert(0, imageColumn);

            gvSearchDocs.Columns.Add("item1", itemNames.Rows[0][2].ToString());
            gvSearchDocs.Columns.Add("item2", itemNames.Rows[1][2].ToString());
            gvSearchDocs.Columns.Add("item3", itemNames.Rows[2][2].ToString());
            gvSearchDocs.Columns.Add("docSubmitDate", "تاریخ ثبت سند");
            gvSearchDocs.Columns.Add("docSrc", "آدرس فایل سند");

            gvSearchDocs.Columns[1].Width = gvSearchDocs.Columns[2].Width = gvSearchDocs.Columns[3].Width = gvSearchDocs.Columns[4].Width = 120;
        }

        /// <summary>
        /// آماده کردن صفحه اصلی
        /// </summary>
        void InitializeHomePage()
        {
            DataTable dt, itemNames;

            dbConnections db = new dbConnections();
            dt = db.GetDocs(out itemNames);


            BarSeries series = new BarSeries();

            series.DataPoints.Add(new CategoricalDataPoint(6, DateTime.Today));


            DateTimeCategoricalAxis categoricalAxis = new DateTimeCategoricalAxis();
            categoricalAxis.DateTimeComponent = DateTimeComponent.Day;
            categoricalAxis.PlotMode = AxisPlotMode.BetweenTicks;
            categoricalAxis.LabelFormat = "{0:m}";
            //First assign the axis to the VerticalAxis property and then add the series to the chart
            series.HorizontalAxis = categoricalAxis;
            chartView1.Series.Add(series);



            txtShowProjectDocsNumber.Text = dt.Rows.Count.ToString();
            txtShowUsername.Text = Properties.Settings.Default.userName;

            if (Properties.Settings.Default.userRole == 1)
                txtShowUserRole.Text = "کاربر ادمین";
            else if (Properties.Settings.Default.userRole == 2)
            {
                txtShowUserRole.Text = "کاربر با امکان ثبت";
                btnOpenUserForm.Enabled = false;
            }
            else if (Properties.Settings.Default.userRole == 3)
            {
                txtShowUserRole.Text = "فقط بازدید";
                addDocsPage.Enabled = false;
            }

        }

        void CleanNewDocPage()
        {
            txtAddDocSrc.Text = txtAddItem1.Text = txtAddItem2.Text = txtAddItem3.Text = string.Empty;
            openFileDialog1.Reset();
            docPicture.Image = null;

            gvAddDocs.Rows.Clear();
            lblAddDocsCount.Text = gvAddDocs.Rows.Count.ToString();
        }

        void CleanSearchDocPage()
        {
            txtSearchItem1.Text = txtSearchItem2.Text = txtSearchItem3.Text = string.Empty;
            cbIsSearchByDate.Checked = false;
            docPictureInSearchTab = null;

            gvSearchDocs.Rows.Clear();
        }

        void ImportFromExcel()
        {
            //اسم جدول در اکسل که باید 
            //Sheet1
            //باشد.
            String name = "Sheet1";
            String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                            openFileDialog2.FileName +
                            ";Extended Properties='Excel 12.0 XML;HDR=YES;';";

            OleDbConnection con = new OleDbConnection(constr);
            OleDbCommand oconn = new OleDbCommand("Select * From [" + name + "$]", con);
            con.Open();

            OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();

            //در صورتی که اولین بار است که ذخیره انجام میشود و هنوز ستون ها ساخته نشده است.
            if (gvAddDocs.Columns.Count == 0)
                InitializeAddDocsGrid();

            string folderPath = Directory.GetParent(openFileDialog2.FileName).FullName;

            string file = "";

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                file = folderPath + "\\" + dt.Rows[i][3].ToString();
                try
                {
                    gvAddDocs.Rows.Add(/*Image.FromFile(file),*/ dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(),
                                                            dt.Rows[i][2].ToString(), file);

                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }

                gvAddDocs.Rows[gvAddDocs.Rows.Count - 1].Height = 40;
            }

            //btnSubmitDocs.Enabled = true;
            //lblAddDocsCount.Text = gvAddDocs.Rows.Count.ToString();
        }

        void ImageOnly()
        {
            string folderPath = Directory.GetParent(openFileDialog2.FileName).FullName;

            string file = "";
            for (int i = 0; i < gvAddDocs.Rows.Count; i++)
            {
                file = gvAddDocs.Rows[i].Cells[4].Value.ToString();
                try
                {
                    gvAddDocs.Rows[i].Cells[0].Value = Image.FromFile(file);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }

                gvAddDocs.Rows[gvAddDocs.Rows.Count - 1].Height = 100;
            }
        }

        private string GenerateHashString(HashAlgorithm algo, string text)
        {
            // Compute hash from text parameter
            algo.ComputeHash(Encoding.UTF8.GetBytes(text));

            // Get has value in array of bytes
            var result = algo.Hash;

            // Return as hexadecimal string
            return string.Join(
                string.Empty,
                result.Select(x => x.ToString("x2")));
        }

        private string MD5(string text)
        {
            var result = default(string);

            using (var algo = new MD5CryptoServiceProvider())
            {
                result = GenerateHashString(algo, text);
            }

            return result;
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
            txtShowProjectName.Text = Properties.Settings.Default.projectName;

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

            InitializeHomePage();
            radPageView1.SelectedPage = homePage;
            CleanNewDocPage();
            CleanSearchDocPage();
        }

        private void btnOpenProjectForm_Click(object sender, EventArgs e)
        {
            ProjectForm pf = new ProjectForm();

            if (pf.ShowDialog() == DialogResult.OK)
            {
                lblProjectName.Text = "نام پروژه: " + Properties.Settings.Default.projectName;
                txtShowProjectName.Text = Properties.Settings.Default.projectName;

                dbConnections db = new dbConnections();
                DataTable itemNames;
                itemNames = db.GetItems();
                if (itemNames.Rows.Count == 0)
                {
                    ItemsForm itemForm = new ItemsForm();
                    if (itemForm.ShowDialog() != DialogResult.OK)
                        Application.ExitThread();
                }
                InitializeAddDocsGrid();
                InitializeSearchDocsGrid();
                CleanNewDocPage();
            }


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
            txtAddDocSrc.Text = txtAddItem1.Text = txtAddItem2.Text = txtAddItem3.Text = string.Empty;
            openFileDialog1.Reset();
            docPicture.Image = null;
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

            //در صورتی که یکی از سطر های جدول انتخاب شده باشد.
            //در این حالت انتخاب این دکمه حکم به روز رسانی داده های سطر را دارد.
            if (gvAddDocs.CurrentRow != null && gvAddDocs.Rows.Count != 0)
            {
                //gvAddDocs.CurrentRow.Cells[0].Value = Image.FromFile(openFileDialog1.FileName);
                gvAddDocs.CurrentRow.Cells[0].Value = txtAddItem1.Text.Trim();
                gvAddDocs.CurrentRow.Cells[1].Value = txtAddItem2.Text.Trim();
                gvAddDocs.CurrentRow.Cells[2].Value = txtAddItem3.Text.Trim();
                gvAddDocs.CurrentRow.Cells[3].Value = openFileDialog1.FileName;
            }
            else
            {
                //در صورتی که اولین بار است که ذخیره انجام میشود و هنوز ستون ها ساخته نشده است.
                if (gvAddDocs.Columns.Count == 0)
                    InitializeAddDocsGrid();

                gvAddDocs.Rows.Add(/*Image.FromFile(openFileDialog1.FileName),*/
                                    txtAddItem1.Text.Trim(), txtAddItem2.Text.Trim(), txtAddItem3.Text.Trim(), openFileDialog1.FileName);

                gvAddDocs.Rows[gvAddDocs.Rows.Count - 1].Height = 40;

                btnAddNewDoc.Enabled = true;
                btnSubmitDocs.Enabled = true;
            }
            lblAddDocsCount.Text = gvAddDocs.Rows.Count.ToString();
        }

        private void gvAddDocs_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            if (e.CurrentRow != null)
            {
                txtAddItem1.Text = e.CurrentRow.Cells[0].Value.ToString();
                txtAddItem2.Text = e.CurrentRow.Cells[1].Value.ToString();
                txtAddItem3.Text = e.CurrentRow.Cells[2].Value.ToString();
                txtAddDocSrc.Text = openFileDialog1.FileName = e.CurrentRow.Cells[3].Value.ToString();

                docPicture.ImageLocation = openFileDialog1.FileName;
            }
            lblAddDocsCount.Text = gvAddDocs.Rows.Count.ToString();
        }

        private void btnSubmitDocs_Click(object sender, EventArgs e)
        {
            if (gvAddDocs.Rows.Count == 0)
                return;
            
            //آدرس فولدر به صورت نسبی
            string relativePath = "\\Files\\" + Properties.Settings.Default.projectID.ToString() + "\\";
            //آدرس فولدر به صورت کامل
            string docsPath = Application.StartupPath + relativePath;
            //ساخت فولدر در صورت عدم وجود
            if (!System.IO.Directory.Exists(docsPath))
            {
                System.IO.Directory.CreateDirectory(docsPath);
            }

            DataTable rowsWithError = new DataTable();

            //ثبت مدرک هر سطر در دیتابیس
            for (int i = 0; i < gvAddDocs.Rows.Count; i++)
            {
                string item1 = gvAddDocs.Rows[i].Cells[0].Value.ToString();
                string item2 = gvAddDocs.Rows[i].Cells[1].Value.ToString();
                string item3 = gvAddDocs.Rows[i].Cells[2].Value.ToString();
                string docSrcFile = gvAddDocs.Rows[i].Cells[3].Value.ToString();

                //ساخت اسم و مسیر فایل
                string newPath = MD5(item1 + "-" + item2 + "-" + item3 + "-" + DateTime.Now.ToFileTime()) + System.IO.Path.GetExtension(docSrcFile);
                string newFile = System.IO.Path.Combine(docsPath, newPath);

                try
                {
                    //کپی فایل به فولدر
                    File.Copy(docSrcFile, newFile);
                }
                catch (Exception)
                {
                    //سطری که خطا دارد و فایل انتخابی درست نیست را در یک دیتاتیبل نگه میدارد تا در انتها دوباره به جدول اضافه کند
                    if (rowsWithError.Columns.Count == 0)
                    {
                        for (int j = 0; j < gvAddDocs.Columns.Count; j++)
                        {
                            rowsWithError.Columns.Add("column" + j.ToString());
                        }
                    }
                    
                    DataRow dr = rowsWithError.NewRow();
                    for (int j = 0; j < gvAddDocs.Columns.Count; j++)
                    {
                        dr["column" + j.ToString()] = gvAddDocs.Rows[i].Cells[j].Value.ToString();
                    }

                    rowsWithError.Rows.Add(dr);
                    continue;
                }

                try
                {
                    //ذخیره در دیتابیس
                    dbConnections db = new dbConnections();
                    db.InsertDocs(item1, item2, item3, relativePath + newPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //در صورت عدم توانایی در ذخیره مشخصات در دیتابیس، فایل کپی شده را نیز حذف میکند تا بعدا تداخل ایجاد نشود.
                    System.IO.File.Delete(newFile);
                }
            }

            string nameOfRowsWithError = "";
            for (int i = 0; i < rowsWithError.Rows.Count; i++)
            {
                nameOfRowsWithError += rowsWithError.Rows[i][3].ToString() + "\n";
            }

            RadMessageBox.ThemeName = "TelerikMetro";
            RadMessageBox.Show(null, gvAddDocs.Rows.Count - rowsWithError.Rows.Count + " مدرک با موفقیت ثبت شدند. \n" + "مدارک زیر ناقص بودند: \n" + nameOfRowsWithError, "ثبت موفق", MessageBoxButtons.OK,
                RadMessageIcon.None, MessageBoxDefaultButton.Button1, RightToLeft.Yes);
            //خالی کردن جدول
            gvAddDocs.Rows.Clear();
            //پر کردن جدول با سطر های ارور دار.
            for (int i = 0; i < rowsWithError.Rows.Count; i++)
            {
                gvAddDocs.Rows.Add(rowsWithError.Rows[i][0].ToString(), rowsWithError.Rows[i][1].ToString(), rowsWithError.Rows[i][2].ToString(),
                                    rowsWithError.Rows[i][3].ToString());
                gvAddDocs.CurrentRow.Height = 40;
            }

            btnAddNewDoc_Click(null, null);
            if (gvAddDocs.Rows.Count == 0)
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
                //Image docPicture = null;
                //try
                //{
                //    docPicture = Image.FromFile(Application.StartupPath + dt.Rows[i][5].ToString());
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
                gvSearchDocs.Rows.Add(/*docPicture,*/ dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(),
                                        dt.Rows[i][3].ToString(), dt.Rows[i][6].ToString(), Application.StartupPath + dt.Rows[i][5].ToString());
                gvSearchDocs.Rows[i].Tag = dt.Rows[i][0].ToString();
                gvSearchDocs.Rows[gvSearchDocs.Rows.Count - 1].Height = 40;
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
                //Image docPicture = null;
                //try
                //{
                //    docPicture = Image.FromFile(Application.StartupPath + dt.Rows[i][5].ToString());
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
                gvSearchDocs.Rows.Add(/*docPicture,*/ dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(),
                                        dt.Rows[i][3].ToString(), dt.Rows[i][6].ToString(), Application.StartupPath + dt.Rows[i][5].ToString());
                gvSearchDocs.Rows[i].Tag = dt.Rows[i][0].ToString();
                gvSearchDocs.Rows[gvSearchDocs.Rows.Count - 1].Height = 40;
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
            string file = e.Row.Cells[4].Value.ToString();
            try
            {
                System.Diagnostics.Process.Start(file);
            }
            catch (Exception)
            {

            }
        }

        private void btnOpenAboutBox_Click(object sender, EventArgs e)
        {
            AboutForm af = new AboutForm();
            af.Show();
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainForm_Load(null, null);
            this.Visible = true;
        }

        private void gvSearchDocs_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point p = new Point();
                p.X = e.X;
                p.Y = e.Y;
                radContextMenu1.Show(gvSearchDocs, p);
            }
        }

        private void btnEditRowItem_Click(object sender, EventArgs e)
        {
            EditDocsForm ef = new EditDocsForm(gvSearchDocs.SelectedRows[0].Tag.ToString());
            ef.ShowDialog();
        }

        private void btnDeleteRowItem_Click(object sender, EventArgs e)
        {
            try
            {
                dbConnections db = new dbConnections();
                db.deleteDoc(gvSearchDocs.SelectedRows[0].Tag.ToString());

                RadMessageBox.ThemeName = "TelerikMetro";
                RadMessageBox.Show(null, "مدرک انتخابی به درستی حذف گردید.", "حذف", MessageBoxButtons.OK,
                    RadMessageIcon.None, MessageBoxDefaultButton.Button1, RightToLeft.Yes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnImportFromExcel_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                //ThreadStart childref = new ThreadStart(ImageOnly);
                //In Main: Creating the Child thread
                //Thread childThread = new Thread(ImageOnly);
                //childThread.Name = "test1";

                ImportFromExcel();
                GC.Collect();

                //childThread.Start();
                //childThread.Join();
                //GC.Collect();


                btnSubmitDocs.Enabled = true;
                lblAddDocsCount.Text = gvAddDocs.Rows.Count.ToString();
            }
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // creating Excel Application  
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application  
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // creating new Excelsheet in workbook  
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // see the excel sheet behind the program  
                app.Visible = true;
                // get the reference of first sheet. By default its name is Sheet1.  
                // store its reference to worksheet  
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                // changing the name of active sheet  
                //worksheet.Name = "Exported from gridview";
                // storing header part in Excel  
                for (int i = 1; i <= 3; i++)
                {
                    worksheet.Cells[1, i] = gvSearchDocs.Columns[i].HeaderText;
                }
                worksheet.Cells[1, 4] = "آدرس نسبی فایل";
                // storing Each row and column value to excel sheet  
                for (int i = 0; i < gvSearchDocs.Rows.Count; i++)
                {
                    for (int j = 1; j < gvSearchDocs.Columns.Count; j++)
                    {
                        if (j == 4)
                            continue;
                        else if (j == 5)
                        {
                            worksheet.Cells[i + 2, j - 1] = gvSearchDocs.Rows[i].Cells[j].Value.ToString().Substring(gvSearchDocs.Rows[i].Cells[j].Value.ToString().LastIndexOf('\\') + 1);
                            continue;
                        }
                        worksheet.Cells[i + 2, j] = gvSearchDocs.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // save the application
                string s = saveFileDialog1.FileName;
                workbook.SaveAs(s, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                // Exit from the application
                app.Quit();
            }
        }

        private void gvAddDocs_ViewCellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.CellElement is GridRowHeaderCellElement && e.Row is GridViewDataRowInfo)
            {
                e.CellElement.Text = (e.CellElement.RowIndex + 1).ToString();
                e.CellElement.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
            else
            {
                e.CellElement.ResetValue(LightVisualElement.TextImageRelationProperty, ValueResetFlags.Local);
            }
        }

        private void gvSearchDocs_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            if (e.CurrentRow != null)
            {
                try
                {
                    docPictureInSearchTab.ImageLocation = e.CurrentRow.Cells[4].Value.ToString();
                }
                catch (Exception)
                {
                    
                }
                
            }
        }
    }
}
