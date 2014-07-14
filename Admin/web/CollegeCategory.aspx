<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage/AdminMaster.master" AutoEventWireup="true" CodeFile="CollegeCategory.aspx.cs" Inherits="Admin_web_CollegeCategory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
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
                                                                Institute Category</td>
                                                        </tr>
                                                        <tr>
                                                            <td class="H2Center" colspan="2">
                                                                <asp:Label ID="lblMsg" runat="server"></asp:Label>
                                                            </td>
                                                        </tr>                                                        
                                                        <tr>
                                                            <td>
                                                                Type:</td>
                                                            <td>
                                                                <asp:RadioButtonList ID="RadioButtonList1" RepeatDirection="Horizontal" 
                                                                    CssClass="RadioButton" runat="server" AutoPostBack="True" 
                                                                    onselectedindexchanged="RadioButtonList1_SelectedIndexChanged" 
                                                                    RepeatLayout="Flow">                                                                    
                                                                   <asp:ListItem Text="College" Value="4" ></asp:ListItem>                                                                
                                                             
                                                                </asp:RadioButtonList>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="RadioButtonList1"
                                                                    Display="None" ErrorMessage="Select Type !" 
                                                                    SetFocusOnError="True" ValidationGroup="majorUnit"></asp:RequiredFieldValidator>
                                                                                                                                                                                </td>
                                                        </tr>
                                                        
                                                        <tr>
                                                            <td>
                                                                Category Name:                                                             </td>
                                                            <td>
                                                                <asp:TextBox ID="txtUserName" runat="server" CssClass="TextBoxSmall" 
                                                                    MaxLength="150"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserName"
                                                                    Display="None" ErrorMessage="Insert Course Category !" 
                                                                    SetFocusOnError="True" ValidationGroup="majorUnit"></asp:RequiredFieldValidator>
                                                              
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
                                                                Sub Title</td>
                                                            <td>
                                                                <asp:TextBox ID="txtSubtitle" runat="server" CssClass="TextBoxSmall" 
                                                                    MaxLength="150"></asp:TextBox>
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
                                                                Description</td>
                                                            <td>
                                                                <asp:TextBox ID="txtdescription" runat="server" CssClass="TextBoxSmall" 
                                                                    MaxLength="150" TextMode="MultiLine"></asp:TextBox>
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
                                                                Image</td>
                                                            <td>
                                                                <asp:FileUpload ID="FileUpload1" runat="server" />
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="H1Center" colspan="2">
                                                                &nbsp;</td>
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
                                                                Stream List</td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 121px" class="H2Center">
                                                                <asp:ListBox ID="lstbox" runat="server" AutoPostBack="True" Height="123px"
                                                                     Width="250px" 
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

</asp:Content>

