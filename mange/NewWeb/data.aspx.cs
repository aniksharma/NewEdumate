using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using nmsEditor;
using System.Collections.Generic;

public partial class mange_NewWeb_data : System.Web.UI.Page
{
    clsBLEditor obj;
    PRPPImageGellery objprp;
    PRPPImageGellery objprpparam;

    string userid = "", viewId = "", divValues = "", id = "", Name = "",tid="";
    string name = "", temp = "", page = "", code = "", all = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {

            if (Page.RouteData.Values["name"] != null)
            {
                name = Page.RouteData.Values["name"].ToString();
            }

            if (Page.RouteData.Values["temp"] != null)
            {
                temp = Page.RouteData.Values["temp"].ToString();
            }

            if (Page.RouteData.Values["page"] != null)
            {
                page = Page.RouteData.Values["page"].ToString();
            }

            if (Page.RouteData.Values["code"] != null)
            {
                code = Page.RouteData.Values["code"].ToString();
            }
            if (RouteData.Values["code"] != null)
            {
                userid = Page.RouteData.Values["code"].ToString();
            }
            if (RouteData.Values["page"] != null)
            {
                viewId = Page.RouteData.Values["page"].ToString();
            }

                SelectDatail();
                bindQuickGellary();
                bindQuickLinks();

            
        }
  
    }

    public string Quicklink(object Value)
    {
        return "http://www.edumateworld.com/ch/" + name + "/" + code + "/" + temp + "/" + Value.ToString();
    }

    public string gallerylink(object Value)
    {
        return "http://www.edumate.edu.in/chg/" + name + "/" + code + "/" + temp + "/" + Value.ToString();
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
            Repeater1.DataSource = lst;
            Repeater1.DataBind();


        }
     
    }
    private void bindQuickLinks()
    {
        obj = new clsBLEditor();
        PRPEditor prp = new PRPEditor();
        prp.Id = userid;
        prp.pagePositin = "Quicklinks";

        repQuickLinks.DataSource = obj.spQuickBind(prp);
        repQuickLinks.DataBind();

    }
    private void bindQuickGellary()
    {
        obj = new clsBLEditor();
        PRPEditor prp = new PRPEditor();
        prp.Id = userid;
        prp.pagePositin = "ImageCategory";

        repQuickGallery.DataSource = obj.spQuickBind(prp);
        repQuickGallery.DataBind();

    }

}