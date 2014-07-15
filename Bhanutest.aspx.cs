using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Bhanutest : System.Web.UI.Page
{

    EdumateService.EdumateServiceClient proxy;

    protected void Page_Load(object sender, EventArgs e)
    {
        string msg, msg1;

        if (!IsPostBack)
        {
            proxy = new EdumateService.EdumateServiceClient();
            EdumateService.listReturns[] objlistRet = new EdumateService.listReturns[1];
            EdumateService.DbPara[] arrObj = new EdumateService.DbPara[1];
            arrObj[0] = new EdumateService.DbPara();
            arrObj[0].ParaName = "@fullname";
            arrObj[0].ParaValue = "vikash";
            objlistRet = proxy.EdumateGetDataTable(out msg, out msg1, "select *  from BhanuT where fullname=@fullname");
            GridView1.DataSource = objlistRet;
            GridView1.DataBind();
        }

    }
}