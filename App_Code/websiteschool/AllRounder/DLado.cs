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
namespace nmsADOI
{

    public class clsDLado
    {
        //----------------------------Non Query ---------------------------------------------------//
        public void NonQuery(clsPRPadoDL obj)
        {
            obj.CommandType = "NonQuery";
            ExecuteCommon(obj);
        }

        //---------------------------Scalar Query----------------------------------------------------//
        public void ScalarQuery(clsPRPadoDL obj)
        {

            obj.CommandType = "ScalarQuery";
            ExecuteCommon(obj);
        }

        //--------------------------Reader Query-----------------------------------------------------//
        public void ReaderQuery(clsPRPadoDL obj)
        {
            obj.CommandType = "Reader";
            ExecuteCommon(obj);

        }

        //--------------------------Dataset Query-----------------------------------------------------//
        public void DataSetQuery(clsPRPadoDL obj)
        {
            obj.CommandType = "DataSet";
            ExecuteCommon(obj);

        }

        //----------------------------dataTable Quere---------------------------------------------------//
        public void DataTableQuery(clsPRPadoDL obj)
        {
            obj.CommandType = "DataTable";
            ExecuteCommon(obj);

        }


        //--------------------------------Common Call For all---------------------------------------------------------------//

        private void ExecuteCommon(clsPRPadoDL obj)
        {

            try
            {

                if (obj.Con.State == ConnectionState.Closed)
                {
                    obj.Con.Open();
                }
                obj.Cmd.CommandTimeout = 300;
                obj.Cmd.Connection = obj.Con;

                if (obj.ArrayPram.Length > 0)
                {
                    for (int i = 0; i < obj.ArrayPram.Length; i++)
                    {
                        obj.Cmd.Parameters.Add(obj.ArrayPram[i]);
                    }
                }
                if (obj.CommandType == "NonQuery")
                {
                    Non(obj);
                }
                else if (obj.CommandType == "ScalarQuery")
                {
                    Scalar(obj);
                }
                else if (obj.CommandType == "Reader")
                {
                    Reader(obj);
                }
                else if (obj.CommandType == "DataSet")
                {
                    Dataset(obj);
                }
                else if (obj.CommandType == "DataTable")
                {
                    DataTable(obj); 
                }
                obj.ReturnMsg = "success";
            

            }
            catch (SqlException ex)
            {
                obj.ReturnMsg = "Database Error :" + ex.Message;
            }
            catch (Exception ex)
            {
                obj.ReturnMsg = "Application Error :" + ex.Message;

            }

            finally
            {
                 if (obj.CommandType != "Reader")
                {
                  
                if (obj.Con.State == ConnectionState.Open)
                {
                    obj.Con.Close();
                }
                }
                 obj.Cmd.Dispose();
                
            }


        }

        //--------------------------------------Non Query---------------------------------------------------------//

        private void Non(clsPRPadoDL obj)
        {
            obj.Cmd.ExecuteNonQuery();
        }

        //-----------------------------------Scalar execute--------------------------------------------//

        private void Scalar(clsPRPadoDL obj)
         {
                 obj.ScalarValue = obj.Cmd.ExecuteScalar().ToString();
         }

        //-----------------------------------reader execute--------------------------------------------//
        private void Reader(clsPRPadoDL obj)
         {
                 obj.Dr = obj.Cmd.ExecuteReader();
         }
           //-----------------------------------dataset execute--------------------------------------------//
        private void Dataset(clsPRPadoDL obj)
           {
               obj.Adp = new SqlDataAdapter();
               obj.Ds = new DataSet(); 
               obj.Adp.SelectCommand = obj.Cmd;
               obj.Adp.Fill(obj.Ds); 
               obj.Adp.Dispose();

           }

        //------------------------------------------------datatable execute-------------------------------//
        private void DataTable(clsPRPadoDL obj)
           {
               obj.Adp = new SqlDataAdapter();
               obj.Dtable = new DataTable(); 
               obj.Adp.SelectCommand = obj.Cmd;
               obj.Adp.Fill(obj.Dtable);
               obj.Adp.Dispose();

           }


        //------------------------------------------------DL reader Close-------------------------------//
         public void ReaderClose(clsPRPadoDL obj)
         {
             obj.Dr.Close();
             obj.Con.Close();
             obj.Cmd.Dispose();
         }

       
        //-------------------------------------------------------------------------------//

    }
}