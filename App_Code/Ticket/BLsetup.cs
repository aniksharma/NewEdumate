using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Collections.Generic;
using nmsSetupTick;
namespace nmsSetupTick
{
    public class clsBLSetupTick
    {
        clsDLSetupTick obj = new clsDLSetupTick ();
//--start university.
        public string InsertUniversity(PRPSetupTick objprp)
        {
            return obj.InsertUniversity(objprp);
        }
        public string UpdateUniversity(PRPSetupTick objprp)
        {
            return obj.UpdateUniversity(objprp);
        }
        public string DeleteUniversity(PRPSetupTick objprp)
        {
            return obj.DeleteUniversity(objprp);
        }
        public PRPSetupTick SelectUniversity(PRPSetupTick objprp)
        {
            return obj.SelectUniversity(objprp);
        }
        public List<PRPSetupTick> ViewUniversity(PRPSetupTick objprp)
        {
            return obj.ViewUniversity(objprp);
        }
//--End university.

 //---start Enquiry form--------
        //public string InsertEnquiry(PRPSetupTick objprp)
        //{
        //    return obj.InsertEnquiry(objprp);
        //}
        //public List<PRPSetupTick> viewEnquiry(PRPSetupTick objprp)
        //{
        //    return obj.viewEnquiry(objprp);
        //}
 //----End Enquiry form----------



//--start university Web.
        public string InsertUniversityWeb(PRPSetupTick objprp)
        {
            return obj.InsertUniversityWeb(objprp);
        }
        public string UpdateUniversityWeb(PRPSetupTick objprp)
        {
            return obj.UpdateUniversityWeb(objprp);
        }
        public string DeleteUniversityWeb(PRPSetupTick objprp)
        {
            return obj.DeleteUniversityWeb(objprp);
        }
        public PRPSetupTick SelectUniversityWeb(PRPSetupTick objprp)
        {
            return obj.SelectUniversityWeb(objprp);
        }
        public List<PRPSetupTick> ViewUniversityWeb(PRPSetupTick objprp)
        {
            return obj.ViewUniversityWeb(objprp);
        }
        public List<PRPSetupTick> ViewUniversityType( PRPSetupTick objprp )
        {
            return obj.ViewUniversityType(objprp);
        }      
//--End university Web.

//--start university Web.
        public string InsertCollegeDetail(PRPSetupTick objprp)
        {
            return obj.InsertCollegeDetail(objprp);
        }
        public string UpdateCollegeDetail(PRPSetupTick objprp)
        {
            return obj.UpdateCollegeDetail(objprp);
        }
        public string DeleteCollegeDetail(PRPSetupTick objprp)
        {
            return obj.DeleteCollegeDetail(objprp);
        }
        public PRPSetupTick SelectCollegeDetail(PRPSetupTick objprp)
        {
            return obj.SelectCollegeDetail(objprp);
        }
        public List<PRPSetupTick> ViewCollegeDetail(PRPSetupTick objprp)
        {
            return obj.ViewCollegeDetail(objprp);
        }
        //public List<PRPSetupTick> ViewCollegeType()
        //{
        //    return obj.ViewCollegeType();
        //}
//--End university Web.






//--Start Setup Course Category.
        public string InsCourseCategory(PRPSetupTick objprp)
        {
            return obj.InsCourseCategory(objprp);
        }
        public string UpdCourseCategory(PRPSetupTick objprp)
        {
            return obj.UpdCourseCategory(objprp);

        }
        public string DelCourseCategory(PRPSetupTick objprp)
        {

            return obj.DelCourseCategory(objprp);

        }
        public PRPSetupTick SelCourseCategory(PRPSetupTick objprp)
        {
            return obj.SelCourseCategory(objprp);
        }
        public DataTable ViewCourseCategory(PRPSetupTick objprp)
        {
            return obj.ViewCourseCategory(objprp);
        }       
//--End Setup Course Category.

//--Start Course Detail Web.
        public string InsertCourse(PRPSetupTick objprp)
        {
            return obj.InsertCourseWeb(objprp);
        }
        public string UpdateCourse(PRPSetupTick objprp)
        {
            return obj.UpdateCourse(objprp);
        }
        public string DeleteCourse(PRPSetupTick objprp)
        {
            return obj.DeleteCourse(objprp);
        }
        public PRPSetupTick SelectCourse(PRPSetupTick objprp)
        {

            return obj.SelectCourse(objprp);
        }
        public List<PRPSetupTick> ViewCourse(PRPSetupTick prp)
        {
            return obj.ViewCourseWeb(prp);
        }
        //--End Course Detail Web.
        //News For Start
        public string InsNewsFor(PRPSetupTick objprp)
        {
            return obj.InsNewsFor(objprp);
        }
        public string UpdNewsFor(PRPSetupTick objprp)
        {
            return obj.UpdNewsFor(objprp);
        }
        public string DelNewsFor(PRPSetupTick objprp)
        {
            return obj.DelNewsFor(objprp);
        }
        public PRPSetupTick SelNewsFor(PRPSetupTick objprp)
        {
            return obj.SelNewsFor(objprp);

        }
        //News For End
//--Start News Type.
        public string InsNewsType(PRPSetupTick objprp)
        {
            return obj.InsNewsType(objprp);
        }
        public string UpdNewsType(PRPSetupTick objprp)
        {
            return obj.UpdNewsType(objprp);
        }
        public string DelNewsType(PRPSetupTick objprp)
        {
            return obj.DelNewsType(objprp);
        }
        public PRPSetupTick SelNewsType(PRPSetupTick objprp)
        {
            return obj.SelNewsType(objprp);
            
        }

