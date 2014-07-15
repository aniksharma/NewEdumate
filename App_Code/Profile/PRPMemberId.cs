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

namespace nmsProfile
{
    public class clsPRPmemberId 
    {
        private Int32 _memberId, _pageIndex, _pageSize ,_employeeId;
        private string _Type;
        private string _TimePeriod, _startDate, _endDate ;

        public Int32 pageIndex { get { return _pageIndex; } set { _pageIndex = value; } }
        public Int32 pageSize { get { return _pageSize; } set { _pageSize = value; } }
        public Int32 memberId { get { return _memberId; } set { _memberId = value; } }
        public Int32 employeeId { get { return _employeeId; } set { _employeeId = value; } }
        public String Type { get { return _Type; } set { _Type = value; } }

        public string TimePeriod { get { return _TimePeriod; } set { _TimePeriod = value; } }
        public string startDate { get { return _startDate; } set { _startDate = value; } }
        public string endDate { get { return _endDate; } set { _endDate = value; } }

        
    }
    public class prpLogin
    {
        private string  _loginName, _loginPassword,_loginIP,_oldPassword;
        private string _EmployeeId, _employeeName, _branchId, _brachName,_loginType;
        private string _memberId,_branchPhone,_urlPath, _emailId;
        private string _IPaddress, _BindStatus, _webSite, _name, _memberShip, _personalDetailsJobsId;
        
        public string IPaddress { get { return _IPaddress; } set { _IPaddress = value; } }
        public string bindStatus { get { return _BindStatus; } set { _BindStatus = value; } }
        public String urlPath { get { return _urlPath; } set { _urlPath = value; } }
        public string emailId { get { return _emailId; } set { _emailId = value; } }

        public string personalDetailsJobsId { get { return _personalDetailsJobsId; } set { _personalDetailsJobsId = value; } }

        public string branchPhone { get { return _branchPhone; } set { _branchPhone = value; } }

        public string membership { get { return _memberShip; } set { _memberShip = value; } }

        public string name { get { return _name; } set { _name = value; } }
        public string webSite { get { return _webSite; } set { _webSite = value; } }
        public string loginName { get { return _loginName; } set { _loginName = value; } }
        public string loginPassword { get { return _loginPassword; } set { _loginPassword = value; } }
        public string EmployeeId { get { return _EmployeeId; } set { _EmployeeId = value; } }
        public string employeeName { get { return _employeeName; } set { _employeeName = value; } }
        public string branchId { get { return _branchId; } set { _branchId = value; } }
        public string brachName { get { return _brachName; } set { _brachName = value; } }
        public string loginType { get { return _loginType; } set { _loginType = value; } }
        public string loginIP { get { return _loginIP; } set { _loginIP = value; } }
        public string oldPassword { get { return _oldPassword; } set { _oldPassword = value; } }
        public string memberId { get { return _memberId; } set { _memberId = value; } }                 
    }
}
