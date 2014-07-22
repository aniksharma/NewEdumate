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
    protected DataSet ds;
    protected DataSet dsImage;
    string contid = "";
    string UniId = "";
    string ContIds = "";
    protected DataSet dss;

    EdumateService.EdumateServiceClient proxy;
    string msg, msg1;
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
        proxy = new EdumateService.EdumateServiceClient();
        EdumateService.DbPara[] arrObj = new EdumateService.DbPara[0];
        ds = new DataSet();
        ds = proxy.EdumateGetDataSetSP(out msg, out msg1, arrObj, "viewUniversityWeb_srikant");
        TotalCount = ds.Tables[0].Rows.Count;

    }
    public void BindImage()
    {
        proxy = new EdumateService.EdumateServiceClient();
        EdumateService.DbPara[] arrObj = new EdumateService.DbPara[0];
        dsImage = new DataSet();
        dsImage = proxy.EdumateGetDataSetSP(out msg, out msg1, arrObj, "viewImageGalleryHome");
        Totalimage = dsImage.Tables[0].Rows.Count;

    }
    protected void ddlNopage_SelectedIndexChanged(object sender, EventArgs e)
    {
        SelectDatail(1);
    }
    private void SelectDatail(Int32 pageIndex)
    {

        proxy = new EdumateService.EdumateServiceClient();
        EdumateService.DbPara[] arrObj = new EdumateService.DbPara[4];
        arrObj[0] = new EdumateService.DbPara();
        arrObj[0].ParaName = "@pageSize";
        arrObj[0].ParaValue = ddlNopage.SelectedValue;
        arrObj[1] = new EdumateService.DbPara();
        arrObj[1].ParaName = "@pageIndex";
        arrObj[1].ParaValue = Convert.ToString(pageIndex);
        arrObj[2] = new EdumateService.DbPara();
        arrObj[2].ParaName = "@ContId";
        arrObj[2].ParaValue = "0";
        arrObj[3] = new EdumateService.DbPara();
        arrObj[3].ParaName = "@collegeID";
        arrObj[3].ParaValue = ContIds;
        ds = new DataSet();
        ds = proxy.EdumateGetDataSetSP(out msg, out msg1, arrObj, "viewCollegeType_srikant");
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
        proxy = new EdumateService.EdumateServiceClient();
        EdumateService.DbPara[] arrObj = new EdumateService.DbPara[0];
        dss = new DataSet();
        dss = proxy.EdumateGetDataSetSP(out msg, out msg1, arrObj, "Sp_Commentdetails");
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