        //--End News Type.
        //Show In Branch Start
        public List<PRPSetupTick> BindBranchForCheck(PRPSetupTick objprp)
        {
            return obj.BindBranchForCheck(objprp);
        }
        public string InsertShowInBranch(PRPSetupTick objprp)
        {
            return obj.InsertShowInBranch(objprp);
        }
        // Show In Branch End
        //Authorisation Start
        
        public List<PRPSetupTick> BindUniforAuth(PRPSetupTick objprp)
        {
            return obj.BindUniforAuth(objprp);
        }
        public List<PRPSetupTick> CheckUniByBranch(PRPSetupTick objprp)
        {
            return obj.CheckUniByBranch(objprp);
        }
        public string InsertCollegeDetailWebType(PRPSetupTick objprp)
        {
            return obj.InsertCollegeDetailWebType(objprp);
        }
       
        public List<PRPSetupTick> BindUniInRepitor(PRPSetupTick prp)
        {
            return obj.BindCollegInRepitor(prp);
        }
        public string DeleteCollSub(PRPSetupTick objprp)
        {
            return obj.DeleteCollSub(objprp);
        }
        //Authorisation End
//--Start News
        public string InsNews(PRPSetupTick objprp)
        {
            return obj.InsNews(objprp);   
        }
        public string UpdNews(PRPSetupTick objprp)
        {
            return obj.UpdNews(objprp);           
        }
        public string DelNews(PRPSetupTick objprp)
        {
            return obj.DelNews(objprp);           
        }
        public PRPSetupTick SelNews(PRPSetupTick objprp)
        {
            return obj.SelNews(objprp);
        }
       
