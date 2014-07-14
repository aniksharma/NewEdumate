<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AcademicDescription.aspx.cs" Inherits="Academic_AcademicDescription" %>
<%@ Register src="~/UserControl/jobs-top.ascx" tagname="header" tagprefix="uc1" %>
<%@ Register src="~/UserControl/Footer.ascx" tagname="footer" tagprefix="uc2" %>
<%@ Register TagPrefix="uc3" TagName="Right" Src="~/UserControl/RightControl.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
  <title>Edumate</title>
  <script src="../js/jquery-1.6.3.min.js" type="text/javascript"></script>
    <link href="../render/stylesheetedumate.css" rel="stylesheet" type="text/css" />
</head>
<body>
<form id="frmjob" runat="server">
<div class="header-inner-fxd">
<uc1:header ID="header1" runat="server" />
</div>
<div class="middle-seacrh-sectn-01">
<div class="middle-seacrh-sectn-01-inner">
<div class="news-sectn">
<div class="nav-03" style="margin-bottom:5px;float:left;width: 312px;">
<ul>
<li><a href="#" title="Fin Job">Find Academic</a></li>
<li><a href="#" title="Job Seeker">Academic Request</a></li>
</ul></div>
</div>
<asp:Label ID="lblMsg"  runat="server" Text="" ></asp:Label>
</div>
</div>
<p class="middle-line-03"></p>



<div class="main-container">

<div class="middle-sectn">
<section class="batch-year">
<div class="lft-txt-hdng-sectn">

<h1 class="hng-txt"><%=strsave%></h1></div>

</section>
<article class="artcless-middle">
<div class="middle-sectn-0011">
<div class="lft-sectn-imgs">
<div class="img-students">
<img src="../Advertisement/<%=strsave2%>" class="img-sz" title="Students"> 
</div>

<b><%=strsave3%></b>
<p><%=strsave4%> (<b style="color:#4179B0"><%=strsave5%></b>-days ago)</p>
<p>NorthWest Arkansas</p>
<p>World Count: 6022</p>

</div><asp:Panel ID="pnlPerson" runat="server">

<span class="acdhd"><h4 style="color: #3D7489;"><b><%=strsave1%></b></h4></span>
    <article class="para-home">
     <div style="overflow-y:scroll; height:230px;">
<p><%=strsave6%></p>
</div>
<p></p>
  </article>
  </asp:Panel>

  <input name="" type="button" value="Register Now" class="registr">
  <asp:Button ID="btnExport" runat="server" class="export" Text="Export" OnClick="btnExport_Click" />
    
  </div>
  <p class="partation-lines"></p>
<section class="batch-year">

<div class="lft-txt-hdng-sectn">
<h1 class="hng-txt">Batch Year</h1></div>
<div class="middle-sectn-02">

<article class="artcless-middle">
<p class="img-02-blk"><img src="../CollegeImage/page.jpg"></p>
<p class="img-02-blk"><img src="../CollegeImage/page-01.jpg"></p>
<p class="img-02-blk"><img src="../CollegeImage/page-02.jpg"></p>

</article>
<article class="artcless-middle">
<p class="img-02-blk"><img src="../CollegeImage/page.jpg"></p>
<p class="img-02-blk"><img src="../CollegeImage/page-01.jpg"></p>
<p class="img-02-blk"><img src="../CollegeImage/page-02.jpg"></p>

   
</article>
</div>

</section>

</article>

</div>
<%--<section>
<article class="btm-sectn">
</article>
</section>--%>
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
</form>
</body>
</html>
