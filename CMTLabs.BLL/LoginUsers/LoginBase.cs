using CMTLabs.DAL.LoginManger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CMTLabs.BLL.LoginUsers
{
    public class LoginBase
    {
        private LoginManager _loginManager;
        public LoginManager loginManager
        {
            get
            {
                if (_loginManager == null)
                    return new LoginManager();
                else
                    return this._loginManager;

            }

            private set
            {
                _loginManager = value;
            }
        }
    }
}