        public List<PRPSetupTick> ViewNewsInBranch(PRPSetupTick prp)
        {
            return obj.ViewNewsInBranch(prp);
        }
       
//--End News

//--Start--New Job.
        public string InsJob(PRPSetupTick objprp)
        {
            return obj.InsJob(objprp);
        }
        public string UpdJob(PRPSetupTick objprp)
        {
            return obj.UpdJob(objprp);
        }
        public string DelJob(PRPSetupTick objprp)
        {
            return obj.DelJob(objprp);
        }
        public PRPSetupTick SelJob(PRPSetupTick objprp)
        {
            return obj.SelJob(objprp);
        }
        public List<PRPSetupTick> ViewJob(PRPSetupTick prp)
        {
            return obj.ViewJob(prp);
        }
        public List<PRPSetupTick> ViewJob1(PRPSetupTick prp)
        {
            return obj.ViewJob1(prp);
        }
//--End--New Job.

//--Start Resume Detail.
        public string InsResumeDetail(PRPSetupTick objprp)
        {
            return obj.InsResumeDetail(objprp);

        }
        public string UpdResumeDetail(PRPSetupTick objprp)
        {
            return obj.UpdResumeDetail(objprp);
        }        
        public List<PRPSetupTick> ViewResumeDetail(PRPSetupTick prp)
        {
            return obj.ViewResumeDetail(prp);
        }
        public string GetMaxFileId()
        {
            return obj.GetMaxFileId();
        }
//--End Resume Detail.

//--Start File Detail
        public string InsFile(PRPSetupTick objprp)
        {
            return obj.InsFile(objprp); 
        }
        public string UpdFile(PRPSetupTick objprp)
        {
            return obj.UpdFile(objprp);
        }
        public List<PRPSetupTick> ViewFile(PRPSetupTick objprp)
        {
            return obj.ViewFile(objprp);
        }
        public PRPSetupTick SelFile(PRPSetupTick objprp)
        {
            return obj.SelFile(objprp);
        }
        public string DelFile(PRPSetupTick objprp)
        {
            return obj.DelFile(objprp);
        }              
//--End File Detail

//--Start Text Editor.
        public string InsText(PRPSetupTick objprp)
        {
            return obj.InsText(objprp);
        }
        public string UpdText(PRPSetupTick objprp)
        {
            return obj.UpdText(objprp);
        }
        public string DelText(PRPSetupTick objprp)
        {
            return obj.DelText(objprp);
        }
        public PRPSetupTick SelText(PRPSetupTick objprp)
        {
            return obj.SelText(objprp);
        }
        public PRPSetupTick SelText1(PRPSetupTick objprp)
        {
            return obj.SelText1(objprp);
        }
        public List<PRPSetupTick> ViewText(PRPSetupTick prp)
        {
            return obj.ViewText(prp);
        }
//--End Text Editor.

        //--Start Text Editor.
        public string InsTextWeb(PRPSetupTick objprp)
        {
            return obj.InsTextWeb(objprp);
        }
        public string UpdTextWeb(PRPSetupTick objprp)
        {
            return obj.UpdTextWeb(objprp);
        }
        public string DelTextWeb(PRPSetupTick objprp)
        {
            return obj.DelTextWeb(objprp);
        }
        public PRPSetupTick SelTextWeb(PRPSetupTick objprp)
        {
            return obj.SelTextWeb(objprp);
        }
        public PRPSetupTick SelTextWeb1(PRPSetupTick objprp)
        {
            return obj.SelTextWeb1(objprp);
        }
        public List<PRPSetupTick> ViewTextWeb(PRPSetupTick prp)
        {
            return obj.ViewTextWeb(prp);
        }
        //--End Text Editor.




//--Start Local Text Editor.        
        public string UpdLocalText(PRPSetupTick objprp)
        {
            return obj.UpdLocalText(objprp);
        }        
        public PRPSetupTick SelLocalText(PRPSetupTick objprp)
        {
            return obj.SelLocalText(objprp);
        }        
//--End Local Text Editor.

//--Start Image Category.
        public string InsImageCategory(PRPSetupTick objprp)
        {
            return obj.InsImageCategory(objprp);
        }
        public string UpdImageCategory(PRPSetupTick objprp)
        {
            return obj.UpdImageCategory(objprp);

        }
        public string DelImageCategory(PRPSetupTick objprp)
        {

            return obj.DelImageCategory(objprp);

        }
        public PRPSetupTick SelImageCategory(PRPSetupTick objprp)
        {
            return obj.SelImageCategory(objprp);
        }
        public DataTable ViewImageCategory(PRPSetupTick objprp)
        {
            return obj.ViewImageCategory(objprp);
        }       
//--End Image Category.

