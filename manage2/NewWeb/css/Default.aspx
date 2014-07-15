<%@ Page Title="" Language="C#" MasterPageFile="~/manage2/NewWeb/Home.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="manage2_NewWeb_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="data" runat="server">
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <h3>
        Gallery
    </h3>
    <asp:DataList ID="Repeater1" runat="server" RepeatColumns="5">
        <ItemTemplate>
            <div class="leftgalleryimgbox">
                <img src='<%#"http://www.edumate.edu.in/"+Eval("imagePath")%>' />
            </div>
        </ItemTemplate>
    </asp:DataList>
    <span class="more"><a href="#">More</a></span>
</asp:Content>
