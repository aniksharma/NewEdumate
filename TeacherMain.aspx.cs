using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using nmsSetupI;
using nmsDropDownI;
using System.Configuration;

public partial class TeacherMain : System.Web.UI.Page
{
    PRPSetup prppram;
    PRPSetup prp;
    clsBLSetup bl;

    string type = "", memberId = "";
    static string branchId = "";
    string strcon = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
    protected int TotalCount;
    SqlDataAdapter da;
    int contid;
    protected DataSet ds = new DataSet();

    protected string Country = "";
    int stateid;
    protected string StateName = "";
    protected void Page_Load(object sender, EventArgs e)
    {
       
        contid = Convert.ToInt32(Request.QueryString["ContId"]);
        stateid = Convert.ToInt32(Request.QueryString["State"]);
        StateName = Convert.ToString(Request.QueryString["StateName"]);
      // SelectDatail(1);
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
        SqlCommand cmd = new SqlCommand("viewCollegeDetail_srikant", con);
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
        SqlConnection con = new SqlConnection(strcon);
        //SqlCommand cmd = new SqlCommand("viewCollegeDetail_srikant", con);

        SqlCommand cmd = new SqlCommand("spteacherdetails", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] paramsToStore =
           new SqlParameter[1];
        //paramsToStore[0] = new SqlParameter("@pageSize", SqlDbType.NVarChar);
        //paramsToStore[0].Size = 20;
        //cmd.Parameters.Add(paramsToStore[0]).Value = ddlNopage.SelectedValue;
        //paramsToStore[1] = new SqlParameter("@pageIndex", SqlDbType.NVarChar);
        //paramsToStore[1].Size = 100;
        //cmd.Parameters.Add(paramsToStore[1]).Value = pageIndex;
        //paramsToStore[2] = new SqlParameter("@loginType", SqlDbType.NVarChar);
        //paramsToStore[2].Size = 60;
        //cmd.Parameters.Add(paramsToStore[2]).Value = "5";

        paramsToStore[0] = new SqlParameter("@id", SqlDbType.NVarChar);
        paramsToStore[0].Size = 60;
        cmd.Parameters.Add(paramsToStore[0]).Value = contid;


        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);

       // Country = ds.Tables[0].Rows[0]["cntName"].ToString();

        //----------------------------------------------

        TotalCount = ds.Tables[0].Rows.Count;

    }
}