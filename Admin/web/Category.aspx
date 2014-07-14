<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage/AdminMaster.master"
    AutoEventWireup="true" CodeFile="Category.aspx.cs" Inherits="Admin_web_Category" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table style="width: 100%">
        <tr>
            <td>
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
                                                <td valign="top" width="80%">
                                                    <table style="width: 100%">
                                                        <tr>
                                                            <td class="Add-Country" colspan="2">
                                                                Add Category
                                                            </td>
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
                                                                 CssClass="RadioButton" runat="server" AutoPostBack="True" RepeatLayout="Flow" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" > 
                                                                <asp:ListItem Text="Institute" Value="2" Selected="True" ></asp:ListItem>
                                                                <asp:ListItem Text="School" Value="3" ></asp:ListItem>
                                                                <asp:ListItem Text="College" Value="4" ></asp:ListItem>
                                                                <asp:ListItem Text="Tutor" Value="5" ></asp:ListItem>
                                                                </asp:RadioButtonList>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="RadioButtonList1"
                                                                    Display="None" ErrorMessage="Select Type !" 
                                                                    SetFocusOnError="True" ValidationGroup="majorUnit"></asp:RequiredFieldValidator>
                                                             </td>
                                                        </tr>

                                                        <tr>
                                                            <td>
                                                                Country:
                                                            </td>
                                                            <td>
                                                                <asp:DropDownList ID="ddlUniversity0" runat="server" AutoPostBack="True" Onchange="ddlChkSelect('newType');"
                                                                    CssClass="txt-fld-Dropdown" OnSelectedIndexChanged="ddlUniversity0_SelectedIndexChanged">
                                                                </asp:DropDownList>
                                                                <div id="newType" style="visibility: hidden; height: 24px; width: 24px; float: right;
                                                                    margin-right: 65px; margin-top: 0px;">
                                                                    <img alt="Loading..." src="../images/loading.gif" style="width: 22px; height: 22px" />
                                                                </div>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ddlUniversity0"
                                                                    Display="None" ErrorMessage=" Select University" InitialValue="0"></asp:RequiredFieldValidator>
                                                                <cc1:ValidatorCalloutExtender ID="RequiredFieldValidator2_ValidatorCalloutExtender0"
                                                                    runat="server" Enabled="True" TargetControlID="RequiredFieldValidator2">
                                                                </cc1:ValidatorCalloutExtender>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                Category Name:
                                                            </td>
                                                            <td>
                                                                <asp:TextBox ID="txtUserName" runat="server" CssClass="txt-fld-country" onblur="javascript:Required('ctl00_ContentPlaceHolder1_txtUserName')"
                                                                    MaxLength="150"></asp:TextBox>
                                                                <span id="ctl00_ContentPlaceHolder1_txtUserNameL" style="width: 50px; float: none;">
                                                                </span>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserName"
                                                                    Display="None" ErrorMessage="Insert Course Category !" SetFocusOnError="True"
                                                                    ValidationGroup="majorUnit"></asp:RequiredFieldValidator>
                                                                <cc1:ValidatorCalloutExtender ID="RequiredFieldValidator1_ValidatorCalloutExtender"
                                                                    runat="server" Enabled="True" HighlightCssClass="validation" TargetControlID="RequiredFieldValidator1">
                                                                </cc1:ValidatorCalloutExtender>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                Sub Title
                                                            </td>
                                                            <td>
                                                                <asp:TextBox ID="txtSubtitle" runat="server" CssClass="TextBoxSmall" MaxLength="150"></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                Description
                                                            </td>
                                                            <td>
                                                                <asp:TextBox ID="txtdescription" runat="server" CssClass="TextBoxSmall" MaxLength="150"
                                                                    TextMode="MultiLine"></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                Image
                                                            </td>
                                                            <td>
                                                                <asp:FileUpload ID="FileUpload1" runat="server" />
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
                                                            <td>
                                                                &nbsp;
                                                            </td>
                                                            <td class="H1Center" colspan="2">
                                                                <asp:Button ID="btnSubmit" runat="server" CssClass="bnt-sbmt" OnClick="btnSubmit_Click"
                                                                    OnClientClick="ddlChkSelect('Submit');" onfocus="javascript:submitDistictdata();"
                                                                    Text="Submit" ValidationGroup="majorUnit" />
                                                                &nbsp;<asp:Button ID="btnCancel" runat="server" CausesValidation="False" CssClass="bnt-sbmt"
                                                                    OnClick="btnCancel_Click" Text="Cancel" />
                                                                &nbsp;
                                                                <asp:Button ID="btnDelete" runat="server" CssClass="bnt-sbmt" OnClick="btnDelete_Click"
                                                                    Text="Delete" ValidationGroup="majorUnit" Visible="False" />
                                                                &nbsp;<div id="Submit" style="visibility: hidden; height: 24px; width: 24px; float: right;
                                                                    margin-right: 65px; margin-top: 0px;">
                                                                    <img alt="Loading..." src="../images/loading.gif" style="width: 22px; height: 22px" />
                                                                </div>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                                <td valign="top" width="20%">
                                                    <table style="width: 100%; border-left-style: solid; border-left-width: 3px; border-left-color: #333333;">
                                                        <tr>
                                                            <td class="Add-Country">
                                                                Category List
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 121px" class="H2Center">
                                                                <asp:ListBox ID="lstbox" runat="server" AutoPostBack="True" style="height: 255px; width: 221px;" Onchange="ddlChkSelect('Submit');"
                                                                     CssClass="H2Center" OnSelectedIndexChanged="lstbox_SelectedIndexChanged">
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
            </td>
        </tr>
    </table>
</asp:Content>
