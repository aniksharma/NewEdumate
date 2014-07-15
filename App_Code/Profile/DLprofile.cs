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
using nmsProfile;
namespace nmsProfile
{
    public class clsDLProfile
    {
        //--------------------------------------------------------
        clsBLado ADO = new clsBLado();
        clsPRPadoBL ADOprp = new clsPRPadoBL();
        clsPRPadoDL ADOprpDL = new clsPRPadoDL();
        clsPRPadoBL adoBL = new clsPRPadoBL(); 
        //--------------------------------------------------------

      
        public List<clsPRPprofile> selectPrint(clsPRPmemberId prp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[3];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.ArrayPram[2] = new SqlParameter("@branchId", prp.employeeId);
            ADOprpDL.SPName = "spPrintDetail";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            clsPRPprofile objprp;
            List<clsPRPprofile> lst = new List<clsPRPprofile>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new clsPRPprofile();
                    objprp.memberId = ADOprpDL.Dr["memberCodeId"].ToString();
                    objprp.Name = ADOprpDL.Dr["memberName"].ToString();
                    objprp.infoPlanVALUE = ADOprpDL.Dr["valueTotalAmount"].ToString();
                    objprp.memberJoiningDATE = ADOprpDL.Dr["memberJoiningDate"].ToString();
                    objprp.empName = ADOprpDL.Dr["employeeName"].ToString();
                    objprp.planName = ADOprpDL.Dr["courseName"].ToString(); 
            
                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new clsPRPprofile();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new clsPRPprofile();
                objprp.SrNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;


            
        }
        public DataSet selectPrintReport1(clsPRPmemberId prp)
        {
            adoBL.ArrayPram = new SqlParameter[1];
            adoBL.ArrayPram[0] = new SqlParameter("@investorId", prp.memberId);
            adoBL.SPName = "spPrintReport";

            return  ADO.DataSetWithProceduresandParam(adoBL);


        }
               
