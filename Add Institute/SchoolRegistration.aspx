<%@ Page Title="" Language="C#" MasterPageFile="~/Add Institute/MasterPage.master"
    AutoEventWireup="true" CodeFile="SchoolRegistration.aspx.cs" Inherits="Add_Institute_SchoolRegistration" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:UpdatePanel ID="updatepanel1" runat="server">
        <ContentTemplate>
            <center>
                <table>
                    <tr>
                        <td class="hdng-topics" style="text-align: left;">
                            School Registration
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <table cellpadding="0px" cellspacing="0px">
                                <tr>
                                    <td style="width: auto; height: 32px; float: left; font-family: Arial, Helvetica, sans-serif;
                                        color: #333333; padding: 30px; font-weight: normal; font-size: 14px; text-decoration: none;">
                                        <span lang="EN-IN" style="font-size: 10.5pt; line-height: 115%; font-family: '
                                            sans-serif', 'color: #333333';">Welcome, Kindly fill the form below with all accurate
                                            information about your College and then click the submit button below.<![if !supportLineBreakNewLine]><br />
                                            <![endif]></span><br>
                                        If you have already registered with us. Please <b></b>
                                    </td>
                                </tr>
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
                                                                        <asp:Button ID="btOk" runat="server" Text="Ok" PostBackUrl="../Default.aspx" CausesValidation="False" />
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
                                                <td colspan="2" style="text-align: left;" class="hdng-topics">
                                                    School Login Details
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
                                                            <td style="width: 187px;">
                                                                Email ID <span style="color: #FF0000">*</span>
                                                            </td>
                                                            <td>
                                                                <asp:TextBox ID="txtemail" runat="server" onchange="ddlChkSelect('txt');" OnTextChanged="txtemail_TextChanged"
                                                                    onblur="javascript:Email('ContentPlaceHolder1_txtemail')" AutoPostBack="True"
                                                                    CssClass="txts-flds"></asp:TextBox>
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
                                                        </tr>
                                                        <tr>
                                                            <td colspan="2" class="blank">
                                                                &nbsp;
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                Verify Email
                                                            </td>
                                                            <td>
                                                                <asp:TextBox ID="Txtvaryfy" runat="server" onblur="javascript:VaryfyEmail('ContentPlaceHolder1_Txtvaryfy')"
                                                                    CssClass="txts-flds"></asp:TextBox>
                                                                <span id="ContentPlaceHolder1_TxtvaryfyL" style="width: 50px; float: none;"></span>
                                                                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtemail"
                                                                    ControlToValidate="Txtvaryfy" ErrorMessage="Confirm E-mail" ValidationGroup="t"></asp:CompareValidator>
                                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="Txtvaryfy"
                                                                    ErrorMessage="Only Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="2" class="blank">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                Password <span style="color: #FF0000">*</span>
                                                            </td>
                                                            <td>
                                                                <asp:TextBox ID="txtpassword" runat="server" TextMode="Password" onblur="javascript:Password('ContentPlaceHolder1_txtpassword')"
                                                                    CssClass="txts-flds"></asp:TextBox>
                                                                <span id="ContentPlaceHolder1_txtpasswordL" style="width: 50px; float: none;"></span>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtpassword"
                                                                    ErrorMessage="It is Required" ValidationGroup="t"></asp:RequiredFieldValidator>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="2" class="blank">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td style="height: 30px">
                                                                Verify Password <span style="color: #FF0000">*</span>
                                                            </td>
                                                            <td style="height: 30px">
                                                                <asp:TextBox ID="txtpassVaryfy" runat="server" TextMode="Password" CssClass="txts-flds"
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
                                                <td style="text-align: left;" class="hdng-topics">
                                                    School Details
                                                    <div style="float: left; position: absolute; top: 710px; left: 800px;">
                                                        <asp:UpdateProgress ID="progressPinChecker" runat="server" AssociatedUpdatePanelID="updatepanel1">
                                                            <ProgressTemplate>
                                                            
                                                            </ProgressTemplate>
                                                        </asp:UpdateProgress>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2">
                                                    <table style="width: 100%;">
                                                       
                                                        <tr>
                                                            <td colspan="2">
                                                                <table width="100%">
                                                                    <tr>
                                                                        <th class="blank" colspan="2">
                                                                        </th>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            School Name <span style="color: #FF0000">*</span>
                                                                        </td>
                                                                        <td>
                                                                            <asp:TextBox ID="txttypename" runat="server" CssClass="txts-flds" onblur="javascript:Required('ContentPlaceHolder1_txttypename')"></asp:TextBox>
                                                                            <span id="ContentPlaceHolder1_txttypenameL" style="width: 50px; float: none;"></span>
                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="txttypename"
                                                                                ErrorMessage="It is Required"></asp:RequiredFieldValidator>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <th class="blank" colspan="2">
                                                                        </th>
                                                                    </tr>
                                                                    <tr>
                                                                        <td style="width: 175px;">
                                                                            Country <span style="color: #FF0000">*</span>
                                                                        </td>
                                                                        <td>
                                                                            <asp:DropDownList ID="ddlCountry" runat="server" AutoPostBack="True" CssClass="txts-drps"
                                                                                onblur="javascript:DropDown('ContentPlaceHolder1_ddlCountry')" OnSelectedIndexChanged="ddlCountry_SelectedIndexChanged">
                                                                            </asp:DropDownList>
                                                                            <span id="Span1" style="width: 50px; float: none;"></span>
                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ddlCountry"
                                                                                ErrorMessage="It is Required" ValidationGroup="t"></asp:RequiredFieldValidator>
                                                                            <div id="Div1" style="visibility: hidden; height: 24px; width: 24px; float: right;
                                                                                margin-right: 65px; margin-top: -24px;">
                                                                                <img alt="Loading..." src="../images/loading.gif" style="width: 22px; height: 22px" />
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td style="width: 175px;">
                                                                            State <span style="color: #FF0000">*</span>
                                                                        </td>
                                                                        <td>
                                                                            <asp:DropDownList ID="ddlUniversity" runat="server" AutoPostBack="True" CssClass="txts-drps"
                                                                                onblur="javascript:DropDown('ContentPlaceHolder1_ddlUniversity')" Onchange="ddlChkSelect('State');"
                                                                                OnSelectedIndexChanged="ddlUniversity0_SelectedIndexChanged">
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
                                                                        <th class="blank" colspan="2">
                                                                        </th>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            District <span style="color: #FF0000">*</span>
                                                                        </td>
                                                                        <td>
                                                                            <asp:DropDownList ID="ddlDist" runat="server" AutoPostBack="True" CssClass="txts-drps"
                                                                                onblur="javascript:DropDown('ContentPlaceHolder1_ddlDist')" Onchange="ddlChkSelect('Dist');"
                                                                                OnSelectedIndexChanged="ddlDist_SelectedIndexChanged">
                                                                            </asp:DropDownList>
                                                                            <span id="ContentPlaceHolder1_ddlDistL" style="width: 50px; float: none;"></span>
                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ddlDist"
                                                                                ErrorMessage="It is Required" ValidationGroup="t"></asp:RequiredFieldValidator>
                                                                            <div id="Dist" style="visibility: hidden; height: 24px; width: 24px; float: right;
                                                                                margin-right: 65px; margin-top: -24px;">
                                                                                <img alt="Loading..." src="../images/loading.gif" style="width: 22px; height: 22px" />
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <th class="blank" colspan="2">
                                                                        </th>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            Location <span style="color: #FF0000">*</span>
                                                                        </td>
                                                                        <td>
                                                                            <asp:DropDownList ID="ddlCity" runat="server" AutoPostBack="True" CssClass="txts-drps"
                                                                                onblur="javascript:DropDown('ContentPlaceHolder1_ddlCity')" onchange="ddlChkSelect('City');"
                                                                                OnSelectedIndexChanged="ddlCity_SelectedIndexChanged">
                                                                            </asp:DropDownList>
                                                                            <span id="ContentPlaceHolder1_ddlCityL" style="width: 50px; float: none;"></span>
                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="ddlCity"
                                                                                ErrorMessage="It is Required" ValidationGroup="t"></asp:RequiredFieldValidator>
                                                                            <div id="City" style="visibility: hidden; height: 24px; width: 24px; float: right;
                                                                                margin-right: 80px; margin-top: -20px">
                                                                                <img alt="Loading..." src="../images/loading.gif" style="width: 22px; height: 22px" />
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td class="blank watermark" colspan="2" style="padding-left: 200px; width: 300px">
                                                                            &nbsp;
                                                                        </td>
                                                                    </tr>
                                                                    <tr class="watermark">
                                                                        <td>
                                                                            If Other Location
                                                                        </td>
                                                                        <td>
                                                                            <asp:TextBox ID="txtOtherLocation" runat="server" CssClass="txts-flds"></asp:TextBox>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <th class="blank" colspan="2">
                                                                        </th>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            Address <span style="color: #FF0000">*</span>
                                                                        </td>
                                                                        <td>
                                                                            <asp:TextBox ID="txtaddress" runat="server" CssClass="txts-flds" Height="70px" onblur="javascript:Required('ContentPlaceHolder1_txtaddress')"
                                                                                TextMode="MultiLine"></asp:TextBox>
                                                                            <span id="ContentPlaceHolder1_txtaddressL" style="width: 50px; float: none;"></span>
                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtaddress"
                                                                                ErrorMessage="It is Required" ValidationGroup="t"></asp:RequiredFieldValidator>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <th class="blank" colspan="2">
                                                                        </th>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            Pin Code <span style="color: #FF0000">*</span>
                                                                        </td>
                                                                        <td>
                                                                            <asp:TextBox ID="txtpincode" runat="server" CssClass="txts-flds" onblur="javascript:Required('ContentPlaceHolder1_txtpincode')"></asp:TextBox>
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
                                                                        <th class="blank" colspan="2">
                                                                        </th>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            Number
                                                                        </td>
                                                                        <td>
                                                                            <asp:TextBox ID="txtcode" runat="server" CssClass="txt-drps-small" MaxLength="7"
                                                                                TabIndex="6" Width="95px"></asp:TextBox>
                                                                            <cc1:FilteredTextBoxExtender ID="txtcode_FilteredTextBoxExtender" runat="server"
                                                                                Enabled="True" FilterType="Numbers" TargetControlID="txtcode">
                                                                            </cc1:FilteredTextBoxExtender>
                                                                            &nbsp;&nbsp;
                                                                            <asp:TextBox ID="txtnumber" runat="server" CssClass="txt-drps-small" TabIndex="7"
                                                                                Width="193px"></asp:TextBox>
                                                                            <cc1:FilteredTextBoxExtender ID="txtnumber_FilteredTextBoxExtender" runat="server"
                                                                                Enabled="True" FilterType="Numbers" TargetControlID="txtnumber">
                                                                            </cc1:FilteredTextBoxExtender>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <th>
                                                                        </th>
                                                                        <td>
                                                                            &nbsp;
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            Fax
                                                                        </td>
                                                                        <td>
                                                                            <asp:TextBox ID="txtfax" runat="server" CssClass="txts-flds"></asp:TextBox>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <th class="blank" colspan="2">
                                                                        </th>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            Mobile <span style="color: #FF0000">*</span>
                                                                        </td>
                                                                        <td>
                                                                            <asp:TextBox ID="txtmobile" runat="server" CssClass="txts-flds" MaxLength="12" onblur="javascript:Mobile('ContentPlaceHolder1_txtmobile')"></asp:TextBox>
                                                                            <span id="ContentPlaceHolder1_txtmobileL" style="width: 50px; float: none;"></span>
                                                                            <cc1:FilteredTextBoxExtender ID="txtmobile_FilteredTextBoxExtender" runat="server"
                                                                                Enabled="True" FilterType="Numbers" TargetControlID="txtmobile">
                                                                            </cc1:FilteredTextBoxExtender>
                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtmobile"
                                                                                ErrorMessage="It is Required" ValidationGroup="t"></asp:RequiredFieldValidator>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td colspan="2" style="text-align: left;" class="hdng-topics">
                                                                            School Type
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td style="width: 175px;">
                                                                            Course Level <span style="color: #FF0000">*</span>
                                                                        </td>
                                                                        <td>
                                                                            <asp:DropDownList ID="ddlCourseLevel" runat="server" CssClass="txts-drps">
                                                                            </asp:DropDownList>
                                                                         
                                                                            <asp:RequiredFieldValidator ID="rfvddlCategory" runat="server" ControlToValidate="ddlCourseLevel"
                                                                                Display="None" ErrorMessage="Select Course Level !" InitialValue="0"></asp:RequiredFieldValidator>
                                                                            <cc1:ValidatorCalloutExtender ID="ValidatorCalloutExtender2" runat="server" Enabled="True"
                                                                                TargetControlID="rfvddlCategory">
                                                                            </cc1:ValidatorCalloutExtender>
                                                                          
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td style="width: 175px;">
                                                                            School Type <span style="color: #FF0000">*</span>
                                                                        </td>
                                                                        <td>
                                                                            <asp:DropDownList ID="ddlSchoolSubCategory" runat="server" CssClass="txts-drps">
                                                                            </asp:DropDownList>
                                                                            <asp:RequiredFieldValidator ID="rfvSubCategory" runat="server" ControlToValidate="ddlSchoolSubCategory"
                                                                                Display="None" ErrorMessage="Select Sub Category !" InitialValue="0"></asp:RequiredFieldValidator>
                                                                            <cc1:ValidatorCalloutExtender ID="ValidatorCalloutExtender3" runat="server" Enabled="True"
                                                                                TargetControlID="rfvSubCategory">
                                                                            </cc1:ValidatorCalloutExtender>
                                                                          
                                                                        </td>
                                                                    </tr>
                                                              
                                                                    <tr>
                                                                        <td style="width: 175px;">
                                                                            ApprovedBy:<span style="color: #FF0000">*</span>
                                                                        </td>
                                                                        <td>
                                                                            <asp:DropDownList ID="ApprovedBy" runat="server" CssClass="txts-drps">
                                                                            </asp:DropDownList>
                                                                            <span id="Span5" style="width: 50px; float: none;"></span>
                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ControlToValidate="ApprovedBy"
                                                                                ErrorMessage="It is Required" ValidationGroup="t"></asp:RequiredFieldValidator>
                                                                            <div id="Div5" style="visibility: hidden; height: 24px; width: 24px; float: right;
                                                                                margin-right: 65px; margin-top: -24px;">
                                                                                <img alt="Loading..." src="../images/loading.gif" style="width: 22px; height: 22px" />
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                   
                                                                    <tr>
                                                                        <th class="blank" colspan="2">
                                                                        </th>
                                                                    </tr>
                                                                    <tr>
                                                                        <th>
                                                                        </th>
                                                                        <td style="line-height: 25px; width: 250px; float: left;">
                                                                            <asp:CheckBox ID="NNEmail" runat="server" CssClass="lbl-reg" Text="Add me to EDU's mailing list" />
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <th>
                                                                        </th>
                                                                        <td style="line-height: 25px; width: 250px; float: left;">
                                                                            <asp:CheckBox ID="NNEdaily" runat="server" Style="width: 214px !important; float: left;"
                                                                                Text="Subscribe EDU's daily newsletter" />
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <th>
                                                                            &nbsp;
                                                                        </th>
                                                                        <td style="line-height: 25px;">
                                                                            <asp:CheckBox ID="NNESMS" runat="server" Text="Subscribe EDU's daily SMS" />
                                                                            &nbsp;
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <th style="height: 25px">
                                                                        </th>
                                                                        <td style="height: 25px">
                                                                            <asp:CheckBox ID="NNeTerm" runat="server" Text="I Agree with" />
                                                                            &nbsp;<a href="Term.aspx" style="color: Red;" target="_blank">Terms of Service</a>
                                                                            <font color="#ff0000">*</font>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            Security code
                                                                        </td>
                                                                        <td>
                                                                            <asp:TextBox ID="Veryfycode" runat="server" class="txts-flds" onblur="javascript:Required('ContentPlaceHolder1_Veryfycode')"></asp:TextBox>
                                                                            <span id="ContentPlaceHolder1_VeryfycodeL" style="width: 50px; float: none;"></span>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <th class="blank" colspan="2">
                                                                        </th>
                                                                    </tr>
                                                                    <tr>
                                                                        <th>
                                                                        </th>
                                                                        <th>
                                                                            <div class="code">
                                                                                <asp:Label ID="Label2" runat="server" CssClass="lab"></asp:Label>
                                                                            </div>
                                                                            <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="false" ImageUrl="images/referesh.jpg"
                                                                                OnClick="ImageButton1_Click" OnClientClick="ddlChkSelect('refresh');" Style="height: 31px;
                                                                                width: 34px;" />
                                                                            <div id="refresh" style="visibility: hidden; height: 24px; width: 24px; float: right;
                                                                                margin-right: 468px;">
                                                                                <img alt="Loading..." src="../images/loading.gif" style="width: 22px; height: 22px" />
                                                                            </div>
                                                                        </th>
                                                                    </tr>
                                                                    <tr>
                                                                        <th>
                                                                        </th>
                                                                        <td>
                                                                            <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <th>
                                                                        </th>
                                                                        <td>
                                                                            <asp:Button ID="btnSubmit" runat="server" CssClass="sbmt-btn" OnClick="Button1_Click"
                                                                                OnClientClick="javascript:submitdata();" onfocus="javascript:submitdata();" Text="Submit"
                                                                                ValidationGroup="t" />
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <th>
                                                            </th>
                                                            <td>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <th>
                                                            </th>
                                                            <td>
                                                            </td>
                                                        </tr>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </center>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
