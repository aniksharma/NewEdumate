<%@ Page Title="" Language="C#" MasterPageFile="~/manage2/NewWeb/Home.master" AutoEventWireup="true"
    CodeFile="pageGellary.aspx.cs" Inherits="manage2_NewWeb_pageGellary" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
<link rel="stylesheet" type="text/css" media="screen" href="h~/mange/NewWeb/css/skin-2.css">
            <link rel="stylesheet" type="text/css" media="screen" href="~/mange/NewWeb/css/jquery.fancybox-1.3.4.css">
            
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="width: 100%; background-color: White">
        <center>
            <h3 id="ih3" runat="server">
                Image Gellary
            </h3>
            <ul id="mycarousel-1" class="jcarousel-skin-tango">
                <asp:Repeater ID="datalist" runat="server">
                    <HeaderTemplate>
                    </HeaderTemplate>
                    <FooterTemplate>
                    </FooterTemplate>
                    <ItemTemplate>
                        <li><a class="plus" href='http://www.edumateworld.com/<%#Eval("imagePath")%>' style="text-decoration: none;">
                            <img src='~/<%#Eval("imagePath")%>' alt='../<%#Eval("caloneyName")%>'
                                width="177" height="240"></a>
                    </ItemTemplate>
                    <AlternatingItemTemplate>
                        <a class="plus" href='~/<%#Eval("imagePath")%>'>
                            <img src='~/<%#Eval("imagePath")%>' alt='../<%#Eval("caloneyName")%>'
                                width="175" height="240"></a> </li>
                    </AlternatingItemTemplate>
                </asp:Repeater>
            </ul>
        </center>
        <br />
        <br />
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
</asp:Content>
