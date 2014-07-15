<%@ Page Title="" Language="C#" MasterPageFile="~/manage2/NewWeb/home2.master" AutoEventWireup="true"
    CodeFile="pageGellary.aspx.cs" Inherits="manage2_NewWeb_pageGellary" %>
    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit.HTMLEditor"
    TagPrefix="cc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

           <link rel="stylesheet" type="text/css" media="screen" href="~/mange/NewWeb/css/skin-2.css" />
            <link rel="stylesheet" type="text/css" media="screen" href="~/mange/NewWeb/css/jquery.fancybox-1.3.4.css" />
            <script  type="text/javascript" src="~/mange/NewWeb/js/jquery-1.7.min.js"></script>
            <script  type="text/javascript" src="~/mange/NewWeb/js/jquery.easing.1.3.js"></script>
            <script  type="text/javascript" src="~/mange/NewWeb/js/jquery.jcarousel.min.js"></script>
            <script  type="text/javascript" src="~/mange/NewWeb/js/jquery.fancybox-1.3.4.pack.js"></script>
            <script  type="text/javascript" src="~/mange/NewWeb/js/JScript.js" type="text/javascript"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="width: 100%; background-color: White">
    
  <asp:LinkButton ID="lblWebsite" CssClass="linkbutton"
                                  runat="server" onclick="lblWebsite_Click"><span style="padding:9px 5px 5px 40px; color: Black; margin-left: 936px; ">Edit</span></asp:LinkButton>
        <center>
            <h3 id="ih3" runat="server">
                Image Gallery
            </h3>
            <ul id="mycarousel-1" class="jcarousel-skin-tango">
                <asp:Repeater ID="datalist" runat="server">
                    <HeaderTemplate>
                    </HeaderTemplate>
                    <FooterTemplate>
                    </FooterTemplate>
                    <ItemTemplate>
                        <li><a class="plus" href='../../../<%#Eval("imagePath")%>' style="text-decoration: none;">
                            <img src='../../../<%#Eval("imagePath")%>' alt='<%#Eval("caloneyName")%>'
                                width="177" height="240"></a>
                    </ItemTemplate>
                    <AlternatingItemTemplate>
                        <a class="plus" href='../../../<%#Eval("imagePath")%>'>
                            <img src='../../../<%#Eval("imagePath")%>' alt='<%#Eval("caloneyName")%>'
                                width="175" height="240"></a> </li>
                    </AlternatingItemTemplate>
                </asp:Repeater>
            </ul>
        </center>
        <br />
        <br />
   



    
    
          </div>


</asp:Content>

