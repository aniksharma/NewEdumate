<%@ Control Language="C#" AutoEventWireup="true" CodeFile="RightControl.ascx.cs" Inherits="UserControl_RightControl" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>


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
            width: 330px;
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


 <aside class="Registration-Form-sectn">
<h4 class="hdng-form-01" id="loginok" runat="server">User Login <img class="login-icn" src="images/login.png" alt="" title=""></h4>
    

    <div class="containerDiv">
        <div id="headerDiv">
            
 <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
          
        </div>
        <center>
           <div class="left-sectn-blk-02" id="afterlogin" runat="server">
<p style="text-align: left;">
    <a href="InstitutePanel/Default.aspx">
        <span class="user-updates" id="usename" runat="server">User Name</span>
        </a></p>
<div class="img-contnt-sectn">
<div class="img-01">
    
 
   <img id="img111" runat="server" style="width:70px;height:56px" />
</div>
<div class="img-contnt">
<p class="paras-01" style="text-align:right;width: 162px;"><b>Email Id: </b><span id="email" runat="server"></span> <br>
<span id="contactno" runat="server"></span></p>

</div>
<div style="float:right;">
    <a href="../InstitutePanel/changepaswd.aspx">Change Password</a>
        <a href="logout.aspx">Logout</a></div>
</div>


</div>
<div id="loginformDiv" runat="server">

 <div id="loginformimageDiv">
</div>
 <table>
                <tr><td colspan="0">
<asp:TextBox ID="txtLoginName" placeholder="Username" runat="server" Width="238px"  Height="16px" CssClass="txt-flds" ValidationGroup="CL"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
ControlToValidate="txtLoginName" ErrorMessage="*" style="margin-top:8px;position:absolute;right:14px;" ValidationGroup="CL"></asp:RequiredFieldValidator>
</td></tr>
<tr><td colspan="0">
<asp:TextBox ID="txtPassword" placeholder="Password" runat="server"  Height="16px" Width="238px" CssClass="txt-flds" TextMode="Password" ValidationGroup="CL"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="*"
style="margin-top:8px;position:absolute;right:18px;" ValidationGroup="CL"></asp:RequiredFieldValidator>
                </td></tr>
                <tr><td>
                <asp:Button ID="btnsubmit" runat="server" CssClass="sbmt-btn" Text="Submit" OnClick="btnSubmit_Click" ValidationGroup="CL" />
              
                </td>
<tr>

<td style="float:left; width: 117px; padding:3px 0"> 
<a href="<%= ResolveUrl("~/Add%20Institute/EduType.aspx") %>">Create New Account</a>
</td>

<td style="float:right;width: 121px;">
 <a href="frgt.aspx">Forgot your Password</a>
</td>
  

</tr>                                
<tr>
<div style="width:215px;color:Red; font-family:Verdana; font-size:10px;" >
 <asp:Label ID="lblMsg"  runat="server" ForeColor="Red" CssClass="invalid-password" Visible="false"></asp:Label></div>   

 <td style="display:none;"> 
<asp:LinkButton ID="LinkButton6" runat="server" onclick="LinkButton6_Click"></asp:LinkButton>
                    <cc1:ModalPopupExtender ID="LinkButton6_ModalPopupExtender" runat="server" 
                        BackgroundCssClass="backcss" CancelControlID="LinkButton5" 
                        DynamicServicePath="" Enabled="True" PopupControlID="Error" 
                        TargetControlID="LinkButton6">
                    </cc1:ModalPopupExtender>
                    </td>
  </tr> 
               </table>     
            </div>
           
        </center>

</div>
        </aside>
<div style="display: none; margin-top: -113px; margin-left: -130px;" id="login-box" class="login-popup">
<a href="#" class="close"><img src="images/closebox.png" class="btn_close" title="Close Window" alt="Close"></a>
<form method="post" class="signin" action="#">
<fieldset class="textbox" style="width: 323px;">
                             
                              
                                      <tr> <td id="trforget" runat="server" >
                                          <table width="100%">
                                              <tr>
                                                  <td>
                                                  </td>
                                                  <td>
                                                  </td>
                                              </tr>
                                              <tr>
                                                  <td align ="left">
                                                    <span style=" color:Highlight; font-family:Verdana; color :White; font-size:12px;">  Registered EmailID: </span> </td>
                                                  <td>
                                                      <asp:TextBox ID="txtEmailID" runat="server" Width="169px" ValidationGroup="ab1" CssClass="txt-flds"></asp:TextBox>
                                                  </td>
                                              </tr>
                                              <tr>
                                                  <td colspan="2" style="height: 25px; padding-left:30px; font-family:Verdana;">
                                                      <asp:Label ID="lblMsg1" runat="server" ForeColor="Red" style="font-size:11px;float:right;"></asp:Label>
                                                  </td>
                                              </tr>
                                              <tr>
                                                  <td>
                                                  </td>
                                                  <td align="left">
                                                      <asp:Button ID="btOk" runat="server" Text="Submit" CssClass="sbmt-btn" onclick="btOk_Click" 
                                                          ValidationGroup="ab1" />
                                                  </td>
                                              </tr>
                                            </table>
                                            </td></tr>
                                          
                              </fieldset>
                              </form>
                              </div>
