<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewCareerDetails.aspx.cs"
    Inherits="ViewCareerDetails" %>

<%@ Register TagPrefix="uc1" TagName="Top" Src="~/UserControl/MainControl.ascx" %>
<%@ Register TagPrefix="uc3" TagName="Right" Src="~/UserControl/RightControl.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Edumate</title>
    <link href="render/stylesheetedumate.css" rel="stylesheet" type="text/css" />
  <script src="js/jquery-1.6.3.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $('a.login-window').click(function () {

                // Getting the variable's value from a link 
                var loginBox = $(this).attr('href');

                //Fade in the Popup and add close button
                $(loginBox).fadeIn(300);

                //Set the center alignment padding + border
                var popMargTop = ($(loginBox).height() + 24) / 2;
                var popMargLeft = ($(loginBox).width() + 24) / 2;

                $(loginBox).css({
                    'margin-top': -popMargTop,
                    'margin-left': -popMargLeft
                });

                // Add the mask to body
                $('body').append('<div id="mask"></div>');
                $('#mask').fadeIn(300);

                return false;
            });

            // When clicking on the button close or the mask layer the popup closed
            $('a.close, #mask').live('click', function () {
                $('#mask , .login-popup').fadeOut(300, function () {
                    $('#mask').remove();
                });
                return false;
            });
        });
    </script>
    <script type="text/javascript">
        $(document).ready(function () {
            $('a.login-window1').click(function () {

                // Getting the variable's value from a link 
                var loginBox = $(this).attr('href');

                //Fade in the Popup and add close button
                $(loginBox).fadeIn(300);

                //Set the center alignment padding + border
                var popMargTop = ($(loginBox).height() + 24) / 2;
                var popMargLeft = ($(loginBox).width() + 24) / 2;

                $(loginBox).css({
                    'margin-top': -popMargTop,
                    'margin-left': -popMargLeft
                });

                // Add the mask to body
                $('body').append('<div id="mask"></div>');
                $('#mask').fadeIn(300);

                return false;
            });

            // When clicking on the button close or the mask layer the popup closed
            $('a.close, #mask').live('click', function () {
                $('#mask , .login-popup').fadeOut(300, function () {
                    $('#mask').remove();
                });
                return false;
            });
        });
    </script>
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="header-inner-fxd">
            <uc1:Top ID="top1" runat="server" />
        </div>
        <p class="middle-line-03">
        </p>
        <div class="main-container">
            <div class="middle-sectn-04">
                <% 
                    string Newsid = ds1.Tables[0].Rows[0]["newsTypeID"].ToString();
                    string link = ds1.Tables[0].Rows[0]["NewsType"].ToString();
                %>
                <article class="artcless-middle middle-sectn-add">
<h5 class="hdng-03"><%=link%></h5>                
<div class="paras-001">
<%
                            string Title = ds1.Tables[0].Rows[0]["newsTypeID"].ToString();
                            string unID = ds1.Tables[0].Rows[0]["newsTitle"].ToString();
                            string ViewDetails = ds1.Tables[0].Rows[0]["newsDescription"].ToString();
                    
                    
                    
                        %>
                        <ul>
                            <%
                                if (Newsid == Title)
                                {   
         
                   
                            %>
                            <li>
                                <%=unID%></li>

                                 <li>
                                <%=ViewDetails%></li>
                            <%} %>
                        </ul>
                        <%%>
                        </article>
                <%    %>
        
            </div>
            <section class="middle-sectn-01">
<h5 class="hdng-03"><asp:Literal ID="litbody" runat="server"></asp:Literal></h5>
<p class="paras-001">
<asp:Literal ID="litName" runat="server"></asp:Literal><br />
<asp:Literal ID="litPresentLocation" runat="server"></asp:Literal><br />
<asp:Literal ID="litPreLocation" runat="server"></asp:Literal>
</p>
            <h6 class="commnt-hdng-cmnt-mn">Comments</h6>
       <section class="commnt-sectn">
<aside class="commnt-sectn-innr">
<article class="commnt-contnt">

  <% 
      if(TotalCount2>0)
      {
      for (int i = 0; i < TotalCount2; i++)
      {

          string Collegeid = dss.Tables[0].Rows[i]["KName"].ToString();
          string cntid = dss.Tables[0].Rows[i]["SComment"].ToString();
          string link1 = dss.Tables[0].Rows[i]["Logo"].ToString();
          %>
<div class="cmnts">
<p class="artcle ss-img-02"><a href ="#">
<img src="~/../<%=link1%>" id="img1"  class="commnt-img" /></a>
</p>


<div class="artcless-container-rght">
<h5 class="hdng-03"><a href ="#"> <%=Collegeid%></a></h5>
<p class="paras-001"><span class="hdng-addr"></span> <%=cntid%></p>
</div>
</div>


<%}}%>

<article class="commnt-contnt">
<asp:Label ID="lblMsg"  runat="server" Text="" ></asp:Label>
<p class="paras-003"><textarea name="comment" class="txt-ara-cmnt" cols="" rows=""></textarea></p>
<div class="btn-sign">
<a href="#login-box" class="login-window">Add Comment</a>
</div>
<div style="display: none; margin-top: -113px; margin-left: -130px;" id="login-box" class="login-popup">
<a href="#" class="close"><img src="../images/closebox.png" class="btn_close" title="Close Window" alt="Close"></a>
<form method="post" class="signin" action="#">
<fieldset class="textbox">
            	<label class="username">
                <span class="lbl-usr">Username or email</span>
                <input id="username" name="username" autocomplete="on" placeholder="Username" type="text" style="font-size:12px;width:154px;margin-bottom:5px;">
                </label>
                
                <label class="password">
                <span class="lbl-usr">Password</span>
                <input id="password" name="password" value="" placeholder="Password" type="password" style="font-size:12px;width:154px;">
                </label>
                
                <p><asp:Button ID ="btn1" runat ="server" Text ="Submit" class="submit button" onclick="btn1_Click" />

              <div class="btn-sign1"> <a href="../Add Institute/EduType.aspx" class="login-window11">Sign In</a></div>
                </p>
                <p><a class="forgot" href="#">Forgot your password?</a></p>
                

                </fieldset>
</form>
</div>
<div style="display: none; margin-top: -113px; margin-left: -130px;" id="login-box1" class="login-popup">
        <a href="#" class="close"><img src="../images/closebox.png" class="btn_close" title="Close Window" alt="Close"></a>
          <form method="post" class="signin" action="#">
                <fieldset class="textbox">
            	<label class="username">
                <span class="lbl-usr">Username or email</span>
                <input id="Text1" name="username" autocomplete="on" placeholder="Username" type="text" style="font-size:12px;width:154px;margin-bottom:5px;">
                </label>
                
                <label class="password">
                <span class="lbl-usr">Password</span>
                <input id="password1" name="password" value="" placeholder="Password" type="password" style="font-size:12px;width:154px;">
                </label>
                
                <p><asp:Button ID ="Button1" runat ="server" Text ="Register" class="submit button" />
                </p>
                <p><a class="forgot" href="#">Forgot your password?</a></p>
                 </fieldset>
          </form>
		</div>    
</aside>
</article>
</section>
        </div>
    
        
    
    <div class="container-rght-sectn-02">
            <uc3:Right ID="Right1" runat="server" />
        </div>
            </div>
    </form>
</body>
</html>
