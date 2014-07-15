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
//using nmsConnection;
using nmsADOI;
namespace nmsADOI
{

    public  class clsADO
    {
        SqlConnection Con;
        public  void NonQuery(clsprpADO obj)
        {
            //obj.Cmd = new SqlCommand();
            Con =   new SqlConnection(ConfigurationManager.ConnectionStrings["cn1"].ConnectionString); 
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            try
            {
                obj.Cmd.Connection = Con;
                obj.Cmd.CommandType = CommandType.StoredProcedure;
                obj.Cmd.ExecuteNonQuery();
                obj.ReturnMsg = "success";
                

            }
            catch(Exception ex)
            {
                //throw ex;
                obj.ReturnMsg = "error on execution"+ex.Message;

            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
                obj.Cmd.Dispose();

            }
         }
        public void ScalarQuery(clsprpADO obj)
        {
            Con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn1"].ConnectionString);
            //obj.Cmd = new SqlCommand();
            

          
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            try
            {
                obj.Cmd.Connection = Con;
                obj.Cmd.CommandType = CommandType.StoredProcedure;
                obj.ScalarValue= obj.Cmd.ExecuteScalar().ToString();
                obj.ReturnMsg = "success";


            }
            catch (Exception ex)
            {
                //throw ex;
                obj.ReturnMsg = "error on execution"+ex.Message;

            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
                obj.Cmd.Dispose();

            }
        }
        public void ReaderQuery(clsprpADO obj)
        {
            obj.Con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
          //  obj.Cmd = new SqlCommand();
           
            if (obj.Con.State == ConnectionState.Closed)
            {
                obj.Con.Open();
            }
            try
            {
                obj.Cmd.Connection = obj.Con;
                obj.Cmd.CommandType = CommandType.StoredProcedure;
                //obj.Cmd.ExecuteNonQuery();
                obj.Dr = obj.Cmd.ExecuteReader();
                obj.ReturnMsg = "success";


            }
            catch (Exception ex)
            {
                //throw ex;
                obj.ReturnMsg = "error on execution"+ex.Message;

            }
            finally
            {
                //if (Con.State == ConnectionState.Open)
                //{
                //    Con.Close();
                //}
                //objcmd.Cmd.Dispose();

            }
        }
        public void ReaderClose(clsprpADO obj)
        {
            obj.Dr.Close();
            obj.Con.Close();
            obj.Cmd.Dispose();
        }
    }

 }
