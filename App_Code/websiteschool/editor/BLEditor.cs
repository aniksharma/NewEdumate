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
using nmsADOI;

namespace nmsEditor
{
    public class clsBLEditor
    {
        clsDLEditor obj = new clsDLEditor();

        public string userLayout(prpImagePlan objprp)
        {
            return obj.userLayout(objprp);
        }

        public string spTempLayout(prpImagePlan objprp)
        {
            return obj.spTempLayout(objprp);
        }


        public string spTempUser(prpImagePlan objprp)
        {
            return obj.spTempUser(objprp);
        }

        public DataTable spSelectTemplateById(prpImagePlan objprp)
        {
            return obj.spSelectTemplateById(objprp);
        }
        public string userTempate(prpImagePlan objprp)
        {
            return obj.userTempate(objprp);
        }

        public string InsertPlanImage(prpImagePlan objprp)
        {
            return obj.InsertPlanImage(objprp);
        }

        public string UpdatePlanImage(prpImagePlan objprp)
        {
            return obj.UpdatePlanImage(objprp);
        }

        public string DeletePlanImage(prpImagePlan objprp)
        {
            return obj.DeletePlanImage(objprp);
        }

        public List<prpImagePlan> viewPlanImage()
        {
            return obj.viewPlanImage();

        }

        public prpImagePlan selectImagePlanByImageId(prpImagePlan objprp)
        {
            return obj.selectImagePlanByImageId(objprp);

        }

        public prpImagePlan selectImagePlanByPlanId(prpImagePlan objprp)
        {
            return obj.selectImagePlanByPlanId(objprp);

        }

        public prpImagePlan selectImagePlanByPlanIdForFront(prpImagePlan objprp)
        {
            return obj.selectImagePlanByPlanIdForFront(objprp);

        }


        public string InsertEditorData(PRPEditor objprp)
        {
            return obj.InsertEditorData(objprp);
        }

        public string UpdateEditorData(PRPEditor objprp)
        {
            return obj.UpdateEditorData(objprp);
        }


        public string DeleteEditorData(PRPEditor objprp)
        {
            return obj.DeleteEditorData(objprp);
        }


        public string addedMobileNo(PRPEditor objprp)
        {
            return obj.addedMobileNo(objprp);
        }

        public string selectMobileNo()
        {
            return obj.selectMobileNo();
        }

        public PRPEditor SelectEditorData(PRPEditor objprp)
        {
            return obj.SelectEditorData(objprp);
        
        }

        public List<PRPEditor> viewEditorData()
        {
            return obj.viewEditorData();
        
        }


        public string CheckLogin(PRPEditor objprp)
        {
            return obj.CheckLogin(objprp);
        }

        public string UpdatePassword(PRPEditor objprp)
        {
            return obj.UpdatePassword(objprp);
        }


        public string InsertNews(PRPEditor objprp)
        {
            return obj.InsertNews(objprp);
        }
        public string UpdateNews(PRPEditor objprp)
        {
            return obj.UpdateNews(objprp);
        }
        public string DeleteNews(PRPEditor objprp)
        {
            return obj.DeleteNews(objprp);
        }

        public PRPEditor selectNews(PRPEditor objprp)
        {
            return obj.SelectNews(objprp);
        }

        public List<PRPEditor> viewNews1()
        {
            return obj.ViewNews1();
        }


        public DataTable ViewNews()
        {
            return obj.ViewNews();
        }

        public DataTable spTemplateSelect()
        {
            return obj.spTemplateSelect();
        }

        public string insertFeedBack(PRPEditor objprp)
        {
            return obj.insertFeedBack(objprp);
        }


        public DataTable viewFeedback(PRPEditor objprp)
        {
            return obj.viewFeedback(objprp);
        }



        public string InsertFeatures(PRPEditor objprp)
        {
            return obj.InsertFeatures(objprp);
        }
        public string UpdateFeatures(PRPEditor objprp)
        {
            return obj.UpdateFeatures(objprp);
        }
        public string DeleteFeatures(PRPEditor objprp)
        {
            return obj.DeleteFeatures(objprp);
        }

        public PRPEditor SelectFeatures(PRPEditor objprp)
        {
            return obj.SelectFeatures(objprp);
        }
        public List<PRPEditor> ViewFeatures()
        {
            return obj.ViewFeatures1();
        }
       public DataTable ViewFeatures1()
        {
            return obj.ViewFeatures();
        }


