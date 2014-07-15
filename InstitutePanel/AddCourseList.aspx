<%@ Page Title="" Language="C#" MasterPageFile="~/InstitutePanel/MasterPage2.master" AutoEventWireup="true" CodeFile="AddCourseList.aspx.cs" Inherits="InstitutePanel_AddCourseList" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script src="../js/modernizr.custom.29473.js" type="text/javascript"></script>
<link href="../render/stylesheetedumate.css" rel="stylesheet" type="text/css" /> 
<table width="100%" style="width:650px; border:1px solid #ccc;">
    <tr><td>
    <asp:UpdatePanel ID="updatepanel1" runat="server">
        <ContentTemplate>
            <table width="100%">
                <tr>
                    <td class="H2Center" width="80%" colspan="2"> 
                    <div style="float:left; position:absolute; top: 710px; left: 800px;">
                                <asp:UpdateProgress ID="progressPinChecker" runat="server" AssociatedUpdatePanelID="updatepanel1">
                                        <ProgressTemplate>
                                           <img alt="Loading..." src="../img/control Image/loading.gif" style="width: 22px;
                                                height: 22px" />
                                        </ProgressTemplate>
                                    </asp:UpdateProgress>
</div>                       
</td>
                </tr>
                             
                <tr>
                    <td colspan="2">
                        <div id="tdinformation" runat="server" visible="true">
                                                                             <section class="ac-container">
				<div>
					<input id="ac-1" name="accordion-1" type="checkbox" class="checkboxs"/>
					<label for="ac-1" class="tab-hdng">Add Subject Detail</label>
					
				</div>

                </section>

                                <table style="width: 100%" >
                                                               <tr>
                    <td  style="height:30px;" colspan="2">
                        &nbsp;</td>
                </tr>
                                    <tr>
                                        <td colspan="2" valign="top" width="70%">
                                            <table style="width: 100%">
                                                
<tr>
<td colspan="2">
<table width="100%" id="Other" runat="server" >
                                                 <tr>
                                                    <td style="width:150px;"> Select Category </td>
                                                    <td>
                                                        <asp:DropDownList ID="ddlCourseType" runat="server" AutoPostBack="True" 
                                                            onselectedindexchanged="ddlCourseType_SelectedIndexChanged" Width="184px"  
                                                            >
                                                        </asp:DropDownList>
                                                        &nbsp;
                                                        <asp:DropDownList ID="ddlSubCourseCate" runat="server" AutoPostBack="True"  Width="184px"
                                                            >
                                                        </asp:DropDownList>
                                                    </td>
                                                </tr> 
                                                 <tr><td colspan="2" class="blank watermark"  ></td></tr>

                                                <tr>
                                                    <td class="H1Left" style="width:120px; vertical-align:middle;">
                                                        Subject(s) Short Description
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="txtCrsShortDescription" runat="server" Height="70px" 
                                                            TextMode="MultiLine" Width="374px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr><td colspan="2" class="blank watermark"  ></td></tr>
                                                <tr>
                                                    <td class="H1Left" style="width: 150px; vertical-align:middle;">
                                                        Subject(s) Long Description
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="txtCrsLongDescription" runat="server" Height="100px" 
                                                            TextMode="MultiLine" Width="374px" ></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr><td colspan="2" class="blank watermark"  ></td></tr>
                                                <tr>
                                                    <td class="H1Left" style="width: 150px; vertical-align:middle;">
                                                        Subject(s) Duration
                                                    </td>
                                                    <td >
                                                        <asp:DropDownList ID="ddlDuration" runat="server" Width="126px">
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
                                                            <asp:ListItem></asp:ListItem>
                                                            <asp:ListItem>80</asp:ListItem>
                                                        </asp:DropDownList>
                                                        <asp:RadioButtonList ID="rdbCourseTime" RepeatDirection="Horizontal" 
                                                            runat="server" RepeatLayout="Flow" ValidationGroup="ab">
                                                        <asp:ListItem Text="Day(s)"  Value="1" ></asp:ListItem>
                                                        <asp:ListItem Text="week(s)" Value="2"></asp:ListItem>
                                                        <asp:ListItem Text="Month(s)" Value="3"></asp:ListItem>
                                                        <asp:ListItem Text="Year(s)" Value="4"></asp:ListItem>                                                        
                                                        </asp:RadioButtonList>
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                                            ControlToValidate="rdbCourseTime" ErrorMessage="*" 
                                                            ValidationGroup="ab"></asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                                               <tr><td colspan="2" class="blank watermark"  ></td></tr>
                                                 <tr>
                                                    <td class="H1Left" style="width: 150px; vertical-align:middle;">
                                                        &nbsp;Fees
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="txtCourseFees" runat="server" Width="165px"></asp:TextBox>
                                                        <cc1:FilteredTextBoxExtender ID="txtCourseFees_FilteredTextBoxExtender" 
                                                            runat="server" Enabled="True" FilterType="Numbers" 
                                                            TargetControlID="txtCourseFees">
                                                        </cc1:FilteredTextBoxExtender>
                                                        &nbsp;
                                                        <asp:DropDownList ID="ddlFeesMode" runat="server" 
                                                            Width="60px">                                                            
                                                            <asp:ListItem>IND</asp:ListItem>
                                                            <asp:ListItem>USD</asp:ListItem>
                                                        </asp:DropDownList>
                                                        &nbsp;
                                                        <asp:DropDownList ID="ddlFeesType" runat="server"  
                                                            Width="127px">
                                                           <asp:ListItem Text="Per Hour" Value="1"></asp:ListItem>
                                                           <asp:ListItem Text="Monthly" Value="2"></asp:ListItem>                        
                                                           <asp:ListItem Text="Entire Course" Value="3"></asp:ListItem> 
                                                        </asp:DropDownList>
                                                    </td>
                                                </tr>
                                               
                                               <tr><td colspan="2" class="blank watermark"  ></td></tr>                                                                                               
                                                <tr>
                                                    <td class="H1Center">
                                                        &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                    </td>
                                                    <td class="H1Left">
                                                        <asp:Button ID="btnSubmit" runat="server"  
                                                            OnClick="btnSubmit_Click"  Text="Submit" 
                                                            ValidationGroup="ab" CssClass="sbmts"/>
                                                        <asp:Button ID="btnCancel" runat="server" onclick="btnCancel_Click" 
                                                            Text="Cancel" Visible="False" />
                                                        <asp:Label ID="lblMsg" runat="server" CssClass="labelMsgRed"></asp:Label>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                        <td valign="top" align="left">
                                             </td>
                                    </tr>
                                </table>   
                                        </td>
                                      
                                </tr>
                                       </table>                                                              
                            </div>
                        </div> </div>
                    </td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>
    </td></tr></table>
</asp:Content>

