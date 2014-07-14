using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using nmsSetup;
using nmsSetupWeb;
using System.Collections.Generic;
public partial class MasterPage : System.Web.UI.MasterPage
{
    clsBLSetup obj;
    PRPSetup objprp, objparm; 
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            getNews();

        }
    }
    public void getNews()
    {
       
    }

}
