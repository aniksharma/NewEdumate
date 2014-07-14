<%@ Page Title="" Language="C#" MasterPageFile="~/InstitutePanel/MasterPage2.master" AutoEventWireup="true" CodeFile="CreateFolder.aspx.cs" Inherits="Academy_CreateFolder" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit.HTMLEditor" TagPrefix="cc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <%--Institute-  2
School-     3
College-    4
Tutor-      5--%>
<h1>Eduamte User :Assignment Templates</h1>
<asp:Button ID="btnInsert" runat="server" Text="Insert" CssClass="cmnt-submt-01" onclick="btnInsert_Click" />
    <asp:Button ID="btnView" runat="server" Text="View" CssClass="sbmts" onclick="btnView_Click" />
  <asp:MultiView ID="mvAssignment" runat="server" ActiveViewIndex="0">
                <asp:View ID="Assignment" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
   <ContentTemplate>
<table id="tblAcademy" runat="server">

    <tr>
    <td>Type</td>
     <td>Category</td>
      <td>Sub Category</td>
        
    </tr>
    <tr>
        
        <td><asp:DropDownList ID="ddlType" CssClass="DropdwonLong" runat="server">
        <asp:ListItem>--Select Type--</asp:ListItem>
        <asp:ListItem>Test</asp:ListItem>
        <asp:ListItem>Notes</asp:ListItem>
        <asp:ListItem>Practicle</asp:ListItem>
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" ControlToValidate="ddlType" ValidationGroup="g1CreateF" InitialValue="--Select Type--"></asp:RequiredFieldValidator>
        </td>

       
        <td><asp:DropDownList ID="ddlCategory" CssClass="DropdwonLong" runat="server" AutoPostBack="true"
                onselectedindexchanged="ddlCategory_SelectedIndexChanged">
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="ddlCategory" ValidationGroup="g1CreateF" InitialValue="--Select Category--"></asp:RequiredFieldValidator>
                </td>

        
        <td><asp:DropDownList ID="ddlSubCategory" CssClass="DropdwonLong" runat="server"></asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ControlToValidate="ddlSubCategory" ValidationGroup="g1CreateF" InitialValue="--Select Sub-Category--"></asp:RequiredFieldValidator>
        </td>
    </tr>
   
   <tr>
    <td>Title</td>
   </tr>
    <tr>
    <td colspan="4"><asp:TextBox ID="txtTitle" CssClass="txtbox-fld" Width="651px" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="reqTitle" runat="server" Text="*" ForeColor="Red" ControlToValidate="txtTitle" ValidationGroup="g1CreateF" ></asp:RequiredFieldValidator>
    </td>
    </tr>

    <tr>
        <td>Description</td>
    </tr>
    <tr>
        <td colspan="4"><asp:TextBox ID="txtDescription" runat="server" CssClass="txtbox-fld" Width="651px" Height="50px" TextMode="MultiLine"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Text="*" ForeColor="Red" ControlToValidate="txtDescription" ValidationGroup="g1CreateF" ></asp:RequiredFieldValidator>
        </td>
    </tr>
    
    <tr>
        <td>Uploading Documents</td>
    </tr>
    <tr>
        <td>
         <asp:RadioButton ID="rdbPaste" Text="Paste" GroupName="VData" Checked="true" runat="server" AutoPostBack="true"
                oncheckedchanged="rdbPaste_CheckedChanged"/>
            <asp:RadioButton ID="rdbUpload" Text="Upload" GroupName="VData"  runat="server" AutoPostBack="true"
                oncheckedchanged="rdbUpload_CheckedChanged"/>
           
        </td>
    </tr>
    
    <tr>
    <td colspan="3">
        <asp:FileUpload ID="FileUploadData"  runat="server" />
        <cc1:editor ID="txt_desc" Visible="false" runat="server" Height="300px" Width="660px" />
    </td>
    </tr>
    
    <tr>
        <td colspan="3">
        <asp:RadioButton ID="rdbPublic" Checked="true" Text="Public" GroupName="gp" runat="server"/>
        <asp:RadioButton ID="rdbPrivate" Text="Private" GroupName="gp" runat="server"/>
        <asp:RadioButton ID="rdbEdumateCommunity" Text="Edumate Community" GroupName="gp" runat="server"/></td>
    </tr>
    <tr>
    <td colspan="2">
        Allow comments: <asp:CheckBox ID="chkcomments" Checked="true" runat="server" />
    </td>
    </tr>
    <tr>
        <td colspan="2">
        <asp:Button ID="btnSave" runat="server" CssClass="bnt-sbmt-01" Text="Save" ValidationGroup="g1CreateF"
                onclick="btnSave_Click" /> || <asp:Button ID="btnCancel" CssClass="bnt-sbmt-01" runat="server" Text="Cancel" />
        </td>
    </tr>
    <tr>
    <td colspan="2">
    <asp:Label ID="lblMSg" runat="server" Font-Bold="True" Font-Size="X-Large"></asp:Label>
    </td>
    </tr>
</table>
</ContentTemplate>
 </asp:UpdatePanel>
 </asp:View>

  <asp:View ID="View1" runat="server">  
   <%-- <asp:UpdatePanel ID="UpdatePanel2" runat="server">
   <ContentTemplate>--%>
  <p style="height:20px;">
  <asp:Label ID="lblViewMsg" runat="server" Text=""></asp:Label>
  </p>
  <asp:Literal ID="litbinddata" runat="server"></asp:Literal>

     <%-- </ContentTemplate>
 </asp:UpdatePanel>--%>
  </asp:View>
 </asp:MultiView>
</asp:Content>


