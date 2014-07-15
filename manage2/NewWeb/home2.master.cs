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
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class manage2_NewWeb_home2 : System.Web.UI.MasterPage
{
    clsBLEditor obj;
    PRPPImageGellery objprp;
    PRPPImageGellery objprpparam;
    prpLogin objlogin;
    string name = "", temp = "", page = "", code = "", all = "",css="";
    DataSet ds;
    
    string collageName = "", lastpart = "", stuid = "";
    
    string websitename = "";
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
                Response.Redirect("../web/default.aspx", false);

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
                    page = Page.RouteData.Values["Pagename"].ToString();
                }
                else
                {
                    page = "Home";
                }
            }
        }
        else
        {
            Response.Redirect("http://www.edumateworld.com/web/default.aspx", false);
        }
    }


    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            if (Page.RouteData.Values["Sname"] != null)
            {
                getdatealldaetilforurl();
                bindmenuNew();
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
        prp.password = temp;

        repQuickLinks.DataSource = obj.spQuickBind(prp);
        repQuickLinks.DataBind();

    }

    private void bindQuickGellary()
    {
        obj = new clsBLEditor();
        PRPEditor prp = new PRPEditor();
        prp.Id = code;
        prp.password = temp;
        prp.pagePositin = "ImageCategory";

    }
    private void bindmenuNew()
    {
        if (Session["datamenu"] == null)
        {

            PRPEditor prppram = new PRPEditor();
            clsBLEditor bl = new clsBLEditor();

            prppram.Id = code;
            prppram.State = temp;
            ds = new DataSet();
            ds = bl.spMenuForMicro(prppram);
        }
        else
        {
            ds = new DataSet();
            ds = (DataSet)(Session["datamenu"]);


        }


        repQuickLinks.DataSource = ds.Tables[3];
        repQuickLinks.DataBind();

    }


}
