<%@ Page Title="" Language="C#" MasterPageFile="~/InstitutePanel/MasterPage2.master" AutoEventWireup="true" CodeFile="InviteFaculty.aspx.cs" Inherits="InstitutePanel_Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table width="100%" class="NewTableLeft" style=border:1px solid #ccc;" >
        <tr><td>
<asp:UpdatePanel ID="updatepanel1" runat="server">
<ContentTemplate>
<table width="100%">
<tr><td class="H2Center" width="80%" colspan="2">
<asp:UpdateProgress ID="updateprocess1" runat="server" AssociatedUpdatePanelID="updatepanel1">
<ProgressTemplate><img src="../img/control Image/loading.gif"/> </ProgressTemplate>
</asp:UpdateProgress>
</td>
</tr>
<tr>
<td colspan="2">
<div id="tdinformation" runat="server" visible="true">
<section class="ac-container">
<div style="margin-bottom:30px;">
<input id="ac-1" name="accordion-1" type="checkbox" class="checkboxs"/>
<label for="ac-1" class="tab-hdng">Invite Faculty</label>
					
				</div>
                
                <table width="100%" id="Other" runat="server" >
                                                 
                                                    <tr>
                                                        <td style="width:150px;" class="H1Left">
                                                             Full Name<font color="#ff0000">*</font>
                                                        </td>
                                                    <td>
                                                        <asp:TextBox ID="txtCrsFullname" CssClass="txts-flds" runat="server" ></asp:TextBox>
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Insert Name" ControlToValidate="txtCrsFullname"  InitialValue="0" ValidationGroup="majorUnit"></asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                                                <tr>
                                                      <td style="width:150px;">Email-ID<font color="#ff0000">*</font> </td>
                                                  
                                                    <td>
                                                        <asp:TextBox ID="txtCrsShortName" CssClass="txts-flds" runat="server" ></asp:TextBox>
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Insert Email-ID" ControlToValidate="txtCrsShortName"  InitialValue="0" ValidationGroup="majorUnit"></asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                    <tr>
                                                    <td>Contact No</td>
                                                    <td style="height: 20px">
                                                        <asp:TextBox ID="txtEligibility" CssClass="txts-flds" runat="server" ></asp:TextBox>
                                                    </td>
                                                </tr>
                                              
                                                <tr>
<td>Functional Area<span style="color:Red">*</span></td>
<td>
<asp:DropDownList ID="ddlFunctionalArea" runat="server"  CssClass="txts-drps">
                    <asp:ListItem> Select Functional Area</asp:ListItem>
                    <asp:ListItem>Teaching, Education</asp:ListItem>
                    <asp:ListItem>Education/ Teaching/Training</asp:ListItem>
                    <asp:ListItem>Teacher / Lecturer / Professor / Academic Research</asp:ListItem>
                    <asp:ListItem>HR / Administration, IR</asp:ListItem>
                    <asp:ListItem>Teaching</asp:ListItem>
                    <asp:ListItem>Others</asp:ListItem>
                </asp:DropDownList>
<asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="ddlFunctionalArea" Text="*" ForeColor="Red" ValidationGroup="valjd"></asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td>Role<span style="color:Red">*</span></td>
                    <td>
                    <asp:DropDownList ID="ddlRole" runat="server" CssClass="txts-drps">
                          <asp:ListItem>Select Role</asp:ListItem>
                          <asp:ListItem>Advisors</asp:ListItem>
                          <asp:ListItem>Assessor</asp:ListItem>
                          <asp:ListItem>Business Manager/Bursar</asp:ListItem>
                          <asp:ListItem>Classroom Teacher</asp:ListItem>
                          <asp:ListItem>Co-ordinator</asp:ListItem>
                          <asp:ListItem>Consultant</asp:ListItem>
                          <asp:ListItem>Content Specialists</asp:ListItem>
                          <asp:ListItem>Curriculum Leader</asp:ListItem>
                          <asp:ListItem>Customer Support/Manager</asp:ListItem>
                          <asp:ListItem>Deputy Head Teacher</asp:ListItem>
                          <asp:ListItem>Director/Principal</asp:ListItem>
                          <asp:ListItem>Education Officer</asp:ListItem>
                          <asp:ListItem>Educational Psychologist</asp:ListItem>
                          <asp:ListItem>Examiner</asp:ListItem>
                          <asp:ListItem>Freelance Teacher</asp:ListItem>
                          <asp:ListItem>Head of Department</asp:ListItem>
                          <asp:ListItem>Head Teacher</asp:ListItem>
                          <asp:ListItem>Leadership/Excellence Teacher</asp:ListItem>
                          <asp:ListItem>Lecturer</asp:ListItem>
                          <asp:ListItem>Librarian</asp:ListItem>
                          <asp:ListItem>Manager</asp:ListItem>
                          <asp:ListItem>Nursery Teacher</asp:ListItem>
                          <asp:ListItem>Special                                 Needs Teacher</asp:ListItem>
                          <asp:ListItem>Teaching Assistant</asp:ListItem>
                          <asp:ListItem>Tutor</asp:ListItem>
                          
                          <asp:ListItem>Other</asp:ListItem>  
                                       
                         </asp:DropDownList>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="ddlRole" Text="*" ForeColor="Red" ValidationGroup="valjd"></asp:RequiredFieldValidator>
                    </td>
                    </tr>   
                                                                                           
                                                <tr>
                                                         <td>&nbsp;</td>                                                
                                                      
                                                   <td class="H1Center">
                                                        <asp:Button ID="btnSubmit" runat="server" 
                                                             Text="Invite" ValidationGroup="majorUnit" CssClass="cmnt-submt-01" />
                                                        
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="HShort">
                                                        &nbsp;
                                                    </td>
                                                    <td>
                                                    <asp:Label ID="lblMsg" runat="server" CssClass="labelMsgRed" ForeColor="#FF3300"></asp:Label>
                                                    </td>
                                                </tr>
                                            </table>
                
                </section>
                                                                                                                                                                              
                                                 
                                            </div>
                                        </td>
                                        <td valign="top" align="left">
                                        
                                        </td>
                                    </tr>
                                </table>   
              
         
        </ContentTemplate>
    </asp:UpdatePanel>
    </td></tr></table>
</asp:Content>

