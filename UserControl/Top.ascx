<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Top.ascx.cs" Inherits="UserControl_Top" %>

<header>
<div class="header-inner">
<div class="logo-sectn"><img src="<%=ResolveClientUrl("~/images/logo.png")%>" class="img-prfil" alt="Edumate"></div>
<div class="country-sectn">
<asp:DropDownList ID ="ddlcountry" runat ="server" class="slct-fld" AutoPostBack ="false"   ></asp:DropDownList>
</div>
<div class="header-inner-right">
<ul>
<li><a href="<%=ResolveClientUrl("../Default.aspx")%>">Home</a></li>
<li><a href="<%=ResolveClientUrl("~/InstitutePanel/InnerCollege.aspx")%>">Course</a></li>
<li><a href="<%=ResolveClientUrl("~/InstitutePanel/InnerCareer.aspx?name=Careers")%>">Careers</a></li>
<li><a href="<%=ResolveClientUrl("~/InstitutePanel/innerEducation.aspx?name=Education")%>">Education</a></li>
<li><a href="<%=ResolveClientUrl("~/InstitutePanel/innerExam.aspx?name=Exam")%>">Exam</a></li>

</ul>

</div>
</div>
</header>
