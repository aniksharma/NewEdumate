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
using nmsADOI;
using System.Collections.Generic;
namespace nmsSetupI
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
        public string InsertUniversity(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[2];
            ADOprp.ArrayPram[0] = new SqlParameter("@universityName", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@universityStatus", objprp.isActive);
            ADOprp.SPName = "InsertUniversity";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }
        public string UpdateUniversity(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[3];
            ADOprp.ArrayPram[0] = new SqlParameter("@universityName", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@universityStatus", objprp.isActive);
            ADOprp.ArrayPram[2] = new SqlParameter("@universityCodeId", objprp.id);
            ADOprp.SPName = "UpdateUniversity";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string DeleteUniversity(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@universityCodeId", objprp.id);
            ADOprp.SPName = "deleteUniversity";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public PRPSetup SelectUniversity(PRPSetup objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@universityCodeId", objprp.id);
            ADOprpDL.SPName = "SelectUniversity";

            ADO.ReaderWithProceduresandParam(ADOprpDL);

            PRPSetup obj = new PRPSetup(); ;

            if (ADOprpDL.Dr.HasRows)
            {

                while (ADOprpDL.Dr.Read())
                {
                    obj.id = ADOprpDL.Dr["uniID"].ToString();
                    obj.name = ADOprpDL.Dr["uniName"].ToString();
                    obj.isActive = ADOprpDL.Dr["uniStatus"].ToString();
                }
            }
            ADO.ReaderClose(ADOprpDL);
            return obj;
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
                    obj.pv= ADOprpDL.Dr["pv"].ToString();
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
                    objprp.pv = ADOprpDL.Dr["pv"].ToString();
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

        //News For
        public string InsNewsFor(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[2];
            ADOprp.ArrayPram[0] = new SqlParameter("@NewName", objprp.name);
            //ADOprp.ArrayPram[1] = new SqlParameter("@uniID", objprp.uniID);
            ADOprp.ArrayPram[1] = new SqlParameter("@isActive ", objprp.isActive);
            ADOprp.SPName = "SpInsertNewsFor";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string UpdNewsFor(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[3];

            ADOprp.ArrayPram[0] = new SqlParameter("@ForId", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@NewName", objprp.name);
            //ADOprp.ArrayPram[1] = new SqlParameter("@uniID", objprp.uniID);
            ADOprp.ArrayPram[2] = new SqlParameter("@isActive", objprp.isActive);
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
                }
            }
            ADO.ReaderClose(ADOprpDL);
            return obj;
        }
//News For



        //--Start--News Type.
        public string InsNewsType(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[3];
            ADOprp.ArrayPram[0] = new SqlParameter("@typeName", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@uniID", objprp.uniID);
            ADOprp.ArrayPram[2] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.SPName = "insNewsType";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string UpdNewsType(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[4];

            ADOprp.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@typeName", objprp.name);
            ADOprp.ArrayPram[2] = new SqlParameter("@uniID", objprp.uniID);
            ADOprp.ArrayPram[3] = new SqlParameter("@isActive", objprp.isActive);
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
                }
            }
            ADO.ReaderClose(ADOprpDL);
            return obj;
        }
        //public DataTable ViewNewsType(PRPSetup objprp)
        //{
        //    ADOprp.ArrayPram = new SqlParameter[1];

        //    ADOprp.ArrayPram[0] = new SqlParameter("@status", objprp.status);

        //    ADOprp.SPName = "viewNewsType";

        //    return ADO.DataTableWithProcedures(ADOprp);

        //}    
        //--End--News Type

//--Start--News.
        public string InsNews(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[8];
            ADOprp.ArrayPram[0] = new SqlParameter("@uniID", objprp.uniID);
            ADOprp.ArrayPram[1] = new SqlParameter("@catID", objprp.catID);
            ADOprp.ArrayPram[2] = new SqlParameter("@newsTitle", objprp.title);
            ADOprp.ArrayPram[3] = new SqlParameter("@newsDescription", objprp.description);
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
            ADOprpDL.ArrayPram = new SqlParameter[3];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.ArrayPram[2] = new SqlParameter("@newsUniversityID", prp.uniID);

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
                    objprp.description = ADOprpDL.Dr["newsDescription"].ToString();
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
        public List<PRPSetup> ViewNews1(PRPSetup prp)//rajender
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
                    objprp.description = ADOprpDL.Dr["newsDescription"].ToString();
                    objprp.DOJ = ADOprpDL.Dr["newsDate"].ToString();
                    objprp.status = ADOprpDL.Dr["subTitle"].ToString();
                    objprp.urlPath = ADOprpDL.Dr["newImage"].ToString();
                    objprp.catID = ADOprpDL.Dr["newsTypeId"].ToString();
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
        //public string DeleteCourse(PRPSetup objprp)
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
                objprp.id = ADOprpDL.Dr["id"].ToString();
                objprp.name = ADOprpDL.Dr["firstName"].ToString();
                objprp.mobNo = ADOprpDL.Dr["MobileNo"].ToString();
                    objprp.emailID = ADOprpDL.Dr["emailID"].ToString();
                    objprp.title = ADOprpDL.Dr["txtcatname"].ToString();
                    objprp.description = ADOprpDL.Dr["Remarks"].ToString();
                    //objprp.urlPath = ADOprpDL.Dr["subcategory"].ToString();
                    objprp.catID = ADOprpDL.Dr["subcategory"].ToString();
                    objprp.DOJ = ADOprpDL.Dr["date"].ToString();
                    objprp.status = ADOprpDL.Dr["markStatus"].ToString();
                    objprp.specilization = ADOprpDL.Dr["lastName"].ToString();
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
            ADOprp.ArrayPram = new SqlParameter[7];
            ADOprp.ArrayPram[0] = new SqlParameter("@textUniID", objprp.uniID);
            ADOprp.ArrayPram[1] = new SqlParameter("@textCatID", objprp.catID);
            ADOprp.ArrayPram[2] = new SqlParameter("@textTitle", objprp.title);
            ADOprp.ArrayPram[3] = new SqlParameter("@textDescription", objprp.description);
            ADOprp.ArrayPram[4] = new SqlParameter("@textImageUrl", objprp.urlPath);
            ADOprp.ArrayPram[5] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.ArrayPram[6] = new SqlParameter("@subTitle", objprp.status);
            ADOprp.SPName = "insText";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string UpdText(PRPSetup objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[8];
            ADOprp.ArrayPram[0] = new SqlParameter("@textID", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@textCatID", objprp.catID);
            ADOprp.ArrayPram[2] = new SqlParameter("@textUniID", objprp.uniID);
            ADOprp.ArrayPram[3] = new SqlParameter("@textTitle", objprp.title);
            ADOprp.ArrayPram[4] = new SqlParameter("@textDescription", objprp.description);
            ADOprp.ArrayPram[5] = new SqlParameter("@textImageUrl", objprp.urlPath);
            ADOprp.ArrayPram[6] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.ArrayPram[7] = new SqlParameter("@subTitle", objprp.status);
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
                    obj.status = ADOprpDL.Dr["subTitle"].ToString();
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
                    obj.status = ADOprpDL.Dr["subTitle"].ToString();
                }
            }
            ADO.ReaderClose(ADOprpDL);
            return obj;
        }
        public List<PRPSetup> ViewText(PRPSetup prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[3];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
            ADOprpDL.ArrayPram[2] = new SqlParameter("@UniId", prp.uniID);
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
                    objprp.status = ADOprpDL.Dr["subTitle"].ToString();
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


//--End Text Editor.
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
//--Start State.
       public string InsState(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@stateName", objprp.name);
           ADOprp.SPName = "insState";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string UpdState(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[2];

           ADOprp.ArrayPram[0] = new SqlParameter("@stateID", objprp.id);
           ADOprp.ArrayPram[1] = new SqlParameter("@stateName", objprp.name);
          
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

//--Start Enquiry form-------------------
       public string InsertEnquiry(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[6];

           ADOprp.ArrayPram[0] = new SqlParameter("@firstName", objprp.name);
           ADOprp.ArrayPram[1] = new SqlParameter("@lastName", objprp.fatherName);
           ADOprp.ArrayPram[2] = new SqlParameter("@emailId", objprp.emailID);
           ADOprp.ArrayPram[3] = new SqlParameter("@courseId", objprp.catID);
           ADOprp.ArrayPram[4] = new SqlParameter("@mobileNo", objprp.mobNo);
           ADOprp.ArrayPram[5] = new SqlParameter("@remarks", objprp.address);
           //  ADOprp.ArrayPram[6] = new SqlParameter("@CourseSubId", objprp.uniID);
           ADOprp.SPName = "spinsEnquiry";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string UpdateEnquiry(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[2];
           ADOprp.ArrayPram[0] = new SqlParameter("@id", objprp.id);
           ADOprp.ArrayPram[1] = new SqlParameter("@status", objprp.description);
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
                   objprp.id = ADOprpDL.Dr["Id"].ToString();
                   objprp.name = ADOprpDL.Dr["firstName"].ToString();
                   objprp.fatherName = ADOprpDL.Dr["lastName"].ToString();
                   objprp.emailID = ADOprpDL.Dr["emailId"].ToString();
                   objprp.mobNo = ADOprpDL.Dr["mobileNo"].ToString();
                   objprp.catID = ADOprpDL.Dr["courseId"].ToString();
                   objprp.address = ADOprpDL.Dr["remarks"].ToString();
                   objprp.description = ADOprpDL.Dr["markStatus"].ToString();
                   objprp.DOJ = ADOprpDL.Dr["Date"].ToString();
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

       public List<PRPSetup> ViewText1(PRPSetup prp)
       {
           ADOprpDL.ArrayPram = new SqlParameter[3];
           //ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
           ADOprpDL.ArrayPram[0] = new SqlParameter("@textcatid", prp.id);
           ADOprpDL.ArrayPram[1] = new SqlParameter("@UniId", prp.uniID);
           ADOprpDL.ArrayPram[2] = new SqlParameter("@textId", prp.codeId);
           ADOprpDL.SPName = "viewText1";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetup objprp;
           List<PRPSetup> lst = new List<PRPSetup>();
           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   objprp = new PRPSetup();
                   objprp.codeId = ADOprpDL.Dr["number"].ToString();
                   objprp.id = ADOprpDL.Dr["textID"].ToString();
                   objprp.title = ADOprpDL.Dr["textTitle"].ToString();
                   objprp.urlPath = ADOprpDL.Dr["ImagePath"].ToString();
                   objprp.description = ADOprpDL.Dr["textDescription"].ToString();
                   objprp.uniID = ADOprpDL.Dr["uniName"].ToString();
                   objprp.catID = ADOprpDL.Dr["txtCatName"].ToString();
                   objprp.isActive = ADOprpDL.Dr["isActive"].ToString();
                   objprp.status = ADOprpDL.Dr["subTitle"].ToString();

                   lst.Add(objprp);
               }
           }
           ADO.ReaderClose(ADOprpDL);
           return lst;
       }

       public List<PRPSetup> ViewText2(PRPSetup prp)
       {
           ADOprpDL.ArrayPram = new SqlParameter[2];
           //ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
           ADOprpDL.ArrayPram[0] = new SqlParameter("@textcatid", prp.id);
           ADOprpDL.ArrayPram[1] = new SqlParameter("@UniId", prp.uniID);
           ADOprpDL.SPName = "viewText2";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetup objprp;
           List<PRPSetup> lst = new List<PRPSetup>();
           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   objprp = new PRPSetup();
                   objprp.codeId = ADOprpDL.Dr["number"].ToString();
                   objprp.id = ADOprpDL.Dr["textID"].ToString();
                   objprp.title = ADOprpDL.Dr["textTitle"].ToString();
                   objprp.urlPath = ADOprpDL.Dr["ImagePath"].ToString();
                   
                   objprp.uniID = ADOprpDL.Dr["uniName"].ToString();
                   objprp.catID = ADOprpDL.Dr["txtCatName"].ToString();
                   objprp.isActive = ADOprpDL.Dr["isActive"].ToString();
                   objprp.status = ADOprpDL.Dr["subTitle"].ToString();
                   lst.Add(objprp);
               }
           }
           ADO.ReaderClose(ADOprpDL);
           return lst;
       }

       public List<PRPSetup> OtherLink(PRPSetup prp)
       {
           ADOprpDL.ArrayPram = new SqlParameter[1];
           //ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
           ADOprpDL.ArrayPram[0] = new SqlParameter("@id", prp.id);
           ADOprpDL.SPName = "viewOtherLink";
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
                   objprp.uniID = ADOprpDL.Dr["txtUniId"].ToString();
                   lst.Add(objprp);
               }
           }
           ADO.ReaderClose(ADOprpDL);
           return lst;

       }
        //11-1
       //public string DelEnquiry(PRPSetup prp)
       //{
       //    ADOprp.ArrayPram = new SqlParameter[1];

       //    ADOprp.ArrayPram[0] = new SqlParameter("@id", prp.id);

       //    ADOprp.SPName = "delInquiry";

       //    return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       //}

//--start--MasterCategory-------------------
       public string InsertMasterCategory(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[3];
           ADOprp.ArrayPram[0] = new SqlParameter("@Name", objprp.name);
           ADOprp.ArrayPram[1] = new SqlParameter("@Status", objprp.isActive);
           ADOprp.ArrayPram[2] = new SqlParameter("@collegeCod", objprp.codeId);
           ADOprp.SPName = "InsertMasterCategory";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);

       }
       public string UpdateMasterCategory(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[3];
           ADOprp.ArrayPram[0] = new SqlParameter("@Name", objprp.name);
           ADOprp.ArrayPram[1] = new SqlParameter("@Status", objprp.isActive);
           ADOprp.ArrayPram[2] = new SqlParameter("@CodeId", objprp.id);
           ADOprp.SPName = "UpdateMasterCategory";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string DeleteMasterCategory(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@CodeId", objprp.id);
           ADOprp.SPName = "deleteMasterCategory";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public PRPSetup SelectMasterCategory(PRPSetup objprp)
       {

           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@CodeId", objprp.id);
           ADOprpDL.SPName = "SelectMasterCategory";

           ADO.ReaderWithProceduresandParam(ADOprpDL);

           PRPSetup obj = new PRPSetup(); ;

           if (ADOprpDL.Dr.HasRows)
           {

               while (ADOprpDL.Dr.Read())
               {
                   obj.id = ADOprpDL.Dr["catID"].ToString();
                   obj.name = ADOprpDL.Dr["catName"].ToString();
                   obj.isActive = ADOprpDL.Dr["Status"].ToString();
               }
           }
           ADO.ReaderClose(ADOprpDL);
           return obj;
       }
       public List<PRPSetup> ViewMasterCategory(PRPSetup prp)
       {

           ADOprpDL.ArrayPram = new SqlParameter[2];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@id", prp.id);
           ADOprpDL.ArrayPram[1] = new SqlParameter("@collegeCod", prp.codeId);
           ADOprpDL.SPName = "viewMasterCategory";
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
//--End----MasterCategory-----------------------

//--Start Master Category Detail.
       public string InsMasterCatDetail(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[4];
           ADOprp.ArrayPram[0] = new SqlParameter("@catName", objprp.name);
           ADOprp.ArrayPram[1] = new SqlParameter("@uniID", objprp.uniID);
           ADOprp.ArrayPram[2] = new SqlParameter("@isActive", objprp.isActive);
           ADOprp.ArrayPram[3] = new SqlParameter("@collegeCod", objprp.codeId);
           ADOprp.SPName = "insMasterCatDetail";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string UpdMasterCatDetail(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[4];

           ADOprp.ArrayPram[0] = new SqlParameter("@catID", objprp.id);
           ADOprp.ArrayPram[1] = new SqlParameter("@catName", objprp.name);
           ADOprp.ArrayPram[2] = new SqlParameter("@uniID", objprp.uniID);
           ADOprp.ArrayPram[3] = new SqlParameter("@isActive", objprp.isActive);

           ADOprp.SPName = "updMasterCatDetail";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);


       }
       public string DelMasterCatDetail(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@catID", objprp.id);
           ADOprp.SPName = "delMasterCatDetail";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);



       }
       public PRPSetup SelMasterCatDetail(PRPSetup objprp)
       {

           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@catID", objprp.id);
           ADOprpDL.SPName = "selMasterCatDetail";

           ADO.ReaderWithProceduresandParam(ADOprpDL);

           PRPSetup obj = new PRPSetup(); ;

           if (ADOprpDL.Dr.HasRows)
           {

               while (ADOprpDL.Dr.Read())
               {
                   obj.id = ADOprpDL.Dr["detailId"].ToString();
                   obj.name = ADOprpDL.Dr["detailName"].ToString();
                   obj.isActive = ADOprpDL.Dr["isActive"].ToString();
               }
           }
           ADO.ReaderClose(ADOprpDL);
           return obj;
       }
       public DataTable ViewMasterCatDetail(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];

           ADOprp.ArrayPram[0] = new SqlParameter("@status", objprp.status);

           ADOprp.SPName = "ViewMasterCatDetail";
           return ADO.DataTableWithProcedures(ADOprp);
       }
//--End Master Category Detail.

//--Start Student Registration-------------------
       public string InsertStudentRegistration(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[10];

           ADOprp.ArrayPram[0] = new SqlParameter("@stName", objprp.name);
           ADOprp.ArrayPram[1] = new SqlParameter("@emailId", objprp.emailID);
           ADOprp.ArrayPram[2] = new SqlParameter("@mobNo", objprp.mobNo);
           ADOprp.ArrayPram[3] = new SqlParameter("@address", objprp.address);
           ADOprp.ArrayPram[4] = new SqlParameter("@doj", objprp.DOJ);
           ADOprp.ArrayPram[5] = new SqlParameter("@userName", objprp.codeId);
           ADOprp.ArrayPram[6] = new SqlParameter("@password", objprp.Password);
           ADOprp.ArrayPram[7] = new SqlParameter("@isActive", objprp.isActive);
           ADOprp.ArrayPram[8] = new SqlParameter("@imageUrl", objprp.urlPath);
           ADOprp.ArrayPram[9] = new SqlParameter("@query", objprp.Query);

           ADOprp.SPName = "insStudentRegistration";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string UpdateStudentRegistration(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[11];

           ADOprp.ArrayPram[0] = new SqlParameter("@stName", objprp.name);
           ADOprp.ArrayPram[1] = new SqlParameter("@emailId", objprp.emailID);
           ADOprp.ArrayPram[2] = new SqlParameter("@mobNo", objprp.mobNo);
           ADOprp.ArrayPram[3] = new SqlParameter("@address", objprp.address);
           ADOprp.ArrayPram[4] = new SqlParameter("@doj", objprp.DOJ);
           ADOprp.ArrayPram[5] = new SqlParameter("@userName", objprp.codeId);
           ADOprp.ArrayPram[6] = new SqlParameter("@password", objprp.Password);
           ADOprp.ArrayPram[7] = new SqlParameter("@isActive", objprp.isActive);
           ADOprp.ArrayPram[8] = new SqlParameter("@stId", objprp.id);
           ADOprp.ArrayPram[9] = new SqlParameter("@imageUrl", objprp.urlPath);
           ADOprp.ArrayPram[10] = new SqlParameter("@query", objprp.Query);
           ADOprp.SPName = "updStudentRegistration";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);

       }
       public PRPSetup SelectStudentRegistration(PRPSetup objprp)
       {

           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@stId", objprp.id);
           ADOprpDL.SPName = "selStudentRegistration";

           ADO.ReaderWithProceduresandParam(ADOprpDL);

           PRPSetup obj = new PRPSetup(); ;

           if (ADOprpDL.Dr.HasRows)
           {

               while (ADOprpDL.Dr.Read())
               {
                   obj.id = ADOprpDL.Dr["stId"].ToString();
                   obj.name = ADOprpDL.Dr["stName"].ToString();
                   obj.emailID = ADOprpDL.Dr["emailId"].ToString();
                   obj.mobNo = ADOprpDL.Dr["mobNo"].ToString();
                   obj.address = ADOprpDL.Dr["address"].ToString();
                   obj.DOJ = ADOprpDL.Dr["doj"].ToString();
                   obj.codeId = ADOprpDL.Dr["userName"].ToString();
                   obj.Password = ADOprpDL.Dr["password"].ToString();                   
                   obj.isActive = ADOprpDL.Dr["isActive"].ToString();
                   obj.urlPath = ADOprpDL.Dr["imageUrl"].ToString();
               }
           }
           ADO.ReaderClose(ADOprpDL);
           return obj;
       } 
       public List<PRPSetup> viewStudentRegistration(PRPSetup prp)
       {

           ADOprpDL.ArrayPram = new SqlParameter[2];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
           ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
           ADOprpDL.SPName = "viewStudentRegistration";
           ADO.ReaderWithProceduresandParam(ADOprpDL);

           PRPSetup objprp;
           List<PRPSetup> lst = new List<PRPSetup>();

           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   objprp = new PRPSetup();
                   objprp.id = ADOprpDL.Dr["stId"].ToString();
                   objprp.name = ADOprpDL.Dr["stName"].ToString();
                   objprp.emailID = ADOprpDL.Dr["emailId"].ToString();
                   objprp.mobNo = ADOprpDL.Dr["mobNo"].ToString();
                   objprp.address = ADOprpDL.Dr["address"].ToString();
                   objprp.DOJ = ADOprpDL.Dr["doj"].ToString();
                   objprp.codeId = ADOprpDL.Dr["userName"].ToString();
                   objprp.Password = ADOprpDL.Dr["password"].ToString();
                   objprp.isActive = ADOprpDL.Dr["isActive"].ToString();
                   objprp.urlPath = ADOprpDL.Dr["imageUrl"].ToString();
                   objprp.description = ADOprpDL.Dr["Subject"].ToString();
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
       public string DelStudentRegistration(PRPSetup prp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];

           ADOprp.ArrayPram[0] = new SqlParameter("@stId", prp.id);

           ADOprp.SPName = "delStudentRegistration";

           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public List<PRPSetup> studentSubjectDetail(PRPSetup prp)
       {
           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@stId", prp.id);


           ADOprpDL.SPName = "spStudentSubjectDetail";
           ADO.ReaderWithProceduresandParam(ADOprpDL);

           PRPSetup obj;
           List<PRPSetup> lst = new List<PRPSetup>();

           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   obj = new PRPSetup();
                   obj.id = ADOprpDL.Dr["stId"].ToString();
                   obj.codeId = ADOprpDL.Dr["subjectId"].ToString();
                   obj.catID = ADOprpDL.Dr["batchId"].ToString();
                   obj.uniID = ADOprpDL.Dr["courseId"].ToString();
                   lst.Add(obj);
               }
           }
           else
           {
               obj = new PRPSetup();
               obj.srNo = "Result Not Find";
               lst.Add(obj);
           }
           ADO.ReaderClose(ADOprpDL);
           return lst;
       }
        
//----End Student Registration-------------------
        
 //--Start Notes Detail.
       public string InsNotesDetail(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[6];
         //  ADOprp.ArrayPram[0] = new SqlParameter("@textUniID", objprp.uniID);
           ADOprp.ArrayPram[0] = new SqlParameter("@subjectId", objprp.catID);
           ADOprp.ArrayPram[1] = new SqlParameter("@notesTitle", objprp.title);
           ADOprp.ArrayPram[2] = new SqlParameter("@notesDescription", objprp.description);
           ADOprp.ArrayPram[3] = new SqlParameter("@notesImageUrl", objprp.urlPath);
           ADOprp.ArrayPram[4] = new SqlParameter("@isActive", objprp.isActive);
           ADOprp.ArrayPram[5] = new SqlParameter("@notesSubTitle", objprp.status);
           ADOprp.SPName = "insNotesDetail";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string UpdNotesDetail(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[7];
           ADOprp.ArrayPram[0] = new SqlParameter("@subjectId", objprp.catID);
           ADOprp.ArrayPram[1] = new SqlParameter("@notesTitle", objprp.title);
           ADOprp.ArrayPram[2] = new SqlParameter("@notesDescription", objprp.description);
           ADOprp.ArrayPram[3] = new SqlParameter("@notesImageUrl", objprp.urlPath);
           ADOprp.ArrayPram[4] = new SqlParameter("@isActive", objprp.isActive);
           ADOprp.ArrayPram[5] = new SqlParameter("@notesSubTitle", objprp.status);
           ADOprp.ArrayPram[6] = new SqlParameter("@notesId", objprp.id);
           ADOprp.SPName = "updNotesDetail";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string UpdNotesStatusDetail(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[2];
           ADOprp.ArrayPram[0] = new SqlParameter("@catId", objprp.catID);
        //   ADOprp.ArrayPram[1] = new SqlParameter("@admissionStatus", objprp.uniID);
           ADOprp.ArrayPram[1] = new SqlParameter("@notesId", objprp.id);
           ADOprp.SPName = "updNotesStatusDetail";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public string DelNotesDetail(PRPSetup objprp)
       {
           ADOprp.ArrayPram = new SqlParameter[1];
           ADOprp.ArrayPram[0] = new SqlParameter("@notesId", objprp.id);
           ADOprp.SPName = "delNotesDetail";
           return ADO.ScalarQueryWithProceduresandParam(ADOprp);
       }
       public PRPSetup SelNotesDetail(PRPSetup objprp)
       {
           ADOprpDL.ArrayPram = new SqlParameter[2];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@notesId", objprp.id);
           ADOprpDL.ArrayPram[1] = new SqlParameter("@collegecod", objprp.codeId);
           ADOprpDL.SPName = "selNotesDetail";
           ADO.ReaderWithProceduresandParam(ADOprpDL);

           PRPSetup obj = new PRPSetup(); ;

           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   obj = new PRPSetup();
                   obj.id = ADOprpDL.Dr["notesId"].ToString();
                   obj.title = ADOprpDL.Dr["notesTitle"].ToString();
                   obj.urlPath = ADOprpDL.Dr["notesImageUrl"].ToString();
                   obj.description = ADOprpDL.Dr["notesDescription"].ToString();
                   obj.catID = ADOprpDL.Dr["subjectId"].ToString();
                   obj.isActive = ADOprpDL.Dr["isActive"].ToString();
                   obj.status = ADOprpDL.Dr["notesSubTitle"].ToString();
               }
           }
           ADO.ReaderClose(ADOprpDL);
           return obj;
       }
       public PRPSetup SelNotesDetail1(PRPSetup objprp)
       {
           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@notesId", objprp.id);
       //    ADOprpDL.ArrayPram[1] = new SqlParameter("@catId", objprp.catID);
           ADOprpDL.SPName = "selNotesDetail1";
           ADO.ReaderWithProceduresandParam(ADOprpDL);

           PRPSetup obj = new PRPSetup(); ;

           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   obj = new PRPSetup();
                   obj.id = ADOprpDL.Dr["notesId"].ToString();
                   obj.title = ADOprpDL.Dr["notesTitle"].ToString();
                   obj.urlPath = ADOprpDL.Dr["notesImageUrl"].ToString();
                   obj.description = ADOprpDL.Dr["notesDescription"].ToString();
                   obj.catID = ADOprpDL.Dr["subjectId"].ToString();
                   obj.isActive = ADOprpDL.Dr["isActive"].ToString();
                   obj.status = ADOprpDL.Dr["notesSubTitle"].ToString();
               }
           }
           ADO.ReaderClose(ADOprpDL);
           return obj;
       }
       public List<PRPSetup> ViewNotesDetail(PRPSetup prp)
       {
           ADOprpDL.ArrayPram = new SqlParameter[4];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@pageIndex", prp.pageIndex);
           ADOprpDL.ArrayPram[1] = new SqlParameter("@pageSize", prp.pageSize);
           ADOprpDL.ArrayPram[2] = new SqlParameter("@subjectId", prp.catID);
           ADOprpDL.ArrayPram[3] = new SqlParameter("@collegeCod", prp.codeId);
           ADOprpDL.SPName = "viewNotesDetail";
           ADO.ReaderWithProceduresandParam(ADOprpDL);
           PRPSetup objprp;
           List<PRPSetup> lst = new List<PRPSetup>();
           if (ADOprpDL.Dr.HasRows)
           {
               while (ADOprpDL.Dr.Read())
               {
                   objprp = new PRPSetup();
                   objprp.id = ADOprpDL.Dr["notesId"].ToString();
                   objprp.title = ADOprpDL.Dr["notesTitle"].ToString();
                 //  objprp.urlPath = ADOprpDL.Dr["ImagePath"].ToString();
                 //  objprp.description = ADOprpDL.Dr["textDescription"].ToString();
                 //  objprp.uniID = ADOprpDL.Dr["uniName"].ToString();
                   objprp.catID = ADOprpDL.Dr["subjectName"].ToString();
                   objprp.isActive = ADOprpDL.Dr["isActive"].ToString();
                   objprp.status = ADOprpDL.Dr["notesSubTitle"].ToString();
                   objprp.srNo = ADOprpDL.Dr["Status"].ToString();
                   objprp.urlId = ADOprpDL.Dr["AdminStatus"].ToString();
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
       public List<PRPSetup> viewSubjectStudentWise(PRPSetup prp)
       {
           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@id", prp.id);
           ADOprpDL.SPName = "viewSubjectStudentWise";
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
       public List<PRPSetup> viewNotesSubjectWise(PRPSetup prp)
       {
           ADOprpDL.ArrayPram = new SqlParameter[1];
           ADOprpDL.ArrayPram[0] = new SqlParameter("@id", prp.id);
           ADOprpDL.SPName = "viewNotesSubjectWise";
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
//--End Notes Detail.


    }
    
}