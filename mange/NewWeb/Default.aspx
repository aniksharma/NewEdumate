<%@ Page Title="" Language="C#" MasterPageFile="Home.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="mange_NewWeb_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="content">
        <div class="subcontent1">
            <div class="leftimgbox">
                <img id="imgwelcome" runat="server" style="float: left;" src="" height="200" width="180" /></div>
            <h2>
                Welcome</h2>
            <div id="datawelcome" runat="server">
            </div>
            <span class="more"><a href="#">More</a></span>
        </div>
        <div class="box1">
            <h3>
                Quick Links</h3>
            <ul>
                <asp:Repeater ID="repQuickLinks" runat="server">
                    <ItemTemplate>
                        <li><a href='<%#Quicklink(Eval("caloneyId"))%>'><%#Eval("caloneyName")%></a>
                             </li>

                    </ItemTemplate>


      

                </asp:Repeater>
            </ul>
        </div>
        <div class="subcontent2">
            <h2>
                About Us</h2>
            <div id="dataaboutus" runat="server">
            </div>
            <span class="more"><a href="#">More</a></span>
        </div>
        <div class="box2">
            <h3>
                Quick Gallery</h3>
            <ul>
                <asp:Repeater ID="repQuickGallery" runat="server">
                    <ItemTemplate>
                            <li><a href='<%#gallerylink(Eval("caloneyId"))%>'><%#Eval("caloneyName")%></a>
                             </li>
                    
                    </ItemTemplate>
                </asp:Repeater>
            </ul>
        </div>
        <div class="widesubcontent">
            <div class="rightbox">
                <img id="imgInfrastru" runat="server" src="" height="200" width="180" /></div>
            <h2>
                Infrastructure</h2>
            <div id="dataInfrastur" runat="server">
            </div>
            <span class="more"><a href="#">More</a></span>
        </div>
        <div class="widesubcontent">
            <div class="leftbox">
                <img id="imgAchiviment" runat="server" src="" height="200" width="180" /></div>
            <h2>
                Achivement</h2>
            <div id="dataachAchivement" runat="server">
            </div>
            <span class="more"><a href="#">More</a></span>
        </div>
        <div class="widesubcontent">
            <div class="rightbox">
                <img id="imgActivites" runat="server" src="" height="200" width="180" /></div>
            <h2>
                Activites
            </h2>
            <div id="dataActivites" runat="server">
            </div>
            <span class="more"><a href="#">More</a></span>
        </div>
        <div class="widesubcontent">
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
        </div>
    </div>
</asp:Content>
