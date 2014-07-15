    <%@ Application Language="C#" %>
<%@ Import Namespace="System.Web.Routing" %>
<script RunAt="server">

    void Application_Start(object sender, EventArgs e)
    {
        RegisterRoutes(RouteTable.Routes);
        // Code that runs on application startup

    }

    void Application_End(object sender, EventArgs e)
    {
        //  Code that runs on application shutdown

    }

    void Application_Error(object sender, EventArgs e)
    {
        // Code that runs when an unhandled error occurs

    }

    void Session_Start(object sender, EventArgs e)
    {
        // Code that runs when a new session is started
        Session["myvariable"] = "Gowtham";

    }

    void Session_End(object sender, EventArgs e)
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.

    }

    void RegisterRoutes(RouteCollection routes)
    {
        //------------------------------------------------------------------------------------------------//
        //micro website setting template I
        routes.MapPageRoute("HOMEONLY", "UserHome", "~/InstitutePanel/Default.aspx");
        routes.MapPageRoute("one", "mkt/{values}", "~/manage2/Default.aspx");
        routes.MapPageRoute("one111", "YourWebsite/{values}", "~/manage2/Default.aspx");

        routes.MapPageRoute("t1rootneww", "Web/{Sname}/{Pagename}", "~/manage2/NewWeb/pagedata.aspx");
        routes.MapPageRoute("t1rootnewwgal1", "WebGallery/{Sname}/{Pagename}", "~/manage2/NewWeb/pageGellary.aspx");


        routes.MapPageRoute("t1gellarygal22", "EditGallery/{Sname}/{Pagename}", "~/manage2/NewWeb/pagegalery.aspx");

        routes.MapPageRoute("t1gellary1fac", "Faculty/{Sname}/{Pagename}", "~/manage2/NewWeb/Faculty.aspx");
        routes.MapPageRoute("t1gellary2stdgrp", "StudentGroup/{Sname}/{Pagename}", "~/manage2/NewWeb/Student-Group.aspx");
        
        routes.MapPageRoute("onestu", "mktst/{values}/{pps}", "~/manage2/Default.aspx");
        routes.MapPageRoute("onesa", "mktuniv/{valuess}/{p1s}/{p1}", "~/ViewUniDetails.aspx");
        routes.MapPageRoute("onesauniv", "University/{valuess}-{p1s}-{p1}", "~/ViewUniDetails.aspx");
        routes.MapPageRoute("onesacollege", "College/{valuess}-{p1s}-{p1}", "~/CollegeDetails.aspx");
        routes.MapPageRoute("onesc", "mktclg/{valuess}/{p1s}/{p1}", "~/TeacherDetails.aspx");
        routes.MapPageRoute("ones", "mkt1/{values}", "~/manage2/NewWeb/page.aspx");
        routes.MapPageRoute("one1", "Teacher/{values}", "~/InstitutePanel/InnerTeacher.aspx");
        routes.MapPageRoute("one2", "Teacher1/{values}/{p1}", "~/InstitutePanel/InnerTeacher.aspx");
        routes.MapPageRoute("one3", "Inst/{values}", "~/InstitutePanel/InnerInstitute.aspx");
        routes.MapPageRoute("one4", "Inst1/{values}/{p1}", "~/InstitutePanel/InnerInstitute.aspx");

        routes.MapPageRoute("one5", "School/{values}", "~/InstitutePanel/InnerSchool.aspx");
        routes.MapPageRoute("one6", "School1/{values}/{p1}", "~/InstitutePanel/InnerSchool.aspx");

        routes.MapPageRoute("one7", "College/{values}", "~/InstitutePanel/InnerCollege.aspx");
        routes.MapPageRoute("one8", "College1/{values}/{p1}", "~/InstitutePanel/InnerCollege.aspx");

        routes.MapPageRoute("one9", "Univ/{values}", "~/InstitutePanel/InnerUnivDetails.aspx");

        routes.MapPageRoute("one10", "Univ1/{values}-{p1}", "~/InstitutePanel/InnerUnivDetails.aspx");
        routes.MapPageRoute("one11", "Univ2/{values}-{p11}-{p2}-{p3}", "~/InstitutePanel/InnerUnivDetails.aspx");
        
        routes.MapPageRoute("one1100", "UniversityInner/{con}-{state}-{uni}-{edu}", "~/InstitutePanel/InnerUnivDetails.aspx");
        
        routes.MapPageRoute("one12", "Studprofile/{values}", "~/InstitutePanel/UpdateStudProfile.aspx");
        //updateInstituteFullProfile.aspx
        routes.MapPageRoute("one1300", "Insttituteprofile/{values}", "~/InstitutePanel/updateInstituteFullProfile.aspx");
        //Tutorprofile

        routes.MapPageRoute("one1301", "Tutorprofile/{values}", "~/InstitutePanel/UpdateTutorProfile.aspx");
        routes.MapPageRoute("one1302", "Studentprofile/{values}", "~/InstitutePanel/UpdateStudProfile.aspx");
        
        routes.MapPageRoute("one13", "profile/{values}", "~/InstitutePanel/UpdateTutorProfile.aspx");
        routes.MapPageRoute("t1root", "c/{name}/{pname}/{code}/{temp}/{page}", "~/manage2/NewWeb/pagedata.aspx");
        
        //routes.MapPageRoute("t1root", "c/{name}/{pname}/{code}/{temp}/{page}", "~/manage2/NewWeb/pagedata.aspx");
        routes.MapPageRoute("t1data", "ch/{name}/{pname}/{code}/{temp}/{page}", "~/manage2/NewWeb/pagedata.aspx");
        
        routes.MapPageRoute("t1datas001", "EditData/{name}/{page}", "~/manage2/NewWeb/page1.aspx");
        
        routes.MapPageRoute("t1datas", "chf/{name}/{pname}/{code}/{temp}/{page}", "~/manage2/NewWeb/page1.aspx");
        routes.MapPageRoute("t1datasa", "chfa/{name}/{code}/{page}", "~/mange3/PageData1.aspx");
        routes.MapPageRoute("t1gellary", "chk/{name}/{pname}/{code}/{temp}/{page}", "~/manage2/NewWeb/pageGellary.aspx");
        routes.MapPageRoute("t1gellarys", "chks/{name}/{pname}/{code}/{temp}/{page}", "~/manage2/NewWeb/pagegalery.aspx");
        routes.MapPageRoute("t1gellary1", "chg/{name}/{pname}/{code}/{temp}/{page}", "~/manage2/NewWeb/Faculty.aspx");
        routes.MapPageRoute("t1gellary2", "chkf/{name}/{pname}/{code}/{temp}/{page}", "~/manage2/NewWeb/Student-Group.aspx");
        routes.MapPageRoute("t1download", "cdownload/{name}/{pname}/{code}/{temp}/{page}", "~/manage2/NewWeb/download.aspx");
        
        routes.MapPageRoute("t1feedback", "feedback/{name}/{code}/{temp}", "~/manage2/NewWeb/feedback.aspx");
        routes.MapPageRoute("t1Login", "login/{name}/{code}/{temp}", "~/manage2/NewWeb/Login.aspx");

        routes.MapPageRoute("t1root1111", "c/{name}/{code}/{temp}/{page}", "~/manage2/NewWeb/Default.aspx");

        //------------------------------------------------------------------------------------------------//
        //micro website setting template II
        routes.MapPageRoute("t1dataII", "stuI/{name}/{code}/{temp}/{page}", "~/mange3/pagedata.aspx");
        routes.MapPageRoute("t1gellaryII", "stuG/{name}/{code}/{temp}/{page}", "~/mange3/pageGellary.aspx");
        routes.MapPageRoute("t1downloadII", "stuD/{name}/{code}/{temp}/{page}", "~/mange3/download.aspx");
        //------------------------------------------------------------------------------------------------//
        //----------teacher -------------------------------------------------------------------------------//
        routes.MapPageRoute("t1rootteacher", "teacher-home/{name}/{pname}/{code}/{temp}/{page}", "~/teacher/Default.aspx");
        routes.MapPageRoute("t1datateacher", "teacher/{name}/{pname}/{code}/{temp}/{page}", "~/teacher/pagedata.aspx");
        routes.MapPageRoute("t1gellaryteacher", "teacher-gellary/{name}/{pname}/{code}/{temp}/{page}", "~/teacher/pageGellary.aspx");
        routes.MapPageRoute("t1downloadteacher", "teacher-download/{name}/{pname}/{code}/{temp}/{page}", "~/teacher/download.aspx");
        routes.MapPageRoute("t1feedbackteacher", "teacher-feedback/{name}/{code}/{temp}", "~/teacher/feedback.aspx");
        routes.MapPageRoute("t1Loginteacher", "teacher-login/{name}/{code}/{temp}", "~/teacher/Login.aspx");
        //---------------------------------------------------------------------------------------------//

        //----------tutor -------------------------------------------------------------------------------//
        routes.MapPageRoute("t1roottutor", "tutor-home/{name}/{pname}/{code}/{temp}/{page}", "~/teacher/Default.aspx");
        routes.MapPageRoute("t1datatutor", "tutor/{name}/{pname}/{code}/{temp}/{page}", "~/teacher/pagedata.aspx");
        routes.MapPageRoute("t1gellarytutor", "tutor-gellary/{name}/{pname}/{code}/{temp}/{page}", "~/teacher/pageGellary.aspx");
        routes.MapPageRoute("t1downloadtutor", "tutor-download/{name}/{pname}/{code}/{temp}/{page}", "~/teacher/download.aspx");
        routes.MapPageRoute("t1feedbacktutor", "tutor-feedback/{name}/{code}/{temp}", "~/teacher/feedback.aspx");
        routes.MapPageRoute("t1Logintutor", "tutor-login/{name}/{code}/{temp}", "~/teacher/Login.aspx");
        //---------------------------------------------------------------------------------------------//


        //----------tschool -------------------------------------------------------------------------------//
        routes.MapPageRoute("t1rootschool", "school-home/{name}/{pname}/{code}/{temp}/{page}", "~/school1/Default.aspx");
        routes.MapPageRoute("t1dataschool", "school/{name}/{pname}/{code}/{temp}/{page}", "~/school1/pagedata.aspx");
        routes.MapPageRoute("t1gellaryschool", "school-gellary/{name}/{pname}/{code}/{temp}/{page}", "~/school1/pageGellary.aspx");
        routes.MapPageRoute("t1downloadschool", "school-download/{name}/{pname}/{code}/{temp}/{page}", "~/school1/download.aspx");
        routes.MapPageRoute("t1feedbackschool", "school-feedback/{name}/{code}/{temp}", "~/school1/feedback.aspx");
        routes.MapPageRoute("t1Loginschool", "school-login/{name}/{code}/{temp}", "~/school1/Login.aspx");
        //---------------------------------------------------------------------------------------------//
        //----------institute -------------------------------------------------------------------------------//
        routes.MapPageRoute("t1rootinstitute", "institute-home/{name}/{pname}/{code}/{temp}/{page}", "~/school1/Default.aspx");
        routes.MapPageRoute("t1datainstitute", "institute/{name}/{pname}/{code}/{temp}/{page}", "~/school1/pagedata.aspx");
        routes.MapPageRoute("t1gellaryinstitute", "institute-gellary/{name}/{pname}/{code}/{temp}/{page}", "~/school1/pageGellary.aspx");
        routes.MapPageRoute("t1downloadinstitute", "institute-download/{name}/{pname}/{code}/{temp}/{page}", "~/school1/download.aspx");
        routes.MapPageRoute("t1feedbackinstitute", "institute-feedback/{name}/{code}/{temp}", "~/school1/feedback.aspx");
        routes.MapPageRoute("t1Logininstitute", "institute-login/{name}/{code}/{temp}", "~/school1/Login.aspx");
        //---------------------------------------------------------------------------------------------//


        //----------institute -------------------------------------------------------------------------------//


        routes.MapPageRoute("t1rootinstitute1", "website-home/{name}/{pname}/{code}/{temp}/{page}", "~/micro/school2/Default.aspx");
        routes.MapPageRoute("t1datainstitute1", "website/{name}/{pname}/{code}/{temp}/{page}", "~/micro/school2/pagedata.aspx");
        routes.MapPageRoute("t1gellaryinstitute1", "website-gellary/{name}/{pname}/{code}/{temp}/{page}", "~/micro/school2/pageGellary.aspx");
        routes.MapPageRoute("t1downloadinstitute1", "website-download/{name}/{pname}/{code}/{temp}/{page}", "~/micro/school2/download.aspx");
        routes.MapPageRoute("t1feedbackinstitute1", "website-feedback/{name}/{code}/{temp}", "~/micro/school2/feedback.aspx");
        routes.MapPageRoute("t1Logininstitute1", "website-login/{name}/{code}/{temp}", "~/micro/school2/Login.aspx");
        //---------------------------------------------------------------------------------------------//



        //----------College -------------------------------------------------------------------------------//
        routes.MapPageRoute("t1rootcollege", "college-home/{name}/{pname}/{code}/{temp}/{page}", "~/school1/Default.aspx");
        routes.MapPageRoute("t1datacollege", "college/{name}/{pname}/{code}/{temp}/{page}", "~/school1/pagedata.aspx");
        routes.MapPageRoute("t1gellarycollege", "college-gellary/{name}/{pname}/{code}/{temp}/{page}", "~/school1/pageGellary.aspx");
        routes.MapPageRoute("t1downloadcollege", "college-download/{name}/{pname}/{code}/{temp}/{page}", "~/school1/download.aspx");
        routes.MapPageRoute("t1feedbackcollege", "college-feedback/{name}/{code}/{temp}", "~/school1/feedback.aspx");
        routes.MapPageRoute("t1Logincollege", "college-login/{name}/{code}/{temp}", "~/school1/Login.aspx");
        //---------------------------------------------------------------------------------------------//


        //micro website Intranal Page------------
        routes.MapPageRoute("myweb-gallery", "myweb-Images/{linkid}/{linkname}", "~/InstitutePanel/myWebsiteNew/imageGellary.aspx");
        routes.MapPageRoute("myweb-page", "myweb-page/{linkid}/{linkname}", "~/InstitutePanel/other/pagedata.aspx");
        routes.MapPageRoute("myweb-calander", "myweb-calander/{linkName}", "~/InstitutePanel/myWebsiteNew/calander.aspx");
        routes.MapPageRoute("myweb-welcome", "myweb-welcome/{linkname}", "~/InstitutePanel/myWebsiteNew/Default.aspx");
        routes.MapPageRoute("myweb-download", "myweb-download/{linkname}", "~/InstitutePanel/myWebsiteNew/download.aspx");
        routes.MapPageRoute("myweb-feedback", "myweb-Live-Feedback/{linkname}", "~/InstitutePanel/myWebsiteNew/Feedback.aspx");
        routes.MapPageRoute("myweb-quickgallerys", "myweb-Quick-Gallery/{linkname}", "~/InstitutePanel/myWebsiteNew/quickGellary.aspx");
        routes.MapPageRoute("myweb-quicklinks", "myweb-quick-links/{linkname}", "~/InstitutePanel/myWebsiteNew/quicklinks.aspx");
        routes.MapPageRoute("myweb-schedule", "myweb-schedule/{linkname}", "~/InstitutePanel/myWebsiteNew/schedule.aspx");
        routes.MapPageRoute("myweb-template", "myweb-Template/{linkname}", "~/InstitutePanel/myWebsiteNew/selectTemplates.aspx");
        routes.MapPageRoute("myweb-PageLayout", "myweb-PageLayout/{linkid}/{linkname}", "~/InstitutePanel/myWebsiteNew/pageLayout.aspx");
        //-------acdmic modules here -------------------------------
        routes.MapPageRoute("myweb-Pagenotes", "myweb-subject", "~/InstitutePanel/myWebsiteNew/MasterCategory.aspx");
        routes.MapPageRoute("myweb-PagenotescatDetail", "myweb-Lession", "~/InstitutePanel/myWebsiteNew/masterCategoryDetail.aspx");
        routes.MapPageRoute("myweb-Pagenotesdetail", "myweb-Notes", "~/InstitutePanel/myWebsiteNew/AddNotesDetail.aspx");
        routes.MapPageRoute("myweb-Pagenotesview", "myweb-Notes-preview/{linkid}", "~/InstitutePanel/myWebsiteNew/viewNotes.aspx");
        routes.MapPageRoute("myweb-PagenoteProduct", "myweb-products", "~/InstitutePanel/myWebsiteNew/product.aspx");
        //------------------------------------------------------------------------------------------------//



        //micro website Inhtranal Page for other------------
        routes.MapPageRoute("controlpanel-welcome", "controlpanel-welcome-User", "~/InstitutePanel/other/other.aspx");
        routes.MapPageRoute("controlpanel-gallery", "controlpanel-Images/{linkid}/{linkname}", "~/InstitutePanel/other/imageGellary.aspx");
        routes.MapPageRoute("controlpanel-page", "controlpanel-page/{linkid}/{linkname}", "~/InstitutePanel/other/pagedata.aspx");
        routes.MapPageRoute("controlpanel-quicklinks", "controlpanel-quick-links/{linkname}", "~/InstitutePanel/other/quicklinks.aspx");


        routes.MapPageRoute("controlpanel-calander", "myweb-calander/{linkName}", "~/InstitutePanel/myWebsiteNew/calander.aspx");
        routes.MapPageRoute("controlpanel-download", "controlpanel-download/{linkname}", "~/InstitutePanel/myWebsiteNew/download.aspx");
        routes.MapPageRoute("controlpanel-feedback", "controlpanel-Live-Feedback/{linkname}", "~/InstitutePanel/myWebsiteNew/Feedback.aspx");
        routes.MapPageRoute("controlpanel-quickgallerys", "controlpanel-Quick-Gallery/{linkname}", "~/InstitutePanel/myWebsiteNew/quickGellary.aspx");

        routes.MapPageRoute("controlpanel-schedule", "controlpanel-schedule/{linkname}", "~/InstitutePanel/myWebsiteNew/schedule.aspx");
        routes.MapPageRoute("controlpanel-template", "controlpanel-Template/{linkname}", "~/InstitutePanel/myWebsiteNew/selectTemplates.aspx");
        routes.MapPageRoute("controlpanel-PageLayout", "controlpanel-PageLayout/{linkid}/{linkname}", "~/InstitutePanel/myWebsiteNew/pageLayout.aspx");
        //micro website Intranal Page- other -----------



        //micro website Inhtranal Page for kids------------
        routes.MapPageRoute("kidspanel-welcome", "panel-welcome-User", "~/InstitutePanel/kidsWebsite/Default.aspx");
        routes.MapPageRoute("kidspanel-gallery", "panel-Images/{linkid}/{linkname}", "~/InstitutePanel/kidsWebsite/imageGellary.aspx");
        routes.MapPageRoute("kidspanel-page", "panel-page/{linkid}/{linkname}", "~/InstitutePanel/kidsWebsite/pagedata.aspx");
        routes.MapPageRoute("kidspanel-quicklinks", "panel-quick-links/{linkname}", "~/InstitutePanel/kidsWebsite/quicklinks.aspx");

        routes.MapPageRoute("kidspanel-download", "panel-download/{linkname}", "~/InstitutePanel/kidsWebsite/download.aspx");
        routes.MapPageRoute("kidspanel-quickgallerys", "panel-Quick-Gallery/{linkname}", "~/InstitutePanel/kidsWebsite/quickGellary.aspx");
        routes.MapPageRoute("kidspanel-template", "panel-Template/{linkname}", "~/InstitutePanel/kidsWebsite/selectTemplates.aspx");

        routes.MapPageRoute("kidspanel-changepassword", "panel-Change-Password", "~/InstitutePanel/kidsWebsite/changePassword.aspx");
        //micro website Intranal Page- kids -----------






        //newcommonpage--------- 
        routes.MapPageRoute("comNews1", "education-{title}", "~/News.aspx");
        //newsdetail------------
        routes.MapPageRoute("lateNews", "education-news/{values}-{pps}", "~/New-Final.aspx");
        routes.MapPageRoute("lateNews1", "education-news", "~/News.aspx");
        routes.MapPageRoute("latearticles", "education-articles/{values}-{pps}", "~/New-Final.aspx");
        routes.MapPageRoute("latealerts", "education-alerts/{values}-{pps}", "~/New-Final.aspx");
        //----carrier option leading page here -------------------------------------------------------------//
        routes.MapPageRoute("comcarreirlandinpage", "careers/{values}-{pps}", "~/ViewCareerDetails.aspx");
        routes.MapPageRoute("comcarreirlandinpageexam", "EntranceExam/{values}-{pps}", "~/ViewCareerDetails.aspx");
        routes.MapPageRoute("comCarrierdetailpage", "careers/{title}-{id}-{typeid}-{uniid}-{CAE}", "~/web/NewsDetail.aspx");
        routes.MapPageRoute("comCarrierdetailpage1", "careers-phd/{title}-{id}-{typeid}-{uniid}", "~/web/phd.aspx");
        //------------------------------------------------------------------------------------------------//
        //----about us -------------------------------------------------------------
        routes.MapPageRoute("dataabout", "about-{sndvlaue}", "~/web/Aboutus.aspx");
        routes.MapPageRoute("dataHome", "home", "~/web/default.aspx");
        //------------------------------------------------------------------------------------------------//

        //------------------------------------------------------------------------------------------------//
        routes.MapPageRoute("unisndshort", "universities", "~/university/UniversityShort.aspx");
        routes.MapPageRoute("unisnd", "universities/university-in-{title}-{id}", "~/university/UniversityShort.aspx");
        routes.MapPageRoute("unisndastype", "universities/{Name}/{uniType}", "~/university/textUniversityType.aspx");
        routes.MapPageRoute("unisndasstate", "universities/{Name}-{stateId}", "~/university/textUniversityType.aspx");
        //   routes.MapPageRoute("unisndastypelast", "universities/india/{Name}/{uniID}/1", "~/university/textUniversityType.aspx");

        routes.MapPageRoute("unisndlast", "home", "~/web/default.aspx");
        //------------------------------------------------------------------------------------------------//


        //------------------------------------------------------------------------------------------------//
        //---pending----Education In India 
        routes.MapPageRoute("comeducationleading", "education-in-india/1", "~/web/Education.aspx");
        routes.MapPageRoute("comEducationleadingsnd1", "education-in-india/education-board", "~/web/Education.aspx");
        routes.MapPageRoute("comEducationleadingsnd2", "education-in-india/education-council", "~/web/Education.aspx");
        routes.MapPageRoute("comEducationsndboard", "education-in-india/education-board/{title}/{id}", "~/web/EducationBoard.aspx");
        routes.MapPageRoute("comEducationsndcouncil", "education-in-india/education-council/{title}/{id}", "~/web/EducationBoard.aspx");
        //------------------------------------------------------------------------------------------------//

        //------------------------------------------------------------------------------------------------//
        //-pendiing-Exams In India 
        routes.MapPageRoute("comexaminindia", "exams-in-india", "~/web/NewsForDetail.aspx");
        routes.MapPageRoute("comexamentranceexam", "exams-in-india/entrance-exams", "~/web/NewsForDetail.aspx");
        routes.MapPageRoute("comexamleadingsnd", "exams-in-india/competitive-exams", "~/web/NewsForDetail.aspx");

        routes.MapPageRoute("comexamlastentrance", "exams-in-india/entrance-exams/{title}-{id}-{CAE}", "~/web/NewsDetail.aspx");
        routes.MapPageRoute("comexamlastcompetitive", "exams-in-india/competitive-exams/{title}-{id}-{CAE}", "~/web/NewsDetail.aspx");
        //------------------------------------------------------------------------------------------------//


        //------courses------------------------------------------------------------------------------------------//
        routes.MapPageRoute("commancourses1", "courses", "~/web/coursesdetail.aspx");
        routes.MapPageRoute("commancourses2", "courses/{type}", "~/web/mainStream.aspx");
        routes.MapPageRoute("commancourses3", "courses/{type}/{page}-{id}", "~/Search/NewForResult.aspx");

        //--------------colleges----------------------------------//
        routes.MapPageRoute("commanUni", "Univ", "~/InstitutePanel/InnerUnivDetails.aspx");

    }
    
       
</script>
