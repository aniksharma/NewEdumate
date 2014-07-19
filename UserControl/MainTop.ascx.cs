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
using st;

public partial class UserControl_MainTop : System.Web.UI.UserControl
{
    string name = "";
    string UniNames = "";
    DataSet ds;
    EdumateService.EdumateServiceClient proxy;
    string msg, msg1;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (name != null)
        {
            Session["UniName"] = name;
            UniNames = Session["UniName"].ToString();
        }
        if (!IsPostBack == true)
        {
            BindCountry();
        }
    }

    public void BindCountry()
    {
        proxy = new EdumateService.EdumateServiceClient();
        ds = new DataSet();
        EdumateService.DbPara[] arrObj = new EdumateService.DbPara[0];
        ds = proxy.EdumateGetDataSetSP(out msg, out msg1, arrObj, "viewCountryDetails");
        ddlcountry.DataSource = ds;
        ddlcountry.DataValueField = "id";
        ddlcountry.DataTextField = "name";
        ststics1.ddlname = "Country";
        ddlcountry.DataBind();
    }
}