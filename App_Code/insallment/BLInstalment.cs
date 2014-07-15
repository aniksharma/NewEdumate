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
namespace nmsProfile
{

    public class BlInsalment
    {
        DlInstalment obj = new DlInstalment();
        public List<prpInstalment> InstalmentDetail(clsPRPmemberId objprp)
        {
            return obj.InstalmentDetail(objprp);
        }
        public List<prpInstalment> InstalmentNewDetail(clsPRPmemberId objprp)
        {
            return obj.InstalmentNewDetail(objprp);
        }        
        public List<prpInstalment> InstalmentPendingPrinting(clsPRPmemberId objprp)
        {
            return obj.InstalmentPendingPrinting(objprp);
        }
        public List<prpInstalment> InstalmentReport(clsPRPmemberId objprp)
        {
            return obj.InstalmentReport(objprp);
        }
        public List<prpInstalment> InstalmentReportNew(clsPRPmemberId objprp)
        {
            return obj.InstalmentReportNew(objprp);
        }

        public List<prpInstalment> InstalmentReportALL(clsPRPmemberId objprp)
        {
            return obj.InstalmentReportALL(objprp);
        }

        public string GetInstalment(prpLogin prp)
        {
            return obj.GetInstalment(prp);
        }

        public string GetInstalment1(prpInstalment prp)
        {
            return obj.GetInstalment1(prp);
        }

        public string checkPendingBalance(prpInstalment prp)
        {
            return obj.CheckPendingBalance(prp);
        }
        public string UpdateInstalmentPrintStatus(prpInstalment prp)
        {
            return obj.UpdateInstalmentPrintStatus(prp);
        }


        public string updateInstallmentStatus(prpInstalment prp)
        {
            return obj.updateInstallmentStatus(prp);
        }

        public prpInstalment printInsallment(prpInstalment prp)
        {
            return obj.printInsallment(prp);
        }


    }
}