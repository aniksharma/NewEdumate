<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SchoolMain.aspx.cs" Inherits="SchoolMain" %>

<%@ Register TagPrefix="uc1" TagName="Top" Src="~/UserControl/MainControl.ascx" %>
<%@ Register TagPrefix="uc2" TagName="MiddleTop" Src="~/UserControl/MiddleControl.ascx" %>
<%@ Register TagPrefix="uc3" TagName="Right" Src="~/UserControl/RightControl.ascx" %>
<%@ Register TagPrefix="uc4" TagName="footer" Src="~/UserControl/Footer.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Edumate</title>
    <link href="render/stylesheetedumate.css" rel="stylesheet" type="text/css" />
    <script src="JS/jqueryTab.js" type="text/javascript"></script>
    <style>
        .left-sectn {
float: left;
margin-left: 0px;
overflow-x: hidden;
width: 770px;
z-index: 1;
}
    </style>
    
    <script>

        /*
        TOOLTIP
        */

        $(document).ready(function () {
            var targets = $('[rel~=tooltip]'),
				target = false,
				tooltip = false,
				title = false;

            targets.bind('mouseenter', function () {
                target = $(this);
                tip = target.attr('title');
                tooltip = $('<div id="tooltip"></div>');

                if (!tip || tip == '')
                    return false;

                target.removeAttr('title');
                tooltip.css('opacity', 0)
					   .html(tip)
					   .appendTo('body');

                var init_tooltip = function () {
                    if ($(window).width() < tooltip.outerWidth() * 1.5)
                        tooltip.css('max-width', $(window).width() / 2);
                    else
                        tooltip.css('max-width', 340);

                    var pos_left = target.offset().left + (target.outerWidth() / 2) - (tooltip.outerWidth() / 2),
						pos_top = target.offset().top - tooltip.outerHeight() - 20;

                    if (pos_left < 0) {
                        pos_left = target.offset().left + target.outerWidth() / 2 - 20;
                        tooltip.addClass('left');
                    }
                    else
                        tooltip.removeClass('left');

                    if (pos_left + tooltip.outerWidth() > $(window).width()) {
                        pos_left = target.offset().left - tooltip.outerWidth() + target.outerWidth() / 2 + 20;
                        tooltip.addClass('right');
                    }
                    else
                        tooltip.removeClass('right');

                    if (pos_top < 0) {
                        var pos_top = target.offset().top + target.outerHeight();
                        tooltip.addClass('top');
                    }
                    else
                        tooltip.removeClass('top');

                    tooltip.css({ left: pos_left, top: pos_top })
						   .animate({ top: '+=10', opacity: 1 }, 50);
                };

                init_tooltip();
                $(window).resize(init_tooltip);

                var remove_tooltip = function () {
                    tooltip.animate({ top: '-=10', opacity: 0 }, 50, function () {
                        $(this).remove();
                    });

                    target.attr('title', tip);
                };

                target.bind('mouseleave', remove_tooltip);
                tooltip.bind('click', remove_tooltip);
            });
        });

        /*
        ---
        */

    </script>
    <script>

        /*
        VIEWPORT BUG FIX
        iOS viewport scaling bug fix, by @mathias, @cheeaun and @jdalton
        */

        (function (doc) {
            var addEvent = 'addEventListener',
			    type = 'gesturestart',
			    qsa = 'querySelectorAll',
			    scales = [1, 1],
			    meta = qsa in doc ? doc[qsa]('meta[name=viewport]') : [];

            function fix() {
                meta.content = 'width=device-width,minimum-scale=' + scales[0] + ',maximum-scale=' + scales[1];
                doc.removeEventListener(type, fix, true);
            }

            if ((meta = meta[meta.length - 1]) && addEvent in doc) {
                fix();
                scales = [.25, 1.6];
                doc[addEvent](type, fix, true);
            }

        } (document));

    </script>
    <script type="text/javascript">

        function Pager(tableName, itemsPerPage) {

            this.tableName = tableName;

            this.itemsPerPage = itemsPerPage;

            this.currentPage = 1;

            this.pages = 0;

            this.inited = false;

            this.showRecords = function (from, to) {

                var rows = document.getElementById(tableName).rows;

                // i starts from 1 to skip table header row

                for (var i = 1; i < rows.length; i++) {

                    if (i < from || i > to)

                        rows[i].style.display = 'none';

                    else

                        rows[i].style.display = '';

                }

            }

            this.showPage = function (pageNumber) {

                if (!this.inited) {

                    alert("not inited");

                    return;

                }

                var oldPageAnchor = document.getElementById('pg' + this.currentPage);

                oldPageAnchor.className = 'pg-normal';

                this.currentPage = pageNumber;

                var newPageAnchor = document.getElementById('pg' + this.currentPage);

                newPageAnchor.className = 'pg-selected';

                var from = (pageNumber - 1) * itemsPerPage + 1;

                var to = from + itemsPerPage - 1;

                this.showRecords(from, to);

            }

            this.prev = function () {

                if (this.currentPage > 1)

                    this.showPage(this.currentPage - 1);

            }

            this.next = function () {

                if (this.currentPage < this.pages) {

                    this.showPage(this.currentPage + 1);

                }

            }

            this.init = function () {

                var rows = document.getElementById(tableName).rows;

                var records = (rows.length - 1);

                this.pages = Math.ceil(records / itemsPerPage);

                this.inited = true;

            }

            this.showPageNav = function (pagerName, positionId) {

                if (!this.inited) {

                    alert("not inited");

                    return;

                }

                var element = document.getElementById(positionId);

                var pagerHtml = '<span onclick="' + pagerName + '.prev();" class="pg-normal"> « Prev </span> ';

                for (var page = 1; page <= this.pages; page++)

                    pagerHtml += '<span id="pg' + page + '" class="pg-normal" onclick="' + pagerName + '.showPage(' + page + ');">' + page + '</span> ';

                pagerHtml += '<span onclick="' + pagerName + '.next();" class="pg-normal"> Next »</span>';

                element.innerHTML = pagerHtml;

            }

        }

    </script>
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
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="header-inner-fxd">
            <uc1:Top ID="top1" runat="server" />
        </div>
        <div>
            <uc2:MiddleTop ID="MiddleTop" runat="server" />
        </div>
        <p class="middle-line-03">
        </p>

        <div class="container-rght-sectn-02">
        
            <uc3:Right ID="Right1" runat="server" />
        </div>
            <div class="left-sectn">

           &nbsp;  <asp:DropDownList ID="ddlNopage" Visible ="false" runat="server" CssClass="DropdwonShort" OnSelectedIndexChanged="ddlNopage_SelectedIndexChanged"
                                                                AutoPostBack="True">
                                                                <asp:ListItem Text="10" Value="10"></asp:ListItem>
                                                                <asp:ListItem Text="30" Value="30"></asp:ListItem>
                                                                <asp:ListItem Text="50" Value="50"></asp:ListItem>
                                                                <asp:ListItem Text="100" Value="100"></asp:ListItem>
                                                            </asp:DropDownList>
                <div class="middle-sectn-02">

                <h3 class="hdng-03"> <a href ="#"><%=Country%> &nbsp;&nbsp;<%=StateName%></a> </h3>
                

       
                
                <% 
     for (int i = 0; i < TotalCount; i++)
     {

         string Collegeid = ds.Tables[0].Rows[i]["CollegeID"].ToString();
         string cntid = ds.Tables[0].Rows[i]["cntId"].ToString();
         string link = ds.Tables[0].Rows[i]["cityName"].ToString();
         string linkuniname = ds.Tables[0].Rows[i]["collegeName"].ToString();
         string linkemail = ds.Tables[0].Rows[i]["collegeEmailID"].ToString();
         string linkaddress = ds.Tables[0].Rows[i]["collegeAddress"].ToString();
           string linkimage = ds.Tables[0].Rows[i]["collegeImage"].ToString();
         string UniWebsite = ds.Tables[0].Rows[i]["collegeWebsite"].ToString();
        %>
<article class="artcless-middle">
 
<p class="artcless-img-02"><a href ="#"><img src="~/<%=linkimage%>" id="img<%=i%>image"  class="img-size" /></a></p>


<div class="artcless-container">
<h5 class="hdng-03"><a href ="#"> <%=linkuniname%></a></h5>
<p class="paras-001"><span class="hdng-addr">Address :- </span> <%=linkaddress%></br>
</p>
<p class="paras-002"><span class="hdng-addr">Email :- </span><%=linkemail%></p>
 

   <div style="padding-bottom: 2px; padding-right: 150px" align="center">
        <a class="readmore" target ="_blank" href="SchoolDetails.aspx?Unid=<%=Collegeid%> /<%=cntid%>/">ViewDetails...</a></div>

</article>



<%} %>


 <div id="pageNavPosition" style="cursor:pointer;padding-top:0;margin-bottom:25px;" align="center"> </div>

<asp:HyperLink ID="HyperLink2"  NavigateUrl ="<%=UniWebsite%>" runat ="server"></asp:HyperLink>
</div>
 </div>

    </div>
<script type="text/javascript"><!--
    var pager = new Pager('tablepaging', 5);
    pager.init();
    pager.showPageNav('pager', 'pageNavPosition');
    pager.showPage(1);
</script>
    </form>
</body>
</html>
