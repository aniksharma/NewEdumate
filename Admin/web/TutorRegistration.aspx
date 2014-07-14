<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage/AdminMaster.master"
    AutoEventWireup="true" CodeFile="TutorRegistration.aspx.cs" Inherits="Admin_web_TutorRegistration" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../Css/box.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table width="100%" style="margin-top: 0px;">
        <tr>
            <td>
                <asp:UpdatePanel ID="updatepanel1" runat="server">
                    <ContentTemplate>
                        <table cellpadding="0px" cellspacing="0px" style="height: 0px; width: 100%">
                            <tr>
                                <td>
                                    <asp:LinkButton ID="LinkButton1" runat="server"></asp:LinkButton>
                                    <cc1:ModalPopupExtender ID="LinkButton1_ModalPopupExtender" runat="server" BackgroundCssClass="backcss"
                                        DynamicServicePath="" Enabled="True" PopupControlID="Error" TargetControlID="LinkButton1"
                                        CancelControlID="LinkButton5">
                                    </cc1:ModalPopupExtender>
                                    <asp:Panel ID="Error" runat="server">
                                        <div style="background: none repeat scroll 0 0 #525252; padding: 10px; z-index: 100000;
                                            display: block; width: 400px; left: 278px; top: 456px;">
                                            <div style="background: none repeat scroll 0 0 #6391CC; padding: 12px 10px;">
                                                <span style="float: right; margin-top: -12px;">
                                                    <asp:LinkButton ID="LinkButton5" runat="server" Font-Underline="false" ForeColor="White">X</asp:LinkButton>
                                                </span>
                                            </div>
                                            <div style="background: none repeat scroll 0 0 #FFFFFF; padding: 10px;">
                                                <div style="background-color: #ffffff; text-align: left;">
                                                    <div>
                                                        <table width="100%">
                                                            <tr>
                                                                <td style="height: 22px">
                                                                </td>
                                                                <td style="height: 22px">
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="2">
                                                                    <asp:Label ID="lblerrorShow" runat="server" ForeColor="#444444"></asp:Label>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="2" style="height: 25px">
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td>
                                                                </td>
                                                                <td align="right">
                                                                    <asp:Button ID="btOk" runat="server" Text="Ok" CausesValidation="False" />
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </asp:Panel>
                                </td>
                            </tr>
                            <tr>
                                <td class="insert">
                                    <table width="100%" style="padding-top: 20px;" class="thAlign">
                                        <tr>
                                            <td style="text-align: left;" class="Add-Country">
                                                Login Details:
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <table style="width: 100%;">
                                                    <tr>
                                                        <td colspan="2" class="blank">
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style="width: 160px;">
                                                            <span style="color: #CC0000">*</span>Email ID
                                                        </td>
                                                        <td style="width: 288px;">
                                                            <asp:TextBox ID="txtemail" runat="server" onchange="ddlChkSelect('txt');" OnTextChanged="txtemail_TextChanged"
                                                                onblur="javascript:Required('ContentPlaceHolder1_txtemail')" AutoPostBack="True"
                                                                Width="250px"></asp:TextBox>
                                                            <span id="ContentPlaceHolder1_txtemailL" style="width: 50px; float: none;"></span>
                                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtemail"
                                                                ErrorMessage="Only Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtemail"
                                                                ErrorMessage="It is Required" ValidationGroup="t"></asp:RequiredFieldValidator>
                                                            <div id="txt" style="visibility: hidden; height: 24px; width: 24px; float: right;
                                                                margin-right: 141px;">
                                                                <img alt="Loading..." src="../images/loading.gif" style="width: 22px; height: 22px" />
                                                            </div>
                                                        </td>
                                                        <td style="width: 210px;">
                                                            Verify Email
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="Txtvaryfy" runat="server" Width="250px" onblur="javascript:VaryfyEmail('ContentPlaceHolder1_Txtvaryfy')"></asp:TextBox>
                                                            <span id="ContentPlaceHolder1_TxtvaryfyL" style="width: 50px; float: none;"></span>
                                                            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtemail"
                                                                ControlToValidate="Txtvaryfy" ErrorMessage="Confirm E-mail" ValidationGroup="t"></asp:CompareValidator>
                                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="Txtvaryfy"
                                                                ErrorMessage="Only Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                                                        </td>
                                                    </tr>
                                                  
                                                    <tr>
                                                        <td>
                                                            <span style="color: #CC0000">*</span>Password
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="txtpassword" Width="250px" runat="server" TextMode="Password" onblur="javascript:Password('ContentPlaceHolder1_txtpassword')"></asp:TextBox>
                                                            <span id="ContentPlaceHolder1_txtpasswordL" style="width: 50px; float: none;"></span>
                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtpassword"
                                                                ErrorMessage="It is Required" ValidationGroup="t"></asp:RequiredFieldValidator>
                                                        </td>
                                                        <td>
                                                            <span style="color: #CC0000">*</span>Verify Password
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="txtpassVaryfy" Width="250px" runat="server" TextMode="Password"
                                                                onblur="javascript:VaryfyPassword('ContentPlaceHolder1_txtpassVaryfy')"></asp:TextBox>
                                                            <span id="ContentPlaceHolder1_txtpassVaryfyL" style="width: 50px; float: none;">
                                                            </span>
                                                            <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="txtpassword"
                                                                ControlToValidate="txtpassVaryfy" ErrorMessage="Confirm Pass" ValidationGroup="t"></asp:CompareValidator>
                                                        </td>
                                                    </tr>
                                                
                                                   
                                                    <tr>
                                                        <td>
                                                        </td>
                                                        <td>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Add-Country" style="text-align: left;">
                                                Personal Details:
                                                <div style="float: left; position: absolute; top: 1500px; left: 920px;">
                                                    <asp:UpdateProgress ID="progressPinChecker" runat="server" AssociatedUpdatePanelID="updatepanel1">
                                                        <ProgressTemplate>
                                                   
                                                        </ProgressTemplate>
                                                    </asp:UpdateProgress>
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <table style="width: 100%">
                                                    <tr>
                                                        <td colspan="2">
                                                            <table width="100%">
                                                                <tr>
                                                                    <td class="blank" colspan="2">
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td style="width: 160px;">
                                                                        <span style="color: #CC0000">*</span>Type
                                                                    </td>
                                                                    <td>
                                                                    <asp:RadioButtonList ID="ddlUniType" runat="server" RepeatDirection="Horizontal"
                                                                            RepeatLayout="Flow">
                                                                            <asp:ListItem Text="Govt" Value="1"></asp:ListItem>
                                                                            <asp:ListItem Text="Private" Value="2" Selected="True"></asp:ListItem>
                                                                            <asp:ListItem Text="Semi-Govt" Value="3"></asp:ListItem>
                                                                        </asp:RadioButtonList>

                                                                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" Visible="false" AutoPostBack="True" RepeatDirection="Horizontal"
                                                                            RepeatLayout="Flow">
                                                                            <asp:ListItem Text="Tutor" Value="5" Selected="True"></asp:ListItem>
                                                                        </asp:RadioButtonList>
                                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="RadioButtonList1"
                                                                            ErrorMessage="Select Type !"></asp:RequiredFieldValidator>
                                                                    </td>
                                                                    <td>
                                                                        <span style="color: #CC0000">*</span>Name
                                                                    </td>
                                                                    <td>
                                                                        <asp:TextBox ID="txttypename" Width="300px" runat="server" onblur="javascript:Required('ContentPlaceHolder1_txttypename')"></asp:TextBox>
                                                                        <span id="ContentPlaceHolder1_txttypenameL" style="width: 50px; float: none;"></span>
                                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="txttypename"
                                                                            ErrorMessage="It is Required"></asp:RequiredFieldValidator>
                                                                    </td>
                                                                </tr>
                                                              
                                                                <tr>
                                                                    <td class="blank" colspan="2">
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td>
                                                                        <span style="color: #CC0000">*</span>DOB
                                                                    </td>
                                                                    <td>
                                                                        <asp:TextBox ID="txtAge" runat="server" Width="300px" CssClass="TextBoxMid" onblur="javascript:Required('ContentPlaceHolder1_txtAge')"></asp:TextBox>
                                                                        <span id="ContentPlaceHolder1_txtAgeL" style="width: 50px; float: none;"></span>
                                                                        <cc1:CalendarExtender ID="txtAge_CalendarExtender" runat="server" Enabled="True"
                                                                            TargetControlID="txtAge">
                                                                        </cc1:CalendarExtender>
                                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" ControlToValidate="txtAge"
                                                                            ErrorMessage="*">*</asp:RequiredFieldValidator>
                                                                        <asp:CompareValidator ID="CompareValidator4" runat="server" ControlToValidate="txtAge"
                                                                            ErrorMessage="Valid Date" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator>
                                                                    </td>
                                                                    <td>
                                                                        <span style="color: #CC0000">*</span>Gender
                                                                    </td>
                                                                    <td>
                                                                        <asp:RadioButtonList ID="RadioButtonList2" runat="server" RepeatDirection="Horizontal"
                                                                            RepeatLayout="Flow">
                                                                            <asp:ListItem Text="Male" Selected="True" Value="1"></asp:ListItem>
                                                                            <asp:ListItem Text="Female" Value="2"></asp:ListItem>
                                                                        </asp:RadioButtonList>
                                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator19" runat="server" ControlToValidate="RadioButtonList2"
                                                                            ErrorMessage="*" InitialValue="0">*</asp:RequiredFieldValidator>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="blank" colspan="2">
                                                                    </td>
                                                                </tr>
                                                             
                                                                <tr>
                                                                    <td class="blank" colspan="2">
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td style="width: 150px;">
                                                                        <span style="color: #CC0000">*</span>Country
                                                                    </td>
                                                                    <td>
                                                                        <asp:DropDownList ID="ddlCountry" AutoPostBack="True" Style="width: 308px;" runat="server"
                                                                            OnSelectedIndexChanged="ddlCountry_SelectedIndexChanged">
                                                                        </asp:DropDownList>
                                                                      
                                                                    </td>
                                                                    <td style="width: 150px;">
                                                                        <span style="color: #CC0000">*</span>State
                                                                    </td>
                                                                    <td>
                                                                        <asp:DropDownList ID="ddlUniversity" Width="308px" runat="server" AutoPostBack="True"
                                                                            onblur="javascript:DropDown('ContentPlaceHolder1_ddlUniversity')" CssClass="DropdwonMid"
                                                                            onchange="ddlChkSelect('ST');" OnSelectedIndexChanged="ddlUniversity0_SelectedIndexChanged">
                                                                        </asp:DropDownList>
                                                                        <span id="ContentPlaceHolder1_ddlUniversityL" style="width: 50px; float: none;">
                                                                        </span>
                                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="ddlUniversity"
                                                                            ErrorMessage="It is Required" ValidationGroup="t"></asp:RequiredFieldValidator>
                                                                        <div id="ST" style="visibility: hidden; height: 24px; width: 24px; float: right;
                                                                            margin-right: 80px; margin-top: -20px">
                                                                            <img alt="Loading..." src="../images/loading.gif" style="width: 22px; height: 22px" />
                                                                        </div>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="blank" colspan="2">
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td>
                                                                        <span style="color: #CC0000">*</span>District
                                                                    </td>
                                                                    <td>
                                                                        <asp:DropDownList ID="ddlDist" Width="308px" runat="server" AutoPostBack="True" onchange="ddlChkSelect('Dist');"
                                                                            onblur="javascript:DropDown('ContentPlaceHolder1_ddlDist')" CssClass="DropdwonMid"
                                                                            OnSelectedIndexChanged="ddlDist_SelectedIndexChanged">
                                                                        </asp:DropDownList>
                                                                        <span id="ContentPlaceHolder1_ddlDistL" style="width: 50px; float: none;"></span>
                                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ddlDist"
                                                                            ErrorMessage="It is Required" ValidationGroup="t"></asp:RequiredFieldValidator>
                                                                        <div id="Dist" style="visibility: hidden; height: 24px; width: 24px; float: right;
                                                                            margin-right: 80px; margin-top: -20px">
                                                                            <img alt="Loading..." src="../images/loading.gif" style="width: 22px; height: 22px" /></div>
                                                                    </td>
                                                                    <td>
                                                                        <span style="color: #CC0000">*</span>Location
                                                                    </td>
                                                                    <td>
                                                                        <asp:DropDownList ID="ddlCity" Width="308px" runat="server" onchange="ddlChkSelect('City');"
                                                                            CssClass="DropdwonMid" AutoPostBack="True" OnSelectedIndexChanged="ddlCity_SelectedIndexChanged">
                                                                        </asp:DropDownList>
                                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="ddlCity"
                                                                            ErrorMessage="It is Required" ValidationGroup="t"></asp:RequiredFieldValidator>
                                                                        <div id="City" style="visibility: hidden; height: 24px; width: 24px; float: right;
                                                                            margin-right: 80px; margin-top: -20px">
                                                                            <img alt="Loading..." src="../images/loading.gif" style="width: 22px; height: 22px" /></div>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="blank" colspan="2">
                                                                    </td>
                                                                </tr>
                                                              
                                                                <tr class="watermark">
                                                                    <td>
                                                                        If Other Location
                                                                    </td>
                                                                    <td>
                                                                        <asp:TextBox ID="txtOtherLocation" Width="300px" runat="server"></asp:TextBox>
                                                                    </td>
                                                                    <td style="vertical-align: middle;">
                                                                        <span style="color: #CC0000">*</span>Address:
                                                                    </td>
                                                                    <td>
                                                                        <asp:TextBox ID="txtaddress" Width="300px" runat="server" Height="70px" TextMode="MultiLine"
                                                                            onblur="javascript:Required('ContentPlaceHolder1_txtaddress')"></asp:TextBox>
                                                                        <span id="ContentPlaceHolder1_txtaddressL" style="width: 50px; float: none;"></span>
                                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtaddress"
                                                                            ErrorMessage="It is Required" ValidationGroup="t"></asp:RequiredFieldValidator>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="blank" colspan="2">
                                                                    </td>
                                                                </tr>
                                                              
                                                                <tr>
                                                                    <td class="blank" colspan="2">
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td>
                                                                        Pin Code
                                                                    </td>
                                                                    <td>
                                                                        <asp:TextBox ID="txtpincode" Width="300px" runat="server" onblur="javascript:Required('ContentPlaceHolder1_txtpincode')"></asp:TextBox>
                                                                        <span id="ContentPlaceHolder1_txtpincodeL" style="width: 50px; float: none;"></span>
                                                                        <cc1:FilteredTextBoxExtender ID="txtpincode_FilteredTextBoxExtender" runat="server"
                                                                            Enabled="True" FilterType="Numbers" TargetControlID="txtpincode">
                                                                        </cc1:FilteredTextBoxExtender>
                                                                        <asp:CompareValidator ID="CompareValidator3" runat="server" ControlToValidate="txtpincode"
                                                                            ErrorMessage="Pin Code Numeric !" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
                                                                    </td>
                                                                    <td>
                                                                        Number
                                                                    </td>
                                                                    <td>
                                                                        <asp:TextBox ID="txtcode" runat="server" TabIndex="6" Width="87px"></asp:TextBox>
                                                                        <cc1:FilteredTextBoxExtender ID="txtcode_FilteredTextBoxExtender" runat="server"
                                                                            Enabled="True" FilterType="Numbers" TargetControlID="txtcode">
                                                                        </cc1:FilteredTextBoxExtender>
                                                                        &nbsp;&nbsp;
                                                                        <asp:TextBox ID="txtnumber" Width="190px" runat="server" TabIndex="7"></asp:TextBox>
                                                                        <cc1:FilteredTextBoxExtender ID="txtnumber_FilteredTextBoxExtender" runat="server"
                                                                            Enabled="True" FilterType="Numbers" TargetControlID="txtnumber">
                                                                        </cc1:FilteredTextBoxExtender>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="blank" colspan="2">
                                                                    </td>
                                                                </tr>
                                                               
                                                                <tr>
                                                                    <td>
                                                                        <span style="color: #CC0000">*</span>Mobile:
                                                                    </td>
                                                                    <td>
                                                                        <asp:TextBox ID="txtmobile" Width="300px" runat="server" onblur="javascript:Mobile('ContentPlaceHolder1_txtmobile')"
                                                                            MaxLength="12"></asp:TextBox>
                                                                        <span id="ContentPlaceHolder1_txtmobileL" style="width: 50px; float: none;"></span>
                                                                        <cc1:FilteredTextBoxExtender ID="txtmobile_FilteredTextBoxExtender" runat="server"
                                                                            Enabled="True" FilterType="Numbers" TargetControlID="txtmobile">
                                                                        </cc1:FilteredTextBoxExtender>
                                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtmobile"
                                                                            ErrorMessage="It is Required" ValidationGroup="t"></asp:RequiredFieldValidator>
                                                                    </td>
                                                                    <td>
                                                                        &nbsp;
                                                                    </td>
                                                                    <td>
                                                                        &nbsp;
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="blank" colspan="2">
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Add-Country" style="text-align: left;">
                                                Academic Details:
                                                <div style="float: left; position: absolute; top: 1275px; left: 920px;">
                                                    <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="updatepanel1">
                                                        <ProgressTemplate>
                                                          
                                                        </ProgressTemplate>
                                                    </asp:UpdateProgress>
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <table style="width: 100%;">
                                                    <tr>
                                                        <td colspan="2" class="blank">
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style="width: 152px; vertical-align: middle;">
                                                            &nbsp;Education Qualification:
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="ShortDescription" runat="server" CssClass="TextBoxBig" TextMode="MultiLine"
                                                                onblur="javascript:Required('ContentPlaceHolder1_ShortDescription')" Height="30px"
                                                                Width="300px"></asp:TextBox>
                                                            <span id="ContentPlaceHolder1_ShortDescriptionL" style="width: 50px; float: none;">
                                                            </span>
                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ControlToValidate="ShortDescription"
                                                                ErrorMessage="Insert Qualification"></asp:RequiredFieldValidator>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2" class="blank watermark" style="padding-left: 200px;">
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            Teaching Style:
                                                        </td>
                                                        <td>
                                                            <asp:DropDownList ID="ddlTutoringStyle" Width="308px" runat="server">
                                                                <asp:ListItem Text="Online Teaching" Value="Online Teaching"></asp:ListItem>
                                                                <asp:ListItem Text="Home Tuition" Value="Home Tuition"></asp:ListItem>
                                                                <asp:ListItem Text="Group Teaching" Value="Group Teaching"></asp:ListItem>
                                                                <asp:ListItem Text="Class Teaching" Value="Class Teaching"></asp:ListItem>
                                                                <asp:ListItem Text="One To One Teaching" Value="One To One Teaching"></asp:ListItem>
                                                                <asp:ListItem Text="Any" Value="Any"></asp:ListItem>
                                                            </asp:DropDownList>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2" class="blank watermark" style="padding-left: 200px;">
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            Best Time To Call:
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="txtBestTimeToCall" Width="300px" runat="server"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2" class="blank watermark" style="padding-left: 200px; width: 300px">
                                                            (like 7 to 10 am, 5 to 9 pm etc)
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Add-Country" style="text-align: left;">
                                                Teaching Details:
                                                <div style="float: left; position: absolute; top: 710px; left: 800px;">
                                                    <asp:UpdateProgress ID="UpdateProgress2" runat="server" AssociatedUpdatePanelID="updatepanel1">
                                                        <ProgressTemplate>
                                                         
                                                        </ProgressTemplate>
                                                    </asp:UpdateProgress>
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <table>
                                                    <tr>
                                                        <td colspan="2" class="blank">
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style="width: 160px;">
                                                            Select Class
                                                        </td>
                                                        <td>
                                                            <asp:DropDownList ID="ddlCourseType" Width="308px" runat="server" AutoPostBack="True"
                                                                onchange="ddlChkSelect('Class');" OnSelectedIndexChanged="ddlCourseType_SelectedIndexChanged"
                                                                CssClass="DropdwonMid">
                                                            </asp:DropDownList>
                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" ControlToValidate="ddlCourseType"
                                                                ErrorMessage="Select Course Type" InitialValue="0"></asp:RequiredFieldValidator>
                                                            <div id="Class" style="visibility: hidden; height: 24px; width: 24px; float: right;
                                                                margin-right: 80px;">
                                                                <img alt="Loading..." src="../images/loading.gif" style="width: 22px; height: 22px" /></div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2" class="blank watermark" style="padding-left: 200px;">
                                                            Major area of Teaching
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            Select Sub Segment:
                                                        </td>
                                                        <td>
                                                            &nbsp;
                                                        </td>
                                                    </tr>
                                                 
                                                    <tr>
                                                        <td colspan="2" style="padding-left: 135px;">
                                                            <asp:CheckBoxList ID="CheckBoxList1" RepeatColumns="2" runat="server">
                                                            </asp:CheckBoxList>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2" class="blank watermark" style="padding-left: 200px;">
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="H1Left">
                                                            Fees
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="txtCourseFees" runat="server" CssClass="TextBoxMid" Width="103px"
                                                                onblur="javascript:Required('ContentPlaceHolder1_txtCourseFees')"></asp:TextBox>
                                                            <span id="ContentPlaceHolder1_txtCourseFeesL" style="width: 50px; float: none;">
                                                            </span>
                                                            <cc1:FilteredTextBoxExtender ID="txtCourseFees_FilteredTextBoxExtender" runat="server"
                                                                Enabled="True" FilterType="Numbers" TargetControlID="txtCourseFees">
                                                            </cc1:FilteredTextBoxExtender>
                                                            &nbsp;
                                                            <asp:DropDownList ID="ddlFeesMode" runat="server" CssClass="DropdwonMid" Width="60px">
                                                                <asp:ListItem>IND</asp:ListItem>
                                                                <asp:ListItem>USD</asp:ListItem>
                                                            </asp:DropDownList>
                                                            &nbsp;
                                                            <asp:DropDownList ID="ddlFeesType" runat="server" CssClass="DropdwonMid" Width="115px">
                                                                <asp:ListItem Text="Per Hour" Value="1"></asp:ListItem>
                                                                <asp:ListItem Text="Monthly" Value="2"></asp:ListItem>
                                                                <asp:ListItem Text="Entire Course" Value="3"></asp:ListItem>
                                                            </asp:DropDownList>
                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" ControlToValidate="txtCourseFees"
                                                                ErrorMessage="Fees Is Required"></asp:RequiredFieldValidator>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2" class="blank">
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="H1Left" style="vertical-align: middle;">
                                                            Tutoring Approach:
                                                        </td>
                                                        <td colspan="3">
                                                            <asp:TextBox ID="LongDescription" runat="server" CssClass="TextBoxBig" TextMode="MultiLine"
                                                                onblur="javascript:Required('ContentPlaceHolder1_LongDescription')" Height="70px"
                                                                Width="328px"></asp:TextBox>
                                                            <span id="ContentPlaceHolder1_LongDescriptionL" style="width: 50px; float: none;">
                                                            </span>
                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ControlToValidate="LongDescription"
                                                                ErrorMessage="Insert Approach"></asp:RequiredFieldValidator>
                                                        </td>
                                                    </tr>
                                                    <tr style="display: none">
                                                        <td colspan="2" class="blank watermark" style="padding-left: 200px; width: 300px">
                                                            Your&nbsp; experience so far in teaching&nbsp;
                                                        </td>
                                                    </tr>
                                                    <tr style="display: none">
                                                        <td>
                                                        </td>
                                                        <td style="line-height: 25px;">
                                                            <asp:CheckBox ID="NNEmail" runat="server" Checked="true" Text="Add me to EDU's mailing list" />
                                                        </td>
                                                    </tr>
                                                    <tr style="display: none">
                                                        <td>
                                                        </td>
                                                        <td style="line-height: 25px;">
                                                            <asp:CheckBox ID="NNEdaily" runat="server" Checked="true" Text="Subscribe EDU's daily newsletter" />
                                                        </td>
                                                    </tr>
                                                    <tr style="display: none">
                                                        <td>
                                                            &nbsp;
                                                        </td>
                                                        <td style="line-height: 25px;">
                                                            <asp:CheckBox ID="NNESMS" Checked="true" runat="server" Text="Subscribe EDU's daily SMS" />
                                                            &nbsp;
                                                        </td>
                                                    </tr>
                                                    <tr style="display: none">
                                                        <td style="height: 25px">
                                                        </td>
                                                        <td style="height: 25px">
                                                            <asp:CheckBox ID="NNeTerm" runat="server" Checked="true" Text="I Agree with" />
                                                            &nbsp;<a href="Term.aspx" target="_blank" style="color: Red;">Terms of Service</a>
                                                            <font color="#ff0000">*</font>
                                                        </td>
                                                    </tr>
                                                    <tr style="display: none">
                                                        <td style="height: 25px">
                                                            <span style="color: #CC0000">*</span>Security Code
                                                        </td>
                                                        <td style="height: 25px">
                                                            <asp:TextBox ID="Veryfycode" runat="server" onblur="javascript:Required('ContentPlaceHolder1_Veryfycode')"></asp:TextBox>
                                                            <span id="ContentPlaceHolder1_VeryfycodeL" style="width: 50px; float: none;"></span>
                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator20" runat="server" ControlToValidate="Veryfycode"
                                                                ErrorMessage="Insert Code"></asp:RequiredFieldValidator>
                                                        </td>
                                                    </tr>
                                                    <tr style="display: none">
                                                        <td>
                                                            &nbsp;
                                                        </td>
                                                        <td>
                                                            <div class="code">
                                                                <asp:Label ID="Label2" runat="server"></asp:Label>
                                                            </div>
                                                            <asp:ImageButton ID="ImageButton1" runat="server" Height="27px" ImageUrl="~/images/referesh.jpg"
                                                                CausesValidation="false" OnClientClick="ddlChkSelect('refresh');" OnClick="ImageButton1_Click"
                                                                Width="27px" />
                                                            <div id="refresh" style="visibility: hidden; height: 24px; width: 24px; float: right;
                                                                margin-right: 240px;">
                                                                <img alt="Loading..." src="../images/loading.gif" style="width: 22px; height: 22px" />
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style="width: 150px;">
                                                            &nbsp;
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
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
            </td>
        </tr>
        <tr>
            <td>
                <table width="100%" style="height: 178px;">
                    <tr>
                        <td>
                            &nbsp; Logo
                        </td>
                        <td>
                            &nbsp;
                        </td>
                        <td style="width: 755px;">
                            <asp:FileUpload ID="logoCollege" runat="server" />
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
                            <asp:Button ID="btnSubmit" runat="server" CssClass="bnt-sbmt" OnClientClick="javascript:Totursubmitdata();"
                                onfocus="javascript:Totursubmitdata();" OnClick="Button1_Click" Text="submit"
                                ValidationGroup="t" />
                        </td>
                        <td>
                            &nbsp;
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
