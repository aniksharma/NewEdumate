<%@ Page Title="" Language="C#" MasterPageFile="~/InstitutePanel/MasterPage2.master" AutoEventWireup="true" CodeFile="AddTutorSubject.aspx.cs" Inherits="InstitutePanel_AddTutorSubject" %>
<%--
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
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
<label for="ac-1" class="tab-hdng">Add Subject Detail</label>
					
				</div>
                
                <table width="100%" id="Other" runat="server" >
                                                 <tr>
                                                    <td style="width:155px;"> Select Category </td>
                                                    <td>
                                                        <asp:DropDownList ID="ddlCourseType" runat="server" AutoPostBack="True" 
                               onselectedindexchanged="ddlCourseType_SelectedIndexChanged" class="txts-flds" Width="155px">
                                                        </asp:DropDownList>
                                                        &nbsp;
                                                        <asp:DropDownList ID="ddlSubCourseCate" runat="server" class="txts-flds"  
                                                             Width="155px">
                                                        </asp:DropDownList>
                                                    </td>
                                                </tr>
                                                 
                                                    <tr>
                                                        <td style="width:150px;" class="H1Left">
                                                            Course Full Name
                                                        </td>
                                                    <td>
                                                        <asp:TextBox ID="txtCrsFullname" CssClass="txts-flds" runat="server" ></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                      <td style="width:150px;">Course Short Name </td>
                                                  
                                                    <td>
                                                        <asp:TextBox ID="txtCrsShortName" CssClass="txts-flds" runat="server" ></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="H1Left" style="vertical-align:middle;">
                                                        Course Short Description
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="txtCrsShortDescription" class="txts-flds" runat="server" Height="70px" 
                                                            TextMode="MultiLine" Width="316px" ></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Course Long Description</td>
                                                    <td>
                                                        <asp:TextBox ID="txtCrsLongDescription" class="txts-flds" runat="server" Height="100px" 
                                                            TextMode="MultiLine" Width="316px"  ></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Course Duration</td>
                                                    <td><asp:DropDownList ID="ddlDuration" class="txts-flds" runat="server" Width="74px">
                                                            <asp:ListItem Value="0">Select</asp:ListItem>
                                                            <asp:ListItem>1</asp:ListItem>
                                                            <asp:ListItem>2</asp:ListItem>
                                                            <asp:ListItem>3</asp:ListItem>
                                                            <asp:ListItem>4</asp:ListItem>
                                                            <asp:ListItem>5</asp:ListItem>
                                                            <asp:ListItem>6</asp:ListItem>
                                                            <asp:ListItem>7</asp:ListItem>
                                                            <asp:ListItem>8</asp:ListItem>
                                                            <asp:ListItem>9</asp:ListItem>
                                                            <asp:ListItem>10</asp:ListItem>
                                                            <asp:ListItem>11</asp:ListItem>
                                                            <asp:ListItem>12</asp:ListItem>
                                                            <asp:ListItem>13</asp:ListItem>
                                                            <asp:ListItem>14</asp:ListItem>
                                                            <asp:ListItem>15</asp:ListItem>
                                                            <asp:ListItem>16</asp:ListItem>
                                                            <asp:ListItem>17</asp:ListItem>
                                                            <asp:ListItem>18</asp:ListItem>
                                                            <asp:ListItem>19</asp:ListItem>
                                                            <asp:ListItem>20</asp:ListItem>
                                                            <asp:ListItem>21</asp:ListItem>
                                                            <asp:ListItem>22</asp:ListItem>
                                                            <asp:ListItem>23</asp:ListItem>
                                                            <asp:ListItem>24</asp:ListItem>
                                                            <asp:ListItem>25</asp:ListItem>
                                                            <asp:ListItem>26</asp:ListItem>
                                                            <asp:ListItem>27</asp:ListItem>
                                                            <asp:ListItem>28</asp:ListItem>
                                                            <asp:ListItem>29</asp:ListItem>
                                                            <asp:ListItem>30</asp:ListItem>
                                                            <asp:ListItem>31</asp:ListItem>
                                                            <asp:ListItem>32</asp:ListItem>
                                                            <asp:ListItem>33</asp:ListItem>
                                                            <asp:ListItem>34</asp:ListItem>
                                                            <asp:ListItem>35</asp:ListItem>
                                                            <asp:ListItem>36</asp:ListItem>
                                                            <asp:ListItem>37</asp:ListItem>
                                                            <asp:ListItem>38</asp:ListItem>
                                                            <asp:ListItem>39</asp:ListItem>
                                                            <asp:ListItem>40</asp:ListItem>
                                                            <asp:ListItem>41</asp:ListItem>
                                                            <asp:ListItem>42</asp:ListItem>
                                                            <asp:ListItem>43</asp:ListItem>
                                                            <asp:ListItem>44</asp:ListItem>
                                                            <asp:ListItem>45</asp:ListItem>
                                                            <asp:ListItem>46</asp:ListItem>
                                                            <asp:ListItem>47</asp:ListItem>
                                                            <asp:ListItem>48</asp:ListItem>
                                                            <asp:ListItem>49</asp:ListItem>
                                                            <asp:ListItem>50</asp:ListItem>
                                                            <asp:ListItem>51</asp:ListItem>
                                                            <asp:ListItem>52</asp:ListItem>
                                                            <asp:ListItem>53</asp:ListItem>
                                                            <asp:ListItem>54</asp:ListItem>
                                                            <asp:ListItem>55</asp:ListItem>
                                                            <asp:ListItem>56</asp:ListItem>
                                                            <asp:ListItem>57</asp:ListItem>
                                                            <asp:ListItem>58</asp:ListItem>
                                                            <asp:ListItem>59</asp:ListItem>
                                                            <asp:ListItem>60</asp:ListItem>
                                                            <asp:ListItem>61</asp:ListItem>
                                                            <asp:ListItem>62</asp:ListItem>
                                                            <asp:ListItem>63</asp:ListItem>
                                                            <asp:ListItem>64</asp:ListItem>
                                                            <asp:ListItem>65</asp:ListItem>
                                                            <asp:ListItem>66</asp:ListItem>
                                                            <asp:ListItem>77</asp:ListItem>
                                                            <asp:ListItem>78</asp:ListItem>
                                                            <asp:ListItem>79</asp:ListItem>
                                                            <asp:ListItem>80</asp:ListItem>
