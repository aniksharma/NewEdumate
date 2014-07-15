<%@ Page Title="" Language="C#" MasterPageFile="~/InstitutePanel/MasterPage2.master" AutoEventWireup="true" CodeFile="List.aspx.cs" Inherits="InstitutePanel_List" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     
    <link href="../Admin/Css/edumate.css" rel="stylesheet" />
<table style="height:500px; width:650px; border:1px solid #ccc;">
    <tr>
    <td style="height:50px;"> </td>
    </tr>
        <tr id="trCollege" runat="server" visible="false">
            <td valign="top"  >
                <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
                    <HeaderTemplate>
                        <table class="MasterTableCenter1">
                            <tr>
                                <th>
                                    Name
                                </th>
                                <th>
                                    Duration
                                </th>
                                <th>
                                    Action
                                </th>
                                
                            </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td >
                                <%#Eval("name") %>
                            </td>
                            <td >
                                <%#Eval("courseTime")%>
                            </td>
                            <td colspan="2" >
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Edit" CommandArgument='<%#Eval("id") %>'>Edit</asp:LinkButton>
                            
                                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="Images/cross.png" CommandArgument='<%#Eval("id") %>'
                                    CommandName="Delete" />
                            </td>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        </table>
                    </FooterTemplate>
                </asp:Repeater>
                <a href="AddTutorSubject.aspx">Add List</a>
            </td>
        </tr>
        
        <tr id="trTutor" runat="server" visible="false">
            <td valign="top"  >
                <asp:Repeater ID="Repeater2" runat="server" 
                    onitemcommand="Repeater2_ItemCommand">
                    <HeaderTemplate>
                        <table class="MasterTableCenter1">
                            <tr>
                                <th>
                                    Category
                                </th>
                                <th>
                                    Sub Category
                                </th>
                                <th>Course Time</th>
                                <th>Fees</th>
                                <th>
                                
                                </th>
                                <th>
                                </th>
                            </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td>
                                <%#Eval("uniID") %>
                            </td>
                            <td><%#Eval("catID")%></td>
                            <td><%#Eval("courseTime")%>&nbsp;&nbsp; <%#Eval("durationMaxTime")%></td>
                            <td><%#Eval("courseFees")%>&nbsp;&nbsp;<%#Eval("examFees")%></td>
                            <td>
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Edit" CommandArgument='<%#Eval("id") %>'>Edit</asp:LinkButton>
                            </td>
                            <td>
                                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="Images/cross.png" CommandArgument='<%#Eval("id") %>'
                                    CommandName="Delete" />
                            </td>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        </table>
                    </FooterTemplate>
                </asp:Repeater>
                <a href="AddCourseList.aspx">Add List</a>
            </td>
        </tr>
        
        
        <tr>
            <td colspan="5" valign="top">
                
            </td>
        </tr>
    </table>
</asp:Content>

