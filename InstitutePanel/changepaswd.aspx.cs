using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using nmsProfile;

public partial class InstitutePanel_Default4 : System.Web.UI.Page
{

    prpLogin objlog;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["OfficeCollege"] == null)
        {
            Response.Redirect("http://www.edumateworld.com");
        }
    }

    protected void btnChangePassword_Click(object sender, EventArgs e)
    {
        UpdatePassword();
    }
    private void UpdatePassword()
    {
        string msg = "";

        clsBLprofile obj = new clsBLprofile();
        prpLogin objprp = new prpLogin();
        objlog = new prpLogin();
        objlog = (prpLogin)(Session["OfficeCollege"]);
        //---------------------------------------------
        objprp.EmployeeId = objlog.EmployeeId;
        objprp.loginPassword = txtNewPassword.Text;
        objprp.oldPassword = txtoldPassword.Text;
        objprp.loginType = objlog.loginType;
        //---------------------------------------------
        msg = obj.UpdateInstitutePassword(objprp);
        lblErrorMsg.Text = msg;
        if (msg == "Password Updated Successfully !")
        {
            lblErrorMsg.CssClass = "labelMsgGreen";
            txtoldPassword.Text = "";
        }
        else
        {
            lblErrorMsg.CssClass = "labelMsgRed";

        }

    }
}