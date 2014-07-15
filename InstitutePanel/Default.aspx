<%@ Page Language="C#" MasterPageFile="~/InstitutePanel/MasterPage2.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="InstitutePanel_Default" Title="Edu Hub" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
<table>
<tr><td>
<div id="wel">
<div class="wel_h"><img src="../Admin/images/logo2.png" style="float:left"  />

    <img src="../Admin/images/welcome.jpg" style="float:right"/>

</div>
<div class="text">
</div>
</div>
</td>
</tr>
<tr>
<td style="line-height:24px;">
<div class="wel_text">Edu Education search</div>
<div class="wel_text_sm">Registration Confirmation</div>
             We have sent you a confirmation mail on your email id-.<asp:Label ID="Label1" runat="server" Font-Bold="True"></asp:Label>
             . !
             <br />
             Kindly login into you mail account and verify your account with us!
             <br />
             Please check your spam/junk/bulk folder incase the verification 
             <br />
             mail has been diverted to the same. Best Regards,<br />
             Team EduMate.                  
       </td></tr>                                                                      
</table>
        
</asp:Content>
