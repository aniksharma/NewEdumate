<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage/AdminMaster.master" AutoEventWireup="true" CodeFile="InstituteListing.aspx.cs" Inherits="Admin_web_InstituteListing" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .style1
        {
            height: 18px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:UpdatePanel ID="updatepanel1" runat="server">
        <ContentTemplate>
            <table width="100%">
                <tr>
                    <td class="Add-Country">
                   <%--Edu Type--%>
                       Institute Info
                    </td>
                </tr>
                <tr>
                    <td class="H1Center">
                        <asp:Label ID="lblMsg" runat="server" CssClass="labelMsgRed"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <table width="100%">
                            <tr>
                                <td class="H1Center">
                                    <asp:UpdateProgress ID="progressPinChecker" runat="server" AssociatedUpdatePanelID="updatepanel1">
                                        <ProgressTemplate>
                                            &nbsp;
                                        </ProgressTemplate>
                                    </asp:UpdateProgress>
                                </td>
                            </tr>
                        </table>
                        <table style="width: 100%;" class="minHeight">
                            <tr>
                                <td>
                                    <asp:Button ID="btnAddNewEmployee" CausesValidation="false" runat="server" Style="width: 140px;"
                                        CssClass="bnt-sbmt" OnClick="btnAddNewEmployee_Click" Text="Add Institute" />
                                    &nbsp;&nbsp;&nbsp;&nbsp;<a href="importInstitute.aspx">Import Institute</a>
                                </td>
                            </tr>
                            <tr>
                                <td class="H1Center">
                                    <table style="width: 100%">
                                        <tr>
                                          
                                            <td style="width: 100%">
                                                <div id="EmployeeDiv" visible="false" runat="server">
                                                    <table width="100%">
                                                        <tr>
                                                            <td>
                                                                <table class="BoxFourRound">
                                                                  
                                                                    <tr>
                                                                        <td class="H3Center">
                                                                            <table>

                                                                            <tr> 
                                                                            <td>&nbsp;&nbsp;&nbsp;Ownership:</td>
                                                                             <td>
                                                                                        <asp:RadioButtonList ID="ddlUniType" runat="server" RepeatDirection="Horizontal"
                                                                                            RepeatLayout="Flow">
                                                                                            <asp:ListItem Text="Govt" Value="1"></asp:ListItem>
                                                                                            <asp:ListItem Text="Private" Value="2" Selected="True"></asp:ListItem>
                                                                                            <asp:ListItem Text="Semi-Govt" Value="3"></asp:ListItem>
                                                                                        </asp:RadioButtonList>
                                                                                    </td>
                                                                            
                                                                            </tr>

                                                                            </table>
                                                                        </td>
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
                                                                                                <td class="H2Left" style="width: 175px;">
                                                                                                    Country:
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                    <asp:DropDownList ID="ddlUniversity0" runat="server" AutoPostBack="True" CssClass="DropdwonMid"
                                                                                                        OnSelectedIndexChanged="ddlUniversity0_SelectedIndexChanged">
                                                                                                    </asp:DropDownList>
                                                                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="ddlUniversity0"
                                                                                                        Display="None" ErrorMessage=" Select University" InitialValue="0"></asp:RequiredFieldValidator>
                                                                                                    <cc1:ValidatorCalloutExtender ID="RequiredFieldValidator2_ValidatorCalloutExtender0"
                                                                                                        runat="server" Enabled="True" TargetControlID="RequiredFieldValidator2">
                                                                                                    </cc1:ValidatorCalloutExtender>
                                                                                                </td>
                                                                                                <td class="H2Left">
                                                                                                    State:
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                    <asp:DropDownList ID="ddlUniversity" runat="server" AutoPostBack="True" CssClass="DropdwonMid"
                                                                                                        OnSelectedIndexChanged="ddlUniversity_SelectedIndexChanged">
                                                                                                    </asp:DropDownList>
                                                                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="ddlUniversity"
                                                                                                        Display="None" ErrorMessage=" Select University" InitialValue="0"></asp:RequiredFieldValidator>
                                                                                                    <cc1:ValidatorCalloutExtender ID="RequiredFieldValidator2_ValidatorCalloutExtender1"
                                                                                                        runat="server" Enabled="True" TargetControlID="RequiredFieldValidator2">
                                                                                                    </cc1:ValidatorCalloutExtender>
                                                                                                </td>
                                                                                                <td class="H2Left">
                                                                                                 
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                  
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr>
                                                                                                <td class="H2Left">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                                <td class="H2Left">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                                <td class="H2Left">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                            </tr>

                                                                                            <tr>
                                                                                                <td class="H2Left">
                                                                                                      District:
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                     <asp:DropDownList ID="ddlDistrict" runat="server" AutoPostBack="True" CssClass="DropdwonMid"
                                                                                                        OnSelectedIndexChanged="ddlDistrict_SelectedIndexChanged">
                                                                                                    </asp:DropDownList>
                                                                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="ddlDistrict"
                                                                                                        Display="None" ErrorMessage="District !" InitialValue="0"></asp:RequiredFieldValidator>
                                                                                                    <cc1:ValidatorCalloutExtender ID="RequiredFieldValidator7_ValidatorCalloutExtender"
                                                                                                        runat="server" Enabled="True" TargetControlID="RequiredFieldValidator7">
                                                                                                    </cc1:ValidatorCalloutExtender>
                                                                                                </td>
                                                                                                <td class="H2Left">
                                                                                                     City:
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                  <asp:DropDownList ID="ddlCity" runat="server" CssClass="DropdwonMid">                                                                                                       
                                                                                                    </asp:DropDownList>
                                                                                                     <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="ddlCity"
                                                                                                        Display="None" ErrorMessage="Select City !" InitialValue="0"></asp:RequiredFieldValidator>
                                                                                                    <cc1:ValidatorCalloutExtender ID="ValidatorCalloutExtender4"
                                                                                                        runat="server" Enabled="True" TargetControlID="RequiredFieldValidator8">
                                                                                                    </cc1:ValidatorCalloutExtender>

                                                                                                </td>
                                                                                                <td class="H2Left">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                            </tr>



                                                                                            <tr>
                                                                                                <td class="H2Left">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                                <td class="H2Left">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                                <td class="H2Left">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                            </tr>

                                                                                            <tr>
                                                                                                <td class="H2Left">
                                                                                                   
                                                                                                    <asp:Label ID="lblCollege" runat="server" Text="Category :"></asp:Label>
                                                                                                  
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                  <asp:DropDownList ID="ddlCategory" runat="server" AutoPostBack="True" CssClass="DropdwonMid"
                                                                                                        OnSelectedIndexChanged="ddlCategory_SelectedIndexChanged">
                                                                                                    </asp:DropDownList>
                                                                                                     <asp:RequiredFieldValidator ID="rfvddlCategory" runat="server" ControlToValidate="ddlCategory"
                                                                                                        Display="None" ErrorMessage="Select Category !" InitialValue="0"></asp:RequiredFieldValidator>
                                                                                                    <cc1:ValidatorCalloutExtender ID="ValidatorCalloutExtender2"
                                                                                                        runat="server" Enabled="True" TargetControlID="rfvddlCategory">
                                                                                                    </cc1:ValidatorCalloutExtender>
                                                                                                </td>
                                                                                                <td class="H2Left">
                                                                                                 
                                                                                                    <asp:Label ID="lblCollegeCategory" runat="server" Text="Sub Category"></asp:Label>:
                                                                                               
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                   <asp:DropDownList ID="ddlSubCategory" runat="server" AutoPostBack="True" CssClass="DropdwonMid">
                                                                                                    </asp:DropDownList>
                                                                                                      <asp:RequiredFieldValidator ID="rfvSubCategory" runat="server" ControlToValidate="ddlSubCategory"
                                                                                                        Display="None" ErrorMessage="Select Sub Category !" InitialValue="0"></asp:RequiredFieldValidator>
                                                                                                    <cc1:ValidatorCalloutExtender ID="ValidatorCalloutExtender3"
                                                                                                        runat="server" Enabled="True" TargetControlID="rfvSubCategory">
                                                                                                    </cc1:ValidatorCalloutExtender>
                                                                                                    
                                                                                                </td>
                                                                                                <td class="H2Left">
                                                                                                &nbsp;
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                    &nbsp;

                                                                                                </td>
                                                                                            </tr>

                                                                                             <tr>
                                                                                                <td class="H2Left">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                                <td class="H2Left">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                                <td class="H2Left">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                            </tr>


                                                                                            <tr>
                                                                                                <td class="H2Left">
                                                                                                   <%--ApprovedBy--%>
                                                                                                   Type:
                                                                                                  
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                <asp:DropDownList ID="ApprovedBy" runat="server" CssClass="DropdwonMid">                                                                                                        
                                                                                                    </asp:DropDownList>
                                                                                                  
                                                                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="ApprovedBy"
                                                                                                        Display="None" ErrorMessage="Select ApprovedBy !" InitialValue="0"></asp:RequiredFieldValidator>
                                                                                                    <cc1:ValidatorCalloutExtender ID="ValidatorCalloutExtender5"
                                                                                                        runat="server" Enabled="True" TargetControlID="RequiredFieldValidator9">
                                                                                                    </cc1:ValidatorCalloutExtender>

                                                                                                </td>
                                                                                             
                                                                                                <td class="H2Left">                                                                                                 
                                                                                                   Course Level</td>
                                                                                           
                                                                                                 <td class="H1Left">                                                                                                   
                                                                                                    <asp:DropDownList ID="ddlCourseLevel" runat="server" CssClass="DropdwonMid">
                                                                                                    </asp:DropDownList>

                                                                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="ddlCourseLevel"
                                                                                                        Display="None" ErrorMessage="Select Course Level !" InitialValue="0"></asp:RequiredFieldValidator>
                                                                                                    <cc1:ValidatorCalloutExtender ID="ValidatorCalloutExtender6"
                                                                                                        runat="server" Enabled="True" TargetControlID="RequiredFieldValidator10">
                                                                                                    </cc1:ValidatorCalloutExtender>

                                                                                                    
                                                                                                </td>
                                                                                                <td class="H2Left">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                 
                                                                                                    
                                                                                                    
                                                                                                </td>
                                                                                            </tr>
                                                                                             <tr>
                                                                                                <td class="style1">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                                <td class="style1">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                                <td class="style1">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                                <td class="style1">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                                <td class="style1">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                                <td class="style1">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                            </tr>
                                                                                            
                                                                                            <tr style="display:none;">
                                                                                                <td class="H2Left">
                                                                                                   Edu_Type:
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                   <asp:DropDownList ID="ddl" runat="server" CssClass="DropdwonMid">
                                                                                                    </asp:DropDownList>
                                                                                                </td>
                                                                                                <td class="H2Left">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                                <td class="H2Left">
                                                                                                 
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                 &nbsp;
                                                                                                </td>
                                                                                            </tr>
                                                                                            
                                                                                            <tr>
                                                                                                <td class="H2Left">
                                                                                                    Name:
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                    <asp:TextBox ID="txtName" runat="server" CssClass="TextBoxMid" MaxLength="100"></asp:TextBox>
                                                                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtName"
                                                                                                        Display="None" ErrorMessage="College Name !" SetFocusOnError="True"></asp:RequiredFieldValidator>
                                                                                                    <cc1:ValidatorCalloutExtender ID="ValidatorCalloutExtender1" runat="server" Enabled="True"
                                                                                                        HighlightCssClass="validation" TargetControlID="RequiredFieldValidator1">
                                                                                                    </cc1:ValidatorCalloutExtender>
                                                                                                </td>
                                                                                                <td class="H2Left">
                                                                                                    Address:
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                    <asp:TextBox ID="txtAddress" runat="server" CssClass="TextBoxMid" MaxLength="100"></asp:TextBox>
                                                                                                </td>
                                                                                                <td class="H2Left">
                                                                                                   
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                    
                                                                                                </td>
                                                                                            </tr>


                                                                                             <tr>
                                                                                                <td class="H2Left">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                                <td class="H2Left">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                                <td class="H2Left">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                            </tr>


                                                                                            <tr>
                                                                                                <td class="H2Left">
                                                                                                    Pin Code:
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                    <asp:TextBox ID="txtBranchCode" runat="server" CssClass="TextBoxMid" MaxLength="100"></asp:TextBox>
                                                                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtBranchCode"
                                                                                                        Display="None" ErrorMessage="Pin Code !" SetFocusOnError="True"></asp:RequiredFieldValidator>
                                                                                                    <cc1:ValidatorCalloutExtender ID="RequiredFieldValidator4_ValidatorCalloutExtender"
                                                                                                        runat="server" Enabled="True" HighlightCssClass="validation" TargetControlID="RequiredFieldValidator4">
                                                                                                    </cc1:ValidatorCalloutExtender>
                                                                                                </td>
                                                                                                <td class="H2Left">
                                                                                                    WebSite:
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                    <asp:TextBox ID="txtWebSite" runat="server" CssClass="TextBoxMid"></asp:TextBox>
                                                                                                </td>
                                                                                                <td class="H2Left">
                                                                                                    
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                   
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr>
                                                                                                <td class="HShort" colspan="6">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                            </tr>


                                                                                            <tr>
                                                                                                <td class="H2Left">
                                                                                                   Phone:
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                   <asp:TextBox ID="txtPhone" runat="server" CssClass="TextBoxMid" MaxLength="16"></asp:TextBox>
                                                                                                    <cc1:FilteredTextBoxExtender ID="txtPhone_FilteredTextBoxExtender" runat="server"
                                                                                                        Enabled="True" FilterType="Numbers" TargetControlID="txtPhone">
                                                                                                    </cc1:FilteredTextBoxExtender>
                                                                                                </td>
                                                                                                <td class="H2Left">
                                                                                                  Mob No:
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                    <asp:TextBox ID="txtmobNo" runat="server" CssClass="TextBoxMid" MaxLength="12"></asp:TextBox>
                                                                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtmobNo"
                                                                                                        Display="None" ErrorMessage="Mobile No !" SetFocusOnError="True"></asp:RequiredFieldValidator>
                                                                                                    <cc1:ValidatorCalloutExtender ID="RequiredFieldValidator2_ValidatorCalloutExtender"
                                                                                                        runat="server" Enabled="True" HighlightCssClass="validation" TargetControlID="RequiredFieldValidator2">
                                                                                                    </cc1:ValidatorCalloutExtender>
                                                                                                    <cc1:FilteredTextBoxExtender ID="txtmobNo_FilteredTextBoxExtender" runat="server"
                                                                                                        Enabled="True" FilterType="Numbers" TargetControlID="txtmobNo">
                                                                                                    </cc1:FilteredTextBoxExtender>
                                                                                                </td>
                                                                                                <td class="H2Left">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                    &nbsp;
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
                                                                                                    <cc1:CalendarExtender ID="txtDate_CalendarExtender" runat="server" Enabled="True"
                                                                                                        TargetControlID="txtDate">
                                                                                                    </cc1:CalendarExtender>
                                                                                                </td>
                                                                                                <td class="H2Left" style="height: 26px">
                                                                                                    Land Mark:
                                                                                                </td>
                                                                                                <td class="H1Left" style="height: 26px">
                                                                                                    <asp:TextBox ID="txtLandMark" runat="server" CssClass="TextBoxMid" MaxLength="100"></asp:TextBox>
                                                                                                </td>
                                                                                                <td class="H2Left" style="height: 26px">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                                <td class="H1Left" style="height: 26px">
                                                                                                   &nbsp;
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr>
                                                                                                <td class="HShort" colspan="6">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr>
                                                                                                <td class="H2Left">
                                                                                                     Mail Id:
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                   <asp:TextBox ID="txtMailId" runat="server" CssClass="TextBoxMid" MaxLength="100"></asp:TextBox>
                                                                                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="txtMailId"
                                                                                                        Display="None" ErrorMessage="Enter email id !" SetFocusOnError="True"></asp:RequiredFieldValidator>
                                                                                                    <cc1:ValidatorCalloutExtender ID="ValidatorCalloutExtender7" runat="server" Enabled="True"
                                                                                                        HighlightCssClass="validation" TargetControlID="RequiredFieldValidator11">
                                                                                                    </cc1:ValidatorCalloutExtender>
                                                                                                </td>
                                                                                                <td class="H2Left">
                                                                                                   Logo:
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                     <asp:FileUpload ID="logoCollege" runat="server" />
                                                                                                </td>
                                                                                                <td class="H2Left">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                            </tr>

                                                                                            <tr>
                                                                                                <td class="HShort" colspan="6">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                            </tr>
                                                                                             <tr>
                                                                                                <td class="H2Left">
                                                                                                       Rank:
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                    <asp:DropDownList ID="ddlRankList" runat="server" CssClass="DropdwonMid">
                                                                                                    </asp:DropDownList>
                                                                                                     <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="ddlRankList"
                                                                                                        Display="None" ErrorMessage="Select  Rank !" InitialValue="0"></asp:RequiredFieldValidator>
                                                                                                    <cc1:ValidatorCalloutExtender ID="ValidatorCalloutExtender9"
                                                                                                        runat="server" Enabled="True" TargetControlID="RequiredFieldValidator13">
                                                                                                    </cc1:ValidatorCalloutExtender>
                                                                                                </td>
                                                                                                <td class="H2Left">
                                                                                                   Grade:
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                     <asp:DropDownList ID="ddlGrade" runat="server" CssClass="DropdwonMid">
                                                                                                        <asp:ListItem Text="A-Grade" Value="A-Grade"></asp:ListItem>
                                                                                                        <asp:ListItem Text="B-Grade" Value="B-Grade"></asp:ListItem>
                                                                                                        <asp:ListItem Text="C-Grade" Value="C-Grade"></asp:ListItem>
                                                                                                        <asp:ListItem Text="D-Grade" Value="D-Grade"></asp:ListItem>
                                                                                                    </asp:DropDownList>
                                                                                                </td>
                                                                                                <td class="H2Left">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                            </tr>

                                                                                            <tr>
                                                                                                <td class="HShort" colspan="6">
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
                                                                                                <td class="H2Left">
                                                                                                  
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                  
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                  
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                   
                                                                                                </td>
                                                                                            </tr>
                                                                                         
                                                                                            <tr>
                                                                                               <%-- <td class="H2Left" style="display:none;">--%>
                                                                                                <td class="H2Left" style="display:none;">
                                                                                                    College Stream:
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                                <td class="H2Left" id="tdUniverciy" runat="server" style="display:none;">
                                                                                                    Affiliated
                                                                                                    <%--University:--%>
                                                                                                </td>
                                                                                                <td class="H1Left" id="tdUniverciyDdl" runat="server" style="display:none;">
                                                                                                    <asp:DropDownList ID="ddlUniversityFinal" runat="server" CssClass="DropdwonMid">
                                                                                                    </asp:DropDownList>
                                                                                                    

                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                   
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                  
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr>
                                                                                                <td class="H2Left" rowspan="2">
                                                                                               
                                                                                                    <div style="overflow: scroll; height: 210px; width: 190px; display:none;">
                                                                                                        <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
                                                                                                            <HeaderTemplate>
                                                                                                                <table width="190" border="0" cellspacing="0" cellpadding="0">
                                                                                                            </HeaderTemplate>
                                                                                                            <ItemTemplate>
                                                                                                                <tr>
                                                                                                                    <td align="center" style="width: 10px;" valign="middle">
                                                                                                                        <asp:CheckBox ID="chk" runat="server" />
                                                                                                                    </td>
                                                                                                                    <td width="171" style="color: #000; font-family: Verdana; font-size: 12px;" align="left"
                                                                                                                        valign="middle">
                                                                                                                        <asp:Label ID="lblName" runat="server" Text='<%#Eval("name")%>'></asp:Label>
                                                                                                                        <asp:Label ID="lblId" runat="server" Visible="false" Text='<%#Eval("id")%>'></asp:Label>
                                                                                                                    </td>
                                                                                                                </tr>
                                                                                                                <tr>
                                                                                                                    <td colspan="2" align="center" valign="middle">
                                                                                                                        ............................
                                                                                                                    </td>
                                                                                                                </tr>
                                                                                                            </ItemTemplate>
                                                                                                            <FooterTemplate>
                                                                                                                </table>
                                                                                                            </FooterTemplate>
                                                                                                        </asp:Repeater>
                                                                                                    </div>
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                                <td class="H2Left">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr>
                                                                                                <td class="H1Left">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                                <td class="H2Left">
                                                                                                    <asp:Button ID="btnSubmit" runat="server" CssClass="bnt-sbmt" OnClick="btnSubmit_Click"
                                                                                                        Text="Submit" Width="76px" />
                                                                                                </td>
                                                                                                <td class="H1Left">
                                                                                                    <asp:Button ID="btnCancel" runat="server" CssClass="bnt-sbmt" OnClick="btnCancel_Click"
                                                                                                        Text="Cancel" Width="83px" />
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                                <td class="H1Center" colspan="2">
                                                                                                    &nbsp;
                                                                                                </td>
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
                                            <%-- <td style="width: 10%">
                                            </td>--%>
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
                                                                        <asp:TextBox ID="txtGoPage" runat="server" CssClass="TextBoxShort" MaxLength="5"
                                                                            Style="width: 167px;"></asp:TextBox>
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
                                                            <asp:DropDownList ID="ddlNopage" runat="server" CssClass="DropdwonShort" OnSelectedIndexChanged="ddlNopage_SelectedIndexChanged"
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
                                        <tr>
                                            <td style="width: 1">
                                                &nbsp;
                                            </td>
                                            <td align="center" style="width: 98%">
                                                <asp:Repeater ID="datalist" runat="server" OnItemCommand="datalist_ItemCommand">
                                                    <HeaderTemplate>
                                                        <table class="MasterTableCenter" cellpadding="10">
                                                            <tr>
                                                                <th rowspan="2" style="width: 50px;">
                                                                    <%--Sr. No.--%><br />
                                                                    <span style="font-size: 8px"><%--Click for change--%></span>
                                                                </th>
                                                                <th rowspan="2">
                                                                    Date
                                                                </th>
                                                                <th colspan="4">
                                                                   Edu Type Info
                                                                </th>
                                                                <th colspan="5">
                                                                    Address Info
                                                                </th>
                                                                <th colspan="2">
                                                                    Contact Info
                                                                </th>
                                                                <th rowspan="2">
                                                                    Delete
                                                                </th>
                                                            </tr>
                                                            <tr>
                                                                <th style="width: 60px;">
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
                                                                <th>
                                                                    College Type
                                                                </th>
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
                                                                <%-- <th>
                                                                    Ph No
                                                                </th>--%>
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
                                                                <asp:LinkButton ID="lnkEdit" CausesValidation="false" runat="server" Visible="false" Text="Edit"
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
                                                            <td>
                                                                <%#Eval("status")%>
                                                            </td>
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
                                                            <td>
                                                                <asp:LinkButton ID="lnkDelete" CausesValidation="false" runat="server" CommandArgument='<%#Eval("Id")%>'
                                                                    CommandName="Delete"> Delete
                                                                </asp:LinkButton>
                                                            </td>
                                                        </tr>
                                                    </ItemTemplate>
                                                    <AlternatingItemTemplate>
                                                        <tr class="alt">
                                                            <td>
                                                                <asp:LinkButton ID="lnkEdit" CausesValidation="false" runat="server" Visible="false" Text="Edit"
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
                                                            <td>
                                                                <%#Eval("status")%>
                                                            </td>
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
                                                            <td>
                                                                <asp:LinkButton ID="lnkDelete" CausesValidation="false" runat="server" CommandArgument='<%#Eval("Id")%>'
                                                                    CommandName="Delete"> Delete
                                                                </asp:LinkButton>
                                                            </td>
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

