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
namespace nmsProfile
{
    public class DlInstalment
    {
        //--------------------------------------------------------
        clsBLado ADO = new clsBLado();
        clsPRPadoBL ADOprp = new clsPRPadoBL();
        clsPRPadoDL ADOprpDL = new clsPRPadoDL();
        clsPRPadoBL adoBL = new clsPRPadoBL();
        //--------------------------------------------------------

        public List<prpInstalment> InstalmentDetail(clsPRPmemberId prp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[3];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.ArrayPram[2] = new SqlParameter("@investorId", prp.memberId);
            ADOprpDL.SPName = "spInstalmentDetail";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            prpInstalment objprp;
            List<prpInstalment> lst = new List<prpInstalment>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new prpInstalment();
                   // objprp.srNo = ADOprpDL.Dr["row"].ToString();
                    objprp.insNo = ADOprpDL.Dr["insNo"].ToString();
                    objprp.insDate = ADOprpDL.Dr["insDate"].ToString();
           //         objprp.graceTime = ADOprpDL.Dr["graceDate"].ToString();
                    objprp.insAmount = ADOprpDL.Dr["insAmount"].ToString();
                    objprp.inslateCharges = ADOprpDL.Dr["insLateAmount"].ToString();
                    objprp.insNetAmount = ADOprpDL.Dr["NetAmount"].ToString();
                    objprp.insStatus = ADOprpDL.Dr["insStatus"].ToString();
          //          objprp.receiptNo = ADOprpDL.Dr["RenewalId"].ToString();
                    objprp.memberID = ADOprpDL.Dr["InvesorId"].ToString();

                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new prpInstalment();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new prpInstalment();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;            

        }

        public List<prpInstalment> InstalmentNewDetail(clsPRPmemberId prp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[3];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.ArrayPram[2] = new SqlParameter("@investorId", prp.memberId);
            ADOprpDL.SPName = "spInstalmentNewDetail";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            prpInstalment objprp;
            List<prpInstalment> lst = new List<prpInstalment>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new prpInstalment();
                    objprp.srNo = ADOprpDL.Dr["row"].ToString();
                    objprp.insNo = ADOprpDL.Dr["insNo"].ToString();
                    objprp.insDate = ADOprpDL.Dr["insDate"].ToString();
                    objprp.graceTime = ADOprpDL.Dr["graceDate"].ToString();
                    objprp.insAmount = ADOprpDL.Dr["insAmount"].ToString();
                    objprp.inslateCharges = ADOprpDL.Dr["insLateAmount"].ToString();
                    objprp.insNetAmount = ADOprpDL.Dr["NetAmount"].ToString();
                    objprp.insStatus = ADOprpDL.Dr["insStatus"].ToString();
                    objprp.receiptNo = ADOprpDL.Dr["RenewalId"].ToString();
                    objprp.memberID = ADOprpDL.Dr["InvesorId"].ToString();

                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new prpInstalment();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new prpInstalment();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;



        }


        public List<prpInstalment> InstalmentReport(clsPRPmemberId prp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[4];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@id", prp.memberId);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@Type", prp.Type);
            ADOprpDL.ArrayPram[2] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[3] = new SqlParameter("@pageSize", prp.pageSize);

            ADOprpDL.SPName = "spInstalmentReport";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            prpInstalment objprp;
            List<prpInstalment> lst = new List<prpInstalment>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new prpInstalment();
                    objprp.srNo = ADOprpDL.Dr["row"].ToString();
                    objprp.memberID = ADOprpDL.Dr["memberCodeId"].ToString();
                    objprp.Name = ADOprpDL.Dr["memberName"].ToString();
                    objprp.sponsorId = ADOprpDL.Dr["memberSponsorId"].ToString();
                    objprp.joiningdate = ADOprpDL.Dr["memberJoiningDate"].ToString();
                    objprp.installmentType = ADOprpDL.Dr["insType1"].ToString();
                    objprp.installmentValue = ADOprpDL.Dr["insValue"].ToString();

