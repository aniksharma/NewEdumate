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
using nmsSetupI;
namespace nmsSetupI
{
    public class clsBLSetup
    {
        clsDLSetup obj = new clsDLSetup();
        //--start university.
        public string InsertUniversity(PRPSetup objprp)
        {
            return obj.InsertUniversity(objprp);
        }
        public string UpdateUniversity(PRPSetup objprp)
        {
            return obj.UpdateUniversity(objprp);
        }
        public string DeleteUniversity(PRPSetup objprp)
        {
            return obj.DeleteUniversity(objprp);
        }
        public PRPSetup SelectUniversity(PRPSetup objprp)
        {
            return obj.SelectUniversity(objprp);
        }
        public List<PRPSetup> ViewUniversity(PRPSetup objprp)
        {
            return obj.ViewUniversity(objprp);
        }
        //--End university.
        //--Start Setup Course Category.
        public string InsCourseCategory(PRPSetup objprp)
        {
            return obj.InsCourseCategory(objprp);
        }
        public string UpdCourseCategory(PRPSetup objprp)
        {
            return obj.UpdCourseCategory(objprp);

        }
        public string DelCourseCategory(PRPSetup objprp)
        {

            return obj.DelCourseCategory(objprp);

        }
        public PRPSetup SelCourseCategory(PRPSetup objprp)
        {
            return obj.SelCourseCategory(objprp);
        }
        public DataTable ViewCourseCategory(PRPSetup objprp)
        {
            return obj.ViewCourseCategory(objprp);
        }       
//--End Setup Course Category.

//--Start Course Detail.
        public string InsertCourse(PRPSetup objprp)
        {
            return obj.InsertCourse(objprp);
        }
        public string UpdateCourse(PRPSetup objprp)
        {
            return obj.UpdateCourse(objprp);
        }
        public string DeleteCourse(PRPSetup objprp)
        {
            return obj.DeleteCourse(objprp);
        }
        public PRPSetup SelectCourse(PRPSetup objprp)
        {

            return obj.SelectCourse(objprp);
        }
        public List<PRPSetup> ViewCourse(PRPSetup prp)
        {
            return obj.ViewCourse(prp);
        }
//--End Course Detail.

//--Start News For
        public string InsNewsFor(PRPSetup objprp)
        {
            return obj.InsNewsFor(objprp);
        }
        public string UpdNewsFor(PRPSetup objprp)
        {
            return obj.UpdNewsFor(objprp);
        }
        public string DelNewsFor(PRPSetup objprp)
        {
            return obj.DelNewsFor(objprp);
        }
        public PRPSetup SelNewsFor(PRPSetup objprp)
        {
            return obj.SelNewsFor(objprp);

        }
//--End News For


//--Start News Type.
        public string InsNewsType(PRPSetup objprp)
        {
            return obj.InsNewsType(objprp);
        }
        public string UpdNewsType(PRPSetup objprp)
        {
            return obj.UpdNewsType(objprp);
        }
        public string DelNewsType(PRPSetup objprp)
        {
            return obj.DelNewsType(objprp);
        }
        public PRPSetup SelNewsType(PRPSetup objprp)
        {
            return obj.SelNewsType(objprp);

        }
        //--End News Type.

