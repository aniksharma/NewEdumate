<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frgt.aspx.cs" Inherits="frgt" %>
<%@ Register TagPrefix="uc1" TagName="Top" Src="~/UserControl/MainTop.ascx" %>
<%@ Register TagPrefix="uc2" TagName="MiddleTop" Src="~/UserControl/MainMiddle.ascx" %>
<%@ Register TagPrefix="uc3" TagName="Right" Src="~/UserControl/RightControl.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="js/jquery-1.6.3.min.js" type="text/javascript"></script>
    <link href="~/render/stylesheetedumate.css" rel="stylesheet" type="text/css" />
    <link href="~/render/tabs-panes.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <uc1:Top ID="top1" runat="server" />
    </div>
    <div class="main-container">
        <section class="middle-sectn-main">
    <table cellspacing="2" cellpadding="2" border="0">
<tr><td></td><td><b>Forgot Password </b></td></tr>
<tr><td><b>Enter Your Email:</b></td><td><asp:TextBox ID="txtEmail" runat="server" /></td></tr>
<tr><td></td><td><asp:button ID="btnSubmit" Text="Submit"  runat="server" onclick="Button1_Click" CssClass="Button"/></td></tr>
<tr><td colspan="2" style=" color:red"><asp:Label ID="lbltxt" runat="server"/></td></tr>
</table>
            </section>
    </div>


        
    </form>
</body>
</html>
