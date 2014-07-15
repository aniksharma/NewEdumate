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

public partial class EntranceExam : System.Web.UI.Page
{
    PRPSetup prppram;
    PRPSetup prp;
    clsBLSetup bl;

    string type = "", memberId = "";
    static string branchId = "";
    string strcon = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
    protected int TotalCount;
    protected int TotalCount1;
    SqlDataAdapter da;
    int contid;
    protected DataSet ds = new DataSet();
    protected DataSet ds1 = new DataSet();
    string NewsId = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        SelectDatail(1);
        SelectDataillist(1);
    }

    private void SelectDatail(Int32 pageIndex)
    {

        bl = new clsBLSetup();
        prppram = new PRPSetup();
        Int32 pageSize = Convert.ToInt32("1");

        prppram.pageIndex = pageIndex.ToString("1");
        prppram.pageSize = pageSize.ToString();

        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand("viewNews_TitleCareer", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] paramsToStore =
           new SqlParameter[4];
        paramsToStore[0] = new SqlParameter("@pageSize", SqlDbType.NVarChar);
        paramsToStore[0].Size = 20;
        cmd.Parameters.Add(paramsToStore[0]).Value = "10";
        paramsToStore[1] = new SqlParameter("@pageIndex", SqlDbType.NVarChar);
        paramsToStore[1].Size = 100;
        cmd.Parameters.Add(paramsToStore[1]).Value = "1";
        paramsToStore[2] = new SqlParameter("@newsUniversityID", SqlDbType.NVarChar);
        paramsToStore[2].Size = 60;
        cmd.Parameters.Add(paramsToStore[2]).Value = "1";
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);



        //----------------------------------------------

        TotalCount = ds.Tables[0].Rows.Count;

    }

    private void SelectDataillist(Int32 pageIndex)
    {

        bl = new clsBLSetup();
        prppram = new PRPSetup();
        Int32 pageSize = Convert.ToInt32("1");

        prppram.pageIndex = pageIndex.ToString("1");
        prppram.pageSize = pageSize.ToString();
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand("viewNews_TitleCareerList", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] paramsToStore =
           new SqlParameter[4];
        paramsToStore[0] = new SqlParameter("@pageSize", SqlDbType.NVarChar);
        paramsToStore[0].Size = 20;
        cmd.Parameters.Add(paramsToStore[0]).Value = "10";
        paramsToStore[1] = new SqlParameter("@pageIndex", SqlDbType.NVarChar);
        paramsToStore[1].Size = 100;
        cmd.Parameters.Add(paramsToStore[1]).Value = "1";
        paramsToStore[2] = new SqlParameter("@newsUniversityID", SqlDbType.NVarChar);
        paramsToStore[2].Size = 60;
        cmd.Parameters.Add(paramsToStore[2]).Value = "1";

        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds1);



        //----------------------------------------------

        TotalCount1 = ds1.Tables[0].Rows.Count;

    }
}