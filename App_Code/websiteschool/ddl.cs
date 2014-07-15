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
namespace SpSchoolProject
{
    //public interface ddlptr
    //{

    //    String Puid
    //    {
    //        get;
    //        set;
    //    }
    //    String Puname
    //    {
    //        get;
    //        set;
    //    }
    //}
    //public class ddlprp : ddlptr
    //{
    //    string uid, uname;
    //    #region ddlptr Members

    //    public string Puid
    //    {
    //        get
    //        {
    //            return uid;
    //        }
    //        set
    //        {
    //            uid = value;
    //        }
    //    }

    //    public string Puname
    //    {
    //        get
    //        {
    //            return uname;
    //        }
    //        set
    //        {
    //            uname = value;
    //        }
    //    }

    //    #endregion
    //}
    // public abstract class conn
    //{
    //    protected SqlConnection con = new SqlConnection();
    //    public conn()
    //    {
    //        con.ConnectionString = ConfigurationManager.ConnectionStrings["raj"].ConnectionString;
    //    }
    //}
    public class Dropwork : conn
    {
        public DataTable BindLeaveKind(prpprofile prp)
        {
            SqlDataAdapter adp = new SqlDataAdapter("speaveType", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@schoolId", prp.Id);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable BindStaffName(prpprofile prp)
        {
            SqlDataAdapter adp = new SqlDataAdapter("SpBindStaffName", con);
            adp.SelectCommand.Parameters.AddWithValue("@schoolId", prp.Id);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable BindDepartment(prpprofile prp)
        {
            SqlDataAdapter adp = new SqlDataAdapter("SpBindDepartment", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@schoolId", prp.Id);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable BindDegination(prpprofile prp )
        {
            SqlDataAdapter adp = new SqlDataAdapter("BindDegination", con);
            adp.SelectCommand.Parameters.AddWithValue("@schoolId", prp.Id);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable BindClass(prpprofile prp)
        {
            SqlDataAdapter adp = new SqlDataAdapter("SpShowClass", con);
            adp.SelectCommand.Parameters.AddWithValue("@schoolId", prp.Id);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable BindStream( prpprofile prp )
        {
            SqlDataAdapter adp = new SqlDataAdapter("SpShowStream", con);
            adp.SelectCommand.Parameters.AddWithValue("@schoolId",prp.Id);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            con.Close();
            con.Close();
            return dt;
        }
        public DataTable BindSubject(prpprofile prp)
        {
            SqlDataAdapter adp = new SqlDataAdapter("SpBindSubject", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@schoolId",prp.Id);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable BindDuration(prpprofile prp)
        {
            SqlDataAdapter adp = new SqlDataAdapter("spBindFeesDuration", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@schoolId", prp.Id);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable BindFeesName(prpprofile prp)
        {
            SqlDataAdapter adp = new SqlDataAdapter("spBindFeesName", con);

            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@schoolId",prp.Id);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable BindExamType(prpprofile prp)
        {
            SqlDataAdapter adp = new SqlDataAdapter("SpShowExameType", con);
            adp.SelectCommand.Parameters.AddWithValue("@schoolId", prp);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable BindProductCatagary(prpprofile prp)
        {
            SqlDataAdapter adp = new SqlDataAdapter("spstockCatagary", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@schoolId", prp);

            DataTable dt = new DataTable();
            adp.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable BindProduct(usprp prp)
        {
            SqlDataAdapter adp = new SqlDataAdapter("SpShowProduct", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@productcatid", prp.PCatagary);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
