<%@ Page Language="C#" AutoEventWireup="true" CodeFile="findjob.aspx.cs" Inherits="JobPlacement_findjob" %>
<%@ Register src="~/UserControl/jobs-top.ascx" tagname="header" tagprefix="uc1" %>
<%@ Register src="~/UserControl/Footer.ascx" tagname="footer" tagprefix="uc2" %>
<%@ Register TagPrefix="uc3" TagName="Right" Src="~/UserControl/RightControl.ascx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Edumate</title>
    <link href="../render/stylesheetedumate.css" rel="stylesheet" type="text/css" />
    <script src="../JS/jqueryTab.js" type="text/javascript"></script>
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
    <link href="../JobPlacement/css/jquery.autocomplete.css" rel="stylesheet" type="text/css" />
    <script src="../scripts/jquery-1.4.1.min.js" type="text/javascript"></script>
    <script src="../scripts/jquery.autocomplete.js" type="text/javascript"></script>
   
</head>
<body>
   <form id="frmjob" runat="server">
<div>
 <div class="header-inner-fxd">
<uc1:header ID="header1" runat="server" />
</div>
    <p class="middle-line-03"></p>
<div class="middle-seacrh-sectn-03">
<section class="middle-sectn-01 middle-sectn-add">
<div class="nav-03" style="margin-bottom:5px;float:left;">
<ul>
<li><a href="findjob.aspx" title="Fin Job">Find Job</a></li>
<li><a href="job-Description.aspx" title="Job Seeker">Job Seeker</a></li>
</ul></div>
   
<div class="slct-sectn-02">
<asp:DropDownList ID="ddlFunctional_Area" CssClass="DropdwonLong" runat="server">
    <asp:ListItem>--Select Functional Area--</asp:ListItem>
    <asp:ListItem>Teaching, Education</asp:ListItem>
    <asp:ListItem>Education/ Teaching/Training</asp:ListItem>
    <asp:ListItem>Teacher / Lecturer / Professor / Academic Research</asp:ListItem>
    <asp:ListItem>HR / Administration, IR</asp:ListItem>
    <asp:ListItem>Teaching</asp:ListItem>
    <asp:ListItem>Others</asp:ListItem>
</asp:DropDownList>
</div>

<div class="slct-sectn-02">
<asp:DropDownList ID="ddlCategory" CssClass="DropdwonLong" runat="server">
 <asp:ListItem>--Select category--</asp:ListItem>
                    <asp:ListItem>Schools</asp:ListItem>
                    <asp:ListItem>College</asp:ListItem>
                    <asp:ListItem>University</asp:ListItem>
                    <asp:ListItem>Company</asp:ListItem>
                    <asp:ListItem>Training/Coaching Institutes</asp:ListItem>
</asp:DropDownList>
</div>

<div class="slct-sectn-02">
<asp:DropDownList ID="ddlRole" runat="server" CssClass="DropdwonLong">
                          <asp:ListItem>--Select Role--</asp:ListItem>
                          <asp:ListItem>Advisors</asp:ListItem>
                          <asp:ListItem>Assessor</asp:ListItem>
                          <asp:ListItem>Business Manager/Bursar</asp:ListItem>
                          <asp:ListItem>Classroom Teacher</asp:ListItem>
                          <asp:ListItem>Co-ordinator</asp:ListItem>
                          <asp:ListItem>Consultant</asp:ListItem>
                          <asp:ListItem>Content Specialists</asp:ListItem>
                          <asp:ListItem>Curriculum Leader</asp:ListItem>
                          <asp:ListItem>Customer Support/Manager</asp:ListItem>
                          <asp:ListItem>Deputy Head Teacher</asp:ListItem>
                          <asp:ListItem>Director/Principal</asp:ListItem>
                          <asp:ListItem>Education Officer</asp:ListItem>
                          <asp:ListItem>Educational Psychologist</asp:ListItem>
                          <asp:ListItem>Examiner</asp:ListItem>
                          <asp:ListItem>Freelance Teacher</asp:ListItem>
                          <asp:ListItem>Head of Department</asp:ListItem>
                          <asp:ListItem>Head Teacher</asp:ListItem>
                          <asp:ListItem>Leadership/Excellence Teacher</asp:ListItem>
                          <asp:ListItem>Lecturer</asp:ListItem>
                          <asp:ListItem>Librarian</asp:ListItem>
                          <asp:ListItem>Manager</asp:ListItem>
                          <asp:ListItem>Nursery Teacher</asp:ListItem>
                          <asp:ListItem>Special Needs Teacher</asp:ListItem>
                          <asp:ListItem>Teaching Assistant</asp:ListItem>
                          <asp:ListItem>Tutor</asp:ListItem>
                          <asp:ListItem>Other</asp:ListItem>               
                         </asp:DropDownList>
</div>

<asp:Label ID="lblMsg"  runat="server" Text="" ></asp:Label>

<asp:Button ID="btnSearch" runat="server" CssClass="bnt-sbmt-01" Text="Search" 
       onclick="btnSearch_Click" CausesValidation="false" />
 
</div>
<p class="sngle-line"></p>
<%--<div class="main-container">--%>

<section class="middle-sectn">

<h5 class="hdng-03"><asp:Literal ID="litbody" runat="server"></asp:Literal></h5>


<p class="paras-001">
<asp:Literal ID="litName" runat="server"></asp:Literal><br />
<asp:Literal ID="litPresentLocation" runat="server"></asp:Literal><br />
<asp:Literal ID="litPreLocation" runat="server"></asp:Literal>
</p>


</section>
<section>

</section>



 <div class="container-rght-sectn-02">
        
            <uc3:Right ID="Right1" runat="server" />
        </div>

</div>
<footer>
<uc2:footer ID="footer1" runat="server" />

</footer>
</section>
</form>
</body>
</html>
