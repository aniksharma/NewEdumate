<%@ Page Title="" Language="C#" MasterPageFile="~/InstitutePanel/MasterPage2.master" AutoEventWireup="true" CodeFile="JD-Form.aspx.cs" Inherits="JobPlacement_JD_Form" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script src="../js/modernizr.custom.29473.js" type="text/javascript"></script>
<p><asp:Button ID="btnInsert" runat="server" Text="Insert" CssClass="cmnt-submt-01" onclick="btnInsert_Click" />
<asp:Button ID="btnView" runat="server" CssClass="sbmts" Text="View" onclick="btnView_Click"/></p>                                     
<asp:UpdatePanel ID="updatePanel1" runat="server">
<ContentTemplate>
<asp:MultiView ID="mvJobDetails" runat="server" ActiveViewIndex="0">
<asp:View ID="JobDescription" runat="server">
<div class="product clearfix">
<section class="ac-container">
<div>
<input id="ac-1" name="accordion-1" type="checkbox" class="checkboxs"/>
<label for="ac-1" class="lbl-tab">Job Description</label>
<article class="ac-large-01">
<table id="Table3" runat="server" style="margin-top:15px;margin-left:10px;">
<tr>
<td style="width:127px;">Title<span style="color:Red">*</span></td>
<td><asp:TextBox ID="txtTitle" CssClass="txts-flds" placeholder="Fill Title" TextMode="MultiLine" Rows="4" Columns="24" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ForeColor="Red" Text="*" ControlToValidate="txtTitle" ValidationGroup="valjd" ></asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td>Salary<span style="color:Red">*</span></td>
<td>
<asp:DropDownList ID="ddlSalary" runat="server" CssClass="txts-drps">
<asp:ListItem>Select Current Salary</asp:ListItem>
<asp:ListItem>10,000 - 14,999</asp:ListItem>
                                <asp:ListItem>15,000 - 19,999</asp:ListItem>
                                <asp:ListItem>20,000 - 24,999</asp:ListItem>
                                <asp:ListItem>25,000 - 29,999</asp:ListItem>
                                <asp:ListItem>30,000 - 34,999</asp:ListItem>
                                <asp:ListItem>35,000 - 39,999</asp:ListItem>
                                <asp:ListItem>40,000 - 44,999</asp:ListItem>
                                <asp:ListItem>45,000 - 49,999</asp:ListItem>
                                <asp:ListItem>50,000 - 54,999</asp:ListItem>
                                <asp:ListItem>55,000 - 59,999</asp:ListItem>
                                <asp:ListItem>60,000 - 64,999</asp:ListItem>
                                <asp:ListItem>65,000 - 69,999</asp:ListItem>
                                <asp:ListItem>70,000 - 99,999</asp:ListItem>
                                <asp:ListItem>1,00,000 - 1,49,999</asp:ListItem>
                                <asp:ListItem>1,50,000 - 1,99,999</asp:ListItem>
                                <asp:ListItem>2,00,000 - 2,99,999</asp:ListItem>
                                <asp:ListItem>3,00,000 - 3,99,999</asp:ListItem>
                                <asp:ListItem>4,00,000 - 4,99,999</asp:ListItem>
                                <asp:ListItem>5,00,000 - 5,99,999</asp:ListItem>
                                <asp:ListItem>6,00,000 +</asp:ListItem>
                                <asp:ListItem>Negotiable</asp:ListItem>
                             </asp:DropDownList>
                             <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="ddlSalary" Text="*" ForeColor="Red" ValidationGroup="valjd"></asp:RequiredFieldValidator>
                    </td>
</tr>
<tr>
<td>Category<span style="color:Red">*</span></td>
<td>
<asp:DropDownList ID="ddlCategory" runat="server" CssClass="txts-drps">
<asp:ListItem>Select category</asp:ListItem>
<asp:ListItem>Schools</asp:ListItem>
<asp:ListItem>College</asp:ListItem>
<asp:ListItem>University</asp:ListItem>
<asp:ListItem>Company</asp:ListItem>
<asp:ListItem>Training/Coaching Institutes</asp:ListItem>
</asp:DropDownList>
<asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="ddlCategory" Text="*" ForeColor="Red" ValidationGroup="valjd"></asp:RequiredFieldValidator>
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
<td>Key Skill<span style="color:Red">*</span></td>
<td><asp:TextBox ID="txtSkill" runat="server" placeholder="Fill Skills" class="txts-flds" TextMode="MultiLine" Rows="4" Columns="24"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ForeColor="Red" Text="*" ControlToValidate="txtSkill" ValidationGroup="valjd" ></asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td>
</td>
<td>
                     </td>
