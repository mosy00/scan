namespace Scan_Project
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radLabelProductName = new Telerik.WinControls.UI.RadLabel();
            this.radLabelVersion = new Telerik.WinControls.UI.RadLabel();
            this.radLabelCopyright = new Telerik.WinControls.UI.RadLabel();
            this.radLabelCompanyName = new Telerik.WinControls.UI.RadLabel();
            this.radTextBoxDescription = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelProductName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelVersion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelCopyright)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelCompanyName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Scan_Project.Properties.Resources.Tis;
            this.pictureBox1.Location = new System.Drawing.Point(9, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // radLabelProductName
            // 
            this.radLabelProductName.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabelProductName.Location = new System.Drawing.Point(156, 12);
            this.radLabelProductName.Name = "radLabelProductName";
            this.radLabelProductName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabelProductName.Size = new System.Drawing.Size(66, 24);
            this.radLabelProductName.TabIndex = 1;
            this.radLabelProductName.Text = "radLabel1";
            this.radLabelProductName.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabelVersion
            // 
            this.radLabelVersion.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabelVersion.Location = new System.Drawing.Point(156, 42);
            this.radLabelVersion.Name = "radLabelVersion";
            this.radLabelVersion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabelVersion.Size = new System.Drawing.Size(66, 24);
            this.radLabelVersion.TabIndex = 2;
            this.radLabelVersion.Text = "radLabel1";
            this.radLabelVersion.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabelCopyright
            // 
            this.radLabelCopyright.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabelCopyright.Location = new System.Drawing.Point(156, 72);
            this.radLabelCopyright.Name = "radLabelCopyright";
            this.radLabelCopyright.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabelCopyright.Size = new System.Drawing.Size(66, 24);
            this.radLabelCopyright.TabIndex = 2;
            this.radLabelCopyright.Text = "radLabel1";
            this.radLabelCopyright.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabelCompanyName
            // 
            this.radLabelCompanyName.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabelCompanyName.Location = new System.Drawing.Point(156, 102);
            this.radLabelCompanyName.Name = "radLabelCompanyName";
            this.radLabelCompanyName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabelCompanyName.Size = new System.Drawing.Size(66, 24);
            this.radLabelCompanyName.TabIndex = 2;
            this.radLabelCompanyName.Text = "radLabel1";
            this.radLabelCompanyName.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radTextBoxDescription
            // 
            this.radTextBoxDescription.AutoSize = false;
            this.radTextBoxDescription.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radTextBoxDescription.Location = new System.Drawing.Point(156, 132);
            this.radTextBoxDescription.Multiline = true;
            this.radTextBoxDescription.Name = "radTextBoxDescription";
            this.radTextBoxDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radTextBoxDescription.Size = new System.Drawing.Size(178, 61);
            this.radTextBoxDescription.TabIndex = 3;
            this.radTextBoxDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.radTextBoxDescription.ThemeName = "TelerikMetro";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 202);
            this.Controls.Add(this.radTextBoxDescription);
            this.Controls.Add(this.radLabelCopyright);
            this.Controls.Add(this.radLabelCompanyName);
            this.Controls.Add(this.radLabelVersion);
            this.Controls.Add(this.radLabelProductName);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.RightToLeftLayout = true;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AboutForm";
            this.ThemeName = "TelerikMetro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelProductName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelVersion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelCopyright)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelCompanyName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadLabel radLabelProductName;
        private Telerik.WinControls.UI.RadLabel radLabelVersion;
        private Telerik.WinControls.UI.RadLabel radLabelCopyright;
        private Telerik.WinControls.UI.RadLabel radLabelCompanyName;
        private Telerik.WinControls.UI.RadTextBox radTextBoxDescription;
    }
}
