using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class Admin_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
        //Response.Cache.SetCacheability(HttpCacheability.NoCache);
        //Response.Cache.SetNoStore();
        //if (!Page.IsPostBack)
        //{
        //    if (Request.QueryString["logout"] != null)
        //    {
        //        if (Request.QueryString["logout"] == "logout")
        //        {
        //            Response.Redirect("ALogin.aspx");
        //        }
        //        else if (Request.QueryString["logout"] == "session")
        //        {
        //            Response.Redirect("ALogin.aspx");
        //        }
        //    }
        //}
    }
}