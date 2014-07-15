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
using nmsSetup;
namespace nmsSetup
{
    public class clsBLSetup
    {
        clsDLSetup obj = new clsDLSetup();
//--start university.

        public List<PRPSetup> ViewCarrier1(PRPSetup prp)
        {
            return obj.ViewCarrier1(prp);
        }
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
        public List<PRPSetup> ViewAcdRequestDetail(PRPSetup objprp)
        {
            return obj.ViewAcdRequestDetail(objprp);
        }
        public string DeleteAcdRequst(PRPSetup objprp)
        {
            return obj.DeleteAcdRequst(objprp);
        }
        public List<PRPSetup> ViewJobDetails(PRPSetup objprp)
        {
            return obj.ViewJobDetails(objprp);
        }
        public string DeleteJobDetails(PRPSetup objprp)
        {
            return obj.DeleteJobDetails(objprp);
        }

        public List<PRPSetup> ViewJobProfile(PRPSetup objprp)
        {
            return obj.ViewJobProfile(objprp);
        }
//--End university.

 //---start Enquiry form--------
        //public string InsertEnquiry(PRPSetup objprp)
        //{
        //    return obj.InsertEnquiry(objprp);
        //}
        //public List<PRPSetup> viewEnquiry(PRPSetup objprp)
        //{
        //    return obj.viewEnquiry(objprp);
        //}
 //----End Enquiry form----------

 //News For Start

        public List<PRPSetup> ViewUniversityTypeWithParamater(PRPSetup objprp)
        {
            return obj.ViewUniversityTypeWithParamater(objprp);
        } 
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

        public List<PRPSetup> viewNewsFor()
        {
            return obj.viewNewsFor();

        }

//News For End

 //Authorisation Start

        public List<PRPSetup> BindUniforAuth(PRPSetup objprp)
        {
            return obj.BindUniforAuth(objprp);
        }
        public List<PRPSetup> CheckUniByBranch(PRPSetup objprp)
        {
            return obj.CheckUniByBranch(objprp);
        }
        public string InsertAuthBranch(PRPSetup objprp)
        {
            return obj.InsertAuthBranch(objprp);
        }
        public List<PRPSetup> BindByAuthorisation(PRPSetup prp)
        {
            return obj.BindByAuthorisation(prp);
        }
        public List<PRPSetup> BindUniInRepitor(PRPSetup prp)
        {
            return obj.BindUniInRepitor(prp);
        }
        public string DelAuthorisation(PRPSetup objprp)
        {
            return obj.DelAuthorisation(objprp);
        }
//Authorisation End

 //--Start Notification.
        public List<PRPSetup> ViewAdmissionNotification(PRPSetup objprp)
        {
            return obj.ViewAdmissionNotification(objprp);
        }
        public string updAdmissionNotification(PRPSetup objprp)
        {
            return obj.updAdmissionNotification(objprp);
        }
 //--End Notification.



//Set Roll No Series.
        public string insSetRollNoSeries(PRPSetup objprp)
        {
            return obj.insSetRollNoSeries(objprp);
        }
        public List<PRPSetup> viewSetRollNoSeries(PRPSetup prp)
        {
            return obj.viewSetRollNoSeries(prp);
        }
        public PRPSetup selSetRollNoSeries(PRPSetup objprp)
        {
            return obj.selSetRollNoSeries(objprp);
        }
        public string delSetRollNoSeries(PRPSetup objprp)
        {
            return obj.delSetRollNoSeries(objprp);
        }
//End Roll No Series.

//--Start Set Agent Comm University wise.
        public String InsertAgentComm(PRPSetup objprp)
        {
            return obj.InsertAgentComm(objprp);
        }
        //public string InsertAuthBranch(PRPSetup objprp)
        //{
        //    return obj.InsertAuthBranch(objprp);
        //}
        public List<PRPSetup> viewAgentCommDetail(PRPSetup prp)
        {
            return obj.viewAgentCommDetail(prp);
        }
        public List<PRPSetup> viewAgentCommDetail1(PRPSetup prp)
        {
            return obj.viewAgentCommDetail1(prp);
        }
     
//--End Set Agent Comm University wise.

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



//-- Set News Panel Wise
        public String InsShowInBranch(PRPSetup objprp)
        {
            return obj.InsShowInBranch(objprp);
        }

        public List<PRPSetup> viewShowInBranch(PRPSetup objprp)
        {
            return obj.viewShowInBranch(objprp);
        }

