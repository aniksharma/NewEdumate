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
using nmsSetupWeb;
namespace nmsSetupWeb
{
    public class clsBLSetupWeb
    {
        clsDLSetupWeb obj = new clsDLSetupWeb();
//--start university.
        public string InsertUniversity(PRPSetupWeb objprp)
        {
            return obj.InsertUniversity(objprp);
        }
        public string UpdateUniversity(PRPSetupWeb objprp)
        {
            return obj.UpdateUniversity(objprp);
        }
        public string DeleteUniversity(PRPSetupWeb objprp)
        {
            return obj.DeleteUniversity(objprp);
        }
        public PRPSetupWeb SelectUniversity(PRPSetupWeb objprp)
        {
            return obj.SelectUniversity(objprp);
        }
        public List<PRPSetupWeb> ViewUniversity(PRPSetupWeb objprp)
        {
            return obj.ViewUniversity(objprp);
        }
//--End university.

 //---start Enquiry form--------
        //public string InsertEnquiry(PRPSetupWeb objprp)
        //{
        //    return obj.InsertEnquiry(objprp);
        //}
        //public List<PRPSetupWeb> viewEnquiry(PRPSetupWeb objprp)
        //{
        //    return obj.viewEnquiry(objprp);
        //}
 //----End Enquiry form----------



//--start university Web.
        public string InsertUniversityWeb(PRPSetupWeb objprp)
        {
            return obj.InsertUniversityWeb(objprp);
        }
        public string UpdateUniversityWeb(PRPSetupWeb objprp)
        {
            return obj.UpdateUniversityWeb(objprp);
        }
        public string DeleteUniversityWeb(PRPSetupWeb objprp)
        {
            return obj.DeleteUniversityWeb(objprp);
        }
        public PRPSetupWeb SelectUniversityWeb(PRPSetupWeb objprp)
        {
            return obj.SelectUniversityWeb(objprp);
        }
        public List<PRPSetupWeb> ViewUniversityWeb(PRPSetupWeb objprp)
        {
            return obj.ViewUniversityWeb(objprp);
        }
        public List<PRPSetupWeb> ViewUniversityType( PRPSetupWeb objprp )
        {
            return obj.ViewUniversityType(objprp);
        }      
//--End university Web.

//--start university Web.
        public string InsertCollegeDetail(PRPSetupWeb objprp)
        {
            return obj.InsertCollegeDetail(objprp);
        }
        public string UpdateCollegeDetail(PRPSetupWeb objprp)
        {
            return obj.UpdateCollegeDetail(objprp);
        }
        public string DeleteCollegeDetail(PRPSetupWeb objprp)
        {
            return obj.DeleteCollegeDetail(objprp);
        }
        public PRPSetupWeb SelectCollegeDetail(PRPSetupWeb objprp)
        {
            return obj.SelectCollegeDetail(objprp);
        }

        

        public List<PRPSetupWeb> ViewCollegeDetail(PRPSetupWeb objprp)
        {
            return obj.ViewCollegeDetail(objprp);
        }
        //public List<PRPSetupWeb> ViewCollegeType()
        //{
        //    return obj.ViewCollegeType();
        //}
//--End university Web.






//--Start Setup Course Category.
        public string InsCourseCategory(PRPSetupWeb objprp)
        {
            return obj.InsCourseCategory(objprp);
        }
        public string UpdCourseCategory(PRPSetupWeb objprp)
        {
            return obj.UpdCourseCategory(objprp);

        }
        public string DelCourseCategory(PRPSetupWeb objprp)
        {

            return obj.DelCourseCategory(objprp);

        }
        public PRPSetupWeb SelCourseCategory(PRPSetupWeb objprp)
        {
            return obj.SelCourseCategory(objprp);
        }
        public DataTable ViewCourseCategory(PRPSetupWeb objprp)
        {
            return obj.ViewCourseCategory(objprp);
        }
        //--End Setup Course Category.

        #region ApprovedBy

        public string InsApprovedBy(PRPSetupWeb objprp)
        {
            return obj.InsApprovedBy(objprp);
        }

        #endregion


        #region Course Level

