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

public partial class ViewCareerDetails : System.Web.UI.Page
{
    PRPSetup prppram;
    PRPSetup prp;
    clsBLSetup bl;

    string type = "", memberId = "";
    static string branchId = "";
    string strcon = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
    protected int TotalCount;
    protected int TotalCount1;
    protected int TotalCount2;
    SqlDataAdapter da;
    int contid;
    protected DataSet ds = new DataSet();
    protected DataSet ds1 = new DataSet();
    string NewsId = "";
    string CareerId = "";
    string UniId = "";
    string sLiteral = "", comment = "", username = "", pwd = "";
    protected DataSet dss = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
      

        if (RouteData.Values["values"].ToString() != null)
        {
          

            UniId = HttpContext.Current.Request.RequestContext.RouteData.Values["values"].ToString();
            CareerId = HttpContext.Current.Request.RequestContext.RouteData.Values["pps"].ToString();

        }
        else 
        {
            CareerId = Request.QueryString["Uid"].ToString();
        
        }
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
        SqlParameter[] paramsToStore =new SqlParameter[4];
        paramsToStore[0] = new SqlParameter("@pageSize", SqlDbType.NVarChar);
        paramsToStore[0].Size = 20;
        cmd.Parameters.Add(paramsToStore[0]).Value = "10";
        paramsToStore[1] = new SqlParameter("@pageIndex", SqlDbType.NVarChar);
        paramsToStore[1].Size = 100;
        cmd.Parameters.Add(paramsToStore[1]).Value = "1";
        paramsToStore[2] = new SqlParameter("@newsUniversityID", SqlDbType.NVarChar);
        paramsToStore[2].Size = 60;
        cmd.Parameters.Add(paramsToStore[2]).Value = "3";

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
        SqlCommand cmd = new SqlCommand("viewNews_TitleCareerListType", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] paramsToStore =
           new SqlParameter[4];
        paramsToStore[0] = new SqlParameter("@pageSize", SqlDbType.NVarChar);
        paramsToStore[0].Size = 20;
        cmd.Parameters.Add(paramsToStore[0]).Value = "10";
        paramsToStore[1] = new SqlParameter("@pageIndex", SqlDbType.NVarChar);
        paramsToStore[1].Size = 100;
        cmd.Parameters.Add(paramsToStore[1]).Value = "1";
     

        paramsToStore[2] = new SqlParameter("@catID", SqlDbType.NVarChar);
        paramsToStore[2].Size = 60;
        cmd.Parameters.Add(paramsToStore[2]).Value = CareerId;


        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds1);



        //----------------------------------------------

        TotalCount1 = ds1.Tables[0].Rows.Count;

    }
    protected void btn1_Click(object sender, EventArgs e)
    {
        // insertComment();
        comment = Request["comment"].ToString();
        username = Request["username"].ToString();
        pwd = Request["password"].ToString();
        insertComment();
        // string cmt = Request["comment"].ToString();
    }

    public void insertComment()
    {
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand("Sp_insert", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "Sp_insert";
        try
        {
            SqlParameter[] paramsToStore = new SqlParameter[2];

            paramsToStore[0] = new SqlParameter("@email", SqlDbType.NVarChar);
            paramsToStore[0].Size = 20;
            cmd.Parameters.Add(paramsToStore[0]).Value = username;
            paramsToStore[1] = new SqlParameter("@comment", SqlDbType.NVarChar);
            paramsToStore[1].Size = 100;
            cmd.Parameters.Add(paramsToStore[1]).Value = comment;


        }

        catch (Exception excp)
        {
            lblMsg.ForeColor = System.Drawing.Color.Red;
            lblMsg.Text = excp.Message;
        }
        con.Open();
        cmd.Connection = con;
        int y = cmd.ExecuteNonQuery();

        if (y > 0)
        {
            lblMsg.Visible = true;
            lblMsg.ForeColor = System.Drawing.Color.Green;
            lblMsg.Text = "Insert Successfully...";

            bindUNI();
        }

        else
        {
            Response.Write("<script>window.alert('Envalid Email or PassWord Plz Register')</script>");
        }


    }
    public void bindUNI()
    {
        DataSet ds = new DataSet();
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand("Sp_Commentdetails", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] paramsToStore =
           new SqlParameter[4];
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dss);
        TotalCount2 = dss.Tables[0].Rows.Count;

    }
}