        public List<PRPSetup> viewShowInBranch1(PRPSetup objprp)
        {
            return obj.viewShowInBranch1(objprp);
        }

        public List<PRPSetup> viewNewsInBranch(PRPSetup objprp)
        {
            return obj.viewNewsInBranch(objprp);
        }



//--End News Panle Wise


//--start university Web.
        public string InsertUniversityWeb(PRPSetup objprp)
        {
            return obj.InsertUniversityWeb(objprp);
        }
        public string UpdateUniversityWeb(PRPSetup objprp)
        {
            return obj.UpdateUniversityWeb(objprp);
        }
        public string DeleteUniversityWeb(PRPSetup objprp)
        {
            return obj.DeleteUniversityWeb(objprp);
        }
        public PRPSetup SelectUniversityWeb(PRPSetup objprp)
        {
            return obj.SelectUniversityWeb(objprp);
        }
        public List<PRPSetup> ViewUniversityWeb(PRPSetup objprp)
        {
            return obj.ViewUniversityWeb(objprp);
        }
        public List<PRPSetup> ViewUniversityType( PRPSetup objprp )
        {
            return obj.ViewUniversityType(objprp);
        }

      

        //--End university Web.
        #region Bind Tutor SubCategory

        public List<PRPSetup> ViewTutorSubcategoryTypeWithParamater(PRPSetup objprp)
        {
            return obj.ViewTutorSubcategoryTypeWithParamater(objprp);
        } 
        #endregion
        //--start university Web.
        public string InsertCollegeDetail(PRPSetup objprp)
        {
            return obj.InsertCollegeDetail(objprp);
        }
        public string UpdateCollegeDetail(PRPSetup objprp)
        {
            return obj.UpdateCollegeDetail(objprp);
        }

        public string UpdateCollegeWebSite(PRPSetup objprp)
        {
            return obj.UpdateCollegeWebSite(objprp);
        }


        public string DeleteCollegeDetail(PRPSetup objprp)
        {
            return obj.DeleteCollegeDetail(objprp);
        }
        public PRPSetup SelectStudDetail(PRPSetup objprp)
        {
            return obj.SelectStudDetail(objprp);
        }

        public PRPSetup SelectStudDetail1(PRPSetup objprp)
        {
            return obj.SelectStudDetail1(objprp);
        }
        public PRPSetup SelectTutorDetail(PRPSetup objprp)
        {
            return obj.SelectTutorDetail(objprp);
        }


        public PRPSetup SelectCollegeDetail(PRPSetup objprp)
        {
            return obj.SelectCollegeDetail(objprp);
        }
        public DataSet SelectCollegeDetail_sal(PRPSetup objprp)
        {
            return obj.SelectCollegeDetail_sal(objprp);
        }
        public DataSet SelectCollegeDetailWithDataset(PRPSetup objprp)
        {
            return obj.SelectCollegeDetailWithDataset(objprp);
        }

        public List<PRPSetup> ViewCollegeDetail(PRPSetup objprp)
        {
            return obj.ViewCollegeDetail(objprp);
        }
        //public List<PRPSetup> ViewCollegeType()
        //{
        //    return obj.ViewCollegeType();
        //}
//--End university Web.
//-----

        //public string InsertTeacherDetail(PRPSetup objprp)
        //{
        //    return obj.InsertTeacherDetail(objprp);
        //}
        //






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

