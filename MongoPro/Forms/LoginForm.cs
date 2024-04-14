using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoPro.Common;
using MongoPro.ViewModels;

namespace MongoPro.Forms
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
            PanelInit();
            AppearanceInti();
        }

        void PanelInit()
        {
            // panelMain 添加无窗体的 ConnectionForm
            ConnectionForm connectionForm = new ConnectionForm();
            connectionForm.TopLevel = false;
            connectionForm.FormBorderStyle = FormBorderStyle.None;
            connectionForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(connectionForm);
            connectionForm.Show();
        }

        void AppearanceInti()
        {
            labelSomeInfo.Text = ConstHelper.SOME_INFO;
            labelDetail.AllowHtmlString = true;
            labelDetail.Text = ConstHelper.DETAIL;
            labelExample.AllowHtmlString = true;
            labelExample.Text = ConstHelper.EXAMPLE_ONE;
            labelExample2.AllowHtmlString = true;
            labelExample2.Text = ConstHelper.EXAMPLE_TWO;
        }
    }
}