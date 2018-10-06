namespace Scan_Project
{
    partial class ProjectForm
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
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.btnOK = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.projectList = new Telerik.WinControls.UI.RadDropDownList();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnCreate = new Telerik.WinControls.UI.RadButton();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.txtNewProject = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("IRANSans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(20, 85);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(105, 34);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "ادامه";
            this.btnOK.ThemeName = "TelerikMetro";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(207, 41);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(61, 25);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "نام پروژه: ";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.projectList);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.btnOK);
            this.radGroupBox1.Font = new System.Drawing.Font("IRANSans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox1.HeaderText = "انتخاب پروژه";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radGroupBox1.Size = new System.Drawing.Size(308, 130);
            this.radGroupBox1.TabIndex = 3;
            this.radGroupBox1.Text = "انتخاب پروژه";
            this.radGroupBox1.ThemeName = "TelerikMetro";
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).Text = "انتخاب پروژه";
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).Font = new System.Drawing.Font("IRANSans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // projectList
            // 
            this.projectList.Font = new System.Drawing.Font("IRANSans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectList.Location = new System.Drawing.Point(20, 42);
            this.projectList.Name = "projectList";
            this.projectList.Size = new System.Drawing.Size(181, 32);
            this.projectList.TabIndex = 3;
            this.projectList.ThemeName = "TelerikMetro";
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.projectList.GetChildAt(0))).RightToLeft = true;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.projectList.GetChildAt(0))).Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.projectList.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(0))).Font = new System.Drawing.Font("IRANSans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.btnCreate);
            this.radGroupBox2.Controls.Add(this.radLabel3);
            this.radGroupBox2.Controls.Add(this.txtNewProject);
            this.radGroupBox2.Font = new System.Drawing.Font("IRANSans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox2.HeaderText = "پروژه جدید";
            this.radGroupBox2.Location = new System.Drawing.Point(12, 148);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radGroupBox2.Size = new System.Drawing.Size(308, 130);
            this.radGroupBox2.TabIndex = 4;
            this.radGroupBox2.Text = "پروژه جدید";
            this.radGroupBox2.ThemeName = "TelerikMetro";
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radGroupBox2.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).Text = "پروژه جدید";
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radGroupBox2.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radGroupBox2.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).Font = new System.Drawing.Font("IRANSans", 11F);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radGroupBox2.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("IRANSans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(20, 86);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(105, 34);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "ایجاد پروژه";
            this.btnCreate.ThemeName = "TelerikMetro";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(207, 43);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(61, 25);
            this.radLabel3.TabIndex = 4;
            this.radLabel3.Text = "نام پروژه: ";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNewProject
            // 
            this.txtNewProject.Font = new System.Drawing.Font("IRANSans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewProject.Location = new System.Drawing.Point(20, 40);
            this.txtNewProject.Name = "txtNewProject";
            this.txtNewProject.Size = new System.Drawing.Size(181, 32);
            this.txtNewProject.TabIndex = 0;
            this.txtNewProject.ThemeName = "TelerikMetro";
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 291);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGroupBox1);
            this.Font = new System.Drawing.Font("IRANSans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ProjectForm";
            this.RightToLeftLayout = true;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم پروژه‌ها";
            this.ThemeName = "TelerikMetro";
            this.Load += new System.EventHandler(this.ProjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.UI.RadButton btnOK;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadTextBox txtNewProject;
        private Telerik.WinControls.UI.RadButton btnCreate;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadDropDownList projectList;
    }
}
