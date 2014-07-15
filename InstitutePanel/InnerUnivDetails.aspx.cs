using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using nmsSetup;
using nmsDropDownJob;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
public partial class InstitutePanel_InnerUnivDetails : System.Web.UI.Page
{
    PRPSetup prppram;
    PRPSetup prp;
    clsBLSetup bl;

    string type = "", memberId = "";
    static string branchId = "";
    string strcon = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
    protected int TotalCount;
    protected int Totalimage;
    SqlDataAdapter da;

    protected DataSet ds = new DataSet();
    protected DataSet dsImage = new DataSet();
    
    string id = "";
    protected string Country = "";
    
    protected string StateName = "";
    string uniid = "" ,page="";
    int contid;
    int stateid;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["OfficeCollege"] == null)
        {
            Response.Redirect("../Default.aspx");
        }

        if (!Page.IsPostBack == true)
        {
            if (Page.RouteData.Values["con"] != null)
            {
                SelectDatailnew(1);
            }
            else
            {
                SelectDatailUnv(1);

            }
        }
    }
    private void SelectDatailnew(Int32 pageIndex)
    {

        bl = new clsBLSetup();
        prppram = new PRPSetup();
        Int32 pageSize = Convert.ToInt32(ddlNopage.SelectedValue);

        prppram.pageIndex = pageIndex.ToString();
        prppram.pageSize = pageSize.ToString();
        string contry = Page.RouteData.Values["con"].ToString();
        string state = Page.RouteData.Values["state"].ToString();
        string uni = Page.RouteData.Values["uni"].ToString();
        string edu = Page.RouteData.Values["edu"].ToString();

        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand("viewUniversityWeb_sliman", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] paramsToStore =
           new SqlParameter[6];
        paramsToStore[0] = new SqlParameter("@pageSize", SqlDbType.NVarChar);
        paramsToStore[0].Size = 20;
        cmd.Parameters.Add(paramsToStore[0]).Value = ddlNopage.SelectedValue;
        paramsToStore[1] = new SqlParameter("@pageIndex", SqlDbType.NVarChar);
        paramsToStore[1].Size = 100;
        cmd.Parameters.Add(paramsToStore[1]).Value = pageIndex;
        paramsToStore[2] = new SqlParameter("@edu", SqlDbType.NChar);
        paramsToStore[2].Size = 60;
        cmd.Parameters.Add(paramsToStore[2]).Value = uni;


        paramsToStore[3] = new SqlParameter("@cntname", SqlDbType.NChar);
        paramsToStore[3].Size = 60;
        cmd.Parameters.Add(paramsToStore[3]).Value = contry;


        paramsToStore[4] = new SqlParameter("@typename", SqlDbType.NChar);
        paramsToStore[4].Size = 60;
        cmd.Parameters.Add(paramsToStore[4]).Value = edu;

        paramsToStore[5] = new SqlParameter("@statename", SqlDbType.NChar);
        paramsToStore[5].Size = 60;
        cmd.Parameters.Add(paramsToStore[5]).Value = state;


        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        TotalCount = ds.Tables[0].Rows.Count;

    }
    private void SelectDatail()
    {

        bl = new clsBLSetup();
        prppram = new PRPSetup();

        List<PRPSetup> lst = new List<PRPSetup>();
        lst = bl.ViewUniversityWeb(prppram);

    }
    private void binduniversity()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();

        drpprp.spName = "viewUniversityWeb";
        drp.bindDropDown(drpprp);

    }
    public void bindUNI()
    {



        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand("viewUniversityWeb_srikant", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] paramsToStore =
           new SqlParameter[4];
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);


        TotalCount = ds.Tables[0].Rows.Count;

    }
    public void BindImage()
    {
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand("viewImageGalleryHome", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] paramsToStore =
           new SqlParameter[4];
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dsImage);


        Totalimage = dsImage.Tables[0].Rows.Count;

    }
    protected void ddlNopage_SelectedIndexChanged(object sender, EventArgs e)
    {
        SelectDatail(1);
    }

    private void SelectDatail(Int32 pageIndex)
    {

        bl = new clsBLSetup();
        prppram = new PRPSetup();
        Int32 pageSize = Convert.ToInt32(ddlNopage.SelectedValue);

        prppram.pageIndex = pageIndex.ToString();
        prppram.pageSize = pageSize.ToString();
        //---------for page work here



        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand("viewUniversityWeb_srikant", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] paramsToStore =
           new SqlParameter[5];
        paramsToStore[0] = new SqlParameter("@pageSize", SqlDbType.NVarChar);
        paramsToStore[0].Size = 20;
        cmd.Parameters.Add(paramsToStore[0]).Value = ddlNopage.SelectedValue;
        paramsToStore[1] = new SqlParameter("@pageIndex", SqlDbType.NVarChar);
        paramsToStore[1].Size = 100;
        cmd.Parameters.Add(paramsToStore[1]).Value = pageIndex;
        paramsToStore[2] = new SqlParameter("@contid", SqlDbType.Int);
        paramsToStore[2].Size = 60;
        cmd.Parameters.Add(paramsToStore[2]).Value = contid;

       
        paramsToStore[3] = new SqlParameter("@stateId", SqlDbType.Int);
        paramsToStore[3].Size = 60;
        cmd.Parameters.Add(paramsToStore[3]).Value = stateid;

       
        paramsToStore[4] = new SqlParameter("@Id", SqlDbType.Int);
        paramsToStore[4].Size = 60;
        cmd.Parameters.Add(paramsToStore[4]).Value = "0";
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
       //----------------------------------------------

        TotalCount = ds.Tables[0].Rows.Count;

    }

    private void SelectDatailUnv(Int32 pageIndex)
    {

        bl = new clsBLSetup();
        prppram = new PRPSetup();
        Int32 pageSize = Convert.ToInt32(ddlNopage.SelectedValue);

        prppram.pageIndex = pageIndex.ToString();
        prppram.pageSize = pageSize.ToString();
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand("viewUniversityWeb_srikant", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] paramsToStore =
           new SqlParameter[5];
        paramsToStore[0] = new SqlParameter("@pageSize", SqlDbType.NVarChar);
        paramsToStore[0].Size = 20;
        cmd.Parameters.Add(paramsToStore[0]).Value = ddlNopage.SelectedValue;
        paramsToStore[1] = new SqlParameter("@pageIndex", SqlDbType.NVarChar);
        paramsToStore[1].Size = 100;
        cmd.Parameters.Add(paramsToStore[1]).Value = pageIndex;
        paramsToStore[2] = new SqlParameter("@contid", SqlDbType.NVarChar);
        paramsToStore[2].Size = 60;
        cmd.Parameters.Add(paramsToStore[2]).Value = contid;

        paramsToStore[3] = new SqlParameter("@stateId", SqlDbType.NVarChar);
        paramsToStore[3].Size = 60;
        cmd.Parameters.Add(paramsToStore[3]).Value = stateid;

        paramsToStore[4] = new SqlParameter("@Id", SqlDbType.NVarChar);
        paramsToStore[4].Size = 60;
        cmd.Parameters.Add(paramsToStore[4]).Value = 0;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        TotalCount = ds.Tables[0].Rows.Count;
        string VirtualPaths = this.Page.AppRelativeVirtualPath;
       
    }
}