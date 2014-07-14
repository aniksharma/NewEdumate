<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ALogin.aspx.cs" Inherits="Admin_ALogin" %>

<%@ Register TagPrefix="uc1" TagName="LoginTop" Src="~/Admin/Control/LoginTop.ascx" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link href="Css/stylesheetedumate.css" rel="stylesheet" type="text/css" />
    <link href="Css/webcontrol.css" rel="stylesheet" type="text/css" />
    <script src="JS/modernizr.custom.29473.js" type="text/javascript"></script>
</head>

<body>
    <form id="loginform" runat="server">
   <center> 
   <uc1:LoginTop ID="Top" runat="server" />

    <div class="containerDiv">
        <div id="headerDiv">
            <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        </div>
        
            <div class="textDiv" style="height:100px;" >

                </div>
            <div id="loginformDiv">
                <div id="loginformimageDiv">
                    <img src="images/user-icon.png" />
                 
                    <img style="padding-top: 20px;" src="images/password-icon.png" />
                </div>
                <table><tr><td colspan="2">
                Login
                </td></tr>
                <tr><td colspan="2">
                <asp:TextBox ID="txtLoginName" runat="server" Width="200px"  Height="25px"></asp:TextBox>
                </td></tr><tr><td colspan="2">
                Password
                </td></tr><tr><td colspan="2">
                <asp:TextBox ID="txtPassword" runat="server"  Height="25px" Width="200px" TextMode="Password"></asp:TextBox>
                </td></tr><tr><td>
                
                <asp:ImageButton ID="btnsubmit" Height="27" Width="75"  ImageUrl="images/login-button.png"
                onclick="btnSubmit_Click"
                runat="server" />
                </td><td><span style="font-size: 12px;
            color: #777; text-decoration: underline;">
                  <asp:LinkButton ID="lnkForgetPassword" style=" color:Highlight; font-family:Verdana; font-size:12px;" runat="server">Forget Password</asp:LinkButton>
                            <cc1:ModalPopupExtender ID="lnkForgetPassword_ModalPopupExtender" 
                                runat="server" BackgroundCssClass="backcss" DynamicServicePath="" 
                                Enabled="True" PopupControlID="Error" TargetControlID="lnkForgetPassword" 
                                CancelControlID="LinkButton5">
                            </cc1:ModalPopupExtender>                                          
                    </span>
                </td></tr><tr><td colspan="2" >                                
                 <div style="height:10px;color:Red; font-family:Verdana; font-size:12px;" >
                  <asp:Label ID="lblMsg"  runat="server" ForeColor="Red"></asp:Label></div>   
                 </td></tr> 
               </table>     
            </div>
            <div class="textDiv">
            
                </div>
               <asp:Panel ID="Error" runat="server">
                          <div style="background: none repeat scroll 0 0 #525252; padding: 10px; z-index: 100000;
                              display: block; width: 400px; left: 278px; top: 456px;">
                              <div style="background: none repeat scroll 0 0 #6391CC; padding: 12px 10px;">
                                  <span style="float: right; margin-top: -9px;">
                                      <asp:LinkButton ID="LinkButton5" runat="server" ForeColor="White" Font-Underline="false">X</asp:LinkButton>
                                  </span>
                              </div>
                              <div style="background: none repeat scroll 0 0 #FFFFFF; padding: 10px;">
                                  <div style="background-color: #ffffff; text-align: left;">
                                      <div>
                                          <table width="100%">
                                              <tr>
                                                  <td>
                                                  </td>
                                                  <td>
                                                  </td>
                                              </tr>
                                              <tr>
                                                  <td>
                                                    <span style=" color:Highlight; font-family:Verdana; font-size:12px;">  Registered EmailID: </span> </td>
                                                  <td>
                                                      <asp:TextBox ID="txtEmailID" runat="server" Width="169px" ValidationGroup="ab1"></asp:TextBox>
                                                  </td>
                                              </tr>
                                              <tr>
                                                  <td colspan="2" style="height: 25px; padding-left:30px; font-family:Verdana;">
                                                      <asp:Label ID="lblMsg1" runat="server" ForeColor="Red"></asp:Label>
                                                  </td>
                                              </tr>
                                              <tr>
                                                  <td>
                                                  </td>
                                                  <td align="left">
                                                      <asp:Button ID="btOk" runat="server" Text="Submit" onclick="btOk_Click" 
                                                          ValidationGroup="ab1" />
                                                  </td>
                                              </tr>
                                          </table>
                                      </div>
                                  </div>
                              </div>
                                    </asp:Panel>
    </div>
 </center>

   </form>
</body>
</html>
