<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Alerts.aspx.cs" Inherits="Alerts" hi this is bhanu%>

<%@ Register TagPrefix="uc1" TagName="Top" Src="~/UserControl/MainControl.ascx" %>
<%@ Register TagPrefix="uc2" TagName="MiddleTop" Src="~/UserControl/TabControl.ascx" %>
<%@ Register TagPrefix="uc3" TagName="Right" Src="~/UserControl/RightControl.ascx" %>
<%@ Register TagPrefix="uc4" TagName="footer" Src="~/UserControl/Footer.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="render/stylesheetedumate.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
updated
        <div>
            <uc1:Top ID="top1" runat="server" />
        </div>
        <div style="height: 31px;">
            <uc2:MiddleTop ID="MiddleTop" runat="server" />
        </div>
         <p class="middle-line">
        </p>
        <div class="left-sectn">
                <% 
     for (int i = 0; i < TotalCount; i++)
     {

          string Newsid = ds.Tables[0].Rows[i]["newsID"].ToString();
         string linkuniname = ds.Tables[0].Rows[i]["newsTitle"].ToString();
         string linkemail = ds.Tables[0].Rows[i]["title"].ToString();
          string linkimage = ds.Tables[0].Rows[i]["Image"].ToString();
        %>
<article class="artcless-middle">
 
<p class="artcless-img-02"><img src="~/<%=linkimage%>" id="img<%=i%>image" class="img-size" /> </p>


<div class="artcless-container">
<h5 class="hdng-03"> <%=linkuniname%></h5>
<p class="paras-001"><span class="paras-001"><%=linkemail%> </span> <%--<%=linkaddress%>--%></br>
</p>
<p class="paras-002"><span class="hdng-addr"> </span><%--<%=linkemail%>--%></p>

  <div style="padding-bottom: 2px; padding-right: 5px" align="center">
        <a class="readmore" target ="_blank" href="New-Final.aspx?Id=<%=Newsid%>">ViewDetails...</a></div>

</article>



<%} %>
</div>


          <div class="container-rght-sectn">
<uc3:Right ID="Right1" runat="server" />
</div>
        </div>
   
     <div id="pageNavPosition" style="padding-top: 20px" align="center">
    </div>
    <footer>
<uc4:footer ID="footer1" runat="server" />

</footer>
    </form>
</body>
</html>