        public string InsCourseLevel(PRPSetupWeb objprp)
        {
            return obj.InsCourseLevel(objprp);
        }
        #endregion

        //Statr Sub Course Catagory
        public string InsSubCategory(PRPSetupWeb objprp)
        {
            return obj.InsSubCategory(objprp);
        }
        public string UpdSubCategory(PRPSetupWeb objprp)
        {
            return obj.UpdSubCategory(objprp);
        }
        public string DelSubCategory(PRPSetupWeb objprp)
        {
            return obj.DelSubCategory(objprp);
        }
        public PRPSetupWeb SelSubCategory(PRPSetupWeb objprp)
        {
            return obj.SelSubCategory(objprp);

        }

        #region For Update Logo

        public PRPSetupWeb SelCollegeLogo(PRPSetupWeb objprp)
        {
            return obj.SelCollegeLogo(objprp);

        }

        public string UpdateCollegeLogo(PRPSetupWeb objprp)
        {
            return obj.UpdateCollegeLogo(objprp);
        }
        #endregion
        //End Sub Course Catagory
//--Start Course Detail Web.
        public string InsertCourse(PRPSetupWeb objprp)
        {
            return obj.InsertCourseWeb(objprp);
        }
        public string UpdateCourse(PRPSetupWeb objprp)
        {
            return obj.UpdateCourse(objprp);
        }
        public string DeleteCourse(PRPSetupWeb objprp)
        {
            return obj.DeleteCourse(objprp);
        }
        public PRPSetupWeb SelectCourse(PRPSetupWeb objprp)
        {

            return obj.SelectCourse(objprp);
        }
        public List<PRPSetupWeb> ViewCourse(PRPSetupWeb prp)
        {
            return obj.ViewCourseWeb(prp);
        }
        //--End Course Detail Web.
        //News For Start
        public string InsNewsFor(PRPSetupWeb objprp)
        {
            return obj.InsNewsFor(objprp);
        }
        public string UpdNewsFor(PRPSetupWeb objprp)
        {
            return obj.UpdNewsFor(objprp);
        }
        public string DelNewsFor(PRPSetupWeb objprp)
        {
            return obj.DelNewsFor(objprp);
        }
        public PRPSetupWeb SelNewsFor(PRPSetupWeb objprp)
        {
            return obj.SelNewsFor(objprp);

        }
        //News For End
//--Start News Type.
        public string InsNewsType(PRPSetupWeb objprp)
        {
            return obj.InsNewsType(objprp);
        }
        public string UpdNewsType(PRPSetupWeb objprp)
        {
            return obj.UpdNewsType(objprp);
        }
        public string DelNewsType(PRPSetupWeb objprp)
        {
            return obj.DelNewsType(objprp);
        }
        public PRPSetupWeb SelNewsType(PRPSetupWeb objprp)
        {
            return obj.SelNewsType(objprp);
            
        }

        //--End News Type.
        //Show In Branch Start
        public List<PRPSetupWeb> BindBranchForCheck(PRPSetupWeb objprp)
        {
            return obj.BindBranchForCheck(objprp);
        }
        public string InsertShowInBranch(PRPSetupWeb objprp)
        {
            return obj.InsertShowInBranch(objprp);
        }
        // Show In Branch End
        //Authorisation Start
        
        public List<PRPSetupWeb> BindUniforAuth(PRPSetupWeb objprp)
        {
            return obj.BindUniforAuth(objprp);
        }
        public List<PRPSetupWeb> CheckUniByBranch(PRPSetupWeb objprp)
        {
            return obj.CheckUniByBranch(objprp);
        }
        public string InsertCollegeDetailWebType(PRPSetupWeb objprp)
        {
            return obj.InsertCollegeDetailWebType(objprp);
        }
        public List<PRPSetupWeb> BindByAuthorisation(PRPSetupWeb prp)
        {
            return obj.BindByAuthorisation(prp);           
        }
        public List<PRPSetupWeb> BindUniInRepitor(PRPSetupWeb prp)
        {
            return obj.BindCollegInRepitor(prp);
        }
        public string DeleteCollSub(PRPSetupWeb objprp)
        {
            return obj.DeleteCollSub(objprp);
        }
        //Authorisation End
//--Start News
        public string InsNews(PRPSetupWeb objprp)
        {
            return obj.InsNews(objprp);   
        }
        public string UpdNews(PRPSetupWeb objprp)
        {
            return obj.UpdNews(objprp);           
        }
        public string DelNews(PRPSetupWeb objprp)
        {
            return obj.DelNews(objprp);           
        }
        public PRPSetupWeb SelNews(PRPSetupWeb objprp)
        {
            return obj.SelNews(objprp);
        }
        public List<PRPSetupWeb> ViewNews(PRPSetupWeb prp)
        {
            return obj.ViewNews(prp);           
        }

