using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using nmsSetup;
using nmsSetupWeb;
using System.Collections.Generic;
public partial class Add_Institute_viewServices : System.Web.UI.Page
{
    clsBLSetup obj;
    PRPSetup objprp, objparm;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            getContent();

        }
    }


    public void getContent()
    {
        obj = new clsBLSetup();
        objprp = new PRPSetup();
        objparm = new PRPSetup();
        if (Request.QueryString["id"] != null)
        {
            objparm.id = Request.QueryString["id"].ToString();
            objprp = obj.SelNews(objparm);
             string str = "";
             str += "<table style='width:710px;padding:10px;'><tr><td>" + objprp.description + "</td></tr></table>";
             str += "<div style='height:15px;'> </div>";
             newsDiv.InnerHtml = str;
        }
    }
}