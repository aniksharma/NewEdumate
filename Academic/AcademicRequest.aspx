<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AcademicRequest.aspx.cs" Inherits="Academic_AcademicRequest" %>
<%@ Register src="~/UserControl/jobs-top.ascx" tagname="header" tagprefix="uc1" %>
<%@ Register src="~/UserControl/Footer.ascx" tagname="footer" tagprefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edumate</title>
    <link href="../render/stylesheetedumate.css" rel="stylesheet" type="text/css" />

    <link rel="stylesheet" href="../render/jquery.popup.css" type="text/css">
<script src="http://code.jquery.com/jquery-1.9.1.js"></script>
<script type="text/javascript" src="../js/jquery.popup.js"></script>

<script type="text/javascript">
    $(function () {
        $(".js__p_start, .js__p_another_start").simplePopup();
    });
  </script>


</head>
<body>
      <form id="frmjob" runat="server">
<section>
<uc1:header ID="header1" runat="server" />

<section class="middle-seacrh-sectn">
<section class="news-sectn">
    <div class="nav-03" style="margin-bottom:5px;float:left;">
<ul>
<li><a href="FindAcademic.aspx" title="Fin Job">Find Academic</a></li>
<li><a href="AcademicRequest.aspx" title="Job Seeker">Academic Request</a></li>
</ul></div>
   </section>

  <p class="sngle-line"></p>
<div class="main-container">

<section class="middle-sectn">

<h5 class="hdng-03">Academic Request</h5>
<p class="paras-001">
<asp:Label ID="lblViewMsg" runat="server" Font-Bold="True" Font-Size="Large" ></asp:Label>
<table id="tblAcdRequest" runat="server">
 <tr>
    <td>Type</td>
     <td>Category</td>
      <td>Sub Category</td>
        
    </tr>
        <tr>
            <td><asp:DropDownList ID="ddlType" CssClass="DropdwonLong" runat="server">
            <asp:ListItem>--Select Type--</asp:ListItem>
            <asp:ListItem>Test</asp:ListItem>
            <asp:ListItem>Notes</asp:ListItem>
            <asp:ListItem>Practicle</asp:ListItem>
             <asp:ListItem>Any</asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" ControlToValidate="ddlType" ValidationGroup="g1CreateF" InitialValue="--Select Type--"></asp:RequiredFieldValidator>
            </td>

            <td><asp:DropDownList ID="ddlCategory" CssClass="DropdwonLong" runat="server" AutoPostBack="true"
                onselectedindexchanged="ddlCategory_SelectedIndexChanged">
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="ddlCategory" ValidationGroup="g1CreateF" InitialValue="--Select Category--"></asp:RequiredFieldValidator>
                </td>
            
               <td><asp:DropDownList ID="ddlSubCategory" CssClass="DropdwonLong" runat="server"></asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ControlToValidate="ddlSubCategory" ValidationGroup="g1CreateF" InitialValue="--Select Sub-Category--"></asp:RequiredFieldValidator>
        </td>
             </tr>
         
           <tr> <td colspan="3">Title :</td>
             </tr>
             <tr>
             <td colspan="3"><asp:TextBox ID="txtTitle" CssClass="txtbox-fld" width="634px" runat="server"></asp:TextBox></td>
             </tr>
           <tr> <td colspan="3">Request :</td></tr>
           <tr>
           <td colspan="3"><asp:TextBox ID="txtDescription" style="height:50px;width:634px;" CssClass="txtbox-fld" TextMode="MultiLine" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
             <asp:Button ID="btnSave" runat="server" CssClass="bnt-sbmt-01" Text="Submit" ValidationGroup="g1CreateF"
                onclick="btnSave_Click" /> || <asp:Button ID="btnCancel" CssClass="bnt-sbmt-01" 
                    runat="server" Text="Cancel" onclick="btnCancel_Click" />
            </td>
        </tr>
    </table>


    <%--<--------------------------PopUp--------------------------------->--%>
  <div class="p_anch"> <a id="link" runat="server" href="#" class="js__p_start"><asp:Literal ID="litClickHere" runat="server"></asp:Literal></a></div>
<div class="p_body js__p_body js__fadeout"></div>



<div class="popup js__popup js__slide_top"> <a href="#" class="p_close js__p_close" title="Close"></a>
<div class="p_content">Welcome to Edumate<br>
<a href="../Default.aspx" target="_blank">Sign In</a> ||
<a href="../Add Institute/EduType.aspx" target="_blank">Sign Up</a>
</div>
</div>

         <%--<--------------------------PopUp--------------------------------->--%>
</p>


</section>
<section>
<article class="btm-sectn">
</article>
</section>


<section class="container-rght-sectn">

<aside class="Registration-Form-sectn">
<h4 class="hdng-form">Registration Form</h4>
<div class="left-sectn-blk-02">
<p><span class="user-updates">User Name</span></p>
<div class="img-contnt-sectn">
<div class="img-01"><img src="images/btm-img.jpg" alt="user Name" title="User Name"></div>
<div class="img-contnt">
<p class="paras-01">Lorem ipsum <br>
Lorem ipsum dolor siter amet,</p>

</div>
</div>


</div>
<div class="left-sectn-blk-02">
<div class="lft-news">
<p style="margin-bottom:0;"><span class="user-updates-01">News</span></p>

<div class="img-contnt-sectn">
<div class="blks"></div>
<div class="img-contnt">
<p class="news-hdng-rght">UPSC Announces<br>
<span class="paras-01">Lorem ipsum dolor siter amet,</span></p>

</div><p class="paras-002">Lorem ipsum Lorem ipsum dolor siter amet,</br>
Lorem ipsum Lorem ipsum dolor siter amet,</br>
Lorem ipsum Lorem ipsum dolor siter amet,</p>
<p class="readmore">more...</p>
</div>
</div>
</div>
</aside>
<aside class="advrtng-sectn">
<div class="advrtng"></div>
</aside>

</section>
</div>
<footer>
<uc2:footer ID="footer1" runat="server" />

</footer>
</section>
      </form>
</body>
</html>
