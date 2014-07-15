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
namespace nmsJoiningJOb
{
    public class clsBLJoining
    {
        clsDLjoining obj = new clsDLjoining();


        public PRPjoining SelectSponsorName(PRPjoining objprp)
        {
            return obj.SelectSponsorName(objprp);
        }

        public PRPjoining SelectPaymentDetail(PRPjoining objprp)
        {
            return obj.SelectPaymentDetail(objprp);
        }

        public PRPprofile InsertJoining(PRPprofile objprp)
        {
            return obj.InsertJoining(objprp);
        }

        public string InsertBankInfo(PRPprofile objprp)
        {
            return obj.InsertBankInfo(objprp);
        }

        public string InsertPaymentInfo(PRPprofile objprp)
        {
            return obj.InsertPaymentInfo(objprp);
        }


        public string updateImage(PRPprofile objprp)
        {
            return obj.updateImage(objprp);
        }


        public string getMaxId()
        {
            return obj.getMaxId();
        }


        public string updateMemberProfile(PRPprofile objprp)    
        {
            return obj.updateProfile(objprp);
        }

        public string updateLogin(PRPprofile objprp)
        {
            return obj.updateLogin(objprp);
        }

        public string updateNominee(PRPprofile objprp)
        {
            return obj.updateNominee(objprp);
        }
        public string updateRank(PRPprofile objprp)
        {
            return obj.updateRank(objprp);
        }

        public List<PRPprofile> ViewAdvanceInvestor(PRPprofile objprp)
        {
            return obj.ViewAdvanceInvestor(objprp);
        }

        public List<PRPprofile> ViewBasicInvestor(PRPprofile objprp)
        {
            return obj.ViewBasicInvestor(objprp);
        }
        public List<PRPprofile> ViewBasicAgent(PRPprofile objprp)
        {
            return obj.ViewBasicAgent(objprp);
        }

        public string checkMember(PRPjoining objprp)
        {
            return obj.CheckMember(objprp);
        }
        public PRPprofile SelectAgentProfile(PRPjoining objprp)
        {
            return obj.SelectAgentProfile(objprp);
        }
        public PRPprofile SelectInvestorProfile(PRPjoining objprp)
        {
            return obj.SelectInvestorProfile(objprp);
        }

        public PRPprofile SelectMemberProfile(PRPjoining objprp)
        {
            return obj.SelectMemberProfile(objprp);
        }



        public List<PRPprofile> search(PRPprofile objprp)
        {
            return obj.search(objprp);
        }

        public string SetForReprinting(PRPjoining objprp)
        {
            return obj.SetForReprinting(objprp);
        }

        public string SetForREInstalment(PRPjoining objprp)
        {
            return obj.SetForREInstalment(objprp);
        }

        


        public string deleteMember(PRPjoining objprp)
        {
            return obj.deleteMember(objprp);
        }

        public string DeleteInstallment(PRPjoining objprp)
        {
            return obj.DeleteInstallment(objprp);
        }

        public List<PRPprofile> spBusinessReoport(PRPprofile objprp)
        {
            return obj.spBusinessReoport(objprp);
        }

    }

}
