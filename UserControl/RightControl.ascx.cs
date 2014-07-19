using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Xml.Linq;
using nmsLogin;
using nmsProfile;
using System.Net;
using System.Net.Mail;


using System.Collections.Generic;
using nmsSetup;
using nmsSetupWeb;
using nmsProfile;
using System.Net;
using System.Web.Script.Serialization;
using nmsDropDown;
using System.Data;
public partial class UserControl_RightControl : System.Web.UI.UserControl
{
    clsBLprofile obj;
    prpLogin prplogin;
    prpLogin prppram;
    string ToMail, FromMail, BodyMail, HeadMail;

    EdumateService.EdumateServiceClient proxy;
    string msg, msg1;
    DataSet ds;
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.Cache.SetNoStore();
        lblMsg.CssClass = "labelMsgRed";
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
            loginformDiv.Attributes.Add("style", "display:block;");
            afterlogin.Attributes.Add("style", "display:none;");

        }
        if (Session["OfficeCollege"] == null)
        {
            loginformDiv.Attributes.Add("style", "display:block;");
            afterlogin.Attributes.Add("style", "display:none;");
            Session["OfficeCollege"] = prplogin;


            loginok.InnerHtml = "User Login";

        }
        else
        {
            loginformDiv.Attributes.Add("style", "display:none;");
            afterlogin.Attributes.Add("style", "display:block;");

            prplogin = (prpLogin)Session["OfficeCollege"];
            if (prplogin.loginType == "2")
            {
                loginok.InnerHtml = "Institute";
            }
            else if (prplogin.loginType == "3")
            {
                loginok.InnerHtml = "School";
            }
            else if (prplogin.loginType == "4")
            {
                loginok.InnerHtml = "College";
            }
            else if (prplogin.loginType == "5")
            {
                loginok.InnerHtml = "Teacher";
            }
            else if (prplogin.loginType == "8")
            {
                loginok.InnerHtml = "Student";
            }
            else
            {
                loginok.InnerHtml = "User Login";
            }
            usename.InnerHtml = prplogin.bindStatus;
            email.InnerHtml = prplogin.employeeName;
            img111.Attributes.Add("src", "http://www.edumateworld.com" + prplogin.urlPath);

            if (prplogin.loginName != "")
            {
                contactno.InnerHtml = "<b>Contact No.: </b>" + prplogin.loginName;
            }

        }

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
                loginformDiv.Attributes.Add("style", "display:block;");
                afterlogin.Attributes.Add("style", "display:none;");

            }
            if (Session["OfficeCollege"] == null)
            {
                loginformDiv.Attributes.Add("style", "display:block;");
                afterlogin.Attributes.Add("style", "display:none;");

            }
            else
            {
                loginformDiv.Attributes.Add("style", "display:none;");
                afterlogin.Attributes.Add("style", "display:block;");
            }

            stream();
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
            prplogin.branchId = mlog[3];
            prplogin.brachName = mlog[3];
            prplogin.loginType = mlog[4];
            prplogin.branchPhone = mlog[5];
            prplogin.urlPath = mlog[5];
            prplogin.webSite = mlog[6];
            prplogin.name = mlog[8];
            prplogin.bindStatus = mlog[10];
            prplogin.loginName = mlog[9];
            usename.InnerHtml = prplogin.bindStatus;
            email.InnerHtml = prplogin.employeeName;
            img111.Attributes.Add("src", "http://www.edumateworld.com" + prplogin.urlPath);
            if (prplogin.loginName != "")
            {
                contactno.InnerHtml = "<b>Contact No.: </b>" + prplogin.loginName;
            }


            loginformDiv.Attributes.Add("style", "display:none;");
            afterlogin.Attributes.Add("style", "display:block;");

            loginok.InnerHtml = "User Panel";

            if (prplogin.loginType == "2" || prplogin.loginType == "4" || prplogin.loginType == "3" ||
                prplogin.loginType == "5" || prplogin.loginType == "6" || prplogin.loginType == "8")
            {
                Session["Login"] = prplogin.loginType;


                Session["OfficeCollege"] = prplogin;

                Session["schoolid"] = prplogin.EmployeeId;
                if (Request.QueryString["path"] != null)
                {
                    Response.Redirect(Request.QueryString["Path"].ToString());
                }
                else
                {
                    Response.Redirect("~/InstitutePanel/Default.aspx");
                }


                if (prplogin.loginType == "2")
                {
                    loginok.InnerHtml = "Institute";
                }
                else if (prplogin.loginType == "3")
                {
                    loginok.InnerHtml = "School";
                }
                else if (prplogin.loginType == "4")
                {
                    loginok.InnerHtml = "College";
                }
                else if (prplogin.loginType == "5")
                {
                    loginok.InnerHtml = "Teacher";
                }
                else if (prplogin.loginType == "8")
                {
                    loginok.InnerHtml = "Student";
                }
                else
                {
                    loginok.InnerHtml = "User Login";
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
                    Response.Redirect("http://www.edumateworld.com/controlpanel-welcome-User");
                }
            }


        }
        else
        {
            lblMsg.Text = msg;
        }
        if (Session["OfficeCollege"] == null)
        {
            loginformDiv.Attributes.Add("style", "display:block;");
            afterlogin.Attributes.Add("style", "display:none;");



        }
        else
        {
            loginformDiv.Attributes.Add("style", "display:none;");
            afterlogin.Attributes.Add("style", "display:block;");


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
                    Response.Redirect("../Admin/ICCO/Default.aspx");
                }
                loginok.InnerHtml = "Institute";


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
                loginok.InnerHtml = "School";

            }

        }
        else
        {
            lblMsg.Text = msg;
        }

    }
    /// <summary>
    /// Ok by Bhanu
    /// </summary>
    /// <returns></returns>
    private string checkLogin()
    {
        obj = new clsBLprofile();
        prppram = new prpLogin();
        prppram.loginName = txtLoginName.Text;
        prppram.loginPassword = txtPassword.Text;
        prppram.IPaddress = Request.UserHostAddress;
        return obj.CheckInstituteLogin(prppram);
    }
    /// <summary>
    /// Ok by bhanu
    /// </summary>
    /// <returns></returns>
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
        trforget.Visible = true;
        LinkButton6_ModalPopupExtender.Show();
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
        trforget.Visible = true;
        LinkButton6_ModalPopupExtender.Show();
    }
    protected void lnkSignUp_Click(object sender, EventArgs e)
    {
        trforget.Visible = false;
        LinkButton6_ModalPopupExtender.Show();
    }
    private void stream()
    {
        proxy = new EdumateService.EdumateServiceClient();
        EdumateService.DbPara[] arrObj = new EdumateService.DbPara[1];
        arrObj[0] = new EdumateService.DbPara();
        arrObj[0].ParaName = "@id";
        arrObj[0].ParaValue = "4";
        ds = new DataSet();
        ds = proxy.EdumateGetDataSetSP(out msg, out msg1, arrObj, "crsViewAllMainCategory");
        ddlStream.DataSource = ds;
        ddlStream.DataTextField = "name";
        ddlStream.DataValueField = "id";
        ddlStream.DataBind();
        ddlStream.Items.Insert(0, "Select Stream");
    }
    private void substream()
    {
        proxy = new EdumateService.EdumateServiceClient();
        EdumateService.DbPara[] arrObj = new EdumateService.DbPara[2];
        arrObj[0] = new EdumateService.DbPara();
        arrObj[0].ParaName = "@id";
        arrObj[0].ParaValue = ddlStream.SelectedValue;
        arrObj[1] = new EdumateService.DbPara();
        arrObj[1].ParaName = "@Type";
        arrObj[1].ParaValue = "1";
        
        ds = new DataSet();
        ds = proxy.EdumateGetDataSetSP(out msg, out msg1, arrObj, "crsViewAllSubCategory");
        ddlSubstream.DataSource = ds;
        ddlSubstream.DataTextField = "name";
        ddlSubstream.DataValueField = "id";
        ddlSubstream.DataBind();
        ddlSubstream.Items.Insert(0, "Sub Stream");
    }
    protected void ddlStream_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlStream.SelectedIndex > 0)
        {
            substream();
        }
    }
    private void InsCommonEnquiry()
    {
        clsBLSetupWeb obj = new clsBLSetupWeb();
        PRPSetupWeb objparm = new PRPSetupWeb();
        objparm.name = txtCName.Text;
        objparm.catID = "Budget-Enquiry";
        objparm.mobNo = txtCMobileNo.Text;
        objparm.emailID = txtCEmailID.Text;
        objparm.Query = txtCQualification.Text;
        objparm.uniID = ddlStream.SelectedItem.Text;
        objparm.urlId = ddlSubstream.SelectedItem.Text;
        objparm.state = ddlState.SelectedItem.Text;
        objparm.district = ddlPlan.SelectedItem.Text;
        objparm.durationMinTime = ddlMinBudget.SelectedItem.Text;
        objparm.durationMaxTime = ddlMaxBudget.SelectedItem.Text;
        obj.InsContactEnquiry(objparm);
        reset1();
    }
    private void reset1()
    {
        txtCName.Text = "";
        txtCMobileNo.Text = "";
        txtCEmailID.Text = "";
        txtCQualification.Text = "";
    }

    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        InsCommonEnquiry();
    }
    protected void LinkButton6_Click(object sender, EventArgs e)
    {

    }

}