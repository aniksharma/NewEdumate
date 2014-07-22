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
using System.Web.Routing;
using javax.jws;

public partial class UniversityMain : System.Web.UI.Page
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
    int contid;
    string id = "";
    protected string Country = "";

    int stateid;
    protected string StateName = "";
    EdumateService.EdumateServiceClient Proxy;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        contid = Convert.ToInt32(Request.QueryString["ContId"]);
        stateid = Convert.ToInt32(Request.QueryString["State"]);
        StateName = Convert.ToString(Request.QueryString["StateName"]);
        
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
        //updated by Anik

        //SqlConnection con = new SqlConnection(strcon);
        //SqlCommand cmd = new SqlCommand("viewUniversityWeb_srikant", con);
        //cmd.CommandType = CommandType.StoredProcedure;
        //SqlParameter[] paramsToStore =
        //   new SqlParameter[4];
        //SqlDataAdapter da = new SqlDataAdapter(cmd);
        string msg, msg1;
        SqlDataAdapter da = new SqlDataAdapter();
        EdumateService.DbPara[] arrObj = new EdumateService.DbPara[0];
        ds = Proxy.EdumateGetDataSetSP(out msg, out msg1, arrObj, "viewUniversityWeb_srikant");
        da.Fill(ds);
        TotalCount = ds.Tables[0].Rows.Count;

    }

    public void BindImage()
    {
        //Updated by Anik
        //SqlConnection con = new SqlConnection(strcon);
        //SqlCommand cmd = new SqlCommand("viewImageGalleryHome", con);
        //cmd.CommandType = CommandType.StoredProcedure;
        //SqlParameter[] paramsToStore =
        //   new SqlParameter[4];
        //SqlDataAdapter da = new SqlDataAdapter(cmd);
        string msg, msg1;
        SqlDataAdapter da = new SqlDataAdapter();
        EdumateService.DbPara[] arrObj = new EdumateService.DbPara[0];
        ds = Proxy.EdumateGetDataSetSP(out msg, out msg1, arrObj, "viewImageGalleryHome");
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
           new SqlParameter[4];
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
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        Country = ds.Tables[0].Rows[0]["uniContact"].ToString();

        //----------------------------------------------
        TotalCount = ds.Tables[0].Rows.Count;

    }

    void Application_Start(object sender, EventArgs e)
    {
        RegisterRoutes(RouteTable.Routes);
    }

    public static void RegisterRoutes(RouteCollection routes)
    {
        routes.MapPageRoute("",
            "Category/{action}/{categoryName}",
            "~/UniversityMain.aspx",
            true,
            new RouteValueDictionary { { "categoryName", "food" }, { "action", "show" } });
    }




}