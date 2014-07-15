using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;


namespace QPDataAccessLayer
{   
    public class QPMYDAL: System.Web.UI.Page
    {
        SqlConnection objCon;
        SqlCommand objCmd;
        SqlTransaction objTrans;
        SqlDataAdapter objDa;
        DataSet objDs;
        DataTable objDt;
      
        #region constructor is Defined here 
       public  QPMYDAL()
        {

            //objCon = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["st"].ToString()); //coment by devesh and change ConnectionStrings["st"] name 

            objCon = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["cn"].ToString()); 
            objTrans = null;           
        }
        #endregion 
        #region this is ExecuteScalar method it takes query only return single value as object type
           public object QPExecuteScalar(string strQuery, out string msg, out string sysMsg)
           {
               object objRetVal = null;
               try
               {
                   objCmd = new SqlCommand();
                   objCmd.Connection = objCon;
                   objCmd.CommandTimeout = 30;
                   objCmd.CommandType = CommandType.Text;
                   objCmd.CommandText = strQuery;
                   CheckConnection();
                   objCmd.Connection.Open();
                   objRetVal = objCmd.ExecuteScalar();
                   objCmd.Connection.Close();
                   msg = "Success";
                   sysMsg = "Success";
                   return objRetVal;

               }
               catch (SqlException ex)
               {
                   //objCmd.Connection.Close();
                   msg = "Database Error";
                   sysMsg = ex.Message;
                   return objRetVal;
               }
               catch (Exception ex)
               {
                   // objCmd.Connection.Close();
                   msg = "Application Error";
                   sysMsg = ex.Message;
                   return objRetVal;
               }

           }
        #endregion
        #region this is ExecuteScalar method it takes query as parameter and return single value as object type
            public object QPExecuteScalar(System.Data.SqlClient.SqlParameter[] arrParam, string strQuery, out string msg, out string sysMsg)
            {
                object objRetVal=null;
                try
                {
                    objCmd = new SqlCommand();
                    objCmd.Connection = objCon;
                    objCmd.CommandType = CommandType.Text;
                    objCmd.CommandTimeout = 30;
                    objCmd.CommandText = strQuery;
                    for (int i = 0; i < arrParam.Length; i++)
                    {
                        objCmd.Parameters.Add(arrParam[i]);
                    }
                    CheckConnection();
                    objCmd.Connection.Open();
                    objRetVal = objCmd.ExecuteScalar();
                    objCmd.Connection.Close();
                    msg = "Success";
                    sysMsg = "Success";
                    return objRetVal;

                }
                catch (SqlException ex)
                {
                    msg = "Database Error";
                    sysMsg = ex.Message;
                    return objRetVal;
                }
                catch (Exception ex)
                {
                    msg = "Application Error";
                    sysMsg = ex.Message;
                    return objRetVal;
                }

            }
         #endregion
        #region this is ExecuteScalar method it takes stored procedure name as parameter and return single value as object type
            public object QPExecuteScalarSP(System.Data.SqlClient.SqlParameter[] arrParam, string strSPName, out string msg, out string sysMsg)
            {
                object objRetVal = null;
                try
                {
                    objCmd = new SqlCommand();
                    objCmd.Connection = objCon;
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.CommandTimeout = 30;
                    objCmd.CommandText = strSPName;
                    for (int i = 0; i < arrParam.Length; i++)
                    {
                        objCmd.Parameters.Add(arrParam[i]);
                    }
                    CheckConnection();
                    objCmd.Connection.Open();
                    objRetVal = objCmd.ExecuteScalar();
                    msg = "Success";
                    sysMsg = "Success";
                    objCmd.Connection.Close();
                    return objRetVal;
                }
                catch (SqlException ex)
                {
                    msg = "Database Error";
                    sysMsg = ex.Message;
                    return objRetVal;
                }
                catch (Exception ex)
                {
                    msg = "Application Error";
                    sysMsg = ex.Message;
                    return objRetVal;
                }
            }
        #endregion
       

