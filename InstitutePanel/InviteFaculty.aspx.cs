using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
using System.IO;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class InstitutePanel_Default3 : System.Web.UI.Page
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

    }
    private string bindData()
    {
        string html = "";
        html += @"<div><center> <table width='500' cellpadding='0' cellspacing='0' style='border:solid 2px gray;'> <tr>
                <th style='color:White; background-color:#3449AE; height:40px; font-size:20px;'  align='center'>
                    Edumate </th> </tr> <tr><td style='width: 50%'> </td> </tr>
            <tr> <td style='font-family:Verdana; font-size:12px;  color:#000000'  align='center'>Hi ";

        //html += txtKidsname.Text + "( " + txtSchoolname.Text+ " )";
        html += txtCrsFullname.Text;
        html += @",<br /><span style=' font-size:11px;'>  Welcome in Edumate HR World's first Education Job Portal
                    <br /><br />    Account Verification Code Is:<br /> <br /> <hr />";

        html += code;
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
    private void mailSender()
    {

        try
        {
            BodyMail = "Code is : " + code; // bindData();
            HeadMail = "Edumate New Faculty Invitation  ";
            ToMail = txtCrsShortName.Text;
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
}