        public List<PRPSetup> crsViewAllSubCategoryByName1(PRPSetup prp)
        {
            return obj.crsViewAllSubCategoryByName1(prp);
        }
        public List<PRPSetup> crsViewAllSubCategory1(PRPSetup prp)
        {
            return obj.crsViewAllSubCategory1(prp);
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

        //--Start Text Editor.
        public string InsTextWeb(PRPSetup objprp)
        {
            return obj.InsTextWeb(objprp);
        }
        public string UpdTextWeb(PRPSetup objprp)
        {
            return obj.UpdTextWeb(objprp);
        }
        public string DelTextWeb(PRPSetup objprp)
        {
            return obj.DelTextWeb(objprp);
        }
        public PRPSetup SelTextWeb(PRPSetup objprp)
        {
            return obj.SelTextWeb(objprp);
        }
        public PRPSetup SelTextWeb1(PRPSetup objprp)
        {
            return obj.SelTextWeb1(objprp);
        }
        public List<PRPSetup> ViewTextWeb(PRPSetup prp)
        {
            return obj.ViewTextWeb(prp);
        }

        public List<PRPSetup> ViewTextWeb1(PRPSetup prp)
        {
            return obj.ViewTextWeb1(prp);
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


//--Start Text Category Web.
        public string InsTextCategoryWeb(PRPSetup objprp)
        {
            return obj.InsTextCategoryWeb(objprp);
        }
        public string UpdTextCategoryWeb(PRPSetup objprp)
        {
            return obj.UpdTextCategoryWeb(objprp);

        }
        public string DelTextCategoryWeb(PRPSetup objprp)
        {

            return obj.DelTextCategoryWeb(objprp);

        }
        public PRPSetup SelTextCategoryWeb(PRPSetup objprp)
        {
            return obj.SelTextCategoryWeb(objprp);
        }
        public DataTable ViewTextCategoryWeb(PRPSetup objprp)
        {
            return obj.ViewTextCategoryWeb(objprp);
        }
//--End Text Category Web.


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

//--Start UniversityType
        public string InsUniversityType(PRPSetup objprp)
        {
            return obj.InsUniversityType(objprp);
        }
        public string UpdUniversityType(PRPSetup objprp)
        {
            return obj.UpdUniversityType(objprp);
        }
        public string DelUniversityType(PRPSetup objprp)
        {
            return obj.DelUniversityType(objprp);
        }
        public PRPSetup SelUniversityType(PRPSetup objprp)
        {
            return obj.SelUniversityType(objprp);
        }

//--End UniversityType

//--Start College Type
        public string InsCollegeType(PRPSetup objprp)
        {
            return obj.InsCollegeType(objprp);
        }
        public string UpdCollegeType(PRPSetup objprp)
        {
            return obj.UpdCollegeType(objprp);
        }
        public string DelCollegeType(PRPSetup objprp)
        {
            return obj.DelCollegeType(objprp);
        }
        public PRPSetup SelCollegeType(PRPSetup objprp)
        {
            return obj.SelCollegeType(objprp);
        }
        public List<PRPSetup> ViewCollegeType(PRPSetup objprp)
        {
            return obj.ViewCollegeType(objprp);
        }

        public List<PRPSetup> ViewCollegeType1(PRPSetup objprp)
        {
            return obj.ViewCollegeType1(objprp);
        }



//--End College Type


//--Start Course Type
        public string InsCourseType(PRPSetup objprp)
        {
            return obj.InsCourseType(objprp);
        }
        public string UpdCourseType(PRPSetup objprp)
        {
            return obj.UpdCourseType(objprp);
        }
        public string DelCourseType(PRPSetup objprp)
        {
            return obj.DelCourseType(objprp);
        }
        public PRPSetup SelCourseType(PRPSetup objprp)
        {
            return obj.SelCourseType(objprp);
        }

//--End Course  Type

//--Start EducationType
        public string InsEducationType(PRPSetup objprp)
        {
            return obj.InsEducationType(objprp);
        }
        public string UpdEducationType(PRPSetup objprp)
        {
            return obj.UpdEducationType(objprp);
        }
        public string DelEducationType(PRPSetup objprp)
        {
            return obj.DelEducationType(objprp);
        }
        public PRPSetup SelEducationType(PRPSetup objprp)
        {
            return obj.SelEducationType(objprp);
        }

        //--End EducationType
        #region School Category

        public string InsSchoolCategory(PRPSetup objprp)
        {
            return obj.InsSchoolCategory(objprp);
        }

        public string UpdSchoolCategory(PRPSetup objprp)
        {
            return obj.UpdSchoolCategory(objprp);
        }



        public PRPSetup SelSchoolCategory(PRPSetup objprp)
        {
            return obj.SelSchoolCategory(objprp);
        }


        public string DelSchoolCategory(PRPSetup objprp)
        {
            return obj.DelSchoolCategory(objprp);
        }


        #endregion


        #region School Sub Category
        //public string InsState(PRPSetup objprp)
        //{
        //    return obj.InsState(objprp);
        //}
        public string UpdSchoolSubCat(PRPSetup objprp)
        {
            return obj.UpdSchoolSubCat(objprp);
        }
        public string DelSchoolSubCat(PRPSetup objprp)
        {
            return obj.DelSchoolSubCat(objprp);
        }
        public PRPSetup SelSchoolSubCat(PRPSetup objprp)
        {
            return obj.SelSchoolSubCat(objprp);
        }



        #endregion

        ///

//--Start State
        public string InsCountry(PRPSetup objprp)
        {
            return obj.InsCountry(objprp);
        }
        public string UpdCountry(PRPSetup objprp)
        {
            return obj.UpdCountry(objprp);
        }
        public string DelCountry(PRPSetup objprp)
        {
            return obj.DelCountry(objprp);
        }
        public PRPSetup SelCountry(PRPSetup objprp)
        {
            return obj.SelCountry(objprp);
        }
//--End State



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

        public List<PRPSetup> ViewTextWeb11(PRPSetup prp)
        {
            return obj.ViewTextWeb11(prp);
        }

        public List<PRPSetup> bindUniversityData(PRPSetup objprp)
        {
            return obj.bindUniversityData(objprp);
        }


        public List<PRPSetup> ViewCarrier(PRPSetup prp)
        {
            return obj.ViewCarrier(prp);
        }

        //10-30
        public string InsEducationBoard(PRPSetup objprp)
        {
            return obj.InsEducationBoard(objprp);
        }
        public string UpdEducationBoard(PRPSetup objprp)
        {
            return obj.UpdEducationBoard(objprp);
        }
        public string DelEducationBoard(PRPSetup objprp)
        {
            return obj.DelEducationBoard(objprp);
        }
        public PRPSetup SelEducationBoard(PRPSetup objprp)
        {
            return obj.SelEducationBoard(objprp);
        }
        public List<PRPSetup> ViewEducationBoard(PRPSetup prp)
        {
            return obj.ViewEducationBoard(prp);
        }



        public DataSet mastercommon()
        {
            return obj.mastercommon();
        }

        public DataSet Defaultcommon()
        {
            return obj.Defaultcommon();
        }


        //12-3-12
        public string InsCommission(PRPSetup objprp)
        {
            return obj.InsCommission(objprp);
        }
        public string UpdCommission(PRPSetup objprp)
        {
            return obj.UpdCommission(objprp);
        }
        public List<PRPSetup> ViewCommission(PRPSetup prp)
        {
            return obj.ViewCommission(prp);
        }
        public PRPSetup SelCommission(PRPSetup objprp)
        {
            return obj.SelCommission(objprp);
        }
        public string DelCommission(PRPSetup objprp)
        {
            return obj.DelCommission(objprp);
        }
        public string InsinfopartnerReference(PRPSetup objprp)
        {
            return obj.InsinfopartnerReference(objprp);
        }
        public List<PRPSetup> BindinfopartnerReference(PRPSetup prp)
        {
            return obj.BindinfopartnerReference(prp);
        }


        public string InsertPartnerPaymentDetail(PRPSetup objprp)
        {
            return obj.InsertPartnerPaymentDetail(objprp);
        }
        public List<PRPSetup> ViewPartnerPaymentDetail(PRPSetup objprp)
        {
            return obj.ViewPartnerPaymentDetail(objprp);
        }

        public PRPSetup SelectPartnerPaymentDetail(PRPSetup objprp)
        {
            return obj.SelectPartnerPaymentDetail(objprp);
        }

        public string UpdPartnerPaymentDetail(PRPSetup objprp)
        {
            return obj.UpdPartnerPaymentDetail(objprp);
        }

        public string updatePartnerPaymentDetail1(PRPSetup objprp)
        {
            return obj.updatePartnerPaymentDetail1(objprp);
        }

        public string InsFlocation(PRPSetup objprp)
        {
            return obj.InsFlocation(objprp);
        }

//...College Inquery.

        public List<PRPSetup> ViewCollegeInqueryDetail(PRPSetup objprp)
        {
            return obj.ViewCollegeInqueryDetail(objprp);
        }

        public List<PRPSetup> ViewRegistrationDetail(PRPSetup objprp)
        {
            return obj.ViewRegistrationDetail(objprp);
        }
        public string DelCollegeInqueryDetail(PRPSetup objprp)
        {
            return obj.DelCollegeInqueryDetail(objprp);
        }

        public List<PRPSetup> ViewNews2(PRPSetup prp)
        {
            return obj.ViewNews2(prp);
        }
        public DataSet spMenuForMicro(PRPSetup objprp)
        {
            return obj.spMenuForMicro(objprp);
        }
    }
}
