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
using nmsProfile;
namespace nmsProfile
{
    
    public class clsBLprofile
    {
        clsDLProfile obj = new clsDLProfile();
        public List<clsPRPprofile> SelectPrint(clsPRPmemberId objprp)
        {
            return obj.selectPrint(objprp);

        }

        public clsPRPprofile SelectPrintReport(clsPRPmemberId objprp)
        {
            return obj.selectPrintReport(objprp);

        }

        public List<clsPRPprofile> SelectAgentPrint(clsPRPmemberId objprp)
        {
            return obj.selectAgentPrint(objprp);

        }

        public List<clsPRPprofile> SelectAgentPrintFinal(clsPRPprofile objprp)
        {
            return obj.selectAgentPrintFinal(objprp);

        }        
        public string CheckLogin(prpLogin objprp)
        {
            return obj.CheckLogin(objprp);
        }
        public string forgetPassword(prpLogin objprp)
        {
            return obj.forgetPassword(objprp);
        }

        public string CheckInstituteLogin(prpLogin objprp)
        {
            return obj.CheckInstituteLogin(objprp);
        }


        public string SpCheckInstituteLoginWithoutPasswrod(prpLogin objprp)
        {
            return obj.SpCheckInstituteLoginWithoutPasswrod(objprp);
        }

        
        public string CheckAgentLogin(prpLogin objprp)
        {
            return obj.CheckAgentLogin(objprp);
        }

        public string UpdatePassword(prpLogin objprp)
        {
            return obj.UpdatePassword(objprp);
        }

        public string UpdateInstitutePassword(prpLogin objprp)
        {
            return obj.UpdateInstitutePassword(objprp);
        }



        public string UpdateAgentPassword(prpLogin objprp)
        {
            return obj.UpdateAgentPassword(objprp);
        }
        public string UpdatePrintStatus(prpLogin objprp)
        {
            return obj.UpdatePrintStatus(objprp);
        }

        public DataSet selectPrintReport1(clsPRPmemberId prp)
        {
            return obj.selectPrintReport1(prp);
        }

        public string CheckPartnerLogin(prpLogin objprp)
        {
            return obj.CheckPartnerLogin(objprp);
        }


        //public string  CheckPrintsts (clsPRPmemberId objprp)
        //{
            
        //    return obj.CheckPrintsts(objprp);
        //}


        //public string CheckInstalment(clsPRPmemberId objprp)
        //{
        //    return obj.CheckInstalment(objprp);
        //}


        //public string CheckMember(clsPRPmemberId objprp)
        //{
        //    return obj.CheckMember(objprp);
        //}



        //public string CheckAssPassword(clsPRPmemberId objprp)
        //{
        //    return obj.CheckAssPassword(objprp);
        //}


        //public List<clsPRPprofile> SelectProfile(clsPRPmemberId objprp)
        //{
        //    return obj.selectProfile(objprp);

        //}

        //public string updateProfile(clsPRPprofile objprp)
        //{
        //    return obj.UpdateProfile(objprp);
        //}

        //public List<clsPRPprofile> InstelmentDetailByInvestor(clsPRPmemberId objprp)
        //{
        //    return obj.InstelmentDetailByInvestorId(objprp);

        //}
        //public clsPRPprofile InstalmetInfoByInvestor(clsPRPmemberId objprp)
        //{
        //    return obj.InstalmetInfoByInvestor(objprp);
        //}

        //public List<clsPRPprofile> SelectInvestor(clsPRPmemberId objprp)
        //{
        //    return obj.selectInvestor(objprp);

        //}



        //public List<clsPRPprofile> SelectAgent(clsPRPmemberId objprp)
        //{
        //    return obj.selectAgent(objprp);

        //}

        //public List<clsPRPprofile> viewAgentTree()
        //{
        //    return obj.ViewTreeAgent();

        //}
        
        //public List<clsPRPprofile> selectAffivate(clsPRPmemberId objprp)
        //{
        //    return obj.selectAffivate(objprp);

        //}

        //public clsPRPprofile selectAffivateDetail(clsPRPmemberId objprp)
        //{
        //    return obj.selectAffivateDetail(objprp);

        //}      
    }
}

