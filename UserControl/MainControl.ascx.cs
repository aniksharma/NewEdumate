using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using nmsDropDownI;
using nmsSetupI;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using st;

public partial class UserControl_MainControl : System.Web.UI.UserControl
{
    clsBLSetup obj;
    PRPSetup objprp, objparm;
    static string Id = "";
    string strcon = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
    DataSet ds = new DataSet();
    string name = "";
    string UniNames = "";
    

    EdumateService.EdumateServiceClient proxy;
    protected void Page_Load(object sender, EventArgs e)
    {

        name = Request.QueryString["name"];
        if (name != null)
        {
            Session["UniName"] = name;
            UniNames = Session["UniName"].ToString();
        }
        if (!IsPostBack == true)
        {


            binduniversity();

            BindCountry();
        }
    }
    private void binduniversity()
    {
        clsBLdropDown drp = new clsBLdropDown();
        ststics1.ddlname = "Country";
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddlcountry;
        drpprp.spName = "viewCountry";
        drp.bindDropDown(drpprp);
    }
    public void BindCountry()
    {
        proxy = new EdumateService.EdumateServiceClient();
        string msg,msg1;
        //SqlConnection con = new SqlConnection(strcon);
        //SqlCommand cmd = new SqlCommand("viewCountryDetails", con);
        //cmd.CommandType = CommandType.StoredProcedure;
        //SqlParameter[] paramsToStore =
        //   new SqlParameter[4];

        //SqlDataAdapter da = new SqlDataAdapter(cmd);
        EdumateService.DbPara[] arrObj = new EdumateService.DbPara[0];
        
        //da.Fill(ds);
        ds = proxy.EdumateGetDataSetSP(out msg, out msg1, arrObj, "viewCountryDetails");
        ddlcountry.DataSource = ds;

        ddlcountry.DataValueField = "id";
        ddlcountry.DataTextField = "name";


        ddlcountry.DataBind();


    } 
    protected void ddlcountry_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlcountry.SelectedValue != "0" && UniNames == "Uni")
        {

            Response.Redirect("UniversityMain.aspx?ContId=" + ddlcountry.SelectedValue);
        }

        else if (ddlcountry.SelectedValue != "0" && name == "College")
        {

            Response.Redirect("CollegeMain.aspx?ContId=" + ddlcountry.SelectedValue);
        }

        else if (ddlcountry.SelectedValue != "0" && name == "School")
        {

            Response.Redirect("SchoolMain.aspx?ContId=" + ddlcountry.SelectedValue);
        }

        else if (ddlcountry.SelectedValue != "0" && name == "Inst")
        {

            Response.Redirect("InstitutesMain.aspx?ContId=" + ddlcountry.SelectedValue);
        }
    }
}