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
using nmsSetup;
using nmsProfile;
using nmsADO;
using System.Collections.Generic;
namespace nmsSetup
{
    public class clsDLSetup
    {
        //--------------------------------------------------------
        clsBLado ADO = new clsBLado();
        clsPRPadoBL ADOprp = new clsPRPadoBL();
        clsPRPadoDL ADOprpDL = new clsPRPadoDL();
       //------------------------------------------------
        clsprpADO objadoprp = new clsprpADO();
        clsADO objado = new clsADO();

//--start--University-------------------


    
        public List<PRPSetup> ViewCarrier1(PRPSetup prp)
       {
           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@id", prp.catID);
           ADOprpDL.SPName = "viewNewsType1";
           ADO.ReaderWithProceduresandParam(ADOprpDL);

           PRPSetup objprp;
           List<PRPSetup> lst = new List<PRPSetup>();

           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   objprp = new PRPSetup();
                   objprp.id = ADOprpDL.Dr["id"].ToString();
                   objprp.title = ADOprpDL.Dr["NewsTypeTitle"].ToString();
                   objprp.urlPath = ADOprpDL.Dr["ImagePath"].ToString();
                   objprp.description = ADOprpDL.Dr["NewsTypeDescription"].ToString();
                   lst.Add(objprp);
               }
           }
           else
           {
               objprp = new PRPSetup();
               objprp.srNo = "Result Not Find";
               lst.Add(objprp);
           }
           ADO.ReaderClose(ADOprpDL);
           return lst;

       }


        public string InsertUniversity(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[14];
            ADOprp.ArrayPram[0] = new SqlParameter("@universityName", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@universityMainLandMark", objprp.mainLandMark);
            ADOprp.ArrayPram[2] = new SqlParameter("@universityAddress", objprp.address);
            ADOprp.ArrayPram[3] = new SqlParameter("@universityCity", objprp.city);
            ADOprp.ArrayPram[4] = new SqlParameter("@universityDistrict", objprp.district);
            ADOprp.ArrayPram[5] = new SqlParameter("@universityState", objprp.state);
            ADOprp.ArrayPram[6] = new SqlParameter("@universityPhone", objprp.phoneNo);
            ADOprp.ArrayPram[7] = new SqlParameter("@universityMobNo", objprp.mobNo);
            ADOprp.ArrayPram[8] = new SqlParameter("@universityMailId", objprp.mailId);
            ADOprp.ArrayPram[9] = new SqlParameter("@universityDate", objprp.DOJ);
            ADOprp.ArrayPram[10] = new SqlParameter("@universityStatus", objprp.status);
            ADOprp.ArrayPram[11] = new SqlParameter("@universityCodeName", objprp.branchCodeName);
            ADOprp.ArrayPram[12] = new SqlParameter("@uniEnrolmentNo", objprp.enrolmentNo);
            ADOprp.ArrayPram[13] = new SqlParameter("@enrolStrartNo", objprp.srNo);
            
            ADOprp.SPName = "InsertUniversity";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }
        public string UpdateUniversity(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[15];
            ADOprp.ArrayPram[0] = new SqlParameter("@universityName", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@universityMainLandMark", objprp.mainLandMark);
            ADOprp.ArrayPram[2] = new SqlParameter("@universityAddress", objprp.address);
            ADOprp.ArrayPram[3] = new SqlParameter("@universityCity", objprp.city);
            ADOprp.ArrayPram[4] = new SqlParameter("@universityDistrict", objprp.district);
            ADOprp.ArrayPram[5] = new SqlParameter("@universityState", objprp.state);
            ADOprp.ArrayPram[6] = new SqlParameter("@universityPhone", objprp.phoneNo);
            ADOprp.ArrayPram[7] = new SqlParameter("@universityMobNo", objprp.mobNo);
            ADOprp.ArrayPram[8] = new SqlParameter("@universityMailId", objprp.mailId);
            ADOprp.ArrayPram[9] = new SqlParameter("@universityDate", objprp.DOJ);
            ADOprp.ArrayPram[10] = new SqlParameter("@universityStatus", objprp.status);
            ADOprp.ArrayPram[11] = new SqlParameter("@universityCodeId", objprp.codeId);
            ADOprp.ArrayPram[12] = new SqlParameter("@universityCodeName", objprp.branchCodeName);
            ADOprp.ArrayPram[13] = new SqlParameter("@uniEnrolmentNo", objprp.enrolmentNo);
            ADOprp.ArrayPram[14] = new SqlParameter("@enrolStrartNo", objprp.srNo);
            ADOprp.SPName = "UpdateUniversity";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string DeleteUniversity(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@universityCodeId", objprp.codeId);
            ADOprp.SPName = "deleteUniversity";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }

        public List<PRPSetup> ViewUniversityTypeWithParamater(PRPSetup obj1)
        {
            objadoprp.Cmd = new SqlCommand();
            objadoprp.Cmd.CommandText = obj1.name;
            objadoprp.Cmd.Parameters.AddWithValue("@id", obj1.uniID);
            objadoprp.Cmd.CommandType = CommandType.StoredProcedure;

            objado.ReaderQuery(objadoprp);

            PRPSetup objprp;
            List<PRPSetup> lst = new List<PRPSetup>();
            PRPSetup obj;

            if (objadoprp.ReturnMsg == "success")
            {
                if (objadoprp.Dr.HasRows)
                {
                    while (objadoprp.Dr.Read())
                    {

                        obj = new PRPSetup();
                        obj.id = objadoprp.Dr["Id"].ToString();
                        obj.name = objadoprp.Dr["name"].ToString();
                        lst.Add(obj);
                    }
                }
                else
                {
                    obj = new PRPSetup();
                    obj.srNo = "Result Not Find";
                    lst.Add(obj);
                }
                objado.ReaderClose(objadoprp);
            }
            else
            {
                obj = new PRPSetup();
                obj.srNo = "Result Not Find";
                lst.Add(obj);
            }
            return lst;
        }
        public PRPSetup SelectUniversity(PRPSetup objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@universityCodeId", objprp.codeId);
            ADOprpDL.SPName = "SelectUniversity";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup obj = new PRPSetup(); ;

            if (ADOprpDL.Dr.HasRows)
            {

                while (ADOprpDL.Dr.Read())
                {
                    obj.id = ADOprpDL.Dr["uniID"].ToString();
                    obj.name = ADOprpDL.Dr["uniName"].ToString();
                    obj.mainLandMark = ADOprpDL.Dr["uniLandMark"].ToString();
                    obj.address = ADOprpDL.Dr["uniAddress"].ToString();
                    obj.city = ADOprpDL.Dr["uniCity"].ToString();
                    obj.district = ADOprpDL.Dr["uniDistrict"].ToString();
                    obj.state = ADOprpDL.Dr["uniState"].ToString();
                    obj.phoneNo = ADOprpDL.Dr["uniContact"].ToString();
                    obj.mobNo = ADOprpDL.Dr["uniMobile"].ToString();
                    obj.mailId = ADOprpDL.Dr["uniEmailID"].ToString();
                    obj.DOJ = ADOprpDL.Dr["uniDate"].ToString();
                    obj.status = ADOprpDL.Dr["uniStatus"].ToString();
                    obj.branchCodeName = ADOprpDL.Dr["uniCod"].ToString();
                    obj.enrolmentNo = ADOprpDL.Dr["uniEntrolmentNo"].ToString();
                    obj.srNo = ADOprpDL.Dr["enrolStartNo"].ToString();
                    objprp.rank = ADOprpDL.Dr["enrolEndNo"].ToString();               
                }
            }
            ADO.ReaderClose(ADOprpDL);
            return obj;
        }
        public List<PRPSetup> ViewAcdRequestDetail(PRPSetup prp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.SPName = "Sp_ViewAcdRequest";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup objprp;
            List<PRPSetup> lst = new List<PRPSetup>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetup();
                    objprp.id = ADOprpDL.Dr["row"].ToString();
                    objprp.AcdRequest_Id = ADOprpDL.Dr["AcdRequest_Id"].ToString();
                    objprp.mailId = ADOprpDL.Dr["Type"].ToString();
                    objprp.city = ADOprpDL.Dr["Category"].ToString();
                    objprp.description = ADOprpDL.Dr["Sub_Category"].ToString();
                    objprp.state = ADOprpDL.Dr["Title"].ToString();
                    objprp.DOB = ADOprpDL.Dr["Request"].ToString();
                    objprp.address = ADOprpDL.Dr["collegeAddress"].ToString();
                    objprp.emailID = ADOprpDL.Dr["collegeEmailID"].ToString();
                    objprp.mobNo = ADOprpDL.Dr["collegeMobile"].ToString();
                    objprp.type = ADOprpDL.Dr["createdby"].ToString();
                    objprp.Password = ADOprpDL.Dr["createddate"].ToString();
                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetup();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPSetup();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
        public string DeleteAcdRequst(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@AcdRequest_Id", objprp.codeId);
            ADOprp.SPName = "deleteAcdRequst";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public List<PRPSetup> ViewJobDetails(PRPSetup prp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.SPName = "Sp_ViewJobDetails";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup objprp;
            List<PRPSetup> lst = new List<PRPSetup>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetup();
                    objprp.JDrow = ADOprpDL.Dr["row"].ToString();
                    objprp.JDJdID = ADOprpDL.Dr["JdID"].ToString();
                    objprp.JDTitle = ADOprpDL.Dr["Title"].ToString();
                    objprp.JDSalary = ADOprpDL.Dr["Salary"].ToString();
                    objprp.JDCategory = ADOprpDL.Dr["Category"].ToString();
                    objprp.JDFunctional_Area = ADOprpDL.Dr["Functional_Area"].ToString();
                    objprp.JDRole = ADOprpDL.Dr["Role"].ToString();
                    objprp.JDSkill = ADOprpDL.Dr["Skill"].ToString();
                    objprp.JDRequired_Qualification = ADOprpDL.Dr["Required_Qualification"].ToString();
                    objprp.JDJob_Description = ADOprpDL.Dr["Job_Description"].ToString();
                    objprp.JDEmployer_Profile = ADOprpDL.Dr["Employer_Profile"].ToString();
                    objprp.JDOrganisation_Name = ADOprpDL.Dr["Organisation_Name"].ToString();
                    objprp.JDRecruiter_Name = ADOprpDL.Dr["Recruiter_Name"].ToString();
                   // objprp.JDcollegeName = ADOprpDL.Dr["collegeName"].ToString();
                    objprp.JDcreatedby = ADOprpDL.Dr["createdby"].ToString();
                    objprp.JDcreatedatetime = ADOprpDL.Dr["createdatetime"].ToString();
                    objprp.JDcollegeEmailID = ADOprpDL.Dr["collegeEmailID"].ToString();
                    objprp.JDcollegeAddress = ADOprpDL.Dr["collegeAddress"].ToString();
                    objprp.JDcollegeMobile = ADOprpDL.Dr["collegeMobile"].ToString();
                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetup();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPSetup();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
        public string DeleteJobDetails(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@JdID", objprp.codeId);
            ADOprp.SPName = "deleteJobDetails";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }

        public List<PRPSetup> ViewJobProfile(PRPSetup prp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.SPName = "Sp_ViewJobProfile";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup objprp;
            List<PRPSetup> lst = new List<PRPSetup>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetup();
                    objprp.JDrow = ADOprpDL.Dr["row"].ToString();
                    objprp.JDJdID = ADOprpDL.Dr["Jobdetails_Id"].ToString();
                    objprp.JDTitle = ADOprpDL.Dr["Skill"].ToString();
                    objprp.JDSalary = ADOprpDL.Dr["Industry"].ToString();
                    objprp.JDCategory = ADOprpDL.Dr["Functional_Area"].ToString();
                    objprp.JDFunctional_Area = ADOprpDL.Dr["Category"].ToString();
                    objprp.JDRole = ADOprpDL.Dr["Current_Employer"].ToString();
                    objprp.JDSkill = ADOprpDL.Dr["Current_Salary"].ToString();
                    objprp.JDRequired_Qualification = ADOprpDL.Dr["Expected_Salary"].ToString();
                    objprp.JDJob_Description = ADOprpDL.Dr["Previous_Employer"].ToString();
                    objprp.JDEmployer_Profile = ADOprpDL.Dr["Present_Job_Location"].ToString();
                    objprp.JDOrganisation_Name = ADOprpDL.Dr["Preferred_Job_Location"].ToString();
                    objprp.JDRecruiter_Name = ADOprpDL.Dr["Total_Experience_Year"].ToString();
                    // objprp.JDcollegeName = ADOprpDL.Dr["collegeName"].ToString();
                    objprp.JDcreatedby = ADOprpDL.Dr["Total_Experience_Month"].ToString();
                    objprp.JDInterested_Job_Type = ADOprpDL.Dr["Interested_Job_Type"].ToString();
                    objprp.JDPassing_Year = ADOprpDL.Dr["Passing_Year"].ToString();
                    objprp.JDLanguage = ADOprpDL.Dr["Language"].ToString();
                    objprp.JDResume_Title = ADOprpDL.Dr["Resume_Title"].ToString();
                  //  objprp.JDcollegecreatedby = ADOprpDL.Dr["createdby"].ToString();
                    objprp.JDcreatedatetime = ADOprpDL.Dr["createtime"].ToString();
                    objprp.JDcollegeEmailID = ADOprpDL.Dr["collegeEmailID"].ToString();
                    objprp.JDcollegeAddress = ADOprpDL.Dr["collegeAddress"].ToString();
                    objprp.JDcollegeMobile = ADOprpDL.Dr["collegeMobile"].ToString();
                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetup();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPSetup();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }

        public List<PRPSetup> ViewUniversity(PRPSetup prp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.SPName = "viewUniversity";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup objprp;
            List<PRPSetup> lst = new List<PRPSetup>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetup();
                    objprp.id = ADOprpDL.Dr["uniId"].ToString();
                    objprp.name = ADOprpDL.Dr["uniName"].ToString();
                    objprp.mainLandMark = ADOprpDL.Dr["uniLandMark"].ToString();
                    objprp.address = ADOprpDL.Dr["uniAddress"].ToString();
                    objprp.city = ADOprpDL.Dr["uniCity"].ToString();
                    objprp.district = ADOprpDL.Dr["uniDistrict"].ToString();
                    objprp.state = ADOprpDL.Dr["uniState"].ToString();
                    objprp.phoneNo = ADOprpDL.Dr["uniContact"].ToString();
                    objprp.mobNo = ADOprpDL.Dr["uniMobile"].ToString();
                    objprp.mailId = ADOprpDL.Dr["uniEmailID"].ToString();
                    objprp.DOJ = ADOprpDL.Dr["uniDate"].ToString();
                    objprp.status = ADOprpDL.Dr["uniStatus"].ToString();
                    objprp.branchCodeName = ADOprpDL.Dr["uniCod"].ToString();
                    objprp.enrolmentNo = ADOprpDL.Dr["uniEntrolmentNo"].ToString();
                    objprp.srNo = ADOprpDL.Dr["enrolStartNo"].ToString();
                    objprp.rank = ADOprpDL.Dr["enrolEndNo"].ToString();               
                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetup();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPSetup();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
//--End----university-----------------------



//News For
        public string InsNewsFor(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[5];
            ADOprp.ArrayPram[0] = new SqlParameter("@NewName", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@NewsTitle", objprp.title);
            ADOprp.ArrayPram[2] = new SqlParameter("@NewsDescription", objprp.description);
            ADOprp.ArrayPram[3] = new SqlParameter("@NewsImage", objprp.urlPath);
            ADOprp.ArrayPram[4] = new SqlParameter("@isActive ", objprp.isActive);
            #region Passing New Value
            //ADOprp.ArrayPram[5] = new SqlParameter("@Country ", objprp.uniID);
            //ADOprp.ArrayPram[6] = new SqlParameter("@State", objprp.state);
            //ADOprp.ArrayPram[7] = new SqlParameter("@Dist", objprp.district);
            //ADOprp.ArrayPram[8] = new SqlParameter("@City", objprp.city);
            #endregion
            ADOprp.SPName = "SpInsertNewsFor";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string UpdNewsFor(PRPSetup objprp)
        {
            //ADOprp.ArrayPram = new SqlParameter[3];
            ADOprp.ArrayPram = new SqlParameter[6];
            ADOprp.ArrayPram[0] = new SqlParameter("@NewName", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@NewsTitle", objprp.title);
            ADOprp.ArrayPram[2] = new SqlParameter("@NewsDescription", objprp.description);
            ADOprp.ArrayPram[3] = new SqlParameter("@NewsImage", objprp.urlPath);
            ADOprp.ArrayPram[4] = new SqlParameter("@isActive ", objprp.isActive);

            ADOprp.ArrayPram[5] = new SqlParameter("@ForId", objprp.id);
            ADOprp.SPName = "spUpdateNewsFor";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string DelNewsFor(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@ForId", objprp.id);
            ADOprp.SPName = "SpDeleteNewsFor";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);



        }
        public PRPSetup SelNewsFor(PRPSetup objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@ForId", objprp.id);
            ADOprpDL.SPName = "SpSelectByIdNewsFor";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup obj = new PRPSetup(); ;

            if (ADOprpDL.Dr.HasRows)
            {

                while (ADOprpDL.Dr.Read())
                {
                    obj.id = ADOprpDL.Dr["ForId"].ToString();
                    obj.name = ADOprpDL.Dr["NewName"].ToString();
                    obj.isActive = ADOprpDL.Dr["isActive"].ToString();

                    obj.title = ADOprpDL.Dr["NewsTitle"].ToString();
                    obj.description = ADOprpDL.Dr["NewsDescription"].ToString();
                    obj.urlPath = ADOprpDL.Dr["NewsImage"].ToString();

                    #region Modify by Devesh
                    //objprp.sCountry = ADOprpDL.Dr["cntName"].ToString();
                    //objprp.sState = ADOprpDL.Dr["stateName"].ToString();
                    //objprp.sDist = ADOprpDL.Dr["distName"].ToString();
                    //objprp.sCity = ADOprpDL.Dr["cityName"].ToString();
                    #endregion

                }
            }
            ADO.ReaderClose(ADOprpDL);
            return obj;
        }

        public List<PRPSetup> viewNewsFor()
        {

            ADOprpDL.ArrayPram = new SqlParameter[0];
            // ADOprpDL.ArrayPram[0] = new SqlParameter("@NewId", prp.id);
            ADOprpDL.SPName = "SpBindNewsFor";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup objprp;
            List<PRPSetup> lst = new List<PRPSetup>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetup();
                    objprp.id = ADOprpDL.Dr["id"].ToString();
                    objprp.name = ADOprpDL.Dr["name"].ToString();
                    objprp.title = ADOprpDL.Dr["NewsTitle"].ToString();

                    #region Modify by Devesh
                    //objprp.uniID = ADOprpDL.Dr["cntName"].ToString();
                    //objprp.state = ADOprpDL.Dr["stateName"].ToString();
                    //objprp.district = ADOprpDL.Dr["distName"].ToString();
                    //objprp.city = ADOprpDL.Dr["cityName"].ToString();
                    #endregion





                    // objprp.description = ADOprpDL.Dr["ShowBranchId"].ToString();

                    //  objprp.urlPath = ADOprpDL.Dr["ShowNewsId"].ToString();
                    // objprp.name = ADOprpDL.Dr["ShowBranchId"].ToString();

                    lst.Add(objprp);
                }

            }
            else
            {
                objprp = new PRPSetup();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }

//News For

//-- Set News Panel Wise
        public String InsShowInBranch(PRPSetup objprp)
        {               
            ADOprp.ArrayPram = new SqlParameter[2];
            ADOprp.ArrayPram[0] = new SqlParameter("@NewsId", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@query", objprp.Query);
            ADOprp.SPName = "insShowInBranch";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);        
        }

        public List<PRPSetup> viewShowInBranch(PRPSetup prp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@NewId", prp.id);
            ADOprpDL.SPName = "viewShowInBranch";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup objprp;
            List<PRPSetup> lst = new List<PRPSetup>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetup();
                    objprp.id = ADOprpDL.Dr["ShowNewsId"].ToString();
                    objprp.uniID = ADOprpDL.Dr["ShowBranchId"].ToString();                    
                    lst.Add(objprp);
                }
                
            }
            else
            {
                objprp = new PRPSetup();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }

        public List<PRPSetup> viewShowInBranch1(PRPSetup prp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[3];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.ArrayPram[2] = new SqlParameter("@uniId", prp.uniID);
            ADOprpDL.SPName = "viewShowInBranch1";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup objprp;
            List<PRPSetup> lst = new List<PRPSetup>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetup();
                    objprp.id = ADOprpDL.Dr["branchCodeId"].ToString();
                    objprp.branchName = ADOprpDL.Dr["branchName"].ToString();
                    objprp.catID = ADOprpDL.Dr["newsTypeId"].ToString();
                    objprp.name = ADOprpDL.Dr["newsType"].ToString();
                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetup();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }

            }
            else
            {
                objprp = new PRPSetup();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }

        public List<PRPSetup> viewNewsInBranch(PRPSetup prp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@branchId", prp.branchId);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@uniId", prp.uniID);
            ADOprpDL.SPName = "viewNewsInBranch";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup objprp;
            List<PRPSetup> lst = new List<PRPSetup>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetup();
                    
                    objprp.id = ADOprpDL.Dr["ShowId"].ToString();
                    objprp.title = ADOprpDL.Dr["newsTitle"].ToString();
                    objprp.DOB = ADOprpDL.Dr["newsDate"].ToString();
                    objprp.name = ADOprpDL.Dr["subTitle"].ToString();
                    objprp.urlPath = ADOprpDL.Dr["newImage"].ToString();
                    lst.Add(objprp);
                }

            }
            else
            {
                objprp = new PRPSetup();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }




//--End News Panle Wise

        //--Start Notification.
        public List<PRPSetup> ViewAdmissionNotification(PRPSetup obj1)
        {
            objadoprp.Cmd = new SqlCommand();
            objadoprp.Cmd.CommandText = obj1.name;

            objadoprp.Cmd.CommandType = CommandType.StoredProcedure;
            objadoprp.Cmd.Parameters.AddWithValue("@sts", obj1.id);
            objado.ReaderQuery(objadoprp);

            PRPSetup objprp;
            List<PRPSetup> lst = new List<PRPSetup>();

            PRPSetup obj;

            if (objadoprp.ReturnMsg == "success")
            {
                if (objadoprp.Dr.HasRows)
                {
                    while (objadoprp.Dr.Read())
                    {

                        obj = new PRPSetup();
                        obj.id = objadoprp.Dr["id"].ToString();
                        obj.name = objadoprp.Dr["name"].ToString();
                        obj.uniID = objadoprp.Dr["total"].ToString();
                        lst.Add(obj);
                    }
                }
                else
                {
                    obj = new PRPSetup();
                    obj.srNo = "Result Not Find";
                    lst.Add(obj);
                }
                objado.ReaderClose(objadoprp);
            }
            else
            {
                obj = new PRPSetup();
                obj.srNo = "Result Not Find";
                lst.Add(obj);
            }
            return lst;
        }
        public string updAdmissionNotification(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[2];

            ADOprp.ArrayPram[0] = new SqlParameter("@branchId", objprp.uniID);
            ADOprp.ArrayPram[1] = new SqlParameter("@query", objprp.id);

            ADOprp.SPName = "updAdmissionNotification";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }


        //--End Notification.


//Authorisatin start
        public List<PRPSetup> CheckUniByBranch(PRPSetup prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@id", prp.id);

            ADOprpDL.SPName = "SpSelectUniId";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup objprp;
            List<PRPSetup> lst = new List<PRPSetup>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetup();
                    objprp.id = ADOprpDL.Dr["id"].ToString();
                    objprp.title = ADOprpDL.Dr["name"].ToString();
                    objprp.courseFees = ADOprpDL.Dr["IccoComm"].ToString();
                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetup();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
          
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
        public List<PRPSetup> BindUniforAuth(PRPSetup prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[0];

            ADOprpDL.SPName = "SpShowUniCode";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup objprp;
            List<PRPSetup> lst = new List<PRPSetup>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetup();
                    objprp.id = ADOprpDL.Dr["UniId"].ToString();
                    objprp.title = ADOprpDL.Dr["UniName"].ToString();
                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetup();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
           
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
        public string InsertAuthBranch(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@Querry", objprp.name);
            ADOprp.SPName = "SpInsertAuthorizedUni";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public List<PRPSetup> BindByAuthorisation(PRPSetup prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.SPName = "SpBindBranchName";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup objprp;
            List<PRPSetup> lst = new List<PRPSetup>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetup();
                    objprp.id = ADOprpDL.Dr["branchCodeId"].ToString();
                    objprp.branchName = ADOprpDL.Dr["branchName"].ToString();

                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetup();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPSetup();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
        public List<PRPSetup> BindUniInRepitor(PRPSetup prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@IccoId", prp.id);
            ADOprpDL.SPName = "SpShowAuthoUni";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup objprp;
            List<PRPSetup> lst = new List<PRPSetup>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetup();
                    objprp.courseFees = ADOprpDL.Dr["IccoComm"].ToString();
                    objprp.title = ADOprpDL.Dr["UniName"].ToString();

                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetup();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }

            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
        public string DelAuthorisation(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@IccoId", objprp.id);
            ADOprp.SPName = "SpDelAuthorisation";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);



        }
//Authorisatin End

        //Set Roll Series start
        public string insSetRollNoSeries(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@Querry", objprp.name);
            ADOprp.SPName = "insSetRollNoSeries";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public List<PRPSetup> viewSetRollNoSeries(PRPSetup prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[5];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.ArrayPram[2] = new SqlParameter("@uniID", prp.uniID);
            ADOprpDL.ArrayPram[3] = new SqlParameter("@catID", prp.catID);
            ADOprpDL.ArrayPram[4] = new SqlParameter("@status", prp.status);
            ADOprpDL.SPName = "viewSetRollNoSeries";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup objprp;
            List<PRPSetup> lst = new List<PRPSetup>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetup();
                    objprp.id = ADOprpDL.Dr["seriesId"].ToString();
                    objprp.DOJ = ADOprpDL.Dr["SessionDate"].ToString();
                    objprp.semMode = ADOprpDL.Dr["sem"].ToString();
                    objprp.srNo = ADOprpDL.Dr["seriesStart"].ToString();
                    objprp.status = ADOprpDL.Dr["seriesEnd"].ToString();
                    objprp.isActive = ADOprpDL.Dr["isActive"].ToString();
                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetup();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPSetup();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }

        public string delSetRollNoSeries(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@Id", objprp.id);
            ADOprp.SPName = "delSetRollNoSeries";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public PRPSetup selSetRollNoSeries(PRPSetup objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@id", objprp.id);

            ADOprpDL.SPName = "selRollNoSeries";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup obj = new PRPSetup(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj = new PRPSetup();
                    obj.uniID = ADOprpDL.Dr["uniID"].ToString();
                    obj.catID = ADOprpDL.Dr["catID"].ToString();
                    obj.DOJ = ADOprpDL.Dr["date"].ToString();
                    obj.name = ADOprpDL.Dr["1"].ToString();
                    obj.branchCodeName = ADOprpDL.Dr["2"].ToString();
                    obj.specilization = ADOprpDL.Dr["3"].ToString();
                    obj.durationMinTime = ADOprpDL.Dr["4"].ToString();
                    obj.durationMaxTime = ADOprpDL.Dr["5"].ToString();
                    obj.eligibility = ADOprpDL.Dr["6"].ToString();
                }
            }
            ADO.ReaderClose(ADOprpDL);
            return obj;
        }
        //End Roll Series End



//--Start set Comm To Agent University Wise        
        public string InsertAgentComm(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@Querry", objprp.name);
            ADOprp.SPName = "InsAgentCommUniWise";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public List<PRPSetup> viewAgentCommDetail(PRPSetup prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[3];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
             ADOprpDL.ArrayPram[2] = new SqlParameter("@id", prp.uniID);
            ADOprpDL.SPName = "viewAgentCommDetail";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup objprp;
            List<PRPSetup> lst = new List<PRPSetup>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetup();
                    objprp.id = ADOprpDL.Dr["memberCodeId"].ToString();
                    objprp.name = ADOprpDL.Dr["memberName"].ToString();
                    objprp.city = ADOprpDL.Dr["MemberCity"].ToString();
                    objprp.mobNo = ADOprpDL.Dr["memberMobileNo"].ToString();
                    objprp.rank = ADOprpDL.Dr["ArankRankId"].ToString();
                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetup();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPSetup();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
        public List<PRPSetup> viewAgentCommDetail1(PRPSetup prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@AgentId", prp.id);
            ADOprpDL.SPName = "viewAgentCommDetail1";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup objprp;
            List<PRPSetup> lst = new List<PRPSetup>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetup();
                    objprp.id = ADOprpDL.Dr["AgentId"].ToString();
                    objprp.courseFees = ADOprpDL.Dr["Comm"].ToString();
                    objprp.title = ADOprpDL.Dr["UniName"].ToString();
                    objprp.uniID = ADOprpDL.Dr["uniId"].ToString();

                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetup();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }

            ADO.ReaderClose(ADOprpDL);
            return lst;

        }        
//--End Set Comm To Agent University Wise

 //--Start Enquiry form-------------------
        public string InsertEnquiry(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[7];

            ADOprp.ArrayPram[0] = new SqlParameter("@name", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@father", objprp.fatherName);
            ADOprp.ArrayPram[2] = new SqlParameter("@dob", objprp.DOB);
            ADOprp.ArrayPram[3] = new SqlParameter("@course", objprp.catID);
            ADOprp.ArrayPram[4] = new SqlParameter("@mob", objprp.mobNo);
            ADOprp.ArrayPram[5] = new SqlParameter("@email", objprp.emailID);
            ADOprp.ArrayPram[6] = new SqlParameter("@address", objprp.address);

            ADOprp.SPName = "spinsEnquiry";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }
        public string UpdateEnquiry(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[2];

            ADOprp.ArrayPram[0] = new SqlParameter("@id", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@status", objprp.address);


            ADOprp.SPName = "SpUpdatestuenqury";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }
        public List<PRPSetup> viewEnquiry(PRPSetup prp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.SPName = "spviewEnquiry";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup objprp;
            List<PRPSetup> lst = new List<PRPSetup>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetup();
                    objprp.id = ADOprpDL.Dr["staid"].ToString();
                    objprp.name = ADOprpDL.Dr["stname"].ToString();
                    objprp.fatherName = ADOprpDL.Dr["stafather"].ToString();
                    objprp.DOB = ADOprpDL.Dr["stadob"].ToString();
                    objprp.courseFees = ADOprpDL.Dr["stacourse"].ToString();
                    objprp.mobNo = ADOprpDL.Dr["stamob"].ToString();                    
                    objprp.isActive = ADOprpDL.Dr["staActive"].ToString();
                    objprp.emailID = ADOprpDL.Dr["staemail"].ToString();
                    objprp.address = ADOprpDL.Dr["staAdres"].ToString();
                    objprp.status = ADOprpDL.Dr["staMarkstatus"].ToString();

                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetup();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPSetup();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
        public string DelEnquiry(PRPSetup prp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];

            ADOprp.ArrayPram[0] = new SqlParameter("@id", prp.id);
            
            ADOprp.SPName = "delInquiry";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
//----End Enquiry form----------------




//--Start Web University--------------------
        public string InsertUniversityWeb(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[18];

            ADOprp.ArrayPram[0] = new SqlParameter("@universityCountry", objprp.uniID);
            ADOprp.ArrayPram[1] = new SqlParameter("@universityState", objprp.state);
            ADOprp.ArrayPram[2] = new SqlParameter("@universityDistrict", objprp.district);
            ADOprp.ArrayPram[3] = new SqlParameter("@universityCity", objprp.city);
            ADOprp.ArrayPram[4] = new SqlParameter("@universityType", objprp.catID);
            ADOprp.ArrayPram[5] = new SqlParameter("@educationType", objprp.education);

            ADOprp.ArrayPram[6] = new SqlParameter("@universityName", objprp.name);
            ADOprp.ArrayPram[7] = new SqlParameter("@universityMainLandMark", objprp.mainLandMark);
            ADOprp.ArrayPram[8] = new SqlParameter("@universityAddress", objprp.address);
            ADOprp.ArrayPram[9] = new SqlParameter("@universityStatus", objprp.status);

            ADOprp.ArrayPram[10] = new SqlParameter("@universityPhone", objprp.phoneNo);
            ADOprp.ArrayPram[11] = new SqlParameter("@universityMobNo", objprp.mobNo);
            ADOprp.ArrayPram[12] = new SqlParameter("@universityMailId", objprp.mailId);
            ADOprp.ArrayPram[13] = new SqlParameter("@universityDate", objprp.DOJ);

            ADOprp.ArrayPram[14] = new SqlParameter("@universityCodeName", objprp.branchCodeName);
            ADOprp.ArrayPram[15] = new SqlParameter("@universitywebId", objprp.emailID);
            ADOprp.ArrayPram[16] = new SqlParameter("@rank", objprp.rank);
            ADOprp.ArrayPram[17] = new SqlParameter("@grade", objprp.grade);

            ADOprp.SPName = "InsertUniversityWeb";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }
        public string UpdateUniversityWeb(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[19];

            ADOprp.ArrayPram[0] = new SqlParameter("@universityCountry", objprp.uniID);
            ADOprp.ArrayPram[1] = new SqlParameter("@universityState", objprp.state);
            ADOprp.ArrayPram[2] = new SqlParameter("@universityDistrict", objprp.district);
            ADOprp.ArrayPram[3] = new SqlParameter("@universityCity", objprp.city);
            ADOprp.ArrayPram[4] = new SqlParameter("@universityType", objprp.catID);
            ADOprp.ArrayPram[5] = new SqlParameter("@educationType", objprp.education);

            ADOprp.ArrayPram[6] = new SqlParameter("@universityName", objprp.name);
            ADOprp.ArrayPram[7] = new SqlParameter("@universityMainLandMark", objprp.mainLandMark);
            ADOprp.ArrayPram[8] = new SqlParameter("@universityAddress", objprp.address);
            ADOprp.ArrayPram[9] = new SqlParameter("@universityStatus", objprp.status);

            ADOprp.ArrayPram[10] = new SqlParameter("@universityPhone", objprp.phoneNo);
            ADOprp.ArrayPram[11] = new SqlParameter("@universityMobNo", objprp.mobNo);
            ADOprp.ArrayPram[12] = new SqlParameter("@universityMailId", objprp.mailId);
            ADOprp.ArrayPram[13] = new SqlParameter("@universityDate", objprp.DOJ);

            ADOprp.ArrayPram[14] = new SqlParameter("@universityCodeName", objprp.branchCodeName);
            ADOprp.ArrayPram[15] = new SqlParameter("@universitywebId", objprp.emailID);
            ADOprp.ArrayPram[16] = new SqlParameter("@rank", objprp.rank);
            ADOprp.ArrayPram[17] = new SqlParameter("@grade", objprp.grade);
            ADOprp.ArrayPram[18] = new SqlParameter("@universityCodeId", objprp.codeId);

            ADOprp.SPName = "UpdateUniversityWeb";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string DeleteUniversityWeb(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@universityCodeId", objprp.codeId);
            ADOprp.SPName = "deleteUniversityWeb";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public PRPSetup SelectUniversityWeb(PRPSetup objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@universityCodeId", objprp.codeId);
            ADOprpDL.SPName = "SelectUniversityWeb";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup obj = new PRPSetup(); ;

            if (ADOprpDL.Dr.HasRows)
            {

                while (ADOprpDL.Dr.Read())
                {
                    obj.id = ADOprpDL.Dr["uniID"].ToString();
                    obj.name = ADOprpDL.Dr["uniName"].ToString();
                    obj.mainLandMark = ADOprpDL.Dr["uniLandMark"].ToString();
                    obj.address = ADOprpDL.Dr["uniAddress"].ToString();
                    obj.city = ADOprpDL.Dr["uniCity"].ToString();
                    obj.district = ADOprpDL.Dr["uniDistrict"].ToString();
                    obj.state = ADOprpDL.Dr["uniState"].ToString();
                    obj.phoneNo = ADOprpDL.Dr["uniContact"].ToString();
                    obj.mobNo = ADOprpDL.Dr["uniMobile"].ToString();
                    obj.mailId = ADOprpDL.Dr["uniEmailID"].ToString();
                    obj.emailID = ADOprpDL.Dr["uniwebsite"].ToString();
                    obj.DOJ = ADOprpDL.Dr["uniDate"].ToString();
                    obj.status = ADOprpDL.Dr["uniStatus"].ToString();
                    obj.branchCodeName = ADOprpDL.Dr["uniCod"].ToString();
                    obj.uniID = ADOprpDL.Dr["uniCountry"].ToString();
                    obj.catID = ADOprpDL.Dr["uniTypeId"].ToString();
                    obj.education = ADOprpDL.Dr["eduTypeId"].ToString();
                    obj.rank = ADOprpDL.Dr["uniRankType"].ToString();
                    obj.grade = ADOprpDL.Dr["uniStudentGrade"].ToString();                    
                }
            }
            ADO.ReaderClose(ADOprpDL);
            return obj;
        }
        public List<PRPSetup> ViewUniversityWeb(PRPSetup prp)
        {            
            ADOprpDL.ArrayPram = new SqlParameter[7];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.ArrayPram[2] = new SqlParameter("@Id", prp.uniID);
            ADOprpDL.ArrayPram[3] = new SqlParameter("@stateId", prp.state);
            ADOprpDL.ArrayPram[4] = new SqlParameter("@districtId", prp.district);
            ADOprpDL.ArrayPram[5] = new SqlParameter("@cityId", prp.city);
            ADOprpDL.ArrayPram[6] = new SqlParameter("@filterby", prp.status);
            ADOprpDL.SPName = "viewUniversityWeb";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup objprp;
            List<PRPSetup> lst = new List<PRPSetup>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    
                    objprp = new PRPSetup();
                    objprp.id = ADOprpDL.Dr["uniId"].ToString();
                    objprp.name = ADOprpDL.Dr["uniName"].ToString();
                    objprp.mainLandMark = ADOprpDL.Dr["uniLandMark"].ToString();
                    objprp.address = ADOprpDL.Dr["uniAddress"].ToString();
                    objprp.city = ADOprpDL.Dr["cityName"].ToString();
                    objprp.district = ADOprpDL.Dr["distName"].ToString();
                    objprp.state = ADOprpDL.Dr["stateName"].ToString();
                    objprp.phoneNo = ADOprpDL.Dr["uniContact"].ToString();
                    objprp.mobNo = ADOprpDL.Dr["uniMobile"].ToString();
                    objprp.mailId = ADOprpDL.Dr["uniEmailID"].ToString();
                    objprp.emailID = ADOprpDL.Dr["uniwebsite"].ToString();
                    objprp.DOJ = ADOprpDL.Dr["uniDate"].ToString();
                    objprp.status = ADOprpDL.Dr["uniStatus"].ToString();
                    objprp.branchCodeName = ADOprpDL.Dr["uniCod"].ToString();
                    objprp.rank = ADOprpDL.Dr["uniRankType"].ToString();
                    objprp.grade = ADOprpDL.Dr["uniStudentGrade"].ToString();
                    objprp.catID = ADOprpDL.Dr["typeName"].ToString();
                    objprp.urlPath = ADOprpDL.Dr["imagePath"].ToString();
                    objprp.fullpath = ADOprpDL.Dr["fullpath"].ToString();
                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetup();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
               }

            }
            else
            {
                objprp = new PRPSetup();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;
        }
        public List<PRPSetup> ViewUniversityType( PRPSetup obj1 )
        {
            objadoprp.Cmd = new SqlCommand();
            objadoprp.Cmd.CommandText = obj1.name;
            objadoprp.Cmd.CommandType = CommandType.StoredProcedure;
            objado.ReaderQuery(objadoprp);

            PRPSetup objprp;
            List<PRPSetup> lst = new List<PRPSetup>();

            PRPSetup obj;

            if (objadoprp.ReturnMsg == "success")
            {
                if (objadoprp.Dr.HasRows)
                {
                    while (objadoprp.Dr.Read())
                    {

                        obj = new PRPSetup();
                        obj.id = objadoprp.Dr["Id"].ToString();
                        obj.name = objadoprp.Dr["name"].ToString();
                        lst.Add(obj);
                    }
                }
                else
                {
                    obj = new PRPSetup();
                    obj.srNo = "Result Not Find";
                    lst.Add(obj);
                }
                objado.ReaderClose(objadoprp);
            }
            else
            {
                obj = new PRPSetup();
                obj.srNo = "Result Not Find";
                lst.Add(obj);
            }
            return lst;
        }

       


        //--End Web University-----------------------
        #region Bind Tutor Subcategory
        public List<PRPSetup> ViewTutorSubcategoryTypeWithParamater(PRPSetup obj1)
        {
            objadoprp.Cmd = new SqlCommand();
            objadoprp.Cmd.CommandText = obj1.name;
            objadoprp.Cmd.Parameters.AddWithValue("@id", obj1.uniID);
            objadoprp.Cmd.Parameters.AddWithValue("@Type", obj1.type);
            objadoprp.Cmd.CommandType = CommandType.StoredProcedure;

            objado.ReaderQuery(objadoprp);

            PRPSetup objprp;
            List<PRPSetup> lst = new List<PRPSetup>();

            PRPSetup obj;

            if (objadoprp.ReturnMsg == "success")
            {
                if (objadoprp.Dr.HasRows)
                {
                    while (objadoprp.Dr.Read())
                    {

                        obj = new PRPSetup();
                        obj.id = objadoprp.Dr["Id"].ToString();
                        obj.name = objadoprp.Dr["name"].ToString();
                        lst.Add(obj);
                    }
                }
                else
                {
                    obj = new PRPSetup();
                    obj.srNo = "Result Not Find";
                    lst.Add(obj);
                }
                objado.ReaderClose(objadoprp);
            }
            else
            {
                obj = new PRPSetup();
                obj.srNo = "Result Not Find";
                lst.Add(obj);
            }
            return lst;
        }
        #endregion
        //--Start Web University--------------------
        public string InsertCollegeDetail(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[37];
            ADOprp.ArrayPram[0] = new SqlParameter("@collegeName", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@collegeCity", objprp.city);
            ADOprp.ArrayPram[2] = new SqlParameter("@collegeDistrict", objprp.district);
            ADOprp.ArrayPram[3] = new SqlParameter("@collegeState", objprp.state);
            ADOprp.ArrayPram[4] = new SqlParameter("@collegeCountry", objprp.uniID);
            ADOprp.ArrayPram[5] = new SqlParameter("@CollegeType", objprp.status);
            ADOprp.ArrayPram[6] = new SqlParameter("@educationType", objprp.education);
            ADOprp.ArrayPram[7] = new SqlParameter("@rank", objprp.rank);
            ADOprp.ArrayPram[8] = new SqlParameter("@grade", objprp.grade);
            ADOprp.ArrayPram[9] = new SqlParameter("@collegePhone", objprp.phoneNo);
            ADOprp.ArrayPram[10] = new SqlParameter("@collegeMailId", objprp.mailId);
            ADOprp.ArrayPram[11] = new SqlParameter("@collegewebId", objprp.emailID);
            ADOprp.ArrayPram[12] = new SqlParameter("@collegeAddress", objprp.address);
            ADOprp.ArrayPram[13] = new SqlParameter("@collegeStatus", objprp.isActive);
            ADOprp.ArrayPram[14] = new SqlParameter("@collegeMobNo", objprp.mobNo);
            ADOprp.ArrayPram[15] = new SqlParameter("@collegeDate", objprp.DOJ);
            ADOprp.ArrayPram[16] = new SqlParameter("@faxNo", objprp.faxNo);
            ADOprp.ArrayPram[17] = new SqlParameter("@nemail", "1");
            ADOprp.ArrayPram[18] = new SqlParameter("@ndaily", objprp.nneDaily);
            ADOprp.ArrayPram[19] = new SqlParameter("@pinCode", objprp.pinCode);
            ADOprp.ArrayPram[20] = new SqlParameter("@LoginType", objprp.title);
            ADOprp.ArrayPram[21] = new SqlParameter("@password", objprp.Password);
            ADOprp.ArrayPram[22] = new SqlParameter("@nesms", objprp.nneSMS);
            ADOprp.ArrayPram[23] = new SqlParameter("@otherLocation", objprp.otherLocation);
            ADOprp.ArrayPram[24] = new SqlParameter("@tutionType", objprp.tutionType);
            ADOprp.ArrayPram[25] = new SqlParameter("@age", objprp.DOB);
            ADOprp.ArrayPram[26] = new SqlParameter("@gender", objprp.marital);  
            ADOprp.ArrayPram[27]=new SqlParameter("@shortDescription",objprp.description);
            ADOprp.ArrayPram[28]=new SqlParameter("@longDescription",objprp.mainLandMark);
            ADOprp.ArrayPram[29]=new SqlParameter("@bestTimeToCall",objprp.AssociateName);
            ADOprp.ArrayPram[30] = new SqlParameter("@query", objprp.urlName);
            ADOprp.ArrayPram[31] = new SqlParameter("@Category", objprp.sCategory);
            ADOprp.ArrayPram[32] = new SqlParameter("@SubCategory", objprp.subCategory);
            ADOprp.ArrayPram[33] = new SqlParameter("@logopath", objprp.sCollegeLogo);
            ADOprp.ArrayPram[34] = new SqlParameter("@ApprovedBy", objprp.ApprovedBy);
            ADOprp.ArrayPram[35] = new SqlParameter("@CourseLevel", objprp.CourseLevel);
            ADOprp.ArrayPram[36] = new SqlParameter("@University", objprp.id);                             
            ADOprp.SPName = "InsertcollegeDetail";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string UpdateCollegeDetail(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[26];

            ADOprp.ArrayPram[0] = new SqlParameter("@collegeCountry", objprp.uniID);
            ADOprp.ArrayPram[1] = new SqlParameter("@collegeState", objprp.state);
            ADOprp.ArrayPram[2] = new SqlParameter("@collegeDistrict", objprp.district);
            ADOprp.ArrayPram[3] = new SqlParameter("@collegeCity", objprp.city);
            ADOprp.ArrayPram[4] = new SqlParameter("@educationType", objprp.education);

            ADOprp.ArrayPram[5] = new SqlParameter("@collegeName", objprp.name);
            ADOprp.ArrayPram[6] = new SqlParameter("@collegeAddress", objprp.address);
            ADOprp.ArrayPram[7] = new SqlParameter("@collegeStatus", objprp.isActive);

            ADOprp.ArrayPram[8] = new SqlParameter("@collegePhone", objprp.phoneNo);
            ADOprp.ArrayPram[9] = new SqlParameter("@collegeMobNo", objprp.mobNo);
            ADOprp.ArrayPram[10] = new SqlParameter("@collegeMailId", objprp.mailId);
            ADOprp.ArrayPram[11] = new SqlParameter("@collegeDate", objprp.DOJ);

            ADOprp.ArrayPram[12] = new SqlParameter("@collegewebId", objprp.emailID);
            ADOprp.ArrayPram[13] = new SqlParameter("@rank", objprp.rank);
            ADOprp.ArrayPram[14] = new SqlParameter("@grade", objprp.grade);
            ADOprp.ArrayPram[15] = new SqlParameter("@CollegeType", objprp.status);
            ADOprp.ArrayPram[16] = new SqlParameter("@pincode", objprp.pinCode);

            ADOprp.ArrayPram[17] = new SqlParameter("@collegeCodeId", objprp.codeId);
            ADOprp.ArrayPram[18] = new SqlParameter("@approvedBy", objprp.branchName);
            ADOprp.ArrayPram[19] = new SqlParameter("@faxnumber", objprp.faxNo);

            ADOprp.ArrayPram[20] = new SqlParameter("@HostalQuerry", objprp.Query);
            ADOprp.ArrayPram[21] = new SqlParameter("@InstituteQuerry", objprp.pageSize);
            ADOprp.ArrayPram[22] = new SqlParameter("@updateStatus", objprp.urlId);
            ADOprp.ArrayPram[23] = new SqlParameter("@affiliatedTo", objprp.urlName);
            ADOprp.ArrayPram[24] = new SqlParameter("@siteName", objprp.urlPrntId);

            ADOprp.ArrayPram[25] = new SqlParameter("@schoolDetail", objprp.bord);
            

            ADOprp.SPName = "UpdateCollegeDetail";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }

        public string UpdateCollegeWebSite(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[2];
            ADOprp.ArrayPram[0] = new SqlParameter("@webSite", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@collegeCod", objprp.id);
            ADOprp.SPName = "updWebSiteName";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }

        public string DeleteCollegeDetail(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@collegeCodeId", objprp.codeId);
            ADOprp.SPName = "deleteCollegeDetail";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }



        public PRPSetup SelectStudDetail(PRPSetup objprp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@kidsId", objprp.codeId);
            //ADOprpDL.ArrayPram[1] = new SqlParameter("@webSite", objprp.name);
            ADOprpDL.SPName = "SelectkidsDetail";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup obj = new PRPSetup();

            if (ADOprpDL.Dr.HasRows)
            {

                while (ADOprpDL.Dr.Read())
                {
                    obj.id = ADOprpDL.Dr["KidsProfileId"].ToString();
                    obj.codeId = ADOprpDL.Dr["KidsProfileId"].ToString();
                    obj.name = ADOprpDL.Dr["KName"].ToString();
                    obj.mainLandMark = ADOprpDL.Dr["KSchoolName"].ToString();
                    obj.urlName = ADOprpDL.Dr["KSchoolBoard"].ToString();
                    obj.address = ADOprpDL.Dr["KAddress"].ToString();
                    obj.city = ADOprpDL.Dr["KDOB"].ToString();
                    obj.district = ADOprpDL.Dr["KGen"].ToString();
                    obj.state = ADOprpDL.Dr["KClass"].ToString();
                    obj.phoneNo = ADOprpDL.Dr["KStream"].ToString();
                    obj.mobNo = ADOprpDL.Dr["KMobNo"].ToString();
                    obj.emailID = ADOprpDL.Dr["KDist"].ToString();
                    obj.mailId = ADOprpDL.Dr["KState"].ToString();
                    obj.DOJ = ADOprpDL.Dr["kCity"].ToString();
                    obj.isActive = ADOprpDL.Dr["isActive"].ToString();
                    obj.branchCodeName = ADOprpDL.Dr["KEmailId"].ToString();
                    obj.uniID = ADOprpDL.Dr["GraduatingYrs"].ToString();
                    obj.status = ADOprpDL.Dr["EduIntrest"].ToString();
                    obj.education = ADOprpDL.Dr["StudyId"].ToString();
                    obj.rank = ADOprpDL.Dr["PrefLocation"].ToString();
                    obj.grade = ADOprpDL.Dr["WhenStart"].ToString();
                    obj.pinCode = ADOprpDL.Dr["CurrentStudying"].ToString();
                    obj.urlPath = ADOprpDL.Dr["KCountry"].ToString();
                    ////
                    //obj.description = ADOprpDL.Dr["ShortDesCription"].ToString();
                    //obj.courseTime = ADOprpDL.Dr["LongDesCription"].ToString();
                    //obj.faxNo = ADOprpDL.Dr["FaxNumber"].ToString();
                    //obj.pv = ADOprpDL.Dr["ContactPerson"].ToString();
                    //obj.designationName = ADOprpDL.Dr["Designation"].ToString();
                    ////
                    //obj.Salary = ADOprpDL.Dr["BoyHostelFee"].ToString();
                    //obj.noOfRecord = ADOprpDL.Dr["BoyHostelSeat"].ToString();
                    //obj.semMode = ADOprpDL.Dr["BoyFeeMode"].ToString();
                    //obj.eligibility = ADOprpDL.Dr["BoyHostelEligibility"].ToString();
                    //obj.Password = ADOprpDL.Dr["BoyFeeType"].ToString();
                    ////
                    //obj.examFees = ADOprpDL.Dr["GirlHostelFee"].ToString();
                    //obj.sex = ADOprpDL.Dr["GirlFeeType"].ToString();
                    //obj.nneDaily = ADOprpDL.Dr["GirlFeeMode"].ToString();
                    //obj.nneEmail = ADOprpDL.Dr["GirlHostelEligibility"].ToString();
                    //obj.otherFees = ADOprpDL.Dr["HostelSeat"].ToString();
                    ////
                    //obj.pageSize = ADOprpDL.Dr["placement"].ToString();
                    //obj.urlPrntId = ADOprpDL.Dr["webcollegeWebSite"].ToString();

                    //obj.DOB = ADOprpDL.Dr["age"].ToString();
                    //obj.AssociateName = ADOprpDL.Dr["gender"].ToString();
                    //obj.specilization = ADOprpDL.Dr["bestTimeToCall"].ToString();
                    //obj.tutionType = ADOprpDL.Dr["tutionType"].ToString();

                    //obj.bord = ADOprpDL.Dr["SchoolBoard"].ToString();
                    //obj.level = ADOprpDL.Dr["SchoolLevel"].ToString();
                    //obj.type = ADOprpDL.Dr["SchoolType"].ToString();
                    //obj.category = ADOprpDL.Dr["SchoolCategory"].ToString();

                    //obj.enrolmentNo = ADOprpDL.Dr["LoginType"].ToString();
                }
            }
            ADO.ReaderClose(ADOprpDL);
            return obj;
        }

        public PRPSetup SelectStudDetail1(PRPSetup objprp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[3];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@SCode", objprp.codeId);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@type", objprp.type);
            ADOprpDL.ArrayPram[2] = new SqlParameter("@ID", objprp.rollNo);
            ADOprpDL.SPName = "SelectStudDetail";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup obj = new PRPSetup();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {      
                   // obj.codeId = ADOprpDL.Dr["SCode"].ToString();
                    obj.name = ADOprpDL.Dr["S_Specilization"].ToString();
                   // obj.isActive = ADOprpDL.Dr["S_Univ"].ToString();
                   // obj.branchCodeName = ADOprpDL.Dr["S_College"].ToString();
                    obj.uniID = ADOprpDL.Dr["S_School"].ToString();
                    obj.status = ADOprpDL.Dr["S_GrdYear"].ToString();
                    obj.education = ADOprpDL.Dr["S_to"].ToString();
                    obj.rank = ADOprpDL.Dr["S_from"].ToString();
                   // obj.grade = ADOprpDL.Dr["S_CityId"].ToString();
                    obj.pinCode = ADOprpDL.Dr["S_StateId"].ToString();
                    obj.urlPath = ADOprpDL.Dr["S_CountryId"].ToString();
                   
                }
            }
            ADO.ReaderClose(ADOprpDL);
            return obj;
        }


        public PRPSetup SelectTutorDetail(PRPSetup objprp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@KidsId", objprp.codeId);
            //ADOprpDL.ArrayPram[1] = new SqlParameter("@webSite", objprp.name);
            ADOprpDL.SPName = "SelectTutorDetailRimpi";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup obj = new PRPSetup();

            if (ADOprpDL.Dr.HasRows)
            {

                while (ADOprpDL.Dr.Read())
                {
                    obj.id = ADOprpDL.Dr["KidsProfileId"].ToString();
                    obj.codeId = ADOprpDL.Dr["KidsProfileId"].ToString();
                    obj.name = ADOprpDL.Dr["KName"].ToString();
                    obj.urlPath = ADOprpDL.Dr["KCountry"].ToString();
                    obj.emailID = ADOprpDL.Dr["KDist"].ToString();
                    obj.mailId = ADOprpDL.Dr["KState"].ToString();
                    obj.DOJ = ADOprpDL.Dr["kCity"].ToString();
                    obj.city = ADOprpDL.Dr["KDOB"].ToString();
                    obj.district = ADOprpDL.Dr["KGen"].ToString();
                    obj.branchCodeName = ADOprpDL.Dr["KEmailId"].ToString();
                    obj.uniID = ADOprpDL.Dr["GraduatingYrs"].ToString();
                    obj.status = ADOprpDL.Dr["EduIntrest"].ToString();
                    obj.mobNo = ADOprpDL.Dr["KMobNo"].ToString();
                    obj.education = ADOprpDL.Dr["StudyId"].ToString();
                    obj.address = ADOprpDL.Dr["KAddress"].ToString();
                    obj.grade = ADOprpDL.Dr["WhenStart"].ToString();
                    obj.mainLandMark = ADOprpDL.Dr["faxNumber"].ToString();
                    obj.urlName = ADOprpDL.Dr["KFname"].ToString();
                    obj.state = ADOprpDL.Dr["KMName"].ToString();
                    obj.phoneNo = ADOprpDL.Dr["smsList"].ToString(); 

                    
                }
            }
            ADO.ReaderClose(ADOprpDL);
            return obj;
        }

        public DataSet SelectCollegeDetail_sal(PRPSetup objprp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@collegeCodeId", objprp.codeId);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@webSite", objprp.name);
            ADOprpDL.SPName = "SelectCollegeDetail_sal";
            DataSet ds = new DataSet();
          ds=ADO.DataSetWithProceduresandParam(ADOprpDL);
          return ds;
        }

        public PRPSetup SelectCollegeDetail(PRPSetup objprp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@collegeCodeId", objprp.codeId);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@webSite", objprp.name);
            ADOprpDL.SPName = "SelectCollegeDetail";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup obj = new PRPSetup(); 

            if (ADOprpDL.Dr.HasRows)
            {

                while (ADOprpDL.Dr.Read())
                {
                    obj.id = ADOprpDL.Dr["collegeCod"].ToString();
                    obj.codeId = ADOprpDL.Dr["collegeID"].ToString();
                    obj.name = ADOprpDL.Dr["collegeName"].ToString();
                    obj.mainLandMark = ADOprpDL.Dr["ApprovedBy"].ToString();
                    obj.urlName = ADOprpDL.Dr["AffilatedTo"].ToString();
                    obj.address = ADOprpDL.Dr["collegeAddress"].ToString();
                    obj.city = ADOprpDL.Dr["collegeCity"].ToString();
                    obj.district = ADOprpDL.Dr["collegeDistrict"].ToString();
                    obj.state = ADOprpDL.Dr["collegeState"].ToString();
                    obj.phoneNo = ADOprpDL.Dr["collegeContact"].ToString();
                    obj.mobNo = ADOprpDL.Dr["collegeMobile"].ToString();
                    obj.emailID = ADOprpDL.Dr["collegewebSite"].ToString();
                    obj.mailId = ADOprpDL.Dr["collegeEmailID"].ToString();
                    obj.DOJ = ADOprpDL.Dr["collegeApprovalDate"].ToString();
                    obj.isActive = ADOprpDL.Dr["isActive"].ToString();
                    obj.branchCodeName = ADOprpDL.Dr["collegeCod"].ToString();
                    obj.uniID = ADOprpDL.Dr["collegeCountry"].ToString();
                    obj.status = ADOprpDL.Dr["collegeType"].ToString();
                    obj.education = ADOprpDL.Dr["eduTypeId"].ToString();
                    obj.rank = ADOprpDL.Dr["collegeRankType"].ToString();
                    obj.grade = ADOprpDL.Dr["collegeStudentGrade"].ToString();
                    obj.pinCode = ADOprpDL.Dr["pincode"].ToString();
                    obj.urlPath = ADOprpDL.Dr["CollegeImage"].ToString();
                    //
                    obj.description = ADOprpDL.Dr["ShortDesCription"].ToString();
                    obj.courseTime = ADOprpDL.Dr["LongDesCription"].ToString();
                    obj.faxNo = ADOprpDL.Dr["FaxNumber"].ToString();
                    obj.pv = ADOprpDL.Dr["ContactPerson"].ToString();
                    obj.designationName = ADOprpDL.Dr["Designation"].ToString();
                    //
                    obj.Salary = ADOprpDL.Dr["BoyHostelFee"].ToString();
                    obj.noOfRecord = ADOprpDL.Dr["BoyHostelSeat"].ToString();
                    obj.semMode = ADOprpDL.Dr["BoyFeeMode"].ToString();
                    obj.eligibility = ADOprpDL.Dr["BoyHostelEligibility"].ToString();
                    obj.Password = ADOprpDL.Dr["BoyFeeType"].ToString();
                    //
                    obj.examFees = ADOprpDL.Dr["GirlHostelFee"].ToString();
                    obj.sex = ADOprpDL.Dr["GirlFeeType"].ToString();
                    obj.nneDaily = ADOprpDL.Dr["GirlFeeMode"].ToString();
                    obj.nneEmail = ADOprpDL.Dr["GirlHostelEligibility"].ToString();
                    obj.otherFees = ADOprpDL.Dr["HostelSeat"].ToString();
                    //
                    obj.pageSize = ADOprpDL.Dr["placement"].ToString();
                    obj.urlPrntId = ADOprpDL.Dr["webcollegeWebSite"].ToString();

                    obj.DOB = ADOprpDL.Dr["age"].ToString();
                    obj.AssociateName = ADOprpDL.Dr["gender"].ToString();
                    obj.specilization = ADOprpDL.Dr["bestTimeToCall"].ToString();
                    obj.tutionType = ADOprpDL.Dr["tutionType"].ToString();

                    obj.bord = ADOprpDL.Dr["SchoolBoard"].ToString();
                    obj.level = ADOprpDL.Dr["SchoolLevel"].ToString();
                    obj.type = ADOprpDL.Dr["SchoolType"].ToString();
                    obj.category = ADOprpDL.Dr["SchoolCategory"].ToString();

                    obj.enrolmentNo = ADOprpDL.Dr["LoginType"].ToString();
                }
            }
            ADO.ReaderClose(ADOprpDL);
            return obj;
}
        public DataSet SelectCollegeDetailWithDataset(PRPSetup objprp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@collegeCodeId", objprp.codeId);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@webSite", objprp.name);
            ADOprpDL.SPName = "SelectCollegeDetail";
            return ADO.DataSetWithProceduresandParam(ADOprpDL);
        }        
        public List<PRPSetup> ViewCollegeDetail(PRPSetup prp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[10];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.ArrayPram[2] = new SqlParameter("@Id", prp.uniID);
            ADOprpDL.ArrayPram[3] = new SqlParameter("@stateId", prp.state);
            ADOprpDL.ArrayPram[4] = new SqlParameter("@districtId", prp.district);
            ADOprpDL.ArrayPram[5] = new SqlParameter("@cityId", prp.city);
            ADOprpDL.ArrayPram[6] = new SqlParameter("@filterby", prp.status);
            ADOprpDL.ArrayPram[7] = new SqlParameter("@universityId", prp.id);
            ADOprpDL.ArrayPram[8] = new SqlParameter("@collegeId", prp.catID);
            ADOprpDL.ArrayPram[9] = new SqlParameter("@LoginType", prp.LoginType);

            ADOprpDL.SPName = "viewCollegeDetail";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup objprp;
            List<PRPSetup> lst = new List<PRPSetup>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetup();
                    objprp.id = ADOprpDL.Dr["collegeId"].ToString();
                    objprp.name = ADOprpDL.Dr["collegeName"].ToString();
                  //  objprp.mainLandMark = ADOprpDL.Dr["collegeLandMark"].ToString();
                    objprp.address = ADOprpDL.Dr["collegeAddress"].ToString();
                    objprp.city = ADOprpDL.Dr["cityName"].ToString();
                    objprp.district = ADOprpDL.Dr["distName"].ToString();
                    objprp.state = ADOprpDL.Dr["stateName"].ToString();
                    objprp.phoneNo = ADOprpDL.Dr["collegeContact"].ToString();
                    objprp.mobNo = ADOprpDL.Dr["collegeMobile"].ToString();
                    objprp.mailId = ADOprpDL.Dr["collegeEmailID"].ToString();
                    objprp.DOJ = ADOprpDL.Dr["Date"].ToString();
                    objprp.isActive = ADOprpDL.Dr["isActive"].ToString();
                    objprp.branchCodeName = ADOprpDL.Dr["collegeCod"].ToString();
                    objprp.rank = ADOprpDL.Dr["collegeRankType"].ToString();
                    objprp.grade = ADOprpDL.Dr["collegeStudentGrade"].ToString();
                    objprp.status = ADOprpDL.Dr["collegeType"].ToString();
                    objprp.catID = ADOprpDL.Dr["typeName"].ToString();
                  //  objprp.uniID = ADOprpDL.Dr["uniName"].ToString();                    
                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetup();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }

            }
            else
            {
                objprp = new PRPSetup();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;
        }
        public List<PRPSetup> ViewCollegeType( PRPSetup obj1 )
        {
            objadoprp.Cmd = new SqlCommand();
            objadoprp.Cmd.CommandText = obj1.name;
            objadoprp.Cmd.CommandType = CommandType.StoredProcedure;
            objado.ReaderQuery(objadoprp);
            List<PRPSetup> lst = new List<PRPSetup>();
            PRPSetup obj;

            if (objadoprp.ReturnMsg == "success")
            {
                if (objadoprp.Dr.HasRows)
                {
                    while (objadoprp.Dr.Read())
                    {

                        obj = new PRPSetup();
                        obj.id = objadoprp.Dr["Id"].ToString();
                        obj.name = objadoprp.Dr["name"].ToString();
                        obj.accutalPath = objadoprp.Dr["paths"].ToString();
                        lst.Add(obj);
                    }
                }
                else
                {
                    obj = new PRPSetup();
                    obj.srNo = "Result Not Find";
                    lst.Add(obj);
                }
                objado.ReaderClose(objadoprp);
            }
            else
            {
                obj = new PRPSetup();
                obj.srNo = "Result Not Find";
                lst.Add(obj);
            }
            return lst;
        }
        public List<PRPSetup> ViewCollegeType1(PRPSetup prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@Id", prp.id);
            ADOprpDL.SPName = "viewCollegeType1";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup objprp;
            List<PRPSetup> lst = new List<PRPSetup>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetup();
                    objprp.id = ADOprpDL.Dr["Id"].ToString();
                    objprp.name = ADOprpDL.Dr["Name"].ToString();
                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetup();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }

            }
            else
            {
                objprp = new PRPSetup();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;
        }
 //--End Web University-----------------------
//---Start---Setup Course Category-----------------  
        public string InsCourseCategory(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[3];
            ADOprp.ArrayPram[0] = new SqlParameter("@catName", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@uniID", objprp.uniID);
            ADOprp.ArrayPram[2] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.SPName = "insCourseCategory";            
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string UpdCourseCategory(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[4];

            ADOprp.ArrayPram[0] = new SqlParameter("@catID", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@catName", objprp.name);
            ADOprp.ArrayPram[2] = new SqlParameter("@uniID", objprp.uniID);
            ADOprp.ArrayPram[3] = new SqlParameter("@isActive", objprp.isActive);

            ADOprp.SPName = "updCourseCategory";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }
        public string DelCourseCategory(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@catID", objprp.id);
            ADOprp.SPName = "delCourseCategory";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);



        }
        public PRPSetup SelCourseCategory(PRPSetup objprp)
        {
            
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@catID", objprp.id);
            ADOprpDL.SPName = "selCourseCategory";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup obj = new PRPSetup(); ;

            if (ADOprpDL.Dr.HasRows)
            {

                while (ADOprpDL.Dr.Read())
                {
                    obj.id = ADOprpDL.Dr["catID"].ToString();
                    obj.name = ADOprpDL.Dr["catName"].ToString();
                    obj.isActive = ADOprpDL.Dr["isActive"].ToString();
                }
            }
            ADO.ReaderClose(ADOprpDL);
            return obj;
        }
        public DataTable ViewCourseCategory( PRPSetup objprp )
        {
            ADOprp.ArrayPram = new SqlParameter[1];

            ADOprp.ArrayPram[0] = new SqlParameter("@status", objprp.status);

            ADOprp.SPName = "ViewCourseCategory";
            return ADO.DataTableWithProcedures(ADOprp);           
        }    
//--End Setup Course Category----.

//--start--Course Detail---------      
        public string InsertCourse(PRPSetup objprp)
        {            
            ADOprp.ArrayPram = new SqlParameter[16];
            ADOprp.ArrayPram[0] = new SqlParameter("@courseName", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@courseCode", objprp.branchCodeName);
            ADOprp.ArrayPram[2] = new SqlParameter("@courseSpecilization", objprp.specilization);
            ADOprp.ArrayPram[3] = new SqlParameter("@durationMinTime", objprp.durationMinTime);
            ADOprp.ArrayPram[4] = new SqlParameter("@durationMaxTime", objprp.durationMaxTime);
            ADOprp.ArrayPram[5] = new SqlParameter("@courseEligibility", objprp.eligibility);
            ADOprp.ArrayPram[6] = new SqlParameter("@pv", objprp.pv);
            ADOprp.ArrayPram[7] = new SqlParameter("@courseFees", objprp.courseFees);
            ADOprp.ArrayPram[8] = new SqlParameter("@examFees", objprp.examFees);
            ADOprp.ArrayPram[9] = new SqlParameter("@otherFees", objprp.otherFees);
            ADOprp.ArrayPram[10] = new SqlParameter("@regFees", objprp.regFees);
            ADOprp.ArrayPram[11] = new SqlParameter("@courseUniID", objprp.uniID);
            ADOprp.ArrayPram[12] = new SqlParameter("@courseCatID", objprp.catID);
            ADOprp.ArrayPram[13] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.ArrayPram[14] = new SqlParameter("@courseTime", objprp.courseTime);
            ADOprp.ArrayPram[15] = new SqlParameter("@semMode", objprp.semMode);
            ADOprp.SPName = "insCourse";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }
        public string UpdateCourse(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[17];
            ADOprp.ArrayPram[0] = new SqlParameter("@courseID", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@courseName", objprp.name);
            ADOprp.ArrayPram[2] = new SqlParameter("@courseCode", objprp.branchCodeName);
            ADOprp.ArrayPram[3] = new SqlParameter("@courseSpecilization", objprp.specilization);
            ADOprp.ArrayPram[4] = new SqlParameter("@durationMinTime", objprp.durationMinTime);
            ADOprp.ArrayPram[5] = new SqlParameter("@durationMaxTime", objprp.durationMaxTime);
            ADOprp.ArrayPram[6] = new SqlParameter("@courseEligibility", objprp.eligibility);
            ADOprp.ArrayPram[7] = new SqlParameter("@pv", objprp.pv);
            ADOprp.ArrayPram[8] = new SqlParameter("@courseFees", objprp.courseFees);
            ADOprp.ArrayPram[9] = new SqlParameter("@examFees", objprp.examFees);
            ADOprp.ArrayPram[10] = new SqlParameter("@otherFees", objprp.otherFees);
            ADOprp.ArrayPram[11] = new SqlParameter("@regFees", objprp.regFees);
            ADOprp.ArrayPram[12] = new SqlParameter("@courseUniID", objprp.uniID);
            ADOprp.ArrayPram[13] = new SqlParameter("@courseCatID", objprp.catID);
            ADOprp.ArrayPram[14] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.ArrayPram[15] = new SqlParameter("@courseTime", objprp.courseTime);
            ADOprp.ArrayPram[16] = new SqlParameter("@semMode", objprp.semMode);
            ADOprp.SPName = "updCourse";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string DeleteCourse(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@CourseID", objprp.id);
            ADOprp.SPName = "delCourse";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);



        }
        public PRPSetup SelectCourse(PRPSetup objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@CourseID", objprp.id);
            ADOprpDL.SPName = "selCourse";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup obj = new PRPSetup(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj=new PRPSetup();
                    obj.id=ADOprpDL.Dr["courseId"].ToString();
                    obj.name= ADOprpDL.Dr["courseName"].ToString();
                    obj.branchCodeName=ADOprpDL.Dr["courseCode"].ToString();
                    obj.specilization= ADOprpDL.Dr["courseSpecilization"].ToString();
                    obj.durationMinTime= ADOprpDL.Dr["durationMinTime"].ToString();
                    obj.durationMaxTime= ADOprpDL.Dr["durationMaxTime"].ToString();
                    obj.eligibility= ADOprpDL.Dr["courseEligibility"].ToString();
                    obj.pv= ADOprpDL.Dr["prosFees"].ToString();                    
                    obj.courseFees= ADOprpDL.Dr["courseFees"].ToString();
                    obj.examFees= ADOprpDL.Dr["examFees"].ToString();
                    obj.otherFees=ADOprpDL.Dr["otherFees"].ToString();
                    obj.regFees=  ADOprpDL.Dr["regFees"].ToString();
                    obj.uniID= ADOprpDL.Dr["courseUniID"].ToString();
                    obj.catID=ADOprpDL.Dr["courseCatID"].ToString();
                    obj.isActive = ADOprpDL.Dr["isActive"].ToString();
                    obj.courseTime = ADOprpDL.Dr["courseTime"].ToString();
                    obj.semMode = ADOprpDL.Dr["semMode"].ToString();                    
                }
            }
            ADO.ReaderClose(ADOprpDL);
            return obj;
        }
        public List<PRPSetup> ViewCourse(PRPSetup prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[5];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.ArrayPram[2] = new SqlParameter("@courseUniID", prp.uniID);
            ADOprpDL.ArrayPram[3] = new SqlParameter("@courseCatID", prp.catID);
            ADOprpDL.ArrayPram[4] = new SqlParameter("@status", prp.status);
            ADOprpDL.SPName = "viewCourse";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup objprp;
            List<PRPSetup> lst = new List<PRPSetup>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetup();
                    objprp.id = ADOprpDL.Dr["courseId"].ToString();
                    objprp.name = ADOprpDL.Dr["courseName"].ToString();
                    objprp.branchCodeName = ADOprpDL.Dr["courseCode"].ToString();
                    objprp.specilization = ADOprpDL.Dr["courseSpecilization"].ToString();
                    objprp.durationMinTime = ADOprpDL.Dr["durationMinTime"].ToString();
                    objprp.durationMaxTime = ADOprpDL.Dr["durationMaxTime"].ToString();
                    objprp.eligibility = ADOprpDL.Dr["courseEligibility"].ToString();
                    objprp.pv = ADOprpDL.Dr["prosFees"].ToString();
                    objprp.courseFees = ADOprpDL.Dr["courseFees"].ToString();
                    objprp.examFees = ADOprpDL.Dr["examFees"].ToString();
                    objprp.otherFees = ADOprpDL.Dr["otherFees"].ToString();
                    objprp.regFees = ADOprpDL.Dr["regFees"].ToString();
                    objprp.uniID = ADOprpDL.Dr["courseUniID"].ToString();
                    objprp.catID = ADOprpDL.Dr["courseCatID"].ToString();
                    objprp.isActive = ADOprpDL.Dr["isActive"].ToString();
                    objprp.courseTime = ADOprpDL.Dr["courseTime"].ToString();
                    objprp.semMode = ADOprpDL.Dr["semMode"].ToString();
                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetup();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPSetup();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
//--End--Course Detail-----------

//--Start--News Type.
        public string InsNewsType(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[6];
            ADOprp.ArrayPram[0] = new SqlParameter("@typeName", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@uniID", objprp.uniID);
            ADOprp.ArrayPram[2] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.ArrayPram[3] = new SqlParameter("@ImagePath", objprp.urlPath);
            ADOprp.ArrayPram[4] = new SqlParameter("@NewsTypeTitle", objprp.title);
            ADOprp.ArrayPram[5] = new SqlParameter("@NewsTypeDescription", objprp.description);

            ADOprp.SPName = "insNewsType";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string UpdNewsType(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[7];

            ADOprp.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@typeName", objprp.name);
            ADOprp.ArrayPram[2] = new SqlParameter("@uniID", objprp.uniID);
            ADOprp.ArrayPram[3] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.ArrayPram[4] = new SqlParameter("@ImagePath", objprp.urlPath);
            ADOprp.ArrayPram[5] = new SqlParameter("@NewsTypeTitle", objprp.title);
            ADOprp.ArrayPram[6] = new SqlParameter("@NewsTypeDescription", objprp.description);

            ADOprp.SPName = "updNewsType";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string DelNewsType(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
            ADOprp.SPName = "delNewsType";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);



        }
        public PRPSetup SelNewsType(PRPSetup objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
            ADOprpDL.SPName = "selNewsType";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup obj = new PRPSetup(); ;

            if (ADOprpDL.Dr.HasRows)
            {

                while (ADOprpDL.Dr.Read())
                {
                    obj.id = ADOprpDL.Dr["typeID"].ToString();
                    obj.name = ADOprpDL.Dr["typeName"].ToString();
                    obj.isActive = ADOprpDL.Dr["isActive"].ToString();
                    obj.uniID = ADOprpDL.Dr["NewForId"].ToString();
                    obj.urlPath = ADOprpDL.Dr["ImagePath"].ToString();
                    obj.title = ADOprpDL.Dr["NewsTypeTitle"].ToString();
                    obj.description = ADOprpDL.Dr["NewsTypeDescription"].ToString();
                }
            }
            ADO.ReaderClose(ADOprpDL);
            return obj;
        }
        
//--End--News Type

//--Start--News.
        public string InsNews(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[8];
            ADOprp.ArrayPram[0] = new SqlParameter("@uniID", objprp.uniID);
            ADOprp.ArrayPram[1] = new SqlParameter("@catID", objprp.catID);
            ADOprp.ArrayPram[2] = new SqlParameter("@newsTitle", objprp.title);
            ADOprp.ArrayPram[3] = new SqlParameter("@newsDescription",objprp.description);            
            ADOprp.ArrayPram[4] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.ArrayPram[5] = new SqlParameter("@Date", objprp.DOJ);
            ADOprp.ArrayPram[6] = new SqlParameter("@subTitle", objprp.status);
            ADOprp.ArrayPram[7] = new SqlParameter("@newImage", objprp.urlPath);
            ADOprp.SPName = "insNews";            
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string UpdNews(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[9];
            ADOprp.ArrayPram[0] = new SqlParameter("@newsID", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@uniID", objprp.uniID);
            ADOprp.ArrayPram[2] = new SqlParameter("@catID", objprp.catID);
            ADOprp.ArrayPram[3] = new SqlParameter("@newsTitle", objprp.title);
            ADOprp.ArrayPram[4] = new SqlParameter("@newsDescription", objprp.description);
            ADOprp.ArrayPram[5] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.ArrayPram[6] = new SqlParameter("@Date", objprp.DOJ);
            ADOprp.ArrayPram[7] = new SqlParameter("@subTitle", objprp.status);
            ADOprp.ArrayPram[8] = new SqlParameter("@newImage", objprp.urlPath);            
            ADOprp.SPName = "updNews";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string DelNews(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@newsID", objprp.id);
            ADOprp.SPName = "delNews";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public PRPSetup SelNews(PRPSetup objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@newsID", objprp.id);
            ADOprpDL.SPName = "selNews";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup obj = new PRPSetup(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {                   
                    obj = new PRPSetup();
                    obj.id = ADOprpDL.Dr["newsID"].ToString();
                    obj.title = ADOprpDL.Dr["newsTitle"].ToString();
                    obj.description = ADOprpDL.Dr["newsDescription"].ToString();
                    obj.catID = ADOprpDL.Dr["newsTypeID"].ToString();
                    obj.uniID = ADOprpDL.Dr["newsUniversityID"].ToString();
                    obj.DOJ = ADOprpDL.Dr["newsDate"].ToString();
                    obj.DOB = ADOprpDL.Dr["newsDate1"].ToString();
                    obj.isActive = ADOprpDL.Dr["isActive"].ToString();
                    obj.status = ADOprpDL.Dr["subTitle"].ToString();
                    obj.urlPath = ADOprpDL.Dr["newImage"].ToString();
                }
            }
            ADO.ReaderClose(ADOprpDL);
            return obj;
        }
        public List<PRPSetup> ViewNews(PRPSetup prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[4];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.ArrayPram[2] = new SqlParameter("@newsUniversityID", prp.uniID);
            ADOprpDL.ArrayPram[3] = new SqlParameter("@catId", prp.catID);

            ADOprpDL.SPName = "viewNews";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup objprp;
            List<PRPSetup> lst = new List<PRPSetup>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetup();
                    objprp.id = ADOprpDL.Dr["newsID"].ToString();
                    objprp.title = ADOprpDL.Dr["newsTitle"].ToString();
                  //  objprp.description = ADOprpDL.Dr["newsDescription"].ToString();
                    objprp.catID = ADOprpDL.Dr["newsType"].ToString();
                    objprp.uniID = ADOprpDL.Dr["uniName"].ToString();                    
                    objprp.DOJ = ADOprpDL.Dr["newsDate"].ToString();
                    objprp.isActive = ADOprpDL.Dr["isActive"].ToString();
                    objprp.status = ADOprpDL.Dr["subTitle"].ToString();
                    objprp.urlPath = ADOprpDL.Dr["newImage"].ToString();
                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetup();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPSetup();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
        public List<PRPSetup> ViewNews1(PRPSetup prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@newsType", prp.catID);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@uniId", prp.uniID);
            ADOprpDL.SPName = "viewNews1";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup objprp;
            List<PRPSetup> lst = new List<PRPSetup>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetup();
                    objprp.id = ADOprpDL.Dr["newsID"].ToString();
                    objprp.title = ADOprpDL.Dr["newsTitle"].ToString();
                    objprp.description = ADOprpDL.Dr["newsDescription"].ToString();
                    objprp.DOJ = ADOprpDL.Dr["newsDate"].ToString();
                    objprp.status = ADOprpDL.Dr["subTitle"].ToString();
                    objprp.urlPath = ADOprpDL.Dr["newImage"].ToString();
                    objprp.catID = ADOprpDL.Dr["newsTypeId"].ToString();
                    objprp.uniID = ADOprpDL.Dr["newsUniversityId"].ToString();
                    objprp.accutalPath = ADOprpDL.Dr["accutalpath"].ToString();
                    objprp.fullpath = ADOprpDL.Dr["imageFullPath"].ToString();
                    lst.Add(objprp);
                }                
            }
            else
            {
                objprp = new PRPSetup();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;
        }

        public List<PRPSetup> crsViewAllSubCategory1(PRPSetup prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@id", prp.id);
          
            ADOprpDL.SPName = "crsViewAllSubCategory1";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup objprp;
            List<PRPSetup> lst = new List<PRPSetup>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetup();
                    objprp.id = ADOprpDL.Dr["id"].ToString();
                    objprp.title = ADOprpDL.Dr["name"].ToString();
                    objprp.accutalPath = ADOprpDL.Dr["accutalPath"].ToString();
                    lst.Add(objprp);
                }
            }
            else
            {
                objprp = new PRPSetup();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;
        }

        public List<PRPSetup> crsViewAllSubCategoryByName1(PRPSetup prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@CatName", prp.name);

            ADOprpDL.SPName = "crsViewAllSubCategoryByName1";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup objprp;
            List<PRPSetup> lst = new List<PRPSetup>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetup();
                    objprp.id = ADOprpDL.Dr["id"].ToString();
                    objprp.title = ADOprpDL.Dr["name"].ToString();
                    objprp.accutalPath = ADOprpDL.Dr["accutalPath"].ToString();
                    lst.Add(objprp);
                }
            }
            else
            {
                objprp = new PRPSetup();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;
        }

        public List<PRPSetup> viewNewsWithPaging1(PRPSetup prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[4];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@newsType", prp.catID);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@uniId", prp.uniID);
            ADOprpDL.ArrayPram[2] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[3] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.SPName = "viewNewsWithPaging1";
            ADO.ReaderWithProceduresandParam(ADOprpDL);
            PRPSetup objprp;
            List<PRPSetup> lst = new List<PRPSetup>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetup();
                    objprp.id = ADOprpDL.Dr["newsID"].ToString();
                    objprp.title = ADOprpDL.Dr["newsTitle"].ToString();
                  //  objprp.description = ADOprpDL.Dr["newsDescription"].ToString();
                    objprp.DOJ = ADOprpDL.Dr["newsDate"].ToString();
                    objprp.status = ADOprpDL.Dr["subTitle"].ToString();
                    objprp.urlPath = ADOprpDL.Dr["newImage"].ToString();
                    objprp.catID = ADOprpDL.Dr["newsTypeId"].ToString();
                    objprp.uniID = ADOprpDL.Dr["newsUniversityID"].ToString();
                    objprp.fullpath = ADOprpDL.Dr["fullpath"].ToString() ; 
                    objprp.accutalPath = ADOprpDL.Dr["accutalpath"].ToString();  

                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetup();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }
            }
            else
            {
                objprp = new PRPSetup();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
        public List<PRPSetup> ViewNews2(PRPSetup prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@newsType", prp.catID);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@uniId", prp.uniID);
            ADOprpDL.SPName = "viewNews2";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup objprp;
            List<PRPSetup> lst = new List<PRPSetup>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetup();
                    objprp.id = ADOprpDL.Dr["newsID"].ToString();
                    objprp.title = ADOprpDL.Dr["newsTitle"].ToString();
                    objprp.description = ADOprpDL.Dr["newsDescription"].ToString();
                    objprp.DOJ = ADOprpDL.Dr["newsDate"].ToString();
                    objprp.status = ADOprpDL.Dr["subTitle"].ToString();
                    objprp.urlPath = ADOprpDL.Dr["newImage"].ToString();
                    objprp.catID = ADOprpDL.Dr["newsTypeId"].ToString();
                    objprp.uniID = ADOprpDL.Dr["newsUniversityId"].ToString();
                    objprp.accutalPath = ADOprpDL.Dr["accutalpath"].ToString();
                    objprp.fullpath = ADOprpDL.Dr["imageFullPath"].ToString();
                    lst.Add(objprp);
                }
            }
            else
            {
                objprp = new PRPSetup();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;
        }
//--End--News.

//--Start--New Job.
        public string InsJob(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[3];
            ADOprp.ArrayPram[0] = new SqlParameter("@JobTitle", objprp.title);
            ADOprp.ArrayPram[1] = new SqlParameter("@JobDescription", objprp.description);
            ADOprp.ArrayPram[2] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.SPName = "insJob";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string UpdJob(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[4];
            ADOprp.ArrayPram[0] = new SqlParameter("@JobID", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@JobTitle", objprp.title);
            ADOprp.ArrayPram[2] = new SqlParameter("@JobDescription", objprp.description);
            ADOprp.ArrayPram[3] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.SPName = "updJob";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string DelJob(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@JobID", objprp.id);
            ADOprp.SPName = "delJob";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public PRPSetup SelJob(PRPSetup objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@JobID", objprp.id);
            ADOprpDL.SPName = "selJob";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup obj = new PRPSetup(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj = new PRPSetup();
                    obj.id = ADOprpDL.Dr["jobID"].ToString();
                    obj.title = ADOprpDL.Dr["jobTitle"].ToString();
                    obj.description = ADOprpDL.Dr["jobDescription"].ToString();
                    obj.DOJ = ADOprpDL.Dr["postedOn"].ToString();
                    obj.isActive = ADOprpDL.Dr["isActive"].ToString();
                }
            }
            ADO.ReaderClose(ADOprpDL);
            return obj;
        }
        public List<PRPSetup> ViewJob(PRPSetup prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.SPName = "viewJob";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup objprp;
            List<PRPSetup> lst = new List<PRPSetup>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetup();
                    objprp.id = ADOprpDL.Dr["jobID"].ToString();
                    objprp.title = ADOprpDL.Dr["jobTitle"].ToString();
                    objprp.description = ADOprpDL.Dr["jobDescription"].ToString();
                    objprp.DOJ = ADOprpDL.Dr["postedOn"].ToString();
                    objprp.isActive = ADOprpDL.Dr["isActive"].ToString();
                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetup();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPSetup();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
        public List<PRPSetup> ViewJob1(PRPSetup prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.SPName = "viewJob1";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup objprp;
            List<PRPSetup> lst = new List<PRPSetup>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetup();
                    objprp.id = ADOprpDL.Dr["jobID"].ToString();
                    objprp.title = ADOprpDL.Dr["jobTitle"].ToString();
                    objprp.description = ADOprpDL.Dr["jobDescription"].ToString();
                    objprp.DOJ = ADOprpDL.Dr["postedOn"].ToString();
                    objprp.isActive = ADOprpDL.Dr["isActive"].ToString();
                    lst.Add(objprp);
                }
                
            }
            else
            {
                objprp = new PRPSetup();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }

//--End--New Job.

//--Start Resume Detail.
        public string InsResumeDetail(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[7];
            ADOprp.ArrayPram[0] = new SqlParameter("@resumeName", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@resumeMobNo", objprp.mobNo);
            ADOprp.ArrayPram[2] = new SqlParameter("@resumeEmailID", objprp.emailID);
            ADOprp.ArrayPram[3] = new SqlParameter("@resumeSubject", objprp.title);
            ADOprp.ArrayPram[4] = new SqlParameter("@resumeDescription", objprp.description);
            ADOprp.ArrayPram[5] = new SqlParameter("@resumePath", objprp.urlPath);
            ADOprp.ArrayPram[6] = new SqlParameter("@resumeJobID", objprp.catID);
            ADOprp.SPName = "insResumeDetail";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }
        public string UpdResumeDetail(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[2];
            ADOprp.ArrayPram[0] = new SqlParameter("@resumeID", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.SPName = "updResumeDetail";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
      
        public string GetMaxFileId()
        {
            ADOprp.SPName = "spGetfieMaxId";
            return ADO.ScalarQueryWithProcedures(ADOprp);
        }
        public List<PRPSetup> ViewResumeDetail(PRPSetup prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.SPName = "viewResumeDetail";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup objprp;
            List<PRPSetup> lst = new List<PRPSetup>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {   objprp = new PRPSetup();
                    objprp.id = ADOprpDL.Dr["resumeID"].ToString();
                    objprp.name = ADOprpDL.Dr["personName"].ToString();
                    objprp.mobNo = ADOprpDL.Dr["mobileNo"].ToString();
                    objprp.emailID = ADOprpDL.Dr["emailID"].ToString();
                    objprp.title = ADOprpDL.Dr["subjects"].ToString();
                    objprp.description = ADOprpDL.Dr["msg"].ToString();
                    objprp.urlPath = ADOprpDL.Dr["resumePath"].ToString();
                    objprp.catID = ADOprpDL.Dr["jobTitle"].ToString();
                    objprp.DOJ = ADOprpDL.Dr["postedOn"].ToString();
                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetup();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPSetup();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
//--End Resume Detail
//--Start Link file Upload.
        public string InsFile(PRPSetup obj)
        {
            ADOprp.ArrayPram = new SqlParameter[4];
            ADOprp.ArrayPram[0] = new SqlParameter("@linkUniversity",obj.uniID);
            ADOprp.ArrayPram[1] = new SqlParameter("@linkName",obj.name);
            ADOprp.ArrayPram[2] = new SqlParameter("@linkPath",obj.urlPath);
            ADOprp.ArrayPram[3] = new SqlParameter("@isActive",obj.isActive);
            ADOprp.SPName = "insFileDetail";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string UpdFile(PRPSetup obj)
        {
            ADOprp.ArrayPram = new SqlParameter[5];
            ADOprp.ArrayPram[0] = new SqlParameter("@linkID", obj.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@linkUniversity", obj.uniID);
            ADOprp.ArrayPram[2] = new SqlParameter("@linkName", obj.name);
            ADOprp.ArrayPram[3] = new SqlParameter("@linkPath", obj.urlPath);
            ADOprp.ArrayPram[4] = new SqlParameter("@isActive", obj.isActive);
            ADOprp.SPName = "updFileDetail";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public List<PRPSetup> ViewFile(PRPSetup obj)
        {
            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", obj.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", obj.pageSize);
            ADOprpDL.SPName = "viewFileDetail";
            ADO.ReaderWithProceduresandParam(ADOprpDL);
            PRPSetup objprp;
            List<PRPSetup> lst = new List<PRPSetup>();
            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetup();
                    objprp.id = ADOprpDL.Dr["downID"].ToString();
                    objprp.name = ADOprpDL.Dr["downLinkName"].ToString();
                    objprp.mobNo = ADOprpDL.Dr["downLinkPath"].ToString();
                    objprp.emailID = ADOprpDL.Dr["downUniID"].ToString();
                    objprp.title = ADOprpDL.Dr["isActive"].ToString();
                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {
                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetup();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPSetup();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
        public PRPSetup SelFile(PRPSetup obj)
        {
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@LinkID", obj.id);            
            ADOprpDL.SPName = "selFileDetail";
            ADO.ReaderWithProceduresandParam(ADOprpDL);
            PRPSetup objprp= new PRPSetup();;
          //  List<PRPSetup> lst = new List<PRPSetup>();
            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp.id = ADOprpDL.Dr["downID"].ToString();
                    objprp.name = ADOprpDL.Dr["downLinkName"].ToString();
                    objprp.urlPath = ADOprpDL.Dr["downLinkPath"].ToString();
                    objprp.uniID = ADOprpDL.Dr["downUniID"].ToString();
                    objprp.isActive = ADOprpDL.Dr["isActive"].ToString();
                }
            }
            ADO.ReaderClose(ADOprpDL);
            return objprp;
        }
        public string DelFile(PRPSetup obj)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@linkID",obj.id);
            ADOprp.SPName = "delFileDetail";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
//--End Link File upload.

//--Start Text Editor.
        public string InsText(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[6];
            ADOprp.ArrayPram[0] = new SqlParameter("@textUniID", objprp.uniID);
            ADOprp.ArrayPram[1] = new SqlParameter("@textCatID", objprp.catID);
            ADOprp.ArrayPram[2] = new SqlParameter("@textTitle", objprp.title);
            ADOprp.ArrayPram[3] = new SqlParameter("@textDescription", objprp.description);
            ADOprp.ArrayPram[4] = new SqlParameter("@textImageUrl", objprp.urlPath);
            ADOprp.ArrayPram[5] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.SPName = "insText";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string UpdText(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[7];
            ADOprp.ArrayPram[0] = new SqlParameter("@textID", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@textCatID", objprp.catID);
            ADOprp.ArrayPram[2] = new SqlParameter("@textUniID", objprp.uniID);
            ADOprp.ArrayPram[3] = new SqlParameter("@textTitle", objprp.title);
            ADOprp.ArrayPram[4] = new SqlParameter("@textDescription", objprp.description);
            ADOprp.ArrayPram[5] = new SqlParameter("@textImageUrl", objprp.urlPath);
            ADOprp.ArrayPram[6] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.SPName = "updText";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string DelText(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@textID", objprp.id);
            ADOprp.SPName = "delText";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public PRPSetup SelText(PRPSetup objprp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@textID", objprp.id);
            ADOprpDL.SPName = "selText";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup obj = new PRPSetup(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj = new PRPSetup();
                    obj.id = ADOprpDL.Dr["textID"].ToString();
                    obj.title = ADOprpDL.Dr["textTitle"].ToString();
                    obj.urlPath = ADOprpDL.Dr["ImagePath"].ToString();
                    obj.description = ADOprpDL.Dr["textDescription"].ToString();
                    obj.catID = ADOprpDL.Dr["textCatID"].ToString();
                    obj.uniID = ADOprpDL.Dr["textUniID"].ToString();
                    obj.isActive = ADOprpDL.Dr["isActive"].ToString();
                }
            }
            ADO.ReaderClose(ADOprpDL);
            return obj;
        }
        public PRPSetup SelText1(PRPSetup objprp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@uniId", objprp.uniID);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@catId", objprp.catID);
            ADOprpDL.SPName = "selText1";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup obj = new PRPSetup(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj = new PRPSetup();
                    obj.id = ADOprpDL.Dr["textID"].ToString();
                    obj.title = ADOprpDL.Dr["textTitle"].ToString();
                    obj.urlPath = ADOprpDL.Dr["ImagePath"].ToString();
                    obj.description = ADOprpDL.Dr["textDescription"].ToString();
                    obj.catID = ADOprpDL.Dr["textCatID"].ToString();
                    obj.uniID = ADOprpDL.Dr["textUniID"].ToString();
                    obj.isActive = ADOprpDL.Dr["isActive"].ToString();
                }
            }
            ADO.ReaderClose(ADOprpDL);
            return obj;
        }
        public List<PRPSetup> ViewText(PRPSetup prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.SPName = "viewText";
            ADO.ReaderWithProceduresandParam(ADOprpDL);
            PRPSetup objprp;
            List<PRPSetup> lst = new List<PRPSetup>();
            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetup();
                    objprp.id = ADOprpDL.Dr["textID"].ToString();
                    objprp.title = ADOprpDL.Dr["textTitle"].ToString();
                    objprp.urlPath = ADOprpDL.Dr["ImagePath"].ToString();
                    objprp.description = ADOprpDL.Dr["textDescription"].ToString();
                    objprp.uniID = ADOprpDL.Dr["uniName"].ToString();
                    objprp.catID = ADOprpDL.Dr["txtCatName"].ToString();
                    objprp.isActive = ADOprpDL.Dr["isActive"].ToString();
                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetup();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPSetup();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
//--End Text Editor.

//--Start Text Editor.
        public string InsTextWeb(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[6];
            ADOprp.ArrayPram[0] = new SqlParameter("@textUniID", objprp.uniID);
            ADOprp.ArrayPram[1] = new SqlParameter("@textCatID", objprp.catID);
            ADOprp.ArrayPram[2] = new SqlParameter("@textTitle", objprp.title);
            ADOprp.ArrayPram[3] = new SqlParameter("@textDescription", objprp.description);
            ADOprp.ArrayPram[4] = new SqlParameter("@textImageUrl", objprp.urlPath);
            ADOprp.ArrayPram[5] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.SPName = "insTextWeb";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string UpdTextWeb(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[7];
            ADOprp.ArrayPram[0] = new SqlParameter("@textID", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@textCatID", objprp.catID);
            ADOprp.ArrayPram[2] = new SqlParameter("@textUniID", objprp.uniID);
            ADOprp.ArrayPram[3] = new SqlParameter("@textTitle", objprp.title);
            ADOprp.ArrayPram[4] = new SqlParameter("@textDescription", objprp.description);
            ADOprp.ArrayPram[5] = new SqlParameter("@textImageUrl", objprp.urlPath);
            ADOprp.ArrayPram[6] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.SPName = "updTextWeb";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string DelTextWeb(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@textID", objprp.id);
            ADOprp.SPName = "delTextWeb";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public PRPSetup SelTextWeb(PRPSetup objprp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@textID", objprp.id);
            ADOprpDL.SPName = "selTextWeb";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup obj = new PRPSetup(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj = new PRPSetup();
                    obj.id = ADOprpDL.Dr["textID"].ToString();
                    obj.title = ADOprpDL.Dr["textTitle"].ToString();
                    obj.urlPath = ADOprpDL.Dr["ImagePath"].ToString();
                    obj.description = ADOprpDL.Dr["textDescription"].ToString();
                    obj.catID = ADOprpDL.Dr["textCatID"].ToString();
                    obj.uniID = ADOprpDL.Dr["textUniID"].ToString();
                    obj.isActive = ADOprpDL.Dr["isActive"].ToString();
                }
            }
            ADO.ReaderClose(ADOprpDL);
            return obj;
        }
        public PRPSetup SelTextWeb1(PRPSetup objprp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@uniId", objprp.uniID);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@catId", objprp.catID);
            ADOprpDL.SPName = "selTextWeb1";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup obj = new PRPSetup(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj = new PRPSetup();
                    obj.id = ADOprpDL.Dr["textID"].ToString();
                    obj.title = ADOprpDL.Dr["textTitle"].ToString();
                    obj.urlPath = ADOprpDL.Dr["ImagePath"].ToString();
                    obj.description = ADOprpDL.Dr["textDescription"].ToString();
                    obj.catID = ADOprpDL.Dr["textCatID"].ToString();
                    obj.uniID = ADOprpDL.Dr["textUniID"].ToString();
                    obj.isActive = ADOprpDL.Dr["isActive"].ToString();
                }
            }
            ADO.ReaderClose(ADOprpDL);
            return obj;
        }
        public List<PRPSetup> ViewTextWeb(PRPSetup prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.SPName = "viewTextWeb";
            ADO.ReaderWithProceduresandParam(ADOprpDL);
            PRPSetup objprp;
            List<PRPSetup> lst = new List<PRPSetup>();
            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetup();
                    objprp.id = ADOprpDL.Dr["textID"].ToString();
                    objprp.title = ADOprpDL.Dr["textTitle"].ToString();
                    objprp.urlPath = ADOprpDL.Dr["ImagePath"].ToString();
                    objprp.description = ADOprpDL.Dr["textDescription"].ToString();
                    objprp.uniID = ADOprpDL.Dr["uniName"].ToString();
                    objprp.catID = ADOprpDL.Dr["txtCatName"].ToString();
                    objprp.isActive = ADOprpDL.Dr["isActive"].ToString();
                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetup();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPSetup();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
        public List<PRPSetup> ViewTextWeb1(PRPSetup prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@uniId", prp.uniID);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@catId", prp.catID);
            ADOprpDL.SPName = "selTextWeb1";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            List<PRPSetup> lst = new List<PRPSetup>();
            PRPSetup obj = new PRPSetup(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj = new PRPSetup();
                    obj.id = ADOprpDL.Dr["textID"].ToString();
                    obj.title = ADOprpDL.Dr["textTitle"].ToString();
                    obj.urlPath = ADOprpDL.Dr["ImagePath"].ToString();
                    obj.description = ADOprpDL.Dr["textDescription"].ToString();
                    obj.catID = ADOprpDL.Dr["textCatID"].ToString();
                    obj.uniID = ADOprpDL.Dr["textUniID"].ToString();
                    obj.isActive = ADOprpDL.Dr["isActive"].ToString();
                    lst.Add(obj);
                }
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
//--End Text Editor.
 //--Start Text Category.
        public string InsTextCategory(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[3];
            ADOprp.ArrayPram[0] = new SqlParameter("@catName", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@uniID", objprp.uniID);
            ADOprp.ArrayPram[2] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.SPName = "insTextCategory";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string UpdTextCategory(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[4];

            ADOprp.ArrayPram[0] = new SqlParameter("@catID", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@catName", objprp.name);
            ADOprp.ArrayPram[2] = new SqlParameter("@uniID", objprp.uniID);
            ADOprp.ArrayPram[3] = new SqlParameter("@isActive", objprp.isActive);

            ADOprp.SPName = "updTextCategory";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }
        public string DelTextCategory(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@catID", objprp.id);
            ADOprp.SPName = "delTextCategory";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);



        }
        public PRPSetup SelTextCategory(PRPSetup objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@catID", objprp.id);
            ADOprpDL.SPName = "selTextCategory";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup obj = new PRPSetup(); ;

            if (ADOprpDL.Dr.HasRows)
            {

                while (ADOprpDL.Dr.Read())
                {
                    obj.id = ADOprpDL.Dr["txtcatID"].ToString();
                    obj.name = ADOprpDL.Dr["txtcatName"].ToString();
                    obj.isActive = ADOprpDL.Dr["isActive"].ToString();
                }
            }
            ADO.ReaderClose(ADOprpDL);
            return obj;
        }
        public DataTable ViewTextCategory(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];

            ADOprp.ArrayPram[0] = new SqlParameter("@status", objprp.status);

            ADOprp.SPName = "ViewTextCategory";
            return ADO.DataTableWithProcedures(ADOprp);
        }
//--End Text Category.

//--Start Text Category.
        public string InsTextCategoryWeb(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[3];
            ADOprp.ArrayPram[0] = new SqlParameter("@catName", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@uniID", objprp.uniID);
            ADOprp.ArrayPram[2] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.SPName = "insTextCategoryWeb";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string UpdTextCategoryWeb(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[4];

            ADOprp.ArrayPram[0] = new SqlParameter("@catID", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@catName", objprp.name);
            ADOprp.ArrayPram[2] = new SqlParameter("@uniID", objprp.uniID);
            ADOprp.ArrayPram[3] = new SqlParameter("@isActive", objprp.isActive);

            ADOprp.SPName = "updTextCategoryWeb";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }
        public string DelTextCategoryWeb(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@catID", objprp.id);
            ADOprp.SPName = "delTextCategoryWeb";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);



        }
        public PRPSetup SelTextCategoryWeb(PRPSetup objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@catID", objprp.id);
            ADOprpDL.SPName = "selTextCategoryWeb";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup obj = new PRPSetup(); ;

            if (ADOprpDL.Dr.HasRows)
            {

                while (ADOprpDL.Dr.Read())
                {
                    obj.id = ADOprpDL.Dr["txtcatID"].ToString();
                    obj.name = ADOprpDL.Dr["txtcatName"].ToString();
                    obj.isActive = ADOprpDL.Dr["isActive"].ToString();
                }
            }
            ADO.ReaderClose(ADOprpDL);
            return obj;
        }
        public DataTable ViewTextCategoryWeb(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];

            ADOprp.ArrayPram[0] = new SqlParameter("@id", objprp.status);

            ADOprp.SPName = "ViewTextCategoryWeb";
            return ADO.DataTableWithProceduresAndParam(ADOprp);
        }
//--End Text Category.

//--Start Local Text Editor.
        public string UpdLocalText(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[4];
            ADOprp.ArrayPram[0] = new SqlParameter("@textID", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@textTitle", objprp.title);
            ADOprp.ArrayPram[2] = new SqlParameter("@textDescription", objprp.description);
            ADOprp.ArrayPram[3] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.SPName = "updLocalText";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public PRPSetup SelLocalText(PRPSetup objprp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@textID", objprp.id);
            ADOprpDL.SPName = "selLocalText";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup obj = new PRPSetup(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj = new PRPSetup();
                    obj.id = ADOprpDL.Dr["textID"].ToString();
                    obj.title = ADOprpDL.Dr["textTitle"].ToString();
                    obj.description = ADOprpDL.Dr["textDescription"].ToString();
                    obj.isActive = ADOprpDL.Dr["isActive"].ToString();
                }
            }
            ADO.ReaderClose(ADOprpDL);
            return obj;
        }
//--End Local Text Editor.

//--Start Image Category.
        public string InsImageCategory(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[3];
            ADOprp.ArrayPram[0] = new SqlParameter("@catName", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@uniID", objprp.uniID);
            ADOprp.ArrayPram[2] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.SPName = "insImageCategory";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string UpdImageCategory(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[4];

            ADOprp.ArrayPram[0] = new SqlParameter("@catID", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@catName", objprp.name);
            ADOprp.ArrayPram[2] = new SqlParameter("@uniID", objprp.uniID);
            ADOprp.ArrayPram[3] = new SqlParameter("@isActive", objprp.isActive);

            ADOprp.SPName = "updImageCategory";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }
        public string DelImageCategory(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@catID", objprp.id);
            ADOprp.SPName = "delImageCategory";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);



        }
        public PRPSetup SelImageCategory(PRPSetup objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@catID", objprp.id);
            ADOprpDL.SPName = "selImageCategory";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup obj = new PRPSetup(); ;

            if (ADOprpDL.Dr.HasRows)
            {

                while (ADOprpDL.Dr.Read())
                {
                    obj.id = ADOprpDL.Dr["catID"].ToString();
                    obj.name = ADOprpDL.Dr["catName"].ToString();
                    obj.isActive = ADOprpDL.Dr["isActive"].ToString();
                }
            }
            ADO.ReaderClose(ADOprpDL);
            return obj;
        }
        public DataTable ViewImageCategory(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];

            ADOprp.ArrayPram[0] = new SqlParameter("@status", objprp.status);

            ADOprp.SPName = "ViewImageCategory";
            return ADO.DataTableWithProcedures(ADOprp);
        }    
//--End Image Category.
        public string InsImageGallery(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[7];
            ADOprp.ArrayPram[0] = new SqlParameter("@imageTitle", objprp.title);
            ADOprp.ArrayPram[1] = new SqlParameter("@description", objprp.description);
            ADOprp.ArrayPram[2] = new SqlParameter("@urlName", objprp.urlName);
            ADOprp.ArrayPram[3] = new SqlParameter("@uniID", objprp.uniID);
            ADOprp.ArrayPram[4] = new SqlParameter("@catID", objprp.catID);
            ADOprp.ArrayPram[5] = new SqlParameter("@urlPath", objprp.urlPath);
            ADOprp.ArrayPram[6] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.SPName = "insImageGallery";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string UpdImageGallery(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[8];
            ADOprp.ArrayPram[0] = new SqlParameter("@imageId", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@imageTitle", objprp.title);
            ADOprp.ArrayPram[2] = new SqlParameter("@description", objprp.description);
            ADOprp.ArrayPram[3] = new SqlParameter("@urlName", objprp.urlName);
            ADOprp.ArrayPram[4] = new SqlParameter("@uniID", objprp.uniID);
            ADOprp.ArrayPram[5] = new SqlParameter("@catID", objprp.catID);
            ADOprp.ArrayPram[6] = new SqlParameter("@urlPath", objprp.urlPath);
            ADOprp.ArrayPram[7] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.SPName = "updImageGallery";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string DelImageGallery(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@imageId", objprp.id);            
            ADOprp.SPName = "delImageGallery";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public PRPSetup SelImageGallery(PRPSetup objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@imageID", objprp.id);
            ADOprpDL.SPName = "selImageGallery";
            ADO.ReaderWithProceduresandParam(ADOprpDL);
            PRPSetup obj = new PRPSetup(); ;
            if (ADOprpDL.Dr.HasRows)
            {//imageId,imageTitle,imagePath,imageSubTitle,imageDescription,uniID,catID,isActive


                while (ADOprpDL.Dr.Read())
                {
                    obj.title=ADOprpDL.Dr["imageTitle"].ToString();
                    obj.id=ADOprpDL.Dr["imageId"].ToString();
                    obj.urlPath=ADOprpDL.Dr["imagePath"].ToString();
                    obj.urlName=ADOprpDL.Dr["imageSubTitle"].ToString();
                    obj.description=ADOprpDL.Dr["imageDescription"].ToString();
                    obj.uniID=ADOprpDL.Dr["uniID"].ToString();
                    obj.catID=ADOprpDL.Dr["catID"].ToString();
                    obj.isActive=ADOprpDL.Dr["isActive"].ToString();                    
                }
            }
            ADO.ReaderClose(ADOprpDL);
            return obj;
        }
       public List<PRPSetup> ViewImageGallery(PRPSetup obj)
        {
            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@uniID", obj.uniID);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@catID", obj.catID);
            ADOprpDL.SPName = "viewImageGallery";
            ADO.ReaderWithProceduresandParam(ADOprpDL);
            PRPSetup objprp;
            List<PRPSetup> lst = new List<PRPSetup>();
            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetup();
                    objprp.id = ADOprpDL.Dr["imageID"].ToString();
                    objprp.title = ADOprpDL.Dr["imageTitle"].ToString();
                    objprp.urlPath = ADOprpDL.Dr["imagePath"].ToString();
                    objprp.isActive = ADOprpDL.Dr["isActive"].ToString();
                    objprp.description = ADOprpDL.Dr["imageSubTitle"].ToString();
                    lst.Add(objprp);
                }                
            }
            else
            {
                objprp = new PRPSetup();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
       
//--Start EducationType
       public string InsEducationType(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[2];
           ADOprp.ArrayPram[0] = new SqlParameter("@typeName", objprp.name);
           ADOprp.ArrayPram[1] = new SqlParameter("@isActive", objprp.isActive);
           ADOprp.SPName = "insEducationType";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string UpdEducationType(PRPSetup objprp)  
       {
           ADOprp.ArrayPram = new SqlParameter[3];

           ADOprp.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
           ADOprp.ArrayPram[1] = new SqlParameter("@typeName", objprp.name);
           ADOprp.ArrayPram[2] = new SqlParameter("@isActive", objprp.isActive);

           ADOprp.SPName = "updEducationType";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);


       }
       public string DelEducationType(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
           ADOprp.SPName = "delEducationType";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public PRPSetup SelEducationType(PRPSetup objprp)
       {

           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
           ADOprpDL.SPName = "selEducationType";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetup obj = new PRPSetup(); ;

           if (ADOprpDL.Dr.HasRows)
           {

               while (ADOprpDL.Dr.Read())
               {
                   obj.id = ADOprpDL.Dr["eduID"].ToString();
                   obj.name = ADOprpDL.Dr["eduName"].ToString();
                   obj.isActive = ADOprpDL.Dr["isActive"].ToString();
               }
           }
           ADO.ReaderClose(ADOprpDL);
           return obj;
       }
       //--End Education Type

       #region School Category Insert Update Delete

       public string InsSchoolCategory(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[2];
           ADOprp.ArrayPram[0] = new SqlParameter("@typeName", objprp.name);
           ADOprp.ArrayPram[1] = new SqlParameter("@isActive", objprp.isActive);
           ADOprp.SPName = "spInsSchoolCategory";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }


       public string UpdSchoolCategory(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[3];

           ADOprp.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
           ADOprp.ArrayPram[1] = new SqlParameter("@typeName", objprp.name);
           ADOprp.ArrayPram[2] = new SqlParameter("@isActive", objprp.isActive);

           ADOprp.SPName = "updateSchoolCategory";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);


       }


       public PRPSetup SelSchoolCategory(PRPSetup objprp)
       {

           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
           ADOprpDL.SPName = "selSchoolType";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetup obj = new PRPSetup(); ;

           if (ADOprpDL.Dr.HasRows)
           {

               while (ADOprpDL.Dr.Read())
               {
                   obj.id = ADOprpDL.Dr["ID"].ToString();
                   obj.name = ADOprpDL.Dr["Name"].ToString(); 
                   obj.isActive = ADOprpDL.Dr["Status"].ToString();


               }
           }
           ADO.ReaderClose(ADOprpDL);
           return obj;
       }

       public string DelSchoolCategory(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
           ADOprp.SPName = "spDelSchoolCategory";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }

       #endregion

       #region School Sub Category Insert Update Delete
       public string UpdSchoolSubCat(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[4];
           ADOprp.ArrayPram[0] = new SqlParameter("@ID ", objprp.id);
           ADOprp.ArrayPram[1] = new SqlParameter("@TypeName", objprp.name);
           ADOprp.ArrayPram[2] = new SqlParameter("@TypeCategory", objprp.uniID);
           ADOprp.ArrayPram[3] = new SqlParameter("@isActive", objprp.isActive);
           ADOprp.SPName = "updSchoolSubCategory";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);


       }

       public PRPSetup SelSchoolSubCat(PRPSetup objprp)
       {

           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@Id", objprp.id);
           ADOprpDL.SPName = "SelectSchoolSubCategory";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetup obj = new PRPSetup(); ;

           if (ADOprpDL.Dr.HasRows)
           {

               while (ADOprpDL.Dr.Read())
               {
                   obj.id = ADOprpDL.Dr["ID"].ToString();
                   obj.name = ADOprpDL.Dr["TypeName"].ToString();
                   obj.uniID = ADOprpDL.Dr["TypeCategory"].ToString();
                   obj.isActive = ADOprpDL.Dr["Status"].ToString();
               }
           }
           ADO.ReaderClose(ADOprpDL);
           return obj;
       }
       public string DelSchoolSubCat(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@Id", objprp.id);
           ADOprp.SPName = "delSchoolSubCategory";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }



       #endregion
       //--Start UniversityType
       public string InsUniversityType(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[5];
           ADOprp.ArrayPram[0] = new SqlParameter("@typeName", objprp.name);
           ADOprp.ArrayPram[1] = new SqlParameter("@isActive", objprp.isActive);
           ADOprp.ArrayPram[2] = new SqlParameter("@SubTitle", objprp.title);
           ADOprp.ArrayPram[3] = new SqlParameter("@UniversityDescription", objprp.description);
           ADOprp.ArrayPram[4] = new SqlParameter("@UniversityImage", objprp.urlPath);
           ADOprp.SPName = "insUniversityType";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string UpdUniversityType(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[3];

           ADOprp.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
           ADOprp.ArrayPram[1] = new SqlParameter("@typeName", objprp.name);
           ADOprp.ArrayPram[2] = new SqlParameter("@isActive", objprp.isActive);

           ADOprp.SPName = "updUniversityType";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);


       }
       public string DelUniversityType(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
           ADOprp.SPName = "delUniversityType";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public PRPSetup SelUniversityType(PRPSetup objprp)
       {

           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
           ADOprpDL.SPName = "selUniversityType";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetup obj = new PRPSetup(); ;

           if (ADOprpDL.Dr.HasRows)
           {

               while (ADOprpDL.Dr.Read())
               {
                   obj.id = ADOprpDL.Dr["typeID"].ToString();
                   obj.name = ADOprpDL.Dr["typeName"].ToString();
                   obj.isActive = ADOprpDL.Dr["isActive"].ToString();
               }
           }
           ADO.ReaderClose(ADOprpDL);
           return obj;
       }               
//--End University Type

//--Start College Type
       public string InsCollegeType(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[2];
           ADOprp.ArrayPram[0] = new SqlParameter("@typeName", objprp.name);
           ADOprp.ArrayPram[1] = new SqlParameter("@isActive", objprp.isActive);
           ADOprp.SPName = "insCollegeType";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string UpdCollegeType(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[3];

           ADOprp.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
           ADOprp.ArrayPram[1] = new SqlParameter("@typeName", objprp.name);
           ADOprp.ArrayPram[2] = new SqlParameter("@isActive", objprp.isActive);

           ADOprp.SPName = "updCollegeType";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);


       }
       public string DelCollegeType(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
           ADOprp.SPName = "delCollegeType";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public PRPSetup SelCollegeType(PRPSetup objprp)
       {

           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
           ADOprpDL.SPName = "selCollegeType";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetup obj = new PRPSetup(); ;

           if (ADOprpDL.Dr.HasRows)
           {

               while (ADOprpDL.Dr.Read())
               {
                   obj.id = ADOprpDL.Dr["typeID"].ToString();
                   obj.name = ADOprpDL.Dr["typeName"].ToString();
                   obj.isActive = ADOprpDL.Dr["isActive"].ToString();
               }
           }
           ADO.ReaderClose(ADOprpDL);
           return obj;
       }
//--End College Type

//--Start Course Type
       public string InsCourseType(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[2];
           ADOprp.ArrayPram[0] = new SqlParameter("@typeName", objprp.name);
           ADOprp.ArrayPram[1] = new SqlParameter("@isActive", objprp.isActive);          
           ADOprp.SPName = "insCourseType";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string UpdCourseType(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[3];

           ADOprp.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
           ADOprp.ArrayPram[1] = new SqlParameter("@typeName", objprp.name);
           ADOprp.ArrayPram[2] = new SqlParameter("@isActive", objprp.isActive);

           ADOprp.SPName = "updCourseType";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);


       }
       public string DelCourseType(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
           ADOprp.SPName = "delCourseType";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public PRPSetup SelCourseType(PRPSetup objprp)
       {

           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
           ADOprpDL.SPName = "selCourseType";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetup obj = new PRPSetup(); ;

           if (ADOprpDL.Dr.HasRows)
           {

               while (ADOprpDL.Dr.Read())
               {
                   obj.id = ADOprpDL.Dr["typeID"].ToString();
                   obj.name = ADOprpDL.Dr["typeName"].ToString();
                   obj.isActive = ADOprpDL.Dr["isActive"].ToString();
               }
           }
           ADO.ReaderClose(ADOprpDL);
           return obj;
       }
//--End Course Type

   //--Start Country.
       public string InsCountry(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@cntName", objprp.name);
           ADOprp.SPName = "insCountry";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string UpdCountry(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[2];

           ADOprp.ArrayPram[0] = new SqlParameter("@cntID", objprp.id);
           ADOprp.ArrayPram[1] = new SqlParameter("@cntName", objprp.name);

           ADOprp.SPName = "updCountry";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);


       }
       public string DelCountry(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@cntID", objprp.id);
           ADOprp.SPName = "delCountry";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public PRPSetup SelCountry(PRPSetup objprp)
       {

           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@cntID", objprp.id);
           ADOprpDL.SPName = "selCountry";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetup obj = new PRPSetup(); ;

           if (ADOprpDL.Dr.HasRows)
           {

               while (ADOprpDL.Dr.Read())
               {
                   obj.id = ADOprpDL.Dr["cntID"].ToString();
                   obj.name = ADOprpDL.Dr["cntName"].ToString();
               }
           }
           ADO.ReaderClose(ADOprpDL);
           return obj;
       }
       //--End Country.

//--Start State.
       public string InsState(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[2];
           ADOprp.ArrayPram[0] = new SqlParameter("@stateName", objprp.name);
           ADOprp.ArrayPram[1] = new SqlParameter("@cnt", objprp.uniID);
           ADOprp.SPName = "insState";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string UpdState(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[3];           
           ADOprp.ArrayPram[0] = new SqlParameter("@stateID", objprp.id);
           ADOprp.ArrayPram[1] = new SqlParameter("@stateName", objprp.name);
           ADOprp.ArrayPram[2] = new SqlParameter("@cntId", objprp.uniID);
           ADOprp.SPName = "updState";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);


       }
       public string DelState(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@stateID", objprp.id);
           ADOprp.SPName = "delState";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);           
       }
       public PRPSetup SelState(PRPSetup objprp)
       {

           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@stateID", objprp.id);
           ADOprpDL.SPName = "selState";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetup obj = new PRPSetup(); ;

           if (ADOprpDL.Dr.HasRows)
           {

               while (ADOprpDL.Dr.Read())
               {
                   obj.id = ADOprpDL.Dr["stateID"].ToString();
                   obj.name = ADOprpDL.Dr["stateName"].ToString();
                   obj.uniID = ADOprpDL.Dr["cntId"].ToString();
               }
           }
           ADO.ReaderClose(ADOprpDL);
           return obj;
       }               
//--End State

//--Start District.
       public string InsDistrict(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[2];
           ADOprp.ArrayPram[0] = new SqlParameter("@distName", objprp.name);
           ADOprp.ArrayPram[1] = new SqlParameter("@stateID", objprp.uniID);
           ADOprp.SPName = "insDistrict";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string UpdDistrict(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[3];

           ADOprp.ArrayPram[0] = new SqlParameter("@distId", objprp.id);
           ADOprp.ArrayPram[1] = new SqlParameter("@distName", objprp.name);
           ADOprp.ArrayPram[2] = new SqlParameter("@stateId", objprp.uniID);
           ADOprp.SPName = "updDistrict";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string DelDistrict(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@distId", objprp.id);
           ADOprp.SPName = "delDistrict";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public PRPSetup SelDistrict(PRPSetup objprp)
       {

           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@distId", objprp.id);
           ADOprpDL.SPName = "selDistrict";

           ADO.ReaderWithProceduresandParam(ADOprpDL);

           PRPSetup obj = new PRPSetup(); ;

           if (ADOprpDL.Dr.HasRows)
           {

               while (ADOprpDL.Dr.Read())
               {
                   obj.id = ADOprpDL.Dr["distId"].ToString();
                   obj.name = ADOprpDL.Dr["distName"].ToString();
                   obj.uniID = ADOprpDL.Dr["statId"].ToString();
               }
           }
           ADO.ReaderClose(ADOprpDL);
           return obj;
       }
//--End District.  
//--Start City.
       public string InsCity(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[2];
           ADOprp.ArrayPram[0] = new SqlParameter("@cityName", objprp.name);
           ADOprp.ArrayPram[1] = new SqlParameter("@distID", objprp.uniID);
           ADOprp.SPName = "insCity";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string UpdCity(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[3];

           ADOprp.ArrayPram[0] = new SqlParameter("@cityID", objprp.id);
           ADOprp.ArrayPram[1] = new SqlParameter("@cityName", objprp.name);
           ADOprp.ArrayPram[2] = new SqlParameter("@distID", objprp.uniID);
           ADOprp.SPName = "updCity";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string DelCity(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@cityID", objprp.id);
           ADOprp.SPName = "delCity";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public PRPSetup SelCity(PRPSetup objprp)
       {

           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@cityID", objprp.id);
           ADOprpDL.SPName = "selCity";

           ADO.ReaderWithProceduresandParam(ADOprpDL);

           PRPSetup obj = new PRPSetup(); ;

           if (ADOprpDL.Dr.HasRows)
           {

               while (ADOprpDL.Dr.Read())
               {
                   obj.id = ADOprpDL.Dr["cityId"].ToString();
                   obj.name = ADOprpDL.Dr["cityName"].ToString();
                   obj.uniID = ADOprpDL.Dr["cityDistrictID"].ToString();
               }
           }
           ADO.ReaderClose(ADOprpDL);
           return obj;
       }       
//--End City.

//--Start Branch Locator
       public string InsBranchLocator(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[4];
           ADOprp.ArrayPram[0] = new SqlParameter("@branchName", objprp.title);
           ADOprp.ArrayPram[1] = new SqlParameter("@branchDescription", objprp.description);
           ADOprp.ArrayPram[2] = new SqlParameter("@cityId", objprp.uniID);
           ADOprp.ArrayPram[3] = new SqlParameter("@isActive", objprp.isActive);
           ADOprp.SPName = "insBranchLocator";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string UpdBranchLocator(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[5];
           ADOprp.ArrayPram[0] = new SqlParameter("@branchId", objprp.id);
           ADOprp.ArrayPram[1] = new SqlParameter("@branchName", objprp.title);
           ADOprp.ArrayPram[2] = new SqlParameter("@branchDescription", objprp.description);
           ADOprp.ArrayPram[3] = new SqlParameter("@cityId", objprp.uniID);
           ADOprp.ArrayPram[4] = new SqlParameter("@isActive", objprp.isActive);
           ADOprp.SPName = "updBranchLocator";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string DelBranchLocator(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@branchId", objprp.id);
           ADOprp.SPName = "delBranchLocator";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public PRPSetup SelBranchLocator(PRPSetup objprp)
       {
           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@branchId", objprp.id);
           ADOprpDL.SPName = "selBranchLocator";
           ADO.ReaderWithProceduresandParam(ADOprpDL);

           PRPSetup obj = new PRPSetup(); ;

           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   obj = new PRPSetup();
                   obj.id = ADOprpDL.Dr["branchId"].ToString();
                   obj.title = ADOprpDL.Dr["branchName"].ToString();
                   obj.description = ADOprpDL.Dr["branchDescription"].ToString();
                   obj.city = ADOprpDL.Dr["branchCityId"].ToString();
                   obj.catID = ADOprpDL.Dr["distId"].ToString();
                   obj.uniID = ADOprpDL.Dr["stateId"].ToString();
                   obj.isActive = ADOprpDL.Dr["isActive"].ToString();
               }
           }
           ADO.ReaderClose(ADOprpDL);
           return obj;
       }
       public List<PRPSetup> ViewBranchLocator(PRPSetup prp)
       {
           ADOprpDL.ArrayPram = new SqlParameter[2];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
           ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
           ADOprpDL.SPName = "viewBranchLocator";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetup objprp;
           List<PRPSetup> lst = new List<PRPSetup>();
           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   objprp = new PRPSetup();
                   objprp.id = ADOprpDL.Dr["branchId"].ToString();
                   objprp.title = ADOprpDL.Dr["branchName"].ToString();
                   objprp.description = ADOprpDL.Dr["branchDescription"].ToString();
                   objprp.city = ADOprpDL.Dr["branchCityId"].ToString();
                   objprp.catID = ADOprpDL.Dr["distName"].ToString();
                   objprp.uniID = ADOprpDL.Dr["stateName"].ToString();
                   objprp.isActive = ADOprpDL.Dr["isActive"].ToString();
                   lst.Add(objprp);
               }
               if (ADOprpDL.Dr.NextResult())
               {

                   ADOprpDL.Dr.Read();
                   objprp = new PRPSetup();
                   objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                   lst.Add(objprp);
               }


           }
           else
           {
               objprp = new PRPSetup();
               objprp.srNo = "Result Not Find";
               lst.Add(objprp);
           }
           ADO.ReaderClose(ADOprpDL);
           return lst;

       }
       public List<PRPSetup> ViewBranchLocator1(PRPSetup prp)
       {
           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@cityId", prp.id);           
           ADOprpDL.SPName = "viewBranchLocator1";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetup objprp;
           List<PRPSetup> lst = new List<PRPSetup>();
           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   objprp = new PRPSetup();
                   objprp.id = ADOprpDL.Dr["branchId"].ToString();
                   objprp.title = ADOprpDL.Dr["branchName"].ToString();
                   objprp.description = ADOprpDL.Dr["branchDescription"].ToString();
                   lst.Add(objprp);
               }              

           }
           else
           {
               objprp = new PRPSetup();
               objprp.srNo = "Result Not Find";
               lst.Add(objprp);
           }
           ADO.ReaderClose(ADOprpDL);
           return lst;
       }
//--End Branch Locator

//--Start Course Text Editor.
       public string InsCourseText(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[6];
           ADOprp.ArrayPram[0] = new SqlParameter("@textUniID", objprp.uniID);
           ADOprp.ArrayPram[1] = new SqlParameter("@textCatID", objprp.catID);
           ADOprp.ArrayPram[2] = new SqlParameter("@textTitle", objprp.title);
           ADOprp.ArrayPram[3] = new SqlParameter("@textDescription", objprp.description);
           ADOprp.ArrayPram[4] = new SqlParameter("@textImageUrl", objprp.urlPath);
           ADOprp.ArrayPram[5] = new SqlParameter("@isActive", objprp.isActive);
           ADOprp.SPName = "insCourseText";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string UpdCourseText(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[7];
           ADOprp.ArrayPram[0] = new SqlParameter("@textID", objprp.id);
           ADOprp.ArrayPram[1] = new SqlParameter("@textCatID", objprp.catID);
           ADOprp.ArrayPram[2] = new SqlParameter("@textUniID", objprp.uniID);
           ADOprp.ArrayPram[3] = new SqlParameter("@textTitle", objprp.title);
           ADOprp.ArrayPram[4] = new SqlParameter("@textDescription", objprp.description);
           ADOprp.ArrayPram[5] = new SqlParameter("@textImageUrl", objprp.urlPath);
           ADOprp.ArrayPram[6] = new SqlParameter("@isActive", objprp.isActive);
           ADOprp.SPName = "updCourseText";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string DelCourseText(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@textID", objprp.id);
           ADOprp.SPName = "delCourseText";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public PRPSetup SelCourseText(PRPSetup objprp)
       {
           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@textID", objprp.id);
           ADOprpDL.SPName = "selCourseText";
           ADO.ReaderWithProceduresandParam(ADOprpDL);

           PRPSetup obj = new PRPSetup(); ;

           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   obj = new PRPSetup();
                   obj.id = ADOprpDL.Dr["textID"].ToString();
                   obj.title = ADOprpDL.Dr["textTitle"].ToString();
                   obj.urlPath = ADOprpDL.Dr["ImagePath"].ToString();
                   obj.description = ADOprpDL.Dr["textDescription"].ToString();
                   obj.catID = ADOprpDL.Dr["textCatID"].ToString();
                   obj.uniID = ADOprpDL.Dr["textUniID"].ToString();
                   obj.isActive = ADOprpDL.Dr["isActive"].ToString();
               }
           }
           ADO.ReaderClose(ADOprpDL);
           return obj;
       }
       public PRPSetup SelCourseText1(PRPSetup objprp)
       {
           ADOprpDL.ArrayPram = new SqlParameter[2];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@uniId", objprp.uniID);
           ADOprpDL.ArrayPram[1] = new SqlParameter("@catId", objprp.catID);
           ADOprpDL.SPName = "selCourseText1";
           ADO.ReaderWithProceduresandParam(ADOprpDL);

           PRPSetup obj = new PRPSetup(); ;

           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   obj = new PRPSetup();
                   obj.id = ADOprpDL.Dr["textID"].ToString();
                   obj.title = ADOprpDL.Dr["textTitle"].ToString();
                   obj.urlPath = ADOprpDL.Dr["ImagePath"].ToString();
                   obj.description = ADOprpDL.Dr["textDescription"].ToString();
                   obj.catID = ADOprpDL.Dr["textCatID"].ToString();
                   obj.uniID = ADOprpDL.Dr["textUniID"].ToString();
                   obj.isActive = ADOprpDL.Dr["isActive"].ToString();
               }
           }
           ADO.ReaderClose(ADOprpDL);
           return obj;
       }
       public List<PRPSetup> ViewCourseText(PRPSetup prp)
       {
           ADOprpDL.ArrayPram = new SqlParameter[2];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
           ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
           ADOprpDL.SPName = "viewCourseText";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetup objprp;
           List<PRPSetup> lst = new List<PRPSetup>();
           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   objprp = new PRPSetup();
                   objprp.id = ADOprpDL.Dr["textID"].ToString();
                   objprp.title = ADOprpDL.Dr["textTitle"].ToString();
                   objprp.urlPath = ADOprpDL.Dr["ImagePath"].ToString();
                   objprp.description = ADOprpDL.Dr["textDescription"].ToString();
                   objprp.uniID = ADOprpDL.Dr["uniName"].ToString();
                   objprp.catID = ADOprpDL.Dr["CatName"].ToString();
                   objprp.isActive = ADOprpDL.Dr["isActive"].ToString();
                   lst.Add(objprp);
               }
               if (ADOprpDL.Dr.NextResult())
               {

                   ADOprpDL.Dr.Read();
                   objprp = new PRPSetup();
                   objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                   lst.Add(objprp);
               }


           }
           else
           {
               objprp = new PRPSetup();
               objprp.srNo = "Result Not Find";
               lst.Add(objprp);
           }
           ADO.ReaderClose(ADOprpDL);
           return lst;

       }
//--End Course Text Editor.
//--Start Visitor Counter.
       public string UpdVisitor(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@maxValue", objprp.courseFees);
           ADOprp.SPName = "updVisitor";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);   
       }
//--End Visitor Counter.
       public List<PRPSetup> ViewTextWeb11(PRPSetup prp)
       {
           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@uniId", prp.uniID);
           //ADOprpDL.ArrayPram[1] = new SqlParameter("@catId", prp.catID);
           ADOprpDL.SPName = "selTextWeb11";
           ADO.ReaderWithProceduresandParam(ADOprpDL);

           List<PRPSetup> lst = new List<PRPSetup>();
           PRPSetup obj = new PRPSetup(); ;

           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   obj = new PRPSetup();
                   obj.id = ADOprpDL.Dr["textID"].ToString();
                   obj.title = ADOprpDL.Dr["textTitle"].ToString();
                   obj.urlPath = ADOprpDL.Dr["ImagePath"].ToString();
                   obj.description = ADOprpDL.Dr["textDescription"].ToString();
                   obj.catID = ADOprpDL.Dr["textCatID"].ToString();
                   obj.uniID = ADOprpDL.Dr["textUniID"].ToString();
                   obj.isActive = ADOprpDL.Dr["isActive"].ToString();
                   lst.Add(obj);
               }
           }
           ADO.ReaderClose(ADOprpDL);
           return lst;

       }
       public List<PRPSetup> bindUniversityData(PRPSetup prp)
       {
           if (prp.id == "1")
           {
               ADOprpDL.ArrayPram = new SqlParameter[1];
               ADOprpDL.ArrayPram[0] = new SqlParameter("@uniTypeId", prp.uniID);
               //ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
               ADOprpDL.SPName = "VeiwUniversityState";
           }
           else
           {
               ADOprpDL.ArrayPram = new SqlParameter[0];
               ADOprpDL.SPName = "viewUniversityType";
           }
           ADO.ReaderWithProceduresandParam(ADOprpDL);

           PRPSetup objprp;
           List<PRPSetup> lst = new List<PRPSetup>();

           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   objprp = new PRPSetup();
                   objprp.id = ADOprpDL.Dr["id"].ToString();
                   objprp.name = ADOprpDL.Dr["Name"].ToString();

                   lst.Add(objprp);
               }



               ADO.ReaderClose(ADOprpDL);

           }
           return lst;
       }
       public List<PRPSetup> ViewCarrier(PRPSetup prp)
       {
           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@id", prp.catID);
           ADOprpDL.SPName = "viewNewsType";
           ADO.ReaderWithProceduresandParam(ADOprpDL);

           PRPSetup objprp;
           List<PRPSetup> lst = new List<PRPSetup>();

           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   objprp = new PRPSetup();
                   objprp.id = ADOprpDL.Dr["id"].ToString();
                   objprp.title = ADOprpDL.Dr["name"].ToString();
                   objprp.urlPath = ADOprpDL.Dr["ImagePath"].ToString();
                   objprp.fullpath = ADOprpDL.Dr["imageFullPath"].ToString();
                   lst.Add(objprp);
               }
           }
           else
           {
               objprp = new PRPSetup();
               objprp.srNo = "Result Not Find";
               lst.Add(objprp);
           }
           ADO.ReaderClose(ADOprpDL);
           return lst;

       }


       //10-30
       public string InsEducationBoard(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[9];
           ADOprp.ArrayPram[0] = new SqlParameter("@StateID", objprp.uniID);
           ADOprp.ArrayPram[1] = new SqlParameter("@EducationBoardID", objprp.catID);
           ADOprp.ArrayPram[2] = new SqlParameter("@EducationTitle", objprp.title);
           ADOprp.ArrayPram[3] = new SqlParameter("@EducationDescription", objprp.description);
           ADOprp.ArrayPram[4] = new SqlParameter("@isActive", objprp.isActive);
           ADOprp.ArrayPram[5] = new SqlParameter("@EducationDate", objprp.DOJ);
           ADOprp.ArrayPram[6] = new SqlParameter("@subTitle", objprp.status);
           ADOprp.ArrayPram[7] = new SqlParameter("@newImage", objprp.urlPath);
           ADOprp.ArrayPram[8] = new SqlParameter("@EducationType", objprp.srNo);
           ADOprp.SPName = "InsEducationBoard";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string UpdEducationBoard(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[10];

           ADOprp.ArrayPram[0] = new SqlParameter("@StateID", objprp.uniID);
           ADOprp.ArrayPram[1] = new SqlParameter("@EducationBoardID", objprp.catID);
           ADOprp.ArrayPram[2] = new SqlParameter("@EducationTitle", objprp.title);
           ADOprp.ArrayPram[3] = new SqlParameter("@EducationDescription", objprp.description);
           ADOprp.ArrayPram[4] = new SqlParameter("@isActive", objprp.isActive);
           ADOprp.ArrayPram[5] = new SqlParameter("@EducationDate", objprp.DOJ);
           ADOprp.ArrayPram[6] = new SqlParameter("@subTitle", objprp.status);
           ADOprp.ArrayPram[7] = new SqlParameter("@newImage", objprp.urlPath);
           ADOprp.ArrayPram[8] = new SqlParameter("@newsID", objprp.id);
           ADOprp.ArrayPram[9] = new SqlParameter("@EducationType", objprp.srNo);
           ADOprp.SPName = "UpdEducationBoard";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string DelEducationBoard(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@newsID", objprp.id);
           ADOprp.SPName = "delEducationBoard";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public PRPSetup SelEducationBoard(PRPSetup objprp)
       {

           ADOprpDL.ArrayPram = new SqlParameter[2];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@newsID", objprp.id);
           ADOprpDL.ArrayPram[1] = new SqlParameter("@Type", objprp.srNo);
           ADOprpDL.SPName = "selEducationBoard";

           ADO.ReaderWithProceduresandParam(ADOprpDL);

           PRPSetup obj = new PRPSetup(); ;

           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   obj = new PRPSetup();
                   obj.id = ADOprpDL.Dr["newsID"].ToString();
                   obj.title = ADOprpDL.Dr["EducationTitle"].ToString();
                   obj.description = ADOprpDL.Dr["EducationDescription"].ToString();
                   obj.catID = ADOprpDL.Dr["EducationBoardID"].ToString();
                   obj.uniID = ADOprpDL.Dr["StateID"].ToString();
                   obj.DOJ = ADOprpDL.Dr["EducationDate"].ToString();
                   obj.isActive = ADOprpDL.Dr["isActive"].ToString();
                   obj.status = ADOprpDL.Dr["subTitle"].ToString();
                   obj.urlPath = ADOprpDL.Dr["newImage"].ToString();
                   obj.srNo = ADOprpDL.Dr["EducationType"].ToString();
               }
           }
           ADO.ReaderClose(ADOprpDL);
           return obj;
       }
       public List<PRPSetup> ViewEducationBoard(PRPSetup prp)
       {
           ADOprpDL.ArrayPram = new SqlParameter[3];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
           ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
           ADOprpDL.ArrayPram[2] = new SqlParameter("@StateID", prp.uniID);

           ADOprpDL.SPName = "veiwEducationBoard";
           ADO.ReaderWithProceduresandParam(ADOprpDL);

           PRPSetup objprp;
           List<PRPSetup> lst = new List<PRPSetup>();

           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   objprp = new PRPSetup();
                   objprp.id = ADOprpDL.Dr["newsID"].ToString();
                   objprp.title = ADOprpDL.Dr["EducationTitle"].ToString();
                  // objprp.description = ADOprpDL.Dr["EducationDescription"].ToString();
                   objprp.catID = ADOprpDL.Dr["EducationBoardID"].ToString();
                   objprp.uniID = ADOprpDL.Dr["StateName"].ToString();
                   objprp.DOJ = ADOprpDL.Dr["newsDate"].ToString();
                   objprp.isActive = ADOprpDL.Dr["isActive"].ToString();
                   objprp.status = ADOprpDL.Dr["subTitle"].ToString();
                   objprp.urlPath = ADOprpDL.Dr["newImage"].ToString();
                   lst.Add(objprp);
               }
               if (ADOprpDL.Dr.NextResult())
               {

                   ADOprpDL.Dr.Read();
                   objprp = new PRPSetup();
                   objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                   lst.Add(objprp);
               }


           }
           else
           {
               objprp = new PRPSetup();
               objprp.srNo = "Result Not Find";
               lst.Add(objprp);
           }
           ADO.ReaderClose(ADOprpDL);
           return lst;

       }


 public DataSet mastercommon( )
        {
            ADOprp.SPName ="viewNewsWithPaging1AsMasterStarter";
            return ADO.DataSetWithProcedures(ADOprp);
        }        
        public DataSet Defaultcommon()
        {
            ADOprp.SPName = "spDefaultSP";
            return ADO.DataSetWithProcedures(ADOprp);

        }


        //12-2-12
        public string InsCommission(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[5];
            ADOprp.ArrayPram[0] = new SqlParameter("@PlannId", objprp.catID);
            ADOprp.ArrayPram[1] = new SqlParameter("@PartnerId", objprp.uniID);
            ADOprp.ArrayPram[2] = new SqlParameter("@CommToYear", objprp.DOJ);
            ADOprp.ArrayPram[3] = new SqlParameter("@CommAmount", objprp.title);
            ADOprp.ArrayPram[4] = new SqlParameter("@CommForYear", objprp.description);
            ADOprp.SPName = "InsCommission";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string UpdCommission(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[6];
            ADOprp.ArrayPram[0] = new SqlParameter("@PlannId", objprp.catID);
            ADOprp.ArrayPram[1] = new SqlParameter("@PartnerId", objprp.uniID);
            ADOprp.ArrayPram[2] = new SqlParameter("@CommToYear", objprp.DOJ);
            ADOprp.ArrayPram[3] = new SqlParameter("@CommAmount", objprp.title);
            ADOprp.ArrayPram[4] = new SqlParameter("@CommForYear", objprp.description);
            ADOprp.ArrayPram[5] = new SqlParameter("@CommId", objprp.id);
            ADOprp.SPName = "UpdCommission";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public List<PRPSetup> ViewCommission(PRPSetup prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            //ADOprpDL.ArrayPram[2] = new SqlParameter("@StateID", prp.uniID);

            ADOprpDL.SPName = "veiwCommission";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup objprp;
            List<PRPSetup> lst = new List<PRPSetup>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetup();
                    objprp.id = ADOprpDL.Dr["CommId"].ToString();
                    objprp.uniID = ADOprpDL.Dr["PartnerId"].ToString();
                    objprp.catID = ADOprpDL.Dr["listingName"].ToString();
                    objprp.title = ADOprpDL.Dr["CommAmount"].ToString();
                    objprp.DOJ = ADOprpDL.Dr["CommToYear"].ToString();
                    objprp.description = ADOprpDL.Dr["CommForYear"].ToString();
                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetup();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }
            }
            else
            {
                objprp = new PRPSetup();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
        public PRPSetup SelCommission(PRPSetup objprp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@CommId", objprp.id);
            ADOprpDL.SPName = "selCommission";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup obj = new PRPSetup(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj = new PRPSetup();
                    obj.id = ADOprpDL.Dr["CommId"].ToString();
                    obj.uniID = ADOprpDL.Dr["PartnerId"].ToString();
                    obj.catID = ADOprpDL.Dr["plannId"].ToString();
                    obj.title = ADOprpDL.Dr["CommAmount"].ToString();
                    obj.DOJ = ADOprpDL.Dr["CommToYear"].ToString();
                    obj.description = ADOprpDL.Dr["CommForYear"].ToString();
                }
            }
            ADO.ReaderClose(ADOprpDL);
            return obj;
        }
        public string DelCommission(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@CommId", objprp.id);
            ADOprp.SPName = "DelCommission";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string InsinfopartnerReference(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@querry", objprp.name);
            ADOprp.SPName = "InsinfopartnerReference";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public List<PRPSetup> BindinfopartnerReference(PRPSetup prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[3];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.ArrayPram[2] = new SqlParameter("@partnerId", prp.uniID);
            ADOprpDL.SPName = "BindInfopartnerReference";
            ADO.ReaderWithProceduresandParam(ADOprpDL);            
            PRPSetup objprp;
            List<PRPSetup> lst = new List<PRPSetup>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetup();
                    objprp.id = ADOprpDL.Dr["partnerId"].ToString();
                    objprp.branchName = ADOprpDL.Dr["collegeName"].ToString();
                    objprp.address = ADOprpDL.Dr["collegeAddress"].ToString();
                    objprp.mobNo = ADOprpDL.Dr["collegeMobile"].ToString();
                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetup();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPSetup();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }

        public string InsertPartnerPaymentDetail(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[13];

            ADOprp.ArrayPram[0] = new SqlParameter("@Collegename", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@Mobileno", objprp.mobNo);
            ADOprp.ArrayPram[2] = new SqlParameter("@EmailId", objprp.emailID);
            ADOprp.ArrayPram[3] = new SqlParameter("@paymentType", objprp.level);
            ADOprp.ArrayPram[4] = new SqlParameter("@paymentDDNo", objprp.srNo);
            ADOprp.ArrayPram[5] = new SqlParameter("@paymentDate", objprp.DOB);
            ADOprp.ArrayPram[6] = new SqlParameter("@paymentBankName", objprp.title);
            ADOprp.ArrayPram[7] = new SqlParameter("@paymentBankAddress", objprp.address);
            ADOprp.ArrayPram[8] = new SqlParameter("@PartnerId", objprp.uniID);
            ADOprp.ArrayPram[9] = new SqlParameter("@PayForID", objprp.catID);
            ADOprp.ArrayPram[10] = new SqlParameter("@bankBranch", objprp.branchName);
            ADOprp.ArrayPram[11] = new SqlParameter("@PaymentAmount", objprp.Salary);
            ADOprp.ArrayPram[12] = new SqlParameter("@collegeCod", objprp.id);

            ADOprp.SPName = "InsPartnerPaymentDetail";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }

        public List<PRPSetup> ViewPartnerPaymentDetail(PRPSetup prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[2];

            ADOprpDL.ArrayPram[0] = new SqlParameter("@partnerId", prp.id);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@status", prp.status);

            ADOprpDL.SPName = "ViewPartnerPaymentDetail";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup objprp;
            List<PRPSetup> lst = new List<PRPSetup>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetup();
                    objprp.id = ADOprpDL.Dr["ReferenceId"].ToString();
                    objprp.name = ADOprpDL.Dr["Collegename"].ToString();
                    objprp.codeId = ADOprpDL.Dr["CollegeCod"].ToString();
                    objprp.mobNo = ADOprpDL.Dr["Mobileno"].ToString();
                    objprp.emailID = ADOprpDL.Dr["EmailID"].ToString();
                    objprp.title = ADOprpDL.Dr["BankName"].ToString();
                    objprp.branchName=ADOprpDL.Dr["BankBranch"].ToString();
                    objprp.level = ADOprpDL.Dr["paymentType"].ToString();
                    objprp.srNo = ADOprpDL.Dr["paymentDDNo"].ToString();
                    objprp.address = ADOprpDL.Dr["Note"].ToString();
                    objprp.DOB = ADOprpDL.Dr["paymentDate"].ToString();
                    objprp.status = ADOprpDL.Dr["status"].ToString();
                    objprp.DOJ = ADOprpDL.Dr["date"].ToString();
                    objprp.uniID = ADOprpDL.Dr["PartnerId"].ToString();
                    objprp.branchId = ADOprpDL.Dr["Product"].ToString();
                    objprp.Salary=ADOprpDL.Dr["PaymentAmount"].ToString();
                    objprp.description=ADOprpDL.Dr["Remarks"].ToString();
                    objprp.type=ADOprpDL.Dr["ProductType"].ToString();
                    lst.Add(objprp);
                }
             
            }
            else
            {
                objprp = new PRPSetup();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }

        public PRPSetup SelectPartnerPaymentDetail(PRPSetup objprp1)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@ReferenceId", objprp1.id);
            ADOprpDL.SPName = "SelectPartnerPaymentDetail";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup objprp = new PRPSetup(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetup();
                    objprp.id = ADOprpDL.Dr["ReferenceId"].ToString();
                    objprp.name = ADOprpDL.Dr["Collegename"].ToString();
                    objprp.codeId = ADOprpDL.Dr["CollegeCod"].ToString();
                    objprp.mobNo = ADOprpDL.Dr["Mobileno"].ToString();
                    objprp.emailID = ADOprpDL.Dr["EmailID"].ToString();
                    objprp.title = ADOprpDL.Dr["BankName"].ToString();
                    objprp.branchName = ADOprpDL.Dr["BankBranch"].ToString();
                    objprp.level = ADOprpDL.Dr["paymentType"].ToString();
                    objprp.srNo = ADOprpDL.Dr["paymentDDNo"].ToString();
                    objprp.address = ADOprpDL.Dr["Note"].ToString();
                    objprp.DOB = ADOprpDL.Dr["paymentDate"].ToString();
                    objprp.status = ADOprpDL.Dr["status"].ToString();
                    objprp.DOJ = ADOprpDL.Dr["date"].ToString();
                    objprp.codeId = ADOprpDL.Dr["PartnerId"].ToString();
                    objprp.branchId = ADOprpDL.Dr["Product"].ToString();
                    objprp.Salary = ADOprpDL.Dr["PaymentAmount"].ToString();
                    objprp.description = ADOprpDL.Dr["Remarks"].ToString();
                    objprp.type = ADOprpDL.Dr["ProductType"].ToString();
                }
            }
            ADO.ReaderClose(ADOprpDL);
            return objprp;
        }


        public string UpdPartnerPaymentDetail(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[3];
            ADOprp.ArrayPram[0] = new SqlParameter("@ReferenceId", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@status", objprp.codeId);
            ADOprp.ArrayPram[2] = new SqlParameter("@Remarks", objprp.description);
            ADOprp.SPName = "UpdPartnerPaymentDetail";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }

        public string updatePartnerPaymentDetail1(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[14];

            ADOprp.ArrayPram[0] = new SqlParameter("@Collegename", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@Mobileno", objprp.mobNo);
            ADOprp.ArrayPram[2] = new SqlParameter("@EmailId", objprp.emailID);
            ADOprp.ArrayPram[3] = new SqlParameter("@paymentType", objprp.level);
            ADOprp.ArrayPram[4] = new SqlParameter("@paymentDDNo", objprp.srNo);
            ADOprp.ArrayPram[5] = new SqlParameter("@paymentDate", objprp.DOB);
            ADOprp.ArrayPram[6] = new SqlParameter("@paymentBankName", objprp.title);
            ADOprp.ArrayPram[7] = new SqlParameter("@paymentBankAddress", objprp.address);
            ADOprp.ArrayPram[8] = new SqlParameter("@PartnerId", objprp.uniID);
            ADOprp.ArrayPram[9] = new SqlParameter("@PayForID", objprp.catID);
            ADOprp.ArrayPram[10] = new SqlParameter("@bankBranch", objprp.branchName);
            ADOprp.ArrayPram[11] = new SqlParameter("@PaymentAmount", objprp.Salary);
            ADOprp.ArrayPram[12] = new SqlParameter("@collegeCod", objprp.id);
            ADOprp.ArrayPram[13] = new SqlParameter("@ReferenceId", objprp.codeId);

            ADOprp.SPName = "UpdPartnerPaymentDetail1";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }

        public string InsFlocation(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[9];
            ADOprp.ArrayPram[0] = new SqlParameter("@Country", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@City", objprp.city);
            ADOprp.ArrayPram[2] = new SqlParameter("@Region", objprp.state);
            ADOprp.ArrayPram[3] = new SqlParameter("@IpAddress", objprp.address);
            ADOprp.ArrayPram[4] = new SqlParameter("@Latitude", objprp.DOB);
            ADOprp.ArrayPram[5] = new SqlParameter("@LatitudeII", objprp.DOJ);
            ADOprp.ArrayPram[6] = new SqlParameter("@IsActive", objprp.status);
            ADOprp.ArrayPram[7] = new SqlParameter("@CountyCode", objprp.codeId);
            ADOprp.ArrayPram[8] = new SqlParameter("@TimeZone", objprp.courseTime);
            ADOprp.SPName = "InsFTrack";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }


        public List<PRPSetup> ViewCollegeInqueryDetail(PRPSetup prp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[4];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.ArrayPram[2] = new SqlParameter("@mainStream", prp.uniID);
            ADOprpDL.ArrayPram[3] = new SqlParameter("@SubStream", prp.catID);
            ADOprpDL.SPName = "ViewCollegeInqueryDetail";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup objprp;
            List<PRPSetup> lst = new List<PRPSetup>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetup();
                    objprp.id = ADOprpDL.Dr["studentid"].ToString();
                    objprp.name = ADOprpDL.Dr["studentName"].ToString();
                    objprp.emailID = ADOprpDL.Dr["StudentEmailId"].ToString();
                    objprp.city = ADOprpDL.Dr["StudentCity"].ToString();
                    objprp.description = ADOprpDL.Dr["studentInquery"].ToString();
                    objprp.mobNo = ADOprpDL.Dr["StudentMobileNo"].ToString();
                    objprp.title = ADOprpDL.Dr["collegeName"].ToString();
                    objprp.DOB = ADOprpDL.Dr["Date"].ToString();
                    objprp.otherLocation = ADOprpDL.Dr["ipCity"].ToString();
                    objprp.state = ADOprpDL.Dr["ipState"].ToString();
                    objprp.address = ADOprpDL.Dr["ipName"].ToString();
                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetup();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPSetup();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }

        public List<PRPSetup> ViewRegistrationDetail(PRPSetup prp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.SPName = "viewRegistrationDetail";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup objprp;
            List<PRPSetup> lst = new List<PRPSetup>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetup();
                    objprp.id = ADOprpDL.Dr["row"].ToString();
                    objprp.name = ADOprpDL.Dr["collegeName"].ToString();
                    objprp.emailID = ADOprpDL.Dr["collegeEmailid"].ToString();
                    objprp.mailId = ADOprpDL.Dr["collegeWebsite"].ToString();
                    objprp.city = ADOprpDL.Dr["cityName"].ToString();
                    objprp.description = ADOprpDL.Dr["distName"].ToString();
                    objprp.state = ADOprpDL.Dr["statename"].ToString();
                    objprp.address = ADOprpDL.Dr["collegeAddress"].ToString();
                    objprp.DOB = ADOprpDL.Dr["Date"].ToString();
                    objprp.mobNo = ADOprpDL.Dr["collegeMobile"].ToString();
                    objprp.type = ADOprpDL.Dr["loginType"].ToString();
                    objprp.Password = ADOprpDL.Dr["loginpassword"].ToString();
                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetup();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPSetup();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
        public string DelCollegeInqueryDetail(PRPSetup prp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];

            ADOprp.ArrayPram[0] = new SqlParameter("@id", prp.id);

            ADOprp.SPName = "DelcollegeStudentInquery";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }

        public DataSet spMenuForMicro(PRPSetup objprp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@linkid", objprp.id);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@tempid", objprp.uniID);
            ADOprpDL.SPName = "spMenuForMicro";
            return ADO.DataSetWithProceduresandParam(ADOprpDL);
        }        

    }
    
}