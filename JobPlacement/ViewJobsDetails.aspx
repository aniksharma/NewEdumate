<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewJobsDetails.aspx.cs" Inherits="JobPlacement_ViewJobsDetails" %>

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
<div>
    <div>
<uc1:header ID="header1" runat="server" />
        </div>
<section class="middle-seacrh-sectn">
<%--<section class="news-sectn">
</section>--%>


<asp:Label ID="lblMsg"  runat="server" Text="" ></asp:Label>


</section>
<p class="middle-line-02"></p>
<div class="main-container">
<div class="left-sectn">
       
                <% 
    
                    string linkuniname = ds.Tables[0].Rows[0]["Organisation_Name"].ToString();
                    string linkemail = ds.Tables[0].Rows[0]["Job_Description"].ToString();
                    string linkaddress = ds.Tables[0].Rows[0]["Required_Qualification"].ToString();
                    string posted = ds.Tables[0].Rows[0]["Recruiter_Name"].ToString();
         string linkimage = ds.Tables[0].Rows[0]["collegeImage"].ToString();

        %>
<article class="artcless-middle">
 
<p class="artcless-img-02"><img src="~/../<%=linkimage%>" id="imgimage" class="img-size" /> </p>
<div class="artcless-container">
<h1 class="hdng-03">Organisation Name: <%=linkuniname%></h1>
<p class="paras-001"><span style="color:#5086BB">Required_Qualification :</span> <%=linkaddress%></p>
<p class="paras-001"><span style="color:#5086BB">PostedBy:</span> <%=posted%></p>
<p class="paras-001"><span style="color:#5086BB">Job Description:&nbsp;</span><span class="para-jobs"><%=linkemail%> </span> <%--<%=linkaddress%>--%></br></p>
<p class="paras-002"><span class="hdng-addr"> </span><%--<%=linkemail%>--%></p>

  <div style="padding-bottom: 2px; padding-right: 5px" align="center">
        
</article>





</div>
    </div>
 <div class="container-rght-sectn-02">
                <uc3:Right ID="Right1" runat="server" />
            </div>



<footer>
<uc2:footer ID="footer1" runat="server" />

</footer>
</div>
</form>
</body>
</html>
