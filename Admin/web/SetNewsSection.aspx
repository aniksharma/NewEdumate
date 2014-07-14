<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage/AdminNewsMaster.master"
    AutoEventWireup="true" CodeFile="SetNewsSection.aspx.cs" Inherits="Admin_web_SetNewsSection" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit.HTMLEditor"
    TagPrefix="cc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc2" %>
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
                                        <table class="BoxFour Round" style="width: 100%">
                                            <tr>
                                                <td class="H2Center">
                                                    <table width="100%" border="0" align="center" cellpadding="0" cellspacing="0" class="bo rder">
                                                        <tr>
                                                            <td class="Add-Country" style="width: 885px;">
                                                                Add News
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="center">
                                                                <asp:Label ID="lblMsg" runat="server"></asp:Label>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="center">
                                                                <table cellpadding="0" cellspacing="0" style="width: 100%" class="textbox">
                                                                    <tr>
                                                                        <td style="width: 15%" align="left">
                                                                            &nbsp;
                                                                        </td>
                                                                        <td align="left">
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td style="width: 15%" align="left">
                                                                            Select News For:
                                                                        </td>
                                                                        <td align="left">
                                                                            <asp:DropDownList ID="ddlUniversity" runat="server" CssClass="DropdwonSmall" onblur="javascript:DropDown('ctl00_ContentPlaceHolder1_ddlUniversity')"
                                                                                Onchange="ddlChkSelect('newType');" AutoPostBack="True" OnSelectedIndexChanged="ddlUniversity_SelectedIndexChanged">
                                                                            </asp:DropDownList>
                                                                            <span id="ctl00_ContentPlaceHolder1_ddlUniversityL" style="width: 50px; float: none;">
                                                                            </span>
                                                                            <div id="newType" style="visibility: hidden; height: 24px; width: 24px; float: right;
                                                                                margin-right: 65px; margin-top: 0px;">
                                                                                <img alt="Loading..." src="../images/loading.gif" style="width: 22px; height: 22px" />
                                                                            </div>
                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="ddlUniversity"
                                                                                Display="None" ErrorMessage="*" InitialValue="0" ValidationGroup="a"></asp:RequiredFieldValidator>
                                                                            <cc2:ValidatorCalloutExtender ID="RequiredFieldValidator2_ValidatorCalloutExtender"
                                                                                runat="server" Enabled="True" TargetControlID="RequiredFieldValidator2">
                                                                            </cc2:ValidatorCalloutExtender>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td style="width: 5%" align="right">
                                                                            &nbsp;
                                                                        </td>
                                                                        <td align="left">
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td style="width: 15%" align="left">
                                                                            Select News Type:
                                                                        </td>
                                                                        <td align="left">
                                                                            <asp:DropDownList ID="ddlNewsType" runat="server" onblur="javascript:DropDown('ctl00_ContentPlaceHolder1_ddlNewsType')"
                                                                                CssClass="DropdwonSmall" AutoPostBack="True" OnSelectedIndexChanged="ddlNewsType_SelectedIndexChanged">
                                                                            </asp:DropDownList>
                                                                            <span id="ctl00_ContentPlaceHolder1_ddlNewsTypeL" style="width: 50px; float: none;">
                                                                            </span>
                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ddlNewsType"
                                                                                Display="None" ErrorMessage="*" InitialValue="0" ValidationGroup="a"></asp:RequiredFieldValidator>
                                                                            <cc2:ValidatorCalloutExtender ID="RequiredFieldValidator4_ValidatorCalloutExtender"
                                                                                runat="server" Enabled="True" TargetControlID="RequiredFieldValidator4">
                                                                            </cc2:ValidatorCalloutExtender>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td style="width: 5%" align="right">
                                                                            &nbsp;
                                                                        </td>
                                                                        <td align="left">
                                                                            &nbsp;
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td style="width: 15%" align="left">
                                                                            Status:
                                                                        </td>
                                                                        <td align="left">
                                                                            <asp:RadioButtonList ID="rblStatus" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                                                                                <asp:ListItem Selected="True" Text="Enable" Value="1"></asp:ListItem>
                                                                                <asp:ListItem Text="Disable" Value="0"></asp:ListItem>
                                                                            </asp:RadioButtonList>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td style="width: 5%" align="right">
                                                                            &nbsp;
                                                                        </td>
                                                                        <td align="left">
                                                                            &nbsp;
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td style="width: 15%" align="left">
                                                                            Date:
                                                                        </td>
                                                                        <td align="left">
                                                                            <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
                                                                            <cc2:CalendarExtender ID="txtDate_CalendarExtender" runat="server" Enabled="True"
                                                                                TargetControlID="txtDate">
                                                                            </cc2:CalendarExtender>
                                                                            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtDate"
                                                                                ErrorMessage="Enter Valid Date!" Operator="DataTypeCheck" Type="Date" ValidationGroup="a"></asp:CompareValidator>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td style="width: 5%" align="right">
                                                                            &nbsp;
                                                                        </td>
                                                                        <td align="left">
                                                                            &nbsp;
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td style="width: 15%" align="left">
                                                                            Title:
                                                                        </td>
                                                                        <td align="left">
                                                                            <asp:TextBox ID="txt_title" runat="server" Width="400px" CssClass="textstyle" onblur="javascript:Required('ctl00_ContentPlaceHolder1_txt_title')"
                                                                                onkeyup="RequiredTitleCount('ctl00_ContentPlaceHolder1_txt_title')" MaxLength="500"></asp:TextBox>
                                                                            <span id="ctl00_ContentPlaceHolder1_txt_titleL" style="width: 50px; float: none;">&nbsp;</span>
                                                                            <asp:Label ID="txt_titleR" runat="server"></asp:Label>
                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_title"
                                                                                ErrorMessage="*" ValidationGroup="a"></asp:RequiredFieldValidator>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td style="height: 14px">
                                                                        </td>
                                                                        <td align="left" style="height: 14px">
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td style="width: 15%" align="left">
                                                                            Sub Title:
                                                                        </td>
                                                                        <td align="left" style="height: 14px">
                                                                            <asp:TextBox ID="txtSubTitle" runat="server" CssClass="textstyle" Width="400px" onblur="javascript:Required('ctl00_ContentPlaceHolder1_txtSubTitle')"
                                                                                onkeyup="javascript:RequiredSubTitleCount('ctl00_ContentPlaceHolder1_txtSubTitle')"
                                                                                MaxLength="501"></asp:TextBox>
                                                                            <span id="ctl00_ContentPlaceHolder1_txtSubTitleL" style="width: 50px; float: none;">
                                                                            </span><span id="ctl00_ContentPlaceHolder1_txtSubTitleR"></span>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td style="height: 14px">
                                                                            &nbsp;
                                                                        </td>
                                                                        <td align="left" style="height: 14px">
                                                                            &nbsp;
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td style="width: 15%" align="left">
                                                                            Description:
                                                                        </td>
                                                                        <td align="left">
                                                                            <cc1:Editor ID="txt_desc" runat="server" Height="300px" Width="400px" onkeyup="javascript:RequiredDescriptionCount('ctl00_ContentPlaceHolder1_txt_desc')" />
                                                                            <span id="ctl00_ContentPlaceHolder1_txt_descL" style="width: 50px; float: none;">
                                                                            </span><span id="ctl00_ContentPlaceHolder1_txt_descR" style="width: 50px; float: none;">
                                                                            </span>
                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txt_desc"
                                                                                ErrorMessage="*" ValidationGroup="a"></asp:RequiredFieldValidator>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            News Image:
                                                                        </td>
                                                                        <td align="left">
                                                                            <asp:FileUpload ID="FileUpload1" runat="server" />
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            &nbsp;
                                                                        </td>
                                                                        <td align="left">
                                                                            <asp:CheckBox ID="chkList" runat="server" CssClass="Checkbox" Text="Select New Image" />
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            &nbsp;
                                                                        </td>
                                                                        <td align="left">
                                                                            &nbsp;
                                                                            <asp:Button ID="btn_submit" runat="server" Text="Save" OnClick="btn_submit_Click"
                                                                                OnClientClick="ddlChkSelect('State');" onfocus="javascript:submitAddNewsdata();"
                                                                                ValidationGroup="a" CssClass="bnt-sbmt" />
                                                                            <div id="State" style="visibility: hidden; height: 24px; width: 24px; float: right;
                                                                                margin-right: 65px; margin-top: 0px;">
                                                                                <img alt="Loading..." src="../images/loading.gif" style="width: 22px; height: 22px" />
                                                                            </div>
                                                                            <asp:Label ID="lblImgUrl" runat="server" Visible="False"></asp:Label>
                                                                        </td>
                                                                    </tr>
                                                                    </table>
                                                               </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                &nbsp;
                                                            </td>
                                                            <td align="left">
                                                                &nbsp;
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
        <tr>
            <td colspan="3" class="HShort">
                <hr style="width: 98%" size="1" color="#616B62" width="98%" />
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <div id="pages">
                    <table style="width: 100%;">
                        <tr>
                            <td align="left" style="width: 100px; padding-left: 10px;">
                                <asp:Label ID="lblCurrentPage" runat="server" Text="1"></asp:Label>
                                &nbsp;
                                <asp:Label ID="lblPageOf" runat="server" Text="Of"></asp:Label>
                                &nbsp;
                                <asp:Label ID="lblLastPage" runat="server" Text="1"></asp:Label>
                            </td>
                            <td style="width: 170px;">
                                <table>
                                    <tr>
                                        <td>
                                            <asp:LinkButton ID="lnkfstPage" runat="server" CssClass="nextprev" OnClick="lnkfstPage_Click">First</asp:LinkButton>
                                        </td>
                                        <td>
                                            <asp:LinkButton ID="lnkPrepage" runat="server" CssClass="nextprev" OnClick="lnkPrepage_Click">Previous</asp:LinkButton>
                                        </td>
                                        <td>
                                            <asp:LinkButton ID="lnkNextpage" runat="server" CssClass="nextprev" OnClick="lnkNextpage_Click">Next</asp:LinkButton>
                                        </td>
                                        <td>
                                            <asp:LinkButton ID="lnkLastpage" runat="server" CssClass="nextprev" OnClick="lnkLastpage_Click">Last</asp:LinkButton>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td valign="top" style="width: 200px; text-align: center;">
                                <table>
                                    <tr>
                                        <td>
                                            <asp:TextBox ID="txtGoPage" runat="server" CssClass="TextBoxShort" Width="75" MaxLength="5"></asp:TextBox>
                                            <cc2:TextBoxWatermarkExtender ID="txtGoPage_TextBoxWatermarkExtender" runat="server"
                                                Enabled="True" TargetControlID="txtGoPage" WatermarkText="Page No">
                                            </cc2:TextBoxWatermarkExtender>
                                            <cc2:FilteredTextBoxExtender ID="txtGoPage_FilteredTextBoxExtender" runat="server"
                                                Enabled="True" FilterType="Numbers" TargetControlID="txtGoPage">
                                            </cc2:FilteredTextBoxExtender>
                                        </td>
                                        <td>
                                            <asp:LinkButton ID="lnkBtnGO" runat="server" CssClass="current" OnClick="lnkBtnGO_Click"
                                                ValidationGroup="go">Go</asp:LinkButton>
                                            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtGoPage"
                                                Display="None" ErrorMessage="Not Negtive Value" MaximumValue="9999999" MinimumValue="0"
                                                ValidationGroup="go"></asp:RangeValidator>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtGoPage"
                                                Display="None" ErrorMessage="Please Enter A Value" ValidationGroup="go"></asp:RequiredFieldValidator>
                                            <cc2:ValidatorCalloutExtender ID="RequiredFieldValidator1_ValidatorCalloutExtender"
                                                runat="server" Enabled="True" HighlightCssClass="validation" TargetControlID="RequiredFieldValidator1">
                                            </cc2:ValidatorCalloutExtender>
                                            <cc2:ValidatorCalloutExtender ID="RangeValidator1_ValidatorCalloutExtender" runat="server"
                                                Enabled="True" HighlightCssClass="validation" TargetControlID="RangeValidator1">
                                            </cc2:ValidatorCalloutExtender>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td style="width: 100px;">
                                <asp:DropDownList ID="ddlNopage" runat="server" Width="75" OnSelectedIndexChanged="ddlNopage_SelectedIndexChanged"
                                    AutoPostBack="True">
                                    <asp:ListItem Text="10" Value="10"></asp:ListItem>
                                    <asp:ListItem Text="30" Value="30"></asp:ListItem>
                                    <asp:ListItem Text="50" Value="50"></asp:ListItem>
                                    <asp:ListItem Text="100" Value="100"></asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                    </table>
                </div>
            </td>
        </tr>
        <tr>
            <td colspan="3" class="HShort">
                <hr style="width: 98%" size="1" color="#616B62" width="98%" />
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Repeater ID="datalist" runat="server" OnItemCommand="datalist_ItemCommand">
                    <HeaderTemplate>
                        <table class="MasterTableCenter">
                            <tr>
                                <tr>
                                    <th>
                                        Sr. No.
                                    </th>
                                    <th>
                                        Title
                                    </th>
                                    <%--  <th>
                                                                                        Description
                                                                                    </th>--%>
                                    <th>
                                        News Type
                                    </th>
                                    <th>
                                        News For
                                    </th>
                                    <th>
                                        Status
                                    </th>
                                    <th>
                                        New Image
                                    </th>
                                    <th>
                                        Date
                                    </th>
                                    <th>
                                        Delete
                                    </th>
                                    <th style="width: 94px;">
                                        View
                                    </th>
                                </tr>
                            </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td valign="top">
                                <asp:LinkButton ID="LinkButton1" runat="server" Text="Edit" CommandArgument='<%#Eval("id")%>'
                                    CommandName="edit" CausesValidation="false">
                                </asp:LinkButton>
                            </td>
                            <td valign="top">
                                <%#Eval("title")%>
                            </td>
                            <td>
                                <%#Eval("catID")%>
                            </td>
                            <td>
                                <%#Eval("uniID")%>
                            </td>
                            <td>
                                <%#Eval("isActive")%>
                            </td>
                            <td>
                                <%#Eval("urlPath")%>
                            </td>
                            <td valign="top">
                                <%#Eval("DOJ")%>
                            </td>
                            <td valign="top">
                                <asp:LinkButton ID="lnkEdit" runat="server" Text="Delete" CommandArgument='<%#Eval("id")%>'
                                    CommandName="Delete" CausesValidation="false">
                                </asp:LinkButton>
                            </td>
                            <td>
                                <a href='../web/ViewPreview.aspx?id=<%#Eval("id")%>' target="_blank">Check Preview</a>
                            </td>
                        </tr>
                    </ItemTemplate>
                    <AlternatingItemTemplate>
                        <tr class="alt">
                            <td valign="top">
                                <asp:LinkButton ID="LinkButton1" runat="server" Text="Edit" CommandArgument='<%#Eval("id")%>'
                                    CommandName="edit" CausesValidation="false">
                                </asp:LinkButton>
                            </td>
                            <td valign="top">
                                <%#Eval("title")%>
                            </td>
                            <td>
                                <%#Eval("catID")%>
                            </td>
                            <td>
                                <%#Eval("uniID")%>
                            </td>
                            <td>
                                <%#Eval("isActive")%>
                            </td>
                            <td>
                                <%#Eval("urlPath")%>
                            </td>
                            <td valign="top">
                                <%#Eval("DOJ")%>
                            </td>
                            <td valign="top">
                                <asp:LinkButton ID="lnkEdit" runat="server" Text="Delete" CommandArgument='<%#Eval("id")%>'
                                    CommandName="Delete" CausesValidation="false">
                                </asp:LinkButton>
                            </td>
                            <td>
                                <a href='../web/ViewPreview.aspx?id=<%#Eval("id")%>' target="_blank">Check Preview</a>
                            </td>
                        </tr>
                    </AlternatingItemTemplate>
                    <FooterTemplate>
                        </table>
                    </FooterTemplate>
                </asp:Repeater>
            </td>
        </tr>
    </table>
</asp:Content>
