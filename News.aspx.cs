using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using nmsSetupI;

public partial class News : System.Web.UI.Page
{
    PRPSetup prppram;
    PRPSetup prp;
    clsBLSetup bl;

    string type = "", memberId = "";
    static string branchId = "";
    string strcon = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
   
    SqlDataAdapter da;
    int contid;
    protected int TotalCount;
    protected DataSet ds = new DataSet();
    string title = string.Empty;

    protected int TotalCount1;
    protected DataSet ds1 = new DataSet();

    protected int TotalCount2;
    protected DataSet ds2 = new DataSet();

    
    protected void Page_Load(object sender, EventArgs e)
    {
        title = HttpContext.Current.Request.RequestContext.RouteData.Values["title"].ToString();

        if (title == "news")
        {
            SelectDatail(1);
            news.Visible = true;
            alerts.Visible = false;
            articles.Visible = false;
        }
        else if (title == "articles")
        {
            SelectDatailArticles(1);

            news.Visible = false;
            alerts.Visible = false;
            articles.Visible = true;
        }
        else if (title == "alerts")
        { 
        SelectDatailAlerts(1);
        news.Visible = false;
        alerts.Visible = true;
        articles.Visible = false;
        }
    }
    private void SelectDatail(Int32 pageIndex)
    {

        bl = new clsBLSetup();
        prppram = new PRPSetup();
        Int32 pageSize = Convert.ToInt32("1");

        prppram.pageIndex = pageIndex.ToString("1");
        prppram.pageSize = pageSize.ToString();
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand("viewNewsWithPaging1", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] paramsToStore =
           new SqlParameter[4];
        paramsToStore[0] = new SqlParameter("@pageSize", SqlDbType.NVarChar);
        paramsToStore[0].Size = 20;
        cmd.Parameters.Add(paramsToStore[0]).Value = "10";
        paramsToStore[1] = new SqlParameter("@pageIndex", SqlDbType.NVarChar);
        paramsToStore[1].Size = 100;
        cmd.Parameters.Add(paramsToStore[1]).Value = pageIndex;
        paramsToStore[2] = new SqlParameter("@newsType", SqlDbType.NVarChar);
        paramsToStore[2].Size = 60;
        cmd.Parameters.Add(paramsToStore[2]).Value = "7";

        paramsToStore[3] = new SqlParameter("@uniId", SqlDbType.NVarChar);
        paramsToStore[3].Size = 60;
        cmd.Parameters.Add(paramsToStore[3]).Value = "1";
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);



        //----------------------------------------------

        TotalCount = ds.Tables[0].Rows.Count;

    }
    private void SelectDatailAlerts(Int32 pageIndex)
    {

        bl = new clsBLSetup();
        prppram = new PRPSetup();
        Int32 pageSize = Convert.ToInt32("1");

        prppram.pageIndex = pageIndex.ToString("1");
        prppram.pageSize = pageSize.ToString();

        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand("viewNewsWithPaging1", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] paramsToStore =
           new SqlParameter[4];
        paramsToStore[0] = new SqlParameter("@pageSize", SqlDbType.NVarChar);
        paramsToStore[0].Size = 20;
        cmd.Parameters.Add(paramsToStore[0]).Value = "10";
        paramsToStore[1] = new SqlParameter("@pageIndex", SqlDbType.NVarChar);
        paramsToStore[1].Size = 100;
        cmd.Parameters.Add(paramsToStore[1]).Value = pageIndex;
        paramsToStore[2] = new SqlParameter("@newsType", SqlDbType.NVarChar);
        paramsToStore[2].Size = 60;
        cmd.Parameters.Add(paramsToStore[2]).Value = "8";

        paramsToStore[3] = new SqlParameter("@uniId", SqlDbType.NVarChar);
        paramsToStore[3].Size = 60;
        cmd.Parameters.Add(paramsToStore[3]).Value = "1";


        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds1);



        //----------------------------------------------

        TotalCount1 = ds1.Tables[0].Rows.Count;

    }
    private void SelectDatailArticles(Int32 pageIndex)
    {

        bl = new clsBLSetup();
        prppram = new PRPSetup();
        Int32 pageSize = Convert.ToInt32("1");

        prppram.pageIndex = pageIndex.ToString("1");
        prppram.pageSize = pageSize.ToString();
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand("viewNewsWithPaging1", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] paramsToStore =
           new SqlParameter[4];
        paramsToStore[0] = new SqlParameter("@pageSize", SqlDbType.NVarChar);
        paramsToStore[0].Size = 20;
        cmd.Parameters.Add(paramsToStore[0]).Value = "10";
        paramsToStore[1] = new SqlParameter("@pageIndex", SqlDbType.NVarChar);
        paramsToStore[1].Size = 100;
        cmd.Parameters.Add(paramsToStore[1]).Value = pageIndex;
        paramsToStore[2] = new SqlParameter("@newsType", SqlDbType.NVarChar);
        paramsToStore[2].Size = 60;
        cmd.Parameters.Add(paramsToStore[2]).Value = "9";

        paramsToStore[3] = new SqlParameter("@uniId", SqlDbType.NVarChar);
        paramsToStore[3].Size = 60;
        cmd.Parameters.Add(paramsToStore[3]).Value = "1";



        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds2);



        //----------------------------------------------

        TotalCount2 = ds2.Tables[0].Rows.Count;

    }

   
}