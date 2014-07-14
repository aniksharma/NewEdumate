using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using nmsLoginJob;

public partial class Add_Institute_CodeVerification : System.Web.UI.Page
{

    clsPRPLogin prp;
    clsBLlogin obj;
    string msg = "";

    protected void Page_Load(object sender, EventArgs e)
    {


    }
    protected void btnContinue_Click(object sender, EventArgs e)
    {
        obj = new clsBLlogin();
        prp = new clsPRPLogin();

        prp.oldPassword = txtCode.Text;

        if (Request.QueryString["type"] != null)
        {
            msg = obj.spResetPasswordNewKIDS(prp);
        }
        else
        {

            msg = obj.spResetPasswordNew(prp);
        }

        lblMsg.Text = msg;
        if (msg != "Edumate HR Account Confrimed !")
        {

            lblMsg.ForeColor = System.Drawing.Color.Red;
            TrLoginpage.Visible = false;
        }
        else
        {

            Response.Redirect("Confermation.aspx");


        }

    }
}