       public string InsertCourse(PRPEditor objprp)
       {
           return obj.InsertCourse(objprp);
       }
       public string UpdateCourse(PRPEditor objprp)
       {
           return obj.UpdateCourse(objprp);
       }
       public string DeleteCourse(PRPEditor objprp)
       {
           return obj.DeleteCourse(objprp);
       }

       public PRPEditor SelectCourse(PRPEditor objprp)
       {
           return obj.SelectCourse(objprp);
       }
       public List<PRPEditor> ViewCourse()
       {
           return obj.ViewCourse1();
       }
       public DataTable ViewCourse1()
       {
           return obj.ViewCourse();
       }



       public string InsertStudent(PRPStudent objprp)
       {
           return obj.InsertStudent(objprp);
       }
    //-----------------image gellary work -----------------------//
       
        public string GetMaxCategoryID()
       {
           return obj.GetMaxCategoryID();
       }
        public string spGetProductMaxId()
        {
            return obj.spGetProductMaxId();
        }

        public string spGetStaffMaxId()
        {
            return obj.spGetStaffMaxId();
        }



        public string GetMaxPropertyOfID()
        {
            return obj.GetMaxPropertyOfID();
        }


        public string GetMaxFileId()
        {
            return obj.GetMaxFileId();
        }

       public string InsertImageGallery(PRPPImageGellery objprp)
       {
           return obj.InsertImageGallery(objprp);
       }


       public string spInssertWebProduct(PRPPImageGellery objprp)
       {
           return obj.spInssertWebProduct(objprp);
       }


       public string spUpdateWebProduct(PRPPImageGellery objprp)
       {
           return obj.spUpdateWebProduct(objprp);
       }
       public string UpdateImageGallery(PRPPImageGellery objprp)
       {
           return obj.UpdateImageGallery(objprp);
       }
       public string DeleteImageGallery(PRPPImageGellery objprp)
       {
           return obj.DeleteImageGallery(objprp);
       }


       public string spdeletewebProduct(PRPPImageGellery objprp)
       {
           return obj.spdeletewebProduct(objprp);
       }

       public PRPPImageGellery SelectImageGallery(PRPPImageGellery objprp)
       {
           return obj.SelectImageGallery(objprp);
       }


       public PRPPImageGellery spwebProductById(PRPPImageGellery objprp)
       {
           return obj.spwebProductById(objprp);
       }


        
       public List<PRPPImageGellery> viewImageGalleryList()
       {
           return obj.viewImageGalleryList();
       }


       public List<PRPPImageGellery> viewImageGalleryShow()
       {
           return obj.viewImageGalleryShow();
       }

       public DataTable viewImageGallery()
       {
           return obj.viewImageGallery();
       }
   //-----------------------------------------------------------//
        //---------------Loction ----------------------------------//

       public DataTable spShowHotproperty()
       {
           return obj.spShowHotproperty();
       }
        //--------------End-Loction ----------------------------------//




        //-------------------------caloney Info-----------------------------------//
       public string InsertCaloney(PRPPImageGellery objprp)
       {
           return obj.InsertCaloney(objprp);
       }
       public string UpdateCaloney(PRPPImageGellery objprp)
       {
           return obj.UpdateCaloney(objprp);
       }
       public string DeleteCaloney(PRPPImageGellery objprp)
       {
           return obj.DeleteCaloney(objprp);
       }

       public PRPPImageGellery selectCaloney(PRPPImageGellery objprp)
       {
           return obj.SelectCaloney(objprp);
       }

       public List<PRPPImageGellery> viewCaloney1(PRPPImageGellery objprp)
       {
           return obj.ViewCaloney1(objprp);
       }

       public List<PRPPImageGellery> viewImageGalleryShowByStudent(PRPPImageGellery objprp)
       {
           return obj.viewImageGalleryShowByStudent(objprp);
       }

       public List<PRPPImageGellery> viewImageGalleryShowByCaloneyId(PRPPImageGellery objprp)
       {
           return obj.viewImageGalleryShowByCaloneyId(objprp);
       }

       public List<PRPPImageGellery> spImageGalleryshowByCaloneyId_sal(PRPPImageGellery objprp)
       {
           return obj.spImageGalleryshowByCaloneyId_sal(objprp);
       }


