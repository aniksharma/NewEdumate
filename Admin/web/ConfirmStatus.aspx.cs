using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using nmsOffice;
using nmsView;
public partial class Admin_web_ConfirmStatus : System.Web.UI.Page
{
    PRPOffice prppram;
    PRPOffice prp;
    BLoffice bl;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    private void UpdateBranch()
    {

        prp = new PRPOffice();
        bl = new BLoffice();

        prp.mailId = txtUserName.Text;
        lblMsg.Text = bl.ConfirmBranch(prp);
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        UpdateBranch();
    }
}