        public List<PRPSetupWeb> ViewNewsInBranch(PRPSetupWeb prp)
        {
            return obj.ViewNewsInBranch(prp);
        }
        public List<PRPSetupWeb> ViewNews1(PRPSetupWeb prp)
        {
            return obj.ViewNews1(prp);
        }
//--End News

//--Start--New Job.
        public string InsJob(PRPSetupWeb objprp)
        {
            return obj.InsJob(objprp);
        }
        public string UpdJob(PRPSetupWeb objprp)
        {
            return obj.UpdJob(objprp);
        }
        public string DelJob(PRPSetupWeb objprp)
        {
            return obj.DelJob(objprp);
        }
        public PRPSetupWeb SelJob(PRPSetupWeb objprp)
        {
            return obj.SelJob(objprp);
        }
        public List<PRPSetupWeb> ViewJob(PRPSetupWeb prp)
        {
            return obj.ViewJob(prp);
        }
        public List<PRPSetupWeb> ViewJob1(PRPSetupWeb prp)
        {
            return obj.ViewJob1(prp);
        }
//--End--New Job.

//--Start Resume Detail.
        public string InsResumeDetail(PRPSetupWeb objprp)
        {
            return obj.InsResumeDetail(objprp);

        }
        public string UpdResumeDetail(PRPSetupWeb objprp)
        {
            return obj.UpdResumeDetail(objprp);
        }        
        public List<PRPSetupWeb> ViewResumeDetail(PRPSetupWeb prp)
        {
            return obj.ViewResumeDetail(prp);
        }
        public string GetMaxFileId()
        {
            return obj.GetMaxFileId();
        }
//--End Resume Detail.

//--Start File Detail
        public string InsFile(PRPSetupWeb objprp)
        {
            return obj.InsFile(objprp); 
        }
        public string UpdFile(PRPSetupWeb objprp)
        {
            return obj.UpdFile(objprp);
        }
        public List<PRPSetupWeb> ViewFile(PRPSetupWeb objprp)
        {
            return obj.ViewFile(objprp);
        }
        public PRPSetupWeb SelFile(PRPSetupWeb objprp)
        {
            return obj.SelFile(objprp);
        }
        public string DelFile(PRPSetupWeb objprp)
        {
            return obj.DelFile(objprp);
        }              
//--End File Detail

//--Start Text Editor.
        public string InsText(PRPSetupWeb objprp)
        {
            return obj.InsText(objprp);
        }
        public string UpdText(PRPSetupWeb objprp)
        {
            return obj.UpdText(objprp);
        }
        public string DelText(PRPSetupWeb objprp)
        {
            return obj.DelText(objprp);
        }
        public PRPSetupWeb SelText(PRPSetupWeb objprp)
        {
            return obj.SelText(objprp);
        }
        public PRPSetupWeb SelText1(PRPSetupWeb objprp)
        {
            return obj.SelText1(objprp);
        }
        public List<PRPSetupWeb> ViewText(PRPSetupWeb prp)
        {
            return obj.ViewText(prp);
        }
//--End Text Editor.

