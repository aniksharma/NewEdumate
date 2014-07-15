<%@ Page Title="" Language="C#" MasterPageFile="~/InstitutePanel/MasterPage2.master" AutoEventWireup="true" CodeFile="SchoolCollegeList.aspx.cs" Inherits="InstitutePanel_Default4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <link href="../Admin/Css/edumate.css" rel="stylesheet" />
    <table style="height:500px; width:650px; border:1px solid #ccc;">
    <tr>
    <td style="height:50px;"> </td>
    </tr>
        
        
    <tr id="School" runat="server" visible="false">
        <td valign="top"  >
                <asp:Repeater ID="Repeater3" runat="server" OnItemCommand="Repeater3_ItemCommand" >
                    <HeaderTemplate>
                        <table class="MasterTableCenter1">
                            <tr>
                                <th>School Name</th>
                                <th>Year(From)</th>
                                <th>Year(To)</th>
                                <th>Graduation Year</th>
                               <th>Specilization</th>
                                <th> </th>
                                <th></th>
                            </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td><%#Eval("designationName") %> </td>
                            <td><%#Eval("uniID")%></td>
                            <td><%#Eval("catID")%></td>
                            <td> <%#Eval("description")%></td>
                            <td><%#Eval("courseTime") %></td>
                      
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
                <a href="AddSchool.aspx">Add List</a>
            </td>
    </tr>

        <tr id="College" runat="server" visible="false">
        <td valign="top"  >
                <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand" >
                    <HeaderTemplate>
                        <table class="MasterTableCenter1">
                            <tr>
                                <th>College</th>
                               
                                <th>Graduation Year</th>
                               <th>Specilization</th>
                                <th> </th>
                                <th></th>
                            </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td><%#Eval("designationName") %> </td>
                         
                            <td> <%#Eval("description")%></td>
                            <td><%#Eval("courseTime") %></td>
                      
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
                <a href="AddCollege.aspx">Add List</a>
            </td>
    </tr>
        
        
        <tr>
            <td colspan="5" valign="top">
                
            </td>
        </tr>
    </table>
</asp:Content>

