<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage/AdminMaster.master" AutoEventWireup="true" CodeFile="UniversityDetail.aspx.cs" Inherits="Admin_web_UniversityDetail" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 <link href="../Css/edumate.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:UpdatePanel ID="updatepanel1" runat="server">
        <ContentTemplate>
            <table>
                <tr>
                    <td class="H3Center">
                        University Info
                    </td>
                </tr>
                <tr>
                    <td class="H1Center">
                        <asp:Label ID="lblMsg" runat="server" CssClass="labelMsgRed"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <table>
                            <tr>
                                <td class="H1Center">
                                  
                                </td>
                            </tr>
                        </table>
                        <table style="width:100%;">
                            <tr>
                            
                                <td>
                                <div style="float:left; position:absolute; top: 295px; left: 292px;">
                                <asp:UpdateProgress ID="progressPinChecker" runat="server" AssociatedUpdatePanelID="updatepanel1">
                                        <ProgressTemplate>

                                                   <img alt="Loading..." src="../images/loading.gif" style="width: 22px;
                                                height: 22px" />
                                        </ProgressTemplate>
                                    </asp:UpdateProgress>

                                </div>
                                    <asp:Button ID="btnAddNewEmployee" CausesValidation="false" runat="server" CssClass="ButtonMid"
                                        OnClick="btnAddNewEmployee_Click" Text="Add New University" />
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="ImportUniversityExcelFile.aspx">Import University</a>
                                </td>
                            </tr>
                            <tr>
                                <td class="H1Center">
                                    <table>
                                        <tr>
                                            <td style="width: 10%">
                                            </td>
                                            <td style="width: 80%">
                                                <div id="EmployeeDiv" visible="false" runat="server">
                                                    <table width="90%">
                                                        <tr>
                                                            <td>
                                                                <table class="BoxFourRound">
                                                                    <tr>
                                                                        <td class="H3Center">
                                                                            University Detail</td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <table style="width: 100%">
                                                                                <tr>
                                                                                    <td width="2%">
                                                                                        &nbsp;
                                                                                    </td>
                                                                                    <td width="96%">
                                                                                        <table style="width: 100%">
                                                                                            <tr>
                                                                                                <td class="H2Left">
                                                                                                    Country:</td>
                                                                                                <td class="H1Left">
                                                                                                    <asp:DropDownList ID="ddlUniversity0" runat="server" AutoPostBack="True" Onchange="ddlChkSelect('ddCountry');"
                                                                                                        CssClass="DropdwonMid" 
                                                                                                        onselectedindexchanged="ddlUniversity0_SelectedIndexChanged">
                                                                                                    </asp:DropDownList>
                                                                                                      <div id="ddCountry"  style="visibility:hidden; height:24px;width:24px; float:right;margin-right:-24px;margin-top:0px;">
                                                                        <img alt="Loading..." src="../images/loading.gif" style="width: 22px;height: 22px" /> 
                                                                      </div>
                                                                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                                                                                        ControlToValidate="ddlUniversity0" Display="None" 
                                                                                                        ErrorMessage=" Select University" InitialValue="0"></asp:RequiredFieldValidator>
                                                                                                    <cc1:ValidatorCalloutExtender ID="RequiredFieldValidator2_ValidatorCalloutExtender0" 
                                                                                                        runat="server" Enabled="True" TargetControlID="RequiredFieldValidator2">
                                                                                                    </cc1:ValidatorCalloutExtender>
                                                                                                </td>
                                                                                                <td class="H2Left">
                                                                                                    State:</td>
                                                                                                <td class="H1Left">
                                                                                                
                                                                                                    <asp:DropDownList ID="ddlUniversity" runat="server" AutoPostBack="True" Onchange="ddlChkSelect('ddUniversity');"
                                                                                                        CssClass="DropdwonMid" 
                                                                                                        onselectedindexchanged="ddlUniversity_SelectedIndexChanged">
                                                                                                    </asp:DropDownList>
                                                                                                      <div id="ddUniversity"  style="visibility:hidden; height:24px;width:24px; float:right;margin-right:-24px;margin-top:0px;">
                                                                        <img alt="Loading..." src="../images/loading.gif" style="width: 22px;height: 22px" /> 
                                                                      </div>
                                                                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                                                                                        ControlToValidate="ddlUniversity" Display="None" 
                                                                                                        ErrorMessage=" Select University" InitialValue="0"></asp:RequiredFieldValidator>
                                                                                                    <cc1:ValidatorCalloutExtender ID="RequiredFieldValidator2_ValidatorCalloutExtender1" 
                                                                                                        runat="server" Enabled="True" TargetControlID="RequiredFieldValidator2">
                                                                                                    </cc1:ValidatorCalloutExtender>
                                                                                                </td>
                                                                                                <td class="H2Left">
                                                                                                    District:</td>
                                                                                                <td class="H1Left">
                                                                                                    <asp:DropDownList ID="ddlDistrict" runat="server" AutoPostBack="True" Onchange="ddlChkSelect('ddDistrict');"
                                                                                                        CssClass="DropdwonMid" 
                                                                                                        onselectedindexchanged="ddlDistrict_SelectedIndexChanged">
                                                                                                    </asp:DropDownList>
                                                                                                      <div id="ddDistrict"  style="visibility:hidden; height:24px;width:24px; float:right;margin-right:-24px;margin-top:0px;">
                                                                        <img alt="Loading..." src="../images/loading.gif" style="width: 22px;height: 22px" /> 
                                                                      </div>
                                                                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                                                                                                        ControlToValidate="ddlDistrict" Display="None" ErrorMessage="District !" 
                                                                                                        InitialValue="0"></asp:RequiredFieldValidator>
                                                                                                    <cc1:ValidatorCalloutExtender ID="RequiredFieldValidator7_ValidatorCalloutExtender" 
                                                                                                        runat="server" Enabled="True" TargetControlID="RequiredFieldValidator7">
                                                                                                    </cc1:ValidatorCalloutExtender>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr>
                                                                                                <td class="H2Left">
                                                                                                    &nbsp;</td>
                                                                                                <td class="H1Left">
                                                                                                    &nbsp;</td>
                                                                                                <td class="H2Left">
                                                                                                    &nbsp;</td>
                                                                                                <td class="H1Left">
                                                                                                    &nbsp;</td>
                                                                                                <td class="H2Left">
                                                                                                    &nbsp;</td>
                                                                                                <td class="H1Left">
                                                                                                    &nbsp;</td>
                                                                                            </tr>
                                                                                            <tr>
                                                                                                <td class="H2Left">
                                                                                                    City:</td>
                                                                                                <td class="H1Left">
                                                                                                    <asp:DropDownList ID="ddlCity" runat="server" CssClass="DropdwonMid">
                                                                                                    </asp:DropDownList>
                                                                                                </td>
                                                                                                <td class="H2Left">
                                                                                                    Uni_Type:</td>
                                                                                                <td class="H1Left">
                                                                                                    <asp:DropDownList ID="ddlUniType" runat="server" CssClass="DropdwonMid">
                                                                                                    </asp:DropDownList>
                                                                                                </td>
                                                                                                <td class="H2Left">
                                                                                                    Edu_Type:</td>
                                                                                                <td class="H1Left">
                                                                                                    <asp:DropDownList ID="ddl" runat="server" CssClass="DropdwonMid">
                                                                                                    </asp:DropDownList>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr>
                                                                                                <td class="H2Left">
                                                                                                    &nbsp;</td>
                                                                                                <td class="H1Left">
                                                                                                    &nbsp;</td>
                                                                                                <td class="H2Left">
                                                                                                    &nbsp;</td>
                                                                                                <td class="H1Left">
                                                                                                    &nbsp;</td>
                                                                                                <td class="H2Left">
                                                                                                    &nbsp;</td>
                                                                                                <td class="H1Left">
                                                                                                    &nbsp;</td>
                                                                                            </tr>
                                                                                            <tr>
                                                                                                <td class="H2Left">
                                                                                                    Name:
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                    <asp:TextBox ID="txtName" runat="server" CssClass="TextBoxMid" onblur="javascript:Required('ctl00_ContentPlaceHolder1_txtName')" MaxLength="100"></asp:TextBox>
                                                                                                     <span id="ctl00_ContentPlaceHolder1_txtNameL" style="width: 50px; float: none;"></span>
                                                                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                                                                        ControlToValidate="txtName" Display="None" ErrorMessage="University Name !" 
                                                                                                        SetFocusOnError="True"></asp:RequiredFieldValidator>
                                                                                                    <cc1:ValidatorCalloutExtender ID="ValidatorCalloutExtender1" runat="server" 
                                                                                                        Enabled="True" HighlightCssClass="validation" 
                                                                                                        TargetControlID="RequiredFieldValidator1">
                                                                                                    </cc1:ValidatorCalloutExtender>
                                                                                                </td>
                                                                                                <td class="H2Left">
                                                                                                    Address:
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                    <asp:TextBox ID="txtAddress" runat="server" CssClass="TextBoxMid" 
                                                                                                        MaxLength="100"></asp:TextBox>
                                                                                                </td>
                                                                                                <td class="H2Left">
                                                                                                    Phone:
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                    <asp:TextBox ID="txtPhone" runat="server" CssClass="TextBoxMid" MaxLength="16"></asp:TextBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr>
                                                                                                <td class="HShort" colspan="6">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr>
                                                                                                <td class="H2Left">
                                                                                                    Code:</td>
                                                                                                <td class="H1Left">
                                                                                                    <asp:TextBox ID="txtBranchCode" runat="server" CssClass="TextBoxMid" onblur="javascript:Required('ctl00_ContentPlaceHolder1_txtBranchCode')"
                                                                                                        MaxLength="100"></asp:TextBox>
                                                                                                          <span id="ctl00_ContentPlaceHolder1_txtBranchCodeL" style="width: 50px; float: none;"></span>
                                                                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                                                                                        ControlToValidate="txtBranchCode" Display="None" ErrorMessage="University Code !" 
                                                                                                        SetFocusOnError="True"></asp:RequiredFieldValidator>
                                                                                                    <cc1:ValidatorCalloutExtender ID="RequiredFieldValidator4_ValidatorCalloutExtender" 
                                                                                                        runat="server" Enabled="True" HighlightCssClass="validation" 
                                                                                                        TargetControlID="RequiredFieldValidator4">
                                                                                                    </cc1:ValidatorCalloutExtender>
                                                                                                </td>
                                                                                                <td class="H2Left">
                                                                                                    WebSite:
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                    <asp:TextBox ID="txtWebSite" runat="server" CssClass="TextBoxMid"></asp:TextBox>
                                                                                                </td>
                                                                                                <td class="H2Left">
                                                                                                    Mob No:
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                    <asp:TextBox ID="txtmobNo" runat="server" CssClass="TextBoxMid" MaxLength="12" onblur="javascript:Mobile('ctl00_ContentPlaceHolder1_txtmobNo')"></asp:TextBox>
                                                                                                      <span id="ctl00_ContentPlaceHolder1_txtmobNoL" style="width: 50px; float: none;"></span>
                                                                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtmobNo"
                                                                                                        Display="None" ErrorMessage="Mobile No !" SetFocusOnError="True"></asp:RequiredFieldValidator>
                                                                                                    <cc1:ValidatorCalloutExtender ID="RequiredFieldValidator2_ValidatorCalloutExtender"
                                                                                                        runat="server" Enabled="True" HighlightCssClass="validation" TargetControlID="RequiredFieldValidator2">
                                                                                                    </cc1:ValidatorCalloutExtender>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr>
                                                                                                <td class="HShort" colspan="6">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr>
                                                                                                <td class="H2Left" style="height: 26px">
                                                                                                    Publish&nbsp; Date:
                                                                                                </td>
                                                                                                <td class="H1Left" style="height: 26px">
                                                                                                    <asp:TextBox ID="txtDate" runat="server" CssClass="TextBoxMid" MaxLength="7">0</asp:TextBox>
                                                                                                    <cc1:CalendarExtender ID="txtDate_CalendarExtender" runat="server" 
                                                                                                        Enabled="True" TargetControlID="txtDate">
                                                                                                    </cc1:CalendarExtender>
                                                                                                </td>
                                                                                                <td class="H2Left" style="height: 26px">
                                                                                                    Land Mark:
                                                                                                </td>
                                                                                                <td class="H1Left" style="height: 26px">
                                                                                                    <asp:TextBox ID="txtLandMark" runat="server" CssClass="TextBoxMid" 
                                                                                                        MaxLength="100"></asp:TextBox>
                                                                                                </td>
                                                                                                <td class="H2Left" style="height: 26px">
                                                                                                    Mail Id:
                                                                                                </td>
                                                                                                <td class="H1Left" style="height: 26px">
                                                                                                    <asp:TextBox ID="txtMailId" runat="server" CssClass="TextBoxMid" MaxLength="100"></asp:TextBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr>
                                                                                                <td class="HShort" colspan="6">
                                                                                                    &nbsp;
                                                                                                </td>
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
                                                                                                </td>
                                                                                                <td class="H2Left">
                                                                                                    Rank:</td>
                                                                                                <td class="H1Left">
                                                                                                    <asp:DropDownList ID="ddlRankList" runat="server" CssClass="DropdwonMid">
                                                                                                    </asp:DropDownList>
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                    Grade:</td>
                                                                                                <td class="H1Left">
                                                                                                    <asp:DropDownList ID="ddlGrade" runat="server" CssClass="DropdwonMid">
                                                                                                    <asp:ListItem Text="A-Grade" Value="A-Grade" ></asp:ListItem>
                                                                                                    <asp:ListItem Text="B-Grade" Value="B-Grade" ></asp:ListItem>
                                                                                                    <asp:ListItem Text="C-Grade" Value="C-Grade" ></asp:ListItem>
                                                                                                    <asp:ListItem Text="D-Grade" Value="D-Grade" ></asp:ListItem>
                                                                                                    
                                                                                                    </asp:DropDownList>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr>
                                                                                                <td class="H2Left">
                                                                                                    &nbsp;</td>
                                                                                                <td class="H1Left">
                                                                                                    &nbsp;</td>
                                                                                                <td class="H2Left">
                                                                                                    &nbsp;</td>
                                                                                                <td class="H1Left">
                                                                                                    &nbsp;</td>
                                                                                                <td class="H1Left">
                                                                                                    &nbsp;</td>
                                                                                                <td class="H1Left">
                                                                                                    &nbsp;</td>
                                                                                            </tr>
                                                                                            <tr>
                                                                                                <td class="H2Left">
                                                                                                    &nbsp;</td>
                                                                                                <td class="H1Left">
                                                                                                    &nbsp;</td>
                                                                                                <td class="H2Left">
                                                                                                    <asp:Button ID="btnSubmit" runat="server" CssClass="ButtonMid" OnClientClick="ddlChkSelect('Submit');" onfocus="javascript:submitAddUniversitydata();"
                                                                                                        OnClick="btnSubmit_Click" Text="Submit" Width="76px" />
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                    <asp:Button ID="btnCancel" runat="server" CssClass="ButtonMid" 
                                                                                                        OnClick="btnCancel_Click" Text="Cancel" Width="83px" />
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                                <td class="H1Center" colspan="2">
                                                                                                <div id="Submit"  style="visibility:hidden; height:24px;width:24px; float:right;margin-right:65px;margin-top:0px;">
                                                                        <img alt="Loading..." src="../images/loading.gif" style="width: 22px;height: 22px" /> 
                                                                      </div>
                                                                                                    &nbsp;</td>
                                                                                            </tr>
                                                                                        </table>
                                                                                    </td>
                                                                                    <td width="2%">
                                                                                        &nbsp;
                                                                                    </td>
                                                                                </tr>
                                                                            </table>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            &nbsp;
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </div>
                                            </td>
                                            <td style="width: 10%">
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td align="center">
                                  
                                </td>
                            </tr>
                            <tr class="H1Center">
                                <td align="center">
                                    <table>
                                        <tr>
                                            <td>
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td class="HShort">
                                    <hr style="width: 98%" size="1" color="#616B62" width="98%" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <table>
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
                                                                        <asp:TextBox ID="txtGoPage" runat="server" CssClass="TextBoxShort" MaxLength="5"></asp:TextBox>
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
                                                            <asp:DropDownList ID="ddlNopage" runat="server" CssClass="DropdwonShort" OnSelectedIndexChanged="ddlNopage_SelectedIndexChanged" Onchange="ddlChkSelect('NoPage');"
                                                                AutoPostBack="True">
                                                                <asp:ListItem Text="10" Value="10"></asp:ListItem>
                                                                <asp:ListItem Text="30" Value="30"></asp:ListItem>
                                                                <asp:ListItem Text="50" Value="50"></asp:ListItem>
                                                                <asp:ListItem Text="100" Value="100"></asp:ListItem>
                                                            </asp:DropDownList>
                                                            <div id="NoPage"  style="visibility:hidden; height:24px;width:24px; float:right;margin-right:65px;margin-top:0px;">
                                                                        <img alt="Loading..." src="../images/loading.gif" style="width: 22px;height: 22px" /> 
                                                                      </div>
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
                                        <tr>
                                            <td style="width: 1">
                                                &nbsp;
                                            </td>
                                            <td align="center" style="width: 98%">
                                                <asp:Repeater ID="datalist" runat="server" OnItemCommand="datalist_ItemCommand">
                                                    <HeaderTemplate>
                                                        <table class="MasterTableCenter" cellpadding="10">
                                                            <tr>
                                                                <th rowspan="2">
                                                                    Sr. No.<br />
                                                                    <span style="font-size: 8px">Click for change</span>
                                                                </th>
                                                                <th rowspan="2">
                                                                    Date
                                                                </th>
                                                                <th colspan="4">
                                                                    University Info
                                                                </th>
                                                                <th colspan="5">
                                                                    Address Info
                                                                </th>
                                                                <th colspan="2">
                                                                    Contact Info
                                                                </th>
                                                                <th rowspan="2">Delete</th>
                                                            </tr>
                                                            <tr>
                                                                <th>
                                                                    Code
                                                                </th>
                                                                
                                                                <th>
                                                                    Name
                                                                </th>
                                                               
                                                                <th>
                                                                    Rank
                                                                </th>
                                                                <th>
                                                                    Grade
                                                                </th>
                                                                <th> University Type </th>
                                                                <th style="width: 180px">
                                                                    Address
                                                                </th>
                                                                <th>
                                                                    City
                                                                </th>
                                                                <th>
                                                                    District
                                                                </th>
                                                                <th>
                                                                    State
                                                                </th>
                                                         
                                                                <th>
                                                                    Mob No
                                                                </th>
                                                                <th>
                                                                    Mail Id
                                                                </th>
                                                            </tr>
                                                    </HeaderTemplate>
                                                    <ItemTemplate>
                                                        <tr>
                                                            <td>
                                                                <asp:LinkButton ID="lnkEdit" CausesValidation="false" runat="server" Text="Edit"
                                                                    CommandArgument='<%#Eval("Id")%>' CommandName="edit">
                                                                </asp:LinkButton>
                                                            </td>
                                                            <td>
                                                                <%#Eval("DOJ")%>
                                                            </td>
                                                            <td>
                                                                <%#Eval("branchCodeName")%>
                                                            </td>
                                                            <td>
                                                                <%#Eval("name")%>
                                                            </td>                                                      
                                                            <td>
                                                                <%#Eval("rank")%>
                                                            </td>
                                                            <td>
                                                                <%#Eval("grade")%>
                                                            </td>
                                                            <td><%#Eval("catID")%> </td>
                                                            <td style="width: 180px">
                                                                <%#Eval("address")%>
                                                            </td>
                                                            <td>
                                                                <%#Eval("city")%>
                                                            </td>
                                                            <td>
                                                                <%#Eval("district")%>
                                                            </td>
                                                            <td>
                                                                <%#Eval("state")%>
                                                            </td>
                                                     
                                                            <td>
                                                                <%#Eval("mobNo")%>
                                                            </td>
                                                            <td>
                                                                <%#Eval("mailId")%>
                                                            </td>
                                                           <td><asp:LinkButton ID="lnkDelete" CausesValidation="false" runat="server"
                                                                    CommandArgument='<%#Eval("Id")%>' CommandName="Delete"> Delete
                                                                </asp:LinkButton></td>
                                                        </tr>
                                                    </ItemTemplate>
                                                    <AlternatingItemTemplate>
                                                        <tr class="alt">
                                                            <td>
                                                                <asp:LinkButton ID="lnkEdit" CausesValidation="false" runat="server" Text="Edit"
                                                                    CommandArgument='<%#Eval("Id")%>' CommandName="edit">
                                                                </asp:LinkButton>
                                                            </td>
                                                            <td>
                                                                <%#Eval("DOJ")%>
                                                            </td>
                                                            <td>
                                                                <%#Eval("branchCodeName")%>
                                                            </td>
                                                            <td>
                                                                <%#Eval("name")%>
                                                            </td>
                                                           <%-- <td>
                                                                <%#Eval("security")%>
                                                            </td>--%>
                                                            <td>
                                                                <%#Eval("rank")%>
                                                            </td>
                                                            <td>
                                                                <%#Eval("grade")%>
                                                            </td>
                                                            <td><%#Eval("catID")%> </td>
                                                            <td style="width: 180px">
                                                                <%#Eval("address")%>
                                                            </td>
                                                            <td>
                                                                <%#Eval("city")%>
                                                            </td>
                                                            <td>
                                                                <%#Eval("district")%>
                                                            </td>
                                                            <td>
                                                                <%#Eval("state")%>
                                                            </td>
                                                         
                                                            <td>
                                                                <%#Eval("mobNo")%>
                                                            </td>
                                                            <td>
                                                                <%#Eval("mailId")%>
                                                            </td>
                                                            <td><asp:LinkButton ID="lnkDelete" CausesValidation="false" runat="server"
                                                                    CommandArgument='<%#Eval("Id")%>' CommandName="Delete"> Delete
                                                                </asp:LinkButton></td>
                                                        </tr>
                                                    </AlternatingItemTemplate>
                                                    <FooterTemplate>
                                                        </table>
                                                    </FooterTemplate>
                                                </asp:Repeater>
                                            </td>
                                            <td style="width: 1%">
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
        </ContentTemplate>
    </asp:UpdatePanel>


</asp:Content>