        //--Start Text Editor.
        public string InsTextWeb(PRPSetupWeb objprp)
        {
            return obj.InsTextWeb(objprp);
        }
        public string UpdTextWeb(PRPSetupWeb objprp)
        {
            return obj.UpdTextWeb(objprp);
        }
        public string DelTextWeb(PRPSetupWeb objprp)
        {
            return obj.DelTextWeb(objprp);
        }
        public PRPSetupWeb SelTextWeb(PRPSetupWeb objprp)
        {
            return obj.SelTextWeb(objprp);
        }
        public PRPSetupWeb SelTextWeb1(PRPSetupWeb objprp)
        {
            return obj.SelTextWeb1(objprp);
        }
        public List<PRPSetupWeb> ViewTextWeb(PRPSetupWeb prp)
        {
            return obj.ViewTextWeb(prp);
        }
        //--End Text Editor.




//--Start Local Text Editor.        
        public string UpdLocalText(PRPSetupWeb objprp)
        {
            return obj.UpdLocalText(objprp);
        }        
        public PRPSetupWeb SelLocalText(PRPSetupWeb objprp)
        {
            return obj.SelLocalText(objprp);
        }        
//--End Local Text Editor.

//--Start Image Category.
        public string InsImageCategory(PRPSetupWeb objprp)
        {
            return obj.InsImageCategory(objprp);
        }
        public string UpdImageCategory(PRPSetupWeb objprp)
        {
            return obj.UpdImageCategory(objprp);

        }
        public string DelImageCategory(PRPSetupWeb objprp)
        {

            return obj.DelImageCategory(objprp);

        }
        public PRPSetupWeb SelImageCategory(PRPSetupWeb objprp)
        {
            return obj.SelImageCategory(objprp);
        }
        public DataTable ViewImageCategory(PRPSetupWeb objprp)
        {
            return obj.ViewImageCategory(objprp);
        }       
//--End Image Category.

 //--Start Image Category.
        public string InsTextCategory(PRPSetupWeb objprp)
        {
            return obj.InsTextCategory(objprp);
        }
        public string UpdTextCategory(PRPSetupWeb objprp)
        {
            return obj.UpdTextCategory(objprp);

        }
        public string DelTextCategory(PRPSetupWeb objprp)
        {

            return obj.DelTextCategory(objprp);

        }
        public PRPSetupWeb SelTextCategory(PRPSetupWeb objprp)
        {
            return obj.SelTextCategory(objprp);
        }
        public DataTable ViewTextCategory(PRPSetupWeb objprp)
        {
            return obj.ViewTextCategory(objprp);
        }
//--End Image Category.


//--Start Text Category Web.
        public string InsTextCategoryWeb(PRPSetupWeb objprp)
        {
            return obj.InsTextCategoryWeb(objprp);
        }
        public string UpdTextCategoryWeb(PRPSetupWeb objprp)
        {
            return obj.UpdTextCategoryWeb(objprp);

        }
        public string DelTextCategoryWeb(PRPSetupWeb objprp)
        {

            return obj.DelTextCategoryWeb(objprp);

        }
        public PRPSetupWeb SelTextCategoryWeb(PRPSetupWeb objprp)
        {
            return obj.SelTextCategoryWeb(objprp);
        }
        public DataTable ViewTextCategoryWeb(PRPSetupWeb objprp)
        {
            return obj.ViewTextCategoryWeb(objprp);
        }
//--End Text Category Web.


//--Start image Gallery
        public string InsImageGallery(PRPSetupWeb objprp)
        {
            return obj.InsImageGallery(objprp);
        }
        public string UpdImageGallery(PRPSetupWeb objprp)
        {
            return obj.UpdImageGallery(objprp);
        }
        public string DelImageGallery(PRPSetupWeb objprp)
        {
            return obj.DelImageGallery(objprp);
        }
        public PRPSetupWeb SelImageGallery(PRPSetupWeb objprp)
        {
            return obj.SelImageGallery(objprp);
        }
        public List<PRPSetupWeb> ViewImageGallery(PRPSetupWeb objprp)
        {
            return obj.ViewImageGallery(objprp);
        }    
//--End Image Gallery.

//--Start UniversityType
        public string InsUniversityType(PRPSetupWeb objprp)
        {
            return obj.InsUniversityType(objprp);
        }
        public string UpdUniversityType(PRPSetupWeb objprp)
        {
            return obj.UpdUniversityType(objprp);
        }
        public string DelUniversityType(PRPSetupWeb objprp)
        {
            return obj.DelUniversityType(objprp);
        }
        public PRPSetupWeb SelUniversityType(PRPSetupWeb objprp)
        {
            return obj.SelUniversityType(objprp);
        }

//--End UniversityType

//--Start College Type
        public string InsCollegeType(PRPSetupWeb objprp)
        {
            return obj.InsCollegeType(objprp);
        }
        public string UpdCollegeType(PRPSetupWeb objprp)
        {
            return obj.UpdCollegeType(objprp);
        }
        public string DelCollegeType(PRPSetupWeb objprp)
        {
            return obj.DelCollegeType(objprp);
        }
        public PRPSetupWeb SelCollegeType(PRPSetupWeb objprp)
        {
            return obj.SelCollegeType(objprp);
        }
        public List<PRPSetupWeb> ViewCollegeType(PRPSetupWeb objprp)
        {
            return obj.ViewCollegeType(objprp);
        }

