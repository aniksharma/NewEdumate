<%@ Page Title="" Language="C#" MasterPageFile="~/Add Institute/MasterPage.master"
    AutoEventWireup="true" CodeFile="StudentRegistration.aspx.cs" Inherits="KidsProfile_KidsProfile" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table style="margin: 0 auto; width: 830px;">
        <tr>
            <td colspan="2">
                <div id="Warrning" runat="server">
                </div>
            </td>
        </tr>

        <tr>
            <td colspan="2" class="hdng-topics">Personal Detail
            </td>
        </tr>
        <tr>
            <td>Name<span style="color: #FF0000">*</span>
            </td>
            <td>
                <asp:TextBox ID="txtKidsname" runat="server" CssClass="txts-flds" onblur="javascript:Required('ContentPlaceHolder1_txtKidsname')"></asp:TextBox>
                <span id="ContentPlaceHolder1_txtKidsnameL"></span>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtKidsname"
                    ErrorMessage="Require Name " ValidationGroup="r"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="2" class="blank">&nbsp;
            </td>
        </tr>

        <tr>
            <td>DOB<span style="color: #FF0000">*</span>
            </td>
            <td>
                <asp:TextBox ID="txtDob" CssClass="txts-flds" runat="server" onblur="javascript:Required('ContentPlaceHolder1_txtDob')"></asp:TextBox>
                <cc1:CalendarExtender ID="txtDob_CalendarExtender" runat="server" Enabled="True"
                    TargetControlID="txtDob">
                </cc1:CalendarExtender>
                <span id="ContentPlaceHolder1_txtDobL"></span>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtDob"
                    ErrorMessage="Enter Valid Date!" Operator="DataTypeCheck" ValidationGroup="r"
                    Type="Date"></asp:CompareValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtDob"
                    ErrorMessage="Insert DOB" ValidationGroup="r"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Gender
            </td>
            <td>
                <asp:RadioButtonList ID="RbGender" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Selected="True">Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td colspan="2" class="blank">&nbsp;
            </td>
        </tr>

        <tr>
            <th colspan="2" class="hdng-topics">Contact Info
            </th>
        </tr>

        <tr>
            <td>Country
            </td>
            <td>
                <asp:DropDownList ID="ddlCountry" CssClass="txts-drps" runat="server" AutoPostBack="True"
                    OnSelectedIndexChanged="ddlCountry_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="2" class="blank">&nbsp;
            </td>
        </tr>
        <tr>
            <td>State
            </td>
            <td>
                <asp:DropDownList ID="ddlState" CssClass="txts-drps" runat="server" AutoPostBack="True"
                    OnSelectedIndexChanged="ddlState_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="2" class="blank">&nbsp;
            </td>
        </tr>
        <tr>
            <td>City
            </td>
            <td>
                <asp:DropDownList ID="ddlCity" CssClass="txts-drps" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="2" class="blank">&nbsp;
            </td>
        </tr>
        <tr>
            <td>&nbsp;Address
            </td>
            <td>
                <asp:TextBox CssClass="txts-flds" ID="txtaddress" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" class="blank">&nbsp;
            </td>
        </tr>
        <tr>
            <td>Mobile No<span style="color: #FF0000">*</span>
            </td>
            <td>
                <asp:TextBox ID="txtmobile" class="txts-flds" runat="server" onblur="javascript:Mobile('ContentPlaceHolder1_txtmobile')"
                    MaxLength="13"></asp:TextBox>
                <span id="ContentPlaceHolder1_txtmobileL"></span>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtmobile"
                    ErrorMessage="Mobile Require" ValidationGroup="r"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="2" class="blank">&nbsp;
            </td>
        </tr>
        <tr>
            <td>E-mail ID<span style="color: #FF0000">*</span>
            </td>
            <td>
                <asp:TextBox ID="txtemail" class="txts-flds" runat="server" onblur="javascript:Email('ContentPlaceHolder1_txtemail')"></asp:TextBox>
                <span id="ContentPlaceHolder1_txtemailL"></span>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtemail"
                    ErrorMessage="Email Is Require" ValidationGroup="r"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtemail"
                    ErrorMessage="Only Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td colspan="2" class="blank">&nbsp;
            </td>
        </tr>
        <tr>
            <td>PassWord<span style="color: #FF0000">*</span>
            </td>
            <td>
                <asp:TextBox ID="txtpassword" runat="server" TextMode="Password" class="txts-flds"
                    onblur="javascript:Password('ContentPlaceHolder1_txtpassword')"></asp:TextBox>
                <span id="ContentPlaceHolder1_txtpasswordL"></span>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtpassword"
                    ErrorMessage="Insert Password" ValidationGroup="r"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="2" class="blank">&nbsp;
            </td>
        </tr>

        <tr>
            <td colspan="2" class="hdng-topics">Current Education Details
            </td>
        </tr>
        <tr>
            <td>Currently Studying
            </td>
            <td>
                <asp:DropDownList ID="DropDownList1" CssClass="txts-drps" runat="server">
                    <asp:ListItem Value="0">Select</asp:ListItem>
                    <asp:ListItem Value="10th">10th</asp:ListItem>
                    <asp:ListItem Value="11th /PUC ">11th /PUC</asp:ListItem>
                    <asp:ListItem Value="12th">12th</asp:ListItem>
                    <asp:ListItem Value="Completed 12th">Completed 12th</asp:ListItem>
                    <asp:ListItem Value="B.A">B.A.</asp:ListItem>
                    <asp:ListItem Value="B.Arch">B.Arch</asp:ListItem>
                    <asp:ListItem Value="B.B.A">B.B.A</asp:ListItem>
                    <asp:ListItem Value="B.Com">B.Com</asp:ListItem>
                    <asp:ListItem Value="B.Ed">B.Ed</asp:ListItem>
                    <asp:ListItem Value="B.Pharm">B.Pharm</asp:ListItem>
                    <asp:ListItem Value="B.P.Th.">Bachelor of Physiotherapy</asp:ListItem>
                    <asp:ListItem Value="B.Sc">B.Sc</asp:ListItem>
                    <asp:ListItem Value="B.Tech/B.E.">B.Tech/B.E.</asp:ListItem>
                    <asp:ListItem Value="BCA">BCA</asp:ListItem>
                    <asp:ListItem Value="BDS">BDS</asp:ListItem>
                    <asp:ListItem Value="BHM">BHM</asp:ListItem>
                    <asp:ListItem Value="B.M.S.">B.M.S.</asp:ListItem>
                    <asp:ListItem Value="BBM">BBM</asp:ListItem>
                    <asp:ListItem Value="BVSc">BVSc</asp:ListItem>
                    <asp:ListItem Value="B.T.M.">Bachelor tourism and managment</asp:ListItem>
                    <asp:ListItem Value="B.Cs.">Bachelor of Computer Science</asp:ListItem>
                    <asp:ListItem Value="CA">CA</asp:ListItem>
                    <asp:ListItem Value="DDS">Doctor of Dental science</asp:ListItem>
                    <asp:ListItem Value="Diploma">Diploma</asp:ListItem>
                    <asp:ListItem Value="Integrated PG">Integrated PG</asp:ListItem>
                    <asp:ListItem Value="LLB">LLB</asp:ListItem>
                    <asp:ListItem Value="LLM">LLM</asp:ListItem>
                    <asp:ListItem Value="M.A">M.A</asp:ListItem>
                    <asp:ListItem Value="M.Arch">M.Arch</asp:ListItem>
                    <asp:ListItem Value="M.Com">M.Com</asp:ListItem>
                    <asp:ListItem Value="M.Ed">M.Ed</asp:ListItem>
                    <asp:ListItem Value="M.Pharm">M.Pharm</asp:ListItem>
                    <asp:ListItem Value="M.Sc">M.Sc</asp:ListItem>
                    <asp:ListItem Value="M.Tech/M.E.">M.Tech/M.E.</asp:ListItem>
                    <asp:ListItem Value="MBA">MBA</asp:ListItem>
                    <asp:ListItem Value="MBBS">MBBS</asp:ListItem>
                    <asp:ListItem Value="MCA">MCA</asp:ListItem>
                    <asp:ListItem Value="MCM">MCM</asp:ListItem>
                    <asp:ListItem Value="M.P.Th.">Master of Physiotherapy</asp:ListItem>
                    <asp:ListItem Value="MS">MS</asp:ListItem>
                    <asp:ListItem Value="MVSc">MVSc</asp:ListItem>
                    <asp:ListItem Value="PG Diploma">PG Diploma</asp:ListItem>
                    <asp:ListItem Value="PGDBA">PGDBA</asp:ListItem>
                    <asp:ListItem Value="PGDM">PGDM</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Graduating in
            </td>
            <td>
                <asp:DropDownList ID="ddlgrd" CssClass="txts-drps" runat="server" OnSelectedIndexChanged="ddlgrd_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="2" class="hdng-topics">Education Preferences
            </td>
        </tr>
        <tr>
            <td>Education Interest
            </td>
            <td>
                <asp:DropDownList ID="ddlentrest" CssClass="txts-drps" runat="server" OnSelectedIndexChanged="ddlentrest_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Study in
            </td>
            <td>
                <asp:RadioButtonList ID="rbs" runat="server" AutoPostBack="true" RepeatDirection="Horizontal"
                    OnSelectedIndexChanged="rbs_SelectedIndexChanged">
                    <asp:ListItem Value="1">India</asp:ListItem>
                    <asp:ListItem Value="2">Study Abroad </asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td>Preferred Location For Higher Studies
            </td>
            <td>
                <asp:DropDownList ID="ddllocation" CssClass="txts-drps" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>When do You Plant to Start
            </td>
            <td>
                <asp:DropDownList ID="DropDownList6" CssClass="txts-drps" runat="server">
                    <asp:ListItem Value="">Select</asp:ListItem>
                    <asp:ListItem Value="Immediately">Immediately</asp:ListItem>
                    <asp:ListItem Value="Within 2 Months">Within 2 Months</asp:ListItem>
                    <asp:ListItem Value="Within 3 Months">Within 3 Months</asp:ListItem>
                    <asp:ListItem Value="Not Sure">Not Sure</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <th>&nbsp;
            </th>
            <td>
                <asp:Button ID="btsubmit" runat="server" Text="Register" OnClientClick="javascript:Kidssubmitdata();"
                    CssClass="sbmt-btn" onfocus="javascript:Kidssubmitdata();" OnClick="btsubmit_Click"
                    ValidationGroup="r" />
            </td>
        </tr>
        <tr>
            <th>&nbsp;
            </th>
            <td>&nbsp;
            </td>
        </tr>
        <tr>
            <th></th>
            <td></td>
        </tr>
    </table>
</asp:Content>
