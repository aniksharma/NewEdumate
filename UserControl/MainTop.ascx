<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MainTop.ascx.cs" Inherits="UserControl_MainTop" %>
<section>
    <header>

        <div class="header-inner">
            <div class="logo-sectn">
                <img src="images/logo.png" class="img-prfil" alt="Edumate"></div>
            <div class="country-sectn">
                <asp:DropDownList ID="ddlcountry" runat="server" class="slct-fld"></asp:DropDownList>
            </div>

            <article class="header-inner-right">
                <ul>
                    <li><a href="Default.aspx">HOME</a></li>
                    <li><a href="<%=ResolveClientUrl("~/CollegeMain.aspx?name=College")%>">Course</a></li>
                    <li><a href="<%=ResolveClientUrl("~/Career.aspx?name=Careers")%>">Careers</a></li>
                    <li><a href="<%=ResolveClientUrl("~/EducationBoard.aspx?name=Education")%>">Education</a></li>
                    <li><a href="<%=ResolveClientUrl("~/EntranceExam.aspx?name=Exam")%>">Exam</a></li>

                </ul>

            </article>

        </div>
    </header>
    <div class="main-container">
        <div class="container-left-sectn">
            <div class="blk-sectn"></div>
            <div class="left-sectn-blk">
                <p><span class="user-updates">User Updates</span><span><img src="images/user-updates.jpg" width="29" height="30" alt="User"></span></p>
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
                        <p class="paras-01">
                            Lorem ipsum
                            <br>
                            Lorem ipsum dolor siter amet,
                        </p>

                    </div>
                </div>
            </div>
            <div class="left-sectn-blk-01">
                <p><span class="user-updates"><a href="../../../http:eduemate.advanceschool.in" target="_blank">Advance School</a> </span></p>
                <div class="img-contnt-sectn">
                    <div class="img-01">
                        <img src="images/advancelogo.jpg" width="61" height="52" alt="Advance"></div>
                    <div class="img-contnt">
                        <p class="paras-01">
                            Lorem ipsum
                            <br>
                            Lorem ipsum dolor siter amet,
                        </p>

                    </div>
                </div>
            </div>
        </div>


    </div>
    <footer>
        <div class="footer-innr">
            <ul>
                <li><a href="<%=ResolveClientUrl("~/logout.aspx?name=Home")%>">Home</a></li>
                <li><a href="#">About us</a></li>
                <li><a href="#">Services</a></li>
                <li><a href="#">Help</a></li>
                <li><a href="#">Contact us</a></li>
            </ul>
        </div>
    </footer>
</section>

