<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="InstitutePanel_Home" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Edumate</title>
<link href="../render/stylesheetedumate.css" rel="stylesheet" type="text/css">
</head>
<body>
    <form id="form1" runat="server">
   <section>
<header>
<div class="header-inner">
<div class="logo-sectn"><img src="../images/logo.jpg" width="62" height="52" class="img-prfil" alt="Edumate"></div>
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
<li><a href="#" title="Home">Home</a></li>
<li><a href="#" title="Courses">Courses</a></li>
<li><a href="#" title="Careers">Careers</a></li>
<li><a href="#" title="Education Board">Education Board</a></li>
<li><a href="#" title="Exam">Exam</a></li>
</ul>

</article>

</div>
</header>
<div class="main-container">
<div class="container-left-sectn">
<div class="blk-sectn"></div>
<div class="left-sectn-blk">
<p><span class="user-updates">User Updates</span><span><img src="../images/user-updates.jpg" width="29" height="30" alt="User"></span></p>
<div class="img-contnt-sectn">
<div class="img-01"></div>
<div class="img-contnt">
<h5 class="hdng-01">IgnoU</h5>
<p class="paras">Open Community College</p>
</div>
</div>
</div>
<div class="left-sectn-blk-01">
<p><span class="user-updates">Books World</span></p>
<div class="img-contnt-sectn">
<div class="img-01"></div>
<div class="img-contnt">
<p class="paras-01">Lorem ipsum <br>
Lorem ipsum dolor siter amet,</p>

</div>
</div>
</div>
<div class="left-sectn-blk-01">
<p><span class="user-updates">Advance School</span></p>
<div class="img-contnt-sectn">
<div class="img-01"><img src="../images/advancelogo.jpg" width="61" height="52" alt="Advance"></div>
<div class="img-contnt">
<p class="paras-01">Lorem ipsum <br>
Lorem ipsum dolor siter amet,</p>

</div>
</div>
</div>
</div>
<section class="middle-sectn-01">
<div class="middle-uppr-sectn">
<div class="middle-uppr-navisectn">
<ul>
<li><a href="#" title="Universities">Universities</a></li>
<li><a href="#" title="College">College</a></li>
<li><a href="#" title="School">School</a></li>
<li><a href="#" title="Institutes">Institutes</a></li>
<li><a href="#" title="Teacher">Teacher</a></li>
<li><a href="#" title="Student">Student</a></li>
</ul>
</div>
<div class="secrh-sectn">
<input name="" type="text" class="secrh-fld"><input name="Search"  value="Search" class="secrh-btn" type="button">
</div>
<div class="nav-03">
<ul>
<li><a href="#" title="News">News</a></li>
<li><a href="#" title="Articles">Articles</a></li>
<li><a href="#" title="Alerts">Alerts</a></li>
</ul>
</div>
</div>
<article class="artcless-middle">
<p class="artcless-img-02"></p>
<div class="artcless-container">
<h5 class="hdng-03">UPSC Announces interview dates for CISF 2013</h5>
<p class="paras-01">Lorem ipsum</br>
Lorem ipsum dolor siter amet, ipsum dolor siter amet,</br>
Lorem ipsum dolor siter amet.</p>
</div>
</article>
<article class="lst-sectn">
<ul>
<li><a href="#">UPSC Announces interview dates for CISF 2013</a></li>
<li><a href="#">UPSC Announces interview dates for CISF 2013</a></li>
<li><a href="#">UPSC Announces interview dates for CISF 2013</a></li>
<li><a href="#">UPSC Announces interview dates for CISF 2013</a></li>
<li><a href="#">UPSC Announces interview dates for CISF 2013</a></li>
</ul>
<p class="readmore"><a href="#">readmore...</a></p>
</article>
<article class="btm-sectn">
<div class="btm-blk-01">
<h5 class="hdng-03">Jobs</h5>
<div class="img-btm-sectn"><img src="../images/btm-img.jpg" width="70" height="52" alt="Jobs"></div>
<p class="paras-01">Lorem ipsum dolor siter,</br>
Lorem ipsum,</p>
</div>
<div class="btm-blk-01">
<h5 class="hdng-03">Tuition Request</h5>
<div class="img-btm-sectn"><img src="../images/btm-img.jpg" width="70" height="52" alt="Jobs"></div>
<p class="paras-01">Lorem ipsum dolor siter,</br>
Lorem ipsum,</p>
</div>
<div class="btm-blk-01">
<h5 class="hdng-03">Blog</h5>
<div class="img-btm-sectn"><img src="../images/btm-img.jpg" width="70" height="52" alt="Jobs"></div>
<p class="paras-01">Lorem ipsum dolor siter,</br>
Lorem ipsum,</p>
</div>
</article>
</section>
<section class="container-rght-sectn">
<div class="social-icon">
<div class="icons-img"><img class="grayscale" src="../images/Facebook.jpg" alt="facebook" title="facebook"></div>
<div class="icons-img"><img class="grayscale" src="../images/twitter.jpg" alt="twitter" title="twitter"></div>
<div class="icons-img"><img class="grayscale" src="../images/linkedin.jpg" alt="linkedin" title="linkedin"></div>
</div>
<aside class="Registration-Form-sectn">
<h4 class="hdng-form">Registration Form</h4>
<div class="left-sectn-blk-02">
<p><span class="user-updates"><asp:Literal ID="litName" runat="server"></asp:Literal></span></p>
<div class="img-contnt-sectn">
<div class="img-01">
<asp:Image ID="imglogo" height="65px" width="65px" runat="server"/></div>
<div class="img-contnt">
<p class="paras-01">Lorem ipsum <br>
Lorem ipsum dolor siter amet,
<a href="Default.aspx">My Account</a>
<a href="#">Create New Account</a>
</p>


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
<div class="footer-innr">
<ul>
<li><a href="#">Home</a></li>
<li><a href="#">About us</a></li>
<li><a href="#">Services</a></li>
<li><a href="#">Help</a></li>
<li><a href="#">Contact us</a></li>
</ul>
</div>
</footer>
</section>
    </form>
</body>
</html>