        #region this method execute sql query & return single value as integer type
            public int QPExecuteNonQuery(string strQuery, out string msg, out string sysMsg)
            {
                int retVal = 0;
                try
                {
                    objCmd = new SqlCommand();
                    objCmd.Connection = objCon;
                    objCmd.CommandType = CommandType.Text;
                    objCmd.CommandText = strQuery;
                    objCon.Open();                
                    objTrans = objCon.BeginTransaction();
                    objCmd.Transaction = objTrans;               
                    retVal= objCmd.ExecuteNonQuery();
                    objTrans.Commit();                    
                    msg = "Success";
                    sysMsg = "Success";
                    return  retVal;
                }
                catch (SqlException ex)
                {
                    objTrans.Rollback();
                    msg = "Database Error";
                    sysMsg = ex.Message;
                    return retVal;
                }
                catch (Exception ex)
                {
                    objTrans.Rollback();
                    msg = "Application Error";
                    sysMsg = ex.Message;
                    return retVal;
                }    
                finally
                {
                    objCon.Close();
                }

            }
        #endregion
        #region this method execute sql query & it takes query parameter return single value as integer type
            public int QPExecuteNonQuery(SqlParameter[] arrParam, string strQuery, out string msg, out string sysMsg)
            {
                int retVal = 0;
                try
                {                   
                    objCmd = new SqlCommand();
                    objCmd.Connection = objCon;                
                    objCmd.CommandType = CommandType.Text;
                    objCmd.CommandText = strQuery;
                    for (int i = 0; i < arrParam.Length; i++)
                    {
                        objCmd.Parameters.Add(arrParam[i]);
                    }
                    objCon.Open();
                    objTrans = objCon.BeginTransaction();
                    objCmd.Transaction = objTrans;                   
                    retVal = objCmd.ExecuteNonQuery();
                    objTrans.Commit();
                    msg = "Success";
                    sysMsg = "Success";
                    return retVal;
                }
                catch (SqlException ex)
                {
                    objTrans.Rollback();
                    msg = "Database Error";
                    sysMsg = ex.Message;
                    return retVal;
                }
                catch (Exception ex)
                {
                    objTrans.Rollback();
                    msg = "Application Error";
                    sysMsg = ex.Message;
                    return retVal;
                }
                finally
                {
                    objCon.Close();
                }
            }
        #endregion
        #region this method execute sql procedure name & it takes procedure parameter return single value as integer type
            public int QPExecuteNonQuerySP(SqlParameter[] arrParam, string strSPName, out string msg, out string sysMsg)
            {
                int retVal = 0;
                try
                {
                    objCmd = new SqlCommand();
                    objCmd.Connection = objCon;                
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.CommandText = strSPName;
                    for (int i = 0; i < arrParam.Length; i++)
                    {
                        objCmd.Parameters.Add(arrParam[i]);
                    }
                    CheckConnection();
                    objCon.Open();
                    objTrans = objCon.BeginTransaction();
                    objCmd.Transaction = objTrans;                
                    retVal = objCmd.ExecuteNonQuery();
                    objTrans.Commit();
                    msg = "Success";
                    sysMsg = "Success";
                    return retVal;
                }
                catch (SqlException ex)
                {
                    objTrans.Rollback();
                    msg = "Database Error";
                    sysMsg = ex.Message;
                    return retVal;
                }
                catch (Exception ex)
                {
                    objTrans.Rollback();
                    msg = "Application Error";
                    sysMsg = ex.Message;
                    return retVal;
                }
                finally
                {
                    objCon.Close();
                }
            }
        #endregion

