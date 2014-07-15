<%@ Page Language="C#" AutoEventWireup="true" CodeFile="New-Final.aspx.cs" Inherits="New_Final" %>

<%@ Register TagPrefix="uc1" TagName="Top" Src="~/UserControl/MainControl.ascx" %>
<%@ Register TagPrefix="uc3" TagName="Right" Src="~/UserControl/RightControl.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Edumate</title>
    <link href="render/stylesheetedumate.css" rel="stylesheet" type="text/css" />
    <link href="render/styles.css" rel="stylesheet" type="text/css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js"></script>
    <script src="js/jqueryTestimonial/jquery.js" type="text/javascript"></script>
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
    <style type="text/css">
        a
        {text-decoration: none;}
        
        h1
        {
            font: 4em normal Arial, Helvetica, sans-serif;
            margin: 0;
            text-align: center;
        }
        
        h1 small
        {
            font: 0.2em normal Arial, Helvetica, sans-serif;
            text-transform: uppercase;
            letter-spacing: 0.2em;
            line-height: 5em;
            display: block;
        }
        
        h2
        {
            color: #bbb;
            font-size: 3em;
            text-align: center;
            text-shadow: 0 1px 3px #161616;
        }
        
        .container
        {
            width: 960px;
            margin: 0 auto;
            overflow: hidden;
        }
        
        #content
        {
            float: left;
            width: 100%;
        }
        
        .post
        {
            margin: 0 auto;
            padding-bottom: 50px;
            float: left;
            width: 960px;
        }
        
        .btn-sign
        {
            border-radius: 5px;
            color: #FFFFFF;
            float: left;
           background: #ffb43e; /* Old browsers */
background: -moz-linear-gradient(top,  #ffb43e 0%, #eb710d 100%); /* FF3.6+ */
background: -webkit-gradient(linear, left top, left bottom, color-stop(0%,#ffb43e), color-stop(100%,#eb710d)); /* Chrome,Safari4+ */
background: -webkit-linear-gradient(top,  #ffb43e 0%,#eb710d 100%); /* Chrome10+,Safari5.1+ */
background: -o-linear-gradient(top,  #ffb43e 0%,#eb710d 100%); /* Opera 11.10+ */
background: -ms-linear-gradient(top,  #ffb43e 0%,#eb710d 100%); /* IE10+ */
background: linear-gradient(to bottom,  #ffb43e 0%,#eb710d 100%); /* W3C */
filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#ffb43e', endColorstr='#eb710d',GradientType=0 ); /* IE6-9 */
border:1px solid #da6808;margin: 0 auto;padding:8px 6px;text-align: center;width:90px;font-size:14px;text-shadow:0 1px 1px #666;}
        
        .btn-sign1{border-radius: 5px;
           color: #FFFFFF;
            float: right;
            background:-moz-linear-gradient(center top, #00c6ff, #018eb6);
            background: -webkit-gradient(linear, left top, left bottom, from(#00c6ff), to(#018eb6));
            background: -o-linear-gradient(top, #00c6ff, #018eb6);
            filter: progid:DXImageTransform.Microsoft.gradient(startColorStr='#00c6ff', EndColorStr='#018eb6');
            margin: 0 auto;
            padding:6px 6px;
            text-align: center;
            width:124px;}
        
        .btn-sign a{color:#fff!important;}
        
        #mask   {
            display: none;
            background: #000;
            position: fixed;
            left: 0;
            top: 0;
            z-index: 10;
            width: 100%;
            height: 100%;
            opacity: 0.8;
            z-index: 999;
        }
        
        .login-popup
        {
            display: none;
            background: #333;
            padding: 10px;
            border: 2px solid #ddd;
            float: left;
            font-size: 1.2em;
            position: fixed;
            width: 300px;
            top: 50%;
            left: 50%;
            z-index: 99999;
            box-shadow: 0px 0px 20px #999;
            -moz-box-shadow: 0px 0px 20px #999; /* Firefox */
            -webkit-box-shadow: 0px 0px 20px #999; /* Safari, Chrome */
            border-radius: 3px 3px 3px 3px;
            -moz-border-radius: 3px; /* Firefox */
            -webkit-border-radius: 3px; /* Safari, Chrome */
        }
        
        img.btn_close
        {
            float: right;
            margin: -32px -28px 0 0;
            color: #f1f1f1;
        }
        
        fieldset
        {
            border: none;
        }
        
        form.signin .textbox label
        {
            display: block;
            padding-bottom: 7px;
        }
        
        form.signin .textbox span
        {
            display: block;
        }
        
        form.signin p, form.signin span
        {
            color: #999;
            font-size: 11px;
            line-height: 18px;
        }
        
        form.signin .textbox input
        {
            background: #666666;
            border-bottom: 1px solid #333;
            border-left: 1px solid #000;
            border-right: 1px solid #333;
            border-top: 1px solid #000;
            color: #fff;
            border-radius: 3px 3px 3px 3px;
            -moz-border-radius: 3px;
            -webkit-border-radius: 3px;
            font: 13px Arial, Helvetica, sans-serif;
            padding: 6px 6px 4px;
            width: 200px;
        }
        
        form.signin input:-moz-placeholder
        {
            color: #bbb;
            text-shadow: 0 0 2px #000;
        }
        form.signin input::-webkit-input-placeholder
        {
            color: #bbb;
            text-shadow: 0 0 2px #000;
        }
        
        .button
        {
            background: -moz-linear-gradient(center top, #f3f3f3, #dddddd);
            background: -webkit-gradient(linear, left top, left bottom, from(#f3f3f3), to(#dddddd));
            background: -o-linear-gradient(top, #f3f3f3, #dddddd);
            filter: progid:DXImageTransform.Microsoft.gradient(startColorStr='#f3f3f3', EndColorStr='#dddddd');
            border-color: #000;
            border-width: 1px;
            border-radius: 4px 4px 4px 4px;
            -moz-border-radius: 4px;
            -webkit-border-radius: 4px;
            color: #333;
            cursor: pointer;
            display: inline-block;
            padding: 6px 6px 4px;
            font: 12px;
            width: 164px;
        }
        
        .lbl-usr
        {color:#ffffff;
            width: 140px;
            float: left;
            margin-bottom: 5px;
        }
        
        .button:hover{background:#ddd;}
        .forgot{width:300px;float:left;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="header-inner-fxd">
            <uc1:Top ID="top1" runat="server" />
        </div>
        
        <p class="middle-line-03"></p>
        <div class="main-container">
            <div class="middle-sectn-02 middle-sectn-add">
<%         
                    string linkuniname = ds.Tables[0].Rows[0]["newsTitle"].ToString();
                    string linkemail = ds.Tables[0].Rows[0]["newsDescription"].ToString();
                    string linkimage = ds.Tables[0].Rows[0]["Image"].ToString();

                %>
<article class="artcless-middle">
<p class="artcless-img-02"><img src="~/../<%=linkimage%>" id="imgimage" class="img-size" /> </p>
<div class="artcless-container">
<h1 class="hdng-05"> <%=linkuniname%></h1>
<p class="paras-001" style="width:636px"><span class="para-jobs"><%=linkemail%> </span> <%--<%=linkaddress%>--%></p>
<p class="paras-002"><span class="hdng-addr"> </span><%--<%=linkemail%>--%></p>
<div style="padding-bottom: 2px; padding-right: 5px" align="center">
</article>
<div class="main-container">
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
      if (TotalCount2 > 0)
      {
          for (int i = 0; i < TotalCount2; i++)
          {

              string Collegeid = dss.Tables[0].Rows[i]["KName"].ToString();
              string cntid = dss.Tables[0].Rows[i]["SComment"].ToString();
              string link = dss.Tables[0].Rows[i]["Logo"].ToString();
          %>
<div class="cmnts">
<p class="artcle ss-img-02"><a href ="#">
<img src="~/../<%=link%>" id="img1"  class="commnt-img" /></a>
</p>


<div class="artcless-container-rght">
<h5 class="hdng-03"><a href ="#"> <%=Collegeid%></a></h5>
<p class="paras-001"><span class="hdng-addr"></span> <%=cntid%></p>
</div>
</div>


<%}
      } %>

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
                
               <%-- <button class="submit button" type="button">Sign in</button>--%>
                <p><asp:Button ID ="Button1" runat ="server" Text ="Register" class="submit button" />
               <%-- <a href="#login-box" class="submit button">Sign In</a>--%>
                </p>
                <p><a class="forgot" href="#">Forgot your password?</a></p>
                 </fieldset>
          </form>
		</div>    
</aside>
</article>
</section>

<div>
<%--<a href="#" id="button">Click me</a>--%>
</div>



<div id="modal">
	<div id="heading">
		Are you sure you want to do that?
	</div>

	<div id="content">
		<p>Clicking yes will make Comic Sans your new system<br> default font. Seriously, have you thought this through?</p>

		<a href="#" class="button green close"><img src="../images/tick.png">Yes, do it now!</a>

		<a href="#" class="button red close"><img src="../images/cross.png">No, I’m insane!</a>
	</div>
</div>


            </div>
                <%--<asp:HyperLink ID="HyperLink2"  NavigateUrl ="<%=UniWebsite%>" runat ="server"></asp:HyperLink>--%>
            </div>
<div class="container-rght-sectn-02"><uc3:Right ID="Right1" runat="server"/></div>
 </div>
    </div>
    </form>
</body>
</html>
