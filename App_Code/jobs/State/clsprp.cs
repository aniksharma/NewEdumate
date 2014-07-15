using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace nmsMovi
{ 
public class clsprpMovi
{
    private string _StateName,_StateDes,_IsActive,_ListBox,_CityName,_CityDes,_JobTitle,_JobDes,_CompanyName,_CompanyDes,_FunName,_FunDes,_FunRole,_FunRoleDes,_IndustryName,_IndustryDes,_InstituteName,_InstituteDes;
    private string _LocationName, _LocationDes,_SkillsName,_SkillsDes,_LangName,_LangDes,_QualificationName,_QualificationDes,_SplznName,_SplznDes;
    private int _CntryId,_stateId,_JobId,_CompanyId,_FunId,_FunRoleId,_IndustryId,_InstituteId,_LocationId,_SkillsId,_LangId,_QualId;

    public string blastjobid { get; set; }
    public string blastHeading { get; set; }
    public string blastBody { get; set; }

    public string detailProfileID { get; set; }
    public string detailBlastID { get; set; }
    public string detailMailStatus { get; set; }
    public string detailMailMessage { get; set; }


    public Int32 cityID { get; set; }
    public string byOrder { get; set; }


    public string mobileNoII { get; set; }
    public Int32 SpecializationID { get; set; }
    public Int32 JobSeekerID { get; set; }
    public string JobSeekerName { get; set; }
    public string JobSeekerMobile { get; set; }
    public string JobSeekerEmailId { get; set; }
    public string JobSeekerAddress { get; set; }

    public string JobSeekerPEmailId { get; set; }
    public string JobSeekerOEmailId { get; set; }
    public string JobSeekerCompany { get; set; }
    public string JobSeekerDOB { get; set; }
    public Int32 JobTitleID { get; set; }
    


    public string JobSeekerCurrentJob { get; set; }
        public string JobSeekerRemark { get; set; }
    public string job_totalPost { get; set; }

       public string Minsalary { get; set; }
    public string Maxsalary { get; set; }
    public string MinExprince { get; set; }
    public string MaxExprince { get; set; }


    public string contactName { get; set; }
    public string contactMobileNo { get; set; }
    public string contactEmailId { get; set; }
    public string contactDesignation { get; set; }

    public string jpd_First_Name { get; set; }
    public string JPD_Last_Name { get; set; }
    public string jpd_Mobile_No { get; set; }

    public string jpd_Date_Of_Birth { get; set; }
    public string jpd_Gender { get; set; }
    public Int32 JHQD_Specilization_Id { get; set; }
    public Int32 JWD_Total_Experience_Year { get; set; }
    public Int32 JWD_Total_Experience_Month { get; set; }
    public string JLD_Emial_Id { get; set; }
    public string JLD_password { get; set; }
    public string ms_Specelization_Description { get; set; }
    public string mobcode { get; set; }
    public Int32 JPD_City_Id { get; set; }

    public string SearchType { get; set; }


    public string startDate { get; set; }
    public string EndDate { get; set; }

    public string profile { get; set; }
    public string Descrption { get; set; }



    public string SpecializationName
    {
        get { return _SplznName; }
        set { _SplznName = value; }

    }
    public string SpecializationDescription
    {
        get { return _SplznDes; }
        set { _SplznDes = value; }
    }


    public string QualificationName
    {
        get { return _QualificationName; }
        set { _QualificationName = value; }
    }
    public string QualificationDes
    {
        get { return _QualificationDes; }
        set { _QualificationDes = value; }
    }
    public int QualId
    {
        get { return _QualId; }
        set { _QualId = value; }
    }
    public int LangId
    {
        get { return _LangId; }
        set { _LangId = value; }
    }
    public string LangName
    {
        get { return _LangName; }
        set { _LangName = value; }
    }
    public string LangDes
    {
        get { return _LangDes; }
        set { _LangDes = value; }
    }
    public string SkillsName
    {
        get { return _SkillsName; }
        set { _SkillsName = value; }
    }
    public string SkillsDes
    {
        get { return _SkillsDes; }
        set {_SkillsDes = value; }
    }
    public int SkillsId
    {
        get { return _SkillsId; }
        set { _SkillsId = value; }
    }
    public string StateName
    {
        get { return _StateName; }
        set { _StateName = value; }
    }
    public string StateDescription
    {
        get { return _StateDes; }
        set { _StateDes = value; }
    }
    public string IsActive
    {
        get { return _IsActive; }
        set { _IsActive = value; }
    }
    public int CountryId
    {
        get { return _CntryId; }
        set { _CntryId = value; }
    }
    public string ListBox
    {
        get { return _ListBox; }
        set { _ListBox = value; }
    }
    public string CityName
    {
        get { return _CityName; }
        set { _CityName = value; }

    }
    public string CityDescription
    {
        get { return _CityDes; }
        set { _CityDes = value; }
    }
    public string JobTitle
    {
        get { return _JobTitle; }
        set { _JobTitle = value; }

    }
    public string JobDescription
    {
        get { return _JobDes; }
        set { _JobDes = value; }
    }
    public string CompanyName
    {
        get { return _CompanyName; }
        set { _CompanyName = value; }
    }
    public string CompanyDescription
    {
        get { return _CompanyDes; }
        set { _CompanyDes = value;}
    }
    public int StateId
    {
        get { return _stateId; }
        set { _stateId = value; }
    }
    public int JobId
    {
        get { return _JobId; }
        set { _JobId = value; }
    }
    public int CompanyId
    {
        get { return _CompanyId; }
        set { _CompanyId = value; }

    }
    public string FunctionName
    {
        get { return _FunName; }
        set { _FunName = value; }
    }
    public string FunctionDescription
    {
        get { return _FunDes; }
        set { _FunDes = value; }
    }
    public int FunctionId
    {
        get { return _FunId; }
        set { _FunId = value; }
    }
    public string FunRole
    {
        get { return _FunRole; }
        set { _FunRole = value; }
    }
    public string FunctionRoleDescription
    {
        get { return _FunRoleDes; }
        set { _FunRoleDes = value; }
    }
    public int FunRoleId
    {
        get { return _FunRoleId; }
        set { _FunRoleId = value; }
    }
    public string IndustryName
    {
        get { return _IndustryName; }
        set { _IndustryName = value; }
    }
    public string IndustryDescription
    {
        get { return _IndustryDes; }
        set { _IndustryDes = value; }
    }
    public int IndustryId
    {
        get { return _IndustryId; }
        set { _IndustryId = value; }
    }
    public string InstituteName
    {
        get { return _InstituteName; }
        set { _InstituteName = value; }
    }
    public string InstituteDes
    {
        get { return _InstituteDes; }
        set { _InstituteDes = value; }
    }
    public int InstituteId
    {
        get { return _InstituteId; }
        set {_InstituteId=value; }
    }

    public string LocationName
    {
        get { return _LocationName; }
        set { _LocationName = value; }
    }
    public string LocationDes
    {
        get { return _LocationDes; }
        set { _LocationDes = value; }
    }
    public int LocationId
    {
        get { return _LocationId; }
        set { _LocationId = value; }
    }

    public string Company_Name { get; set; }
    public string Company_Tital_Name { get; set; }
    public string Registration_No { get; set; }
    public string Phone_No { get; set; }
    public string Personale_Details_Id { get; set; }
    public string Company_Address { get; set; }
    public string City_Id { get; set; }
    public string Company_Email_Id { get; set; }
    public string Company_Type_Id { get; set; }
    public string Company_Img_Url { get; set; }
    public string Employee_Designation { get; set; }
    public string Created_Date { get; set; }
    public string Updated_date { get; set; }
    public string Company_IsActive { get; set; }
    public string company_serviceOffers { get; set; }
    public string company_Description { get; set; }
    public string company_LogoForHome { get; set; }
    public string company_phoneNo { get; set; }
    public string company_ContactPerson { get; set; }
    public string company_emailId { get; set; }
    public string company_website { get; set; }
}
}