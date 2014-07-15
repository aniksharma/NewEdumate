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
using nmsLogin;

namespace nmsLogin
{
    public class clsBLlogin
    {
        clsDLlogin obj = new clsDLlogin();


        public string checkLogin(clsPRPLogin objprp)
        {
            return obj.checkLogin(objprp);
        }
    }

}
