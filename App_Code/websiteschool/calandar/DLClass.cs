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

namespace Calander
{
    public class clsDL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn1"].ConnectionString);
        SqlCommand cmd;
        SqlDataAdapter adp;
        SqlDataReader dr;
        DataSet ds;
        DataTable dt;

        public string InsertEvent(clsprop prop)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SpInsertEvent";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EventName", prop.name );
            cmd.Parameters.AddWithValue("@EventDescription", prop.Description);
            cmd.Parameters.AddWithValue("@EndDate", prop.EndDate);
            cmd.Parameters.AddWithValue("@EventEndTime", prop.EndTime);
            cmd.Parameters.AddWithValue("@EventStartTime", prop.StartTime);
            cmd.Parameters.AddWithValue("@EventRemind ", prop.RemindingDate);
            cmd.Parameters.AddWithValue("@EventOrganiser", prop.Organiser);
            cmd.Parameters.AddWithValue("@EventLocation", prop.Location);
            cmd.Parameters.AddWithValue("@StartDate", prop.StartDate);
            cmd.Parameters.AddWithValue("@eventType ", prop.Type);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            string st = "Succssfully insertd..";
            return st;
        }

        public DataTable BindType()
        {
            SqlDataAdapter adp = new SqlDataAdapter("BindType", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public DataTable viewEvent(clsprop prop)
        {
            SqlDataAdapter adp = new SqlDataAdapter("ViewEvent", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@date", prop.StartDate);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }



        public DataTable viewEventByID(clsprop prop)
        {
            SqlDataAdapter adp = new SqlDataAdapter("spEvenById", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@id", prop.id);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }



        public string DeleteEvent(clsprop prop)
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


    }
}






