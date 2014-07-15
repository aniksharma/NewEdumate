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


namespace hr
{
    public class clsprophr
    {
        string _pageSize, _pageIndex, _noOfRecord, _Dist, _City, _uniId, _mob, _email, _name, _Type, _Description, _Location, _EndDate, _StartDate, _EndTime, _StartTime, _Organiser, _RemindingDate, _id, _Salary, _catid, _Designation, _DOB, _Qualification, _Experience, _title, _Country, _CurrentStudying, _GraduatingYrs, _EduIntrest, _StudyId, _PrefLocation, _WhenStart, _urlName, _urlPath, _security, _AssociateName, _tutionType, _mainLandMark, _description, _marital, _nneSMS, _nneDaily, _pinCode, _Password, _grade, _rank, _phoneNo, _address, _isActive, _status, _nneEmail, _state, _district, _city;

        public string pageSize
        {
            get { return _pageSize; }
            set { _pageSize = value; }
        }
        public string pageIndex
        {
            get { return _pageIndex; }
            set { _pageIndex = value; }
        }
        public string noOfRecord
        {
            get { return _noOfRecord; }
            set { _noOfRecord = value; }
        }
        
        public string Country
        {
            get { return _Country; }
            set { _Country = value; }
        }
        public string City
        {
            get { return _City; }
            set { _City = value; }
        }
        public string Dist
        {
            get { return _Dist; }
            set { _Dist = value; }
        }
        public string uniId
        {
            get { return _uniId; }
            set { _uniId = value; }
        }
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string mob
        {
            get { return _mob; }
            set { _mob = value; }
        }
        public string title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string Experience
        {
            get { return _Experience; }
            set { _Experience = value; }
        }
        public string Qualification
        {
            get { return _Qualification; }
            set { _Qualification = value; }
        }
        public string DOB
        {
            get { return _DOB; }
            set { _DOB = value; }
        }
        public string Designation
        {
            get { return _Designation; }
            set { _Designation = value; }
        }
        public string catid
        {
            get { return _catid; }
            set { _catid = value; }
        }
        public string Salary
        {
            get { return _Salary; }
            set { _Salary = value; }
        }
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Type
        {
            get { return _Type; }
            set { _Type = value; }
        }
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        public string Location
        {
            get { return _Location; }
            set { _Location = value; }
        }

        public string EndDate
        {
            get { return _EndDate; }
            set { _EndDate = value; }
        }
        public string StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }
        public string EndTime
        {
            get { return _EndTime; }
            set { _EndTime = value; }
        }
        public string StartTime
        {
            get { return _StartTime; }
            set { _StartTime = value; }
        }
        public string Organiser
        {
            get { return _Organiser; }
            set { _Organiser = value; }
        }
        public string RemindingDate
        {
            get { return _RemindingDate; }
            set { _RemindingDate = value; }
        }
        public string id
        {
            get { return _id; }
            set { _id = value; }
        }


        public string CurrentStudying
        {
            get { return _CurrentStudying; }
            set { _CurrentStudying = value; }
        }


        public string GraduatingYrs
        {
            get { return _GraduatingYrs; }
            set { _GraduatingYrs = value; }
        }

        public string EduIntrest
        {
            get { return _EduIntrest; }
            set { _EduIntrest = value; }
        }

        public string StudyId
        {
            get { return _StudyId; }
            set { _StudyId = value; }
        }

        public string WhenStart


        {
            get { return _WhenStart; }

            set { _WhenStart = value;
  }
        }

        public string PrefLocation
        {
            get { return _PrefLocation; }
            set { _PrefLocation = value; }
        }


        public string status
        {
            get { return _status; }
            set { _status = value; }
        }
        public string isActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }
        public string address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string phoneNo
        {
            get { return _phoneNo; }
            set { _phoneNo = value; }
        }
        public string rank
        {
            get { return _rank; }
            set { _rank = value; }
        }

        public string grade
        {
            get { return _grade; }
            set { _grade = value; }
        }
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        public string nneEmail
        {
            get { return _nneEmail; }
            set { _nneEmail = value; }
        }
        public string pinCode
        {
            get { return _pinCode; }
            set { _pinCode = value; }
        }


        public string nneDaily
        {
            get { return _nneDaily; }
            set { _nneDaily = value; }
        }
        public string nneSMS
        {
            get { return _nneSMS; }
            set { _nneSMS = value; }
        }

        public string marital
        {
            get { return _marital; }
            set { _marital = value; }
        }

        public string description
        {
            get { return _description; }
            set { _description = value; }
        }
        public string mainLandMark
        {
            get { return _mainLandMark; }
            set { _mainLandMark = value; }
        }
        public string tutionType
        {
            get { return _tutionType; }
            set { _tutionType = value; }
        }

        public string AssociateName
        {
            get { return _AssociateName; }
            set { _AssociateName = value; }
        }
        public string security
        {
            get { return _security; }
            set { _security = value; }
        }

        public string urlPath
        {
            get { return _urlPath; }
            set { _urlPath = value; }
        }

        public string urlName
        {
            get { return _urlName; }
            set { _urlName = value; }
        }


        public string state
        {
            get { return _state; }
            set { _state = value; }
        }
        public string district
        {
            get { return _district; }
            set { _district = value; }
        }
        public string city
        {
            get { return _city; }
            set { _city = value; }
        }
    }

}
