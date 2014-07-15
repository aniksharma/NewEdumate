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
namespace nmsJoining
{

    public class PRPjoining
    {
        private string _sponsorName, _sponsorId, _installmentId, _installmentValue, _planId, _PlanValue, _planValueId, _PlanName, _installmentType;
        private string _pageIndex, _pageSize, _noOfRecord, _srNo, _id;
        private string _insTotal, _insPaid, _insDue, _retrunValue, _retrunDate;
        private string _joiningdate;
        private string _branchId, _employeeId, _receiptNo;
        private string _planType,_insPaidDate,_insDueDate;
        private string _sponsorMobileNo,_sponsorCity;
        private string _agentRankName,_memberType;
        private string _paymentNote, _bankNote;
        private string _valueInWord ,_searchType;
        private string _dueDate, _PayDate,_valueNo,_valueAmount,_TotalMember, _TotalInvestor,_TotalAmount,_TotalFresh;

        private string _dobDay, _dobYear, _dobMoths;
        private string _startDate, _endDate, _examSession;
        private string _ViewType, _ViewId,  _date, _group, _viewDate, _imagePath;

        string _courseFees, _examFees, _otherFees, _regFees, _uniID, _catID,_receivedFees,_pendingFees,_subsidyFees,_graceTime,_pinTypeId,_courseId,_prosFees;

        string _plId, _PlSponsorId, _plDate, _plPv, _plAgencyId, _plAgencyName, _plSpId, _plSponsorName,_transferFees;

        public string plId { get { return _plId; } set { _plId = value; } }
        public string plSponsorId { get { return _PlSponsorId; } set { _PlSponsorId = value; } }
        public string plDate { get { return _plDate; } set { _plDate = value; } }
        public string plPv { get { return _plPv; } set { _plPv = value; } }
        public string plAgencyId { get { return _plAgencyId; } set { _plAgencyId = value; } }
        public string plAgencyName { get { return _plAgencyName; } set { _plAgencyName = value; } }
        public string plSpId { get { return _plSpId; } set { _plSpId = value; } }
        public string plSponsorName { get { return _plSponsorName; } set { _plSponsorName = value; } }

        public string transferFees { get { return _transferFees; } set { _transferFees = value; } }
        public string examSession { get { return _examSession; } set { _examSession = value; } }
        public string courseFees { get { return _courseFees; } set { _courseFees = value; } }
        public string examFees { get { return _examFees; } set { _examFees = value; } }
        public string otherFees { get { return _otherFees; } set { _otherFees = value; } }
        public string regFees { get { return _regFees; } set { _regFees = value; } }
        public string prosFees { get { return _prosFees; } set { _prosFees = value; } }
        public string uniID { get { return _uniID; } set { _uniID = value; } }
        public string catID { get { return _catID; } set { _catID = value; } }
        public string receivedFees { get { return _receivedFees; } set { _receivedFees = value; } }
        public string pendingFees { get { return _pendingFees; } set { _pendingFees = value; } }
        public string subsidyFees { get { return _subsidyFees; } set { _subsidyFees = value; } }
        public string graceTime { get { return _graceTime; } set { _graceTime = value; } }
        public string pinTypeId { get { return _pinTypeId; } set { _pinTypeId = value; } }
        public string courseId { get { return _courseId; } set { _courseId = value; } }

                
        public string TotalMember { get { return _TotalMember; } set { _TotalMember = value; } }
        public string TotalInvestor { get { return _TotalInvestor; } set { _TotalInvestor = value; } }
        public string TotalAmount { get { return _TotalAmount; } set { _TotalAmount = value; } }
        public string TotalFresh { get { return _TotalFresh; } set { _TotalFresh = value; } }

        public string dueDate { get { return _dueDate; } set { _dueDate = value; } }
        public string PayDate { get { return _PayDate; } set { _PayDate = value; } }
        public string valueNo { get { return _valueNo; } set { _valueNo = value; } }

        public string valueAmount { get { return _valueAmount; } set { _valueAmount = value; } }
        
        public string startDate { get { return _startDate; } set { _startDate = value; } }
        public string endDate { get { return _endDate; } set { _endDate = value; } }
        
        public string valueInWord { get { return _valueInWord; } set { _valueInWord = value; } }
        public string searchType { get { return _searchType; } set { _searchType = value; } }
        
        public string dobDay { get { return _dobDay; } set { _dobDay = value; } }
        public string dobYear { get { return _dobYear; } set { _dobYear = value; } }
        public string dobMoths { get { return _dobMoths; } set { _dobMoths = value; } }
        
        public string paymentNote { get { return _paymentNote; } set { _paymentNote = value; } }
        public string bankNote { get { return _bankNote; } set { _bankNote = value; } }
        
        public string memberType { get { return _memberType; } set { _memberType = value; } }
        