</asp:DropDownList>
<asp:RadioButtonList ID="rdbCourseTime" RepeatDirection="Horizontal" runat="server" RepeatLayout="Flow">
<asp:ListItem Text="Day(s)" Value="1"></asp:ListItem>
<asp:ListItem Text="week(s)" Value="2"></asp:ListItem>
<asp:ListItem Text="Month(s)" Value="3"></asp:ListItem>
<asp:ListItem Text="Year(s)" Value="4"></asp:ListItem>       
</asp:RadioButtonList> <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
ControlToValidate="rdbCourseTime" ErrorMessage="Select Fee Mode"></asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                                                 <tr>
                                                    <td>Course Type</td>
                                                    <td>
                                                        <asp:DropDownList ID="ddlCollegeType" class="txts-flds" runat="server" Width="74px">
                                                        </asp:DropDownList>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Eligibility</td>
                                                    <td style="height: 20px">
                                                        <asp:TextBox ID="txtEligibility" CssClass="txts-flds" runat="server" ></asp:TextBox>
                                                    </td>
                                                </tr>
                                                 <tr>
                                                    <td>
                                                        Course Fees
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="txtCourseFees" class="txts-flds"  runat="server" Width="114px" ></asp:TextBox>
                                                        &nbsp;
                                                        <asp:DropDownList ID="ddlFeesMode" runat="server"  
                                                            Width="60px" class="txts-flds">                                                            
                                                            <asp:ListItem>IND</asp:ListItem>
                                                            <asp:ListItem>USD</asp:ListItem>
                                                        </asp:DropDownList>
                                                        &nbsp;
                                                        <asp:DropDownList ID="ddlFeesType" runat="server"  
                                                            Width="116px" class="txts-flds">
                                                          <asp:ListItem Text="Monthly" Value="2"></asp:ListItem>                        
                                                            <asp:ListItem Text="Trimester" Value="4">
                                                            </asp:ListItem>
                                                            <asp:ListItem Text="Semester" Value="6"></asp:ListItem>
                                                            <asp:ListItem Text="Yearly" Value="12">
                                                            </asp:ListItem>
                                                            <asp:ListItem Text="Entire Course" Value="3"></asp:ListItem>
                                                        </asp:DropDownList>
                                                    </td>
                                                </tr>
                                               
                                                <tr>
                                                    <td>No. of Seats <font color="#ff0000">*</font></td>
                                                    <td>
                                                        <asp:TextBox ID="txtNoOfSeat" runat="server" CssClass="txts-flds"></asp:TextBox>
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                            ControlToValidate="txtNoOfSeat" ErrorMessage="Can Not Blank Seat" 
                                                            ValidationGroup="majorUnit"></asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Course Method <font color="#ff0000">*</font></td>
                                                    <td>
                                                        <asp:DropDownList ID="ddlCrsMethod" runat="server" CssClass="txts-drps">
                                                            <asp:ListItem Value="0">Select</asp:ListItem>
                                                            <asp:ListItem Value="Full-Time">Full-Time/Regular</asp:ListItem>
                                                            <asp:ListItem>PartTime</asp:ListItem>
                                                            <asp:ListItem>Correspondence</asp:ListItem>
                                                            <asp:ListItem>Distance Learning</asp:ListItem>
                                                            <asp:ListItem Value="Online">E-learning/Online</asp:ListItem>
                                                            <asp:ListItem>Executive</asp:ListItem>
                                                        </asp:DropDownList>
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                            ControlToValidate="ddlCrsMethod" ErrorMessage="Select Couse Method" 
                                                            InitialValue="0" ValidationGroup="majorUnit"></asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                                                     <tr>
                                                         <td>Scholarship</td>
                                                         <td>
                                                             <asp:TextBox class="txts-flds" ID="txtscholarship" runat="server"  
                                                                 Height="70px" TextMode="MultiLine" Width="316px"></asp:TextBox>
                                                         </td>
                                                     </tr>
                                                                                           
                                                <tr>
                                                         <td>&nbsp;</td>                                                
                                                   <td class="H1Center">
                                                        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" 
                                                             Text="Submit" ValidationGroup="majorUnit" CssClass="cmnt-submt-01" />
                                                        <asp:Button ID="btnCancel" runat="server" CssClass="cmnt-submt-01" onclick="btnCancel_Click" 
                                                            Text="Cancel" Visible="False" />
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

