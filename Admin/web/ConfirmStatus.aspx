<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage/AdminInqueryMaster.master" AutoEventWireup="true" CodeFile="ConfirmStatus.aspx.cs" Inherits="Admin_web_ConfirmStatus" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width: 100%">
        <tr>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                <table style="width: 100%">
                    <tr>
                        <td width="10%">
                            &nbsp;
                        </td>
                        <td width="80%">
                            <table style="width: 100%">
                                <tr>
                                    <td>
                                        <table style="width: 100%" class="BoxFour">
                                            <tr>
                                                <td valign="top" width="50%">
                                                    <table style="width: 100%">
                                                        <tr>
                                                            <td class="H2Center" colspan="2">
                                                                Confirm Status</td>
                                                        </tr>
                                                        <tr>
                                                            <td class="H2Center" colspan="2">
                                                                <asp:Label ID="lblMsg" runat="server"></asp:Label>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                &nbsp;</td>
                                                            <td>
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                Email ID:
                                                            </td>
                                                            <td>
                                                                <asp:TextBox ID="txtUserName" runat="server" CssClass="TextBoxSmall" onblur="javascript:Required('ctl00_ContentPlaceHolder1_txtUserName')"
                                                                    MaxLength="150"></asp:TextBox>
                                                                     <span id="ctl00_ContentPlaceHolder1_txtUserNameL" style="width: 50px; float: none;"></span>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserName"
                                                                    Display="None" ErrorMessage="Insert Course Category !" 
                                                                    SetFocusOnError="True" ValidationGroup="majorUnit"></asp:RequiredFieldValidator>
                                                                <cc1:validatorcalloutextender id="RequiredFieldValidator1_ValidatorCalloutExtender"
                                                                    runat="server" enabled="True" highlightcssclass="validation" targetcontrolid="RequiredFieldValidator1">
                                                                </cc1:validatorcalloutextender>
                                                            </td>
                                                        </tr>
                                                       
                                                        <tr>
                                                            <td class="H1Center" colspan="2">
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td class="HShort" colspan="2">
                                                                &nbsp;
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="H1Center" colspan="2">
                                                                <asp:Button ID="btnSubmit" runat="server" CssClass="ButtonSmall" OnClick="btnSubmit_Click" onfocus="javascript:submitNewsFordata();" OnClientClick="ddlChkSelect('State');"
                                                                    Text="Submit" ValidationGroup="majorUnit" />
                                                                &nbsp;&nbsp;
                                                                &nbsp;<div id="State"  style="visibility:hidden; height:24px;width:24px; float:right;margin-right:65px;margin-top:0px;">
                                                                        <img alt="Loading..." src="../Icon/loading.gif" style="width: 22px;height: 22px" /> 
                                                                      </div></td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>
                        <td width="10%">
                            &nbsp;
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
        </tr>
    </table>
</asp:Content>