</tr>
                </table>
					</article>
				</div>
				<div>
					<input id="ac-2" name="accordion-1" type="checkbox" class="checkboxs"/>
					<label for="ac-2" class="lbl-tab">Desired Candidate Profile</label>
					<article class="ac-medium">
						<table id="Table1" runat="server" style="margin-left:10px;">
                        
                        <tr>
                            <td>Required Qualification</td>
                            <td><asp:TextBox ID="txtQualification" class="txts-flds" placeholder="UG - Any Graduate - Any Specialization, Graduation Not Required                         
                                " TextMode="MultiLine" Rows="4" Columns="33" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>Job Description</td>
                            <td><asp:TextBox ID="txtJobDescription" placeholder="Job Description" class="txts-flds" TextMode="MultiLine" Rows="4" Columns="33" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                    <td></td>
<td>
</td>
</tr>
</table>
</article>
				</div>
				<div>
					<input id="ac-3" name="accordion-1" type="checkbox" class="checkboxs"/>
					<label for="ac-3" class="lbl-tab">Contact Details</label>
					<article class="ac-large-02">
					<table id="Table2" runat="server" style="margin-top:35px;margin-left:10px;">
                                             <tr>
                            <td>Employer Profile </td>
                            <td><asp:TextBox ID="txtEmployerProfile" class="txts-flds" placeholder="Job Description" TextMode="MultiLine" Rows="4" Columns="33" runat="server"></asp:TextBox></td>
                        </tr>
                          <tr>
                        <td>Organisation Name</td>
                        <td><asp:TextBox ID="txtCompanyName" class="txts-flds" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                        <td>Recruiter Name</td>
                        <td><asp:TextBox ID="txtRecruiterName" class="txts-flds" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                        <td>Address</td>
                        <td><asp:TextBox ID="txtAddress" TextMode="MultiLine" class="txts-flds" Rows="4" Columns="33" runat="server"></asp:TextBox></td>
                        </tr><tr>
                        <td>Email ID</td>
                        <td><asp:TextBox ID="txtEmail" class="txts-flds" runat="server"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                                ControlToValidate="txtEmail" ValidationGroup="valjd" 
                                ErrorMessage="Provide Proper Email" 
                                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                              </td>
                        </tr>
                         <tr>
                        <td>Mobile</td>
                        <td><asp:TextBox ID="txtMobile" class="txts-flds" runat="server"></asp:TextBox>
                        </td>
                        </tr>
                        <tr>
                        <td>Website</td>
                        <td><asp:TextBox ID="txtWebsite" class="txts-flds" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                        <td></td>
                        <td> 
                            <asp:Button ID="btnSubmitFinally" Text="Submit" runat="server" ValidationGroup="valjd"
                             CssClass="sbmts" onclick="btnSubmitFinally_Click"/></td>
                        </tr>
                        <tr>
                        <td colspan="2">
                        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
                        </td>
                        </tr>
                        </table>
					</article>
				</div>
				   </section>
                   
              
                  
                </div>
                 <div class="product clearfix">
                 
                  <div class="productDescription_Contact_Details">
               <p>
                    
                        </p>
                        </div>
                </div>
                </asp:View>

                <asp:View ID="bindGridView" runat="server">

               <div style="overflow-y:hidden;font-weight:normal;">
                <asp:GridView ID="imgGV" runat="server" AutoGenerateColumns="False" 
                            CellPadding="3" 
                            onrowcommand="imgGV_RowCommand" onrowediting="imgGV_RowEditing" 
                        onrowdatabound="imgGV_RowDataBound" BackColor="White" 
                       BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px">
                            <RowStyle ForeColor="#000066" />
                            <Columns>
                             <asp:TemplateField HeaderText="Image Name" Visible="false">
                                    <ItemStyle Width="50px" />
                                    <ItemTemplate>
                                        <asp:Label ID="lblNewsCode" runat="server" Text='<%#Eval("JdID") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Title">
                                    <ItemStyle Width="50px" HorizontalAlign="Center" />
                                    <ItemTemplate>
                                        <asp:Label ID="lblITitle" runat="server" Text='<%#Eval("Title") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Salary">
                                    <ItemStyle Width="50px" HorizontalAlign="Center"/>
                                    <ItemTemplate>
                                        <asp:Label ID="lblSalary" runat="server" Text='<%#Eval("Salary") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                  <asp:TemplateField HeaderText="Category">
                                <ItemStyle Width="50px" HorizontalAlign="Center"/>
                                    <ItemTemplate>
                                        <asp:Label ID="lblCategory" runat="server" Text='<%#Eval("Category") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="Functional Area">
                                <ItemStyle Width="50px" HorizontalAlign="Center"/>
                                    <ItemTemplate>
                                        <asp:Label ID="txtImgType" runat="server" Text='<%#Eval("Functional_Area") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                   <asp:TemplateField HeaderText="Role">
                                <ItemStyle Width="50px" HorizontalAlign="Center"/>
                                    <ItemTemplate>
                                        <asp:Label ID="lblRole" runat="server" Text='<%#Eval("Role") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                   <asp:TemplateField HeaderText="Skill">
                                <ItemStyle Width="50px" HorizontalAlign="Center"/>
                                    <ItemTemplate>
                                        <asp:Label ID="lblSkill" runat="server" Text='<%#Eval("Skill") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                   <asp:TemplateField HeaderText="Required_Qualification" Visible="false">
                                <ItemStyle Width="50px" HorizontalAlign="Center"/>
                                    <ItemTemplate>
                                        <asp:Label ID="lblRequired_Qualification" runat="server" Text='<%#Eval("Required_Qualification") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                  <asp:TemplateField HeaderText="Organisation Name">
                                <ItemStyle Width="50px" HorizontalAlign="Center"/>
                                    <ItemTemplate>
                                        <asp:Label ID="lblOrganisation_Name" runat="server" Text='<%#Eval("Organisation_Name") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                  <asp:TemplateField HeaderText="Recruiter Name">
                                <ItemStyle Width="50px" HorizontalAlign="Center"/>
                                    <ItemTemplate>
                                        <asp:Label ID="lblRecruiter_Name" runat="server" Text='<%#Eval("Recruiter_Name") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                  <asp:TemplateField HeaderText="Address">
                                <ItemStyle Width="50px" HorizontalAlign="Center"/>
                                    <ItemTemplate>
                                        <asp:Label ID="lblAddress" runat="server" Text='<%#Eval("Address") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                  <asp:TemplateField HeaderText="Email_ID">
                                <ItemStyle Width="50px" HorizontalAlign="Center"/>
                                    <ItemTemplate>
                                        <asp:Label ID="lblEmail_ID" runat="server" Text='<%#Eval("Email_ID") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                  <asp:TemplateField HeaderText="Mobile">
                                <ItemStyle Width="50px" HorizontalAlign="Center"/>
                                    <ItemTemplate>
                                        <asp:Label ID="lblMobile" runat="server" Text='<%#Eval("Mobile") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                  <asp:TemplateField HeaderText="Website">
                                <ItemStyle Width="50px" HorizontalAlign="Center"/>
                                    <ItemTemplate>
                                        <asp:Label ID="lblWebsite" runat="server" Text='<%#Eval("Website") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                 <asp:TemplateField HeaderText="Status">
                                    <ItemStyle HorizontalAlign="Center"/>
                                    <ItemTemplate>
                                        <asp:ImageButton ID="imgStat" runat="server" ImageUrl="img/icon_tick_circle.png" CommandName="status" CommandArgument='<%#Eval("Sln") %>' OnClientClick="return Status_confirm()"/>
                                        <asp:Label ID="lblStatus" runat="server" Text="Active"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="Image Action">
                                    <ItemStyle Width="90px" HorizontalAlign="Center" />
                                    <ItemTemplate>
                                        <asp:Panel ID="pnlAction" runat="server">
                                          
                                            <asp:ImageButton ID="imgEdit" runat="server" ImageUrl="img/gtk-edit.png"
                                                CommandName="edit" CommandArgument='<%#Eval("Sln") %>' OnClientClick="return Edit_confirm()"/>&nbsp
                                            <asp:ImageButton ID="delImg" runat="server" ImageUrl="img/delete_icon.gif"
                                                CommandName="del" CommandArgument='<%#Eval("Sln") %>' OnClientClick="return disp_confirm()" />
                                          
                                            &nbsp;</asp:Panel>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Set Pages" Visible="false">
                                    <ItemStyle Width="100px" HorizontalAlign="Center" />
                                    <ItemTemplate>
                                        <a href="PagedImages.aspx?id=<%#Eval("Sln") %>"><img src="images/add_page.png" style="border:0;"/></a>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                            <FooterStyle BackColor="White" ForeColor="#000066" />
                            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                            <SelectedRowStyle BackColor="#4c82b8" ForeColor="White"/>
                            <HeaderStyle BackColor="#4c82b8" ForeColor="White" CssClass="tblehdngs"/>
                            <SortedAscendingCellStyle BackColor="#F1F1F1" />
                            <SortedAscendingHeaderStyle BackColor="#007DBB" />
                            <SortedDescendingCellStyle BackColor="#CAC9C9" />
                            <SortedDescendingHeaderStyle BackColor="#00547E" />
                        </asp:GridView>
               </div>
                
                </asp:View>
            </asp:MultiView>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

