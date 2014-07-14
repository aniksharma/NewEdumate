<%@ Page Title="" Language="C#" MasterPageFile="~/Add Institute/MasterPage.master" AutoEventWireup="true" CodeFile="CodeVerification.aspx.cs" Inherits="Add_Institute_CodeVerification" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<center>
        <br />
        <br />
        <table width="500" cellpadding="0" cellspacing="0" style="border: solid 2px gray;">
            <tr>
                <th style="color: White; background-color: #3449AE; height: 40px; font-size: 20px;"  align="center">
                    Verification Code
                </th>
            </tr>
            <tr>
                <td style="width: 50%; font-family: Verdana; font-size: 16px; color: #000000" align="center">
                    Check Your Email
                    <br />
                    <br />
                    <span style='font-size: 12px;'>we sent you an email with a confirmation code.</span>
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td align="center" style="font-family: Verdana; font-size: 12px; color: #000000">
                    &nbsp;Confirmation Code<span style='font-size: 11px;'> :&nbsp;&nbsp;
                        <asp:TextBox ID="txtCode" runat="server" Width="180px" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCode"
                            Display="None" ErrorMessage="Reset Code !" SetFocusOnError="True"></asp:RequiredFieldValidator>
                        <cc1:validatorcalloutextender id="RequiredFieldValidator1_ValidatorCalloutExtender"
                            runat="server" enabled="True" targetcontrolid="RequiredFieldValidator1">
                    </cc1:validatorcalloutextender>
                        &nbsp;&nbsp; </span>&nbsp;<br />
                    <br />
                    <br />
                    <asp:Button ID="btnContinue" runat="server" Text="Submit" OnClick="btnContinue_Click" />
                    <br />
                    <br />
                    <asp:Label ID="lblMsg" runat="server"></asp:Label>
                    <br />
                </td>
            </tr>
            <tr id="TrLoginpage" runat="server" visible="false">
             
            </tr>
        </table>
    </center>

</asp:Content>