       public List<PRPPImageGellery> spwebProductBySchool(PRPPImageGellery objprp)
       {
           return obj.spwebProductBySchool(objprp);
       }


        

       public List<PRPPImageGellery> spImageGalleryshowByCaloneyIdtop5(PRPPImageGellery objprp)
       {
           return obj.spImageGalleryshowByCaloneyIdtop5(objprp);
       }

       public List<PRPPImageGellery> homepageAllWeb(PRPPImageGellery objprp)
       {
           return obj.homepageAllWeb(objprp);
       }
    
        
        //----------------------end---caloney Info-----------------------------------//


       //-------------------------PropertyType Info-----------------------------------//
       public string InsertPropertyType(PRPPImageGellery objprp)
       {
           return obj.InsertPropertyType(objprp);
       }
       public string UpdatePropertyType(PRPPImageGellery objprp)
       {
           return obj.UpdatePropertyType(objprp);
       }
       public string DeletePropertyType(PRPPImageGellery objprp)
       {
           return obj.DeletePropertyType(objprp);
       }

       public PRPPImageGellery selectPropertyType(PRPPImageGellery objprp)
       {
           return obj.SelectPropertyType(objprp);
       }

       public List<PRPPImageGellery> viewPropertyType1()
       {
           return obj.ViewPropertyType1();
       }
        //----------------------end---PropertyType Info-----------------------------------//



       //-------------------------Location Info-----------------------------------//
       public string InsertLocation(PRPPImageGellery objprp)
       {
           return obj.InsertLocation(objprp);
       }
       public string UpdateLocation(PRPPImageGellery objprp)
       {
           return obj.UpdateLocation(objprp);
       }
       public string DeleteLocation(PRPPImageGellery objprp)
       {
           return obj.DeleteLocation(objprp);
       }

       public PRPPImageGellery selectLocation(PRPPImageGellery objprp)
       {
           return obj.SelectLocation(objprp);
       }

       public List<PRPPImageGellery> viewLocation()
       {
           return obj.ViewLocation1();
       }
       //----------------------end---Location Info-----------------------------------//



       //-------------------------Tenant Info-----------------------------------//
       public string InsertTenantType(PRPPImageGellery objprp)
       {
           return obj.InsertTenantType(objprp);
       }
       public string UpdateTenantType(PRPPImageGellery objprp)
       {
           return obj.UpdateTenantType(objprp);
       }
       public string DeleteTenantType(PRPPImageGellery objprp)
       {
           return obj.DeleteTenantType(objprp);
       }

       public PRPPImageGellery selectTenant(PRPPImageGellery objprp)
       {
           return obj.SelectTenantType(objprp);
       }

       public List<PRPPImageGellery> viewTenant1()
       {
           return obj.ViewTenantType1();
           
       }
        //----------------------end---PropertyType Info-----------------------------------//



       public string InsertBuyer(PRPProfile objprp)
       {
           return obj.InsertBuyer(objprp);
       }


       public string updateBuyer(PRPProfile objprp)
       {
           return obj.updateBuyer(objprp);
       }

       public List<PRPProfile> ViewSellerDetail(PRPProfile objprp)
       {
           return obj.ViewSellerDetail(objprp);
       }



       public PRPProfile SelectSellerById(PRPPImageGellery objprp)
       {
           return obj.SelectSellerById(objprp);
       }


    //-----------------------------------------------------------------------------------//
       public string InsertdocFile(PRPPImageGellery objprp)
       {
           return obj.InsertDocmentFile(objprp);
       }
       public string UpdatedocFile(PRPPImageGellery objprp)
       {
           return obj.UpdateDocmentFile(objprp);
       }
       public string DeletedocFile(PRPPImageGellery objprp)
       {
           return obj.DeleteDocmentFile(objprp);
       }

       public PRPPImageGellery selectdocFile(PRPPImageGellery objprp)
       {
           return obj.SelectDocmentFile(objprp);
       }

       public List<PRPPImageGellery> viewdocFile1(PRPPImageGellery objpr)
       {
           return obj.ViewDocmentFile1(objpr);
       }


       public DataTable ViewdocFile()
       {
           return obj.ViewDocmentFile();
       }

        //-----------------------------------------------------------------------------------//