        public List<PRPSetupWeb> ViewCollegeType1(PRPSetupWeb objprp)
        {
            return obj.ViewCollegeType1(objprp);
        }



//--End College Type


//--Start Course Type
        public string InsCourseType(PRPSetupWeb objprp)
        {
            return obj.InsCourseType(objprp);
        }
        public string UpdCourseType(PRPSetupWeb objprp)
        {
            return obj.UpdCourseType(objprp);
        }
        public string DelCourseType(PRPSetupWeb objprp)
        {
            return obj.DelCourseType(objprp);
        }
        public PRPSetupWeb SelCourseType(PRPSetupWeb objprp)
        {
            return obj.SelCourseType(objprp);
        }

//--End Course  Type
        // Start main Course Stream
        public string InsMainCategory(PRPSetupWeb objprp)
        {
            return obj.InsMainCategory(objprp);
        }
        public string UpdMainCategory(PRPSetupWeb objprp)
        {
            return obj.UpdMainCategory(objprp);
        }
        public string DelMainCategory(PRPSetupWeb objprp)
        {
            return obj.DelMainCategory(objprp);
        }
        public PRPSetupWeb SelMainCategory(PRPSetupWeb objprp)
        {
            return obj.SelMainCategory(objprp);
        }

        public PRPSetupWeb crsViewbySelectMainCategorybyName(PRPSetupWeb objprp)
        {
            return obj.crsViewbySelectMainCategorybyName(objprp);
        }
        // End main Course Stream
//--Start EducationType
        public string InsEducationType(PRPSetupWeb objprp)
        {
            return obj.InsEducationType(objprp);
        }
        public string UpdEducationType(PRPSetupWeb objprp)
        {
            return obj.UpdEducationType(objprp);
        }
        public string DelEducationType(PRPSetupWeb objprp)
        {
            return obj.DelEducationType(objprp);
        }
        public PRPSetupWeb SelEducationType(PRPSetupWeb objprp)
        {
            return obj.SelEducationType(objprp);
        }
//--End EducationType



//--Start State
        public string InsCountry(PRPSetupWeb objprp)
        {
            return obj.InsCountry(objprp);
        }
        public string UpdCountry(PRPSetupWeb objprp)
        {
            return obj.UpdCountry(objprp);
        }
        public string DelCountry(PRPSetupWeb objprp)
        {
            return obj.DelCountry(objprp);
        }
        public PRPSetupWeb SelCountry(PRPSetupWeb objprp)
        {
            return obj.SelCountry(objprp);
        }
//--End State



//--Start State
        public string InsState(PRPSetupWeb objprp)
        {
            return obj.InsState(objprp);
        }
        public string UpdState(PRPSetupWeb objprp)
        {
            return obj.UpdState(objprp);
        }
        public string DelState(PRPSetupWeb objprp)
        {
            return obj.DelState(objprp);
        }
        public PRPSetupWeb SelState(PRPSetupWeb objprp)
        {
            return obj.SelState(objprp);
        }
//--End State

//--Start District.
        public string InsDistrict(PRPSetupWeb objprp)
        {
            return obj.InsDistrict(objprp);
        }
        public string UpdDistrict(PRPSetupWeb objprp)
        {
            return obj.UpdDistrict(objprp);
        }
        public string DelDistrict(PRPSetupWeb objprp)
        {
            return obj.DelDistrict(objprp);
        }
        public PRPSetupWeb SelDistrict(PRPSetupWeb objprp)
        {
            return obj.SelDistrict(objprp);
        }
//--End District.  
//--Start City.
        public string InsCity(PRPSetupWeb objprp)
        {
            return obj.InsCity(objprp);
        }
        public string UpdCity(PRPSetupWeb objprp)
        {
            return obj.UpdCity(objprp);
        }
        public string DelCity(PRPSetupWeb objprp)
        {
            return obj.DelCity(objprp);
        }
        public PRPSetupWeb SelCity(PRPSetupWeb objprp)
        {
            return obj.SelCity(objprp);
        }

