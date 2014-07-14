using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using nmsOffice;
using nmsView;
public partial class Add_Institute_Confermation : System.Web.UI.Page
{
    PRPOffice prppram;
    PRPOffice prp;
    BLoffice bl;
    protected void Page_Load(object sender, EventArgs e)
    {
        UpdateBranch();
    }
    private void UpdateBranch()
    {

        prp = new PRPOffice();
        bl = new BLoffice();
        if (Request.QueryString["username"] != null)
        {
            prp.mailId = Request.QueryString["username"].ToString();
            bl.ConfirmBranch(prp);
        }


    }


}
