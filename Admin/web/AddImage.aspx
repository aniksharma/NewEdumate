<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage/AdminMaster.master" AutoEventWireup="true" CodeFile="AddImage.aspx.cs" Inherits="Admin_web_AddImage" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <div>
        <table width="90%">
            <tr>
                <td height="30px">
                    <asp:Button ID="btnAdd" runat="server" Text="Add New Image" CausesValidation="False"
                        CssClass="bnt-sbmt" style="width: 128px;" OnClick="btnAdd_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <table class="BoxFourRound">
                        <tr id="trInsert" runat="server" visible="false">
                            <td>
                                <table style="width: 100%">
                                    <tr>
                                        <td width="1%">
                                        </td>
                                        <td>
                                            <table width="98%">
                                                <tr>
                                                    <td style="width: 70%" valign="top">
                                                        <table width="100%" class="MasterTableLeft">
                                                            <tr>
                                                                <th class="H2Left" colspan="2">
                                                                    &nbsp;image&nbsp; Name
                                                                </th>
                                                                <th class="H2Left" colspan="3">
                                                                    Select Category</th>
                                                                <th class="H2Left">
                                                                    Select SubCategory
                                                                </th>
                                                            </tr>
                                                            <tr>
                                                                <td class="H2Left" colspan="6" height="6px">
                                                                    &nbsp;
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td class="H2Left" colspan="2">
                                                                    <asp:TextBox ID="txtImageName" runat="server" CssClass="TextBoxSmall"></asp:TextBox>
                                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtImageName"
                                                                        Display="None" ErrorMessage="Image Name !" SetFocusOnError="True"></asp:RequiredFieldValidator>
                                                                    <cc1:validatorcalloutextender ID="RequiredFieldValidator7_ValidatorCalloutExtender"
                                                                        runat="server" Enabled="True" HighlightCssClass="validation" 
                                                                        TargetControlID="RequiredFieldValidator7">
                                                                    </cc1:validatorcalloutextender>
                                                                </td>
                                                                <td class="H2Left" colspan="3">
                                                                    <asp:DropDownList ID="ddlUniversity" runat="server" CssClass="DropdwonMid" 
                                                                        onselectedindexchanged="ddlUniversity_SelectedIndexChanged" 
                                                                        AutoPostBack="True">
                                                                    </asp:DropDownList>
                                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                                                                        ControlToValidate="ddlUniversity" Display="None" ErrorMessage="Select University ?" 
                                                                        InitialValue="0" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                                                                    <cc1:ValidatorCalloutExtender ID="RequiredFieldValidator8_ValidatorCalloutExtender" 
                                                                        runat="server" Enabled="True" HighlightCssClass="validation" 
                                                                        TargetControlID="RequiredFieldValidator8">
                                                                    </cc1:ValidatorCalloutExtender>
                                                                </td>
                                                                <td class="H2Left">
                                                                    <asp:DropDownList ID="DDLSubCategory" runat="server" CssClass="DropdwonMid" 
                                                                        onselectedindexchanged="DDLSubCategory_SelectedIndexChanged" 
                                                                        AutoPostBack="True">
                                                                    </asp:DropDownList>
                                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                                                                        ControlToValidate="DDLSubCategory" InitialValue="0">*</asp:RequiredFieldValidator>
                                                                </td>
                                                            </tr>
                                                            <tr style="height:10px;">
                                                                <td colspan="6">
                                                                    
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td class="H2Right">
                                                                    
                                                                    Image Status</td>
                                                                <td colspan="2" class="H2Right">
                                                                    
                                                                    <asp:RadioButtonList ID="rblCategoryStatus" runat="server" CssClass="RadioButton"
                                                                        RepeatDirection="Horizontal" RepeatLayout="Flow">
                                                                        <asp:ListItem Value="1" Selected="True">Enable</asp:ListItem>
                                                                        <asp:ListItem Value="0">Disable</asp:ListItem>
                                                                    </asp:RadioButtonList>
                                                                                                                                </td>
                                                                <td class="H2Right">
                                                                    
                                                                    Image SubTitle</td>
                                                                <td colspan="2" >
                                                                    <asp:TextBox ID="txtSubTitle" runat="server" CssClass="TextBoxMid"></asp:TextBox>
                                                                    </td>
                                                           </tr>
                                                            <tr>
                                                                <td colspan="6" height="10px">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <th colspan="2">
                                                                    Description
                                                                </th>
                                                                <td colspan="4">
                                                                    <asp:TextBox ID="txtDescription" runat="server" CssClass="TextBoxMidSearch" Height="56px"
                                                                        Width="352px" TextMode="MultiLine"></asp:TextBox>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="6" class="style1" height="6px">
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <th class="style2" colspan="2">
                                                                    Upload Image :
                                                                </th>
                                                                <td colspan="4" class="style2">
                                                                    <asp:FileUpload ID="FileUpload1" runat="server" />
                                                                    (Width:250px, height:150)</td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="6" class="H2Left" height="6px">
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="4" class="H2Center">
                                                                    &nbsp;
                                                                </td>
                                                                <td colspan="2" class="H2Left">
                                                                    <asp:Button ID="btnInsert" runat="server" CssClass="ButtonMid" Text="Save" OnClick="btnSubmit_Click"
                                                                        Width="79px" />
                                                                    &nbsp;&nbsp;
                                                                    <asp:Button ID="btnCancel" runat="server" CausesValidation="False" CssClass="ButtonMid"
                                                                        Text="Cancel" OnClick="btnCancel_Click1" Width="83px" />
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                    <td style="width: 30%" valign="top">
                                                        <table>
                                                            <tr>
                                                                <td class="H1Left" height="50px">
                                                                    &nbsp;
                                                                    <asp:Label ID="lblImgUrl" runat="server"></asp:Label>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td class="H1Left">
                                                                    <asp:Image ID="imgShow" runat="server" Height="150" Width="250" AlternateText="NO Image" />
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                        <td width="1%">
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td class="H3Center">
                                Image&nbsp; Detail
                            </td>
                        </tr>
                        <tr>
                            <td class="H2Center">
                                <asp:Label ID="lblmsg" runat="server" CssClass="labelMsgRed"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="H2Center">
                                <hr color="#616B62" size="1" style="width: 98%" width="98%" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <table>
                                    <tr>
                                        <td style="width: 2%">
                                            &nbsp;
                                        </td>
                                        <td align="center" style="width: 96%">
                                            <%--<%#Eval("caloneyName")%>--%>
                                        </td>
                                        <td style="width: 2%">
                                            &nbsp;
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="3" style="width: 4%" class="HShort">
                                            <hr style="width: 98%" size="1" color="#616B62" width="98%" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 5%">
                                            &nbsp;
                                        </td>
                                        <td align="center" style="width: 90%">
                                            <asp:DataList ID="datalist" runat="server" RepeatColumns="4" RepeatDirection="Horizontal"
                                                OnItemCommand="datalist_ItemCommand1">
                                                <ItemTemplate>
                                                    <table>
                                                        <tr>
                                                        <td valign="top">
                                                        <img src='../<%#Eval("urlPath")%>' height="150" width="250" />
                                                        
                                                            <br />
                                                            <asp:LinkButton ID="lnkEdit" runat="server" Text='<%#Eval("title")%>' CommandArgument='<%#Eval("id")%>'
                                                                CommandName="edit" CausesValidation="false">
                                                            </asp:LinkButton>
                                                            &nbsp;&nbsp;
                                                            <%#Eval("isActive")%>                                                            
                                                        </td>
                                                        <td valign="top">
                                                        </td>
                                                    </tr>
                                                    </table>
                                                </ItemTemplate>
                                            </asp:DataList>
                                        </td>
                                        <td style="width: 5%">
                                            &nbsp;
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td height="30px">
                </td>
            </tr>
        </table>
    </div>
    <asp:Button ID="btnhover" Text="Click Me" runat="server" Height="1" Width="1" Enabled="false"
        CssClass="modalBackground" />
    <cc1:modalpopupextender ID="ModalMenuExtender1" runat="server" BackgroundCssClass="modalBackground"
        CancelControlID="btn_canceltrans" PopupControlID="PopupMenu" TargetControlID="btnhover"
        X="150" Y="10">
    </cc1:modalpopupextender>
    
    <asp:Panel ID="PopupMenu" runat="server" BackColor="#eeeeee" Width="700" BorderColor="Black"
        BorderWidth="2" Height="100">
        <table cellpadding="0" cellspacing="0" style="width: 100%" class="boardbgcoloruser">
            <tr>
                <td style="height: 16px">
                </td>
                <td style="height: 16px">
                    <asp:LinkButton ID="btn_canceltrans" runat="server" Text="Close"></asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td align="center" class="H3Center" style="font-family: Verdana; color: #000000;
                    font-size: 15px">
                    Image Gellary Message
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td style="height: 16px">
                </td>
                <td style="height: 16px">
                </td>
            </tr>
            <tr class="H1Left">
                <td align="left" style="font-family: verdana; font-size: 12px; padding-left: 12px;"
                    class="H2Center">
                    <asp:Label ID="lblInsMsg" runat="server"></asp:Label>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
        </table>
    </asp:Panel>
 
</asp:Content>

