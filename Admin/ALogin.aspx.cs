using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using nmsProfile;

public partial class Admin_ALogin : System.Web.UI.Page
{
    clsBLprofile obj;
    prpLogin prplogin;
    prpLogin prppram;
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.Cache.SetNoStore();
        lblMsg.CssClass = "labelMsgRed";
        if (!Page.IsPostBack)
        {
            if (Request.QueryString["logout"] != null)
            {
                if (Request.QueryString["logout"] == "logout")
                {
                    lblMsg.Text = "You Successfully Logout ! ";
                    lblMsg.CssClass = "labelMsgGreen";
                }
                else if (Request.QueryString["logout"] == "session")
                {
                    lblMsg.Text = "Session Time Out Please Re-Login To Continue !";
                    lblMsg.CssClass = "labelMsgGreen";
                }
            }
        }
    }
    private void iccoLogin()
    {
        prplogin = new prpLogin();

        string msg = checkICCOLogin();
        string[] mlog;
        mlog = new string[3];
        mlog = msg.Split(',');

        if (mlog[0] == "Ok")
        {
            prplogin.EmployeeId = mlog[1];
            prplogin.employeeName = mlog[2];
            prplogin.branchId = mlog[3];
            prplogin.brachName = mlog[4];
            prplogin.loginType = mlog[5];
            prplogin.branchPhone = mlog[6];
            prplogin.urlPath = mlog[7];

            if (prplogin.loginType == "2")
            {
                Session["OfficeAdmin"] = prplogin;
                if (Request.QueryString["path"] != null)
                {
                    Response.Redirect(Request.QueryString["Path"].ToString());
                }
                else
                {

                    Response.Redirect("../Admin/Web/Default.aspx");
                }

            }
            else if (prplogin.loginType == "3")
            {
                Session["OfficeEmployee"] = prplogin;

                if (Request.QueryString["path"] != null)
                {
                    Response.Redirect(Request.QueryString["Path"].ToString());
                }
                else
                {
                    Response.Redirect("../employee/Default.aspx");
                }

            }

        }
        else
        {
            lblMsg.Text = msg;
        }

    }
    private string checkLogin()
    {
        obj = new clsBLprofile();
        prppram = new prpLogin();

        prppram.loginName = txtLoginName.Text;
        prppram.loginPassword = txtPassword.Text;
        prppram.IPaddress = Request.UserHostAddress;
        return obj.CheckInstituteLogin(prppram);
    }
    private string checkICCOLogin()
    {
        obj = new clsBLprofile();
        prppram = new prpLogin();

        prppram.loginName = txtLoginName.Text;
        prppram.loginPassword = txtPassword.Text;
        prppram.IPaddress = Request.UserHostAddress;


        return obj.CheckLogin(prppram);
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        iccoLogin();
    }
    protected void btOk_Click(object sender, EventArgs e)
    {
        String st = "";
        obj = new clsBLprofile();
        prppram = new prpLogin();

        prppram.emailId = txtEmailID.Text;
        st = obj.forgetPassword(prppram);
        if (st != "No")
        {
            lblMsg1.Text = "New Password Sent To Your EmailID";
        }
        else
        {
            lblMsg1.Text = "EmailID is not Registered!";
        }
        lnkForgetPassword_ModalPopupExtender.Show();
    }
    
}