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
using nmsOffice;
using nmsView;
using nmsSetup;
using System.Collections.Generic;
using nmsDropDown;
using System.Net;
using System.Net.Mail;
using nmsProfile;

public partial class Add_Institute_SchoolRegistration : System.Web.UI.Page
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
            
            BindCountry();
            NNEmail.Checked = true;
            NNEdaily.Checked = true;
            string checkCode = this.CreateRandomCode(6);
            Session["CheckCode"] = checkCode;
            Label2.Text = checkCode;
        }
        if (!Page.IsPostBack)
        {

            BindCountry();
           
        }


    }

    protected void ddlUniversity0_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlUniversity.SelectedIndex != 0)
            bindDist();
       
    }
    protected void ddlUniversity_SelectedIndexChanged(object sender, EventArgs e)
    {

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
Your request to add your organisation details in our database has been successfully recorded with us. Kindly click on the
<b>Confirm</b>
button below to complete your registration process.
</div>
<div>
<a target='_blank' style='border-right:#000 1px solid;text-align:center;width:75px;background-color:#9f0;font-weight:bold;padding:5px;float:left;font-size:12px;margin-left:12px;border-bottom:#000 1px solid;font-family:arial;text-decoration:none;margin-top:10px' href='http://www.edumateworld.com/Add Institute/Confermation.aspx?username=" + txtemail.Text + "'>Confirm</a>" + @"
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
            FromMail = "oreply@edumateworld.com";

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
            // href='http://www.eduemart.com/Add Institute/Confermation.aspx?username="
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {


        if (NNeTerm.Checked == true)
        {
            if (Veryfycode.Text == Session["CheckCode"].ToString())
            {
                insertBranch();
                if (lblMsg.Text == "Submit Successfully!" || lblMsg.Text == "yes")
                {
                    mailSender();
                    Response.Redirect("../Add Institute/Welcome.aspx");
                  
                }
            }
            else
            {
                string checkCode = this.CreateRandomCode(6);
                Session["CheckCode"] = checkCode;
                Label2.Text = checkCode;
                Veryfycode.Text = "";
                lblMsg.Text = "Enter Same Code";
            }
        }
        else
        {
            lblMsg.Text = "Select Term & Condition";
        }


    }
    private void insertBranch()
    {
        PRPSetup prp = new PRPSetup();
        clsBLSetup bl = new clsBLSetup();
        prp.uniID = ddlCountry.SelectedValue;
       
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
        prp.status = "Private"; //ddlUniType.SelectedItem.Text;
        prp.name = txttypename.Text;
        //  prp.mainLandMark = txtLandMark.Text;
        prp.isActive = "1"; // rblStatus.SelectedValue;
        prp.address = txtaddress.Text;
        prp.phoneNo = txtcode.Text + txtnumber.Text;
        prp.mobNo = txtmobile.Text;
        prp.faxNo = txtfax.Text;
        prp.mailId = txtemail.Text;
        Session["Email"] = txtemail.Text;
        prp.rank = "4"; //ddlRankList.SelectedItem.Text;
        prp.grade = "A-Grade"; //  ddlGrade.SelectedValue;
        prp.Password = txtpassword.Text;
        prp.pinCode = txtpincode.Text;
        prp.sCollegeLogo = "../Advertisement/universityLogo.png";


        prp.id = "0";// ddlUniversityFinal.SelectedValue;  // for Univercity        

        //prp.sCategory = ddlCategory.SelectedValue;
        //prp.subCategory = ddlSubCategory.SelectedValue;
        #region Use for School Step3
        prp.subCategory = ddlSchoolSubCategory.SelectedValue;  //School Type
        prp.CourseLevel = ddlCourseLevel.SelectedValue;
        #endregion
        prp.CourseLevel = "0";// ddlCourseLevel.SelectedValue;
        prp.ApprovedBy = ApprovedBy.SelectedValue;


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

        prp.title = "3";  // For School Type is 3
        //prp.title = RadioButtonList1.SelectedValue;

        lblMsg.Text = bl.InsertCollegeDetail(prp);
    }

    private void bindState()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddlUniversity;
        if (ddlCountry.SelectedIndex != 0)
            drpprp.id = Convert.ToInt32(ddlCountry.SelectedValue);
        drpprp.spName = "viewState";
        drp.bindDropDown(drpprp);

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
            lblerrorShow.Text = "Yout are all ready registered with this email id please Click on ok to login if forget password then click on forget password";
            LinkButton1_ModalPopupExtender.Show();
        }
    }

    protected void txtemail_TextChanged(object sender, EventArgs e)
    {
        checkEmailID();
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
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        string checkCode = this.CreateRandomCode(6);
        Session["CheckCode"] = checkCode;
        Label2.Text = checkCode;

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

    #region Country Bind

    private void BindCountry()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddlCountry;
        drpprp.spName = "viewCountry";
        drp.bindDropDown(drpprp);
    }
    #endregion
    protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlUniversity.SelectedIndex != 0)
            bindState();
        SchoolType();
        SchoolApprovedBy();
        SchoolCourseLevel();
        
    }



    #region School Type
    private void SchoolType()
    {
        clsBLdropDown objdrp = new clsBLdropDown();
        clsPRPdropdown objprpdrp = new clsPRPdropdown();
        objprpdrp.controlList = ddlSchoolSubCategory;
        //if (RadioButtonList1.SelectedIndex != 0)
        objprpdrp.id = Convert.ToInt32(ddlCountry.SelectedValue);
        objprpdrp.Type = "SchoolType";
        objprpdrp.spName = "SpGetSchoolTypeAndLevelDetails";
        objdrp.bindCategoryControlList(objprpdrp);

    }
    #endregion
    #region School SchoolApprovedBy
    private void SchoolApprovedBy()
    {
        clsBLdropDown objdrp = new clsBLdropDown();
        clsPRPdropdown objprpdrp = new clsPRPdropdown();
        objprpdrp.controlList = ApprovedBy;
        objprpdrp.id = Convert.ToInt32(ddlCountry.SelectedValue);
        objprpdrp.Type = "SchoolApprovedBy";
        objprpdrp.spName = "SpGetSchoolTypeAndLevelDetails";
        objdrp.bindCategoryControlList(objprpdrp);

    }

    #endregion
    #region School SchoolCourseLevel
    private void SchoolCourseLevel()
    {
        clsBLdropDown objdrp = new clsBLdropDown();
        clsPRPdropdown objprpdrp = new clsPRPdropdown();
        objprpdrp.controlList = ddlCourseLevel;
        objprpdrp.id = Convert.ToInt32(ddlCountry.SelectedValue);
        objprpdrp.Type = "SchoolLevel";
        objprpdrp.spName = "SpGetSchoolTypeAndLevelDetails";
        objdrp.bindCategoryControlList(objprpdrp);

    }
    #endregion
}