<aside class="Registration-Form-sectn">

<div class="left-sectn-blk-02">

<div class="test-workspace">
        <div class="query-form-sectn">
        <a  style ="color :White" href="javascript:void(0);" 
        onClick="$('#workspace').slideToggle('slow');">Query Form</a></div>
        <div style="display: none;" id="workspace">
        
<aside class="advrtng-sectn">
<div class="advrtng">

<table class="box-shadow" style="width:248px;">
                                           
                                            <tr>
                                                <td style="margin-top: 10px;">
                                                </td>
                                            </tr>
                                            <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                                            <ContentTemplate>
                                             <tr>
<td style="padding-left:6px;">
<asp:DropDownList ID="ddlStream" CssClass="drp-dwn-query" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlStream_SelectedIndexChanged">
</asp:DropDownList>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" 
                                                        ControlToValidate="ddlStream" ErrorMessage="*" ForeColor="Red" InitialValue="0" 
                                                        ValidationGroup="abc" CssClass="err-sectn">*</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                             <tr>
                                                <td style="padding-left:6px;">
                                                    <asp:DropDownList ID="ddlSubstream" onchange="ddlChkSelect('substream');" CssClass="drp-dwn-query"
                                                        runat="server">
                                                    </asp:DropDownList>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" 
                                                        ControlToValidate="ddlSubstream" ErrorMessage="*" InitialValue="0" 
                                                        ValidationGroup="abc" CssClass="err-sectn">*</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            </ContentTemplate>
                                            </asp:UpdatePanel>
                                           
                                               <tr>
                                                <td style="padding-left:6px;">
                                                    <asp:DropDownList ID="ddlState" runat="server" CssClass="drp-dwn-query">
                                                    </asp:DropDownList>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" 
                                                        ControlToValidate="ddlState" ErrorMessage="*" ValidationGroup="abc" CssClass="err-sectn">*</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                                <tr>
                                                <td style="padding-left:6px;">
                                                   <asp:DropDownList ID="ddlPlan" CssClass="drp-dwn-query" runat="server">
                                                   <asp:ListItem Text="When do you plan start?" Value="0" ></asp:ListItem>
                                                   <asp:ListItem Text="Immediately" Value="1"></asp:ListItem>
                                                   <asp:ListItem Text="Within 2 Months" Value="2"></asp:ListItem>
                                                   <asp:ListItem Text="Within 3 Months" Value="3"></asp:ListItem>
                                                   <asp:ListItem Text="Not Sure" Value="4"></asp:ListItem>
                                                   </asp:DropDownList>
                                                   <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" 
                                                        ControlToValidate="ddlPlan" ErrorMessage="*" ValidationGroup="abc" CssClass="err-sectn">*</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                               <tr>
                                                <td style="padding-left:6px;">
                                                   <asp:DropDownList ID="ddlMinBudget" runat="server" CssClass="drp-dwn-query-01-02">
                                                   <asp:ListItem Text="Min. Budget" Value="0" ></asp:ListItem>
                                                   <asp:ListItem Text="50000" Value="50000"></asp:ListItem>
                                                    <asp:ListItem Text="100000" Value="100000"></asp:ListItem>
                                                    <asp:ListItem Text="200000" Value="200000"></asp:ListItem>
                                                    <asp:ListItem Text="300000" Value="300000"></asp:ListItem>
                                                    <asp:ListItem Text="400000" Value="400000"></asp:ListItem>
                                                    <asp:ListItem Text="500000" Value="500000"></asp:ListItem>
                                                    <asp:ListItem Text="600000" Value="600000"></asp:ListItem>
                                                   <asp:ListItem Text="700000" Value="700000"></asp:ListItem>
                                                   <asp:ListItem Text="800000" Value="800000"></asp:ListItem>
                                                   <asp:ListItem Text="900000" Value="900000"></asp:ListItem>
                                                   <asp:ListItem Text="1000000" Value="1000000"></asp:ListItem>
                                                    </asp:DropDownList>                                                                                                                                                           
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" 
                                                        ControlToValidate="ddlMinBudget" ErrorMessage="*" InitialValue="0" 
                                                        ValidationGroup="abc" CssClass="err-sectn">*</asp:RequiredFieldValidator>
                                                    &nbsp;<asp:DropDownList ID="ddlMaxBudget" runat="server" CssClass="drp-dwn-query-01-03">
                                                   <asp:ListItem Text="Max.Budget" Value="0" ></asp:ListItem>
                                                   <asp:ListItem Text="50000" Value="50000"></asp:ListItem>
                                                    <asp:ListItem Text="100000" Value="100000"></asp:ListItem>
                                                    <asp:ListItem Text="200000" Value="200000"></asp:ListItem>
                                                    <asp:ListItem Text="300000" Value="300000"></asp:ListItem>
                                                    <asp:ListItem Text="400000" Value="400000"></asp:ListItem>
                                                    <asp:ListItem Text="500000" Value="500000"></asp:ListItem>
                                                    <asp:ListItem Text="600000" Value="600000"></asp:ListItem>
                                                   <asp:ListItem Text="700000" Value="700000"></asp:ListItem>
                                                   <asp:ListItem Text="800000" Value="800000"></asp:ListItem>
                                                   <asp:ListItem Text="900000" Value="900000"></asp:ListItem>
                                                   <asp:ListItem Text="1000000" Value="1000000"></asp:ListItem>
                                                    </asp:DropDownList>                                                                                                    
                                                    </td>
                                            </tr>
                                          <tr>
                                                <td style="padding-left:6px;">
                                                    <asp:TextBox ID="txtCName" runat="server" CssClass="drp-dwn-query-01-01"></asp:TextBox>
                                                    <cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender1" runat="server" Enabled="True"
                                                        TargetControlID="txtCName" WatermarkCssClass="drp-dwn-query-01-01" WatermarkText="Name">
                                                    </cc1:TextBoxWatermarkExtender>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtCName"
                                                        ErrorMessage="*" ValidationGroup="abc" CssClass="err-sectn" ForeColor="Red"></asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                               <tr>
                                                <td style="padding-left:6px;">
                                                    <asp:TextBox ID="txtCEmailID" runat="server" CssClass="drp-dwn-query-01-01"></asp:TextBox>
                                                    <cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender2" runat="server" Enabled="True"
                                                        TargetControlID="txtCEmailID" WatermarkCssClass="drp-dwn-query-01-01" WatermarkText="Email-ID">
                                                    </cc1:TextBoxWatermarkExtender>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtCEmailID"
                                                        ErrorMessage="*" ValidationGroup="abc" ForeColor="Red" CssClass="err-sectn"></asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="padding-left:6px;">
                                                    <asp:TextBox ID="txtCMobileNo" runat="server" CssClass="drp-dwn-query-01-01"></asp:TextBox>
                                                    <cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender3" runat="server" Enabled="True"
                                                        TargetControlID="txtCMobileNo" WatermarkCssClass="drp-dwn-query-01-01" WatermarkText="Mobile No">
                                                    </cc1:TextBoxWatermarkExtender>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtCMobileNo"
                                                        ErrorMessage="*" ValidationGroup="abc" ForeColor="Red" CssClass="err-sectn"></asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                              <tr>
                                                <td style="padding-left:6px;">
                                                    <asp:TextBox ID="txtCQualification" runat="server" CssClass="drp-dwn-query-01-04"></asp:TextBox>
                                                    <cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender4" runat="server" Enabled="True"
                                                        TargetControlID="txtCQualification" WatermarkCssClass="drp-dwn-query-01-04" WatermarkText="Post Your Comment">
                                                    </cc1:TextBoxWatermarkExtender>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="txtCQualification"
                                                        ErrorMessage="*" ValidationGroup="abc" ForeColor="Red" CssClass="err-sectn"></asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="center" >
<asp:ImageButton ID="ImageButton2" runat="server" ValidationGroup="abc" OnClientClick="ddlChkSelect('sSubmit');"
OnClick="ImageButton2_Click" CssClass="sbmts-querys"/>                                                                                    
</td>
                                            </tr>
                                        </table>

</div>
</aside>
 </div>

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