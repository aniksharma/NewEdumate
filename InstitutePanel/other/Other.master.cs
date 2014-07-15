using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class InstitutePanel_other_Other : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["other"] == null)
        {
            Response.Redirect("http://www.edumateworld.com");
        }
    }
}