        public clsPRPprofile selectPrintReport(clsPRPmemberId prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@investorId", prp.memberId);
            ADOprpDL.SPName = "spPrintReport";
            ADO.ReaderWithProceduresandParam(ADOprpDL);
           clsPRPprofile  obj = new clsPRPprofile(); 
            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj.memberJoiningDATE = ADOprpDL.Dr["memberJoiningDate"].ToString();
                    obj.memberId = ADOprpDL.Dr["memberCodeId"].ToString();
                    obj.DOB = ADOprpDL.Dr["pSessionDate"].ToString();
                    obj.infoGuaranteedDATE = ADOprpDL.Dr["pSessionEndDate"].ToString();
                    obj.AgentID = ADOprpDL.Dr["memberSponsorId"].ToString();
                    obj.printRegisterNo = ADOprpDL.Dr["printRegisterNo"].ToString(); ;
                    
                    obj.Name = ADOprpDL.Dr["memberName"].ToString();
                    obj.Relation = ADOprpDL.Dr["memberRelation"].ToString();
                    obj.FatherNAME = ADOprpDL.Dr["memberFatherName"].ToString(); ;
                    obj.Address = ADOprpDL.Dr["memberCategory"].ToString();
                    obj.Mobile = ADOprpDL.Dr["memberMobileNo"].ToString();

                    obj.TotalAmount = ADOprpDL.Dr["ValueTotalAmount"].ToString();
                    obj.receivedFees = ADOprpDL.Dr["valueReceivedAmount"].ToString();
                    obj.pendingFees = ADOprpDL.Dr["valuePendingAmount"].ToString();

                    obj.installmentType = ADOprpDL.Dr["InsType"].ToString();
                    obj.receiptNo = ADOprpDL.Dr["valueReceiptNo"].ToString();
                    obj.infoMonth = ADOprpDL.Dr["planPeriod"].ToString();
                    obj.valueInWord = ADOprpDL.Dr["ValueInWorld"].ToString();
                    obj.insDueDate = ADOprpDL.Dr["insDueDate"].ToString();

                    obj.uniID = ADOprpDL.Dr["uniName"].ToString();
                    obj.planName = ADOprpDL.Dr["courseName"].ToString();


                    obj.branchName = ADOprpDL.Dr["branchName"].ToString();
                    obj.printAddress2 = ADOprpDL.Dr["branchAddress"].ToString();
                    obj.District = ADOprpDL.Dr["branchDistrict"].ToString();
                    obj.State = ADOprpDL.Dr["branchState"].ToString();
                    obj.City = ADOprpDL.Dr["branchCity"].ToString();
                    obj.Telephone = ADOprpDL.Dr["branchPhone"].ToString();

                     }
               
            }
            else
            {
                obj = new clsPRPprofile();
                obj.SrNo = "Result Not Find";
            }
            ADO.ReaderClose(ADOprpDL);
            return obj;




        }

        public List<clsPRPprofile> selectAgentPrint(clsPRPmemberId prp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[3];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.ArrayPram[2] = new SqlParameter("@branchId", prp.employeeId);
            ADOprpDL.SPName = "spAgentPrintDetail";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            clsPRPprofile objprp;
            List<clsPRPprofile> lst = new List<clsPRPprofile>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new clsPRPprofile();
                    objprp.memberId = ADOprpDL.Dr["memberCodeId"].ToString();
                    objprp.Name = ADOprpDL.Dr["memberName"].ToString();
                    objprp.FatherNAME = ADOprpDL.Dr["fatherName"].ToString();
                    objprp.memberJoiningDATE = ADOprpDL.Dr["memberJoiningDate"].ToString();
                    objprp.empName = ADOprpDL.Dr["employeeName"].ToString();
                    //objprp.planName = ADOprpDL.Dr["planName"].ToString();

                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new clsPRPprofile();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new clsPRPprofile();
                objprp.SrNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;



        }

        public List<clsPRPprofile> selectAgentPrintFinal(clsPRPprofile prp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@memberId", prp.memberId);
            //   ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            //    ADOprpDL.ArrayPram[2] = new SqlParameter("@branchId", prp.employeeId);
            ADOprpDL.SPName = "spAgentPrintDetailFinal";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            clsPRPprofile objprp;
            List<clsPRPprofile> lst = new List<clsPRPprofile>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new clsPRPprofile();
                    objprp.memberId = ADOprpDL.Dr["memberCodeId"].ToString();
                    objprp.sponsorId = ADOprpDL.Dr["memberSponsorId"].ToString();
                    objprp.Name = ADOprpDL.Dr["memberName"].ToString();
                    objprp.FatherNAME = ADOprpDL.Dr["memberfatherName"].ToString();
                    objprp.Address = ADOprpDL.Dr["memberAddress"].ToString();
                    objprp.DOB = ADOprpDL.Dr["memberdob"].ToString();
                    objprp.rankName = ADOprpDL.Dr["agentrankName"].ToString();
                    objprp.Mobile = ADOprpDL.Dr["memberMobileNo"].ToString();
                    objprp.PanNO = ADOprpDL.Dr["memberPanNo"].ToString();
                    objprp.imagePath = ADOprpDL.Dr["imagePath"].ToString();
                    //  objprp.empName = ADOprpDL.Dr["employeeName"].ToString();

                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new clsPRPprofile();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new clsPRPprofile();
                objprp.SrNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;



        }

        public string CheckLogin(prpLogin  objprp)
        {
            adoBL.ArrayPram = new SqlParameter[3];

            adoBL.ArrayPram[0] = new SqlParameter("@LoginName", objprp.loginName);
            adoBL.ArrayPram[1] = new SqlParameter("@password", objprp.loginPassword);
            adoBL.ArrayPram[2] = new SqlParameter("@IPaddress", objprp.IPaddress);
            

            adoBL.SPName = "spCheckLogin";

            return ADO.ScalarQueryWithProceduresandParam(adoBL);

        }

        public string CheckAgentLogin(prpLogin objprp)
        {
            adoBL.ArrayPram = new SqlParameter[3];

            adoBL.ArrayPram[0] = new SqlParameter("@LoginName", objprp.loginName);
            adoBL.ArrayPram[1] = new SqlParameter("@password", objprp.loginPassword);
            adoBL.ArrayPram[2] = new SqlParameter("@IPaddress", objprp.IPaddress);


            adoBL.SPName = "spCheckAgentLogin";

            return ADO.ScalarQueryWithProceduresandParam(adoBL);

        }
        public string UpdateAgentPassword(prpLogin objprp)
        {
            adoBL.ArrayPram = new SqlParameter[3];

            adoBL.ArrayPram[0] = new SqlParameter("@loginUserId", objprp.memberId);
            adoBL.ArrayPram[1] = new SqlParameter("@loginPassword", objprp.loginPassword);
            adoBL.ArrayPram[2] = new SqlParameter("@oldpassword", objprp.oldPassword);

            adoBL.SPName = "spUpdateAgentPassword";

            return ADO.ScalarQueryWithProceduresandParam(adoBL);

        }
        public string UpdatePassword(prpLogin objprp)
        {
            adoBL.ArrayPram = new SqlParameter[3];

            adoBL.ArrayPram[0] = new SqlParameter("@loginUserId", objprp.EmployeeId);
            adoBL.ArrayPram[1] = new SqlParameter("@loginPassword", objprp.loginPassword);
            adoBL.ArrayPram[2] = new SqlParameter("@oldpassword", objprp.oldPassword);



            adoBL.SPName = "spUpdatePassword";

            return ADO.ScalarQueryWithProceduresandParam(adoBL);

        }
        public string UpdateInstitutePassword(prpLogin objprp)
        {
            adoBL.ArrayPram = new SqlParameter[4];

            adoBL.ArrayPram[0] = new SqlParameter("@loginUserId", objprp.EmployeeId);
            adoBL.ArrayPram[1] = new SqlParameter("@loginPassword", objprp.loginPassword);
            adoBL.ArrayPram[2] = new SqlParameter("@oldpassword", objprp.oldPassword);
            adoBL.ArrayPram[3] = new SqlParameter("@LoginType", objprp.loginType);



            adoBL.SPName = "spUpdateInstitutePassword";

            return ADO.ScalarQueryWithProceduresandParam(adoBL);

        }        
        public string UpdatePrintStatus(prpLogin objprp)
        {
            adoBL.ArrayPram = new SqlParameter[3];

            adoBL.ArrayPram[0] = new SqlParameter("@printMemberId", objprp.memberId);
            adoBL.ArrayPram[1] = new SqlParameter("@printEmployeeId", objprp.EmployeeId);
            adoBL.ArrayPram[2] = new SqlParameter("@printBranchId", objprp.branchId);

            adoBL.SPName = "spUpdatePrintStatus";
            return ADO.ScalarQueryWithProceduresandParam(adoBL);

            
        }

        public string CheckInstituteLogin(prpLogin objprp)
        {
            
            adoBL.ArrayPram = new SqlParameter[3];
            adoBL.ArrayPram[0] = new SqlParameter("@LoginName", objprp.loginName);
            adoBL.ArrayPram[1] = new SqlParameter("@password", objprp.loginPassword);
            adoBL.ArrayPram[2] = new SqlParameter("@IPaddress", objprp.IPaddress);
            //adoBL.SPName = "SpCheckInstituteLogin";    // coment by devesh
            adoBL.SPName = "SpCheckInstituteLoginDevesh";

            return ADO.ScalarQueryWithProceduresandParam(adoBL);

        }


        public string SpCheckInstituteLoginWithoutPasswrod(prpLogin objprp)
        {

            adoBL.ArrayPram = new SqlParameter[3];
            adoBL.ArrayPram[0] = new SqlParameter("@LoginName", objprp.loginName);
            adoBL.ArrayPram[1] = new SqlParameter("@password", objprp.loginPassword);
            adoBL.ArrayPram[2] = new SqlParameter("@IPaddress", objprp.IPaddress);
            adoBL.SPName = "SpCheckInstituteLoginWithoutPasswrod";

            return ADO.ScalarQueryWithProceduresandParam(adoBL);

        }



        public string forgetPassword(prpLogin objprp)
        {
            adoBL.ArrayPram = new SqlParameter[1];
            adoBL.ArrayPram[0] = new SqlParameter("@emailId", objprp.emailId);

            adoBL.SPName = "forgetPassword";
            return ADO.ScalarQueryWithProceduresandParam(adoBL);
        }

        public string CheckPartnerLogin(prpLogin objprp)
        {
            adoBL.ArrayPram = new SqlParameter[3];
            adoBL.ArrayPram[0] = new SqlParameter("@partnerCod", objprp.EmployeeId);
            adoBL.ArrayPram[1] = new SqlParameter("@LoginName", objprp.loginName);
            adoBL.ArrayPram[2] = new SqlParameter("@password", objprp.loginPassword);
            adoBL.SPName = "checkPartnerLoginDetail";
            return ADO.ScalarQueryWithProceduresandParam(adoBL);
        }


        //public string CheckPrintsts(clsPRPmemberId objprp)
        //{
        //    objadoprp.Cmd = new SqlCommand();
        //    objadoprp.Cmd.CommandText = "spcheckPrintSts";
        //    objadoprp.Cmd.Parameters.AddWithValue("@investorId", objprp.memberId);
        //    objado.ScalarQuery(objadoprp);
        //    if (objadoprp.ReturnMsg == "success")
        //    {
        //        return objadoprp.ScalarValue;
        //    }
        //    else
        //    {
        //        return objadoprp.ReturnMsg;


        //    }


        //}
     
        
        
        
        //public string CheckInstalment(clsPRPmemberId objprp)
        //{
        //    objadoprp.Cmd = new SqlCommand();
        //    objadoprp.Cmd.CommandText = "spCheckInstalment";
        //    objadoprp.Cmd.Parameters.AddWithValue("@InvestorId", objprp.memberId);
        //    objado.ScalarQuery(objadoprp);
        //    if (objadoprp.ReturnMsg == "success")
        //    {
        //        return objadoprp.ScalarValue;
        //    }
        //    else
        //    {
        //        return objadoprp.ReturnMsg;


        //    }


        //}
        //public string CheckAssPassword(clsPRPmemberId objprp)
        //{
        //    objadoprp.Cmd = new SqlCommand();
        //    objadoprp.Cmd.CommandText = "spLogin";
        //    objadoprp.Cmd.Parameters.AddWithValue("@pwd", objprp.Type);
        //    objado.ScalarQuery(objadoprp);
        //    if (objadoprp.ReturnMsg == "success")
        //    {
        //        return objadoprp.ScalarValue;
        //    }
        //    else
        //    {
        //        return objadoprp.ReturnMsg;


        //    }


        //}
        //public string CheckMember(clsPRPmemberId objprp)
        //{
        //    objadoprp.Cmd = new SqlCommand();
        //    objadoprp.Cmd.CommandText = "spcheckMember";
        //    objadoprp.Cmd.Parameters.AddWithValue("@memberId", objprp.memberId);
        //    objado.ScalarQuery(objadoprp);
        //    if (objadoprp.ReturnMsg == "success")
        //    {
        //        return objadoprp.ScalarValue;
        //    }
        //    else
        //    {
        //        return objadoprp.ReturnMsg;


        //    }


        //}
        //public List<clsPRPprofile> selectProfile( clsPRPmemberId objprp)
        //{
        //    objadoprp.Cmd = new SqlCommand();
        //    objadoprp.Cmd.CommandText = "spViewProfile";
        //    objadoprp.Cmd.Parameters.AddWithValue("@memberid",objprp.memberId);
        //    objado.ReaderQuery(objadoprp);

        //    List<clsPRPprofile> list = new List<clsPRPprofile>();

        //    if (objadoprp.ReturnMsg == "success")
        //    {
        //        if (objadoprp.Dr.HasRows)
        //        {
        //            while (objadoprp.Dr.Read())
        //            {

        //                clsPRPprofile obj = new clsPRPprofile();
        //                if (objadoprp.Dr["memberName"] != DBNull.Value)
        //                obj.memberName = objadoprp.Dr["memberName"].ToString();

        //                if (objadoprp.Dr["branchName"] != DBNull.Value)
        //                obj.branchName = objadoprp.Dr["branchName"].ToString();

        //                if (objadoprp.Dr["empName"] != DBNull.Value)
        //                obj.empName = objadoprp.Dr["empName"].ToString();

        //                if (objadoprp.Dr["memberAddress"] != DBNull.Value)
        //                obj.memberAddress = objadoprp.Dr["memberAddress"].ToString();

        //                if (objadoprp.Dr["memberAge"] != DBNull.Value)
        //                obj.memberAge = objadoprp.Dr["memberAge"].ToString();

        //                if (objadoprp.Dr["memberAgentID"] != DBNull.Value)
        //                obj.memberAgentID = Convert.ToInt32(objadoprp.Dr["memberAgentID"]);

        //                if (objadoprp.Dr["memberBankACNO"] != DBNull.Value)
        //                obj.memberBankACNO = objadoprp.Dr["memberBankACNO"].ToString();
        //                if (objadoprp.Dr["memberBankBranch"] != DBNull.Value)
        //                obj.memberBankBranch = objadoprp.Dr["memberBankBranch"].ToString();
        //                if (objadoprp.Dr["memberBankName"] != DBNull.Value)
        //                obj.memberBankName = objadoprp.Dr["memberBankName"].ToString();
        //                if (objadoprp.Dr["memberBankuserNAME"] != DBNull.Value)
        //                obj.memberBankuserNAME = objadoprp.Dr["memberBankuserNAME"].ToString();
        //                if (objadoprp.Dr["memberCity"] != DBNull.Value)
        //                obj.memberCity = objadoprp.Dr["memberCity"].ToString();
        //                if (objadoprp.Dr["memberCompanyNAME"] != DBNull.Value)
        //                obj.memberCompanyNAME = objadoprp.Dr["memberCompanyNAME"].ToString();
        //                if (objadoprp.Dr["memberDistrict"] != DBNull.Value)
        //                obj.memberDistrict = objadoprp.Dr["memberDistrict"].ToString();
        //                if (objadoprp.Dr["memberDOB"] != DBNull.Value)
        //                obj.memberDOB = objadoprp.Dr["memberDOB"].ToString();
        //                if (objadoprp.Dr["memverFatherNAME"] != DBNull.Value)
        //                obj.memberFatherNAME = objadoprp.Dr["memverFatherNAME"].ToString();
        //                if (objadoprp.Dr["memberJoiningDATE"] != DBNull.Value)
        //                obj.memberJoiningDATE = objadoprp.Dr["memberJoiningDATE"].ToString();
        //                if (objadoprp.Dr["memberMarital"] != DBNull.Value)
        //                obj.memberMarital = objadoprp.Dr["memberMarital"].ToString();
        //                if (objadoprp.Dr["memberMobile"] != DBNull.Value)
        //                obj.memberMobile = objadoprp.Dr["memberMobile"].ToString();
        //                if (objadoprp.Dr["memberNomineeAGE"] != DBNull.Value)
        //                obj.memberNomineeAGE = objadoprp.Dr["memberNomineeAGE"].ToString();
        //                if (objadoprp.Dr["memberNomineeNAME"] != DBNull.Value)
        //                obj.memberNomineeNAME = objadoprp.Dr["memberNomineeNAME"].ToString();
        //                if (objadoprp.Dr["memberNomineeRELATION"] != DBNull.Value)
        //                obj.memberNomineeRELATION = objadoprp.Dr["memberNomineeRELATION"].ToString();
        //                if (objadoprp.Dr["memberPanNO"] != DBNull.Value)
        //                obj.memberPanNO = objadoprp.Dr["memberPanNO"].ToString();
        //                if (objadoprp.Dr["memberPaymemtBANKname"] != DBNull.Value)
        //                obj.memberPaymemtBANKname = objadoprp.Dr["memberPaymemtBANKname"].ToString();
        //                if (objadoprp.Dr["memberPaymentAmount"] != DBNull.Value)
        //                obj.memberPaymentAmount = Convert.ToInt32(objadoprp.Dr["memberPaymentAmount"]);
        //                if (objadoprp.Dr["memberPaymentBANKbranch"] != DBNull.Value)
        //                obj.memberPaymentBANKbranch = objadoprp.Dr["memberPaymentBANKbranch"].ToString();
        //                if (objadoprp.Dr["memberPaymentDATE"] != DBNull.Value)
        //                obj.memberPaymentDATE = objadoprp.Dr["memberPaymentDATE"].ToString();
        //                if (objadoprp.Dr["memberPaymentDDNO"] != DBNull.Value)
        //                obj.memberPaymentDDNO = objadoprp.Dr["memberPaymentDDNO"].ToString();
        //                if (objadoprp.Dr["memberPaymentTYPE"] != DBNull.Value)
        //                obj.memberPaymentTYPE = objadoprp.Dr["memberPaymentTYPE"].ToString();
        //                if (objadoprp.Dr["memberPinNO"] != DBNull.Value)
        //                obj.memberPinNO = objadoprp.Dr["memberPinNO"].ToString();
        //                if (objadoprp.Dr["memberRelation"] != DBNull.Value)
        //                obj.memberRelation = objadoprp.Dr["memberRelation"].ToString();
        //                if (objadoprp.Dr["memberSex"] != DBNull.Value)
        //                obj.memberSex = objadoprp.Dr["memberSex"].ToString();
        //                if (objadoprp.Dr["memberState"] != DBNull.Value)
        //                obj.memberState = objadoprp.Dr["memberState"].ToString();
        //                if (objadoprp.Dr["memberTelephone"] != DBNull.Value)
        //                obj.memberTelephone = objadoprp.Dr["memberTelephone"].ToString();
        //                if (objadoprp.Dr["sponsordistrict"] != DBNull.Value)
        //                obj.sponsordistrict = objadoprp.Dr["sponsordistrict"].ToString();
        //                if (objadoprp.Dr["sponsorMobile"] != DBNull.Value)
        //                obj.sponsorMobile = objadoprp.Dr["sponsorMobile"].ToString();
        //                if (objadoprp.Dr["sponsorName"] != DBNull.Value)
        //                obj.sponsorName = objadoprp.Dr["sponsorName"].ToString();
        //                if (objadoprp.Dr["memberDOBDay"] != DBNull.Value)
        //                obj.memberDOBDay = objadoprp.Dr["memberDOBDay"].ToString();
        //                if (objadoprp.Dr["memberDOBmonth"] != DBNull.Value)
        //                obj.memberDOBmonth = objadoprp.Dr["memberDOBmonth"].ToString();
        //                if (objadoprp.Dr["memberDOByear"] != DBNull.Value)
        //                obj.memberDOByear = objadoprp.Dr["memberDOByear"].ToString();



        //                if (objprp.memberId.ToString().Length == 8)
        //                {

        //                    if (objadoprp.Dr["loginPassword"] != DBNull.Value)
        //                    obj.loginPassword = objadoprp.Dr["loginPassword"].ToString();

        //                    if (objadoprp.Dr["rankName"] != DBNull.Value)
        //                    obj.rankName = objadoprp.Dr["rankName"].ToString();

        //                }
        //                else
        //                {
        //                    if (objadoprp.Dr["infoAdjustVALUE"] != DBNull.Value)
        //                    obj.infoAdjustVALUE = Convert.ToInt32(objadoprp.Dr["infoAdjustVALUE"]);
        //                    if (objadoprp.Dr["infoInstelmentValue"] != DBNull.Value)
        //                    obj.infoInstelmentValue = Convert.ToInt32(objadoprp.Dr["infoInstelmentValue"]);
        //                    if (objadoprp.Dr["infoMonth"] != DBNull.Value)
        //                    obj.infoMonth = Convert.ToInt32(objadoprp.Dr["infoMonth"]);
        //                    if (objadoprp.Dr["infoPlanVALUE"] != DBNull.Value)
        //                    obj.infoPlanVALUE = Convert.ToInt32(objadoprp.Dr["infoPlanVALUE"]);
        //                    if (objadoprp.Dr["infoPolicyID"] != DBNull.Value)
        //                    obj.infoPolicyID = Convert.ToInt32(objadoprp.Dr["infoPolicyID"]);
        //                    if (objadoprp.Dr["infoPolicyTYPE"] != DBNull.Value)
        //                    obj.infoPolicyTYPE = objadoprp.Dr["infoPolicyTYPE"].ToString();
        //                    if (objadoprp.Dr["instalmentNetAmount"] != DBNull.Value)
        //                    obj.instalmentNetAmount = Convert.ToInt32(objadoprp.Dr["instalmentNetAmount"]);
        //                    if (objadoprp.Dr["instalmentValue"] != DBNull.Value)
        //                    obj.instalmentValue = Convert.ToInt32(objadoprp.Dr["instalmentValue"]);
        //                    if (objadoprp.Dr["memberPolicyId"] != DBNull.Value)
        //                    obj.memberPolicyId = Convert.ToInt32(objadoprp.Dr["memberPolicyId"]);
        //                    if (objadoprp.Dr["memberPolicyTYPE"] != DBNull.Value)
        //                    obj.memberPolicyTYPE = objadoprp.Dr["memberPolicyTYPE"].ToString();


        //                    if (objadoprp.Dr["infoGuaranteedDATE"] != DBNull.Value)
        //                        obj.infoGuaranteedDATE = objadoprp.Dr["infoGuaranteedDATE"].ToString();
        //                    if (objadoprp.Dr["infoGuaranteedVALUE"] != DBNull.Value)
        //                        obj.infoGuaranteedValue = Convert.ToInt32(objadoprp.Dr["infoGuaranteedVALUE"]);


        //                }

        //                list.Add(obj);

        //            }

        //        }
        //        else
        //        {
        //            clsPRPprofile obj = new clsPRPprofile();
        //            obj.memberName = "Result Not Find ";
        //            list.Add(obj);
        //        }

        //    }
        //    else
        //    {
                
        //            clsPRPprofile obj = new clsPRPprofile();
        //            obj.memberName = "Result Not Find ";
        //            list.Add(obj);
        //    }

        //    objado.ReaderClose(objadoprp);

        //    return list;

        //}
        //public string UpdateProfile(clsPRPprofile objprp)
        //{
        //    objadoprp.Cmd = new SqlCommand();
        //    objadoprp.Cmd.CommandText = "spUpdateMember";
        //    objadoprp.Cmd.Parameters.AddWithValue("@memberCodeID", objprp.memberId);
        //    objadoprp.Cmd.Parameters.AddWithValue("@memberName", objprp.memberName);
        //    objadoprp.Cmd.Parameters.AddWithValue("@memberRelation", objprp.memberRelation);
        //    objadoprp.Cmd.Parameters.AddWithValue("@memberFatherNAME", objprp.memberFatherNAME);
        //    objadoprp.Cmd.Parameters.AddWithValue("@memberAddress", objprp.memberAddress);
        //    objadoprp.Cmd.Parameters.AddWithValue("@memberCity", objprp.memberCity);
        //    objadoprp.Cmd.Parameters.AddWithValue("@memberDistrict", objprp.memberDistrict);
        //    objadoprp.Cmd.Parameters.AddWithValue("@memberState", objprp.memberState);
        //    objadoprp.Cmd.Parameters.AddWithValue("@memberPinNO", objprp.memberPinNO);
        //    objadoprp.Cmd.Parameters.AddWithValue("@memberMobile", objprp.memberMobile);
        //    objadoprp.Cmd.Parameters.AddWithValue("@memberTelephone", objprp.memberTelephone);
        //    objadoprp.Cmd.Parameters.AddWithValue("@memberDOB", objprp.memberDOB);
        //    objadoprp.Cmd.Parameters.AddWithValue("@memberAge", objprp.memberAge);
        //    objadoprp.Cmd.Parameters.AddWithValue("@memberSex", objprp.memberSex);
        //    objadoprp.Cmd.Parameters.AddWithValue("@memberMarital", objprp.memberMarital);
        //    objadoprp.Cmd.Parameters.AddWithValue("@memberNomineeNAME", objprp.memberNomineeNAME);
        //    objadoprp.Cmd.Parameters.AddWithValue("@memberNomineeRELATION", objprp.memberNomineeRELATION);
        //    objadoprp.Cmd.Parameters.AddWithValue("@memberNomineeAGE", objprp.memberNomineeAGE);
        //    objadoprp.Cmd.Parameters.AddWithValue("@memberBankuserNAME", objprp.memberBankuserNAME);
        //    objadoprp.Cmd.Parameters.AddWithValue("@memberBankName", objprp.memberBankName);
        //    objadoprp.Cmd.Parameters.AddWithValue("@memberBankBranch", objprp.memberBankBranch);
        //    objadoprp.Cmd.Parameters.AddWithValue("@memberBankACNO", objprp.memberBankACNO);
        //    objadoprp.Cmd.Parameters.AddWithValue("@memberPanNO", objprp.memberPanNO);
        //    objadoprp.Cmd.Parameters.AddWithValue("@memberPaymentTYPE", objprp.memberPaymentTYPE);
        //    objadoprp.Cmd.Parameters.AddWithValue("@memberPaymentDATE", objprp.memberPaymentDATE);
        //    objadoprp.Cmd.Parameters.AddWithValue("@memberPaymentDDNO", objprp.memberPaymentDDNO);
        //    objadoprp.Cmd.Parameters.AddWithValue("@memberPaymentAmount", objprp.memberPaymentAmount);
        //    objadoprp.Cmd.Parameters.AddWithValue("@memberPaymemtBANKname", objprp.memberPaymemtBANKname);
        //    objadoprp.Cmd.Parameters.AddWithValue("@memberPaymentBANKbranch", objprp.memberPaymentBANKbranch);
        //    objado.ScalarQuery(objadoprp);

        //    if (objadoprp.ReturnMsg == "success")
        //    {
        //        return objadoprp.ScalarValue;
        //    }
        //    else
        //    {
        //        return objadoprp.ReturnMsg;


        //    }

        //}
        //public List<clsPRPprofile> InstelmentDetailByInvestorId(clsPRPmemberId objprp)
        //{
        //    objadoprp.Cmd = new SqlCommand();
        //    objadoprp.Cmd.CommandText = "spInstelamentDetail";
        //    objadoprp.Cmd.Parameters.AddWithValue("@pageIndex", objprp.pageIndex);
        //    objadoprp.Cmd.Parameters.AddWithValue("@pageSize", objprp.pageSize);
        //    objadoprp.Cmd.Parameters.AddWithValue("@InvestorId", objprp.memberId);
        //    objadoprp.Cmd.Parameters.AddWithValue("@Type", objprp.Type);
        //    objado.ReaderQuery(objadoprp);

        //    List<clsPRPprofile> list = new List<clsPRPprofile>();
        //    clsPRPprofile obj;

        //    if (objadoprp.ReturnMsg == "success")
        //    {
        //        if (objadoprp.Dr.HasRows)
        //        {
        //            while (objadoprp.Dr.Read())
        //            {

        //                obj = new clsPRPprofile();
        //                obj.SrNo = objadoprp.Dr["InstalmentNoOf"].ToString();
        //                obj.Status = objadoprp.Dr["Instelmentstatus"].ToString();
        //                obj.instalmentDate = objadoprp.Dr["InstalmentDate"].ToString();
        //                obj.Amount = objadoprp.Dr["InstalmentAmount"].ToString();
        //                obj.Extra = objadoprp.Dr["instalmentLageCharge"].ToString();
        //                obj.NetAmount = objadoprp.Dr["NetAmount"].ToString();

        //                list.Add(obj);


        //            }
        //            if (objadoprp.Dr.NextResult())
        //            {

        //                objadoprp.Dr.Read();
        //                obj = new clsPRPprofile();
        //                obj.noOfRecord = Convert.ToInt32(objadoprp.Dr[0]);
        //                list.Add(obj);
        //            }


        //        }
        //        else
        //        {
        //            obj = new clsPRPprofile();
        //            obj.SrNo = "Result Not Find";
        //            list.Add(obj);
        //        }

        //    }
        //    else
        //    {
        //        obj = new clsPRPprofile();
        //        obj.SrNo = "Result Not Find";
        //        list.Add(obj);
        //    }

        //    objado.ReaderClose(objadoprp);

        //    return list;

        //}
        //public List<clsPRPprofile> selectInvestor(clsPRPmemberId objprp)
        //{
        //    objadoprp.Cmd = new SqlCommand();
        //    objadoprp.Cmd.CommandText = "spSelectInvestor";
        //    objadoprp.Cmd.Parameters.AddWithValue("@pageIndex", objprp.pageIndex);
        //    objadoprp.Cmd.Parameters.AddWithValue("@pageSize", objprp.pageSize);
        //    objado.ReaderQuery(objadoprp);

        //    List<clsPRPprofile> list = new List<clsPRPprofile>();
        //    clsPRPprofile obj;

        //    if (objadoprp.ReturnMsg == "success")
        //    {
        //        if (objadoprp.Dr.HasRows)
        //        {
        //            while (objadoprp.Dr.Read())
        //            {

        //                obj = new clsPRPprofile();
        //                obj.memberId = Convert.ToInt32(objadoprp.Dr["memberId"]);
        //                obj.memberName=objadoprp.Dr["memberName"].ToString();
        //                obj.memberMobile = objadoprp.Dr["memberMobile"].ToString();
        //                obj.memberAgentID = Convert.ToInt32(objadoprp.Dr["memberAgentID"]);
        //                obj.sponsorName = objadoprp.Dr["sponsorName"].ToString();
        //                obj.sponsorMobile = objadoprp.Dr["sponsorMobile"].ToString();
        //                obj.planName = objadoprp.Dr["planName"].ToString();
        //                obj.infoPlanVALUE = Convert.ToInt32(objadoprp.Dr["infoPlanVALUE"]);
        //                obj.instalmentType = objadoprp.Dr["typename"].ToString();
        //                obj.branchName = objadoprp.Dr["branchName"].ToString();
        //                obj.empName = objadoprp.Dr["empName"].ToString(); ;
        //                obj.memberJoiningDATE = objadoprp.Dr["memberJoiningDATE"].ToString();
        //                list.Add(obj);
                        

        //            }
        //            if (objadoprp.Dr.NextResult())
        //            {

        //                objadoprp.Dr.Read();
        //                obj = new clsPRPprofile();
        //                obj.noOfRecord = Convert.ToInt32(objadoprp.Dr[0]);
        //                list.Add(obj);
        //            }


        //        }
        //        else
        //        {
        //            obj = new clsPRPprofile();
        //            obj.memberName = "Result Not Find ";
        //            list.Add(obj);
        //        }

        //    }
        //    else
        //    {
        //        obj = new clsPRPprofile();
        //        obj.memberName = "Result Not Find ";
        //        list.Add(obj);
        //    }

        //    objado.ReaderClose(objadoprp);

        //    return list;

        //}
        //public List<clsPRPprofile> selectAgent(clsPRPmemberId objprp)
        //{
        //    objadoprp.Cmd = new SqlCommand();
        //    objadoprp.Cmd.CommandText = "spSelectAgent";
        //    objadoprp.Cmd.Parameters.AddWithValue("@pageIndex", objprp.pageIndex);
        //    objadoprp.Cmd.Parameters.AddWithValue("@pageSize", objprp.pageSize);
        //    objado.ReaderQuery(objadoprp);

        //    List<clsPRPprofile> list = new List<clsPRPprofile>();
        //    clsPRPprofile obj;

        //    if (objadoprp.ReturnMsg == "success")
        //    {
        //        if (objadoprp.Dr.HasRows)
        //        {
        //            while (objadoprp.Dr.Read())
        //            {

        //                obj = new
        //                    clsPRPprofile();
        //                obj.memberId = Convert.ToInt32(objadoprp.Dr["memberId"]);
        //                obj.memberName = objadoprp.Dr["memberName"].ToString();
        //                obj.memberMobile = objadoprp.Dr["memberMobile"].ToString();
        //                obj.memberAgentID = Convert.ToInt32(objadoprp.Dr["memberAgentID"]);
        //                obj.sponsorName = objadoprp.Dr["sponsorName"].ToString();
        //                obj.sponsorMobile = objadoprp.Dr["sponsorMobile"].ToString();
        //                obj.rankName = objadoprp.Dr["rankName"].ToString();
        //                obj.branchName = objadoprp.Dr["branchName"].ToString();
        //                obj.empName = objadoprp.Dr["empName"].ToString(); ;
        //                obj.memberJoiningDATE = objadoprp.Dr["memberJoiningDATE"].ToString();
        //                list.Add(obj);


        //            }
        //            if (objadoprp.Dr.NextResult())
        //            {

        //                objadoprp.Dr.Read();
        //                obj = new clsPRPprofile();
        //                obj.noOfRecord = Convert.ToInt32(objadoprp.Dr[0]);
        //                list.Add(obj);
        //            }


        //        }
        //        else
        //        {
        //            obj = new clsPRPprofile();
        //            obj.memberName = "Result Not Find ";
        //            list.Add(obj);
        //        }

        //    }
        //    else
        //    {
        //        obj = new clsPRPprofile();
        //        obj.memberName = "Result Not Find ";
        //        list.Add(obj);
        //    }

        //    objado.ReaderClose(objadoprp);

        //    return list;

        //}
        //public List<clsPRPprofile> selectAffivate(clsPRPmemberId objprp)
        //{
        //    objadoprp.Cmd = new SqlCommand();
        //    objadoprp.Cmd.CommandText = "spPrintAffidavate";
        //    objadoprp.Cmd.Parameters.AddWithValue("@pageIndex", objprp.pageIndex);
        //    objadoprp.Cmd.Parameters.AddWithValue("@pageSize", objprp.pageSize);
        //    objadoprp.Cmd.Parameters.AddWithValue("@employeeId", objprp.employeeId);
        //    objado.ReaderQuery(objadoprp);

        //    List<clsPRPprofile> list = new List<clsPRPprofile>();
        //    clsPRPprofile obj;

        //    if (objadoprp.ReturnMsg == "success")
        //    {
        //        if (objadoprp.Dr.HasRows)
        //        {
        //            while (objadoprp.Dr.Read())
        //            {

        //                obj = new clsPRPprofile();
        //                obj.memberId = Convert.ToInt32(objadoprp.Dr["printreceaptNo"]);
        //                obj.memberName = objadoprp.Dr["printName"].ToString();
        //                obj.infoPlanVALUE = Convert.ToInt32(objadoprp.Dr["printPlanValue"]);
        //                obj.memberJoiningDATE = objadoprp.Dr["printDate"].ToString();
        //                obj.empName = objadoprp.Dr["empName"].ToString();
        //                list.Add(obj);


        //            }
        //            if (objadoprp.Dr.NextResult())
        //            {

        //                objadoprp.Dr.Read();
        //                obj = new clsPRPprofile();
        //                obj.noOfRecord = Convert.ToInt32(objadoprp.Dr[0]);
        //                list.Add(obj);
        //            }


        //        }
        //        else
        //        {
        //            obj = new clsPRPprofile();
        //            obj.memberName = "Result Not Find ";
        //            list.Add(obj);
        //        }

        //    }
        //    else
        //    {
        //        obj = new clsPRPprofile();
        //        obj.memberName = "Result Not Find ";
        //        list.Add(obj);
        //    }

        //    objado.ReaderClose(objadoprp);

        //    return list;

        //}
        //public clsPRPprofile selectAffivateDetail(clsPRPmemberId objprp)
        //{
        //    objadoprp.Cmd = new SqlCommand();
        //    objadoprp.Cmd.CommandText = "spPrintAffidavateDetail";
        //    objadoprp.Cmd.Parameters.AddWithValue("@MemberId", objprp.memberId);
        //    objado.ReaderQuery(objadoprp);
        //    clsPRPprofile obj = new clsPRPprofile();
        //    if (objadoprp.ReturnMsg == "success")
        //    {
        //        if (objadoprp.Dr.HasRows)
        //        {
        //            while (objadoprp.Dr.Read())
        //            {

        //                obj.memberName =  objadoprp.Dr["memberName"].ToString();
        //                obj.memberCity =  objadoprp.Dr["memberCity"].ToString();
        //                obj.memberState = objadoprp.Dr["memberState"].ToString();
        //                obj.SrNo =        objadoprp.Dr["memberId"].ToString();
        //                obj.memberId =  Convert.ToInt32( objadoprp.Dr["memberCodeID"].ToString());
        //                obj.memberJoiningDATE = objadoprp.Dr["memberJoiningDATE"].ToString();
        //                obj.infoPlanVALUE = Convert.ToInt32( objadoprp.Dr["infoPlanVALUE"].ToString());


        //            }
        //        }
        //        else
        //        {
        //            obj = new clsPRPprofile();
        //            obj.memberName = "Result Not Find ";
        //        }

        //    }
        //    else
        //    {
        //        obj = new clsPRPprofile();
        //        obj.memberName = "Result Not Find ";
        //    }

        //    objado.ReaderClose(objadoprp);

        //    return obj;

        //}
        //public clsPRPprofile InstalmetInfoByInvestor(clsPRPmemberId objprp)
        //{
        //    objadoprp.Cmd = new SqlCommand();
        //    objadoprp.Cmd.CommandText = "spInstelmentInfo";
        //    objadoprp.Cmd.Parameters.AddWithValue("@InvestorId", objprp.memberId);
        //    objado.ReaderQuery(objadoprp);
        //    clsPRPprofile obj = new clsPRPprofile();
        //    if (objadoprp.ReturnMsg == "success")
        //    {
        //        if (objadoprp.Dr.HasRows)
        //        {
        //            while (objadoprp.Dr.Read())
        //            {

        //                obj.instalmentType = objadoprp.Dr["instalmentType"].ToString();
        //                obj.instalmentValue = Convert.ToInt32(objadoprp.Dr["infoInstelmentValue"]);
        //                obj.infoInstalmentPAIDDATE = objadoprp.Dr["infoInstalmentPAIDDATE"].ToString();
        //                obj.infoInstalmentDUEDATE = objadoprp.Dr["infoInstalmentDUEDATE"].ToString();
        //                string abc = objadoprp.Dr["totalPandingAmount"].ToString();
        //                obj.instalmentNetAmount = Convert.ToInt32( objadoprp.Dr["totalPandingAmount"]);
        //                obj.instalmentLateCHARGE =Convert.ToInt32( objadoprp.Dr["totalextraCharges"]);
                        
        //                obj.TotalPanding = objadoprp.Dr["totalPanding"].ToString();
        //                obj.total = objadoprp.Dr["infoInstalmentTOTAL"].ToString();
        //                obj.totalPaid = objadoprp.Dr["infoInstalmentPaid"].ToString();
        //                obj.totalDue = objadoprp.Dr["infoInstalmentDue"].ToString();
                        
                        
        //            }
        //        }
        //        else
        //        {
        //            obj = new clsPRPprofile();
        //            obj.memberName = "Result Not Find ";
        //        }

        //    }
        //    else
        //    {
        //        obj = new clsPRPprofile();
        //        obj.memberName = "Result Not Find ";
        //    }

        //    objado.ReaderClose(objadoprp);

        //    return obj;

        //}
        //public string UpdatePrintStatus(clsPRPmemberId objprp)
        //{
        //    objadoprp.Cmd = new SqlCommand();
        //    objadoprp.Cmd.CommandText = "spUpdatePrintStatus";
        //    objadoprp.Cmd.Parameters.AddWithValue("@memberId", objprp.memberId);
        //    objado.NonQuery(objadoprp);
        //    return objadoprp.ReturnMsg;

        //}
        //public List<clsPRPprofile>ViewTreeAgent()
        //{
        //    objadoprp.Cmd = new SqlCommand();
        //    objadoprp.Cmd.CommandText = "spViewTreeAgent";
        //    objado.ReaderQuery(objadoprp);

        //    List<clsPRPprofile> list = new List<clsPRPprofile>();
        //    clsPRPprofile obj;

        //    if (objadoprp.ReturnMsg == "success")
        //    {
        //        if (objadoprp.Dr.HasRows)
        //        {
        //            while (objadoprp.Dr.Read())
        //            {

        //                obj = new
        //                    clsPRPprofile();
        //                obj.memberId = Convert.ToInt32(objadoprp.Dr["memberId"]);
        //                obj.memberCodeID = Convert.ToInt32(objadoprp.Dr["memberCodeId"]);
        //                obj.memberName = objadoprp.Dr["memberName"].ToString();
        //                obj.memberMobile = objadoprp.Dr["memberMobile"].ToString();
        //                obj.memberAgentID = Convert.ToInt32(objadoprp.Dr["memberAgentID"]);
        //                obj.sponsorName = objadoprp.Dr["sponsorName"].ToString();
        //                obj.sponsorMobile = objadoprp.Dr["sponsorMobile"].ToString();
        //                obj.rankName = objadoprp.Dr["rankName"].ToString();
        //                obj.branchName = objadoprp.Dr["branchName"].ToString();
        //                obj.empName = objadoprp.Dr["empName"].ToString(); ;
        //                obj.memberJoiningDATE = objadoprp.Dr["memberJoiningDATE"].ToString();
        //                list.Add(obj);


        //            }
                    


        //        }
        //        else
        //        {
        //            obj = new clsPRPprofile();
        //            obj.memberName = "Result Not Find ";
        //            list.Add(obj);
        //        }

        //    }
        //    else
        //    {
        //        obj = new clsPRPprofile();
        //        obj.memberName = "Result Not Find ";
        //        list.Add(obj);
        //    }

        //    objado.ReaderClose(objadoprp);

        //    return list;

        //}
      

   
    }
}
