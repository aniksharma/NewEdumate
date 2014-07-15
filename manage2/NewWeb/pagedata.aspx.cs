using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using nmsEditor;
using System.Collections.Generic;
using nmsProfile;
using System.Data.SqlClient;
using System.Configuration;
public partial class manage2_NewWeb_pagedata : System.Web.UI.Page
{
    clsBLEditor obj;
    PRPPImageGellery objprp;
    PRPPImageGellery objprpparam;
    
    string linkid = "", linkName = "";
    string st = "";
    string UserId = "",Name="";
    string name = "", temp = "", pname = "", page = "", code = "", all = "", css = "";

    HtmlMeta heardermeta;

    prpLogin prppram, objlogin;

   
    prpImagePlan prp;
    static string imageId = "", fileURL = "";
    string catname;
    string imgurl = "", path = "", MaxId = "";
    String webname = "";
    string deletebutton = "", updatebutton = "";

    string collageName = "", lastpart = "", stuid = "";
    string websitename = "";
    protected string title1(object name)
    {
        return ((string)name).Replace(" ", "-").ToLower();
    }

    protected void Page_Load(object sender, EventArgs e)
    {

        if (Page.RouteData.Values["Sname"] != null)
             {
                 getdatealldaetilforurl();
                 if (Page.RouteData.Values["Pagename"].ToString() == "Gallery")
                 {
                     SelectDatail();
                     galary.Visible = true;
                     common.Visible = false;

                 }
                 else
                 {
                     galary.Visible = false;
                     common.Visible = true;
                     ShowByClass1();
                   
                 }
                 SelectMeta();
                 viewTitle();              

             }
            

             else
             {
                 Response.Redirect("default.aspx");
             }
             objlogin = new prpLogin();
             if (Session["OfficeCollege"] != null)
             {
                 objlogin = (prpLogin)(Session["OfficeCollege"]);
                 webname = objlogin.webSite;
                 ViewState["codeId"] = objlogin.EmployeeId;
                 if (objlogin.webSite != "Set Website Name")
                 {
                     lblWebsite.Visible = true;
                     string stttt = Page.RouteData.Values["Sname"] .ToString()+ "/" + Page.RouteData.Values["Pagename"].ToString();
                     lblWebsite.Attributes.Add("onclick", "window.open('http://localhost:52023/NewEdumate/EditData/" + stttt + "' ,'newwindow','toolbar=yes,location=no,menubar=no,width=1000,height=700,resizable=yes,scrollbars=yes,top=200,left=250');return false;");
                 }
             }
             else
             {
                 lblWebsite.Visible = false;

             }

    }

    private void SelectMeta()
    {        
        obj = new clsBLEditor();
        PRPPImageGellery objparm = new PRPPImageGellery();
        List<PRPPImageGellery> lst = new List<PRPPImageGellery>();
        objparm.caloneyId = page;
        objparm.schoolid = code;
        lst = obj.viewMetaPageWiseMicro(objparm);

        foreach (PRPPImageGellery p in lst)
        {
          heardermeta = new HtmlMeta();
          heardermeta.Name = p.name;
          heardermeta.Content = p.imageDescription;
          Header.Controls.Add(heardermeta);       
        }
        

    }
    private void viewTitle()
    {        
        obj = new clsBLEditor();
        PRPPImageGellery objparm = new PRPPImageGellery();
        PRPPImageGellery lst = new PRPPImageGellery();
        objparm.caloneyId = page;
        objparm.schoolid = code;
        lst = obj.selTitlePageWiseMicro(objparm);

        Page.Title=lst.name;

    }

    private void getdatealldaetilforurl()
    {
        if (Page.RouteData.Values["Sname"] != null)
        {
            lastpart = Page.RouteData.Values["Sname"].ToString();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "spuserTempateCheck";
            cmd.Parameters.AddWithValue("@title", lastpart);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            // Code that runs on application startup
            collageName = cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            con.Close();

            if (collageName == "" || collageName == "nill")
            {
                Response.Redirect("default.aspx", false);

            }
            else
            {
                string[] mlog;
                mlog = new string[2];
                mlog = collageName.Split('-');
                name = lastpart;
                code = mlog[0];
                temp = mlog[1];
                css = mlog[2];
                if (Page.RouteData.Values["Pagename"] != null)
                {
                    page = Page.RouteData.Values["Pagename"].ToString().Replace("-", " "); 
                }
                else
                {
                    page = "Home";
                }
            }
        }
        else
        {
            Response.Redirect("default.aspx", false);
        }
    }
    protected void lblWebsite_Click(object sender, EventArgs e)
    {

        
    }

    private void SelectDatail()
    {

        obj = new clsBLEditor();
        PRPPImageGellery objparm = new PRPPImageGellery();
        List<PRPPImageGellery> lst = new List<PRPPImageGellery>();
        objparm.caloneyId = page;
        objparm.id = code;

        lst = obj.viewImageGalleryShowByCaloneyId(objparm);

        if (lst[0].id != "Result Not Find")
        {
            datalist.DataSource = lst;
            datalist.DataBind();
        }

    }