        //--Start News
        public string InsNews(PRPSetup objprp)
        {
            return obj.InsNews(objprp);
        }
        public string UpdNews(PRPSetup objprp)
        {
            return obj.UpdNews(objprp);
        }
        public string DelNews(PRPSetup objprp)
        {
            return obj.DelNews(objprp);
        }
        public PRPSetup SelNews(PRPSetup objprp)
        {
            return obj.SelNews(objprp);
        }
        public List<PRPSetup> ViewNews(PRPSetup prp)
        {
            return obj.ViewNews(prp);
        }
        public List<PRPSetup> ViewNews1(PRPSetup prp)
        {
            return obj.ViewNews1(prp);
        }
        public List<PRPSetup> viewNewsWithPaging1(PRPSetup prp)
        {
            return obj.viewNewsWithPaging1(prp);
        }
//--End News

//--Start--New Job.
        public string InsJob(PRPSetup objprp)
        {
            return obj.InsJob(objprp);
        }
        public string UpdJob(PRPSetup objprp)
        {
            return obj.UpdJob(objprp);
        }
        public string DelJob(PRPSetup objprp)
        {
            return obj.DelJob(objprp);
        }
        public PRPSetup SelJob(PRPSetup objprp)
        {
            return obj.SelJob(objprp);
        }
        public List<PRPSetup> ViewJob(PRPSetup prp)
        {
            return obj.ViewJob(prp);
        }
        public List<PRPSetup> ViewJob1(PRPSetup prp)
        {
            return obj.ViewJob1(prp);
        }
//--End--New Job.

//--Start Resume Detail.
        public string InsResumeDetail(PRPSetup objprp)
        {
            return obj.InsResumeDetail(objprp);

        }
        public string UpdResumeDetail(PRPSetup objprp)
        {
            return obj.UpdResumeDetail(objprp);
        }        
        public List<PRPSetup> ViewResumeDetail(PRPSetup prp)
        {
            return obj.ViewResumeDetail(prp);
        }
        public string GetMaxFileId()
        {
            return obj.GetMaxFileId();
        }
//--End Resume Detail.

//--Start File Detail
        public string InsFile(PRPSetup objprp)
        {
            return obj.InsFile(objprp); 
        }
        public string UpdFile(PRPSetup objprp)
        {
            return obj.UpdFile(objprp);
        }
        public List<PRPSetup> ViewFile(PRPSetup objprp)
        {
            return obj.ViewFile(objprp);
        }
        public PRPSetup SelFile(PRPSetup objprp)
        {
            return obj.SelFile(objprp);
        }
        public string DelFile(PRPSetup objprp)
        {
            return obj.DelFile(objprp);
        }              
//--End File Detail

//--Start Text Editor.
        public string InsText(PRPSetup objprp)
        {
            return obj.InsText(objprp);
        }
        public string UpdText(PRPSetup objprp)
        {
            return obj.UpdText(objprp);
        }
        public string DelText(PRPSetup objprp)
        {
            return obj.DelText(objprp);
        }
        public PRPSetup SelText(PRPSetup objprp)
        {
            return obj.SelText(objprp);
        }
        public PRPSetup SelText1(PRPSetup objprp)
        {
            return obj.SelText1(objprp);
        }
        public List<PRPSetup> ViewText(PRPSetup prp)
        {
            return obj.ViewText(prp);
        }
//--End Text Editor.


//--Start Local Text Editor.        
        public string UpdLocalText(PRPSetup objprp)
        {
            return obj.UpdLocalText(objprp);
        }        
        public PRPSetup SelLocalText(PRPSetup objprp)
        {
            return obj.SelLocalText(objprp);
        }        
//--End Local Text Editor.

//--Start Image Category.
        public string InsImageCategory(PRPSetup objprp)
        {
            return obj.InsImageCategory(objprp);
        }
        public string UpdImageCategory(PRPSetup objprp)
        {
            return obj.UpdImageCategory(objprp);

        }
        public string DelImageCategory(PRPSetup objprp)
        {

            return obj.DelImageCategory(objprp);

        }
        public PRPSetup SelImageCategory(PRPSetup objprp)
        {
            return obj.SelImageCategory(objprp);
        }
        public DataTable ViewImageCategory(PRPSetup objprp)
        {
            return obj.ViewImageCategory(objprp);
        }       
//--End Image Category.

