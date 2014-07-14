<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage/AdminNewsMaster.master" AutoEventWireup="true" CodeFile="NewsType.aspx.cs" Inherits="Admin_web_NewsType" %>
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
                                                <td valign="top" width="50%">
                                                    <table style="width: 100%">
                                                        <tr>
                                                            <td class="Add-Country" colspan="2">
                                                                Add News Type</td>
                                                        </tr>
                                                        <tr>
                                                            <td class="H2Center" colspan="2">
                                                                <asp:Label ID="lblMsg" runat="server"></asp:Label>
                                                            </td>
                                                        </tr>

                                                               <tr>
                                                            <td>
                                                                News For:
                                                            </td>
                                                            <td>
                                                                <asp:DropDownList ID="ddlUniversity" runat="server" AutoPostBack="True" 
                                                                    onselectedindexchanged="ddlUniversity_SelectedIndexChanged" 
                                                                    CssClass="DropdwonMid">
                                                                </asp:DropDownList>
                                                           </td></tr>                                              
                                                         <tr>
                                                            <td>
                                                                News Type:
                                                            </td>
                                                            <td>
                                                                <asp:TextBox ID="txtUserName" runat="server" CssClass="TextBoxMid"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserName"
                                                                    Display="None" ErrorMessage="Insert Course Category !" 
                                                                    SetFocusOnError="True" ValidationGroup="majorUnit"></asp:RequiredFieldValidator>
                                                             
                                                            </td>
                                                        </tr>
                                                        
                                                         <tr>
                                                            <td>
                                                                SubTitle</td>
                                                            <td>
                                                                <asp:TextBox ID="txtSubtitle" runat="server" CssClass="TextBoxMid"></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                        
                                                         <tr>
                                                            <td>
                                                                Description</td>
                                                            <td>
                                                                <asp:TextBox ID="txtdescription" runat="server" CssClass="TextBoxMid" 
                                                                    TextMode="MultiLine"></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                        
                                                         <tr>
                                                            <td>
                                                                &nbsp;</td>
                                                            <td>
                                                                &nbsp;</td>
                                                        </tr>
                                                        
                                                        <tr id="Image" runat="server" visible="false">
                                                            <td >
                                                                Title Image</td>
                                                            <td >
                                                                <asp:FileUpload ID="FileUpload1" runat="server" />
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
                                                            &nbsp;<asp:Label ID="lblImgUrl" runat="server" Visible="false"></asp:Label>
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
                                                <td valign="top" width="50%">
                                                    <table style="width: 100%; border-left-style: solid; border-left-width: 3px; border-left-color: #333333;">
                                                        <tr>
                                                            <td class="Add-Country">
                                                                News Type List                                                             </td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 121px" class="H2Center">
                                                                <asp:ListBox ID="lstbox" runat="server" AutoPostBack="True" Height="123px"
                                                                     Width="260px" 
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

