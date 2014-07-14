<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage/AdminNewsMaster.master"
    AutoEventWireup="true" CodeFile="NewsFor.aspx.cs" Inherits="Admin_web_NewsFor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table style="width: 100%">
        <tr>
            <td width="10%">
                &nbsp;
            </td>
            <td width="90%" class="H1Center">
                <table style="width: 80%">
                    <tr>
                        <td>
                            <table style="width: 100%" class="BoxFour">
                                <tr>
                                    <td valign="top" align="center">
                                        <table style="width: 100%">
                                            <tr>
                                                <td class="Add-Country" colspan="2">
                                                    News For
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="H2Center" colspan="2">
                                                    <asp:Label ID="lblMsg" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                           
                                            <tr>
                                                <td style="width: 250px;">
                                                    News Type:
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="txtUserName" runat="server" CssClass="TextBoxSmall"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserName"
                                                        Display="None" ErrorMessage="Insert Course Category !" SetFocusOnError="True"
                                                        ValidationGroup="majorUnit"></asp:RequiredFieldValidator>
                                                   
                                                </td>
                                            </tr>
                                           
                                            <tr>
                                                <td style="width: 40px">
                                                    SubTitle
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="txtSubtitle" CssClass="TextBoxSmall" runat="server"></asp:TextBox>
                                                </td>
                                            </tr>
                                        
                                            <tr>
                                                <td style="width: 40px">
                                                    Description
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="txtdescription" runat="server" CssClass="TextBoxSmall" TextMode="MultiLine"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="width: 40px">
                                                    Source Reference
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="txtSourceReference" runat="server" CssClass="TextBoxSmall" TextMode="MultiLine"></asp:TextBox>
                                                </td>
                                            </tr>
                                         
                                            <tr>
                                                <td style="width: 40px">
                                                    Image
                                                </td>
                                                <td>
                                                    <asp:FileUpload ID="FileUpload1" runat="server" />
                                                </td>
                                            </tr>
                                         
                                            <tr>
                                                <td class="H2Left" style="width: 40px">
                                                    Status:
                                                </td>
                                                <td class="H1Left">
                                                    <asp:RadioButtonList ID="rblStatus" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
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
                                                    &nbsp;
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="H1Center" colspan="2">
                                                    &nbsp;
                                                </td>
                                            </tr>
                                          
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
                                            <HeaderTemplate>
                                                <table class="MasterTableCenter">
                                                    <tr>
                                                        <th>
                                                            Name
                                                        </th>
                                                        <th>
                                                            Title
                                                        </th>
                                                       
                                                        <th>
                                                            Edit
                                                        </th>
                                                    </tr>
                                            </HeaderTemplate>
                                            <FooterTemplate>
                                                </table></FooterTemplate>
                                            <ItemTemplate>
                                                <tr>
                                                    <td>
                                                        <%#Eval("name") %>
                                                    </td>
                                                    <td>
                                                        <%#Eval("title") %>
                                                    </td>
                                                  
                                                    <td>
                                                        <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("id") %>'
                                                            CommandName='Edit'>Edit</asp:LinkButton>
                                                    </td>
                                                </tr>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
</asp:Content>
