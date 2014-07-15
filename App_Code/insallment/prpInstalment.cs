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
    public class prpInstalment : PRPprofile
    {
        private string _insNo, _insDate, _insAmount, _inslateCharges;
        private string _insNetAmount, _insStatus, _insInvestorId ;
        private string _insTotal, _insTotalAmount;
        private string _paidTotal, _paidAmount, _paidLateCharges;
        private string _pendingTotal, _pendingAmount, _pendingLateCharges;
        private string _dueTotal ,_dueAmount;
        private string _unitCode, _dueDate, _lateFee, _ReceiptDate,_netAmount ,_branchPhone,_plotRegiNo,_planNo;
        private string _nextDueDate,_joiningyear,_newPlanValue,_memberIdNew;

        private string _branchAddress, _branchCity, _branchDistrict, _branchState, _branchName,_branchCode;

        public string newPlanValue { get { return _newPlanValue; } set { _newPlanValue = value; } }
        
        public string nextDueDate { get { return _nextDueDate; } set { _nextDueDate = value; } }

        public string memberIdNew { get { return _memberIdNew; } set { _memberIdNew = value; } }
      
        public string branchAddress { get { return _branchAddress; } set { _branchAddress = value; } }
        public string branchCity { get { return _branchCity; } set { _branchCity = value; } }
        public string branchDistrict { get { return _branchDistrict; } set { _branchDistrict = value; } }
        public string branchState { get { return _branchState; } set { _branchState = value; } }
        public string branchName { get { return _branchName; } set { _branchName = value; } }
       public string branchCode { get { return _branchCode; } set { _branchCode = value; } }
       public string branchPhone { get { return _branchPhone; } set { _branchPhone = value; } }
       public string plotRegiNo { get { return _plotRegiNo; } set { _plotRegiNo = value; } }
       public string planNo { get { return _planNo; } set { _planNo = value; } }
       public string joiningyear { get { return _joiningyear; } set { _joiningyear = value; } }
        public string insNo { get { return _insNo; } set { _insNo = value; } }
        public string insDate { get { return _insDate; } set { _insDate = value; } }
        public string insAmount { get { return _insAmount; } set { _insAmount = value; } }
        public string inslateCharges { get { return _inslateCharges; } set { _inslateCharges = value; } }
        public string insNetAmount { get { return _insNetAmount; } set { _insNetAmount = value; } }
        public string insStatus { get { return _insStatus; } set { _insStatus = value; } }
        public string insInvestorId { get { return _insInvestorId; } set { _insInvestorId = value; } }
        public string insTotal { get { return _insTotal; } set { _insTotal = value; } }
        public string insTotalAmount { get { return _insTotalAmount; } set { _insTotalAmount = value; } }
        public string paidTotal { get { return _paidTotal; } set { _paidTotal = value; } }
        public string paidAmount { get { return _paidAmount; } set { _paidAmount = value; } }
        public string paidLateCharges { get { return _paidLateCharges; } set { _paidLateCharges = value; } }
        public string pendingTotal { get { return _pendingTotal; } set { _pendingTotal = value; } }
        public string pendingAmount { get { return _pendingAmount; } set { _pendingAmount = value; } }
        public string pendingLateCharges { get { return _pendingLateCharges; } set { _pendingLateCharges = value; } }
        public string dueTotal { get { return _dueTotal; } set { _dueTotal = value; } }
        public string dueAmount { get { return _dueAmount; } set { _dueAmount = value; } }

        public string unitCode { get { return _unitCode; } set { _unitCode = value; } }
        public string dueDate { get { return _dueDate; } set { _dueDate = value; } }
        public string lateFee { get { return _lateFee; } set { _lateFee = value; } }
        public string netAmount { get { return _netAmount; } set { _netAmount = value; } }
        public string ReceiptDate { get { return _ReceiptDate; } set { _ReceiptDate = value; } }

    }
}
