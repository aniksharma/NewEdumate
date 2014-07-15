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

public partial class Career : System.Web.UI.Page
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
    protected DataSet ds;
    protected DataSet ds1 = new DataSet();
    protected DataSet ds2 = new DataSet();
    string NewsId = "";
    EdumateService.EdumateServiceClient proxy;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack == true)
        {
            BindCountry();
            SelectDatail(1);
            SelectDataillist(1);
        }
    }

    private void SelectDatail(Int32 pageIndex)
    {

        bl = new clsBLSetup();
        prppram = new PRPSetup();
        Int32 pageSize = Convert.ToInt32("1");

        prppram.pageIndex = pageIndex.ToString("1");
        prppram.pageSize = pageSize.ToString();
        //---------for page work here
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand("viewNews_TitleSelectedCareer", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] paramsToStore = new SqlParameter[4];
        paramsToStore[0] = new SqlParameter("@pageSize", SqlDbType.NVarChar);
        paramsToStore[0].Size = 20;
        cmd.Parameters.Add(paramsToStore[0]).Value = "10";
        paramsToStore[1] = new SqlParameter("@pageIndex", SqlDbType.NVarChar);
        paramsToStore[1].Size = 100;
        cmd.Parameters.Add(paramsToStore[1]).Value = "1";
        paramsToStore[2] = new SqlParameter("@newsUniversityID", SqlDbType.NVarChar);
        paramsToStore[2].Size = 60;
        cmd.Parameters.Add(paramsToStore[2]).Value = "2";

        paramsToStore[3] = new SqlParameter("@catID", SqlDbType.NVarChar);
        paramsToStore[3].Size = 60;
        cmd.Parameters.Add(paramsToStore[3]).Value = ddl.SelectedValue;


        SqlDataAdapter da = new SqlDataAdapter(cmd);
        ds = new DataSet();
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
        //---------for page work here
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand("viewNews_TitleSelectedCareerList", con);
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
        cmd.Parameters.Add(paramsToStore[2]).Value = "2";

        paramsToStore[3] = new SqlParameter("@catID", SqlDbType.NVarChar);
        paramsToStore[3].Size = 60;
        cmd.Parameters.Add(paramsToStore[3]).Value = ddl.SelectedValue;


        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds1);



        //----------------------------------------------

        TotalCount1 = ds1.Tables[0].Rows.Count;

    }
    public void BindCountry()
    {
        proxy = new EdumateService.EdumateServiceClient();
        string msg, msg1;

        EdumateService.DbPara[] arrObj = new EdumateService.DbPara[0];

        //da.Fill(ds);
        ds = new DataSet();
        ds = proxy.EdumateGetDataSetSP(out msg, out msg1, arrObj, "TitleCareerList");


        //SqlConnection con = new SqlConnection(strcon);
        //SqlCommand cmd = new SqlCommand("TitleCareerList", con);
        //cmd.CommandType = CommandType.StoredProcedure;
        //SqlParameter[] paramsToStore =
        //   new SqlParameter[4];
        //SqlDataAdapter da = new SqlDataAdapter(cmd);
        //da.Fill(ds2);
        ddl.DataSource = ds;
        ddl.DataValueField = "newsTypeID";
        ddl.DataTextField = "newsType";
        ddl.DataBind();

    }
    protected void ddl_SelectedIndexChanged(object sender, EventArgs e)
    {
        SelectDatail(1);
        SelectDataillist(1);
    }
}