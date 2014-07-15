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
using System.Data.SqlClient;
using nmsADOjob;
using bal.Registration;
namespace nmsJoiningJOb
{
    public class clsDLjoining
    {
        //--------------------------------------------------------
        clsBLado ADO = new clsBLado();
        clsPRPadoBL ADOprp = new clsPRPadoBL();
        clsPRPadoDL ADOprpDL = new clsPRPadoDL();
        clsPRPadoBL adoBL = new clsPRPadoBL();


        SqlParameter[] sqlParams;

         
        //--------------------------------------------------------

        public PRPjoining SelectSponsorName(PRPjoining objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@sponsorId", objprp.sponsorId);
            //ADOprpDL.ArrayPram[1] = new SqlParameter("@InstallType", objprp.installmentType);
            //ADOprpDL.ArrayPram[2] = new SqlParameter("@planValueId", objprp.planValueId);
            ADOprpDL.SPName = "spSponsorName";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPjoining obj = new PRPjoining(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj.sponsorName = ADOprpDL.Dr["sponsorName"].ToString();
                   // obj.installmentValue = ADOprpDL.Dr["insvalue"].ToString();

                }
                ADO.ReaderClose(ADOprpDL);
            }
            else
            {
                obj.sponsorName = "No";
            }

            

            return obj;

        }        
        public PRPjoining SelectPaymentDetail(PRPjoining objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@CourseId", objprp.planId);
            ADOprpDL.SPName = "selCourse";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPjoining obj = new PRPjoining(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj.courseFees = ADOprpDL.Dr["courseFees"].ToString();
                    obj.examFees = ADOprpDL.Dr["examFees"].ToString();
                    obj.otherFees = ADOprpDL.Dr["otherFees"].ToString();
                    obj.regFees = ADOprpDL.Dr["regFees"].ToString();                   
                }
                ADO.ReaderClose(ADOprpDL);
            }
            else
            {
                obj.sponsorName = "No";
            }
            

