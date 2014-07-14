<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage/AdminMaster.master"
    AutoEventWireup="true" CodeFile="AddSchool.aspx.cs" Inherits="Admin_web_AddSchool" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../Css/box.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table width="100%">
        <tr>
            <td>
                <table width="100%">
                    <tr>
                        <td>
                            <asp:UpdatePanel ID="updatepanel1" runat="server">
                                <ContentTemplate>
                                    <table width="100%">
                                        <tr>
                                            <td>
                                                <br />
                                                <asp:LinkButton ID="LinkButton1" runat="server"></asp:LinkButton>
                                                <cc1:ModalPopupExtender ID="LinkButton1_ModalPopupExtender" runat="server" BackgroundCssClass="backcss"
                                                    DynamicServicePath="" Enabled="True" PopupControlID="Error" TargetControlID="LinkButton1">
                                                </cc1:ModalPopupExtender>
                                                <asp:Panel ID="Error" runat="server">
                                                    <div style="background: none repeat scroll 0 0 #525252; padding: 10px; z-index: 100000;
                                                        display: block; width: 400px; left: 278px; top: 456px;">
                                                        <div style="background: none repeat scroll 0 0 #6391CC; padding: 12px 10px;">
                                                            
                                                        </div>
                                                        <div style="background: none repeat scroll 0 0 #FFFFFF; padding: 10px;">
                                                            <div style="background-color: #ffffff; text-align: left;">
                                                                <div>
                                                                    <table width="100%">
                                                                        <tr>
                                                                            <td>
                                                                            </td>
                                                                            <td>
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
                                                                                <asp:Button ID="btOk" runat="server" Text="Ok" PostBackUrl="AddSchool.aspx" CausesValidation="False" />
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
                                                <table width="100%" class="thAlign">
                                                    <tr>
                                                        <td colspan="2" style="text-align: left;" class="Add-Country">
                                                            Login Details
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2">
                                                            <table style="width: 100%;">
                                                                <tr>
                                                                    <td colspan="2" class="blank">
                                                                        &nbsp;
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td style="width: 136px;">
                                                                        <span style="color: #FF0000">*</span>Email ID
                                                                    </td>
                                                                    <td style="width: 315px;">
                                                                        <asp:TextBox ID="txtemail" runat="server" onchange="ddlChkSelect('txt');" OnTextChanged="txtemail_TextChanged"
                                                                            onblur="javascript:Required('ContentPlaceHolder1_txtemail')" AutoPostBack="True"
                                                                            Width="220px"></asp:TextBox>
                                                                        <span id="ContentPlaceHolder1_txtemailL" style="width: 50px; float: none;"></span>
                                                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtemail"
                                                                            ErrorMessage="Only Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtemail"
                                                                            ErrorMessage="*" ValidationGroup="t"></asp:RequiredFieldValidator>
                                                                        <div id="txt" style="visibility: hidden; height: 24px; width: 24px; float: right;
                                                                            margin-right: 141px;">
                                                                            <img alt="Loading..." src="../images/loading.gif" style="width: 22px; height: 22px" />
                                                                        </div>
                                                                    </td>
                                                                    <td style="width: 197px;">
                                                                        Verify Email
                                                                    </td>
                                                                    <td>
                                                                        <asp:TextBox ID="Txtvaryfy" runat="server" Width="220px" onblur="javascript:VaryfyEmail('ContentPlaceHolder1_Txtvaryfy')"></asp:TextBox>
                                                                        <span id="ContentPlaceHolder1_TxtvaryfyL" style="width: 50px; float: none;"></span>
                                                                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtemail"
                                                                            ControlToValidate="Txtvaryfy" ErrorMessage="Confirm E-mail" ValidationGroup="t"></asp:CompareValidator>
                                                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="Txtvaryfy"
                                                                            ErrorMessage="Only Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                                                                    </td>
                                                                </tr>
                                                   
                                                                <tr>
                                                                    <td>
                                                                        <span style="color: #FF0000">*</span>Password
                                                                    </td>
                                                                    <td>
                                                                        <asp:TextBox ID="txtpassword" runat="server" TextMode="Password" Width="220px" onblur="javascript:Password('ContentPlaceHolder1_txtpassword')"></asp:TextBox>
                                                                        <span id="ContentPlaceHolder1_txtpasswordL" style="width: 50px; float: none;"></span>
                                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtpassword"
                                                                            ErrorMessage="It is Required" ValidationGroup="t"></asp:RequiredFieldValidator>
                                                                    </td>
                                                                    <td style="height: 30px">
                                                                        <span style="color: #FF0000">*</span>Verify Password
                                                                    </td>
                                                                    <td style="height: 30px">
                                                                        <asp:TextBox ID="txtpassVaryfy" runat="server" TextMode="Password" Width="220px"
                                                                            onblur="javascript:VaryfyPassword('ContentPlaceHolder1_txtpassVaryfy')"></asp:TextBox>
                                                                        <span id="ContentPlaceHolder1_txtpassVaryfyL" style="width: 50px; float: none;">
                                                                        </span>
                                                                        <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="txtpassword"
                                                                            ControlToValidate="txtpassVaryfy" ErrorMessage="Confirm Pass" ValidationGroup="t"></asp:CompareValidator>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td colspan="2" class="blank">
                                                                    </td>
                                                                </tr>
                                                 
                                                            </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style="text-align: left;" class="Add-Country">
                                                            Organization Details
                                                            <div style="float: left; position: absolute; top: 710px; left: 800px;">
                                                              
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2">
                                                            <table style="width: 100%;">
                                                                <tr>
                                                                    <td colspan="2" class="blank">
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td style="width: 177px;">
                                                                        <span style="color: #FF0000">*</span>School Type
                                                                    </td>
                                                                    <td>
                                                                        <asp:RadioButtonList ID="ddlUniType" runat="server" RepeatDirection="Horizontal"
                                                                            RepeatLayout="Flow">
                                                                            <asp:ListItem Text="Govt" Value="1" Selected="True"></asp:ListItem>
                                                                            <asp:ListItem Text="Private" Value="2"></asp:ListItem>
                                                                            <asp:ListItem Text="Semi-Govt" Value="3"></asp:ListItem>
                                                                        </asp:RadioButtonList>
                                                                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" Visible="false"
                                                                            RepeatDirection="Horizontal" RepeatLayout="Flow">
                                                                          
                                                                            <asp:ListItem Value="3" Selected="True">School</asp:ListItem>
                                                                            
                                                                        </asp:RadioButtonList>
                                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="RadioButtonList1"
                                                                            ErrorMessage="Select Organization Detail !"></asp:RequiredFieldValidator>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td colspan="2">
                                                                        <table width="100%">
                                                                            <tr>
                                                                                <td colspan="2" class="blank">
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td>
                                                                                    <span style="color: #FF0000">*</span>school
                                                                                </td>
                                                                                <td>
                                                                                    <asp:TextBox ID="txttypename" runat="server" Width="220px" onblur="javascript:Required('ContentPlaceHolder1_txttypename')"></asp:TextBox>
                                                                                    <span id="ContentPlaceHolder1_txttypenameL" style="width: 50px; float: none;"></span>
                                                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="txttypename"
                                                                                        ErrorMessage="It is Required"></asp:RequiredFieldValidator>
                                                                                </td>
                                                                                <td>
                                                                                    &nbsp;
                                                                                </td>
                                                                                <td>
                                                                                    &nbsp
                                                                                </td>
                                                                            </tr>
                                                                           
                                                                            <tr>
                                                                                <td style="width: 175px;">
                                                                                    <span style="color: #FF0000">*</span>School Category
                                                                                </td>
                                                                                <td>
                                                                                  
                                                                                    <asp:DropDownList ID="ddlCategory" runat="server" AutoPostBack="True" CssClass="DropdwonMid"
                                                                                        Width="230px" OnSelectedIndexChanged="ddlCategory_SelectedIndexChanged">
                                                                                    </asp:DropDownList>
                                                                                    <span id="Span2" style="width: 50px; float: none;"></span>
                                                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="ddlCategory"
                                                                                        ErrorMessage="It is Required" ValidationGroup="t"></asp:RequiredFieldValidator>
                                                                                    <div id="Div2" style="visibility: hidden; height: 24px; width: 24px; float: right;
                                                                                        margin-right: 65px; margin-top: -24px;">
                                                                                        <img alt="Loading..." src="../images/loading.gif" style="width: 22px; height: 22px" />
                                                                                    </div>
                                                                                </td>
                                                                                <td style="width: 175px;">
                                                                                    <span style="color: #FF0000">*</span>School Sub Category
                                                                                </td>
                                                                                <td>
                                                                                    <asp:DropDownList ID="ddlSubCategory" runat="server" AutoPostBack="True" onblur="javascript:DropDown('ContentPlaceHolder1_ddlUniversity')"
                                                                                        CssClass="DropdwonMid" Width="230px" Onchange="ddlChkSelect('State');">
                                                                                    </asp:DropDownList>
                                                                                    <span id="Span3" style="width: 50px; float: none;"></span>
                                                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="ddlSubCategory"
                                                                                        ErrorMessage="It is Required" ValidationGroup="t"></asp:RequiredFieldValidator>
                                                                                    <div id="Div3" style="visibility: hidden; height: 24px; width: 24px; float: right;
                                                                                        margin-right: 65px; margin-top: -24px;">
                                                                                        <img alt="Loading..." src="../images/loading.gif" style="width: 22px; height: 22px" />
                                                                                    </div>
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td style="width: 175px;">
                                                                                    <span style="color: #FF0000">*</span>Country
                                                                                </td>
                                                                                <td>
                                                                                 
                                                                                    <asp:DropDownList ID="ddlCountry" runat="server" AutoPostBack="True" CssClass="DropdwonMid"
                                                                                        Width="230px" OnSelectedIndexChanged="ddlCountry_SelectedIndexChanged">
                                                                                    </asp:DropDownList>
                                                                                    <span id="Span1" style="width: 50px; float: none;"></span>
                                                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ddlCountry"
                                                                                        ErrorMessage="It is Required" ValidationGroup="t"></asp:RequiredFieldValidator>
                                                                                    <div id="Div1" style="visibility: hidden; height: 24px; width: 24px; float: right;
                                                                                        margin-right: 65px; margin-top: -24px;">
                                                                                        <img alt="Loading..." src="../images/loading.gif" style="width: 22px; height: 22px" />
                                                                                    </div>
                                                                                </td>
                                                                                <td style="width: 175px;">
                                                                                    <span style="color: #FF0000">*</span>State
                                                                                </td>
                                                                                <td>
                                                                                    <asp:DropDownList ID="ddlUniversity" runat="server" AutoPostBack="True" onblur="javascript:DropDown('ContentPlaceHolder1_ddlUniversity')"
                                                                                        CssClass="DropdwonMid" Width="230px" Onchange="ddlChkSelect('State');" OnSelectedIndexChanged="ddlUniversity0_SelectedIndexChanged">
                                                                                    </asp:DropDownList>
                                                                                    <span id="ContentPlaceHolder1_ddlUniversityL" style="width: 50px; float: none;">
                                                                                    </span>
                                                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="ddlUniversity"
                                                                                        ErrorMessage="It is Required" ValidationGroup="t"></asp:RequiredFieldValidator>
                                                                                    <div id="State" style="visibility: hidden; height: 24px; width: 24px; float: right;
                                                                                        margin-right: 65px; margin-top: -24px;">
                                                                                        <img alt="Loading..." src="../images/loading.gif" style="width: 22px; height: 22px" />
                                                                                    </div>
                                                                                </td>
                                                                            </tr>
                                                                           
                                                                            <tr>
                                                                                <td>
                                                                                    <span style="color: #FF0000">*</span>District
                                                                                </td>
                                                                                <td>
                                                                                    <asp:DropDownList ID="ddlDist" runat="server" AutoPostBack="True" onblur="javascript:DropDown('ContentPlaceHolder1_ddlDist')"
                                                                                        CssClass="DropdwonMid" Width="230px" OnSelectedIndexChanged="ddlDist_SelectedIndexChanged"
                                                                                        Onchange="ddlChkSelect('Dist');">
                                                                                    </asp:DropDownList>
                                                                                    <span id="ContentPlaceHolder1_ddlDistL" style="width: 50px; float: none;"></span>
                                                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ddlDist"
                                                                                        ErrorMessage="It is Required" ValidationGroup="t"></asp:RequiredFieldValidator>
                                                                                    <div id="Dist" style="visibility: hidden; height: 24px; width: 24px; float: right;
                                                                                        margin-right: 65px; margin-top: -24px;">
                                                                                        <img alt="Loading..." src="../images/loading.gif" style="width: 22px; height: 22px" />
                                                                                    </div>
                                                                                </td>
                                                                                <td>
                                                                                    <span style="color: #FF0000">*</span>Location
                                                                                </td>
                                                                                <td>
                                                                                    <asp:DropDownList ID="ddlCity" Width="230px" runat="server" onchange="ddlChkSelect('City');"
                                                                                        onblur="javascript:DropDown('ContentPlaceHolder1_ddlCity')" CssClass="DropdwonMid"
                                                                                        AutoPostBack="True" OnSelectedIndexChanged="ddlCity_SelectedIndexChanged">
                                                                                    </asp:DropDownList>
                                                                                    <span id="ContentPlaceHolder1_ddlCityL" style="width: 50px; float: none;"></span>
                                                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="ddlCity"
                                                                                        ErrorMessage="It is Required" ValidationGroup="t"></asp:RequiredFieldValidator>
                                                                                    <div id="City" style="visibility: hidden; height: 24px; width: 24px; float: right;
                                                                                        margin-right: 80px; margin-top: -20px">
                                                                                        <img alt="Loading..." src="../images/loading.gif" style="width: 22px; height: 22px" /></div>
                                                                                </td>
                                                                            </tr>
                                                                           
                                                                            <tr class="watermark">
                                                                                <td>
                                                                                    If Other Location
                                                                                </td>
                                                                                <td>
                                                                                    <asp:TextBox ID="txtOtherLocation" Width="220px" runat="server"></asp:TextBox>
                                                                                </td>
                                                                                <td>
                                                                                    <span style="color: #FF0000">*</span>Pin Code
                                                                                </td>
                                                                                <td>
                                                                                    <asp:TextBox ID="txtpincode" runat="server" Width="220px" onblur="javascript:Required('ContentPlaceHolder1_txtpincode')"></asp:TextBox>
                                                                                    <span id="ContentPlaceHolder1_txtpincodeL" style="width: 50px; float: none;"></span>
                                                                                    <cc1:FilteredTextBoxExtender ID="txtpincode_FilteredTextBoxExtender" runat="server"
                                                                                        Enabled="True" FilterType="Numbers" TargetControlID="txtpincode">
                                                                                    </cc1:FilteredTextBoxExtender>
                                                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtpincode"
                                                                                        ErrorMessage="It is Required" ValidationGroup="t"></asp:RequiredFieldValidator>
                                                                                    <asp:CompareValidator ID="CompareValidator3" runat="server" ControlToValidate="txtpincode"
                                                                                        ErrorMessage="Pin Code Numeric !" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
                                                                                </td>
                                                                            </tr>
                                                                          
                                                                            <tr>
                                                                                <td>
                                                                                    <span style="color: #FF0000">*</span>Address:
                                                                                </td>
                                                                                <td>
                                                                                    <asp:TextBox ID="txtaddress" Height="70px" runat="server" TextMode="MultiLine" Width="220px"
                                                                                        onblur="javascript:Required('ContentPlaceHolder1_txtaddress')"></asp:TextBox>
                                                                                    <span id="ContentPlaceHolder1_txtaddressL" style="width: 50px; float: none;"></span>
                                                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtaddress"
                                                                                        ErrorMessage="It is Required" ValidationGroup="t"></asp:RequiredFieldValidator>
                                                                                </td>
                                                                                <td>
                                                                                    &nbsp;Phone Number
                                                                                </td>
                                                                                <td>
                                                                                    <asp:TextBox ID="txtcode" runat="server" Width="50px" TabIndex="6" MaxLength="7"></asp:TextBox>
                                                                                    <cc1:FilteredTextBoxExtender ID="txtcode_FilteredTextBoxExtender" runat="server"
                                                                                        Enabled="True" FilterType="Numbers" TargetControlID="txtcode">
                                                                                    </cc1:FilteredTextBoxExtender>
                                                                                    &nbsp;&nbsp;
                                                                                    <asp:TextBox ID="txtnumber" runat="server" TabIndex="7" Width="150px"></asp:TextBox>
                                                                                    <cc1:FilteredTextBoxExtender ID="txtnumber_FilteredTextBoxExtender" runat="server"
                                                                                        Enabled="True" FilterType="Numbers" TargetControlID="txtnumber">
                                                                                    </cc1:FilteredTextBoxExtender>
                                                                                </td>
                                                                            </tr>
                                                                           
                                                                   
                                                                            <tr>
                                                                                <td>
                                                                                    &nbsp;Fax
                                                                                </td>
                                                                                <td>
                                                                                    <asp:TextBox ID="txtfax" runat="server" Width="220px"></asp:TextBox>
                                                                                </td>
                                                                                <td>
                                                                                    <span style="color: #FF0000">*</span>Mobile:
                                                                                </td>
                                                                                <td>
                                                                                    <asp:TextBox ID="txtmobile" runat="server" Width="220px" onblur="javascript:Mobile('ContentPlaceHolder1_txtmobile')"
                                                                                        MaxLength="12"></asp:TextBox>
                                                                                    <span id="ContentPlaceHolder1_txtmobileL" style="width: 50px; float: none;"></span>
                                                                                    <cc1:FilteredTextBoxExtender ID="txtmobile_FilteredTextBoxExtender" runat="server"
                                                                                        Enabled="True" FilterType="Numbers" TargetControlID="txtmobile">
                                                                                    </cc1:FilteredTextBoxExtender>
                                                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtmobile"
                                                                                        ErrorMessage="It is Required" ValidationGroup="t"></asp:RequiredFieldValidator>
                                                                                </td>
                                                                            </tr>
                                                               
                                                                            
                                                                            <tr style="display: none;">
                                                                                <td>
                                                                                </td>
                                                                                <td style="line-height: 25px;">
                                                                                    <asp:CheckBox ID="NNEmail" runat="server" Checked="true" Text="Add me to EDU's mailing list" />
                                                                                </td>
                                                                            </tr>
                                                                            <tr style="display: none;">
                                                                                <td>
                                                                                </td>
                                                                                <td style="line-height: 25px;">
                                                                                    <asp:CheckBox ID="NNEdaily" Checked="true" runat="server" Text="Subscribe EDU's daily newsletter" />
                                                                                </td>
                                                                            </tr>
                                                                            <tr style="display: none;">
                                                                                <td>
                                                                                    &nbsp;
                                                                                </td>
                                                                                <td style="line-height: 25px;">
                                                                                    <asp:CheckBox ID="NNESMS" runat="server" Checked="true" Text="Subscribe EDU's daily SMS" />
                                                                                    &nbsp;
                                                                                </td>
                                                                            </tr>
                                                                            <tr style="display: none;">
                                                                                <td style="height: 25px">
                                                                                </td>
                                                                                <td style="height: 25px">
                                                                                    <asp:CheckBox ID="NNeTerm" Checked="true" runat="server" Text="I Agree with" />
                                                                                    &nbsp;<a href="Term.aspx" target="_blank" style="color: Red;">Terms of Service</a>
                                                                                    <font color="#ff0000">*</font>
                                                                                </td>
                                                                            </tr>
                                                                            <tr style="display: none;">
                                                                                <td>
                                                                                    Security code
                                                                                </td>
                                                                                <td>
                                                                                    <asp:TextBox ID="Veryfycode" runat="server" Width="200px" onblur="javascript:Required('ContentPlaceHolder1_Veryfycode')"></asp:TextBox>
                                                                                    <span id="ContentPlaceHolder1_VeryfycodeL" style="width: 50px; float: none;"></span>
                                                                                </td>
                                                                            </tr>
                                                                            <tr style="display: none;">
                                                                                <td colspan="2" class="blank">
                                                                                </td>
                                                                            </tr>
                                                                            <tr style="display: none;">
                                                                                <td>
                                                                                </td>
                                                                                <td>
                                                                                    <div class="code">
                                                                                        <asp:Label ID="Label2" runat="server" CssClass="lab"></asp:Label>
                                                                                    </div>
                                                                                    <asp:ImageButton ID="ImageButton1" runat="server" Height="27px" ImageUrl="../images/referesh.jpg"
                                                                                        CausesValidation="false" OnClientClick="ddlChkSelect('refresh');" OnClick="ImageButton1_Click"
                                                                                        Width="27px" />
                                                                                    <div id="refresh" style="visibility: hidden; height: 24px; width: 24px; float: right;
                                                                                        margin-right: 180px;">
                                                                                        <img alt="Loading..." src="../images/loading.gif" style="width: 22px; height: 22px" />
                                                                                    </div>
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td>
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
                                            </td>
                                        </tr>
                                    </table>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <table width="100%">
                    <tr>
                        <td>
                            &nbsp;  Logo
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
                         <asp:Button ID="btnSubmit" runat="server" style="width: 134px; height: 40px;" Text="Submit" OnClick="Button1_Click" CssClass="orange-button"
                                OnClientClick="javascript:submitdata();" onfocus="javascript:submitdata();" ValidationGroup="t" />
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
