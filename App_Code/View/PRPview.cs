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

namespace nmsView
{
    public class clsPRPParm
    {
        string _MemId, _PageIndex, _PageSize, _ViewType, _StartDate, _EndDate,_spName, _uniID, _catID;
        

        public string MemId { get { return _MemId; } set { _MemId = value; } }
        public string PageIndex { get { return _PageIndex; } set { _PageIndex = value; } }
        public string PageSize { get { return _PageSize; } set { _PageSize = value; } }
        public string ViewType { get { return _ViewType; } set { _ViewType = value; } }
        public string StartDate { get { return _StartDate; } set { _StartDate = value; } }
        public string EndDate { get { return _EndDate; } set { _EndDate = value; } }
        public string spName { get { return _spName; } set { _spName = value; } }
        public string uniID { get { return _uniID; } set { _uniID = value; } }
        public string catID { get { return _catID; } set { _catID = value; } }
    }
    public class clsPRPView
    {
        string _date, _startDate, _endDate, _amount, _decduction, _netAmount, _memid, _srNo;
        string _topupCode, _days, _percentage, _forId, _binaryId, _leftCarry, _rightCarry;
        string _roiAmount, _status, _paymentMode, _voucherCode, _voucherNo, _usedType, _memo, _tramsferTo;
        string _acceptamount, _Sponsorid, _memName, _noOfRecord;
        string _refferralId, _rightBusiness, _leftBusiness;
        string _LoginName, _Name;
        string _LRNO;
        string _Level, _Pair, _Reward, _SalaryAmount, _salaryForMonth;
        string _mobNo, _SponsorName,_rewardStatus, _slaryStatus;

        public string Level { get { return _Level; } set { _Level = value; } }
        public string Pair { get { return _Pair; } set { _Pair = value; } }
        public string Reward { get { return _Reward; } set { _Reward = value; } }
        public string SalaryAmount { get { return _SalaryAmount; } set { _SalaryAmount = value; } }
        public string salaryForMonth { get { return _salaryForMonth; } set { _salaryForMonth = value; } }

        public string mobNo { get { return _mobNo; } set { _mobNo = value; } }
        public string SponsorName { get { return _SponsorName; } set { _SponsorName = value; } }

        public string rewardStatus { get { return _rewardStatus; } set { _rewardStatus = value; } }
        public string slaryStatus { get { return _slaryStatus; } set { _slaryStatus = value; } }

        public string LRNO { get { return _LRNO; } set { _LRNO = value; } }
        public string leftBusiness { get { return _leftBusiness; } set { _leftBusiness = value; } }
        public string rightBusiness { get { return _rightBusiness; } set { _rightBusiness = value; } }
        public string refferralId { get { return _refferralId; } set { _refferralId = value; } }
        
        public string noOfRecord { get { return _noOfRecord; } set { _noOfRecord = value; } }
        public string Date { get { return _date; } set { _date = value; } }
        public string StartDate { get { return _startDate; } set { _startDate = value; } }
        public string EndDate { get { return _endDate; } set { _endDate = value; } }
        public string Amount { get { return _amount; } set { _amount = value; } }
        public string Decduction { get { return _decduction; } set { _decduction = value; } }
        public string NetAmount { get { return _netAmount; } set { _netAmount = value; } }
        public string Memid { get { return _memid; } set { _memid = value; } }
        public string SrNo { get { return _srNo; } set { _srNo = value; } }
        public string MemName { get { return _memName; } set { _memName = value; } }
        public string Sponsorid { get { return _Sponsorid; } set { _Sponsorid = value; } }
        public string TopupCode { get { return _topupCode; } set { _topupCode = value; } }
        public string Days { get { return _days; } set { _days = value; } }
        public string Percentage { get { return _percentage; } set { _percentage = value; } }
        public string ForId { get { return _forId; } set { _forId = value; } }
        public string BinaryId { get { return _binaryId; } set { _binaryId = value; } }
        public string LeftCarry { get { return _leftCarry; } set { _leftCarry = value; } }
        public string RightCarry { get { return _rightCarry; } set { _rightCarry = value; } }
        public string Acceptamount { get { return _acceptamount; } set { _acceptamount = value; } }
        public string RoiAmount { get { return _roiAmount; } set { _roiAmount = value; } }
        public string Status { get { return _status; } set { _status = value; } }
        public string PaymentMode { get { return _paymentMode; } set { _paymentMode = value; } }
        public string VoucherCode { get { return _voucherCode; } set { _voucherCode = value; } }
        public string VoucherNo { get { return _voucherNo; } set { _voucherNo = value; } }
        public string UsedType { get { return _usedType; } set { _usedType = value; } }
        public string Memo { get { return _memo; } set { _memo = value; } }
        public string TramsferTo { get { return _tramsferTo; } set { _tramsferTo = value; } }

        public string LoginName { get { return _LoginName; } set { _LoginName = value; } }
        public string Name { get { return _Name; } set { _Name = value; } }
      
    }
}
