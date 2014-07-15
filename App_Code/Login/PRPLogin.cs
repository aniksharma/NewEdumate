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
using System.Collections.Generic;
namespace nmsLogin
{

    public class clsPRPLogin
    {
        private string _LoginName, _password, _MemberId, _memberName, _SponsorName;
        private string _LeftId, _RightId,_WithdrawalBalance,_BinaryBalance,_LastLoginIP,_LastLoginTime;
        public string LastLoginIP { get { return _LastLoginIP; } set { _LastLoginIP = value; } }
        public string LastLoginTime { get { return _LastLoginTime; } set { _LastLoginTime = value; } }
        public string WithdrawalBalance { get { return _WithdrawalBalance; } set { _WithdrawalBalance = value; } }
        public string BinaryBalance { get { return _BinaryBalance; } set { _BinaryBalance = value; } }
        public string LeftId { get { return _LeftId; } set { _LeftId = value; } }
        public string RightId { get { return _RightId; } set { _RightId = value; } }
        public string LoginName { get { return _LoginName; } set { _LoginName = value; } }
        public string password { get { return _password; } set { _password = value; } }
        public string MemberId { get { return _MemberId; } set { _MemberId = value; } }
        public string memberName { get { return _memberName; } set { _memberName = value; } }
        public string SponsorName { get { return _SponsorName; } set { _SponsorName = value; } }
        


    }

}