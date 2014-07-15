<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CollegeDetails.aspx.cs" Inherits="CollegeDetails" %>

<%@ Register TagPrefix="uc1" TagName="Top" Src="~/UserControl/MainControl.ascx" %>
<%@ Register TagPrefix="uc2" TagName="MiddleTop" Src="~/UserControl/MiddleControl.ascx" %>
<%@ Register TagPrefix="uc3" TagName="Right" Src="~/UserControl/RightControl.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Edumate</title>
    <link href="render/stylesheetedumate.css" rel="stylesheet" type="text/css" />
    <script src="JS/jquery.easing.js" type="text/javascript"></script>
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.6.4/jquery.min.js"></script>
    <script src="JS/jqueryTab.js" type="text/javascript"></script>
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
<script src="JS/jquery.prettyPhoto.js" type="text/javascript"></script>
<script src="JS/jquery.quicksand.js" type="text/javascript"></script>
<link href="JS/prettyPhoto.css" rel="stylesheet" type="text/css" />
<script src="JS/script.js" type="text/javascript"></script>
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
            $('a.login-window1').click(function () {

                // Getting the variable's value from a link 
                var loginBox = $(this).attr('href');

                //Fade in the Popup and add close button
                $(loginBox).fadeIn(300);

                //Set the center alignment padding + border
                var popMargTop = ($(loginBox).height() + 24) / 2;
                var popMargLeft = ($(loginBox).width() + 24) / 2;

                $(loginBox).css({
                    'margin-top': -popMargTop,
                    'margin-left': -popMargLeft
                });

                // Add the mask to body
                $('body').append('<div id="mask"></div>');
                $('#mask').fadeIn(300);

                return false;
            });

            // When clicking on the button close or the mask layer the popup closed
            $('a.close, #mask').live('click', function () {
                $('#mask , .login-popup').fadeOut(300, function () {
                    $('#mask').remove();
                });
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
        <div class="main-container">
            
            <asp:DropDownList ID="ddlNopage" runat="server" Visible ="false" CssClass="DropdwonShort" OnSelectedIndexChanged="ddlNopage_SelectedIndexChanged"
                AutoPostBack="True">
                <asp:ListItem Text="10" Value="10"></asp:ListItem>
                <asp:ListItem Text="30" Value="30"></asp:ListItem>
                <asp:ListItem Text="50" Value="50"></asp:ListItem>
                <asp:ListItem Text="100" Value="100"></asp:ListItem>
            </asp:DropDownList>
            <div class="middle-sectn-02 middle-sectn-add">
                <% 
                    string link = ds.Tables[0].Rows[0]["cityName"].ToString();
                    string linkuniname = ds.Tables[0].Rows[0]["collegeName"].ToString();
                    string linkemail = ds.Tables[0].Rows[0]["collegeEmailID"].ToString();
                    string linkaddress = ds.Tables[0].Rows[0]["collegeAddress"].ToString();
                    string linkimage = ds.Tables[0].Rows[0]["collegeimage"].ToString();
                    string UniWebsite = ds.Tables[0].Rows[0]["collegeWebsite"].ToString();

                    string uniID = ds.Tables[0].Rows[0]["collegeID"].ToString();
                %>
                <article class="artcless-middle">
 
<p class="artcless-img-02"><img src="<%=linkimage%>" id="imgimage" class="img-size" /> </p>
<div class="artcless-container">
<h5 class="hdng-03"> <%=linkuniname%></h5>
<p class="paras-001"><span class="hdng-addr">Address :- </span> <%=linkaddress%></br>
</p>
<p class="paras-002"><span class="hdng-addr">Email :- </span><%=linkemail%></p>
  <div class="test-workspace">
        
        <div style="display: Block;" id="workspace">
     <div class="container">

    <ul class="tabs">
        <li><a class="active" href="#tab1">Intro</a></li>

        <li><a href="#tab2">Courses</a></li>
        <li><a href="#tab3">Photos</a></li>
        <li><a href="#tab4">e-Brochure</a></li>
        <li><a href="#tab5<">Contact</a></li>
    </ul>
    <div class="tab_container" id ="tyty" style="display:block; width:680px;overflow-y:scroll;min-height:200px;max-height:210px;">
        <div id="tab1" class="tab_content" style="display:block; width:97%;">
           
        </div>
        <div id="tab2" class="tab_content">
            <h2>Tab 02</h2>
            <p>Grandma been has bankrupt said hospitality fence everlastin' wrestlin' rodeo redblooded chitlins marshal. Boobtube soap her hootch lordy cow, rattler. </p>
            <p>Rottgut havin' ignorant go, hee-haw shiney jail fetched hillbilly havin' cipherin'. Bacon no cowpoke tobaccee horse water rightly trailer tools git hillbilly. </p>
            <p>Jezebel had whiskey snakeoil, askin' weren't, skanky aunt townfolk fetched. Fit tractor, them broke askin', them havin' rattler fell heffer, been tax-collectors buffalo. Quarrel confounded fence wagon trailer, moonshine wuz, city-slickers fixin' cow. </p>
        </div>
        <div id="tab3" class="tab_content">
            <h2>University-Gallery</h2>
         <p></p>
          <% 
              for (int j = 0; j < Totalimage; j++)
              {
                  string Title = dsImage.Tables[0].Rows[j]["imagePath"].ToString();

                  string unID = dsImage.Tables[0].Rows[j]["uniID"].ToString();            
     %>
     <%
         if (uniID == unID)
         {             
     %>

         <span class="image-block">
					<a class="image-zoom" href="~/<%=Title%>" rel="prettyPhoto[gallery]" title="College Gallery"><img width="225" height="140" src="~/<%=Title%>" alt="College Gallery" title="College Gallery" />                    
                    </a>
                    </span>
           
     <%} %>

    
       <%} %>
      
           
            
        </div>
        <div id="tab4" class="tab_content">
            <h2>Tab 04</h2>
       <p>Dirt tools thar, pot buffalo put jehosephat rent, ya pot promenade. Come pickled far greasy fightin', wirey, it poor yer, drive jig landlord. Rustle is been moonshine whomp hogtied. Stew, wirey stew cold uncle ails. Slap hoosegow road cooked, where gal pot, commencin' country. Weren't dogs backwoods, city-slickers me afford boxcar fat, dumb sittin' sittin' drive rustle slap, tornado. Fuss stinky knickers whomp ain't, city-slickers sherrif darn ignorant tobaccee round-up old buckshot that. </p>
            <p>Deep-fried over shootin' a wagon cheatin' work cowpoke poor, wuz, whiskey got wirey that. Shot beer, broke kickin' havin' buckshot gritts. Drunk, em moonshine his commencin' country drunk chitlins stole. Fer tonic boxcar liar ass jug cousin simple, wuz showed yonder hee-haw drive is me. Horse country inbred wirey, skanky kinfolk. Rattler, sittin' darn skanky fence, shot huntin'.</p> 
        </div>
        <div id="tab5" class="tab_content">
            <h2>Tab 03</h2>
             <p>Dirt tools thar, pot buffalo put jehosephat rent, ya pot promenade. Come pickled far greasy fightin', wirey, it poor yer, drive jig landlord. Rustle is been moonshine whomp hogtied. Stew, wirey stew cold uncle ails. Slap hoosegow road cooked, where gal pot, commencin' country. Weren't dogs backwoods, city-slickers me afford boxcar fat, dumb sittin' sittin' drive rustle slap, tornado. Fuss stinky knickers whomp ain't, city-slickers sherrif darn ignorant tobaccee round-up old buckshot that. </p> 
            <p>Deep-fried over shootin' a wagon cheatin' work cowpoke poor, wuz, whiskey got wirey that. Shot beer, broke kickin' havin' buckshot gritts. Drunk, em moonshine his commencin' country drunk chitlins stole. Fer tonic boxcar liar ass jug cousin simple, wuz showed yonder hee-haw drive is me. Horse country inbred wirey, skanky kinfolk. Rattler, sittin' darn skanky fence, shot huntin'.</p> 
            
        </div>
    </div>
</div>         
        </div>
</div>

</article>
                <% %>
                <asp:HyperLink ID="HyperLink2" NavigateUrl="<%=UniWebsite%>" runat="server"></asp:HyperLink>
            </div>
            <div class="middle-sectn-01">
            <h5 class="hdng-03"><asp:Literal ID="litbody" runat="server"></asp:Literal></h5>
<p class="paras-001">
<asp:Literal ID="litName" runat="server"></asp:Literal><br />
<asp:Literal ID="litPresentLocation" runat="server"></asp:Literal><br />
<asp:Literal ID="litPreLocation" runat="server"></asp:Literal>
</p>
            <h6 class="commnt-hdng-cmnt-mn">Comments</h6>
       <section class="commnt-sectn">
<aside class="commnt-sectn-innr">
<article class="commnt-contnt">

  <% 
      if(TotalCount2>0)
      {
      for (int i = 0; i < TotalCount2; i++)
      {

          string Collegeid = dss.Tables[0].Rows[i]["KName"].ToString();
          string cntid = dss.Tables[0].Rows[i]["SComment"].ToString();
          string link1 = dss.Tables[0].Rows[i]["Logo"].ToString();
          %>
<div class="cmnts">
<p class="artcle ss-img-02"><a href ="#">
<img src="~/../<%=link1%>" id="img1"  class="commnt-img" /></a>
</p>


<div class="artcless-container-rght">
<h5 class="hdng-03"><a href ="#"> <%=Collegeid%></a></h5>
<p class="paras-001"><span class="hdng-addr"></span> <%=cntid%></p>
</div>
</div>


<%}}%>

<article class="commnt-contnt">
<asp:Label ID="lblMsg"  runat="server" Text="" ></asp:Label>
<p class="paras-003"><textarea name="comment" class="txt-ara-cmnt" cols="" rows=""></textarea></p>
<div class="btn-sign">
<a href="#login-box" class="login-window1">Add Comment</a>
</div>
    </article>
<div style="display: none; margin-top: -113px; margin-left: -130px;" id="login-box" class="login-popup">
<a href="#" class="close"><img src="../images/closebox.png" class="btn_close" title="Close Window" alt="Close"></a>
<form method="post" class="signin" action="#">
<fieldset class="textbox">
            	<label class="username">
                <span class="lbl-usr">Username or email</span>
                <input id="username" name="username" autocomplete="on" placeholder="Username" type="text" style="font-size:12px;width:154px;margin-bottom:5px;">
                </label>
                
                <label class="password">
                <span class="lbl-usr">Password</span>
                <input id="password" name="password" value="" placeholder="Password" type="password" style="font-size:12px;width:154px;">
                </label>
                
               <%-- <button class="submit button" type="button">Sign in</button>--%>
                <p><asp:Button ID ="btn1" runat ="server" Text ="Submit" class="submit button" onclick="btn1_Click" />

              <div class="btn-sign1"> <a href="../Add Institute/EduType.aspx" class="login-window11">Sign In</a></div>
                </p>
                <p><a class="forgot" href="#">Forgot your password?</a></p>
                

                </fieldset>
</form>
</div>
<div style="display: none; margin-top: -113px; margin-left: -130px;" id="login-box1" class="login-popup">
        <a href="#" class="close"><img src="../images/closebox.png" class="btn_close" title="Close Window" alt="Close"></a>
          <form method="post" class="signin" action="#">
                <fieldset class="textbox">
            	<label class="username">
                <span class="lbl-usr">Username or email</span>
                <input id="Text1" name="username" autocomplete="on" placeholder="Username" type="text" style="font-size:12px;width:154px;margin-bottom:5px;">
                </label>
                
                <label class="password">
                <span class="lbl-usr">Password</span>
                <input id="password1" name="password" value="" placeholder="Password" type="password" style="font-size:12px;width:154px;">
                </label>
                
                <p><asp:Button ID ="Button1" runat ="server" Text ="Register" class="submit button" />
                </p>
                <p><a class="forgot" href="#">Forgot your password?</a></p>
                 </fieldset>
          </form>
		</div>    
</aside>
</article>
         
</section>
               
           </div>
            
        </div>
        <div class="container-rght-sectn-02">
            <uc3:Right ID="Right1" runat="server" />
        </div>
    </div>
<div id="pageNavPosition" style="cursor:pointer;padding-top:0;margin-bottom:25px;" align="center"> </div>
    <script type="text/javascript"><!--
        var pager = new Pager('tablepaging', 5);
        pager.init();
        pager.showPageNav('pager', 'pageNavPosition');
        pager.showPage(1);
    </script>
    </form>
</body>
</html>
