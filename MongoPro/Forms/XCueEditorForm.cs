using DevExpress.XtraBars;
using MongoPro.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MongoPro.Forms
{
    public partial class XCueEditorForm : DevExpress.XtraEditors.XtraForm
    {
        public XCueEditorForm()
        {
            InitializeComponent();
            SetUi();
            BindMvvm();
        }

        private void SetUi()
        {
        }

        private void BindMvvm()
        {
            this.mvvmContext.ViewModelType = typeof(XCueViewModel);
            // Data binding
            var fluentApi = mvvmContext.OfType<UserViewModel>();
            if (fluentApi != null)
            {
            }

            var xCueViewModel = mvvmContext.GetViewModel<XCueViewModel>();

            // treeListCommands 数据绑定
            treeListCommands.DataBindings.Clear();
            treeListCommands.Nodes.Clear();
            treeListCommands.OptionsBehavior.AutoPopulateColumns = true;
            treeListCommands.DataSource = xCueViewModel.ScriptCommandsDt;
            treeListCommands.KeyFieldName = nameof(ScriptCommand.ID);
            treeListCommands.ParentFieldName = nameof(ScriptCommand.ParentID);

            if (treeListCommands.Nodes.Count > 0)
            {
                treeListCommands.SelectNode(treeListCommands.Nodes[0]);
            }

            treeListCommands.ExpandAll();

            // gridControl
            gridControlFileInfos.DataBindings.Clear();
            gridControlFileInfos.DataSource = xCueViewModel.FileInfos; 
            gridControlRow.DataBindings.Clear();
            gridControlRow.DataSource = xCueViewModel.RowInfos;
            gridControlScript.DataBindings.Clear();
            gridControlScript.DataSource = xCueViewModel.ScriptStates;
        }

        private void treeListCommands_CustomDrawNodeCell(object sender,
            DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs e)
        {
            var row = e.Node.GetValue("ParentID"); // 获取当前节点的ParentID字段的值

            if (row == null || row.ToString() == "0") // 如果ParentID为空或者为0，说明是父节点
            {
                e.Appearance.Font = new System.Drawing.Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size,
                    System.Drawing.FontStyle.Bold); // 设置父节点为粗体字
                e.Appearance.BackColor = Color.FromArgb(236, 251, 255);
            }

            // 如果该行被选中，则设置为红色
            if (e.Node == treeListCommands.FocusedNode)
            {
                e.Appearance.BackColor = Color.FromArgb(132, 189, 0);
                e.Appearance.ForeColor = System.Drawing.Color.White;
            }
        }

        private void gridView3_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }
    }
}