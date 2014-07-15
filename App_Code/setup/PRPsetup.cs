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
namespace nmsSetup
{
    public class PRPSetup
    {
        string _id, _codeId,_AcdRequest_Id, _name,_sCountry,_sState,_sDist,_sCity, _mainLandMark, _address, _city, _district, _state, _phoneNo, _mobNo;

        string _JDrow, _JDJdID, _JDTitle, _JDSalary, _JDCategory, _JDFunctional_Area, _JDRole, _JDSkill, _JDRequired_Qualification, _JDJob_Description, _JDEmployer_Profile, _JDOrganisation_Name, _JDRecruiter_Name, _JDcollegeName, _JDcreatedby, _JDcreatedatetime, _JDcollegeEmailID, _JDcollegeAddress, _JDcollegeMobile, _JDcollegecreatedby, _JDcollegecollegeAddress, _JDcollegecollegeMobile, _JDcollegecreatetime, _JDInterested_Job_Type, _JDPassing_Year, _JDLanguage, _JDResume_Title;




        string _mailId, _DOJ, _security, _status, _isActive, _emailID;
        string _pageIndex, _pageSize, _srNo, _noOfRecord, _LoginType;
        string _designationId, _designationName, _designationStatus, _title, _description;

        string _DOB, _sex, _marital, _fatherName, _education, _Graduate, _ProfList, _Salary;
        string _AssociateId, _AssociateName, _branchId, _branchName, _Password, _pinCode, _sCategory, _subCategory, _sCollegeLogo, _Affiliated, _CourseLevel, _ApprovedBy;
        string _branchCode, _Query;

        string _urlId, _urlName, _urlPath, _urlPrntId, _rank, _grade, _faxNo, _courseName;

        string _specilization, _durationMinTime, _durationMaxTime, _eligibility,_pv, _nneEamil, _nneDaily;
        string _courseFees, _examFees, _otherFees, _regFees,_uniID , _catID,_semMode, _courseTime;

        string _enrolmentNo, _rollNo, _nneSMS, _otherLocation, _tutionType;

        string _bord, _level, _type, _category, _fullpath,_accutalPath;
        public string accutalPath { get { return _accutalPath; } set { _accutalPath = value; } }

        public string fullpath { get { return _fullpath; } set { _fullpath = value; } }
        public string bord { get { return _bord; } set { _bord = value; } }
        public string level { get { return _level; } set { _level = value; } }
        public string type { get { return _type; } set { _type = value; } }
        public string category { get { return _category; } set { _category = value; } }


        public string otherLocation { get { return _otherLocation; } set { _otherLocation = value; } }
        public string tutionType { get { return _tutionType; } set { _tutionType = value; } }


        public string rank { get { return _rank; } set { _rank = value; } }
        public string grade { get { return _grade; } set { _grade = value; } }

        public string nneEmail { get { return _nneEamil; } set { _nneEamil = value; } }
        public string nneDaily { get { return _nneDaily; } set { _nneDaily = value; } }

        public string nneSMS { get { return _nneSMS; } set { _nneSMS = value; } }

        public string faxNo { get { return _faxNo; } set { _faxNo = value; } }
        public string courseName { get { return _courseName; } set { _courseName = value; } }

        public string enrolmentNo { get { return _enrolmentNo; } set { _enrolmentNo = value; } }
        public string rollNo { get { return _rollNo; } set { _rollNo = value; } }
        
        public string specilization {get {return _specilization;} set { _specilization=value;}} 
        public string durationMinTime {get {return _durationMinTime;} set{ _durationMinTime=value;}}
        public string durationMaxTime {get { return _durationMaxTime;} set {_durationMaxTime=value;}}
        public string eligibility {get { return _eligibility;} set { _eligibility=value;}}
        public string pv {get {return _pv;} set {_pv=value;}}
        public string courseFees {get { return _courseFees;}set {_courseFees=value;}}    
        public string examFees {get {return _examFees;} set {_examFees=value;}}
        public string otherFees  { get {return _otherFees;} set { _otherFees=value;}}
        public string regFees { get {return _regFees;} set {_regFees =value;}} 
        public string uniID {get {return _uniID;} set { _uniID=value;}}
        public string catID { get { return _catID; } set { _catID = value; } }
        public string title { get { return _title; } set { _title = value; } }


        public string description { get { return _description; } set { _description = value; } }


        public string urlId { get { return _urlId; } set { _urlId = value; } }
        public string urlName { get { return _urlName; } set { _urlName = value; } }
        public string urlPath { get { return _urlPath; } set { _urlPath = value; } }
        public string urlPrntId { get { return _urlPrntId; } set { _urlPrntId = value; } }


        public string Query { get { return _Query; } set { _Query = value; } }

        public string DOB { get { return _DOB; } set { _DOB = value; } }
        public string branchCodeName { get { return _branchCode; } set { _branchCode = value; } }
        public string sex { get { return _sex; } set { _sex = value; } }
        public string marital { get { return _marital; } set { _marital = value; } }

        public string fatherName { get { return _fatherName; } set { _fatherName = value; } }
        public string education { get { return _education; } set { _education = value; } }
        public string Graduate { get { return _Graduate; } set { _Graduate = value; } }
        public string ProfList { get { return _ProfList; } set { _ProfList = value; } }
        public string Salary { get { return _Salary; } set { _Salary = value; } }
        public string AssociateId { get { return _AssociateId; } set { _AssociateId = value; } }
        public string AssociateName { get { return _AssociateName; } set { _AssociateName = value; } }
        public string branchId { get { return _branchId; } set { _branchId = value; } }
        public string branchName { get { return _branchName; } set { _branchName = value; } }
        public string Password { get { return _Password; } set { _Password = value; } }
        public string pinCode { get { return _pinCode; } set { _pinCode = value; } }

