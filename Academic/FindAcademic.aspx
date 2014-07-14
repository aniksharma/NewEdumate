<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FindAcademic.aspx.cs" Inherits="Academic_FindAcademic" %>
<%@ Register src="~/UserControl/jobs-top.ascx" tagname="header" tagprefix="uc1" %>
<%@ Register src="~/UserControl/Footer.ascx" tagname="footer" tagprefix="uc2" %>
<%@ Register TagPrefix="uc3" TagName="Right" Src="~/UserControl/RightControl.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Edumate</title>
  <script src="js/jquery-1.6.3.min.js" type="text/javascript"></script>
    <link href="../render/stylesheetedumate.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="frmjob" runat="server">
<div>
<uc1:header ID="header1" runat="server" />

</div>
<div class="middle-seacrh-sectn-02">
<div class="middle-seacrh-sectn-01-inner">
<div class="news-sectn">
<div class="nav-03" style="margin-bottom:5px;float:left;">
<ul>
<li><a href="#" title="Fin Job">Find Academic</a></li>
<li><a href="#" title="Job Seeker">Academic Request</a></li>
</ul></div>
<div class="slct-sectn-02">
<asp:DropDownList ID="ddlCategory" CssClass="DropdwonLong" runat="server" AutoPostBack="true"
                onselectedindexchanged="ddlCategory_SelectedIndexChanged">
                </asp:DropDownList>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="ddlCategory" ValidationGroup="g1CreateF" InitialValue="--Select Category--"></asp:RequiredFieldValidator>
</div>
<div class="slct-sectn-02">
<asp:DropDownList ID="ddlSubCategory" CssClass="DropdwonLong" runat="server"></asp:DropDownList>
 <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ControlToValidate="ddlSubCategory" ValidationGroup="g1CreateF" InitialValue="--Select Sub-Category--"></asp:RequiredFieldValidator>
</div>
<asp:Button ID="btnSearch" runat="server" CssClass="bnt-sbmt-01" Text="Search" ValidationGroup="g1CreateF" onclick="btnSearch_Click" />
<asp:Label ID="lblMsg"  runat="server" Text="" ></asp:Label>
</div>
</div>
</div>

<p class="middle-line-02"></p>
<div class="main-container">
<div class="middle-sectn">
<h5 class="hdng-03">
    <asp:Literal ID="litbody" runat="server"></asp:Literal>
</h5>

<p class="paras-001">
<asp:Literal ID="litName" runat="server"></asp:Literal><br />
<asp:Literal ID="litPresentLocation" runat="server"></asp:Literal><br />
<asp:Literal ID="litPreLocation" runat="server"></asp:Literal>
</p>
</div>
</div>
<div class="container-rght-sectn">

<aside class="Registration-Form-sectn">
<uc3:Right ID="right" runat="server" />
</aside>
<aside class="advrtng-sectn">
<div class="advrtng"></div>
</aside>
</div>
<footer>
<uc2:footer ID="footer1" runat="server" />
</footer>
</form>
</body>
</html>