            return obj;

        }
        public PRPprofile InsertJoining(PRPprofile objprp)
        {
            
            ADOprpDL.ArrayPram = new SqlParameter[36];
            
            
            ADOprpDL.ArrayPram[0] = new SqlParameter("@universityId",objprp.uniID);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@courseId", objprp.PlanID);
            ADOprpDL.ArrayPram[2]=new SqlParameter("@pinTypeId",objprp.pinTypeId);
            ADOprpDL.ArrayPram[3]=new SqlParameter("@totalAmount",objprp.TotalAmount);
            ADOprpDL.ArrayPram[4]=new SqlParameter("@regfees",objprp.regFees);
            ADOprpDL.ArrayPram[5]=new SqlParameter("@subsidyFees",objprp.subsidyFees);
            ADOprpDL.ArrayPram[6]=new SqlParameter("@receivedFees",objprp.receivedFees);
            ADOprpDL.ArrayPram[7]=new SqlParameter("@pendingFees",objprp.pendingFees);
            ADOprpDL.ArrayPram[8]=new SqlParameter("@graceTimes",objprp.graceTime);
            ADOprpDL.ArrayPram[9]=new SqlParameter("@sessionDate",objprp.startDate);
            ADOprpDL.ArrayPram[10] = new SqlParameter("@SponsorId", objprp.AgentID);
            ADOprpDL.ArrayPram[11]=new SqlParameter("@motherName",objprp.memberMotherName);

            ADOprpDL.ArrayPram[12] = new SqlParameter("@Name", objprp.Name);
            ADOprpDL.ArrayPram[13] = new SqlParameter("@Relation", objprp.Relation);
            ADOprpDL.ArrayPram[14] = new SqlParameter("@FatherName", objprp.FatherNAME);
            
            ADOprpDL.ArrayPram[15] = new SqlParameter("@DOB", objprp.DOB);

            ADOprpDL.ArrayPram[16] = new SqlParameter("@Age", objprp.Age);
            ADOprpDL.ArrayPram[17] = new SqlParameter("@Sex", objprp.Sex);
            ADOprpDL.ArrayPram[18] = new SqlParameter("@Marital", objprp.Marital);
            ADOprpDL.ArrayPram[19] = new SqlParameter("@Address", objprp.Address);
            ADOprpDL.ArrayPram[20] = new SqlParameter("@City", objprp.City);
            ADOprpDL.ArrayPram[21] = new SqlParameter("@District", objprp.District);
            ADOprpDL.ArrayPram[22] = new SqlParameter("@State", objprp.State);
            ADOprpDL.ArrayPram[23] = new SqlParameter("@PinZipcode", objprp.pinCode);
            ADOprpDL.ArrayPram[24] = new SqlParameter("@MobileNo", objprp.Mobile);
            ADOprpDL.ArrayPram[25] = new SqlParameter("@TelePhone", objprp.Telephone);
            ADOprpDL.ArrayPram[26] = new SqlParameter("@PanNo", objprp.PanNO);
            
            ADOprpDL.ArrayPram[27] = new SqlParameter("@nomineeName", objprp.NomineeNAME);
            ADOprpDL.ArrayPram[28] = new SqlParameter("@nomineeRelation", objprp.NomineeRELATION);
            ADOprpDL.ArrayPram[29] = new SqlParameter("@nomineeAge", objprp.NomineeAGE);

            ADOprpDL.ArrayPram[30] = new SqlParameter("@nomineeDOB", objprp.NomineeDOB);
            
            ADOprpDL.ArrayPram[31] = new SqlParameter("@EmployeeId",objprp.employeeId);
            ADOprpDL.ArrayPram[32] = new SqlParameter("@BranchId",objprp.branchID);
            ADOprpDL.ArrayPram[33] = new SqlParameter("@valueInWord", objprp.valueInWord);
            ADOprpDL.ArrayPram[34] = new SqlParameter("@rankId", objprp.agentRankName);
            ADOprpDL.ArrayPram[35]=new SqlParameter("@generalCategory",objprp.memberCastCategory);

            ADOprpDL.SPName = "spJoinMember";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPprofile obj = new PRPprofile(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj.memberID = ADOprpDL.Dr["memberId"].ToString();
                    obj.password = ADOprpDL.Dr["password"].ToString();
                    obj.status = ADOprpDL.Dr["status"].ToString();

                }
            }
            ADO.ReaderClose(ADOprpDL);

            return obj;
        }
        public string InsertBankInfo(PRPprofile objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[7];
            ADOprp.ArrayPram[0] = new SqlParameter("@memberID", objprp.memberID);
            ADOprp.ArrayPram[1] = new SqlParameter("@BankUserName", objprp.BankuserNAME);
            ADOprp.ArrayPram[2] = new SqlParameter("@BankName", objprp.BankName);
            ADOprp.ArrayPram[3] = new SqlParameter("@BankBranch", objprp.BankBranch);
            ADOprp.ArrayPram[4] = new SqlParameter("@BankAcNo", objprp.BankACNO);
            ADOprp.ArrayPram[5] = new SqlParameter("@BankAddress", "");
            ADOprp.ArrayPram[6] = new SqlParameter("@BankNote", objprp.bankNote);


            ADOprp.SPName = "spJoinBankInfo";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }
        public string InsertPaymentInfo(PRPprofile objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[11];
            ADOprp.ArrayPram[0] = new SqlParameter("@memberID", objprp.memberID);
            ADOprp.ArrayPram[1] = new SqlParameter("@Type", objprp.PaymentTYPE);
            ADOprp.ArrayPram[2] = new SqlParameter("@Date", objprp.PaymentDATE);
            ADOprp.ArrayPram[3] = new SqlParameter("@DDNo", objprp.PaymentDDNO);
            ADOprp.ArrayPram[4] = new SqlParameter("@Amount", objprp.PaymentAmount);
            ADOprp.ArrayPram[5] = new SqlParameter("@BankUserName", "");
            ADOprp.ArrayPram[6] = new SqlParameter("@BankName", objprp.PaymemtBANKname);

            ADOprp.ArrayPram[7] = new SqlParameter("@BankBranch", objprp.PaymentBANKbranch);
            ADOprp.ArrayPram[8] = new SqlParameter("@BankAcNo", "");
            ADOprp.ArrayPram[9] = new SqlParameter("@BankAddress", "");
            ADOprp.ArrayPram[10] = new SqlParameter("@paymentNote", objprp.paymentNote);
            
            ADOprp.SPName = "spJoinPaymentInfo";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }        
        public string updateProfile(PRPprofile objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[17];
            ADOprp.ArrayPram[0] = new SqlParameter("@memberCodeId", objprp.memberID);
            ADOprp.ArrayPram[1] = new SqlParameter("@memberName", objprp.Name);
            ADOprp.ArrayPram[2] = new SqlParameter("@memberRelation", objprp.Relation);
            ADOprp.ArrayPram[3] = new SqlParameter("@memberFatherName", objprp.FatherNAME);
            ADOprp.ArrayPram[4] = new SqlParameter("@memberDOB", objprp.DOB);
            ADOprp.ArrayPram[5] = new SqlParameter("@memberAge", objprp.Age);
            ADOprp.ArrayPram[6] = new SqlParameter("@memberSex", objprp.Sex);
            ADOprp.ArrayPram[7] = new SqlParameter("@memberMarital", objprp.Marital);
            ADOprp.ArrayPram[8] = new SqlParameter("@memberAddress", objprp.Address);
            ADOprp.ArrayPram[9] = new SqlParameter("@memberCity", objprp.City);
            ADOprp.ArrayPram[10] = new SqlParameter("@memberDistrict", objprp.District);
            ADOprp.ArrayPram[11] = new SqlParameter("@memberState", objprp.State);
            ADOprp.ArrayPram[12] = new SqlParameter("@memberMobileNo", objprp.Mobile);
            ADOprp.ArrayPram[13] = new SqlParameter("@memberTelePhone", objprp.Telephone);
            ADOprp.ArrayPram[14] = new SqlParameter("@memberPanNo", objprp.PanNO);
            ADOprp.ArrayPram[15] = new SqlParameter("@memberMotherName", objprp.memberMotherName);
            ADOprp.ArrayPram[16] = new SqlParameter("@generalCategory", objprp.memberCastCategory);
            
            ADOprp.SPName = "UpdateMember";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }

        public string updateLogin(PRPprofile objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[3];
            ADOprp.ArrayPram[0] = new SqlParameter("@loginMemberId", objprp.memberID);
            ADOprp.ArrayPram[1] = new SqlParameter("@loginPassword", objprp.password);
            ADOprp.ArrayPram[2] = new SqlParameter("@loginStatus", objprp.status);
            
            ADOprp.SPName = "UpdateLogin";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }

        public string updateNominee(PRPprofile objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[5];
            ADOprp.ArrayPram[0] = new SqlParameter("@memberID", objprp.memberID);
            ADOprp.ArrayPram[1] = new SqlParameter("@nomineeName", objprp.NomineeNAME);
            ADOprp.ArrayPram[2] = new SqlParameter("@nomineeRelation", objprp.NomineeRELATION);
            ADOprp.ArrayPram[3] = new SqlParameter("@nomineeAge", objprp.NomineeAGE);
            ADOprp.ArrayPram[4] = new SqlParameter("@nomineeDOB", objprp.NomineeDOB);
           
            
            
            //ADOprp.ArrayPram[5] = new SqlParameter("@nomineeAddress", objprp.Address);
            //ADOprp.ArrayPram[6] = new SqlParameter("@nomineeCity", objprp.City);
            //ADOprp.ArrayPram[7] = new SqlParameter("@nomineeDistrict", objprp.District);
            //ADOprp.ArrayPram[8] = new SqlParameter("@nomineeState", objprp.State);
            //ADOprp.ArrayPram[9] = new SqlParameter("@nomineePinCode", objprp.pinCode);
            
            ADOprp.SPName = "spUpdateNomineeInfo";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }

        public string updateImage(PRPprofile objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[2];
            ADOprp.ArrayPram[0] = new SqlParameter("@memberID", objprp.memberID);
            ADOprp.ArrayPram[1] = new SqlParameter("@imagePath", objprp.imagePath);

            ADOprp.SPName = "spUpdateImage";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }


        public string getMaxId()
        {
            adoBL.SPName = "spMaxId";

            return ADO.ScalarQueryWithProcedures(adoBL);
        }


        public string updateRank(PRPprofile objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[3];
            ADOprp.ArrayPram[0] = new SqlParameter("@memberId", objprp.memberID);
            ADOprp.ArrayPram[1] = new SqlParameter("@RankId", objprp.NomineeNAME);
            ADOprp.ArrayPram[2] = new SqlParameter("@bussiness", objprp.NomineeRELATION);
            
            ADOprp.SPName = "spJoinRank2";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }
        public List<PRPprofile> ViewAdvanceInvestor(PRPjoining prp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.SPName = "spViewAdvanceInvestor";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPprofile obj;
            List<PRPprofile> lst = new List<PRPprofile>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj = new PRPprofile();
                    obj.srNo = ADOprpDL.Dr["row"].ToString();
                    obj.id = ADOprpDL.Dr["memberId"].ToString();
                    obj.memberID = ADOprpDL.Dr["memberCodeId"].ToString();
                    obj.Name = ADOprpDL.Dr["memberName"].ToString();
                    //obj.Relation = ADOprpDL.Dr["memberRelation"].ToString();
                    //obj.FatherNAME = ADOprpDL.Dr["memberFatherName"].ToString();
                    //obj.Sex = ADOprpDL.Dr["memberSex"].ToString();
                    //obj.Marital = ADOprpDL.Dr["memberMarital"].ToString();
                    //obj.DOB = ADOprpDL.Dr["memberDOB"].ToString();
                    //obj.Age = ADOprpDL.Dr["memberAge"].ToString();
                    //obj.Address = ADOprpDL.Dr["memberAddress"].ToString();
                    //obj.City = ADOprpDL.Dr["memberCity"].ToString();
                    //obj.District = ADOprpDL.Dr["memberDistrict"].ToString();
                    //obj.State = ADOprpDL.Dr["memberState"].ToString();
                    //obj.District = ADOprpDL.Dr["memberPincode"].ToString();
                   // obj.PanNO = ADOprpDL.Dr["memberPanNo"].ToString();
                    obj.joiningdate = ADOprpDL.Dr["memberJoiningDate"].ToString();
                    obj.branchId = ADOprpDL.Dr["controlBranchId"].ToString();
                    obj.branchName = ADOprpDL.Dr["branchName"].ToString();
                    //obj.NomineeNAME = ADOprpDL.Dr["nomineeName"].ToString();
                    //obj.NomineeRELATION = ADOprpDL.Dr["nomineeRelation"].ToString();
                    //obj.NomineeAGE = ADOprpDL.Dr["nomineeAge"].ToString();
                    //obj.receiptNo = ADOprpDL.Dr["valueReceiptNo"].ToString();
                    obj.PlanValue = ADOprpDL.Dr["valueTotalAmount"].ToString();
                    //obj.planType = ADOprpDL.Dr["valueType"].ToString();
                    obj.PlanID = ADOprpDL.Dr["puniId"].ToString();
                    obj.planValueId = ADOprpDL.Dr["pCourseId"].ToString();
                    obj.Month = ADOprpDL.Dr["pMinTime"].ToString();
                    obj.PlanVALUE = ADOprpDL.Dr["pv"].ToString();
                    obj.startDate = ADOprpDL.Dr["pSessionDate"].ToString();

                   // obj.retrunValue = ADOprpDL.Dr["pReturnValue"].ToString();
                    obj.retrunDate = ADOprpDL.Dr["SessioncpDate"].ToString();
                    obj.PlanName = ADOprpDL.Dr["courseName"].ToString();
                    obj.installmentValue = ADOprpDL.Dr["insValue"].ToString();
                    obj.installmentType = ADOprpDL.Dr["insType"].ToString();
                    obj.insTotal = ADOprpDL.Dr["insTotal"].ToString();
                    obj.insPaid = ADOprpDL.Dr["insPaid"].ToString();
                    obj.insDue = ADOprpDL.Dr["insDue"].ToString();
                    obj.insPaidDate = ADOprpDL.Dr["insPaidDate"].ToString();
                    obj.insDueDate = ADOprpDL.Dr["insDueDate"].ToString();

                    obj.sponsorId = ADOprpDL.Dr["memberSponsorId"].ToString();
                    //obj.sponsorName = ADOprpDL.Dr["spnrName"].ToString();
                    //obj.status = ADOprpDL.Dr["loginStatus"].ToString();
                    //obj.password = ADOprpDL.Dr["loginPassword"].ToString();
                    //obj.employeeId = ADOprpDL.Dr["controlEmployeeId"].ToString();
                    //obj.employeeName = ADOprpDL.Dr["employeename"].ToString();
                    
                    lst.Add(obj);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    obj = new PRPprofile();
                    obj.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(obj);
                }


            }
            else
            {
                obj = new PRPprofile();
                obj.srNo = "Result Not Find";
                lst.Add(obj);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
        public List<PRPprofile> ViewBasicInvestor(PRPjoining prp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[3];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.ArrayPram[2] = new SqlParameter("@branchId", prp.branchId);
            ADOprpDL.SPName = "spViewBasicInvestor";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPprofile obj;
            List<PRPprofile> lst = new List<PRPprofile>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj = new PRPprofile();
                    obj.srNo = ADOprpDL.Dr["row"].ToString();
                    obj.id = ADOprpDL.Dr["memberId"].ToString();
                    obj.memberID = ADOprpDL.Dr["memberCodeId"].ToString();
                    obj.Name = ADOprpDL.Dr["memberName"].ToString();
                    obj.Relation = ADOprpDL.Dr["memberRelation"].ToString();
                    obj.FatherNAME = ADOprpDL.Dr["memberFatherName"].ToString();
                    obj.DOB = ADOprpDL.Dr["memberDOB"].ToString();
                    obj.Age = ADOprpDL.Dr["memberAge"].ToString();
                    obj.Marital = ADOprpDL.Dr["memberMarital"].ToString();
                    obj.Sex = ADOprpDL.Dr["memberSex"].ToString();
                    obj.PanNO = ADOprpDL.Dr["memberPanNo"].ToString();
                    obj.Address = ADOprpDL.Dr["memberAddress"].ToString();
                    obj.City = ADOprpDL.Dr["memberCity"].ToString();
                    obj.District = ADOprpDL.Dr["memberDistrict"].ToString();
                    obj.State = ADOprpDL.Dr["memberState"].ToString();
                    obj.pinCode = ADOprpDL.Dr["memberPincode"].ToString();
                    obj.Mobile = ADOprpDL.Dr["memberMobileNo"].ToString();
                    obj.Telephone = ADOprpDL.Dr["memberTelePhone"].ToString();
                    obj.joiningdate = ADOprpDL.Dr["membDOJ"].ToString();
                    obj.sponsorName = ADOprpDL.Dr["spnrName"].ToString();
                    obj.sponsorMobileNo = ADOprpDL.Dr["spnrMobileNo"].ToString();
                    //obj.NomineeAGE = ADOprpDL.Dr["spnrCity"].ToString();
                    obj.sponsorId = ADOprpDL.Dr["memberSponsorId"].ToString();
                    obj.status = ADOprpDL.Dr["loginStatus"].ToString();
                    obj.password = ADOprpDL.Dr["loginPassword"].ToString();
                    obj.employeeId = ADOprpDL.Dr["controlEmployeeId"].ToString();
                    obj.employeeName = ADOprpDL.Dr["employeeName"].ToString();
                    obj.branchId = ADOprpDL.Dr["controlBranchId"].ToString();
                    obj.branchName = ADOprpDL.Dr["branchName"].ToString();
                    obj.NomineeNAME = ADOprpDL.Dr["nomineeName"].ToString();
                    obj.NomineeRELATION = ADOprpDL.Dr["nomineeRelation"].ToString();
                    obj.NomineeAGE = ADOprpDL.Dr["nomineeAge"].ToString();
                    obj.PlanName = ADOprpDL.Dr["planName"].ToString();

                    
                    lst.Add(obj);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    obj = new PRPprofile();
                    obj.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(obj);
                }


            }
            else
            {
                obj = new PRPprofile();
                obj.srNo = "Result Not Find";
                lst.Add(obj);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
        public List<PRPprofile> ViewBasicAgent(PRPjoining prp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.SPName = "spViewBasicAgent";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPprofile obj;
            List<PRPprofile> lst = new List<PRPprofile>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj = new PRPprofile();
                    obj.srNo = ADOprpDL.Dr["row"].ToString();
                    obj.id = ADOprpDL.Dr["memberId"].ToString();
                    obj.memberID = ADOprpDL.Dr["memberCodeId"].ToString();
                    obj.Name = ADOprpDL.Dr["memberName"].ToString();
                    obj.Relation = ADOprpDL.Dr["memberRelation"].ToString();
                    obj.FatherNAME = ADOprpDL.Dr["memberFatherName"].ToString();
                    obj.DOB = ADOprpDL.Dr["memberDOB"].ToString();
                    obj.Age = ADOprpDL.Dr["memberAge"].ToString();
                    obj.Marital = ADOprpDL.Dr["memberMarital"].ToString();
                    obj.Sex = ADOprpDL.Dr["memberSex"].ToString();
                    obj.PanNO = ADOprpDL.Dr["memberPanNo"].ToString();
                    obj.Address = ADOprpDL.Dr["memberAddress"].ToString();
                    obj.City = ADOprpDL.Dr["memberCity"].ToString();
                    obj.District = ADOprpDL.Dr["memberDistrict"].ToString();
                    obj.State = ADOprpDL.Dr["memberState"].ToString();
                    obj.pinCode = ADOprpDL.Dr["memberPincode"].ToString();
                    obj.Mobile = ADOprpDL.Dr["memberMobileNo"].ToString();
                    obj.Telephone = ADOprpDL.Dr["memberTelePhone"].ToString();
                    obj.joiningdate = ADOprpDL.Dr["membDOJ"].ToString();
                    obj.sponsorName = ADOprpDL.Dr["spnrName"].ToString();
                   // obj.sponsorMobileNo = ADOprpDL.Dr["spnrMobileNo"].ToString();
                    //obj.NomineeAGE = ADOprpDL.Dr["spnrCity"].ToString();
                    obj.sponsorId = ADOprpDL.Dr["memberSponsorId"].ToString();
                    obj.status = ADOprpDL.Dr["loginStatus"].ToString();
                    obj.password = ADOprpDL.Dr["loginPassword"].ToString();
                    obj.employeeId = ADOprpDL.Dr["controlEmployeeId"].ToString();
                    obj.employeeName = ADOprpDL.Dr["employeeName"].ToString();
                    obj.branchId = ADOprpDL.Dr["controlBranchId"].ToString();
                    obj.branchName = ADOprpDL.Dr["branchName"].ToString();
                    obj.NomineeNAME = ADOprpDL.Dr["nomineeName"].ToString();
                    obj.NomineeRELATION = ADOprpDL.Dr["nomineeRelation"].ToString();
                    obj.NomineeAGE = ADOprpDL.Dr["nomineeAge"].ToString();
                    obj.agentRankName = ADOprpDL.Dr["agentRankName"].ToString();


                    lst.Add(obj);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    obj = new PRPprofile();
                    obj.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(obj);
                }


            }
            else
            {
                obj = new PRPprofile();
                obj.srNo = "Result Not Find";
                lst.Add(obj);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
        public string CheckMember(PRPjoining objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[2];
            ADOprp.ArrayPram[0] = new SqlParameter("@memberId", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@memberType", objprp.memberType);
            
            ADOprp.SPName = "spcheckMember";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }


        public PRPprofile SelectAgentProfile(PRPjoining objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@memberId", objprp.id);
            ADOprpDL.SPName = "spselectAgent";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPprofile obj = new PRPprofile(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj.id = ADOprpDL.Dr["memberId"].ToString();
                    obj.memberID = ADOprpDL.Dr["memberCodeId"].ToString();
                    obj.Name = ADOprpDL.Dr["memberName"].ToString();
                    obj.Relation = ADOprpDL.Dr["memberRelation"].ToString();
                    obj.FatherNAME = ADOprpDL.Dr["memberFatherName"].ToString();
                    obj.Sex = ADOprpDL.Dr["memberSex"].ToString();
                    obj.Marital = ADOprpDL.Dr["memberMarital"].ToString();
                    obj.DOB = ADOprpDL.Dr["memberDOB"].ToString();
                    obj.Age = ADOprpDL.Dr["memberAge"].ToString();
                    
                    obj.Address = ADOprpDL.Dr["memberAddress"].ToString();
                    obj.City = ADOprpDL.Dr["memberCity"].ToString();
                    obj.District = ADOprpDL.Dr["memberDistrict"].ToString();
                    obj.State = ADOprpDL.Dr["memberState"].ToString();
                    obj.pinCode = ADOprpDL.Dr["memberPincode"].ToString();
                    obj.PanNO = ADOprpDL.Dr["memberPanNo"].ToString();
                    obj.joiningdate = ADOprpDL.Dr["memberJoiningDate"].ToString();
                    
                    obj.sponsorId = ADOprpDL.Dr["memberSponsorId"].ToString();
                    obj.sponsorName = ADOprpDL.Dr["spnrName"].ToString();
                    obj.sponsorCity = ADOprpDL.Dr["spnrCity"].ToString();
                    obj.sponsorMobileNo = ADOprpDL.Dr["spnrMobileNo"].ToString();
                    
                    obj.status = ADOprpDL.Dr["loginStatus"].ToString();
                    obj.password = ADOprpDL.Dr["loginPassword"].ToString();
                    
                    obj.employeeId = ADOprpDL.Dr["controlEmployeeId"].ToString();
                    obj.employeeName = ADOprpDL.Dr["employeename"].ToString();
                    obj.branchId = ADOprpDL.Dr["controlBranchId"].ToString();
                    obj.branchName = ADOprpDL.Dr["branchName"].ToString();
                    
                    obj.NomineeNAME = ADOprpDL.Dr["nomineeName"].ToString();
                    obj.NomineeRELATION = ADOprpDL.Dr["nomineeRelation"].ToString();
                    obj.NomineeAGE = ADOprpDL.Dr["nomineeAge"].ToString();
                    obj.NomineeDOB = ADOprpDL.Dr["nomineeDOB"].ToString();
                    obj.agentRankName = ADOprpDL.Dr["agentRankName"].ToString();

                    obj.BankACNO = ADOprpDL.Dr["bankAcNo"].ToString();
                    obj.BankName = ADOprpDL.Dr["bankName"].ToString();
                    obj.BankuserNAME = ADOprpDL.Dr["bankUserName"].ToString();
                    obj.BankBranch = ADOprpDL.Dr["bankBranch"].ToString();

                    obj.PaymentTYPE = ADOprpDL.Dr["paymentType"].ToString();
                    obj.PaymentDATE = ADOprpDL.Dr["paymentDate"].ToString();
                    obj.PaymemtBANKname = ADOprpDL.Dr["paymentBankName"].ToString();
                    obj.PaymentAmount = ADOprpDL.Dr["paymentAmount"].ToString();
                    obj.PaymentBANKbranch = ADOprpDL.Dr["paymentBankBranch"].ToString();
                    obj.PaymentDDNO = ADOprpDL.Dr["paymentDDNo"].ToString();
                    
                }
            }
            ADO.ReaderClose(ADOprpDL);

            return obj;




        }
        public PRPprofile SelectInvestorProfile(PRPjoining objprp)
        {
            
            
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@memberId", objprp.id);
            ADOprpDL.SPName = "spselectInvestor";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPprofile obj = new PRPprofile(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj.id = ADOprpDL.Dr["memberId"].ToString();
                    obj.memberID = ADOprpDL.Dr["memberCodeId"].ToString();
                    obj.Name = ADOprpDL.Dr["memberName"].ToString();
                    obj.Relation = ADOprpDL.Dr["memberRelation"].ToString();
                    obj.FatherNAME = ADOprpDL.Dr["memberFatherName"].ToString();
                    obj.Sex = ADOprpDL.Dr["memberSex"].ToString();
                    obj.Marital = ADOprpDL.Dr["memberMarital"].ToString();
                    obj.DOB = ADOprpDL.Dr["memberDOB"].ToString();
                    obj.Age = ADOprpDL.Dr["memberAge"].ToString();

                    obj.Address = ADOprpDL.Dr["memberAddress"].ToString();
                    obj.City = ADOprpDL.Dr["memberCity"].ToString();
                    obj.District = ADOprpDL.Dr["memberDistrict"].ToString();
                    obj.State = ADOprpDL.Dr["memberState"].ToString();
                    obj.pinCode = ADOprpDL.Dr["memberPincode"].ToString();
                    obj.PanNO = ADOprpDL.Dr["memberPanNo"].ToString();
                    obj.joiningdate = ADOprpDL.Dr["memberJoiningDate"].ToString();

                    obj.sponsorId = ADOprpDL.Dr["memberSponsorId"].ToString();
                    obj.sponsorName = ADOprpDL.Dr["spnrName"].ToString();
                    obj.sponsorCity = ADOprpDL.Dr["spnrCity"].ToString();
                    obj.sponsorMobileNo = ADOprpDL.Dr["spnrMobileNo"].ToString();

                    obj.status = ADOprpDL.Dr["loginStatus"].ToString();
                    obj.password = ADOprpDL.Dr["loginPassword"].ToString();

                    obj.employeeId = ADOprpDL.Dr["controlEmployeeId"].ToString();
                    obj.employeeName = ADOprpDL.Dr["employeename"].ToString();
                    obj.branchId = ADOprpDL.Dr["controlBranchId"].ToString();
                    obj.branchName = ADOprpDL.Dr["branchName"].ToString();

                    obj.NomineeNAME = ADOprpDL.Dr["nomineeName"].ToString();
                    obj.NomineeRELATION = ADOprpDL.Dr["nomineeRelation"].ToString();
                    obj.NomineeAGE = ADOprpDL.Dr["nomineeAge"].ToString();
                    obj.NomineeDOB = ADOprpDL.Dr["nomineeDOB"].ToString();
                    //obj.agentRankName = ADOprpDL.Dr["agentRankName"].ToString();

                    obj.BankACNO = ADOprpDL.Dr["bankAcNo"].ToString();
                    obj.BankName = ADOprpDL.Dr["bankName"].ToString();
                    obj.BankuserNAME = ADOprpDL.Dr["bankUserName"].ToString();
                    obj.BankBranch = ADOprpDL.Dr["bankBranch"].ToString();

                    obj.PaymentTYPE = ADOprpDL.Dr["paymentType"].ToString();
                    obj.PaymentDATE = ADOprpDL.Dr["paymentDate"].ToString();
                    obj.PaymemtBANKname = ADOprpDL.Dr["paymentBankName"].ToString();
                    obj.PaymentAmount = ADOprpDL.Dr["paymentAmount"].ToString();
                    obj.PaymentBANKbranch = ADOprpDL.Dr["paymentBankBranch"].ToString();
                    obj.PaymentDDNO = ADOprpDL.Dr["paymentDDNo"].ToString();

                    obj.PlanName = ADOprpDL.Dr["courseName"].ToString();
                    obj.PlanValue = ADOprpDL.Dr["ValueTotalAmount"].ToString();
                    obj.uniID = ADOprpDL.Dr["uniName"].ToString();
                    obj.retrunDate = ADOprpDL.Dr["pSessionEndDate"].ToString();
                  //  obj.retrunValue = ADOprpDL.Dr["pReturnValue"].ToString();


                    obj.installmentType = ADOprpDL.Dr["insType"].ToString();
                    obj.installmentValue = ADOprpDL.Dr["valueTotalAmount"].ToString();                    
                    obj.insTotal = ADOprpDL.Dr["insTotal"].ToString();
                    obj.insPaid = ADOprpDL.Dr["insPaid"].ToString();
                    obj.insDue = ADOprpDL.Dr["insDue"].ToString();
                    
                }
            }
            ADO.ReaderClose(ADOprpDL);

            return obj;




        }
        public PRPprofile SelectMemberProfile(PRPjoining objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@memberId", objprp.id);
            ADOprpDL.SPName = "spSelectMember";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPprofile obj = new PRPprofile(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj.id = ADOprpDL.Dr["memberId"].ToString();
                    obj.memberID = ADOprpDL.Dr["memberCodeId"].ToString();
                    obj.Name = ADOprpDL.Dr["memberName"].ToString();
                    obj.Relation = ADOprpDL.Dr["memberRelation"].ToString();
                    obj.FatherNAME = ADOprpDL.Dr["memberFatherName"].ToString();
                    obj.memberMotherName = ADOprpDL.Dr["memberMotherName"].ToString();
                    obj.memberCastCategory = ADOprpDL.Dr["memberCategory"].ToString();
                    obj.Sex = ADOprpDL.Dr["memberSex"].ToString();
                    obj.Marital = ADOprpDL.Dr["memberMarital"].ToString();
                    obj.DOB = ADOprpDL.Dr["memberDOB"].ToString();
                    obj.Age = ADOprpDL.Dr["memberAge"].ToString();

                    obj.memberMotherName = ADOprpDL.Dr["memberMotherName"].ToString();
                    obj.memberCastCategory = ADOprpDL.Dr["memberCategory"].ToString();

                    obj.Address = ADOprpDL.Dr["memberAddress"].ToString();
                    obj.City = ADOprpDL.Dr["memberCity"].ToString();
                    obj.District = ADOprpDL.Dr["memberDistrict"].ToString();
                    obj.State = ADOprpDL.Dr["memberState"].ToString();
                    obj.pinCode = ADOprpDL.Dr["memberPincode"].ToString();
                    obj.PanNO = ADOprpDL.Dr["memberPanNo"].ToString();
                    obj.joiningdate = ADOprpDL.Dr["memberJoiningDate"].ToString();
                    obj.Mobile = ADOprpDL.Dr["memberMobileNo"].ToString();
                    obj.Telephone = ADOprpDL.Dr["memberTelePhone"].ToString();

                    obj.sponsorId = ADOprpDL.Dr["memberSponsorId"].ToString();
                    obj.sponsorName = ADOprpDL.Dr["spnrName"].ToString();
                    obj.sponsorCity = ADOprpDL.Dr["spnrCity"].ToString();
                    obj.sponsorMobileNo = ADOprpDL.Dr["spnrMobileNo"].ToString();

                    obj.status = ADOprpDL.Dr["loginStatus"].ToString();
                    obj.password = ADOprpDL.Dr["loginPassword"].ToString();

                    obj.employeeId = ADOprpDL.Dr["controlEmployeeId"].ToString();
                    obj.employeeName = ADOprpDL.Dr["employeename"].ToString();
                    obj.branchId = ADOprpDL.Dr["controlBranchId"].ToString();
                    obj.branchName = ADOprpDL.Dr["branchName"].ToString();

                    obj.NomineeNAME = ADOprpDL.Dr["nomineeName"].ToString();
                    obj.NomineeRELATION = ADOprpDL.Dr["nomineeRelation"].ToString();
                    obj.NomineeAGE = ADOprpDL.Dr["nomineeAge"].ToString();
                    obj.NomineeDOB = ADOprpDL.Dr["nomineeDOB"].ToString();
                    //obj.agentRankName = ADOprpDL.Dr["agentRankName"].ToString();


                    obj.BankACNO = ADOprpDL.Dr["bankAcNo"].ToString();
                    obj.BankName = ADOprpDL.Dr["bankName"].ToString();
                    obj.BankuserNAME = ADOprpDL.Dr["bankUserName"].ToString();
                    obj.BankBranch = ADOprpDL.Dr["bankBranch"].ToString();
                    obj.bankNote = ADOprpDL.Dr["bankNote"].ToString();

                    obj.PaymentTYPE = ADOprpDL.Dr["paymentType"].ToString();
                    obj.PaymentDATE = ADOprpDL.Dr["paymentDate"].ToString();
                    obj.PaymemtBANKname = ADOprpDL.Dr["paymentBankName"].ToString();
                    obj.PaymentAmount = ADOprpDL.Dr["paymentAmount"].ToString();
                    obj.PaymentBANKbranch = ADOprpDL.Dr["paymentBankBranch"].ToString();
                    obj.PaymentDDNO = ADOprpDL.Dr["paymentDDNo"].ToString();
                    obj.paymentNote = ADOprpDL.Dr["paymentNote"].ToString();


                    obj.dobDay = ADOprpDL.Dr["dbodays"].ToString();
                    obj.dobMoths = ADOprpDL.Dr["dbmonths"].ToString();
                    obj.dobYear = ADOprpDL.Dr["dobyears"].ToString();
                    obj.imagePath = ADOprpDL.Dr["imagePath"].ToString();                    
                }
            }
            ADO.ReaderClose(ADOprpDL);

            return obj;




        }
        
        public List<PRPprofile> search(PRPprofile prp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[23];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@searchType", prp.searchType);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@memberId", prp.memberID);
            ADOprpDL.ArrayPram[2] = new SqlParameter("@planId", prp.planId);
            ADOprpDL.ArrayPram[3] = new SqlParameter("@Name", prp.Name);
            ADOprpDL.ArrayPram[4] = new SqlParameter("@fatherName", prp.FatherNAME);
            ADOprpDL.ArrayPram[5] = new SqlParameter("@NomineeName", prp.NomineeNAME);
            ADOprpDL.ArrayPram[6] = new SqlParameter("@DOBYear", prp.dobYear);
            ADOprpDL.ArrayPram[7] = new SqlParameter("@address", prp.Address);
            ADOprpDL.ArrayPram[8] = new SqlParameter("@pinCode", prp.pinCode);
            ADOprpDL.ArrayPram[9] = new SqlParameter("@city", prp.City);
            ADOprpDL.ArrayPram[10] = new SqlParameter("@district", prp.District);
            ADOprpDL.ArrayPram[11] = new SqlParameter("@state", prp.State);
            ADOprpDL.ArrayPram[12] = new SqlParameter("@panNo", prp.PanNO);
            ADOprpDL.ArrayPram[13] = new SqlParameter("@mobileNo", prp.Mobile);
            ADOprpDL.ArrayPram[14] = new SqlParameter("@phoneNo", prp.Telephone);
            ADOprpDL.ArrayPram[15] = new SqlParameter("@sponsorId", prp.sponsorId);
            ADOprpDL.ArrayPram[16] = new SqlParameter("@sponsorName", prp.sponsorName);
            ADOprpDL.ArrayPram[17] = new SqlParameter("@startDate", prp.startDate);
            ADOprpDL.ArrayPram[18] = new SqlParameter("@enddate", prp.endDate);
            ADOprpDL.ArrayPram[19] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[20] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.ArrayPram[21] = new SqlParameter("@courseTypeId", prp.planValueId);
            ADOprpDL.ArrayPram[22] = new SqlParameter("@courseId", prp.courseId);

            ADOprpDL.SPName = "spSearch";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPprofile obj;
            List<PRPprofile> lst = new List<PRPprofile>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj = new PRPprofile();
                    obj.srNo = ADOprpDL.Dr["row"].ToString();
                    obj.id = ADOprpDL.Dr["memberId"].ToString();
                    obj.memberID = ADOprpDL.Dr["memberCodeId"].ToString();
                    obj.Name = ADOprpDL.Dr["memberName"].ToString();
                    obj.Relation = ADOprpDL.Dr["memberRelation"].ToString();
                    obj.FatherNAME = ADOprpDL.Dr["memberFatherName"].ToString();
                    obj.DOB = ADOprpDL.Dr["memberDOB"].ToString();
                    obj.Age = ADOprpDL.Dr["memberAge"].ToString();
                    obj.Marital = ADOprpDL.Dr["memberMarital"].ToString();
                    obj.Sex = ADOprpDL.Dr["memberSex"].ToString();
                    obj.PanNO = ADOprpDL.Dr["memberPanNo"].ToString();
                    obj.Address = ADOprpDL.Dr["memberAddress"].ToString();
                    obj.City = ADOprpDL.Dr["memberCity"].ToString();
                    obj.District = ADOprpDL.Dr["memberDistrict"].ToString();
                    obj.State = ADOprpDL.Dr["memberState"].ToString();
                    obj.pinCode = ADOprpDL.Dr["memberPincode"].ToString();
                    obj.Mobile = ADOprpDL.Dr["memberMobileNo"].ToString();
                    obj.Telephone = ADOprpDL.Dr["memberTelePhone"].ToString();
                    obj.joiningdate = ADOprpDL.Dr["membDOJ"].ToString();
                    obj.sponsorName = ADOprpDL.Dr["spnrName"].ToString();
                    // obj.sponsorMobileNo = ADOprpDL.Dr["spnrMobileNo"].ToString();
                    //obj.NomineeAGE = ADOprpDL.Dr["spnrCity"].ToString();
                    obj.sponsorId = ADOprpDL.Dr["memberSponsorId"].ToString();
                    obj.status = ADOprpDL.Dr["loginStatus"].ToString();
                    obj.password = ADOprpDL.Dr["loginPassword"].ToString();
                    obj.employeeId = ADOprpDL.Dr["controlEmployeeId"].ToString();
                    obj.employeeName = ADOprpDL.Dr["employeeName"].ToString();
                    obj.branchId = ADOprpDL.Dr["controlBranchId"].ToString();
                    obj.branchName = ADOprpDL.Dr["branchName"].ToString();
                    obj.NomineeNAME = ADOprpDL.Dr["nomineeName"].ToString();
                    obj.NomineeRELATION = ADOprpDL.Dr["nomineeRelation"].ToString();
                    obj.NomineeAGE = ADOprpDL.Dr["nomineeAge"].ToString();
                    obj.PlanName = ADOprpDL.Dr["Type1"].ToString();


                    lst.Add(obj);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    obj = new PRPprofile();
                    obj.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(obj);
                }


            }
            else
            {
                obj = new PRPprofile();
                obj.srNo = "Result Not Find";
                lst.Add(obj);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }


        public string SetForReprinting(PRPjoining objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[4];
            ADOprp.ArrayPram[0] = new SqlParameter("@id", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@employeeId", objprp.employeeId);
            ADOprp.ArrayPram[2] = new SqlParameter("@branchId", objprp.branchId);
            ADOprp.ArrayPram[3] = new SqlParameter("@deleteResion", objprp.valueInWord);

            ADOprp.SPName = "spRePrintingMember";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }


        public string SetForREInstalment(PRPjoining objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[4];
            ADOprp.ArrayPram[0] = new SqlParameter("@id", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@employeeId", objprp.employeeId);
            ADOprp.ArrayPram[2] = new SqlParameter("@branchId", objprp.branchId);
            ADOprp.ArrayPram[3] = new SqlParameter("@deleteResion", objprp.valueInWord);

            ADOprp.SPName = "spRePrintingMemberINS";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }

        
        public string deleteMember(PRPjoining objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[4];
            ADOprp.ArrayPram[0] = new SqlParameter("@id", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@employeeId", objprp.employeeId);
            ADOprp.ArrayPram[2] = new SqlParameter("@branchId", objprp.branchId);
            ADOprp.ArrayPram[3] = new SqlParameter("@deleteResion", objprp.valueInWord);

            ADOprp.SPName = "spDeleteMember";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }

        public string DeleteInstallment(PRPjoining objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[4];
            ADOprp.ArrayPram[0] = new SqlParameter("@id", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@employeeId", objprp.employeeId);
            ADOprp.ArrayPram[2] = new SqlParameter("@branchId", objprp.branchId);
            ADOprp.ArrayPram[3] = new SqlParameter("@deleteResion", objprp.valueInWord);

            ADOprp.SPName = "spDeleteInstallment";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }


        public List<PRPprofile> spBusinessReoport(PRPprofile prp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[5];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@BarnchId", prp.branchID);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@startDate", prp.startDate);
            ADOprpDL.ArrayPram[2] = new SqlParameter("@enddate", prp.endDate);
            ADOprpDL.ArrayPram[3] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[4] = new SqlParameter("@pageSize", prp.pageSize);

            ADOprpDL.SPName = "spBusinessReoport";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPprofile obj;
            List<PRPprofile> lst = new List<PRPprofile>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj = new PRPprofile();
                    obj.srNo = ADOprpDL.Dr["row"].ToString();
                    obj.id = ADOprpDL.Dr["memberId"].ToString();
                    obj.memberID = ADOprpDL.Dr["memberCodeId"].ToString();
                    obj.Name = ADOprpDL.Dr["memberName"].ToString();
                    obj.receiptNo = ADOprpDL.Dr["valueReceiptNo"].ToString();
                    obj.valueAmount = ADOprpDL.Dr["valueTotalAmount"].ToString();
                    obj.regFees = ADOprpDL.Dr["valueRegFee"].ToString();
                    obj.subsidyFees = ADOprpDL.Dr["valueSubsidyFee"].ToString();
                    obj.receivedFees = ADOprpDL.Dr["valueReceivedAmount"].ToString();
                    obj.pendingFees = ADOprpDL.Dr["valuePendingAmount"].ToString();

                    obj.valueNo = ADOprpDL.Dr["valueNo"].ToString();
                    obj.dueDate = ADOprpDL.Dr["valueDueDate"].ToString();
                    obj.PayDate = ADOprpDL.Dr["valuePayDate"].ToString();
                    obj.graceTime = ADOprpDL.Dr["valueGraceDate"].ToString();
                    obj.planType = ADOprpDL.Dr["typeName"].ToString();
                    obj.PlanName = ADOprpDL.Dr["courseName"].ToString();
                    obj.sponsorId = ADOprpDL.Dr["memberSponsorId"].ToString();

                    lst.Add(obj);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    obj = new PRPprofile();
                    obj.noOfRecord = ADOprpDL.Dr["total"].ToString();
                    obj.TotalAmount = ADOprpDL.Dr["TotalAmount"].ToString();
                    obj.receivedFees = ADOprpDL.Dr["TotalReceivedAmount"].ToString();
                    obj.pendingFees = ADOprpDL.Dr["TotalPendingAmount"].ToString();
                    obj.TotalMember = ADOprpDL.Dr["total"].ToString();
                    obj.TotalFresh = ADOprpDL.Dr["TotalNew"].ToString();
                    obj.TotalInvestor = ADOprpDL.Dr["TotalInstallment"].ToString();
                  
                    lst.Add(obj);
                }


            }
            else
            {
                obj = new PRPprofile();
                obj.srNo = "Result Not Find";
                lst.Add(obj);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }



        public string InsertPersonalDetail(UserRegistraionProp objUserRegistraionProp)
        {
             sqlParams = new SqlParameter[]
            {
                new SqlParameter("@para_Role_Id", objUserRegistraionProp.jpd_Role_Id),
                new SqlParameter("@para_first_name", objUserRegistraionProp.jpd_First_Name),
                new SqlParameter("@para_Last_Name", objUserRegistraionProp.JPD_Last_Name),
                new SqlParameter("@para_Mobile_No", objUserRegistraionProp.jpd_Mobile_No),
                new SqlParameter("@para_Dateofbirth", objUserRegistraionProp.jpd_Date_Of_Birth),
               
                new SqlParameter("@para_Gender", objUserRegistraionProp.jpd_Gender),
                
                            
                new SqlParameter("@para_Specialization_Id",objUserRegistraionProp.JHQD_Specilization_Id),
                new SqlParameter("@para_Total_Experience_Year",objUserRegistraionProp.JWD_Total_Experience_Year),
                new SqlParameter("@para_Total_Experience_Month",objUserRegistraionProp.JWD_Total_Experience_Month),
                new SqlParameter("@para_City_Id",objUserRegistraionProp.JPD_City_Id),
                new SqlParameter("@para_Email_Id", objUserRegistraionProp.JLD_Emial_Id),
                new SqlParameter("@para_Password",objUserRegistraionProp.JLD_password),
                new SqlParameter("@other_qualification",objUserRegistraionProp.MINS_Institute_Description)

               };

             ADOprp.ArrayPram = sqlParams;
             ADOprp.SPName = "job_Insert_PersonalDetails";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }

    }


}

