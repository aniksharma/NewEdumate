using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using nmsProfile;
using nmsSetup;
using nmsSetupWeb;
using nmsEditor;
using System.Collections.Generic;
using System.Data;

using System.Net;
using System.Web.Script.Serialization;


public partial class mange_Default : System.Web.UI.Page
{
    string collageName = "", lastpart = "", stuid="";
    string name = "", temp = "", page = "",code="", css="";

    DataSet ds;
    string websitename="";
    protected void Page_Load(object sender, EventArgs e)
        {

        if (Page.IsPostBack == false)
        {
            Label1.Text = "yes i am here ";
            //GetIpAddress();
            try
            {
                if (Page.RouteData.Values["values"] != null)
                {
                    checkParamaters();
                    InsertViewStatus();
                }
                else
                {
                    Response.Redirect("default.aspx",false);

                }
            }
            catch( Exception ex)
            {
            Label1.Text+=  ex.Message;
            }
        }
      
      
    }
    private void checkParamaters()
    {
        lastpart = Page.RouteData.Values["values"].ToString();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        con.Open();
        cmd.Connection = con;
        cmd.CommandText = "spuserTempateCheck";
        cmd.Parameters.AddWithValue("@title", lastpart);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        // Code that runs on application startup
        collageName = cmd.ExecuteScalar().ToString();
        cmd.Dispose();
        con.Close();

        if (collageName == "" || collageName=="nill")
        {
            Response.Redirect("default.aspx",false);

        }
        else
        {
            string[] mlog;
            mlog = new string[2];
            mlog = collageName.Split('-');
            name = lastpart;
            code=mlog[0];
            temp = mlog[1];
            css = mlog[2];
            page = "Home";

            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = con;
            cmd2.CommandText = "sp_getname_web";
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.AddWithValue("@collegeCodeId", code);
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd2);
            adp.Fill(dt);
       
            if (dt.Rows.Count > 0)
            {
                websitename = dt.Rows[0]["collegeWebSite"].ToString();
            }

            bindmenuNew();
            HttpCookie StudentCookies = new HttpCookie("cssCokkie");
            StudentCookies.Value = css;
            StudentCookies.Expires = DateTime.Now.AddDays(10);
            Response.Cookies.Add(StudentCookies);

            HttpCookie StudentCookies1 = new HttpCookie("cssCokkie");
            StudentCookies1.Value = temp;
            StudentCookies1.Expires = DateTime.Now.AddDays(10);
            Response.Cookies.Add(StudentCookies1);
            Response.Redirect("../Web/" + websitename + "/" + page, false);
            }


       
    }

    //private void GetIpAddress()
    //{
    //    string ipAddress = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
    //    if (string.IsNullOrEmpty(ipAddress))
    //    {
    //        ipAddress = Request.ServerVariables["REMOTE_ADDR"];
    //    }

    //    string APIKey = "2d759b1d2e1b02ee8aebda9e9a006775c940865c4d24c35235ecb9b680ee2e25";
    //    string url = string.Format("http://api.ipinfodb.com/v3/ip-city/?key={0}&ip={1}&format=json", APIKey, ipAddress);
    //    using (WebClient client = new WebClient())
    //    {
    //        string json = client.DownloadString(url);
    //        Location location = new JavaScriptSerializer().Deserialize<Location>(json);
    //        List<Location> locations = new List<Location>();

    //        locations.Add(location);

    //        foreach (Location l in locations)
    //        {
    //            ViewState["address"] = Session["pip"] = l.IPAddress;
    //            ViewState["Latitu"] = l.Latitude;
    //            ViewState["LatituII"] = l.Longitude;
    //            ViewState["CountryCide"] = l.CountryCode;
    //            ViewState["TimeZone"] = l.TimeZone;
    //            //-----------
    //            ViewState["name"] = Session["pname"] = l.CountryName;
    //            ViewState["city"] = Session["pcity"] = l.CityName;
    //            ViewState["state"] = Session["pstate"] = l.RegionName;


    //        }
    //       }
    //}
    private void InsertViewStatus()
    {

        clsBLSetupWeb obj = new clsBLSetupWeb();
        PRPSetupWeb objprp = new PRPSetupWeb();
        string st = DateTime.Now.ToString();
        objprp.address = "insert into tblviewstatus(viewCode,viewDate,ViewStatus,pip,ipName,ipCity,ipState) values(" + code + ",'" + st + "'," + "4" + ",'" + Session["pip"].ToString() + "','" + Session["pname"].ToString() + "','" + Session["pcity"].ToString() + "','" + Session["pstate"].ToString() + "');";       
        obj.InsViewStatus(objprp);


       
    }
    private void bindmenuNew( )
    { 
        Int32 t =Convert.ToInt32(temp) ;
        if (t == 30 || t == 31 || t == 32 || t == 33 || t == 34 || t == 35 || t == 36 || t == 37 )
        {
            PRPEditor prppram = new PRPEditor();
            clsBLEditor bl = new clsBLEditor();

            prppram.Id = code;
            prppram.State = temp;
            Label1.Text = code.ToString() + "  " + temp.ToString() + "  ";


            ds = new DataSet();
            ds = bl.spMenuForMicro_srikant_sal_stu(prppram);

            Session["datamenu"] = ds;
            string linkurl = ds.Tables[0].Rows[0][1].ToString();

            Label1.Text = code.ToString() + "  " + temp.ToString() + "  " + linkurl;

       }
        else
        {

            PRPEditor prppram = new PRPEditor();
            clsBLEditor bl = new clsBLEditor();

            prppram.Id = code;
            prppram.State = temp;
            Label1.Text = code.ToString() + "  " + temp.ToString() + "  ";


            ds = new DataSet();
            ds = bl.spMenuForMicro(prppram);

            Session["datamenu"] = ds;
            string linkurl = ds.Tables[0].Rows[0][1].ToString();

            Label1.Text = code.ToString() + "  " + temp.ToString() + "  " + linkurl;
        }
      
    }
}