<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage/AdminMaster.master" AutoEventWireup="true" CodeFile="importTutor.aspx.cs" Inherits="Admin_MasterPage_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="2px" width="40%" style="float: left; margin-left: 25px;"
        id="formation-03">
        <tr>
            <td>
                <div id="Warrning" runat="server">
                </div>
                <table width="100%">
                    <tr>
                     <th class="tble-thclr">
                            Import File
                        </th>
                        <th class="tble-thclr">
                            <asp:FileUpload ID="FileUpload1" runat="server" />
                        </th>
                        
                    </tr>
                    <tr>
                   <td>
                        <asp:Button ID="Button2" runat="server" Text="Submit" OnClick="Button2_Click" CssClass="btn btn-blue" />
                        </td>
                        <td> <asp:Label ID="lblMsg" runat="server" Visible="false" CssClass="labelMsgRed"></asp:Label></td>
                    </tr>
                </table>
</asp:Content>

