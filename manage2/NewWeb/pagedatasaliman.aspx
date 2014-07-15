<%@ Page Title="" Language="C#" MasterPageFile="~/manage2/NewWeb/homemain.master" AutoEventWireup="true" CodeFile="pagedatasaliman.aspx.cs" Inherits="manage2_NewWeb_pagedatasaliman" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit.HTMLEditor"
    TagPrefix="cc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
<link href="~/manage2/newweb/css/micro-webstyle.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
<div class="main-container-001">
<div class="middle-web-stage-left">
<asp:LinkButton ID="lblWebsite" CssClass="linkbutton"
                                  runat="server" onclick="lblWebsite_Click">
    <span style="padding:9px 5px 5px 40px; color: Black; margin-left: 936px; ">Edit</span></asp:LinkButton>  
    <div id="data" runat="server">
    </div>
    </div>
    </div>
</asp:Content>


