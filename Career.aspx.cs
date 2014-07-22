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

    protected int TotalCount;
    protected int TotalCount1;
    protected DataSet ds;
    protected DataSet ds1;
    protected DataSet ds2;
    EdumateService.EdumateServiceClient proxy;
    string msg, msg1;
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
        proxy = new EdumateService.EdumateServiceClient();
        EdumateService.DbPara[] arrObj = new EdumateService.DbPara[4];
        arrObj[0] = new EdumateService.DbPara();
        arrObj[0].ParaName = "@pageSize";
        arrObj[0].ParaValue = "10";
        arrObj[1] = new EdumateService.DbPara();
        arrObj[1].ParaName = "@pageIndex";
        arrObj[1].ParaValue = "1";
        arrObj[2] = new EdumateService.DbPara();
        arrObj[2].ParaName = "@newsUniversityID";
        arrObj[2].ParaValue = "2";
        arrObj[3] = new EdumateService.DbPara();
        arrObj[3].ParaName = "@catID";
        arrObj[3].ParaValue = ddl.SelectedValue;
        ds = new DataSet();
        ds = proxy.EdumateGetDataSetSP(out msg, out msg1, arrObj, "viewNews_TitleSelectedCareer");
        //----------------------------------------------

        TotalCount = ds.Tables[0].Rows.Count;

    }

    private void SelectDataillist(Int32 pageIndex)
    {
        proxy = new EdumateService.EdumateServiceClient();
        EdumateService.DbPara[] arrObj = new EdumateService.DbPara[4];
        arrObj[0] = new EdumateService.DbPara();
        arrObj[0].ParaName = "@pageSize";
        arrObj[0].ParaValue = "10";
        arrObj[1] = new EdumateService.DbPara();
        arrObj[1].ParaName = "@pageIndex";
        arrObj[1].ParaValue = "1";
        arrObj[2] = new EdumateService.DbPara();
        arrObj[2].ParaName = "@newsUniversityID";
        arrObj[2].ParaValue = "2";
        arrObj[3] = new EdumateService.DbPara();
        arrObj[3].ParaName = "@catID";
        arrObj[3].ParaValue = ddl.SelectedValue;
        ds1 = new DataSet();
        ds1 = proxy.EdumateGetDataSetSP(out msg, out msg1, arrObj, "viewNews_TitleSelectedCareerList");
        //----------------------------------------------

        TotalCount1 = ds1.Tables[0].Rows.Count;

    }
    public void BindCountry()
    {
        proxy = new EdumateService.EdumateServiceClient();
        EdumateService.DbPara[] arrObj = new EdumateService.DbPara[0];
        ds = new DataSet();
        ds = proxy.EdumateGetDataSetSP(out msg, out msg1, arrObj, "TitleCareerList");
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