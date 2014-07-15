using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using nmsEditor;
using System.Collections.Generic;

public partial class manage2_NewWeb_Default : System.Web.UI.Page
{
    clsBLEditor obj;
    PRPPImageGellery objprp;
    PRPPImageGellery objprpparam;
    
    string linkid = "", linkName = "";
    string st = "";
    string UserId = "",Name="";
    string name = "", temp = "", page = "", code = "", all = "";


    protected void Page_Load(object sender, EventArgs e)
    {

            if (Page.RouteData.Values["page"] != null)
            {
                page = Page.RouteData.Values["page"].ToString();
            }

            if (Page.RouteData.Values["code"] != null)
            {
                code = Page.RouteData.Values["code"].ToString();
                ShowByClass();
                imageGellary();
            }
            else
            {
                Response.Redirect("default.aspx");
            }

    }

    private void ShowByClass()
    {
        obj = new clsBLEditor();
        PRPPImageGellery objparm = new PRPPImageGellery();
        List<PRPPImageGellery> lst = new List<PRPPImageGellery>();
        objparm.caloneyId = page;
        objparm.id = code;
        lst = obj.viewImageGalleryShowByCaloneyId(objparm);
        string title = "Edumate";
        if (lst[0].id != "Result Not Find")
        {
            Page.Title = lst[0].imageTitle;


            st += "<table class='pageTable'>";
            if (lst[0].layout == "1" || lst[0].layout == "")
            {
                foreach (PRPPImageGellery prp in lst)
                {
                    title = "<h1>" + prp.imageTitle + "</h1>";
                    st += "<tr></td><td valign='top'> " + title + prp.imageDescription + "</td></tr>";
                    
                }
            }
            else if (lst[0].layout == "5")
            {
                string st1 = "";
                st += "<tr><td><table width='100%' cellpadding='0' cellspacing='5px'><tr>";
                foreach (PRPPImageGellery prp in lst)
                {
                    title = "<h1>" + prp.imageTitle + "</h1>";
                    st += "<td><img alt='" + prp.imageTitle + "' src='" + prp.imagePath + "' height=\"150px\" width=\"190px\" alt=\"\" style=\"border:solid 1px #ffffff;\" /></td>";
                    st1 += "<tr></td><td valign='top'>" + title + prp.imageDescription + "</td></tr>";
                }
                st += "</tr></table></td></tr>";
                st = st + st1;
            }
            else if (lst[0].layout == "6")
            {
                string st1 = "<tr><td><table width='100%' cellpadding='0' cellspacing='5px'><tr>";
                foreach (PRPPImageGellery prp in lst)
                {
                    title = "<h1>" + prp.imageTitle + "</h1>";
                    st1 += "<td><img  alt='" + prp.imageTitle + "' src='" + prp.imagePath + "' height=\"150px\" width=\"210px\" alt=\"\" style=\"border:solid 1px #ffffff;\" /></td>";
                    st += "<tr></td><td valign='top'>" + title + prp.imageDescription + "</td></tr>";
                }
                st1 += "</tr></table></td></tr>";
                st = st + st1;
            }
            else if (lst[0].layout == "2")
            {
                foreach (PRPPImageGellery prp in lst)
                {
                    title = "<h1>" + prp.imageTitle + "</h1>";
                    st += "<tr></td><td valign='top'><div style=\"float:left; height:150px;width:210px;margin-right:7px; border:solid 1px #ffffff;\"><img  alt='" + prp.imageTitle + "' src='" + prp.imagePath + "' height=\"150\" width=\"210\" alt=\"\" style=\"border:solid 1px #ffffff;\" /></div>" + title + prp.imageDescription + "</td></tr>";
                }
            }
            else if (lst[0].layout == "3")
            {
                foreach (PRPPImageGellery prp in lst)
                {
                    title = "<h1>" + prp.imageTitle + "</h1>";
                    st += "<tr><td valign='top'>" + title + prp.imageDescription + "</td><td valign='top'><img  alt='" + prp.imageTitle + "' src='" + prp.imagePath + "' Height='150' Width='200px' /></td></tr>";
                }
            }
            else if (lst[0].layout == "4")
            {
                int a;
                for (a = 0; a < lst.Count; a++)
                {
                    if (a == 0)
                    {
                        st += "<tr></td><td valign='top'><div style=\"float:left; height:150;width:210;margin-right:7px; border:solid 1px #ffffff;\"><img  alt='" + lst[a].imageTitle + "' src='" + lst[a].imagePath + "' height=\"150\" width=\"210\" alt=\"\" style=\"border:solid 1px #ffffff;\" /></div><h1>" + lst[a].imageTitle + "</h1>" + lst[a].imageDescription + "</td></tr>";
                    }
                    if (a == 1)
                    {
                        st += "<tr></td><td valign='top'><div style=\"float:right; height:150;width:210;margin-left:7px; border:solid 1px #ffffff;\"><img  alt='" + lst[a].imageTitle + "' src='" + lst[a].imagePath + "' height=\"150\" width=\"210\" alt=\"\" style=\"border:solid 1px #ffffff;\" /></div><h1>" + lst[a].imageTitle + "</h1>" + lst[a].imageDescription + "</td></tr>";
                    }
                    if (a == 2)
                    {
                        st += "<tr></td><td valign='top'><div style=\"float:left; height:150;width:210;margin-right:7px; border:solid 1px #ffffff;\"><img  alt='" + lst[a].imageTitle + "' src='" + lst[a].imagePath + "' height=\"150\" width=\"210\" alt=\"\" style=\"border:solid 1px #ffffff;\" /></div><h1>" + lst[a].imageTitle + "</h1>" + lst[a].imageDescription + "</h1>" + "</td></tr>";
                    }
                }

            }
            st += "</table>";
            data.InnerHtml = st;

        }
    }

    private void imageGellary()
    {

        obj = new clsBLEditor();
        PRPPImageGellery objparm = new PRPPImageGellery();
        List<PRPPImageGellery> lst = new List<PRPPImageGellery>();
        objparm.caloneyId = "4";
        objparm.id = code;
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