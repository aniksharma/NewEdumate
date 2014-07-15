<%@ Control Language="C#" AutoEventWireup="true" CodeFile="adminmenus.ascx.cs" Inherits="adminWebControl_adminmenu" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<link href="~/render/stylesheetedumate.css" rel="stylesheet" type="text/css"/>
<div class="header-top-02">
    <div class="header-top-01-innr-01">
        <div class="navi-top-02">
            <ul>
              

                 <li>
                <asp:LinkButton ID="LinkButton5" runat="server" OnClick="LinkButton5_Click" Style="color: White"> Universities </asp:LinkButton>
                </li>
                 <li>
                <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click" Style="color: White">  College </asp:LinkButton>
                </li>
                 <li>
                <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click" Style="color: White">  School </asp:LinkButton>
                </li>
                <li>
                <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click" Style="color: White">  Institutes </asp:LinkButton>
                </li>
                <li>
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" Style="color: White">  Teacher </asp:LinkButton>
                </li>
          
                <li><a href="#"></a></li>
            </ul>
              </div>
        <div class="search-sectn">
            <input name="" type="text" placeholder="search" class="search-fld-sectn">
            <input name="" type="button" value="search" class="search-btn-setcn-01">
        </div>
    </div>
</div>
<div style="float:right; width: 207px;">
<a href="<%=ResolveClientUrl("~/InstitutePanel/Default.aspx")%>">Home&nbsp;|</a>
    <a href="../logout.aspx">Logout &nbsp;|</a>
    <a target="_blank" href="../mkt/<%=id%>">Go To Website</a><br />
</div>

<div>
   
</div>
<div style="margin: 0 auto; width: 640px;">
    <asp:DropDownList ID="ddlcountry" runat="server" class="slct-fld" AutoPostBack="true"
        OnSelectedIndexChanged="ddlcountry_SelectedIndexChanged" Style="border-left-width: 1px;"
        Visible="false">
    </asp:DropDownList>
    <asp:DropDownList ID="DropDownList1" runat="server" class="slct-fld" AutoPostBack="true" 
        Visible="false" onselectedindexchanged="DropDownList1_SelectedIndexChanged">
    </asp:DropDownList>
    <asp:DropDownList ID="ddl" runat="server" class="slct-fld" Visible="false" AutoPostBack="true"
        OnSelectedIndexChanged="ddl_SelectedIndexChanged">
    </asp:DropDownList>
    <asp:DropDownList ID="Ddledu" runat="server" class="slct-fld" Visible="false" AutoPostBack="true"
        OnSelectedIndexChanged="Ddledu_SelectedIndexChanged">
    </asp:DropDownList>
    <asp:DropDownList ID="ddlUniType" runat="server" class="slct-fld" 
        Visible="false" AutoPostBack="True" 
        onselectedindexchanged="ddlUniType_SelectedIndexChanged">
    </asp:DropDownList>
    <asp:DropDownList ID="ddlexam" runat="server" class="slct-fld" Visible="false">
    </asp:DropDownList>
</div>