        #region this method takes sql query & return a dataset object
            public DataSet QPGetDataSet(string strQuery, out string msg, out string sysMsg)
            {
                try
                {
                    objDs = new DataSet();
                    objCmd = new SqlCommand();
                    objCmd.CommandTimeout = 30;
                    objCmd.CommandType = CommandType.Text;
                    objCmd.CommandText = strQuery ;
                    objCmd.Connection = objCon;
                    objDa = new SqlDataAdapter();               
                    objDa.SelectCommand = objCmd;
                    objDa.Fill(objDs);                
                    msg = "Success";
                    sysMsg = "Success";
                    return objDs;
                }
                catch (SqlException ex)
                {
                    msg = "Database Error";
                    sysMsg = ex.Message;
                    return objDs;
                }
                catch (Exception ex)
                {
                    msg = "Application Error";
                    sysMsg = ex.Message;
                    return objDs;
                }    
            }
        #endregion
        #region this method takes sql query as parameter and return a dataset object
            public DataSet QPGetDataSet(SqlParameter[] arrParam, string strName, out string msg, out string sysMsg)
            {
                try
                {
                    objDs = new DataSet();
                    objCmd = new SqlCommand();
                    objDs = new DataSet();
                    objCmd.CommandTimeout = 30;
                    objCmd.CommandType = CommandType.Text;
                    objCmd.CommandText = strName;
                    objCmd.Connection = objCon;
                   
                    for (int i = 0; i < arrParam.Length; i++)
                    {
                        objCmd.Parameters.Add(arrParam[i]);
                    }
                    objDa = new SqlDataAdapter();
                    objDa.SelectCommand = objCmd;
                   
                    objDa.Fill(objDs);
                    msg = "Success";
                    sysMsg = "Success";            
                    return objDs;
                }
                catch (SqlException ex)
                {
                    msg = "Database Error";
                    sysMsg = ex.Message;
                    return objDs;
                }
                catch (Exception ex)
                {
                    msg = "Application Error";
                    sysMsg = ex.Message;
                    return objDs;
                }
            }
        #endregion
        #region this method takes stored procedure name as parameter and  return a dataset object
            public DataSet QPGetDataSetSP(SqlParameter[] arrParam, string strSPName, out string msg, out string sysMsg)
            {
                try
                {
                    objDa = new SqlDataAdapter();
                    objCmd = new SqlCommand();
                    objDs = new DataSet();
                    objCmd.CommandTimeout = 30;
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.CommandText = strSPName;
                    objCmd.Connection = objCon;
                    for (int i = 0; i < arrParam.Length; i++)
                    {
                        objCmd.Parameters.Add(arrParam[i]);
                    }
                    objDa.SelectCommand = objCmd;
                    objDa.Fill(objDs);
                    msg = "Success";
                    sysMsg = "Success";
                    return objDs;
                }
                catch (SqlException ex)
                {
                    msg = "Database Error";
                    sysMsg = ex.Message;
                    return objDs;
                }
                catch (Exception ex)
                {
                    msg = "Application Error";
                    sysMsg = ex.Message;
                    return objDs;
                }
            }
        #endregion

