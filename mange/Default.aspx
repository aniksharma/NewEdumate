<%@ Page Title="" Language="C#" MasterPageFile="~/manage2/NewWeb/home2.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="manage2_NewWeb_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="data" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="Server">
 <div class="widesubcontent">
    <h3>
        Gallery
    <%--</h3>--%>
    <asp:DataList ID="Repeater1" runat="server" RepeatColumns="5">
        <ItemTemplate>
            <div class="leftgalleryimgbox">
                <img src='<%#Eval("imagePath")%>' height ="180px" width="180px" />
            </div>
        </ItemTemplate>
    </asp:DataList>
    <span class="more"><a href="#">More</a></span>
    </div>
</asp:Content>
