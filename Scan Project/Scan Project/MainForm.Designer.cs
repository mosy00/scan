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
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.radMenuButtonItem1 = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.lblProjectName = new Telerik.WinControls.UI.RadLabelElement();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPageView1
            // 
            resources.ApplyResources(this.radPageView1, "radPageView1");
            this.radPageView1.Controls.Add(this.radPageViewPage1);
            this.radPageView1.Controls.Add(this.radPageViewPage2);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.SelectedPage = this.radPageViewPage1;
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
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuButtonItem1});
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
            ((Telerik.WinControls.UI.RadButtonElement)(this.radMenuButtonItem1.GetChildAt(2))).Image = ((System.Drawing.Image)(resources.GetObject("radMenuButtonItem1.ButtonElement.Image1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.radMenuButtonItem1.GetChildAt(2))).ImageIndex = ((int)(resources.GetObject("radMenuButtonItem1.ButtonElement.ImageIndex1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.radMenuButtonItem1.GetChildAt(2))).ImageKey = resources.GetString("radMenuButtonItem1.ButtonElement.ImageKey1");
            ((Telerik.WinControls.UI.RadButtonElement)(this.radMenuButtonItem1.GetChildAt(2))).TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("radMenuButtonItem1.ButtonElement.TextOrientation1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.radMenuButtonItem1.GetChildAt(2))).FlipText = ((bool)(resources.GetObject("radMenuButtonItem1.ButtonElement.FlipText1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.radMenuButtonItem1.GetChildAt(2))).ToolTipText = resources.GetString("radMenuButtonItem1.ButtonElement.ToolTipText1");
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
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
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
    }
}