 //--Start Image Category.
        public string InsTextCategory(PRPSetupTick objprp)
        {
            return obj.InsTextCategory(objprp);
        }
        public string UpdTextCategory(PRPSetupTick objprp)
        {
            return obj.UpdTextCategory(objprp);

        }
        public string DelTextCategory(PRPSetupTick objprp)
        {

            return obj.DelTextCategory(objprp);

        }
        public PRPSetupTick SelTextCategory(PRPSetupTick objprp)
        {
            return obj.SelTextCategory(objprp);
        }
        public DataTable ViewTextCategory(PRPSetupTick objprp)
        {
            return obj.ViewTextCategory(objprp);
        }
//--End Image Category.


//--Start Text Category Web.
        public string InsTextCategoryWeb(PRPSetupTick objprp)
        {
            return obj.InsTextCategoryWeb(objprp);
        }
        public string UpdTextCategoryWeb(PRPSetupTick objprp)
        {
            return obj.UpdTextCategoryWeb(objprp);

        }
        public string DelTextCategoryWeb(PRPSetupTick objprp)
        {

            return obj.DelTextCategoryWeb(objprp);

        }
        public PRPSetupTick SelTextCategoryWeb(PRPSetupTick objprp)
        {
            return obj.SelTextCategoryWeb(objprp);
        }
        public DataTable ViewTextCategoryWeb(PRPSetupTick objprp)
        {
            return obj.ViewTextCategoryWeb(objprp);
        }
//--End Text Category Web.


//--Start image Gallery
        public string InsImageGallery(PRPSetupTick objprp)
        {
            return obj.InsImageGallery(objprp);
        }
        public string UpdImageGallery(PRPSetupTick objprp)
        {
            return obj.UpdImageGallery(objprp);
        }
        public string DelImageGallery(PRPSetupTick objprp)
        {
            return obj.DelImageGallery(objprp);
        }
        public PRPSetupTick SelImageGallery(PRPSetupTick objprp)
        {
            return obj.SelImageGallery(objprp);
        }
        public List<PRPSetupTick> ViewImageGallery(PRPSetupTick objprp)
        {
            return obj.ViewImageGallery(objprp);
        }    
//--End Image Gallery.

//--Start UniversityType
        public string InsUniversityType(PRPSetupTick objprp)
        {
            return obj.InsUniversityType(objprp);
        }
        public string UpdUniversityType(PRPSetupTick objprp)
        {
            return obj.UpdUniversityType(objprp);
        }
        public string DelUniversityType(PRPSetupTick objprp)
        {
            return obj.DelUniversityType(objprp);
        }
        public PRPSetupTick SelUniversityType(PRPSetupTick objprp)
        {
            return obj.SelUniversityType(objprp);
        }

//--End UniversityType

//--Start College Type
        public string InsCollegeType(PRPSetupTick objprp)
        {
            return obj.InsCollegeType(objprp);
        }
        public string UpdCollegeType(PRPSetupTick objprp)
        {
            return obj.UpdCollegeType(objprp);
        }
        public string DelCollegeType(PRPSetupTick objprp)
        {
            return obj.DelCollegeType(objprp);
        }
        public PRPSetupTick SelCollegeType(PRPSetupTick objprp)
        {
            return obj.SelCollegeType(objprp);
        }
        public List<PRPSetupTick> ViewCollegeType(PRPSetupTick objprp)
        {
            return obj.ViewCollegeType(objprp);
        }

        public List<PRPSetupTick> ViewCollegeType1(PRPSetupTick objprp)
        {
            return obj.ViewCollegeType1(objprp);
        }



//--End College Type


//--Start Tkt Dep 
        public string InsTktDep(PRPSetupTick objprp)
        {
            return obj.InsTktDep(objprp);
        }
        public string UpdTktDep(PRPSetupTick objprp)
        {
            return obj.UpdTktDep(objprp);
        }
        public string DelTktDep(PRPSetupTick objprp)
        {
            return obj.DelTktDep(objprp);
        }
        public PRPSetupTick SelTktDep(PRPSetupTick objprp)
        {
            return obj.SelTktDep(objprp);
        }

