<%@ Page Title="" Language="C#" MasterPageFile="Home.master" AutoEventWireup="true"
    CodeFile="gallery.aspx.cs" Inherits="mange_NewWeb_gallery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="width: 100%; background-color: White">
        <center>
            <link rel="stylesheet" type="text/css" media="screen" href="../mange/NewWeb/css/skin-2.css">
            <link rel="stylesheet" type="text/css" media="screen" href="../mange/NewWeb/css/jquery.fancybox-1.3.4.css">
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
                        <li><a class="plus" href='http://www.edumateworld.com/<%#Eval("imagePath")%>'  style="text-decoration:none;">
                            <img src='http://www.edumateworld.com/<%#Eval("imagePath")%>' alt='../<%#Eval("caloneyName")%>' width="177"
                                height="240"></a>
                    </ItemTemplate>
                    <AlternatingItemTemplate>
                        <a class="plus" href='http://www.edumateworld.com/<%#Eval("imagePath")%>'>
                            <img src='http://www.edumateworld.com/<%#Eval("imagePath")%>' alt='../<%#Eval("caloneyName")%>' width="175"
                                height="240"></a> </li>
                    </AlternatingItemTemplate>
                </asp:Repeater>
            </ul>
        </center>
        <br />
        <br />
    </div>
</asp:Content>
