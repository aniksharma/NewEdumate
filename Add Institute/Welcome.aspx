<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Welcome.aspx.cs" Inherits="Add_Institute_Welcome" %>
<%@ Register TagPrefix="uc1" TagName="Top" Src="~/UserControl/MainControl.ascx" %>
<%@ Register TagPrefix="uc2" TagName="MiddleTop" Src="~/UserControl/MiddleControl.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="../render/stylesheetedumate.css" rel="stylesheet" type="text/css" />
    <link href="../render/login.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    
            <div>
                <div>
                    <uc1:Top ID="top1" runat="server" />
                </div>
                 
            
                <p class="sngle-line"></p>

<div class="middle-sectn-ebag">
<div class="midlle-home"> 
<div class="form-01">
 <h2 class="hdng-edu">Edumate Portal</h2>
  <p>  We have sent you a confirmation mail on your email id-<asp:Label ID="Label1" runat="server" Font-Bold="True"></asp:Label>
Kindly login into you mail account and verify your account with us!
 Please check your spam/junk/bulk folder incase the verification 
 mail has been diverted to the same. Best Regards,<br />
             Team EduMate.
               <a href="../default.aspx" style="text-decoration:none; font-weight:bold; color:Blue;" >
             Go Back</a>  
</p>
   
 </div>


    </div>
    </div>
            </div>
       
    
    </form>
</body>
</html>
