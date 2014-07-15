<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MainControl.ascx.cs" Inherits="UserControl_MainControl" %>
<link href="~/render/stylesheetedumate.css" rel="stylesheet" type="text/css"/>
<link href="~/JobPlacement/css/jquery.autocomplete.css" rel="stylesheet" type="text/css"/>
<script src="~/scripts/jquery-1.4.1.min.js" type="text/javascript"></script>
<script src="~/scripts/jquery.autocomplete.js" type="text/javascript"></script>   
<script type="text/javascript">
$(document).ready(function () {
 $("#<%=txtlocation.ClientID%>").autocomplete("../JobPlacement/Search.ashx", {
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
<div class="header-inner"> 
<div class="logo-sectn"><img src="<%= ResolveUrl("~/images/logo.png") %>" alt="Edumate"></div>
<div class="country-sectn">
<asp:DropDownList ID ="ddlcountry" runat ="server" class="slct-fld" AutoPostBack ="true" OnSelectedIndexChanged="ddlcountry_SelectedIndexChanged"  ></asp:DropDownList>
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
<div class="header-top-01">
<div class="header-top-01-innr">
<div class="navi-top-02">
<ul>
<li><a href="<%=ResolveClientUrl("~/UniversityMain.aspx?name=Uni")%>">Universities</a></li>
<li><a href="<%=ResolveClientUrl("~/CollegeMain.aspx?name=College")%>">College</a></li>
<li><a href="<%=ResolveClientUrl("~/SchoolMain.aspx?name=School")%>">School</a></li>
<li><a href="<%=ResolveClientUrl("~/InstitutesMain.aspx?name=Inst")%>">Institutes</a></li>
<li><a href="<%=ResolveClientUrl("~/TeacherMain.aspx?name=Teacher")%>">Teacher</a></li>
<li><a href="#">Blog</a></li>
</ul>
</div>
<div class="search-sectn">
<asp:TextBox id="txtlocation" runat="server" placeholder="Quick Search" CssClass="search-fld-sectn"></asp:TextBox>
<input name="" type="button" value="search" class="search-btn-setcn-01">
</div>
<div>
<span id="txtHint"></span>
</div>
</div>
</div>