 //--Start Image Category.
        public string InsTextCategory(PRPSetup objprp)
        {
            return obj.InsTextCategory(objprp);
        }
        public string UpdTextCategory(PRPSetup objprp)
        {
            return obj.UpdTextCategory(objprp);

        }
        public string DelTextCategory(PRPSetup objprp)
        {

            return obj.DelTextCategory(objprp);

        }
        public PRPSetup SelTextCategory(PRPSetup objprp)
        {
            return obj.SelTextCategory(objprp);
        }
        public DataTable ViewTextCategory(PRPSetup objprp)
        {
            return obj.ViewTextCategory(objprp);
        }
//--End Image Category.

//--Start image Gallery
        public string InsImageGallery(PRPSetup objprp)
        {
            return obj.InsImageGallery(objprp);
        }
        public string UpdImageGallery(PRPSetup objprp)
        {
            return obj.UpdImageGallery(objprp);
        }
        public string DelImageGallery(PRPSetup objprp)
        {
            return obj.DelImageGallery(objprp);
        }
        public PRPSetup SelImageGallery(PRPSetup objprp)
        {
            return obj.SelImageGallery(objprp);
        }
        public List<PRPSetup> ViewImageGallery(PRPSetup objprp)
        {
            return obj.ViewImageGallery(objprp);
        }    
//--End Image Gallery.

//--Start State
        public string InsState(PRPSetup objprp)
        {
            return obj.InsState(objprp);
        }
        public string UpdState(PRPSetup objprp)
        {
            return obj.UpdState(objprp);
        }
        public string DelState(PRPSetup objprp)
        {
            return obj.DelState(objprp);
        }
        public PRPSetup SelState(PRPSetup objprp)
        {
            return obj.SelState(objprp);
        }
//--End State

//--Start District.
        public string InsDistrict(PRPSetup objprp)
        {
            return obj.InsDistrict(objprp);
        }
        public string UpdDistrict(PRPSetup objprp)
        {
            return obj.UpdDistrict(objprp);
        }
        public string DelDistrict(PRPSetup objprp)
        {
            return obj.DelDistrict(objprp);
        }
        public PRPSetup SelDistrict(PRPSetup objprp)
        {
            return obj.SelDistrict(objprp);
        }
//--End District.  
//--Start City.
        public string InsCity(PRPSetup objprp)
        {
            return obj.InsCity(objprp);
        }
        public string UpdCity(PRPSetup objprp)
        {
            return obj.UpdCity(objprp);
        }
        public string DelCity(PRPSetup objprp)
        {
            return obj.DelCity(objprp);
        }
        public PRPSetup SelCity(PRPSetup objprp)
        {
            return obj.SelCity(objprp);
        }

        //--Start Branch Locator
        public string InsBranchLocator(PRPSetup objprp)
        {
            return obj.InsBranchLocator(objprp);
        }
        public string UpdBranchLocator(PRPSetup objprp)
        {
            return obj.UpdBranchLocator(objprp);
        }
        public string DelBranchLocator(PRPSetup objprp)
        {
            return obj.DelBranchLocator(objprp) ;
        }
        public PRPSetup SelBranchLocator(PRPSetup objprp)
        {
            return obj.SelBranchLocator(objprp);
        }
        public List<PRPSetup> ViewBranchLocator(PRPSetup prp)
        {
            return obj.ViewBranchLocator(prp);
        }
        public List<PRPSetup> ViewBranchLocator1(PRPSetup prp)
        {
            return obj.ViewBranchLocator1(prp);
        }
        //--End Branch Locator

//--Start Text Editor.
        public string InsCourseText(PRPSetup objprp)
        {
            return obj.InsCourseText(objprp);
        }
        public string UpdCourseText(PRPSetup objprp)
        {
            return obj.UpdCourseText(objprp);
        }
        public string DelCourseText(PRPSetup objprp)
        {
            return obj.DelCourseText(objprp);
        }
        public PRPSetup SelCourseText(PRPSetup objprp)
        {
            return obj.SelCourseText(objprp);
        }
        public PRPSetup SelCourseText1(PRPSetup objprp)
        {
            return obj.SelCourseText1(objprp);
        }
        public List<PRPSetup> ViewCourseText(PRPSetup prp)
        {
            return obj.ViewCourseText(prp);
        }
        //--End Text Editor.
//Start Visitor Counter.
        public string UpdVisitor(PRPSetup objprp)
        {
            return obj.UpdVisitor(objprp);
        }

//---start Enquiry form--------
        public string InsertEnquiry(PRPSetup objprp)
        {
            return obj.InsertEnquiry(objprp);
        }
        public string UpdateEnquiry(PRPSetup objprp)
        {
            return obj.UpdateEnquiry(objprp);
        }
        public List<PRPSetup> viewEnquiry(PRPSetup objprp)
        {
            return obj.viewEnquiry(objprp);
        }
        public string DelEnquiry(PRPSetup objprp)
        {
            return obj.DelEnquiry(objprp);
        }
//----End Enquiry form----------
        public List<PRPSetup> ViewText1(PRPSetup prp)
        {
            return obj.ViewText1(prp);
        }

