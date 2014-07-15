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

using BusEntry;
namespace BusEntry
{
    public class DL1
    {
        prp pr = new prp();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn1"].ConnectionString);
        SqlCommand cmd = new SqlCommand();

        public String Insert(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.CommandText = "spInsert";
            cmd.Parameters.AddWithValue("@BusNo", pr.PBusNO);
            cmd.Parameters.AddWithValue("@BusModel", pr.PBusModel);
            cmd.Parameters.AddWithValue("@BusCompany", pr.PBusCompany);
            cmd.Parameters.AddWithValue("@BusCondition", pr.PBusCondition);
            cmd.Parameters.AddWithValue("@BusAddDate", pr.PBusAddDate);
            cmd.Parameters.AddWithValue("@BusStatus", pr.PBusStatus);
            cmd.Parameters.AddWithValue("@SchoolID", pr.PSchoolID);
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
            
            string st="Succesfully Insert";
            return st;
        }


        public DataSet ShowData(prp prp)
        {
            SqlDataAdapter adp = new SqlDataAdapter("spShow", con);
            adp.SelectCommand.Parameters.AddWithValue("@schoolID",prp.PSchoolID);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure; 
            DataSet ds = new DataSet();
            adp.Fill(ds);
           
            con.Close();
            return ds;
        }
        public string Delete(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spdelete";
            cmd.Parameters.AddWithValue("@BusId", pr.PBusID);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
           
            String st = "Sucessfully Delete";
            return st;
        }

