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
    string title = string.Empty;
    protected DataSet ds;
    protected DataSet ds1;
    protected DataSet ds2;
    EdumateService.EdumateServiceClient proxy;
    string msg, msg1;
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
        proxy = new EdumateService.EdumateServiceClient();
        EdumateService.DbPara[] arrObj = new EdumateService.DbPara[4];
        arrObj[0] = new EdumateService.DbPara();
        arrObj[0].ParaName = "@pageSize";
        arrObj[0].ParaValue = "10";
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

    }
    private void SelectDatailAlerts(Int32 pageIndex)
    {
        proxy = new EdumateService.EdumateServiceClient();
        EdumateService.DbPara[] arrObj = new EdumateService.DbPara[4];
        arrObj[0] = new EdumateService.DbPara();
        arrObj[0].ParaName = "@pageSize";
        arrObj[0].ParaValue = "10";
        arrObj[1] = new EdumateService.DbPara();
        arrObj[1].ParaName = "@pageIndex";
        arrObj[1].ParaValue = Convert.ToString(pageIndex);
        arrObj[2] = new EdumateService.DbPara();
        arrObj[2].ParaName = "@newsType";
        arrObj[2].ParaValue = "8";
        arrObj[3] = new EdumateService.DbPara();
        arrObj[3].ParaName = "@uniId";
        arrObj[3].ParaValue = "1";
        ds1 = new DataSet();
        ds1 = proxy.EdumateGetDataSetSP(out msg, out msg1, arrObj, "viewNewsWithPaging1");


    }
    private void SelectDatailArticles(Int32 pageIndex)
    {
        proxy = new EdumateService.EdumateServiceClient();
        EdumateService.DbPara[] arrObj = new EdumateService.DbPara[4];
        arrObj[0] = new EdumateService.DbPara();
        arrObj[0].ParaName = "@pageSize";
        arrObj[0].ParaValue = "10";
        arrObj[1] = new EdumateService.DbPara();
        arrObj[1].ParaName = "@pageIndex";
        arrObj[1].ParaValue = Convert.ToString(pageIndex);
        arrObj[2] = new EdumateService.DbPara();
        arrObj[2].ParaName = "@newsType";
        arrObj[2].ParaValue = "9";
        arrObj[3] = new EdumateService.DbPara();
        arrObj[3].ParaName = "@uniId";
        arrObj[3].ParaValue = "1";
        ds2 = new DataSet();
        ds2 = proxy.EdumateGetDataSetSP(out msg, out msg1, arrObj, "viewNewsWithPaging1");
    }
}