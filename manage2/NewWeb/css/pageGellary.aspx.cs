using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using nmsEditor;
using System.Collections.Generic;

public partial class manage2_NewWeb_pageGellary : System.Web.UI.Page
{
    clsBLEditor obj;

    string userid = "", viewId = "", Name = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            if (RouteData.Values["code"] != null)
            {
                userid = Page.RouteData.Values["code"].ToString();
            }
            if (RouteData.Values["page"] != null)
            {
                viewId = Page.RouteData.Values["page"].ToString();
                SelectDatail();
            }
            else
            {
                Response.Redirect("default.aspx");
            }

            
        }

    }

    private void SelectDatail()
    {

        obj = new clsBLEditor();
        PRPPImageGellery objparm = new PRPPImageGellery();
        List<PRPPImageGellery> lst = new List<PRPPImageGellery>();
        objparm.caloneyId = viewId;
        objparm.id = userid;
        lst = obj.viewImageGalleryShowByCaloneyId(objparm);


        if (lst[0].id != "Result Not Find")
        {
            datalist.DataSource = lst;
            datalist.DataBind();
        }

    }
}