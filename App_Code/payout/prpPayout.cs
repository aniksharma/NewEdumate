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
using nmsProfile;
namespace nmsPayout
{
    public class PRPpayout:clsPRPprofile
    {
        private string _Commission, _Orc, _Growth, _TDS, _HCharges, _Net,_Date;

        public string Commission { get { return _Commission; } set { _Commission = value; } }
        public string Orc { get { return _Orc; } set { _Orc = value; } }
        public string Growth { get { return _Growth; } set { _Growth = value; } }
        public string TDS { get { return _TDS; } set { _TDS = value; } }

        public string HCharges { get { return _HCharges; } set { _HCharges = value; } }
        public string Net { get { return _Net; } set { _Net = value; } }
        public string Date { get { return _Date; } set { _Date = value; } }

    }
    public class payoutMemberid : clsPRPmemberId
    {
        private string _ViewType, _ViewId, _id, _date, _group;

        public string ViewType { get { return _ViewType; } set { _ViewType = value; } }
        public string ViewId { get { return _ViewId; } set { _ViewId = value; } }
        public string id { get { return _id; } set { _id = value; } }

        public string date { get { return _date; } set { _date = value; } }
        public string group { get { return _group; } set { _group = value; } }

    }
}
