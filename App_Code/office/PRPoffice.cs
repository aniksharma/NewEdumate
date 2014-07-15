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

namespace nmsOffice
{

    public class PRPOffice
    {
       string    _id,	_codeId,	_name,	_mainLandMark,	_address,	_city,	_district,	_state, 	_phoneNo,	_mobNo;
       string _mailId,	_DOJ,	_security,	_status	;
       string _pageIndex, _pageSize, _srNo, _noOfRecord;
        string _designationId, _designationName, _designationStatus, _branchType,_branchLoginStatus;
        
        string _DOB, _sex, _marital, _fatherName, _education, _Graduate, _ProfList, _Salary;
        string _AssociateId, _AssociateName, _branchId, _branchName,_Password,  _pinCode;
        string _branchCode ,_Query;

        string _urlId, _urlName, _urlPath, _urlPrntId;

        public string urlId { get { return _urlId; } set { _urlId = value; } }
        public string urlName { get { return _urlName; } set { _urlName = value; } }
        public string urlPath { get { return _urlPath; } set { _urlPath = value; } }
        public string urlPrntId { get { return _urlPrntId; } set { _urlPrntId = value; } }

        public string branchType { get { return _branchType; } set { _branchType = value; } }
        public string branchLoginStatus { get { return _branchLoginStatus; } set { _branchLoginStatus = value; } }


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
       public string phoneNo { get { return _phoneNo; } set { _phoneNo = value; } }
       public string mobNo { get { return _mobNo; } set { _mobNo = value; } }
       public string mailId { get { return _mailId; } set { _mailId = value; } }
       public string DOJ { get { return _DOJ; } set { _DOJ = value; } }
       public string security { get { return _security; } set { _security = value; } }
       public string status { get { return _status; } set { _status = value; } }
     
        public string designationId { get { return _designationId; } set { _designationId = value; } }
        public string designationName { get { return _designationName; } set { _designationName = value; } }
        public string designationStatus { get { return _designationStatus; } set { _designationStatus = value; } }


	

    }

}