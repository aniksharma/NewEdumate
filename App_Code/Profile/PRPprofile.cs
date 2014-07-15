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
using nmsJoining;
namespace nmsProfile
{
    public class clsPRPprofile:PRPprofile
    {
        private string _noOfRecord;
        private string _memberId, _memberCodeID, _memberPlanID, _rankBusiness, _empId, _empCodeID;
        private string _JrankID, _JrankAgentId, _JrankRankId, _JrankBusiness, _JrankUNITCODE, _rankId, _workId, _workEmployeeID, _workjoiningID, _empSalary;
        private string _empAssociateId, _empSecurity, _loginId, _loginMemberId, _infoGuaranteedValue;
        private string _instalmentId, _instalmentMemberID, _instalmentReceiptNO, _instalmentValue, _instalmentLateCHARGE, _instalmentNetAmount;
        private string _instalmentNumber, _infoId, _infoInvsetorID, _infoAgentId, _infoAgentRANKID, _infoMonth, _infoPlanID, _infoPlanVALUE, _infoInstelmentValue;
        private string _memberJoiningDATE, _loginPassword, _rankName, _rankDate, _empName, _empEducation, _empGraduate, _empPostgraduate, _empSex;
        private string _JrankDate, _JrankUpdate, _loginType, _loginStatus, _loginDate, _workDate, _sponsorName, _sponsorMobile, _sponsordistrict;
        private string _empDOB, _empAddress, _empDistrict, _empCity, _empState, _empMobile, _empProfLIST, _empJoinDATE, _branchName;
        private string _instalmentDate, _instalmentDueDATE, _infoInstalmentPAIDDATE, _infoInstalmentDUEDATE, _infoGuaranteedDATE, _infoPolicyTYPE;
        private string _memberDOBDay, _memberDOBmonth, _memberDOByear, _planName, _instalmentType, _memberAge;
        private string _printRegisterNo, _printSizeofplot, _printPlanNAME, _printAgencyUNITCODE, _printAddress2, _printDueDATE, _printIntalment;
        private string _SrNo, _Amount, _Extra, _NetAmount,_status;

        private string _TotalPanding, _totalDue, _totalPaid, _total;

        public string TotalPanding { get { return _TotalPanding; } set { _TotalPanding = value; } }
        public string totalDue { get { return _totalDue; } set { _totalDue = value; } }
        public string totalPaid { get { return _totalPaid; } set { _totalPaid = value; } }
        public string total { get { return _total; } set { _total = value; } }


        public string SrNo { get { return _SrNo; } set { _SrNo = value; } }
        public string Amount { get { return _Amount; } set { _Amount = value; } }
        public string Extra { get { return _Extra; } set { _Extra = value; } }
        public string NetAmount { get { return _NetAmount; } set { _NetAmount = value; } }
        public string Status { get { return _status; } set { _status = value; } }

        public string infoGuaranteedValue { get { return _infoGuaranteedValue; } set { _infoGuaranteedValue = value; } }
        public string printAgencyUNITCODE { get { return _printAgencyUNITCODE; } set { _printAgencyUNITCODE = value; } }
        public string printAddress2 { get { return _printAddress2; } set { _printAddress2 = value; } }
        public string printDueDATE { get { return _printDueDATE; } set { _printDueDATE = value; } }
        public string printPlanNAME { get { return _printPlanNAME; } set { _printPlanNAME = value; } }
        public string printSizeofplot { get { return _printSizeofplot; } set { _printSizeofplot = value; } }
        public string printRegisterNo { get { return _printRegisterNo; } set { _printRegisterNo = value; } }
        public string planName { get { return _planName; } set { _planName = value; } }
        public string memberDOBDay { get { return _memberDOBDay; } set { _memberDOBDay = value; } }
        public string memberDOBmonth { get { return _memberDOBmonth; } set { _memberDOBmonth = value; } }
        public string memberDOByear { get { return _memberDOByear; } set { _memberDOByear = value; } }
        public string printIntalment { get { return _printIntalment; } set { _printIntalment = value; } }
        public string noOfRecord { get { return _noOfRecord; } set { _noOfRecord = value; } }

