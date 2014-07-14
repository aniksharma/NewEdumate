<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage/AdminMaster.master" AutoEventWireup="true" CodeFile="AddTextDetail.aspx.cs" Inherits="Admin_web_AddTextDetail" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit.HTMLEditor"
    TagPrefix="cc1" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width: 100%">
        <tr>
            <td width="10%">
                &nbsp;
            </td>
            <td width="80%">
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
                                                <td class="Add-Country" >
                                                                                                        Add Text
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="center">
                                                    &nbsp;
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="center">
                                                    <asp:Label ID="lblMsg" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="center">
                                                    &nbsp;
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="center">
                                                    <table cellpadding="0" cellspacing="0" style="width: 80%" class="textbox">
                                                        <tr>
                                                            <td style="width: 5%" align="right">
                                                                &nbsp;</td>
                                                            <td align="left">
                                                                Select University:</td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 5%" align="right">
                                                                &nbsp;</td>
                                                            <td align="left">
                                                            <asp:DropDownList ID="ddlUniversity" runat="server" CssClass="DropdwonSmall" 
                                                                    AutoPostBack="True" onselectedindexchanged="ddlUniversity_SelectedIndexChanged" 
                                                                    >
                                                                </asp:DropDownList>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                                    ControlToValidate="ddlUniversity" Display="None" 
                                                                    ErrorMessage=" Select University" InitialValue="0"></asp:RequiredFieldValidator>
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
                                                                Select Category:</td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 5%" align="right">
                                                                &nbsp;</td>
                                                            <td align="left">
                                                                <asp:DropDownList ID="ddlTextCategory" runat="server" CssClass="DropdwonSmall">
                                                                </asp:DropDownList>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                                                    Display="None" ErrorMessage="Text Category !" InitialValue="0" 
                                                                    ControlToValidate="ddlTextCategory"></asp:RequiredFieldValidator>
                                                                <cc2:ValidatorCalloutExtender ID="RequiredFieldValidator6_ValidatorCalloutExtender" 
                                                                    runat="server" Enabled="True" TargetControlID="RequiredFieldValidator6">
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
                                                                Upload Image:(Width:280px, Height:160px)</td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 5%" align="right">
                                                                &nbsp;</td>
                                                            <td align="left">
                                                                <asp:FileUpload ID="FileUpload1" runat="server" />
                                                                                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                                                                    ControlToValidate="FileUpload1" Display="None" ErrorMessage="Image Upload !"></asp:RequiredFieldValidator>
                                                                <cc2:ValidatorCalloutExtender ID="RequiredFieldValidator7_ValidatorCalloutExtender" 
                                                                    runat="server" Enabled="True" TargetControlID="RequiredFieldValidator7">
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
                                                                <asp:TextBox ID="txt_title" runat="server" Width="400px" CssClass="textstyle" onblur="javascript:Required('ctl00_ContentPlaceHolder1_txt_title')"
                                                                ></asp:TextBox>
                                                                <span id="ctl00_ContentPlaceHolder1_txt_titleL" style="width: 50px; float: none;"></span>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td style="height: 14px">
                                                            </td>
                                                            <td align="left" style="height: 14px">
                                                            </td>
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
                                                                &nbsp;
                                                            </td>
                                                            <td align="left">
                                                                <asp:Button ID="btn_submit" runat="server" Text="Save" OnClick="btn_submit_Click" OnClientClick="ddlChkSelect('Submit');" onfocus="javascript:submitAddUniTextdata();"
                                                                    ValidationGroup="a" CssClass="bnt-sbmt" />
                                                                <asp:Label ID="lblImageUrl" runat="server" Visible="false"></asp:Label>
                                                                <div id="Submit"  style="visibility:hidden; height:24px;width:24px; float:right;margin-right:65px;margin-top:0px;">
                                                                        <img alt="Loading..." src="../images/loading.gif" style="width: 22px;height: 22px" /> 
                                                                      </div>
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
                        </td>
                    </tr>
                </table>
            </td>
            <td width="10%">
                &nbsp;
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
                                                                                    <th>
                                                                                    Image
                                                                                    </th>
                                                                                                                                                                      
                                                                                    <th>University</th>
                                                                                    <th>Category</th>
                                                                                    <th>Status</th>                                                                                    
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
                                                                            <td><img src='../<%#Eval("urlPath")%>' height="70" width="100" /></td>                                                                                                                                                      
                                                                            <td><%#Eval("uniID")%></td>
                                                                            <td><%#Eval("catID")%></td>
                                                                            <td><%#Eval("isActive")%></td>                                                                            
                                                                            
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
                                                                            <td><img src='../<%#Eval("urlPath")%>' height="70" width="100" /></td>                                                                                                                                                       
                                                                            <td><%#Eval("uniID")%></td>
                                                                            <td><%#Eval("catID")%></td>
                                                                            <td><%#Eval("isActive")%></td>
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

