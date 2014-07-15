using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using nmsEditor;
using System.Collections.Generic;
using nmsProfile;
using System.Data.SqlClient;
using System.Configuration;

public partial class manage2_NewWeb_pageGellary : System.Web.UI.Page
{
    string userid = "", viewId = "", Name = "";
    string name = "", temp = "", pname = "", page = "", code = "", all = "", css = "";
    clsBLEditor obj;
    PRPPImageGellery objprp;
    PRPPImageGellery objprpparam;
    prpLogin prppram, objlogin;
    static string imageId = "", fileURL = "";
    string catname;
    string imgurl = "", path = "", MaxId = "";

    string linkid = "", linkName = "";
    String webname = "";


    string collageName = "", lastpart = "", stuid = "";
    static string logintypre = "", linkidst = "";
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
            if (Session["OfficeCollege"] != null)
            {
                prpLogin prplogin = new prpLogin();
                prplogin = (prpLogin)Session["OfficeCollege"];
                logintypre = prplogin.loginType;
                SqlConnection con11 = new SqlConnection(ConfigurationManager.ConnectionStrings["cn1"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand();
                con11.Open();
                cmd1.Connection = con11;
                cmd1.CommandText = "spgetLinkIdbyname";
                cmd1.Parameters.AddWithValue("@linkname", page);
                cmd1.Parameters.AddWithValue("@typeid", logintypre);

                cmd1.CommandType = System.Data.CommandType.StoredProcedure;
                // Code that runs on application startup
                linkidst = cmd1.ExecuteScalar().ToString();
                cmd1.Dispose();
                con11.Close();
            }
            
        }
        else
        {
            Response.Redirect("default.aspx", false);
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (Page.IsPostBack == false)
        {
            if (Page.RouteData.Values["Sname"] != null)
            {
                getdatealldaetilforurl();
                SelectDatail();

            }
            else
            {
                Response.Redirect("~/default.aspx");
            }
            
            objlogin = new prpLogin();
            if (Session["OfficeCollege"] != null)
            {
                objlogin = (prpLogin)(Session["OfficeCollege"]);
                webname = objlogin.webSite;

                ViewState["codeId"] = objlogin.EmployeeId;
                Session["schoolid"] = objlogin.EmployeeId;
                if (objlogin.webSite != "Set Website Name")
                {
                    string stttt = Page.RouteData.Values["Sname"].ToString() + "/" + Page.RouteData.Values["Pagename"].ToString();
                    lblWebsite.Attributes.Add("onclick", "window.open('http://www.edumateworld.com/EditGallery/" + stttt + "' ,'newwindow','toolbar=yes,location=no,menubar=no,width=1000,height=700,resizable=yes,scrollbars=yes,top=200,left=250');return false;");
                     }
            }    
            
        }


       

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
    protected void lblWebsite_Click(object sender, EventArgs e)
    {
      

    }
 


    
}