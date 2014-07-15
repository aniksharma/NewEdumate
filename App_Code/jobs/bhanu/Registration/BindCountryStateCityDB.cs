using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using bal.Registration;
using QPDataAccessLayer;
using System.Data;
using System.Data.SqlClient;
namespace dal.Registration
{
    
    public class BindCountryStateCityDB
    {
        SqlConnection con;
        SqlCommand cmd;
        QPMYDAL objQPMYDAL;
        SqlDataReader dr;
        DataSet ds;
        SqlParameter[] sqlParams;
        string msg, Message;
        public DataSet GetJobLocations()
        {
            objQPMYDAL = new QPMYDAL();
            try
            {
                sqlParams = new SqlParameter[] {               
               };
                return ds = objQPMYDAL.QPGetDataSetSP(sqlParams, "job_GetJobLocations", out msg, out Message);

            }
            catch
            {
                return null;
            }
        }
        public DataSet GetCountryList()
        {
            objQPMYDAL = new QPMYDAL();
            try
            {
                sqlParams = new SqlParameter[] {               
               };
                   return ds = objQPMYDAL.QPGetDataSetSP(sqlParams, "Job_getcountryList", out msg, out Message);
                
            }
            catch
            {
                return null;
            }
        }

        public DataSet BindIndustryList()
        {
            objQPMYDAL = new QPMYDAL();
            try
            {
                sqlParams = new SqlParameter[] {               
               };
                return ds = objQPMYDAL.QPGetDataSetSP(sqlParams, "job_Get_All_Indutry", out msg, out Message);
                
            }
            catch
            {
                return null;
            }
        }
        
        public DataSet GetInstituteList()
        {
            objQPMYDAL = new QPMYDAL();
            try
            {
                sqlParams = new SqlParameter[] {               
               };
                return ds = objQPMYDAL.QPGetDataSetSP(sqlParams, "Job_getInstituteList", out msg, out Message);
                
            }
            catch
            {
                return null;
            }
        }
        public DataSet GetStateList(int SelectedCountryId)
        {
            objQPMYDAL = new QPMYDAL();
            try
            {

                sqlParams = new SqlParameter[]
            {   
                new SqlParameter("@para_Country_Id", SelectedCountryId)
               };


                return ds = objQPMYDAL.QPGetDataSetSP(sqlParams, "Job_GetStateList", out msg, out Message);
                
            }
            catch
            {
                return null;
            }
        }

        public DataSet BindFunctionList(int SelectedIndustryId)
        {
            objQPMYDAL = new QPMYDAL();
            try
            {

                sqlParams = new SqlParameter[]
            {   
                new SqlParameter("@para_Industry_Id", SelectedIndustryId)
               };


                return ds = objQPMYDAL.QPGetDataSetSP(sqlParams, "job_Get_All_FunctionByIndustry", out msg, out Message);
                
            }
            catch
            {
                return null;
            }
        }

        
        public DataSet GetCityList(int SelectedStateId)
        {
            objQPMYDAL = new QPMYDAL();
            try
            {

                sqlParams = new SqlParameter[]
            {   
                new SqlParameter("@para_State_Id", SelectedStateId)
               };


                return ds = objQPMYDAL.QPGetDataSetSP(sqlParams, "Job_GetCityList", out msg, out Message);
                
            }
            catch
            {
                return null;
            }
        }
        public DataSet BindFunctionRoleList(int SelectedFunctionId)
        {
            objQPMYDAL = new QPMYDAL();
            try
            {

                sqlParams = new SqlParameter[]
            {   
                new SqlParameter("@para_Function_Id", SelectedFunctionId)
               };


                return ds = objQPMYDAL.QPGetDataSetSP(sqlParams, "Job_Get_All_FunctionRoleByFunction", out msg, out Message);
                
            }
            catch
            {
                return null;
            }
        }
        
        public DataSet GetQualificationList()
        {
            objQPMYDAL = new QPMYDAL();
            try
            {
                sqlParams = new SqlParameter[] {               
               };
                return ds = objQPMYDAL.QPGetDataSetSP(sqlParams, "Job_getQualificationList", out msg, out Message);

            }
            catch
            {
                return null;
            }
        }
        public DataSet GetSpecializationList(int SelectedQualificationId)
        {
            objQPMYDAL = new QPMYDAL();
            try
            {

                sqlParams = new SqlParameter[]
            {   
                new SqlParameter("@para_Qualification_Id", SelectedQualificationId)
               };


                return ds = objQPMYDAL.QPGetDataSetSP(sqlParams, "Job_GetSpecelizationList", out msg, out Message);

            }
            catch
            {
                return null;
            }
        }
        
        
        
    }
}