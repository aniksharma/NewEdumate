using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using nmsDropDownKIDS;
using hr;
using bal.Registration;
using System.Net;
using System.Net.Mail;
using System.IO;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class KidsProfile_KidsProfile : System.Web.UI.Page
{
    string Message;
    string msg = "", tokenno = "";
    string ToMail, FromMail, BodyMail, HeadMail;
    string Mail1, Mail2, Mail3, Mail4, Mail5, Mail6, Mail7, Mail8, MailBody = "";
    string strcon = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
    static string code = "";

    string mailID, Name, UserName, Pwd, Date;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            BindCountry();
            var sourcess = Enumerable.Range(2001, 20)
           .Select(i => new { Text = i.ToString(), Value = i.ToString() });
            ddlgrd.DataSource = sourcess;
            ddlgrd.DataTextField = "Text";
            ddlgrd.DataValueField = "Value";
            ddlgrd.DataBind();
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



    public void BindSubCategory()
    {

        DataSet ds3 = new DataSet();
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand("GetAllCategoryType1", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] paramsToStore =
           new SqlParameter[4];
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds3);
        ddlentrest.DataSource = ds3;
        ddlentrest.DataValueField = "id";
        ddlentrest.DataTextField = "name";
        ddlentrest.DataBind();


    }
    private void bindState()
    {
        nmsDropDown.clsBLdropDown drp = new nmsDropDown.clsBLdropDown();
        nmsDropDown.clsPRPdropdown drpprp = new nmsDropDown.clsPRPdropdown();
        drpprp.controlList = ddlState;
    
        drpprp.id = Convert.ToInt32(ddlCountry.SelectedValue);
        drpprp.spName = "viewState";
        drp.bindDropDown(drpprp);
      
    }
    private void bindCity()
    {
        nmsDropDown.clsBLdropDown drp = new nmsDropDown.clsBLdropDown();
        nmsDropDown.clsPRPdropdown drpprp = new nmsDropDown.clsPRPdropdown();
        drpprp.controlList = ddlCity;
        if (ddlState.SelectedIndex > 0)
        {
            drpprp.id = Convert.ToInt32(ddlState.SelectedValue);
        }
        drpprp.spName = "viewDistrict";
        drp.bindDropDown(drpprp);
       
    }
    private void InsKIdsProfile()
    {
        clsBLhr bl = new clsBLhr();
        clsprophr prop = new clsprophr();
        prop.name = txtKidsname.Text;
       
        prop.DOB = txtDob.Text;
        prop.email = txtemail.Text;
        prop.Description = txtaddress.Text;
        prop.Country = ddlCountry.SelectedValue;
        prop.City = ddlCity.SelectedValue;
        prop.catid = ddlState.SelectedValue;
        prop.mob = txtmobile.Text;
        prop.Type = RbGender.SelectedValue;
        //--- Start edu
        prop.CurrentStudying = DropDownList1.SelectedValue;
        prop.GraduatingYrs = ddlgrd.SelectedValue;
        prop.EduIntrest = ddlentrest.SelectedValue;
        prop.StudyId = rbs.SelectedValue;
        prop.PrefLocation = ddllocation.SelectedValue;
        prop.WhenStart = DropDownList6.SelectedValue;
       // prop.Experience = txtpassword.Text;
        //-- end edu
      string st=  bl.InsKidsProfile(prop);

      if (st != "note")
      {
          code = st;
          mailSender1();
          Response.Redirect("../Add Institute/CodeVerification.aspx?type=stu");
        

      }
      else
      {
          Warrning.InnerHtml = "<div  style='color:red;' ><p>Mail Address Already Exists !</p> </div>";
      }
        

    }
    protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
    {
        bindCity();

    }
    protected void btsubmit_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            InsKIdsProfile();
        }
    }
    private void mailSender()
    {

        try
        {
            BodyMail = "Code is : " + code; // bindData();
            HeadMail = "Edumate  New Registration Code  ";
            ToMail = txtemail.Text;
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
    private void mailSender1()
    {

        try
        {
            BodyMail = bindData();
            HeadMail = "Edumate New Registration Code";
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
    private string bindData()
    {
        string html = "";
        html += @"<div><center> <table width='500' cellpadding='0' cellspacing='0' style='border:solid 2px gray;'> <tr>
                <th style='color:White; background-color:#3449AE; height:40px; font-size:20px;'  align='center'>
                    Edumate </th> </tr> <tr><td style='width: 50%'> </td> </tr>
            <tr> <td style='font-family:Verdana; font-size:12px;  color:#000000'  align='center'>Hi ";

        
        html += txtKidsname.Text;
        html += @",<br /><span style=' font-size:11px;'>  Welcome in Edumate HR World's first Education Job Portal
                    <br /><br />    Account Verification Code Is:<br /> <br /> <hr />";
       
        html += @" <hr />
                    <a style='text-decoration:none;' href='http://www.edumateworld.com/Add Institute/CodeVerification.aspx?type=stu'> Click Here To Continue !</a>                    
                    </span>
                    <br />
                    <br />
                    Thank You
                    <br />
                    <br />
                    Edumate  Team
                   </span>
                       <br>
                       <br>

</td>
            </tr>
            <tr>
                <td>
                  
                </td>
            </tr>
            
        </table>
    </div> </center>";
        return html;
    }
    protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlCountry.SelectedIndex != 0)
        bindState();

        BindSubCategory();
    }
    protected void rbs_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (rbs.SelectedValue == "1")
        {
            bindState1();
        }
        else 
        {
            BindCountry1();
        }
        
    }

    private void bindState1()
    {
        nmsDropDown.clsBLdropDown drp = new nmsDropDown.clsBLdropDown();
        nmsDropDown.clsPRPdropdown drpprp = new nmsDropDown.clsPRPdropdown();
        drpprp.controlList = ddllocation;
        drpprp.id = Convert.ToInt32(rbs.SelectedValue);
        drpprp.spName = "viewState";
        drp.bindDropDown(drpprp);
    
    }
    private void BindCountry1()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddllocation;
        drpprp.spName = "viewCountry";
        drp.bindDropDown(drpprp);
    }
    protected void ddlentrest_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void ddlgrd_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindSubCategory();
    }
}