<%@ Control Language="C#" AutoEventWireup="true" CodeFile="jobs-top.ascx.cs" Inherits="UserControl_jobs_top" %>
<html>
<head>
    <meta charset="utf-8">
    <title>Edumate</title>
    <link href="../render/stylesheetedumate.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <section>
<header>
<div class="header-inner">
<div class="logo-sectn"><img src="../images/logo.jpg" width="62" height="52" alt="Edumate"></div>
<div class="country-sectn">
<select name="" class="slct-fld">
<option>Country</option>
<option>a</option>
<option>b</option>
<option>c</option>
<option>d</option>
</select>
</div>
<article class="header-inner-right">
<ul>
<li><a href="<%=ResolveClientUrl("~/logout.aspx?name=Home")%>">Home</a></li>
<li><a href="<%=ResolveClientUrl("~/CollegeMain.aspx?name=College")%>">Course</a></li>
<li><a href="<%=ResolveClientUrl("~/Career.aspx?name=Careers")%>">Careers</a></li>
<li><a href="<%=ResolveClientUrl("~/EducationBoard.aspx?name=Education")%>">Education</a></li>
<li><a href="<%=ResolveClientUrl("~/EntranceExam.aspx?name=Exam")%>">Exam</a></li>

</ul>

</article>

</div>
<div class="header-top-01">
  <div class="header-top-01-innr">
    <div class="navi-top-02">
      <ul>
        <li><a href="<%=ResolveClientUrl("~/UniversityMain.aspx?name=Uni")%>">Universities</a></li>
<li><a href="<%=ResolveClientUrl("~/CollegeMain.aspx?name=College")%>">College</a></li>
<li><a href="<%=ResolveClientUrl("~/SchoolMain.aspx?name=School")%>">School</a></li>
<li><a href="<%=ResolveClientUrl("~/InstitutesMain.aspx?name=Inst")%>">Institutes</a></li>
<li><a href="<%=ResolveClientUrl("~/TeacherMain.aspx?name=Teacher")%>">Teacher</a></li>
<li><a href="#" title="Blog">Blog</a></li>
      </ul>
    </div>
    <div class="search-sectn">
      <input name="input" type="text" placeholder="search" class="search-fld-sectn">
      <input name="input" type="button" value="search" class="search-btn-setcn-01">
    </div>
    
  </div>
</div>
</header>
<div class="header-inner">
<div class="header-top-01-innr">
<div class="navi-top-02">
<ul>
<li><a href="<%=ResolveClientUrl("~/UniversityMain.aspx?name=Uni")%>">Universities</a></li>
<li><a href="<%=ResolveClientUrl("~/CollegeMain.aspx?name=College")%>">College</a></li>
<li><a href="<%=ResolveClientUrl("~/SchoolMain.aspx?name=School")%>">School</a></li>
<li><a href="<%=ResolveClientUrl("~/InstitutesMain.aspx?name=Inst")%>">Institutes</a></li>
<li><a href="<%=ResolveClientUrl("~/TeacherMain.aspx?name=Teacher")%>">Teacher</a></li>
<li><a href="#" title="Blog">Blog</a></li>
</ul>
</div>
<div class="search-sectn">
<input name="" type="text" placeholder="search" class="search-fld-sectn">
<input name="" type="button" value="search" class="search-btn-setcn-01">
</div>

</div>
</div>
</body>
</html>
