namespace MongoPro.Forms
{
    partial class ConnectionForm
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
            this.labelConn = new DevExpress.XtraEditors.LabelControl();
            this.labelConnDescription = new DevExpress.XtraEditors.LabelControl();
            this.textEditUri = new DevExpress.XtraEditors.TextEdit();
            this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelHost = new DevExpress.XtraEditors.LabelControl();
            this.textEditHost = new DevExpress.XtraEditors.TextEdit();
            this.labelUsername = new DevExpress.XtraEditors.LabelControl();
            this.labelPassword = new DevExpress.XtraEditors.LabelControl();
            this.textEditUsername = new DevExpress.XtraEditors.TextEdit();
            this.textEditPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEditDb = new DevExpress.XtraEditors.TextEdit();
            this.labelURI = new DevExpress.XtraEditors.LabelControl();
            this.btnTry = new DevExpress.XtraEditors.SimpleButton();
            this.btnConnect = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.radioButtonDefault = new System.Windows.Forms.RadioButton();
            this.radioButtonSHA1 = new System.Windows.Forms.RadioButton();
            this.radioButtonSHA256 = new System.Windows.Forms.RadioButton();
            this.mvvmContextLogin = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.textEditUri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditHost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContextLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // labelConn
            // 
            this.labelConn.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelConn.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelConn.Appearance.Options.UseFont = true;
            this.labelConn.Appearance.Options.UseForeColor = true;
            this.labelConn.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelConn.Location = new System.Drawing.Point(22, 12);
            this.labelConn.Name = "labelConn";
            this.labelConn.Size = new System.Drawing.Size(183, 23);
            this.labelConn.TabIndex = 1;
            this.labelConn.Text = "New Connection";
            // 
            // labelConnDescription
            // 
            this.labelConnDescription.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelConnDescription.Appearance.Options.UseForeColor = true;
            this.labelConnDescription.Location = new System.Drawing.Point(22, 41);
            this.labelConnDescription.Name = "labelConnDescription";
            this.labelConnDescription.Size = new System.Drawing.Size(214, 14);
            this.labelConnDescription.TabIndex = 2;
            this.labelConnDescription.Text = "Connect to a MongoDB Deployment....";
            // 
            // textEditUri
            // 
            this.textEditUri.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.False;
            this.textEditUri.EditValue = "mongodb://localhost:27017";
            this.textEditUri.Enabled = false;
            this.textEditUri.Location = new System.Drawing.Point(22, 95);
            this.textEditUri.Name = "textEditUri";
            this.textEditUri.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.textEditUri.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textEditUri.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(151)))));
            this.textEditUri.Properties.Appearance.Options.UseBackColor = true;
            this.textEditUri.Properties.Appearance.Options.UseFont = true;
            this.textEditUri.Properties.Appearance.Options.UseForeColor = true;
            this.textEditUri.Properties.Appearance.Options.UseTextOptions = true;
            this.textEditUri.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.textEditUri.Properties.AutoHeight = false;
            this.textEditUri.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textEditUri.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textEditUri.Size = new System.Drawing.Size(490, 96);
            this.textEditUri.TabIndex = 4;
            this.textEditUri.ToolTip = "连接 MongoDB 字符串";
            this.textEditUri.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.Location = new System.Drawing.Point(63, 70);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.toggleSwitch1.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitch1.Properties.LookAndFeel.SkinName = "The Bezier";
            this.toggleSwitch1.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.toggleSwitch1.Properties.OffText = "";
            this.toggleSwitch1.Properties.OnText = "";
            this.toggleSwitch1.Size = new System.Drawing.Size(58, 19);
            this.toggleSwitch1.TabIndex = 5;
            this.toggleSwitch1.EditValueChanged += new System.EventHandler(this.toggleSwitch1_EditValueChanged);
            // 
            // labelHost
            // 
            this.labelHost.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelHost.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelHost.Appearance.Options.UseFont = true;
            this.labelHost.Appearance.Options.UseForeColor = true;
            this.labelHost.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelHost.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelHost.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelHost.Location = new System.Drawing.Point(23, 206);
            this.labelHost.Name = "labelHost";
            this.labelHost.Size = new System.Drawing.Size(44, 19);
            this.labelHost.TabIndex = 6;
            this.labelHost.Text = "Host";
            // 
            // textEditHost
            // 
            this.textEditHost.Location = new System.Drawing.Point(121, 207);
            this.textEditHost.Name = "textEditHost";
            this.textEditHost.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.textEditHost.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textEditHost.Properties.Appearance.Options.UseBackColor = true;
            this.textEditHost.Properties.Appearance.Options.UseForeColor = true;
            this.textEditHost.Properties.NullText = "Optional";
            this.textEditHost.Size = new System.Drawing.Size(391, 20);
            this.textEditHost.TabIndex = 7;
            // 
            // labelUsername
            // 
            this.labelUsername.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelUsername.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelUsername.Appearance.Options.UseFont = true;
            this.labelUsername.Appearance.Options.UseForeColor = true;
            this.labelUsername.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelUsername.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelUsername.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelUsername.Location = new System.Drawing.Point(23, 248);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(92, 19);
            this.labelUsername.TabIndex = 8;
            this.labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelPassword.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelPassword.Appearance.Options.UseFont = true;
            this.labelPassword.Appearance.Options.UseForeColor = true;
            this.labelPassword.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelPassword.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelPassword.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelPassword.Location = new System.Drawing.Point(23, 288);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(76, 19);
            this.labelPassword.TabIndex = 9;
            this.labelPassword.Text = "Password";
            // 
            // textEditUsername
            // 
            this.textEditUsername.Location = new System.Drawing.Point(121, 249);
            this.textEditUsername.Name = "textEditUsername";
            this.textEditUsername.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.textEditUsername.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textEditUsername.Properties.Appearance.Options.UseBackColor = true;
            this.textEditUsername.Properties.Appearance.Options.UseForeColor = true;
            this.textEditUsername.Properties.NullText = "Optional";
            this.textEditUsername.Size = new System.Drawing.Size(391, 20);
            this.textEditUsername.TabIndex = 10;
            // 
            // textEditPassword
            // 
            this.textEditPassword.Location = new System.Drawing.Point(121, 289);
            this.textEditPassword.Name = "textEditPassword";
            this.textEditPassword.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.textEditPassword.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textEditPassword.Properties.Appearance.Options.UseBackColor = true;
            this.textEditPassword.Properties.Appearance.Options.UseForeColor = true;
            this.textEditPassword.Properties.NullText = "Optional";
            this.textEditPassword.Size = new System.Drawing.Size(391, 20);
            this.textEditPassword.TabIndex = 11;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl1.Location = new System.Drawing.Point(22, 329);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 19);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Database";
            // 
            // textEditDb
            // 
            this.textEditDb.Location = new System.Drawing.Point(121, 330);
            this.textEditDb.Name = "textEditDb";
            this.textEditDb.Properties.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.textEditDb.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.textEditDb.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textEditDb.Properties.Appearance.Options.UseBackColor = true;
            this.textEditDb.Properties.Appearance.Options.UseForeColor = true;
            this.textEditDb.Properties.ContextImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.textEditDb.Properties.NullText = "Optional";
            this.textEditDb.Size = new System.Drawing.Size(391, 20);
            this.textEditDb.TabIndex = 13;
            // 
            // labelURI
            // 
            this.labelURI.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelURI.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelURI.Appearance.Options.UseFont = true;
            this.labelURI.Appearance.Options.UseForeColor = true;
            this.labelURI.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelURI.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelURI.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelURI.Location = new System.Drawing.Point(23, 70);
            this.labelURI.Name = "labelURI";
            this.labelURI.Size = new System.Drawing.Size(44, 19);
            this.labelURI.TabIndex = 3;
            this.labelURI.Text = "URI";
            // 
            // btnTry
            // 
            this.btnTry.Location = new System.Drawing.Point(287, 420);
            this.btnTry.Name = "btnTry";
            this.btnTry.Size = new System.Drawing.Size(97, 35);
            this.btnTry.TabIndex = 14;
            this.btnTry.Text = "Try";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(415, 420);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(97, 35);
            this.btnConnect.TabIndex = 15;
            this.btnConnect.Text = "Connect";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl2.Location = new System.Drawing.Point(22, 374);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(77, 19);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "Mechanism";
            // 
            // radioButtonDefault
            // 
            this.radioButtonDefault.AutoSize = true;
            this.radioButtonDefault.Checked = true;
            this.radioButtonDefault.Location = new System.Drawing.Point(122, 376);
            this.radioButtonDefault.Name = "radioButtonDefault";
            this.radioButtonDefault.Size = new System.Drawing.Size(64, 18);
            this.radioButtonDefault.TabIndex = 17;
            this.radioButtonDefault.TabStop = true;
            this.radioButtonDefault.Text = "Default";
            this.radioButtonDefault.UseVisualStyleBackColor = true;
            // 
            // radioButtonSHA1
            // 
            this.radioButtonSHA1.AutoSize = true;
            this.radioButtonSHA1.Location = new System.Drawing.Point(235, 376);
            this.radioButtonSHA1.Name = "radioButtonSHA1";
            this.radioButtonSHA1.Size = new System.Drawing.Size(101, 18);
            this.radioButtonSHA1.TabIndex = 18;
            this.radioButtonSHA1.Text = "SCRAM-SHA-1";
            this.radioButtonSHA1.UseVisualStyleBackColor = true;
            // 
            // radioButtonSHA256
            // 
            this.radioButtonSHA256.AutoSize = true;
            this.radioButtonSHA256.Location = new System.Drawing.Point(397, 376);
            this.radioButtonSHA256.Name = "radioButtonSHA256";
            this.radioButtonSHA256.Size = new System.Drawing.Size(115, 18);
            this.radioButtonSHA256.TabIndex = 19;
            this.radioButtonSHA256.Text = "SCRAM-SHA-256";
            this.radioButtonSHA256.UseVisualStyleBackColor = true;
            // 
            // mvvmContextLogin
            // 
            this.mvvmContextLogin.ContainerControl = this;
            // 
            // ConnectionForm
            // 
            this.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 479);
            this.Controls.Add(this.radioButtonSHA256);
            this.Controls.Add(this.radioButtonSHA1);
            this.Controls.Add(this.radioButtonDefault);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnTry);
            this.Controls.Add(this.textEditDb);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEditPassword);
            this.Controls.Add(this.textEditUsername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textEditHost);
            this.Controls.Add(this.labelHost);
            this.Controls.Add(this.toggleSwitch1);
            this.Controls.Add(this.textEditUri);
            this.Controls.Add(this.labelURI);
            this.Controls.Add(this.labelConnDescription);
            this.Controls.Add(this.labelConn);
            this.Name = "ConnectionForm";
            this.Text = "ConnectionForm";
            ((System.ComponentModel.ISupportInitialize)(this.textEditUri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditHost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContextLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelConn;
        private DevExpress.XtraEditors.LabelControl labelConnDescription;
        private DevExpress.XtraEditors.TextEdit textEditUri;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
        private DevExpress.XtraEditors.LabelControl labelHost;
        private DevExpress.XtraEditors.TextEdit textEditHost;
        private DevExpress.XtraEditors.LabelControl labelUsername;
        private DevExpress.XtraEditors.LabelControl labelPassword;
        private DevExpress.XtraEditors.TextEdit textEditUsername;
        private DevExpress.XtraEditors.TextEdit textEditPassword;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEditDb;
        private DevExpress.XtraEditors.LabelControl labelURI;
        private DevExpress.XtraEditors.SimpleButton btnTry;
        private DevExpress.XtraEditors.SimpleButton btnConnect;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.RadioButton radioButtonDefault;
        private System.Windows.Forms.RadioButton radioButtonSHA1;
        private System.Windows.Forms.RadioButton radioButtonSHA256;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContextLogin;
    }
}