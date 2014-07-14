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

using System.Collections.Generic;
using nmsDropDown;
using nmsProfile;
using hr;
using System.Net;
using System.Net.Mail;
using nmsSetupI;
using System.Data.SqlClient;


public partial class Tutorregistration : System.Web.UI.Page
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

    string strcon = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
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
 

    public void BindSubCategory()
    {



        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand("crsViewAllSubCategory", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] paramsToStore =
           new SqlParameter[4];
        paramsToStore[0] = new SqlParameter("@id", SqlDbType.NVarChar);
        paramsToStore[0].Size = 20;
        cmd.Parameters.Add(paramsToStore[0]).Value = ddlCourseType.SelectedValue;
        paramsToStore[1] = new SqlParameter("@Type", SqlDbType.NVarChar);
        paramsToStore[1].Size = 100;
        cmd.Parameters.Add(paramsToStore[1]).Value = ddlCountry.SelectedValue;
        DataSet ds3 = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds3);
        ddsubcategory.DataSource = ds3;
        ddsubcategory.DataValueField = "id";
        ddsubcategory.DataTextField = "name";
        ddsubcategory.DataBind();
        ddsubcategory.Items.Insert(0, "--Select --");


    }
    #region SubCategoryBind
    private void bindsuniversity()
    {
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand("crsViewAllSubCategory", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] paramsToStore =
           new SqlParameter[4];
        paramsToStore[0] = new SqlParameter("@id", SqlDbType.NVarChar);
        paramsToStore[0].Size = 20;
        cmd.Parameters.Add(paramsToStore[0]).Value = ddlCourseType.SelectedValue;
        paramsToStore[1] = new SqlParameter("@Type", SqlDbType.NVarChar);
        paramsToStore[1].Size = 100;
        cmd.Parameters.Add(paramsToStore[1]).Value = ddlCountry.SelectedValue;
        DataSet ds3 = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds3);
        ddsubcategory.DataSource = ds3;
        ddsubcategory.DataValueField = "id";
        ddsubcategory.DataTextField = "name";
        ddsubcategory.DataBind();
       
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
                if (Veryfycode.Text == Session["CheckCode"].ToString())
                {
                    insertBranch();
                    if (lblMsg.Text == "Submit Successfully!" || lblMsg.Text == "yes")
                    {
                        mailSender();
                    
                        Response.Redirect("Welcome.aspx");
                        string checkCode = this.CreateRandomCode(6);
                        Session["CheckCode"] = checkCode;
                        Label2.Text = checkCode;

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
            ToMail = txtemail.Text;
            FromMail = "noreply@edumateworld.com";

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
    private void insertBranch()
    {
        clsBLhr bl1 = new clsBLhr();
       clsprophr prop = new clsprophr();
        prop.Country  = ddlCountry.SelectedValue;  //ddlUniversity0.SelectedValue;
      
        prop.state = ddlUniversity.SelectedValue;
        prop.district = ddlDist.SelectedValue;

        if (txtOtherLocation.Text != "")
        {
            prop.Location  = txtOtherLocation.Text;
        }
        else
        {
            if(ddlCity.SelectedIndex!=0)
                prop.city = ddlCity.SelectedValue;
            else
            {
                prop.city = null;
            }           

        }

        
        prop.EduIntrest = "1"; // ddl.SelectedValue;
        prop.status = "Private"; //ddlUniType.SelectedItem.Text;
        prop.name = txttypename.Text;
        prop.isActive = "1"; // rblStatus.SelectedValue;
        prop.address = txtaddress.Text;
        prop.phoneNo = txtcode.Text + txtnumber.Text;
        prop.mob  = txtmobile.Text;

        prop.email  = txtemail.Text;
        Session["Email"] = txtemail.Text;
        prop.rank = "4"; //ddlRankList.SelectedItem.Text;
        prop.grade = "A-Grade"; //  ddlGrade.SelectedValue;
        prop.Password = txtpassword.Text;
        prop.pinCode = txtpincode.Text;                
       
        if (NNEmail.Checked == true)
        {
            prop.nneEmail = "1";
        }
        else
        {
            prop.nneEmail = "0";
        }
        if (NNEdaily.Checked == true)
        {
            prop.nneDaily = "1";
        }
        else
        {
            prop.nneEmail = "0";
        }
        if (NNESMS.Checked == true)
        {
            prop.nneSMS = "1";
        }
        else
        {
            prop.nneSMS = "0";
        }

        prop.DOB = txtAge.Text;

        prop.marital = RadioButtonList2.SelectedItem.Text;

        prop.title = RadioButtonList1.SelectedValue;

        prop.description = ShortDescription.Text;
        prop.mainLandMark = LongDescription.Text;
        prop.tutionType = ddlTutoringStyle.SelectedItem.Text;
        prop.AssociateName = txtBestTimeToCall.Text;

        if (txtCourseFees.Text == "")
        {
            prop.Salary = "0";
        }
        else
        {
            prop.Salary = txtCourseFees.Text;
        }

        prop.security = ddlFeesType.SelectedValue;
        prop.urlPath = ddlFeesMode.SelectedValue;
        prop.GraduatingYrs = ddsubcategory.SelectedValue;
        prop.catid = ddlCourseType.SelectedValue;
        String Query = "";

        foreach (ListItem lt in CheckBoxList1.Items)
            {
                if (lt.Selected == true)
                {
                    Query += "insert collegeCourseDetail(courseCategory,courseSubCategory,courseFees,FeesMode,currencyType) values(" + ddlCourseType.SelectedValue + "," + lt.Value + "," + prp.Salary + "," + prp.security + ",'" + prp.urlPath + "')";

                }
            }
        prop.urlName = Query;
        lblMsg.Text = bl1.InsTutorProfilesaliman(prop);
        if(lblMsg.Text=="note")
        {
            lblMsg.Text = "Email Already Exist";
        }
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
  
    protected void ddlCountry_SelectedIndexChanged1(object sender, EventArgs e)
    {
        if (ddlCountry.SelectedIndex != 0)
            bindState();
    }

}
