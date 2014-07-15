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
using System.Data.SqlClient;
using System.Collections.Generic;
using nmsADO;

namespace nmsPayout
{
    public class DLPayout
    {
        //--------------------------------------------------------
        clsBLado ADO = new clsBLado();
        clsPRPadoBL ADOprp = new clsPRPadoBL();
        clsPRPadoDL ADOprpDL = new clsPRPadoDL();
        clsPRPadoBL adoBL = new clsPRPadoBL();
        //--------------------------------------------------------
        public PRPpayout payoutSummary(payoutMemberid prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@type", prp.Type);
            ADOprpDL.SPName = "spPayoutSummary";
            ADO.ReaderWithProceduresandParam(ADOprpDL);


            PRPpayout obj = new PRPpayout();
            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj.total = ADOprpDL.Dr["TotalAgent"].ToString();
                    obj.Commission = ADOprpDL.Dr["reportCommission"].ToString();
                    obj.Orc = ADOprpDL.Dr["reportORC"].ToString();
                    obj.Growth = ADOprpDL.Dr["reportGrowth"].ToString();
                    obj.TDS = ADOprpDL.Dr["reportTDS"].ToString();
                    obj.HCharges = ADOprpDL.Dr["reportHandlingCharges"].ToString();
                    obj.NetAmount = ADOprpDL.Dr["reportNetAmount"].ToString();
                }

            }
            else
            {
                obj = new PRPpayout();
                obj.SrNo = "Result Not Find";
            }
            ADO.ReaderClose(ADOprpDL);
            return obj;




        }

        public List< PRPpayout> payoutPoolSummary(payoutMemberid prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@type", "All"); //prp.Type);
            ADOprpDL.SPName = "spPayoutPoolSummary";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            List<PRPpayout> obj = new List<PRPpayout>();

            PRPpayout objprp; // = new PRPpayout();
            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPpayout();
                    objprp.memberId = ADOprpDL.Dr["plMemberId"].ToString();
                    objprp.plAgencyId = ADOprpDL.Dr["plAgencyId"].ToString();
                    objprp.Name=ADOprpDL.Dr["memberName"].ToString();
                    objprp.rankId=ADOprpDL.Dr["plprankId"].ToString();
                    objprp.TotalMember=ADOprpDL.Dr["plpTotalMember"].ToString();
                    objprp.Commission=ADOprpDL.Dr["plpCommission"].ToString();
                    objprp.Date=ADOprpDL.Dr["plpDate"].ToString();
                    obj.Add(objprp);
                }

            }
            else
            {
                objprp = new PRPpayout();
                objprp.SrNo = "Result Not Find";
                obj.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return obj;
        }

        public string GenratePayout()
        {
            adoBL.SPName = "spGenratePayout";

            return ADO.ScalarQueryWithProcedures(adoBL);

        }

        public string GenratePoolPayout()
        {
            adoBL.SPName = "plPayoutCalculate";

            return ADO.ScalarQueryWithProcedures(adoBL);

        }


        public List<PRPpayout> PayoutTDSReport(payoutMemberid prp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[7];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@ViewType", prp.ViewType);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@ViewId", prp.ViewId);
            ADOprpDL.ArrayPram[2] = new SqlParameter("@id", prp.id);
            ADOprpDL.ArrayPram[3] = new SqlParameter("@date", prp.date);
            ADOprpDL.ArrayPram[4] = new SqlParameter("@group", prp.group);
            ADOprpDL.ArrayPram[5] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[6] = new SqlParameter("@pageSize", prp.pageSize);

            ADOprpDL.SPName = "spPayoutTDSReport";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPpayout objprp;
            List<PRPpayout> lst = new List<PRPpayout>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPpayout();
                    objprp.SrNo = ADOprpDL.Dr["row"].ToString();
                    objprp.Date = ADOprpDL.Dr["reportDate"].ToString();
                    objprp.Commission = ADOprpDL.Dr["reportCommission"].ToString();
                    objprp.Orc = ADOprpDL.Dr["reportORC"].ToString();
                    objprp.Growth = ADOprpDL.Dr["reportGrowth"].ToString();
                    objprp.TDS = ADOprpDL.Dr["reportTDS"].ToString();
                    objprp.HCharges = ADOprpDL.Dr["reportHandlingCharges"].ToString();
                    objprp.NetAmount = ADOprpDL.Dr["reportNetAmount"].ToString();
                    objprp.AgentID = ADOprpDL.Dr["AgentId"].ToString();
                    objprp.Name = ADOprpDL.Dr["AgentName"].ToString();
                    objprp.sponsorId = ADOprpDL.Dr["SponsorId"].ToString();
                    objprp.sponsorName = ADOprpDL.Dr["SponsorName"].ToString();
                    objprp.agentRankName = ADOprpDL.Dr["agentrankName"].ToString();

                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPpayout();
                    objprp.total = ADOprpDL.Dr["TotalAgent"].ToString();
                    objprp.Commission = ADOprpDL.Dr["reportCommission"].ToString();
                    objprp.Orc = ADOprpDL.Dr["reportORC"].ToString();
                    objprp.Growth = ADOprpDL.Dr["reportGrowth"].ToString();
                    objprp.TDS = ADOprpDL.Dr["reportTDS"].ToString();
                    objprp.HCharges = ADOprpDL.Dr["reportHandlingCharges"].ToString();
                    objprp.NetAmount = ADOprpDL.Dr["reportNetAmount"].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPpayout();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }

        public List<PRPpayout> PayoutORCAgentWise(payoutMemberid prp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@agnetId", prp.id);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@Type", prp.Type);
           
            ADOprpDL.SPName = "spORCAgentWise";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPpayout objprp;
            List<PRPpayout> lst = new List<PRPpayout>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPpayout();
                    objprp.memberCodeID = ADOprpDL.Dr["memberCodeId"].ToString();
                    objprp.Name = ADOprpDL.Dr["memberName"].ToString();
                    objprp.planName = ADOprpDL.Dr["courseName"].ToString();
                    objprp.valueNo = ADOprpDL.Dr["valueNo"].ToString();
                    objprp.valueAmount = ADOprpDL.Dr["pv"].ToString();
                    objprp.sponsorId = ADOprpDL.Dr["orcAgentId"].ToString();
                    objprp.sponsorName = ADOprpDL.Dr["agentname"].ToString();
                    objprp.rankName = ADOprpDL.Dr["agentrankName"].ToString();
                    objprp.Amount = ADOprpDL.Dr["orcAmount"].ToString();
                    
                    lst.Add(objprp);
                }
                

            }
            else
            {
                objprp = new PRPpayout();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }

        public List<PRPpayout> PayoutCommissionAgentWise(payoutMemberid prp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@agnetId", prp.id);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@Type", prp.Type);

            ADOprpDL.SPName = "spCommissionAgentwise";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPpayout objprp;
            List<PRPpayout> lst = new List<PRPpayout>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPpayout();
                    objprp.memberCodeID = ADOprpDL.Dr["memberCodeId"].ToString();
                    objprp.Name = ADOprpDL.Dr["memberName"].ToString();
                    objprp.sponsorId = ADOprpDL.Dr["memberSponsorId"].ToString();
                    objprp.sponsorName = ADOprpDL.Dr["spnrName"].ToString();
                    objprp.planName = ADOprpDL.Dr["courseName"].ToString();
                    objprp.valueAmount = ADOprpDL.Dr["pv"].ToString();
                    objprp.Commission = ADOprpDL.Dr["payoutCommission"].ToString();
                    objprp.Orc = ADOprpDL.Dr["payoutORC"].ToString();
                    objprp.rankName = ADOprpDL.Dr["rankName"].ToString();
                    objprp.valueNo = ADOprpDL.Dr["valueNo"].ToString();

                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPpayout();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }

        public List<PRPpayout> PoolPayoutTDSReport(payoutMemberid prp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[6];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@ViewType", prp.ViewType);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@id", prp.id);
            ADOprpDL.ArrayPram[2] = new SqlParameter("@sdate", prp.date);
            ADOprpDL.ArrayPram[3] = new SqlParameter("@edate", prp.date);
            ADOprpDL.ArrayPram[4] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[5] = new SqlParameter("@pageSize", prp.pageSize);

            ADOprpDL.SPName = "spJoinPoolDetail";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPpayout objprp;
            List<PRPpayout> lst = new List<PRPpayout>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPpayout();
                    objprp.SrNo = ADOprpDL.Dr["row"].ToString();
                    objprp.Date = ADOprpDL.Dr["plDate"].ToString();
                    objprp.memberId = ADOprpDL.Dr["memberCodeId"].ToString();
                    objprp.receiptNo = ADOprpDL.Dr["plRenewalId"].ToString();
                    objprp.Name = ADOprpDL.Dr["memberName"].ToString();                                        
                    objprp.Commission = ADOprpDL.Dr["pv"].ToString();                    
                    objprp.NetAmount = ADOprpDL.Dr["valueTotalAmount"].ToString();
                    objprp.insPaid = ADOprpDL.Dr["valueNo"].ToString();
                    objprp.plId = ADOprpDL.Dr["PoolId"].ToString();
                    objprp.plAgencyId = ADOprpDL.Dr["plAgencyId"].ToString();
                    objprp.plAgencyName = ADOprpDL.Dr["AgencyName"].ToString();
                    objprp.plSpId = ADOprpDL.Dr["plSponsorId"].ToString();
                    objprp.plSponsorId = ADOprpDL.Dr["SponsorId"].ToString();
                    objprp.plSponsorName = ADOprpDL.Dr["spnrName"].ToString();                                        
                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPpayout();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    
                    //objprp.total = ADOprpDL.Dr["TotalAgent"].ToString();
                    //objprp.Commission = ADOprpDL.Dr["reportCommission"].ToString();
                    //objprp.Orc = ADOprpDL.Dr["reportORC"].ToString();
                    //objprp.Growth = ADOprpDL.Dr["reportGrowth"].ToString();
                    //objprp.TDS = ADOprpDL.Dr["reportTDS"].ToString();
                    //objprp.HCharges = ADOprpDL.Dr["reportHandlingCharges"].ToString();
                    //objprp.NetAmount = ADOprpDL.Dr["reportNetAmount"].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPpayout();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }


    }
}


