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
using nmsADO;
using nmsProfile;
using nmsJoining;
namespace nmsOffice
{
    public class DLoffice
    {
        //--------------------------------------------------------
        clsBLado ADO = new clsBLado();
        clsPRPadoBL ADOprp = new clsPRPadoBL();
        clsPRPadoDL ADOprpDL = new clsPRPadoDL();
        //------------------------------------------------

        //------------------------start----designation--------------------


        public string spOpenPayment(PRPOffice objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[2];
            ADOprp.ArrayPram[0] = new SqlParameter("@openAmount", objprp.srNo);
            ADOprp.ArrayPram[1] = new SqlParameter("@openIP", objprp.id);

            ADOprp.SPName = "spOpenPayment";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }



        public string InsertDesignation(PRPOffice objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[2];
            ADOprp.ArrayPram[0] = new SqlParameter("@designationName", objprp.designationName);
            ADOprp.ArrayPram[1] = new SqlParameter("@designationStatus", objprp.designationStatus);

            ADOprp.SPName = "insertDesignation";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }
        public string UpdateDesignation(PRPOffice objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[3];

            ADOprp.ArrayPram[0] = new SqlParameter("@designationId", objprp.designationId);
            ADOprp.ArrayPram[1] = new SqlParameter("@designationName", objprp.designationName);
            ADOprp.ArrayPram[2] = new SqlParameter("@designationStatus", objprp.designationStatus);

            ADOprp.SPName = "UpdateDesignation";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }
        public string DeleteDesignation(PRPOffice objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@designationId", objprp.designationId);
            ADOprp.SPName = "deleteDesignation";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);



        }        
        public DataTable SelectDesignation(PRPOffice objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];

            ADOprp.ArrayPram[0] = new SqlParameter("@designationId", objprp.designationId);

            ADOprp.SPName = "SelectDesignation";