    private void ShowByClass1()
    {
        obj = new clsBLEditor();
        PRPPImageGellery objparm = new PRPPImageGellery();
        List<PRPPImageGellery> lst = new List<PRPPImageGellery>();

        if (linkid != "bankimg.jpg")
        {

            objparm.caloneyId = page;
            objparm.id = code;
            lst = obj.spImageGalleryshowByCaloneyId_sal(objparm);
        }
        string title = "Edumate";


        if (lst[0].id != "Result Not Find")
        {
            st += "<table class='pageTable' style='width: 850px;'>";
            if (lst[0].layout == "1" || lst[0].layout == "")
            {
                foreach (PRPPImageGellery prp in lst)
                {


                    title = "<h1>" + prp.imageTitle + "</h1>";
                    st += "<tr></td><td valign='top'> " + title + prp.imageDescription + "<br></td></tr>";
                }
            }
            else if (lst[0].layout == "5")
            {
                string st1 = "";
                st += "<tr><td  valign='top'><table width='100%' cellpadding='0' cellspacing='5px'><tr>";
                foreach (PRPPImageGellery prp in lst)
                {
                    title = "<h1>" + prp.imageTitle + "</h1>";
                    st += "<td  valign='top'><img alt='" + prp.imageTitle + "' src='" + prp.imagePath + "' height=\"150px\" width=\"190px\" alt=\"\" style=\"border:solid 1px #ffffff;\" /></td>";
                    st1 += "<tr></td><td valign='top'>" + title + prp.imageDescription + "</td></tr>";
                }
                st += "</tr></table><br></td></tr>";
                st = st + st1;
            }
            else if (lst[0].layout == "6")
            {
                string st1 = "<tr><td  valign='top'><table width='100%' cellpadding='0' cellspacing='5px'><tr>";
                foreach (PRPPImageGellery prp in lst)
                {
                    title = "<h1>" + prp.imageTitle + "</h1>";
                    st1 += "<td  valign='top'><img  alt='" + prp.imageTitle + "' src='../../../" + prp.imagePath + "' height=\"150px\" width=\"210px\" alt=\"\" style=\"border:solid 1px #ffffff;\" /></td>";
                    st += "<tr></td><td valign='top'>" + title + prp.imageDescription + "</td></tr>";
                }
                st1 += "</tr></table><br></td></tr>";
                st = st + st1;
            }
            else if (lst[0].layout == "2")
            {
                foreach (PRPPImageGellery prp in lst)
                {
                    title = "<h1>" + prp.imageTitle + "</h1>";
                    st += "<tr></td><td valign='top'><div style=\"float:left; height:150px;width:210px;margin-right:7px; border:solid 1px #ffffff;\"><img  alt='" + prp.imageTitle + "' src='../../../" + prp.imagePath + "' height=\"150\" width=\"210\" alt=\"\" style=\"border:solid 1px #ffffff;\" /></div>" + title + prp.imageDescription + "<br></td></tr>";
                }
            }
            else if (lst[0].layout == "3")
            {
                foreach (PRPPImageGellery prp in lst)
                {
                    title = "<h1>" + prp.imageTitle + "</h1>";
                    st += "<tr><td valign='top'>" + title + prp.imageDescription + "</td><td valign='top'><img  alt='" + prp.imageTitle + "' src='../../../" + prp.imagePath + "' Height='150' Width='200px' /><br></td></tr>";
                }
            }
            else if (lst[0].layout == "4")
            {
                int a;
                for (a = 0; a < lst.Count; a++)
                {
                    if (a == 0)
                    {
                        st += "<tr></td><td valign='top'><div style=\"float:left; height:150;width:210;margin-right:7px; border:solid 1px #ffffff;\"  class='img-students' ><img  alt='" + lst[a].imageTitle + "' src=' ../../../" + lst[a].imagePath + "' height=\"150\" width=\"210\" alt=\"\" style=\"border:solid 1px #ffffff;\" /></div><h1>" + lst[a].imageTitle + "</h1>" + lst[a].imageDescription + "<br></td></tr>";
                    }
                    if (a == 1)
                    {
                        st += "<tr></td><td valign='top'><div style=\"float:right; height:150;width:210;margin-left:7px; border:solid 1px #ffffff;\" class='img-students'><img  alt='" + lst[a].imageTitle + "' src='../../../" + lst[a].imagePath + "' height=\"150\" width=\"210\" alt=\"\" style=\"border:solid 1px #ffffff;\" /></div><h1>" + lst[a].imageTitle + "</h1>" + lst[a].imageDescription + "<br></td></tr>";
                    }
                    if (a == 2)
                    {
                        st += "<tr></td><td valign='top'><div style=\"float:left; height:150;width:210;margin-right:7px; border:solid 1px #ffffff;\" class='img-students'><img  alt='" + lst[a].imageTitle + "' src='../../../" + lst[a].imagePath + "' height=\"150\" width=\"210\" alt=\"\" style=\"border:solid 1px #ffffff;\" /></div><h1>" + lst[a].imageTitle + "</h1>" + lst[a].imageDescription + "</h1>" + "<br></td></tr>";
                    }
                }

            }
            st += "</table>";
            data.InnerHtml = st;


        }

    }
}