using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using nmsEditor;
using System.Collections.Generic;


public partial class download : System.Web.UI.Page
{
    clsBLEditor obj;
    PRPPImageGellery objprpparam;
    string name = "", temp = "", page = "", code = "", all = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            if (Page.RouteData.Values["page"] != null)
            {
                page = Page.RouteData.Values["page"].ToString();
            }

            if (Page.RouteData.Values["code"] != null)
            {
                code = Page.RouteData.Values["code"].ToString();
                SelectDatail();
               
            }
            else
            {
                Response.Redirect("default.aspx");
            }

    }

     
        

    }

    private void SelectDatail( )
    {

        obj = new clsBLEditor();
        PRPPImageGellery objparm = new PRPPImageGellery();
        List<PRPPImageGellery> lst = new List<PRPPImageGellery>();
        objparm.schoolid = code;
        lst = obj.viewdocFile1(objparm);


        if (lst[0].id != "Result Not Find")
        {
            ListCaloney.DataSource = lst;
            ListCaloney.DataBind();


        }
        else
        {
            ListCaloney.DataSource = null;
            ListCaloney.DataBind();
    

        }
    }
}
