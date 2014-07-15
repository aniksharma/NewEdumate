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

public partial class frgt : System.Web.UI.Page
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

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        mailSender();
        lbltxt.Text = "Your Password Details Sent to your mail";
        txtEmail.Text = "";
       
    }
    
    private void mailSender()
    {

        try
        {
            DataSet ds = new DataSet();
           using (SqlConnection con = new SqlConnection("Data Source=216.144.254.243;Max Pool Size=200;Initial Catalog=dbedumatenew;uid =eduworld;pwd=eduworld#@345"))
          {
                  con.Open();
                  SqlCommand cmd = new SqlCommand("SELECT LoginName,LoginPassWord FROM tblInstituteLogin Where LoginName= '" + txtEmail.Text.Trim() + "'", con);
                  SqlDataAdapter da = new SqlDataAdapter(cmd);
                  da.Fill(ds);
                  con.Close();
             }
                if (ds.Tables[0].Rows.Count > 0)
                  {
                      BodyMail = @"<div style='width:625px;border-top:#c0f solid 3px;padding-top:10px'>
<span style='font-family:arial;width:270px;font-size:24px;font-weight:bold;color:#006'>
<i>Edu Education Search </i>
</span>
<span style='padding-left:235px;vertical-align:bottom;font-family:arial;font-size:14px;text-align:right;color:#666'>Forget Password Mail</span>
<div style='border-top:#ebebeb solid 1px'></div>
<div style='border-top:#ebebeb solid 1px'></div>
<div style='margin-top:20px;padding:10px;float:left;font-family:arial;font-size:18px;color:#666'>
<img>
</div>
<div style='font-size:12px;width:512px;margin-left:10px;font-family:arial;margin-top:20px;float:right'>
Hello <b>" +
txtEmail.Text
+ @"</b>,
<br>
<br>
Please check your Login Details<br/><br/>Your Username: " + ds.Tables[0].Rows[0]["LoginName"] +
                                            "<br/><br/>Your Password: " + ds.Tables[0].Rows[0]["LoginPassWord"] + "<br/><br/>" + @"
 Kindly click on the<b>Continue</b>
button to confirm your password.
</div>
<div>
<a target='_blank' style='border-right:#000 1px solid;text-align:center;width:75px;background-color:#9f0;font-weight:bold;padding:5px;
float:left;font-size:12px;margin-left:12px;border-bottom:#000 1px solid;font-family:arial;text-decoration:none;margin-top:10px'
href='http://www.edumateworld.com/Default.aspx?username=" + txtEmail.Text + "'>Continue</a>" + @"
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


  
            HeadMail = "Edu - Your Password Detail";
            ToMail = txtEmail.Text;
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
               
                else
                {
                    lbltxt.Text = "The Email you entered not exists.";
                }


        }


        catch (Exception ex)
        {
        }

    }   
    }

