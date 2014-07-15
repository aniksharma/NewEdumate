<%@ Page Language="C#" AutoEventWireup="true" CodeFile="News.aspx.cs" Inherits="News" %>

<%@ Register TagPrefix="uc1" TagName="Top" Src="~/UserControl/MainControl.ascx" %>
<%@ Register TagPrefix="uc3" TagName="Right" Src="~/UserControl/RightControl.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="render/stylesheetedumate.css" rel="stylesheet" type="text/css" />
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
        {
            text-decoration: none;
            color: #00c6ff;
        }
        
        h1
        {
            font: 4em normal Arial, Helvetica, sans-serif;
            padding: 20px;
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
            box-shadow: none;
            color: #FFFFFF;
            float: left;
            background: -moz-linear-gradient(center top, #00c6ff, #018eb6);
            background: -webkit-gradient(linear, left top, left bottom, from(#00c6ff), to(#018eb6));
            background: -o-linear-gradient(top, #00c6ff, #018eb6);
            filter: progid:DXImageTransform.Microsoft.gradient(startColorStr='#00c6ff', EndColorStr='#018eb6');
            margin: 0 auto;
            padding: 18px 6px;
            text-align: center;
            width: 90px;
        }
        
        
        .btn-sign1
        {
            border-radius: 5px;
            box-shadow: none;
            color: #FFFFFF;
            float: left;
            background: -moz-linear-gradient(center top, #00c6ff, #018eb6);
            background: -webkit-gradient(linear, left top, left bottom, from(#00c6ff), to(#018eb6));
            background: -o-linear-gradient(top, #00c6ff, #018eb6);
            filter: progid:DXImageTransform.Microsoft.gradient(startColorStr='#00c6ff', EndColorStr='#018eb6');
            margin: 0 auto;
            padding: 3px 6px;
            text-align: center;
            width: 50px;
        }
        
        .btn-sign a
        {
            color: #fff;
            text-shadow: 0 1px 2px #161616;
        }
        
        #mask
        {
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
            margin-top: 10px;
            font: 12px;
            width: 214px;
        }
        
        .lbl-usr
        {
            width: 140px;
            float: left;
            margin-bottom: 5px;
        }
        
        .button:hover
        {
            background: #ddd;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="header-inner-fxd">
            <uc1:Top ID="top1" runat="server" />
        </div>
<p class="middle-line-03"></p>
</div>
<table style="float: left;">
<tr>
<td id="news" runat="server">
<div class="left-sectn middle-sectn-add">
<%for (int i = 0; i < TotalCount; i++)
{string Newsid = ds.Tables[0].Rows[i]["newsID"].ToString();
string linkuniname = ds.Tables[0].Rows[i]["newsTitle"].ToString();
string linkemail = ds.Tables[0].Rows[i]["SubTitle"].ToString();
string linkimage = ds.Tables[0].Rows[i]["fullpath"].ToString();
string News = ds.Tables[0].Rows[i]["newsID"].ToString();
string TextTitle = ds.Tables[0].Rows[i]["accutalpath"].ToString();
string NewsTitle = ds.Tables[0].Rows[i]["newsTitle"].ToString();
       %>
<article class="artcless-middle">
<p class="artcless-img-02"><img src="~/../<%=linkimage%>" id="img<%=i%>image" class="img-size" /> </p>
<div class="artcless-container">
<h5 class="hdng-03"> <%=linkuniname%></h5>
<p class="paras-001"><span class="paras-001"><%=linkemail%> </span> <%--<%=linkaddress%>--%></br></p>
<p class="paras-002"><span class="hdng-addr"> </span><%--<%=linkemail%>--%></p>
<div style="padding-bottom: 2px; padding-right: 5px" align="center">
  <a class="readmore" target ="_blank" href="<%=TextTitle%>-<%=News%>">ViewDetails...</a></div>
</div>
</article>
                    <%} %>
                </div>
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td id="articles" runat="server">
                <div class="left-sectn">
                    <% 
                        for (int i = 0; i < TotalCount2; i++)
                        {

                            string Newsid = ds2.Tables[0].Rows[i]["newsID"].ToString();
                            string linkuniname = ds2.Tables[0].Rows[i]["newsTitle"].ToString();
                            string linkemail = ds2.Tables[0].Rows[i]["SubTitle"].ToString();
                            string linkimage = ds2.Tables[0].Rows[i]["fullpath"].ToString();

                            string News = ds2.Tables[0].Rows[i]["newsID"].ToString();
                            string TextTitle = ds2.Tables[0].Rows[i]["accutalpath"].ToString();
                            string NewsTitle = ds2.Tables[0].Rows[i]["newsTitle"].ToString();
                    %>
                    <article class="artcless-middle">
 
<p class="artcless-img-02"><img src="~/../<%=linkimage%>" id="img1" class="img-size" /> </p>


<div class="artcless-container">
<h5 class="hdng-03"> <%=linkuniname%></h5>
<p class="paras-001"><span class="paras-001"><%=linkemail%> </span> <%--<%=linkaddress%>--%></br>
</p>
<p class="paras-002"><span class="hdng-addr"> </span><%--<%=linkemail%>--%></p>
 

  <div style="padding-bottom: 2px; padding-right: 5px" align="center">
        <a class="readmore" target ="_blank" href="<%=TextTitle %>-<%=News%>">ViewDetails...</a></div>
      </div>
</article>
                    <%} %>
                </div>
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td id="alerts" runat="server">
                <div class="left-sectn">
                    <% 
                        for (int i = 0; i < TotalCount1; i++)
                        {

                            string Newsid = ds1.Tables[0].Rows[i]["newsID"].ToString();
                            string linkuniname = ds1.Tables[0].Rows[i]["newsTitle"].ToString();
                            string linkemail = ds1.Tables[0].Rows[i]["SubTitle"].ToString();
                            string linkimage = ds1.Tables[0].Rows[i]["fullpath"].ToString();


                            string News = ds1.Tables[0].Rows[i]["newsID"].ToString();
                            string TextTitle = ds1.Tables[0].Rows[i]["accutalpath"].ToString();
                            string NewsTitle = ds1.Tables[0].Rows[i]["newsTitle"].ToString();
                    %>
                    <article class="artcless-middle">
 
<p class="artcless-img-02"><img src="~/../<%=linkimage%>" id="img2" class="img-size" /> </p>


<div class="artcless-container">
<h5 class="hdng-03"> <%=linkuniname%></h5>
<p class="paras-001"><span class="paras-001"><%=linkemail%> </span> <%--<%=linkaddress%>--%></br></p>
<p class="paras-002"><span class="hdng-addr"> </span><%--<%=linkemail%>--%></p>
<div style="padding-bottom: 2px; padding-right: 5px" align="center">
        <a class="readmore" target ="_blank" href="<%=TextTitle %>-<%=News%>">ViewDetails...</a></div>
        </div>
</article>
                    <%} %>
                  
                </div>
            </td>
        </tr>
    </table>
    <div class="container-rght-sectn-02">
        <uc3:Right ID="Right1" runat="server" />
    </div>
    </form>
</body>
</html>
