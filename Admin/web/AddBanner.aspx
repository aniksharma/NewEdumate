<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage/AdminMaster.master" AutoEventWireup="true" CodeFile="AddBanner.aspx.cs" Inherits="Admin_web_AddBanner" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<asp:GridView ID="imgGV" runat="server" AutoGenerateColumns="False" CellPadding="4"
                            ForeColor="#333333" GridLines="None" OnRowCommand="imgGV_RowCommand" OnRowEditing="imgGV_RowEditing"
                            OnRowDataBound="imgGV_RowDataBound">
                            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                            <Columns>
                                <asp:TemplateField HeaderText="News Code" Visible="false">
                                    <ItemStyle Width="120px" />
                                    <ItemTemplate>
                                        <asp:Label ID="lblNewsCode" runat="server" Text='<%#Eval("Time_Id") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Session" Visible="false">
                                    <ItemStyle Width="120px" />
                                    <ItemTemplate>
                                        <asp:Label ID="lblEnrollment_Id" runat="server" Text='<%#Eval("Time_Id") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Subject_Name">
                                    <ItemStyle Width="120px" />
                                    <ItemTemplate>
                                        <asp:Label ID="lblNews" runat="server" Text='<%#Eval("Time_Table") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Class_Name">
                                    <ItemStyle Width="120px" />
                                    <ItemTemplate>
                                        <asp:Label ID="lblDes" runat="server" Text='<%#Eval("Time_Table") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                
                                <asp:TemplateField HeaderText="Status">
                                    <ItemStyle HorizontalAlign="Center" />
                                    <ItemTemplate>
                                        <asp:ImageButton ID="imgStat" runat="server" ImageUrl="images/icon_tick_circle.png"
                                            CommandName="status" CommandArgument='<%#Eval("Sln") %>' />
                                        <asp:Label ID="lblStatus" runat="server" Text="Active"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Delete">
                                    <ItemStyle Width="90px" HorizontalAlign="Center" />
                                    <ItemTemplate>
                                        <asp:Panel ID="pnlAction" runat="server">
                                          
                                            <asp:ImageButton ID="delImg" runat="server" ImageUrl="images/delete_icon.gif" CommandName="del"
                                                CommandArgument='<%#Eval("Sln") %>' OnClientClick="return disp_confirm()" />
                                           
                                            &nbsp;</asp:Panel>
                                    </ItemTemplate>
                                </asp:TemplateField>
                      
                            </Columns>
                            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <EditRowStyle BackColor="#999999" />
                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        </asp:GridView>

</asp:Content>