        //--Start Branch Locator
        public string InsBranchLocator(PRPSetupWeb objprp)
        {
            return obj.InsBranchLocator(objprp);
        }
        public string UpdBranchLocator(PRPSetupWeb objprp)
        {
            return obj.UpdBranchLocator(objprp);
        }
        public string DelBranchLocator(PRPSetupWeb objprp)
        {
            return obj.DelBranchLocator(objprp) ;
        }
        public PRPSetupWeb SelBranchLocator(PRPSetupWeb objprp)
        {
            return obj.SelBranchLocator(objprp);
        }
        public List<PRPSetupWeb> ViewBranchLocator(PRPSetupWeb prp)
        {
            return obj.ViewBranchLocator(prp);
        }
        public List<PRPSetupWeb> ViewBranchLocator1(PRPSetupWeb prp)
        {
            return obj.ViewBranchLocator1(prp);
        }
        //--End Branch Locator

//--Start Text Editor.
        public string InsCourseText(PRPSetupWeb objprp)
        {
            return obj.InsCourseText(objprp);
        }
        public string UpdCourseText(PRPSetupWeb objprp)
        {
            return obj.UpdCourseText(objprp);
        }
        public string DelCourseText(PRPSetupWeb objprp)
        {
            return obj.DelCourseText(objprp);
        }
        public PRPSetupWeb SelCourseText(PRPSetupWeb objprp)
        {
            return obj.SelCourseText(objprp);
        }
        public PRPSetupWeb SelCourseText1(PRPSetupWeb objprp)
        {
            return obj.SelCourseText1(objprp);
        }
        public List<PRPSetupWeb> ViewCourseText(PRPSetupWeb prp)
        {
            return obj.ViewCourseText(prp);
        }
        //--End Text Editor.
//Start Visitor Counter.
        public string UpdVisitor(PRPSetupWeb objprp)
        {
            return obj.UpdVisitor(objprp);
        }

        //Start CrsLinkList By Raj
        public string InsertCrsLinkList(PRPSetupWeb objprp)
        {
            return obj.InsertCrsLinkList(objprp);
        }
        public string UpdateCrsLinkList(PRPSetupWeb objprp)
        {
            return obj.UpdateCrsLinkList(objprp);
        }
        public string DelCrsLinkList(PRPSetupWeb objprp)
        {
            return obj.DelCrsLinkList(objprp);
        }

        public string DelSchoolDetail(PRPSetupWeb objprp)
        {
            return obj.DelSchoolDetail(objprp);
        }

        public string DelCollegeDetail(PRPSetupWeb objprp)
        {
            return obj.DelCollegeDetail(objprp);
        }
       
        public PRPSetupWeb SelectCrsLinkList(PRPSetupWeb objprp)
        {

            return obj.SelectCrsLinkList(objprp);
        }
        public List<PRPSetupWeb> ShowCrsLinkList(PRPSetupWeb objprp)
        {

            return obj.ShowCrsLinkList(objprp);
        }
        //End CrsLinkList By Raj
//Start Work By Raj.
        ////////////////8-30-12