        public prp Select(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spshowbyID";
            cmd.Parameters.AddWithValue("@BusID", pr.PBusID);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                pr.PBusNO = dr["BusNo"].ToString();
                pr.PBusModel = dr["BusModel"].ToString();
                pr.PBusCompany = dr["BusCompany"].ToString();
                pr.PBusCondition = dr["BusCondition"].ToString();
                pr.PBusAddDate = dr["BusAddDate"].ToString();
                pr.PBusStatus = dr["BusStatus"].ToString();
                pr.PSchoolID = dr["SchoolId"].ToString();
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return pr;
       
        }
        public string Update(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.CommandText = "spUpdate";
            cmd.Parameters.AddWithValue("@BusID", pr.PBusID);
            cmd.Parameters.AddWithValue("@BusNo", pr.PBusNO);
            cmd.Parameters.AddWithValue("@BusModel", pr.PBusModel);
            cmd.Parameters.AddWithValue("@BusCompany", pr.PBusCompany);
            cmd.Parameters.AddWithValue("@BusCondition", pr.PBusCondition);
            cmd.Parameters.AddWithValue("@BusAddDate", pr.PBusAddDate);
            cmd.Parameters.AddWithValue("@BusStatus", pr.PBusStatus);

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
          
            string st = "Updated";
            return st;
        }
        public string RouteInsert(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.CommandText = "spInsertRoute";
            cmd.Parameters.AddWithValue("@RouteName", pr.PRouteName);
            cmd.Parameters.AddWithValue("@StartPoint", pr.PStartPoint);
            cmd.Parameters.AddWithValue("@EndingPoint", pr.PEndingPoint);
            cmd.Parameters.AddWithValue("@RouteAddDate", pr.PRouteAddDate);
            cmd.Parameters.AddWithValue("@RouteStatus", pr.PRouteStatus);
            cmd.Parameters.AddWithValue("@SchoolID", pr.PSchoolID);
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
          
            string st = "Inserted";
            return st;
        }
        public DataSet RouteShowData( prp prp )
        {
            SqlDataAdapter adp = new SqlDataAdapter("spShowRoute", con);
            adp.SelectCommand.Parameters.AddWithValue("@schoolID", prp.PSchoolID);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure; 
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }
        public string DeleteRoute(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spDeleteRoute";
            cmd.Parameters.AddWithValue("@RouteID", pr.PRouteID);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
          
           
            string st = "Deleted";
            return st;
        }
        public prp SelectRoute(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spRouteShowByID";
            cmd.Parameters.AddWithValue("@RouteID", pr.PRouteID);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                pr.PRouteName = dr["RouteName"].ToString();
                pr.PStartPoint = dr["StartPoint"].ToString();
                pr.PEndingPoint = dr["EndingPoint"].ToString();
                pr.PRouteAddDate = dr["RouteAddDate"].ToString();

                pr.PRouteStatus = dr["RouteStatus"].ToString();
                pr.PSchoolID = dr["SchoolId"].ToString();
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return pr;
        }
        public string UpdateRoute(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.CommandText = "spUpdateRoute";
            cmd.Parameters.AddWithValue("@RouteID", pr.PRouteID);
            cmd.Parameters.AddWithValue("@RouteName", pr.PRouteName);
            cmd.Parameters.AddWithValue("@StartPoint", pr.PStartPoint);
            cmd.Parameters.AddWithValue("@EndingPoint", pr.PEndingPoint);
            cmd.Parameters.AddWithValue("@RouteAddDate", pr.PRouteAddDate);
            cmd.Parameters.AddWithValue("@RouteStatus", pr.PRouteStatus);


            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
            string st = "Updated";
            return st;
            
        }
        public string StopsInsert(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.CommandText = "spInsertStops";
            cmd.Parameters.AddWithValue("@StopsName", pr.PStopesName);
            cmd.Parameters.AddWithValue("@StopesRouteID", pr.PStopesID);
            cmd.Parameters.AddWithValue("@Distance", pr.PDistance);
            cmd.Parameters.AddWithValue("@Remark", pr.PRemark);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            string st = "Inserted";
            return st;
           
        }
        public DataSet StopesShowData(prp prp)
        {
            SqlDataAdapter adp = new SqlDataAdapter("spShowStops", con);
            adp.SelectCommand.Parameters.AddWithValue("@schoolId",prp.PSchoolID);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure; 
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }
        public DataSet DropListBoundData( prp prp)
        {
            SqlDataAdapter ad = new SqlDataAdapter("spDropList", con);
            ad.SelectCommand.Parameters.AddWithValue("@schoolid",prp.PSchoolID);
            ad.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            ad.Fill(ds);
            return ds;
        }
        public string DeleteStopes(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spDeleteStopes";
            cmd.Parameters.AddWithValue("@StopesID", pr.PStopesID);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
          
            String st = "Sucessfully Delete";
            return st;
        }
        public prp selectStopes(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spSelectStopesByID";
            cmd.Parameters.AddWithValue("@StopesID", pr.PStopesID);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                ////pr.PStopesID=Convert.ToString(
                pr.PStopesName = dr["StopesName"].ToString();
                pr.PDistance = dr["Distance"].ToString();
                pr.PRemark = dr["Remark"].ToString();
                pr.PRouteID = dr["RouteID"].ToString();
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return pr;
        }
        public string updatestopes(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.CommandText = "spUpdateStops";
            cmd.Parameters.AddWithValue("@StopesID", pr.PStopesID);
            cmd.Parameters.AddWithValue("@StopesName", pr.PStopesName);
            cmd.Parameters.AddWithValue("@StopesRouteID", pr.PRouteID);
            cmd.Parameters.AddWithValue("@Distance", pr.PDistance);
            cmd.Parameters.AddWithValue("@Remark", pr.PRemark);


            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
            string st = "Updated";
            return st;
        }
        public DataSet BusRouteShowData(prp prp)
        {
            SqlDataAdapter adp = new SqlDataAdapter("spShowBusRoute", con);
            adp.SelectCommand.Parameters.AddWithValue("@schoolid", prp.PSchoolID);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure; 
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }
        public DataSet DD1BoundData(prp prp)
        {
            SqlDataAdapter DD1 = new SqlDataAdapter("spDropList", con);
            DD1.SelectCommand.Parameters.AddWithValue("@schoolid", prp.PSchoolID); 
            DD1.SelectCommand.CommandType = CommandType.StoredProcedure; 

            DataSet ds = new DataSet();
            DD1.Fill(ds);
            return ds;
        }
        public DataSet DD2BoundData(prp prp)
        {
            SqlDataAdapter DD2 = new SqlDataAdapter("spDD2List", con);
            DD2.SelectCommand.Parameters.AddWithValue("@schoolid", prp.PSchoolID);
            DD2.SelectCommand.CommandType = CommandType.StoredProcedure; 
            DataSet ds = new DataSet();
            DD2.Fill(ds);
            return ds;
        }
        public string BusRouteInsert(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.CommandText = "spBusRouteInsert";
            cmd.Parameters.AddWithValue("@RouteID", pr.PRouteID);
            cmd.Parameters.AddWithValue("@BusID", pr.PBusID);
            cmd.Parameters.AddWithValue("@StartDate", pr.PStartDate);
            cmd.Parameters.AddWithValue("@EndDate", pr.PEndDate);
            cmd.Parameters.AddWithValue("@MorngStarttime", pr.PMorngStarttime);
            cmd.Parameters.AddWithValue("@MorngEndtime", pr.PMorngEndtime);
            cmd.Parameters.AddWithValue("@Evngstarttime", pr.PEvngstarttime);
            cmd.Parameters.AddWithValue("@Evngendtime", pr.PEvngendtime);
            cmd.Parameters.AddWithValue("@BusRouteStatus", pr.PBusRouteStatus);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            string st = "Inserted";
            return st;
            
        }
        public prp selectBusRoute(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spSelectRouteByID";
            cmd.Parameters.AddWithValue("@BusRouteID", pr.PStopesID);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                pr.PRouteID = dr["RouteID"].ToString();
                pr.PBusID = dr["BusID"].ToString();
                pr.PStartDate = dr["StartDate"].ToString();
                pr.PEndDate = dr["EndDate"].ToString();
                pr.PMorngStarttime = dr["MorngStarttime"].ToString();
                pr.PMorngEndtime = dr["MorngEndtime"].ToString();
                pr.PEvngstarttime = dr["Evngstarttime"].ToString();
                pr.PEvngendtime = dr["Evngendtime"].ToString();
                pr.PBusRouteStatus = dr["BusRouteStatus"].ToString();
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return pr;
        }
        public string updateBusRoute(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spBusRouteUpdate";
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@BusRouteID", pr.PBusRouteID);
            cmd.Parameters.AddWithValue("@RouteID", pr.PRouteID);
            cmd.Parameters.AddWithValue("@BusID", pr.PBusID);
            cmd.Parameters.AddWithValue("@StartDate", pr.PStartDate);
            cmd.Parameters.AddWithValue("@EndDate", pr.PEndDate);
            cmd.Parameters.AddWithValue("@MorngStartTime", pr.PMorngStarttime);
            cmd.Parameters.AddWithValue("@MorngEndtime", pr.PMorngEndtime);
            cmd.Parameters.AddWithValue("@Evngstarttime", pr.PEvngstarttime);
            cmd.Parameters.AddWithValue("@Evngendtime", pr.PEvngendtime);
            cmd.Parameters.AddWithValue("@BusRouteStatus", pr.PBusRouteStatus);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            string st = "updated";
            return st;
        }
        public string DeleteBusRoute(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spDeleteBusRoute";
            cmd.Parameters.AddWithValue("@BusRouteID", pr.PBusRouteID);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            string st = "Deleted";
            return st;
        }
        public DataSet DDLBusBoundData()
        {
            SqlDataAdapter DDL = new SqlDataAdapter("spDDLBus", con);
            DataSet ds = new DataSet();
            DDL.Fill(ds);
            return ds;
        }
        public DataSet DDLDriverBoundData()
        {
            SqlDataAdapter DDL = new SqlDataAdapter("spDDLDriver", con);
            DataSet ds = new DataSet();
            DDL.Fill(ds);
            return ds;
        }
        public string BusDriverInsert(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd.Connection = con;
            cmd.CommandText = "spBusDriverInsert";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BusID", pr.PBusID);
            cmd.Parameters.AddWithValue("@DriverID", pr.PStaffID);
            cmd.Parameters.AddWithValue("@startDate", pr.PstartDate);
            cmd.Parameters.AddWithValue("@Enddate", pr.PEnddate);
            cmd.Parameters.AddWithValue("@DriverStatus", pr.PDriverStatus);
            cmd.Parameters.AddWithValue("@Remark", pr.PRemark);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            string st = "Inserted";
            return st;
        }
        public DataSet BusDriverShowData()
        {
            SqlDataAdapter adp = new SqlDataAdapter("BusDriverShowData", con);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }
        public prp BusDriverSelect(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "BusDriverSelect";
            cmd.Parameters.AddWithValue("@BusdriverID", pr.PBusDriverID);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                pr.PBusID = dr["BusID"].ToString();
                pr.PStaffID = dr["StaffID"].ToString();
                pr.PstartDate = dr["startDate"].ToString();
                pr.PEnddate = dr["Enddate"].ToString();
                pr.PDriverStatus = dr["DriverStatus"].ToString();
                pr.PRemark = dr["Remark"].ToString();
                
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return pr;
        }

