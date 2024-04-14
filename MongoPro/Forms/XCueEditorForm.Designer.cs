using DevExpress.LookAndFeel;

namespace MongoPro.Forms
{
    partial class XCueEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XCueEditorForm));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.treeListCommands = new DevExpress.XtraTreeList.TreeList();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gridControlFileInfos = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl7 = new DevExpress.XtraEditors.PanelControl();
            this.gridControlScript = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ScriptStatement = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.panelControl8 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.gridControlRow = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.RowNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ErrorDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            this.btnInsertBefore = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsertAfter = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteRow = new DevExpress.XtraEditors.SimpleButton();
            this.btnComment = new DevExpress.XtraEditors.SimpleButton();
            this.btnBlank = new DevExpress.XtraEditors.SimpleButton();
            this.btnMoveUp = new DevExpress.XtraEditors.SimpleButton();
            this.btnMoveDown = new DevExpress.XtraEditors.SimpleButton();
            this.btnConversion = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListCommands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFileInfos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).BeginInit();
            this.panelControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlScript)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl8)).BeginInit();
            this.panelControl8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).BeginInit();
            this.panelControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).BeginInit();
            this.stackPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "File";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Edit";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Setup";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "About";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.barDockControlTop.Size = new System.Drawing.Size(1111, 21);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 631);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.barDockControlBottom.Size = new System.Drawing.Size(1111, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 21);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 610);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1111, 21);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 610);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 21);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(449, 610);
            this.panelControl1.TabIndex = 4;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.treeListCommands);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(2, 16);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(445, 592);
            this.panelControl2.TabIndex = 1;
            // 
            // treeListCommands
            // 
            this.treeListCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListCommands.Location = new System.Drawing.Point(2, 2);
            this.treeListCommands.MenuManager = this.barManager1;
            this.treeListCommands.Name = "treeListCommands";
            this.treeListCommands.OptionsBehavior.Editable = false;
            this.treeListCommands.OptionsView.ShowColumns = false;
            this.treeListCommands.Size = new System.Drawing.Size(441, 434);
            this.treeListCommands.TabIndex = 5;
            this.treeListCommands.CustomDrawNodeCell += new DevExpress.XtraTreeList.CustomDrawNodeCellEventHandler(this.treeListCommands_CustomDrawNodeCell);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gridControlFileInfos);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(2, 436);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(441, 154);
            this.panelControl3.TabIndex = 0;
            // 
            // gridControlFileInfos
            // 
            this.gridControlFileInfos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlFileInfos.Location = new System.Drawing.Point(2, 2);
            this.gridControlFileInfos.MainView = this.gridView1;
            this.gridControlFileInfos.MenuManager = this.barManager1;
            this.gridControlFileInfos.Name = "gridControlFileInfos";
            this.gridControlFileInfos.Size = new System.Drawing.Size(437, 150);
            this.gridControlFileInfos.TabIndex = 0;
            this.gridControlFileInfos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(189)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(189)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(96)))), ((int)(((byte)(98)))));
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.ColumnPanelRowHeight = 0;
            this.gridView1.FooterPanelHeight = 0;
            this.gridView1.GridControl = this.gridControlFileInfos;
            this.gridView1.GroupRowHeight = 0;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.UseIndicatorForSelection = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.RowHeight = 0;
            this.gridView1.ViewCaptionHeight = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.AllowHtmlString = true;
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(96)))), ((int)(((byte)(98)))));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(2, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(445, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Script Command Set";
            // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.panelControl5);
            this.panelControl4.Controls.Add(this.stackPanel1);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(449, 21);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(662, 610);
            this.panelControl4.TabIndex = 10;
            // 
            // panelControl5
            // 
            this.panelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl5.Controls.Add(this.panelControl7);
            this.panelControl5.Controls.Add(this.panelControl6);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl5.Location = new System.Drawing.Point(99, 2);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(561, 606);
            this.panelControl5.TabIndex = 1;
            // 
            // panelControl7
            // 
            this.panelControl7.Appearance.BorderColor = System.Drawing.Color.Lime;
            this.panelControl7.Appearance.Options.UseBorderColor = true;
            this.panelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl7.Controls.Add(this.gridControlScript);
            this.panelControl7.Controls.Add(this.panelControl8);
            this.panelControl7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl7.Location = new System.Drawing.Point(0, 0);
            this.panelControl7.Name = "panelControl7";
            this.panelControl7.Size = new System.Drawing.Size(561, 436);
            this.panelControl7.TabIndex = 1;
            // 
            // gridControlScript
            // 
            this.gridControlScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlScript.Location = new System.Drawing.Point(2, 2);
            this.gridControlScript.MainView = this.gridView3;
            this.gridControlScript.MenuManager = this.barManager1;
            this.gridControlScript.Name = "gridControlScript";
            this.gridControlScript.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.gridControlScript.Size = new System.Drawing.Size(557, 400);
            this.gridControlScript.TabIndex = 1;
            this.gridControlScript.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(189)))), ((int)(((byte)(0)))));
            this.gridView3.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView3.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(189)))), ((int)(((byte)(0)))));
            this.gridView3.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView3.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(96)))), ((int)(((byte)(98)))));
            this.gridView3.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView3.ColumnPanelRowHeight = 0;
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ScriptStatement});
            this.gridView3.FooterPanelHeight = 0;
            this.gridView3.GridControl = this.gridControlScript;
            this.gridView3.GroupRowHeight = 0;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsView.RowAutoHeight = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            this.gridView3.RowHeight = 0;
            this.gridView3.ViewCaptionHeight = 0;
            this.gridView3.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView3_CustomDrawRowIndicator);
            // 
            // ScriptStatement
            // 
            this.ScriptStatement.AppearanceCell.Options.UseTextOptions = true;
            this.ScriptStatement.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ScriptStatement.Caption = "Script Statement";
            this.ScriptStatement.ColumnEdit = this.repositoryItemMemoEdit1;
            this.ScriptStatement.FieldName = "ScriptStatement";
            this.ScriptStatement.Name = "ScriptStatement";
            this.ScriptStatement.Visible = true;
            this.ScriptStatement.VisibleIndex = 0;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // panelControl8
            // 
            this.panelControl8.Controls.Add(this.labelControl2);
            this.panelControl8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl8.Location = new System.Drawing.Point(2, 402);
            this.panelControl8.Name = "panelControl8";
            this.panelControl8.Size = new System.Drawing.Size(557, 32);
            this.panelControl8.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.AllowHtmlString = true;
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl2.Location = new System.Drawing.Point(2, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(553, 32);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Successfully compiled at 5:15:03.6444 PM 2024-04-14";
            // 
            // panelControl6
            // 
            this.panelControl6.Controls.Add(this.gridControlRow);
            this.panelControl6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl6.Location = new System.Drawing.Point(0, 436);
            this.panelControl6.Name = "panelControl6";
            this.panelControl6.Size = new System.Drawing.Size(561, 170);
            this.panelControl6.TabIndex = 0;
            // 
            // gridControlRow
            // 
            this.gridControlRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlRow.Location = new System.Drawing.Point(2, 2);
            this.gridControlRow.MainView = this.gridView2;
            this.gridControlRow.MenuManager = this.barManager1;
            this.gridControlRow.Name = "gridControlRow";
            this.gridControlRow.Size = new System.Drawing.Size(557, 166);
            this.gridControlRow.TabIndex = 1;
            this.gridControlRow.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(189)))), ((int)(((byte)(0)))));
            this.gridView2.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(189)))), ((int)(((byte)(0)))));
            this.gridView2.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(96)))), ((int)(((byte)(98)))));
            this.gridView2.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView2.ColumnPanelRowHeight = 0;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.RowNo,
            this.ErrorDescription});
            this.gridView2.FooterPanelHeight = 0;
            this.gridView2.GridControl = this.gridControlRow;
            this.gridView2.GroupRowHeight = 0;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsSelection.UseIndicatorForSelection = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.OptionsView.ShowIndicator = false;
            this.gridView2.RowHeight = 0;
            this.gridView2.ViewCaptionHeight = 0;
            // 
            // RowNo
            // 
            this.RowNo.Caption = "Row No";
            this.RowNo.FieldName = "RowNo";
            this.RowNo.MaxWidth = 60;
            this.RowNo.Name = "RowNo";
            this.RowNo.Visible = true;
            this.RowNo.VisibleIndex = 0;
            this.RowNo.Width = 30;
            // 
            // ErrorDescription
            // 
            this.ErrorDescription.Caption = "Error Description";
            this.ErrorDescription.FieldName = "ErrorDescription";
            this.ErrorDescription.Name = "ErrorDescription";
            this.ErrorDescription.Visible = true;
            this.ErrorDescription.VisibleIndex = 1;
            // 
            // stackPanel1
            // 
            this.stackPanel1.Appearance.BorderColor = System.Drawing.Color.Lime;
            this.stackPanel1.Appearance.Options.UseBorderColor = true;
            this.stackPanel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.stackPanel1.Controls.Add(this.btnInsertBefore);
            this.stackPanel1.Controls.Add(this.btnInsertAfter);
            this.stackPanel1.Controls.Add(this.btnDeleteRow);
            this.stackPanel1.Controls.Add(this.btnComment);
            this.stackPanel1.Controls.Add(this.btnBlank);
            this.stackPanel1.Controls.Add(this.btnMoveUp);
            this.stackPanel1.Controls.Add(this.btnMoveDown);
            this.stackPanel1.Controls.Add(this.btnConversion);
            this.stackPanel1.Controls.Add(this.simpleButton1);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.stackPanel1.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.TopDown;
            this.stackPanel1.Location = new System.Drawing.Point(2, 2);
            this.stackPanel1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(97, 606);
            this.stackPanel1.TabIndex = 0;
            // 
            // btnInsertBefore
            // 
            this.btnInsertBefore.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnInsertBefore.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnInsertBefore.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnInsertBefore.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnInsertBefore.Appearance.Options.UseBackColor = true;
            this.btnInsertBefore.Appearance.Options.UseBorderColor = true;
            this.btnInsertBefore.Appearance.Options.UseFont = true;
            this.btnInsertBefore.Appearance.Options.UseForeColor = true;
            this.btnInsertBefore.Appearance.Options.UseImage = true;
            this.btnInsertBefore.Appearance.Options.UseTextOptions = true;
            this.btnInsertBefore.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnInsertBefore.ImageOptions.Image = global::MongoPro.Properties.Resources.redo_32x32;
            this.btnInsertBefore.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnInsertBefore.Location = new System.Drawing.Point(5, 3);
            this.btnInsertBefore.LookAndFeel.SkinMaskColor = System.Drawing.Color.Transparent;
            this.btnInsertBefore.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.Transparent;
            this.btnInsertBefore.LookAndFeel.SkinName = "London Liquid Sky";
            this.btnInsertBefore.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnInsertBefore.Name = "btnInsertBefore";
            this.btnInsertBefore.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnInsertBefore.Size = new System.Drawing.Size(87, 62);
            this.btnInsertBefore.TabIndex = 1;
            this.btnInsertBefore.Text = "Insert\nBefore";
            // 
            // btnInsertAfter
            // 
            this.btnInsertAfter.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnInsertAfter.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnInsertAfter.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnInsertAfter.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnInsertAfter.Appearance.Options.UseBackColor = true;
            this.btnInsertAfter.Appearance.Options.UseBorderColor = true;
            this.btnInsertAfter.Appearance.Options.UseFont = true;
            this.btnInsertAfter.Appearance.Options.UseForeColor = true;
            this.btnInsertAfter.Appearance.Options.UseImage = true;
            this.btnInsertAfter.Appearance.Options.UseTextOptions = true;
            this.btnInsertAfter.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnInsertAfter.ImageOptions.Image = global::MongoPro.Properties.Resources.undo_32x32;
            this.btnInsertAfter.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnInsertAfter.Location = new System.Drawing.Point(8, 71);
            this.btnInsertAfter.LookAndFeel.SkinMaskColor = System.Drawing.Color.Transparent;
            this.btnInsertAfter.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.Transparent;
            this.btnInsertAfter.LookAndFeel.SkinName = "London Liquid Sky";
            this.btnInsertAfter.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnInsertAfter.Name = "btnInsertAfter";
            this.btnInsertAfter.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnInsertAfter.Size = new System.Drawing.Size(81, 62);
            this.btnInsertAfter.TabIndex = 2;
            this.btnInsertAfter.Text = "Insert\nAfter";
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnDeleteRow.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnDeleteRow.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnDeleteRow.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteRow.Appearance.Options.UseBackColor = true;
            this.btnDeleteRow.Appearance.Options.UseBorderColor = true;
            this.btnDeleteRow.Appearance.Options.UseFont = true;
            this.btnDeleteRow.Appearance.Options.UseForeColor = true;
            this.btnDeleteRow.Appearance.Options.UseImage = true;
            this.btnDeleteRow.Appearance.Options.UseTextOptions = true;
            this.btnDeleteRow.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnDeleteRow.ImageOptions.Image = global::MongoPro.Properties.Resources.groupby_32x32;
            this.btnDeleteRow.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnDeleteRow.Location = new System.Drawing.Point(8, 139);
            this.btnDeleteRow.LookAndFeel.SkinMaskColor = System.Drawing.Color.Transparent;
            this.btnDeleteRow.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.Transparent;
            this.btnDeleteRow.LookAndFeel.SkinName = "London Liquid Sky";
            this.btnDeleteRow.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnDeleteRow.Size = new System.Drawing.Size(80, 62);
            this.btnDeleteRow.TabIndex = 3;
            this.btnDeleteRow.Text = "Delete\nRows";
            // 
            // btnComment
            // 
            this.btnComment.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnComment.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnComment.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnComment.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnComment.Appearance.Options.UseBackColor = true;
            this.btnComment.Appearance.Options.UseBorderColor = true;
            this.btnComment.Appearance.Options.UseFont = true;
            this.btnComment.Appearance.Options.UseForeColor = true;
            this.btnComment.Appearance.Options.UseImage = true;
            this.btnComment.Appearance.Options.UseTextOptions = true;
            this.btnComment.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnComment.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnComment.ImageOptions.Image")));
            this.btnComment.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnComment.Location = new System.Drawing.Point(10, 207);
            this.btnComment.LookAndFeel.SkinMaskColor = System.Drawing.Color.Transparent;
            this.btnComment.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.Transparent;
            this.btnComment.LookAndFeel.SkinName = "London Liquid Sky";
            this.btnComment.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnComment.Name = "btnComment";
            this.btnComment.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnComment.Size = new System.Drawing.Size(77, 62);
            this.btnComment.TabIndex = 4;
            this.btnComment.Text = "Comment";
            // 
            // btnBlank
            // 
            this.btnBlank.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnBlank.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnBlank.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnBlank.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnBlank.Appearance.Options.UseBackColor = true;
            this.btnBlank.Appearance.Options.UseBorderColor = true;
            this.btnBlank.Appearance.Options.UseFont = true;
            this.btnBlank.Appearance.Options.UseForeColor = true;
            this.btnBlank.Appearance.Options.UseImage = true;
            this.btnBlank.Appearance.Options.UseTextOptions = true;
            this.btnBlank.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnBlank.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBlank.ImageOptions.Image")));
            this.btnBlank.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnBlank.Location = new System.Drawing.Point(9, 275);
            this.btnBlank.LookAndFeel.SkinMaskColor = System.Drawing.Color.Transparent;
            this.btnBlank.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.Transparent;
            this.btnBlank.LookAndFeel.SkinName = "London Liquid Sky";
            this.btnBlank.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnBlank.Name = "btnBlank";
            this.btnBlank.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnBlank.Size = new System.Drawing.Size(78, 57);
            this.btnBlank.TabIndex = 5;
            this.btnBlank.Text = "Blank";
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnMoveUp.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnMoveUp.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnMoveUp.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnMoveUp.Appearance.Options.UseBackColor = true;
            this.btnMoveUp.Appearance.Options.UseBorderColor = true;
            this.btnMoveUp.Appearance.Options.UseFont = true;
            this.btnMoveUp.Appearance.Options.UseForeColor = true;
            this.btnMoveUp.Appearance.Options.UseImage = true;
            this.btnMoveUp.Appearance.Options.UseTextOptions = true;
            this.btnMoveUp.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnMoveUp.ImageOptions.Image = global::MongoPro.Properties.Resources.moveup_32x32;
            this.btnMoveUp.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnMoveUp.Location = new System.Drawing.Point(9, 338);
            this.btnMoveUp.LookAndFeel.SkinMaskColor = System.Drawing.Color.Transparent;
            this.btnMoveUp.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.Transparent;
            this.btnMoveUp.LookAndFeel.SkinName = "London Liquid Sky";
            this.btnMoveUp.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnMoveUp.Size = new System.Drawing.Size(78, 62);
            this.btnMoveUp.TabIndex = 6;
            this.btnMoveUp.Text = "Move\nUp";
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnMoveDown.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnMoveDown.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnMoveDown.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnMoveDown.Appearance.Options.UseBackColor = true;
            this.btnMoveDown.Appearance.Options.UseBorderColor = true;
            this.btnMoveDown.Appearance.Options.UseFont = true;
            this.btnMoveDown.Appearance.Options.UseForeColor = true;
            this.btnMoveDown.Appearance.Options.UseImage = true;
            this.btnMoveDown.Appearance.Options.UseTextOptions = true;
            this.btnMoveDown.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnMoveDown.ImageOptions.Image = global::MongoPro.Properties.Resources.moveup_32x32;
            this.btnMoveDown.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnMoveDown.Location = new System.Drawing.Point(9, 406);
            this.btnMoveDown.LookAndFeel.SkinMaskColor = System.Drawing.Color.Transparent;
            this.btnMoveDown.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.Transparent;
            this.btnMoveDown.LookAndFeel.SkinName = "London Liquid Sky";
            this.btnMoveDown.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnMoveDown.Size = new System.Drawing.Size(79, 60);
            this.btnMoveDown.TabIndex = 7;
            this.btnMoveDown.Text = "Move\nDown";
            // 
            // btnConversion
            // 
            this.btnConversion.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.btnConversion.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnConversion.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnConversion.Appearance.Options.UseBackColor = true;
            this.btnConversion.Appearance.Options.UseBorderColor = true;
            this.btnConversion.Appearance.Options.UseFont = true;
            this.btnConversion.Appearance.Options.UseForeColor = true;
            this.btnConversion.Appearance.Options.UseImage = true;
            this.btnConversion.Appearance.Options.UseTextOptions = true;
            this.btnConversion.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnConversion.ImageOptions.Image = global::MongoPro.Properties.Resources.converttorange_32x32;
            this.btnConversion.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnConversion.Location = new System.Drawing.Point(7, 472);
            this.btnConversion.Name = "btnConversion";
            this.btnConversion.Size = new System.Drawing.Size(82, 81);
            this.btnConversion.TabIndex = 8;
            this.btnConversion.Text = "Conversion\nResults";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(189)))), ((int)(((byte)(0)))));
            this.simpleButton1.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseBorderColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.Appearance.Options.UseImage = true;
            this.simpleButton1.Appearance.Options.UseTextOptions = true;
            this.simpleButton1.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButton1.Location = new System.Drawing.Point(8, 559);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(80, 38);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "Conversion\nResults";
            // 
            // XCueEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 631);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "XCueEditorForm";
            this.Text = "XCueEditor";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListCommands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFileInfos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).EndInit();
            this.panelControl7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlScript)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl8)).EndInit();
            this.panelControl8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).EndInit();
            this.panelControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).EndInit();
            this.stackPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraTreeList.TreeList treeListCommands;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        private DevExpress.XtraEditors.SimpleButton btnInsertBefore;
        private DevExpress.XtraEditors.SimpleButton btnInsertAfter;
        private DevExpress.XtraEditors.SimpleButton btnDeleteRow;
        private DevExpress.XtraEditors.SimpleButton btnComment;
        private DevExpress.XtraEditors.SimpleButton btnBlank;
        private DevExpress.XtraEditors.SimpleButton btnMoveUp;
        private DevExpress.XtraEditors.SimpleButton btnMoveDown;
        private DevExpress.XtraEditors.SimpleButton btnConversion;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.PanelControl panelControl7;
        private DevExpress.XtraEditors.PanelControl panelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl6;
        private DevExpress.XtraGrid.GridControl gridControlFileInfos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControlRow;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn RowNo;
        private DevExpress.XtraGrid.Columns.GridColumn ErrorDescription;
        private DevExpress.XtraGrid.GridControl gridControlScript;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn ScriptStatement;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
    }
}