            return ADO.DataTableWithProcedures(ADOprp);


        }
        public DataTable ViewDesignation()
        {
            ADOprp.SPName = "viewDesignation";

            return ADO.DataTableWithProcedures(ADOprp);


        }        
        //------------------------end----designation-----------------
        
        //------------------------start----Branch--------------------

        public string InsertBranch(PRPOffice objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[16];
            ADOprp.ArrayPram[0] = new SqlParameter("@branchName", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@branchMainLandMark", objprp.mainLandMark);
            ADOprp.ArrayPram[2] = new SqlParameter("@branchAddress", objprp.address);
            ADOprp.ArrayPram[3] = new SqlParameter("@branchCity", objprp.city);
            ADOprp.ArrayPram[4] = new SqlParameter("@branchDistrict", objprp.district);
            ADOprp.ArrayPram[5] = new SqlParameter("@branchState", objprp.state);
            ADOprp.ArrayPram[6] = new SqlParameter("@branchPhone", objprp.phoneNo);
            ADOprp.ArrayPram[7] = new SqlParameter("@branchMobNo", objprp.mobNo);
            ADOprp.ArrayPram[8] = new SqlParameter("@branchMailId", objprp.mailId);
            ADOprp.ArrayPram[9] = new SqlParameter("@branchSecurity", objprp.security);
            ADOprp.ArrayPram[10] = new SqlParameter("@branchStatus", objprp.status);
            ADOprp.ArrayPram[11] = new SqlParameter("@branchCodeName", objprp.branchCodeName);
            ADOprp.ArrayPram[12] = new SqlParameter("@urlPath", objprp.urlPath);
            ADOprp.ArrayPram[13] = new SqlParameter("@branchType", objprp.branchType);
            ADOprp.ArrayPram[14] = new SqlParameter("@branchLoginStatus", objprp.branchLoginStatus);
            ADOprp.ArrayPram[15]=new SqlParameter("@branchPassword",objprp.Password);

            ADOprp.SPName = "InsertBranch";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }
        public string UpdateBranch(PRPOffice objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[17];
            ADOprp.ArrayPram[0] = new SqlParameter("@branchName", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@branchMainLandMark", objprp.mainLandMark);
            ADOprp.ArrayPram[2] = new SqlParameter("@branchAddress", objprp.address);
            ADOprp.ArrayPram[3] = new SqlParameter("@branchCity", objprp.city);
            ADOprp.ArrayPram[4] = new SqlParameter("@branchDistrict", objprp.district);
            ADOprp.ArrayPram[5] = new SqlParameter("@branchState", objprp.state);
            ADOprp.ArrayPram[6] = new SqlParameter("@branchPhone", objprp.phoneNo);
            ADOprp.ArrayPram[7] = new SqlParameter("@branchMobNo", objprp.mobNo);
            ADOprp.ArrayPram[8] = new SqlParameter("@branchMailId", objprp.mailId);
            ADOprp.ArrayPram[9] = new SqlParameter("@branchSecurity", objprp.security);
            ADOprp.ArrayPram[10] = new SqlParameter("@branchStatus", objprp.status);
            ADOprp.ArrayPram[11] = new SqlParameter("@branchCodeId", objprp.codeId);
            ADOprp.ArrayPram[12] = new SqlParameter("@branchCodeName", objprp.branchCodeName);
            ADOprp.ArrayPram[13] = new SqlParameter("@urlPath", objprp.urlPath);
            ADOprp.ArrayPram[14] = new SqlParameter("@branchType", objprp.branchType);
            ADOprp.ArrayPram[15] = new SqlParameter("@branchLoginStatus", objprp.branchLoginStatus);
            ADOprp.ArrayPram[16] = new SqlParameter("@branchPassword", objprp.Password);


            ADOprp.SPName = "UpdateBranch";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }
        public string DeleteBranch(PRPOffice objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@branchCodeId", objprp.codeId);
            ADOprp.SPName = "deleteBranch";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);



        }       
        public PRPOffice SelectBranch(PRPOffice objprp)
        {            
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@branchCodeId", objprp.codeId);
            ADOprpDL.SPName = "SelectBranch";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPOffice obj = new PRPOffice(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj.id = ADOprpDL.Dr["branchId"].ToString();
                    obj.codeId = ADOprpDL.Dr["branchCodeId"].ToString();
                    obj.name = ADOprpDL.Dr["branchName"].ToString();
                    obj.mainLandMark = ADOprpDL.Dr["branchMainLandMark"].ToString();
                    obj.address = ADOprpDL.Dr["branchAddress"].ToString();
                    obj.city = ADOprpDL.Dr["branchCity"].ToString();
                    obj.district = ADOprpDL.Dr["branchDistrict"].ToString();
                    obj.state = ADOprpDL.Dr["branchState"].ToString();
                    obj.phoneNo = ADOprpDL.Dr["branchPhone"].ToString();
                    obj.mobNo = ADOprpDL.Dr["branchMobNo"].ToString();
                    obj.mailId = ADOprpDL.Dr["branchMailId"].ToString();
                    obj.DOJ = ADOprpDL.Dr["branchDOJ"].ToString();
                    obj.security = ADOprpDL.Dr["branchSecurity"].ToString();
                    obj.status = ADOprpDL.Dr["branchStatus"].ToString();
                    obj.branchCodeName = ADOprpDL.Dr["branchCodeName"].ToString();
                    obj.urlPath = ADOprpDL.Dr["branchImage"].ToString();
                    obj.Password = ADOprpDL.Dr["branchPassword"].ToString();
                    obj.branchLoginStatus = ADOprpDL.Dr["branchLoginStatus"].ToString();
                    obj.branchType = ADOprpDL.Dr["branchType"].ToString();
                }
            }
            ADO.ReaderClose(ADOprpDL);

            return obj;            
        }      
        public List<PRPOffice> ViewBranch(PRPOffice prp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.SPName = "viewBranch";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPOffice objprp;
            List<PRPOffice> lst = new List<PRPOffice>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPOffice();
                    objprp.id = ADOprpDL.Dr["branchId"].ToString();
                    objprp.codeId = ADOprpDL.Dr["branchCodeId"].ToString();
                    objprp.name = ADOprpDL.Dr["branchName"].ToString();
                    objprp.mainLandMark = ADOprpDL.Dr["branchMainLandMark"].ToString();
                    objprp.address = ADOprpDL.Dr["branchAddress"].ToString();
                    objprp.city = ADOprpDL.Dr["branchCity"].ToString();
                    objprp.district = ADOprpDL.Dr["branchDistrict"].ToString();
                    objprp.state = ADOprpDL.Dr["branchState"].ToString();
                    objprp.phoneNo = ADOprpDL.Dr["branchPhone"].ToString();
                    objprp.mobNo = ADOprpDL.Dr["branchMobNo"].ToString();
                    objprp.mailId = ADOprpDL.Dr["branchMailId"].ToString();
                    objprp.DOJ = ADOprpDL.Dr["branchDOJ"].ToString();
                    objprp.security = ADOprpDL.Dr["branchSecurity"].ToString();
                    objprp.status = ADOprpDL.Dr["branchStatus"].ToString();
                    objprp.branchCodeName = ADOprpDL.Dr["branchCodeName"].ToString();
                    objprp.urlPath = ADOprpDL.Dr["branchImage"].ToString();
                    objprp.Password = ADOprpDL.Dr["branchPassword"].ToString();
                    objprp.branchLoginStatus = ADOprpDL.Dr["branchLoginStatus"].ToString();
                    objprp.branchType = ADOprpDL.Dr["branchType"].ToString();

                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPOffice();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPOffice();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }

        public string ConfirmBranch(PRPOffice objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];

            ADOprp.ArrayPram[0] = new SqlParameter("@branchMailId", objprp.mailId);


            ADOprp.SPName = "SpBranchConfirm";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }

        //------------------------End----Branch--------------------

       //--------------------------------start employee panel ---------------------

        public List<PRPOffice> InsertEmployee(PRPOffice objprp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[20];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@employeeName", objprp.name);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@employeeSex", objprp.sex);
            ADOprpDL.ArrayPram[2] = new SqlParameter("@employeeDOB", objprp.DOB);
            ADOprpDL.ArrayPram[3] = new SqlParameter("@employeeMarital", objprp.marital);
            ADOprpDL.ArrayPram[4] = new SqlParameter("@employeeAddress", objprp.address);
            ADOprpDL.ArrayPram[5] = new SqlParameter("@employeeCity", objprp.city);
            ADOprpDL.ArrayPram[6] = new SqlParameter("@employeeDistrict", objprp.district);
            ADOprpDL.ArrayPram[7] = new SqlParameter("@employeeState", objprp.state);
            ADOprpDL.ArrayPram[8] = new SqlParameter("@employeeMobileNo", objprp.mobNo);
            ADOprpDL.ArrayPram[9] = new SqlParameter("@employeeMailId", objprp.mailId);
            ADOprpDL.ArrayPram[10] = new SqlParameter("@employeeFatherName", objprp.fatherName);
            ADOprpDL.ArrayPram[11] = new SqlParameter("@employeeEducation", objprp.education);
            ADOprpDL.ArrayPram[12] = new SqlParameter("@packageProfList", objprp.ProfList);
            ADOprpDL.ArrayPram[13] = new SqlParameter("@packageSalary", objprp.Salary);
            ADOprpDL.ArrayPram[14] = new SqlParameter("@packageAssociateId", objprp.AssociateId);
            ADOprpDL.ArrayPram[15] = new SqlParameter("@packageAssociateBranch", objprp.branchId);
            ADOprpDL.ArrayPram[16] = new SqlParameter("@packageDesignationId", objprp.designationId);
            ADOprpDL.ArrayPram[17] = new SqlParameter("@employeeLoginPassword", objprp.Password);
            ADOprpDL.ArrayPram[18] = new SqlParameter("@employeeLoginStatus", objprp.status);
            ADOprpDL.ArrayPram[19] = new SqlParameter("@employeePinCode", objprp.pinCode);

            ADOprpDL.SPName = "InsertEmplolyee";

            ADO.ReaderWithProceduresandParam(ADOprpDL);
            PRPOffice obj;
            List<PRPOffice> lst = new List<PRPOffice>();
            if (ADOprpDL.Dr.HasRows)
            {
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    obj = new PRPOffice();
                    obj.name = ADOprpDL.Dr[0].ToString();
                    lst.Add(obj);
                }

                ADO.ReaderClose(ADOprpDL);
            }
            else
             {
                 obj = new PRPOffice();
                 obj.srNo = "Result Not Find";
                 lst.Add(obj);
             }
          return lst;

         }
        
        public string UpdateEmployee(PRPOffice objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[21];
            ADOprp.ArrayPram[0] = new SqlParameter("@employeeName", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@employeeSex", objprp.sex);
            ADOprp.ArrayPram[2] = new SqlParameter("@employeeDOB", objprp.DOB);
            ADOprp.ArrayPram[3] = new SqlParameter("@employeeMarital", objprp.marital);
            ADOprp.ArrayPram[4] = new SqlParameter("@employeeAddress", objprp.address);
            ADOprp.ArrayPram[5] = new SqlParameter("@employeeCity", objprp.city);
            ADOprp.ArrayPram[6] = new SqlParameter("@employeeDistrict", objprp.district);
            ADOprp.ArrayPram[7] = new SqlParameter("@employeeState", objprp.state);
            ADOprp.ArrayPram[8] = new SqlParameter("@employeeMobileNo", objprp.mobNo);
            ADOprp.ArrayPram[9] = new SqlParameter("@employeeMailId", objprp.mailId);
            ADOprp.ArrayPram[10] = new SqlParameter("@employeeFatherName", objprp.fatherName);
            ADOprp.ArrayPram[11] = new SqlParameter("@employeeEducation", objprp.education);
            ADOprp.ArrayPram[12] = new SqlParameter("@packageProfList", objprp.ProfList);
            ADOprp.ArrayPram[13] = new SqlParameter("@packageSalary", objprp.Salary);
            ADOprp.ArrayPram[14] = new SqlParameter("@packageAssociateId", objprp.AssociateId);
            ADOprp.ArrayPram[15] = new SqlParameter("@packageAssociateBranch", objprp.branchId);
            ADOprp.ArrayPram[16] = new SqlParameter("@packageDesignationId", objprp.designationId);
            ADOprp.ArrayPram[17] = new SqlParameter("@employeeLoginPassword", objprp.Password);
            ADOprp.ArrayPram[18] = new SqlParameter("@employeeLoginStatus", objprp.status);
            ADOprp.ArrayPram[19] = new SqlParameter("@employeePinCode", objprp.pinCode);
            ADOprp.ArrayPram[20] = new SqlParameter("@employeeCode", objprp.id);
          
            ADOprp.SPName = "updateEmployee";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }
         public PRPOffice SelectEmployee(PRPOffice objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@employeeId", objprp.codeId);
            ADOprpDL.SPName = "selectEmployee";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPOffice obj = new PRPOffice(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj.ProfList = ADOprpDL.Dr["packageProfList"].ToString();
                    obj.Salary = ADOprpDL.Dr["packageSalary"].ToString();
                    obj.DOJ = ADOprpDL.Dr["packageDOJ"].ToString();
                    obj.AssociateId = ADOprpDL.Dr["packageAssociateId"].ToString();
                    obj.branchId = ADOprpDL.Dr["packageAssociateBranch"].ToString();
                    obj.designationId = ADOprpDL.Dr["packageDesignationId"].ToString();
                    obj.codeId = ADOprpDL.Dr["employeeCodeId"].ToString();
                    obj.name = ADOprpDL.Dr["employeeName"].ToString();
                    obj.sex = ADOprpDL.Dr["employeeSex"].ToString();
                    obj.DOB = ADOprpDL.Dr["employeeDOB"].ToString();
                    obj.marital = ADOprpDL.Dr["employeeMarital"].ToString();
                    obj.address = ADOprpDL.Dr["employeeAddress"].ToString();
                    obj.city = ADOprpDL.Dr["employeeCity"].ToString();
                     obj.district = ADOprpDL.Dr["employeeDistrict"].ToString();
                    obj.state = ADOprpDL.Dr["employeeState"].ToString();
                    obj.mobNo = ADOprpDL.Dr["employeeMobileNo"].ToString();
                    obj.mailId = ADOprpDL.Dr["employeeMailId"].ToString();
                    obj.fatherName = ADOprpDL.Dr["employeeFatherName"].ToString();
                    obj.education = ADOprpDL.Dr["employeeEducation"].ToString();
                    obj.pinCode = ADOprpDL.Dr["employeePinCode"].ToString();
                    obj.Password = ADOprpDL.Dr["employeeLoginPassword"].ToString();
                    obj.status = ADOprpDL.Dr["employeeLoginStatus"].ToString();
                    obj.designationName = ADOprpDL.Dr["designationName"].ToString();
                    obj.branchName = ADOprpDL.Dr["branchName"].ToString();
                    obj.AssociateName = ADOprpDL.Dr["associateName"].ToString();

                }
            }
            ADO.ReaderClose(ADOprpDL);

            return obj;




        }

         public List<PRPOffice> ViewEmployee(PRPOffice prp)
         {

             ADOprpDL.ArrayPram = new SqlParameter[2];
             ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
             ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
             ADOprpDL.SPName = "spViewEmployee";
             ADO.ReaderWithProceduresandParam(ADOprpDL);

             PRPOffice obj;
             List<PRPOffice> lst = new List<PRPOffice>();

             if (ADOprpDL.Dr.HasRows)
             {
                 while (ADOprpDL.Dr.Read())
                 {
                     obj = new PRPOffice();
                     obj.srNo = ADOprpDL.Dr["row"].ToString();
                     obj.ProfList = ADOprpDL.Dr["packageProfList"].ToString();
                     obj.Salary = ADOprpDL.Dr["packageSalary"].ToString();
                     obj.DOJ = ADOprpDL.Dr["packageDOJ"].ToString();
                     obj.AssociateId = ADOprpDL.Dr["packageAssociateId"].ToString();
                     obj.branchId = ADOprpDL.Dr["packageAssociateBranch"].ToString();
                     obj.designationId = ADOprpDL.Dr["packageDesignationId"].ToString();
                     obj.codeId = ADOprpDL.Dr["employeeCodeId"].ToString();
                     obj.name = ADOprpDL.Dr["employeeName"].ToString();
                     obj.sex = ADOprpDL.Dr["employeeSex"].ToString();
                     obj.DOB = ADOprpDL.Dr["employeeDOB"].ToString();
                     obj.marital = ADOprpDL.Dr["employeeMarital"].ToString();
                     obj.address = ADOprpDL.Dr["employeeAddress"].ToString();
                     obj.city = ADOprpDL.Dr["employeeCity"].ToString();
                     obj.district = ADOprpDL.Dr["employeeDistrict"].ToString();
                     obj.state = ADOprpDL.Dr["employeeState"].ToString();
                     obj.mobNo = ADOprpDL.Dr["employeeMobileNo"].ToString();
                     obj.mailId = ADOprpDL.Dr["employeeMailId"].ToString();
                     obj.fatherName = ADOprpDL.Dr["employeeFatherName"].ToString();
                     obj.education = ADOprpDL.Dr["employeeEducation"].ToString();
                     obj.pinCode = ADOprpDL.Dr["employeePinCode"].ToString();
                     obj.Password = ADOprpDL.Dr["employeeLoginPassword"].ToString();
                     obj.status = ADOprpDL.Dr["employeeLoginStatus"].ToString();
                     obj.designationName = ADOprpDL.Dr["designationName"].ToString();
                     obj.branchName = ADOprpDL.Dr["branchName"].ToString();
                     obj.AssociateName = ADOprpDL.Dr["associateName"].ToString();
                     lst.Add(obj);
                 }
                 if (ADOprpDL.Dr.NextResult())
                 {

                     ADOprpDL.Dr.Read();
                     obj = new PRPOffice();
                     obj.noOfRecord = ADOprpDL.Dr[0].ToString();
                     lst.Add(obj);
                 }


             }
             else
             {
                 obj = new PRPOffice();
                 obj.srNo = "Result Not Find";
                 lst.Add(obj);
             }
             ADO.ReaderClose(ADOprpDL);
             return lst;

         }
         public string deleteEmployee(PRPOffice objprp)
         {
             ADOprp.ArrayPram = new SqlParameter[1];
             ADOprp.ArrayPram[0] = new SqlParameter("@employeeId", objprp.id);
             ADOprp.SPName = "delEmployee";
             return ADO.ScalarQueryWithProceduresandParam(ADOprp);
         }
      
        
        //---------------------------------end employee panel-----------------------

         //--------Start Collage Profile
         public string InsertCollage(PRPOffice objprp)
         {
             ADOprp.ArrayPram = new SqlParameter[10];
             ADOprp.ArrayPram[0] = new SqlParameter("@branchName", objprp.name);
             ADOprp.ArrayPram[1] = new SqlParameter("@branchAddress", objprp.address);
             ADOprp.ArrayPram[2] = new SqlParameter("@branchCity", objprp.city);
             ADOprp.ArrayPram[3] = new SqlParameter("@branchDistrict", objprp.district);
             ADOprp.ArrayPram[4] = new SqlParameter("@branchState", objprp.state);
             ADOprp.ArrayPram[5] = new SqlParameter("@branchPhone", objprp.phoneNo);
             ADOprp.ArrayPram[6] = new SqlParameter("@branchMobNo", objprp.mobNo);
             ADOprp.ArrayPram[7] = new SqlParameter("@branchMailId", objprp.mailId);
             ADOprp.ArrayPram[8] = new SqlParameter("@branchPassword", objprp.Password);
             ADOprp.ArrayPram[9] = new SqlParameter("@FaxNumber", objprp.noOfRecord);

             ADOprp.SPName = "SpInsertCollageDetail";

             return ADO.ScalarQueryWithProceduresandParam(ADOprp);

         }
         public string UpdateCollage(PRPOffice objprp)
         {
             ADOprp.ArrayPram = new SqlParameter[15];

             ADOprp.ArrayPram[0] = new SqlParameter("@branchName", objprp.name);
             ADOprp.ArrayPram[1] = new SqlParameter("@branchMainLandMark", objprp.branchCodeName);
             ADOprp.ArrayPram[2] = new SqlParameter("@branchAddress", objprp.address);
             ADOprp.ArrayPram[3] = new SqlParameter("@branchPhone", objprp.phoneNo);
             ADOprp.ArrayPram[4] = new SqlParameter("@branchMobNo", objprp.mobNo);
             ADOprp.ArrayPram[5] = new SqlParameter("@CollegeType", objprp.urlPrntId);
             ADOprp.ArrayPram[6] = new SqlParameter("@CollegeRankType", "A-Grade");
             ADOprp.ArrayPram[7] = new SqlParameter("@CollegeWebsite", objprp.designationId);
             ADOprp.ArrayPram[8] = new SqlParameter("@CollegeApprovalDate", objprp.DOJ);
             ADOprp.ArrayPram[9] = new SqlParameter("@ApprovedBy", objprp.AssociateId);
             ADOprp.ArrayPram[10] = new SqlParameter("@FaxNumber", objprp.noOfRecord);
             ADOprp.ArrayPram[11] = new SqlParameter("@collegeid", objprp.id);
             ADOprp.ArrayPram[12] = new SqlParameter("@HostelQuerry", objprp.pageSize);
             ADOprp.ArrayPram[13] = new SqlParameter("@InstituteQuerry", objprp.Query);

             ADOprp.ArrayPram[14] = new SqlParameter("@AffilatedTo", objprp.mailId);

             ADOprp.SPName = "SpUpdateCollageDetail";

             return ADO.ScalarQueryWithProceduresandParam(ADOprp);

         }

         public PRPOffice ShowProfile(PRPOffice prp)
         {

             ADOprpDL.ArrayPram = new SqlParameter[1];
             ADOprpDL.ArrayPram[0] = new SqlParameter("@branchMailId", prp.mailId);
             ADOprpDL.SPName = "SpShowBranchProfile";
             ADO.ReaderWithProceduresandParam(ADOprpDL);

             PRPOffice objprp = new PRPOffice();

             if (ADOprpDL.Dr.HasRows)
             {
                 ADOprpDL.Dr.Read();

                 objprp.id = ADOprpDL.Dr["collegeid"].ToString();
                 objprp.branchCodeName = ADOprpDL.Dr["CollegeLandMark"].ToString();
                 objprp.name = ADOprpDL.Dr["CollegeName"].ToString();
                 objprp.address = ADOprpDL.Dr["collegeAddress"].ToString();
                 objprp.city = ADOprpDL.Dr["CollegeCity"].ToString();
                 objprp.district = ADOprpDL.Dr["CollegeDistrict"].ToString();
                 objprp.state = ADOprpDL.Dr["CollegeState"].ToString();
                 objprp.phoneNo = ADOprpDL.Dr["CollegeContact"].ToString();
                 objprp.mobNo = ADOprpDL.Dr["CollegeMobile"].ToString();
                 objprp.mailId = ADOprpDL.Dr["CollegeEmailId"].ToString();
                 objprp.DOJ = ADOprpDL.Dr["CollegeApprovalDate"].ToString();
                 objprp.urlPath = ADOprpDL.Dr["CollegeImage"].ToString();


                 objprp.urlPrntId = ADOprpDL.Dr["CollegeType"].ToString();
                 objprp.Graduate = ADOprpDL.Dr["CollegeStudentGrade"].ToString();
                 objprp.designationId = ADOprpDL.Dr["Collegewebsite"].ToString();
                 objprp.DOB = ADOprpDL.Dr["Date"].ToString();
                 objprp.AssociateId = ADOprpDL.Dr["ApprovedBy"].ToString();
                 objprp.noOfRecord = ADOprpDL.Dr["FaxNumber"].ToString();
                 objprp.urlPrntId = ADOprpDL.Dr["ShortDesCription"].ToString();
                 objprp.fatherName = ADOprpDL.Dr["LongDesCription"].ToString();
                 objprp.designationName = ADOprpDL.Dr["ContactPerson"].ToString();
                 objprp.designationStatus = ADOprpDL.Dr["Designation"].ToString();
                 objprp.ProfList = ADOprpDL.Dr["BoyHostelFee"].ToString();
                 objprp.urlId = ADOprpDL.Dr["BoyFeeType"].ToString();
                 objprp.srNo = ADOprpDL.Dr["BoyFeeMode"].ToString();
                 objprp.sex = ADOprpDL.Dr["BoyHostelEligibility"].ToString();
                 objprp.security = ADOprpDL.Dr["BoyHostelSeat"].ToString();
                 objprp.Salary = ADOprpDL.Dr["GirlHostelFee"].ToString();
                 objprp.pageIndex = ADOprpDL.Dr["GirlFeeType"].ToString();///
                 objprp.Query = ADOprpDL.Dr["GirlFeeMode"].ToString();
                 objprp.pinCode = ADOprpDL.Dr["GirlHostelEligibility"].ToString();
                 objprp.pageSize = ADOprpDL.Dr["GirlHostelSeat"].ToString();
                 objprp.codeId = ADOprpDL.Dr["CollegeCod"].ToString();
                 objprp.marital = ADOprpDL.Dr["AffilatedTo"].ToString();
                 //lst.Add(objprp);
             }
           
             ADO.ReaderClose(ADOprpDL);
             return objprp;

         }
         public string updateLogoImage(PRPOffice objprp)
         {
             ADOprp.ArrayPram = new SqlParameter[2];
             ADOprp.ArrayPram[0] = new SqlParameter("@memberID", objprp.urlId);
             ADOprp.ArrayPram[1] = new SqlParameter("@imagePath", objprp.urlPath);
            // ADOprp.ArrayPram[2] = new SqlParameter("@logintype", objprp.codeId);
             

             ADOprp.SPName = "colLogoUpdate";

             return ADO.ScalarQueryWithProceduresandParam(ADOprp);

         }

         //--------End Collage Profile

         public string UpStudentLogo(PRPOffice objprp)
         {
             ADOprp.ArrayPram = new SqlParameter[2];
             ADOprp.ArrayPram[0] = new SqlParameter("@memberID", objprp.urlId);
             ADOprp.ArrayPram[1] = new SqlParameter("@imagePath", objprp.urlPath);
             // ADOprp.ArrayPram[2] = new SqlParameter("@logintype", objprp.codeId);


             ADOprp.SPName = "UpateStudentLogo";

             return ADO.ScalarQueryWithProceduresandParam(ADOprp);

         }
        
         public List<PRPOffice> PrentLinks()
         {

             ADOprpDL.SPName = "SpPrentLinks";
             ADO.ReaderWithProcedures(ADOprpDL);

             PRPOffice obj;
             List<PRPOffice> lst = new List<PRPOffice>();

             if (ADOprpDL.Dr.HasRows)
             {
                 while (ADOprpDL.Dr.Read())
                 {
                     obj = new PRPOffice();
                     obj.id = ADOprpDL.Dr["urlprntId"].ToString();
                     lst.Add(obj);
                 }



             }
             else
             {
                 obj = new PRPOffice();
                 obj.srNo = "Result Not Find";
                 lst.Add(obj);
             }
             ADO.ReaderClose(ADOprpDL);
             return lst;

         }

         public List<PRPOffice> EmployeePermission(PRPOffice prp)
         {
             ADOprpDL.ArrayPram = new SqlParameter[1];
             ADOprpDL.ArrayPram[0] = new SqlParameter("@id", prp.id);
         

             ADOprpDL.SPName = "spPermissiontdUrl";
             ADO.ReaderWithProceduresandParam(ADOprpDL);

             PRPOffice obj;
             List<PRPOffice> lst = new List<PRPOffice>();

             if (ADOprpDL.Dr.HasRows)
             {
                 while (ADOprpDL.Dr.Read())
                 {
                     obj = new PRPOffice();
                     obj.id = ADOprpDL.Dr["permissionUrlId"].ToString();
                     lst.Add(obj);
                 }



             }
             else
             {
                 obj = new PRPOffice();
                 obj.srNo = "Result Not Find";
                 lst.Add(obj);
             }
             ADO.ReaderClose(ADOprpDL);
             return lst;

         }

         public List<PRPOffice> EmployeeAuthority(PRPOffice prp)
         {
             ADOprpDL.ArrayPram = new SqlParameter[1];
             ADOprpDL.ArrayPram[0] = new SqlParameter("@id", prp.id);


             ADOprpDL.SPName = "spAuthorityUrl";
             ADO.ReaderWithProceduresandParam(ADOprpDL);

             PRPOffice obj;
             List<PRPOffice> lst = new List<PRPOffice>();

             if (ADOprpDL.Dr.HasRows)
             {
                 while (ADOprpDL.Dr.Read())
                 {
                     obj = new PRPOffice();
                     obj.id = ADOprpDL.Dr["authorityUrlId"].ToString();
                     lst.Add(obj);
                 }



             }
             else
             {
                 obj = new PRPOffice();
                 obj.srNo = "Result Not Find";
                 lst.Add(obj);
             }
             ADO.ReaderClose(ADOprpDL);
             return lst;

         }
        
         public string InsertPermission(PRPOffice objprp)
         {
             ADOprp.ArrayPram = new SqlParameter[2];
             ADOprp.ArrayPram[0] = new SqlParameter("@query", objprp.Query);
             ADOprp.ArrayPram[1] = new SqlParameter("@id", objprp.id);

             
             ADOprp.SPName = "spInsertUrlPermission";

             return ADO.ScalarQueryWithProceduresandParam(ADOprp);

         }

         public string InsertAuthority(PRPOffice objprp)
         {
             ADOprp.ArrayPram = new SqlParameter[2];
             ADOprp.ArrayPram[0] = new SqlParameter("@query", objprp.Query);
             ADOprp.ArrayPram[1] = new SqlParameter("@id", objprp.Query);

             ADOprp.SPName = "spInsertUrlAUTHORITIES";

             return ADO.ScalarQueryWithProceduresandParam(ADOprp);

         }

         public List<PRPOffice> EmployeeMenu(PRPOffice prp)
         {
             ADOprpDL.ArrayPram = new SqlParameter[1];
             ADOprpDL.ArrayPram[0] = new SqlParameter("@id", prp.id);


             ADOprpDL.SPName = "spEmployeeUrl";
             ADO.ReaderWithProceduresandParam(ADOprpDL);

             PRPOffice obj;
             List<PRPOffice> lst = new List<PRPOffice>();

             if (ADOprpDL.Dr.HasRows)
             {
                 while (ADOprpDL.Dr.Read())
                 {
                     obj = new PRPOffice();
                     obj.urlId = ADOprpDL.Dr["urlId"].ToString();
                     obj.urlName = ADOprpDL.Dr["urlName"].ToString();
                     obj.urlPath = ADOprpDL.Dr["urlPath"].ToString();
                     obj.urlPrntId = ADOprpDL.Dr["urlprntId"].ToString();

                     lst.Add(obj);
                 }



             }
             else
             {
                 obj = new PRPOffice();
                 obj.srNo = "Result Not Find";
                 lst.Add(obj);
             }
             ADO.ReaderClose(ADOprpDL);
             return lst;

         }


         public List<PRPOffice> EmployeeMenubyUrlID(PRPOffice prp)
         {
             ADOprpDL.ArrayPram = new SqlParameter[3];
             ADOprpDL.ArrayPram[0] = new SqlParameter("@id", prp.id);
             ADOprpDL.ArrayPram[1] = new SqlParameter("@UrlId", prp.id);
             ADOprpDL.ArrayPram[2] = new SqlParameter("@type", prp.id);


             ADOprpDL.SPName = "spEmployeeUrlbyUrlId";
             ADO.ReaderWithProceduresandParam(ADOprpDL);

             PRPOffice obj;
             List<PRPOffice> lst = new List<PRPOffice>();

             if (ADOprpDL.Dr.HasRows)
             {
                 while (ADOprpDL.Dr.Read())
                 {
                     obj = new PRPOffice();
                     obj.urlId = ADOprpDL.Dr["urlId"].ToString();
                     obj.urlName = ADOprpDL.Dr["urlName"].ToString();
                     obj.urlPath = ADOprpDL.Dr["urlPath"].ToString();
                     obj.urlPrntId = ADOprpDL.Dr["urlprntId"].ToString();

                     lst.Add(obj);
                 }



             }
             else
             {
                 obj = new PRPOffice();
                 obj.srNo = "Result Not Find";
                 lst.Add(obj);
             }
             ADO.ReaderClose(ADOprpDL);
             return lst;

         }

         public List<PRPOffice> MainMenu(PRPOffice prp)
         {
             ADOprpDL.ArrayPram = new SqlParameter[1];
             ADOprpDL.ArrayPram[0] = new SqlParameter("@empID", prp.AssociateId);

             ADOprpDL.SPName = "spMainUrl";
             ADO.ReaderWithProceduresandParam(ADOprpDL);
             PRPOffice obj;
             List<PRPOffice> lst = new List<PRPOffice>();
             if (ADOprpDL.Dr.HasRows)
             {
                 while (ADOprpDL.Dr.Read())
                 {
                     obj = new PRPOffice();
                     obj.urlId = ADOprpDL.Dr["urlId"].ToString();
                     obj.urlName = ADOprpDL.Dr["urlName"].ToString();
                     obj.urlPath = ADOprpDL.Dr["urlPath"].ToString();
                     obj.urlPrntId = ADOprpDL.Dr["urlprntId"].ToString();
                     lst.Add(obj);
                 }
             }
             ADO.ReaderClose(ADOprpDL);
             return lst;

         }

         public List<PRPOffice> BindMenuNode(PRPOffice prp)
         {
             
             ADOprpDL.ArrayPram = new SqlParameter[2];
             ADOprpDL.ArrayPram[0] = new SqlParameter("@prntId", prp.urlPrntId);
             ADOprpDL.ArrayPram[1] = new SqlParameter("@empID", prp.AssociateId);


             ADOprpDL.SPName = "spMainUrlByPrntId";
             ADO.ReaderWithProceduresandParam(ADOprpDL);

             PRPOffice obj;
             List<PRPOffice> lst = new List<PRPOffice>();

             if (ADOprpDL.Dr.HasRows)
             {
                 while (ADOprpDL.Dr.Read())
                 {
                     obj = new PRPOffice();
                     obj.urlId = ADOprpDL.Dr["urlId"].ToString();
                     obj.urlName = ADOprpDL.Dr["urlName"].ToString();
                     obj.urlPath = ADOprpDL.Dr["urlPath"].ToString();
                     obj.urlPrntId = ADOprpDL.Dr["urlprntId"].ToString();

                     lst.Add(obj);
                 }
                      }
            
             ADO.ReaderClose(ADOprpDL);
             return lst;

         }

         public DataTable BindMainNodeById(PRPOffice objprp)
         {
             ADOprpDL = new clsPRPadoDL(); 
             ADOprpDL.ArrayPram = new SqlParameter[2];

             ADOprpDL.ArrayPram[0] = new SqlParameter("@prntId", objprp.urlPrntId);
             ADOprpDL.ArrayPram[1] = new SqlParameter("@empID", objprp.AssociateId);

             ADOprpDL.SPName = "spMainUrlByPrntId";

             return ADO.DataTableWithProceduresAndParam(ADOprpDL);


         }

         public PRPOffice ViewCenterProfile(PRPOffice objprp)
         {
             ADOprpDL.ArrayPram = new SqlParameter[2];
             ADOprpDL.ArrayPram[0] = new SqlParameter("@branchId", objprp.branchId);
             ADOprpDL.ArrayPram[1] = new SqlParameter("@employeeId", objprp.id);
             ADOprpDL.SPName = "SelCenterProfile";

             ADO.ReaderWithProceduresandParam(ADOprpDL);

             PRPOffice obj = new PRPOffice(); ;

             if (ADOprpDL.Dr.HasRows)
             {
                 while (ADOprpDL.Dr.Read())
                 {

                     obj.branchId = ADOprpDL.Dr["branchCodeId"].ToString();
                     obj.branchName = ADOprpDL.Dr["branchName"].ToString();
                     obj.address = ADOprpDL.Dr["branchAddress"].ToString();
                     obj.phoneNo = ADOprpDL.Dr["branchPhone"].ToString();
                     obj.city = ADOprpDL.Dr["branchCity"].ToString();
                     obj.state = ADOprpDL.Dr["branchState"].ToString();
                     obj.name = ADOprpDL.Dr["employeeName"].ToString();
                     obj.mailId = ADOprpDL.Dr["branchMailId"].ToString();
                     obj.mobNo = ADOprpDL.Dr["employeeMobileNo"].ToString();
                     obj.urlPath = ADOprpDL.Dr["empImage"].ToString();
                     obj.fatherName = ADOprpDL.Dr["employeeLoginName"].ToString();
                     obj.urlName = ADOprpDL.Dr["branchImage"].ToString();

                 }
             }
             ADO.ReaderClose(ADOprpDL);

             return obj;




         }


         public string updateCenterProfile(PRPOffice objprp)
         {

             ADOprp.ArrayPram = new SqlParameter[11];
             ADOprp.ArrayPram[0] = new SqlParameter("@branchId", objprp.branchId);
             ADOprp.ArrayPram[1] = new SqlParameter("@employeeId", objprp.id);
             ADOprp.ArrayPram[2] = new SqlParameter("@branchName", objprp.branchName);
             ADOprp.ArrayPram[3] = new SqlParameter("@employeeName", objprp.name);
             ADOprp.ArrayPram[4] = new SqlParameter("@branchEmailId", objprp.mailId);
             ADOprp.ArrayPram[5] = new SqlParameter("@branchPhone", objprp.phoneNo);
             ADOprp.ArrayPram[6] = new SqlParameter("@branchCity", objprp.city);
             ADOprp.ArrayPram[7] = new SqlParameter("@branchState", objprp.state);
             ADOprp.ArrayPram[8] = new SqlParameter("@MobileNo", objprp.mobNo);
             ADOprp.ArrayPram[9] = new SqlParameter("@empImage", objprp.urlPath);
             ADOprp.ArrayPram[10] = new SqlParameter("@branchAddress", objprp.address);

             ADOprp.SPName = "UpdCenterProfile";

             return ADO.ScalarQueryWithProceduresandParam(ADOprp);

         }



         
         public string InsertPayment(PRPprofile objprp)
         {
             ADOprp.ArrayPram = new SqlParameter[9];
             ADOprp.ArrayPram[0] = new SqlParameter("@GroupName", objprp.Name);
             ADOprp.ArrayPram[1] = new SqlParameter("@DateOfPayment", objprp.PaymentDATE);
             ADOprp.ArrayPram[2] = new SqlParameter("@Admition", objprp.noOfRecord);
             ADOprp.ArrayPram[3] = new SqlParameter("@Amount", objprp.PaymentAmount);
             ADOprp.ArrayPram[4] = new SqlParameter("@PaymentMode", objprp.PaymentTYPE);
             ADOprp.ArrayPram[5] = new SqlParameter("@ModeNo", objprp.BankuserNAME);
             ADOprp.ArrayPram[6] = new SqlParameter("@BankName", objprp.BankName);
             ADOprp.ArrayPram[7] = new SqlParameter("@Remark", objprp.bankNote);

             ADOprp.ArrayPram[8] = new SqlParameter("@ModeDate", objprp.DOB);

             ADOprp.SPName = "SpInsertPayment";

             return ADO.ScalarQueryWithProceduresandParam(ADOprp);

         }
         public string ConfirmPayment(PRPOffice objprp)
         {
             ADOprp.ArrayPram = new SqlParameter[1];

             ADOprp.ArrayPram[0] = new SqlParameter("@Querry", objprp.id);
             ADOprp.SPName = "SpConfirmPayment";

             return ADO.ScalarQueryWithProceduresandParam(ADOprp);

         }
         public List<PRPprofile> ViewPaidPayment()
         {

             ADOprpDL.ArrayPram = new SqlParameter[0];
             ADOprpDL.SPName = "SpShowPayment";
             ADO.ReaderWithProceduresandParam(ADOprpDL);

             PRPprofile objprp;
             List<PRPprofile> lst = new List<PRPprofile>();

             if (ADOprpDL.Dr.HasRows)
             {
                 while (ADOprpDL.Dr.Read())
                 {
                     objprp = new PRPprofile();
                     objprp.id = ADOprpDL.Dr["id"].ToString();
                     objprp.Name = ADOprpDL.Dr["GroupName"].ToString();
                     objprp.noOfRecord = ADOprpDL.Dr["Admition"].ToString();
                     objprp.PaymentAmount = ADOprpDL.Dr["Amount"].ToString();
                     objprp.PaymentTYPE = ADOprpDL.Dr["PaymentMode"].ToString();
                     objprp.BankuserNAME = ADOprpDL.Dr["ModeNo"].ToString();
                     objprp.DOB = ADOprpDL.Dr["ModeDate"].ToString();
                     objprp.BankName = ADOprpDL.Dr["BankName"].ToString();
                     objprp.PaymentDATE = ADOprpDL.Dr["DateOfPayment"].ToString();
                     objprp.paymentNote = ADOprpDL.Dr["Remark"].ToString();

                     lst.Add(objprp);
                 }
                 if (ADOprpDL.Dr.NextResult())
                 {

                     ADOprpDL.Dr.Read();
                     objprp = new PRPprofile();
                     objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                     lst.Add(objprp);
                 }


             }
             else
             {
                 objprp = new PRPprofile();
                 objprp.srNo = "Result Not Find";
                 lst.Add(objprp);
             }
             ADO.ReaderClose(ADOprpDL);
             return lst;

         }
         public List<PRPprofile> ViewPayment()
         {

             ADOprpDL.ArrayPram = new SqlParameter[0];
             ADOprpDL.SPName = "SpShowPayment";
             ADO.ReaderWithProceduresandParam(ADOprpDL);

             PRPprofile objprp;
             List<PRPprofile> lst = new List<PRPprofile>();

             if (ADOprpDL.Dr.HasRows)
             {
                 while (ADOprpDL.Dr.Read())
                 {
                     objprp = new PRPprofile();
                     objprp.id = ADOprpDL.Dr["id"].ToString();
                     objprp.Name = ADOprpDL.Dr["GroupName"].ToString();
                     objprp.noOfRecord = ADOprpDL.Dr["Admition"].ToString();
                     objprp.PaymentAmount = ADOprpDL.Dr["Amount"].ToString();
                     objprp.PaymentTYPE = ADOprpDL.Dr["PaymentMode"].ToString();
                     objprp.BankuserNAME = ADOprpDL.Dr["ModeNo"].ToString();
                     objprp.DOB = ADOprpDL.Dr["ModeDate"].ToString();
                     objprp.BankName = ADOprpDL.Dr["BankName"].ToString();
                     objprp.PaymentDATE = ADOprpDL.Dr["DateOfPayment"].ToString();
                     objprp.paymentNote = ADOprpDL.Dr["Remark"].ToString();

                     lst.Add(objprp);
                 }
                 if (ADOprpDL.Dr.NextResult())
                 {

                     ADOprpDL.Dr.Read();
                     objprp = new PRPprofile();
                     objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                     lst.Add(objprp);
                 }


             }
             else
             {
                 objprp = new PRPprofile();
                 objprp.srNo = "Result Not Find";
                 lst.Add(objprp);
             }
             ADO.ReaderClose(ADOprpDL);
             return lst;

         }
//------------------------start----Branch--------------------


    }

}