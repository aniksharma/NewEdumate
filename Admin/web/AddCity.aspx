﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage/AdminMaster.master" AutoEventWireup="true" CodeFile="AddCity.aspx.cs" Inherits="Admin_web_AddCity" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

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
                                                                Add City&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="ImportCity.aspx">Import City</a></td>
                                                        </tr>
                                                        <tr>
                                                            <td class="H2Center" colspan="2">
                                                                <asp:Label ID="lblMsg" runat="server"></asp:Label>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                Country:</td>
                                                            <td>
                                                                <asp:DropDownList ID="ddlUniversity0" runat="server" AutoPostBack="True" Onchange="ddlChkSelect('country');"
                                                                    CssClass="txt-fld-Dropdown" 
                                                                    onselectedindexchanged="ddlUniversity0_SelectedIndexChanged">
                                                                </asp:DropDownList>
                                                                 <div id="country"  style="visibility:hidden; height:24px;width:24px; float:right;margin-right:65px;margin-top:0px;">
                                                                        <img alt="Loading..." src="../images/loading.gif" style="width: 22px;height: 22px" /> 
                                                                      </div> 
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                                                    ControlToValidate="ddlUniversity0" Display="None" 
                                                                    ErrorMessage=" Select University" InitialValue="0"></asp:RequiredFieldValidator>
                                                                <cc1:ValidatorCalloutExtender ID="RequiredFieldValidator2_ValidatorCalloutExtender0" 
                                                                    runat="server" Enabled="True" TargetControlID="RequiredFieldValidator2">
                                                                </cc1:ValidatorCalloutExtender>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                State:</td>
                                                            <td>
                                                                <asp:DropDownList ID="ddlUniversity" runat="server" CssClass="txt-fld-Dropdown" Onchange="ddlChkSelect('State');"
                                                                    AutoPostBack="True" onselectedindexchanged="ddlUniversity_SelectedIndexChanged">
                                                                </asp:DropDownList>
                                                                 <div id="State"  style="visibility:hidden; height:24px;width:24px; float:right;margin-right:65px;margin-top:0px;">
                                                                        <img alt="Loading..." src="../images/loading.gif" style="width: 22px;height: 22px" /> 
                                                                      </div> 
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                                    ControlToValidate="ddlUniversity" Display="None" 
                                                                    ErrorMessage=" Select University" InitialValue="0"></asp:RequiredFieldValidator>
                                                                <cc1:ValidatorCalloutExtender ID="RequiredFieldValidator2_ValidatorCalloutExtender" 
                                                                    runat="server" Enabled="True" TargetControlID="RequiredFieldValidator2">
                                                                </cc1:ValidatorCalloutExtender>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                District:&nbsp;</td>
                                                            <td>
                                                                <asp:DropDownList ID="ddlDistrict" runat="server" AutoPostBack="True" Onchange="ddlChkSelect('District');"
                                                                    CssClass="txt-fld-Dropdown" 
                                                                    onselectedindexchanged="ddlDistrict_SelectedIndexChanged">
                                                                </asp:DropDownList>
                                                                 <div id="District"  style="visibility:hidden; height:24px;width:24px; float:right;margin-right:65px;margin-top:0px;">
                                                                        <img alt="Loading..." src="../images/loading.gif" style="width: 22px;height: 22px" /> 
                                                                      </div> 
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                                                    Display="None" ErrorMessage="District !" InitialValue="0" 
                                                                    ControlToValidate="ddlDistrict"></asp:RequiredFieldValidator>
                                                                <cc1:ValidatorCalloutExtender ID="RequiredFieldValidator3_ValidatorCalloutExtender" 
                                                                    runat="server" Enabled="True" TargetControlID="RequiredFieldValidator3">
                                                                </cc1:ValidatorCalloutExtender>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                City&nbsp; Name:
                                                            </td>
                                                            <td>
                                                                <asp:TextBox ID="txtUserName" runat="server" CssClass="txt-fld-country" onblur="javascript:Required('ctl00_ContentPlaceHolder1_txtUserName')"
                                                                    MaxLength="150"></asp:TextBox>
                                                                      <span id="ctl00_ContentPlaceHolder1_txtUserNameL" style="width: 50px; float: none;"></span>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserName"
                                                                    Display="None" ErrorMessage="Insert Course Category !" 
                                                                    SetFocusOnError="True" ValidationGroup="majorUnit"></asp:RequiredFieldValidator>
                                                                <cc1:validatorcalloutextender id="RequiredFieldValidator1_ValidatorCalloutExtender"
                                                                    runat="server" enabled="True" highlightcssclass="validation" targetcontrolid="RequiredFieldValidator1">
                                                                </cc1:validatorcalloutextender>

                                                            </td>
                                                        </tr>
                                                    
                                                        <tr>
                                                            <td class="H1Center" colspan="2">
                                                                &nbsp;</td>
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
                                                        <td>&nbsp;</td>
                                                            <td class="H1Center" colspan="2">
                                                                <asp:Button ID="btnSubmit" runat="server" CssClass="bnt-sbmt" OnClick="btnSubmit_Click" OnClientClick="ddlChkSelect('Submit');" onfocus="javascript:submitCitydata();"
                                                                    Text="Submit" ValidationGroup="majorUnit" />
                                                                &nbsp;<asp:Button ID="btnCancel" runat="server" CausesValidation="False" CssClass="ButtonSmall"
                                                                    OnClick="btnCancel_Click" Text="Cancel" />
                                                                &nbsp;
                                                                <asp:Button ID="btnDelete" runat="server" CssClass="bnt-sbmt" OnClick="btnDelete_Click"
                                                                    Text="Delete" ValidationGroup="majorUnit" Visible="False" />
                                                            &nbsp;<div id="Submit"  style="visibility:hidden; height:24px;width:24px; float:right;margin-right:65px;margin-top:0px;">
                                                                        <img alt="Loading..." src="../images/loading.gif" style="width: 22px;height: 22px" /> 
                                                                      </div></td>
                                                        </tr>
                                                    </table>
                                                </td>
                                                <td valign="top" width="20%">
                                                    <table style="width: 100%; border-left-style: solid; border-left-width: 3px; border-left-color: #333333;">
                                                        <tr>
                                                            <td class="Add-Country">
                                                                City List                                                             </td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 121px" class="H2Center">
                                                                <asp:ListBox ID="lstbox" runat="server" AutoPostBack="True" Height="123px" Onchange="ddlChkSelect('Submit');"
                                                                     Width="229px" 
                                                                    CssClass="H2Center" onselectedindexchanged="lstbox_SelectedIndexChanged">
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

