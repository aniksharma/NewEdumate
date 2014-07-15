<%@ Page Title="" Language="C#" MasterPageFile="~/InstitutePanel/MasterPage2.master" AutoEventWireup="true" CodeFile="UpdateTutorProfile.aspx.cs" Inherits="InstitutePanel_UpdateTutorProfile" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit.HTMLEditor" tagprefix="cc1" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc2" %>
<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:UpdatePanel ID="updatepanel1" runat="server">
        <ContentTemplate>
            <center>
                <table width="830px">
                    <tr>
                        <td>
                            <table cellpadding="0px" cellspacing="0px">
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
                                     
                                                                <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
                                                            
                                     <asp:Label ID="Label1" runat="server" ForeColor="Red" Visible="false" Text="Updated Successfully"></asp:Label>
                                    <td class="insert">

                                        <table width="100%" style="padding-top: 20px;" class="thAlign">
                                                <tr><td colspan="2" class="hdng-topics">Personal Details:
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
                                                                        <td>Name<span style="color: #CC0000">*</span></td>
                                                                        <td>
                                                                            <asp:TextBox ID="txttypename" CssClass="txts-flds" runat="server" onblur="javascript:Required('ContentPlaceHolder1_txttypename')"></asp:TextBox>
                                                                            <span id="ContentPlaceHolder1_txttypenameL" style="width: 50px; float: none;"></span>
                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="txttypename"
                                                                                ErrorMessage="It is Required" ValidationGroup="t"></asp:RequiredFieldValidator>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <th class="blank" colspan="2">
                                                                        </th>
                                                                    </tr>
                                                                    <tr>
                                                                        <td> DOB <span style="color: #CC0000">*</span><td>
                                                                            <asp:TextBox ID="txtAge" runat="server" CssClass="txts-flds"  onblur="javascript:Required('ContentPlaceHolder1_txtAge')"></asp:TextBox>
                                                                            <span id="ContentPlaceHolder1_txtAgeL" style="width: 50px; float: none;"></span>
                                                                            <cc1:CalendarExtender ID="txtAge_CalendarExtender" runat="server" Enabled="True"
                                                                                TargetControlID="txtAge">
                                                                            </cc1:CalendarExtender>
                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" ControlToValidate="txtAge"
                                                                                ErrorMessage="*">*</asp:RequiredFieldValidator>
                                                                            <asp:CompareValidator ID="CompareValidator4" runat="server" ControlToValidate="txtAge"
                                                                                ErrorMessage="Valid Date" Operator="DataTypeCheck" Type="Date" ValidationGroup="t"></asp:CompareValidator>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <th class="blank" colspan="2">
                                                                        </th>
                                                                    </tr>
                                                                    <tr>
                                                                        <td> Gender <span style="color: #CC0000">*</span></td>                                                                        
                                                                        <td>
                                                                            <asp:RadioButtonList ID="RadioButtonList2" runat="server" RepeatDirection="Horizontal"
                                                                                RepeatLayout="Flow">
                                                                                <asp:ListItem Text="Male" Selected="True" Value="1"></asp:ListItem>
                                                                                <asp:ListItem Text="Female" Value="2"></asp:ListItem>
                                                                            </asp:RadioButtonList>
                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator19" runat="server" ControlToValidate="RadioButtonList2"
                                                                                ErrorMessage="*" InitialValue="0" ValidationGroup="t">*</asp:RequiredFieldValidator>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <th class="blank" colspan="2">
                                                                        </th>
                                                                    </tr>
                                                                    <tr>
                                                                        <td style="width: 160px;">
                                                                            Country<span style="color: #CC0000">*</span>
                                                                        </td>
                                                                        <td>
                                                                            <asp:DropDownList ID="ddlCountry" runat="server" AutoPostBack="True" CssClass="txts-drps"
                                                                                onblur="javascript:DropDown('ContentPlaceHolder1_ddlCountry')" 
                                                                                onselectedindexchanged="ddlCountry_SelectedIndexChanged1">
                                                                            </asp:DropDownList>
                                                                            <span id="Span1" style="width: 50px; float: none;"></span>
                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ddlCountry"
                                                                                ErrorMessage="It is Required" ValidationGroup="t"></asp:RequiredFieldValidator>
                                                                            <div id="Div1" style="visibility: hidden; height: 24px; width: 24px; float: right;
                                                                                margin-right: 80px; margin-top: -20px">
                                                                                <img alt="Loading..." src="../images/loading.gif" style="width: 22px;
                                                                                    height: 22px" />
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <th class="blank" colspan="2">
                                                                        </th>
                                                                    </tr>
                                                                    <tr>
                                                                        <td style="width: 160px;">
                                                                            State<span style="color: #CC0000">*</span>
                                                                        </td>
                                                                        <td>
                                                                            <asp:DropDownList ID="ddlUniversity" CssClass="txts-drps" runat="server" AutoPostBack="True"
                                                                                onblur="javascript:DropDown('ContentPlaceHolder1_ddlUniversity')" onchange="ddlChkSelect('ST');" OnSelectedIndexChanged="ddlUniversity0_SelectedIndexChanged">
                                                                            </asp:DropDownList>
                                                                            <span id="ContentPlaceHolder1_ddlUniversityL" style="width: 50px; float: none;">
                                                                            </span>
                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="ddlUniversity"
                                                                                ErrorMessage="It is Required" ValidationGroup="t"></asp:RequiredFieldValidator>
                                                                            <div id="ST" style="visibility: hidden; height: 24px; width: 24px; float: right;
                                                                                margin-right: 80px; margin-top: -20px">
                                                                                <img alt="Loading..." src="../images/loading.gif" style="width: 22px;
                                                                                    height: 22px" />
                                                                            </div>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <th class="blank" colspan="2">
                                                                        </th>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>District
                                                                            <span style="color: #CC0000">*</span>
                                                                        </td>
                                                                        <td>
                                                                            <asp:DropDownList ID="ddlDist" CssClass="txts-drps" runat="server" AutoPostBack="True" onchange="ddlChkSelect('Dist');"
                                                                                onblur="javascript:DropDown('ContentPlaceHolder1_ddlDist')" OnSelectedIndexChanged="ddlDist_SelectedIndexChanged">
                                                                            </asp:DropDownList>
                                                                            <span id="ContentPlaceHolder1_ddlDistL" style="width: 50px; float: none;"></span>
                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ddlDist"
                                                                                ErrorMessage="It is Required" ValidationGroup="t"></asp:RequiredFieldValidator>
                                                                            <div id="Dist" style="visibility: hidden; height: 24px; width: 24px; float: right;
                                                                                margin-right: 80px; margin-top: -20px">
                                                                                <img alt="Loading..." src="../images/loading.gif" style="width: 22px;
                                                                                    height: 22px" /></div>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <th class="blank" colspan="2">
                                                                        </th>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>Location
                                                                            <span style="color: #CC0000">*</span>
                                                                        </td>
                                                                        <td>
                                                                            <asp:DropDownList ID="ddlCity" CssClass="txts-drps" runat="server" onchange="ddlChkSelect('City');"
                                                                                AutoPostBack="True" OnSelectedIndexChanged="ddlCity_SelectedIndexChanged">
                                                                            </asp:DropDownList>
                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="ddlCity"
                                                                                ErrorMessage="It is Required" ValidationGroup="t"></asp:RequiredFieldValidator>
                                                                            <div id="City" style="visibility: hidden; height: 24px; width: 24px; float: right;
                                                                                margin-right: 80px; margin-top: -20px">
                                                                                <img alt="Loading..." src="../images/loading.gif" style="width: 22px;
                                                                                    height: 22px" /></div>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td colspan="2" class="blank watermark" style="padding-left: 200px; width: 300px">
                                                                            &nbsp;
                                                                        </td>
                                                                    </tr>
                                                                    <tr class="watermark">
                                                                        <td>
                                                                            If Other Location
                                                                        </td>
                                                                        <td>
                                                                            <asp:TextBox ID="txtOtherLocation" CssClass="txts-flds" runat="server"></asp:TextBox>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <th class="blank" colspan="2">
                                                                        </th>
                                                                    </tr>
                                                                    <tr>
                                                                        <td style="vertical-align: middle;">Address
                                                                            <span style="color: #CC0000">*</span>
                                                                        </td>
                                                                        <td>
                                                                            <asp:TextBox ID="txtaddress" CssClass="txts-flds" runat="server" Height="70px" TextMode="MultiLine"
                                                                                onblur="javascript:Required('ContentPlaceHolder1_txtaddress')"></asp:TextBox>
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
                                                                            Pin Code
                                                                        </td>
                                                                        <td>
                                                                            <asp:TextBox ID="txtpincode" CssClass="txts-flds" runat="server" onblur="javascript:Required('ContentPlaceHolder1_txtpincode')"></asp:TextBox>
                                                                            <span id="ContentPlaceHolder1_txtpincodeL" style="width: 50px; float: none;"></span>
                                                                            <cc1:FilteredTextBoxExtender ID="txtpincode_FilteredTextBoxExtender" runat="server"
                                                                                Enabled="True" FilterType="Numbers" TargetControlID="txtpincode">
                                                                            </cc1:FilteredTextBoxExtender>
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
                                                                            <asp:TextBox ID="txtcode" runat="server" CssClass="txts-flds" TabIndex="6" Width="87px"></asp:TextBox>
                                                                            <cc1:FilteredTextBoxExtender ID="txtcode_FilteredTextBoxExtender" runat="server"
                                                                                Enabled="True" FilterType="Numbers" TargetControlID="txtcode">
                                                                            </cc1:FilteredTextBoxExtender>
                                                                            &nbsp;&nbsp;
                                                                            <asp:TextBox ID="txtnumber" Width="203px" CssClass="txts-flds" runat="server" TabIndex="7"></asp:TextBox>
                                                                            <cc1:FilteredTextBoxExtender ID="txtnumber_FilteredTextBoxExtender" runat="server"
                                                                                Enabled="True" FilterType="Numbers" TargetControlID="txtnumber">
                                                                            </cc1:FilteredTextBoxExtender>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <th class="blank" colspan="2">
                                                                        </th>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>Mobile
                                                                            <span style="color: #CC0000">*</span>
                                                                        </td>
                                                                        <td>
                                                                            <asp:TextBox ID="txtmobile" CssClass="txts-flds" runat="server" onblur="javascript:Mobile('ContentPlaceHolder1_txtmobile')"
                                                                                MaxLength="12"></asp:TextBox>
                                                                            <span id="ContentPlaceHolder1_txtmobileL" style="width: 50px; float: none;"></span>
                                                                            <cc1:FilteredTextBoxExtender ID="txtmobile_FilteredTextBoxExtender" runat="server"
                                                                                Enabled="True" FilterType="Numbers" TargetControlID="txtmobile">
                                                                            </cc1:FilteredTextBoxExtender>
                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server"  ControlToValidate="txtmobile"
                                                                                ErrorMessage="It is Required" ValidationGroup="t"></asp:RequiredFieldValidator>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <th class="blank" colspan="2">
                                                                        </th>
                                                                    </tr>
                                                                    <tr id="trwebsite" runat="server">
                                <td class="H1Left" style="font-weight: 600;">www.edumateworld.com/</td>
                                <td class="H1Left" colspan="2">
                                     <script type="text/javascript">
                                         var specialKeys = new Array();
                                         specialKeys.push(music); //Backspace
                                         specialKeys.push(9); //Tab
                                         specialKeys.push(46); //Delete
                                         specialKeys.push(36); //Home
                                         specialKeys.push(35); //End
                                         specialKeys.push(37); //Left
                                         specialKeys.push(39); //Right
                                         function IsAlphaNumeric(e) {
                                             var keyCode = e.keyCode == 0 ? e.charCode : e.keyCode;
                                             var ret = ((keyCode >= 48 && keyCode <= 57) || (keyCode >= 65 && keyCode <= 90) || (keyCode >= 97 && keyCode <= 122) || (specialKeys.indexOf(e.keyCode) != -1 && e.charCode != e.keyCode));
                                             document.getElementById("error").style.display = ret ? "none" : "inline";
                                             return ret;
                                         }
    </script>
                                    <asp:TextBox ID="txtsite" Width="298px" runat="server" onkeypress="return IsAlphaNumeric(event);" ondrop="return false;"
        onpaste="return false;"></asp:TextBox>
                                    <span id="error" style="color: Red; display: none">* Special Characters not allowed</span>
                                    <asp:RequiredFieldValidator ControlToValidate="txtsite" 
                            ValidationGroup="t" ID="RequiredFieldValidator1" runat="server" 
                            ErrorMessage="Enter Your WebName" CssClass="validatiom"></asp:RequiredFieldValidator>
                                </td>
                                <td class="H1Left"></td>
                            </tr>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="hdng-topics"style="text-align: left;">
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
                                                            <td style="width: 160px; vertical-align: middle;">
                                                               Education Qualification:
                                                            </td>
                                                            <td>
                                                                <asp:TextBox ID="ShortDescription" runat="server" CssClass="txts-flds" TextMode="MultiLine"
                                                                    onblur="javascript:Required('ContentPlaceHolder1_ShortDescription')" Height="70px"></asp:TextBox>
                                                                <span id="ContentPlaceHolder1_ShortDescriptionL" style="width: 50px; float: none;">
                                                                </span>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ControlToValidate="ShortDescription"
                                                                    ErrorMessage="Insert Qualification" ValidationGroup="t"></asp:RequiredFieldValidator>
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
                                                                <asp:DropDownList ID="ddlTutoringStyle" CssClass="txts-drps" runat="server">
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
                                                            <td>Best Time To Call:</td>
                                                            <td>
                                                                <asp:TextBox ID="txtBestTimeToCall" CssClass="txts-flds" runat="server"></asp:TextBox>
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
                                                <td class="hdng-topics" colspan="2">
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
                                                                <asp:DropDownList ID="ddlCourseType" CssClass="txts-drps" runat="server" AutoPostBack="True"
                                                                    onchange="ddlChkSelect('Class');" OnSelectedIndexChanged="ddlCourseType_SelectedIndexChanged">
                                                                </asp:DropDownList>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" ControlToValidate="ddlCourseType"
                                                                    ErrorMessage="Select Course Type" InitialValue="0" ValidationGroup="t"></asp:RequiredFieldValidator>
                                                                <div id="Class" style="visibility: hidden; height: 24px; width: 24px; float: right;
                                                                    margin-right: 80px;">
                                                                    <img alt="Loading..." src="../images/loading.gif" style="width: 22px;
                                                                        height: 22px" /></div>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="2" class="blank watermark" style="padding-left: 200px;">
                                                                Major area of Teaching
                                                            </td>
                                                        </tr>
                                                        <tr>