        #region this method takes sql query & return a sqldatareader object
            public SqlDataReader QPGetDataReader(string strQuery, out string msg, out string sysMsg)
            {
                SqlDataReader objDataReader = null;
                try
                {                    
                    objCmd = new SqlCommand();
                    objCmd.CommandType = CommandType.Text;
                    objCmd.CommandTimeout = 30;
                    objCmd.CommandText = strQuery;                   
                    objCmd.Connection = objCon;
                    CheckConnection();
                    objCmd.Connection.Open();
                    objDataReader  = objCmd.ExecuteReader(CommandBehavior.CloseConnection);
                    msg = "Success";
                    sysMsg = "Success";
                    return objDataReader;
                }
                catch (SqlException ex)
                {
                    msg = "Database Error";
                    sysMsg = ex.Message;
                    return objDataReader;
                }
                catch (Exception ex)
                {
                    msg = "Application Error";
                    sysMsg = ex.Message;
                    return objDataReader;
                }
            }
        #endregion
        #region this method takes argument query as text & parameter, retuns datareader object 
            public SqlDataReader QPGetDataReader(SqlParameter[] arrParam, string strQuery, out string msg, out string sysMsg)
            {
                SqlDataReader objDataReader=null;
                try
                {
                    // Set Command object properties.                    
                    objCmd = new SqlCommand();
                    objCmd.Connection = objCon;
                    objCmd.CommandType = CommandType.Text;
                    objCmd.CommandText = strQuery;
                    objCmd.CommandTimeout = 30;
                    
                    for (int i = 0; i < arrParam.Length; i++)
                    {
                        objCmd.Parameters.Add(arrParam[i]);
                    }
                    CheckConnection();
                    objCmd.Connection.Open();
                    objDataReader = objCmd.ExecuteReader(CommandBehavior.CloseConnection);
                    msg = "Success";
                    sysMsg = "Success";
                    return objDataReader;
                }
                catch (SqlException ex)
                {
                    msg = "Database Error";
                    sysMsg = ex.Message;
                    return objDataReader;
                }
                catch (Exception ex)
                {
                    msg = "Application Error";
                    sysMsg = ex.Message;
                    return objDataReader;
                }
            }
        #endregion 
        #region this method takes argument as sql procedure name & parameter, retuns datareader object
            public SqlDataReader QPGetDataReaderSP(SqlParameter[] arrParam, string strSPName, out string msg, out string sysMsg)
            {
                SqlDataReader objDataReader=null;
                try
                {
                    // Set Command object properties.
                    
                    objCmd = new SqlCommand();
                    objCmd.Connection = objCon;
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.CommandText = strSPName;
                    objCmd.CommandTimeout = 30;

                    for (int i = 0; i < arrParam.Length; i++)
                    {
                        objCmd.Parameters.Add(arrParam[i]);
                    }

                    objCmd.Connection = objCon;
                    CheckConnection();
                    objCmd.Connection.Open();
                    objDataReader = objCmd.ExecuteReader(CommandBehavior.CloseConnection);
                    msg = "Success";
                    sysMsg = "Success";
                    return objDataReader;
                }
                catch (SqlException ex)
                {
                    msg = "Database Error";
                    sysMsg = ex.Message;
                    return objDataReader;
                }
                catch (Exception ex)
                {
                    msg = "Application Error";
                    sysMsg = ex.Message;
                    return objDataReader;
                }  
            }

          
            
        #endregion

        #region this method takes sql query & return a DataTable
            public DataTable QPGetDataTable(string strQuery, out string msg, out string sysMsg)
            {
                try
                {
                    objDa = new SqlDataAdapter();
                    objCmd = new SqlCommand();
                    objDt = new DataTable();
                    objCmd.Connection = objCon;
                    objCmd.CommandType = CommandType.Text;
                    objCmd.CommandTimeout = 30;
                    objCmd.CommandText = strQuery;
                    objDa.SelectCommand = objCmd;
                    objDa.Fill(objDt);
                    msg = "Success";
                    sysMsg = "Success";
                    return objDt;
                }
                catch(SqlException ex)
                {
                    msg = "Database Error";
                    sysMsg = ex.Message;
                    return objDt;
                }
                catch (Exception ex)
                {
                    msg = "Application Error";
                    sysMsg = ex.Message;
                    return objDt;
                }
            }
        #endregion
        #region this method takes sql query & its parameter return a DataTable
            public DataTable QPGetDataTable(SqlParameter[] arrParam, string strQuery, out string msg, out string sysMsg)
            {
                try
                {
                    objDa = new SqlDataAdapter();
                    objCmd = new SqlCommand();
                    objDt = new DataTable();
                    objCmd.Connection = objCon;
                    objCmd.CommandType = CommandType.Text;
                    objCmd.CommandTimeout = 30;
                    objCmd.CommandText = strQuery;

                    for (int i = 0; i < arrParam.Length; i++)
                    {
                        objCmd.Parameters.Add(arrParam[i]);
                    }

                    objDa.SelectCommand = objCmd;
                    objDa.Fill(objDt);
                    msg = "Success";
                    sysMsg = "Success";
                    return objDt;
                }
                catch (SqlException ex)
                {
                    msg = "Database Error";
                    sysMsg = ex.Message;
                    return objDt;
                }
                catch (Exception ex)
                {
                    msg = "Application Error";
                    sysMsg = ex.Message;
                    return objDt;
                }
            }
        #endregion
        #region this method takes sql procedure name & its parameter return a DataTable
            public DataTable QPGetDataTableSP(SqlParameter[] arrParam, string strSPName, out string msg, out string sysMsg)
            {
                try
                {
                    objDa = new SqlDataAdapter();
                    objCmd = new SqlCommand();
                    objDt = new DataTable();
                    objCmd.Connection = objCon;
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.CommandTimeout = 30;
                    objCmd.CommandText = strSPName;

                    for (int i = 0; i < arrParam.Length; i++)
                    {
                        objCmd.Parameters.Add(arrParam[i]);
                    }


                    objDa.SelectCommand = objCmd;
                    objDa.Fill(objDt);
                    msg = "Success";
                    sysMsg = "Success";
                    return objDt;

                }
                catch (SqlException ex)
                {
                    msg = "Database Error";
                    sysMsg = ex.Message;
                    return objDt;
                }
                catch (Exception ex)
                {
                    msg = "Application Error";
                    sysMsg = ex.Message;
                    return objDt;
                }
            }
        #endregion       

