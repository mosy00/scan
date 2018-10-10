namespace Scan_Project
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.homePage = new Telerik.WinControls.UI.RadPageViewPage();
            this.addDocsPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnEditDoc = new Telerik.WinControls.UI.RadButton();
            this.btnSubmitDocs = new Telerik.WinControls.UI.RadButton();
            this.btnAddNewDoc = new Telerik.WinControls.UI.RadButton();
            this.docPicture = new System.Windows.Forms.PictureBox();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.txtAddDocSrc = new Telerik.WinControls.UI.RadTextBox();
            this.btnBrowseFile = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.txtAddItem2 = new Telerik.WinControls.UI.RadTextBox();
            this.txtAddDocSubmitDate = new Telerik.WinControls.UI.RadTextBox();
            this.txtAddItem3 = new Telerik.WinControls.UI.RadTextBox();
            this.txtAddItem1 = new Telerik.WinControls.UI.RadTextBox();
            this.gvAddDocs = new Telerik.WinControls.UI.RadGridView();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.lblProjectName = new Telerik.WinControls.UI.RadLabelElement();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.radMenuButtonItem1 = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.btnOpenProjectForm = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.btnOpenItemForm = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.btnOpenUserForm = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.btnOpenChangePasswordForm = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.uname = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            this.addDocsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmitDocs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNewDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddDocSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBrowseFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddDocSubmitDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAddDocs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAddDocs.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            this.radMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPageView1
            // 
            resources.ApplyResources(this.radPageView1, "radPageView1");
            this.radPageView1.Controls.Add(this.homePage);
            this.radPageView1.Controls.Add(this.addDocsPage);
            this.radPageView1.DefaultPage = this.homePage;
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.SelectedPage = this.homePage;
            this.radPageView1.ThemeName = "TelerikMetro";
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).ItemAlignment = Telerik.WinControls.UI.StripViewItemAlignment.Near;
            // 
            // homePage
            // 
            this.homePage.Image = global::Scan_Project.Properties.Resources.home_2_;
            this.homePage.ItemSize = new System.Drawing.SizeF(125F, 40F);
            resources.ApplyResources(this.homePage, "homePage");
            this.homePage.Name = "homePage";
            // 
            // addDocsPage
            // 
            this.addDocsPage.Controls.Add(this.radGroupBox1);
            this.addDocsPage.Controls.Add(this.gvAddDocs);
            this.addDocsPage.Image = global::Scan_Project.Properties.Resources.document_add_outlined_symbol;
            this.addDocsPage.ItemSize = new System.Drawing.SizeF(112F, 40F);
            resources.ApplyResources(this.addDocsPage, "addDocsPage");
            this.addDocsPage.Name = "addDocsPage";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.btnEditDoc);
            this.radGroupBox1.Controls.Add(this.btnSubmitDocs);
            this.radGroupBox1.Controls.Add(this.btnAddNewDoc);
            this.radGroupBox1.Controls.Add(this.docPicture);
            this.radGroupBox1.Controls.Add(this.radLabel5);
            this.radGroupBox1.Controls.Add(this.txtAddDocSrc);
            this.radGroupBox1.Controls.Add(this.btnBrowseFile);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.radLabel4);
            this.radGroupBox1.Controls.Add(this.txtAddItem2);
            this.radGroupBox1.Controls.Add(this.txtAddDocSubmitDate);
            this.radGroupBox1.Controls.Add(this.txtAddItem3);
            this.radGroupBox1.Controls.Add(this.txtAddItem1);
            resources.ApplyResources(this.radGroupBox1, "radGroupBox1");
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.ThemeName = "TelerikMetro";
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).Text = resources.GetString("resource.Text1");
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).Font = new System.Drawing.Font("IRANSans", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.Alignment")));
            // 
            // btnEditDoc
            // 
            resources.ApplyResources(this.btnEditDoc, "btnEditDoc");
            this.btnEditDoc.Name = "btnEditDoc";
            this.btnEditDoc.ThemeName = "TelerikMetro";
            this.btnEditDoc.Click += new System.EventHandler(this.btnEditDoc_Click);
            // 
            // btnSubmitDocs
            // 
            resources.ApplyResources(this.btnSubmitDocs, "btnSubmitDocs");
            this.btnSubmitDocs.Name = "btnSubmitDocs";
            this.btnSubmitDocs.ThemeName = "TelerikMetro";
            // 
            // btnAddNewDoc
            // 
            resources.ApplyResources(this.btnAddNewDoc, "btnAddNewDoc");
            this.btnAddNewDoc.Name = "btnAddNewDoc";
            this.btnAddNewDoc.ThemeName = "TelerikMetro";
            this.btnAddNewDoc.Click += new System.EventHandler(this.btnAddNewDoc_Click);
            // 
            // docPicture
            // 
            resources.ApplyResources(this.docPicture, "docPicture");
            this.docPicture.Name = "docPicture";
            this.docPicture.TabStop = false;
            // 
            // radLabel5
            // 
            resources.ApplyResources(this.radLabel5, "radLabel5");
            this.radLabel5.Name = "radLabel5";
            // 
            // txtAddDocSrc
            // 
            resources.ApplyResources(this.txtAddDocSrc, "txtAddDocSrc");
            this.txtAddDocSrc.Name = "txtAddDocSrc";
            this.txtAddDocSrc.ThemeName = "TelerikMetro";
            // 
            // btnBrowseFile
            // 
            resources.ApplyResources(this.btnBrowseFile, "btnBrowseFile");
            this.btnBrowseFile.Image = global::Scan_Project.Properties.Resources.browse_black;
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.ThemeName = "TelerikMetro";
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnBrowseFile.GetChildAt(0))).Image = global::Scan_Project.Properties.Resources.browse_black;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnBrowseFile.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnBrowseFile.GetChildAt(0))).DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnBrowseFile.GetChildAt(0))).Text = resources.GetString("resource.Text");
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnBrowseFile.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnBrowseFile.GetChildAt(0).GetChildAt(2))).Width = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnBrowseFile.GetChildAt(0).GetChildAt(2))).LeftWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnBrowseFile.GetChildAt(0).GetChildAt(2))).TopWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnBrowseFile.GetChildAt(0).GetChildAt(2))).RightWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnBrowseFile.GetChildAt(0).GetChildAt(2))).BottomWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnBrowseFile.GetChildAt(0).GetChildAt(2))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            // 
            // radLabel1
            // 
            resources.ApplyResources(this.radLabel1, "radLabel1");
            this.radLabel1.Name = "radLabel1";
            // 
            // radLabel2
            // 
            resources.ApplyResources(this.radLabel2, "radLabel2");
            this.radLabel2.Name = "radLabel2";
            // 
            // radLabel3
            // 
            resources.ApplyResources(this.radLabel3, "radLabel3");
            this.radLabel3.Name = "radLabel3";
            // 
            // radLabel4
            // 
            resources.ApplyResources(this.radLabel4, "radLabel4");
            this.radLabel4.Name = "radLabel4";
            // 
            // txtAddItem2
            // 
            resources.ApplyResources(this.txtAddItem2, "txtAddItem2");
            this.txtAddItem2.Name = "txtAddItem2";
            this.txtAddItem2.ThemeName = "TelerikMetro";
            // 
            // txtAddDocSubmitDate
            // 
            resources.ApplyResources(this.txtAddDocSubmitDate, "txtAddDocSubmitDate");
            this.txtAddDocSubmitDate.Name = "txtAddDocSubmitDate";
            this.txtAddDocSubmitDate.ThemeName = "TelerikMetro";
            // 
            // txtAddItem3
            // 
            resources.ApplyResources(this.txtAddItem3, "txtAddItem3");
            this.txtAddItem3.Name = "txtAddItem3";
            this.txtAddItem3.ThemeName = "TelerikMetro";
            // 
            // txtAddItem1
            // 
            resources.ApplyResources(this.txtAddItem1, "txtAddItem1");
            this.txtAddItem1.Name = "txtAddItem1";
            this.txtAddItem1.ThemeName = "TelerikMetro";
            // 
            // gvAddDocs
            // 
            resources.ApplyResources(this.gvAddDocs, "gvAddDocs");
            // 
            // 
            // 
            this.gvAddDocs.MasterTemplate.AllowAddNewRow = false;
            this.gvAddDocs.MasterTemplate.AllowDeleteRow = false;
            this.gvAddDocs.MasterTemplate.AllowEditRow = false;
            this.gvAddDocs.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gvAddDocs.Name = "gvAddDocs";
            this.gvAddDocs.ReadOnly = true;
            this.gvAddDocs.ThemeName = "TelerikMetro";
            this.gvAddDocs.CurrentRowChanged += new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.gvAddDocs_CurrentRowChanged);
            // 
            // radStatusStrip1
            // 
            resources.ApplyResources(this.radStatusStrip1, "radStatusStrip1");
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.lblProjectName});
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.ThemeName = "TelerikMetro";
            // 
            // lblProjectName
            // 
            resources.ApplyResources(this.lblProjectName, "lblProjectName");
            this.lblProjectName.Name = "lblProjectName";
            this.radStatusStrip1.SetSpring(this.lblProjectName, false);
            this.lblProjectName.TextWrap = true;
            this.lblProjectName.UseCompatibleTextRendering = false;
            // 
            // radMenu1
            // 
            this.radMenu1.Controls.Add(this.uname);
            this.radMenu1.Controls.Add(this.radLabel6);
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuButtonItem1,
            this.btnOpenProjectForm,
            this.btnOpenItemForm,
            this.btnOpenUserForm,
            this.btnOpenChangePasswordForm});
            resources.ApplyResources(this.radMenu1, "radMenu1");
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.ThemeName = "TelerikMetro";
            // 
            // radMenuButtonItem1
            // 
            resources.ApplyResources(this.radMenuButtonItem1, "radMenuButtonItem1");
            this.radMenuButtonItem1.BorderHighlightColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.radMenuButtonItem1.ButtonElement.Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("radMenuButtonItem1.ButtonElement.Alignment")));
            this.radMenuButtonItem1.ButtonElement.AngleTransform = ((float)(resources.GetObject("radMenuButtonItem1.ButtonElement.AngleTransform")));
            this.radMenuButtonItem1.ButtonElement.FlipText = ((bool)(resources.GetObject("radMenuButtonItem1.ButtonElement.FlipText")));
            this.radMenuButtonItem1.ButtonElement.Image = ((System.Drawing.Image)(resources.GetObject("radMenuButtonItem1.ButtonElement.Image")));
            this.radMenuButtonItem1.ButtonElement.ImageIndex = ((int)(resources.GetObject("radMenuButtonItem1.ButtonElement.ImageIndex")));
            this.radMenuButtonItem1.ButtonElement.ImageKey = resources.GetString("radMenuButtonItem1.ButtonElement.ImageKey");
            this.radMenuButtonItem1.ButtonElement.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("radMenuButtonItem1.ButtonElement.Margin")));
            this.radMenuButtonItem1.ButtonElement.Padding = ((System.Windows.Forms.Padding)(resources.GetObject("radMenuButtonItem1.ButtonElement.Padding")));
            this.radMenuButtonItem1.ButtonElement.RightToLeft = ((bool)(resources.GetObject("radMenuButtonItem1.ButtonElement.RightToLeft")));
            this.radMenuButtonItem1.ButtonElement.TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("radMenuButtonItem1.ButtonElement.TextOrientation")));
            this.radMenuButtonItem1.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.radMenuButtonItem1.FocusBorderColor = System.Drawing.Color.Transparent;
            this.radMenuButtonItem1.Font = new System.Drawing.Font("IRANSans", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMenuButtonItem1.Image = global::Scan_Project.Properties.Resources.gears;
            this.radMenuButtonItem1.Name = "radMenuButtonItem1";
            this.radMenuButtonItem1.ShadowColor = System.Drawing.Color.White;
            this.radMenuButtonItem1.UseCompatibleTextRendering = false;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radMenuButtonItem1.GetChildAt(2))).Image = ((System.Drawing.Image)(resources.GetObject("radMenuButtonItem1.ButtonElement.Image1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.radMenuButtonItem1.GetChildAt(2))).ImageIndex = ((int)(resources.GetObject("radMenuButtonItem1.ButtonElement.ImageIndex1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.radMenuButtonItem1.GetChildAt(2))).ImageKey = resources.GetString("radMenuButtonItem1.ButtonElement.ImageKey1");
            ((Telerik.WinControls.UI.RadButtonElement)(this.radMenuButtonItem1.GetChildAt(2))).TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("radMenuButtonItem1.ButtonElement.TextOrientation1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.radMenuButtonItem1.GetChildAt(2))).FlipText = ((bool)(resources.GetObject("radMenuButtonItem1.ButtonElement.FlipText1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.radMenuButtonItem1.GetChildAt(2))).Padding = ((System.Windows.Forms.Padding)(resources.GetObject("radMenuButtonItem1.ButtonElement.Padding1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.radMenuButtonItem1.GetChildAt(2))).Margin = ((System.Windows.Forms.Padding)(resources.GetObject("radMenuButtonItem1.ButtonElement.Margin1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.radMenuButtonItem1.GetChildAt(2))).Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("radMenuButtonItem1.ButtonElement.Alignment1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.radMenuButtonItem1.GetChildAt(2))).RightToLeft = ((bool)(resources.GetObject("radMenuButtonItem1.ButtonElement.RightToLeft1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.radMenuButtonItem1.GetChildAt(2))).AngleTransform = ((float)(resources.GetObject("radMenuButtonItem1.ButtonElement.AngleTransform1")));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radMenuButtonItem1.GetChildAt(2).GetChildAt(2))).Width = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radMenuButtonItem1.GetChildAt(2).GetChildAt(2))).LeftWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radMenuButtonItem1.GetChildAt(2).GetChildAt(2))).TopWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radMenuButtonItem1.GetChildAt(2).GetChildAt(2))).RightWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radMenuButtonItem1.GetChildAt(2).GetChildAt(2))).BottomWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radMenuButtonItem1.GetChildAt(2).GetChildAt(2))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            // 
            // btnOpenProjectForm
            // 
            resources.ApplyResources(this.btnOpenProjectForm, "btnOpenProjectForm");
            // 
            // 
            // 
            this.btnOpenProjectForm.ButtonElement.Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("btnOpenProjectForm.ButtonElement.Alignment")));
            this.btnOpenProjectForm.ButtonElement.AngleTransform = ((float)(resources.GetObject("btnOpenProjectForm.ButtonElement.AngleTransform")));
            this.btnOpenProjectForm.ButtonElement.FlipText = ((bool)(resources.GetObject("btnOpenProjectForm.ButtonElement.FlipText")));
            this.btnOpenProjectForm.ButtonElement.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenProjectForm.ButtonElement.Image")));
            this.btnOpenProjectForm.ButtonElement.ImageIndex = ((int)(resources.GetObject("btnOpenProjectForm.ButtonElement.ImageIndex")));
            this.btnOpenProjectForm.ButtonElement.ImageKey = resources.GetString("btnOpenProjectForm.ButtonElement.ImageKey");
            this.btnOpenProjectForm.ButtonElement.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("btnOpenProjectForm.ButtonElement.Margin")));
            this.btnOpenProjectForm.ButtonElement.Padding = ((System.Windows.Forms.Padding)(resources.GetObject("btnOpenProjectForm.ButtonElement.Padding")));
            this.btnOpenProjectForm.ButtonElement.RightToLeft = ((bool)(resources.GetObject("btnOpenProjectForm.ButtonElement.RightToLeft")));
            this.btnOpenProjectForm.ButtonElement.TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("btnOpenProjectForm.ButtonElement.TextOrientation")));
            this.btnOpenProjectForm.Image = global::Scan_Project.Properties.Resources.tabs;
            this.btnOpenProjectForm.Name = "btnOpenProjectForm";
            this.btnOpenProjectForm.Click += new System.EventHandler(this.btnOpenProjectForm_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenProjectForm.GetChildAt(2))).Image = ((System.Drawing.Image)(resources.GetObject("btnOpenProjectForm.ButtonElement.Image1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenProjectForm.GetChildAt(2))).ImageIndex = ((int)(resources.GetObject("btnOpenProjectForm.ButtonElement.ImageIndex1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenProjectForm.GetChildAt(2))).ImageKey = resources.GetString("btnOpenProjectForm.ButtonElement.ImageKey1");
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenProjectForm.GetChildAt(2))).TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("btnOpenProjectForm.ButtonElement.TextOrientation1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenProjectForm.GetChildAt(2))).FlipText = ((bool)(resources.GetObject("btnOpenProjectForm.ButtonElement.FlipText1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenProjectForm.GetChildAt(2))).Padding = ((System.Windows.Forms.Padding)(resources.GetObject("btnOpenProjectForm.ButtonElement.Padding1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenProjectForm.GetChildAt(2))).Margin = ((System.Windows.Forms.Padding)(resources.GetObject("btnOpenProjectForm.ButtonElement.Margin1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenProjectForm.GetChildAt(2))).Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("btnOpenProjectForm.ButtonElement.Alignment1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenProjectForm.GetChildAt(2))).RightToLeft = ((bool)(resources.GetObject("btnOpenProjectForm.ButtonElement.RightToLeft1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenProjectForm.GetChildAt(2))).AngleTransform = ((float)(resources.GetObject("btnOpenProjectForm.ButtonElement.AngleTransform1")));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnOpenProjectForm.GetChildAt(2).GetChildAt(2))).Width = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnOpenProjectForm.GetChildAt(2).GetChildAt(2))).LeftWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnOpenProjectForm.GetChildAt(2).GetChildAt(2))).TopWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnOpenProjectForm.GetChildAt(2).GetChildAt(2))).RightWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnOpenProjectForm.GetChildAt(2).GetChildAt(2))).BottomWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnOpenProjectForm.GetChildAt(2).GetChildAt(2))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            // 
            // btnOpenItemForm
            // 
            resources.ApplyResources(this.btnOpenItemForm, "btnOpenItemForm");
            // 
            // 
            // 
            this.btnOpenItemForm.ButtonElement.Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("btnOpenItemForm.ButtonElement.Alignment")));
            this.btnOpenItemForm.ButtonElement.AngleTransform = ((float)(resources.GetObject("btnOpenItemForm.ButtonElement.AngleTransform")));
            this.btnOpenItemForm.ButtonElement.FlipText = ((bool)(resources.GetObject("btnOpenItemForm.ButtonElement.FlipText")));
            this.btnOpenItemForm.ButtonElement.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenItemForm.ButtonElement.Image")));
            this.btnOpenItemForm.ButtonElement.ImageIndex = ((int)(resources.GetObject("btnOpenItemForm.ButtonElement.ImageIndex")));
            this.btnOpenItemForm.ButtonElement.ImageKey = resources.GetString("btnOpenItemForm.ButtonElement.ImageKey");
            this.btnOpenItemForm.ButtonElement.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("btnOpenItemForm.ButtonElement.Margin")));
            this.btnOpenItemForm.ButtonElement.Padding = ((System.Windows.Forms.Padding)(resources.GetObject("btnOpenItemForm.ButtonElement.Padding")));
            this.btnOpenItemForm.ButtonElement.RightToLeft = ((bool)(resources.GetObject("btnOpenItemForm.ButtonElement.RightToLeft")));
            this.btnOpenItemForm.ButtonElement.TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("btnOpenItemForm.ButtonElement.TextOrientation")));
            this.btnOpenItemForm.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.btnOpenItemForm.Image = global::Scan_Project.Properties.Resources.list_interface_symbol;
            this.btnOpenItemForm.Name = "btnOpenItemForm";
            this.btnOpenItemForm.Click += new System.EventHandler(this.btnOpenItemForm_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenItemForm.GetChildAt(2))).Image = ((System.Drawing.Image)(resources.GetObject("btnOpenItemForm.ButtonElement.Image1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenItemForm.GetChildAt(2))).ImageIndex = ((int)(resources.GetObject("btnOpenItemForm.ButtonElement.ImageIndex1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenItemForm.GetChildAt(2))).ImageKey = resources.GetString("btnOpenItemForm.ButtonElement.ImageKey1");
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenItemForm.GetChildAt(2))).TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("btnOpenItemForm.ButtonElement.TextOrientation1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenItemForm.GetChildAt(2))).FlipText = ((bool)(resources.GetObject("btnOpenItemForm.ButtonElement.FlipText1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenItemForm.GetChildAt(2))).Padding = ((System.Windows.Forms.Padding)(resources.GetObject("btnOpenItemForm.ButtonElement.Padding1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenItemForm.GetChildAt(2))).Margin = ((System.Windows.Forms.Padding)(resources.GetObject("btnOpenItemForm.ButtonElement.Margin1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenItemForm.GetChildAt(2))).Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("btnOpenItemForm.ButtonElement.Alignment1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenItemForm.GetChildAt(2))).RightToLeft = ((bool)(resources.GetObject("btnOpenItemForm.ButtonElement.RightToLeft1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenItemForm.GetChildAt(2))).AngleTransform = ((float)(resources.GetObject("btnOpenItemForm.ButtonElement.AngleTransform1")));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnOpenItemForm.GetChildAt(2).GetChildAt(2))).Width = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnOpenItemForm.GetChildAt(2).GetChildAt(2))).LeftWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnOpenItemForm.GetChildAt(2).GetChildAt(2))).TopWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnOpenItemForm.GetChildAt(2).GetChildAt(2))).RightWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnOpenItemForm.GetChildAt(2).GetChildAt(2))).BottomWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnOpenItemForm.GetChildAt(2).GetChildAt(2))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            // 
            // btnOpenUserForm
            // 
            resources.ApplyResources(this.btnOpenUserForm, "btnOpenUserForm");
            // 
            // 
            // 
            this.btnOpenUserForm.ButtonElement.Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("btnOpenUserForm.ButtonElement.Alignment")));
            this.btnOpenUserForm.ButtonElement.AngleTransform = ((float)(resources.GetObject("btnOpenUserForm.ButtonElement.AngleTransform")));
            this.btnOpenUserForm.ButtonElement.FlipText = ((bool)(resources.GetObject("btnOpenUserForm.ButtonElement.FlipText")));
            this.btnOpenUserForm.ButtonElement.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenUserForm.ButtonElement.Image")));
            this.btnOpenUserForm.ButtonElement.ImageIndex = ((int)(resources.GetObject("btnOpenUserForm.ButtonElement.ImageIndex")));
            this.btnOpenUserForm.ButtonElement.ImageKey = resources.GetString("btnOpenUserForm.ButtonElement.ImageKey");
            this.btnOpenUserForm.ButtonElement.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("btnOpenUserForm.ButtonElement.Margin")));
            this.btnOpenUserForm.ButtonElement.Padding = ((System.Windows.Forms.Padding)(resources.GetObject("btnOpenUserForm.ButtonElement.Padding")));
            this.btnOpenUserForm.ButtonElement.RightToLeft = ((bool)(resources.GetObject("btnOpenUserForm.ButtonElement.RightToLeft")));
            this.btnOpenUserForm.ButtonElement.TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("btnOpenUserForm.ButtonElement.TextOrientation")));
            this.btnOpenUserForm.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.btnOpenUserForm.Image = global::Scan_Project.Properties.Resources.user;
            this.btnOpenUserForm.Name = "btnOpenUserForm";
            this.btnOpenUserForm.Click += new System.EventHandler(this.btnOpenUserForm_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenUserForm.GetChildAt(2))).Image = ((System.Drawing.Image)(resources.GetObject("btnOpenUserForm.ButtonElement.Image1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenUserForm.GetChildAt(2))).ImageIndex = ((int)(resources.GetObject("btnOpenUserForm.ButtonElement.ImageIndex1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenUserForm.GetChildAt(2))).ImageKey = resources.GetString("btnOpenUserForm.ButtonElement.ImageKey1");
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenUserForm.GetChildAt(2))).TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("btnOpenUserForm.ButtonElement.TextOrientation1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenUserForm.GetChildAt(2))).FlipText = ((bool)(resources.GetObject("btnOpenUserForm.ButtonElement.FlipText1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenUserForm.GetChildAt(2))).Padding = ((System.Windows.Forms.Padding)(resources.GetObject("btnOpenUserForm.ButtonElement.Padding1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenUserForm.GetChildAt(2))).Margin = ((System.Windows.Forms.Padding)(resources.GetObject("btnOpenUserForm.ButtonElement.Margin1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenUserForm.GetChildAt(2))).Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("btnOpenUserForm.ButtonElement.Alignment1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenUserForm.GetChildAt(2))).RightToLeft = ((bool)(resources.GetObject("btnOpenUserForm.ButtonElement.RightToLeft1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenUserForm.GetChildAt(2))).AngleTransform = ((float)(resources.GetObject("btnOpenUserForm.ButtonElement.AngleTransform1")));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnOpenUserForm.GetChildAt(2).GetChildAt(2))).Width = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnOpenUserForm.GetChildAt(2).GetChildAt(2))).LeftWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnOpenUserForm.GetChildAt(2).GetChildAt(2))).TopWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnOpenUserForm.GetChildAt(2).GetChildAt(2))).RightWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnOpenUserForm.GetChildAt(2).GetChildAt(2))).BottomWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnOpenUserForm.GetChildAt(2).GetChildAt(2))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            // 
            // btnOpenChangePasswordForm
            // 
            resources.ApplyResources(this.btnOpenChangePasswordForm, "btnOpenChangePasswordForm");
            // 
            // 
            // 
            this.btnOpenChangePasswordForm.ButtonElement.Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("btnOpenChangePasswordForm.ButtonElement.Alignment")));
            this.btnOpenChangePasswordForm.ButtonElement.AngleTransform = ((float)(resources.GetObject("btnOpenChangePasswordForm.ButtonElement.AngleTransform")));
            this.btnOpenChangePasswordForm.ButtonElement.FlipText = ((bool)(resources.GetObject("btnOpenChangePasswordForm.ButtonElement.FlipText")));
            this.btnOpenChangePasswordForm.ButtonElement.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenChangePasswordForm.ButtonElement.Image")));
            this.btnOpenChangePasswordForm.ButtonElement.ImageIndex = ((int)(resources.GetObject("btnOpenChangePasswordForm.ButtonElement.ImageIndex")));
            this.btnOpenChangePasswordForm.ButtonElement.ImageKey = resources.GetString("btnOpenChangePasswordForm.ButtonElement.ImageKey");
            this.btnOpenChangePasswordForm.ButtonElement.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("btnOpenChangePasswordForm.ButtonElement.Margin")));
            this.btnOpenChangePasswordForm.ButtonElement.Padding = ((System.Windows.Forms.Padding)(resources.GetObject("btnOpenChangePasswordForm.ButtonElement.Padding")));
            this.btnOpenChangePasswordForm.ButtonElement.RightToLeft = ((bool)(resources.GetObject("btnOpenChangePasswordForm.ButtonElement.RightToLeft")));
            this.btnOpenChangePasswordForm.ButtonElement.TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("btnOpenChangePasswordForm.ButtonElement.TextOrientation")));
            this.btnOpenChangePasswordForm.Image = global::Scan_Project.Properties.Resources.password;
            this.btnOpenChangePasswordForm.Name = "btnOpenChangePasswordForm";
            this.btnOpenChangePasswordForm.Click += new System.EventHandler(this.btnOpenChangePasswordForm_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenChangePasswordForm.GetChildAt(2))).Image = ((System.Drawing.Image)(resources.GetObject("btnOpenChangePasswordForm.ButtonElement.Image1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenChangePasswordForm.GetChildAt(2))).ImageIndex = ((int)(resources.GetObject("btnOpenChangePasswordForm.ButtonElement.ImageIndex1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenChangePasswordForm.GetChildAt(2))).ImageKey = resources.GetString("btnOpenChangePasswordForm.ButtonElement.ImageKey1");
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenChangePasswordForm.GetChildAt(2))).TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("btnOpenChangePasswordForm.ButtonElement.TextOrientation1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenChangePasswordForm.GetChildAt(2))).FlipText = ((bool)(resources.GetObject("btnOpenChangePasswordForm.ButtonElement.FlipText1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenChangePasswordForm.GetChildAt(2))).Padding = ((System.Windows.Forms.Padding)(resources.GetObject("btnOpenChangePasswordForm.ButtonElement.Padding1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenChangePasswordForm.GetChildAt(2))).Margin = ((System.Windows.Forms.Padding)(resources.GetObject("btnOpenChangePasswordForm.ButtonElement.Margin1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenChangePasswordForm.GetChildAt(2))).Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("btnOpenChangePasswordForm.ButtonElement.Alignment1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenChangePasswordForm.GetChildAt(2))).RightToLeft = ((bool)(resources.GetObject("btnOpenChangePasswordForm.ButtonElement.RightToLeft1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenChangePasswordForm.GetChildAt(2))).AngleTransform = ((float)(resources.GetObject("btnOpenChangePasswordForm.ButtonElement.AngleTransform1")));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnOpenChangePasswordForm.GetChildAt(2).GetChildAt(2))).Width = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnOpenChangePasswordForm.GetChildAt(2).GetChildAt(2))).LeftWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnOpenChangePasswordForm.GetChildAt(2).GetChildAt(2))).TopWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnOpenChangePasswordForm.GetChildAt(2).GetChildAt(2))).RightWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnOpenChangePasswordForm.GetChildAt(2).GetChildAt(2))).BottomWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnOpenChangePasswordForm.GetChildAt(2).GetChildAt(2))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            // 
            // radLabel6
            // 
            resources.ApplyResources(this.radLabel6, "radLabel6");
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.ThemeName = "TelerikMetro";
            // 
            // uname
            // 
            resources.ApplyResources(this.uname, "uname");
            this.uname.Name = "uname";
            this.uname.ThemeName = "TelerikMetro";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.radMenu1);
            this.Controls.Add(this.radPageView1);
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.ThemeName = "TelerikMetro";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.radPageView1.ResumeLayout(false);
            this.addDocsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmitDocs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNewDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddDocSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBrowseFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddDocSubmitDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAddDocs.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAddDocs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            this.radMenu1.ResumeLayout(false);
            this.radMenu1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadPageViewPage homePage;
        private Telerik.WinControls.UI.RadPageViewPage addDocsPage;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuButtonItem radMenuButtonItem1;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadLabelElement lblProjectName;
        private Telerik.WinControls.UI.RadMenuButtonItem btnOpenProjectForm;
        private Telerik.WinControls.UI.RadMenuButtonItem btnOpenItemForm;
        private Telerik.WinControls.UI.RadMenuButtonItem btnOpenUserForm;
        private Telerik.WinControls.UI.RadGridView gvAddDocs;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox txtAddItem2;
        private Telerik.WinControls.UI.RadTextBox txtAddDocSubmitDate;
        private Telerik.WinControls.UI.RadTextBox txtAddItem3;
        private Telerik.WinControls.UI.RadTextBox txtAddItem1;
        private Telerik.WinControls.UI.RadTextBox txtAddDocSrc;
        private Telerik.WinControls.UI.RadButton btnBrowseFile;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadButton btnEditDoc;
        private Telerik.WinControls.UI.RadButton btnSubmitDocs;
        private Telerik.WinControls.UI.RadButton btnAddNewDoc;
        private System.Windows.Forms.PictureBox docPicture;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Telerik.WinControls.UI.RadMenuButtonItem btnOpenChangePasswordForm;
        private Telerik.WinControls.UI.RadLabel uname;
        private Telerik.WinControls.UI.RadLabel radLabel6;
    }
}