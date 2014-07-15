using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using nmsProfile;
using nmsSetup;
using nmsSetupWeb;
using nmsEditor;
using System.Collections.Generic;
public partial class mange3_home2 : System.Web.UI.MasterPage
{
    clsBLEditor obj;
    PRPPImageGellery objprp;
    PRPPImageGellery objprpparam;
    prpLogin objlogin;
    string name = "", temp = "", page = "", code = "", all = "";


    public string Quicklink(object Value)
    {
        return "http://www.edumate.edu.in/stuI/" + name + "/" + code + "/" + temp + "/" + Value.ToString();
    }

    public string gallerylink(object Value)
    {
        return "http://www.edumate.edu.in/stuG/" + name + "/" + code + "/" + temp + "/" + Value.ToString();
    }



    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            if (Page.RouteData.Values["name"] != null)
            {
                name = Page.RouteData.Values["name"].ToString();
            }

            if (Page.RouteData.Values["page"] != null)
            {
                page = Page.RouteData.Values["page"].ToString();
            }
            if (Page.RouteData.Values["temp"] != null)
            {
                temp = Page.RouteData.Values["temp"].ToString();
            }



            if (Page.RouteData.Values["code"] != null)
            {
                code = Page.RouteData.Values["code"].ToString();
                bindQuickGellary();
                bindQuickLinks();
               // SelectDatail();
            }
            else
            {
                Response.Redirect("default.aspx");
            }


        }


    }



    private void bindQuickLinks()
    {
        obj = new clsBLEditor();
        PRPEditor prp = new PRPEditor();
        prp.Id = code;
        prp.pagePositin = "Quicklinks";

        repQuickLinks.DataSource = obj.spQuickBind(prp);
        repQuickLinks.DataBind();

    }


    private void bindQuickGellary()
    {
        obj = new clsBLEditor();
        PRPEditor prp = new PRPEditor();
        prp.Id = code;
        prp.pagePositin = "ImageCategory";

        repQuickGallery.DataSource = obj.spQuickBind(prp);
        repQuickGallery.DataBind();

    }


}
