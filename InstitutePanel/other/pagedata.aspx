<%@ Page Title="" Language="C#" MasterPageFile="Other.master" AutoEventWireup="true"
    CodeFile="pageData.aspx.cs" Inherits="web_website_pageData" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit.HTMLEditor"
    TagPrefix="cc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="controlpanelcat">
        <div class="controlpanelcathead">
            &nbsp;<span class="head1"><asp:Label ID="lblName2" runat="server" Text=""
               ForeColor="White"></asp:Label>
                                    </span>
                                    </div>
        <div style="clear: both;">
        </div>
        <div style="clear: both;">
        <br />
            <table cellpadding="0" cellspacing="0" width="100%">
                <tr>
                    <td style="width: 10%">
                    </td>
                    <td style="width: 80%">
                        <table cellpadding="0" cellspacing="0" class="insI">
                            <tr>
                                <td style="width: 96%">
                                    <span class="head1">
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    </span>
                                    <asp:Button ID="btnInsert" Text="Add New Paragraph" runat="server" />
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Layout :<asp:DropDownList ID="ddpLayout" runat="server"
                                        AutoPostBack="True" OnSelectedIndexChanged="ddpLayout_SelectedIndexChanged" Height="30px"
                                        Width="200px">
                                        <asp:ListItem Text="Blank Text Only" Value="1"> </asp:ListItem>
                                        <asp:ListItem Text="Left Image and Text" Value="2"> </asp:ListItem>
                                        <asp:ListItem Text="Right Image and Text" Value="3"> </asp:ListItem>
                                        <asp:ListItem Text="Left Right  Image and Text" Value="4" Selected="True"> </asp:ListItem>
                                        <asp:ListItem Text="Top Image and Text" Value="5"> </asp:ListItem>
                                        <asp:ListItem Text="Bottom Image and Text" Value="6"> </asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td style="width: 2%">
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 96%">
                                    <asp:Label ID="lblMsageNew" runat="server" ForeColor="#FF3300"></asp:Label>
                                </td>
                                <td style="width: 2%">
                                    &nbsp;
                                </td>
                            </tr>
                        </table>
                        <div id="datatop" runat="server" visible="false">
                            <asp:LinkButton ID="lnkbtn" runat="server" OnClick="lnkbtn_Click">Close Layout</asp:LinkButton>
                            <div id="data" runat="server">
                            </div>
                        </div>
                        <table cellpadding="0" cellspacing="0" width="100%">
                            <tr>
                                <td>
                                    <div class="grd">
                                        <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
                                            <HeaderTemplate>
                                                <table cellpadding="0" cellspacing="0" border="0" width="100%">
                                                    <thead>
                                                        <tr>
                                                            <td>
                                                                Image
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
                                                    <td valign="top">
                                                        <img src='<%#Eval("imagePath")%>' runat="server" id="img2" height="70" width="70"
                                                            alt='<%#Eval("imageTitle")%>' />
                                                    </td>
                                                    <td valign="top">
                                                        <%#Eval("imageTitle")%>
                                                    </td>
                                                    <td valign="top">
                                                        <%#Eval("imageDescription")%>
                                                    </td>
                                                    <td valign="top">
                                                        <asp:LinkButton ID="LinkButton3" runat="server" Text='Update' CommandArgument='<%#Eval("imageId")%>'
                                                            CommandName="edit" CausesValidation="false">
                                                        </asp:LinkButton>
                                                    </td>
                                                    <td valign="top">
                                                        <asp:LinkButton ID="lnkDelete" runat="server" Text='Delete' CommandArgument='<%#Eval("imageId")%>'
                                                            CommandName="Delete" CausesValidation="false">
                                                        </asp:LinkButton>
                                                    </td>
                                                </tr>
                                            </ItemTemplate>
                                            <AlternatingItemTemplate>
                                                <tr>
                                                    <td valign="top">
                                                        <img src='<%#Eval("imagePath")%>' runat="server" id="img2" height="70" width="70"
                                                            alt='<%#Eval("imageTitle")%>' />
                                                    </td>
                                                    <td valign="top">
                                                        <%#Eval("imageTitle")%>
                                                    </td>
                                                    <td>
                                                        <%#Eval("imageDescription")%>
                                                    </td>
                                                    <td valign="top">
                                                        <asp:LinkButton ID="LinkButton3" runat="server" Text='Update' CommandArgument='<%#Eval("imageId")%>'
                                                            CommandName="edit" CausesValidation="false">
                                                        </asp:LinkButton>
                                                    </td>
                                                    <td valign="top">
                                                        <asp:LinkButton ID="lnkDelete" runat="server" Text='Delete' CommandArgument='<%#Eval("imageId")%>'
                                                            CommandName="Delete" CausesValidation="false">
                                                        </asp:LinkButton>
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
                        <div style="padding-top: 300px;">
                            <asp:Button ID="btnhover" Text="Click Me" runat="server" Height="1" Width="1" Enabled="false"
                                CssClass="modalBackground" />
                            <asp:Button ID="Button1" Text="Click Me New Here" runat="server" Height="1" Width="1"
                                Enabled="false" CssClass="modalBackground" />
                            <cc1:ModalPopupExtender ID="ModalPopupInsert" runat="server" BackgroundCssClass="modalBackground"
                                CancelControlID="lnkClose" PopupControlID="panelInsert" TargetControlID="btnInsert"
                                X="200" Y="100">
                            </cc1:ModalPopupExtender>
                            <cc1:ModalPopupExtender ID="ModalMenuExtender1" runat="server" BackgroundCssClass="modalBackground"
                                CancelControlID="btn_canceltrans" PopupControlID="PopupMenu" TargetControlID="btnhover"
                                X="250" Y="100">
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
                                            &nbsp;
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
                                    <tr class="H1Left">
                                        <td align="left" class="H2Center" style="font-family: verdana; font-size: 12px; padding-left: 12px;">
                                            &nbsp;
                                        </td>
                                        <td>
                                            &nbsp;
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                            <asp:Panel ID="panelInsert" runat="server" Height="550" Width="650" CssClass="panel"
                             BackColor="#eeeeee">
                                <table cellpadding="0" cellspacing="0" class="insI">
                                    <tr>
                                        <td style="width: 96%">
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
                                                            Display="Dynamic" ErrorMessage="Heading !" SetFocusOnError="True"></asp:RequiredFieldValidator>
                                                    </td>
                                                    <td>
                                                        &nbsp;
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
                                                    </td>
                                                    <td valign="top">
                                                        &nbsp;
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td valign="top">
                                                        Paragraphs :
                                                    </td>
                                                    <td>
                                                        <cc1:Editor ID="txtDescription" runat="server" Height="300px" Width="400px" TextMode="MultiLine" />
                                                    </td>
                                                    <td>
                                                        &nbsp;
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
                                                        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Reset" />
                                                        &nbsp;&nbsp;&nbsp;&nbsp;
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
                            </asp:Panel>
                        </div>
                    </td>
                    <td style="width: 10%">
                    </td>
                </tr>
            </table>
            <br />
        </div>
        <div style="clear: both;">
        </div>
    </div>
</asp:Content>
