using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using nmsProfile;
public partial class Admin_web_ChangePassword : System.Web.UI.Page
{
    prpLogin objlog;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["OfficeAdmin"] == null)
        {
            Response.Redirect("../ALogin.aspx?logout=session&path=Web/ChangePassword.aspx");
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
        objlog = (prpLogin)(Session["OfficeAdmin"]);
        //---------------------------------------------
        objprp.EmployeeId = objlog.EmployeeId;
        objprp.loginPassword = txtNewPassword.Text;
        objprp.oldPassword = txtoldPassword.Text;
        //---------------------------------------------
        msg = obj.UpdatePassword(objprp);
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
