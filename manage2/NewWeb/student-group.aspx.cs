using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using nmsEditor;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class manage2_NewWeb_Student_Group : System.Web.UI.Page
{
    clsBLEditor obj;

    string userid = "", viewId = "", Name = "";
    string strcon = ConfigurationManager.ConnectionStrings["cn1"].ConnectionString;
    PRPPImageGellery objprp;
    PRPPImageGellery objprpparam;

    static string imageId = "", fileURL = "";
    string catname;
    string imgurl = "", path = "", MaxId = "";

    string linkid = "", linkName = "";
    protected DataSet ds1 = new DataSet();
    protected int totalcount;
    string collageName = "", lastpart = "", stuid = "", css = "";
    string name = "", temp = "", pname = "", page = "", code = "", all = "";
    static string logintypre = "", linkidst = "";
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Page.IsPostBack == false)
        {
            getdatealldaetilforurl();
            
            bindUNI();

            Session["Stud"] = "studentGroup";
        }
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
                userid = mlog[0];
                if (Page.RouteData.Values["Pagename"] != null)
                {
                    page = Page.RouteData.Values["Pagename"].ToString().Replace("-", " ");
                }
                else
                {
                    page = "Home";
                }


                SqlConnection con11 = new SqlConnection(ConfigurationManager.ConnectionStrings["cn1"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand();
                con11.Open();
                cmd1.Connection = con11;
                cmd1.CommandText = "sp_getlinknamefront";
                cmd1.Parameters.AddWithValue("@linkname", page);
                cmd1.Parameters.AddWithValue("@id", code);

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
    public void bindUNI()
    {
        DataSet ds = new DataSet();
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand("spImageGalleryshowStudent", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] paramsToStore =
           new SqlParameter[4];
        paramsToStore[0] = new SqlParameter("@caloneyId", SqlDbType.NVarChar);
        paramsToStore[0].Size = 20;
        cmd.Parameters.Add(paramsToStore[0]).Value = userid;
        paramsToStore[1] = new SqlParameter("@schoolId", SqlDbType.NVarChar);
        paramsToStore[1].Size = 100;
        cmd.Parameters.Add(paramsToStore[1]).Value = "8";
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds1);

        totalcount = ds1.Tables[0].Rows.Count;
         }
    protected void lblWebsite_Click(object sender, EventArgs e)
    {
    }
}