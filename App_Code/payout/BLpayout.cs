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
namespace nmsPayout
{
     
    public class BlPayout
    {
        DLPayout dl = new DLPayout();
        public PRPpayout payoutSummary(payoutMemberid prp)
        {
            return dl.payoutSummary(prp);
        }

        public List<PRPpayout> payoutPoolSummary(payoutMemberid prp)
        {
            return dl.payoutPoolSummary(prp);
        }
        public List<PRPpayout> payoutReport(payoutMemberid prp)
        {
            return dl.PayoutTDSReport(prp);
        }

        public List<PRPpayout> PoolPayoutTDSReport(payoutMemberid prp)
        {
            return dl.PoolPayoutTDSReport(prp);
        }

        public string GenratePayout()
        {
            return dl.GenratePayout();
        }

        public string GenratePoolPayout()
        {
            return dl.GenratePoolPayout();
        }


        public List<PRPpayout> PayoutCommissionAgentWise(payoutMemberid prp)
        {
            return dl.PayoutCommissionAgentWise(prp);
        }


        public List<PRPpayout> PayoutORCAgentWise(payoutMemberid prp)
        {
            return dl.PayoutORCAgentWise(prp);
        }


    }

}
