<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TabControl.ascx.cs" Inherits="UserControl_TabControl" %>
<link href="../render/stylesheetedumate.css" rel="stylesheet" type="text/css" />
<script src="../JS/jqueryTab.js" type="text/javascript"></script>
<script type="text/javascript">


    $(document).ready(function () {

        //Default Action
        $(".tab_content").hide(); //Hide all content
        $("ul.tabs li:first").addClass("active").show(); //Activate first tab
        $(".tab_content:first").show(); //Show first tab content

        //On Click Event
        $("ul.tabs li").click(function () {
            $("ul.tabs li").removeClass("active"); //Remove any "active" class
            $(this).addClass("active"); //Add "active" class to selected tab
            $(".tab_content").hide(); //Hide all tab content
            var activeTab = $(this).find("a").attr("href"); //Find the rel attribute value to identify the active tab + content
            $(activeTab).fadeIn(); //Fade in the active content
            return false;
        });

    });

</script>

<section class="middle-seacrh-sectn">

<div class="nav-03" style="width:97%;padding:0px;margin-bottom:6px;">
    <ul>
        <li><a href="<%=ResolveClientUrl("~/News.aspx?name=News")%>">News</a></li>
        <li><a href="<%=ResolveClientUrl("~/Articles.aspx?name=Articles")%>">Articles</a></li>
        <li><a href="<%=ResolveClientUrl("~/Alerts.aspx?name=Alerts")%>">Alerts</a></li>
    </ul>
</div>

</section>
