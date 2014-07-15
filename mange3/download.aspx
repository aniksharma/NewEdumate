<%@ Page Language="C#" MasterPageFile="home2.master" AutoEventWireup="true" CodeFile="download.aspx.cs" Inherits="download"
 Title="Edumate Download" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table  width ="100%" >
<tr><td>
<table width="100%">
        <tr>
            <td valign="top" align="center">
                <table width="100%">
                   
                    <tr>
                        <td colspan="3">
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 25%">
                            &nbsp;
                        </td>
                        <td align="center" style="width: 50%">
                            <table width="100%" border="0" cellpadding="0" cellspacing="0">
                                <tr bgcolor="#F9C039" height="30px">
                                    <td align="center" style="font-size: 20px;">
                                        &nbsp;Download Documents Format</td>
                                </tr>
                                <tr>
                                    <td align="left">
                                        <ul>
                                            <asp:DataList ID="ListCaloney" runat="server" RepeatColumns="1" RepeatDirection="Horizontal"
                                           Width="100%">
                                                <HeaderTemplate>
                                                    <table width="100%">
                                                </HeaderTemplate>
                                                <ItemTemplate>
                                                    <tr>
                                                        <td class="botton_link1" align="left">
                                                            <li>
                                                            <a href ='http://www.edumate.edu.in/<%#Eval("shortPath")%>'  Style="color: black; text-decoration: none; font-size: 16px"><%#Eval("name")%> </a>
                                                               
                                                            </li>
                                                        </td>
                                                    </tr>
                                                    <tr> 
                                                    <td>
                                                    <table width ="100%" >
                                                    <tr>
                                                    <td width ="80%">
                                                    <hr />
                                                    </td>
                                                    <td width ="20%"></td>
                                                    </tr>
                                                    
                                                    </table>
                                                    </td>
                                                    </tr>
                                                </ItemTemplate>
                                                <FooterTemplate>
                                                
                                                    </table></FooterTemplate>
                                                  
                                            </asp:DataList>
                                        </ul>
                                    </td>
                                </tr>
                            </table>
                        </td>
                        <td style="width: 25%">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>

</td></tr>
</table>

</asp:Content>

