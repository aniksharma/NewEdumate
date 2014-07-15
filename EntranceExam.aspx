﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EntranceExam.aspx.cs" Inherits="EntranceExam" %>

<%@ Register TagPrefix="uc1" TagName="Top" Src="~/UserControl/MainControl.ascx" %>
<%@ Register TagPrefix="uc3" TagName="Right" Src="~/UserControl/RightControl.ascx" %>
<%@ Register TagPrefix="uc2" TagName="MiddleTop" Src="~/UserControl/MiddleControl.ascx" %>
<%@ Register TagPrefix="uc4" TagName="footer" Src="~/UserControl/Footer.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Edumate</title>
     <script src="js/jquery-1.6.3.min.js" type="text/javascript"></script>
    <link href="render/stylesheetedumate.css" rel="stylesheet" type="text/css" />
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
        <p class="middle-line-03"></p>
       
        <div class="main-container">
            <div class="middle-sectn-02 middle-sectn-add">
<table id='table' class="blck-01">
                <% 
                    for (int i = 0; i < TotalCount; i+=2)
                    {

                        string Newsid = ds.Tables[0].Rows[i]["newsTypeID"].ToString();
                        string link = ds.Tables[0].Rows[i]["NewsType"].ToString();
                %>
                <tr>
<td style="height: auto;">
<article class="artcless-middle-lft1">
<h5 class="hdng-03">
                    <%=link%>
                </h5>
<div class="paras-001">
<% 
                            for (int j = 0; j < TotalCount1; j+=2)
                            {
                                string Title = ds1.Tables[0].Rows[j]["newsTypeID"].ToString();

                                string unID = ds1.Tables[0].Rows[j]["newsTitle"].ToString();
                                string newstypeid = ds1.Tables[0].Rows[j]["newsID"].ToString();
                                string path = ds1.Tables[0].Rows[j]["acctualPath"].ToString();
                    
                    
                    
                        %>
<ul style="padding:0;margin-left:15px;">
<%
if (Newsid == Title)
{   
 %>
<li><a target ="_blank" class="lnl-styl" href="<%=path %><%=newstypeid%>">
                                <%=unID%></a></li>
                            <%} %>
                        </ul>
                        <%}%>
</div>
</article>



</td>
</tr>
 <% } %>
</table>

<table id='table1' class="blck-01">
                <% 
                    for (int i = 1; i < TotalCount; i+=2)
                    {

                        string Newsid = ds.Tables[0].Rows[i]["newsTypeID"].ToString();
                        string link = ds.Tables[0].Rows[i]["NewsType"].ToString();
                %>
                <tr>
<td style="height: auto;">
<article class="artcless-middle-lft1">
<h5 class="hdng-03">
                    <%=link%>
                </h5>
<div class="paras-001">
<% 
for (int j = 1; j < TotalCount1; j+=2)
{
                                string Title = ds1.Tables[0].Rows[j]["newsTypeID"].ToString();

                                string unID = ds1.Tables[0].Rows[j]["newsTitle"].ToString();
                                string newstypeid = ds1.Tables[0].Rows[j]["newsID"].ToString();
                                string path = ds1.Tables[0].Rows[j]["acctualPath"].ToString();
                    
                    
%>
<ul style="padding:0;margin-left:15px;">
<%
if (Newsid == Title){ %>
<li><a target ="_blank" class="lnl-styl" href="<%=path %><%=newstypeid%>">
 <%=unID%></a></li>
<%} %>
 </ul>
<%}%>
</div>
</article>



</td>
</tr>
 <% } %>
</table>

 <div id="pageNavPosition" align="center">
    </div>
    <script type="text/javascript"><!--
        var pager = new Pager('tablepaging', 7);
        pager.init();
        pager.showPageNav('pager', 'pageNavPosition');
        pager.showPage(1);
    </script>
                    </div>

                   
            </div>

             <div class="container-rght-sectn-02"><uc3:Right ID="Right1" runat="server"/></div>
            </div>
<footer>
<uc4:footer ID="footer1" runat="server" />
</footer>
    </form>
</body>
</html>
