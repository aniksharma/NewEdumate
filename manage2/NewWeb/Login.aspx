<%@ Page Title="" Language="C#" MasterPageFile="~/manage2/NewWeb/home2.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="manage2_NewWeb_Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../../css/head_sty.css" rel="stylesheet" type="text/css" />
    <link href="../../css/webcontrol.css" rel="stylesheet" type="text/css" />        
    <link href="../../newPcss/styles.css" rel="stylesheet" type="text/css" />    
    <title>LogIn</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <div id="loginform" runat="server">
    <div class="containerDiv">
        <div id="headerDiv">            
          
        </div>
        <center>

        <fieldset style="min-height:200px;" >
                                        <legend class="legText" >Login:</legend>    
            <div id="loginformDiv">
         

                <table><tr><td colspan="2">
                Login
                </td></tr>
                <tr><td colspan="2">
                <asp:TextBox ID="txtLoginName" runat="server" Width="200px"  Height="25px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtLoginName" ErrorMessage="*"></asp:RequiredFieldValidator>
                </td></tr><tr><td colspan="2">
                Password
                </td></tr><tr><td colspan="2">
                <asp:TextBox ID="txtPassword" runat="server"  Height="25px" Width="200px" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                            ControlToValidate="txtPassword" ErrorMessage="*"></asp:RequiredFieldValidator>
                </td></tr><tr><td>
                
                <asp:ImageButton ID="btnsubmit" Height="27" Width="75"  ImageUrl="~/InstitutePanel/image/login-button.png"
                onclick="btnSubmit_Click"
                runat="server" />
                </td><td><span style="font-size: 12px;
            color: #777; text-decoration: underline;">
                  <asp:LinkButton ID="lnkForgetPassword" 
                                style=" color:Highlight; font-family:Verdana; font-size:12px;" runat="server" 
                                onclick="lnkForgetPassword_Click" OnClientClick="ddlChkSelect('Submit');" CausesValidation="False">Forget Password</asp:LinkButton>
                    </span>
                    <div id="Submit" style="visibility: hidden;">
                        <img alt="Loading..." src="~/Search/Search_files/loading.gif" style="width: 50px;
                            height: 50px" />
                    </div>
                </td></tr>
                <tr><td > 
                    <asp:LinkButton ID="LinkButton6" runat="server"></asp:LinkButton>
                    </td><td >
                    </td></tr>                    
                <tr><td colspan="2" >                                
                 <div style="height:10px;color:Red; font-family:Verdana; font-size:10px;" >
                  <asp:Label ID="lblMsg"  runat="server" ForeColor="Red"></asp:Label></div>   
                 </td></tr> 
               </table>     
            </div>
</fieldset>

            <div id="tforgetpassword" runat="server" visible="false">
            <fieldset style="min-height:100px;" >
                                        <legend class="legText" >Forget Password:</legend>   
            <table  >
                <tr>
                    <td colspan="2" style="height: 25px; padding-left: 30px; font-family: Verdana;">
                        <asp:Label ID="lblMsg1" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span style="color: Highlight; font-family: Verdana; font-size: 12px;">Registered EmailID:
                        </span>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmailID" runat="server" Width="169px" ValidationGroup="ab1"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td align="left">
                        <asp:Button ID="btOk" runat="server" Text="Submit" OnClientClick="ddlChkSelect('Ok');" OnClick="btOk_Click" ValidationGroup="ab1" />
                  
                  <div id="Ok" style="visibility: hidden;">
                        <img alt="Loading..." src="http://www.edumate.edu.in/Search/Search_files/loading.gif" style="width: 50px;
                            height: 50px" />
                    </div>

                  
                    </td>
                </tr>
            </table>
            </fieldset>
            </div>
            <div class="textDiv">
                </div>
        </center>

</div>
                                                            
   </div>                                            
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">

</asp:Content>

