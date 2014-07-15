<%@ Page Title="" Language="C#" MasterPageFile="Other.master" AutoEventWireup="true"
    CodeFile="download.aspx.cs" Inherits="web_website_downloads" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="insI">
        <table cellpadding="0" cellspacing="0">
            <tr>
                <td style="width: 5%">
                    &nbsp;
                </td>
                <th colspan="2">
                    Upload Files For Download
                </th>
                <th>
                    &nbsp;
                </th>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
                <td>
                    File Name:
                </td>
                <td>
                    <asp:TextBox ID="txtImageName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtImageName"
                        Display="Dynamic" ErrorMessage="File Name !" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
                <td rowspan="4" >
                               
                    
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
                <td>
                    File Path :
                </td>
                <td>
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                    <br />
                    <asp:Label ID="lblImgUrl" runat="server"></asp:Label>
                    &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="FileUpload1"
                        Display="Dynamic" ErrorMessage="File Path !" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
                <td>
                    Is Active
                </td>
                <td>
                    <asp:RadioButtonList ID="rblCategoryStatus" runat="server" RepeatDirection="Horizontal"
                        RepeatLayout="Flow">
                        <asp:ListItem Value="1" Selected="True">Enable</asp:ListItem>
                        <asp:ListItem Value="0">Disable</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    <asp:Button ID="btnInsert" runat="server" OnClick="btsubmit_Click" Text="Submit" />
                    &nbsp;&nbsp;
                    <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel"
                        CausesValidation="False" />
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    <asp:Label ID="lblmsg" runat="server" CssClass="labelMsgRed"></asp:Label>
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
                <td colspan="2">
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
        </table>
    </div>
    <table cellpadding="0" cellspacing="0" width="100%">
        <tr>
            <td style="width: 5%">
            </td>
            <td style="width: 90%">
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
                                        <td>
                                            Data
                                        </td>
                                        <td colspan="2">
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
                                    <%#Eval("id")%>
                                </td>
                                <td>
                                    <%#Eval("name")%>
                                </td>
                                <td>
                                    <%#Eval("path")%>
                                </td>
                                <td>
                                    <asp:LinkButton ID="lnkEdit" runat="server" Text='Change' CommandArgument='<%#Eval("id")%>'
                                        CommandName="Edit" CausesValidation="false"></asp:LinkButton>
                                </td>
                                <td>
                                    <asp:LinkButton ID="lnkDelete" runat="server" Text='Delete' CommandArgument='<%#Eval("id")%>'
                                        CommandName="Delete" CausesValidation="false"></asp:LinkButton>
                                </td>
                            </tr>
                        </ItemTemplate>
                        <AlternatingItemTemplate>
                            <tr>
                                <td>
                                    <%#Eval("id")%>
                                </td>
                                <td>
                                    <%#Eval("name")%>
                                </td>
                                <td>
                                    <%#Eval("path")%>
                                </td>
                                <td>
                                    <asp:LinkButton ID="lnkEdit" runat="server" Text='Change' CommandArgument='<%#Eval("id")%>'
                                        CommandName="Edit" CausesValidation="false"></asp:LinkButton>
                                </td>
                                <td>
                                    <asp:LinkButton ID="lnkDelete" runat="server" Text='Delete' CommandArgument='<%#Eval("id")%>'
                                        CommandName="Delete" CausesValidation="false"></asp:LinkButton>
                                </td>
                            </tr>
                        </AlternatingItemTemplate>
                    </asp:Repeater>
                </div>
            </td>
            <td style="width: 5%">
            </td>
        </tr>
    </table>
    <asp:Button ID="btnhover" Text="Click Me" runat="server" Height="1" Width="1" Enabled="false"
        CssClass="modalBackground" />
    <cc1:ModalPopupExtender ID="ModalMenuExtender1" runat="server" BackgroundCssClass="modalBackground"
        CancelControlID="btn_canceltrans" PopupControlID="PopupMenu" TargetControlID="btnhover"
        X="300" Y="300">
    </cc1:ModalPopupExtender>
    <asp:Panel ID="PopupMenu" runat="server" BackColor="#eeeeee" Width="300" BorderColor="Black"
        BorderWidth="2" Height="100">
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
                    File Upload Message
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td style="height: 16px; text-align: center" align="center">
                    <asp:Label ID="lblInsMsg" runat="server"></asp:Label>
                </td>
                <td style="height: 16px">
                </td>
            </tr>
            <tr class="H1Left">
                <td align="left" style="font-family: verdana; font-size: 12px; padding-left: 12px;"
                    class="H2Center">
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
