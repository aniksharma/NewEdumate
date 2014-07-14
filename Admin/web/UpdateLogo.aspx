<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage/AdminMaster.master"
    AutoEventWireup="true" CodeFile="UpdateLogo.aspx.cs" Inherits="Admin_web_UpdateLogo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table style="width: 100%">
        <tr>
            <td width="10%">
                &nbsp;
            </td>
            <td width="90%">
                <table style="width: 100%" class="BoxFour">
                    <tr>
                        <td valign="top" width="70%">
                            <table style="width: 100%">
                                <tr>
                                    <td class="Add-Country" colspan="2">
                                        Add Institute Sub Category
                                    </td>
                                </tr>
                                <tr>
                                    <td class="H2Center" colspan="2">
                                        <asp:Label ID="lblMsg" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Type:
                                    </td>
                                    <td>
                                        <asp:RadioButtonList ID="rbtType" RepeatDirection="Horizontal" CssClass="RadioButton"
                                            runat="server" AutoPostBack="True" OnSelectedIndexChanged="rbtType_SelectedIndexChanged"
                                            RepeatLayout="Flow">
                                            <asp:ListItem Text="Institute" Value="2"></asp:ListItem>
                                            <asp:ListItem Text="School" Value="3"></asp:ListItem>
                                            <asp:ListItem Text="College" Value="4"></asp:ListItem>
                                            
                                        </asp:RadioButtonList>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Country:
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="ddlCountry" runat="server" AutoPostBack="True" 
                                                                    CssClass="DropdwonMid" onselectedindexchanged="ddlCountry_SelectedIndexChanged">
                                                                </asp:DropDownList>
                                    
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Name:
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="ddlName" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlName_SelectedIndexChanged"
                                            CssClass="DropdwonMid">
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Image
                                    </td>
                                    <td>
                                        <asp:FileUpload ID="FileUpload1" runat="server" />
                                        <asp:Label ID="lblImage" runat="server" Visible="true"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="H1Center" colspan="2">
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td class="H1Center" colspan="2">
                                        <asp:Label ID="lblId" runat="server" Visible="False"></asp:Label>
                                    </td>
                                </tr>
                            
                                <tr>
                                    <td>
                                        &nbsp;
                                    </td>
                                    <td class="H1Center" colspan="2">
                                        <asp:Button ID="btnSubmit" runat="server" CssClass="bnt-sbmt" OnClick="btnSubmit_Click"
                                            Text="Update" ValidationGroup="majorUnit" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                        <td valign="top" width="30%">
                            <table style="width: 100%; border-left-style: solid; border-left-width: 3px; border-left-color: #333333;">
                                <tr>
                                    <td class="Add-Country">
                                        Current Logo
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width: 252px" class="H2Center">
                                        <img style="border: none; width: 195px; height: 195px;" id="logo" runat="server">
                                       
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