        //--End  Tkt Dep 
 //Start Submit Ticket Done
        public string InsTicket(PRPSetupTick objprp)
        {
            return obj.InsTicket(objprp);
        }
        public string InsTicketReply(PRPSetupTick objprp)
        {
            return obj.InsTicketReply(objprp);
        }
        public string InsTicketReplyByAdm(PRPSetupTick objprp)
        {
            return obj.InsTicketReplyByAdm(objprp);
        }
        public string AssignByAdm(PRPSetupTick objprp)
        {
            return obj.AssignByAdm(objprp);
        }
        public List<PRPSetupTick> BindByAuthorisation()
        {
            return obj.BindByAuthorisation();
        }
        public List<PRPSetupTick> BindDepByCountInAdm()
        {
            return obj.BindDepByCountInAdm();
        }
        public List<PRPSetupTick> ViewTicket(PRPSetupTick prp)
        {
            return obj.ViewTicket(prp);
        }
        public List<PRPSetupTick> ViewTicketAdm(PRPSetupTick prp)
        {
            return obj.ViewTicketAdm(prp);
        }
        public List<PRPSetupTick> ViewTicket1(PRPSetupTick prp)
        {
            return obj.ViewTicket1(prp);
        }
        public List<PRPSetupTick> ViewPTicket1(PRPSetupTick prp)
        {
            return obj.ViewPTicket1(prp);
        }
        public List<PRPSetupTick> ViewReplyTicket1(PRPSetupTick prp)
        {
            return obj.ViewReplyTicket1(prp);
        }

        // End Submit Ticket
        // Start Tkt Status
        public string InsTktStatus(PRPSetupTick objprp)
        {
            return obj.InsTktStatus(objprp);
        }
        public string UpdTktStatus(PRPSetupTick objprp)
        {
            return obj.UpdTktStatus(objprp);
        }
        public string DelTktStatus(PRPSetupTick objprp)
        {
            return obj.DelTktStatus(objprp);
        }
        public PRPSetupTick SelTktStatus(PRPSetupTick objprp)
        {
            return obj.SelTktStatus(objprp);
        }

        // End Tkt Status
          // start tkt ptype
           public string InstktPtype(PRPSetupTick objprp)
        {
            return obj.InstktPtype(objprp);
        }
        public string UpdtktPtype(PRPSetupTick objprp)
        {
            return obj.UpdtktPtype(objprp);
        }
        public string DeltktPtype(PRPSetupTick objprp)
        {
            return obj.DeltktPtype(objprp);
        }
        public PRPSetupTick SeltktPtype(PRPSetupTick objprp)
        {
            return obj.SeltktPtype(objprp);
        }
          // End tkt ptype
//--Start EducationType
        public string InsEducationType(PRPSetupTick objprp)
        {
            return obj.InsEducationType(objprp);
        }
        public string UpdEducationType(PRPSetupTick objprp)
        {
            return obj.UpdEducationType(objprp);
        }
        public string DelEducationType(PRPSetupTick objprp)
        {
            return obj.DelEducationType(objprp);
        }
        public PRPSetupTick SelEducationType(PRPSetupTick objprp)
        {
            return obj.SelEducationType(objprp);
        }

//--End EducationType



//--Start State
        public string InsCountry(PRPSetupTick objprp)
        {
            return obj.InsCountry(objprp);
        }
        public string UpdCountry(PRPSetupTick objprp)
        {
            return obj.UpdCountry(objprp);
        }
        public string DelCountry(PRPSetupTick objprp)
        {
            return obj.DelCountry(objprp);
        }
        public PRPSetupTick SelCountry(PRPSetupTick objprp)
        {
            return obj.SelCountry(objprp);
        }
//--End State



//--Start State
        public string InsState(PRPSetupTick objprp)
        {
            return obj.InsState(objprp);
        }
        public string UpdState(PRPSetupTick objprp)
        {
            return obj.UpdState(objprp);
        }
        public string DelState(PRPSetupTick objprp)
        {
            return obj.DelState(objprp);
        }
        public PRPSetupTick SelState(PRPSetupTick objprp)
        {
            return obj.SelState(objprp);
        }
//--End State

//--Start District.
        public string InsDistrict(PRPSetupTick objprp)
        {
            return obj.InsDistrict(objprp);
        }
        public string UpdDistrict(PRPSetupTick objprp)
        {
            return obj.UpdDistrict(objprp);
        }
        public string DelDistrict(PRPSetupTick objprp)
        {
            return obj.DelDistrict(objprp);
        }
        public PRPSetupTick SelDistrict(PRPSetupTick objprp)
        {
            return obj.SelDistrict(objprp);
        }
//--End District.  
//--Start City.
        public string InsCity(PRPSetupTick objprp)
        {
            return obj.InsCity(objprp);
        }
        public string UpdCity(PRPSetupTick objprp)
        {
            return obj.UpdCity(objprp);
        }
        public string DelCity(PRPSetupTick objprp)
        {
            return obj.DelCity(objprp);
        }
        public PRPSetupTick SelCity(PRPSetupTick objprp)
        {
            return obj.SelCity(objprp);
        }

