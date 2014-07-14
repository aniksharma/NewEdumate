<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EduType.aspx.cs" Inherits="Add_Institute_EduType" %>

<%@ Register TagPrefix="uc1" TagName="Top" Src="~/UserControl/MainControl.ascx" %>
<%@ Register TagPrefix="uc2" TagName="MiddleTop" Src="~/UserControl/MiddleControl.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../render/stylesheetedumate.css" rel="stylesheet" type="text/css" />
    <link href="../render/login.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <div>
                <uc1:Top ID="top1" runat="server" />
            </div>
            <p class="sngle-line"></p>

            <div class="middle-sectn-ebag">
                <div class="midlle-home">
                    <div class="form">
                        <ul>
                            <h2 class="hdng-edu">Sign up now it’s free</h2>
                            <a href="CollegeRegistration.aspx">
                                <p class="btns-tab">College</p>
                            </a>
                            <a href="SchoolRegistration.aspx">
                                <p class="btns-tab">School</p>
                            </a>
                            <a href="InstituteRegistration.aspx">
                                <p class="btns-tab">Institutes</p>
                            </a>
                            <a href="TutorRegistration.aspx">
                                <p class="btns-tab">Teacher</p>
                            </a>
                            <a href="StudentRegistration.aspx">
                                <p class="btns-tab">Student</p>
                            </a>
                        </ul>

                    </div>
                    <div class="form-01">
                        <h2 class="hdng-edu">Edumate Portal</h2>
                        <p>
                            Edumate helps connect all college with the consultant
and resources needed to reach their full potential.all college with the consultant and resources needed
to reach their full potential.
                        </p>

                    </div>


                </div>
            </div>
        </div>


    </form>
</body>
</html>