        public string BusDriverUpdate(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "BusDriverUpdate";
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@BusdriverID", pr.PBusDriverID);
            cmd.Parameters.AddWithValue("@BusID", pr.PBusID);
            cmd.Parameters.AddWithValue("@DriverID", pr.PStaffID);
            cmd.Parameters.AddWithValue("@startDate", pr.PstartDate);
            cmd.Parameters.AddWithValue("@Enddate", pr.PEnddate);
            cmd.Parameters.AddWithValue("@DriverStatus", pr.PDriverStatus);
            cmd.Parameters.AddWithValue("@Remark", pr.PRemark);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            string st = "updated";
            return st;
        }
        public string DeleteBusDriver(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spDeleteBusDriver";
            cmd.Parameters.AddWithValue("@BusdriverID", pr.PBusDriverID);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            string st = "Deleted";
            return st;
        }
        public DataSet DDLBus1()
        {
            SqlDataAdapter adp = new SqlDataAdapter("spDDLBus", con);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }
        public DataSet DDLStops1()
        {
            SqlDataAdapter adp = new SqlDataAdapter("spDDLStops", con);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }
        public DataSet BusstudentShowData()
        {
            SqlDataAdapter adp = new SqlDataAdapter("BusstudentShowData", con);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }
        public string BusStudentInsert(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd.Connection = con;
            cmd.CommandText = "spBusStudentInsert";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StudentID", pr.PStudentBusID);
            cmd.Parameters.AddWithValue("@BusID", pr.PBusID);
            cmd.Parameters.AddWithValue("@StartDate", pr.PStartDate);
            cmd.Parameters.AddWithValue("@EndDate", pr.PEndDate);
            cmd.Parameters.AddWithValue("@StudentStatus", pr.PStudentStatus);
            cmd.Parameters.AddWithValue("@StopsID", pr.PStopesID);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            string st = "Inserted";
            return st;
        }
        public prp BusStudentSelect(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "BusStudentSelect";
            cmd.Parameters.AddWithValue("@StudentBusID", pr.PStudentBusID);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                pr.PStudentID = dr["StudentID"].ToString();
                pr.PBusID = dr["BusID"].ToString();
                pr.PStartDate = dr["StartDate"].ToString();
                pr.PEndDate = dr["EndDate"].ToString();
                pr.PStudentStatus = dr["StudentStatus"].ToString();
                pr.PStopesID = dr["StopesID"].ToString();

            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return pr;
        }
        public string BusStudentUpdate(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "BusStudentUpdate";
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@StudentID", pr.PStudentID);

            cmd.Parameters.AddWithValue("@StudentBusID", pr.PStudentBusID);
            
            cmd.Parameters.AddWithValue("@BusID", pr.PBusID);
            cmd.Parameters.AddWithValue("@StartDate", pr.PStartDate);
            cmd.Parameters.AddWithValue("@EndDate", pr.PEndDate);
            cmd.Parameters.AddWithValue("@StudentStatus", pr.PStudentStatus);
            cmd.Parameters.AddWithValue("@StopsID", pr.PStopesID);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            string st = "updated";
            return st;
        }
        public string DeleteBusStudent(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DeleteBusStudent";
            cmd.Parameters.AddWithValue("@StudentBusID", pr.PStudentBusID);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            string st = "Deleted";
            return st;
        }





