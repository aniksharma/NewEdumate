using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using nmsSetupI;
using nmsDropDownJob;
using System.Configuration;

public partial class EducationBoard : System.Web.UI.Page
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
    protected string Country = "";
    protected string StateName = "";
    int stateid;

    EdumateService.EdumateServiceClient proxy;
    string msg, msg1;
    protected void Page_Load(object sender, EventArgs e)
    {

        SelectDatail(1);
        contid = Convert.ToInt32(Request.QueryString["ContId"]);
        stateid = Convert.ToInt32(Request.QueryString["State"]);
        StateName = Convert.ToString(Request.QueryString["StateName"]);

    }
    private void SelectDatail(Int32 pageIndex)
    {
        proxy = new EdumateService.EdumateServiceClient();
        EdumateService.DbPara[] arrObj = new EdumateService.DbPara[3];
        arrObj[0] = new EdumateService.DbPara();
        arrObj[0].ParaName = "@pageSize";
        arrObj[0].ParaValue = "vikash";
        arrObj[1] = new EdumateService.DbPara();
        arrObj[1].ParaName = "@pageIndex";
        arrObj[1].ParaValue = "vikash";
        arrObj[2] = new EdumateService.DbPara();
        arrObj[2].ParaName = "@cntId";
        arrObj[2].ParaValue = "vikash";
        ds = new DataSet();
        ds = proxy.EdumateGetDataSetPara(out msg, out msg1, arrObj, "spEducationMarch");
        //----------------------------------------------

        TotalCount = ds.Tables[0].Rows.Count;

    }
    //private void binduniversity()
    //{
    //    clsBLdropDown drp = new clsBLdropDown();
    //    clsPRPdropdown drpprp = new clsPRPdropdown();

    //    drpprp.spName = "viewUniversityWeb";
    //    drp.bindDropDown(drpprp);

    //}
}