        public List<PRPSetupWeb> ShowSchoolDetail(PRPSetupWeb objprp)
        {

            return obj.ShowSchoolDetail(objprp);
        }
        public List<PRPSetupWeb> ShowCollegeDetail(PRPSetupWeb objprp)
        {

            return obj.ShowCollegeDetail(objprp);
        }
        public List<PRPSetupWeb> ViewState(PRPSetupWeb objprp)
        {
            return obj.ViewState(objprp);
        }
        public List<PRPSetupWeb> ViewCity(PRPSetupWeb objprp)
        {
            return obj.ViewCity(objprp);
        }
        public List<PRPSetupWeb> ViewCollegeSearch(PRPSetupWeb objprp)
        {
            return obj.ViewCollegeSearch(objprp);
        }

        public List<PRPSetupWeb> ViewSchoolSearch(PRPSetupWeb objprp)
        {
            return obj.ViewSchoolSearch(objprp);
        }

        public List<PRPSetupWeb> GetDatalist(PRPSetupWeb objprp)
        {
            return obj.GetDatalist(objprp);
        }
        public List<PRPSetupWeb> GetDatalist1(PRPSetupWeb objprp)
        {
            return obj.GetDatalist1(objprp);
        }
        public List<PRPSetupWeb> GetDatalist2(PRPSetupWeb objprp)
        {
            return obj.GetDatalist2(objprp);
        }
        public string InsCollegeEnqury(PRPSetupWeb objprp)
        {
            return obj.InsCollegeEnqury(objprp);
        }

        public List<PRPSetupWeb> ViewCollegeStudentInquery(PRPSetupWeb objprp)
        {
            return obj.ViewCollegeStudentInquery(objprp);
        }
        //9/8/12
        public List<PRPSetupWeb> ViewCompareCollege(PRPSetupWeb objprp)
        {
            return obj.ViewCompareCollege(objprp);
        }
        //public List<PRPSetupWeb> ViewCity(PRPSetupWeb objprp)
        //{
        //    return obj.ViewCity(objprp);
        //}
        //public List<PRPSetupWeb> ViewCity(PRPSetupWeb objprp)
        //{
        //    return obj.ViewCity(objprp);
        //}
        //public List<PRPSetupWeb> ViewCity(PRPSetupWeb objprp)
        //{
        //    return obj.ViewCity(objprp);
        //}
//End Work By Raj


        ////////////////////9/21
        public string InslistingPackageDetail(PRPSetupWeb objprp)
        {
            return obj.InslistingPackageDetail(objprp);
        }
        public string updlistingPackageDetail(PRPSetupWeb objprp)
        {
            return obj.updlistingPackageDetail(objprp);
        }
        public DataTable ViewlistingPackageDetail(PRPSetupWeb objpr)
        {
            return obj.ViewlistingPackageDetail(objpr);
        }
        public PRPSetupWeb ViewlistingPackageDetailById(PRPSetupWeb objpr)
        {
            return obj.ViewlistingPackageDetailById(objpr);
        }
        public string dellistingPackageDetail(PRPSetupWeb objpr)
        {
            return obj.dellistingPackageDetail(objpr);
        }
        public string InsLatesteUpdate(PRPSetupWeb objprp)
        {
            return obj.InsLatesteUpdate(objprp);
        }
        public List<PRPSetupWeb> ShowlatesteUpdate(PRPSetupWeb objprp)
        {

            return obj.ShowlatesteUpdate(objprp);
        }

        public string updLatesteUpdate(PRPSetupWeb objprp)
        {
            return obj.updLatestUpdate(objprp);
        }

        public PRPSetupWeb bindLatestUpdate(PRPSetupWeb objprp)
        {
            return obj.bindLatestUpdate(objprp);
        }

        public string delLatesteUpdate(PRPSetupWeb objprp)
        {
            return obj.delLatestUpdate(objprp);
        }


        public string CheckDayUpdates(PRPSetupWeb objprp)
        {
            return obj.CheckDayUpdates(objprp);
        }
        public DataTable SearchRelatedWord(PRPSetupWeb objprp)
        {
            return obj.SearchRelatedWord(objprp);
        }

        public List<PRPSetupWeb> ViewSchoolState(PRPSetupWeb objprp)
        {
            return obj.ViewSchoolState(objprp);
        }

        public List<PRPSetupWeb> ShowTastomony()
        {

            return obj.ShowTastomony();
        }

        public DataSet ViewCollegePackage()
        {
            return obj.ViewCollegePackage();
        }

