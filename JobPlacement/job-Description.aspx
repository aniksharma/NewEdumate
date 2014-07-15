<%@ Page Language="C#" AutoEventWireup="true" CodeFile="job-Description.aspx.cs" Inherits="JobPlacement_job_Description" %>
<%@ Register src="~/UserControl/jobs-top.ascx" tagname="header" tagprefix="uc1" %>
<%@ Register src="~/UserControl/Footer.ascx" tagname="footer" tagprefix="uc2" %>
<%@ Register TagPrefix="uc3" TagName="Right" Src="~/UserControl/RightControl.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Edumate</title>
  <script src="js/jquery-1.6.3.min.js" type="text/javascript"></script>
 <link href="../render/stylesheetedumate.css" rel="stylesheet" type="text/css" />
    <link href="css/jquery.autocomplete.css" rel="stylesheet" type="text/css" />
    <script src="../scripts/jquery-1.4.1.min.js" type="text/javascript"></script>
    <script src="../scripts/jquery.autocomplete.js" type="text/javascript"></script>

 <script type="text/javascript">
     $(document).ready(function () {
         $("#<%=txtlocation.ClientID%>").autocomplete("Search.ashx", {
             width: 200,
             formatItem: function (data, i, n, value) {
                 return "<img style = 'width:50px;height:50px' src='Images/" + value.split(",")[1] + "'/> " + value.split(",")[0];
             },
             formatResult: function (data, value) {
                 return value.split(",")[0];
             }
         });
     });
</script>
</head>
<body>
   <form id="frmdesc" runat="server">
<div class="header-inner-fxd">
<uc1:header ID="header1" runat="server"/>
</div>
       <p class="middle-line-03"></p>
<div class="middle-seacrh-sectn-03">
<div class="middle-sectn-01 middle-sectn-add">
<%--<div class="news-sectn">--%>
<div class="nav-03" style="margin-bottom:5px;float:left;">
<ul>
<li><a href="findjob.aspx" title="Fin Job">Find Job</a></li>
<li><a href="job-Description.aspx" title="Job Seeker">Job Seeker</a></li>
</ul></div>

<div class="slct-sectn-02">
<asp:DropDownList ID="ddlFunctional_Area" CssClass="DropdwonLong" runat="server">
    <asp:ListItem>--Select Functional Area--</asp:ListItem>
    <asp:ListItem>Teaching, Education</asp:ListItem>
    <asp:ListItem>Education/ Teaching/Training</asp:ListItem>
    <asp:ListItem>Teacher / Lecturer / Professor / Academic Research</asp:ListItem>
    <asp:ListItem>HR / Administration, IR</asp:ListItem>
    <asp:ListItem>Teaching</asp:ListItem>
    <asp:ListItem>Others</asp:ListItem>
</asp:DropDownList>
</div>

<div class="slct-sectn-02">
<asp:DropDownList ID="ddlCategory" CssClass="DropdwonLong" runat="server">
 <asp:ListItem>--Select category--</asp:ListItem>
                    <asp:ListItem>Schools</asp:ListItem>
                    <asp:ListItem>College</asp:ListItem>
                    <asp:ListItem>University</asp:ListItem>
                    <asp:ListItem>Company</asp:ListItem>
                    <asp:ListItem>Training/Coaching Institutes</asp:ListItem>
</asp:DropDownList>
</div>

<div class="slct-sectn-02">
<asp:TextBox id="txtlocation" runat="server" placeholder="Type Your Location" CssClass="txtbox-fld"></asp:TextBox>
</div>

<asp:Label ID="lblMsg"  runat="server" Text="" ></asp:Label>

<asp:Button ID="btnSearch" runat="server" CssClass="bnt-sbmt-01" Text="Search" 
       onclick="btnSearch_Click" />

</div>

<p class="middle-line-02"></p>
<div class="main-container">
<div class="middle-sectn">
<div class="artcless-middle">
<h5 class="hdng-03"><asp:Literal ID="litbody" runat="server"></asp:Literal></h5>
<div class="artcless-container">
<p class="paras-001">
<asp:Literal ID="litName" runat="server"></asp:Literal><br />
<asp:Literal ID="litPresentLocation" runat="server"></asp:Literal><br />
<asp:Literal ID="litPreLocation" runat="server"></asp:Literal>
</p>
</div>
</div>
</div>
<div class="left-sectn-blk-02">
</div>
<div class="container-rght-sectn-02">
                <uc3:Right ID="Right1" runat="server" />
            </div>
</div>
<footer>
<uc2:footer ID="footer1" runat="server" />
</footer>
</form>
</body>
</html>
