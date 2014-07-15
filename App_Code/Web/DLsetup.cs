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
namespace nmsSetupWeb
{
    public class clsDLSetupWeb
    {
        //--------------------------------------------------------
        clsBLado ADO = new clsBLado();
        clsPRPadoBL ADOprp = new clsPRPadoBL();
        clsPRPadoDL ADOprpDL = new clsPRPadoDL();
       //------------------------------------------------
        clsprpADO objadoprp = new clsprpADO();
        clsADO objado = new clsADO();

//--start--University-------------------
        public string InsertUniversity(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[12];
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

            ADOprp.SPName = "InsertUniversity";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }
        public string UpdateUniversity(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[13];
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
            ADOprp.SPName = "UpdateUniversity";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string DeleteUniversity(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@universityCodeId", objprp.codeId);
            ADOprp.SPName = "deleteUniversity";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public PRPSetupWeb SelectUniversity(PRPSetupWeb objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@universityCodeId", objprp.codeId);
            ADOprpDL.SPName = "SelectUniversity";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupWeb obj = new PRPSetupWeb(); ;

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
                }
            }
            ADO.ReaderClose(ADOprpDL);
            return obj;
        }
        public List<PRPSetupWeb> ViewUniversity(PRPSetupWeb prp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.SPName = "viewUniversity";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupWeb objprp;
            List<PRPSetupWeb> lst = new List<PRPSetupWeb>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetupWeb();
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

                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetupWeb();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPSetupWeb();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
//--End----university-----------------------


//--Start Web University--------------------
        public string InsertUniversityWeb(PRPSetupWeb objprp)
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
        public string UpdateUniversityWeb(PRPSetupWeb objprp)
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
        public string DeleteUniversityWeb(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@universityCodeId", objprp.codeId);
            ADOprp.SPName = "deleteUniversityWeb";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public PRPSetupWeb SelectUniversityWeb(PRPSetupWeb objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@universityCodeId", objprp.codeId);
            ADOprpDL.SPName = "SelectUniversityWeb";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupWeb obj = new PRPSetupWeb(); ;

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
        public List<PRPSetupWeb> ViewUniversityWeb(PRPSetupWeb prp)
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

            PRPSetupWeb objprp;
            List<PRPSetupWeb> lst = new List<PRPSetupWeb>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetupWeb();
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
                    objprp.DOJ = ADOprpDL.Dr["uniDate"].ToString();
                    objprp.status = ADOprpDL.Dr["uniStatus"].ToString();
                    objprp.branchCodeName = ADOprpDL.Dr["uniCod"].ToString();
                    objprp.rank = ADOprpDL.Dr["uniRankType"].ToString();
                    objprp.grade = ADOprpDL.Dr["uniStudentGrade"].ToString();
                    objprp.catID = ADOprpDL.Dr["typeName"].ToString();                    
                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetupWeb();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
               }

            }
            else
            {
                objprp = new PRPSetupWeb();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;
        }
        public List<PRPSetupWeb> ViewUniversityType(PRPSetupWeb obj1)
        {
            objadoprp.Cmd = new SqlCommand();
            objadoprp.Cmd.CommandText = obj1.name;
            objadoprp.Cmd.CommandType = CommandType.StoredProcedure;
            objado.ReaderQuery(objadoprp);

            PRPSetupWeb objprp;
            List<PRPSetupWeb> lst = new List<PRPSetupWeb>();

            //  List<clsPRPView> list = new List<clsPRPView>();
            //            clsPRPView obj;
            PRPSetupWeb obj;

            if (objadoprp.ReturnMsg == "success")
            {
                if (objadoprp.Dr.HasRows)
                {
                    while (objadoprp.Dr.Read())
                    {

                        obj = new PRPSetupWeb();
                        obj.id = objadoprp.Dr["Id"].ToString();
                        obj.name = objadoprp.Dr["name"].ToString();
                        lst.Add(obj);
                    }
                }
                else
                {
                    obj = new PRPSetupWeb();
                    obj.srNo = "Result Not Find";
                    lst.Add(obj);
                }
                objado.ReaderClose(objadoprp);
            }
            else
            {
                obj = new PRPSetupWeb();
                obj.srNo = "Result Not Find";
                lst.Add(obj);
            }
            return lst;
        }
//--End Web University-----------------------

//--Start Web University--------------------
        public string InsertCollegeDetail(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[20];

            ADOprp.ArrayPram[0] = new SqlParameter("@collegeCountry", objprp.uniID);
            ADOprp.ArrayPram[1] = new SqlParameter("@collegeState", objprp.state);
            ADOprp.ArrayPram[2] = new SqlParameter("@collegeDistrict", objprp.district);
            ADOprp.ArrayPram[3] = new SqlParameter("@collegeCity", objprp.city);
            ADOprp.ArrayPram[4] = new SqlParameter("@collegeTypeId", objprp.catID);
            ADOprp.ArrayPram[5] = new SqlParameter("@educationType", objprp.education);

            ADOprp.ArrayPram[6] = new SqlParameter("@collegeName", objprp.name);
            ADOprp.ArrayPram[7] = new SqlParameter("@collegeMainLandMark", objprp.mainLandMark);
            ADOprp.ArrayPram[8] = new SqlParameter("@collegeAddress", objprp.address);
            ADOprp.ArrayPram[9] = new SqlParameter("@collegeStatus", objprp.isActive);

            ADOprp.ArrayPram[10] = new SqlParameter("@collegePhone", objprp.phoneNo);
            ADOprp.ArrayPram[11] = new SqlParameter("@collegeMobNo", objprp.mobNo);
            ADOprp.ArrayPram[12] = new SqlParameter("@collegeMailId", objprp.mailId);
            ADOprp.ArrayPram[13] = new SqlParameter("@collegeDate", objprp.DOJ);

            ADOprp.ArrayPram[14] = new SqlParameter("@collegeCodeName", objprp.branchCodeName);
            ADOprp.ArrayPram[15] = new SqlParameter("@collegewebId", objprp.emailID);
            ADOprp.ArrayPram[16] = new SqlParameter("@rank", objprp.rank);
            ADOprp.ArrayPram[17] = new SqlParameter("@grade", objprp.grade);
            ADOprp.ArrayPram[18] = new SqlParameter("@CollegeType", objprp.status);
            ADOprp.ArrayPram[19] = new SqlParameter("@universityId", objprp.id);

            ADOprp.SPName = "InsertcollegeDetail";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }
        public string UpdateCollegeDetail(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[21];

            ADOprp.ArrayPram[0] = new SqlParameter("@collegeCountry", objprp.uniID);
            ADOprp.ArrayPram[1] = new SqlParameter("@collegeState", objprp.state);
            ADOprp.ArrayPram[2] = new SqlParameter("@collegeDistrict", objprp.district);
            ADOprp.ArrayPram[3] = new SqlParameter("@collegeCity", objprp.city);
            ADOprp.ArrayPram[4] = new SqlParameter("@collegeTypeId", objprp.catID);
            ADOprp.ArrayPram[5] = new SqlParameter("@educationType", objprp.education);

            ADOprp.ArrayPram[6] = new SqlParameter("@collegeName", objprp.name);
            ADOprp.ArrayPram[7] = new SqlParameter("@collegeMainLandMark", objprp.mainLandMark);
            ADOprp.ArrayPram[8] = new SqlParameter("@collegeAddress", objprp.address);
            ADOprp.ArrayPram[9] = new SqlParameter("@collegeStatus", objprp.isActive);

            ADOprp.ArrayPram[10] = new SqlParameter("@collegePhone", objprp.phoneNo);
            ADOprp.ArrayPram[11] = new SqlParameter("@collegeMobNo", objprp.mobNo);
            ADOprp.ArrayPram[12] = new SqlParameter("@collegeMailId", objprp.mailId);
            ADOprp.ArrayPram[13] = new SqlParameter("@collegeDate", objprp.DOJ);

            ADOprp.ArrayPram[14] = new SqlParameter("@collegeCodeName", objprp.branchCodeName);
            ADOprp.ArrayPram[15] = new SqlParameter("@collegewebId", objprp.emailID);
            ADOprp.ArrayPram[16] = new SqlParameter("@rank", objprp.rank);
            ADOprp.ArrayPram[17] = new SqlParameter("@grade", objprp.grade);
            ADOprp.ArrayPram[18] = new SqlParameter("@collegeCodeId", objprp.codeId);
            ADOprp.ArrayPram[19] = new SqlParameter("@collegeType", objprp.status);
            ADOprp.ArrayPram[20] = new SqlParameter("@universityId", objprp.id);

            ADOprp.SPName = "UpdateCollegeDetail";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string DeleteCollegeDetail(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@collegeCodeId", objprp.codeId);
            ADOprp.SPName = "deleteCollegeDetail";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public PRPSetupWeb SelectCollegeDetail(PRPSetupWeb objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@collegeCodeId", objprp.codeId);
            ADOprpDL.SPName = "SelectCollegeDetail";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupWeb obj = new PRPSetupWeb(); ;

            if (ADOprpDL.Dr.HasRows)
            {

                while (ADOprpDL.Dr.Read())
                {
                    obj.id = ADOprpDL.Dr["collegeCod"].ToString();
                    obj.codeId = ADOprpDL.Dr["collegeID"].ToString();
                    obj.name = ADOprpDL.Dr["collegeName"].ToString();
                    obj.mainLandMark = ADOprpDL.Dr["collegeLandMark"].ToString();
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
                    obj.id = ADOprpDL.Dr["universityId"].ToString();
                }
            }
            ADO.ReaderClose(ADOprpDL);
            return obj;
        }
        public List<PRPSetupWeb> ViewCollegeDetail(PRPSetupWeb prp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[9];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.ArrayPram[2] = new SqlParameter("@Id", prp.uniID);
            ADOprpDL.ArrayPram[3] = new SqlParameter("@stateId", prp.state);
            ADOprpDL.ArrayPram[4] = new SqlParameter("@districtId", prp.district);
            ADOprpDL.ArrayPram[5] = new SqlParameter("@cityId", prp.city);
            ADOprpDL.ArrayPram[6] = new SqlParameter("@filterby", prp.status);
            ADOprpDL.ArrayPram[7] = new SqlParameter("@universityId", prp.id);
            ADOprpDL.ArrayPram[8] = new SqlParameter("@collegeId", prp.catID);

            ADOprpDL.SPName = "viewCollegeDetail";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupWeb objprp;
            List<PRPSetupWeb> lst = new List<PRPSetupWeb>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetupWeb();
                    objprp.id = ADOprpDL.Dr["collegeId"].ToString();
                    objprp.name = ADOprpDL.Dr["collegeName"].ToString();
                    objprp.mainLandMark = ADOprpDL.Dr["collegeLandMark"].ToString();
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
                    objprp.uniID = ADOprpDL.Dr["uniName"].ToString();                    
                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetupWeb();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }

            }
            else
            {
                objprp = new PRPSetupWeb();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;
        }
        public List<PRPSetupWeb> ViewCollegeType( PRPSetupWeb obj1 )
        {
            objadoprp.Cmd = new SqlCommand();
            objadoprp.Cmd.CommandText = obj1.name;
            objadoprp.Cmd.CommandType = CommandType.StoredProcedure;
            objado.ReaderQuery(objadoprp);

            PRPSetupWeb objprp;
            List<PRPSetupWeb> lst = new List<PRPSetupWeb>();

            //  List<clsPRPView> list = new List<clsPRPView>();
            //            clsPRPView obj;
            PRPSetupWeb obj;

            if (objadoprp.ReturnMsg == "success")
            {
                if (objadoprp.Dr.HasRows)
                {
                    while (objadoprp.Dr.Read())
                    {

                        obj = new PRPSetupWeb();
                        obj.id = objadoprp.Dr["Id"].ToString();
                        obj.name = objadoprp.Dr["name"].ToString();
                        lst.Add(obj);
                    }
                }
                else
                {
                    obj = new PRPSetupWeb();
                    obj.srNo = "Result Not Find";
                    lst.Add(obj);
                }
                objado.ReaderClose(objadoprp);
            }
            else
            {
                obj = new PRPSetupWeb();
                obj.srNo = "Result Not Find";
                lst.Add(obj);
            }
            return lst;
        }
        public List<PRPSetupWeb> ViewCollegeType1(PRPSetupWeb prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@Id", prp.id);
            ADOprpDL.SPName = "viewCollegeType1";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupWeb objprp;
            List<PRPSetupWeb> lst = new List<PRPSetupWeb>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetupWeb();
                    objprp.id = ADOprpDL.Dr["Id"].ToString();
                    objprp.name = ADOprpDL.Dr["Name"].ToString();
                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetupWeb();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }

            }
            else
            {
                objprp = new PRPSetupWeb();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;
        }
        //--End Web University-----------------------
//---Start---Setup Course Category-----------------  
        public string InsCourseCategory(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[3];
            ADOprp.ArrayPram[0] = new SqlParameter("@catName", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@uniID", objprp.uniID);
            ADOprp.ArrayPram[2] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.SPName = "insCourseCategory";            
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string UpdCourseCategory(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[4];

            ADOprp.ArrayPram[0] = new SqlParameter("@catID", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@catName", objprp.name);
            ADOprp.ArrayPram[2] = new SqlParameter("@uniID", objprp.uniID);
            ADOprp.ArrayPram[3] = new SqlParameter("@isActive", objprp.isActive);

            ADOprp.SPName = "updCourseCategory";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }
        public string DelCourseCategory(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@catID", objprp.id);
            ADOprp.SPName = "delCourseCategory";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);



        }
        public PRPSetupWeb SelCourseCategory(PRPSetupWeb objprp)
        {
            
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@catID", objprp.id);
            ADOprpDL.SPName = "selCourseCategory";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupWeb obj = new PRPSetupWeb(); ;

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
        public DataTable ViewCourseCategory( PRPSetupWeb objprp )
        {
            ADOprp.ArrayPram = new SqlParameter[1];

            ADOprp.ArrayPram[0] = new SqlParameter("@status", objprp.status);

            ADOprp.SPName = "ViewCourseCategory";
            return ADO.DataTableWithProcedures(ADOprp);           
        }
        //--End Setup Course Category----.
        #region ApprovedBy

        public string InsApprovedBy(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[5];
            ADOprp.ArrayPram[0] = new SqlParameter("@Country", objprp.sCountry);
            ADOprp.ArrayPram[1] = new SqlParameter("@sCatName", objprp.name);
            ADOprp.ArrayPram[2] = new SqlParameter("@sMainCatId", objprp.uniID); 
            ADOprp.ArrayPram[3] = new SqlParameter("@Description", objprp.description);
            ADOprp.ArrayPram[4] = new SqlParameter("@ImagePath", objprp.urlPath);
            ADOprp.SPName = "InsApprovedBy";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        #endregion

        #region Insert CourseLevel

        public string InsCourseLevel(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[5];
            ADOprp.ArrayPram[0] = new SqlParameter("@Country", objprp.sCountry);
            ADOprp.ArrayPram[1] = new SqlParameter("@sCatName", objprp.name);
            ADOprp.ArrayPram[2] = new SqlParameter("@sMainCatId", objprp.uniID);
            ADOprp.ArrayPram[3] = new SqlParameter("@Description", objprp.description);
            ADOprp.ArrayPram[4] = new SqlParameter("@ImagePath", objprp.urlPath);
            ADOprp.SPName = "InsCourseLevel";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        #endregion

        //Start Sub Course Catagory
        public string InsSubCategory(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[6];
            ADOprp.ArrayPram[0] = new SqlParameter("@Country", objprp.sCountry);
            ADOprp.ArrayPram[1] = new SqlParameter("@sCatName", objprp.name);
            ADOprp.ArrayPram[2] = new SqlParameter("@sMainCatId", objprp.uniID);
            // ADOprp.ArrayPram[2] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.ArrayPram[3] = new SqlParameter("@Title", objprp.title);
            ADOprp.ArrayPram[4] = new SqlParameter("@Description", objprp.description);
            ADOprp.ArrayPram[5] = new SqlParameter("@ImagePath", objprp.urlPath);
            ADOprp.SPName = "crsInsSubCategory";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string UpdSubCategory(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[7];

            ADOprp.ArrayPram[0] = new SqlParameter("@sCatId", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@sCatName", objprp.name);
            ADOprp.ArrayPram[2] = new SqlParameter("@Title", objprp.title);
            ADOprp.ArrayPram[3] = new SqlParameter("@Description", objprp.description);
            ADOprp.ArrayPram[4] = new SqlParameter("@ImagePath", objprp.urlPath);
            ADOprp.ArrayPram[5] = new SqlParameter("@sMainCatId", objprp.uniID);
            ADOprp.ArrayPram[6] = new SqlParameter("@Country", objprp.sCountry);
            // ADOprp.ArrayPram[3] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.SPName = "crsUpdSubCategory";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string DelSubCategory(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@sCatId", objprp.id);
            ADOprp.SPName = "crsDeleteSubCategory";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);



        }
        public PRPSetupWeb SelSubCategory(PRPSetupWeb objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@sCatId", objprp.id);
            ADOprpDL.SPName = "crsViewbySelectSubCategory";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupWeb obj = new PRPSetupWeb();

            if (ADOprpDL.Dr.HasRows)
            {

                while (ADOprpDL.Dr.Read())
                {
                    obj.id = ADOprpDL.Dr["id"].ToString();
                    obj.name = ADOprpDL.Dr["name"].ToString();
                    obj.title = ADOprpDL.Dr["Title"].ToString();
                    obj.uniID = ADOprpDL.Dr["sMainCatId"].ToString();
                    obj.description = ADOprpDL.Dr["Description"].ToString();
                    obj.urlPath = ADOprpDL.Dr["ImagePath"].ToString();
                }
            }
            ADO.ReaderClose(ADOprpDL);
            return obj;
        }



        //SelCollegeLogo
        //End Sub Course Catagory
        #region CollegeLogo
        public PRPSetupWeb SelCollegeLogo(PRPSetupWeb objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@sCatId", objprp.id);
            ADOprpDL.SPName = "SpGetCollegeLogo";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupWeb obj = new PRPSetupWeb();

            if (ADOprpDL.Dr.HasRows)
            {

                while (ADOprpDL.Dr.Read())
                {
                    obj.id = ADOprpDL.Dr["id"].ToString();                   
                    obj.urlPath = ADOprpDL.Dr["ImagePath"].ToString();
                }
            }
            ADO.ReaderClose(ADOprpDL);
            return obj;
        }

        public string UpdateCollegeLogo(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[2];
            ADOprp.ArrayPram[0] = new SqlParameter("@CollegeId", objprp.id);           
            ADOprp.ArrayPram[1] = new SqlParameter("@ImagePath", objprp.urlPath);           
            ADOprp.SPName = "SpUpdateCollegeLogo";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }

        #endregion
        //--start--Course Detail Web---------      
        public string InsertCourseWeb(PRPSetupWeb objprp)
        {            
            ADOprp.ArrayPram = new SqlParameter[16];
            ADOprp.ArrayPram[0] = new SqlParameter("@courseName", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@courseCode", objprp.branchCodeName);
            ADOprp.ArrayPram[2] = new SqlParameter("@courseSpecilization", objprp.specilization);
            ADOprp.ArrayPram[3] = new SqlParameter("@durationMinTime", objprp.durationMinTime);
            ADOprp.ArrayPram[4] = new SqlParameter("@durationMaxTime", objprp.durationMaxTime);
            ADOprp.ArrayPram[5] = new SqlParameter("@courseEligibility", objprp.eligibility);
            ADOprp.ArrayPram[6] = new SqlParameter("@courseFees", objprp.courseFees);
            ADOprp.ArrayPram[7] = new SqlParameter("@examFees", objprp.examFees);
            ADOprp.ArrayPram[8] = new SqlParameter("@otherFees", objprp.otherFees);
            ADOprp.ArrayPram[9] = new SqlParameter("@regFees", objprp.regFees);
            ADOprp.ArrayPram[10] = new SqlParameter("@courseCatID", objprp.catID);
            ADOprp.ArrayPram[11] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.ArrayPram[12] = new SqlParameter("@courseTime", objprp.courseTime);
            ADOprp.ArrayPram[13] = new SqlParameter("@semMode", objprp.semMode);
            ADOprp.ArrayPram[14] = new SqlParameter("@crsMainCatId", objprp.id);
            ADOprp.ArrayPram[15] = new SqlParameter("@crsSCatId", objprp.codeId);
            ADOprp.SPName = "insCourseWeb";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }
        public string UpdateCourse(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[17];
            ADOprp.ArrayPram[0] = new SqlParameter("@courseID", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@courseName", objprp.name);
            ADOprp.ArrayPram[2] = new SqlParameter("@courseCode", objprp.branchCodeName);
            ADOprp.ArrayPram[3] = new SqlParameter("@courseSpecilization", objprp.specilization);
            ADOprp.ArrayPram[4] = new SqlParameter("@durationMinTime", objprp.durationMinTime);
            ADOprp.ArrayPram[5] = new SqlParameter("@durationMaxTime", objprp.durationMaxTime);
            ADOprp.ArrayPram[6] = new SqlParameter("@courseEligibility", objprp.eligibility);
            ADOprp.ArrayPram[7] = new SqlParameter("@courseFees", objprp.courseFees);
            ADOprp.ArrayPram[8] = new SqlParameter("@examFees", objprp.examFees);
            ADOprp.ArrayPram[9] = new SqlParameter("@otherFees", objprp.otherFees);
            ADOprp.ArrayPram[10] = new SqlParameter("@regFees", objprp.regFees);
            ADOprp.ArrayPram[11] = new SqlParameter("@courseCatID", objprp.catID);
            ADOprp.ArrayPram[12] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.ArrayPram[13] = new SqlParameter("@courseTime", objprp.courseTime);
            ADOprp.ArrayPram[14] = new SqlParameter("@semMode", objprp.semMode);
            ADOprp.ArrayPram[15] = new SqlParameter("@crsMainCatId", objprp.branchId);
            ADOprp.ArrayPram[16] = new SqlParameter("@crsSCatId", objprp.codeId);
            ADOprp.SPName = "updCourseWeb";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string DeleteCourse(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@CourseID", objprp.id);
            ADOprp.SPName = "delCourseWeb";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);



        }
        public PRPSetupWeb SelectCourse(PRPSetupWeb objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@CourseID", objprp.id);
            ADOprpDL.SPName = "selCourseWeb";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupWeb obj = new PRPSetupWeb(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj=new PRPSetupWeb();
                    obj.id=ADOprpDL.Dr["courseId"].ToString();
                    obj.name= ADOprpDL.Dr["courseName"].ToString();
                    obj.branchCodeName=ADOprpDL.Dr["courseCode"].ToString();
                    obj.specilization= ADOprpDL.Dr["courseSpecilization"].ToString();
                    obj.durationMinTime= ADOprpDL.Dr["durationMinTime"].ToString();
                    obj.durationMaxTime= ADOprpDL.Dr["durationMaxTime"].ToString();
                    obj.eligibility= ADOprpDL.Dr["courseEligibility"].ToString();
                    obj.courseFees= ADOprpDL.Dr["courseFees"].ToString();
                    obj.examFees= ADOprpDL.Dr["examFees"].ToString();
                    obj.otherFees=ADOprpDL.Dr["otherFees"].ToString();
                    obj.regFees=  ADOprpDL.Dr["regFees"].ToString();
                    obj.catID=ADOprpDL.Dr["courseCatID"].ToString();
                    obj.isActive = ADOprpDL.Dr["isActive"].ToString();
                    obj.courseTime = ADOprpDL.Dr["courseTime"].ToString();
                    obj.semMode = ADOprpDL.Dr["semMode"].ToString();
                    obj.rank = ADOprpDL.Dr["crsMainCatId"].ToString(); ;
                    obj.codeId = ADOprpDL.Dr["crsSCatId"].ToString(); ;
                }
            }
            ADO.ReaderClose(ADOprpDL);
            return obj;
        }
        public List<PRPSetupWeb> ViewCourseWeb(PRPSetupWeb prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[4];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.ArrayPram[2] = new SqlParameter("@courseCatID", prp.catID);
            ADOprpDL.ArrayPram[3] = new SqlParameter("@status", prp.status);
            ADOprpDL.SPName = "viewCourseWeb";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupWeb objprp;
            List<PRPSetupWeb> lst = new List<PRPSetupWeb>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetupWeb();
                    objprp.id = ADOprpDL.Dr["courseId"].ToString();
                    objprp.name = ADOprpDL.Dr["courseName"].ToString();
                    objprp.branchCodeName = ADOprpDL.Dr["courseCode"].ToString();
                    objprp.specilization = ADOprpDL.Dr["courseSpecilization"].ToString();
                    objprp.durationMinTime = ADOprpDL.Dr["durationMinTime"].ToString();
                    objprp.durationMaxTime = ADOprpDL.Dr["durationMaxTime"].ToString();
                    objprp.eligibility = ADOprpDL.Dr["courseEligibility"].ToString();
                    objprp.courseFees = ADOprpDL.Dr["courseFees"].ToString();
                    objprp.examFees = ADOprpDL.Dr["examFees"].ToString();
                    objprp.otherFees = ADOprpDL.Dr["otherFees"].ToString();
                    objprp.regFees = ADOprpDL.Dr["regFees"].ToString();
                    objprp.catID = ADOprpDL.Dr["courseCatID"].ToString();
                    objprp.isActive = ADOprpDL.Dr["isActive"].ToString();
                    objprp.courseTime = ADOprpDL.Dr["courseTime"].ToString();
                    objprp.semMode = ADOprpDL.Dr["semMode"].ToString();
                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetupWeb();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPSetupWeb();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
        //--End--Course Detail Web-----------
        //News For
        public string InsNewsFor(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[2];
            ADOprp.ArrayPram[0] = new SqlParameter("@NewName", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@isActive ", objprp.isActive);
            ADOprp.SPName = "SpInsertNewsFor";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string UpdNewsFor(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[3];

            ADOprp.ArrayPram[0] = new SqlParameter("@ForId", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@NewName", objprp.name);
            ADOprp.ArrayPram[2] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.SPName = "spUpdateNewsFor";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string DelNewsFor(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@ForId", objprp.id);
            ADOprp.SPName = "SpDeleteNewsFor";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);



        }
        public PRPSetupWeb SelNewsFor(PRPSetupWeb objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@ForId", objprp.id);
            ADOprpDL.SPName = "SpSelectByIdNewsFor";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupWeb obj = new PRPSetupWeb(); ;

            if (ADOprpDL.Dr.HasRows)
            {

                while (ADOprpDL.Dr.Read())
                {
                    obj.id = ADOprpDL.Dr["ForId"].ToString();
                    obj.name = ADOprpDL.Dr["NewName"].ToString();
                    obj.isActive = ADOprpDL.Dr["isActive"].ToString();
                }
            }
            ADO.ReaderClose(ADOprpDL);
            return obj;
        }
        //News For
//--Start--News Type.
        public string InsNewsType(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[3];
            ADOprp.ArrayPram[0] = new SqlParameter("@typeName", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@uniID", objprp.uniID);
            ADOprp.ArrayPram[2] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.SPName = "insNewsType";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string UpdNewsType(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[4];

            ADOprp.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@typeName", objprp.name);
            ADOprp.ArrayPram[2] = new SqlParameter("@uniID", objprp.uniID);
            ADOprp.ArrayPram[3] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.SPName = "updNewsType";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);            
        }
        public string DelNewsType(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
            ADOprp.SPName = "delNewsType";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);



        }
        public PRPSetupWeb SelNewsType(PRPSetupWeb objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
            ADOprpDL.SPName = "selNewsType";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupWeb obj = new PRPSetupWeb(); 

            if (ADOprpDL.Dr.HasRows)
            {

                while (ADOprpDL.Dr.Read())
                {
                    obj.id = ADOprpDL.Dr["typeID"].ToString();
                    obj.name = ADOprpDL.Dr["typeName"].ToString();
                    obj.isActive = ADOprpDL.Dr["isActive"].ToString();
                    obj.uniID = ADOprpDL.Dr["NewForId"].ToString();
                }
            }
            ADO.ReaderClose(ADOprpDL);
            return obj;
        }
        
        public List<PRPSetupWeb> BindBranchForCheck(PRPSetupWeb prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[0];
          
            if (prp.id == "2")
            {
                ADOprpDL.SPName = "spViewBranch";
            }
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupWeb objprp;
            List<PRPSetupWeb> lst = new List<PRPSetupWeb>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetupWeb();
                    objprp.id = ADOprpDL.Dr["branchCodeId"].ToString();
                    objprp.title = ADOprpDL.Dr["branchName"].ToString();
                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetupWeb();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
          
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
        public string InsertShowInBranch(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[3];
            ADOprp.ArrayPram[0] = new SqlParameter("@ShowNewsId", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@ShowBranchId", objprp.uniID);
            ADOprp.ArrayPram[2] = new SqlParameter("@ShowNewsForId", objprp.codeId);
            ADOprp.SPName = "SpInsertShowInBranch";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        //Show In Branch End
        //Sub by college start
        public List<PRPSetupWeb> CheckUniByBranch(PRPSetupWeb prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@CourseId", prp.id);
            // PRPSetupWeb prp=new PRPSetupWeb ();

            ADOprpDL.SPName = "SpdetailwebtypeById";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupWeb objprp;
            List<PRPSetupWeb> lst = new List<PRPSetupWeb>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetupWeb();
                    objprp.id = ADOprpDL.Dr["CourseTypeId"].ToString();
                    objprp.courseFees = ADOprpDL.Dr["CourseId"].ToString();
                    objprp.branchId = ADOprpDL.Dr["CollegeId"].ToString();
                    objprp.designationId = ADOprpDL.Dr["CollegeType"].ToString();
                    objprp.catID = ADOprpDL.Dr["CrsSubCategory"].ToString();
                    
                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetupWeb();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
          
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
        public List<PRPSetupWeb> BindUniforAuth(PRPSetupWeb prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[0];
          
            ADOprpDL.SPName = "SpShowUniCode";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupWeb objprp;
            List<PRPSetupWeb> lst = new List<PRPSetupWeb>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetupWeb();
                    objprp.id = ADOprpDL.Dr["UniId"].ToString();
                    objprp.title = ADOprpDL.Dr["UniName"].ToString();
                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetupWeb();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
         
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
        public string InsertCollegeDetailWebType(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@Querry", objprp.name);
            ADOprp.SPName = "SpinsertCollegeDetailWebType";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }

        public List<PRPSetupWeb> BindByAuthorisation(PRPSetupWeb prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[3];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.ArrayPram[2] = new SqlParameter("@Type", prp.uniID);
            ADOprpDL.SPName = "SpBinnWebType";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupWeb objprp;
            List<PRPSetupWeb> lst = new List<PRPSetupWeb>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetupWeb();
                    objprp.id = ADOprpDL.Dr["CourseId"].ToString();
                    objprp.branchName = ADOprpDL.Dr["courseName"].ToString();
                   
                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetupWeb();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPSetupWeb();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
        public List<PRPSetupWeb> BindCollegInRepitor(PRPSetupWeb prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@CourseId", prp.id);
            ADOprpDL.SPName = "SpBindCollegeByIdInRep";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupWeb objprp;
            List<PRPSetupWeb> lst = new List<PRPSetupWeb>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetupWeb();
                    objprp.title = ADOprpDL.Dr["CollegeName"].ToString();

                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetupWeb();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
           
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
        public string DeleteCollSub(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@CourseId", objprp.id);
            ADOprp.SPName = "DeleteCollSub";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);



        }
        //Sub by college End
//--Start--News.
        public string InsNews(PRPSetupWeb objprp)
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
        public string UpdNews(PRPSetupWeb objprp)
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
        public string DelNews(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@newsID", objprp.id);
            ADOprp.SPName = "delNews";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public PRPSetupWeb SelNews(PRPSetupWeb objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@newsID", objprp.id);
            ADOprpDL.SPName = "selNews";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupWeb obj = new PRPSetupWeb(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {                   
                    obj = new PRPSetupWeb();
                    obj.id = ADOprpDL.Dr["newsID"].ToString();
                    obj.title = ADOprpDL.Dr["newsTitle"].ToString();
                    obj.description = ADOprpDL.Dr["newsDescription"].ToString();
                    obj.catID = ADOprpDL.Dr["newsTypeID"].ToString();
                    obj.uniID = ADOprpDL.Dr["newsUniversityID"].ToString();
                    obj.DOJ = ADOprpDL.Dr["newsDate"].ToString();
                    obj.isActive = ADOprpDL.Dr["isActive"].ToString();
                    obj.status = ADOprpDL.Dr["subTitle"].ToString();
                }
            }
            ADO.ReaderClose(ADOprpDL);
            return obj;
        }
        public List<PRPSetupWeb> ViewNews(PRPSetupWeb prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[3];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.ArrayPram[2] = new SqlParameter("@newsUniversityID", prp.uniID);
            ADOprpDL.SPName = "viewNews";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupWeb objprp;
            List<PRPSetupWeb> lst = new List<PRPSetupWeb>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetupWeb();
                    objprp.id = ADOprpDL.Dr["newsID"].ToString();
                    objprp.title = ADOprpDL.Dr["newsTitle"].ToString();
                    objprp.description = ADOprpDL.Dr["newsDescription"].ToString();
                    objprp.catID = ADOprpDL.Dr["newsType"].ToString();
                    objprp.uniID = ADOprpDL.Dr["NewName"].ToString();                    
                    objprp.DOJ = ADOprpDL.Dr["newsDate"].ToString();
                    objprp.isActive = ADOprpDL.Dr["isActive"].ToString();
                    objprp.status = ADOprpDL.Dr["subTitle"].ToString();
                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetupWeb();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPSetupWeb();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;
            
        }
        public List<PRPSetupWeb> ViewNewsInBranch(PRPSetupWeb prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@UniId", prp.catID);
            ADOprpDL.SPName = "SpVeiwNewsInBranch";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupWeb objprp;
            List<PRPSetupWeb> lst = new List<PRPSetupWeb>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetupWeb();
                    objprp.id = ADOprpDL.Dr["NewsId"].ToString();
                    objprp.title = ADOprpDL.Dr["SubTitle"].ToString();
                    //objprp.description = ADOprpDL.Dr["BranchName"].ToString();
                    objprp.DOJ = ADOprpDL.Dr["NewsDate"].ToString();
                    objprp.branchName = ADOprpDL.Dr["newImage"].ToString();
                    lst.Add(objprp);
                }
            }
            else
            {
                objprp = new PRPSetupWeb();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
        public List<PRPSetupWeb> ViewNews1(PRPSetupWeb prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@newsType", prp.catID);
            //ADOprpDL.SPName = "viewNews1";
            ADOprpDL.SPName = "ShowNewsById";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupWeb objprp;
            List<PRPSetupWeb> lst = new List<PRPSetupWeb>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetupWeb();
                    objprp.title = ADOprpDL.Dr["newsTitle"].ToString();
                    objprp.description = ADOprpDL.Dr["newsDescription"].ToString();
                    objprp.DOJ = ADOprpDL.Dr["newsDate"].ToString();                   
                    lst.Add(objprp);
                }                
            }
            else
            {
                objprp = new PRPSetupWeb();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }

//--End--News.

//--Start--New Job.
        public string InsJob(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[3];
            ADOprp.ArrayPram[0] = new SqlParameter("@JobTitle", objprp.title);
            ADOprp.ArrayPram[1] = new SqlParameter("@JobDescription", objprp.description);
            ADOprp.ArrayPram[2] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.SPName = "insJob";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string UpdJob(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[4];
            ADOprp.ArrayPram[0] = new SqlParameter("@JobID", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@JobTitle", objprp.title);
            ADOprp.ArrayPram[2] = new SqlParameter("@JobDescription", objprp.description);
            ADOprp.ArrayPram[3] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.SPName = "updJob";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string DelJob(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@JobID", objprp.id);
            ADOprp.SPName = "delJob";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public PRPSetupWeb SelJob(PRPSetupWeb objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@JobID", objprp.id);
            ADOprpDL.SPName = "selJob";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupWeb obj = new PRPSetupWeb(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj = new PRPSetupWeb();
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
        public List<PRPSetupWeb> ViewJob(PRPSetupWeb prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.SPName = "viewJob";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupWeb objprp;
            List<PRPSetupWeb> lst = new List<PRPSetupWeb>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetupWeb();
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
                    objprp = new PRPSetupWeb();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPSetupWeb();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
        public List<PRPSetupWeb> ViewJob1(PRPSetupWeb prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.SPName = "viewJob1";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupWeb objprp;
            List<PRPSetupWeb> lst = new List<PRPSetupWeb>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetupWeb();
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
                objprp = new PRPSetupWeb();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }

//--End--New Job.

//--Start Resume Detail.
        public string InsResumeDetail(PRPSetupWeb objprp)
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
        public string UpdResumeDetail(PRPSetupWeb objprp)
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
        public List<PRPSetupWeb> ViewResumeDetail(PRPSetupWeb prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.SPName = "viewResumeDetail";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupWeb objprp;
            List<PRPSetupWeb> lst = new List<PRPSetupWeb>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {   objprp = new PRPSetupWeb();
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
                    objprp = new PRPSetupWeb();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPSetupWeb();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
//--End Resume Detail
//--Start Link file Upload.
        public string InsFile(PRPSetupWeb obj)
        {
            ADOprp.ArrayPram = new SqlParameter[4];
            ADOprp.ArrayPram[0] = new SqlParameter("@linkUniversity",obj.uniID);
            ADOprp.ArrayPram[1] = new SqlParameter("@linkName",obj.name);
            ADOprp.ArrayPram[2] = new SqlParameter("@linkPath",obj.urlPath);
            ADOprp.ArrayPram[3] = new SqlParameter("@isActive",obj.isActive);
            ADOprp.SPName = "insFileDetail";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string UpdFile(PRPSetupWeb obj)
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
        public List<PRPSetupWeb> ViewFile(PRPSetupWeb obj)
        {
            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", obj.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", obj.pageSize);
            ADOprpDL.SPName = "viewFileDetail";
            ADO.ReaderWithProceduresandParam(ADOprpDL);
            PRPSetupWeb objprp;
            List<PRPSetupWeb> lst = new List<PRPSetupWeb>();
            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetupWeb();
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
                    objprp = new PRPSetupWeb();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPSetupWeb();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
        public PRPSetupWeb SelFile(PRPSetupWeb obj)
        {
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@LinkID", obj.id);            
            ADOprpDL.SPName = "selFileDetail";
            ADO.ReaderWithProceduresandParam(ADOprpDL);
            PRPSetupWeb objprp= new PRPSetupWeb();;
          //  List<PRPSetupWeb> lst = new List<PRPSetupWeb>();
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
        public string DelFile(PRPSetupWeb obj)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@linkID",obj.id);
            ADOprp.SPName = "delFileDetail";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
//--End Link File upload.

//--Start Text Editor.
        public string InsText(PRPSetupWeb objprp)
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
        public string UpdText(PRPSetupWeb objprp)
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
        public string DelText(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@textID", objprp.id);
            ADOprp.SPName = "delText";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public PRPSetupWeb SelText(PRPSetupWeb objprp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@textID", objprp.id);
            ADOprpDL.SPName = "selText";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupWeb obj = new PRPSetupWeb(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj = new PRPSetupWeb();
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
        public PRPSetupWeb SelText1(PRPSetupWeb objprp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@uniId", objprp.uniID);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@catId", objprp.catID);
            ADOprpDL.SPName = "selText1";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupWeb obj = new PRPSetupWeb(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj = new PRPSetupWeb();
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
        public List<PRPSetupWeb> ViewText(PRPSetupWeb prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.SPName = "viewText";
            ADO.ReaderWithProceduresandParam(ADOprpDL);
            PRPSetupWeb objprp;
            List<PRPSetupWeb> lst = new List<PRPSetupWeb>();
            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetupWeb();
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
                    objprp = new PRPSetupWeb();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPSetupWeb();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
//--End Text Editor.

//--Start Text Editor.
        public string InsTextWeb(PRPSetupWeb objprp)
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
        public string UpdTextWeb(PRPSetupWeb objprp)
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
        public string DelTextWeb(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@textID", objprp.id);
            ADOprp.SPName = "delTextWeb";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public PRPSetupWeb SelTextWeb(PRPSetupWeb objprp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@textID", objprp.id);
            ADOprpDL.SPName = "selTextWeb";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupWeb obj = new PRPSetupWeb(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj = new PRPSetupWeb();
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
        public PRPSetupWeb SelTextWeb1(PRPSetupWeb objprp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@uniId", objprp.uniID);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@catId", objprp.catID);
            ADOprpDL.SPName = "selTextWeb1";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupWeb obj = new PRPSetupWeb(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj = new PRPSetupWeb();
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
        public List<PRPSetupWeb> ViewTextWeb(PRPSetupWeb prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.SPName = "viewTextWeb";
            ADO.ReaderWithProceduresandParam(ADOprpDL);
            PRPSetupWeb objprp;
            List<PRPSetupWeb> lst = new List<PRPSetupWeb>();
            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetupWeb();
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
                    objprp = new PRPSetupWeb();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPSetupWeb();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
//--End Text Editor.
 //--Start Text Category.
        public string InsTextCategory(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[3];
            ADOprp.ArrayPram[0] = new SqlParameter("@catName", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@uniID", objprp.uniID);
            ADOprp.ArrayPram[2] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.SPName = "insTextCategory";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string UpdTextCategory(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[4];

            ADOprp.ArrayPram[0] = new SqlParameter("@catID", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@catName", objprp.name);
            ADOprp.ArrayPram[2] = new SqlParameter("@uniID", objprp.uniID);
            ADOprp.ArrayPram[3] = new SqlParameter("@isActive", objprp.isActive);

            ADOprp.SPName = "updTextCategory";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }
        public string DelTextCategory(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@catID", objprp.id);
            ADOprp.SPName = "delTextCategory";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);



        }
        public PRPSetupWeb SelTextCategory(PRPSetupWeb objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@catID", objprp.id);
            ADOprpDL.SPName = "selTextCategory";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupWeb obj = new PRPSetupWeb(); ;

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
        public DataTable ViewTextCategory(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];

            ADOprp.ArrayPram[0] = new SqlParameter("@status", objprp.status);

            ADOprp.SPName = "ViewTextCategory";
            return ADO.DataTableWithProcedures(ADOprp);
        }
//--End Text Category.

//--Start Text Category.
        public string InsTextCategoryWeb(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[3];
            ADOprp.ArrayPram[0] = new SqlParameter("@catName", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@uniID", objprp.uniID);
            ADOprp.ArrayPram[2] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.SPName = "insTextCategoryWeb";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string UpdTextCategoryWeb(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[4];

            ADOprp.ArrayPram[0] = new SqlParameter("@catID", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@catName", objprp.name);
            ADOprp.ArrayPram[2] = new SqlParameter("@uniID", objprp.uniID);
            ADOprp.ArrayPram[3] = new SqlParameter("@isActive", objprp.isActive);

            ADOprp.SPName = "updTextCategoryWeb";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }
        public string DelTextCategoryWeb(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@catID", objprp.id);
            ADOprp.SPName = "delTextCategoryWeb";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);



        }
        public PRPSetupWeb SelTextCategoryWeb(PRPSetupWeb objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@catID", objprp.id);
            ADOprpDL.SPName = "selTextCategoryWeb";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupWeb obj = new PRPSetupWeb(); ;

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
        public DataTable ViewTextCategoryWeb(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];

            ADOprp.ArrayPram[0] = new SqlParameter("@status", objprp.status);

            ADOprp.SPName = "ViewTextCategoryWeb";
            return ADO.DataTableWithProcedures(ADOprp);
        }
//--End Text Category.

//--Start Local Text Editor.
        public string UpdLocalText(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[4];
            ADOprp.ArrayPram[0] = new SqlParameter("@textID", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@textTitle", objprp.title);
            ADOprp.ArrayPram[2] = new SqlParameter("@textDescription", objprp.description);
            ADOprp.ArrayPram[3] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.SPName = "updLocalText";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public PRPSetupWeb SelLocalText(PRPSetupWeb objprp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@textID", objprp.id);
            ADOprpDL.SPName = "selLocalText";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupWeb obj = new PRPSetupWeb(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj = new PRPSetupWeb();
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
        public string InsImageCategory(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[3];
            ADOprp.ArrayPram[0] = new SqlParameter("@catName", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@uniID", objprp.uniID);
            ADOprp.ArrayPram[2] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.SPName = "insImageCategory";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string UpdImageCategory(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[4];

            ADOprp.ArrayPram[0] = new SqlParameter("@catID", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@catName", objprp.name);
            ADOprp.ArrayPram[2] = new SqlParameter("@uniID", objprp.uniID);
            ADOprp.ArrayPram[3] = new SqlParameter("@isActive", objprp.isActive);

            ADOprp.SPName = "updImageCategory";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }
        public string DelImageCategory(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@catID", objprp.id);
            ADOprp.SPName = "delImageCategory";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);



        }
        public PRPSetupWeb SelImageCategory(PRPSetupWeb objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@catID", objprp.id);
            ADOprpDL.SPName = "selImageCategory";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupWeb obj = new PRPSetupWeb(); ;

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
        public DataTable ViewImageCategory(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];

            ADOprp.ArrayPram[0] = new SqlParameter("@status", objprp.status);

            ADOprp.SPName = "ViewImageCategory";
            return ADO.DataTableWithProcedures(ADOprp);
        }    
//--End Image Category.
        public string InsImageGallery(PRPSetupWeb objprp)
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
        public string UpdImageGallery(PRPSetupWeb objprp)
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
        public string DelImageGallery(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@imageId", objprp.id);            
            ADOprp.SPName = "delImageGallery";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public PRPSetupWeb SelImageGallery(PRPSetupWeb objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@imageID", objprp.id);
            ADOprpDL.SPName = "selImageGallery";
            ADO.ReaderWithProceduresandParam(ADOprpDL);
            PRPSetupWeb obj = new PRPSetupWeb(); ;
            if (ADOprpDL.Dr.HasRows)
            {

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
       public List<PRPSetupWeb> ViewImageGallery(PRPSetupWeb obj)
        {
            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@uniID", obj.uniID);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@catID", obj.catID);
            ADOprpDL.SPName = "viewImageGallery";
            ADO.ReaderWithProceduresandParam(ADOprpDL);
            PRPSetupWeb objprp;
            List<PRPSetupWeb> lst = new List<PRPSetupWeb>();
            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetupWeb();
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
                objprp = new PRPSetupWeb();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
       
//--Start EducationType
       public string InsEducationType(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[2];
           ADOprp.ArrayPram[0] = new SqlParameter("@typeName", objprp.name);
           ADOprp.ArrayPram[1] = new SqlParameter("@isActive", objprp.isActive);
           ADOprp.SPName = "insEducationType";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string UpdEducationType(PRPSetupWeb objprp)  
       {
           ADOprp.ArrayPram = new SqlParameter[3];

           ADOprp.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
           ADOprp.ArrayPram[1] = new SqlParameter("@typeName", objprp.name);
           ADOprp.ArrayPram[2] = new SqlParameter("@isActive", objprp.isActive);

           ADOprp.SPName = "updEducationType";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);


       }
       public string DelEducationType(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
           ADOprp.SPName = "delEducationType";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public PRPSetupWeb SelEducationType(PRPSetupWeb objprp)
       {

           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
           ADOprpDL.SPName = "selEducationType";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetupWeb obj = new PRPSetupWeb(); ;

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

        
        
//--Start UniversityType
       public string InsUniversityType(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[2];
           ADOprp.ArrayPram[0] = new SqlParameter("@typeName", objprp.name);
           ADOprp.ArrayPram[1] = new SqlParameter("@isActive", objprp.isActive);
           ADOprp.SPName = "insUniversityType";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string UpdUniversityType(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[3];

           ADOprp.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
           ADOprp.ArrayPram[1] = new SqlParameter("@typeName", objprp.name);
           ADOprp.ArrayPram[2] = new SqlParameter("@isActive", objprp.isActive);

           ADOprp.SPName = "updUniversityType";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);


       }
       public string DelUniversityType(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
           ADOprp.SPName = "delUniversityType";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public PRPSetupWeb SelUniversityType(PRPSetupWeb objprp)
       {

           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
           ADOprpDL.SPName = "selUniversityType";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetupWeb obj = new PRPSetupWeb(); ;

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
       public string InsCollegeType(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[2];
           ADOprp.ArrayPram[0] = new SqlParameter("@typeName", objprp.name);
           ADOprp.ArrayPram[1] = new SqlParameter("@isActive", objprp.isActive);
           ADOprp.SPName = "insCollegeType";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string UpdCollegeType(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[3];

           ADOprp.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
           ADOprp.ArrayPram[1] = new SqlParameter("@typeName", objprp.name);
           ADOprp.ArrayPram[2] = new SqlParameter("@isActive", objprp.isActive);

           ADOprp.SPName = "updCollegeType";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);


       }
       public string DelCollegeType(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
           ADOprp.SPName = "delCollegeType";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public PRPSetupWeb SelCollegeType(PRPSetupWeb objprp)
       {

           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
           ADOprpDL.SPName = "selCollegeType";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetupWeb obj = new PRPSetupWeb(); ;

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
       public string InsCourseType(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[2];
           ADOprp.ArrayPram[0] = new SqlParameter("@typeName", objprp.name);
           ADOprp.ArrayPram[1] = new SqlParameter("@isActive", objprp.isActive);
           ADOprp.SPName = "insCourseType";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string UpdCourseType(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[3];

           ADOprp.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
           ADOprp.ArrayPram[1] = new SqlParameter("@typeName", objprp.name);
           ADOprp.ArrayPram[2] = new SqlParameter("@isActive", objprp.isActive);

           ADOprp.SPName = "updCourseType";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);


       }
       public string DelCourseType(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
           ADOprp.SPName = "delCourseType";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public PRPSetupWeb SelCourseType(PRPSetupWeb objprp)
       {

           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
           ADOprpDL.SPName = "selCourseType";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetupWeb obj = new PRPSetupWeb(); ;

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
 // Start main Course Stream
       public string InsMainCategory(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[5];
           ADOprp.ArrayPram[0] = new SqlParameter("@CatName", objprp.name);
           ADOprp.ArrayPram[1] = new SqlParameter("@uniID", objprp.uniID);
           // ADOprp.ArrayPram[1] = new SqlParameter("@isActive", objprp.isActive);
           ADOprp.ArrayPram[2] = new SqlParameter("@Title", objprp.title);
           ADOprp.ArrayPram[3] = new SqlParameter("@Description", objprp.description);
           ADOprp.ArrayPram[4] = new SqlParameter("@ImagePath", objprp.urlPath);
          // ADOprp.ArrayPram[5] = new SqlParameter("@Country", objprp.sCountry);
           //ADOprp.ArrayPram[6] = new SqlParameter("@State", objprp.state);
           ADOprp.SPName = "crsInsMainCategory";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string UpdMainCategory(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[6];
           ADOprp.ArrayPram[0] = new SqlParameter("@CatName", objprp.name);
           ADOprp.ArrayPram[1] = new SqlParameter("@uniID", objprp.uniID);
           // ADOprp.ArrayPram[1] = new SqlParameter("@isActive", objprp.isActive);
           ADOprp.ArrayPram[2] = new SqlParameter("@Title", objprp.title);
           ADOprp.ArrayPram[3] = new SqlParameter("@Description", objprp.description);
           ADOprp.ArrayPram[4] = new SqlParameter("@ImagePath", objprp.urlPath);
           ADOprp.ArrayPram[5] = new SqlParameter("@CatId", objprp.id);
           //ADOprp.ArrayPram[6] = new SqlParameter("@Country", objprp.sCountry);
           //ADOprp.ArrayPram[7] = new SqlParameter("@State", objprp.state);
           // ADOprp.ArrayPram[2] = new SqlParameter("@isActive", objprp.isActive);

           ADOprp.SPName = "crsUpdMainCategory";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);


       }
       public string DelMainCategory(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@CatId", objprp.id);
           ADOprp.SPName = "crsDeleteMainCategory";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public PRPSetupWeb SelMainCategory(PRPSetupWeb objprp)
       {

           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@CatId", objprp.id);
           ADOprpDL.SPName = "crsViewbySelectMainCategory";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetupWeb obj = new PRPSetupWeb(); ;

           if (ADOprpDL.Dr.HasRows)
           {

               while (ADOprpDL.Dr.Read())
               {
                   obj.id = ADOprpDL.Dr["id"].ToString();
                   obj.name = ADOprpDL.Dr["name"].ToString();
                   obj.isActive = ADOprpDL.Dr["categoryType"].ToString();
                   obj.title = ADOprpDL.Dr["Title"].ToString();
                   obj.description = ADOprpDL.Dr["Description"].ToString();
                   obj.urlPath = ADOprpDL.Dr["ImagePath"].ToString();
               }
           }
           ADO.ReaderClose(ADOprpDL);
           return obj;
       }
        // End main Course Stream
   //--Start Country.
       public string InsCountry(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@cntName", objprp.name);
           ADOprp.SPName = "insCountry";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string UpdCountry(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[2];

           ADOprp.ArrayPram[0] = new SqlParameter("@cntID", objprp.id);
           ADOprp.ArrayPram[1] = new SqlParameter("@cntName", objprp.name);

           ADOprp.SPName = "updCountry";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);


       }
       public string DelCountry(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@cntID", objprp.id);
           ADOprp.SPName = "delCountry";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public PRPSetupWeb SelCountry(PRPSetupWeb objprp)
       {

           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@cntID", objprp.id);
           ADOprpDL.SPName = "selCountry";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetupWeb obj = new PRPSetupWeb(); ;

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
       public string InsState(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[2];
           ADOprp.ArrayPram[0] = new SqlParameter("@stateName", objprp.name);
           ADOprp.ArrayPram[1] = new SqlParameter("@cnt", objprp.uniID);
           ADOprp.SPName = "insState";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string UpdState(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[3];           
           ADOprp.ArrayPram[0] = new SqlParameter("@stateID", objprp.id);
           ADOprp.ArrayPram[1] = new SqlParameter("@stateName", objprp.name);
           ADOprp.ArrayPram[2] = new SqlParameter("@cntId", objprp.uniID);
           ADOprp.SPName = "updState";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);


       }
       public string DelState(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@stateID", objprp.id);
           ADOprp.SPName = "delState";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);           
       }
       public PRPSetupWeb SelState(PRPSetupWeb objprp)
       {

           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@stateID", objprp.id);
           ADOprpDL.SPName = "selState";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetupWeb obj = new PRPSetupWeb(); ;

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
       public string InsDistrict(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[2];
           ADOprp.ArrayPram[0] = new SqlParameter("@distName", objprp.name);
           ADOprp.ArrayPram[1] = new SqlParameter("@stateID", objprp.uniID);
           ADOprp.SPName = "insDistrict";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string UpdDistrict(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[3];

           ADOprp.ArrayPram[0] = new SqlParameter("@distId", objprp.id);
           ADOprp.ArrayPram[1] = new SqlParameter("@distName", objprp.name);
           ADOprp.ArrayPram[2] = new SqlParameter("@stateId", objprp.uniID);
           ADOprp.SPName = "updDistrict";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string DelDistrict(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@distId", objprp.id);
           ADOprp.SPName = "delDistrict";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public PRPSetupWeb SelDistrict(PRPSetupWeb objprp)
       {

           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@distId", objprp.id);
           ADOprpDL.SPName = "selDistrict";

           ADO.ReaderWithProceduresandParam(ADOprpDL);

           PRPSetupWeb obj = new PRPSetupWeb(); ;

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
       public string InsCity(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[2];
           ADOprp.ArrayPram[0] = new SqlParameter("@cityName", objprp.name);
           ADOprp.ArrayPram[1] = new SqlParameter("@distID", objprp.uniID);
           ADOprp.SPName = "insCity";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string UpdCity(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[3];

           ADOprp.ArrayPram[0] = new SqlParameter("@cityID", objprp.id);
           ADOprp.ArrayPram[1] = new SqlParameter("@cityName", objprp.name);
           ADOprp.ArrayPram[2] = new SqlParameter("@distID", objprp.uniID);
           ADOprp.SPName = "updCity";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string DelCity(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@cityID", objprp.id);
           ADOprp.SPName = "delCity";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public PRPSetupWeb SelCity(PRPSetupWeb objprp)
       {

           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@cityID", objprp.id);
           ADOprpDL.SPName = "selCity";

           ADO.ReaderWithProceduresandParam(ADOprpDL);

           PRPSetupWeb obj = new PRPSetupWeb(); ;

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
       public string InsBranchLocator(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[4];
           ADOprp.ArrayPram[0] = new SqlParameter("@branchName", objprp.title);
           ADOprp.ArrayPram[1] = new SqlParameter("@branchDescription", objprp.description);
           ADOprp.ArrayPram[2] = new SqlParameter("@cityId", objprp.uniID);
           ADOprp.ArrayPram[3] = new SqlParameter("@isActive", objprp.isActive);
           ADOprp.SPName = "insBranchLocator";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string UpdBranchLocator(PRPSetupWeb objprp)
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
       public string DelBranchLocator(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@branchId", objprp.id);
           ADOprp.SPName = "delBranchLocator";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public PRPSetupWeb SelBranchLocator(PRPSetupWeb objprp)
       {
           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@branchId", objprp.id);
           ADOprpDL.SPName = "selBranchLocator";
           ADO.ReaderWithProceduresandParam(ADOprpDL);

           PRPSetupWeb obj = new PRPSetupWeb(); ;

           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   obj = new PRPSetupWeb();
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
       public List<PRPSetupWeb> ViewBranchLocator(PRPSetupWeb prp)
       {
           ADOprpDL.ArrayPram = new SqlParameter[2];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
           ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
           ADOprpDL.SPName = "viewBranchLocator";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetupWeb objprp;
           List<PRPSetupWeb> lst = new List<PRPSetupWeb>();
           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   objprp = new PRPSetupWeb();
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
                   objprp = new PRPSetupWeb();
                   objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                   lst.Add(objprp);
               }


           }
           else
           {
               objprp = new PRPSetupWeb();
               objprp.srNo = "Result Not Find";
               lst.Add(objprp);
           }
           ADO.ReaderClose(ADOprpDL);
           return lst;

       }
       public List<PRPSetupWeb> ViewBranchLocator1(PRPSetupWeb prp)
       {
           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@cityId", prp.id);           
           ADOprpDL.SPName = "viewBranchLocator1";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetupWeb objprp;
           List<PRPSetupWeb> lst = new List<PRPSetupWeb>();
           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   objprp = new PRPSetupWeb();
                   objprp.id = ADOprpDL.Dr["branchId"].ToString();
                   objprp.title = ADOprpDL.Dr["branchName"].ToString();
                   objprp.description = ADOprpDL.Dr["branchDescription"].ToString();
                   lst.Add(objprp);
               }              

           }
           else
           {
               objprp = new PRPSetupWeb();
               objprp.srNo = "Result Not Find";
               lst.Add(objprp);
           }
           ADO.ReaderClose(ADOprpDL);
           return lst;
       }
//--End Branch Locator

//--Start Course Text Editor.
       public string InsCourseText(PRPSetupWeb objprp)
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
       public string UpdCourseText(PRPSetupWeb objprp)
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
       public string DelCourseText(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@textID", objprp.id);
           ADOprp.SPName = "delCourseText";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public PRPSetupWeb SelCourseText(PRPSetupWeb objprp)
       {
           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@textID", objprp.id);
           ADOprpDL.SPName = "selCourseText";
           ADO.ReaderWithProceduresandParam(ADOprpDL);

           PRPSetupWeb obj = new PRPSetupWeb(); ;

           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   obj = new PRPSetupWeb();
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
       public PRPSetupWeb SelCourseText1(PRPSetupWeb objprp)
       {
           ADOprpDL.ArrayPram = new SqlParameter[2];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@uniId", objprp.uniID);
           ADOprpDL.ArrayPram[1] = new SqlParameter("@catId", objprp.catID);
           ADOprpDL.SPName = "selCourseText1";
           ADO.ReaderWithProceduresandParam(ADOprpDL);

           PRPSetupWeb obj = new PRPSetupWeb(); ;

           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   obj = new PRPSetupWeb();
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
       public List<PRPSetupWeb> ViewCourseText(PRPSetupWeb prp)
       {
           ADOprpDL.ArrayPram = new SqlParameter[2];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
           ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
           ADOprpDL.SPName = "viewCourseText";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetupWeb objprp;
           List<PRPSetupWeb> lst = new List<PRPSetupWeb>();
           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   objprp = new PRPSetupWeb();
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
                   objprp = new PRPSetupWeb();
                   objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                   lst.Add(objprp);
               }


           }
           else
           {
               objprp = new PRPSetupWeb();
               objprp.srNo = "Result Not Find";
               lst.Add(objprp);
           }
           ADO.ReaderClose(ADOprpDL);
           return lst;

       }
//--End Course Text Editor.
//--Start Visitor Counter.
       public string UpdVisitor(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@maxValue", objprp.courseFees);
           ADOprp.SPName = "updVisitor";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);   
       }
//--End Visitor Counter.

       //Start CrsLinkList
       public string InsertCrsLinkList(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[17];
           ADOprp.ArrayPram[0] = new SqlParameter("@crsMainId", objprp.pageIndex);
           ADOprp.ArrayPram[1] = new SqlParameter("@CrsScatagoryId", objprp.pageSize);
           ADOprp.ArrayPram[2] = new SqlParameter("@CrsInstituteCode", objprp.city);
           ADOprp.ArrayPram[3] = new SqlParameter("@CrsSeats", objprp.noOfRecord);
           ADOprp.ArrayPram[4] = new SqlParameter("@Coursemode", objprp.marital);
           ADOprp.ArrayPram[5] = new SqlParameter("@crsFullName", objprp.name);
           //ADOprp.ArrayPram[6] = new SqlParameter("@pv", objprp.pv);
           ADOprp.ArrayPram[6] = new SqlParameter("@CrsShortName", objprp.branchName);
           ADOprp.ArrayPram[7] = new SqlParameter("@CrsShortDecription", objprp.designationName);
           ADOprp.ArrayPram[8] = new SqlParameter("@CrsLongDescription", objprp.description);
           ADOprp.ArrayPram[9] = new SqlParameter("@CrsDuration", objprp.durationMaxTime);
           //  ADOprp.ArrayPram[11] = new SqlParameter("@courseUniID", objprp.uniID);
           ADOprp.ArrayPram[10] = new SqlParameter("@CrsFees", objprp.Salary);
           ADOprp.ArrayPram[11] = new SqlParameter("@CrsFeesMode", objprp.security );
           ADOprp.ArrayPram[12] = new SqlParameter("@CurrencyType", objprp.grade);
           ADOprp.ArrayPram[13] = new SqlParameter("@CrsType", objprp.codeId);
           ADOprp.ArrayPram[14] = new SqlParameter("@scholarship", objprp.id);
           ADOprp.ArrayPram[15] = new SqlParameter("@CrsEligibility", objprp.eligibility);
           ADOprp.ArrayPram[16] = new SqlParameter("@DurationMode", objprp.courseTime);
           // ADOprp.ArrayPram[16] = new SqlParameter("@scholarship", objprp.city);
           ADOprp.SPName = "crsInsLinkList";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }

       public string UpdateCrsLinkList(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[17];
           ADOprp.ArrayPram[0] = new SqlParameter("@courseCategory", objprp.pageIndex);
           ADOprp.ArrayPram[1] = new SqlParameter("@courseSubCategory", objprp.pageSize);
           //ADOprp.ArrayPram[2] = new SqlParameter("@CrsInstituteCode", objprp.city);
           ADOprp.ArrayPram[2] = new SqlParameter("@courseSeat", objprp.noOfRecord);
           ADOprp.ArrayPram[3] = new SqlParameter("@courseMode", objprp.marital);
           ADOprp.ArrayPram[4] = new SqlParameter("@courseFullName", objprp.name);
           //ADOprp.ArrayPram[6] = new SqlParameter("@pv", objprp.pv);
           ADOprp.ArrayPram[5] = new SqlParameter("@courseShortName", objprp.branchName);
           ADOprp.ArrayPram[6] = new SqlParameter("@courseShortDescription", objprp.designationName);
           ADOprp.ArrayPram[7] = new SqlParameter("@courseLongDescription", objprp.description);
           ADOprp.ArrayPram[8] = new SqlParameter("@courseDuration", objprp.durationMaxTime);
           //  ADOprp.ArrayPram[11] = new SqlParameter("@courseUniID", objprp.uniID);
           ADOprp.ArrayPram[9] = new SqlParameter("@courseFees", objprp.Salary);
           ADOprp.ArrayPram[10] = new SqlParameter("@feesMode", objprp.grade);
           ADOprp.ArrayPram[11] = new SqlParameter("@currencyType", objprp.security);
           ADOprp.ArrayPram[12] = new SqlParameter("@courseType", objprp.codeId);
           ADOprp.ArrayPram[13] = new SqlParameter("@courseId", objprp.id);
           ADOprp.ArrayPram[14] = new SqlParameter("@eligibility", objprp.eligibility);
           ADOprp.ArrayPram[15] = new SqlParameter("@scholarship", objprp.specilization);
           ADOprp.ArrayPram[16] = new SqlParameter("@durationMode", objprp.courseTime);

           //ADOprp.ArrayPram[16] = new SqlParameter("@CrsInstituteCode", objprp.city)@durationMode,@,@,@date;
           ADOprp.SPName = "crsUpdLinkList";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);

       }
        
       public string DelCrsLinkList(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[2];

           ADOprp.ArrayPram[0] = new SqlParameter("@id", objprp.id);
           ADOprp.ArrayPram[1] = new SqlParameter("@CrsInstituteCode", objprp.codeId);

           ADOprp.SPName = "crsDelLinkList";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);

       }

       public PRPSetupWeb SelectCrsLinkList(PRPSetupWeb objprp)
       {

           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@ListId", objprp.id);
           ADOprpDL.SPName = "crsShowLinkList";

           ADO.ReaderWithProceduresandParam(ADOprpDL);

           PRPSetupWeb obj = new PRPSetupWeb(); ;

           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   obj = new PRPSetupWeb();
                   obj.pageIndex = ADOprpDL.Dr["CourseCategory"].ToString();
                   obj.pageSize = ADOprpDL.Dr["CourseSubCategory"].ToString();
                   obj.city = ADOprpDL.Dr["CollegeCod"].ToString();
                   obj.noOfRecord = ADOprpDL.Dr["CourseSeat"].ToString();
                   obj.marital = ADOprpDL.Dr["Coursemode"].ToString();
                   obj.name = ADOprpDL.Dr["CourseFullName"].ToString();
                   obj.branchName = ADOprpDL.Dr["CourseShortName"].ToString();
                   // obj.pv= ADOprpDL.Dr["pv"].ToString();
                   obj.designationName = ADOprpDL.Dr["CourseShortDescription"].ToString();
                   obj.description = ADOprpDL.Dr["CourseLongDescription"].ToString();
                   obj.durationMaxTime = ADOprpDL.Dr["CourseDuration"].ToString();
                   obj.courseTime = ADOprpDL.Dr["durationMode"].ToString();
                   obj.Salary = ADOprpDL.Dr["CourseFees"].ToString();
                   //obj.uniID= ADOprpDL.Dr["courseUniID"].ToString();
                   obj.grade = ADOprpDL.Dr["FeesMode"].ToString();
                   obj.security = ADOprpDL.Dr["CurrencyType"].ToString();
                   obj.codeId = ADOprpDL.Dr["CourseType"].ToString();
                   obj.id = ADOprpDL.Dr["CourseShortName"].ToString();
                   obj.eligibility = ADOprpDL.Dr["Eligibility"].ToString();
                   obj.mainLandMark = ADOprpDL.Dr["CourseId"].ToString();
                   obj.address = ADOprpDL.Dr["Scholarship"].ToString();
                   obj.salarynum = Convert.ToInt32(ADOprpDL.Dr["CourseFees"]);
               }
           }
           ADO.ReaderClose(ADOprpDL);
           return obj;
       }
        
        public List<PRPSetupWeb> ShowCrsLinkList(PRPSetupWeb objprp)
       {

           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@id", objprp.id);
           ADOprpDL.SPName = "CrsShowInListBox";

           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetupWeb obj;
           List<PRPSetupWeb> lst = new List<PRPSetupWeb>();
           // PRPSetupWeb obj = new PRPSetupWeb(); ;

           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   obj = new PRPSetupWeb();                   
                   
                   obj.id = ADOprpDL.Dr["id"].ToString();
                   obj.codeId = ADOprpDL.Dr["CollegeCod"].ToString();
                   obj.uniID = ADOprpDL.Dr["catName"].ToString();
                   obj.catID = ADOprpDL.Dr["sCatName"].ToString();
                   obj.name = ADOprpDL.Dr["name"].ToString();
                   obj.fatherName = ADOprpDL.Dr["CourseShortName"].ToString();
                   obj.description = ADOprpDL.Dr["courseLongDescription"].ToString();
                   obj.designationName = ADOprpDL.Dr["courseShortDescription"].ToString();                    
                   obj.courseTime = ADOprpDL.Dr["courseDuration"].ToString();
                   obj.durationMaxTime = ADOprpDL.Dr["durationMode"].ToString();
                   obj.srNo = ADOprpDL.Dr["courseSeat"].ToString();
                   obj.courseFees = ADOprpDL.Dr["courseFees"].ToString();
                   obj.feeMode = ADOprpDL.Dr["feesMode"].ToString();
                   obj.courseType = ADOprpDL.Dr["courseType"].ToString();
                   obj.courseMode = ADOprpDL.Dr["courseMode"].ToString();
                   obj.scholarship = ADOprpDL.Dr["scholarship"].ToString();
                   obj.examFees = ADOprpDL.Dr["currencyType"].ToString();
                   obj.eligibility = ADOprpDL.Dr["eligibility"].ToString();
                   lst.Add(obj);
               }
           }
           ADO.ReaderClose(ADOprpDL);
           return lst;
       }
        //  End CrsLinkList


        public List<PRPSetupWeb> ShowSchoolDetail(PRPSetupWeb objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@id", objprp.id);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@type", objprp.courseType);
            ADOprpDL.SPName = "SchoolDetailRimpi";

            ADO.ReaderWithProceduresandParam(ADOprpDL);
            PRPSetupWeb obj;
            List<PRPSetupWeb> lst = new List<PRPSetupWeb>();
            // PRPSetupWeb obj = new PRPSetupWeb(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj = new PRPSetupWeb();

                    obj.id = ADOprpDL.Dr["id"].ToString();
                    obj.codeId = ADOprpDL.Dr["SCode"].ToString();
                    obj.uniID = ADOprpDL.Dr["S_from"].ToString();
                    obj.catID = ADOprpDL.Dr["S_to"].ToString();
                    obj.description = ADOprpDL.Dr["S_GrdYear"].ToString();
                    obj.designationName = ADOprpDL.Dr["S_School"].ToString();
                    obj.courseTime = ADOprpDL.Dr["S_Specilization"].ToString();
                    obj.durationMaxTime = ADOprpDL.Dr["S_Type"].ToString();
                    lst.Add(obj);
                }
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;
        }
        public string DelSchoolDetail(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];

            ADOprp.ArrayPram[0] = new SqlParameter("@id", objprp.id);

            ADOprp.SPName = "delSchoolDetailRimpi";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }


        public List<PRPSetupWeb> ShowCollegeDetail(PRPSetupWeb objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@id", objprp.id);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@type", objprp.courseType);
            ADOprpDL.SPName = "CollegeDetailRimpi";

            ADO.ReaderWithProceduresandParam(ADOprpDL);
            PRPSetupWeb obj;
            List<PRPSetupWeb> lst = new List<PRPSetupWeb>();
            // PRPSetupWeb obj = new PRPSetupWeb(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj = new PRPSetupWeb();

                    obj.id = ADOprpDL.Dr["id"].ToString();
                    obj.codeId = ADOprpDL.Dr["SCode"].ToString();
                    obj.uniID = ADOprpDL.Dr["S_from"].ToString();
                    obj.catID = ADOprpDL.Dr["S_to"].ToString();
                    obj.description = ADOprpDL.Dr["S_GrdYear"].ToString();
                    obj.designationName = ADOprpDL.Dr["S_College"].ToString();
                    obj.courseTime = ADOprpDL.Dr["S_Specilization"].ToString();
                    obj.durationMaxTime = ADOprpDL.Dr["S_Type"].ToString();
                    lst.Add(obj);
                }
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;
        }
        public string DelCollegeDetail(PRPSetupWeb objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];

            ADOprp.ArrayPram[0] = new SqlParameter("@id", objprp.id);

            ADOprp.SPName = "delCollegeDetailRimpi";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }
//Start Work By Raj
       ///////////////////8-30-12 
       public List<PRPSetupWeb> ViewState(PRPSetupWeb obj)
       {
           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@CrsType", obj.id);
           //ADOprpDL.ArrayPram[1] = new SqlParameter("@catID", obj.catID);
           ADOprpDL.SPName = "viewState1";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetupWeb objprp;
           List<PRPSetupWeb> lst = new List<PRPSetupWeb>();
           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   objprp = new PRPSetupWeb();
                   objprp.id = ADOprpDL.Dr["id"].ToString();
                   objprp.title = ADOprpDL.Dr["name"].ToString();

                   lst.Add(objprp);
               }
           }
           return lst;
       }
       public List<PRPSetupWeb> ViewCity(PRPSetupWeb obj)
       {
           ADOprpDL.ArrayPram = new SqlParameter[2];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@statid", obj.id);
           ADOprpDL.ArrayPram[1] = new SqlParameter("@crsScatagoryId", obj.catID);
           ADOprpDL.SPName = "viewcity1";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetupWeb objprp;
           List<PRPSetupWeb> lst = new List<PRPSetupWeb>();
           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   objprp = new PRPSetupWeb();
                   objprp.id = ADOprpDL.Dr["id"].ToString();
                   objprp.title = ADOprpDL.Dr["name"].ToString();

                   lst.Add(objprp);
               }
           }
           return lst;
       }
       public List<PRPSetupWeb> ViewCollegeSearch(PRPSetupWeb obj)
       {
    
           ADOprpDL.ArrayPram = new SqlParameter[11];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@collegeCity", obj.id);
           ADOprpDL.ArrayPram[1] = new SqlParameter("@pageIndex", obj.pageIndex);
           ADOprpDL.ArrayPram[2] = new SqlParameter("@pageSize", obj.pageSize);
           ADOprpDL.ArrayPram[3] = new SqlParameter("@CrsScatagoryId", obj.catID);
           ADOprpDL.ArrayPram[4] = new SqlParameter("@loginType", obj.uniID);
           ADOprpDL.ArrayPram[5] = new SqlParameter("@ipaddress", obj.address);
           ADOprpDL.ArrayPram[6] = new SqlParameter("@collegeState", obj.state);
           ADOprpDL.ArrayPram[7] = new SqlParameter("@pip", obj.urlId);
           ADOprpDL.ArrayPram[8] = new SqlParameter("@pname", obj.urlName);
           ADOprpDL.ArrayPram[9] = new SqlParameter("@pcity", obj.urlPath);
           ADOprpDL.ArrayPram[10] = new SqlParameter("@pstate", obj.urlPrntId);
           ADOprpDL.SPName = "ViewCollegeSearch";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetupWeb objprp;
           List<PRPSetupWeb> lst = new List<PRPSetupWeb>();
           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   objprp = new PRPSetupWeb();
                   objprp.rank = ADOprpDL.Dr["id"].ToString();
                   objprp.id = ADOprpDL.Dr["InstCode"].ToString();
                   objprp.title = ADOprpDL.Dr["CollegeName"].ToString();
                   objprp.urlPath = ADOprpDL.Dr["collegeImage"].ToString();
                   objprp.description = ADOprpDL.Dr["CourseShortName"].ToString();
                   objprp.examFees = ADOprpDL.Dr["CourseFees"].ToString();
                   objprp.city = ADOprpDL.Dr["Cityname"].ToString();
                   objprp.durationMinTime = ADOprpDL.Dr["courseDuration"].ToString();
                   objprp.address = ADOprpDL.Dr["collegeAddress"].ToString();
                   objprp.state = ADOprpDL.Dr["state"].ToString();
                   objprp.district = ADOprpDL.Dr["district"].ToString();
                   objprp.srNo = ADOprpDL.Dr["total"].ToString();
                   objprp.emailID = ADOprpDL.Dr["collegeEmailID"].ToString();
                   objprp.mailId = ADOprpDL.Dr["collegewebsite"].ToString();
                   objprp.branchCodeName = ADOprpDL.Dr["webFolder"].ToString();
                   objprp.urlId = ADOprpDL.Dr["tutionType"].ToString();
                   objprp.semMode = ADOprpDL.Dr["ShortDescription"].ToString();
                   objprp.DOB = ADOprpDL.Dr["JoinIngDate"].ToString();
                   objprp.status = ADOprpDL.Dr["gender"].ToString();
                   
                   lst.Add(objprp);
               }              
               if (ADOprpDL.Dr.NextResult())
               {

                   ADOprpDL.Dr.Read();
                   objprp = new PRPSetupWeb();
                   objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                   lst.Add(objprp);
               }
           }
           else
           {
               objprp = new PRPSetupWeb();
               objprp.srNo = "Result Not Find";
               lst.Add(objprp);
           }
           return lst;
       }

       public List<PRPSetupWeb> ViewSchoolSearch(PRPSetupWeb obj)
       {
           ADOprpDL.ArrayPram = new SqlParameter[4];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@collegeCity", obj.id);
           ADOprpDL.ArrayPram[1] = new SqlParameter("@pageIndex", obj.pageIndex);
           ADOprpDL.ArrayPram[2] = new SqlParameter("@pageSize", obj.pageSize);
           ADOprpDL.ArrayPram[3] = new SqlParameter("@CrsScatagoryId", obj.catID);
           //  ADOprpDL.ArrayPram[4] = new SqlParameter("@collegeCourse", obj.codeId);
           ADOprpDL.SPName = "ViewSchoolSearch";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetupWeb objprp;
           List<PRPSetupWeb> lst = new List<PRPSetupWeb>();
           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   objprp = new PRPSetupWeb();
                   objprp.rank = ADOprpDL.Dr["id"].ToString();
                   objprp.id = ADOprpDL.Dr["InstCode"].ToString();
                   objprp.title = ADOprpDL.Dr["CollegeName"].ToString();
                   objprp.urlPath = ADOprpDL.Dr["collegeImage"].ToString();
                   objprp.city = ADOprpDL.Dr["Cityname"].ToString();
                   objprp.address = ADOprpDL.Dr["collegeAddress"].ToString();
                   objprp.state = ADOprpDL.Dr["state"].ToString();
                   objprp.district = ADOprpDL.Dr["district"].ToString();
                   objprp.srNo = ADOprpDL.Dr["total"].ToString();
                   objprp.emailID = ADOprpDL.Dr["collegeEmailID"].ToString();
                   objprp.mailId = ADOprpDL.Dr["collegewebsite"].ToString();
                   objprp.branchCodeName = ADOprpDL.Dr["webFolder"].ToString();
                   lst.Add(objprp);
               }

               if (ADOprpDL.Dr.NextResult())
               {

                   ADOprpDL.Dr.Read();
                   objprp = new PRPSetupWeb();
                   objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                   lst.Add(objprp);
               }
           }
           else
           {
               objprp = new PRPSetupWeb();
               objprp.srNo = "Result Not Find";
               lst.Add(objprp);
           }
           return lst;
       }

       public List<PRPSetupWeb> GetDatalist(PRPSetupWeb obj)
       {
           ADOprpDL.ArrayPram = new SqlParameter[2];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@CollegeCod", obj.id);
           ADOprpDL.ArrayPram[1] = new SqlParameter("@CourseSubCategory", obj.catID);
           ADOprpDL.SPName = "srcCorsedetailshow";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetupWeb objprp;
           List<PRPSetupWeb> lst = new List<PRPSetupWeb>();
           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   objprp = new PRPSetupWeb();
                   objprp.AssociateName = ADOprpDL.Dr["ApprovedBy"].ToString();
                   objprp.description = ADOprpDL.Dr["ShortDescription"].ToString();
                   objprp.mailId = ADOprpDL.Dr["CollegeEmailID"].ToString();
                   objprp.specilization = ADOprpDL.Dr["CourseShortDescription"].ToString();
                   objprp.branchId = ADOprpDL.Dr["CourseShortname"].ToString();
                   objprp.designationName = ADOprpDL.Dr["ContactPerson"].ToString();
                   objprp.address = ADOprpDL.Dr["CollegeAddress"].ToString();
                   objprp.designationId = ADOprpDL.Dr["Designation"].ToString();
                   objprp.mainLandMark = ADOprpDL.Dr["CollegeWebsite"].ToString();

                   lst.Add(objprp);
               }
           }
           return lst;
       }
       public List<PRPSetupWeb> GetDatalist1(PRPSetupWeb obj)
       {
           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@InstCode", obj.id);
           PRPSetupWeb objprp;
           List<PRPSetupWeb> lst = new List<PRPSetupWeb>();
           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   objprp = new PRPSetupWeb();
                   objprp.description = ADOprpDL.Dr["CrsShortDecription"].ToString();
                   objprp.name = ADOprpDL.Dr["CrsShortName"].ToString();

                   lst.Add(objprp);
               }
           }
           return lst;
       }
       public List<PRPSetupWeb> GetDatalist2(PRPSetupWeb obj)
       {
           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@InstCode", obj.id);
           ADOprpDL.SPName = "srcContactdetailshow";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetupWeb objprp;
           List<PRPSetupWeb> lst = new List<PRPSetupWeb>();
           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   objprp = new PRPSetupWeb();
                   objprp.name = ADOprpDL.Dr["ContactPerson"].ToString();
                   objprp.description = ADOprpDL.Dr["CollegeAddress"].ToString();
                   objprp.designationId = ADOprpDL.Dr["Designation"].ToString();
                   objprp.designationName = ADOprpDL.Dr["CollegeWebsite"].ToString();

                   lst.Add(objprp);
               }
           }
           return lst;
       }
       public string InsCollegeEnqury(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@Queery", objprp.Query);
           ADOprp.SPName = "InsertCollegeEnquiry";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public List<PRPSetupWeb> ViewCollegeStudentInquery(PRPSetupWeb obj)
       {
           ADOprpDL.ArrayPram = new SqlParameter[3];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@collegecod", obj.codeId);
           ADOprpDL.ArrayPram[1] = new SqlParameter("@pageIndex", obj.pageIndex);
           ADOprpDL.ArrayPram[2] = new SqlParameter("@pageSize", obj.pageSize);
          
           ADOprpDL.SPName = "viewStudentInquerybyCollege";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetupWeb objprp;
           List<PRPSetupWeb> lst = new List<PRPSetupWeb>();
           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   objprp = new PRPSetupWeb();                   
                   objprp.id = ADOprpDL.Dr["studentId"].ToString();
                   objprp.name = ADOprpDL.Dr["studentname"].ToString();
                   objprp.emailID = ADOprpDL.Dr["studentEmailId"].ToString();
                   objprp.mobNo = ADOprpDL.Dr["studentMobileNo"].ToString();
                   objprp.city = ADOprpDL.Dr["studentCity"].ToString();
                   objprp.description = ADOprpDL.Dr["studentInquery"].ToString();
                   objprp.codeId = ADOprpDL.Dr["collegeCod"].ToString();
                   objprp.DOJ = ADOprpDL.Dr["date"].ToString();                  
                   lst.Add(objprp);
               }

               if (ADOprpDL.Dr.NextResult())
               {

                   ADOprpDL.Dr.Read();
                   objprp = new PRPSetupWeb();
                   objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                   lst.Add(objprp);
               }
           }
           else
           {
               objprp = new PRPSetupWeb();
               objprp.srNo = "Result Not Find";
               lst.Add(objprp);
           }
           return lst;
       }
  
        
        //9/8/12
       public List<PRPSetupWeb> ViewCompareCollege(PRPSetupWeb obj)
       {
           ADOprpDL.ArrayPram = new SqlParameter[2];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@CollegeId", obj.id);
           ADOprpDL.ArrayPram[1] = new SqlParameter("@CrsScatagoryId", obj.catID);
           ADOprpDL.SPName = "collegeCompare";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetupWeb objprp;
           List<PRPSetupWeb> lst = new List<PRPSetupWeb>();
           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   objprp = new PRPSetupWeb();
                   objprp.designationName = ADOprpDL.Dr["CourseFullName"].ToString();
                   objprp.name = ADOprpDL.Dr["AffiliatedTo"].ToString();
                   objprp.title = ADOprpDL.Dr["CollegeName"].ToString();
                   objprp.urlPath = ADOprpDL.Dr["CollegeImage"].ToString();
                   objprp.description = ADOprpDL.Dr["CourseShortName"].ToString();
                   objprp.examFees = ADOprpDL.Dr["CourseFees"].ToString();
                   objprp.durationMaxTime = ADOprpDL.Dr["CourseDuration"].ToString();
                   objprp.pageIndex = ADOprpDL.Dr["CourseMode"].ToString();
                   objprp.noOfRecord = ADOprpDL.Dr["CourseSeat"].ToString();
                   objprp.DOB = ADOprpDL.Dr["Date"].ToString();
                   lst.Add(objprp);
               }
           }
           return lst;
       }
       ////////////9/21
       public string InslistingPackageDetail(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[12];
           ADOprp.ArrayPram[0] = new SqlParameter("@listingName", objprp.name);
           ADOprp.ArrayPram[1] = new SqlParameter("@listingDuration", objprp.durationMaxTime);
           ADOprp.ArrayPram[2] = new SqlParameter("@listingCharges", objprp.Salary);
           ADOprp.ArrayPram[3] = new SqlParameter("@websitePages", objprp.noOfRecord);
           ADOprp.ArrayPram[4] = new SqlParameter("@websiteImage", objprp.urlId);
           ADOprp.ArrayPram[5] = new SqlParameter("@websiteDownload", objprp.srNo);
           ADOprp.ArrayPram[6] = new SqlParameter("@websiteUpdates", objprp.urlName);
           ADOprp.ArrayPram[7] = new SqlParameter("@websiteAdd", objprp.address);
           ADOprp.ArrayPram[8] = new SqlParameter("@isActvie", objprp.status);
           ADOprp.ArrayPram[9] = new SqlParameter("@listingActivationTime", objprp.courseTime);
           ADOprp.ArrayPram[10] = new SqlParameter("@ListingType", objprp.title);
           ADOprp.ArrayPram[11] = new SqlParameter("@EmailId", objprp.pageIndex);
           ADOprp.SPName = "inslistingPackageDetail";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string updlistingPackageDetail(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[13];
           ADOprp.ArrayPram[0] = new SqlParameter("@listingName", objprp.name);
           ADOprp.ArrayPram[1] = new SqlParameter("@listingDuration", objprp.durationMaxTime);
           ADOprp.ArrayPram[2] = new SqlParameter("@listingCharges", objprp.Salary);
           ADOprp.ArrayPram[3] = new SqlParameter("@websitePages", objprp.noOfRecord);
           ADOprp.ArrayPram[4] = new SqlParameter("@websiteImage", objprp.urlId);
           ADOprp.ArrayPram[5] = new SqlParameter("@websiteDownload", objprp.srNo);
           ADOprp.ArrayPram[6] = new SqlParameter("@websiteUpdates", objprp.urlName);
           ADOprp.ArrayPram[7] = new SqlParameter("@websiteAdd", objprp.address);
           ADOprp.ArrayPram[8] = new SqlParameter("@isActvie", objprp.status);
           ADOprp.ArrayPram[9] = new SqlParameter("@listingActivationTime", objprp.courseTime);
           ADOprp.ArrayPram[10] = new SqlParameter("@ListingType", objprp.title);
           ADOprp.ArrayPram[11] = new SqlParameter("@listingID", objprp.id);
           ADOprp.ArrayPram[12] = new SqlParameter("@EmailId", objprp.pageIndex);
           ADOprp.SPName = "updlistingPackageDetail";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public DataTable ViewlistingPackageDetail(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];

           ADOprp.ArrayPram[0] = new SqlParameter("@LoginType", objprp.semMode);

           ADOprp.SPName = "showlistingPackage";
           return ADO.DataTableWithProceduresAndParam(ADOprp);
       }
       public PRPSetupWeb ViewlistingPackageDetailById(PRPSetupWeb obj)
       {
           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@listingID", obj.id);
           ADOprpDL.SPName = "showlistingPackageById";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetupWeb objprp = new PRPSetupWeb();
           // List<PRPSetupWeb> lst = new List<PRPSetupWeb>();
           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   // objprp = new PRPSetupWeb();

                   objprp.id = ADOprpDL.Dr["listingID"].ToString();
                   objprp.title = ADOprpDL.Dr["listingName"].ToString();
                   objprp.durationMaxTime = ADOprpDL.Dr["listingDuration"].ToString();
                   objprp.Salary = ADOprpDL.Dr["listingCharges"].ToString();
                   objprp.branchId = ADOprpDL.Dr["listingActivationTime"].ToString();
                   objprp.noOfRecord = ADOprpDL.Dr["websitePages"].ToString();

                   objprp.urlId = ADOprpDL.Dr["websiteImage"].ToString();
                   objprp.noOfRecord = ADOprpDL.Dr["websiteDownload"].ToString();
                   objprp.urlPath = ADOprpDL.Dr["websiteUpdates"].ToString();
                   objprp.address = ADOprpDL.Dr["websiteAdd"].ToString();
                   objprp.status = ADOprpDL.Dr["isActvie"].ToString();
                   objprp.AssociateName = ADOprpDL.Dr["PlannType"].ToString();

                   objprp.pageIndex = ADOprpDL.Dr["EmailId"].ToString();
                   // lst.Add(objprp);
               }
           }
           return objprp;
       }
       
        public string dellistingPackageDetail(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@listingID", objprp.id);
           ADOprp.SPName = "dellistingPackageById";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string InsLatesteUpdate(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[4];
           ADOprp.ArrayPram[0] = new SqlParameter("@newsTitle", objprp.title);
           ADOprp.ArrayPram[1] = new SqlParameter("@newsDescription", objprp.description);
           ADOprp.ArrayPram[2] = new SqlParameter("@collegeCod", objprp.codeId);
           ADOprp.ArrayPram[3] = new SqlParameter("@status", objprp.status);
           ADOprp.SPName = "insCollegeNewsDetail";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }

       public List<PRPSetupWeb> ShowlatesteUpdate(PRPSetupWeb objprp)
       {

           ADOprpDL.ArrayPram = new SqlParameter[3];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@collegeCod", objprp.id);
           ADOprpDL.ArrayPram[1] = new SqlParameter("@pageIndex", objprp.pageIndex);
           ADOprpDL.ArrayPram[2] = new SqlParameter("@pageSize", objprp.pageSize);
           
           ADOprpDL.SPName = "showCollegeNewsDetail";

           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetupWeb obj;
           List<PRPSetupWeb> lst = new List<PRPSetupWeb>();
          
           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   obj = new PRPSetupWeb();

                   obj.name = ADOprpDL.Dr["newsTitle"].ToString();
                   obj.id = ADOprpDL.Dr["newsID"].ToString();
                   obj.eligibility = ADOprpDL.Dr["newsDate"].ToString();
                   lst.Add(obj);
               }
               if (ADOprpDL.Dr.NextResult())
               {
                   ADOprpDL.Dr.Read();
                   obj = new PRPSetupWeb();
                   obj.noOfRecord = ADOprpDL.Dr[0].ToString();
                   lst.Add(objprp);
               }
           }
           ADO.ReaderClose(ADOprpDL);
           return lst;
       }
       public String updLatestUpdate(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[3];
           ADOprp.ArrayPram[0] = new SqlParameter("@newsId", objprp.id);
           ADOprp.ArrayPram[1] = new SqlParameter("@newsTitle", objprp.title);
           ADOprp.ArrayPram[2] = new SqlParameter("@newsDescription", objprp.description);
           ADOprp.SPName = "updCollegeNewsDetail";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
      public String delLatestUpdate(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@newsId", objprp.id);
           ADOprp.SPName = "delCollegeNewsDetail";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
      }

      public PRPSetupWeb bindLatestUpdate(PRPSetupWeb objprp)
      {
          ADOprpDL.ArrayPram = new SqlParameter[1];
          ADOprpDL.ArrayPram[0] = new SqlParameter("@newsId", objprp.id);
          ADOprpDL.SPName = "bindCollegeNewsDetail";
          ADO.ReaderWithProceduresandParam(ADOprpDL);
          
          PRPSetupWeb obj = new PRPSetupWeb(); ;

          if (ADOprpDL.Dr.HasRows)
          {
              while (ADOprpDL.Dr.Read())
              {                 
                  obj.name = ADOprpDL.Dr["newsTitle"].ToString();
                  obj.id = ADOprpDL.Dr["newsID"].ToString();
                  obj.eligibility = ADOprpDL.Dr["newsDate"].ToString();
                  obj.description = ADOprpDL.Dr["newsDescription"].ToString();
                  obj.codeId = ADOprpDL.Dr["collegeCod"].ToString();
                  obj.DOB = ADOprpDL.Dr["newsDate"].ToString();                  
              }
          }
          ADO.ReaderClose(ADOprpDL);
          return obj;
      }


       public string CheckDayUpdates(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@collegeCod", objprp.codeId);

           ADOprp.SPName = "checkUpdateDay";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
           //ADOprpDL.ArrayPram = new SqlParameter[1];
           //ADOprpDL.ArrayPram[0] = new SqlParameter("@collegeCod", objprp.codeId);
           //ADOprp.SPName = "checkUpdateDay";
           //return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public DataTable SearchRelatedWord(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];

           ADOprp.ArrayPram[0] = new SqlParameter("@id", objprp.name);

           ADOprp.SPName = "SearchRelated";
           return ADO.DataTableWithProcedures(ADOprp);
       }    
//End Work By Raj

       public List<PRPSetupWeb> ViewSchoolState(PRPSetupWeb obj)
       {
           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@id", obj.id);
           ADOprpDL.SPName = "ViewState2";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetupWeb objprp;
           List<PRPSetupWeb> lst = new List<PRPSetupWeb>();
           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   objprp = new PRPSetupWeb();
                   objprp.id = ADOprpDL.Dr["id"].ToString();
                   objprp.title = ADOprpDL.Dr["name"].ToString();

                   lst.Add(objprp);
               }
           }
           return lst;
       }
       public List<PRPSetupWeb> ShowTastomony()
       {
           ADOprpDL.ArrayPram = new SqlParameter[0];
           ADOprpDL.SPName = "showCollegeNewsDetail";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetupWeb obj;
           List<PRPSetupWeb> lst = new List<PRPSetupWeb>();          
           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   obj = new PRPSetupWeb();
                   obj.name = ADOprpDL.Dr["collegeName"].ToString();
                   obj.id = ADOprpDL.Dr["newsID"].ToString();
                   obj.description = ADOprpDL.Dr["newsDescription"].ToString();
                   lst.Add(obj);
               }
           }
           ADO.ReaderClose(ADOprpDL);
           return lst;
       }

       public DataSet ViewCollegePackage()
       {
           ADOprp.ArrayPram = new SqlParameter[0];

           //  ADOprp.ArrayPram[0] = new SqlParameter("@collegecod", objprp.codeId);

           ADOprp.SPName = "ViewCollegePackage";
           return ADO.DataSetWithProcedures(ADOprp);
       }


       /////11-23
       public string InsViewStatus(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@querry", objprp.address);
           ADOprp.SPName = "InsViewStatus";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public List<PRPSetupWeb> viewTrackStatus(PRPSetupWeb obj)
       {
           ADOprpDL.ArrayPram = new SqlParameter[3];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@collegecod", obj.codeId);
           ADOprpDL.ArrayPram[1] = new SqlParameter("@pageIndex", obj.pageIndex);
           ADOprpDL.ArrayPram[2] = new SqlParameter("@pageSize", obj.pageSize);

           ADOprpDL.SPName = "viewTrackStatus";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetupWeb objprp;
           List<PRPSetupWeb> lst = new List<PRPSetupWeb>();
           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   objprp = new PRPSetupWeb();
                   objprp.id = ADOprpDL.Dr["pip"].ToString();
                   objprp.name = ADOprpDL.Dr["ipName"].ToString();
                   objprp.city = ADOprpDL.Dr["ipCity"].ToString();
                   objprp.state = ADOprpDL.Dr["ipState"].ToString();
                   objprp.DOJ = ADOprpDL.Dr["date"].ToString();
                   objprp.status = ADOprpDL.Dr["viewStatus"].ToString();
                   objprp.codeId = ADOprpDL.Dr["viewCode"].ToString();
                   lst.Add(objprp);
               }

               if (ADOprpDL.Dr.NextResult())
               {

                   ADOprpDL.Dr.Read();
                   objprp = new PRPSetupWeb();
                   objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                   lst.Add(objprp);
               }
           }
           else
           {
               objprp = new PRPSetupWeb();
               objprp.srNo = "Result Not Find";
               lst.Add(objprp);
           }
           return lst;
       }

       public DataSet ViewWebsiteStatus(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[2];

           ADOprp.ArrayPram[0] = new SqlParameter("@loginType", objprp.uniID);
           ADOprp.ArrayPram[1] = new SqlParameter("@collegeCode", objprp.codeId);

           ADOprp.SPName = "viewSearchStatus";
           return ADO.DataSetWithProceduresandParam(ADOprp);
       }

       public string InsCollegePaymentDetail(PRPSetupWeb objprp)
       {

           ADOprp.ArrayPram = new SqlParameter[2];
           ADOprp.ArrayPram[0] = new SqlParameter("@collegeCod", objprp.id);
           ADOprp.ArrayPram[1] = new SqlParameter("@planId", objprp.codeId);
           ADOprp.SPName = "InsCollegePaymentDetail";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }

       public List<PRPSetupWeb> viewCollegePaymentDetail(PRPSetupWeb obj)
       {
           ADOprpDL.ArrayPram = new SqlParameter[3];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@collegecod", obj.codeId);
           ADOprpDL.ArrayPram[1] = new SqlParameter("@pageIndex", obj.pageIndex);
           ADOprpDL.ArrayPram[2] = new SqlParameter("@pageSize", obj.pageSize);

           ADOprpDL.SPName = "viewCollegePaymentDetail";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetupWeb objprp;
           List<PRPSetupWeb> lst = new List<PRPSetupWeb>();
           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   objprp = new PRPSetupWeb();
                   objprp.id = ADOprpDL.Dr["paymentId"].ToString();
                   objprp.codeId = ADOprpDL.Dr["innovoiceNo"].ToString();
                   objprp.catID = ADOprpDL.Dr["collegeCod"].ToString();
                   objprp.uniID = ADOprpDL.Dr["planId"].ToString();
                   objprp.examFees = ADOprpDL.Dr["payment"].ToString();
                   objprp.fatherName = ADOprpDL.Dr["tds"].ToString();
                   objprp.durationMaxTime = ADOprpDL.Dr["lateFee"].ToString();
                   objprp.durationMinTime = ADOprpDL.Dr["TotalPayment"].ToString();
                   objprp.DOJ = ADOprpDL.Dr["createDate"].ToString();
                   objprp.DOB = ADOprpDL.Dr["DueDate"].ToString();
                   objprp.status = ADOprpDL.Dr["isActive"].ToString();                   
                   lst.Add(objprp);
               }

               if (ADOprpDL.Dr.NextResult())
               {

                   ADOprpDL.Dr.Read();
                   objprp = new PRPSetupWeb();
                   objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                   lst.Add(objprp);
               }
           }
           else
           {
               objprp = new PRPSetupWeb();
               objprp.srNo = "Result Not Find";
               lst.Add(objprp);
           }
           return lst;
       }

       public PRPSetupWeb selCollegePaymentDetail(PRPSetupWeb objprp)
       {

           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@innovoiceNo", objprp.id);
           ADOprpDL.SPName = "selCollegePaymentDetail";

           ADO.ReaderWithProceduresandParam(ADOprpDL);

           PRPSetupWeb obj = new PRPSetupWeb(); ;

           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   obj.id = ADOprpDL.Dr["paymentId"].ToString();
                   obj.codeId = ADOprpDL.Dr["innovoiceNo"].ToString();
                   obj.catID = ADOprpDL.Dr["collegeCod"].ToString();
                   obj.uniID = ADOprpDL.Dr["planId"].ToString();
                   obj.examFees = ADOprpDL.Dr["payment"].ToString();
                   obj.fatherName = ADOprpDL.Dr["tds"].ToString();
                   obj.durationMaxTime = ADOprpDL.Dr["lateFee"].ToString();
                   obj.durationMinTime = ADOprpDL.Dr["TotalPayment"].ToString();
                   obj.DOJ = ADOprpDL.Dr["createDate"].ToString();
                   obj.DOB = ADOprpDL.Dr["DueDate"].ToString();
                   obj.status = ADOprpDL.Dr["isActive"].ToString();
                   obj.name = ADOprpDL.Dr["collegeName"].ToString();
                   obj.city = ADOprpDL.Dr["cityName"].ToString();
                   obj.state = ADOprpDL.Dr["stateName"].ToString();
                   obj.pinCode = ADOprpDL.Dr["pinCode"].ToString();
                   obj.address = ADOprpDL.Dr["collegeAddress"].ToString();
                   obj.srNo = ADOprpDL.Dr["cntName"].ToString();
               }
           }
           ADO.ReaderClose(ADOprpDL);
           return obj;
       }

//Start Partner Registration.
       public string InsPartnerLoginDetail(PRPSetupWeb objprp)
       {        
           ADOprp.ArrayPram = new SqlParameter[4];
           ADOprp.ArrayPram[0] = new SqlParameter("@partnerCod", objprp.id);
           ADOprp.ArrayPram[1] = new SqlParameter("@partnerMobileNo", objprp.mobNo);
           ADOprp.ArrayPram[2] = new SqlParameter("@emailID", objprp.emailID);
           ADOprp.ArrayPram[3] = new SqlParameter("@query", objprp.description);
           ADOprp.SPName = "insPartnerLoginDetail";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }

       public string UpdPartnerLoginDetail(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[4];
           ADOprp.ArrayPram[0] = new SqlParameter("@partnerId", objprp.id);
           ADOprp.ArrayPram[1] = new SqlParameter("@loginName", objprp.codeId);
           ADOprp.ArrayPram[2] = new SqlParameter("@password", objprp.Password);
           ADOprp.ArrayPram[3] = new SqlParameter("@isActive", objprp.isActive);
           ADOprp.SPName = "updPartnerLoginDetail";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }

       public List<PRPSetupWeb> viewPartnerLoginDetail(PRPSetupWeb obj)
       {
           ADOprpDL.ArrayPram = new SqlParameter[2];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", obj.pageIndex);
           ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", obj.pageSize);

           ADOprpDL.SPName = "viewPartnerLoginDetail";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetupWeb objprp;
           List<PRPSetupWeb> lst = new List<PRPSetupWeb>();
           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   objprp = new PRPSetupWeb();
                   objprp.id = ADOprpDL.Dr["partnerId"].ToString();
                   objprp.name = ADOprpDL.Dr["collegeName"].ToString();
                   objprp.address = ADOprpDL.Dr["collegeAddress"].ToString();
                   objprp.mobNo = ADOprpDL.Dr["partnerMobileNo"].ToString();
                   objprp.emailID = ADOprpDL.Dr["emailId"].ToString();
                   objprp.description = ADOprpDL.Dr["query"].ToString();
                   objprp.codeId = ADOprpDL.Dr["loginName"].ToString();
                   objprp.Password = ADOprpDL.Dr["password"].ToString();
                   objprp.isActive = ADOprpDL.Dr["isActive"].ToString();                   
                   lst.Add(objprp);
               }

               if (ADOprpDL.Dr.NextResult())
               {

                   ADOprpDL.Dr.Read();
                   objprp = new PRPSetupWeb();
                   objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                   lst.Add(objprp);
               }
           }
           else
           {
               objprp = new PRPSetupWeb();
               objprp.srNo = "Result Not Find";
               lst.Add(objprp);
           }
           return lst;
       }

       public List<PRPSetupWeb> ViewCollegeDetail1(PRPSetupWeb prp)
       {

           ADOprpDL.ArrayPram = new SqlParameter[1];

           ADOprpDL.ArrayPram[0] = new SqlParameter("@loginType", prp.srNo);
           ADOprpDL.SPName = "viewCollegeDetail1";
           ADO.ReaderWithProceduresandParam(ADOprpDL);

           PRPSetupWeb objprp;
           List<PRPSetupWeb> lst = new List<PRPSetupWeb>();

           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   objprp = new PRPSetupWeb();
                   objprp.id = ADOprpDL.Dr["collegeID"].ToString();
                   objprp.name = ADOprpDL.Dr["collegeName"].ToString();     
                   lst.Add(objprp);
               }
               

           }
           else
           {
               objprp = new PRPSetupWeb();
               objprp.srNo = "Result Not Find";
               lst.Add(objprp);
           }
           ADO.ReaderClose(ADOprpDL);
           return lst;
       }
       public List<PRPSetupWeb> viewPartnerbusiness(PRPSetupWeb obj)
       {
           ADOprpDL.ArrayPram = new SqlParameter[3];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@partnerId", obj.codeId);
           ADOprpDL.ArrayPram[1] = new SqlParameter("@pageIndex", obj.pageIndex);
           ADOprpDL.ArrayPram[2] = new SqlParameter("@pageSize", obj.pageSize);

           ADOprpDL.SPName = "viewPartnerbusiness";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetupWeb objprp;
           List<PRPSetupWeb> lst = new List<PRPSetupWeb>();
           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   objprp = new PRPSetupWeb();
                   objprp.id = ADOprpDL.Dr["partnerId"].ToString();
                   objprp.codeId = ADOprpDL.Dr["CollegeCod"].ToString();
                   objprp.Salary = ADOprpDL.Dr["PaymentAmount"].ToString();
                   objprp.DOB = ADOprpDL.Dr["paymentDate"].ToString();
                   objprp.urlName = ADOprpDL.Dr["PaymentType"].ToString();
                   objprp.title = ADOprpDL.Dr["listingName"].ToString();
                   objprp.status = ADOprpDL.Dr["year"].ToString();
                   objprp.name = ADOprpDL.Dr["CollegeName"].ToString();
                   objprp.rank = ADOprpDL.Dr["pType"].ToString();
                   lst.Add(objprp);
               }

           }
           else
           {
               objprp = new PRPSetupWeb();
               objprp.srNo = "Result Not Find";
               lst.Add(objprp);
           }
           return lst;
       }

//End Partner Registration.

// Start Tracing.
       public List<PRPSetupWeb> ShowTracking()
       {
           ADOprpDL.ArrayPram = new SqlParameter[0];
           ADOprpDL.SPName = "ViewTracking";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetupWeb obj;
           List<PRPSetupWeb> lst = new List<PRPSetupWeb>();
           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   obj = new PRPSetupWeb();
                   obj.id = ADOprpDL.Dr["TrackId"].ToString();
                   obj.state = ADOprpDL.Dr["Region"].ToString();
                   obj.city = ADOprpDL.Dr["city"].ToString();
                   obj.name = ADOprpDL.Dr["Viewed"].ToString();
                   obj.urlPath = ADOprpDL.Dr["flage"].ToString();
                   lst.Add(obj);
               }
           }
           ADO.ReaderClose(ADOprpDL);
           return lst;
       }

       //Start Master Enquiry.
       public string InsContactEnquiry(PRPSetupWeb objprp)
       {

           ADOprp.ArrayPram = new SqlParameter[15];

           ADOprp.ArrayPram[0] = new SqlParameter("@Name", objprp.name);
           ADOprp.ArrayPram[1] = new SqlParameter("@EnquiryType", objprp.catID);
           ADOprp.ArrayPram[2] = new SqlParameter("@phone", objprp.mobNo);
           ADOprp.ArrayPram[3] = new SqlParameter("@Email", objprp.emailID);
           ADOprp.ArrayPram[4] = new SqlParameter("@Enquiry", objprp.address);
           ADOprp.ArrayPram[5] = new SqlParameter("@IsActive", "1");
           ADOprp.ArrayPram[6] = new SqlParameter("@stream", objprp.uniID);
           ADOprp.ArrayPram[7] = new SqlParameter("@substream", objprp.urlId);
           ADOprp.ArrayPram[8] = new SqlParameter("@qualification", objprp.Query);
           ADOprp.ArrayPram[9] = new SqlParameter("@state", objprp.state);
           ADOprp.ArrayPram[10] = new SqlParameter("@plan", objprp.district);
           ADOprp.ArrayPram[11] = new SqlParameter("@minBudget", objprp.durationMinTime);
           ADOprp.ArrayPram[12] = new SqlParameter("@maxBudget", objprp.durationMaxTime);
           ADOprp.ArrayPram[13] = new SqlParameter("@collegeId", objprp.id);
           ADOprp.ArrayPram[14] = new SqlParameter("@expectedyear", objprp.city);

           ADOprp.SPName = "InsContactEnquiry";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);

       }
       public List<PRPSetupWeb> ViewContactEnquiry(PRPSetupWeb prp)
       {
           ADOprpDL.ArrayPram = new SqlParameter[3];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
           ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
           ADOprpDL.ArrayPram[2] = new SqlParameter("@status", prp.status);
           ADOprpDL.SPName = "ViewContactEnquiry";
           ADO.ReaderWithProceduresandParam(ADOprpDL);

           PRPSetupWeb objprp;
           List<PRPSetupWeb> lst = new List<PRPSetupWeb>();

           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   objprp = new PRPSetupWeb();
                   objprp.id = ADOprpDL.Dr["id"].ToString();
                   objprp.name = ADOprpDL.Dr["Name"].ToString();
                   objprp.mobNo = ADOprpDL.Dr["phone"].ToString();
                   objprp.description = ADOprpDL.Dr["Enquiry"].ToString();
                   objprp.status = ADOprpDL.Dr["EnquiryType"].ToString();
                   objprp.emailID = ADOprpDL.Dr["Email"].ToString();
                   objprp.DOB = ADOprpDL.Dr["EnquiryDate"].ToString();
                   objprp.uniID = ADOprpDL.Dr["stream"].ToString();
                   objprp.urlId = ADOprpDL.Dr["substream"].ToString();
                   objprp.Query = ADOprpDL.Dr["qualification"].ToString();
                   objprp.state = ADOprpDL.Dr["state"].ToString();
                   objprp.district = ADOprpDL.Dr["yourPlan"].ToString();
                   objprp.durationMinTime = ADOprpDL.Dr["minBudget"].ToString();
                   objprp.durationMaxTime = ADOprpDL.Dr["maxBudget"].ToString();
                   objprp.id = ADOprpDL.Dr["collegeId"].ToString();
                   objprp.city = ADOprpDL.Dr["expectedyear"].ToString();                   
                   lst.Add(objprp);
               }
               if (ADOprpDL.Dr.NextResult())
               {

                   ADOprpDL.Dr.Read();
                   objprp = new PRPSetupWeb();
                   objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                   lst.Add(objprp);
               }


           }
           else
           {
               objprp = new PRPSetupWeb();
               objprp.srNo = "Result Not Find";
               lst.Add(objprp);
           }
           ADO.ReaderClose(ADOprpDL);
           return lst;

       }
       public string DelContactEnquiry(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@id", objprp.id);
           ADOprp.SPName = "DelContactEnquiry";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       //End Master Enquiry.    

//Start Job Post.
       public string InsForJObApply(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[8];

           ADOprp.ArrayPram[0] = new SqlParameter("@ApplerName", objprp.name);
           ADOprp.ArrayPram[1] = new SqlParameter("@Qualification", objprp.catID);
           ADOprp.ArrayPram[2] = new SqlParameter("@PhoneNumber", objprp.mobNo);
           ADOprp.ArrayPram[3] = new SqlParameter("@EmailId", objprp.emailID);
           ADOprp.ArrayPram[4] = new SqlParameter("@AboutSelf", objprp.address);
           ADOprp.ArrayPram[5] = new SqlParameter("@ApplyJobId", objprp.uniID);
           ADOprp.ArrayPram[6] = new SqlParameter("@city", objprp.city);
           ADOprp.ArrayPram[7] = new SqlParameter("@ApplyResume", objprp.urlPath);
           ADOprp.SPName = "InsApplyForJob";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);

       }
       public List<PRPSetupWeb> ViewForJObApply(PRPSetupWeb prp)
       {

           ADOprpDL.ArrayPram = new SqlParameter[2];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
           ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
           ADOprpDL.SPName = "ViewApplyForJob";
           ADO.ReaderWithProceduresandParam(ADOprpDL);

           PRPSetupWeb objprp;
           List<PRPSetupWeb> lst = new List<PRPSetupWeb>();

           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   objprp = new PRPSetupWeb();
                   objprp.id = ADOprpDL.Dr["ApplyId"].ToString();
                   objprp.name = ADOprpDL.Dr["ApplerName"].ToString();
                   objprp.description = ADOprpDL.Dr["AboutSelf"].ToString();
                   objprp.DOB = ADOprpDL.Dr["ApplyDate"].ToString();
                   objprp.catID = ADOprpDL.Dr["ApplyJobId"].ToString();
                   objprp.mobNo = ADOprpDL.Dr["PhoneNumber"].ToString();
                   objprp.urlPath = ADOprpDL.Dr["ApplyResume"].ToString();
                   objprp.city = ADOprpDL.Dr["city"].ToString();

                   objprp.emailID = ADOprpDL.Dr["EmailId"].ToString();
                   objprp.address = ADOprpDL.Dr["Qualification"].ToString();
                   objprp.status = ADOprpDL.Dr["Remark"].ToString();

                   lst.Add(objprp);
               }
               if (ADOprpDL.Dr.NextResult())
               {

                   ADOprpDL.Dr.Read();
                   objprp = new PRPSetupWeb();
                   objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                   lst.Add(objprp);
               }


           }
           else
           {
               objprp = new PRPSetupWeb();
               objprp.srNo = "Result Not Find";
               lst.Add(objprp);
           }
           ADO.ReaderClose(ADOprpDL);
           return lst;

       }
       public string DelForJObApply(PRPSetupWeb prp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];

           ADOprp.ArrayPram[0] = new SqlParameter("@id", prp.id);

           ADOprp.SPName = "DelApplyForJob";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string RemarkForJObApply(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[2];
           ADOprp.ArrayPram[0] = new SqlParameter("@id", objprp.id);
           ADOprp.ArrayPram[1] = new SqlParameter("@Remark", objprp.description);
           ADOprp.SPName = "RemarkForJObApply";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
//End Job Post.

//--Start Mail Id

       public string CheckMailStatus(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@CollegeCod", objprp.codeId);
           ADOprp.SPName = "CheckMail";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string InsCollegemailDetail(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[3];
           ADOprp.ArrayPram[0] = new SqlParameter("@CollegeCod", objprp.codeId);
           ADOprp.ArrayPram[1] = new SqlParameter("@Collegemail", objprp.emailID);
           ADOprp.ArrayPram[2] = new SqlParameter("@CollegePassword", objprp.Password);
           ADOprp.SPName = "InsCollegemailDetail";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }

       public List<PRPSetupWeb> viewMailDetail(PRPSetupWeb prp)
       {
           ADOprpDL.ArrayPram = new SqlParameter[4];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
           ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
           ADOprpDL.ArrayPram[2] = new SqlParameter("@collegeCod", prp.codeId);
           ADOprpDL.ArrayPram[3] = new SqlParameter("@isActive", prp.isActive);

            ADOprpDL.SPName = "viewMailDetail";
           ADO.ReaderWithProceduresandParam(ADOprpDL);

           PRPSetupWeb objprp;
           List<PRPSetupWeb> lst = new List<PRPSetupWeb>();

           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   objprp = new PRPSetupWeb();
                   objprp.id = ADOprpDL.Dr["row"].ToString();
                   objprp.mailId = ADOprpDL.Dr["collegemailId"].ToString();
                   objprp.emailID = ADOprpDL.Dr["collegeMail"].ToString();
                   objprp.Password = ADOprpDL.Dr["CollegePassword"].ToString();
                   objprp.DOJ = ADOprpDL.Dr["requestDate"].ToString();
                   objprp.DOB = ADOprpDL.Dr["approvalDate"].ToString();
                   objprp.isActive = ADOprpDL.Dr["isActive"].ToString();
                   objprp.codeId = ADOprpDL.Dr["CollegeCod"].ToString();
                   objprp.name = ADOprpDL.Dr["collegeName"].ToString();
                   objprp.status = ADOprpDL.Dr["a1"].ToString();

                   lst.Add(objprp);
               }
               if (ADOprpDL.Dr.NextResult())
               {

                   ADOprpDL.Dr.Read();
                   objprp = new PRPSetupWeb();
                   objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                   lst.Add(objprp);
               }


           }
           else
           {
               objprp = new PRPSetupWeb();
               objprp.srNo = "Result Not Find";
               lst.Add(objprp);
           }
           ADO.ReaderClose(ADOprpDL);
           return lst;

       }

       public string updCollegemailDetail(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@mailId", objprp.id);
           ADOprp.SPName = "updCollegemailDetail";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }



       public PRPSetupWeb crsViewbySelectMainCategorybyName(PRPSetupWeb objprp)
       {

           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@CatName", objprp.name);
           ADOprpDL.SPName = "crsViewbySelectMainCategorybyName";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetupWeb obj = new PRPSetupWeb(); ;

           if (ADOprpDL.Dr.HasRows)
           {

               while (ADOprpDL.Dr.Read())
               {
                   obj.id = ADOprpDL.Dr["id"].ToString();
                   obj.name = ADOprpDL.Dr["name"].ToString();
                   obj.isActive = ADOprpDL.Dr["categoryType"].ToString();
                   obj.title = ADOprpDL.Dr["Title"].ToString();
                   obj.description = ADOprpDL.Dr["Description"].ToString();
                   obj.urlPath = ADOprpDL.Dr["ImagePath"].ToString();
               }
           }
           ADO.ReaderClose(ADOprpDL);
           return obj;
       }

//--End Mail Id

       //Start Sub Course Catagory
       public string InscrsCourse(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[5];
           ADOprp.ArrayPram[0] = new SqlParameter("@sCatName", objprp.name);
           ADOprp.ArrayPram[1] = new SqlParameter("@Title", objprp.title);
           ADOprp.ArrayPram[2] = new SqlParameter("@Description", objprp.description);
           ADOprp.ArrayPram[3] = new SqlParameter("@ImagePath", objprp.urlPath);
           ADOprp.ArrayPram[4] = new SqlParameter("@subCateId", objprp.catID);
           ADOprp.SPName = "crsInsCourse";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string UpdcrsCourse(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[6];

           ADOprp.ArrayPram[0] = new SqlParameter("@sCatId", objprp.id);
           ADOprp.ArrayPram[1] = new SqlParameter("@sCatName", objprp.name);
           ADOprp.ArrayPram[2] = new SqlParameter("@Title", objprp.title);
           ADOprp.ArrayPram[3] = new SqlParameter("@Description", objprp.description);
           ADOprp.ArrayPram[4] = new SqlParameter("@ImagePath", objprp.urlPath);

           ADOprp.ArrayPram[5] = new SqlParameter("@sMainCatId", objprp.catID);
           // ADOprp.ArrayPram[3] = new SqlParameter("@isActive", objprp.isActive);
           ADOprp.SPName = "crsUpdCourse";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string DelcrsCourse(PRPSetupWeb objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@sCatId", objprp.id);
           ADOprp.SPName = "crsDelCourse";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);



       }
       public PRPSetupWeb SelcrsCategory(PRPSetupWeb objprp)
       {

           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@sCatId", objprp.id);
           ADOprpDL.SPName = "crsSelCourse";

           ADO.ReaderWithProceduresandParam(ADOprpDL);

           PRPSetupWeb obj = new PRPSetupWeb();

           if (ADOprpDL.Dr.HasRows)
           {

               while (ADOprpDL.Dr.Read())
               {
                   obj.id = ADOprpDL.Dr["id"].ToString();
                   obj.name = ADOprpDL.Dr["name"].ToString();
                   obj.title = ADOprpDL.Dr["Title"].ToString();
                   obj.uniID = ADOprpDL.Dr["courseSubId"].ToString();
                   obj.description = ADOprpDL.Dr["Description"].ToString();
                   obj.urlPath = ADOprpDL.Dr["ImagePath"].ToString();
               }
           }
           ADO.ReaderClose(ADOprpDL);
           return obj;
       }
        //End Sub Course Catagory

    }
    

    
}