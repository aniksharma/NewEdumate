<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage/AdminMaster.master"
    AutoEventWireup="true" CodeFile="UniversityType.aspx.cs" Inherits="Admin_web_UniversityType" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit.HTMLEditor"
    TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../Css/edumate.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
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
                                    <td valign="top" width="100%" align="center">
                                        <table style="width: 100%">
                                            <tr>
                                                <td class="Add-Country" colspan="2">
                                                    Add University Type&nbsp;&nbsp;&nbsp;&nbsp; <a href="ImportUniType.aspx">Import Type
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="H2Center" colspan="2">
                                                    <asp:Label ID="lblMsg" runat="server"></asp:Label>
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
                                            <tr>
                                                <td style="width: 170px;">
                                                    Country:
                                                </td>
                                                <td>
                                               <asp:Label ID="lblCountry" runat="server" Visible="false"></asp:Label>
                                                    <asp:DropDownList ID="ddlCountry" runat="server" AutoPostBack="True" CssClass="DropdwonMid"
                                                        Width="200px" OnSelectedIndexChanged="ddlCountry_SelectedIndexChanged">
                                                    </asp:DropDownList>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ddlCountry"
                                                        ErrorMessage="It is Required" ValidationGroup="majorUnit"></asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2">
                                                    &nbsp;
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    State:
                                                </td>
                                                 <td>
                                                 <asp:Label ID="lblState" runat="server" Visible="false"></asp:Label>
                                                    <asp:DropDownList ID="ddlUniversity" runat="server" AutoPostBack="True" onblur="javascript:DropDown('ContentPlaceHolder1_ddlUniversity')"
                                                        CssClass="DropdwonMid" Width="200px" Onchange="ddlChkSelect('State');" OnSelectedIndexChanged="ddlUniversity0_SelectedIndexChanged">
                                                    </asp:DropDownList>
                                                    <span id="ContentPlaceHolder1_ddlUniversityL" style="width: 50px; float: none;">
                                                    </span>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="ddlUniversity"
                                                        ErrorMessage="It is Required" ValidationGroup="majorUnit"></asp:RequiredFieldValidator>
                                                    <div id="State" style="visibility: hidden; height: 24px; width: 24px; float: right;
                                                        margin-right: 65px; margin-top: -24px;">
                                                        <img alt="Loading..." src="../images/loading.gif" style="width: 22px; height: 22px" />
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2">
                                                    &nbsp;
                                                </td>
                                            </tr>

                                             <tr>
                                                <td style="width: 40px">
                                                    District
                                                </td>
                                                <td>
                                                 <asp:Label ID="lblDist" runat="server" Visible="false"></asp:Label>
                                                    <asp:DropDownList ID="ddlDist" runat="server" AutoPostBack="True" CssClass="DropdwonMid"
                                                        Width="200px">
                                                    </asp:DropDownList>
                                                    <span id="ContentPlaceHolder1_ddlDistL" style="width: 50px; float: none;"></span>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ddlDist"
                                                        ErrorMessage="It is Required" ValidationGroup="majorUnit"></asp:RequiredFieldValidator>
                                                    <div id="Dist" style="visibility: hidden; height: 24px; width: 24px; float: right;
                                                        margin-right: 65px; margin-top: -24px;">
                                                        <img alt="Loading..." src="../images/loading.gif" style="width: 22px; height: 22px" />
                                                    </div>
                                                </td>
                                            </tr>

                                             <tr>
                                                <td colspan="2">
                                                    &nbsp;
                                                </td>
                                            </tr>


                                            <tr>
                                                <td>
                                                    University Type:
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="txtUserName" runat="server" CssClass="TextBoxSmall" onblur="javascript:Required('ctl00_ContentPlaceHolder1_txtUserName')"
                                                        MaxLength="150"></asp:TextBox>
                                                    <span id="ctl00_ContentPlaceHolder1_txtUserNameL" style="width: 50px; float: none;">
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserName"
                                                            Display="None" ErrorMessage="Insert Course Category !" SetFocusOnError="True"
                                                            ValidationGroup="majorUnit"></asp:RequiredFieldValidator>
                                                    </span>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2">
                                                    &nbsp;
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    SubTitle
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="txtSubTitle" runat="server" CssClass="TextBoxSmall" onkeyup="RequiredSubTitleCount('ctl00_ContentPlaceHolder1_txtSubTitle')"
                                                        onblur="javascript:Required('ctl00_ContentPlaceHolder1_txtSubTitle')" MaxLength="501"
                                                        TextMode="MultiLine"></asp:TextBox>
                                                    <span id="ctl00_ContentPlaceHolder1_txtSubTitleL" style="width: 50px; float: none;">
                                                    </span><span id="ctl00_ContentPlaceHolder1_txtSubTitleR"></span>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2">
                                                    &nbsp;
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    Description
                                                </td>
                                                <td>
                                                
                                                    <asp:TextBox ID="Editor1" runat="server" Height="57px" TextMode="MultiLine" Width="300px"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2">
                                                    &nbsp;
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
                                                    &nbsp;
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="H2Left">
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
                                                    <asp:Label ID="lblImgUrl" runat="server" Visible="false"></asp:Label>
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
                                                        OnClientClick="ddlChkSelect('Submit');" onfocus="javascript:submitUniversityTypedata();"
                                                        Text="Submit" ValidationGroup="majorUnit" />
                                                    &nbsp;<asp:Button ID="btnCancel" runat="server" CausesValidation="False" CssClass="bnt-sbmt"
                                                        OnClick="btnCancel_Click" Text="Cancel" />
                                                    &nbsp;
                                                    <asp:Button ID="btnDelete" runat="server" CssClass="bnt-sbmt" OnClick="btnDelete_Click"
                                                        Text="Delete" ValidationGroup="majorUnit" Visible="False" />
                                                    &nbsp;
                                                    <div id="Submit" style="visibility: hidden; height: 24px; width: 24px; float: right;
                                                        margin-right: 65px; margin-top: 0px;">
                                                        <img alt="Loading..." src="../images/loading.gif" style="width: 22px; height: 22px" />
                                                    </div>
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
                                                            Subtitle
                                                        </th>
                                                        <th>Country</th>
                                                         <th>State</th>
                                                          <th>City</th>
                                                        <th>
                                                            Edit
                                                        </th>
                                                    </tr>
                                            </HeaderTemplate>
                                            <FooterTemplate>
                                                </table>
                                            </FooterTemplate>
                                            <ItemTemplate>
                                                <tr>
                                                    <td>
                                                        <%#Eval("name") %>
                                                    </td>
                                                    <td>
                                                        <%#Eval("title") %>
                                                    </td>
                                                    <td>
                                                        <%#Eval("country")%>
                                                    </td>
                                                    <td>
                                                        <%#Eval("state")%>
                                                    </td>
                                                    <td>
                                                        <%#Eval("district")%>
                                                    </td>

                                                    <td>
                                                        <asp:LinkButton ID="LinkButton1" CommandArgument='<%#Eval("id") %>' runat="server">Edit</asp:LinkButton>
                                                    
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
            </td>
        </tr>
    </table>
</asp:Content>
