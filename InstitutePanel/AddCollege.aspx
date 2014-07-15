<%@ Page Title="" Language="C#" MasterPageFile="~/InstitutePanel/MasterPage2.master" AutoEventWireup="true" CodeFile="AddCollege.aspx.cs" Inherits="InstitutePanel_Default3" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit.HTMLEditor"
    TagPrefix="cc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <link href="~/render/stylesheetedumate.css" rel="stylesheet" type="text/css" />
    <script src="~/JS/jquery.easing.js" type="text/javascript"></script>
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.6.4/jquery.min.js"></script>
    <script src="~/JS/jqueryTab.js" type="text/javascript"></script>
    <script type="text/javascript">


        $(document).ready(function () {

            //Default Action
            $(".tab_content").hide(); //Hide all content
            $("ul.tabs li:first").addClass("active").show(); //Activate first tab
            $(".tab_content:first").show(); //Show first tab content

            //On Click Event
            $("ul.tabs li").click(function () {
                $("ul.tabs li").removeClass("active"); //Remove any "active" class
                $(this).addClass("active"); //Add "active" class to selected tab
                $(".tab_content").hide(); //Hide all tab content
                var activeTab = $(this).find("a").attr("href"); //Find the rel attribute value to identify the active tab + content
                $(activeTab).fadeIn(); //Fade in the active content
                return false;
            });

        });

    </script>
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
    <section class="ac-container">
    <label for="ac-1" class="tab-hdng">Update College</label>
     
        
        <div id="Htab1" class="tab_content" 
                         style="display:block;border-top-style: solid; border-top-width: thin;
 border-top-color: #C0C0C0; border-bottom-style: solid; border-bottom-width: thin; border-bottom-color: #C0C0C0;">
        <asp:UpdatePanel ID ="UpdatePanel6" runat ="server">
        <ContentTemplate>
       
        <div style="margin-bottom:15px; margin-top :10px;"  id ="ww" runat ="server">
        <label class="lbls-wdth" style="text-align:left">Country</label>
            <asp:DropDownList ID ="HddlCountry" runat ="server" AutoPostBack ="true" 
                class="txts-drps"  onselectedindexchanged="HddlCountry_SelectedIndexChanged" >
        </asp:DropDownList>
        </div>
        
          <div style="margin-bottom:15px;" id ="Hstate" runat ="server">
        <label class="lbls-wdth">State</label><asp:DropDownList ID ="Hddlstate" runat ="server" AutoPostBack ="true" 
                  class="txts-drps" onselectedindexchanged="Hddlstate_SelectedIndexChanged"> 
        </asp:DropDownList>
        </div>

        
          <div style="margin-bottom:15px;" id ="Div2" runat ="server" >
        <label class="lbls-wdth">University</label><asp:DropDownList ID ="ddluniv" runat ="server" AutoPostBack ="false"
                  class="txts-drps">
        <asp:ListItem Value ="0">-Select-</asp:ListItem>
        
        </asp:DropDownList>
        </div>

         
          <div style="margin-bottom:15px;" id ="HSchool" runat ="server" >
        <label class="lbls-wdth">College</label><asp:DropDownList ID ="HddlSchool" runat ="server" AutoPostBack ="true"
                  class="txts-drps" onselectedindexchanged="HddlSchool_SelectedIndexChanged">
        <asp:ListItem Value ="0">-Select-</asp:ListItem>
        
        </asp:DropDownList>
        </div>
        </ContentTemplate><Triggers></Triggers></asp:UpdatePanel>
        
          <div style="margin-bottom:15px;" id ="Hfrom" runat ="server">
       <label class="lbls-wdth">Department</label><asp:DropDownList ID ="Hddlfrom" runat ="server" class="txts-drps">
        <asp:ListItem Value ="0">-Select-</asp:ListItem>
        <asp:ListItem Value ="1">-Arts-</asp:ListItem>
        <asp:ListItem Value ="2">-Science-</asp:ListItem>
        <asp:ListItem Value ="3">-Computer Science-</asp:ListItem>
        
        </asp:DropDownList>
        </div>
          <div style="margin-bottom:15px;" id ="Hto" runat ="server">
        <label class="lbls-wdth">Mode_Of_Study</label><asp:DropDownList ID ="Hddlto" runat ="server" class="txts-drps">
        <asp:ListItem Value ="0">-Select-</asp:ListItem>
         <asp:ListItem Value ="1">-Part Time-</asp:ListItem>
        <asp:ListItem Value ="2">-Full Time-</asp:ListItem>
        <asp:ListItem Value ="3">-Distance Learning-</asp:ListItem>
        </asp:DropDownList>
        </div>
          <div style="margin-bottom:15px;" id ="Hgrd" runat ="server">
       <label class="lbls-wdth"> Graduation year</label><asp:DropDownList ID ="Hddlgrd" runat ="server" class="txts-drps">
        <asp:ListItem Value ="0">-Select-</asp:ListItem>
        
        </asp:DropDownList>
        </div>
          <div style="margin-bottom:15px;" id ="Hspc" runat ="server">
        <label class="lbls-wdth">Specialization</label><asp:TextBox ID ="Htxtspc" runat ="server" class="txts-drps"></asp:TextBox>
        
        
        </div>
         <div>
        
        </div>
         </div>
    <div>
                <asp:Button ID ="Hbtn3" runat ="server" Text ="Save" OnClick ="Hbtn3_Click" />
        <asp:Label ID ="msg2" runat="server" Text ="Insert Successfully..." ForeColor ="Red" Visible ="false" ></asp:Label>
                </div>
        
          </section>
</asp:Content>

