<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MainMiddle.ascx.cs" Inherits="UserControl_MainMiddle" %>
<script>
    $(document).ready(function () {
        $("#content div").hide(); // Initially hide all content
        $("#tabs li:first").attr("id", "current"); // Activate first tab
        $("#content div:first").fadeIn(); // Show first tab content

        $('#tabs a').click(function (e) {
            e.preventDefault();
            $("#content div").hide(); //Hide all content
            $("#tabs li").attr("id", ""); //Reset id's
            $(this).parent().attr("id", "current"); // Activate this
            $('#' + $(this).attr('title')).fadeIn(); // Show content for current tab
        });
    })();
</script>
<section class="middle-sectn-main">
    .
    <div class="middle-uppr-sectn">
        <div class="middle-uppr-navisectn">
            <ul>
                <li><a href="<%=ResolveClientUrl("~/UniversityMain.aspx?name=Uni")%>">Universities</a></li>
                <li><a href="<%=ResolveClientUrl("~/CollegeMain.aspx?name=College")%>">College</a></li>
                <li><a href="<%=ResolveClientUrl("~/SchoolMain.aspx?name=School")%>">School</a></li>
                <li><a href="<%=ResolveClientUrl("~/InstitutesMain.aspx?name=Inst")%>">Institutes</a></li>
                <li><a href="<%=ResolveClientUrl("~/TeacherMain.aspx?name=Teacher")%>">Teacher</a></li>
                <li><a href="#" title="Blog">Blog</a></li>
            </ul>
        </div>
        <div class="secrh-sectn">
            <input name="" type="text" class="secrh-fld"><input name="Search" value="Search" class="secrh-btn" type="button">
        </div>
    </div>
    <article class="lst-sectn" style="width: 86%">

        <div class="tabs-sectn">
            <ul id="tabs">
                <li><a href="#" title="tab1">News</a></li>
                <li><a href="#" title="tab2">Articles</a></li>

                <li><a href="#" title="tab3">Alerts</a></li>

            </ul>

            <div id="content">
                <div id="tab1">
                    <% 
            
                        if (ds.Tables[0].Rows.Count > 0)
                        {

                            string linkuniname = ds.Tables[0].Rows[0]["newsTitle"].ToString();
     
                    %>

                    <article class="artcless-middle" style="width: 670px">
                        <p class="artcless-img-02">
                            <img src="~/../<%=ds.Tables[0].Rows[0]["fullpath"].ToString()%>" id="img1" class="img-size" />
                        </p>
                        <h5 class="user-updates" style="margin: 0 0 5px 0;"><a target="_blank" href="<%=ds.Tables[0].Rows[0]["accutalpath"].ToString() %>-<%=ds.Tables[0].Rows[0]["newsID"].ToString()%>"><%=ds.Tables[0].Rows[0]["newsTitle"].ToString()%></a></h5>
                        <p class="paras-001-01">
                            <span><%=ds.Tables[0].Rows[0]["SubTitle"].ToString()%> </span>
                            <br />
                            <p class="paras-002"><span class="hdng-addr"></span></p>
                        <div style="padding-bottom: 2px; padding-right: 150px" align="center">
                            <a class="readmore" target="_blank" href="New-Final.aspx?Id=<%=ds.Tables[0].Rows[0]["newsID"].ToString()%>">ViewDetails...</a>
                        </div>

                    </article>



                    <% }%>



                    <article class="lst-sectn">
                        <% 
                            for (int i = 0; i < TotalCount; i++)
                            {
                               
                        %>

                        <ul>
                            <li><a target="_blank" href="<%=ds.Tables[0].Rows[i]["accutalpath"].ToString() %>-<%=ds.Tables[0].Rows[i]["newsID"].ToString()%>"><%=ds.Tables[0].Rows[i]["newsTitle"].ToString()%></a></li>

                        </ul>
                        <%} %>

                        <a class="readmore" target="_blank" href="education-news">More...</a>
                </div>
                <div id="tab2">
                    <% 
                        if (ds1.Tables[0].Rows.Count > 0)
                        {

                            string linkuniname = ds1.Tables[0].Rows[0]["newsTitle"].ToString();
                           
                    %>

                    <article class="artcless-middle">

                        <p class="artcless-img-02">
                            <img src="~/../images/<%=ds1.Tables[0].Rows[0]["fullpath"].ToString()%>" id="img2" class="img-size" />
                        </p>


                        <h5 class="user-updates" style="margin: 0 0 5px 0;"><a target="_blank" href="<%=ds1.Tables[0].Rows[0]["accutalpath"].ToString() %>-<%=ds1.Tables[0].Rows[0]["newsID"].ToString()%>"><%=ds.Tables[0].Rows[0]["newsTitle"].ToString()%></h5>
                        <p class="paras-001-01">
                            <span><%=ds1.Tables[0].Rows[0]["SubTitle"].ToString()%> </span><%--<%=linkaddress%>--%>
                        </br>
                        <p class="paras-002"><%--<%=linkemail%>--%></p>


                        <div style="padding-bottom: 2px; padding-right: 150px" align="center">
                            <a class="readmore" target="_blank" href="New-Final.aspx?Id=<%=ds1.Tables[0].Rows[0]["newsID"].ToString()%>">ViewDetails...</a>
                        </div>

                    </article>



                    <% }%>



                    <article class="lst-sectn">
                        <% 
                            for (int i = 0; i < TotalCount1; i++)
                            {
                                
                        %>

                        <ul>
                            <li><a target="_blank" href="<%=ds1.Tables[0].Rows[i]["accutalpath"].ToString() %>-<%=ds1.Tables[0].Rows[i]["newsID"].ToString()%>"><%=ds1.Tables[0].Rows[i]["newsTitle"].ToString()%></a></li>

                        </ul>
                        <%} %>

                        <a class="readmore" target="_blank" href="education-articles">More...</a>
                </div>
                <div id="tab3">
                    <% 
                        if (ds2.Tables[0].Rows.Count > 0)
                        {

                            string linkuniname = ds2.Tables[0].Rows[0]["newsTitle"].ToString();
                            
                    %>

                    <article class="artcless-middle">

                        <p class="artcless-img-02">
                            <img src="~/../<%=ds2.Tables[0].Rows[0]["fullpath"].ToString()%>" id="img3" class="img-size" />
                        </p>

                        <h5 class="user-updates" style="margin: 0 0 5px 0;"><a target="_blank" href="<%=ds2.Tables[0].Rows[0]["accutalpath"].ToString() %>-<%=ds2.Tables[0].Rows[0]["newsID"].ToString()%>"><%=ds.Tables[0].Rows[0]["newsTitle"].ToString()%></h5>
                        <p class="paras-001-01">
                            <span><%=ds2.Tables[0].Rows[0]["SubTitle"].ToString()%> </span><%--<%=linkaddress%>--%></br>
                        </p>
                        <p class="paras-002"><%--<%=linkemail%>--%></p>


                        <div style="padding-bottom: 2px; padding-right: 150px" align="center">
                            <a class="readmore" target="_blank" href="New-Final.aspx?Id=<%=ds2.Tables[0].Rows[0]["newsID"].ToString()%>">ViewDetails...</a>
                        </div>

                    </article>



                    <% }%>



                    <article class="lst-sectn">
                        <% 
                            for (int i = 0; i < TotalCount2; i++)
                            {

                        %>

                        <ul>
                            <li><a target="_blank" href="<%=ds2.Tables[0].Rows[i]["accutalpath"].ToString() %>-<%=ds2.Tables[0].Rows[i]["newsID"].ToString()%>"><%=ds2.Tables[0].Rows[i]["newsTitle"].ToString()%></a></li>

                        </ul>
                        <%} %>



                        <a class="readmore" target="_blank" href="education-alerts">More...</a>
                </div>
            </div>
        </div>

    </article>
    <article class="btm-sectn">
        <div class="btm-blk-01">
            <h5 class="hdng-03"><a target="_blank" href="<%=ResolveClientUrl("~/JobPlacement/findJob.aspx")%>">Jobs</a> </h5>
            <div class="img-btm-sectn">
                <img src="images/btm-img.jpg" width="70" height="52" alt="Jobs">
            </div>
            <p class="paras-01">
                Lorem ipsum dolor siter,</br>
Lorem ipsum,
            </p>
        </div>
        <div class="btm-blk-01">
            <h5 class="hdng-03"><a href="Academic/FindAcademic.aspx">Academic</a></h5>
            <div class="img-btm-sectn">
                <img src="images/btm-img.jpg" width="70" height="52" alt="Jobs">
            </div>
            <p class="paras-01">
                Lorem ipsum dolor siter,</br>
Lorem ipsum,
            </p>
        </div>
        <div class="btm-blk-01">
            <h5 class="hdng-03">Tuition Request</h5>
            <div class="img-btm-sectn">
                <img src="images/btm-img.jpg" width="70" height="52" alt="Jobs">
            </div>
            <p class="paras-01">
                Lorem ipsum dolor siter,</br>
Lorem ipsum,
            </p>
        </div>

    </article>
</section>
