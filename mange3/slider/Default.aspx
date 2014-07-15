<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="mange3_slider_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>dd</title>
      <link rel="stylesheet" href="nivo-slider.css" type="text/css" media="screen" />
    <link rel="stylesheet" href="style.css" type="text/css" media="screen" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
         
            <div id="slider" class="nivoSlider" >
             <asp:Repeater ID="datalist" runat="server" >
                    <ItemTemplate>

                        <img src='<%#Eval("path")%>' height="210" width="610" alt='<%#Eval("name")%>' />
                    </ItemTemplate>
                </asp:Repeater>
            </div>
    
    <script type="text/javascript" src="jquery-1.4.3.min.js"></script>

    <script type="text/javascript" src="jquery.nivo.slider.pack.js"></script>

    <script type="text/javascript">
        $(window).load(function () {
            $('#slider').nivoSlider();
        });
    </script>

    </div>
    </form>
</body>
</html>