<td class="hdng-topics" colspan="2">
                                                                Select Sub Segment</td>
                                                            <td>
                                                                &nbsp;
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="2" class="blank">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <th colspan="2" style="padding-left: 135px;">
                                                                <asp:CheckBoxList ID="CheckBoxList1" RepeatColumns="2" CssClass="blcks-sectn" runat="server">
                                                                </asp:CheckBoxList>
                                                            </th>
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
                                                                <asp:TextBox ID="txtCourseFees" runat="server" CssClass="txts-drps" Width="103px"
                                                                    onblur="javascript:Required('ContentPlaceHolder1_txtCourseFees')"></asp:TextBox>
                                                                <span id="ContentPlaceHolder1_txtCourseFeesL" style="width: 50px; float: none;">
                                                                </span>
                                                                <cc1:FilteredTextBoxExtender ID="txtCourseFees_FilteredTextBoxExtender" runat="server"
                                                                    Enabled="True" FilterType="Numbers" TargetControlID="txtCourseFees">
                                                                </cc1:FilteredTextBoxExtender>
                                                                &nbsp;
                                                                <asp:DropDownList ID="ddlFeesMode" runat="server" CCssClass="txts-drps" Width="60px">
                                                                    <asp:ListItem>IND</asp:ListItem>
                                                                    <asp:ListItem>USD</asp:ListItem>
                                                                </asp:DropDownList>
                                                                &nbsp;
                                                                <asp:DropDownList ID="ddlFeesType" runat="server" CssClass="txts-drps" Width="115px">
                                                                    <asp:ListItem Text="Per Hour" Value="1"></asp:ListItem>
                                                                    <asp:ListItem Text="Monthly" Value="2"></asp:ListItem>
                                                                    <asp:ListItem Text="Entire Course" Value="3"></asp:ListItem>
                                                                </asp:DropDownList>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" ControlToValidate="txtCourseFees"
                                                                    ErrorMessage="Fees Is Required" ValidationGroup="t"></asp:RequiredFieldValidator>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="2" class="blank">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                Tutoring Approach:
                                                            </td>
                                                            <td colspan="3">
                                                                <asp:TextBox ID="LongDescription" runat="server" CssClass="txts-flds"  TextMode="MultiLine"
                                                                    onblur="javascript:Required('ContentPlaceHolder1_LongDescription')" Height="70px"
                                                                    Width="328px"></asp:TextBox>
                                                                <span id="ContentPlaceHolder1_LongDescriptionL" style="width: 50px; float: none;">
                                                                </span>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ControlToValidate="LongDescription"
                                                                    ErrorMessage="Insert Approach" ValidationGroup="t"></asp:RequiredFieldValidator>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="2" class="blank watermark" style="padding-left: 200px; width: 300px">
                                                                Your&nbsp; experience so far in teaching&nbsp;
                                                            </td>
                                                        </tr>      
                                                        <tr>
                                                            <th style="width: 150px;">
                                                            </th>
                                                            <td>
                                                                <asp:Button ID="btnSubmit" runat="server" CssClass="sbmt-btn" OnClientClick="javascript:Totursubmitdata();"
                                                                    onfocus="javascript:Totursubmitdata();" OnClick="Button1_Click" Text="Update"
                                                                    ValidationGroup="t" />
                                                            </td>
                                                        </tr>

                                                         <tr>
                                                            <td colspan="2" class="blank watermark" style="padding-left: 200px; height :20px">
                                                            </td>
                                                        </tr>
                                                         <tr>
                                                            <td colspan="2" class="blank watermark" style="padding-left: 200px;">
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
            </center>
        </ContentTemplate>
    </asp:UpdatePanel>       
</asp:Content>

