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

public partial class CollegeDetails : System.Web.UI.Page
{
    PRPSetup prppram;
    PRPSetup prp;
    clsBLSetup bl;

    string type = "", memberId = "";
    static string branchId = "";
    string strcon = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
    protected int TotalCount;
    protected int TotalCount2;
    protected int Totalimage;
    SqlDataAdapter da;

    string sLiteral = "", comment = "", username = "", pwd = "";
    protected DataSet ds = new DataSet();
    protected DataSet dsImage = new DataSet();
    string contid = "";
    string UniId = "";
    string ContIds = "";
    protected DataSet dss = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {

            if (RouteData.Values["valuess"] != null)
            {

                UniId = HttpContext.Current.Request.RequestContext.RouteData.Values["p1"].ToString();
                ContIds = HttpContext.Current.Request.RequestContext.RouteData.Values["p1s"].ToString();
                SelectDatail(1);
                BindImage();
            }

            else
            {
                contid = Convert.ToString(Request.QueryString["Unid"]);
                string[] mlog;
                mlog = new string[3];

            UniId = mlog[0];
            ContIds = mlog[1];

            if (contid != null)
            {
                SelectDatail(1);
                BindImage();
            }
            else
            {
                SelectDatail(1);
                BindImage();

                }
            }
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

        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand("viewCollegeType_srikant", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] paramsToStore =
           new SqlParameter[5];
        paramsToStore[0] = new SqlParameter("@pageSize", SqlDbType.NVarChar);
        paramsToStore[0].Size = 20;
        cmd.Parameters.Add(paramsToStore[0]).Value = ddlNopage.SelectedValue;
        paramsToStore[1] = new SqlParameter("@pageIndex", SqlDbType.NVarChar);
        paramsToStore[1].Size = 100;
        cmd.Parameters.Add(paramsToStore[1]).Value = pageIndex;
        paramsToStore[2] = new SqlParameter("@ContId", SqlDbType.Int);
        paramsToStore[2].Size = 60;
        cmd.Parameters.Add(paramsToStore[2]).Value = "0";
        paramsToStore[3] = new SqlParameter("@collegeID", SqlDbType.Int);
        paramsToStore[3].Size = 60;
        cmd.Parameters.Add(paramsToStore[3]).Value = ContIds;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);



        //----------------------------------------------

        TotalCount = ds.Tables[0].Rows.Count;

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

            bindUNI1();
        }

        else
        {
            Response.Write("<script>window.alert('Envalid Email or PassWord Plz Register')</script>");
        }


    }
    public void bindUNI1()
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
    protected void btn1_Click(object sender, EventArgs e)
    {
        // insertComment();
        comment = Request["comment"].ToString();
        username = Request["username"].ToString();
        pwd = Request["password"].ToString();
        insertComment();
        // string cmt = Request["comment"].ToString();
    }
}