<%@ Control Language="C#" AutoEventWireup="true" CodeFile="newspanel.ascx.cs" Inherits="adminWebControl_newspanel" %>

<div class="box-shadow">
                                            <table style="width: 790px" border="0" cellspacing="0" cellpadding="0">
                                                <tr>
                                                    <td align="left" style="height: 250px; padding-left: 5px;" valign="top">
                                                        <table width="790" border="0" cellspacing="0" cellpadding="0">
                                                            <tr>
                                                                <td align="left" valign="top">
                                                                    <div id="TabbedPanels3" style="width: 790px; height: 243px;" class="TabbedPanels">
                                                                        <ul class="TabbedPanelsTabGroup" style="width: 790px; height: 25px; border-bottom: 1px solid #DADADA;">
                                                                            <li class="TabbedPanelsTab" style="background-color:#91C82F;color:#fff;"  tabindex="0">News</li>
                                                                            <li class="TabbedPanelsTab" style="background-color:#3388E2;color:#fff;"  tabindex="0">Articles</li>
                                                                            <li class="TabbedPanelsTab"  style="background-color:#33C9E2;color:#fff;"  tabindex="0">Alerts</li>
                                                                        </ul>
                                                                        <div class="TabbedPanelsContentGroup" style="width: 790px; height: 210px;">
                                                                            <div class="nav" style="height: 220px; overflow:hidden;">
                                                                                <div style="height:198px; overflow:hidden;">
                                                                                <asp:DataList ID="DataList2" runat="server" RepeatColumns="4" Width="750px" Height="198"
                                                                                    RepeatDirection="Horizontal">
                                                                                    <ItemTemplate>
                                                                                        <div style="padding-top: 5px; padding-right: 5px;">
                                                                                            <img src='<%#Eval("urlPath")%>' width="190" height="90" alt="" /></div>
                                                                                        <div style="font-weight: 600; width: 180px; height: 45px; overflow: hidden;">
                                                                                         
                                                                                            <a href='<%#Eval("accutalPath")%>' style="text-decoration: none;">
                                                                                                <%#Eval("title")%></a>
                                                                                        </div>
                                                                                        <div style="overflow: hidden; height: 70px; width: 180px;">
                                                                                            <%#Eval("status")%></div>
                                                                                    </ItemTemplate>
                                                                                </asp:DataList>
                                                                                </div>
                                                                                <div style="text-align: right; border-top: 1px solid #DADADA; padding-right: 20px;display:compact;">
                                                                                                                                                                                                                                                
                                                                                  <a  href="http://www.edumate.edu.in/education-news"
                                                                                              style="text-decoration: none;" class="link">                                                                                              
                                                                                              More...
                                                                                              </a> 
                                                                                              
                                                                                 
                                                                                </div>
                                                                          
                                                                            </div>
                                                                            <div class="TabbedPanelsContent" style="height: 213px; overflow:hidden; ">
                                                                            <div style=" height:220px;" class="nav"  >
                                                                            <div style="height:195px; overflow: hidden;" >
                                                                                <asp:DataList ID="Artical" runat="server" RepeatDirection="Vertical">
                                                                                   <HeaderTemplate>
                                                                                   <table>
                                                                                   </HeaderTemplate>
                                                                                    <ItemTemplate>
                                                                                        <tr>
                                                                                            <td align="center" valign="middle" style="width: 10px;">
                                                                                                <img src="http://www.edumate.edu.in/img/dot.gif" alt="" />
                                                                                            </td>
                                                                                            <td>
                                                                                             
                                                                                                <a href='<%#Eval("accutalPath")%>' style="text-decoration: none;">
                                                                                                    <div style="overflow: hidden; float: left;">
                                                                                                        <%#Eval("status")%></div>
                                                                                                </a>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </ItemTemplate>
                                                                                    <FooterTemplate>
                                                                                    </table>
                                                                                    </FooterTemplate>
                                                                                </asp:DataList>
                                                                                </div>
                                                                                
                                                                                <div style="text-align: right; border-top: 1px solid #DADADA; padding-right: 20px;display:compact;">
                                                                              
                                                                                   <a  href="http://www.edumate.edu.in/education-articles" 
                                                                                              style="text-decoration: none;" class="link">
                                                                                              
                                                                                              More...
                                                                                              </a> 
                                                                                    
                                                                                  
                                                                                
                                                                                </div>
                                                                                </div>
                                                                            </div>
                                                                            <div class="TabbedPanelsContent" style="height: 213px; overflow:hidden;">
                                                                            <div style=" height:220px;" class="nav"  >
                                                                            <div style="height:195px; overflow: hidden;" >

                                                                            <asp:DataList ID="ddlAlert" runat="server" RepeatDirection="Vertical" Height="198">
                                                                                    <HeaderTemplate>
                                                                                   <table>
                                                                                   </HeaderTemplate>
                                                                                    <ItemTemplate>
                                                                                        <tr>
                                                                                            <td align="center" valign="middle" style="width: 10px;">
                                                                                                <img src="http://www.edumate.edu.in/img/dot.gif" alt="" />
                                                                                            </td>
                                                                                            <td>
                                                                                      
                                                                                                <a href='<%#Eval("accutalPath")%>' style="text-decoration: none;">
                                                                                                    <div style="overflow: hidden; float: left;">
                                                                                                        <%#Eval("status")%></div>
                                                                                                </a>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </ItemTemplate>
                                                                                    <FooterTemplate>
                                                                                    </table>
                                                                                    </FooterTemplate>
                                                                                </asp:DataList>
                                                                                
                                                                                </div>
                                                                                <div style="text-align: right; border-top: 1px solid #DADADA; padding-right: 20px; display:compact; ">
                                                                                
                                                                                 <a  href="http://www.edumate.edu.in/education-alerts" 
                                                                                              style="text-decoration: none;" class="link">
                                                                                              
                                                                                              More...
                                                                                             
                                                                                              </a> 
                                                                               
                                                                                </div>
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </div>