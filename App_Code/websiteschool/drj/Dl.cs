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
namespace SchoolInFormation
{
    public class clsDl
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn1"].ConnectionString);
        SqlCommand cmd;
        SqlDataAdapter adp;
        DataSet ds;
        DataTable dt;
        SqlDataReader dr;

        public string DlMainLineInsert(clsprop prop)
        {
            if (con.State == ConnectionState.Closed)
                con.Open()
                    ;
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spMainLineInsert";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mainlineType", prop.MainLineType);
            cmd.Parameters.AddWithValue("@mainLine", prop.MainLine);
            cmd.ExecuteNonQuery();
            string msg = "Succesfully Inserted";
            return msg;
            cmd.Dispose();
            con.Close();
        }
        public string DlMainLineUpdate(clsprop prop)
        {
            if (con.State == ConnectionState.Closed)
                con.Open()
                    ;
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spMainLineUpdate";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mainlineId", prop.MainLineId);
            cmd.Parameters.AddWithValue("@mainlineType", prop.MainLineType);
            cmd.Parameters.AddWithValue("@mainLine", prop.MainLine);
            cmd.ExecuteNonQuery();
            string msg = "Succesfully Updated";
            cmd.Dispose();
            con.Close();
       
            return msg;
        }
        public string DlMainLineDelete(clsprop prop)
        {
            if (con.State == ConnectionState.Closed)
                con.Open()
                    ;
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spMainLineDelete";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mainlineId", prop.MainLineId);
            cmd.ExecuteNonQuery();
            string msg = "Succesfully Deleted";
            return msg;
            cmd.Dispose();
            con.Close();
        
        }

        public clsprop DlMainLineById(clsprop prop)
        {
            clsprop prp = new clsprop();
            if (con.State == ConnectionState.Closed)
                con.Open()
                    ;
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spMainLineById";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mainlineId", prop.MainLineId);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                prp.MainLineId = Convert.ToInt32(dr["mainlineId"].ToString());
                prp.MainLine = dr["mainLine"].ToString();
                prp.MainLineType = dr["mainlineType"].ToString();
                dr.Close();

            }
            return prp;
            cmd.Dispose();
            con.Close();
        }
        public DataTable DlMainLineAll()
        {
            clsprop prp = new clsprop();
            if (con.State == ConnectionState.Closed)
                con.Open()
                    ;
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spMainLineAll";
            cmd.CommandType = CommandType.StoredProcedure;
            adp = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adp.Fill(dt);
            return dt;
            cmd.Dispose();
            con.Close();
        }

       // ----------------------------------------------------------------

        public string DlContentInsert(clsprop prop)
        {
            if (con.State == ConnectionState.Closed)
                con.Open()
                    ;
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spContentInsert";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@contentTitle",prop.contentTitle);
            cmd.Parameters.AddWithValue("@contentDetails", prop.contentDetails);
            cmd.Parameters.AddWithValue("@contentImagePath", prop.contentImagepath);
            cmd.ExecuteNonQuery();
            string msg = "Succesfully Inserted";
            return msg;
            cmd.Dispose();
            con.Close();
        }
        public string DlContentUpdate(clsprop prop)
        {
            if (con.State == ConnectionState.Closed)
                con.Open()
                    ;
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spContentUpdate";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@contentId",prop.contentId);
            cmd.Parameters.AddWithValue("@contentTitle", prop.contentTitle);
            cmd.Parameters.AddWithValue("@contentDetails", prop.contentDetails);
            cmd.Parameters.AddWithValue("@contentImagePath", prop.contentImagepath);
            cmd.ExecuteNonQuery();
            string msg = "Succesfully Updated";
            return msg;
            cmd.Dispose();
            con.Close();
        }
        public string DlContentDelete(clsprop prop)
        {
            if (con.State == ConnectionState.Closed)
                con.Open()
                    ;
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spContentDelete";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@contentId", prop.contentId);
            cmd.ExecuteNonQuery();
            string msg = "Succesfully Deleted";
            return msg;
            cmd.Dispose();
            con.Close();
        
        }

        public clsprop DlContentById(clsprop prop)
        {
            clsprop prp = new clsprop();
            if (con.State == ConnectionState.Closed)
                con.Open()
                    ;
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spContentbyId";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@contentId",prop.contentId);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                prp.contentId= Convert.ToInt32(dr["contentId"].ToString());
                prp.contentTitle = dr["contentTitle"].ToString();
                prp.contentDetails = dr["contentDetails"].ToString();
                prp.contentImagepath = dr["contentImagepath"].ToString();
                dr.Close();

            }
            return prp;
            cmd.Dispose();
            con.Close();
        }
        public DataTable DlContentAll()
        {
            clsprop prp = new clsprop();
            if (con.State == ConnectionState.Closed)
                con.Open()
                    ;
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spContentAll";
            cmd.CommandType = CommandType.StoredProcedure;
            adp = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adp.Fill(dt);
            return dt;
            cmd.Dispose();
            con.Close();
        }
        //--------------------------------------------------------


        public string DlImageGallaryInsert(clsprop prop)
        {
            if (con.State == ConnectionState.Closed)
                con.Open()
                    ;
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spImageGallaryInsert";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@imageTitle", prop.imageTitle);
            cmd.Parameters.AddWithValue("@imageType", prop.imageType);
            cmd.Parameters.AddWithValue("@imagePath", prop.imagePath);
            cmd.ExecuteNonQuery();
            string msg = "Succesfully Inserted";
            return msg;
            cmd.Dispose();
            con.Close();
        }
        public string DlImageGallaryUpdate(clsprop prop)
        {
            if (con.State == ConnectionState.Closed)
                con.Open()
                    ;
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spImageGallaryUpdate";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@imageId", prop.imageId);
            cmd.Parameters.AddWithValue("@imageTitle", prop.imageTitle);
            cmd.Parameters.AddWithValue("@imageType", prop.imageType);
            cmd.Parameters.AddWithValue("@imagePath", prop.imagePath);
            cmd.ExecuteNonQuery();
            string msg = "Succesfully Updated";
            return msg;
            cmd.Dispose();
            con.Close();
        }
        public string DlImageGallaryDelete(clsprop prop)
        {
            if (con.State == ConnectionState.Closed)
                con.Open()
                    ;
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spImageGallaryDelete";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@imageId", prop.imageId);
            cmd.ExecuteNonQuery();
            string msg = "Succesfully Deleted";
            return msg;
            cmd.Dispose();
            con.Close();

        }

        public clsprop DlImageGallaryById(clsprop prop)
        {
            clsprop prp = new clsprop();
            if (con.State == ConnectionState.Closed)
                con.Open()
                    ;
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spImageGallarybyId";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@imageId",prop.imageId);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                prp.imageId = Convert.ToInt32(dr["imageId"].ToString());
                prp.imageTitle = dr["imageTitle"].ToString();
                prp.imageType = dr["imageType"].ToString();
                prp.imagePath = dr["imagePath"].ToString();
                dr.Close();

            }
            return prp;
            cmd.Dispose();
            con.Close();
        }
        public DataTable DlImageGallaryAll()
        {
            clsprop prp = new clsprop();
            if (con.State == ConnectionState.Closed)
                con.Open()
                    ;
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spImageGallaryAll";
            cmd.CommandType = CommandType.StoredProcedure;
            adp = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adp.Fill(dt);
            return dt;
            cmd.Dispose();
            con.Close();
        }

        //=================================================
        public DataTable DlMainLineByType(clsprop prop)
        {
            clsprop prp = new clsprop();
            if (con.State == ConnectionState.Closed)
                con.Open()
                    ;
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spMailLineSelect";
            cmd.Parameters.AddWithValue("@type",prop.MainLineType);
            cmd.Parameters.AddWithValue("@schoolId", prop.SchoolId);

            cmd.CommandType = CommandType.StoredProcedure;
            adp = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adp.Fill(dt);
            cmd.Dispose();
            con.Close();
    
            return dt;
        }


        public DataSet DlMainLineByTypeAll( clsprop prp1)
        {
            clsprop prp = new clsprop();
            DataSet dataset = new DataSet(); 
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spMailLineSelectByTypeALL";
            cmd.Parameters.AddWithValue("@schoolId", prp1.SchoolId); 
            cmd.CommandType = CommandType.StoredProcedure;
            adp = new SqlDataAdapter(cmd);
            adp.Fill(dataset);
            cmd.Dispose();
            con.Close();
            return dataset;
        }


    }
}
