using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using nmsSetupI;
using System.Data.SqlClient;
using System.Data;

public partial class UserControl_MainMiddle : System.Web.UI.UserControl
{
 
    protected int TotalCount;
    protected int TotalCount1;
    protected int TotalCount2;
    protected DataSet ds;
    protected DataSet ds1;
    protected DataSet ds2;
    EdumateService.EdumateServiceClient proxy;
    string msg, msg1;
    protected void Page_Load(object sender, EventArgs e)
    {
        SelectDatail(1);
        SelectDatailnews(1);
        SelectDatailAlerts(1);
    }

    private void SelectDatail(Int32 pageIndex)
    {
        proxy = new EdumateService.EdumateServiceClient();
        EdumateService.DbPara[] arrObj = new EdumateService.DbPara[4];
        arrObj[0] = new EdumateService.DbPara();
        arrObj[0].ParaName = "@pageSize";
        arrObj[0].ParaValue = "7";
        arrObj[1] = new EdumateService.DbPara();
        arrObj[1].ParaName = "@pageIndex";
        arrObj[1].ParaValue = Convert.ToString(pageIndex);
        arrObj[2] = new EdumateService.DbPara();
        arrObj[2].ParaName = "@newsType";
        arrObj[2].ParaValue = "7";
        arrObj[3] = new EdumateService.DbPara();
        arrObj[3].ParaName = "@uniId";
        arrObj[3].ParaValue = "1";
        ds = new DataSet();
        ds = proxy.EdumateGetDataSetSP(out msg, out msg1, arrObj, "viewNewsWithPaging1");
        //----------------------------------------------
        if (ds.Tables[0].Rows.Count > 0)
        {
            TotalCount = ds.Tables[0].Rows.Count;
        }

    }
    private void SelectDatailnews(Int32 pageIndex)
    {
        proxy = new EdumateService.EdumateServiceClient();
        EdumateService.DbPara[] arrObj = new EdumateService.DbPara[4];
        arrObj[0] = new EdumateService.DbPara();
        arrObj[0].ParaName = "@pageSize";
        arrObj[0].ParaValue = "7";
        arrObj[1] = new EdumateService.DbPara();
        arrObj[1].ParaName = "@pageIndex";
        arrObj[1].ParaValue = Convert.ToString(pageIndex);
        arrObj[2] = new EdumateService.DbPara();
        arrObj[2].ParaName = "@newsType";
        arrObj[2].ParaValue = "9";
        arrObj[3] = new EdumateService.DbPara();
        arrObj[3].ParaName = "@uniId";
        arrObj[3].ParaValue = "1";
        ds1 = new DataSet();
        ds1 = proxy.EdumateGetDataSetSP(out msg, out msg1, arrObj, "viewNewsWithPaging1");        //----------------------------------------------
        if (ds1.Tables[0].Rows.Count > 0)
        {
            TotalCount1 = ds1.Tables[0].Rows.Count;
        }

    }
    private void SelectDatailAlerts(Int32 pageIndex)
    {

        proxy = new EdumateService.EdumateServiceClient();
        EdumateService.DbPara[] arrObj = new EdumateService.DbPara[4];
        arrObj[0] = new EdumateService.DbPara();
        arrObj[0].ParaName = "@pageSize";
        arrObj[0].ParaValue = "7";
        arrObj[1] = new EdumateService.DbPara();
        arrObj[1].ParaName = "@pageIndex";
        arrObj[1].ParaValue = Convert.ToString(pageIndex);
        arrObj[2] = new EdumateService.DbPara();
        arrObj[2].ParaName = "@newsType";
        arrObj[2].ParaValue = "8";
        arrObj[3] = new EdumateService.DbPara();
        arrObj[3].ParaName = "@uniId";
        arrObj[3].ParaValue = "1";
        ds2 = new DataSet();
        ds2 = proxy.EdumateGetDataSetSP(out msg, out msg1, arrObj, "viewNewsWithPaging1");
        if (ds2.Tables[0].Rows.Count > 0)
        {
            TotalCount2 = ds2.Tables[0].Rows.Count;
        }
    }
}