using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Collections.Generic;
namespace nmsLoginJob
{

    public class clsPRPLogin
    {
        private string _LoginName, _password,_oldPassword;
        private string _LastLoginIP,_LastLoginTime;
        private string _UserName, _UserRole ,_UserId,_name ;

        public string name { get { return _name; } set { _name = value; } }
       
        public string oldPassword { get { return _oldPassword; } set { _oldPassword = value; } }
       
        public string LoginName { get { return _LoginName; } set { _LoginName = value; } }
        public string password { get { return _password; } set { _password = value; } }
       
        public string LastLoginIP { get { return _LastLoginIP; } set { _LastLoginIP = value; } }
        public string LastLoginTime { get { return _LastLoginTime; } set { _LastLoginTime = value; } }

        public string UserName { get { return _UserName; } set { _UserName = value; } }
        public string UserRole { get { return _UserRole; } set { _UserRole = value; } }
        public string UserId { get { return _UserId; } set { _UserId = value; } }
        


    }

}