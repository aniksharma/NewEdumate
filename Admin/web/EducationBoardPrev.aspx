<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage/AdminNewsMaster.master" AutoEventWireup="true" CodeFile="EducationBoardPrev.aspx.cs" Inherits="Admin_web_EducationBoardPrev" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="780px" style="padding-left:10px;" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td align="center" valign="top">
                                        <table width="780px" border="0" cellspacing="0" cellpadding="0" >
                                            <tr>
                                               
                                                <td align="center" valign="top">
                                                    <div >
                                                    <table width="780px" border="0" cellspacing="0" cellpadding="0">
                                                        <tr>
                                                            
                                                            <td colspan="2" class="contents2" style="font-weight:bold; height: 24px;">
                                                              <asp:Label ID="lblMsg" runat="server" ></asp:Label>
                                                              
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="2" align="left" style="height: 200px;" valign="top"
                                                                class="text_new">
                                                               <div id="newsDiv"  style="vertical-align:top; font-size:13px; line-height:1.5; padding-right:5px; text-align:justify;"  runat="server">
                         
                                                              </div>
                
                                                            </td>
                                                        </tr>
                                                    </table>
                                                    </div>
                                                </td>
                                            </tr>
                                        </table>
                                      
                                    </td>
                                </tr>
      
                            </table>

</asp:Content>

