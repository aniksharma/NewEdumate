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
    clsBLSetup obj;
    PRPSetup objprp, objparm;
    static string Id = "";
    string strcon = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
    DataSet ds = new DataSet();
    string name = "";
    string UniNames = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (name != null)
        {
            Session["UniName"] = name;
            UniNames = Session["UniName"].ToString();
        }
        if (!IsPostBack == true)
        {
        }
    }

     public void BindCountry()
    {
      
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand("viewCountryDetails", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] paramsToStore =
           new SqlParameter[4];
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        ddlcountry.DataSource = ds;
       
        ddlcountry.DataValueField = "id";
        ddlcountry.DataTextField = "name";
        ststics1.ddlname = "Country";

        ddlcountry.DataBind();
      

    }

     protected void ddlcountry_SelectedIndexChanged(object sender, EventArgs e)
     {
     }
   
    
}