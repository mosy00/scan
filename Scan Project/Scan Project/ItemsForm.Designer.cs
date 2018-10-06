namespace Scan_Project
{
    partial class ItemsForm
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
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.radTextBox2 = new Telerik.WinControls.UI.RadTextBox();
            this.radTextBox3 = new Telerik.WinControls.UI.RadTextBox();
            this.btnOK = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radTextBox1
            // 
            this.radTextBox1.Location = new System.Drawing.Point(12, 33);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.NullText = "نام شاخص اول";
            this.radTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radTextBox1.ShowNullText = true;
            this.radTextBox1.Size = new System.Drawing.Size(200, 24);
            this.radTextBox1.TabIndex = 0;
            this.radTextBox1.ThemeName = "TelerikMetro";
            // 
            // radTextBox2
            // 
            this.radTextBox2.Location = new System.Drawing.Point(12, 75);
            this.radTextBox2.Name = "radTextBox2";
            this.radTextBox2.NullText = "نام شاخص دوم";
            this.radTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radTextBox2.ShowNullText = true;
            this.radTextBox2.Size = new System.Drawing.Size(200, 24);
            this.radTextBox2.TabIndex = 1;
            this.radTextBox2.ThemeName = "TelerikMetro";
            // 
            // radTextBox3
            // 
            this.radTextBox3.Location = new System.Drawing.Point(12, 117);
            this.radTextBox3.Name = "radTextBox3";
            this.radTextBox3.NullText = "نام شاخص سوم";
            this.radTextBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radTextBox3.ShowNullText = true;
            this.radTextBox3.Size = new System.Drawing.Size(200, 24);
            this.radTextBox3.TabIndex = 2;
            this.radTextBox3.ThemeName = "TelerikMetro";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(12, 159);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(94, 31);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "ثبت";
            this.btnOK.ThemeName = "TelerikMetro";
            // 
            // ItemsForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 201);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.radTextBox3);
            this.Controls.Add(this.radTextBox2);
            this.Controls.Add(this.radTextBox1);
            this.Font = new System.Drawing.Font("IRANSans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ItemsForm";
            this.RightToLeftLayout = true;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemsForm";
            this.ThemeName = "TelerikMetro";
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadTextBox radTextBox2;
        private Telerik.WinControls.UI.RadTextBox radTextBox3;
        private Telerik.WinControls.UI.RadButton btnOK;
    }
}
