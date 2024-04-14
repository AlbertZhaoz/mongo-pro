using DevExpress.XtraEditors;
using MongoDB.Bson;
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
    public partial class ConnectionForm : DevExpress.XtraEditors.XtraForm
    {
        public ConnectionForm()
        {
            InitializeComponent();

            BindMvvm();
        }

        private void BindMvvm()
        {
            this.mvvmContextLogin.ViewModelType = typeof(UserViewModel);
            // Data binding
            var fluentApi = mvvmContextLogin.OfType<UserViewModel>();
            if (fluentApi != null)
            {
                fluentApi.SetBinding(textEditUri,e=>e.EditValue,x=>x.Uri);
                fluentApi.SetBinding(textEditHost,e=>e.EditValue,x=>x.Host);
                fluentApi.SetBinding(textEditUsername,e=>e.EditValue,x=>x.Username);
                fluentApi.SetBinding(textEditPassword,e=>e.EditValue,x=>x.Password);
                fluentApi.SetBinding(textEditDb,e=>e.EditValue,x=>x.Database);
            }
        }

        private void toggleSwitch1_EditValueChanged(object sender, EventArgs e)
        {
            // 当 toggleSwitch1 的值为 true 时，textEditUri 的 Enabled 属性为 true，否则为 false
            if (this.toggleSwitch1.IsOn)
            {
                textEditUri.Enabled = true;
                textEditUri.BackColor = Color.White;
            }
            else
            {
                textEditUri.Enabled = false;
                textEditUri.BackColor =  System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            var userInfo = mvvmContextLogin.GetViewModel<UserViewModel>();
            if (userInfo != null)
            {
                MessageBox.Show(userInfo.ToJson());
            }
        }
    }
}