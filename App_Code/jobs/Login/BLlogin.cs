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
using nmsLoginJob;

namespace nmsLoginJob
{
    public class clsBLlogin
    {
        clsDLlogin obj = new clsDLlogin();


        public string checkLogin(clsPRPLogin objprp)
        {
            return obj.checkLogin(objprp);
        }

        public string checkLoginUser(clsPRPLogin objprp)
        {
            return obj.CheckLoginUser(objprp);
        }

        public string UpdatePassword(clsPRPLogin objprp)
        {
            return obj.UpdatePassword(objprp);
        }


        public string spInsertForgetPassword(clsPRPLogin objprp)
        {
            return obj.spInsertForgetPassword(objprp);
        }

        public string spResetPassword(clsPRPLogin objprp)
        {
            return obj.spResetPassword(objprp);
        }

        public string spResetPasswordNew(clsPRPLogin objprp)
        {
            return obj.spResetPasswordNew(objprp);
        }

        public string spResetPasswordNewKIDS(clsPRPLogin objprp)
        {
            return obj.spResetPasswordNewKIDS(objprp);
        } 
    }

}
