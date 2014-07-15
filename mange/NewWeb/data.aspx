<%@ Page Title="" Language="C#" MasterPageFile="Home.master" AutoEventWireup="true"
    CodeFile="data.aspx.cs" Inherits="mange_NewWeb_data" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="content">

            <div class="aboutcontent">
        <div>
        
            <asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>
                    <table cellpadding="0" cellspacing="0" width="100%">
                </HeaderTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
                <ItemTemplate>
                    <tr>
                        <td>
                            <div style="text-align: justify; padding: 5px 5px 5px 5px">
                            <p>
                                <div style="float: left; padding: 5px 5px 5px 5px">
                                    <img src='<%#"http://www.edumateworld.com/"+Eval("imagePath")%>' runat="server" id="img2" height="150" width="250"
                                        alt='<%#Eval("imageTitle")%>' />
                                </div>
                               <h2>
                                    <%#Eval("imageTitle")%>
                                    </h2>
                                
                                <br />
                                <%#Eval("imageDescription")%>
                                </p>
                            </div>
                        </td>
                    </tr>
                </ItemTemplate>
                <AlternatingItemTemplate>
                    <tr>
                        <td>
                            <div style="text-align: justify; padding: 5px 5px 5px 5px">
                            <p>
                                <div style="float: right; padding: 5px 5px 5px 5px">
                                    <img src='<%#"http://www.edumateworld.com/"+Eval("imagePath")%>' runat="server" id="img2" height="150" width="250"
                                        alt='<%#Eval("imageTitle")%>' />
                                </div>
                               <h2>
                                    <%#Eval("imageTitle")%>
                                    </h2>
                                
                                <br />
                                <%#Eval("imageDescription")%>
                                </p>
                            </div>
                        </td>
                    </tr>
                </AlternatingItemTemplate>
            </asp:Repeater>
                            </div>

        </div>
        <div class="aboutrightblock">
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
    </div>
</asp:Content>
