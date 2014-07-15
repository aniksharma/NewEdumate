<%@ Page Title="" Language="C#" MasterPageFile="~/InstitutePanel/MasterPage2.master" AutoEventWireup="true" CodeFile="changepaswd.aspx.cs" Inherits="InstitutePanel_Default4" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:650px; border:1px solid #ccc;" class="insI">
                <tr>
                    <td colspan="3" class="H3Center">
<label for="ac-1" class="tab-hdng"> Change Password</label>
                       
                    </td>
                </tr>
                <tr>
                    <td style="width: 10%">
                    </td>
                    <td style="width: 80%">
                        <table >
                            <tr>
                                <td class="H3Center" rowspan="13" width="1%">
                                    &nbsp;
                                </td>
                                <td colspan="2" class="H3Center">
                                    <asp:UpdateProgress ID="progressPinChecker" runat="server">
                                        <ProgressTemplate>
                                            &nbsp;<img alt="Loading..." src="../img/control Image/loading.gif" style="width: 22px;
                                                height: 22px" />
                                        </ProgressTemplate>
                                    </asp:UpdateProgress>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2" class="HShort" style="height: 9px">
                            </tr>
                            <tr>
                                <td class="H1Left" width="30%">
                                    Old Password :
                                </td>
                                <td class="H1Left">
                                    <asp:TextBox ID="txtoldPassword" runat="server" CssClass="TextBoxSmall" Width="200px"  MaxLength="30"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtoldPassword"
                                        Display="None" ErrorMessage="Old Password  !" SetFocusOnError="True" ValidationGroup="new"></asp:RequiredFieldValidator>
                                    <cc1:validatorcalloutextender id="RequiredFieldValidator1_ValidatorCalloutExtender"
                                        runat="server" enabled="True" targetcontrolid="RequiredFieldValidator1" highlightcssclass="validation">
                                    </cc1:validatorcalloutextender>
                                </td>
                            </tr>
                            <tr>
                                <td class="HShort" colspan="2">
                                    &nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td class="H1Left">
                                    New Passoword :
                                </td>
                                <td class="H1Left">
                                    <asp:TextBox ID="txtNewPassword" runat="server" CssClass="TextBoxSmall" Width="200px" MaxLength="30"
                                        TextMode="Password"></asp:TextBox>
                                    <cc1:passwordstrength id="txtPassword_PasswordStrength" runat="server" enabled="True"
                                        helphandleposition="LeftSide" helpstatuslabelid="lblPasswordmsg" minimumlowercasecharacters="1"
                                        minimumnumericcharacters="1" minimumsymbolcharacters="1" minimumuppercasecharacters="1"
                                        preferredpasswordlength="12" targetcontrolid="txtNewPassword">
                                        </cc1:passwordstrength>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="New Password !"
                                        ControlToValidate="txtNewPassword" Display="None" SetFocusOnError="True" ValidationGroup="new"></asp:RequiredFieldValidator>
                                    <cc1:validatorcalloutextender id="RequiredFieldValidator2_ValidatorCalloutExtender"
                                        runat="server" enabled="True" highlightcssclass="validation" targetcontrolid="RequiredFieldValidator2">
                                    </cc1:validatorcalloutextender>
                                    <br />
                                    <asp:Label ID="lblPasswordmsg" runat="server" CssClass="labelMsgRed"></asp:Label>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtNewPassword"
                                        Display="None" ErrorMessage="Please Try A Strong Password ! (Min is 4 max is 10 And latest one numaric one letter  Require )"
                                        SetFocusOnError="True" 
                                        ValidationExpression="^(?=.*\d)(?=.*([a-z]|[A-Z]))([\x20-\x7E]){4,10}$" ValidationGroup="new"></asp:RegularExpressionValidator>
                                    <cc1:validatorcalloutextender id="RegularExpressionValidator2_ValidatorCalloutExtender"
                                        runat="server" enabled="True" highlightcssclass="validation" targetcontrolid="RegularExpressionValidator2">
                                    </cc1:validatorcalloutextender>
                                </td>
                            </tr>
                            <tr>
                                <td class="H1Left">
                                    Confirm Password :
                                </td>
                                <td class="H1Left">
                                    <asp:TextBox ID="txtConfirmPassowrd" runat="server" CssClass="TextBoxSmall" Width="200px" MaxLength="30"
                                        TextMode="Password"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtConfirmPassowrd"
                                        Display="None" ErrorMessage="Confirm Password !" SetFocusOnError="True" ValidationGroup="new"></asp:RequiredFieldValidator>
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
                                        SetFocusOnError="True" ValidationGroup="new"></asp:CompareValidator>
                                    <cc1:validatorcalloutextender id="CompareValidator1_ValidatorCalloutExtender" runat="server"
                                        enabled="True" highlightcssclass="validation" targetcontrolid="CompareValidator1">
                                    </cc1:validatorcalloutextender>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2" class="HShort">
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
                                    <asp:Button ID="btnChangePassword" runat="server" CssClass="ButtonMid" Text="Update"
                                        OnClick="btnChangePassword_Click" Width="124px" ValidationGroup="new" />
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
                    <td style="width: 10%">
                    </td>
                </tr>
                <tr>
                    <td colspan="3" height="30px">
                        &nbsp;</td>
                </tr>
            </table>
</asp:Content>

  