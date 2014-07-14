<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage/AdminMaster.master" AutoEventWireup="true" CodeFile="Welcome.aspx.cs" Inherits="Admin_web_Welcome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table ><tr><td>
<div id="wel">
   
<div class="wel_h"><img src="../images/logo.jpg" /> </div>
<div class="wel_img"><img src="../images/welcome.png"></div>
<div class="wel_text">Edu Education search</div>
<div class="wel_text_sm">Added Sucessfully </div>
<div class="text">
<table>
<tr><td style="font-family:@Arial Unicode MS; font-size:15px; line-height:15px;">
           
              your email id- &nbsp; &nbsp;<asp:Label ID="Label1" runat="server" Font-Bold="True"></asp:Label>
             . !
           
             Team EduMate.
             
       </td></tr>                                                                      
</table>

</div>



</div>


</td></tr></table>

</asp:Content>

