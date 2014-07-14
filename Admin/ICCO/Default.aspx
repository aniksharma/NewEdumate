<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage/AdminMaster.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Admin_ICCO_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<table style="width: 100%">
        <tr>
            <td height="30px">
                &nbsp;
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
                            <table class="BoxFourRound">
                                <tr>
                                    <td style="height: 20px">
                                    </td>
                                </tr>
                                <tr>
                                    <td class="H3Center" style="color: #009900">
                                        Wel- Come In Admin Panel&nbsp;&nbsp;&nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <table style="width: 100%">
                                            <tr>
                                                <td>
                                                    &nbsp;
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <table style="width: 100%">
                                                        <tr>
                                                            <td width="96%">
                                                                <table style="width: 100%">
                                                                    <tr>
                                                                        <td>
                                                                            <table style="width: 100%" class="BoxFour">
                                                                                <tr>
                                                                                    <td valign="top" width="98%" style="padding: 30px 200px 30px 200px;">
                                                                                        <table width="80%">
                                                                                            <tr>
                                                                                                <td style="height: 100px;">
                                                                                                    <a href="../setup/SetNewsSection.aspx">
                                                                                                        <img src="../Icon/news.png" height="70" width="70" style="border-style: none;" /></a>
                                                                                                </td>
                                                                                                <td>
                                                                                                    <a href="../setup/TextEditor.aspx?key=3&Name=Term%20&%20Condition">
                                                                                                        <img src="../Icon/WebStting.png" height="70" width="70" style="border-style: none;" /></a>
                                                                                                </td>
                                                                                                <td>
                                                                                                    <a href="../web/LatestUpdate.aspx">
                                                                                                        <img src="../Icon/testomony.png" height="70" width="70" style="border-style: none;" /></a>
                                                                                                </td>
                                                                                                <td>
                                                                                                    <a href="../web/universityDetail.aspx">
                                                                                                        <img src="../Icon/college.png" height="70" width="70" style="border-style: none;" /></a>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr style="color: #444444; font-family: Arial;">
                                                                                                <th>
                                                                                                    <a href="../setup/SetNewsSection.aspx" style="text-decoration: none; margin-left: 5px;">
                                                                                                        News</a>
                                                                                                </th>
                                                                                                <th>
                                                                                                    <a href="../setup/TextEditor.aspx?key=3&Name=Term%20&%20Condition" style="text-decoration: none;
                                                                                                        margin-left: 5px;">SetPage</a>
                                                                                                </th>
                                                                                                <th>
                                                                                                    <a href="../web/LatestUpdate.aspx" style="text-decoration: none; margin-left: 5px;">
                                                                                                        Testomony</a>
                                                                                                </th>
                                                                                                <th>
                                                                                                    <a href="../web/universityDetail.aspx" style="text-decoration: none; margin-left: 5px;">
                                                                                                        University</a>
                                                                                                </th>
                                                                                            </tr>
                                                                                            <tr>
                                                                                                <td style="height: 100px;">
                                                                                                    <a href="../web/addImage.aspx">
                                                                                                        <img src="../Icon/Image.png" height="70" width="70" style="border-style: none;" /></a>
                                                                                                </td>
                                                                                                <td>
                                                                                                    <a href="">
                                                                                                        <img src="../Icon/Setup.png" height="70" width="70" style="border-style: none;" /></a>
                                                                                                </td>
                                                                                                <td>
                                                                                                    <a href="../partner/viewPartners.aspx">
                                                                                                        <img src="../Icon/partner.png" height="70" width="70" style="border-style: none;" /></a>
                                                                                                </td>
                                                                                                <td>
                                                                                                    <a href="../ticketWork/ShowWithCount.aspx">
                                                                                                        <img src="../Icon/Ticket.png" height="70" width="70" style="border-style: none;" /></a>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr style="color: #444444; font-family: Arial;">
                                                                                                <th>
                                                                                                    <a href="../web/addImage.aspx" style="text-decoration: none; margin-left: 5px;">Image</a>
                                                                                                </th>
                                                                                                <th>
                                                                                                    <a href="" style="text-decoration: none; margin-left: 5px;">Setup</a>
                                                                                                </th>
                                                                                                <th>
                                                                                                    <a href="../partner/viewPartners.aspx" style="text-decoration: none; margin-left: 5px;">
                                                                                                        Partner</a>
                                                                                                </th>
                                                                                                <th>
                                                                                                    <a href="../ticketWork/ShowWithCount.aspx" style="text-decoration: none; margin-left: 5px;">
                                                                                                        Ticket</a>
                                                                                                </th>
                                                                                            </tr>
                                                                                            <tr style="color: #444444; font-family: Arial;">
                                                                                                <th>
                                                                                                    <asp:Button ID="Button1" runat="server" Text="Login To User Panel" 
                                                                                                        onclick="Button1_Click" />
                                                                                                </th>
                                                                                                <th>
                                                                                                    &nbsp;
                                                                                                </th>
                                                                                                <th>
                                                                                                    &nbsp;
                                                                                                </th>
                                                                                                <th>
                                                                                                    &nbsp;
                                                                                                </th>
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
                                            <tr>
                                                <td>
                                                    &nbsp;
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="H1Center">
                                        <asp:Label ID="lblMessage" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
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
            <td height="30px">
                &nbsp;
            </td>
        </tr>
    </table>
</asp:Content>

