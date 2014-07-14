<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage/AdminInqueryMaster.master" AutoEventWireup="true" CodeFile="RecentComment.aspx.cs" Inherits="Admin_web_RecentComment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="100%">
        <tr>
            <td colspan="4">
                <asp:Label ID="lblMsg" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Type
            </td>
            <td>
                <asp:DropDownList ID="ddlType" runat="server" Width="200px" AutoPostBack="True" OnSelectedIndexChanged="ddlType_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td>
                Title
            </td>
            <td>
                <asp:DropDownList ID="ddlTitle" Width="200px" runat="server" AutoPostBack="True"
                    OnSelectedIndexChanged="ddlTitle_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="4" style="width: 700px;">
                <br />
                <asp:Repeater ID="Repeater2" runat="server" OnItemCommand="Repeater2_ItemCommand">
                    <ItemTemplate>
                        <div style="width: 700px; float: left; vertical-align: middle;">
                            <table style="width: 700px; height: 120px;" cellpadding="0" cellspacing="0">
                                <tr>
                                    <td style="width: 100px;">
                                        <img src="../images/Comment.png" height="40" width="40" />
                                    </td>
                                    <td style="width: 400px; color: #0A4F8E;">
                                        <h5>
                                            <%#Eval("id")%>&nbsp;&nbsp;
                                            <%#Eval("name")%>&nbsp;&nbsp;
                                            <%#Eval("DOJ")%>
                                        </h5>
                                    </td>
                                    <td style="color: #82A811;">
                                        <asp:LinkButton ID="LinkButton1" CommandArgument='<%#Eval("id")%>' runat="server">Delete</asp:LinkButton>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="3">
                                        <%#Eval("emailID")%>
                                        &nbsp;&nbsp;<%#Eval("mobNo")%>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="padding-left: 50px; color: #0A4F8E; margin-top: 50px;">
                                        <%#Eval("description")%>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="3">
                                       
                                        <hr style="border: 1px solid #555555; margin-bottom: 2px;" />
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </td>
        </tr>
    </table>
</asp:Content>

