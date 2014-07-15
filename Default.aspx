<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ Register TagPrefix="uc1" TagName="Top" Src="~/UserControl/MainTop.ascx" %>
<%@ Register TagPrefix="uc2" TagName="MiddleTop" Src="~/UserControl/MainMiddle.ascx" %>
<%@ Register TagPrefix="uc3" TagName="Right" Src="~/UserControl/RightControl.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Edumate</title>
    <script src="js/jquery-1.6.3.min.js" type="text/javascript"></script>
    <link href="~/render/stylesheetedumate.css" rel="stylesheet" type="text/css" />
    <link href="~/render/tabs-panes.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:Top ID="top1" runat="server" />
    </div>
    <div>
        <uc2:MiddleTop ID="MiddleTop" runat="server" />
    </div>
    <div class="container-rght-sectn-01">
    <div class="social-icon">
<div class="icons-img"><img class="grayscale" src="~/../images/Facebook.jpg" alt="" title="facebook"></div>
<div class="icons-img"><img class="grayscale" src="~/../images/twitter.jpg" alt="" title="twitter"></div>
<div class="icons-img"><img class="grayscale" src="~/../images/linkedin.jpg" alt="" title="linkedin"></div>
</div>
        <uc3:Right ID="Right1" runat="server" />
    </div>
    <div id="pageNavPosition" style="padding-top: 20px" align="center">
    </div>
    </form>
</body>
</html>
