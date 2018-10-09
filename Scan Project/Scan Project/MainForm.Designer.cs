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
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.radPageViewPage1 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage2 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.lblProjectName = new Telerik.WinControls.UI.RadLabelElement();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.radMenuButtonItem1 = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.btnOpenProjectForm = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.btnOpenItemForm = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.btnOpenUserForm = new Telerik.WinControls.UI.RadMenuButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPageView1
            // 
            resources.ApplyResources(this.radPageView1, "radPageView1");
            this.radPageView1.Controls.Add(this.radPageViewPage1);
            this.radPageView1.Controls.Add(this.radPageViewPage2);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.SelectedPage = this.radPageViewPage2;
            this.radPageView1.ThemeName = "TelerikMetro";
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).ItemAlignment = Telerik.WinControls.UI.StripViewItemAlignment.Near;
            // 
            // radPageViewPage1
            // 
            this.radPageViewPage1.Image = global::Scan_Project.Properties.Resources.home_2_;
            this.radPageViewPage1.ItemSize = new System.Drawing.SizeF(125F, 40F);
            resources.ApplyResources(this.radPageViewPage1, "radPageViewPage1");
            this.radPageViewPage1.Name = "radPageViewPage1";
            // 
            // radPageViewPage2
            // 
            this.radPageViewPage2.Image = global::Scan_Project.Properties.Resources.document_add_outlined_symbol;
            this.radPageViewPage2.ItemSize = new System.Drawing.SizeF(112F, 40F);
            resources.ApplyResources(this.radPageViewPage2, "radPageViewPage2");
            this.radPageViewPage2.Name = "radPageViewPage2";
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
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuButtonItem1,
            this.btnOpenProjectForm,
            this.btnOpenItemForm,
            this.btnOpenUserForm});
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
            this.radMenuButtonItem1.ButtonElement.ToolTipText = resources.GetString("radMenuButtonItem1.ButtonElement.ToolTipText");
            this.radMenuButtonItem1.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.radMenuButtonItem1.FocusBorderColor = System.Drawing.Color.Transparent;
            this.radMenuButtonItem1.Font = new System.Drawing.Font("IRANSans", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMenuButtonItem1.Image = global::Scan_Project.Properties.Resources.gears;
            this.radMenuButtonItem1.Name = "radMenuButtonItem1";
            this.radMenuButtonItem1.ShadowColor = System.Drawing.Color.White;
            this.radMenuButtonItem1.UseCompatibleTextRendering = false;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radMenuButtonItem1.GetChildAt(2))).Image = ((System.Drawing.Image)(resources.GetObject("radMenuButtonItem1.ButtonElement.Image")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.radMenuButtonItem1.GetChildAt(2))).ImageIndex = ((int)(resources.GetObject("radMenuButtonItem1.ButtonElement.ImageIndex")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.radMenuButtonItem1.GetChildAt(2))).ImageKey = resources.GetString("radMenuButtonItem1.ButtonElement.ImageKey");
            ((Telerik.WinControls.UI.RadButtonElement)(this.radMenuButtonItem1.GetChildAt(2))).TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("radMenuButtonItem1.ButtonElement.TextOrientation")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.radMenuButtonItem1.GetChildAt(2))).FlipText = ((bool)(resources.GetObject("radMenuButtonItem1.ButtonElement.FlipText")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.radMenuButtonItem1.GetChildAt(2))).ToolTipText = resources.GetString("radMenuButtonItem1.ButtonElement.ToolTipText");
            ((Telerik.WinControls.UI.RadButtonElement)(this.radMenuButtonItem1.GetChildAt(2))).Padding = ((System.Windows.Forms.Padding)(resources.GetObject("radMenuButtonItem1.ButtonElement.Padding")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.radMenuButtonItem1.GetChildAt(2))).Margin = ((System.Windows.Forms.Padding)(resources.GetObject("radMenuButtonItem1.ButtonElement.Margin")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.radMenuButtonItem1.GetChildAt(2))).Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("radMenuButtonItem1.ButtonElement.Alignment")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.radMenuButtonItem1.GetChildAt(2))).RightToLeft = ((bool)(resources.GetObject("radMenuButtonItem1.ButtonElement.RightToLeft")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.radMenuButtonItem1.GetChildAt(2))).AngleTransform = ((float)(resources.GetObject("radMenuButtonItem1.ButtonElement.AngleTransform")));
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
            this.btnOpenProjectForm.ButtonElement.ToolTipText = resources.GetString("btnOpenProjectForm.ButtonElement.ToolTipText");
            this.btnOpenProjectForm.Image = global::Scan_Project.Properties.Resources.tabs;
            this.btnOpenProjectForm.Name = "btnOpenProjectForm";
            this.btnOpenProjectForm.Click += new System.EventHandler(this.btnOpenProjectForm_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenProjectForm.GetChildAt(2))).Image = ((System.Drawing.Image)(resources.GetObject("btnOpenProjectForm.ButtonElement.Image")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenProjectForm.GetChildAt(2))).ImageIndex = ((int)(resources.GetObject("btnOpenProjectForm.ButtonElement.ImageIndex")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenProjectForm.GetChildAt(2))).ImageKey = resources.GetString("btnOpenProjectForm.ButtonElement.ImageKey");
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenProjectForm.GetChildAt(2))).TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("btnOpenProjectForm.ButtonElement.TextOrientation")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenProjectForm.GetChildAt(2))).FlipText = ((bool)(resources.GetObject("btnOpenProjectForm.ButtonElement.FlipText")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenProjectForm.GetChildAt(2))).ToolTipText = resources.GetString("btnOpenProjectForm.ButtonElement.ToolTipText");
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenProjectForm.GetChildAt(2))).Padding = ((System.Windows.Forms.Padding)(resources.GetObject("btnOpenProjectForm.ButtonElement.Padding")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenProjectForm.GetChildAt(2))).Margin = ((System.Windows.Forms.Padding)(resources.GetObject("btnOpenProjectForm.ButtonElement.Margin")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenProjectForm.GetChildAt(2))).Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("btnOpenProjectForm.ButtonElement.Alignment")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenProjectForm.GetChildAt(2))).RightToLeft = ((bool)(resources.GetObject("btnOpenProjectForm.ButtonElement.RightToLeft")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenProjectForm.GetChildAt(2))).AngleTransform = ((float)(resources.GetObject("btnOpenProjectForm.ButtonElement.AngleTransform")));
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
            this.btnOpenItemForm.ButtonElement.ToolTipText = resources.GetString("btnOpenItemForm.ButtonElement.ToolTipText");
            this.btnOpenItemForm.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.btnOpenItemForm.Image = global::Scan_Project.Properties.Resources.list_interface_symbol;
            this.btnOpenItemForm.Name = "btnOpenItemForm";
            this.btnOpenItemForm.Click += new System.EventHandler(this.btnOpenItemForm_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenItemForm.GetChildAt(2))).Image = ((System.Drawing.Image)(resources.GetObject("btnOpenItemForm.ButtonElement.Image")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenItemForm.GetChildAt(2))).ImageIndex = ((int)(resources.GetObject("btnOpenItemForm.ButtonElement.ImageIndex")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenItemForm.GetChildAt(2))).ImageKey = resources.GetString("btnOpenItemForm.ButtonElement.ImageKey");
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenItemForm.GetChildAt(2))).TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("btnOpenItemForm.ButtonElement.TextOrientation")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenItemForm.GetChildAt(2))).FlipText = ((bool)(resources.GetObject("btnOpenItemForm.ButtonElement.FlipText")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenItemForm.GetChildAt(2))).ToolTipText = resources.GetString("btnOpenItemForm.ButtonElement.ToolTipText");
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenItemForm.GetChildAt(2))).Padding = ((System.Windows.Forms.Padding)(resources.GetObject("btnOpenItemForm.ButtonElement.Padding")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenItemForm.GetChildAt(2))).Margin = ((System.Windows.Forms.Padding)(resources.GetObject("btnOpenItemForm.ButtonElement.Margin")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenItemForm.GetChildAt(2))).Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("btnOpenItemForm.ButtonElement.Alignment")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenItemForm.GetChildAt(2))).RightToLeft = ((bool)(resources.GetObject("btnOpenItemForm.ButtonElement.RightToLeft")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenItemForm.GetChildAt(2))).AngleTransform = ((float)(resources.GetObject("btnOpenItemForm.ButtonElement.AngleTransform")));
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
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenUserForm.GetChildAt(2))).Image = ((System.Drawing.Image)(resources.GetObject("btnOpenUserForm.ButtonElement.Image")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenUserForm.GetChildAt(2))).ImageIndex = ((int)(resources.GetObject("btnOpenUserForm.ButtonElement.ImageIndex")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenUserForm.GetChildAt(2))).ImageKey = resources.GetString("btnOpenUserForm.ButtonElement.ImageKey");
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenUserForm.GetChildAt(2))).TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("btnOpenUserForm.ButtonElement.TextOrientation")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenUserForm.GetChildAt(2))).FlipText = ((bool)(resources.GetObject("btnOpenUserForm.ButtonElement.FlipText")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenUserForm.GetChildAt(2))).Padding = ((System.Windows.Forms.Padding)(resources.GetObject("btnOpenUserForm.ButtonElement.Padding")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenUserForm.GetChildAt(2))).Margin = ((System.Windows.Forms.Padding)(resources.GetObject("btnOpenUserForm.ButtonElement.Margin")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenUserForm.GetChildAt(2))).Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("btnOpenUserForm.ButtonElement.Alignment")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenUserForm.GetChildAt(2))).RightToLeft = ((bool)(resources.GetObject("btnOpenUserForm.ButtonElement.RightToLeft")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnOpenUserForm.GetChildAt(2))).AngleTransform = ((float)(resources.GetObject("btnOpenUserForm.ButtonElement.AngleTransform")));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnOpenUserForm.GetChildAt(2).GetChildAt(2))).Width = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnOpenUserForm.GetChildAt(2).GetChildAt(2))).LeftWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnOpenUserForm.GetChildAt(2).GetChildAt(2))).TopWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnOpenUserForm.GetChildAt(2).GetChildAt(2))).RightWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnOpenUserForm.GetChildAt(2).GetChildAt(2))).BottomWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnOpenUserForm.GetChildAt(2).GetChildAt(2))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
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
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage2;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuButtonItem radMenuButtonItem1;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadLabelElement lblProjectName;
        private Telerik.WinControls.UI.RadMenuButtonItem btnOpenProjectForm;
        private Telerik.WinControls.UI.RadMenuButtonItem btnOpenItemForm;
        private Telerik.WinControls.UI.RadMenuButtonItem btnOpenUserForm;
    }
}