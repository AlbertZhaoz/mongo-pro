using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoPro.ViewModels
{
    public class UserViewModel : ViewModelBase
    {
        private string uri;

        public string Uri
        {
            get
            {
                var result = new StringBuilder("mongodb://");

                if (!string.IsNullOrEmpty(Username))
                {
                    result.Append(Username);

                    if (!string.IsNullOrEmpty(Password))
                    {
                        result.Append(':')
                            .Append("***");
                    }

                    result.Append("@");
                }

                result.Append(Host);

                return result.ToString();
            }
            set { uri = value; }
        }

        private string _host = "localhost:27017";

        public virtual string Host
        {
            get { return _host; }
            set
            {
                _host = value;
                RaisePropertyChanged(nameof(Uri));
            }
        }

        private string _userName;

        public virtual string Username
        {
            get { return _userName; }
            set
            {
                _userName = value;
                RaisePropertyChanged(nameof(Uri));
            }
        }

        private string _password;

        public virtual string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                RaisePropertyChanged(nameof(Uri));
            }
        }

        public virtual string Database { get; set; }
        public virtual MechanismEnum Mechanism { get; set; } = MechanismEnum.Default;
    }

    public enum MechanismEnum
    {
        Default,
        SCRAM_SHA_1,
        SCRAM_SHA_256,
    }
}