using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace payget
{
    
        public class prp_pay
        {
            string OrderId, Amount, MerchantId, RedirectUrl, CustomerName, CustAddr, CustCountry, CustPhone;
            string CustEmail, CustState, CustCity, ZipCode, CustNotes, DelCustName, DelCustAddr, DelCustCntry, DelCustTel;
            string DelCustState, DelCustCity, DelZipCode, MerchantParam, GetPayType, billingPageHeading;
            string status, paymentplan,proposalno,proposaldate ,duedata,descripion,latefees,servicetax,total;

            public string _status { get { return status; } set { status = value; } }
            public string _paymentplan { get { return paymentplan; } set { paymentplan = value; } }
            public string _proposalno { get { return proposalno; } set { proposalno = value; } }
            public string _proposaldate { get { return proposaldate; } set { proposaldate = value; } }
            public string _duedata { get { return duedata; } set { duedata = value; } }
            public string _descripion { get { return descripion; } set { descripion = value; } }
            public string _latefees { get { return latefees; } set { latefees = value; } }
            public string _servicetax { get { return servicetax; } set { servicetax = value; } }
            public string _total { get { return total; } set { total = value; } }
            


            public string _OrderId { get { return OrderId; } set { OrderId = value; } }
            public string _Amount { get { return Amount; } set { Amount = value; } }
            public string _MerchantId { get { return MerchantId; } set { MerchantId = value; } }
            public string _RedirectUrl { get { return RedirectUrl; } set { RedirectUrl = value; } }
            public string _CustomerName { get { return CustomerName; } set { CustomerName = value; } }
            public string _CustAddr { get { return CustAddr; } set { CustAddr = value; } }
            public string _CustCountry { get { return CustCountry; } set { CustCountry = value; } }
            public string _CustPhone { get { return CustPhone; } set { CustPhone = value; } }
            public string _CustEmail { get { return CustEmail; } set { CustEmail = value; } }
            public string _CustState { get { return CustState; } set { CustState = value; } }
            public string _CustCity { get { return CustCity; } set { CustCity = value; } }
            public string _ZipCode { get { return ZipCode; } set { ZipCode = value; } }
            public string _CustNotes { get { return CustNotes; } set { CustNotes = value; } }
            public string _DelCustName { get { return DelCustName; } set { DelCustName = value; } }
            public string _DelCustAddr { get { return DelCustAddr; } set { DelCustAddr = value; } }
            public string _DelCustCntry { get { return DelCustCntry; } set { DelCustCntry = value; } }
            public string _DelCustTel { get { return DelCustTel; } set { DelCustTel = value; } }
            public string _DelCustState { get { return DelCustState; } set { DelCustState = value; } }
            public string _DelCustCity { get { return DelCustCity; } set { DelCustCity = value; } }
            public string _DelZipCode { get { return DelZipCode; } set { DelZipCode = value; } }
            public string _MerchantParam { get { return MerchantParam; } set { MerchantParam = value; } }
            public string _GetPayType { get { return GetPayType; } set { GetPayType = value; } }
            public string _billingPageHeading { get { return billingPageHeading; } set { billingPageHeading = value; } }

        }

}