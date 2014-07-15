<%@ Page Language="C#" AutoEventWireup="true" CodeFile="educationboardprev.aspx.cs" Inherits="educationboardprev" %>

<%@ Register TagPrefix="uc1" TagName="Top" Src="~/UserControl/MainControl.ascx" %>
<%@ Register TagPrefix="uc3" TagName="Right" Src="~/UserControl/RightControl.ascx" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <link href="render/stylesheetedumate.css" rel="stylesheet" type="text/css" />
  <script src="js/jquery-1.6.3.min.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <div class="header-inner-fxd">
            <uc1:Top ID="top1" runat="server" />
        </div>
            <p class="middle-line-03">
        </p>
           <div class="main-container">
               <div class="middle-sectn-04">
    <table width="880px" style="padding-left:10px;" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td align="left" valign="top">
                                        <table width="880px" border="0" cellspacing="0" cellpadding="0" >
                                            <tr>
                                               
                                                <td align="left" valign="top">
                                                    <div >
                                                    <table width="880px" border="0" cellspacing="0" cellpadding="0">
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
                   </div>
               </div>
     <div class="container-rght-sectn-02">
            <uc3:Right ID="Right1" runat="server" />
        </div>
            </div>
        </form>
</body>
</html>
