<%@ Page Title="" Language="C#" MasterPageFile="~/InstitutePanel/MasterPage2.master" AutoEventWireup="true" CodeFile="InnerUnivDetails.aspx.cs" Inherits="InstitutePanel_InnerUnivDetails" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <style>
    .artcless-middle {
width: 90%;
clear: both;
overflow: hidden;
margin-bottom: 20px;
}
.trstfctr {float: right;
border: 1px solid #A7CCF0;
height: 125px;
background: #E2EDF8;
width: 90%;
position: relative;
margin-right: 5px;}
.jdshop .trstfctr{width:313px;}
.trusttl{ margin:0 auto; display:block; line-height:normal; padding:2px 0 2px 0; background:#747474; font-size:12px; color:#e6e6e6;-webkit-border-radius: 0px 0px 10px 10px;-moz-border-radius: 0px 0px 10px 10px;border-radius: 0px 0px 5px 5px; width:98px; text-align:center;}
.trstfctr a{color:#747474;cursor:pointer;}
.trstfctr ul{float:left; width:100%;}
.trstfctr li{border-right: 1px solid #E4E4E4;
float: left;
text-align: center;
color: #747474;
height: 38px;
padding-top: 5px;
width: 99px !important;cursor:pointer;
}
.trstfctr li:hover
{
    background: #F9F9F9;
color: #424242;
cursor:pointer;
}
.fctrnam{width:100%; padding:0 0 7px 0; display:inline-block; font-size:11px; float:left;text-align: left;}
.trstfctr .estd{width: 61px;font-size: 20px;display: inline-block;}
.jdshop .trstfctr .estd{width:50px;}
.trstfctr .fctrtng{width: 148px !important;
padding-left: 16px;height: 47px;}
.jdshop .trstfctr .fctrtng{width:101px;}
.fctrtng a{float:left; width:100%; height:100%;}
.trstfctr .fctnmrt{font-size:19px; width:74px;}
.trstfctr .star_m{padding:0px; margin:3px 0 0 6px;}
.jdshop .trstfctr .star_m{margin:3px 0 0 3px;}
.trstfctr .trjdvrfy{width:112px; border:none; }
.jdshop .trstfctr .trjdvrfy{width:75px;}


.s0,.s1,.s3,.s2,.s4,.s5,.s6,.s7,.s8,.s9,.s10 {
    background-image: url("http://images.jdmagicbox.com/icontent/starbx.gif");
    background-repeat: no-repeat;
    float: left;
    height: 19px;
    width: 19px;
}

.s0 {
    background-position: -2px -1px;
}

.s1 {
    background-position: -22px -1px;
}

.s2 {
    background-position: -41px -1px;
}

.s3 {
    background-position: -61px -1px;
}

.s4 {
    background-position: -81px -1px;
}

.s5 {
    background-position: -101px -1px;
}

.s6 {
    background-position: -121px -1px;
}

.s7 {
    background-position: -141px -1px;
}

.s8 {
    background-position: -161px -1px;
}

.s9 {
    background-position: -180px -1px;
}

.s10 {
    background-position: -200px -1px;
}



.yfrtbx{width:92px;font-size:10px; color:#424242;}
.yfrtbx a{width:100%; height:100%; float:left;}
.jdshop .yfrtbx{width:83px;}
.jfbt .yfrtbx{border:solid 1px #e4e4e4; margin:15px 27px 0 27px; _margin:15px 14px 0 14px; float:right;}
.yfrtbx:hover{background: #f9f9f9; color:#424242;}
.yft{padding:0; font-size:11px; color:#626262; float:left; width:100%; font-weight:bold;}
.yfnm{width:100%;font-size:11px;color:#1274c0;}
.yfstr{float:left; width:56px; padding:2px 21px;}
.jdshop .yfstr{padding:2px 14px;}
.yfrtbx.demo3 .yfstr{padding:2px 21px;}
.yfcnt{font-size:11px; color:#1274c0;}
.yfst{font-size:13px; color:#747474; display:block; padding:3px 0; float:left; width:100%;line-height:13px;}
.yfst b{color:#626262;font-size:12.5px;}
.yfst .rt{color:#1274C0;}
.yfrtbx .nlgn{padding:12px 0;}
.yrt{float:left; width:100%; padding:20px 0 3px 0;}
.yrevnm{clear:both; float:left; width:100%;}/*height:67px;*/
.yrevlnk{width:100%;vertical-align:middle;}
.yamr{float:left; width:100%;}
/*display:table-cell;*/

ul, li, h3, p {
padding: 0;
margin: 0;
list-style-type: none;
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

      <asp:DropDownList ID="ddlNopage" runat="server" CssClass="DropdwonShort" OnSelectedIndexChanged="ddlNopage_SelectedIndexChanged"
                                                                AutoPostBack="True">
                                                                 <asp:ListItem Text="100" Value="100"></asp:ListItem>
                                                                <asp:ListItem Text="500" Value="500"></asp:ListItem>
                                                            </asp:DropDownList>

  <h1 class="country-hdng"><%=Country%> &nbsp;&nbsp;<%=StateName%> </h1>
     <table id='tablepaging'> 
                  <div class="middle-sectn-02">

       
<% for (int i = 0; i <TotalCount; i++)
{
string UniCont = ds.Tables[0].Rows[i]["uniCountry"].ToString();
string linkuniname = ds.Tables[0].Rows[i]["uniName"].ToString();
string linkemail = ds.Tables[0].Rows[i]["uniEmailID"].ToString();
string linkaddress = ds.Tables[0].Rows[i]["uniAddress"].ToString();
string linkimage = ds.Tables[0].Rows[i]["imagePath"].ToString();
string TextTitle = ds.Tables[0].Rows[i]["textTitle"].ToString();
string TextDetails = ds.Tables[0].Rows[i]["textDescription"].ToString();
string UniWebsite = ds.Tables[0].Rows[i]["UniWebsite"].ToString();
string uniID = ds.Tables[0].Rows[i]["uniID"].ToString();
%>

  <tr>
                        <td style="height: 143px; width: 712px;">
<div class="artcless-middle"> 
<p class="artcless-img-02">
<a href ="#"><img src="<%=linkimage%>" id="img<%=i%>image" class="img-size" /> </a></p>


<div class="artcless-container">
<h5 class="hdng-03"><a href ="#"> <%=linkuniname%></a></h5>
<p class="paras-001"><span class="hdng-addr">Address :- </span> <%=linkaddress%></br>
</p>
<p class="paras-002"><span class="hdng-addr">Email :- </span><%=linkemail%></p> 
<div style="padding-bottom: 2px; padding-right: 150px" align="center">
<a class="readmore" target="_blank" href="../mktuniv/<%=uniID%>/<%=UniCont%>/<%=linkuniname%> ">ViewDetails...</a>
</div>            
       
</div></td>
</tr>
<%} %>
<asp:HyperLink ID="HyperLink2" NavigateUrl="<%=UniWebsite%>" runat="server"></asp:HyperLink>
</Table>

</div>
  <div id="pageNavPosition" style="cursor:pointer;padding-top:0;margin-bottom:25px;" align="center"> </div>
    <script type="text/javascript"><!--
        var pager = new Pager('tablepaging', 15);
        pager.init();
        pager.showPageNav('pager', 'pageNavPosition');
        pager.showPage(1);
    </script>
</asp:Content>

