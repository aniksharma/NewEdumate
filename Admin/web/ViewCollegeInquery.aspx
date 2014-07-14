<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage/AdminInqueryMaster.master" AutoEventWireup="true" CodeFile="ViewCollegeInquery.aspx.cs" Inherits="Admin_web_ViewCollegeInquery" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table>
                                    <tr>
                                    <td colspan="3" class="Add-Country">
                                        <asp:Label ID="lblHeading" runat="server" Text="Student Inquiry Detail"></asp:Label>
                                    </td>
                                    </tr>
                                    <tr>
                                    <td colspan="3" class="H1Center" >
                                        <asp:Label ID="lblMsg" runat="server" ></asp:Label>
                                    </td>
                                    </tr>
                                    <tr>
                                            <td colspan="3" style="width: 4%" class="HShort">
                                                <hr style="width: 98%" size="1" color="#616B62" width="98%" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 2%">
                                                &nbsp;
                                            </td>
                                            <td align="center" style="width: 96%">
                                                <table>
                                                    <tr>
                                                        <td align="left" style="width: 25%">
                                                            <asp:Label ID="lblCurrentPage" runat="server" Text="1"></asp:Label>
                                                            &nbsp;
                                                            <asp:Label ID="lblPageOf" runat="server" Text="Of"></asp:Label>
                                                            &nbsp;
                                                            <asp:Label ID="lblLastPage" runat="server" Text="1"></asp:Label>
                                                        </td>
                                                        <td style="width: 25%">
                                                            <table>
                                                                <tr>
                                                                    <td>
                                                                        <asp:LinkButton ID="lnkfstPage" runat="server" CssClass="LinkButtonMid" OnClick="lnkfstPage_Click">&lt;&lt;</asp:LinkButton>
                                                                    </td>
                                                                    <td>
                                                                        <asp:LinkButton ID="lnkPrepage" runat="server" CssClass="LinkButtonMid" OnClick="lnkPrepage_Click">&lt;</asp:LinkButton>
                                                                    </td>
                                                                    <td>
                                                                        <asp:LinkButton ID="lnkNextpage" runat="server" CssClass="LinkButtonMid" OnClick="lnkNextpage_Click">&gt;</asp:LinkButton>
                                                                        <td>
                                                                            <asp:LinkButton ID="lnkLastpage" runat="server" CssClass="LinkButtonMid" OnClick="lnkLastpage_Click">&gt;&gt;</asp:LinkButton>
                                                                        </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                        <td valign="top" style="width: 25%">
                                                            <table>
                                                                <tr>
                                                                    <td>
                                                                        <asp:TextBox ID="txtGoPage" runat="server" Width="75"  CssClass="TextBoxShort" MaxLength="5"></asp:TextBox>
                                                                        <cc1:TextBoxWatermarkExtender ID="txtGoPage_TextBoxWatermarkExtender" runat="server"
                                                                            Enabled="True" TargetControlID="txtGoPage" WatermarkText="Page No">
                                                                        </cc1:TextBoxWatermarkExtender>
                                                                        <cc1:FilteredTextBoxExtender ID="txtGoPage_FilteredTextBoxExtender" runat="server"
                                                                            Enabled="True" FilterType="Numbers" TargetControlID="txtGoPage">
                                                                        </cc1:FilteredTextBoxExtender>
                                                                        <asp:LinkButton ID="lnkBtnGO" runat="server" CssClass="LinkButtonMid" OnClick="lnkBtnGO_Click"
                                                                            ValidationGroup="go">Go</asp:LinkButton>
                                                                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtGoPage"
                                                                            Display="None" ErrorMessage="Not Negtive Value" MaximumValue="9999999" MinimumValue="0"
                                                                            ValidationGroup="go"></asp:RangeValidator>
                                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtGoPage"
                                                                            Display="None" ErrorMessage="Please Enter A Value" ValidationGroup="go"></asp:RequiredFieldValidator>
                                                                        <cc1:ValidatorCalloutExtender ID="RequiredFieldValidator1_ValidatorCalloutExtender"
                                                                            runat="server" Enabled="True" HighlightCssClass="validation" TargetControlID="RequiredFieldValidator1">
                                                                        </cc1:ValidatorCalloutExtender>
                                                                        <cc1:ValidatorCalloutExtender ID="RangeValidator1_ValidatorCalloutExtender" runat="server"
                                                                            Enabled="True" HighlightCssClass="validation" TargetControlID="RangeValidator1">
                                                                        </cc1:ValidatorCalloutExtender>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                        <td style="width: 25%">
                                                            <asp:DropDownList ID="ddlNopage" Width="100px"  runat="server" CssClass="DropdwonShort" OnSelectedIndexChanged="ddlNopage_SelectedIndexChanged"
                                                                AutoPostBack="True">
                                                                <asp:ListItem Text="10" Value="10"></asp:ListItem>
                                                                <asp:ListItem Text="30" Value="30"></asp:ListItem>
                                                                <asp:ListItem Text="50" Value="50"></asp:ListItem>
                                                                <asp:ListItem Text="100" Value="100"></asp:ListItem>
                                                            </asp:DropDownList>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                            <td style="width: 2%">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="3" style="width: 4%" class="HShort">
                                                <hr style="width: 98%" size="1" color="#616B62" width="98%" />
                                            </td>
                                        </tr>
                                       <tr>  <td style="width: 1">
                                                &nbsp;
                                            </td><td align="center"><table width="400px"><tr><td>
                                         <tr>
                                                            <td>
                                                                Type:</td>
                                                            <td>
                                                                <asp:RadioButtonList ID="RadioButtonList1" RepeatDirection="Horizontal" 
                                                                    CssClass="RadioButton" runat="server" AutoPostBack="True" 
                                                                    onselectedindexchanged="RadioButtonList1_SelectedIndexChanged" 
                                                                    RepeatLayout="Flow">
                                                                <asp:ListItem Text="College" Value="4" ></asp:ListItem>
                                                                <asp:ListItem Text="Tutor" Value="5"></asp:ListItem>
                                                                </asp:RadioButtonList>
                                                                                                                                                                                </td>
                                                        </tr>
                                                         
                                        <tr><td>Main Stream<asp:DropDownList ID="ddlmainStream" runat="server" Width="150px"  AutoPostBack="True" 
                                                onselectedindexchanged="ddlmainStream_SelectedIndexChanged">
                                            </asp:DropDownList>
                                            </td><td>
                                        Category<asp:DropDownList ID="ddlCategory" runat="server" Width="150px" 
                                                onselectedindexchanged="ddlCategory_SelectedIndexChanged" AutoPostBack="True">
                                            </asp:DropDownList></td></tr>
                                            </td></tr></table></td><td style="width: 1">
                                                &nbsp;
                                            </td></tr>
                                        <tr>
                                            <td style="width: 1">
                                                &nbsp;
                                            </td>
                                            <td align="center" style="width: 98%">
                                                <asp:Repeater ID="Repeater1" runat="server" 
                                                    onitemcommand="Repeater1_ItemCommand">
                                                <HeaderTemplate><table class="MasterTableCenter"><tr><th>Sender Name</th><th>Email</th><th>City</th><th>Description</th><th>Mobile-no</th>
                                                <th>CollegeName</th><th>Date</th><th>Location</th><th>State</th><th>IpAddress</th><th>Delete</th></tr></HeaderTemplate>
                                                <FooterTemplate></table></FooterTemplate>
                                                <ItemTemplate><tr><td><%#Eval("name")%></td><td><%#Eval("emailID")%></td><td><%#Eval("city")%></td><td><%#Eval("description")%></td>
                                                <td><%#Eval("mobNo")%></td><td><%#Eval("title")%></td><td><%#Eval("DOB")%></td><td><%#Eval("otherLocation")%></td>
                                                <td><%#Eval("state")%></td><td><%#Eval("address")%></td><td>
                                                    <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("id")%>' CommandName="Delete">Delete</asp:LinkButton></td></tr></ItemTemplate>
                                                </asp:Repeater>
                                            </td>
                                            <td style="width: 1%">
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </table>

</asp:Content>

