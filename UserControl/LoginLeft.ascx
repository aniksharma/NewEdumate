<%@ Control Language="C#" AutoEventWireup="true" CodeFile="LoginLeft.ascx.cs" Inherits="UserControl_LoginLeft" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<link href="../render/stylesheetedumate.css" rel="stylesheet" type="text/css" />


<header>
<div class="header-inner">
<div class="logo-sectn"><img src="images/logo.jpg" width="62" height="52" class="img-prfil" alt="Edumate"></div>
<div class="country-sectn">
<asp:DropDownList ID ="ddlcountry" runat ="server" class="slct-fld" AutoPostBack ="True"  ></asp:DropDownList>
</div>

<article class="header-inner-right">
<ul>

<li><a href="<%=ResolveClientUrl("~/logout.aspx?name=Home")%>">Home</a></li>
<li><a href="<%=ResolveClientUrl("~/CollegeMain.aspx?name=College")%>">Course</a></li>

<li><a href="<%=ResolveClientUrl("~/Career.aspx?name=Careers")%>">Careers</a></li>
<li><a href="<%=ResolveClientUrl("~/EducationBoard.aspx?name=EducationBoard")%>">Education</a></li>
<li><a href="<%=ResolveClientUrl("~/EntranceExam.aspx?name=Exam")%>">Exam</a></li>
</ul>

</article>

</div>


</header>




<div class="container-left-sectn">

<div class="middle-uppr-sectn">
<div class="middle-uppr-navisectn">
<ul>
<li><a href="#" title="Universities">Universities</a></li>
<li><a href="#" title="College">College</a></li>
<li><a href="#" title="School">School</a></li>
<li><a href="#" title="Institutes">Institutes</a></li>
<li><a href="#" title="Teacher">Teacher</a></li>
<li><a href="#" title="Student">Blog</a></li>
</ul>
</div>


</div>
<div class="img-box"> <asp:Image ID="imglogo" runat="server" Height="122px" 
        Width="106px" /> </div>
<p class="edit">  <asp:LinkButton ID="LinkButton2" CssClass="iconlink" runat="server" >Edit Image</asp:LinkButton>                                           
                                            <cc1:ModalPopupExtender ID="LinkButton2_ModalPopupExtender" runat="server" 
        BackgroundCssClass="backcss" CancelControlID="LinkButton3" 
        DynamicServicePath="" Enabled="True" PopupControlID="EditImage" 
        TargetControlID="LinkButton2">
    </cc1:ModalPopupExtender></p>
<p class="profile-name"><asp:Literal ID="litName" runat="server"></asp:Literal> </p>
<div class="left-sectn-navi">
<ul>
<li><a href="UpdateTutorProfile.aspx">Profile </a></li>
<li><a href="List.aspx">Listing</a></li>
<li><a href="#">Job</a></li>
<li><a href="#">Acadmic</a></li>  
<li><a href="StudentLead.aspx">Students Lead</a></li>  
<li><a href="#">Students Group</a></li>  
<li><a href="#">More...</a></li>
<ul>
<li>Help Desk</li>
<li>Change Password</li>
</ul>

</ul>
</div>
<div class="advrtng"></div>

</div>

<section class="middle-sectn-01">
<p class="sngle-line">
<asp:Panel ID="EditImage" runat="server" style="border:2px solid #DADADA;" >
            <table width="500px"  style="background-color:#929292; height:200px;  text-align:center"  >
            <tr valign="top"><td align="right" style="color:White; size:15px;height: 17px;">
                <asp:LinkButton ID="LinkButton3" CssClass="crosbutton" runat="server"><span style="padding-right:5px;" >X</span></asp:LinkButton></td></tr>
            <tr valign="top"><td style="color:White; font-family:Verdana; font-weight:500; height: 22px;">
                Choose Your Logo Image<br /> &nbsp;<asp:Label ID="lblMsg" runat="server"></asp:Label>
                </td></tr>
             <tr valign="top"><td style="height: 26px">
                 <asp:FileUpload ID="FileUpload1" runat="server" />
                 <span style="color:White; size:15px;height: 17px;">
                 (size Height:150px, Width:150px;)</span>
                 </td></tr>
              <tr valign="top"><td style="height: 30px">
                  <asp:Button ID="btupload" runat="server" Text="Upload" 
                  onclick="btupload_Click" />
                                                   
             </td>
                      </tr>
            </table>
            </asp:Panel>

</p>
<div class="artcless-container">


</div>