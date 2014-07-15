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
namespace nmsSetupWeb
{
    public class PRPSetupWeb
    {
        string _id, _codeId, _name, _mainLandMark, _address, _city, _district, _state,_sCountry, _phoneNo, _mobNo;
        string _mailId, _DOJ, _security, _status, _isActive, _emailID;
        string _pageIndex, _pageSize, _srNo, _noOfRecord;
        string _designationId, _designationName, _designationStatus, _title, _description;

        Int32 _salarynum;

        string _DOB, _sex, _marital, _fatherName, _education, _Graduate, _ProfList, _Salary;
        string _AssociateId, _AssociateName, _branchId, _branchName, _Password, _pinCode;
        string _branchCode, _Query;

        string _urlId, _urlName, _urlPath, _urlPrntId, _rank, _grade;

        string _specilization, _durationMinTime, _durationMaxTime, _eligibility,_pv;
        string _courseFees, _examFees, _otherFees, _regFees,_uniID , _catID,_semMode, _courseTime;


        string _feesMode, _courseType, _courseMode, _scholarship;


        public Int32 salarynum { get { return _salarynum; } set { _salarynum = value; } }

        public string feeMode {get {return _feesMode;} set { _feesMode=value;}}
        public string courseType { get { return _courseType; } set { _courseType = value; } }
        public string courseMode { get { return _courseMode; } set { _courseMode = value; } }
        public string scholarship { get { return _scholarship; } set { _scholarship = value; } }


        public string rank { get { return _rank; } set { _rank = value; } }
        public string grade { get { return _grade; } set { _grade = value; } }
        
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

        public string pageIndex { get { return _pageIndex; } set { _pageIndex = value; } }
        public string pageSize { get { return _pageSize; } set { _pageSize = value; } }
        public string noOfRecord { get { return _noOfRecord; } set { _noOfRecord = value; } }

        public string srNo { get { return _srNo; } set { _srNo = value; } }
        public string id { get { return _id; } set { _id = value; } }
        public string codeId { get { return _codeId; } set { _codeId = value; } }

        public string name { get { return _name; } set { _name = value; } }
        public string mainLandMark { get { return _mainLandMark; } set { _mainLandMark = value; } }
        public string address { get { return _address; } set { _address = value; } }
        public string city { get { return _city; } set { _city = value; } }
        public string district { get { return _district; } set { _district = value; } }
        public string state { get { return _state; } set { _state = value; } }
        public string sCountry { get { return _sCountry; } set { _sCountry = value; } }
        public string phoneNo { get { return _phoneNo; } set { _phoneNo = value; } }
        public string mobNo { get { return _mobNo; } set { _mobNo = value; } }
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
    }

    
    
    


}