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
                                                                                      
                                                                                        <div style="font-weight: 600; width: 180px; height:45px; overflow: hidden;">
                                                                                            <%--<a  href='<%# String.Format("http://www.edumate.edu.in/latest-education-news/{0}/{1}/{2}/{3}"
                                                                                           , title1(Eval("title")),Eval("Id"),Eval("catID"),(1) ) %>'
                                                                                              style="text-decoration: none;"><%# Eval("title")%></a>--%> 
                                                                                            
                                                                                            <a href='<%#"NewsDetail.aspx?id="+Eval("Id")%>&&TypeId=<%#Eval("catID")%>&&uniID=1'
                                                                                                style="text-decoration: none;">
                                                                                                <%#Eval("title")%></a>

                                                                                                </div>                                                                                        
                                                                                        
                                                                                        <div style="overflow: hidden; height: 70px; width: 180px;">
                                                                                            <%#Eval("status")%></div>
                                                                                    </ItemTemplate>
                                                                                </asp:DataList>
                                                                                </div>
                                                                                <div style="text-align: right; border-top: 1px solid #DADADA; padding-right: 20px;display:compact;">
                                                                                                                                                                                                                                                
                                                                                  <a  href="http://www.edumate.edu.in/education-news/1"
                                                                                              style="text-decoration: none;" class="link">                                                                                              
                                                                                              More...
                                                                                              </a> 
                                                                                               <%--
                                                                                    <a href='newscommon.aspx?TypeId=7&&uniID=1&&Name=Daily Education News'>More...</a>  
                                                                                    --%>
                                                                                 
                                                                                </div>
                                                                                <%--<div id="News12" style="visibility: hidden; position: absolute; height: 40px; width: 40px;
                                                                                    float: right; margin-left: 400px; margin-top: -96px;">
                                                                                    <img alt="Loading..." src="../img/control Image/loading.gif" style="width: 40px;
                                                                                        height: 40px" />
                                                                                </div>
                                                                                <div style="text-align: right; border-top: 1px solid #DADADA; padding-right: 20px;">
                                                                                    <asp:Label ID="lblPageIndex" runat="server" Visible="false" Text="1"></asp:Label>
                                                                                    <asp:Label ID="lblStartRecord" runat="server">1</asp:Label>&nbsp;To&nbsp;
                                                                                    <asp:Label ID="lblEndRecord" runat="server">4</asp:Label>&nbsp;of&nbsp;
                                                                                    <asp:Label ID="lblTotal" runat="server"></asp:Label>
                                                                                    <asp:ImageButton ID="btnPre" ImageUrl="../img/control Image/prev.png" OnClientClick="ddlChkSelect('News12');"
                                                                                        OnClick="LinkButton1_Click1" runat="server" />
                                                                                    <asp:ImageButton ID="btnnext" ImageUrl="../img/control Image/next.png" OnClientClick="ddlChkSelect('News12');"
                                                                                        OnClick="LinkButton2_Click" runat="server" />
                                                                                </div>--%>
                                                                            </div>
                                                                            <div class="TabbedPanelsContent" style="height: 213px; overflow:hidden; ">
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
                                                                                            <%--<a  href='<%# String.Format("http://www.edumate.edu.in/latest-education-alert/{0}/{1}/{2}/{3}"
                                                                                           , title1(Eval("status")),Eval("Id"),Eval("catID"),(1) ) %>'
                                                                                              style="text-decoration: none;" class="link">
                                                                                              <div style="overflow: hidden; float: left;">
                                                                                              <%# Eval("status")%>
                                                                                              </div>
                                                                                              </a> --%>

                                                                                              <a href='<%#"NewsDetail.aspx?id="+Eval("Id")%>&&TypeId=<%#Eval("catID")%>&&uniID=1'
                                                                                                    style="text-decoration: none;" class="link">
                                                                                                    <div style="overflow: hidden; float: left;">
                                                                                                        <%#Eval("status")%></div>
                                                                                                </a
                                                                                              
                                                                                                
                                                                                            </td>
                                                                                        </tr>
                                                                                    </ItemTemplate>
                                                                                    <FooterTemplate>
                                                                                    </table>
                                                                                    </FooterTemplate>
                                                                                </asp:DataList>
                                                                                </div>
                                                                                
                                                                                <div style="text-align: right; border-top: 1px solid #DADADA; padding-right: 20px;display:compact;">
                                                                              
                                                                                   <a  href="http://www.edumate.edu.in//education-alerts/2" 
                                                                                              style="text-decoration: none;" class="link">
                                                                                              
                                                                                              More...
                                                                                              </a> 
                                                                                    
                                                                                   <%--
                                                                                    <a href='newscommon.aspx?TypeId=8&&uniID=1&&Name=Latest Articles'>More...</a>  --%>
                                                                              
                                                                                
                                                                                </div>
                                                                                </div>
                                                                            </div>
                                                                            <div class="TabbedPanelsContent" style="height: 213px; overflow:hidden;">
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
                                                                                                <%--<a  href='<%# String.Format("http://www.edumate.edu.in/latest-education-artical/{0}/{1}/{2}/{3}"
                                                                                           , title1(Eval("status")),Eval("Id"),Eval("catID"),(1) ) %>'
                                                                                              style="text-decoration: none;" class="link">
                                                                                              <div style="overflow: hidden; float: left;">
                                                                                              <%# Eval("status")%>
                                                                                              </div>
                                                                                              </a> --%>

                                                                                              <a href='<%#"NewsDetail.aspx?id="+Eval("Id")%>&&TypeId=<%#Eval("catID")%>&&uniID=1'
                                                                                                    style="text-decoration: none;" class="link">
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
                                                                                
                                                                                 <a  href="http://www.edumate.edu.in/education-articles/3" 
                                                                                              style="text-decoration: none;" class="link">
                                                                                              
                                                                                              More...
                                                                                             
                                                                                              </a> 
                                                                                <%--              
                                                                              <a href='newscommon.aspx?TypeId=9&&uniID=1&&Name=Latest Alert'>More...</a>
                                                                               --%>
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