        public string sCategory { get { return _sCategory; } set { _sCategory = value; } }
        public string subCategory { get { return _subCategory; } set { _subCategory = value; } }
        public string sCollegeLogo { get { return _sCollegeLogo; } set { _sCollegeLogo = value; } }
        public string Affiliated { get { return _Affiliated; } set { _Affiliated = value; } }
        public string CourseLevel { get { return _CourseLevel; } set { _CourseLevel = value; } }
        public string ApprovedBy { get { return _ApprovedBy; } set { _ApprovedBy = value; } }
        

        public string pageIndex { get { return _pageIndex; } set { _pageIndex = value; } }
        public string pageSize { get { return _pageSize; } set { _pageSize = value; } }
        public string noOfRecord { get { return _noOfRecord; } set { _noOfRecord = value; } }
        public string LoginType { get { return _LoginType; } set { _LoginType = value; } }

        public string srNo { get { return _srNo; } set { _srNo = value; } }
        public string id { get { return _id; } set { _id = value; } }
        public string codeId { get { return _codeId; } set { _codeId = value; } }

        public string name { get { return _name; } set { _name = value; } }

        public string sCountry { get { return _sCountry; } set { _sCountry = value; } }
        public string sState { get { return _sState; } set { _sState = value; } }
        public string sDist { get { return _sDist; } set { _sDist = value; } }
        public string sCity { get { return _sCity; } set { _sCity = value; } }


        public string mainLandMark { get { return _mainLandMark; } set { _mainLandMark = value; } }
        public string address { get { return _address; } set { _address = value; } }
        public string city { get { return _city; } set { _city = value; } }
        public string district { get { return _district; } set { _district = value; } }
        public string state { get { return _state; } set { _state = value; } }
        public string phoneNo { get { return _phoneNo; } set { _phoneNo = value; } }
        public string mobNo { get { return _mobNo; } set { _mobNo = value; } }
        public string AcdRequest_Id { get { return _AcdRequest_Id; } set { _AcdRequest_Id = value; } }
        public string mailId { get { return _mailId; } set { _mailId = value; } }
        public string DOJ { get { return _DOJ; } set { _DOJ = value; } }
        public string security { get { return _security; } set { _security = value; } }
        public string status { get { return _status; } set { _status = value; } }
        public string isActive { get { return _isActive; } set { _isActive = value; } }
        public string emailID { get { return _emailID; } set { _emailID = value; } }

        public string semMode { get { return _semMode; } set { _semMode = value; } }
        public string courseTime { get { return _courseTime; } set { _courseTime = value; } }

        public string designationId { get { return _designationId; } set { _designationId = value; } }
        public string designationName { get { return _designationName; } set { _designationName = value; } }
        public string designationStatus { get { return _designationStatus; } set { _designationStatus = value; } }


        //--------------------------------------Deepak-----------------------------------------------------------------

        public string JDrow { get { return _JDrow; } set { _JDrow = value; } }
        public string JDJdID { get { return _JDJdID; } set { _JDJdID = value; } }
        public string JDTitle { get { return _JDTitle; } set { _JDTitle = value; } }
        public string JDSalary { get { return _JDSalary; } set { _JDSalary = value; } }
        public string JDCategory { get { return _JDCategory; } set { _JDCategory = value; } }
        public string JDFunctional_Area { get { return _JDFunctional_Area; } set { _JDFunctional_Area = value; } }
        public string JDRole { get { return _JDRole; } set { _JDRole = value; } }
        public string JDSkill { get { return _JDSkill; } set { _JDSkill = value; } }
        public string JDRequired_Qualification { get { return _JDRequired_Qualification; } set { _JDRequired_Qualification = value; } }
        public string JDJob_Description { get { return _JDJob_Description; } set { _JDJob_Description = value; } }
        public string JDEmployer_Profile { get { return _JDEmployer_Profile; } set { _JDEmployer_Profile = value; } }
        public string JDOrganisation_Name { get { return _JDOrganisation_Name; } set { _JDOrganisation_Name = value; } }
        public string JDRecruiter_Name { get { return _JDRecruiter_Name; } set { _JDRecruiter_Name = value; } }
        public string JDcollegeName { get { return _JDcollegeName; } set { _JDcollegeName = value; } }
        public string JDcreatedby { get { return _JDcreatedby; } set { _JDcreatedby = value; } }
        public string JDcreatedatetime { get { return _JDcreatedatetime; } set { _JDcreatedatetime = value; } }
        public string JDcollegeEmailID { get { return _JDcollegeEmailID; } set { _JDcollegeEmailID = value; } }
        public string JDcollegeAddress { get { return _JDcollegeAddress; } set { _JDcollegeAddress = value; } }
        public string JDcollegeMobile { get { return _JDcollegeMobile; } set { _JDcollegeMobile = value; } }




        public string JDInterested_Job_Type { get { return _JDInterested_Job_Type; } set { _JDInterested_Job_Type = value; } }
        public string JDPassing_Year { get { return _JDPassing_Year; } set { _JDPassing_Year = value; } }
        public string JDLanguage { get { return _JDLanguage; } set { _JDLanguage = value; } }
        public string JDResume_Title { get { return _JDResume_Title; } set { _JDResume_Title = value; } }
       // public string JDcollegecreatedby { get { return _JDcollegecreatedby; } set { _JDcollegecreatedby = value; } }
      
        
          //--------------------------------------Deepak-----------------------------------------------------------------



    }

    
    
    


}