        ////11/23
        public string InsViewStatus(PRPSetupWeb objprp)
        {
            return obj.InsViewStatus(objprp);
        }
        public DataSet ViewWebsiteStatus(PRPSetupWeb objprp)
        {
            return obj.ViewWebsiteStatus(objprp);
        }

        public List<PRPSetupWeb> viewTrackStatus(PRPSetupWeb objprp)
        {
            return obj.viewTrackStatus(objprp);
        }

        public string InsCollegePaymentDetail(PRPSetupWeb objprp)
        {
            return obj.InsCollegePaymentDetail(objprp);
        }

        public List<PRPSetupWeb> viewCollegePaymentDetail(PRPSetupWeb objprp)
        {
            return obj.viewCollegePaymentDetail(objprp);
        }

        public PRPSetupWeb selCollegePaymentDetail(PRPSetupWeb objprp)
        {
            return obj.selCollegePaymentDetail(objprp);

        }


        //Start Partner Registration.
        public string InsPartnerLoginDetail(PRPSetupWeb objprp)
        {
            return obj.InsPartnerLoginDetail(objprp);
        }

        public string UpdPartnerLoginDetail(PRPSetupWeb objprp)
        {
            return obj.UpdPartnerLoginDetail(objprp);
        }

        public List<PRPSetupWeb> viewPartnerLoginDetail(PRPSetupWeb objprp)
        {
            return obj.viewPartnerLoginDetail(objprp);
        }

        public List<PRPSetupWeb> ViewCollegeDetail1(PRPSetupWeb objprp)
        {
            return obj.ViewCollegeDetail1(objprp);
        }
        public List<PRPSetupWeb> viewPartnerbusiness(PRPSetupWeb objprp)
        {
            return obj.viewPartnerbusiness(objprp);
        }


        //End Partner Registration.

        public List<PRPSetupWeb> ShowTracking()
        {

            return obj.ShowTracking();
        }

        public string CheckMailStatus(PRPSetupWeb objprp)
        {
            return obj.CheckMailStatus(objprp);
        }

        public string InsCollegemailDetail(PRPSetupWeb objprp)
        {
            return obj.InsCollegemailDetail(objprp);
        }

        public List<PRPSetupWeb> viewMailDetail(PRPSetupWeb prp)
        {
            return obj.viewMailDetail(prp);
        }

        public string updCollegemailDetail(PRPSetupWeb objprp)
        {
            return obj.updCollegemailDetail(objprp);
        }

//Start Master Enquiry.
        public string InsContactEnquiry(PRPSetupWeb objprp)
        {
            return obj.InsContactEnquiry(objprp);
        }
        public List<PRPSetupWeb> ViewContactEnquiry(PRPSetupWeb prp)
        {
            return obj.ViewContactEnquiry(prp);
        }
        public string DelContactEnquiry(PRPSetupWeb objprp)
        {
            return obj.DelContactEnquiry(objprp);
        }        
//End Master Enquiry.

//Start Job Setting.
        public string InsForJObApply(PRPSetupWeb objprp)
        {
            return obj.InsForJObApply(objprp);
        }
        public List<PRPSetupWeb> ViewForJObApply(PRPSetupWeb objprp)
        {
            return obj.ViewForJObApply(objprp);
        }
        public string DelForJObApply(PRPSetupWeb objprp)
        {
            return obj.DelForJObApply(objprp);
        }
        public string RemarkForJObApply(PRPSetupWeb objprp)
        {
            return obj.RemarkForJObApply(objprp);
        }
//End Job Setting.
//Statr Sub Course Catagory
        public string InscrsCourse(PRPSetupWeb objprp)
        {
            return obj.InscrsCourse(objprp);
        }
        public string UpdcrsCourse(PRPSetupWeb objprp)
        {
            return obj.UpdcrsCourse(objprp);
        }
        public string DelcrsCourse(PRPSetupWeb objprp)
        {
            return obj.DelcrsCourse(objprp);
        }
        public PRPSetupWeb SelcrsCategory(PRPSetupWeb objprp)
        {
            return obj.SelcrsCategory(objprp);

        }
 //End Sub Course Catagory

    }
}