      public String InsertCategory(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.CommandText = "spInsertCategory";
            cmd.Parameters.AddWithValue("@CategoryName", pr.PCategoryName);
            cmd.Parameters.AddWithValue("@SchoolID", pr.PSchoolID);
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
            string st = "Succesfully Insert";
            return st;
        }
        public DataSet ShowCategory( string schoolid )
        {
            SqlDataAdapter adp = new SqlDataAdapter("spShowCat", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@schoolId",schoolid);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            con.Close();
            return ds;
        }
        public prp SelectCategory(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spShowCatByID";
            cmd.Parameters.AddWithValue("@CategoryID", pr.PCategoryID);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                pr.PSchoolID = dr["SchoolID"].ToString();
                pr.PCategoryName = dr["CategoryName"].ToString();

            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return pr;

        }
        public string UpdateCategory(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.CommandText = "spUpdateCategory";
            cmd.Parameters.AddWithValue("@CategoryID", pr.PCategoryID);
            cmd.Parameters.AddWithValue("@CategoryName", pr.PCategoryName);
           

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();

            string st = "Updated";
            return st;
        }
        public string DeleteCategory(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spDeleteCat";
            cmd.Parameters.AddWithValue("@CategoryID", pr.PCategoryID);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

            String st = "Sucessfully Delete";
            return st;
        }
        public DataSet DDLCategory(string schoolid )
        {
            SqlDataAdapter adp = new SqlDataAdapter("spDDLCategory", con);
            adp.SelectCommand.Parameters.AddWithValue("@schoolId",schoolid);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            con.Close();
            return ds;
        }
        public String InsertProduct(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.CommandText = "spInsertProduct";
            cmd.Parameters.AddWithValue("@CategoryID", pr.PCategoryID);
            cmd.Parameters.AddWithValue("@SchoolID", pr.PSchoolID);
            cmd.Parameters.AddWithValue("@ProductName", pr.PProductName);
            cmd.Parameters.AddWithValue("@ProductType", pr.PProductType);
            cmd.Parameters.AddWithValue("@ProductDescripation", pr.PProductDescripation);
          //  cmd.Parameters.AddWithValue("@ProductEntryDate", pr.PProductEntryDate);

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
            string st = "Succesfully Insert";
            return st;
        }
        public DataSet ShowProduct(string schoolid )
        {
            SqlDataAdapter adp = new SqlDataAdapter("spShowProduct", con);
            adp.SelectCommand.Parameters.AddWithValue("@schoolId",schoolid);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure; 
            DataSet ds = new DataSet();
            adp.Fill(ds);

            con.Close();
            return ds;
        }
        public prp SelectProduct(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spSelectProduct";
            cmd.Parameters.AddWithValue("@ProductID", pr.PProductID);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                pr.PSchoolID = dr["SchoolID"].ToString();
                pr.PCategoryID = dr["CategoryID"].ToString();
                pr.PProductName = dr["ProductName"].ToString();
                pr.PProductType = dr["ProductType"].ToString();
                pr.PProductDescripation = dr["ProductDescripation"].ToString();
                pr.PProductEntryDate = dr["ProductEntryDate"].ToString();

            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return pr;

        }
        public string UpdateProduct(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.CommandText = "spUpdateProduct";
            cmd.Parameters.AddWithValue("@ProductID", pr.PProductID);
           // cmd.Parameters.AddWithValue("@SchoolID", pr.PSchoolID);
            cmd.Parameters.AddWithValue("@CategoryID", pr.PCategoryID);
            cmd.Parameters.AddWithValue("@ProductName", pr.PProductName);
            cmd.Parameters.AddWithValue("@ProductType", pr.PProductType);
            cmd.Parameters.AddWithValue("@ProductDescripation", pr.PProductDescripation);
           // cmd.Parameters.AddWithValue("@ProductEntryDate", pr.PProductEntryDate);


            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();

            string st = "Updated";
            return st;
        }
        public string DeleteProduct(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spDeleteProduct";
            cmd.Parameters.AddWithValue("@ProductID", pr.PProductID);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

            String st = "Sucessfully Delete";
            return st;
        }
        public String InsertParty(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.CommandText = "spInsertParty";
            cmd.Parameters.AddWithValue("@PartyName", pr.PPartyName);
            cmd.Parameters.AddWithValue("@Location ", pr.PLocation);
            cmd.Parameters.AddWithValue("@PartyType", pr.PPartyType);
            cmd.Parameters.AddWithValue("@PartyDescripation", pr.PPartyDescripation);
            cmd.Parameters.AddWithValue("@ContactNo", pr.PContactNo);
            cmd.Parameters.AddWithValue("@EmailID", pr.PEmailID);
            cmd.Parameters.AddWithValue("@schoolid", pr.PSchoolID);

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
            string st = "Succesfully Insert";
            return st;
        }
        public DataSet ShowParty(string schoolid )
        {
            SqlDataAdapter adp = new SqlDataAdapter("spShowParty", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@schoolId",schoolid);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            con.Close();
            return ds;
        }
        public prp SelectParty(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spSelectParty";
            cmd.Parameters.AddWithValue("@PartyID", pr.PPartyID);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                pr.PPartyName = dr["PartyName"].ToString();
                pr.PLocation = dr["Location"].ToString();
                pr.PPartyType = dr["PartyType"].ToString();
                pr.PPartyDescripation = dr["PartyDescripation"].ToString();
                pr.PContactNo = dr["ContactNo"].ToString();
                pr.PEmailID = dr["EmailID"].ToString();
                pr.PPartyAddDate = dr["PartyAddDate"].ToString();

            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return pr;

        }
        public string UpdateParty(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.CommandText = "spUpdateParty";
            cmd.Parameters.AddWithValue("@PartyID", pr.PPartyID);
            cmd.Parameters.AddWithValue("@PartyName", pr.PPartyName);
            cmd.Parameters.AddWithValue("@Location", pr.PLocation);
            cmd.Parameters.AddWithValue("@PartyType", pr.PPartyType);
            cmd.Parameters.AddWithValue("@PartyDescripation", pr.PPartyDescripation);
            cmd.Parameters.AddWithValue("@ContactNo", pr.PContactNo);
            cmd.Parameters.AddWithValue("@EmailID", pr.PEmailID);



            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();

            string st = "Updated";
            return st;
        }
        public string DeleteParty(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spDeleteParty";
            cmd.Parameters.AddWithValue("@PartyID", pr.PPartyID);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

            String st = "Sucessfully Delete";
            return st;
        }
        public String InsertOrder(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.CommandText = "spInsertOrder";
            cmd.Parameters.AddWithValue("@SchoolID", pr.PSchoolID);
            cmd.Parameters.AddWithValue("@OrderNo", pr.POrderNo);
            cmd.Parameters.AddWithValue("@ProductID", pr.PProductID);
            cmd.Parameters.AddWithValue("@TotalQuantity", pr.PTotalQuantity);
            cmd.Parameters.AddWithValue("@PaymentType", pr.PPayementType);
            cmd.Parameters.AddWithValue("@Amount", pr.PAmount);
            cmd.Parameters.AddWithValue("@Discount", pr.PDiscount);
            cmd.Parameters.AddWithValue("@PartyID", pr.PPartyID);
            cmd.Parameters.AddWithValue("@OrderDate", pr.POrderDate);
            cmd.Parameters.AddWithValue("OrderStatusID", pr.POrderStatusID);
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
            string st = "Succesfully Insert";
            return st;
        }
        public DataSet DDLProduct(string schoolid)
        {
            SqlDataAdapter adp = new SqlDataAdapter("spDDLProduct", con);
            adp.SelectCommand.Parameters.AddWithValue("@schoolId", schoolid);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure; 
            DataSet ds = new DataSet();
            adp.Fill(ds);
            con.Close();
            return ds;
        }
        public DataSet DDLParty(string schoolid)
        {
            SqlDataAdapter adp = new SqlDataAdapter("DDLParty", con);
            adp.SelectCommand.Parameters.AddWithValue("@schoolid", schoolid);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure; 
            DataSet ds = new DataSet();
            adp.Fill(ds);
            con.Close();
            return ds;
        }
        public DataSet ShowOrder(string schoolid)
        {
            SqlDataAdapter adp = new SqlDataAdapter("spShowOrder", con);
            adp.SelectCommand.Parameters.AddWithValue("@schoolid", schoolid);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure; 
            DataSet ds = new DataSet();
            adp.Fill(ds);

            con.Close();
            return ds;
        }
        public prp SelectOrder(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spSelectOrder";
            cmd.Parameters.AddWithValue("@OrderId", pr.POrderID);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                pr.PSchoolID = dr["SchoolID"].ToString();
                pr.POrderNo = dr["OrderNo"].ToString();
                pr.PProductID = dr["ProdcutID"].ToString();
                pr.PTotalQuantity = dr["TotalQuantity"].ToString();
                pr.PPayementType = dr["PaymentType"].ToString();
                pr.PAmount = dr["Amount"].ToString();
                pr.PDiscount = dr["Discount"].ToString();
                pr.PPartyID = dr["PartyID"].ToString();
                pr.POrderDate = dr["OrderDate"].ToString();
                pr.POrderStatusID = dr["OrderStatusID"].ToString();

            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return pr;

        }
        public string UpdateOrder(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.CommandText = "spUpdateOrder";
            cmd.Parameters.AddWithValue("@OrderId", pr.POrderID);
          //  cmd.Parameters.AddWithValue("@SchoolID", pr.PSchoolID);
            cmd.Parameters.AddWithValue("@OrderNo", pr.POrderNo);
            cmd.Parameters.AddWithValue("@ProductID", pr.PProductID);
            cmd.Parameters.AddWithValue("@TotalQuantity", pr.PTotalQuantity);
            cmd.Parameters.AddWithValue("@PaymentType", pr.PPayementType);
            cmd.Parameters.AddWithValue("@Amount", pr.PAmount);
            cmd.Parameters.AddWithValue("@Discount", pr.PDiscount);
            cmd.Parameters.AddWithValue("@PartyID", pr.PPartyID);
            cmd.Parameters.AddWithValue("@OrderDate", pr.POrderDate);
            cmd.Parameters.AddWithValue("OrderStatusID", pr.POrderStatusID);


            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();

            string st = "Updated";
            return st;
        }
        public string DeleteOrder(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spDeleteOrder";
            cmd.Parameters.AddWithValue("@OrderId", pr.POrderID);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

            String st = "Sucessfully Delete";
            return st;
        }
        public DataSet DDLStatus()
        {
            SqlDataAdapter adp = new SqlDataAdapter("spDDLStatus", con);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            con.Close();
            return ds;
        }
        public DataTable PaymentRecordShow(prp pr)
        {
            SqlDataAdapter adp = new SqlDataAdapter("spSelectPayment", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@OrderNo", pr.POrderNo);
            adp.SelectCommand.Parameters.AddWithValue("@schoolid", pr.PSchoolID);

            DataTable dt = new DataTable();
            adp.Fill(dt);
            con.Close();
            return dt;

        }
        public string InsertPaymentDetail(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.CommandText = "spInsertPayment";
            cmd.Parameters.AddWithValue("@OrderNo", pr.POrderNo);
            cmd.Parameters.AddWithValue("@TotalAmount ", pr.PTotalAmount);
            cmd.Parameters.AddWithValue("@PaymentDate", pr.PPaymentDate);
            cmd.Parameters.AddWithValue("@Remark", pr.PRemark);
            cmd.Parameters.AddWithValue("@schoolid", pr.PSchoolID);

            string st = "";
            st = cmd.ExecuteScalar().ToString();

            cmd.Dispose();
            con.Close();

            return st;
        }
        public DataSet ShowPaymentDetail(prp pr)
        {
            SqlDataAdapter adp = new SqlDataAdapter("spShowPaymentDetail", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@OrderNo", pr.POrderNo);
            adp.SelectCommand.Parameters.AddWithValue("@schoolId", pr.PSchoolID);

            DataSet ds = new DataSet();
            adp.Fill(ds);

            con.Close();
            return ds;
        }
        public DataSet PartyWiseShow(prp pr)
        {
            SqlDataAdapter adp = new SqlDataAdapter("spShowPartyWise", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@PartyID", pr.PPartyID);
            adp.SelectCommand.Parameters.AddWithValue("@schoolId", pr.PSchoolID);

            DataSet ds = new DataSet();
            adp.Fill(ds);

            con.Close();
            return ds;
        }
        public DataSet ShorOrderALL(prp pr)
        {
            SqlDataAdapter adp = new SqlDataAdapter("spShowOrderRecord", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@OrderID", pr.POrderID);
            adp.SelectCommand.Parameters.AddWithValue("@schoolId", pr.PSchoolID);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            con.Close();
            return ds;
        }
        public String InsertVoucherType(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.CommandText = "spInsertVoucher";
            cmd.Parameters.AddWithValue("@vocherTypeName", pr.PVoucherTypeName);
            cmd.Parameters.AddWithValue("@SchoolID", pr.PSchoolID);
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
            string st = "Succesfully Insert";
            return st;
        }
        public DataSet ShowVocher()
        {
            SqlDataAdapter adp = new SqlDataAdapter("spShowVoucher", con);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            con.Close();
            return ds;
        }
        public prp SelectVocher(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spSelectVoucher";
            cmd.Parameters.AddWithValue("@VocherTypeID", pr.PVoucherTypeID);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                pr.PSchoolID = dr["SchoolID"].ToString();
                pr.PVoucherTypeName = dr["vocherTypeName"].ToString();

            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return pr;

        }
        public string UpdateVocher(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.CommandText = "spUpdateVocher";
            cmd.Parameters.AddWithValue("@VocherTypeId", pr.PVoucherTypeID);
            cmd.Parameters.AddWithValue("@VocherTypeName", pr.PVoucherTypeName);
            cmd.Parameters.AddWithValue("@SchoolID", pr.PSchoolID);

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();

            string st = "Updated";
            return st;
        }
        public string DeleteVocher(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spDeleteVocherType";
            cmd.Parameters.AddWithValue("@VocherTypeID", pr.PVoucherTypeID);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

            String st = "Sucessfully Delete";
            return st;
        }
        public String InsertVoucher(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.CommandText = "spInsertVocher";
            cmd.Parameters.AddWithValue("@VoucherNo", pr.PVoucherNo);
            cmd.Parameters.AddWithValue("@SchoolID", pr.PSchoolID);
            cmd.Parameters.AddWithValue("@PaidTo", pr.PPaidTo);
            cmd.Parameters.AddWithValue("@ToFor", pr.PToFor);
            cmd.Parameters.AddWithValue("@ReceviedBy", pr.PReceivedBy);
            cmd.Parameters.AddWithValue("@ApprrovedBy", pr.PApprrovedBY);
            cmd.Parameters.AddWithValue("@Amount", pr.PAmount);
            cmd.Parameters.AddWithValue("@Remark", pr.PRemark);
            cmd.Parameters.AddWithValue("@VoucherDate", pr.PVoucherDate);
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
            string st = "Succesfully Insert";
            return st;
        }
        public DataSet ShowVoucher( string schoolid)
        {
            SqlDataAdapter adp = new SqlDataAdapter("spShowVocher", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@schoolid",schoolid);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            con.Close();
            return ds;
        }
        public prp SelectVoucherByID(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spSelectVocherByID";
            cmd.Parameters.AddWithValue("@VoucherID", pr.PVoucherID);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                pr.PSchoolID = dr["SchoolID"].ToString();
                pr.PVoucherNo = dr["VoucherNo"].ToString();
                pr.PPaidTo = dr["PaidTo"].ToString();
                pr.PToFor = dr["ToFor"].ToString();
                pr.PReceivedBy = dr["ReceviedBy"].ToString();
                pr.PApprrovedBY = dr["ApprrovedBy"].ToString();
                pr.PAmount = dr["Amount"].ToString();
                pr.PRemark = dr["Remark"].ToString();
                pr.PVoucherDate = dr["VoucherDate"].ToString();

            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return pr;

        }
        public string UpdateVoucher(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.CommandText = "spUpdateVoucher";
            cmd.Parameters.AddWithValue("@VoucherID", pr.PVoucherID);
            cmd.Parameters.AddWithValue("@VoucherNo", pr.PVoucherNo);
            cmd.Parameters.AddWithValue("@PaidTo", pr.PPaidTo);
            cmd.Parameters.AddWithValue("@ToFor", pr.PToFor);
            cmd.Parameters.AddWithValue("@ReceviedBy", pr.PReceivedBy);
            cmd.Parameters.AddWithValue("@ApprrovedBy", pr.PApprrovedBY);
            cmd.Parameters.AddWithValue("@Amount", pr.PAmount);
            cmd.Parameters.AddWithValue("@Remark", pr.PRemark);
            cmd.Parameters.AddWithValue("@VoucherDate", pr.PVoucherDate);
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();

            string st = "Updated";
            return st;
        }
        public string DeleteVoucher(prp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spDeleteVocherByID";
            cmd.Parameters.AddWithValue("@VoucherID", pr.PVoucherID);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

            String st = "Sucessfully Delete";
            return st;





        }
    




        

            

 
    }
}

        