       //-----------------------------------------------------------------------------------//
       public string InsertAvailability(PRPPImageGellery objprp)
       {
           return obj.InsertAvailability(objprp);
       }
       public string UpdateAvailability(PRPPImageGellery objprp)
       {
           return obj.UpdateAvailability(objprp);
       }
       public string DeleteAvailability(PRPPImageGellery objprp)
       {
           return obj.DeleteAvailability(objprp);
       }

       public PRPPImageGellery selectAvailability(PRPPImageGellery objprp)
       {
           return obj.SelectAvailability(objprp);
       }

       public List<PRPPImageGellery> viewAvailability1()
       {
           return obj.ViewAvailability1();
       }


       public DataTable ViewAvailability()
       {
           return obj.ViewAvailability();
       }

        //-----------------------------------------------------------------------------------//
       //-----------------------------------------------------------------------------------//
       public string InsertPropertyOfTheDay(PRPPImageGellery objprp)
       {
           return obj.InsertPropertyOfTheDay(objprp);
       }
       public string UpdatePropertyOfTheDay(PRPPImageGellery objprp)
       {
           return obj.UpdatePropertyOfTheDay(objprp);
       }
       public string DeletePropertyOfTheDay(PRPPImageGellery objprp)
       {
           return obj.DeletePropertyOfTheDay(objprp);
       }
       public PRPPImageGellery selectPropertyOfTheDay(PRPPImageGellery objprp)
       {
           return obj.SelectPropertyOfTheDay(objprp);
       }
       public List<PRPPImageGellery> viewPropertyOfTheDay1()
       {
           return obj.ViewPropertyOfTheDay1();
       }
       public List<PRPPImageGellery> ViewPropertyOfTheDayHomeByList()
       {
           return obj.ViewPropertyOfTheDayHomeByList();
       }
       public DataTable ViewPropertyOfTheDay()
       {
           return obj.ViewPropertyOfTheDay();
       }
       public DataTable ViewPropertyOfTheDayHome()
       {
           return obj.ViewPropertyOfTheDayHome();
       }
       public DataTable spImageDetail()
       {
           return obj.spImageDetail();
       }

       public string DeleleSellerDetail(PRPEditor objprp)
       {
           return obj.DeleleSellerDetail(objprp);
       }

       public DataTable spQuickBind(PRPEditor objprp)
       {
           return obj.spQuickBind(objprp);
       }

       public DataSet spMenuForMicro(PRPEditor objprp)
       {
           return obj.spMenuForMicro(objprp);
       }
       public DataSet spMenuForMicro_srikant_sal_stu(PRPEditor objprp)
       {
           return obj.spMenuForMicro_srikant_sal_stu(objprp);
       }
// Start Title tag Micro.
       public string insTitlePageWiseMicro(PRPPImageGellery objprp)
       {
           return obj.insTitlePageWiseMicro(objprp);
       }
      
       public PRPPImageGellery selTitlePageWiseMicro(PRPPImageGellery objprp)
       {
           return obj.selTitlePageWiseMicro(objprp);
       }

       
 // End Title Tag Micro.

// Start Meta tag Micro.
       public string insMetaPageWiseMicro(PRPPImageGellery objprp)
       {
           return obj.insMetaPageWiseMicro(objprp);
       }
       public string updMetaPageWiseMicro(PRPPImageGellery objprp)
       {
           return obj.updMetaPageWiseMicro(objprp);
       }
       public string delMetaPageWiseMicro(PRPPImageGellery objprp)
       {
           return obj.delMetaPageWiseMicro(objprp);
       }

       public PRPPImageGellery selMetaPageWiseMicro(PRPPImageGellery objprp)
       {
           return obj.selMetaPageWiseMicro(objprp);
       }

       public List<PRPPImageGellery> viewMetaPageWiseMicro(PRPPImageGellery objpram)
       {
           return obj.viewMetaPageWiseMicro(objpram);
       }
 // End Meta Tag Micro.

       //--Start Enquiry form-------------------
       public string InsertEnquiry(PRPEditor objprp)
       {
           return obj.InsertEnquiry(objprp);
       }
       public string UpdateEnquiry(PRPEditor objprp)
       {
           return obj.UpdateEnquiry(objprp);
       }
       public List<PRPEditor> viewEnquiry(PRPEditor prp)
       {

           return obj.viewEnquiry(prp);
       }
       public string DelEnquiry(PRPEditor prp)
       {
           return obj.DelEnquiry(prp);
       }
        //----End Enquiry form----------------


    }
}


