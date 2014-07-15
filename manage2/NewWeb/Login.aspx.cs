using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using nmsLogin;
using nmsProfile;
using System.Net;
using System.Net.Mail;

public partial class manage2_NewWeb_Login : System.Web.UI.Page
{
    clsBLprofile obj;
    prpLogin prplogin;
    prpLogin prppram;
    string ToMail, FromMail, BodyMail, HeadMail;
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
    private void collegeLogin()
    {
        prplogin = new prpLogin();

        string msg = checkLogin();
        string[] mlog;
        mlog = new string[3];
        mlog = msg.Split(',');

        if (mlog[0] == "Ok")
        {
            prplogin.EmployeeId = mlog[1];
            prplogin.employeeName = prplogin.emailId = mlog[2];
       
            prplogin.brachName = mlog[3];
            prplogin.loginType = mlog[4];
            prplogin.branchPhone = mlog[5];
            prplogin.urlPath = mlog[6];
            prplogin.webSite = mlog[7];
            prplogin.name = mlog[8];
        
            if (prplogin.loginType == "2" || prplogin.loginType == "4" || prplogin.loginType == "3" || prplogin.loginType == "5" || prplogin.loginType == "6")
            {
                Session["OfficeCollege"] = prplogin;
                Session["schoolid"] = prplogin.EmployeeId;
                if (Request.QueryString["path"] != null)
                {
                    Response.Redirect(Request.QueryString["Path"].ToString());
                }
                
            }

            else if (prplogin.loginType == "9")
            {
                Session["OfficeCollege"] = prplogin;
                Session["schoolid"] = prplogin.EmployeeId;
                if (Request.QueryString["path"] != null)
                {
                    Response.Redirect(Request.QueryString["Path"].ToString());
                }
                else
                {
                    Response.Redirect("../PartnerPanel/Default.aspx");
                }
            }
            else if (prplogin.loginType == "8")
            {
                Session["OfficeCollege"] = prplogin;
                Session["schoolid"] = prplogin.EmployeeId;
                if (Request.QueryString["path"] != null)
                {
                    Response.Redirect(Request.QueryString["Path"].ToString());
                }
                else
                {
                    Response.Redirect("~/panel-welcome-User");
                }
            }
            else if (prplogin.loginType == "7")
            {
                Session["other"] = "yes";
                Session["OfficeCollege"] = prplogin;
                Session["schoolid"] = prplogin.EmployeeId;
                if (Request.QueryString["path"] != null)
                {
                    Response.Redirect(Request.QueryString["Path"].ToString());
                }
                else
                {
                    Response.Redirect("~/controlpanel-welcome-User");
                }
            }

        }
        else
        {
            lblMsg.Text = msg;
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
                    Response.Redirect("../../Admin/ICCO/Default.aspx");
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
        collegeLogin();

    }
    protected void btOk_Click(object sender, EventArgs e)
    {
        String st = "";
        obj = new clsBLprofile();
        prppram = new prpLogin();
        prplogin = new prpLogin();
        prppram.emailId = txtEmailID.Text;
        string msg = obj.forgetPassword(prppram);
        string[] mlog;
        mlog = new string[3];
        mlog = msg.Split(',');

        if (mlog[0] == "Ok")
        {
            prplogin.EmployeeId = mlog[1];
            prplogin.employeeName = prplogin.emailId = mlog[2];
            prplogin.brachName = mlog[3];
            prplogin.loginType = mlog[4];
            prplogin.branchPhone = mlog[5];
            prplogin.urlPath = mlog[6];
            prplogin.webSite = mlog[7];
            prplogin.name = mlog[8];
            prplogin.loginPassword = mlog[9];
            Session["emailDetail"] = prplogin;
            mailSender();
            lblMsg1.Text = "New Password Sent To Your EmailID";
        }
        else
        {
            lblMsg1.Text = "EmailID is not Registered!";
        }
        
    }
    private void mailSender()
    {
        prplogin = new prpLogin();
        prplogin = (prpLogin)(Session["emailDetail"]);

        try
        {
            BodyMail = @"<div style='width:625px;border-top:#c0f solid 3px;padding-top:10px'>
<span style='font-family:arial;width:270px;font-size:24px;font-weight:bold;color:#006'>
<i>Edu Education </i>
</span>
<span style='padding-left:235px;vertical-align:bottom;font-family:arial;font-size:14px;text-align:right;color:#666'>Forget Password Mail</span>
<div style='border-top:#ebebeb solid 1px'></div>
<div style='border-top:#ebebeb solid 1px'></div>
<div style='margin-top:20px;padding:10px;float:left;font-family:arial;font-size:18px;color:#666'>
<img>
</div>
<div style='font-size:12px;width:512px;margin-left:10px;font-family:arial;margin-top:20px;float:right'>
Hello <b>" +
prplogin.name
+ @"</b>,
<br>
<br>
Your new password is " + prplogin.loginPassword + @". Kindly click on the
<b>Login</b>
button below to Login.
</div>
<div>
<a target='_blank' style='border-right:#000 1px solid;text-align:center;width:75px;background-color:#9f0;font-weight:bold;padding:5px;float:left;font-size:12px;margin-left:12px;border-bottom:#000 1px solid;font-family:arial;text-decoration:none;margin-top:10px' href='http://www.edumate.edu.in/web/Login.aspx?username=" + prplogin.emailId + "'>Login</a>" + @"
</div>
<div style='margin-top:20px;width:600px;font-family:arial;border-top:#09f 2px solid;color:#666;font-size:11px;float:left'>
PLEASE DO NOT REPLY TO THIS MAIL.
<br>
<div style='border-top:#ebebeb solid 1px'></div>
<br>
We value your privacy. At no time your email address will be shared with any 3rd party.
<br>
This service is brought to you by -
<br>
<br>
Copyright 2012 Edu Education Group
</div>
</div>
<div ></div>
<div >
<br>
<br>
</div>
</div>
<div >&#10;&#10;</div>
</div>
</div>
<div id=':6b'  style='display:none'>
<div id=':6a'></div>
</div>
<div ></div>
</div>";
            HeadMail = "You requested a new Edumate Password";
            ToMail = prplogin.emailId;
            FromMail = "noreply@edumate.edu.in";
            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            SmtpClient SmtpServer = new SmtpClient();

            mail.To.Add(ToMail);
            mail.From = new System.Net.Mail.MailAddress(FromMail);
            mail.Subject = HeadMail;
            mail.Body = BodyMail;
            mail.IsBodyHtml = true;
            SmtpServer.Send(mail);
        }
        catch (Exception ex)
        {
            
        }
    }

    protected void lnkForgetPassword_Click(object sender, EventArgs e)
    {
        tforgetpassword.Visible = true;
    }
 
    protected void btnSubmit_Click(object sender, ImageClickEventArgs e)
    {
        collegeLogin();
    }
}