        public List<PRPSetup> ViewText2(PRPSetup prp)
        {
            return obj.ViewText2(prp);
        }

        public List<PRPSetup> OtherLink(PRPSetup prp)
        {
            return obj.OtherLink(prp);
        }
        //11-1
        //public string DelEnquiry(PRPSetup objprp)
        //{
        //    return obj.DelEnquiry(objprp);
        //}

//--start Master Category.
        public string InsertMasterCategory(PRPSetup objprp)
        {
            return obj.InsertMasterCategory(objprp);
        }
        public string UpdateMasterCategory(PRPSetup objprp)
        {
            return obj.UpdateMasterCategory(objprp);
        }
        public string DeleteMasterCategory(PRPSetup objprp)
        {
            return obj.DeleteMasterCategory(objprp);
        }
        public PRPSetup SelectMasterCategory(PRPSetup objprp)
        {
            return obj.SelectMasterCategory(objprp);
        }
        public List<PRPSetup> ViewMasterCategory(PRPSetup objprp)
        {
            return obj.ViewMasterCategory(objprp);
        }
//--End MasterCategory.


//--Start Master Category Detail.
        public string InsMasterCatDetail(PRPSetup objprp)
        {
            return obj.InsMasterCatDetail(objprp);
        }
        public string UpdMasterCatDetail(PRPSetup objprp)
        {
            return obj.UpdMasterCatDetail(objprp);

        }
        public string DelMasterCatDetail(PRPSetup objprp)
        {

            return obj.DelMasterCatDetail(objprp);

        }
        public PRPSetup SelMasterCatDetail(PRPSetup objprp)
        {
            return obj.SelMasterCatDetail(objprp);
        }
        public DataTable ViewMasterCatDetail(PRPSetup objprp)
        {
            return obj.ViewMasterCatDetail(objprp);
        }
 //--End Master Category Detail.

//--Start Student Registration.
        public string InsertStudentRegistration(PRPSetup objprp)
        {
            return obj.InsertStudentRegistration(objprp);
        }
        public string UpdateStudentRegistration(PRPSetup objprp)
        {
            return obj.UpdateStudentRegistration(objprp);
        }
        public PRPSetup SelectStudentRegistration(PRPSetup objprp)
        {
            return obj.SelectStudentRegistration(objprp);
        }
        public List<PRPSetup> viewStudentRegistration(PRPSetup prp)
        {
            return obj.viewStudentRegistration(prp);
        }
        public string DelStudentRegistration(PRPSetup prp)
        {
            return obj.DelStudentRegistration(prp);
        }

        public List<PRPSetup> studentSubjectDetail(PRPSetup prp)
        {
            return obj.studentSubjectDetail(prp);
        }

//--End Student Registration.



 //--Start Notes Detail.
        public string InsNotesDetail(PRPSetup objprp)
        {
            return obj.InsNotesDetail(objprp);
        }
        public string UpdNotesDetail(PRPSetup objprp)
        {
            return obj.UpdNotesDetail(objprp);
        }

        public string UpdNotesStatusDetail(PRPSetup objprp)
        {
            return obj.UpdNotesStatusDetail(objprp);
        }
        public string DelNotesDetail(PRPSetup objprp)
        {
            return obj.DelNotesDetail(objprp);
        }
        public PRPSetup SelNotesDetail(PRPSetup objprp)
        {
            return obj.SelNotesDetail(objprp);
        }
        public PRPSetup SelNotesDetail1(PRPSetup objprp)
        {
            return obj.SelNotesDetail1(objprp);
        }
        public List<PRPSetup> ViewNotesDetail(PRPSetup prp)
        {
            return obj.ViewNotesDetail(prp);
        }

        public List<PRPSetup> viewSubjectStudentWise(PRPSetup prp)
        {
            return obj.viewSubjectStudentWise(prp);
        }

        public List<PRPSetup> viewNotesSubjectWise(PRPSetup prp)
        {
            return obj.viewNotesSubjectWise(prp);
        }

//--End Notes Detail.
    }
}
