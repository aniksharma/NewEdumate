<%@ Page Title="" Language="C#" MasterPageFile="~/InstitutePanel/MasterPage2.master" AutoEventWireup="true" CodeFile="AddSchool.aspx.cs" Inherits="InstitutePanel_Default3" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit.HTMLEditor"
    TagPrefix="cc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <link href="~/render/stylesheetedumate.css" rel="stylesheet" type="text/css" />
    <script src="~/JS/jquery.easing.js" type="text/javascript"></script>
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.6.4/jquery.min.js"></script>
    <script src="~/JS/jqueryTab.js" type="text/javascript"></script>
    <style>
        
.txts-drps {
width: 322px;
padding: 0px;
background-color: #FFF;
border: 1px solid #999;
color: #666;
float: right;

}
.txts-flds {
width: 314px;
padding: 3px;
background-color: #FFF;
border: 1px solid #999;
color: #666;
float: right;
}

    </style>
    <asp:UpdatePanel ID="updatepanel1" runat="server">
        <ContentTemplate>
            <section class="ac-container">      
                    
       <div class="tab-spc">
                 <div style="display: block; background:white;width:716px;" >
        <div id="tab1" class="tab_content" 
          style="display:block;border-top-style:solid;border-top-width: thin; border-top-color: #C0C0C0; 
border-bottom-style: solid; border-bottom-width: thin; border-bottom-color: #C0C0C0;">
        <asp:UpdatePanel ID ="UpdatePanel4" runat ="server">
        <ContentTemplate>
        <br />
        <div style="margin-bottom:5px;">
        <label class="lbls-wdth">Country</label>
        <asp:DropDownList ID ="ddlCountry"  class="txts-drps" runat ="server" AutoPostBack ="true" 
                 onselectedindexchanged="ddlCountry_SelectedIndexChanged">
        </asp:DropDownList>
        </div>
          <div id ="state" runat ="server"  style="margin-bottom:5px;">
        <label class="lbls-wdth">State</label>
        <asp:DropDownList ID ="ddlstate" runat ="server" AutoPostBack ="true" 
                  class="txts-drps" onselectedindexchanged="ddlstate_SelectedIndexChanged">
        </asp:DropDownList>
        </div>
         <div id ="School" runat ="server" style="margin-bottom:5px;">
         <label class="lbls-wdth"> School </label> 
         <asp:DropDownList ID ="ddlSchool" runat ="server" AutoPostBack ="true"
                 class="txts-drps" onselectedindexchanged="ddlSchool_SelectedIndexChanged">
        </asp:DropDownList>
        </div>
        </ContentTemplate>
        <Triggers></Triggers>
        </asp:UpdatePanel>
                  <div id ="from" runat ="server" style="margin-bottom:5px;">
        <label class="lbls-wdth"> From </label>
                      <asp:DropDownList ID ="ddlfrom" class="txts-drps" runat ="server" OnSelectedIndexChanged="ddlfrom_SelectedIndexChanged" >       
        <asp:ListItem Value ="0">-Select-</asp:ListItem>
        
        </asp:DropDownList>
        </div>
                  <div id ="to" runat ="server" style="margin-bottom:5px;">
        <label class="lbls-wdth" >To</label>
        <asp:DropDownList ID ="ddlto" runat ="server" class="txts-drps">
        <asp:ListItem Value ="0">-Select-</asp:ListItem>
        
        </asp:DropDownList>
        </div>

          <div  id ="grd" runat ="server" style="margin-bottom:5px;">
        <label class="lbls-wdth">Graduation year</label><asp:DropDownList ID ="ddlgrd" runat ="server" class="txts-drps">
        <asp:ListItem Value ="0">-Select-</asp:ListItem>
        
        </asp:DropDownList>
        </div>
        <div id ="spc" runat ="server" style="margin-bottom:5px;">
        <label class="lbls-wdth">Specialization</label><asp:TextBox ID ="txtspc" runat ="server" class="txts-flds"></asp:TextBox>
        </div>
         
         </div>
        

        <div> 
                <asp:Button ID ="btn3" runat ="server" Text ="Save" OnClick ="btn3_Click"/>
                <asp:Label ID ="lblmsg1" runat ="server" Text ="Insert Successfully..." ForeColor ="Red" Visible ="false"></asp:Label>
                </div>
        </div>
       
        </div>
        
				
				</section>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

