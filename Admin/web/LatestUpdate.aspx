<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage/AdminNewsMaster.master" AutoEventWireup="true" CodeFile="LatestUpdate.aspx.cs" Inherits="Admin_web_LatestUpdate" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit.HTMLEditor" tagprefix="cc1" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width: 100%">
        <tr>
            <td>
                <table style="width: 100%">
                    <tr>
                        <td width="10%">
                            &nbsp;
                        </td>
                        <td width="90%">
                            <table style="width: 100%">
                                <tr>
                                    <td>
                                        <table style="width: 100%" class="BoxFour">
                                        <tr>
                                        <td colspan="2" valign="top">
       <table id="ShowUpdate" runat="server">
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        </table>
                                        </td>
                                        </tr>
                                            <tr>
                                                <td id="Update" runat="server" valign="top" width="100%">
                                                <fieldset>
                                            <legend class="legText" >Update News: </legend>
                                                
                                                    <table class="NewTableLeft" style="width: 100%">
                                                        <tr>
                                                        <td ></td>
                                                        </tr>
                                                        <tr>
                                                            <th class="H2Center" colspan="2">
                                                                Latest Update</th>
                                                        </tr>
                                                        <tr>
                                                            <td style="height:30px;" colspan="2">
                                                                <asp:Label ID="lblsms" runat="server" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width:70px;" >
                                                                Name:</td>
                                                            <td>
                                                                <asp:TextBox ID="txttitle" Width="400px" runat="server" onblur="javascript:Required('ctl00_ContentPlaceHolder1_txttitle')"
                                                                    onkeyup="RequiredTastomonyNameCount('ctl00_ContentPlaceHolder1_txttitle')" MaxLength="21" 
                                                                ></asp:TextBox>
                                                                 <span id="ctl00_ContentPlaceHolder1_txttitleL" style="width: 50px; float: none;"></span>
                                                                     <span id="ctl00_ContentPlaceHolder1_txttitleR"></span>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                Detail:</td>
                                                            <td>
                                                                <asp:TextBox ID="Editor1"  Width="500px" runat="server" Height="114px" onblur="javascript:Required('ctl00_ContentPlaceHolder1_Editor1')"
                                                                    onkeyup="RequiredTastomonyDescriptionCount('ctl00_ContentPlaceHolder1_Editor1')" 
                                                                    TextMode="MultiLine" MaxLength="201"></asp:TextBox>
                                                                     <span id="ctl00_ContentPlaceHolder1_Editor1L" style="width: 50px; float: none;"></span>
                                                                     <span id="ctl00_ContentPlaceHolder1_Editor1R"></span>
                                                            </td>
                                                        </tr>
                                                        <%#Eval("eligibility")%>
                                                        <tr>
                                                            <td class="H1Center" colspan="2">
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td class="H2Left">
                                                                &nbsp;</td>
                                                            <td class="H1Left">
                                                                <asp:Button ID="btnSubmit" runat="server" CssClass="bnt-sbmt" OnClick="btnSubmit_Click" OnClientClick="ddlChkSelect('State');" onfocus="javascript:submitTastomonydata();"
                                                                    Text="Submit" ValidationGroup="majorUnit" />
                                                                    <div id="State"  style="visibility:hidden; height:24px;width:24px; float:right;margin-right:65px;margin-top:0px;">
                                                                        <img alt="Loading..." src="../Images/loading.gif" style="width: 22px;height: 22px" /> 
                                                                      </div>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="H1Center" colspan="2">
                                                                <asp:Label ID="lblId" runat="server" Visible="False"></asp:Label>
                                                            </td>
                                                        </tr>
                                                        </table>
                                                     
                                          </fieldset>           
                                                </td>
                                                <td valign="top" >
                                                    &nbsp;</td>
                                            </tr>
                                        </table>
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
                                                       <table style="width:100%;" >
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
                                                                        <asp:TextBox ID="txtGoPage" runat="server" CssClass="TextBoxShort" Width="75" MaxLength="5"></asp:TextBox>
                                                                        <cc2:TextBoxWatermarkExtender ID="txtGoPage_TextBoxWatermarkExtender" runat="server"
                                                                            Enabled="True" TargetControlID="txtGoPage" WatermarkText="Page No">
                                                                        </cc2:TextBoxWatermarkExtender>
                                                                        <cc2:FilteredTextBoxExtender ID="txtGoPage_FilteredTextBoxExtender" runat="server"
                                                                            Enabled="True" FilterType="Numbers" TargetControlID="txtGoPage">
                                                                        </cc2:FilteredTextBoxExtender>
                                                                        <asp:LinkButton ID="lnkBtnGO" runat="server" CssClass="LinkButtonMid" ForeColor="Blue" OnClick="lnkBtnGO_Click"
                                                                            ValidationGroup="go">Go</asp:LinkButton>
                                                                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtGoPage"
                                                                            Display="None" ErrorMessage="Not Negtive Value" MaximumValue="9999999" MinimumValue="0"
                                                                            ValidationGroup="go"></asp:RangeValidator>
                                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtGoPage"
                                                                            Display="None" ErrorMessage="Please Enter A Value" ValidationGroup="go"></asp:RequiredFieldValidator>
                                                                        <cc2:ValidatorCalloutExtender ID="RangeValidator1_ValidatorCalloutExtender" runat="server"
                                                                            Enabled="True" HighlightCssClass="validation" TargetControlID="RangeValidator1">
                                                                        </cc2:ValidatorCalloutExtender>
                                                                       
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                        <td style="width: 25%">
                                                            <asp:DropDownList ID="ddlNopage" runat="server" Width="75" OnSelectedIndexChanged="ddlNopage_SelectedIndexChanged"
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
                        <td width="10%">
                            &nbsp;</td>
                        <td width="80%">
                            <asp:Label ID="lblMsg" runat="server"></asp:Label>
                        </td>
                        <td width="10%">
                            &nbsp;</td>
                    </tr>

                    <tr>
                        <td width="10%">
                            &nbsp;</td>
                        <td width="80%">
                <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
                    <HeaderTemplate>
                        <table class="MasterTableCenter">
                            <tr>
                                <th style="padding-left:20px; text-align:left;" >
                                    Title
                                </th>
                                <th>
                                    Date
                                </th>
                                <th>
                                </th>
                                <th>
                                </th>
                            </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td  style="padding-left:20px; text-align:left;">
                                <%#Eval("name") %>
                            </td>
                            <td>
                                <%#Eval("eligibility")%>
                            </td>
                            <td>
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Edit" CommandArgument='<%#Eval("id") %>'>Edit</asp:LinkButton>
                            </td>
                            <td>
                                <asp:LinkButton ID="ImageButton1" CommandArgument='<%#Eval("id") %>' ToolTip="Delete" CommandName="Delete" runat="server">Delete</asp:LinkButton>                               
                            </td>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        </table>
                    </FooterTemplate>
                </asp:Repeater>
                        </td>
                        <td width="10%">
                            &nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
            <asp:LinkButton ID="LinkButton6" runat="server"></asp:LinkButton>
                                                               
                                                                <cc2:ModalPopupExtender ID="LinkButton6_ModalPopupExtender" runat="server" PopupControlID="Eroor" CancelControlID="lkbClose"
                                                                    DynamicServicePath="" Enabled="True" TargetControlID="LinkButton6">
                                                                </cc2:ModalPopupExtender>
              <asp:Panel ID="Eroor" runat="server" >
               <div style="background: none repeat scroll 0 0 #525252; padding: 10px; z-index: 100000;
                    display: block; width: 400px; left: 278px; top: 456px;">
                    <div style="background: none repeat scroll 0 0 #6391CC; padding: 7px 10px;">
                        <span style="float: right; margin-top: -12px;">
                            <asp:LinkButton ID="lkbClose" runat="server" ForeColor="White" Font-Underline="false">X</asp:LinkButton>
                        </span>
                    </div>
                    <div style="background: none repeat scroll 0 0 #FFFFFF; padding: 10px;">
                        <div style="background-color: #ffffff; text-align: left;">
                            <div>
                                <table width="100%">
                                    <tr>
                                        <td>
                                        </td>
                                        <td>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <asp:Label ID="lblerrorShow" runat="server" ForeColor="#444444"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2" style="height: 25px">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                        </td>
                                        <td align="right">
                                            <asp:Button ID="btOk" runat="server" Text="Ok" />
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </div>
                    </div>
                </asp:Panel>  
            </td>
        </tr>
    </table>
</asp:Content>

