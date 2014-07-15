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
public partial class mange_NewWeb_Default : System.Web.UI.Page
{
    clsBLEditor obj;
    PRPPImageGellery objprp;
    PRPPImageGellery objprpparam;
    prpLogin objlogin;

    string UserId = "",Name="";
    string name = "", temp = "", page = "", code = "", all = "";
    private string getname()
    {
        return "edu";
    }
    public string Quicklink(object Value)
    {
        return "http://www.edumate.edu.in/ch/" + name + "/" + code + "/" + temp +"/"+ Value.ToString();
    }

    public string gallerylink(object Value)
    {
        return "http://www.edumate.edu.in/chg/" + name + "/" + code + "/" + temp + "/" + Value.ToString();
    }
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

      
            if (Page.RouteData.Values["code"] != null)
            {
                UserId = Page.RouteData.Values["code"].ToString();
                bindQuickLinks();
              bindQuickGellary();
               homepageAllWeb();
                imageGellary();
            }
            else
            {
                Response.Redirect("../default.aspx");
            }
        }


    }
    private void bindQuickLinks()
    {
        obj = new clsBLEditor();
        PRPEditor prp = new PRPEditor();
        prp.Id = UserId;
        prp.pagePositin = "Quicklinks";

        repQuickLinks.DataSource = obj.spQuickBind(prp);
        repQuickLinks.DataBind();

    }
    private void bindQuickGellary()
    {
        obj = new clsBLEditor();
        PRPEditor prp = new PRPEditor();
        prp.Id = UserId;
        prp.pagePositin = "ImageCategory";

        repQuickGallery.DataSource = obj.spQuickBind(prp);
        repQuickGallery.DataBind();

    }
    private void homepageAllWeb()
    {
        try
        {

            obj = new clsBLEditor();
            PRPPImageGellery objparm = new PRPPImageGellery();
            List<PRPPImageGellery> lst = new List<PRPPImageGellery>();
            objparm.id = UserId;
            lst = obj.homepageAllWeb(objparm);


            if (lst[0].id != "Result Not Find")
            {
                dataaboutus.InnerHtml = lst[2].imageDescription;
                dataachAchivement.InnerHtml = lst[3].imageDescription;
                datawelcome.InnerHtml = lst[1].imageDescription;
                dataInfrastur.InnerHtml = lst[0].imageDescription;
                dataActivites.InnerHtml = lst[4].imageDescription;

                imgAchiviment.Src ="http://www.edumate.edu.in/"+ lst[3].imagePath;
                imgActivites.Src = "http://www.edumate.edu.in/" + lst[4].imagePath;
                imgInfrastru.Src = "http://www.edumate.edu.in/" + lst[0].imagePath;
                imgwelcome.Src = "http://www.edumate.edu.in/" + lst[1].imagePath;
            }
        }
        catch
        {

        }
    }
    private void imageGellary()
    {

        obj = new clsBLEditor();
        PRPPImageGellery objparm = new PRPPImageGellery();
        List<PRPPImageGellery> lst = new List<PRPPImageGellery>();
        objparm.caloneyId = "2";
        objparm.id = UserId;
        lst = obj.spImageGalleryshowByCaloneyIdtop5(objparm);


        if (lst[0].id != "Result Not Find")
        {
            Repeater1.DataSource = lst;
            Repeater1.DataBind();


        }
        else
        {
            //Repeater1.DataSource = null;
            //Repeater1.DataBind();
            // Response.Redirect("Default.aspx");

        }
    }
}
