﻿using System;
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
using nmsOffice;
using nmsView;
using nmsSetup;
using System.Collections.Generic;
using nmsDropDown;
using System.Net;
using System.Net.Mail;
using nmsProfile;

public partial class Admin_web_TutorRegistration : System.Web.UI.Page
{
    clsPRPdropdown drpprps;
    clsBLdropDown drps;
    PRPOffice prppram;
    PRPOffice prp;
    BLoffice bl;

    clsBLprofile obj;
    prpLogin prplogin;
    prpLogin prppram1;

    string type = "", memberId = "";
    static string branchId = "", fileURL = "";
    string imgurl = "", path = "", MaxId = "";
    string ToMail, FromMail, BodyMail, HeadMail;
    protected void Page_Load(object sender, EventArgs e)
    {

        PostBackOptions optionsSubmit = new PostBackOptions(btnSubmit);
        btnSubmit.OnClientClick = "disableButtonOnClick1(this, 'Please wait...', 'disabled_button1'); ";
        btnSubmit.OnClientClick += ClientScript.GetPostBackEventReference(optionsSubmit);

        if (IsPostBack && txtpassword.Text != string.Empty)
        {
            txtpassword.Attributes["value"] = txtpassword.Text;
            txtpassVaryfy.Attributes["value"] = txtpassVaryfy.Text;
        }

        if (Page.IsPostBack == false)
        {
            bindCountry();
            //bindState();
            NNEmail.Checked = true;
            NNEdaily.Checked = true;
            binduniversity();

            string checkCode = this.CreateRandomCode(6);
            Session["CheckCode"] = checkCode;
            Label2.Text = checkCode;

        }

    }
    public string CreateRandomCode(int codeCount)
    {
        string allChar = "0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";
        string[] allCharArray = allChar.Split(',');
        string randomCode = "";
        int temp = -1;

        Random rand = new Random();
        for (int i = 0; i < codeCount; i++)
        {
            if (temp != -1)
            {
                rand = new Random(i * temp * ((int)DateTime.Now.Ticks));
            }
            int t = rand.Next(36);
            if (temp != -1 && temp == t)
            {
                return CreateRandomCode(codeCount);
            }
            temp = t;
            randomCode += allCharArray[t];
        }
        return randomCode;
    }
    private void binduniversity()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddlCourseType;
        drpprp.id = 5;
        drpprp.spName = "crsViewAllMainCategory";
        drp.bindDropDown(drpprp);
        //ddlCourseType.SelectedIndex = 1;
    }
  
    private void bindsuniversity()
    {

        clsBLSetup bl = new clsBLSetup();
        PRPSetup prppram = new PRPSetup();
        prppram.name = "crsViewAllSubCategory";
        if (ddlCourseType.SelectedIndex != 0)
            prppram.uniID = ddlCourseType.SelectedValue;
            prppram.type = ddlCountry.SelectedValue;
           CheckBoxList1.DataSource = bl.ViewTutorSubcategoryTypeWithParamater(prppram);
           CheckBoxList1.DataTextField = "name";
           CheckBoxList1.DataValueField = "id";
           CheckBoxList1.DataBind();


    }


    #region Bind Country
    private void bindCountry()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddlCountry;
        drpprp.spName = "viewCountry";
        drp.bindDropDown(drpprp);
       // ddlCountry.SelectedIndex = 1;
    }

    //protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    if (ddlCountry.SelectedIndex != 0)
    //        GetStateName();
    //}



    private void GetStateName()
    {
        clsBLdropDown objdrp = new clsBLdropDown();
        clsPRPdropdown objprpdrp = new clsPRPdropdown();
        objprpdrp.controlList = ddlUniversity;
        if (ddlCountry.SelectedIndex != 0)
            objprpdrp.id = Convert.ToInt32(ddlCountry.SelectedValue);
            objprpdrp.spName = "viewState";
            //objdrp.bindControlList(objprpdrp);
            objdrp.bindDropDown(objprpdrp);
       


    }

    #endregion



    protected void ddlUniversity0_SelectedIndexChanged(object sender, EventArgs e)
    {
        bindDist();

    }
    protected void ddlUniversity_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            if (NNeTerm.Checked == true)
            {
               
                    insertBranch();
                    if (lblMsg.Text == "Submit Successfully!" || lblMsg.Text == "yes")
                    {
                       
                        Response.Redirect("Welcome.aspx");
                        string checkCode = this.CreateRandomCode(6);
                        Session["CheckCode"] = checkCode;
                        Label2.Text = checkCode;

                    }
             
            }
            else
            {
                lblMsg.Text = "Select Term & Condition";
            }

        }
    }
    private void mailSender()
    {

        try
        {
            BodyMail = @"<div style='width:625px;border-top:#c0f solid 3px;padding-top:10px'>
<span style='font-family:arial;width:270px;font-size:24px;font-weight:bold;color:#006'>
<i>Edu Education Search </i>
</span>
<span style='padding-left:235px;vertical-align:bottom;font-family:arial;font-size:14px;text-align:right;color:#666'>Confirmation Mail</span>
<div style='border-top:#ebebeb solid 1px'></div>
<div style='border-top:#ebebeb solid 1px'></div>
<div style='margin-top:20px;padding:10px;float:left;font-family:arial;font-size:18px;color:#666'>
<img>
</div>
<div style='font-size:12px;width:512px;margin-left:10px;font-family:arial;margin-top:20px;float:right'>
Hello <b>" +
txttypename.Text
+ @"</b>,
<br>
<br>
Your request to add your details in our database has been successfully recorded with us. Kindly click on the
<b>Confirm</b>
button below to complete your registration process.
</div>
<div>
<a target='_blank' style='border-right:#000 1px solid;text-align:center;width:75px;background-color:#9f0;font-weight:bold;padding:5px;float:left;font-size:12px;margin-left:12px;border-bottom:#000 1px solid;font-family:arial;text-decoration:none;margin-top:10px' href='http://www.edumate.edu.in/Add Institute/Confermation.aspx?username=" + txtemail.Text + "'>Confirm</a>" + @"
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

            HeadMail = "Edu - Registration Confirmation";
            ToMail = txtemail.Text; ;
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
            //   lblErrorMsg.Text = "Mail Not Sended";
           
        }
    }

    private void checkFileUploadedPath()
    {
        clsPRPParm objprm = new clsPRPParm();
        clsBLview obj = new clsBLview();
        objprm.spName = "GetCollegeLogoMaxImageId";
        MaxId = obj.GetMaxFileId(objprm);
    }  


    private void insertBranch()
    {
        PRPSetup prp = new PRPSetup();
        clsBLSetup bl = new clsBLSetup();

        prp.uniID = ddlCountry.SelectedValue;
        //prp.uniID = "1";  //ddlUniversity0.SelectedValue;
        prp.state = ddlUniversity.SelectedValue;
        prp.district = ddlDist.SelectedValue;

        if (txtOtherLocation.Text != "")
        {
            prp.otherLocation = txtOtherLocation.Text;
        }
        else
        {
            if (ddlCity.SelectedIndex != 0)
                prp.city = ddlCity.SelectedValue;
            else
            {
                prp.city = null;
            }

        }
        prp.education = "1"; // ddl.SelectedValue;
       // prp.status =ddlUniType.SelectedItem.Text;
        prp.status = ddlUniType.SelectedItem.Text;
       // prp.status = "Private"; //ddlUniType.SelectedItem.Text;
        prp.name = txttypename.Text;
        prp.isActive = "1"; // rblStatus.SelectedValue;
        prp.address = txtaddress.Text;
        prp.phoneNo = txtcode.Text + txtnumber.Text;
        prp.mobNo = txtmobile.Text;
        prp.mailId = txtemail.Text;
        Session["Email"] = txtemail.Text;
        prp.rank = "4"; //ddlRankList.SelectedItem.Text;
        prp.grade = "A-Grade"; //  ddlGrade.SelectedValue;
        prp.Password = txtpassword.Text;
        prp.pinCode = txtpincode.Text;
        prp.sCategory = ddlCourseType.SelectedItem.Text;
        if (logoCollege.HasFile)
        {
            checkFileUploadedPath();
            //<img src="../../Advertisement/1215.png" />
            imgurl = "../Advertisement/" + MaxId + logoCollege.FileName;
            path = Server.MapPath("../../Advertisement/" + imgurl);
            logoCollege.SaveAs(path);
            prp.sCollegeLogo = imgurl;

        }
        else
            prp.sCollegeLogo = "../Advertisement/universityLogo.png";           

        if (NNEmail.Checked == true)
        {
            prp.nneEmail = "1";
        }
        else
        {
            prp.nneEmail = "0";
        }
        if (NNEdaily.Checked == true)
        {
            prp.nneDaily = "1";
        }
        else
        {
            prp.nneEmail = "0";
        }
        if (NNESMS.Checked == true)
        {
            prp.nneSMS = "1";
        }
        else
        {
            prp.nneSMS = "0";
        }

        prp.DOB = txtAge.Text;

        prp.marital = RadioButtonList2.SelectedItem.Text;

        prp.title = RadioButtonList1.SelectedValue;

        prp.description = ShortDescription.Text;
        prp.mainLandMark = LongDescription.Text;
        prp.tutionType = ddlTutoringStyle.SelectedItem.Text;
        prp.AssociateName = txtBestTimeToCall.Text;

        if (txtCourseFees.Text == "")
        {
            prp.Salary = "0";
        }
        else
        {
            prp.Salary = txtCourseFees.Text;
        }

        prp.security = ddlFeesType.SelectedValue;
        prp.urlPath = ddlFeesMode.SelectedValue;

        String Query = "";

        foreach (ListItem lt in CheckBoxList1.Items)
        {
            if (lt.Selected == true)
            {
                Query += "insert collegeCourseDetail(courseCategory,courseSubCategory,courseFees,FeesMode,currencyType) values(" + ddlCourseType.SelectedValue + "," + lt.Value + "," + prp.Salary + "," + prp.security + ",'" + prp.urlPath + "')";

            }
        }
        prp.urlName = Query;
        lblMsg.Text = bl.InsertCollegeDetail(prp);
    }
    private void bindState()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddlUniversity;
        drpprp.id = 1; //Convert.ToInt32(ddlCountry.SelectedValue);
        drpprp.spName = "viewState";
        drp.bindDropDown(drpprp);
        //ddlUniversity0.SelectedIndex = 1;
    }
    private void bindDist()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddlDist;

        if (ddlUniversity.SelectedIndex != 0)
            drpprp.id = Convert.ToInt32(ddlUniversity.SelectedValue);
        drpprp.spName = "viewDistrict";
        drp.bindDropDown(drpprp);
        //ddlUniversity0.SelectedIndex = 1;
    }
    private void bindCity()
    {
        clsBLdropDown drps = new clsBLdropDown();
        clsPRPdropdown drpprps = new clsPRPdropdown();
        drpprps.controlList = ddlCity;
        if (ddlDist.SelectedIndex != 0)
            drpprps.id = Convert.ToInt32(ddlDist.SelectedValue);
        drpprps.spName = "viewCity";
        drps.bindDropDown(drpprps);
    }
    protected void ddlDist_SelectedIndexChanged(object sender, EventArgs e)
    {
        bindCity();
    }
    private void checkEmailID()
    {
        String st = "";
        obj = new clsBLprofile();
        prppram1 = new prpLogin();
        prppram1.emailId = txtemail.Text;
        st = obj.forgetPassword(prppram1);
        if (st != "No")
        {
            lblerrorShow.Text = " Thanks! Yout are all ready registered with this email id. We will meet soon";
            LinkButton1_ModalPopupExtender.Show();
        }
    }
    protected void txtemail_TextChanged(object sender, EventArgs e)
    {
        checkEmailID();
    }
    protected void ddlCourseType_SelectedIndexChanged(object sender, EventArgs e)
    {
        bindsuniversity();
    }
    protected void ddlSubCourseCate_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlCity.SelectedIndex != 0)
        {
            txtOtherLocation.Enabled = false;
        }
        else
        {
            txtOtherLocation.Enabled = true;
        }

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        string checkCode = this.CreateRandomCode(6);
        Session["CheckCode"] = checkCode;
        Label2.Text = checkCode;
    }
    protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlCountry.SelectedIndex != 0)
            GetStateName();
    }
}
