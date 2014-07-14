<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage/AdminMaster.master" AutoEventWireup="true" CodeFile="SchoolCategory.aspx.cs" Inherits="Admin_web_SchoolCategory" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width: 100%">
                    <tr>
                        <td width="10%">
                            &nbsp;
                        </td>
                        <td width="90%">
                            <table style="width: 100%">
                                <tr>
                                    <td>
                                        <table style="width: 100%" class="BoxFour">
                                            <tr>
                                                <td valign="top" width="70%">
                                                    <table style="width: 100%">
                                                        <tr>
                                                            <td class="Add-Country" colspan="2">
                                                                Add School Category</td>
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
                                                                Education Type: </td>
                                                            <td>
                                                                <asp:TextBox ID="txtUserName" runat="server" CssClass="TextBoxSmall" 
                                                                    MaxLength="150"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserName"
                                                                    Display="None" ErrorMessage="Insert  Category !" 
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
                                                            <td class="H2Left">
                                                                Status:</td>
                                                            <td class="H1Left">
                                                                <asp:RadioButtonList ID="rblStatus" runat="server" RepeatDirection="Horizontal" 
                                                                    RepeatLayout="Flow">
                                                                    <asp:ListItem Selected="True" Text="Enable" Value="1"></asp:ListItem>
                                                                    <asp:ListItem Text="Disable" Value="0"></asp:ListItem>
                                                                </asp:RadioButtonList>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="H1Center" colspan="2">
                                                                <asp:Label ID="lblId" runat="server" Visible="False"></asp:Label>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="HShort" colspan="2">
                                                                &nbsp;
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                        <td>&nbsp;</td>
                                                            <td class="H1Center" colspan="2">
                                                                <asp:Button ID="btnSubmit" runat="server" CssClass="bnt-sbmt" OnClick="btnSubmit_Click"
                                                                    Text="Submit" ValidationGroup="majorUnit" />
                                                                &nbsp;<asp:Button ID="btnCancel" runat="server" CausesValidation="False" CssClass="bnt-sbmt"
                                                                    OnClick="btnCancel_Click" Text="Cancel" />
                                                                &nbsp;
                                                                <asp:Button ID="btnDelete" runat="server" CssClass="bnt-sbmt" OnClick="btnDelete_Click"
                                                                    Text="Delete" ValidationGroup="majorUnit" Visible="False" />
                                                            &nbsp;</td>
                                                        </tr>
                                                    </table>
                                                </td>
                                                <td valign="top" width="30%">
                                                    <table style="width: 100%; border-left-style: solid; border-left-width: 3px; border-left-color: #333333;">
                                                        <tr>
                                                            <td class="Add-Country">
                                                                School Category&nbsp; List                                                             </td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 218px" class="H2Center">
                                                                <asp:ListBox ID="lstbox" runat="server" AutoPostBack="True" Height="123px"
                                                                     Width="212px" 
                                                                    CssClass="H2Center" onselectedindexchanged="lstbox_SelectedIndexChanged">
                                                                </asp:ListBox>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>
                       
                    </tr>
                </table>

</asp:Content>

