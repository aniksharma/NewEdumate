<%@ Page Title="" Language="C#" MasterPageFile="~/InstitutePanel/MasterPage2.master" AutoEventWireup="true" CodeFile="innerExam.aspx.cs" Inherits="InstitutePanel_innerExam" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
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

                oldPageAnchor.className = 'pg';

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

                    pagerHtml += '<span id="pg' + page + '" onclick="' + pagerName + '"></span> ';

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
    <div>
    <table id='tablepaging'>
 <div class="main-container">
            <div class="middle-sectn-02">
           
                <% 
                    for (int i = 0; i < TotalCount; i++)
                    {

                        string Newsid = ds.Tables[0].Rows[i]["newsTypeID"].ToString();
                        string link = ds.Tables[0].Rows[i]["NewsType"].ToString();
                %>
              <tr>
                        <td style="height: 143px; width: 712px;">
                <article class="artcless-middle">
                                <h1 class="edu-analy-hdng"><%=link%></h1>
                
                    <div class="paras-001">
                        <% 
                            for (int j = 0; j < TotalCount1; j++)
{
string Title = ds1.Tables[0].Rows[j]["newsTypeID"].ToString();
string unID = ds1.Tables[0].Rows[j]["newsTitle"].ToString();
string newstypeid = ds1.Tables[0].Rows[j]["newsID"].ToString();
 %>
                        <ul style="padding-left:15px;">
                            <%
                                if (Newsid == Title)
                                {   
         
                   
                            %>
                             <li><a target ="_blank"  href="../ViewCareerDetails.aspx?Uid=<%=newstypeid%>">
                                <%=unID%></a></li>
                            <%} %>
                        </ul>
                        <%}%>
                        </article>
                      </td>
                    </tr>

                        <%   } %>
</table>
<div id="pageNavPosition" style="cursor:pointer;padding-top:0;margin-bottom:25px;" align="center"> </div>
    <script type="text/javascript"><!--
        var pager = new Pager('tablepaging', 2);
        pager.init();
        pager.showPageNav('pager', 'pageNavPosition');
        pager.showPage(1);  
    </script>
</div>
</asp:Content>

