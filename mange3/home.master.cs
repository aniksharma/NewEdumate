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
public partial class mange3_home : System.Web.UI.MasterPage
{
    clsBLEditor obj;
    PRPPImageGellery objprp;
    PRPPImageGellery objprpparam;
    prpLogin objlogin;
    string name = "", temp = "", page = "", code = "", all = "";
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
                linkid.Href = "~/mange3/css/"+temp+".css"; 
            }



            if (Page.RouteData.Values["code"] != null)
            {
                code = Page.RouteData.Values["code"].ToString();
          
                bindMenu();
                bindTextBox();
            }
            else
            {
                Response.Redirect("~/default.aspx");
            }


        }

    }

    private void bindMenu()
    {
        all = "~/stuI/" + name + "/" + code + "/" + temp;

        linkcontact.NavigateUrl=linkfooterContact.NavigateUrl = all + "/63";
        linkabout.NavigateUrl = linkfooterAbout.NavigateUrl = all + "/62";
        linkHome.NavigateUrl = linkfooterHome.NavigateUrl = all + "/61";
        linkcreativity.NavigateUrl = all + "/62";
        linkvideo.NavigateUrl=  all + "/65";
        
        linkfooterGallery.NavigateUrl = linkgallery.NavigateUrl = "~/stuG/" + name + "/" + code + "/" + temp + "/109"; ;
        
        

    }

    private void bindTextBox()
    {
        PRPSetup prp = new PRPSetup();
        PRPSetup prppram = new PRPSetup();
        clsBLSetup bl = new clsBLSetup();

        prppram.codeId = code;
        prppram.name = "";
        prp = bl.SelectCollegeDetail(prppram);
        imglogo.Src = "~/" + prp.urlPath;



    }

}