                    objprp.insTotal = ADOprpDL.Dr["total"].ToString();
                    objprp.insTotalAmount = ADOprpDL.Dr["totalAmount"].ToString();
                    objprp.paidTotal = ADOprpDL.Dr["paidTotal"].ToString();
                    objprp.paidAmount = ADOprpDL.Dr["paidAmount"].ToString();
                    objprp.paidLateCharges = ADOprpDL.Dr["paidLateCharges"].ToString();
                    objprp.pendingTotal = ADOprpDL.Dr["pendingTotal"].ToString();
                    objprp.pendingAmount = ADOprpDL.Dr["pendingAmount"].ToString();
                    objprp.pendingLateCharges = ADOprpDL.Dr["pendingLateCharges"].ToString();
                    objprp.dueTotal = ADOprpDL.Dr["dueTotal"].ToString();
                    objprp.dueAmount = ADOprpDL.Dr["DueAmount"].ToString();


                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new prpInstalment();
                    objprp.noOfRecord = ADOprpDL.Dr["TotalMember"].ToString();
                    objprp.pendingTotal = ADOprpDL.Dr["TotalInstalment"].ToString();
                    objprp.pendingAmount = ADOprpDL.Dr["TotalAmount"].ToString();
                    objprp.pendingLateCharges = ADOprpDL.Dr["TotalLateCharges"].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new prpInstalment();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;



        }

        public List<prpInstalment> InstalmentReportNew(clsPRPmemberId prp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[4];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@id", prp.memberId);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@Type", prp.Type);
            ADOprpDL.ArrayPram[2] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[3] = new SqlParameter("@pageSize", prp.pageSize);