        public string memberId { get { return _memberId; } set { _memberId = value; } }
        public string memberCodeID { get { return _memberCodeID; } set { _memberCodeID = value; } }
        public string memberPlanID { get { return _memberPlanID; } set { _memberPlanID = value; } }
        public string memberAge { get { return _memberAge; } set { _memberAge = value; } }
        public string rankBusiness { get { return _rankBusiness; } set { _rankBusiness = value; } }
        public string empId { get { return _empId; } set { _empId = value; } }
        public string empCodeID { get { return _empCodeID; } set { _empCodeID = value; } }
        public string JrankID { get { return _JrankID; } set { _JrankID = value; } }
        public string JrankAgentId { get { return _JrankAgentId; } set { _JrankAgentId = value; } }
        public string JrankRankId { get { return _JrankRankId; } set { _JrankRankId = value; } }
        public string JrankBusiness { get { return _JrankBusiness; } set { _JrankBusiness = value; } }
        public string JrankUNITCODE { get { return _JrankUNITCODE; } set { _JrankUNITCODE = value; } }
        public string rankId { get { return _rankId; } set { _rankId = value; } }
        public string workId { get { return _workId; } set { _workId = value; } }
        public string workEmployeeID { get { return _workEmployeeID; } set { _workEmployeeID = value; } }
        public string workjoiningID { get { return _workjoiningID; } set { _workjoiningID = value; } }
        public string empSalary { get { return _empSalary; } set { _empSalary = value; } }
        public string empAssociateId { get { return _empAssociateId; } set { _empAssociateId = value; } }
        public string empSecurity { get { return _empSecurity; } set { _empSecurity = value; } }
        public string loginId { get { return _loginId; } set { _loginId = value; } }
        public string loginMemberId { get { return _loginMemberId; } set { _loginMemberId = value; } }
        public string instalmentId { get { return _instalmentId; } set { _instalmentId = value; } }
        public string instalmentMemberID { get { return _instalmentMemberID; } set { _instalmentMemberID = value; } }
        public string instalmentValue { get { return _instalmentValue; } set { _instalmentValue = value; } }
        public string instalmentReceiptNO { get { return _instalmentReceiptNO; } set { _instalmentReceiptNO = value; } }
        public string instalmentLateCHARGE { get { return _instalmentLateCHARGE; } set { _instalmentLateCHARGE = value; } }
        public string instalmentNetAmount { get { return _instalmentNetAmount; } set { _instalmentNetAmount = value; } }
        public string instalmentType { get { return _instalmentType; } set { _instalmentType = value; } }
        public string instalmentNumber { get { return _instalmentNumber; } set { _instalmentNumber = value; } }
        public string infoId { get { return _infoId; } set { _infoId = value; } }
        public string infoInvsetorID { get { return _infoInvsetorID; } set { _infoInvsetorID = value; } }
        public string infoAgentId { get { return _infoAgentId; } set { _infoAgentId = value; } }
        public string infoAgentRANKID { get { return _infoAgentRANKID; } set { _infoAgentRANKID = value; } }
        public string infoMonth { get { return _infoMonth; } set { _infoMonth = value; } }
        public string infoPlanID { get { return _infoPlanID; } set { _infoPlanID = value; } }
        public string infoPlanVALUE { get { return _infoPlanVALUE; } set { _infoPlanVALUE = value; } }
        public string infoInstelmentValue { get { return _infoInstelmentValue; } set { _infoInstelmentValue = value; } }
        public string memberJoiningDATE { get { return _memberJoiningDATE; } set { _memberJoiningDATE = value; } }
        public string loginPassword { get { return _loginPassword; } set { _loginPassword = value; } }
        public string rankName { get { return _rankName; } set { _rankName = value; } }
        public string rankDate { get { return _rankDate; } set { _rankDate = value; } }
        public string empName { get { return _empName; } set { _empName = value; } }
        public string empEducation { get { return _empEducation; } set { _empEducation = value; } }
        public string empGraduate { get { return _empGraduate; } set { _empGraduate = value; } }
        public string empPostgraduate { get { return _empPostgraduate; } set { _empPostgraduate = value; } }
        public string empSex { get { return _empSex; } set { _empSex = value; } }
        public string JrankDate { get { return _JrankDate; } set { _JrankDate = value; } }
        public string JrankUpdate { get { return _JrankUpdate; } set { _JrankUpdate = value; } }
        public string loginType { get { return _loginType; } set { _loginType = value; } }
        public string loginStatus { get { return _loginStatus; } set { _loginStatus = value; } }
        public string loginDate { get { return _loginDate; } set { _loginDate = value; } }
        public string workDate { get { return _workDate; } set { _workDate = value; } }
        public string sponsorName { get { return _sponsorName; } set { _sponsorName = value; } }
        public string sponsorMobile { get { return _sponsorMobile; } set { _sponsorMobile = value; } }
        public string sponsordistrict { get { return _sponsordistrict; } set { _sponsordistrict = value; } }
        public string empDOB { get { return _empDOB; } set { _empDOB = value; } }
        public string empAddress { get { return _empAddress; } set { _empAddress = value; } }
        public string empDistrict { get { return _empDistrict; } set { _empDistrict = value; } }
        public string empCity { get { return _empCity; } set { _empCity = value; } }
        public string empState { get { return _empState; } set { _empState = value; } }
        public string empMobile { get { return _empMobile; } set { _empMobile = value; } }
        public string empProfLIST { get { return _empProfLIST; } set { _empProfLIST = value; } }
        public string empJoinDATE { get { return _empJoinDATE; } set { _empJoinDATE = value; } }
        public string branchName { get { return _branchName; } set { _branchName = value; } }
        public string instalmentDate { get { return _instalmentDate; } set { _instalmentDate = value; } }
        public string instalmentDueDATE { get { return _instalmentDueDATE; } set { _instalmentDueDATE = value; } }
        public string infoInstalmentPAIDDATE { get { return _infoInstalmentPAIDDATE; } set { _infoInstalmentPAIDDATE = value; } }
        public string infoInstalmentDUEDATE { get { return _infoInstalmentDUEDATE; } set { _infoInstalmentDUEDATE = value; } }
        public string infoGuaranteedDATE { get { return _infoGuaranteedDATE; } set { _infoGuaranteedDATE = value; } }
        public string infoPolicyTYPE { get { return _infoPolicyTYPE; } set { _infoPolicyTYPE = value; } }

 


    }
}
