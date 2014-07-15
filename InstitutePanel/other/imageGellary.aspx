<%@ Page Title="" Language="C#" MasterPageFile="Other.master" AutoEventWireup="true"
    CodeFile="ImageGellary.aspx.cs" Inherits="web_website_ImageGellary" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit.HTMLEditor"
    TagPrefix="cc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="controlpanelcat">
        <div class="controlpanelcathead">
            &nbsp;<asp:Label ID="lblName2" runat="server" Text="" ForeColor ="White"></asp:Label>
        </div>
        <div style="clear: both;">
        </div>
        <div style="clear: both;">
            <br />
            <table cellpadding="0" cellspacing="0" class="insI">
                <tr>
                    <td style="width: 96%">
                        <asp:Button ID="btnInsert" Text="Add New Image" runat="server" />
                        <cc1:ModalPopupExtender ID="ModalPopupInsert" runat="server" BackgroundCssClass="modalBackground"
                            CancelControlID="lnkClose" PopupControlID="panelInsert" TargetControlID="btnInsert"
                            X="200" Y="100">
                        </cc1:ModalPopupExtender>
                    </td>
                    <td style="width: 2%">
                    </td>
                </tr>
            </table>
            <table cellpadding="0" cellspacing="0" width="100%">
                <tr>
                    <td style="width: 5%">
                    </td>
                    <td style="width: 90%">
                        <h1 class="head1">
                            &nbsp;</h1>
                        <asp:DataList ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand1"
                            RepeatColumns="2" Width="100%">
                            <ItemTemplate>
                                <table cellpadding="0" cellspacing="0" width="90%" class="co">
                                    <tr>
                                        <td valign="top" colspan="2">
                                            <img src='<%#Eval("imagePath")%>' runat="server" id="img2" height="170" width="250"
                                                alt='<%#Eval("imageTitle")%>' />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td valign="top" style="width: 80%">
                                            <%#Eval("imageTitle")%>
                                        </td>
                                        <td valign="top">
                                            <asp:LinkButton ID="lnkDelete" runat="server" Text='Delete' CommandArgument='<%#Eval("imageId")%>'
                                                CommandName="Delete" CausesValidation="false">
                                            </asp:LinkButton>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td valign="top">
                                            <%#Eval("imageDescription")%>
                                        </td>
                                        <td valign="top">
                                            <asp:LinkButton ID="LinkButton3" runat="server" Text='Update' CommandArgument='<%#Eval("imageId")%>'
                                                CommandName="edit" CausesValidation="false">
                                            </asp:LinkButton>
                                        </td>
                                    </tr>
                                </table>
                                <br />
                            </ItemTemplate>
                        </asp:DataList>
                    </td>
                    <td style="width: 5%">
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
            <asp:Panel ID="panelInsert" runat="server" Height="400" Width="650" CssClass="panel"
              BackColor="#eeeeee">
                <div>
                    <table cellpadding="0" cellspacing="0" class="tins">
                        <tr>
                            <td colspan="2">
                                <span class="head1">
                                    <asp:Label ID="lblPageName" runat="server"></asp:Label>
                                </span>&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Label ID="lblmsg" runat="server" CssClass="labelMsgRed"></asp:Label>
                            </td>
                            <td align="right" style="text-align: right; padding-right: 10px">
                                <asp:LinkButton ID="lnkClose" runat="server">Close</asp:LinkButton>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                *Heading :
                            </td>
                            <td>
                                <asp:TextBox ID="txtImageName" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtImageName"
                                    Display="Dynamic" ErrorMessage="Heading !"></asp:RequiredFieldValidator>
                            </td>
                            <td rowspan="4">
                                <asp:Image ID="imgShow" runat="server" Height="244px" Width="166px" />
                            </td>
                        </tr>
                        <tr>
                            <td valign="top">
                                Image :
                            </td>
                            <td valign="top">
                                <asp:FileUpload ID="FileUpload1" runat="server" />
                                &nbsp;&nbsp;
                                <br />
                                <asp:Label ID="lblImgUrl" runat="server"></asp:Label>
                                &nbsp;&nbsp;
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="FileUpload1"
                                    Display="Dynamic" ErrorMessage="Image !"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td valign="top">
                                Description:
                            </td>
                            <td>
                                <asp:TextBox ID="txtDescription" runat="server" Height="80px" Width="300px" TextMode="MultiLine"
                                    MaxLength="200"></asp:TextBox>
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
                            <td>
                                &nbsp;
                                <asp:Button ID="btsubmit" runat="server" OnClick="btsubmit_Click" Text="Submit" />
                                &nbsp;&nbsp;
                                <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Reset"
                                    CausesValidation="false" />
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
                                &nbsp;
                            </td>
                        </tr>
                    </table>
                </div>
            </asp:Panel>
            <br />
        </div>
        <div style="clear: both;">
        </div>
    </div>
</asp:Content>