        public string insPaidDate { get { return _insPaidDate; } set { _insPaidDate = value; } }
        public string insDueDate { get { return _insDueDate; } set { _insDueDate = value; } }
        public string sponsorMobileNo { get { return _sponsorMobileNo; } set { _sponsorMobileNo = value; } }
        public string agentRankName { get { return _agentRankName; } set { _agentRankName = value; } }
        public string sponsorCity { get { return _sponsorCity; } set { _sponsorCity = value; } }
        
        public string planType { get { return _planType; } set { _planType = value; } }

        public string receiptNo { get { return _receiptNo; } set { _receiptNo = value; } }
        
        public string branchId { get { return _branchId; } set { _branchId = value; } }
        public string employeeId { get { return _employeeId; } set { _employeeId = value; } }
        
        public string joiningdate { get { return _joiningdate; } set { _joiningdate = value; } }
        
        public string sponsorName { get { return _sponsorName; } set { _sponsorName = value; } }
        public string sponsorId { get { return _sponsorId; } set { _sponsorId = value; } }
        
        public string installmentType { get { return _installmentType; } set { _installmentType = value; } }
        public string installmentId { get { return _installmentId; } set { _installmentId = value; } }
        public string installmentValue { get { return _installmentValue; } set { _installmentValue = value; } }

        public string imagePath { get { return _imagePath; } set { _imagePath = value; } }

        public string planId { get { return _planId; } set { _planId = value; } }
        public string planValueId { get { return _planValueId; } set { _planValueId = value; } }
        public string PlanValue { get { return _PlanValue; } set { _PlanValue = value; } }
        public string PlanName { get { return _PlanName; } set { _PlanName = value; } }
        
        public string pageIndex { get { return _pageIndex; } set { _pageIndex = value; } }
        public string pageSize { get { return _pageSize; } set { _pageSize = value; } }
        public string noOfRecord { get { return _noOfRecord; } set { _noOfRecord = value; } }
        public string srNo { get { return _srNo; } set { _srNo = value; } }
        public string id { get { return _id; } set { _id = value; } }


        public string insTotal { get { return _insTotal; } set { _insTotal = value; } }
        public string insPaid { get { return _insPaid; } set { _insPaid = value; } }
        public string insDue { get { return _insDue; } set { _insDue = value; } }
        public string retrunValue { get { return _retrunValue; } set { _retrunValue = value; } }
        public string retrunDate { get { return _retrunDate; } set { _retrunDate = value; } }

        
        public string ViewType { get { return _ViewType; } set { _ViewType = value; } }
        public string viewDate { get { return _viewDate; } set { _viewDate = value; } }
        
        
    }

    public class clsPRPchecker
    {
        private Int32 _memberId;
        public Int32 memberId { get { return _memberId; } set { _memberId = value; } }

    }
    public class clsPRPArjustchecker
    {
        private string _companyName;
        private Int32 _companyId;
        public string companyName { get { return _companyName; } set { _companyName = value; } }
        public Int32 companyId { get { return _companyId; } set { _companyId = value; } }
       
    }
    public class PRPprofile:PRPjoining
    {
        private string _infoMonth, _InfoPlanValueId, _memberAge, _memberPaymentAmount, _memberPolicyId, _workEmployeeID, _pinPlanID, _infoInstalmentTYPE, _infoPolicyID;
        private string _memberAgentID;
        private string _memberDOB, _memberPaymentDATE;
        private string _infoPlanVALUE, _infoAdjustVALUE;
        
        private string _memberName, _memberRelation,_memberMotherName, _memberFatherNAME, _memberAddress,_memberCity, _memberDistrict, _memberState;
        private string _memberPinNO, _memberMobile, _memberTelephone, _memberMarital, _memberNomineeNAME, _memberNomineeRELATION;
        private string _memberNomineeAGE, _memberBankuserNAME, _memberBankName, _memberBankBranch, _memberBankACNO, _memberPanNO;
        private string _memberPaymentDDNO, _memberPaymemtBANKname, _memberPaymentBANKbranch, _memberPolicyTYPE, _memberCompanyNAME;
        private string _memberSex, _printIntalment,  _memberPaymentTYPE,_memberCastCategory;
        private string _FreshValue,_installmentValue,_pinCode,_NomineeDOB;
        private string _employeeId, _employeeName, _branchID, _branchName;
        private string _password, _memberID,_status;
        private string _bankAddress, _bankNote,_paymentNote;

        public string bankAddress { get { return _bankAddress; } set { _bankAddress = value; } }
        public string bankNote { get { return _bankNote; } set { _bankNote = value; } }
        public string paymentNote { get { return _paymentNote; } set { _paymentNote = value; } }

        public string password { get { return _password; } set { _password = value; } }
        public string memberID { get { return _memberID; } set { _memberID = value; } }
        public string status { get { return _status; } set { _status = value; } }

