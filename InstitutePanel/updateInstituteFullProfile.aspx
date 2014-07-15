<%@ Page Language="C#" MasterPageFile="~/InstitutePanel/MasterPage2.master" AutoEventWireup="true" CodeFile="updateInstituteFullProfile.aspx.cs"
    Inherits="employee_updateFullProfile" Title="Edu-Hub" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit.HTMLEditor" tagprefix="cc1" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="width:650px; border:1px solid #ccc;">
    <asp:UpdatePanel ID="updatepanel1" runat="server">
        <ContentTemplate>
            <table>

                <tr>
                    <td class="H2Center" colspan="2"></td>
                </tr>
                <tr>
                    <td style="width: 10%;"></td>
                    <td style="width: 80%;">

<label for="ac-1" class="tab-hdng">Full Profile</label>
                        <table style="width: 100%;" class="NewTableLeft">

                            
                            <tr>

                                <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                                </td>
                                <td colspan="2">&nbsp;</td>

                            </tr>
                            <tr>
                                <td style="width: 150px; font-weight: 600;">Organization Name:
                                </td>
                                <td class="H1Left" colspan="3">
                                    <asp:TextBox ID="txtName" runat="server" Width="400px"></asp:TextBox>
                                </td>
                            </tr>

                            <tr id="cApproved" runat="server" visible="false">
                                <td class="H1Left" style="font-weight: 600;">&nbsp;Approved By:</td>
                                <td class="H1Left" colspan="3">
                                    <asp:TextBox ID="txtApprovedBy" runat="server" Width="400px"></asp:TextBox>
                                </td>

                            </tr>
                            <tr id="cApproved1" runat="server" visible="false">
                                <td class="H1Left" style="font-weight: 600;">&nbsp;Approved By:</td>
                                <td class="H1Left" colspan="3">
                                    <asp:DropDownList ID="ApprovedBy" runat="server" CssClass="txts-drps">
                                    </asp:DropDownList>

                                </td>
                            </tr>
                            <tr id="cAffiliation" runat="server" visible="false">
                                <td class="H1Left" style="font-weight: 600;">Affiliated To:</td>
                                <td class="H1Left" colspan="3">
                                    <asp:TextBox ID="txtAffiliatedTo" runat="server"
                                        Width="400px"></asp:TextBox>
                                </td>

                            </tr>
                            <tr id="sAffiliation" runat="server" visible="true">
                                <td class="H1Left" style="width: 150px; font-weight: 600;">Affiliated To:</td>
                                <td class="H1Left" colspan="3">
                                    <asp:DropDownList ID="ddlAffilitedTo" Width="400px" runat="server">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr id="sLevel" runat="server" visible="false">
                                <td class="H1Left" style="font-weight: 600;">Level of school:</td>
                                <td class="H1Left" colspan="3">
                                    <asp:DropDownList ID="ddlLevel" runat="server">
                                    </asp:DropDownList>
                                </td>
                            </tr>

                            <tr id="sType" runat="server" visible="false">
                                <td class="H1Left" style="font-weight: 600;">Type of school:</td>
                                <td class="H1Left" colspan="3">
                                    <asp:DropDownList ID="ddlType" runat="server">
                                    </asp:DropDownList>
                                </td>
                            </tr>

                            <tr id="sCategory" runat="server" visible="false">
                                <td class="H1Left" style="font-weight: 600;">Category of school:</td>
                                <td class="H1Left" colspan="3">
                                    <asp:DropDownList ID="ddlCategory" runat="server">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="H1Left" style="font-weight: 600;">Year of Establishment:
                                </td>
                                <td class="H1Left" colspan="3">
                                    <asp:TextBox ID="txtApprovedDate" runat="server" Width="400px"></asp:TextBox>
                                    <cc2:CalendarExtender ID="txtApprovedDate_CalendarExtender" runat="server"
                                        Enabled="True" TargetControlID="txtApprovedDate">
                                    </cc2:CalendarExtender>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="H1Left" style="font-weight: 600; vertical-align: middle;">Short Description:</td>
                                <td class="H1Left" colspan="3">
                                    <asp:TextBox ID="ShortDescription" runat="server"
                                        TextMode="MultiLine" Height="100px" Width="400px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="H1Left" style="font-weight: 600; vertical-align: middle;">Long Description:</td>
                                <td class="H1Left" colspan="3">

                                    <asp:TextBox ID="LongDescription" runat="server"
                                        TextMode="MultiLine" Height="150px" Width="400px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr id="place1" runat="server">
                                <td class="H1Left" style="font-weight: 600;">placement
                                </td>
                                <td class="H1Left" style="font-weight: 600;">

                                    <asp:RadioButtonList ID="rbplacement" runat="server" AutoPostBack="True"
                                        OnSelectedIndexChanged="rbplacement_SelectedIndexChanged" onchange="ddlChkSelect('placement');"
                                        RepeatDirection="Horizontal" RepeatLayout="Flow">
                                        <asp:ListItem>Yes</asp:ListItem>
                                        <asp:ListItem>No</asp:ListItem>
                                    </asp:RadioButtonList>

                                    <div id="placement" style="visibility: hidden; height: 24px; width: 24px; float: right; margin-right: 141px;">
                                        <img alt="Loading..." src="../img/control Image/loading.gif" style="width: 22px; height: 22px" />
                                </td>
                                <td class="H1Left">&nbsp;</td>
                                <td class="H1Left">
                                </td>
                            </tr>
                            <tr id="Placement" runat="server">
                                <td class="H1Left" style="font-weight: 600; vertical-align: middle;">Companies Detail:</td>
                                <td colspan="3">
                                    <asp:TextBox ID="txtplacement" runat="server" Height="150px" Width="400px"
                                        TextMode="MultiLine"></asp:TextBox>
                                </td>
                            </tr>

                            <tr>
                                <td class="H1Left" style="height: 20px;" colspan="4"></td>
                            </tr>

                            <tr>
                                <th colspan="4" style="font-weight: 600;">
                                    <b><span>Contact Info :</span></b>
                                    &nbsp;</th>
                            </tr>
                            <tr>
                                <td colspan="4" style="height: 20px;"></td>
                            </tr>

                            <tr>
                                <td class="H1Left" style="font-weight: 600;">Contact&nbsp; person:</td>
                                <td class="H1Left" colspan="2">
                          

                                    <asp:TextBox ID="txtContactPerson" runat="server" Width="298px"></asp:TextBox>

                                </td>
                                <td class="H1Left">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="H1Left" style="font-weight: 600;">Mobile No:</td>
                                <td class="H1Left" colspan="2">
                                    <asp:TextBox ID="txtMobile" runat="server" Width="298px"
                                        MaxLength="10"></asp:TextBox>
                                </td>
                                <td class="H1Left">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="H1Left" style="font-weight: 600; vertical-align: middle;">Address:</td>
                                <td class="H1Left" colspan="2">
                                    <asp:TextBox ID="txtAddress" runat="server" Height="79px"
                                        MaxLength="30" TextMode="MultiLine" Width="298px"></asp:TextBox>
                                </td>
                                <td class="H1Left"></td>
                            </tr>
                            <tr>
                                <td class="H1Left" style="font-weight: 600;">Designation:</td>
                                <td class="H1Left" colspan="2">
                                    <asp:TextBox ID="txtDesignation" runat="server" Width="298px"></asp:TextBox>
                                </td>
                                <td class="H1Left">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="H1Left" style="font-weight: 600;">Website:</td>
                                <td class="H1Left" colspan="2">
                                    <asp:TextBox ID="txtWebsite" runat="server" Width="298px"></asp:TextBox>
                                </td>
                                <td class="H1Left">
                                    </td>
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
                            ValidationGroup="t" ID="RequiredFieldValidator3" runat="server" 
                            ErrorMessage="Enter Your WebName" CssClass="validatiom"></asp:RequiredFieldValidator>
                                </td>
                                <td class="H1Left"></td>
                            </tr>
                            <tr>
                                <td class="H1Left" style="font-weight: 600;">Hostel Facility:</td>
                                <td class="H1Left" style="font-weight: 600;">
                                    <asp:RadioButtonList ID="RadioButtonList1" runat="server"
                                        RepeatDirection="Horizontal" onchange="ddlChkSelect('hostel');" RepeatLayout="Flow" AutoPostBack="True"
                                        OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                                        <asp:ListItem>Yes</asp:ListItem>
                                        <asp:ListItem>No</asp:ListItem>
                                    </asp:RadioButtonList>
                                    <div id="hostel" style="visibility: hidden; height: 24px; width: 24px; float: right; margin-right: 141px;">
                                        <img alt="Loading..." src="../img/control Image/loading.gif" style="width: 22px; height: 22px" />
                                </td>
                                <td></td>
                                <td></td>
                            </tr>
                            <tr>
                                <td colspan="4">
                                    <table width="100%" id="Hostel" runat="server" visible="false" style="border-top-width: medium; border-top: solid 1px #444444;">
                                        <tr>
                                            <td class="H1Left" colspan="2">
                                                <b>Boys Hostel:-</b></td>
                                            <td></td>
                                            <td></td>
                                        </tr>
                                        <tr>
                                            <td class="H1Left" style="font-weight: 600; width: 150px;">Hostel Fees:</td>
                                            <td class="H1Left">
                                                <asp:TextBox ID="txtboysHostelFees" Width="100px" runat="server"></asp:TextBox>
                                            </td>
                                            <td class="H1Left" style="font-weight: 600; width: 150px;">
                                                <asp:RadioButtonList ID="ddlBoyFeeType" runat="server"
                                                    RepeatDirection="Horizontal" RepeatLayout="Flow">
                                                    <asp:ListItem>INR</asp:ListItem>
                                                    <asp:ListItem>USD</asp:ListItem>
                                                </asp:RadioButtonList>
                                               
                                             &nbsp;
                                            </td>
                                            <td class="H1Left" style="font-weight: 600; width: 105px;">
                                                <asp:DropDownList ID="ddlBoyFeeMode" runat="server" Width="100px">
                                                    <asp:ListItem>Yearly</asp:ListItem>
                                                    <asp:ListItem>Monthly</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="H1Left" style="height: 26px; font-weight: 600;">Hostel Seats:</td>
                                            <td class="H1Left" style="height: 26px">
                                                <asp:TextBox ID="txtBoysHostelSeats" Width="100px" runat="server"></asp:TextBox>
                                            </td>
                                            <td class="H1Left" style="font-weight: 600;">Eligibility:</td>
                                            <td class="H1Left">
                                                <asp:TextBox ID="boyHostelEgibility" runat="server" Width="100px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="H1Left" style="font-weight: 600;" colspan="2">
                                                <b>Girls Hostel:-</b></td>
                                            <td colspan="2" style="font-weight: 600;">
                                                <asp:CheckBox ID="chkGirls" runat="server" AutoPostBack="True"
                                                    OnCheckedChanged="chkGirls_CheckedChanged" Text="Same As Above" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="H1Left" style="font-weight: 600;">Hostel Fees:</td>
                                            <td class="H1Left" style="font-weight: 600;">
                                                <asp:TextBox ID="txtGirlHostelFees" Width="100px" runat="server"></asp:TextBox></td>
                                            <td class="H1Left" style="font-weight: 600;">
                                                <asp:RadioButtonList ID="ddlGirlFeeType" runat="server"
                                                    RepeatDirection="Horizontal" RepeatLayout="Flow">
                                                    <asp:ListItem>INR</asp:ListItem>
                                                    <asp:ListItem>USD</asp:ListItem>
                                                </asp:RadioButtonList>
                                               
                                            </td>
                                            <td class="H1Left">
                                                <asp:DropDownList ID="ddlGirlFeeMode" runat="server" Width="100px">
                                                    <asp:ListItem Value="0">Select</asp:ListItem>
                                                    <asp:ListItem>Yearly</asp:ListItem>
                                                    <asp:ListItem>Monthly</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="H1Left" style="font-weight: 600;">Hostel Seats:</td>
                                            <td class="H1Left">
                                                <asp:TextBox ID="TxtGirlHostelSeat" Width="100px" runat="server"></asp:TextBox>
                                            </td>
                                            <td class="H1Left" style="font-weight: 600;">Eligibility:</td>
                                            <td class="H1Left">
                                                <asp:TextBox ID="txtGirlEgibility" runat="server" Width="100px"></asp:TextBox>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td style="line-height: 50px;"></td>
                                <td>
                                    <asp:Button ID="btnUpdateFullProfile" runat="server"
                                        Height="27px" OnClick="btnUpdateFullProfile_Click" Text="Update"
                                        ValidationGroup="info" />
                                </td>
                                <td></td>
                            </tr>
                            <tr>
                                <td style="line-height: 50px;">&nbsp;</td>
                                <td>
                                    <asp:Label ID="lblMsg" runat="server" CssClass="labelMsgRed"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                            </tr>




                        </table>

                    </td>
                    <td style="width: 10%;"></td>
                </tr>
            </table>           
        </ContentTemplate>
        
    </asp:UpdatePanel>     
    </div>
  
    
    
</asp:Content>