        // added by him
            public SqlDataReader QPGetDataReaderSP(string strSPName, out string msg, out string sysMsg)
            {
                SqlParameter[] arr = new SqlParameter[0];
                return QPGetDataReaderSP(arr, strSPName, out msg, out sysMsg);

            }

            public DataSet QPGetDataSetSP(string strSPName, out string msg, out string sysMsg)
            {
                SqlParameter[] arr = new SqlParameter[0];
                return QPGetDataSetSP(arr, strSPName, out msg, out sysMsg);
            }

            private void CheckConnection()
            {
                if (objCon.State == ConnectionState.Open)
                {
                    objCon.Close();
                }
            }
            
     
        // end added by him

            #region Added by Anil
            public int ExecuteNonQueryReturn_Parameter(string _procedureName, SqlParameter[] _Parameters, SqlParameter _Outputparameter, out string msg, out string sysMsg)
            {
                int returnresult = 0;
                try
                {
                    SqlCommand _command = new SqlCommand();
                    _command.Connection = objCon;
                    _command.CommandTimeout = 30;
                    _command.CommandType = CommandType.StoredProcedure;
                    _command.CommandText = _procedureName;
                    this.CheckConnection();
                    _command.Connection.Open();
                    objTrans = objCon.BeginTransaction();
                    _command.Transaction = objTrans;
                    if (_command.Parameters.Count > 0)
                        _command.Parameters.Clear();
                    foreach (SqlParameter LoopVar_Param in _Parameters)
                    {
                        _command.Parameters.Add(LoopVar_Param);
                    }
                    _command.Parameters.Add(_Outputparameter);
                    _command.Parameters[_Outputparameter.ParameterName].Direction = ParameterDirection.Output;
                    _command.ExecuteNonQuery();
                    objTrans.Commit();
                    msg = "Sucess";
                    sysMsg = "Sucess";
                    returnresult = Convert.ToInt32(_command.Parameters[_Outputparameter.ParameterName].Value);
                    return returnresult;
                }
                catch (SqlException ex)
                {
                    objTrans.Rollback();
                    msg = "Database Error";
                    sysMsg = ex.Message;
                    return 0;
                }
                catch (Exception ex)
                {
                    objTrans.Rollback();
                    msg = "Application Error";
                    sysMsg = ex.Message;
                    return 0;
                }
                finally
                {
                    objCon.Close();
                }
            }



            public DataTable QPGetDataTableSP(string strSPName, out string msg, out string sysMsg)
            {
                try
                {
                    objDa = new SqlDataAdapter();
                    objCmd = new SqlCommand();
                    objDt = new DataTable();
                    objCmd.Connection = objCon;
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.CommandTimeout = 30;
                    objCmd.CommandText = strSPName;
                    objDa.SelectCommand = objCmd;
                    objDa.Fill(objDt);
                    msg = "Success";
                    sysMsg = "Success";
                    return objDt;
                }
                catch (SqlException ex)
                {
                    msg = "Database Error";
                    sysMsg = ex.Message;
                    return objDt;
                }
                catch (Exception ex)
                {
                    msg = "Application Error";
                    sysMsg = ex.Message;
                    return objDt;
                }
            }
            #endregion
    }
}
