namespace MongoPro.Forms
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            this.panelLeft = new DevExpress.XtraEditors.PanelControl();
            this.panelAbout = new DevExpress.XtraEditors.PanelControl();
            this.labelAbout = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelRight = new DevExpress.XtraEditors.PanelControl();
            this.labelExample2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelExample = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelInfo = new DevExpress.XtraEditors.PanelControl();
            this.labelDetail = new DevExpress.XtraEditors.LabelControl();
            this.labelSomeInfo = new DevExpress.XtraEditors.LabelControl();
            this.panelBack = new DevExpress.XtraEditors.PanelControl();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.panelMain = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelLeft)).BeginInit();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelAbout)).BeginInit();
            this.panelAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelRight)).BeginInit();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelInfo)).BeginInit();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelBack)).BeginInit();
            this.panelBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelLeft.Appearance.Options.UseBackColor = true;
            this.panelLeft.Controls.Add(this.panelMain);
            this.panelLeft.Controls.Add(this.panelAbout);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(201, 2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(547, 560);
            this.panelLeft.TabIndex = 3;
            // 
            // panelAbout
            // 
            this.panelAbout.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(74)))));
            this.panelAbout.Appearance.Options.UseBackColor = true;
            this.panelAbout.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelAbout.Controls.Add(this.labelAbout);
            this.panelAbout.Controls.Add(this.labelControl1);
            this.panelAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAbout.Location = new System.Drawing.Point(2, 2);
            this.panelAbout.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelAbout.Name = "panelAbout";
            this.panelAbout.Size = new System.Drawing.Size(543, 63);
            this.panelAbout.TabIndex = 0;
            // 
            // labelAbout
            // 
            this.labelAbout.ImageOptions.Image = global::MongoPro.Properties.Resources.technology_32x32;
            this.labelAbout.Location = new System.Drawing.Point(122, 20);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(32, 32);
            this.labelAbout.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(32, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "MongoPro";
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.labelExample2);
            this.panelRight.Controls.Add(this.labelControl3);
            this.panelRight.Controls.Add(this.labelExample);
            this.panelRight.Controls.Add(this.labelControl2);
            this.panelRight.Controls.Add(this.panelInfo);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRight.Location = new System.Drawing.Point(2, 2);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(199, 560);
            this.panelRight.TabIndex = 4;
            // 
            // labelExample2
            // 
            this.labelExample2.AllowHtmlString = true;
            this.labelExample2.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.labelExample2.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelExample2.Appearance.Options.UseFont = true;
            this.labelExample2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelExample2.Location = new System.Drawing.Point(16, 228);
            this.labelExample2.Name = "labelExample2";
            this.labelExample2.Size = new System.Drawing.Size(149, 13);
            this.labelExample2.TabIndex = 5;
            this.labelExample2.Text = "See example";
            // 
            // labelControl3
            // 
            this.labelControl3.AllowHtmlString = true;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl3.Location = new System.Drawing.Point(16, 194);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(172, 28);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "How do I find my connectionstring in Atlas?";
            // 
            // labelExample
            // 
            this.labelExample.AllowHtmlString = true;
            this.labelExample.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.labelExample.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelExample.Appearance.Options.UseFont = true;
            this.labelExample.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelExample.Location = new System.Drawing.Point(16, 161);
            this.labelExample.Name = "labelExample";
            this.labelExample.Size = new System.Drawing.Size(149, 13);
            this.labelExample.TabIndex = 3;
            this.labelExample.Text = "See example";
            // 
            // labelControl2
            // 
            this.labelControl2.AllowHtmlString = true;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl2.Location = new System.Drawing.Point(16, 127);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(172, 28);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "How do I format my connection string?";
            // 
            // panelInfo
            // 
            this.panelInfo.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(252)))), ((int)(((byte)(247)))));
            this.panelInfo.Appearance.Options.UseBackColor = true;
            this.panelInfo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelInfo.Controls.Add(this.labelDetail);
            this.panelInfo.Controls.Add(this.labelSomeInfo);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(2, 2);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(195, 95);
            this.panelInfo.TabIndex = 0;
            // 
            // labelDetail
            // 
            this.labelDetail.AllowHtmlString = true;
            this.labelDetail.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.labelDetail.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelDetail.Appearance.Options.UseFont = true;
            this.labelDetail.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelDetail.Location = new System.Drawing.Point(14, 37);
            this.labelDetail.Name = "labelDetail";
            this.labelDetail.Size = new System.Drawing.Size(149, 39);
            this.labelDetail.TabIndex = 2;
            this.labelDetail.Text = "If you don\'t know how to use it yet, check out the related readme file";
            // 
            // labelSomeInfo
            // 
            this.labelSomeInfo.AllowHtmlString = true;
            this.labelSomeInfo.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelSomeInfo.Appearance.Options.UseFont = true;
            this.labelSomeInfo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelSomeInfo.Location = new System.Drawing.Point(14, 10);
            this.labelSomeInfo.Name = "labelSomeInfo";
            this.labelSomeInfo.Size = new System.Drawing.Size(172, 14);
            this.labelSomeInfo.TabIndex = 1;
            this.labelSomeInfo.Text = "Welcome to MongoPro!";
            // 
            // panelBack
            // 
            this.panelBack.Appearance.Options.UseBackColor = true;
            this.panelBack.Controls.Add(this.panelLeft);
            this.panelBack.Controls.Add(this.panelRight);
            this.panelBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBack.Location = new System.Drawing.Point(0, 0);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(750, 564);
            this.panelBack.TabIndex = 5;
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "DevExpress Style";
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(2, 65);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(543, 493);
            this.panelMain.TabIndex = 1;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 564);
            this.Controls.Add(this.panelBack);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MongoPro";
            ((System.ComponentModel.ISupportInitialize)(this.panelLeft)).EndInit();
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelAbout)).EndInit();
            this.panelAbout.ResumeLayout(false);
            this.panelAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelRight)).EndInit();
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelInfo)).EndInit();
            this.panelInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelBack)).EndInit();
            this.panelBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelLeft;
        private DevExpress.XtraEditors.PanelControl panelAbout;
        private DevExpress.XtraEditors.LabelControl labelAbout;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelRight;
        private DevExpress.XtraEditors.LabelControl labelExample2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelExample;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelInfo;
        private DevExpress.XtraEditors.LabelControl labelDetail;
        private DevExpress.XtraEditors.LabelControl labelSomeInfo;
        private DevExpress.XtraEditors.PanelControl panelBack;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        private DevExpress.XtraEditors.PanelControl panelMain;
    }
}