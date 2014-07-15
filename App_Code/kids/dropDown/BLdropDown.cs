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
using nmsDropDownKIDS;
namespace nmsDropDownKIDS
{
    public class clsBLdropDown
    {
        clsDLdropDown obj = new clsDLdropDown();
        public void bindDropDown( clsPRPdropdown objprp)
        {
            objprp.controlList.DataValueField = "id";
            objprp.controlList.DataTextField = "name";
            objprp.controlList.DataSource = obj.SelectDropDown(objprp);
            objprp.controlList.DataBind();
        }

        public void bindDropDownII(clsPRPdropdown objprp)
        {
            objprp.controlList.DataValueField = "stringId";
            objprp.controlList.DataTextField = "name";
            objprp.controlList.DataSource = obj.SelectDropDownII(objprp);
            objprp.controlList.DataBind();
        }

        public void bindControlList(clsPRPdropdown objprp)
        {
            objprp.controlList.DataValueField = "id";
            objprp.controlList.DataTextField = "name";
            objprp.controlList.DataSource = obj.SelectControlList(objprp);
            objprp.controlList.DataBind();
        }



        public void bindControlListII(clsPRPdropdown objprp)
        {
            objprp.controlList.DataValueField = "stringId";
            objprp.controlList.DataTextField = "name";
            objprp.controlList.DataSource = obj.SelectControlListII(objprp);
            objprp.controlList.DataBind();
        }

        

    }
}