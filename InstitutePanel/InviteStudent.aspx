<%@ Page Title="" Language="C#" MasterPageFile="~/InstitutePanel/MasterPage2.master" AutoEventWireup="true" CodeFile="InviteStudent.aspx.cs" Inherits="InstitutePanel_Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table width="100%" class="NewTableLeft" style=border:1px solid #ccc;" ><tr><td>
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
<label for="ac-1" class="tab-hdng">Invite Student</label>
					
				</div>
                
                <table width="100%" id="Other" runat="server" >
                                                 
                                                    <tr>
                                                        <td style="width:150px;" class="H1Left">
                                                             Full Name <font color="#ff0000">*</font>
                                                        </td>
                                                    <td>
                                                        <asp:TextBox ID="txtCrsFullname" CssClass="txts-flds" runat="server" ></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Insert Name" ControlToValidate="txtCrsFullname" InitialValue="0" ValidationGroup="majorUnit"></asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                                                <tr>
                                                      <td style="width:150px;">Email-ID <font color="#ff0000">*</font> </td>
                                                  
                                                    <td>
                                                        <asp:TextBox ID="txtCrsShortName" CssClass="txts-flds" runat="server" ></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Insert Email-ID" ControlToValidate="txtCrsShortName" InitialValue="0" ValidationGroup="majorUnit"></asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                    <tr>
                                                    <td>Contact No</td>
                                                    <td style="height: 20px">
                                                        <asp:TextBox ID="txtEligibility" CssClass="txts-flds" runat="server" ></asp:TextBox>
                                                    </td>
                                                </tr>
                                               
                                                <tr>
                                                    <td>Class<font color="#ff0000">*</font></td>
                                                    <td>
                                                        <asp:DropDownList ID="DropDownList3" CssClass="txts-drps" runat="server">
                    <asp:ListItem Value="0">Select</asp:ListItem>
                    <asp:ListItem Value="10th">10th</asp:ListItem>
                    <asp:ListItem Value="11th /PUC ">11th /PUC</asp:ListItem>
                    <asp:ListItem Value="12th">12th</asp:ListItem>
                    <asp:ListItem Value="Completed 12th">Completed 12th</asp:ListItem>
                    <asp:ListItem Value="B.A">B.A.</asp:ListItem>
                    <asp:ListItem Value="B.Arch">B.Arch</asp:ListItem>
                    <asp:ListItem Value="B.B.A">B.B.A</asp:ListItem>
                    <asp:ListItem Value="B.Com">B.Com</asp:ListItem>
                    <asp:ListItem Value="B.Ed">B.Ed</asp:ListItem>
                    <asp:ListItem Value="B.Pharm">B.Pharm</asp:ListItem>
                    <asp:ListItem Value="B.P.Th.">Bachelor of Physiotherapy</asp:ListItem>
                    <asp:ListItem Value="B.Sc">B.Sc</asp:ListItem>
                    <asp:ListItem Value="B.Tech/B.E.">B.Tech/B.E.</asp:ListItem>
                    <asp:ListItem Value="BCA">BCA</asp:ListItem>
                    <asp:ListItem Value="BDS">BDS</asp:ListItem>
                    <asp:ListItem Value="BHM">BHM</asp:ListItem>
                    <asp:ListItem Value="B.M.S.">B.M.S.</asp:ListItem>
                    <asp:ListItem Value="BBM">BBM</asp:ListItem>
                    <asp:ListItem Value="BVSc">BVSc</asp:ListItem>
                    <asp:ListItem Value="B.T.M.">Bachelor tourism and managment</asp:ListItem>
                    <asp:ListItem Value="B.Cs.">Bachelor of Computer Science</asp:ListItem>
                    <asp:ListItem Value="CA">CA</asp:ListItem>
                    <asp:ListItem Value="DDS">Doctor of Dental science</asp:ListItem>
                    <asp:ListItem Value="Diploma">Diploma</asp:ListItem>
                    <asp:ListItem Value="Integrated PG">Integrated PG</asp:ListItem>
                    <asp:ListItem Value="LLB">LLB</asp:ListItem>
                    <asp:ListItem Value="LLM">LLM</asp:ListItem>
                    <asp:ListItem Value="M.A">M.A</asp:ListItem>
                    <asp:ListItem Value="M.Arch">M.Arch</asp:ListItem>
                    <asp:ListItem Value="M.Com">M.Com</asp:ListItem>
                    <asp:ListItem Value="M.Ed">M.Ed</asp:ListItem>
                    <asp:ListItem Value="M.Pharm">M.Pharm</asp:ListItem>
                    <asp:ListItem Value="M.Sc">M.Sc</asp:ListItem>
                    <asp:ListItem Value="M.Tech/M.E.">M.Tech/M.E.</asp:ListItem>
                    <asp:ListItem Value="MBA">MBA</asp:ListItem>
                    <asp:ListItem Value="MBBS">MBBS</asp:ListItem>
                    <asp:ListItem Value="MCA">MCA</asp:ListItem>
                    <asp:ListItem Value="MCM">MCM</asp:ListItem>
                    <asp:ListItem Value="M.P.Th.">Master of Physiotherapy</asp:ListItem>
                    <asp:ListItem Value="MS">MS</asp:ListItem>
                    <asp:ListItem Value="MVSc">MVSc</asp:ListItem>
                    <asp:ListItem Value="PG Diploma">PG Diploma</asp:ListItem>
                    <asp:ListItem Value="PGDBA">PGDBA</asp:ListItem>
                    <asp:ListItem Value="PGDM">PGDM</asp:ListItem>
                </asp:DropDownList>
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                            ControlToValidate="DropDownList3" ErrorMessage="Select Class" 
                                                            InitialValue="0" ValidationGroup="majorUnit"></asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                                                 <tr>
                                                    <td>Category<font color="#ff0000">*</font></td>
                                                    <td>
                                                        <asp:DropDownList ID="DropDownList1" CssClass="txts-drps" runat="server">
                    <asp:ListItem Value="0">Select</asp:ListItem>
                    <asp:ListItem Value="10th">10th</asp:ListItem>
                    <asp:ListItem Value="11th /PUC ">11th /PUC</asp:ListItem>
                    <asp:ListItem Value="12th">12th</asp:ListItem>
                    <asp:ListItem Value="Completed 12th">Completed 12th</asp:ListItem>
                    <asp:ListItem Value="B.A">B.A.</asp:ListItem>
                    <asp:ListItem Value="B.Arch">B.Arch</asp:ListItem>
                    <asp:ListItem Value="B.B.A">B.B.A</asp:ListItem>
                    <asp:ListItem Value="B.Com">B.Com</asp:ListItem>
                    <asp:ListItem Value="B.Ed">B.Ed</asp:ListItem>
                    <asp:ListItem Value="B.Pharm">B.Pharm</asp:ListItem>
                    <asp:ListItem Value="B.P.Th.">Bachelor of Physiotherapy</asp:ListItem>
                    <asp:ListItem Value="B.Sc">B.Sc</asp:ListItem>
                    <asp:ListItem Value="B.Tech/B.E.">B.Tech/B.E.</asp:ListItem>
                    <asp:ListItem Value="BCA">BCA</asp:ListItem>
                    <asp:ListItem Value="BDS">BDS</asp:ListItem>
                    <asp:ListItem Value="BHM">BHM</asp:ListItem>
                    <asp:ListItem Value="B.M.S.">B.M.S.</asp:ListItem>
                    <asp:ListItem Value="BBM">BBM</asp:ListItem>
                    <asp:ListItem Value="BVSc">BVSc</asp:ListItem>
                    <asp:ListItem Value="B.T.M.">Bachelor tourism and managment</asp:ListItem>
                    <asp:ListItem Value="B.Cs.">Bachelor of Computer Science</asp:ListItem>
                    <asp:ListItem Value="CA">CA</asp:ListItem>
                    <asp:ListItem Value="DDS">Doctor of Dental science</asp:ListItem>
                    <asp:ListItem Value="Diploma">Diploma</asp:ListItem>
                    <asp:ListItem Value="Integrated PG">Integrated PG</asp:ListItem>
                    <asp:ListItem Value="LLB">LLB</asp:ListItem>
                    <asp:ListItem Value="LLM">LLM</asp:ListItem>
                    <asp:ListItem Value="M.A">M.A</asp:ListItem>
                    <asp:ListItem Value="M.Arch">M.Arch</asp:ListItem>
                    <asp:ListItem Value="M.Com">M.Com</asp:ListItem>
                    <asp:ListItem Value="M.Ed">M.Ed</asp:ListItem>
                    <asp:ListItem Value="M.Pharm">M.Pharm</asp:ListItem>
                    <asp:ListItem Value="M.Sc">M.Sc</asp:ListItem>
                    <asp:ListItem Value="M.Tech/M.E.">M.Tech/M.E.</asp:ListItem>
                    <asp:ListItem Value="MBA">MBA</asp:ListItem>
                    <asp:ListItem Value="MBBS">MBBS</asp:ListItem>
                    <asp:ListItem Value="MCA">MCA</asp:ListItem>
                    <asp:ListItem Value="MCM">MCM</asp:ListItem>
                    <asp:ListItem Value="M.P.Th.">Master of Physiotherapy</asp:ListItem>
                    <asp:ListItem Value="MS">MS</asp:ListItem>
                    <asp:ListItem Value="MVSc">MVSc</asp:ListItem>
                    <asp:ListItem Value="PG Diploma">PG Diploma</asp:ListItem>
                    <asp:ListItem Value="PGDBA">PGDBA</asp:ListItem>
                    <asp:ListItem Value="PGDM">PGDM</asp:ListItem>
                </asp:DropDownList>
<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Select Category" ControlToValidate="DropDownList1" InitialValue="0" ValidationGroup="majorUnit"></asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>    
                                                                                           
                                                <tr>
                                                         <td>&nbsp;</td>                                                
                                                     
                                                   <td class="H1Center">
                                                        <asp:Button ID="btnSubmit" runat="server"  
                                                             Text="Invite" ValidationGroup="majorUnit" CssClass="cmnt-submt-01" OnClick="btnSubmit_Click" />
                                                        
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