        public string memberMotherName { get { return _memberMotherName; } set { _memberMotherName = value; } }
        public string memberCastCategory { get { return _memberCastCategory; } set { _memberCastCategory = value; } }
        
        public string employeeId { get { return _employeeId; } set { _employeeId = value; } }
        public string employeeName { get { return _employeeName; } set { _employeeName = value; } }
        public string branchID { get { return _branchID; } set { _branchID = value; } }
        public string branchName { get { return _branchName; } set { _branchName = value; } }

        public string NomineeDOB { get { return _NomineeDOB; } set { _NomineeDOB = value; } }
        public string pinCode { get { return _pinCode; } set { _pinCode = value; } }
        public string FreshValue { get { return _FreshValue; } set { _FreshValue = value; } }
        public string installmentValue { get { return _installmentValue; } set { _installmentValue = value; } }
        public string Name { get { return _memberName; } set { _memberName = value; } }
        public string Relation { get { return _memberRelation; } set { _memberRelation = value; } }
        public string FatherNAME { get { return _memberFatherNAME; } set { _memberFatherNAME = value; } }
        public string Address { get { return _memberAddress; } set { _memberAddress = value; } }
        public string City { get { return _memberCity; } set { _memberCity = value; } }
        public string District { get { return _memberDistrict; } set { _memberDistrict = value; } }
        public string State { get { return _memberState; } set { _memberState = value; } }

        public string PinNO { get { return _memberPinNO; } set { _memberPinNO = value; } }
        public string Mobile { get { return _memberMobile; } set { _memberMobile = value; } }
        public string Telephone { get { return _memberTelephone; } set { _memberTelephone = value; } }
        public string Marital { get { return _memberMarital; } set { _memberMarital = value; } }
        public string NomineeNAME { get { return _memberNomineeNAME; } set { _memberNomineeNAME = value; } }
        public string NomineeRELATION { get { return _memberNomineeRELATION; } set { _memberNomineeRELATION = value; } }
        public string NomineeAGE { get { return _memberNomineeAGE; } set { _memberNomineeAGE = value; } }
        public string BankuserNAME { get { return _memberBankuserNAME; } set { _memberBankuserNAME = value; } }
        public string BankName { get { return _memberBankName; } set { _memberBankName = value; } }
        public string BankBranch { get { return _memberBankBranch; } set { _memberBankBranch = value; } }
        public string BankACNO { get { return _memberBankACNO; } set { _memberBankACNO = value; } }
        public string PanNO { get { return _memberPanNO; } set { _memberPanNO = value; } }
        public string PaymentDDNO { get { return _memberPaymentDDNO; } set { _memberPaymentDDNO = value; } }
        public string PaymemtBANKname { get { return _memberPaymemtBANKname; } set { _memberPaymemtBANKname = value; } }
        public string PaymentBANKbranch { get { return _memberPaymentBANKbranch; } set { _memberPaymentBANKbranch = value; } }
        public string PolicyTYPE { get { return _memberPolicyTYPE; } set { _memberPolicyTYPE = value; } }
        public string PolicyCompanyNAME { get { return _memberCompanyNAME; } set { _memberCompanyNAME = value; } }
        public string Sex { get { return _memberSex; } set { _memberSex = value; } }
        public string printIntalment { get { return _printIntalment; } set { _printIntalment = value; } }
        public string PaymentTYPE { get { return _memberPaymentTYPE; } set { _memberPaymentTYPE = value; } }
        public string PlanValueId { get { return _InfoPlanValueId; } set { _InfoPlanValueId = value; } }
        public string Month { get { return _infoMonth; } set { _infoMonth = value; } }
        public string Age { get { return _memberAge; } set { _memberAge = value; } }
        public string PaymentAmount { get { return _memberPaymentAmount; } set { _memberPaymentAmount = value; } }
        //public string PolicyId { get { return _memberPolicyId; } set { _memberPolicyId = value; } }
        public string workEmployeeID { get { return _workEmployeeID; } set { _workEmployeeID = value; } }
        public string PlanID { get { return _pinPlanID; } set { _pinPlanID = value; } }
        public string InstalmentTYPE { get { return _infoInstalmentTYPE; } set { _infoInstalmentTYPE = value; } }
        public string PolicyID { get { return _infoPolicyID; } set { _infoPolicyID = value; } }
        public string AgentID { get { return _memberAgentID; } set { _memberAgentID = value; } }
        public string DOB { get { return _memberDOB; } set { _memberDOB = value; } }
        public string PaymentDATE { get { return _memberPaymentDATE; } set { _memberPaymentDATE = value; } }
        public string PlanVALUE { get { return _infoPlanVALUE; } set { _infoPlanVALUE = value; } }
        public string AdjustVALUE { get { return _infoAdjustVALUE; } set { _infoAdjustVALUE = value; } }
        
   }



}