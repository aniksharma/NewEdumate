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
namespace nmsSetupTick
{
    public class clsDLSetupTick
    {
        //--------------------------------------------------------
        clsBLado ADO = new clsBLado();
        clsPRPadoBL ADOprp = new clsPRPadoBL();
        clsPRPadoDL ADOprpDL = new clsPRPadoDL();
       //------------------------------------------------
        clsprpADO objadoprp = new clsprpADO();
        clsADO objado = new clsADO();

//--start--University-------------------
        public string InsertUniversity(PRPSetupTick objprp)
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
        public string UpdateUniversity(PRPSetupTick objprp)
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
        public string DeleteUniversity(PRPSetupTick objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@universityCodeId", objprp.codeId);
            ADOprp.SPName = "deleteUniversity";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public PRPSetupTick SelectUniversity(PRPSetupTick objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@universityCodeId", objprp.codeId);
            ADOprpDL.SPName = "SelectUniversity";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupTick obj = new PRPSetupTick(); ;

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
        public List<PRPSetupTick> ViewUniversity(PRPSetupTick prp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.SPName = "viewUniversity";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupTick objprp;
            List<PRPSetupTick> lst = new List<PRPSetupTick>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetupTick();
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
                    objprp = new PRPSetupTick();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPSetupTick();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
//--End----university-----------------------

//--Start Enquiry form-------------------
        //public string InsertEnquiry(PRPSetupTick objprp)
        //{
        //    ADOprp.ArrayPram = new SqlParameter[8];

        //    ADOprp.ArrayPram[0] = new SqlParameter("@stname", objprp.staname);
        //    ADOprp.ArrayPram[1] = new SqlParameter("@stafather", objprp.stafather);
        //    ADOprp.ArrayPram[2] = new SqlParameter("@stadob", objprp.stadob);
        //    ADOprp.ArrayPram[3] = new SqlParameter("@stacourse", objprp.stacourse);
        //    ADOprp.ArrayPram[4] = new SqlParameter("@stamob", objprp.stamob);
        //    ADOprp.ArrayPram[5] = new SqlParameter("@staactive", objprp.staActive);

        //    ADOprp.ArrayPram[6] = new SqlParameter("@staemail", objprp.staemail);
        //    ADOprp.ArrayPram[7] = new SqlParameter("@staadres", objprp.staAdres);


        //    ADOprp.SPName = "spinsEnquiry";

        //    return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        //}
        //public string UpdateEnquiry(PRPSetupTick objprp)
        //{
        //    ADOprp.ArrayPram = new SqlParameter[9];

        //    ADOprp.ArrayPram[0] = new SqlParameter("@stname", objprp.staname);
        //    ADOprp.ArrayPram[1] = new SqlParameter("@stafather", objprp.stafather);
        //    ADOprp.ArrayPram[2] = new SqlParameter("@stadob", objprp.stadob);
        //    ADOprp.ArrayPram[3] = new SqlParameter("@stacourse", objprp.stacourse);
        //    ADOprp.ArrayPram[4] = new SqlParameter("@stamob", objprp.stamob);
        //    ADOprp.ArrayPram[5] = new SqlParameter("@staactive", objprp.staActive);

        //    ADOprp.ArrayPram[6] = new SqlParameter("@staemail", objprp.staemail);
        //    ADOprp.ArrayPram[7] = new SqlParameter("@staadres", objprp.staAdres);
        //    ADOprp.ArrayPram[8] = new SqlParameter("@staMarkstatus", objprp.staMarkstatus);

        //    ADOprp.SPName = "spinsEnquiry";

        //    return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        //}
        //public List<PRPSetupTick> viewEnquiry(PRPSetupTick prp)
        //{

        //    ADOprpDL.ArrayPram = new SqlParameter[2];
        //    ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
        //    ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
        //    ADOprpDL.SPName = "spviewEnquiry";
        //    ADO.ReaderWithProceduresandParam(ADOprpDL);

        //    PRPSetupTick objprp;
        //    List<PRPSetupTick> lst = new List<PRPSetupTick>();

        //    if (ADOprpDL.Dr.HasRows)
        //    {
        //        while (ADOprpDL.Dr.Read())
        //        {
        //            objprp = new PRPSetupTick();
        //            objprp.staid = ADOprpDL.Dr["staid"].ToString();
        //            objprp.staname = ADOprpDL.Dr["stname"].ToString();
        //            objprp.stafather = ADOprpDL.Dr["stafather"].ToString();
        //            objprp.stadob = ADOprpDL.Dr["stadob"].ToString();
        //            objprp.stacourse = ADOprpDL.Dr["stacourse"].ToString();
        //            objprp.stamob = ADOprpDL.Dr["stamob"].ToString();
        //            objprp.stacourse = ADOprpDL.Dr["stacourse"].ToString();
        //            objprp.staActive = ADOprpDL.Dr["staActive"].ToString();
        //            objprp.staemail = ADOprpDL.Dr["staemail"].ToString();
        //            objprp.staAdres = ADOprpDL.Dr["staAdres"].ToString();
        //            objprp.staMarkstatus = ADOprpDL.Dr["staMarkstatus"].ToString();

        //            lst.Add(objprp);
        //        }
        //        if (ADOprpDL.Dr.NextResult())
        //        {

        //            ADOprpDL.Dr.Read();
        //            objprp = new PRPSetupTick();
        //            objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
        //            lst.Add(objprp);
        //        }


        //    }
        //    else
        //    {
        //        objprp = new PRPSetupTick();
        //        objprp.srNo = "Result Not Find";
        //        lst.Add(objprp);
        //    }
        //    ADO.ReaderClose(ADOprpDL);
        //    return lst;

        //}
//----End Enquiry form----------------


//--Start Web University--------------------
        public string InsertUniversityWeb(PRPSetupTick objprp)
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
        public string UpdateUniversityWeb(PRPSetupTick objprp)
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
        public string DeleteUniversityWeb(PRPSetupTick objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@universityCodeId", objprp.codeId);
            ADOprp.SPName = "deleteUniversityWeb";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public PRPSetupTick SelectUniversityWeb(PRPSetupTick objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@universityCodeId", objprp.codeId);
            ADOprpDL.SPName = "SelectUniversityWeb";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupTick obj = new PRPSetupTick(); ;

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
        public List<PRPSetupTick> ViewUniversityWeb(PRPSetupTick prp)
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

            PRPSetupTick objprp;
            List<PRPSetupTick> lst = new List<PRPSetupTick>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetupTick();
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
                    objprp = new PRPSetupTick();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
               }

            }
            else
            {
                objprp = new PRPSetupTick();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;
        }
        public List<PRPSetupTick> ViewUniversityType( PRPSetupTick obj1 )
        {
            objadoprp.Cmd = new SqlCommand();
            objadoprp.Cmd.CommandText = obj1.name;
            objadoprp.Cmd.CommandType = CommandType.StoredProcedure;
            objado.ReaderQuery(objadoprp);

            PRPSetupTick objprp;
            List<PRPSetupTick> lst = new List<PRPSetupTick>();

            //  List<clsPRPView> list = new List<clsPRPView>();
            //            clsPRPView obj;
            PRPSetupTick obj;

            if (objadoprp.ReturnMsg == "success")
            {
                if (objadoprp.Dr.HasRows)
                {
                    while (objadoprp.Dr.Read())
                    {

                        obj = new PRPSetupTick();
                        obj.id = objadoprp.Dr["Id"].ToString();
                        obj.name = objadoprp.Dr["name"].ToString();
                        lst.Add(obj);
                    }
                }
                else
                {
                    obj = new PRPSetupTick();
                    obj.srNo = "Result Not Find";
                    lst.Add(obj);
                }
                objado.ReaderClose(objadoprp);
            }
            else
            {
                obj = new PRPSetupTick();
                obj.srNo = "Result Not Find";
                lst.Add(obj);
            }
            return lst;
        }
//--End Web University-----------------------

//--Start Web University--------------------
        public string InsertCollegeDetail(PRPSetupTick objprp)
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
        public string UpdateCollegeDetail(PRPSetupTick objprp)
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
        public string DeleteCollegeDetail(PRPSetupTick objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@collegeCodeId", objprp.codeId);
            ADOprp.SPName = "deleteCollegeDetail";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public PRPSetupTick SelectCollegeDetail(PRPSetupTick objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@collegeCodeId", objprp.codeId);
            ADOprpDL.SPName = "SelectCollegeDetail";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupTick obj = new PRPSetupTick(); ;

            if (ADOprpDL.Dr.HasRows)
            {

                while (ADOprpDL.Dr.Read())
                {
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
        public List<PRPSetupTick> ViewCollegeDetail(PRPSetupTick prp)
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

            PRPSetupTick objprp;
            List<PRPSetupTick> lst = new List<PRPSetupTick>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetupTick();
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
                    objprp = new PRPSetupTick();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }

            }
            else
            {
                objprp = new PRPSetupTick();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;
        }
        public List<PRPSetupTick> ViewCollegeType( PRPSetupTick obj1 )
        {
            objadoprp.Cmd = new SqlCommand();
            objadoprp.Cmd.CommandText = obj1.name;
            objadoprp.Cmd.CommandType = CommandType.StoredProcedure;
            objado.ReaderQuery(objadoprp);

            PRPSetupTick objprp;
            List<PRPSetupTick> lst = new List<PRPSetupTick>();

            //  List<clsPRPView> list = new List<clsPRPView>();
            //            clsPRPView obj;
            PRPSetupTick obj;

            if (objadoprp.ReturnMsg == "success")
            {
                if (objadoprp.Dr.HasRows)
                {
                    while (objadoprp.Dr.Read())
                    {

                        obj = new PRPSetupTick();
                        obj.id = objadoprp.Dr["Id"].ToString();
                        obj.name = objadoprp.Dr["name"].ToString();
                        lst.Add(obj);
                    }
                }
                else
                {
                    obj = new PRPSetupTick();
                    obj.srNo = "Result Not Find";
                    lst.Add(obj);
                }
                objado.ReaderClose(objadoprp);
            }
            else
            {
                obj = new PRPSetupTick();
                obj.srNo = "Result Not Find";
                lst.Add(obj);
            }
            return lst;
        }
        public List<PRPSetupTick> ViewCollegeType1(PRPSetupTick prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@Id", prp.id);
            ADOprpDL.SPName = "viewCollegeType1";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupTick objprp;
            List<PRPSetupTick> lst = new List<PRPSetupTick>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetupTick();
                    objprp.id = ADOprpDL.Dr["Id"].ToString();
                    objprp.name = ADOprpDL.Dr["Name"].ToString();
                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetupTick();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }

            }
            else
            {
                objprp = new PRPSetupTick();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;
        }
        //--End Web University-----------------------
//---Start---Setup Course Category-----------------  
        public string InsCourseCategory(PRPSetupTick objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[3];
            ADOprp.ArrayPram[0] = new SqlParameter("@catName", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@uniID", objprp.uniID);
            ADOprp.ArrayPram[2] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.SPName = "insCourseCategory";            
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string UpdCourseCategory(PRPSetupTick objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[4];

            ADOprp.ArrayPram[0] = new SqlParameter("@catID", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@catName", objprp.name);
            ADOprp.ArrayPram[2] = new SqlParameter("@uniID", objprp.uniID);
            ADOprp.ArrayPram[3] = new SqlParameter("@isActive", objprp.isActive);

            ADOprp.SPName = "updCourseCategory";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }
        public string DelCourseCategory(PRPSetupTick objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@catID", objprp.id);
            ADOprp.SPName = "delCourseCategory";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);



        }
        public PRPSetupTick SelCourseCategory(PRPSetupTick objprp)
        {
            
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@catID", objprp.id);
            ADOprpDL.SPName = "selCourseCategory";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupTick obj = new PRPSetupTick(); ;

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
        public DataTable ViewCourseCategory( PRPSetupTick objprp )
        {
            ADOprp.ArrayPram = new SqlParameter[1];

            ADOprp.ArrayPram[0] = new SqlParameter("@status", objprp.status);

            ADOprp.SPName = "ViewCourseCategory";
            return ADO.DataTableWithProcedures(ADOprp);           
        }    
//--End Setup Course Category----.

//--start--Course Detail Web---------      
        public string InsertCourseWeb(PRPSetupTick objprp)
        {            
            ADOprp.ArrayPram = new SqlParameter[14];
            ADOprp.ArrayPram[0] = new SqlParameter("@courseName", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@courseCode", objprp.branchCodeName);
            ADOprp.ArrayPram[2] = new SqlParameter("@courseSpecilization", objprp.specilization);
            ADOprp.ArrayPram[3] = new SqlParameter("@durationMinTime", objprp.durationMinTime);
            ADOprp.ArrayPram[4] = new SqlParameter("@durationMaxTime", objprp.durationMaxTime);
            ADOprp.ArrayPram[5] = new SqlParameter("@courseEligibility", objprp.eligibility);
            //ADOprp.ArrayPram[6] = new SqlParameter("@pv", objprp.pv);
            ADOprp.ArrayPram[6] = new SqlParameter("@courseFees", objprp.courseFees);
            ADOprp.ArrayPram[7] = new SqlParameter("@examFees", objprp.examFees);
            ADOprp.ArrayPram[8] = new SqlParameter("@otherFees", objprp.otherFees);
            ADOprp.ArrayPram[9] = new SqlParameter("@regFees", objprp.regFees);
          //  ADOprp.ArrayPram[11] = new SqlParameter("@courseUniID", objprp.uniID);
            ADOprp.ArrayPram[10] = new SqlParameter("@courseCatID", objprp.catID);
            ADOprp.ArrayPram[11] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.ArrayPram[12] = new SqlParameter("@courseTime", objprp.courseTime);
            ADOprp.ArrayPram[13] = new SqlParameter("@semMode", objprp.semMode);
            ADOprp.SPName = "insCourseWeb";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }
        public string UpdateCourse(PRPSetupTick objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[15];
            ADOprp.ArrayPram[0] = new SqlParameter("@courseID", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@courseName", objprp.name);
            ADOprp.ArrayPram[2] = new SqlParameter("@courseCode", objprp.branchCodeName);
            ADOprp.ArrayPram[3] = new SqlParameter("@courseSpecilization", objprp.specilization);
            ADOprp.ArrayPram[4] = new SqlParameter("@durationMinTime", objprp.durationMinTime);
            ADOprp.ArrayPram[5] = new SqlParameter("@durationMaxTime", objprp.durationMaxTime);
            ADOprp.ArrayPram[6] = new SqlParameter("@courseEligibility", objprp.eligibility);
            //ADOprp.ArrayPram[7] = new SqlParameter("@pv", objprp.pv);
            ADOprp.ArrayPram[7] = new SqlParameter("@courseFees", objprp.courseFees);
            ADOprp.ArrayPram[8] = new SqlParameter("@examFees", objprp.examFees);
            ADOprp.ArrayPram[9] = new SqlParameter("@otherFees", objprp.otherFees);
            ADOprp.ArrayPram[10] = new SqlParameter("@regFees", objprp.regFees);
           // ADOprp.ArrayPram[12] = new SqlParameter("@courseUniID", objprp.uniID);
            ADOprp.ArrayPram[11] = new SqlParameter("@courseCatID", objprp.catID);
            ADOprp.ArrayPram[12] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.ArrayPram[13] = new SqlParameter("@courseTime", objprp.courseTime);
            ADOprp.ArrayPram[14] = new SqlParameter("@semMode", objprp.semMode);
            ADOprp.SPName = "updCourseWeb";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string DeleteCourse(PRPSetupTick objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@CourseID", objprp.id);
            ADOprp.SPName = "delCourseWeb";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);



        }
        public PRPSetupTick SelectCourse(PRPSetupTick objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@CourseID", objprp.id);
            ADOprpDL.SPName = "selCourseWeb";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupTick obj = new PRPSetupTick(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj=new PRPSetupTick();
                    obj.id=ADOprpDL.Dr["courseId"].ToString();
                    obj.name= ADOprpDL.Dr["courseName"].ToString();
                    obj.branchCodeName=ADOprpDL.Dr["courseCode"].ToString();
                    obj.specilization= ADOprpDL.Dr["courseSpecilization"].ToString();
                    obj.durationMinTime= ADOprpDL.Dr["durationMinTime"].ToString();
                    obj.durationMaxTime= ADOprpDL.Dr["durationMaxTime"].ToString();
                    obj.eligibility= ADOprpDL.Dr["courseEligibility"].ToString();
                   // obj.pv= ADOprpDL.Dr["pv"].ToString();
                    obj.courseFees= ADOprpDL.Dr["courseFees"].ToString();
                    obj.examFees= ADOprpDL.Dr["examFees"].ToString();
                    obj.otherFees=ADOprpDL.Dr["otherFees"].ToString();
                    obj.regFees=  ADOprpDL.Dr["regFees"].ToString();
                    //obj.uniID= ADOprpDL.Dr["courseUniID"].ToString();
                    obj.catID=ADOprpDL.Dr["courseCatID"].ToString();
                    obj.isActive = ADOprpDL.Dr["isActive"].ToString();
                    obj.courseTime = ADOprpDL.Dr["courseTime"].ToString();
                    obj.semMode = ADOprpDL.Dr["semMode"].ToString();                    
                }
            }
            ADO.ReaderClose(ADOprpDL);
            return obj;
        }
        public List<PRPSetupTick> ViewCourseWeb(PRPSetupTick prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[4];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            //ADOprpDL.ArrayPram[2] = new SqlParameter("@courseUniID", prp.uniID);
            ADOprpDL.ArrayPram[2] = new SqlParameter("@courseCatID", prp.catID);
            ADOprpDL.ArrayPram[3] = new SqlParameter("@status", prp.status);
            ADOprpDL.SPName = "viewCourseWeb";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupTick objprp;
            List<PRPSetupTick> lst = new List<PRPSetupTick>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetupTick();
                    objprp.id = ADOprpDL.Dr["courseId"].ToString();
                    objprp.name = ADOprpDL.Dr["courseName"].ToString();
                    objprp.branchCodeName = ADOprpDL.Dr["courseCode"].ToString();
                    objprp.specilization = ADOprpDL.Dr["courseSpecilization"].ToString();
                    objprp.durationMinTime = ADOprpDL.Dr["durationMinTime"].ToString();
                    objprp.durationMaxTime = ADOprpDL.Dr["durationMaxTime"].ToString();
                    objprp.eligibility = ADOprpDL.Dr["courseEligibility"].ToString();
                    //objprp.pv = ADOprpDL.Dr["pv"].ToString();
                    objprp.courseFees = ADOprpDL.Dr["courseFees"].ToString();
                    objprp.examFees = ADOprpDL.Dr["examFees"].ToString();
                    objprp.otherFees = ADOprpDL.Dr["otherFees"].ToString();
                    objprp.regFees = ADOprpDL.Dr["regFees"].ToString();
                   // objprp.uniID = ADOprpDL.Dr["courseUniID"].ToString();
                    objprp.catID = ADOprpDL.Dr["courseCatID"].ToString();
                    objprp.isActive = ADOprpDL.Dr["isActive"].ToString();
                    objprp.courseTime = ADOprpDL.Dr["courseTime"].ToString();
                    objprp.semMode = ADOprpDL.Dr["semMode"].ToString();
                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetupTick();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPSetupTick();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
        //--End--Course Detail Web-----------
        //News For
        public string InsNewsFor(PRPSetupTick objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[2];
            ADOprp.ArrayPram[0] = new SqlParameter("@NewName", objprp.name);
            //ADOprp.ArrayPram[1] = new SqlParameter("@uniID", objprp.uniID);
            ADOprp.ArrayPram[1] = new SqlParameter("@isActive ", objprp.isActive);
            ADOprp.SPName = "SpInsertNewsFor";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string UpdNewsFor(PRPSetupTick objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[3];

            ADOprp.ArrayPram[0] = new SqlParameter("@ForId", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@NewName", objprp.name);
            //ADOprp.ArrayPram[1] = new SqlParameter("@uniID", objprp.uniID);
            ADOprp.ArrayPram[2] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.SPName = "spUpdateNewsFor";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string DelNewsFor(PRPSetupTick objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@ForId", objprp.id);
            ADOprp.SPName = "SpDeleteNewsFor";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);



        }
        public PRPSetupTick SelNewsFor(PRPSetupTick objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@ForId", objprp.id);
            ADOprpDL.SPName = "SpSelectByIdNewsFor";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupTick obj = new PRPSetupTick(); ;

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
        public string InsNewsType(PRPSetupTick objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[3];
            ADOprp.ArrayPram[0] = new SqlParameter("@typeName", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@uniID", objprp.uniID);
            ADOprp.ArrayPram[2] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.SPName = "insNewsType";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string UpdNewsType(PRPSetupTick objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[4];

            ADOprp.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@typeName", objprp.name);
            ADOprp.ArrayPram[2] = new SqlParameter("@uniID", objprp.uniID);
            ADOprp.ArrayPram[3] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.SPName = "updNewsType";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);            
        }
        public string DelNewsType(PRPSetupTick objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
            ADOprp.SPName = "delNewsType";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);



        }
        public PRPSetupTick SelNewsType(PRPSetupTick objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
            ADOprpDL.SPName = "selNewsType";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupTick obj = new PRPSetupTick(); 

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
        //public DataTable ViewNewsType(PRPSetupTick objprp)
        //{
        //    ADOprp.ArrayPram = new SqlParameter[1];

        //    ADOprp.ArrayPram[0] = new SqlParameter("@status", objprp.status);

        //    ADOprp.SPName = "viewNewsType";

        //    return ADO.DataTableWithProcedures(ADOprp);

        //}    
//--End--News Type
        //Show In Branch Start
        public List<PRPSetupTick> BindBranchForCheck(PRPSetupTick prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[0];
            //ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
           // ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
           // PRPSetupTick prp=new PRPSetupTick ();
            if (prp.id == "2")
            {
                ADOprpDL.SPName = "spViewBranch";
            }
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupTick objprp;
            List<PRPSetupTick> lst = new List<PRPSetupTick>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetupTick();
                    objprp.id = ADOprpDL.Dr["branchCodeId"].ToString();
                    objprp.title = ADOprpDL.Dr["branchName"].ToString();
                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetupTick();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            //else
            //{
            //    objprp = new PRPSetupTick();
            //    objprp.srNo = "Result Not Find";
            //    lst.Add(objprp);
            //}
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
        public string InsertShowInBranch(PRPSetupTick objprp)
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
        public List<PRPSetupTick> CheckUniByBranch(PRPSetupTick prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@CourseId", prp.id);
            // ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            // PRPSetupTick prp=new PRPSetupTick ();

            ADOprpDL.SPName = "SpdetailwebtypeById";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupTick objprp;
            List<PRPSetupTick> lst = new List<PRPSetupTick>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetupTick();
                    objprp.id = ADOprpDL.Dr["CourseTypeId"].ToString();
                    objprp.courseFees = ADOprpDL.Dr["CourseId"].ToString();
                    objprp.branchId = ADOprpDL.Dr["CollegeId"].ToString();
                    objprp.designationId = ADOprpDL.Dr["CollegeType"].ToString();
                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetupTick();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            //else
            //{
            //    objprp = new PRPSetupTick();
            //    objprp.srNo = "Result Not Find";
            //    lst.Add(objprp);
            //}
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
        public List<PRPSetupTick> BindUniforAuth(PRPSetupTick prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[0];
            //ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            // ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            // PRPSetupTick prp=new PRPSetupTick ();

            ADOprpDL.SPName = "SpShowUniCode";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupTick objprp;
            List<PRPSetupTick> lst = new List<PRPSetupTick>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetupTick();
                    objprp.id = ADOprpDL.Dr["UniId"].ToString();
                    objprp.title = ADOprpDL.Dr["UniName"].ToString();
                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetupTick();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            //else
            //{
            //    objprp = new PRPSetupTick();
            //    objprp.srNo = "Result Not Find";
            //    lst.Add(objprp);
            //}
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
        public string InsertCollegeDetailWebType(PRPSetupTick objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@Querry", objprp.name);
            //ADOprp.ArrayPram[1] = new SqlParameter("@IccoId", objprp.uniID);
            //ADOprp.ArrayPram[2] = new SqlParameter("@IccoComm", objprp.courseFees);
            ADOprp.SPName = "SpinsertCollegeDetailWebType";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }

       
        public List<PRPSetupTick> BindCollegInRepitor(PRPSetupTick prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@CourseId", prp.id);
            ADOprpDL.SPName = "SpBindCollegeByIdInRep";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupTick objprp;
            List<PRPSetupTick> lst = new List<PRPSetupTick>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetupTick();
                   // objprp.courseFees = ADOprpDL.Dr["IccoComm"].ToString();
                    objprp.title = ADOprpDL.Dr["CollegeName"].ToString();

                    lst.Add(objprp);
                }
                if (ADOprpDL.Dr.NextResult())
                {

                    ADOprpDL.Dr.Read();
                    objprp = new PRPSetupTick();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
           
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
        public string DeleteCollSub(PRPSetupTick objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@CourseId", objprp.id);
            ADOprp.SPName = "DeleteCollSub";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);



        }
        //Sub by college End
//--Start--News.
        public string InsNews(PRPSetupTick objprp)
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
        public string UpdNews(PRPSetupTick objprp)
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
        public string DelNews(PRPSetupTick objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@newsID", objprp.id);
            ADOprp.SPName = "delNews";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public PRPSetupTick SelNews(PRPSetupTick objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@newsID", objprp.id);
            ADOprpDL.SPName = "selNews";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupTick obj = new PRPSetupTick(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {                   
                    obj = new PRPSetupTick();
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
       
        public List<PRPSetupTick> ViewNewsInBranch(PRPSetupTick prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@UniId", prp.catID);
            ADOprpDL.SPName = "SpVeiwNewsInBranch";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupTick objprp;
            List<PRPSetupTick> lst = new List<PRPSetupTick>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetupTick();
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
                objprp = new PRPSetupTick();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
       
//--End--News.

//--Start--New Job.
        public string InsJob(PRPSetupTick objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[3];
            ADOprp.ArrayPram[0] = new SqlParameter("@JobTitle", objprp.title);
            ADOprp.ArrayPram[1] = new SqlParameter("@JobDescription", objprp.description);
            ADOprp.ArrayPram[2] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.SPName = "insJob";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string UpdJob(PRPSetupTick objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[4];
            ADOprp.ArrayPram[0] = new SqlParameter("@JobID", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@JobTitle", objprp.title);
            ADOprp.ArrayPram[2] = new SqlParameter("@JobDescription", objprp.description);
            ADOprp.ArrayPram[3] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.SPName = "updJob";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string DelJob(PRPSetupTick objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@JobID", objprp.id);
            ADOprp.SPName = "delJob";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public PRPSetupTick SelJob(PRPSetupTick objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@JobID", objprp.id);
            ADOprpDL.SPName = "selJob";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupTick obj = new PRPSetupTick(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj = new PRPSetupTick();
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
        public List<PRPSetupTick> ViewJob(PRPSetupTick prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.SPName = "viewJob";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupTick objprp;
            List<PRPSetupTick> lst = new List<PRPSetupTick>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetupTick();
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
                    objprp = new PRPSetupTick();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPSetupTick();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
        public List<PRPSetupTick> ViewJob1(PRPSetupTick prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.SPName = "viewJob1";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupTick objprp;
            List<PRPSetupTick> lst = new List<PRPSetupTick>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetupTick();
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
                objprp = new PRPSetupTick();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }

//--End--New Job.

//--Start Resume Detail.
        public string InsResumeDetail(PRPSetupTick objprp)
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
        public string UpdResumeDetail(PRPSetupTick objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[2];
            ADOprp.ArrayPram[0] = new SqlParameter("@resumeID", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.SPName = "updResumeDetail";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        //public string DeleteCourse(PRPSetupTick objprp)
        //{
        //    ADOprp.ArrayPram = new SqlParameter[1];
        //    ADOprp.ArrayPram[0] = new SqlParameter("@CourseID", objprp.id);
        //    ADOprp.SPName = "delCourse";

        //    return ADO.ScalarQueryWithProceduresandParam(ADOprp);



        //}
        public string GetMaxFileId()
        {
            ADOprp.SPName = "spGetfieMaxId";
            return ADO.ScalarQueryWithProcedures(ADOprp);
        }
        public List<PRPSetupTick> ViewResumeDetail(PRPSetupTick prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.SPName = "viewResumeDetail";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupTick objprp;
            List<PRPSetupTick> lst = new List<PRPSetupTick>();

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {   objprp = new PRPSetupTick();
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
                    objprp = new PRPSetupTick();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPSetupTick();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
//--End Resume Detail
//--Start Link file Upload.
        public string InsFile(PRPSetupTick obj)
        {
            ADOprp.ArrayPram = new SqlParameter[4];
            ADOprp.ArrayPram[0] = new SqlParameter("@linkUniversity",obj.uniID);
            ADOprp.ArrayPram[1] = new SqlParameter("@linkName",obj.name);
            ADOprp.ArrayPram[2] = new SqlParameter("@linkPath",obj.urlPath);
            ADOprp.ArrayPram[3] = new SqlParameter("@isActive",obj.isActive);
            ADOprp.SPName = "insFileDetail";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string UpdFile(PRPSetupTick obj)
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
        public List<PRPSetupTick> ViewFile(PRPSetupTick obj)
        {
            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", obj.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", obj.pageSize);
            ADOprpDL.SPName = "viewFileDetail";
            ADO.ReaderWithProceduresandParam(ADOprpDL);
            PRPSetupTick objprp;
            List<PRPSetupTick> lst = new List<PRPSetupTick>();
            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetupTick();
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
                    objprp = new PRPSetupTick();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPSetupTick();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
        public PRPSetupTick SelFile(PRPSetupTick obj)
        {
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@LinkID", obj.id);            
            ADOprpDL.SPName = "selFileDetail";
            ADO.ReaderWithProceduresandParam(ADOprpDL);
            PRPSetupTick objprp= new PRPSetupTick();;
          //  List<PRPSetupTick> lst = new List<PRPSetupTick>();
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
        public string DelFile(PRPSetupTick obj)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@linkID",obj.id);
            ADOprp.SPName = "delFileDetail";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
//--End Link File upload.

//--Start Text Editor.
        public string InsText(PRPSetupTick objprp)
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
        public string UpdText(PRPSetupTick objprp)
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
        public string DelText(PRPSetupTick objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@textID", objprp.id);
            ADOprp.SPName = "delText";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public PRPSetupTick SelText(PRPSetupTick objprp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@textID", objprp.id);
            ADOprpDL.SPName = "selText";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupTick obj = new PRPSetupTick(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj = new PRPSetupTick();
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
        public PRPSetupTick SelText1(PRPSetupTick objprp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@uniId", objprp.uniID);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@catId", objprp.catID);
            ADOprpDL.SPName = "selText1";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupTick obj = new PRPSetupTick(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj = new PRPSetupTick();
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
        public List<PRPSetupTick> ViewText(PRPSetupTick prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.SPName = "viewText";
            ADO.ReaderWithProceduresandParam(ADOprpDL);
            PRPSetupTick objprp;
            List<PRPSetupTick> lst = new List<PRPSetupTick>();
            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetupTick();
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
                    objprp = new PRPSetupTick();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPSetupTick();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
//--End Text Editor.

//--Start Text Editor.
        public string InsTextWeb(PRPSetupTick objprp)
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
        public string UpdTextWeb(PRPSetupTick objprp)
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
        public string DelTextWeb(PRPSetupTick objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@textID", objprp.id);
            ADOprp.SPName = "delTextWeb";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public PRPSetupTick SelTextWeb(PRPSetupTick objprp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@textID", objprp.id);
            ADOprpDL.SPName = "selTextWeb";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupTick obj = new PRPSetupTick(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj = new PRPSetupTick();
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
        public PRPSetupTick SelTextWeb1(PRPSetupTick objprp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@uniId", objprp.uniID);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@catId", objprp.catID);
            ADOprpDL.SPName = "selTextWeb1";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupTick obj = new PRPSetupTick(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj = new PRPSetupTick();
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
        public List<PRPSetupTick> ViewTextWeb(PRPSetupTick prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.SPName = "viewTextWeb";
            ADO.ReaderWithProceduresandParam(ADOprpDL);
            PRPSetupTick objprp;
            List<PRPSetupTick> lst = new List<PRPSetupTick>();
            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetupTick();
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
                    objprp = new PRPSetupTick();
                    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                    lst.Add(objprp);
                }


            }
            else
            {
                objprp = new PRPSetupTick();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
//--End Text Editor.
 //--Start Text Category.
        public string InsTextCategory(PRPSetupTick objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[3];
            ADOprp.ArrayPram[0] = new SqlParameter("@catName", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@uniID", objprp.uniID);
            ADOprp.ArrayPram[2] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.SPName = "insTextCategory";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string UpdTextCategory(PRPSetupTick objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[4];

            ADOprp.ArrayPram[0] = new SqlParameter("@catID", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@catName", objprp.name);
            ADOprp.ArrayPram[2] = new SqlParameter("@uniID", objprp.uniID);
            ADOprp.ArrayPram[3] = new SqlParameter("@isActive", objprp.isActive);

            ADOprp.SPName = "updTextCategory";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }
        public string DelTextCategory(PRPSetupTick objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@catID", objprp.id);
            ADOprp.SPName = "delTextCategory";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);



        }
        public PRPSetupTick SelTextCategory(PRPSetupTick objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@catID", objprp.id);
            ADOprpDL.SPName = "selTextCategory";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupTick obj = new PRPSetupTick(); ;

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
        public DataTable ViewTextCategory(PRPSetupTick objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];

            ADOprp.ArrayPram[0] = new SqlParameter("@status", objprp.status);

            ADOprp.SPName = "ViewTextCategory";
            return ADO.DataTableWithProcedures(ADOprp);
        }
//--End Text Category.

//--Start Text Category.
        public string InsTextCategoryWeb(PRPSetupTick objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[3];
            ADOprp.ArrayPram[0] = new SqlParameter("@catName", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@uniID", objprp.uniID);
            ADOprp.ArrayPram[2] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.SPName = "insTextCategoryWeb";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string UpdTextCategoryWeb(PRPSetupTick objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[4];

            ADOprp.ArrayPram[0] = new SqlParameter("@catID", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@catName", objprp.name);
            ADOprp.ArrayPram[2] = new SqlParameter("@uniID", objprp.uniID);
            ADOprp.ArrayPram[3] = new SqlParameter("@isActive", objprp.isActive);

            ADOprp.SPName = "updTextCategoryWeb";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }
        public string DelTextCategoryWeb(PRPSetupTick objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@catID", objprp.id);
            ADOprp.SPName = "delTextCategoryWeb";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);



        }
        public PRPSetupTick SelTextCategoryWeb(PRPSetupTick objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@catID", objprp.id);
            ADOprpDL.SPName = "selTextCategoryWeb";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupTick obj = new PRPSetupTick(); ;

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
        public DataTable ViewTextCategoryWeb(PRPSetupTick objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];

            ADOprp.ArrayPram[0] = new SqlParameter("@status", objprp.status);

            ADOprp.SPName = "ViewTextCategoryWeb";
            return ADO.DataTableWithProcedures(ADOprp);
        }
//--End Text Category.

//--Start Local Text Editor.
        public string UpdLocalText(PRPSetupTick objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[4];
            ADOprp.ArrayPram[0] = new SqlParameter("@textID", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@textTitle", objprp.title);
            ADOprp.ArrayPram[2] = new SqlParameter("@textDescription", objprp.description);
            ADOprp.ArrayPram[3] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.SPName = "updLocalText";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public PRPSetupTick SelLocalText(PRPSetupTick objprp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@textID", objprp.id);
            ADOprpDL.SPName = "selLocalText";
            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupTick obj = new PRPSetupTick(); ;

            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    obj = new PRPSetupTick();
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
        public string InsImageCategory(PRPSetupTick objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[3];
            ADOprp.ArrayPram[0] = new SqlParameter("@catName", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@uniID", objprp.uniID);
            ADOprp.ArrayPram[2] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.SPName = "insImageCategory";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string UpdImageCategory(PRPSetupTick objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[4];

            ADOprp.ArrayPram[0] = new SqlParameter("@catID", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@catName", objprp.name);
            ADOprp.ArrayPram[2] = new SqlParameter("@uniID", objprp.uniID);
            ADOprp.ArrayPram[3] = new SqlParameter("@isActive", objprp.isActive);

            ADOprp.SPName = "updImageCategory";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }
        public string DelImageCategory(PRPSetupTick objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@catID", objprp.id);
            ADOprp.SPName = "delImageCategory";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);



        }
        public PRPSetupTick SelImageCategory(PRPSetupTick objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@catID", objprp.id);
            ADOprpDL.SPName = "selImageCategory";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetupTick obj = new PRPSetupTick(); ;

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
        public DataTable ViewImageCategory(PRPSetupTick objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];

            ADOprp.ArrayPram[0] = new SqlParameter("@status", objprp.status);

            ADOprp.SPName = "ViewImageCategory";
            return ADO.DataTableWithProcedures(ADOprp);
        }    
//--End Image Category.
        public string InsImageGallery(PRPSetupTick objprp)
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
        public string UpdImageGallery(PRPSetupTick objprp)
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
        public string DelImageGallery(PRPSetupTick objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@imageId", objprp.id);            
            ADOprp.SPName = "delImageGallery";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public PRPSetupTick SelImageGallery(PRPSetupTick objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@imageID", objprp.id);
            ADOprpDL.SPName = "selImageGallery";
            ADO.ReaderWithProceduresandParam(ADOprpDL);
            PRPSetupTick obj = new PRPSetupTick(); ;
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
       public List<PRPSetupTick> ViewImageGallery(PRPSetupTick obj)
        {
            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@uniID", obj.uniID);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@catID", obj.catID);
            ADOprpDL.SPName = "viewImageGallery";
            ADO.ReaderWithProceduresandParam(ADOprpDL);
            PRPSetupTick objprp;
            List<PRPSetupTick> lst = new List<PRPSetupTick>();
            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetupTick();
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
                objprp = new PRPSetupTick();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            ADO.ReaderClose(ADOprpDL);
            return lst;

        }
       
//--Start EducationType
       public string InsEducationType(PRPSetupTick objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[2];
           ADOprp.ArrayPram[0] = new SqlParameter("@typeName", objprp.name);
           ADOprp.ArrayPram[1] = new SqlParameter("@isActive", objprp.isActive);
           ADOprp.SPName = "insEducationType";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string UpdEducationType(PRPSetupTick objprp)  
       {
           ADOprp.ArrayPram = new SqlParameter[3];

           ADOprp.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
           ADOprp.ArrayPram[1] = new SqlParameter("@typeName", objprp.name);
           ADOprp.ArrayPram[2] = new SqlParameter("@isActive", objprp.isActive);

           ADOprp.SPName = "updEducationType";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);


       }
       public string DelEducationType(PRPSetupTick objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
           ADOprp.SPName = "delEducationType";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public PRPSetupTick SelEducationType(PRPSetupTick objprp)
       {

           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
           ADOprpDL.SPName = "selEducationType";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetupTick obj = new PRPSetupTick(); ;

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
       public string InsUniversityType(PRPSetupTick objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[2];
           ADOprp.ArrayPram[0] = new SqlParameter("@typeName", objprp.name);
           ADOprp.ArrayPram[1] = new SqlParameter("@isActive", objprp.isActive);
           ADOprp.SPName = "insUniversityType";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string UpdUniversityType(PRPSetupTick objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[3];

           ADOprp.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
           ADOprp.ArrayPram[1] = new SqlParameter("@typeName", objprp.name);
           ADOprp.ArrayPram[2] = new SqlParameter("@isActive", objprp.isActive);

           ADOprp.SPName = "updUniversityType";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);


       }
       public string DelUniversityType(PRPSetupTick objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
           ADOprp.SPName = "delUniversityType";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public PRPSetupTick SelUniversityType(PRPSetupTick objprp)
       {

           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
           ADOprpDL.SPName = "selUniversityType";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetupTick obj = new PRPSetupTick(); ;

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
       public string InsCollegeType(PRPSetupTick objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[2];
           ADOprp.ArrayPram[0] = new SqlParameter("@typeName", objprp.name);
           ADOprp.ArrayPram[1] = new SqlParameter("@isActive", objprp.isActive);
           ADOprp.SPName = "insCollegeType";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string UpdCollegeType(PRPSetupTick objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[3];

           ADOprp.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
           ADOprp.ArrayPram[1] = new SqlParameter("@typeName", objprp.name);
           ADOprp.ArrayPram[2] = new SqlParameter("@isActive", objprp.isActive);

           ADOprp.SPName = "updCollegeType";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);


       }
       public string DelCollegeType(PRPSetupTick objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
           ADOprp.SPName = "delCollegeType";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public PRPSetupTick SelCollegeType(PRPSetupTick objprp)
       {

           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
           ADOprpDL.SPName = "selCollegeType";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetupTick obj = new PRPSetupTick(); ;

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

//--Start Tkt Department
       public string InsTktDep(PRPSetupTick objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@DepName", objprp.name);
           //ADOprp.ArrayPram[1] = new SqlParameter("@isActive", objprp.isActive);
           ADOprp.SPName = "SpInsertTktDep";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string UpdTktDep(PRPSetupTick objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[3];

           ADOprp.ArrayPram[0] = new SqlParameter("@DepId", objprp.id);
           ADOprp.ArrayPram[1] = new SqlParameter("@DepName", objprp.name);
           ADOprp.ArrayPram[2] = new SqlParameter("@DepStatus", 1);

           ADOprp.SPName = "SpUpdateTktDep";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);


       }
       public string DelTktDep(PRPSetupTick objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@DepId", objprp.id);
           ADOprp.SPName = "SpdeleteTktDep";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public PRPSetupTick SelTktDep(PRPSetupTick objprp)
       {

           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@DepId", objprp.id);
           ADOprpDL.SPName = "SpSelectByIdTktDep";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetupTick obj = new PRPSetupTick(); ;

           if (ADOprpDL.Dr.HasRows)
           {

               while (ADOprpDL.Dr.Read())
               {
                   obj.id = ADOprpDL.Dr["DepId"].ToString();
                   obj.name = ADOprpDL.Dr["DepName"].ToString();
                   obj.isActive = ADOprpDL.Dr["DepStatus"].ToString();
               }
           }
           ADO.ReaderClose(ADOprpDL);
           return obj;
       }
       //--End Tkt Department
//Start Submit Ticket Done
       public string InsTicket(PRPSetupTick objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[16];
           ADOprp.ArrayPram[0] = new SqlParameter("@tktDep", objprp.designationId);
           ADOprp.ArrayPram[1] = new SqlParameter("@tktPtype", objprp.status);
           ADOprp.ArrayPram[2] = new SqlParameter("@tktClienttype",objprp.userType);
           ADOprp.ArrayPram[3] = new SqlParameter("@tktSubject", objprp.title);
           ADOprp.ArrayPram[4] = new SqlParameter("@MebName", objprp.name);
           ADOprp.ArrayPram[5] = new SqlParameter("@MebEmail", objprp.emailID);
           ADOprp.ArrayPram[6] = new SqlParameter("@MebMobileNo", "9812777210");
           ADOprp.ArrayPram[7] = new SqlParameter("@RegClientId",objprp.id);
           ADOprp.ArrayPram[8] = new SqlParameter("@RegServiceType", 1);
           ADOprp.ArrayPram[9] = new SqlParameter("@tktdata", objprp.description);
           ADOprp.ArrayPram[10] = new SqlParameter("@tktTranStatus", 1);
           ADOprp.ArrayPram[11] = new SqlParameter("@Rating", "1");
           ADOprp.ArrayPram[12] = new SqlParameter("@IpAddress", objprp.address);
           ADOprp.ArrayPram[13] = new SqlParameter("@ImagePath", objprp.urlPath);
           ADOprp.ArrayPram[14] = new SqlParameter("@tktStatus", 1);
           ADOprp.ArrayPram[15] = new SqlParameter("@replyType", objprp.isActive);
           
           ADOprp.SPName = "tktInsTicket";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string InsTicketReply(PRPSetupTick objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[7];
           ADOprp.ArrayPram[0] = new SqlParameter("@tktNo", objprp.designationId);
           ADOprp.ArrayPram[1] = new SqlParameter("@tktdata", objprp.description);
           ADOprp.ArrayPram[2] = new SqlParameter("@tktTranStatus", 1);
           ADOprp.ArrayPram[3] = new SqlParameter("@rating", 1);
           ADOprp.ArrayPram[4] = new SqlParameter("@Ipaddress", objprp.address);
           ADOprp.ArrayPram[5] = new SqlParameter("@imagePath", objprp.urlPath);
           ADOprp.ArrayPram[6] = new SqlParameter("@replyType", objprp.status);
         // ADOprp.ArrayPram[6] = new SqlParameter("@MebMobileNo", "9812777210");
           ADOprp.SPName = "tktInstrans";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string InsTicketReplyByAdm(PRPSetupTick objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[7];
           ADOprp.ArrayPram[0] = new SqlParameter("@tktNo", objprp.designationId);
           ADOprp.ArrayPram[1] = new SqlParameter("@tktdata", objprp.description);
           ADOprp.ArrayPram[2] = new SqlParameter("@tktTranStatus", 0);
           ADOprp.ArrayPram[3] = new SqlParameter("@rating", 1);
           ADOprp.ArrayPram[4] = new SqlParameter("@Ipaddress", objprp.address);
           ADOprp.ArrayPram[5] = new SqlParameter("@imagePath", objprp.urlPath);
           ADOprp.ArrayPram[6] = new SqlParameter("@replyType", objprp.status);
           // ADOprp.ArrayPram[6] = new SqlParameter("@MebMobileNo", "9812777210");
           ADOprp.SPName = "tktInstransByAdd";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string AssignByAdm(PRPSetupTick objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[3];
           ADOprp.ArrayPram[0] = new SqlParameter("@tktno", objprp.noOfRecord);
           ADOprp.ArrayPram[1] = new SqlParameter("@EmpId", objprp.id);
           ADOprp.ArrayPram[2] = new SqlParameter("@IpAddress",objprp.address);
           //ADOprp.ArrayPram[3] = new SqlParameter("@rating", 1);
           //ADOprp.ArrayPram[4] = new SqlParameter("@Ipaddress", objprp.address);
           //ADOprp.ArrayPram[5] = new SqlParameter("@imagePath", objprp.urlPath);
           // ADOprp.ArrayPram[6] = new SqlParameter("@MebMobileNo", "9812777210");
           ADOprp.SPName = "tktInsOnAssign";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public List<PRPSetupTick> BindByAuthorisation()
       {
           ADOprpDL.ArrayPram = new SqlParameter[0];
           //ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
           //ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
           // ADOprpDL.ArrayPram[2] = new SqlParameter("@newsUniversityID", prp.uniID);
           ADOprpDL.SPName = "SpViewAllTktDep1";
           ADO.ReaderWithProceduresandParam(ADOprpDL);

           PRPSetupTick objprp;
           List<PRPSetupTick> lst = new List<PRPSetupTick>();

           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   objprp = new PRPSetupTick();
                   objprp.id = ADOprpDL.Dr["id"].ToString();
                   objprp.branchName = ADOprpDL.Dr["name"].ToString();
                   objprp.noOfRecord = ADOprpDL.Dr["Number"].ToString();
                   lst.Add(objprp);
               }
               //if (ADOprpDL.Dr.NextResult())
               //{

               //    ADOprpDL.Dr.Read();
               //    objprp = new PRPSetupTick();
               //    objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
               //    lst.Add(objprp);
               //}


           }
           else
           {
               objprp = new PRPSetupTick();
               objprp.srNo = "Result Not Find";
               lst.Add(objprp);
           }
           ADO.ReaderClose(ADOprpDL);
           return lst;

       }
       public List<PRPSetupTick> BindDepByCountInAdm()
       {
           ADOprpDL.ArrayPram = new SqlParameter[0];
           //ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
           //ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
           // ADOprpDL.ArrayPram[2] = new SqlParameter("@newsUniversityID", prp.uniID);
           ADOprpDL.SPName = "SpViewAllTktDepInAdm";
           ADO.ReaderWithProceduresandParam(ADOprpDL);

           PRPSetupTick objprp;
           List<PRPSetupTick> lst = new List<PRPSetupTick>();

           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   objprp = new PRPSetupTick();
                   objprp.id = ADOprpDL.Dr["id"].ToString();
                   objprp.branchName = ADOprpDL.Dr["name"].ToString();
                   objprp.noOfRecord = ADOprpDL.Dr["Number"].ToString(); 
                 
                   lst.Add(objprp);
               }
               //if (ADOprpDL.Dr.NextResult())
               //{

               //    ADOprpDL.Dr.Read();
               //    objprp = new PRPSetupTick();
                  
               //    lst.Add(objprp);
               //}


           }
           else
           {
               objprp = new PRPSetupTick();
               objprp.srNo = "Result Not Find";
               lst.Add(objprp);
           }
           ADO.ReaderClose(ADOprpDL);
           return lst;

       }
       public List<PRPSetupTick> ViewTicket(PRPSetupTick prp)
       {
           ADOprpDL.ArrayPram = new SqlParameter[4];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
           ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.ArrayPram[2] = new SqlParameter("@uniId", prp.uniID);
            ADOprpDL.ArrayPram[3] = new SqlParameter("@depId", prp.catID);
           ADOprpDL.SPName = "tktview";
           ADO.ReaderWithProceduresandParam(ADOprpDL);

           PRPSetupTick objprp;
           List<PRPSetupTick> lst = new List<PRPSetupTick>();

           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   objprp = new PRPSetupTick();
                   objprp.id = ADOprpDL.Dr["tktno"].ToString();
                   objprp.title = ADOprpDL.Dr["DepName"].ToString();
                   objprp.description = ADOprpDL.Dr["tktsubject"].ToString();
                   // objprp.catID = ADOprpDL.Dr["newsType"].ToString();
                   //objprp.uniID = ADOprpDL.Dr["NewName"].ToString();
                   objprp.DOJ = ADOprpDL.Dr["tktdate"].ToString();
                   objprp.isActive = ADOprpDL.Dr["Pname"].ToString();
                   objprp.status = ADOprpDL.Dr["ststype"].ToString();
                   lst.Add(objprp);
               }
               if (ADOprpDL.Dr.NextResult())
               {

                   ADOprpDL.Dr.Read();
                   objprp = new PRPSetupTick();
                   objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                   lst.Add(objprp);
               }


           }
           else
           {
               objprp = new PRPSetupTick();
               objprp.srNo = "Result Not Find";
               lst.Add(objprp);
           }
           ADO.ReaderClose(ADOprpDL);
           return lst;

       }
       public List<PRPSetupTick> ViewTicketAdm(PRPSetupTick prp)
       {
           ADOprpDL.ArrayPram = new SqlParameter[3];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
           ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
           ADOprpDL.ArrayPram[2] = new SqlParameter("@tktdep", prp.uniID);
           ADOprpDL.SPName = "tktviewAdmBydep";
           ADO.ReaderWithProceduresandParam(ADOprpDL);

           PRPSetupTick objprp;
           List<PRPSetupTick> lst = new List<PRPSetupTick>();

           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   objprp = new PRPSetupTick();
                   objprp.id = ADOprpDL.Dr["tktno"].ToString();
                   objprp.title = ADOprpDL.Dr["DepName"].ToString();
                   objprp.description = ADOprpDL.Dr["tktsubject"].ToString();
                   // objprp.catID = ADOprpDL.Dr["newsType"].ToString();
                   //objprp.uniID = ADOprpDL.Dr["NewName"].ToString();
                   objprp.DOJ = ADOprpDL.Dr["tktdate"].ToString();
                   objprp.isActive = ADOprpDL.Dr["Pname"].ToString();
                   objprp.status = ADOprpDL.Dr["ststype"].ToString();
                   lst.Add(objprp);
               }
               if (ADOprpDL.Dr.NextResult())
               {

                   ADOprpDL.Dr.Read();
                   objprp = new PRPSetupTick();
                   objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                   lst.Add(objprp);
               }


           }
           else
           {
               objprp = new PRPSetupTick();
               objprp.srNo = "Result Not Find";
               lst.Add(objprp);
           }
           ADO.ReaderClose(ADOprpDL);
           return lst;

       }
       public List<PRPSetupTick> ViewTicket1(PRPSetupTick prp)
       {
           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@tktno", prp.catID);
           //ADOprpDL.SPName = "viewNews1";
           ADOprpDL.SPName = "tktview1";
           ADO.ReaderWithProceduresandParam(ADOprpDL);

           PRPSetupTick objprp;
           List<PRPSetupTick> lst = new List<PRPSetupTick>();

           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   objprp = new PRPSetupTick();
                   objprp.id = ADOprpDL.Dr["tktno"].ToString();
                   objprp.title = ADOprpDL.Dr["DepName"].ToString();
                   objprp.description = ADOprpDL.Dr["tktsubject"].ToString();
                   objprp.name = ADOprpDL.Dr["MebName"].ToString();
                   //objprp.uniID = ADOprpDL.Dr["NewName"].ToString();
                   objprp.DOJ = ADOprpDL.Dr["tktdate"].ToString();
                   objprp.isActive = ADOprpDL.Dr["Pname"].ToString();
                   objprp.status = ADOprpDL.Dr["ststype"].ToString();

                   lst.Add(objprp);
               }
           }
           else
           {
               objprp = new PRPSetupTick();
               objprp.srNo = "Result Not Find";
               lst.Add(objprp);
           }
           ADO.ReaderClose(ADOprpDL);
           return lst;

       }
       public List<PRPSetupTick> ViewPTicket1(PRPSetupTick prp)
       {
           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@tktno", prp.catID);
           //ADOprpDL.SPName = "viewNews1";
           ADOprpDL.SPName = "tktPview";
           ADO.ReaderWithProceduresandParam(ADOprpDL);

           PRPSetupTick objprp;
           List<PRPSetupTick> lst = new List<PRPSetupTick>();

           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   objprp = new PRPSetupTick();
                   objprp.id = ADOprpDL.Dr["tktno"].ToString();
                   objprp.title = ADOprpDL.Dr["DepName"].ToString();
                   objprp.description = ADOprpDL.Dr["tktdata"].ToString();
                   objprp.name = ADOprpDL.Dr["MebName"].ToString();
                   //objprp.uniID = ADOprpDL.Dr["NewName"].ToString();
                   objprp.DOJ = ADOprpDL.Dr["tktdate"].ToString();
                 //  objprp.isActive = ADOprpDL.Dr["Pname"].ToString();
                   objprp.status = ADOprpDL.Dr["ipaddress"].ToString();

                   lst.Add(objprp);
               }
           }
           else
           {
               objprp = new PRPSetupTick();
               objprp.srNo = "Result Not Find";
               lst.Add(objprp);
           }
           ADO.ReaderClose(ADOprpDL);
           return lst;

       }
       public List<PRPSetupTick> ViewReplyTicket1(PRPSetupTick prp)
       {
           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@tktno", prp.catID);
           //ADOprpDL.SPName = "viewNews1";
           ADOprpDL.SPName = "tktPview";
           ADO.ReaderWithProceduresandParam(ADOprpDL);

           PRPSetupTick objprp;
           List<PRPSetupTick> lst = new List<PRPSetupTick>();

           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   objprp = new PRPSetupTick();
                   objprp.id = ADOprpDL.Dr["tktno"].ToString();
                   objprp.title = ADOprpDL.Dr["DepName"].ToString();
                   objprp.description = ADOprpDL.Dr["tktdata"].ToString();
                   objprp.name = ADOprpDL.Dr["MebName"].ToString();
                   //objprp.uniID = ADOprpDL.Dr["NewName"].ToString();
                   objprp.DOJ = ADOprpDL.Dr["tktdate"].ToString();
                 //  objprp.isActive = ADOprpDL.Dr["Pname"].ToString();
                   objprp.status = ADOprpDL.Dr["ipaddress"].ToString();

                   lst.Add(objprp);
               }
           }
           else
           {
               objprp = new PRPSetupTick();
               objprp.srNo = "Result Not Find";
               lst.Add(objprp);
           }
           ADO.ReaderClose(ADOprpDL);
           return lst;

       }
 //End Submit Ticket
       // Start Tkt Status
       public string InsTktStatus(PRPSetupTick objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@stsType", objprp.name);
           //ADOprp.ArrayPram[1] = new SqlParameter("@isActive", objprp.isActive);
           ADOprp.SPName = "SpInsertTktStatus";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string UpdTktStatus(PRPSetupTick objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[2];

           ADOprp.ArrayPram[0] = new SqlParameter("@stsid", objprp.id);
           ADOprp.ArrayPram[1] = new SqlParameter("@stsType", objprp.name);
           //ADOprp.ArrayPram[2] = new SqlParameter("@DepStatus", 1);

           ADOprp.SPName = "SpUpdateTktStatus";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);


       }
       public string DelTktStatus(PRPSetupTick objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@stsid", objprp.id);
           ADOprp.SPName = "SpdeleteTktStatus";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public PRPSetupTick SelTktStatus(PRPSetupTick objprp)
       {

           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@stsid", objprp.id);
           ADOprpDL.SPName = "SpSelectByIdTktStatus";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetupTick obj = new PRPSetupTick(); ;

           if (ADOprpDL.Dr.HasRows)
           {

               while (ADOprpDL.Dr.Read())
               {
                   obj.id = ADOprpDL.Dr["stsid"].ToString();
                   obj.name = ADOprpDL.Dr["stsType"].ToString();
                  // obj.isActive = ADOprpDL.Dr["DepStatus"].ToString();
               }
           }
           ADO.ReaderClose(ADOprpDL);
           return obj;
       }
       //End Tkt Status
// start tkt ptype
       public string InstktPtype(PRPSetupTick objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@pName", objprp.name);
           //ADOprp.ArrayPram[1] = new SqlParameter("@isActive", objprp.isActive);
           ADOprp.SPName = "SpInsertPtype";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string UpdtktPtype(PRPSetupTick objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[2];

           ADOprp.ArrayPram[0] = new SqlParameter("@pid", objprp.id);
           ADOprp.ArrayPram[1] = new SqlParameter("@pName", objprp.name);
           //ADOprp.ArrayPram[2] = new SqlParameter("@DepStatus", 1);

           ADOprp.SPName = "SpUpdatePtype";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);


       }
       public string DeltktPtype(PRPSetupTick objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@pid", objprp.id);
           ADOprp.SPName = "SpdeletePtype";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public PRPSetupTick SeltktPtype(PRPSetupTick objprp)
       {

           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@pid", objprp.id);
           ADOprpDL.SPName = "SpSelectByIdPtype";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetupTick obj = new PRPSetupTick(); ;

           if (ADOprpDL.Dr.HasRows)
           {

               while (ADOprpDL.Dr.Read())
               {
                   obj.id = ADOprpDL.Dr["pid"].ToString();
                   obj.name = ADOprpDL.Dr["pName"].ToString();
                   // obj.isActive = ADOprpDL.Dr["DepStatus"].ToString();
               }
           }
           ADO.ReaderClose(ADOprpDL);
           return obj;
       }
// End tkt ptype
//--Start Country.
       public string InsCountry(PRPSetupTick objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@cntName", objprp.name);
           ADOprp.SPName = "insCountry";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string UpdCountry(PRPSetupTick objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[2];

           ADOprp.ArrayPram[0] = new SqlParameter("@cntID", objprp.id);
           ADOprp.ArrayPram[1] = new SqlParameter("@cntName", objprp.name);

           ADOprp.SPName = "updCountry";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);


       }
       public string DelCountry(PRPSetupTick objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@cntID", objprp.id);
           ADOprp.SPName = "delCountry";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public PRPSetupTick SelCountry(PRPSetupTick objprp)
       {

           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@cntID", objprp.id);
           ADOprpDL.SPName = "selCountry";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetupTick obj = new PRPSetupTick(); ;

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
       public string InsState(PRPSetupTick objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[2];
           ADOprp.ArrayPram[0] = new SqlParameter("@stateName", objprp.name);
           ADOprp.ArrayPram[1] = new SqlParameter("@cnt", objprp.uniID);
           ADOprp.SPName = "insState";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string UpdState(PRPSetupTick objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[3];           
           ADOprp.ArrayPram[0] = new SqlParameter("@stateID", objprp.id);
           ADOprp.ArrayPram[1] = new SqlParameter("@stateName", objprp.name);
           ADOprp.ArrayPram[2] = new SqlParameter("@cntId", objprp.uniID);
           ADOprp.SPName = "updState";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);


       }
       public string DelState(PRPSetupTick objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@stateID", objprp.id);
           ADOprp.SPName = "delState";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);           
       }
       public PRPSetupTick SelState(PRPSetupTick objprp)
       {

           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@stateID", objprp.id);
           ADOprpDL.SPName = "selState";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetupTick obj = new PRPSetupTick(); ;

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
       public string InsDistrict(PRPSetupTick objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[2];
           ADOprp.ArrayPram[0] = new SqlParameter("@distName", objprp.name);
           ADOprp.ArrayPram[1] = new SqlParameter("@stateID", objprp.uniID);
           ADOprp.SPName = "insDistrict";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string UpdDistrict(PRPSetupTick objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[3];

           ADOprp.ArrayPram[0] = new SqlParameter("@distId", objprp.id);
           ADOprp.ArrayPram[1] = new SqlParameter("@distName", objprp.name);
           ADOprp.ArrayPram[2] = new SqlParameter("@stateId", objprp.uniID);
           ADOprp.SPName = "updDistrict";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string DelDistrict(PRPSetupTick objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@distId", objprp.id);
           ADOprp.SPName = "delDistrict";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public PRPSetupTick SelDistrict(PRPSetupTick objprp)
       {

           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@distId", objprp.id);
           ADOprpDL.SPName = "selDistrict";

           ADO.ReaderWithProceduresandParam(ADOprpDL);

           PRPSetupTick obj = new PRPSetupTick(); ;

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
       public string InsCity(PRPSetupTick objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[2];
           ADOprp.ArrayPram[0] = new SqlParameter("@cityName", objprp.name);
           ADOprp.ArrayPram[1] = new SqlParameter("@distID", objprp.uniID);
           ADOprp.SPName = "insCity";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string UpdCity(PRPSetupTick objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[3];

           ADOprp.ArrayPram[0] = new SqlParameter("@cityID", objprp.id);
           ADOprp.ArrayPram[1] = new SqlParameter("@cityName", objprp.name);
           ADOprp.ArrayPram[2] = new SqlParameter("@distID", objprp.uniID);
           ADOprp.SPName = "updCity";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string DelCity(PRPSetupTick objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@cityID", objprp.id);
           ADOprp.SPName = "delCity";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public PRPSetupTick SelCity(PRPSetupTick objprp)
       {

           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@cityID", objprp.id);
           ADOprpDL.SPName = "selCity";

           ADO.ReaderWithProceduresandParam(ADOprpDL);

           PRPSetupTick obj = new PRPSetupTick(); ;

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
       public string InsBranchLocator(PRPSetupTick objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[4];
           ADOprp.ArrayPram[0] = new SqlParameter("@branchName", objprp.title);
           ADOprp.ArrayPram[1] = new SqlParameter("@branchDescription", objprp.description);
           ADOprp.ArrayPram[2] = new SqlParameter("@cityId", objprp.uniID);
           ADOprp.ArrayPram[3] = new SqlParameter("@isActive", objprp.isActive);
           ADOprp.SPName = "insBranchLocator";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string UpdBranchLocator(PRPSetupTick objprp)
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
       public string DelBranchLocator(PRPSetupTick objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@branchId", objprp.id);
           ADOprp.SPName = "delBranchLocator";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public PRPSetupTick SelBranchLocator(PRPSetupTick objprp)
       {
           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@branchId", objprp.id);
           ADOprpDL.SPName = "selBranchLocator";
           ADO.ReaderWithProceduresandParam(ADOprpDL);

           PRPSetupTick obj = new PRPSetupTick(); ;

           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   obj = new PRPSetupTick();
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
       public List<PRPSetupTick> ViewBranchLocator(PRPSetupTick prp)
       {
           ADOprpDL.ArrayPram = new SqlParameter[2];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
           ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
           ADOprpDL.SPName = "viewBranchLocator";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetupTick objprp;
           List<PRPSetupTick> lst = new List<PRPSetupTick>();
           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   objprp = new PRPSetupTick();
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
                   objprp = new PRPSetupTick();
                   objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                   lst.Add(objprp);
               }


           }
           else
           {
               objprp = new PRPSetupTick();
               objprp.srNo = "Result Not Find";
               lst.Add(objprp);
           }
           ADO.ReaderClose(ADOprpDL);
           return lst;

       }
       public List<PRPSetupTick> ViewBranchLocator1(PRPSetupTick prp)
       {
           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@cityId", prp.id);           
           ADOprpDL.SPName = "viewBranchLocator1";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetupTick objprp;
           List<PRPSetupTick> lst = new List<PRPSetupTick>();
           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   objprp = new PRPSetupTick();
                   objprp.id = ADOprpDL.Dr["branchId"].ToString();
                   objprp.title = ADOprpDL.Dr["branchName"].ToString();
                   objprp.description = ADOprpDL.Dr["branchDescription"].ToString();
                   lst.Add(objprp);
               }              

           }
           else
           {
               objprp = new PRPSetupTick();
               objprp.srNo = "Result Not Find";
               lst.Add(objprp);
           }
           ADO.ReaderClose(ADOprpDL);
           return lst;
       }
//--End Branch Locator

//--Start Course Text Editor.
       public string InsCourseText(PRPSetupTick objprp)
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
       public string UpdCourseText(PRPSetupTick objprp)
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
       public string DelCourseText(PRPSetupTick objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@textID", objprp.id);
           ADOprp.SPName = "delCourseText";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public PRPSetupTick SelCourseText(PRPSetupTick objprp)
       {
           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@textID", objprp.id);
           ADOprpDL.SPName = "selCourseText";
           ADO.ReaderWithProceduresandParam(ADOprpDL);

           PRPSetupTick obj = new PRPSetupTick(); ;

           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   obj = new PRPSetupTick();
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
       public PRPSetupTick SelCourseText1(PRPSetupTick objprp)
       {
           ADOprpDL.ArrayPram = new SqlParameter[2];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@uniId", objprp.uniID);
           ADOprpDL.ArrayPram[1] = new SqlParameter("@catId", objprp.catID);
           ADOprpDL.SPName = "selCourseText1";
           ADO.ReaderWithProceduresandParam(ADOprpDL);

           PRPSetupTick obj = new PRPSetupTick(); ;

           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   obj = new PRPSetupTick();
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
       public List<PRPSetupTick> ViewCourseText(PRPSetupTick prp)
       {
           ADOprpDL.ArrayPram = new SqlParameter[2];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
           ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
           ADOprpDL.SPName = "viewCourseText";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetupTick objprp;
           List<PRPSetupTick> lst = new List<PRPSetupTick>();
           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   objprp = new PRPSetupTick();
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
                   objprp = new PRPSetupTick();
                   objprp.noOfRecord = ADOprpDL.Dr[0].ToString();
                   lst.Add(objprp);
               }


           }
           else
           {
               objprp = new PRPSetupTick();
               objprp.srNo = "Result Not Find";
               lst.Add(objprp);
           }
           ADO.ReaderClose(ADOprpDL);
           return lst;

       }
//--End Course Text Editor.
//--Start Visitor Counter.
       public string UpdVisitor(PRPSetupTick objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@maxValue", objprp.courseFees);
           ADOprp.SPName = "updVisitor";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);   
       }
//--End Visitor Counter.

//-- Start Comment Detail.
       public string InsCommentDetail(PRPSetupTick objprp)
       {           
           ADOprp.ArrayPram = new SqlParameter[12];
           ADOprp.ArrayPram[0] = new SqlParameter("@cmtName", objprp.name);
           ADOprp.ArrayPram[1] = new SqlParameter("@cmtMobileNo", objprp.mobNo);
           ADOprp.ArrayPram[2] = new SqlParameter("@cmtEmailid", objprp.emailID);
           ADOprp.ArrayPram[3] = new SqlParameter("@cmtMessage", objprp.description);
           ADOprp.ArrayPram[4] = new SqlParameter("@newsID", objprp.codeId);
           ADOprp.ArrayPram[5] = new SqlParameter("@newsTypeId", objprp.catID);
           ADOprp.ArrayPram[6] = new SqlParameter("@pageID", objprp.uniID);
           ADOprp.ArrayPram[7] = new SqlParameter("@cmtReplyID", objprp.urlId);
           ADOprp.ArrayPram[8] = new SqlParameter("@pip", objprp.pip);
           ADOprp.ArrayPram[9] = new SqlParameter("@ipName", objprp.ipName);
           ADOprp.ArrayPram[10] = new SqlParameter("@ipCity", objprp.ipCity);
           ADOprp.ArrayPram[11] = new SqlParameter("@ipState", objprp.ipState);

           ADOprp.SPName = "insCommentDetail";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string UpdCommentDetail(PRPSetupTick objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[11];
           ADOprp.ArrayPram[0] = new SqlParameter("@cmtName", objprp.name);
           ADOprp.ArrayPram[1] = new SqlParameter("@cmtMobileNo", objprp.mobNo);
           ADOprp.ArrayPram[2] = new SqlParameter("@cmtEmailid", objprp.emailID);
           ADOprp.ArrayPram[3] = new SqlParameter("@cmtMessage", objprp.description);
           ADOprp.ArrayPram[4] = new SqlParameter("@newsID", objprp.codeId);
           ADOprp.ArrayPram[5] = new SqlParameter("@newsTypeId", objprp.catID);
           ADOprp.ArrayPram[6] = new SqlParameter("@pageID", objprp.uniID);
           ADOprp.ArrayPram[7] = new SqlParameter("@cmtReplyID", objprp.urlId);
           ADOprp.ArrayPram[8] = new SqlParameter("@cmtID", objprp.id);
           ADOprp.ArrayPram[9] = new SqlParameter("@isActive", objprp.isActive);
           ADOprp.ArrayPram[10] = new SqlParameter("@cmtAbouse", objprp.status);
           ADOprp.SPName = "updCommentDetail";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string DelCommentDetail(PRPSetupTick objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@cmtId", objprp.id);
           ADOprp.SPName = "delCommentDetail";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public List<PRPSetupTick> ViewMCommentDetail(PRPSetupTick prp)
       {      
           ADOprpDL.ArrayPram = new SqlParameter[4];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@newsID", prp.codeId);
           ADOprpDL.ArrayPram[1] = new SqlParameter("@newsTypeID", prp.catID);
           ADOprpDL.ArrayPram[2] = new SqlParameter("@isActive", prp.isActive);
           ADOprpDL.ArrayPram[3] = new SqlParameter("@cmtAbouse", prp.urlId);

           ADOprpDL.SPName = "viewMCommentDetail";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetupTick objprp;
           List<PRPSetupTick> lst = new List<PRPSetupTick>();
           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {                
                   objprp = new PRPSetupTick();
                   objprp.id = ADOprpDL.Dr["cmtId"].ToString();
                   objprp.name = ADOprpDL.Dr["cmtName"].ToString();
                   objprp.mobNo = ADOprpDL.Dr["cmtMobileNo"].ToString();
                   objprp.emailID = ADOprpDL.Dr["cmtEmailId"].ToString();
                   objprp.description = ADOprpDL.Dr["cmtMessage"].ToString();                   
                   objprp.isActive = ADOprpDL.Dr["isActive"].ToString();
                   objprp.DOJ = ADOprpDL.Dr["cmtDate"].ToString();
                   objprp.codeId = ADOprpDL.Dr["newsTitle"].ToString();
                   objprp.urlId = ADOprpDL.Dr["cmdAbouse"].ToString();
                   objprp.catID = ADOprpDL.Dr["newsType"].ToString();
                   objprp.uniID=  ADOprpDL.Dr["pageId"].ToString();
                   objprp.urlPrntId = ADOprpDL.Dr["cmtReplyID"].ToString();
                   lst.Add(objprp);
               }              
           }
           else
           {
               objprp = new PRPSetupTick();
               objprp.srNo = "Result Not Find";
               lst.Add(objprp);
           }
           ADO.ReaderClose(ADOprpDL);
           return lst;

       }

       public List<PRPSetupTick> viewMCommentDetail3(PRPSetupTick prp)
       {      
           ADOprpDL.ArrayPram = new SqlParameter[4];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@newsID", prp.codeId);
           ADOprpDL.ArrayPram[1] = new SqlParameter("@newsTypeID", prp.catID);
           ADOprpDL.ArrayPram[2] = new SqlParameter("@isActive", prp.isActive);
           ADOprpDL.ArrayPram[3] = new SqlParameter("@cmtAbouse", prp.urlId);

           ADOprpDL.SPName = "viewMCommentDetail3";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetupTick objprp;
           List<PRPSetupTick> lst = new List<PRPSetupTick>();
           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {                
                   objprp = new PRPSetupTick();
                   objprp.id = ADOprpDL.Dr["cmtId"].ToString();
                   objprp.name = ADOprpDL.Dr["cmtName"].ToString();
                   objprp.mobNo = ADOprpDL.Dr["cmtMobileNo"].ToString();
                   objprp.emailID = ADOprpDL.Dr["cmtEmailId"].ToString();
                   objprp.description = ADOprpDL.Dr["cmtMessage"].ToString();                   
                   objprp.isActive = ADOprpDL.Dr["isActive"].ToString();
                   objprp.DOJ = ADOprpDL.Dr["cmtDate"].ToString();
                   objprp.codeId = ADOprpDL.Dr["newsTitle"].ToString();
                   objprp.urlId = ADOprpDL.Dr["cmdAbouse"].ToString();
                   objprp.catID = ADOprpDL.Dr["newsType"].ToString();
                   objprp.uniID=  ADOprpDL.Dr["pageId"].ToString();
                   objprp.urlPrntId = ADOprpDL.Dr["cmtReplyID"].ToString();
                   lst.Add(objprp);
               }              
           }
           else
           {
               objprp = new PRPSetupTick();
               objprp.srNo = "Result Not Find";
               lst.Add(objprp);
           }
           ADO.ReaderClose(ADOprpDL);
           return lst;

       }



       public List<PRPSetupTick> viewMCommentDetail4(PRPSetupTick prp)
       {
           ADOprpDL.ArrayPram = new SqlParameter[4];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@newsID", prp.codeId);
           ADOprpDL.ArrayPram[1] = new SqlParameter("@newsTypeID", prp.catID);
           ADOprpDL.ArrayPram[2] = new SqlParameter("@isActive", prp.isActive);
           ADOprpDL.ArrayPram[3] = new SqlParameter("@cmtAbouse", prp.urlId);

           ADOprpDL.SPName = "viewMCommentDetail4";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetupTick objprp;
           List<PRPSetupTick> lst = new List<PRPSetupTick>();
           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   objprp = new PRPSetupTick();
                   objprp.id = ADOprpDL.Dr["cmtId"].ToString();
                   objprp.name = ADOprpDL.Dr["cmtName"].ToString();
                   objprp.mobNo = ADOprpDL.Dr["cmtMobileNo"].ToString();
                   objprp.emailID = ADOprpDL.Dr["cmtEmailId"].ToString();
                   objprp.description = ADOprpDL.Dr["cmtMessage"].ToString();
                   objprp.isActive = ADOprpDL.Dr["isActive"].ToString();
                   objprp.DOJ = ADOprpDL.Dr["cmtDate"].ToString();
                   objprp.codeId = ADOprpDL.Dr["newsTitle"].ToString();
                   objprp.urlId = ADOprpDL.Dr["cmdAbouse"].ToString();
                   objprp.catID = ADOprpDL.Dr["newsType"].ToString();
                   objprp.uniID = ADOprpDL.Dr["pageId"].ToString();
                   objprp.urlPrntId = ADOprpDL.Dr["cmtReplyID"].ToString();
                   lst.Add(objprp);
               }
           }
           else
           {
               objprp = new PRPSetupTick();
               objprp.srNo = "Result Not Find";
               lst.Add(objprp);
           }
           ADO.ReaderClose(ADOprpDL);
           return lst;

       }

        
       public List<PRPSetupTick> ViewSCommentDetail(PRPSetupTick prp)
       {

           ADOprpDL.ArrayPram = new SqlParameter[5];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@newsID", prp.codeId);
           ADOprpDL.ArrayPram[1] = new SqlParameter("@newsTypeID", prp.catID);
           ADOprpDL.ArrayPram[2] = new SqlParameter("@isActive", prp.isActive);
           ADOprpDL.ArrayPram[3] = new SqlParameter("@cmtAbouse", prp.urlId);
           ADOprpDL.ArrayPram[4] = new SqlParameter("@cmtID", prp.id);

           ADOprpDL.SPName = "viewSCommentDetail";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetupTick objprp;
           List<PRPSetupTick> lst = new List<PRPSetupTick>();
           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   objprp = new PRPSetupTick();
                   objprp.id = ADOprpDL.Dr["cmtId"].ToString();
                   objprp.name = ADOprpDL.Dr["cmtName"].ToString();
                   objprp.mobNo = ADOprpDL.Dr["cmtMobileNo"].ToString();
                   objprp.emailID = ADOprpDL.Dr["cmtEmailId"].ToString();
                   objprp.description = ADOprpDL.Dr["cmtMessage"].ToString();
                   objprp.isActive = ADOprpDL.Dr["isActive"].ToString();
                   objprp.DOJ = ADOprpDL.Dr["cmtDate"].ToString();
                   objprp.codeId = ADOprpDL.Dr["newsTitle"].ToString();
                   objprp.urlId = ADOprpDL.Dr["cmdAbouse"].ToString();
                   objprp.catID = ADOprpDL.Dr["newsType"].ToString();
                   objprp.uniID = ADOprpDL.Dr["pageId"].ToString();
                   objprp.urlPrntId = ADOprpDL.Dr["cmtReplyID"].ToString();
                   lst.Add(objprp);
               }
           }
           else
           {
               objprp = new PRPSetupTick();
               objprp.srNo = "Result Not Find";
               lst.Add(objprp);
           }
           ADO.ReaderClose(ADOprpDL);
           return lst;


       }
//--End Comment Detail.

     


    }
    
}