        //--Start Branch Locator
        public string InsBranchLocator(PRPSetupTick objprp)
        {
            return obj.InsBranchLocator(objprp);
        }
        public string UpdBranchLocator(PRPSetupTick objprp)
        {
            return obj.UpdBranchLocator(objprp);
        }
        public string DelBranchLocator(PRPSetupTick objprp)
        {
            return obj.DelBranchLocator(objprp) ;
        }
        public PRPSetupTick SelBranchLocator(PRPSetupTick objprp)
        {
            return obj.SelBranchLocator(objprp);
        }
        public List<PRPSetupTick> ViewBranchLocator(PRPSetupTick prp)
        {
            return obj.ViewBranchLocator(prp);
        }
        public List<PRPSetupTick> ViewBranchLocator1(PRPSetupTick prp)
        {
            return obj.ViewBranchLocator1(prp);
        }
        //--End Branch Locator

//--Start Text Editor.
        public string InsCourseText(PRPSetupTick objprp)
        {
            return obj.InsCourseText(objprp);
        }
        public string UpdCourseText(PRPSetupTick objprp)
        {
            return obj.UpdCourseText(objprp);
        }
        public string DelCourseText(PRPSetupTick objprp)
        {
            return obj.DelCourseText(objprp);
        }
        public PRPSetupTick SelCourseText(PRPSetupTick objprp)
        {
            return obj.SelCourseText(objprp);
        }
        public PRPSetupTick SelCourseText1(PRPSetupTick objprp)
        {
            return obj.SelCourseText1(objprp);
        }
        public List<PRPSetupTick> ViewCourseText(PRPSetupTick prp)
        {
            return obj.ViewCourseText(prp);
        }
 //--End Text Editor.


//Start Visitor Counter.
        public string UpdVisitor(PRPSetupTick objprp)
        {
            return obj.UpdVisitor(objprp);
        }

//--Start Text Editor.
        public string InsCommentDetail(PRPSetupTick objprp)
        {
            return obj.InsCommentDetail(objprp);
        }
        public string UpdCommentDetail(PRPSetupTick objprp)
        {
            return obj.UpdCommentDetail(objprp);
        }
        public string DelCommentDetail(PRPSetupTick objprp)
        {
            return obj.DelCommentDetail(objprp);
        }       
        public List<PRPSetupTick> ViewMCommentDetail(PRPSetupTick prp)
        {
            return obj.ViewMCommentDetail(prp);
        }
        public List<PRPSetupTick> viewMCommentDetail3(PRPSetupTick prp)
        {
            return obj.viewMCommentDetail3(prp);
        }

        public List<PRPSetupTick> viewMCommentDetail4(PRPSetupTick prp)
        {
            return obj.viewMCommentDetail4(prp);
        }

        public List<PRPSetupTick> ViewSCommentDetail(PRPSetupTick prp)
        {
            return obj.ViewSCommentDetail(prp);
        }
//--End Text Editor.
    }
}
