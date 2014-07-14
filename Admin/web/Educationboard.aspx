<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage/AdminNewsMaster.master" AutoEventWireup="true" CodeFile="Educationboard.aspx.cs" Inherits="Admin_web_Educationboard" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit.HTMLEditor" TagPrefix="cc1" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width: 100%">
        <tr>
            <td width="10%">
                &nbsp;
            </td>
            <td width="90%">
                <table style="width: 100%">
                    <tr>
                        <td height="12px">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <table class="BoxFourRound" style="width: 100%">
                                <tr>
                                    <td class="H2Center">
                                        <table width="100%" border="0" align="center" cellpadding="0" cellspacing="0" class="border">
                                            <tr>
                                                <td class="H3Center" >
                                                    Add Education</td>
                                            </tr>
                                        
                                            <tr>
                                                <td align="center">
                                                    <asp:Label ID="lblMsg" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                           
                                            <tr>
                                                <td align="center">
                                                    <table cellpadding="0" cellspacing="0" style="width: 100%" class="textbox">
                                                        <tr>
                                                            <td style="width: 5%" align="right">
                                                                &nbsp;</td>
                                                            <td align="left">
                                                              Type: </td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 5%; height: 24px;" align="right">
                                                                &nbsp;</td>
                                                            <td align="left" style="height: 24px">
                                                                <asp:DropDownList ID="ddlEducationType" runat="server" CssClass="DropdwonSmall">
                                                                    <asp:ListItem Value="0">Select</asp:ListItem>
                                                                    <asp:ListItem Value="1">Education Board</asp:ListItem>
                                                                    <asp:ListItem Value="2">Education Council</asp:ListItem>
                                                                    <asp:ListItem Value="3">Education System</asp:ListItem>
                                                                </asp:DropDownList>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                                                    ControlToValidate="ddlEducationType" Display="None" 
                                                                    ErrorMessage=" Select Type" InitialValue="0"></asp:RequiredFieldValidator>
                                                                <cc2:ValidatorCalloutExtender ID="RequiredFieldValidator6_ValidatorCalloutExtender" 
                                                                    runat="server" Enabled="True" TargetControlID="RequiredFieldValidator6">
                                                                </cc2:ValidatorCalloutExtender>
                                                            </td>
                                                        </tr>

                                                         <tr>
                                                            <td style="width: 5%" align="right">
                                                                &nbsp;</td>
                                                            <td align="left">
                                                            Country:    </td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 5%; height: 24px;" align="right">
                                                                &nbsp;</td>
                                                            <td align="left" style="height: 24px">
                                                                <asp:DropDownList ID="ddlCountry" runat="server" AutoPostBack="True" 
                                                                    CssClass="DropdwonMid" onselectedindexchanged="ddlCountry_SelectedIndexChanged">                                                                 
                                                                </asp:DropDownList>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                                                                    ControlToValidate="ddlCountry" Display="None" 
                                                                    ErrorMessage=" Select Type" InitialValue="0"></asp:RequiredFieldValidator>
                                                                <cc2:ValidatorCalloutExtender ID="ValidatorCalloutExtender1" 
                                                                    runat="server" Enabled="True" TargetControlID="RequiredFieldValidator6">
                                                                </cc2:ValidatorCalloutExtender>
                                                            </td>
                                                        </tr>





                                                        <tr>
                                                            <td style="width: 5%" align="right">
                                                                &nbsp;</td>
                                                            <td align="left">
                                                               Select State: </td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 5%" align="right">
                                                                &nbsp;</td>
                                                            <td align="left">
                                                            <asp:DropDownList ID="ddlUniversity" runat="server" CssClass="DropdwonSmall" 
                                                                    >
                                                                </asp:DropDownList>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                                    ControlToValidate="ddlUniversity" Display="None" 
                                                                    ErrorMessage=" Select State" InitialValue="0"></asp:RequiredFieldValidator>
                                                                <cc2:ValidatorCalloutExtender ID="RequiredFieldValidator2_ValidatorCalloutExtender" 
                                                                    runat="server" Enabled="True" TargetControlID="RequiredFieldValidator2">
                                                                </cc2:ValidatorCalloutExtender>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 5%" align="right">
                                                                &nbsp;</td>
                                                            <td align="left">
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 5%" align="right">
                                                                &nbsp;</td>
                                                            <td align="left">
                                                                Select Education Board:</td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 5%" align="right">
                                                                &nbsp;</td>
                                                            <td align="left">
                                                                <asp:DropDownList ID="ddlNewsType" runat="server" 
                                                                    CssClass="DropdwonSmall" OnSelectedIndexChanged="ddlNewsType_SelectedIndexChanged">
                                                                </asp:DropDownList>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                                                    ControlToValidate="ddlNewsType" Display="None" 
                                                                    ErrorMessage="Select Education Board!" InitialValue="0"></asp:RequiredFieldValidator>
                                                                <cc2:ValidatorCalloutExtender ID="RequiredFieldValidator4_ValidatorCalloutExtender" 
                                                                    runat="server" Enabled="True" TargetControlID="RequiredFieldValidator4">
                                                                </cc2:ValidatorCalloutExtender>
                                                                                                                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 5%" align="right">
                                                                &nbsp;</td>
                                                            <td align="left">
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 5%" align="right">
                                                                &nbsp;</td>
                                                            <td align="left">
                                                                Status:</td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 5%" align="right">
                                                                &nbsp;</td>
                                                            <td align="left">
                                                                <asp:RadioButtonList ID="rblStatus" runat="server" RepeatDirection="Horizontal" 
                                                                    RepeatLayout="Flow">
                                                                    <asp:ListItem Selected="True" Text="Enable" Value="1"></asp:ListItem>
                                                                    <asp:ListItem Text="Disable" Value="0"></asp:ListItem>
                                                                </asp:RadioButtonList>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 5%" align="right">
                                                                &nbsp;</td>
                                                            <td align="left">
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 5%" align="right">
                                                                &nbsp;</td>
                                                            <td align="left">
                                                                Date:</td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 5%" align="right">
                                                                &nbsp;</td>
                                                            <td align="left">
                                                                <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
                                                                <cc2:CalendarExtender ID="txtDate_CalendarExtender" runat="server" 
                                                                    Enabled="True" TargetControlID="txtDate">
                                                                </cc2:CalendarExtender>
                                                                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                                                    ControlToValidate="txtDate" ErrorMessage="Enter Valid Date!" 
                                                                    Operator="DataTypeCheck" Type="Date"></asp:CompareValidator>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 5%" align="right">
                                                                &nbsp;</td>
                                                            <td align="left">
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 5%" align="right">
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_title"
                                                                    ErrorMessage="*" ValidationGroup="a"></asp:RequiredFieldValidator>
                                                            </td>
                                                            <td align="left">
                                                                Title:
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                &nbsp;
                                                            </td>
                                                            <td align="left">
                                                                <asp:TextBox ID="txt_title" runat="server" Width="400px" CssClass="textstyle"></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td style="height: 14px">
                                                            </td>
                                                            <td align="left" style="height: 14px">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td style="height: 14px">
                                                                &nbsp;</td>
                                                            <td align="left" style="height: 14px">
                                                                *Sub Title:</td>
                                                        </tr>
                                                        <tr>
                                                            <td style="height: 14px">
                                                                &nbsp;</td>
                                                            <td align="left" style="height: 14px">
                                                                <asp:TextBox ID="txtSubTitle" runat="server" CssClass="textstyle" Width="400px" 
                                                                   ></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td style="height: 14px">
                                                                &nbsp;</td>
                                                            <td align="left" style="height: 14px">
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td align="right">
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txt_desc"
                                                                    ErrorMessage="*" ValidationGroup="a"></asp:RequiredFieldValidator>
                                                            </td>
                                                            <td align="left">
                                                                Description:
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                &nbsp;
                                                            </td>
                                                            <td align="left">
                                                                <cc1:Editor ID="txt_desc" runat="server" Height="300px" Width="400px" />
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                &nbsp;
                                                            </td>
                                                            <td align="left">
                                                                &nbsp;
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                &nbsp;</td>
                                                            <td align="left">
                                                                News Image:</td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                &nbsp;</td>
                                                            <td align="left">
                                                                <asp:FileUpload ID="FileUpload1" runat="server" />
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                &nbsp;</td>
                                                            <td align="left">
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                &nbsp;
                                                            </td>
                                                            <td align="left">
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                &nbsp;
                                                            </td>
                                                            <td align="left">
                                                                &nbsp;
                                                                <asp:Button ID="btn_submit" runat="server" Text="Save" OnClick="btn_submit_Click"
                                                                    ValidationGroup="a" CssClass="ButtonMid" />
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                &nbsp;
                                                            </td>
                                                            <td align="left">
                                                                <tr>
                                            
                                            <td style="width: 2%">
                                                &nbsp;
                                            </td>
                                        </tr>
                                                              
                                        <tr>
                                            <td colspan="2" style="width: 4%" class="HShort">
                                                
                                            </td>
                                        </tr>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                &nbsp;
                                                            </td>
                                                            <td align="left">
                                                                &nbsp;
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td height="12px">
                            &nbsp;
                            <asp:Label ID="lblimage" runat="server" Visible="False" ></asp:Label>
                        </td>
                    </tr>
                </table>
            </td>
          
        </tr>
        <tr>
       <td colspan="3" class="HShort"> <hr style="width: 98%" size="1" color="#616B62" width="98%" /></td>
       </tr>
       <tr>
       <td colspan="3">
                                                       <table>
                                                    <tr>
                                                        <td align="left" style="width: 25%">
                                                            <asp:Label ID="lblCurrentPage" runat="server" Text="1"></asp:Label>
                                                            &nbsp;
                                                            <asp:Label ID="lblPageOf" runat="server" Text="Of"></asp:Label>
                                                            &nbsp;
                                                            <asp:Label ID="lblLastPage" runat="server" Text="1"></asp:Label>
                                                        </td>
                                                        <td style="width: 25%">
                                                            <table>
                                                                <tr>
                                                                    <td>
                                                                        <asp:LinkButton ID="lnkfstPage" runat="server" CssClass="LinkButtonMid" OnClick="lnkfstPage_Click">&lt;&lt;</asp:LinkButton>
                                                                    </td>
                                                                    <td>
                                                                        <asp:LinkButton ID="lnkPrepage" runat="server" CssClass="LinkButtonMid" OnClick="lnkPrepage_Click">&lt;</asp:LinkButton>
                                                                    </td>
                                                                    <td>
                                                                        <asp:LinkButton ID="lnkNextpage" runat="server" CssClass="LinkButtonMid" OnClick="lnkNextpage_Click">&gt;</asp:LinkButton>
                                                                        <td>
                                                                            <asp:LinkButton ID="lnkLastpage" runat="server" CssClass="LinkButtonMid" OnClick="lnkLastpage_Click">&gt;&gt;</asp:LinkButton>
                                                                        </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                        <td valign="top" style="width: 25%">
                                                            <table>
                                                                <tr>
                                                                    <td>
                                                                        <asp:TextBox ID="txtGoPage" runat="server" CssClass="TextBoxShort" MaxLength="5"></asp:TextBox>
                                                                        <cc2:TextBoxWatermarkExtender ID="txtGoPage_TextBoxWatermarkExtender" runat="server"
                                                                            Enabled="True" TargetControlID="txtGoPage" WatermarkText="Page No">
                                                                        </cc2:TextBoxWatermarkExtender>
                                                                        <cc2:FilteredTextBoxExtender ID="txtGoPage_FilteredTextBoxExtender" runat="server"
                                                                            Enabled="True" FilterType="Numbers" TargetControlID="txtGoPage">
                                                                        </cc2:FilteredTextBoxExtender>
                                                                        <asp:LinkButton ID="lnkBtnGO" runat="server" CssClass="LinkButtonMid" OnClick="lnkBtnGO_Click"
                                                                            ValidationGroup="go">Go</asp:LinkButton>
                                                                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtGoPage"
                                                                            Display="None" ErrorMessage="Not Negtive Value" MaximumValue="9999999" MinimumValue="0"
                                                                            ValidationGroup="go"></asp:RangeValidator>
                                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtGoPage"
                                                                            Display="None" ErrorMessage="Please Enter A Value" ValidationGroup="go"></asp:RequiredFieldValidator>
                                                                        <cc2:ValidatorCalloutExtender ID="RequiredFieldValidator1_ValidatorCalloutExtender"
                                                                            runat="server" Enabled="True" HighlightCssClass="validation" TargetControlID="RequiredFieldValidator1">
                                                                        </cc2:ValidatorCalloutExtender>
                                                                        <cc2:ValidatorCalloutExtender ID="RangeValidator1_ValidatorCalloutExtender" runat="server"
                                                                            Enabled="True" HighlightCssClass="validation" TargetControlID="RangeValidator1">
                                                                        </cc2:ValidatorCalloutExtender>
                                                                       
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                        <td style="width: 25%">
                                                            <asp:DropDownList ID="ddlNopage" runat="server" CssClass="DropdwonShort" OnSelectedIndexChanged="ddlNopage_SelectedIndexChanged"
                                                                AutoPostBack="True">
                                                                <asp:ListItem Text="10" Value="10"></asp:ListItem>
                                                                <asp:ListItem Text="30" Value="30"></asp:ListItem>
                                                                <asp:ListItem Text="50" Value="50"></asp:ListItem>
                                                                <asp:ListItem Text="100" Value="100"></asp:ListItem>
                                                            </asp:DropDownList>
                                                        </td>
                                                    </tr>
                                                </table>

       </td>
       </tr> 
       <tr>
       <td colspan="3" class="HShort"> <hr style="width: 98%" size="1" color="#616B62" width="98%" /></td>
       </tr>
       <tr>
       <td colspan="3">          
                                                             <asp:Repeater ID="datalist" runat="server" OnItemCommand="datalist_ItemCommand">
                                                                    <HeaderTemplate>
                                                                        <table class="MasterTableCenter">
                                                                            <tr>
                                                                                <tr>
                                                                                    <th>
                                                                                        Sr. No.
                                                                                    </th>
                                                                                    <th>
                                                                                        Title
                                                                                    </th>
                                                                                   
                                                                                    <th>News Type</th>
                                                                                    <th>News For</th>
                                                                                    <th>Status</th>
                                                                                    <th>New Image</th>
                                                                                    <th>
                                                                                        Date
                                                                                    </th>
                                                                                    <th>View</th>
                                                                                    <th>
                                                                                        Delete
                                                                                    </th>
                                                                                </tr>
                                                                            </tr>
                                                                    </HeaderTemplate>
                                                                    <ItemTemplate>
                                                                        <tr>
                                                                            <td valign="top">
                                                                                <asp:LinkButton ID="LinkButton1" runat="server" Text="Edit" CommandArgument='<%#Eval("id")%>'
                                                                                    CommandName="edit" CausesValidation="false">
                                                                                </asp:LinkButton>
                                                                            </td>
                                                                            <td valign="top">
                                                                                <%#Eval("title")%>
                                                                            </td>
                                                                                                                                                     
                                                                            <td><%#Eval("catID")%></td>
                                                                            <td><%#Eval("uniID")%></td>
                                                                            <td><%#Eval("isActive")%></td>
                                                                            <td><%#Eval("urlPath")%> </td>
                                                                            <td valign="top">
                                                                                <%#Eval("DOJ")%>
                                                                            </td>
                                                                            <td><a href="EducationBoardPrev.aspx?uniid=<%#Eval("id")%>" target="_blank">View Preview</a></td>
                                                                            <td valign="top">
                                                                                <asp:LinkButton ID="lnkEdit" runat="server" Text="Delete" CommandArgument='<%#Eval("id")%>'
                                                                                    CommandName='<%#Eval("urlPath")%>' CausesValidation="false">
                                                                                </asp:LinkButton>
                                                                            </td>
                                                                        </tr>
                                                                    </ItemTemplate>
                                                                    <AlternatingItemTemplate>
                                                                        <tr class="alt">
                                                                            <td valign="top">
                                                                                <asp:LinkButton ID="LinkButton1" runat="server" Text="Edit" CommandArgument='<%#Eval("id")%>'
                                                                                    CommandName="edit" CausesValidation="false">
                                                                                </asp:LinkButton>
                                                                            </td>
                                                                            <td valign="top">
                                                                                <%#Eval("title")%>
                                                                            </td>
                                                                          
                                                                            
                                                                            <td><%#Eval("catID")%></td>
                                                                            <td><%#Eval("uniID")%></td>
                                                                            <td><%#Eval("isActive")%></td>
                                                                            <td><%#Eval("urlPath")%></td>
                                                                            <td valign="top">
                                                                                <%#Eval("DOJ")%>
                                                                            </td>
                                                                            <td><a href="EducationBoardPrev.aspx?uniid=<%#Eval("id")%>" target="_blank">View Preview</a></td>
                                                                            <td valign="top">
                                                                                 <asp:LinkButton ID="lnkEdit" runat="server" Text="Delete" CommandArgument='<%#Eval("id")%>'
                                                                                    CommandName='<%#Eval("urlPath")%>' CausesValidation="false">
                                                                                </asp:LinkButton>
                                                                            </td>
                                                                        </tr>
                                                                    </AlternatingItemTemplate>
                                                                    <FooterTemplate>
                                                                        </table>
                                                                    </FooterTemplate>
                                                                </asp:Repeater>
</td>
       </tr>
    </table>
</asp:Content>

