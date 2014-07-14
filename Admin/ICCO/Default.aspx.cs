using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using nmsSetupI;

public partial class Admin_ICCO_Default : System.Web.UI.Page
{
    PRPSetup prppram;
    PRPSetup prp;
    clsBLSetup bl;
    protected void Page_Load(object sender, EventArgs e)
    {
      

    }

    
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("userlogin.aspx");
    }
}
