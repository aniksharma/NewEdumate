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
namespace hr
{
    public class clsDLhr
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cnkids"].ConnectionString);
        SqlCommand cmd;
        SqlDataAdapter adp;
        SqlDataReader dr;
        DataSet ds;
        DataTable dt;

        public string InsRequirment(clsprophr prop)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "InstblOrganisationRequirement";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Title", prop.name);
            cmd.Parameters.AddWithValue("@Qualification", prop.Qualification);
            cmd.Parameters.AddWithValue("@Experience", prop.Experience);
            cmd.Parameters.AddWithValue("@SalaryOffer", prop.Salary);
            cmd.Parameters.AddWithValue("@InterViewDate", prop.StartDate);
            cmd.Parameters.AddWithValue("@DepartmentId ", prop.id);
            cmd.Parameters.AddWithValue("@DesignationId", prop.catid);
            cmd.Parameters.AddWithValue("@ContactPerson", prop.title);
            cmd.Parameters.AddWithValue("@MobileNo", prop.mob);
            cmd.Parameters.AddWithValue("@ContactEmailId ", prop.email);
            cmd.Parameters.AddWithValue("@JobDescription", prop.Description);
            cmd.Parameters.AddWithValue("@RequirementSchoolId", prop.uniId);
           
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            string st = "Succssfully insertd..";
            return st;
        }
        public string InsEmployeeProfile(clsprophr prop)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "InsSelectEmployeeProfile";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmployeeName", prop.title);
            cmd.Parameters.AddWithValue("@EmployeeQualification", prop.Qualification);
            cmd.Parameters.AddWithValue("@EmployeeResume", "");
            cmd.Parameters.AddWithValue("@EmployeeEmailId", prop.email);
            cmd.Parameters.AddWithValue("@EmployeeMobileNo", prop.mob);
            cmd.Parameters.AddWithValue("@EmployeeAddress ", prop.Location);
            cmd.Parameters.AddWithValue("@EmployeeCity", prop.City);
            cmd.Parameters.AddWithValue("@EmployeeDist", prop.Dist);
            cmd.Parameters.AddWithValue("@EmployeeSchoolId", prop.uniId);
            cmd.Parameters.AddWithValue("@Queery", prop.Description);

            cmd.Parameters.AddWithValue("@DepartmentAllowId", prop.catid);
            cmd.Parameters.AddWithValue("@DesignationAllowId", prop.id);
            cmd.Parameters.AddWithValue("@ReportTo", prop.Experience);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            string st = "Succssfully insertd..";
            return st;
        }
        public DataTable BindType(clsprophr prop)
        {
            SqlDataAdapter adp = new SqlDataAdapter("bindEmployeename", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@id", prop.id);
            adp.SelectCommand.Parameters.AddWithValue("@DepartmentAllowId", prop.catid);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public string InsSalaryReceive(clsprophr prop)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "InstblEmployeePaymentDetail";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PaymentAmount", prop.Salary);
            cmd.Parameters.AddWithValue("@PayMode", prop.uniId);
            cmd.Parameters.AddWithValue("@PaymentRemark", prop.Description);
            cmd.Parameters.AddWithValue("@PaymentEmployeeId", prop.id);
            cmd.Parameters.AddWithValue("@DepartmentId", prop.catid);
            cmd.Parameters.AddWithValue("@EmployeeSchoolId", prop.City);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            string st = "Succssfully insertd..";
            return st;
        }
        public string getmaxid()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SpGetEmployeeMaxId";
            cmd.CommandType = CommandType.StoredProcedure;
            string st = cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            con.Close();
           
            return st;
        }
        //Work Management
        public string InsDailyReport(clsprophr prop)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "InsEmployeeDailyReport";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ReportingEmployeeId", prop.id);
            cmd.Parameters.AddWithValue("@ReportDescription", prop.Description);
            cmd.Parameters.AddWithValue("@ReportHilite", prop.Location);
            cmd.Parameters.AddWithValue("@NextDayWork", prop.Designation);
            cmd.Parameters.AddWithValue("@ReportTitle", prop.title);
           // cmd.Parameters.AddWithValue("@EmployeeSchoolId", prop.City);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            string st = "Succssfully insertd..";
            return st;
        }
        public string UpdDailyReport(clsprophr prop)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UpdEmployeeDailyReport";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ReportingEmployeeId", prop.id);
            cmd.Parameters.AddWithValue("@ReportDescription", prop.Description);
            cmd.Parameters.AddWithValue("@ReportHilite", prop.Location);
            cmd.Parameters.AddWithValue("@NextDayWork", prop.Designation);
            cmd.Parameters.AddWithValue("@ReportTitle", prop.title);
            cmd.Parameters.AddWithValue("@Reportid", prop.catid);
            // cmd.Parameters.AddWithValue("@EmployeeSchoolId", prop.City);
            string st = cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            con.Close();
            
            return st;
        }
        public DataTable viewEmployeeDailyReport(clsprophr prop)
        {
            SqlDataAdapter adp = new SqlDataAdapter("viewEmployeeDailyReport", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@ReportingEmployeeId", prop.id);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dt.Dispose();
            adp.Dispose();
            return dt;

        }

        public clsprophr viewEmployeeDailyReportById(clsprophr pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "EmployeeDailyReportselectById";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", pr.id);
            clsprophr prp = new clsprophr();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                prp.title = dr["ReportTitle"].ToString();
                prp.Description = dr["ReportDescription"].ToString();
                prp.name = dr["NextDayWork"].ToString();
                prp.id = dr["ReportId"].ToString();
                prp.Organiser = dr["ReportHilite"].ToString();
               
            }
            dr.Dispose();
            con.Close();
            return prp;


        }

        public DataTable ViewReportBySr(clsprophr prop)
        {
            SqlDataAdapter adp = new SqlDataAdapter("ViewReportBySr", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@SrProfileId", prop.id);
            adp.SelectCommand.Parameters.AddWithValue("@ReportingEmployeeId", prop.catid);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dt.Dispose();
            adp.Dispose();
            return dt;

        }
        public string InsSrReportToJunier(clsprophr prop)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UpdSrDailyUpdate";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@remark", prop.title);
            cmd.Parameters.AddWithValue("@WorkStatus", prop.Description);
            cmd.Parameters.AddWithValue("@PoinBySr", prop.catid);
            cmd.Parameters.AddWithValue("@id", prop.id);
           // cmd.Parameters.AddWithValue("@ReportTitle", prop.title);
            // cmd.Parameters.AddWithValue("@EmployeeSchoolId", prop.City);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            string st = "Succssfully insertd..";
            return st;
        }

        // not use
        public DataTable viewEventByID(clsprophr prop)
        {
            SqlDataAdapter adp = new SqlDataAdapter("spEvenById", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@id", prop.id);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }



        public string DeleteEvent(clsprophr prop)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spDeleteEvent";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", prop.id);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            string st = "Succssfully delete..";
            return st;
        }

        //Liabarary
        public string InsLiabararyBookDetail(clsprophr prop)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "InsLiberaryBook";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BookName", prop.name);
            cmd.Parameters.AddWithValue("@BookCode", prop.catid);
            cmd.Parameters.AddWithValue("@BookSchoolId", prop.id);
            cmd.Parameters.AddWithValue("@bookPrice", prop.Salary);
            cmd.Parameters.AddWithValue("@BookWriter", prop.title);
            cmd.Parameters.AddWithValue("@IsActive", prop.Location);
            string st = cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            con.Close();
           // string st = "Succssfully insertd..";
            return st;
        }
        public List<clsprophr> viewLiabararyBookDetail(clsprophr pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "ViewLiberaryBook";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BookSchoolId", pr.id);
            cmd.Parameters.AddWithValue("@pageIndex", pr.pageIndex);
            cmd.Parameters.AddWithValue("@pageSize", pr.pageSize);
            clsprophr prp;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsprophr> lst = new List<clsprophr>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    prp = new clsprophr();
                    prp.title = dr["BookCode"].ToString();
                    prp.Description = dr["BookWriter"].ToString();
                    prp.name = dr["BookName"].ToString();
                    prp.id = dr["LibarybookId"].ToString();
                    prp.Salary = dr["bookPrice"].ToString();
                    prp.Location = dr["bookstatus"].ToString();
                    lst.Add(prp);
                }
                if (dr.NextResult())
                {
                    dr.Read();
                    prp = new clsprophr();
                    prp.noOfRecord = dr[0].ToString();
                    lst.Add(prp);
                }
            }
            else
            {
                prp = new clsprophr();
                prp.Type = "Result Not Find";
                lst.Add(prp);
            }
            dr.Dispose();
            con.Close();
            return lst;


        }

        public clsprophr viewLiabararyBookDetailById(clsprophr pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "ViewLiberaryBookById";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BookSchoolId", pr.catid);
            cmd.Parameters.AddWithValue("@LibarybookId", pr.id);
            clsprophr prp = new clsprophr();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                prp.title = dr["IsActive"].ToString();
                prp.Description = dr["BookWriter"].ToString();
                prp.name = dr["BookName"].ToString();
                prp.id = dr["LibarybookId"].ToString();
                prp.Salary = dr["bookPrice"].ToString();
                prp.catid = dr["BookCode"].ToString();

            }
            dr.Dispose();
            con.Close();
            return prp;


        }
        public string UpdLiabararyBookDetail(clsprophr prop)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UpdLiberaryBook";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BookName", prop.name);
            cmd.Parameters.AddWithValue("@BookCode", prop.catid);
            cmd.Parameters.AddWithValue("@BookSchoolId", prop.id);
            cmd.Parameters.AddWithValue("@bookPrice", prop.Salary);
            cmd.Parameters.AddWithValue("@BookWriter", prop.title);
            cmd.Parameters.AddWithValue("@IsActive", prop.Location);
            cmd.Parameters.AddWithValue("@LibarybookId", prop.uniId);
            string st = cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            con.Close();
            // string st = "Succssfully insertd..";
            return st;
        }

        public string InsKidsProfile(clsprophr prop)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "InsKidsProfileDetail";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@KName", prop.name);
            cmd.Parameters.AddWithValue("@KSchoolName", prop.title);
            cmd.Parameters.AddWithValue("@KSchoolBoard", prop.uniId);
            cmd.Parameters.AddWithValue("@KAddress", prop.Description);
            cmd.Parameters.AddWithValue("@KDOB", prop.DOB);
            cmd.Parameters.AddWithValue("@KGen", prop.Type);
            cmd.Parameters.AddWithValue("@KClass", prop.Qualification);
            cmd.Parameters.AddWithValue("@KStream", prop.id);
            cmd.Parameters.AddWithValue("@kCity", prop.City);
            cmd.Parameters.AddWithValue("@KState", prop.catid);
            cmd.Parameters.AddWithValue("@KpassWord", prop.Experience);
            cmd.Parameters.AddWithValue("@KMobNo", prop.mob);
            cmd.Parameters.AddWithValue("@KEmailId", prop.email);
            cmd.Parameters.AddWithValue("@KFname", prop.Organiser);
            cmd.Parameters.AddWithValue("@kMname", "");
            cmd.Parameters.AddWithValue("@KCountry", prop.Country);


            cmd.Parameters.AddWithValue("@CurrentStudying", prop.CurrentStudying);
            cmd.Parameters.AddWithValue("@GraduatingYrs", prop.GraduatingYrs);
            cmd.Parameters.AddWithValue("@EduIntrest", prop.EduIntrest);
            cmd.Parameters.AddWithValue("@StudyId", prop.StudyId);
            cmd.Parameters.AddWithValue("@PrefLocation", prop.PrefLocation);
            cmd.Parameters.AddWithValue("@WhenStart", prop.WhenStart);


            string st = cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            con.Close();
            return st;
        }
        public clsprophr viewKidsProfileprById(clsprophr pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "ViewKidsProfileDetailById";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@KidsProfileId", pr.id);
            clsprophr prp = new clsprophr();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                prp.name = dr["KName"].ToString();
                prp.title = dr["KSchoolName"].ToString();
                prp.uniId = dr["KSchoolBoard"].ToString();
                prp.Description = dr["KAddress"].ToString();
                prp.DOB = dr["KDOB"].ToString();
                prp.Type = dr["KGen"].ToString();
                prp.Qualification = dr["KClass"].ToString();
                prp.mob = dr["KMobNo"].ToString();
                prp.email = dr["KEmailId"].ToString();
                prp.Organiser = dr["KFname"].ToString();
                prp.Designation = dr["kMname"].ToString();
                prp.catid = dr["KidsProfileId"].ToString();
            }
            dr.Dispose();
            con.Close();
            return prp;


        }
        public string InsTutorProfilesaliman(clsprophr prop)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "InsTutorProfileDetail_saliman";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@KName", prop.name);
            cmd.Parameters.AddWithValue("@kCity", prop.city);
            cmd.Parameters.AddWithValue("@collegeDistrict", prop.district);
            cmd.Parameters.AddWithValue("@KState", prop.state);
            cmd.Parameters.AddWithValue("@KCountry", prop.Country);
            cmd.Parameters.AddWithValue("@CollegeType", prop.status);
            cmd.Parameters.AddWithValue("@educationType", prop.EduIntrest);
            cmd.Parameters.AddWithValue("@rank", prop.rank);
            cmd.Parameters.AddWithValue("@grade", prop.grade);
            cmd.Parameters.AddWithValue("@collegePhone", prop.phoneNo);
            cmd.Parameters.AddWithValue("@KEmailId", prop.email);
            cmd.Parameters.AddWithValue("@collegeAddress", prop.address);
            cmd.Parameters.AddWithValue("@collegeStatus", prop.isActive);
            cmd.Parameters.AddWithValue("@KMobNo", prop.mob);
            cmd.Parameters.AddWithValue("@collegeDate", prop.StartDate);
            cmd.Parameters.AddWithValue("@faxNo", prop.phoneNo);
            cmd.Parameters.AddWithValue("@nemail", "1");
            cmd.Parameters.AddWithValue("@ndaily", prop.nneDaily);
            cmd.Parameters.AddWithValue("@pinCode", prop.pinCode);
            cmd.Parameters.AddWithValue("@LoginType", prop.title);
            cmd.Parameters.AddWithValue("@KpassWord", prop.Password);
            cmd.Parameters.AddWithValue("@nesms", prop.nneSMS);
            cmd.Parameters.AddWithValue("@otherLocation", prop.Location);
            cmd.Parameters.AddWithValue("@tutionType", prop.tutionType);
            cmd.Parameters.AddWithValue("@age", prop.DOB);
            cmd.Parameters.AddWithValue("@KGen", prop.marital);
            cmd.Parameters.AddWithValue("@shortDescription", prop.description);
            cmd.Parameters.AddWithValue("@longDescription", prop.mainLandMark);
            cmd.Parameters.AddWithValue("@bestTimeToCall", prop.AssociateName);
            cmd.Parameters.AddWithValue("@query", prop.urlName);
            cmd.Parameters.AddWithValue("@Category", prop.catid);
            cmd.Parameters.AddWithValue("@SubCategory", prop.GraduatingYrs);
            string st = cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            con.Close();
            return st;
        }
        public string UpdKidsProfile(clsprophr prop)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UpdKidsProfileDetail";
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.AddWithValue("@KName", prop.name);
            cmd.Parameters.AddWithValue("@KSchoolName", prop.title);
            cmd.Parameters.AddWithValue("@KSchoolBoard", prop.uniId);
            cmd.Parameters.AddWithValue("@KAddress", prop.Description);
            cmd.Parameters.AddWithValue("@KDOB", prop.DOB);
            cmd.Parameters.AddWithValue("@KGen", prop.Type);
            //cmd.Parameters.AddWithValue("@KClass", prop.Qualification);
            // cmd.Parameters.AddWithValue("@KStream", prop.id);
            // cmd.Parameters.AddWithValue("@kCity", prop.City);
            cmd.Parameters.AddWithValue("@KidsProfileId", prop.catid);
            cmd.Parameters.AddWithValue("@KMobNo", prop.mob);
            cmd.Parameters.AddWithValue("@KEmailId", prop.email);
            cmd.Parameters.AddWithValue("@KFname", prop.Organiser);
            cmd.Parameters.AddWithValue("@kMname", prop.Designation);
            cmd.Parameters.AddWithValue("@siteName", prop.urlName);
            string st = cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            con.Close();
            return st;
        }

        public string InsTutorProfile(clsprophr prop)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "InsTutorProfileDetail";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@KName", prop.name);
            cmd.Parameters.AddWithValue("@kCity", prop.city);
            cmd.Parameters.AddWithValue("@collegeDistrict", prop.district);
            cmd.Parameters.AddWithValue("@KState", prop.state);
            cmd.Parameters.AddWithValue("@KCountry", prop.Country);
            cmd.Parameters.AddWithValue("@CollegeType", prop.status);
            cmd.Parameters.AddWithValue("@educationType", prop.EduIntrest );
            cmd.Parameters.AddWithValue("@rank", prop.rank);
            cmd.Parameters.AddWithValue("@grade", prop.grade);
            cmd.Parameters.AddWithValue("@collegePhone", prop.phoneNo);
            cmd.Parameters.AddWithValue("@KEmailId", prop.email);
            cmd.Parameters.AddWithValue("@collegeAddress", prop.address);
            cmd.Parameters.AddWithValue("@collegeStatus", prop.isActive);
            cmd.Parameters.AddWithValue("@KMobNo", prop.mob);
            cmd.Parameters.AddWithValue("@collegeDate", prop.StartDate);
            cmd.Parameters.AddWithValue("@faxNo", prop.phoneNo);
            cmd.Parameters.AddWithValue("@nemail", "1");
            cmd.Parameters.AddWithValue("@ndaily", prop.nneDaily);
            cmd.Parameters.AddWithValue("@pinCode", prop.pinCode);
            cmd.Parameters.AddWithValue("@LoginType", prop.title);
            cmd.Parameters.AddWithValue("@KpassWord", prop.Password);
            cmd.Parameters.AddWithValue("@nesms", prop.nneSMS);
            cmd.Parameters.AddWithValue("@otherLocation", prop.Location);
            cmd.Parameters.AddWithValue("@tutionType", prop.tutionType);
            cmd.Parameters.AddWithValue("@age", prop.DOB);
            cmd.Parameters.AddWithValue("@KGen", prop.marital);
            cmd.Parameters.AddWithValue("@shortDescription", prop.description);
            cmd.Parameters.AddWithValue("@longDescription", prop.mainLandMark);
            cmd.Parameters.AddWithValue("@bestTimeToCall", prop.AssociateName);
            cmd.Parameters.AddWithValue("@query", prop.urlName);
            //cmd.Parameters.AddWithValue("@Category", prop.catid);
            //cmd.Parameters.AddWithValue("@SubCategory", prop.subCategory);
            //cmd.Parameters.AddWithValue("@logopath", prop.sCollegeLogo);
            //cmd.Parameters.AddWithValue("@Affiliated", prop.Affiliated);
            //cmd.Parameters.AddWithValue("@CourseLevel", prop.CourseLevel);
            //cmd.Parameters.AddWithValue("@University", prop.id);
            string st = cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            con.Close();
            return st;
        }
        public string UpTutorProfile(clsprophr prop)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UpTutorProfileDetail";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CollegeId", prop.email);
           cmd.Parameters.AddWithValue("@KName", prop.name);
           cmd.Parameters.AddWithValue("@kCity", prop.city);
            cmd.Parameters.AddWithValue("@collegeDistrict", prop.district);
            cmd.Parameters.AddWithValue("@KState", prop.state);
            cmd.Parameters.AddWithValue("@KCountry", prop.Country);
           // cmd.Parameters.AddWithValue("@KEmailId", prop.email);
            cmd.Parameters.AddWithValue("@KMobNo", prop.mob);
            cmd.Parameters.AddWithValue("@tutionType", prop.tutionType);
            cmd.Parameters.AddWithValue("@Collegeaddress", prop.address);
            cmd.Parameters.AddWithValue("@shortDescription", prop.description);
            cmd.Parameters.AddWithValue("@longDescription", prop.mainLandMark);
            cmd.Parameters.AddWithValue("@bestTimeToCall", prop.AssociateName);
            cmd.Parameters.AddWithValue("@age", prop.DOB);
            cmd.Parameters.AddWithValue("@KGen", prop.Type);
           cmd.Parameters.AddWithValue("@CollegeStatus", prop.status);
           cmd.Parameters.AddWithValue("@query", prop.Salary);
           cmd.Parameters.AddWithValue("@pinCode", prop.pinCode);
           cmd.Parameters.AddWithValue("@faxNo", prop.phoneNo);
           cmd.Parameters.AddWithValue("@siteName", prop.urlName);
           // cmd.Parameters.AddWithValue("@educationType", prop.EduIntrest);
           //cmd.Parameters.AddWithValue("@grade", prop.grade);          
           // cmd.Parameters.AddWithValue("@LoginType", prop.title);
          //  cmd.Parameters.AddWithValue("@otherLocation", prop.Location);
           // cmd.Parameters.AddWithValue("@query", prop.urlName);
            string st = cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            con.Close();
            return st;
        }
        public clsprophr viewTutorProfileprById(clsprophr pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "ViewKidsProfileDetailById";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@KidsProfileId", pr.id);
            clsprophr prp = new clsprophr();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                prp.name = dr["KName"].ToString();
                prp.title = dr["KSchoolName"].ToString();
                prp.uniId = dr["KSchoolBoard"].ToString();
                prp.Description = dr["KAddress"].ToString();
                prp.DOB = dr["KDOB"].ToString();
                prp.Type = dr["KGen"].ToString();
                prp.Qualification = dr["KClass"].ToString();
                prp.mob = dr["KMobNo"].ToString();
                prp.email = dr["KEmailId"].ToString();
                prp.Organiser = dr["KFname"].ToString();
                prp.Designation = dr["kMname"].ToString();
                prp.catid = dr["KidsProfileId"].ToString();
            }
            dr.Dispose();
            con.Close();
            return prp;


        }
       
      
      
    }
}