            ADOprpDL.SPName = "spInstalmentNewReport";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            prpInstalment objprp;
            List<prpInstalment> lst = new List<prpInstalment>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new prpInstalment();
                    objprp.srNo = ADOprpDL.Dr["row"].ToString();
                    objprp.memberID = ADOprpDL.Dr["memberCodeId"].ToString();
                    objprp.receiptNo = ADOprpDL.Dr["valueReceiptNo"].ToString();
                    objprp.Name = ADOprpDL.Dr["memberName"].ToString();
                    objprp.sponsorId = ADOprpDL.Dr["memberSponsorId"].ToString();
                    objprp.joiningdate = ADOprpDL.Dr["memberJoiningDate"].ToString();
                    objprp.installmentType = ADOprpDL.Dr["insType1"].ToString();
                    objprp.installmentValue = ADOprpDL.Dr["insValue"].ToString();
                    objprp.receivedFees = ADOprpDL.Dr["valueReceivedAmount"].ToString();
                    objprp.pendingAmount = ADOprpDL.Dr["valuePendingAmount"].ToString();
                    objprp.dueDate = ADOprpDL.Dr["valueDueDate"].ToString();
                    objprp.PayDate = ADOprpDL.Dr["valuePayDate"].ToString();
                    objprp.graceTime = ADOprpDL.Dr["valueGraceDate"].ToString();
                   

                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new prpInstalment();
                    objprp.noOfRecord = ADOprpDL.Dr["TotalMember"].ToString();
                    objprp.pendingTotal = ADOprpDL.Dr["TotalInstalment"].ToString();
                    objprp.pendingAmount = ADOprpDL.Dr["TotalAmount"].ToString();
                    objprp.pendingLateCharges = ADOprpDL.Dr["TotalLateCharges"].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new prpInstalment();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;



        }



        public List<prpInstalment> InstalmentReportALL(clsPRPmemberId prp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[6];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@Type", prp.Type);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@TimePeriod", prp.TimePeriod);
            ADOprpDL.ArrayPram[2] = new SqlParameter("@startDate", prp.startDate);
            ADOprpDL.ArrayPram[3] = new SqlParameter("@endDate", prp.endDate);
            ADOprpDL.ArrayPram[4] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[5] = new SqlParameter("@pageSize", prp.pageSize);

            ADOprpDL.SPName = "spInstalmentReportALL";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            prpInstalment objprp;
            List<prpInstalment> lst = new List<prpInstalment>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new prpInstalment();
                    objprp.srNo = ADOprpDL.Dr["row"].ToString();
                    objprp.memberID = ADOprpDL.Dr["memberCodeId"].ToString();
                    objprp.Name = ADOprpDL.Dr["memberName"].ToString();
                    objprp.sponsorId = ADOprpDL.Dr["memberSponsorId"].ToString();
                    objprp.joiningdate = ADOprpDL.Dr["memberJoiningDate"].ToString();
                    objprp.installmentType = ADOprpDL.Dr["insType1"].ToString();
                    objprp.installmentValue = ADOprpDL.Dr["insValue"].ToString();

                    objprp.insTotal = ADOprpDL.Dr["total"].ToString();
                    objprp.insTotalAmount = ADOprpDL.Dr["totalAmount"].ToString();
                    objprp.paidTotal = ADOprpDL.Dr["paidTotal"].ToString();
                    objprp.paidAmount = ADOprpDL.Dr["paidAmount"].ToString();
                    objprp.paidLateCharges = ADOprpDL.Dr["paidLateCharges"].ToString();
                    objprp.pendingTotal = ADOprpDL.Dr["pendingTotal"].ToString();
                    objprp.pendingAmount = ADOprpDL.Dr["pendingAmount"].ToString();
                    objprp.pendingLateCharges = ADOprpDL.Dr["pendingLateCharges"].ToString();
                    objprp.dueTotal = ADOprpDL.Dr["dueTotal"].ToString();
                    objprp.dueAmount = ADOprpDL.Dr["DueAmount"].ToString();


                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new prpInstalment();
                    objprp.noOfRecord = ADOprpDL.Dr["TotalMember"].ToString();
                    objprp.pendingTotal = ADOprpDL.Dr["TotalInstalment"].ToString();
                    objprp.pendingAmount = ADOprpDL.Dr["TotalAmount"].ToString();
                    objprp.pendingLateCharges = ADOprpDL.Dr["TotalLateCharges"].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new prpInstalment();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;



        }

        public string GetInstalment(prpLogin objprp)
        {
            adoBL.ArrayPram = new SqlParameter[4];   
            adoBL.ArrayPram[0] = new SqlParameter("@memberId", objprp.memberId);
            adoBL.ArrayPram[1] = new SqlParameter("@EmployeeId", objprp.EmployeeId);
            adoBL.ArrayPram[2] = new SqlParameter("@BranchId", objprp.branchId);
            adoBL.ArrayPram[3] = new SqlParameter("@InWord", objprp.bindStatus);

            adoBL.SPName = "spGetInstalment";
            return ADO.ScalarQueryWithProceduresandParam(adoBL);


        }
        public string GetInstalment1(prpInstalment objprp)
        {
            adoBL.ArrayPram = new SqlParameter[14];   
            adoBL.ArrayPram[0] = new SqlParameter("@memberId", objprp.memberID);
            adoBL.ArrayPram[1] = new SqlParameter("@EmployeeId", objprp.employeeId);
            adoBL.ArrayPram[2] = new SqlParameter("@BranchId", objprp.branchId);
            adoBL.ArrayPram[3] = new SqlParameter("@InWord", objprp.valueInWord);
            adoBL.ArrayPram[4] = new SqlParameter("@receiptNo",objprp.receiptNo);
            adoBL.ArrayPram[5] = new SqlParameter("@totalAmount",objprp.TotalAmount);
            adoBL.ArrayPram[6] = new SqlParameter("@receivedFees",objprp.receivedFees);
            adoBL.ArrayPram[7] = new SqlParameter("@pendingAmount",objprp.pendingAmount);
            adoBL.ArrayPram[8] = new SqlParameter("@graceTime",objprp.graceTime);
            adoBL.ArrayPram[9] = new SqlParameter("@insDate", objprp.insDate);
            adoBL.ArrayPram[10] = new SqlParameter("@examFees", objprp.examFees);
            adoBL.ArrayPram[11] = new SqlParameter("@otherFees", objprp.otherFees);
            adoBL.ArrayPram[12] = new SqlParameter("@prosFees", objprp.prosFees);
            adoBL.ArrayPram[13] = new SqlParameter("@courseFees", objprp.courseFees);

            adoBL.SPName = "spGetInstalment";
            return ADO.ScalarQueryWithProceduresandParam(adoBL);


        }


        public string CheckPendingBalance(prpInstalment objprp)
        {
            adoBL.ArrayPram = new SqlParameter[1];
            adoBL.ArrayPram[0] = new SqlParameter("@memberId", objprp.memberID);
         //   adoBL.ArrayPram[1] = new SqlParameter("@EmployeeId", objprp.EmployeeId);
         //   adoBL.ArrayPram[2] = new SqlParameter("@BranchId", objprp.branchId);
        //    adoBL.ArrayPram[3] = new SqlParameter("@InWord", objprp.bindStatus);

            adoBL.SPName = "spCheckPendingBalance";
            return ADO.ScalarQueryWithProceduresandParam(adoBL);


        }

        public prpInstalment printInsallment(prpInstalment objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@InvestorId", objprp.id);
            ADOprpDL.SPName = "spPrintInstalment";

            ADO.ReaderWithProceduresandParam(ADOprpDL);
            
            prpInstalment obj = new prpInstalment();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj.memberIdNew = ADOprpDL.Dr["valueMemberId"].ToString();
                    obj.receiptNo = ADOprpDL.Dr["valueReceiptNo"].ToString();
                    obj.insAmount = ADOprpDL.Dr["valueAmount"].ToString();
                    obj.lateFee = ADOprpDL.Dr["valueLateFee"].ToString();
                    obj.netAmount = ADOprpDL.Dr["valueNetAmount"].ToString();
                    //obj.receiptNo = ADOprpDL.Dr["valueType"].ToString();
                    obj.srNo = ADOprpDL.Dr["valueNo"].ToString();
                    obj.valueInWord = ADOprpDL.Dr["valueInWord"].ToString();
                    obj.dueDate = ADOprpDL.Dr["valueDueDate"].ToString();
                    obj.ReceiptDate = ADOprpDL.Dr["valuepayDate"].ToString();
                    obj.branchCode = ADOprpDL.Dr["branchCodeName"].ToString();
                    obj.branchName = ADOprpDL.Dr["branchName"].ToString();
                    obj.branchAddress = ADOprpDL.Dr["branchAddress"].ToString();
                    obj.branchCity = ADOprpDL.Dr["branchCity"].ToString();
                    obj.branchDistrict = ADOprpDL.Dr["branchDistrict"].ToString();
                    obj.branchState = ADOprpDL.Dr["branchState"].ToString();
                    obj.branchPhone = ADOprpDL.Dr["branchPhone"].ToString();
                    obj.retrunDate = ADOprpDL.Dr["pReturnDate"].ToString();
                    obj.retrunValue = ADOprpDL.Dr["pReturnValue"].ToString();
                    obj.plotRegiNo = ADOprpDL.Dr["plotregino"].ToString();
                    obj.sponsorId = ADOprpDL.Dr["memberSponsorId"].ToString();
                    obj.unitCode = ADOprpDL.Dr["ArankUnitcode"].ToString();
                    obj.joiningdate = ADOprpDL.Dr["memberJoiningDate"].ToString();
                    obj.planNo = ADOprpDL.Dr["planPrintName"].ToString();
                    obj.PlanValue = ADOprpDL.Dr["pValue"].ToString();
                    obj.PaymentTYPE = ADOprpDL.Dr["paymentType"].ToString();

                    obj.Name = ADOprpDL.Dr["memberName"].ToString();
                    obj.Relation = ADOprpDL.Dr["memberRelation"].ToString();
                    obj.FatherNAME = ADOprpDL.Dr["memberFatherName"].ToString();
                    obj.City = ADOprpDL.Dr["memberCity"].ToString();
                    obj.District = ADOprpDL.Dr["memberDistrict"].ToString();
                    obj.State = ADOprpDL.Dr["memberState"].ToString();
                    obj.pinCode = ADOprpDL.Dr["memberPincode"].ToString();
                    obj.Mobile = ADOprpDL.Dr["memberMobileNo"].ToString();
                    obj.Address = ADOprpDL.Dr["memberAddress"].ToString();
                    obj.nextDueDate = ADOprpDL.Dr["nextdaue"].ToString();
                    obj.joiningyear = ADOprpDL.Dr["memberJoiningyear"].ToString();
                    obj.newPlanValue = ADOprpDL.Dr["pValue"].ToString();
                    

                }
                ADO.ReaderClose(ADOprpDL);
            }
                return obj;




            
        }

        public string UpdateInstalmentPrintStatus(prpInstalment objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@repId", objprp.memberID);

            ADOprp.SPName = "spInsupdatePrintStatus";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }


        public List<prpInstalment> InstalmentPendingPrinting(clsPRPmemberId prp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);

            ADOprpDL.SPName = "spInstalmentPendingPrinting";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            prpInstalment objprp;
            List<prpInstalment> lst = new List<prpInstalment>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new prpInstalment();
                    objprp.srNo = ADOprpDL.Dr["row"].ToString();
                    objprp.receiptNo = ADOprpDL.Dr["insPrintReceiptId"].ToString();
                    objprp.memberID = ADOprpDL.Dr["valueMemberId"].ToString();
                    objprp.Name = ADOprpDL.Dr["memberName"].ToString();
                    objprp.City = ADOprpDL.Dr["memberCity"].ToString();
                    objprp.sponsorId = ADOprpDL.Dr["memberSponsorId"].ToString();
                    objprp.sponsorName = ADOprpDL.Dr["spnrName"].ToString();
                    objprp.Mobile = ADOprpDL.Dr["spnrMobileNo"].ToString();
                    objprp.insNo = ADOprpDL.Dr["valueNo"].ToString();
                    objprp.netAmount = ADOprpDL.Dr["valueNetAmount"].ToString();                                        
                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new prpInstalment();
                    objprp.noOfRecord = ADOprpDL.Dr["tot"].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new prpInstalment();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;



        }


        public string updateInstallmentStatus(prpInstalment objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[2];
            ADOprp.ArrayPram[0] = new SqlParameter("@id", objprp.receiptNo);
            ADOprp.ArrayPram[1] = new SqlParameter("@status", objprp.status);

            ADOprp.SPName = "spUpdateStatusById";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }


    }
}