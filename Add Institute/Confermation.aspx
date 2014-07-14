<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Confermation.aspx.cs" Inherits="Add_Institute_Confermation" %>

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
    <div class="form">
    <ul>
    <img src="images/welcome.jpg" style="width: 215px; height: 153px" alt="WelCome" />
</ul>

  </div>
<div class="form-01">
 <h2 class="hdng-edu">Edumate Portal</h2>
  <p>   Congratulations!
Your organisation have successfully registered with us. Please Login <a href="../Default.aspx">here</a>
 <br />

<b>Best Regards:</b><br />
             Team EduMate.
               
</p>
   
 </div>


    </div>
    </div>
            </div>
       
    
    </form>
</body>
</html>

