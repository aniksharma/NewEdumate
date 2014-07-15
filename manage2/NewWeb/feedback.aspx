<%@ Page Title="" Language="C#" MasterPageFile="home2.master"  AutoEventWireup="true" CodeFile="feedback.aspx.cs" Inherits="Contactus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div  style="margin-top:20px;">	                     
                <div class="block-6">
                    <h3>Get In Touch</h3>
                   
                      <fieldset>
                  <div id="form" >     
                       <table align="center" width="100%" cellspacing="0" cellpadding="0" border="0">
  <tbody><tr>
    
    <td width="100%" valign="top">
	
	<table align="center" width="90%" cellspacing="4" cellpadding="2" class="para">
                        <tbody><tr>
                          <td align="center" height="42" class="dark_black" colspan="2">
							    <asp:Label ID="lblMsg" runat="server"></asp:Label>
							    </td>
                        </tr>
                        <tr>
                            <td width="24%" class="style1"> First Name: <span style="color:Red;visibility:hidden;" id="rfvName">*</span></td>
                            <td width="76%" style="color: #000000;" class="style1">
                                
                                
    <asp:TextBox ID="txtFirstName" Width="319px"   runat="server"></asp:TextBox>	
                                					  <asp:RequiredFieldValidator ID="RequiredFieldValidator3" 
                                    runat="server" ControlToValidate="txtFirstName" 
                                    ErrorMessage="First Name !" ValidationGroup="yy"></asp:RequiredFieldValidator>
                                					  </td>
                        </tr>
                        <tr>
                            <td height="40">
                                Last Name: <span style="color:Red;visibility:hidden;" id="rfvEnroll">*</span></td>
                            <td style="width: 85%">
    <asp:TextBox ID="txtLastName" Width="319px"   runat="server"></asp:TextBox>	</td> 
                        </tr>
                        <tr>
                          <td height="40"> Email Id:</td>
                          <td>
                              <asp:TextBox ID="txtEmailID" Width="319px"   runat="server"></asp:TextBox>	

                             

                              <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                  ControlToValidate="txtEmailID" ErrorMessage="Email ID !" 
                                  ValidationGroup="yy"></asp:RequiredFieldValidator>

                          </td>
                        </tr>
                        <tr>
                          <td height="40"> Mobile No: <span style="color:Red;visibility:hidden;" id="RequiredFieldValidator2">*</span></td>
                          <td style="width: 85%">
                              <asp:TextBox ID="txtMobileNo" Width="320px"   runat="server"></asp:TextBox>	

                              <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                  ControlToValidate="txtMobileNo" ErrorMessage="Mobile No.!" 
                                  ValidationGroup="yy"></asp:RequiredFieldValidator>

                          </td>
                        </tr>
                        <tr>
                            <td height="40" style="width: 15%; height: 63px;">
                                Remarks: <span style="color:Red;visibility:hidden;" id="RequiredFieldValidator1">* <td style="width: 85%; height: 63px;">
                                                             
                                    <asp:TextBox ID="txtRemarks" Width="320px"   runat="server" Height="100px" 
                                        TextMode="MultiLine"></asp:TextBox>	

                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                                ControlToValidate="txtRemarks" ErrorMessage="Remarks!" 
                                        ValidationGroup="yy"></asp:RequiredFieldValidator>

                                </td></tr>
                        <tr>
                            <td height="40">Varification: <span style="color:Red;visibility:hidden;">*</span></td>
                            <td style="width: 85%">
                            <div style="border:solid 1px Gray; text-align:center;font-weight:bold;background-image:url(http://www.edumate.edu.in/Add Institute/Images/i-02.gif);background-position:center;background-repeat:repeat-x;height:35px;width:100px;color:Blue;font-family:lucida grande,sans-serif;font-size:16px;line-height:33px; ">
                                            <asp:Label ID="Label2" runat="server" ></asp:Label></div>                          
                                            <asp:TextBox ID="Veryfycode" runat="server" style="width:319px"></asp:TextBox>                              
                                          <div  style="float:right; margin-right:335px; top:10px;">  
                                              <asp:ImageButton ID="ImageButton1" runat="server" Height="27px" Width="27px" 
                                    ImageUrl="http://www.edumate.edu.in/Add Institute/images/referesh.jpg" onclick="ImageButton1_Click" />    </div>    
                                <asp:Label ID="Label1" runat="server" ForeColor="#CC3300"></asp:Label>
                                            
                              </td>
                        </tr>
                        <tr>
                          <td height="40"></td>
                          <td style="width: 85%" class="btns">
                          <div>
                          <table cellpadding="0" cellspacing="0" width="80%">
                         <tr>
                         <td style="width:30%; float:left">
                         <asp:Button ID="Button3" runat="server" OnClientClick="ddlChkSelect('Submit');" onclick="Button3_Click" Text="Submit" 
                                 ValidationGroup="yy"  style="height:30px; width:60px" CssClass="submit"/>
                         <div id="Submit" style="visibility: hidden;">
                                                                    <img alt="Loading..." src="../../Search/Search_files/loading.gif" style="width:50px; height:50px" />

                                                                </div>
                         </td>
                         <td style="float:left;" valign="top" align="left">
                           <asp:Button ID="Button1" runat="server" Text="Clear"  CssClass="submit" 
                            CausesValidation="false" style=" height:30px; width:60px"/>
                         </td>
                         </tr>
                          </table>
       
    </div></td>
                        </tr>
                        <tr>
                        
                          <td style="width: 20%"></td>
                          <td style="width: 80%">&nbsp;</td>
                        </tr>
        </tbody></table>
  </td>
  </tr>
</tbody></table>
                  </div>
                        </fieldset>  
                   
                </div>                      
          <div class="clear"></div>
        </div>

</asp:Content>

