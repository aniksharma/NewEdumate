using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using nmsSetupI;
using System.Configuration;
using nmsDropDownI;

public partial class InstitutePanel_InnerCollege : System.Web.UI.Page
{
    PRPSetup prppram;
    PRPSetup prp;
    clsBLSetup bl;

    string type = "", memberId = "";
    static string branchId = "";
    string strcon = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
    protected int TotalCount;
    SqlDataAdapter da;

    protected DataSet ds = new DataSet();
   
    protected string Country = "";
    
    protected string StateName = "";
     string uniid = "";
    int contid;
    int stateid;
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["OfficeCollege"] == null)
        {
            Response.Redirect("../Default.aspx");
        }
        uniid = Convert.ToString(Request.QueryString["ContId"]);
        if (uniid != null)
        {

            string[] mlog;
            mlog = new string[3];
            mlog = uniid.Split('/');
            contid = Convert.ToInt32(mlog[0]);
            stateid = Convert.ToInt32(mlog[1]);
        }
        if (!Page.IsPostBack)
        {
            SelectDatail(1);
        }
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
        SqlCommand cmd = new SqlCommand("viewCollegeDetail", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] paramsToStore =
           new SqlParameter[4];
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        TotalCount = ds.Tables[0].Rows.Count;

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
        SqlCommand cmd = new SqlCommand("viewCollegeDetail_srikant", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] paramsToStore =
           new SqlParameter[5];
        paramsToStore[0] = new SqlParameter("@pageSize", SqlDbType.NVarChar);
        paramsToStore[0].Size = 20;
        cmd.Parameters.Add(paramsToStore[0]).Value = ddlNopage.SelectedValue;
        paramsToStore[1] = new SqlParameter("@pageIndex", SqlDbType.NVarChar);
        paramsToStore[1].Size = 100;
        cmd.Parameters.Add(paramsToStore[1]).Value = pageIndex;
        paramsToStore[2] = new SqlParameter("@loginType", SqlDbType.NVarChar);
        paramsToStore[2].Size = 60;
        cmd.Parameters.Add(paramsToStore[2]).Value = "4";

        paramsToStore[3] = new SqlParameter("@ContId", SqlDbType.NVarChar);
        paramsToStore[3].Size = 60;
        cmd.Parameters.Add(paramsToStore[3]).Value = contid;

        paramsToStore[4] = new SqlParameter("@stateId", SqlDbType.NVarChar);
        paramsToStore[4].Size = 60;
        cmd.Parameters.Add(paramsToStore[4]).Value = stateid;


        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            Country = ds.Tables[0].Rows[0]["cntName"].ToString();

            //----------------------------------------------

            TotalCount = ds.Tables[0].Rows.Count;
        }

    }
}