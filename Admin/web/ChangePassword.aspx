<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage/AdminMaster.master" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="Admin_web_ChangePassword" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<table style="width:100%">
<tr><td style="width:10%"></td>
<td style="width:90%">
<table style="width:100%">
                <tr>
                    <td colspan="3" class="Add-Country">
                        Change Password
                    </td>
                </tr>
                <tr>
                   
                    <td style="width: 100%">
                        <table class="BoxFo urRound" style="width: 100%">
                            <tr>
                                <td class="H3Center" rowspan="13" width="10%">
                                    &nbsp;
                                </td>
                                <td colspan="2" class="H3Center">
                                    <asp:UpdateProgress ID="progressPinChecker" runat="server">
                                        <ProgressTemplate>
                                            &nbsp;<img alt="Loading..." src="../images/loading.gif" style="width: 234px;
                                                height: 79px" />
                                        </ProgressTemplate>
                                    </asp:UpdateProgress>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2" class="HShort" style="height: 9px"></td>
                            </tr>
                            <tr>
                                <td class="H1Left" width="30%">
                                    Old Password :
                                </td>
                                <td class="H1Left">
                                    <asp:TextBox ID="txtoldPassword" runat="server" CssClass="TextBoxSmall" MaxLength="30"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtoldPassword"
                                        Display="None" ErrorMessage="Old Password  !" SetFocusOnError="True"></asp:RequiredFieldValidator>
                                    <cc1:validatorcalloutextender id="RequiredFieldValidator1_ValidatorCalloutExtender"
                                        runat="server" enabled="True" targetcontrolid="RequiredFieldValidator1" highlightcssclass="validation">
                                    </cc1:validatorcalloutextender>
                                </td>
                            </tr>
                         
                            <tr>
                                <td class="H1Left">
                                    New Passoword :
                                </td>
                                <td class="H1Left">
                                    <asp:TextBox ID="txtNewPassword" runat="server" CssClass="TextBoxSmall" MaxLength="30"
                                        TextMode="Password"></asp:TextBox>
                                    <cc1:passwordstrength id="txtPassword_PasswordStrength" runat="server" enabled="True"
                                        helphandleposition="LeftSide" helpstatuslabelid="lblPasswordmsg" minimumlowercasecharacters="1"
                                        minimumnumericcharacters="1" minimumsymbolcharacters="1" minimumuppercasecharacters="1"
                                        preferredpasswordlength="10" targetcontrolid="txtNewPassword">
                                        </cc1:passwordstrength>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="New Password !"
                                        ControlToValidate="txtNewPassword" Display="None" SetFocusOnError="True"></asp:RequiredFieldValidator>
                                    <cc1:validatorcalloutextender id="RequiredFieldValidator2_ValidatorCalloutExtender"
                                        runat="server" enabled="True" highlightcssclass="validation" targetcontrolid="RequiredFieldValidator2">
                                    </cc1:validatorcalloutextender>
                                    <br />
                                    <asp:Label ID="lblPasswordmsg" runat="server" CssClass="labelMsgRed"></asp:Label>
                                  
                                </td>
                            </tr>
                            <tr>
                                <td class="H1Left">
                                    Confirm Password :
                                </td>
                                <td class="H1Left">
                                    <asp:TextBox ID="txtConfirmPassowrd" runat="server" CssClass="TextBoxSmall" MaxLength="30"
                                        TextMode="Password"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtConfirmPassowrd"
                                        Display="None" ErrorMessage="Confirm Password !" SetFocusOnError="True"></asp:RequiredFieldValidator>
                                    <cc1:validatorcalloutextender id="RequiredFieldValidator3_validatorcalloutextender"
                                        runat="server" enabled="True" highlightcssclass="validation" targetcontrolid="RequiredFieldValidator3">
                                    </cc1:validatorcalloutextender>
                                </td>
                            </tr>
                            <tr>
                                <td class="H1Left">
                                    &nbsp;
                                </td>
                                <td class="H1Left">
                                    &nbsp;
                                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtNewPassword"
                                        ControlToValidate="txtConfirmPassowrd" Display="None" ErrorMessage="Can Not Match Confirm Password !"
                                        SetFocusOnError="True"></asp:CompareValidator>
                                    <cc1:validatorcalloutextender id="CompareValidator1_ValidatorCalloutExtender" runat="server"
                                        enabled="True" highlightcssclass="validation" targetcontrolid="CompareValidator1">
                                    </cc1:validatorcalloutextender>
                                </td>
                            </tr>
                            <tr>
                            <td>&nbsp;</td>
                                <td colspan="2" class="HShort">
                                  <asp:Button ID="btnChangePassword" runat="server" CssClass="bnt-sbmt" Text="Update"
                                        OnClick="btnChangePassword_Click" Width="124px" />
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2" class="HShort">
                                    &nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2" class="H1Center">
                                    <asp:Label ID="lblErrorMsg" runat="server" CssClass="labelMsgRed"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2" class="H1Center" style="height: 40px">
                                    &nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2" class="H1Center">
                                &nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2" class="HShort">
                                    &nbsp;
                                </td>
                            </tr>
                        </table>
                    </td>
                  
                </tr>
                <tr>
                    <td colspan="3" height="30px">
                        &nbsp;</td>
                </tr>
            </table></td>
</tr>
</table>

</asp:Content>

