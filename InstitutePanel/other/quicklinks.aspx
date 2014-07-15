<%@ Page Title="" Language="C#" MasterPageFile="Other.master" AutoEventWireup="true"
    CodeFile="quicklinks.aspx.cs" Inherits="web_website_quicklink" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit.HTMLEditor"
    TagPrefix="cc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table cellpadding="0" cellspacing="0" class="insI">
        <tr>
            <td style="width: 96%">
                <table cellpadding="0" cellspacing="0" class="tins">
                    <tr>
                        <td colspan="2">
                            <span class="head1">Quick Links&nbsp;</span>
                            <asp:Label ID="lblMsg" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            *Link Name :
                        </td>
                        <td>
                            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName"
                                Display="Dynamic" ErrorMessage="Link Name !"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Is Active :
                        </td>
                        <td>
                            <asp:RadioButtonList ID="rblCategoryStatus" runat="server" RepeatDirection="Horizontal"
                                RepeatLayout="Flow">
                                <asp:ListItem Value="1" Selected="True">Enable</asp:ListItem>
                                <asp:ListItem Value="0">Disable</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;
                        </td>
                        <td>
                            <asp:Button ID="btsubmit" runat="server" OnClick="btsubmit_Click" Text="Submit" />
                            &nbsp;&nbsp;<asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <div class="grd">
                                <asp:Label ID="lblName2" runat="server" Text=""></asp:Label>
                                <asp:Repeater ID="datalist" runat="server" OnItemCommand="Repeater1_ItemCommand">
                                    <HeaderTemplate>
                                        <table cellpadding="0" cellspacing="0" border="0" width="100%">
                                            <thead>
                                                <tr>
                                                    <td>
                                                        Id
                                                    </td>
                                                    <td>
                                                        Title
                                                    </td>
                                                    <td colspan="3">
                                                        Action
                                                    </td>
                                                </tr>
                                            </thead>
                                            <tbody>
                                    </HeaderTemplate>
                                    <FooterTemplate>
                                        </tbody> </table>
                                    </FooterTemplate>
                                    <ItemTemplate>
                                        <tr>
                                            <td>
                                                <asp:Label runat="server" ID="lblId"  ToolTip='<%#Eval("id")%>'><%#Eval("caloneyId")%></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label runat="server" ID="lblName" Text='<%#Eval("name")%>'></asp:Label>
                                            </td>
                                            <td>
                                                <asp:LinkButton ID="lnkEdit" runat="server" Text='Change' CommandArgument='<%#Eval("id")%>'
                                                    CommandName="Edit" CausesValidation="false"></asp:LinkButton>
                                            </td>
                                            <td>
                                                <asp:LinkButton ID="lnkDelete" runat="server" Text='Delete' CommandArgument='<%#Eval("id")%>'
                                                    CommandName="Delete" CausesValidation="false"></asp:LinkButton>
                                            </td>
                                            <td>
                                                <asp:LinkButton ID="LinkButton1" runat="server" Text='Set Value' CommandArgument='<%#Eval("id")%>'
                                                    CommandName="setValue" CausesValidation="false"></asp:LinkButton>
                                            </td>
                                        </tr>
                                    </ItemTemplate>
                                    <AlternatingItemTemplate>
                                        <tr>
                                            <td>
                                                <asp:Label runat="server" ID="lblId"  ToolTip='<%#Eval("id")%>'><%#Eval("caloneyId")%></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label runat="server" ID="lblName" Text='<%#Eval("name")%>'></asp:Label>
                                            </td>
                                            <td>
                                                <asp:LinkButton ID="lnkEdit" runat="server" Text='Change' CommandArgument='<%#Eval("id")%>'
                                                    CommandName="Edit" CausesValidation="false"></asp:LinkButton>
                                            </td>
                                            <td>
                                                <asp:LinkButton ID="lnkDelete" runat="server" Text='Delete' CommandArgument='<%#Eval("id")%>'
                                                    CommandName="Delete" CausesValidation="false"></asp:LinkButton>
                                            </td>
                                            <td>
                                                <asp:LinkButton ID="LinkButton1" runat="server" Text='Set Value' CommandArgument='<%#Eval("id")%>'
                                                    CommandName="setValue" CausesValidation="false"></asp:LinkButton>
                                            </td>
                                        </tr>
                                    </AlternatingItemTemplate>
                                </asp:Repeater>
                            </div>
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
                </table>
            </td>
            <td style="width: 2%">
            </td>
        </tr>
    </table>
    <asp:Button ID="btnhover" Text="Click Me" runat="server" Height="1" Width="1" Enabled="false"
        CssClass="modalBackground" />
    <cc1:ModalPopupExtender ID="ModalMenuExtender1" runat="server" BackgroundCssClass="modalBackground"
        CancelControlID="btn_canceltrans" PopupControlID="PopupMenu" TargetControlID="btnhover"
        X="200" Y="200">
    </cc1:ModalPopupExtender>
    <asp:Panel ID="PopupMenu" runat="server" BackColor="#eeeeee" Width="400" BorderColor="Black"
        BorderWidth="2" Height="130">
        <table cellpadding="0" cellspacing="0" style="width: 100%" class="boardbgcoloruser">
            <tr>
                <td style="height: 16px">
                </td>
                <td style="height: 16px">
                    <asp:LinkButton ID="btn_canceltrans" runat="server" Text="Close"></asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td align="center" class="H3Center" style="font-family: Verdana; color: #000000;
                    font-size: 15px">
                    &nbsp;Message
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td style="height: 16px">
                </td>
                <td style="height: 16px">
                </td>
            </tr>
            <tr class="H1Left">
                <td align="left" style="font-family: verdana; font-size: 12px; padding-left: 12px;"
                    class="H2Center">
                    <asp:Label ID="lblInsMsg" runat="server"></asp:Label>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
