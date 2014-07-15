using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using bal.Registration;
using QPDataAccessLayer;

namespace dal.Registration
{
    public class ManageUserProfileDB
    {
        SqlConnection con;
        SqlCommand cmd;
        QPMYDAL objQPMYDAL;
        SqlDataReader dr;
        SqlParameter[] sqlParams;
        string msg, Message;
        int ret;
        public UserRegistraionProp GetUserFullDetails(UserRegistraionProp objUserRegistraionProp)
        {

            objQPMYDAL = new QPMYDAL();
            try
            {

                sqlParams = new SqlParameter[]
            {
              
                new SqlParameter("@Personal_Details_Id",objUserRegistraionProp.JPD_Personal_Details_Id)
               };


                dr = objQPMYDAL.QPGetDataReaderSP(sqlParams, "Job_UserfullDetails", out msg, out Message);

                if (dr.HasRows)
                {
                    dr.Read();





                    if (dr["Personal_Details_Id"] != DBNull.Value)
                        objUserRegistraionProp.JPD_Personal_Details_Id = Convert.ToInt16(dr["Personal_Details_Id"]);
                    objUserRegistraionProp.jpd_First_Name = Convert.ToString(dr["First_Name"]);
                    objUserRegistraionProp.JPD_Last_Name = Convert.ToString(dr["Last_Name"]);
                    if (dr["Role_Id"] != DBNull.Value)
                        objUserRegistraionProp.jpd_Role_Id = Convert.ToInt16(dr["Role_Id"]);
                    objUserRegistraionProp.jpd_Alternate_Email_Id = Convert.ToString(dr["Alternate_Email_Id"]);
                    objUserRegistraionProp.jpd_Mobile_No = Convert.ToString(dr["Mobile_No"]);
                    objUserRegistraionProp.jpd_Date_Of_Birth = Convert.ToString(dr["Date_Of_Birth"]);
                    objUserRegistraionProp.jpd_Gender = Convert.ToString(dr["Gender"]);
                    objUserRegistraionProp.jpd_Phone_No = Convert.ToString(dr["Phone_No"]);
                    objUserRegistraionProp.jpd_Address = Convert.ToString(dr["Address"]);
                    if (dr["City_Id"] != DBNull.Value)
                        objUserRegistraionProp.JPD_City_Id = Convert.ToInt16(dr["City_Id"]);
                    if (dr["ImgUrl"] != DBNull.Value)
                        objUserRegistraionProp.jpd_ImgUrl = Convert.ToString(dr["ImgUrl"]);
                    objUserRegistraionProp.jpd_Created_Date = Convert.ToString(dr["personaldetailsCreatedDate"]);
                    objUserRegistraionProp.jpd_Updated_Date = Convert.ToString(dr["personaldetailsUpdatedDate"]);
                    if (dr["JPDJC_City_Id"] != DBNull.Value)
                        objUserRegistraionProp.JPDJC_City_Id = Convert.ToInt16(dr["JPDJC_City_Id"]);
                    if (dr["JPDJC_City_Name"] != DBNull.Value)
                        objUserRegistraionProp.JPDJC_City_Name = Convert.ToString(dr["JPDJC_City_Name"]);
                    if (dr["JPDJS_State_Id"] != DBNull.Value)
                        objUserRegistraionProp.JPDJS_State_Id = Convert.ToInt16(dr["JPDJS_State_Id"]);
                    if (dr["JPDJS_State_Name"] != DBNull.Value)
                        objUserRegistraionProp.JPDJS_State_Name = Convert.ToString(dr["JPDJS_State_Name"]);
                    if (dr["JPDJCO_Country_Id"] != DBNull.Value)
                        objUserRegistraionProp.JPDJCO_Country_Id = Convert.ToInt16(dr["JPDJCO_Country_Id"]);
                    if (dr["JPDJCO_Country_Name"] != DBNull.Value)
                        objUserRegistraionProp.JPDJCO_Country_Name = Convert.ToString(dr["JPDJCO_Country_Name"]);














                    if (dr["Highest_Qualification_Id"] != DBNull.Value)
                        objUserRegistraionProp.JHQD_Highest_Qualification_Id = Convert.ToInt16(dr["Highest_Qualification_Id"]);
                    if (dr["JHQD_Specilization_Id"] != DBNull.Value)
                        objUserRegistraionProp.JHQD_Specilization_Id = Convert.ToInt16(dr["JHQD_Specilization_Id"]);
                    if (dr["Passing_Year"] != DBNull.Value)
                        objUserRegistraionProp.JHQD_Passing_Year = Convert.ToInt16(dr["Passing_Year"]);
                    if (dr["JHQD_Institude_Id"] != DBNull.Value)
                        objUserRegistraionProp.JHQD_Institude_Id = Convert.ToInt16(dr["JHQD_Institude_Id"]);
                    objUserRegistraionProp.JHQD_Course_Type = Convert.ToString(dr["Course_Type"]);
                    objUserRegistraionProp.JHQD_Created_Date = Convert.ToString(dr["HighqualificationCreatedDate"]);
                    objUserRegistraionProp.JHQD_Updated_Date = Convert.ToString(dr["HighqualificationUpdatedDate"]);
                    if (dr["JHQDMQ_Qualification_Id"] != DBNull.Value)
                        objUserRegistraionProp.JHQDMQ_Qualification_Id = Convert.ToInt16(dr["JHQDMQ_Qualification_Id"]);
                    objUserRegistraionProp.JHQDMQ_Qualification_Name = Convert.ToString(dr["JHQDMQ_Qualification_Name"]);
                    objUserRegistraionProp.JHQDMINS_Institute_Name = Convert.ToString(dr["JHQDMINS_Institute_Name"]);
                    objUserRegistraionProp.JHQDMS_Specelization_Name = Convert.ToString(dr["JHQDMS_Specelization_Name"]);




                    if (dr["JobSecondHighestQualification_Id"] != DBNull.Value)
                        objUserRegistraionProp.JSQD_JobSecondHighestQualification = Convert.ToInt16(dr["JobSecondHighestQualification_Id"]);
                    if (dr["JSQD_Specilization_Id"] != DBNull.Value)
                        objUserRegistraionProp.JSQD_Specilization_Id = Convert.ToInt16(dr["JSQD_Specilization_Id"]);
                    if (dr["JSQDPassing_Year"] != DBNull.Value)
                        objUserRegistraionProp.JSQD_Passing_Year = Convert.ToInt16(dr["JSQDPassing_Year"]);
                    if (dr["JSQD_Institude_Id"] != DBNull.Value)
                        objUserRegistraionProp.JSQD_Institude_Id = Convert.ToInt16(dr["JSQD_Institude_Id"]);
                    objUserRegistraionProp.JSQD_Course_Type = Convert.ToString(dr["SecondHighestCourseType"]);
                    objUserRegistraionProp.JSQD_Created_Date = Convert.ToString(dr["JSQDCreated_Date"]);
                    objUserRegistraionProp.JSQD_Updated_Date = Convert.ToString(dr["JSQDUpdated_Date"]);



                    if (dr["Current_Work_Id"] != DBNull.Value)
                        objUserRegistraionProp.JCWD_Current_Work_Id = Convert.ToInt16(dr["Current_Work_Id"]);
                    objUserRegistraionProp.JCWD_Company_Name = Convert.ToString(dr["JCWD_Company_Name"]);
                    objUserRegistraionProp.JCWD_Work_From_Date = Convert.ToString(dr["JCWDWork_From_Date"]);
                    objUserRegistraionProp.JCWD_Work_To_Date = Convert.ToString(dr["JCWDWork_To_Date"]);
                    objUserRegistraionProp.JCWD_Job_Type = Convert.ToString(dr["JCWD_Job_Type"]);
                    if (dr["Current_Salary_InLack"] != DBNull.Value)
                        objUserRegistraionProp.JCWD_Current_Salary_InLack = Convert.ToInt16(dr["Current_Salary_InLack"]);
                    if (dr["Current_Salary_InThousand"] != DBNull.Value)
                        objUserRegistraionProp.JCWD_Current_Salary_InThousand = Convert.ToInt16(dr["Current_Salary_InThousand"]);
                    if (dr["Job_Location_Id"] != DBNull.Value)
                        objUserRegistraionProp.JCWD_Job_Location_Id = Convert.ToInt16(dr["Job_Location_Id"]);
                    objUserRegistraionProp.JCWD_Created_Date = Convert.ToString(dr["JCWDCreated_Date"]);
                    objUserRegistraionProp.JCWD_Updated_Date = Convert.ToString(dr["JCWDUpdated_Date"]);
                    objUserRegistraionProp.JCWDMJL_Location_Name = Convert.ToString(dr["JCWDMJL_Location_Name"]);




                    if (dr["Work_Details_Id"] != DBNull.Value)
                        objUserRegistraionProp.JWD_Work_Details_Id = Convert.ToInt16(dr["Work_Details_Id"]);
                    objUserRegistraionProp.JWD_Resume_Title = Convert.ToString(dr["Resume_Title"]);
                    objUserRegistraionProp.JWD_Resume_Url = Convert.ToString(dr["Resume_Url"]);
                    if (dr["Total_Experience_Year"] != DBNull.Value)
                        objUserRegistraionProp.JWD_Total_Experience_Year = Convert.ToInt16(dr["Total_Experience_Year"]);
                    if (dr["Total_Experience_Month"] != DBNull.Value)
                        objUserRegistraionProp.JWD_Total_Experience_Month = Convert.ToInt16(dr["Total_Experience_Month"]);
                    objUserRegistraionProp.JWD_Key_Skills = Convert.ToString(dr["Key_Skills"]);
                    objUserRegistraionProp.JWD_Job_Type_Preference = Convert.ToString(dr["Job_Type_Preference"]);
                    if (dr["JWD_Function_Role_Id"] != DBNull.Value)
                        objUserRegistraionProp.JWD_Function_Role_Id = Convert.ToInt16(dr["JWD_Function_Role_Id"]);
                    objUserRegistraionProp.JWD_Created_Date = Convert.ToString(dr["JWDCreatedDate"]);
                    objUserRegistraionProp.JWD_Updated_Date = Convert.ToString(dr["JWDUpdated_Date"]);
                    objUserRegistraionProp.JWDMINDUS_Industry_Name = Convert.ToString(dr["JWDMINDUS_Industry_Name"]);
                    objUserRegistraionProp.JWDMINDUS_Industry_Description = Convert.ToString(dr["JWDMINDUS_Industry_Description"]);
                    if (dr["JWDMINDUS_Industry_Id"] != DBNull.Value)
                        objUserRegistraionProp.JWDMINDUS_Industry_Id = Convert.ToInt16(dr["JWDMINDUS_Industry_Id"]);
                    if (dr["JWDMF_Function_Id"] != DBNull.Value)
                        objUserRegistraionProp.JWDMF_Function_Id = Convert.ToInt16(dr["JWDMF_Function_Id"]);
                    objUserRegistraionProp.JWDMF_Function_Name = Convert.ToString(dr["JWDMF_Function_Name"]);
                    objUserRegistraionProp.JWDMF_Function_Description = Convert.ToString(dr["JWDMF_Function_Description"]);
                    objUserRegistraionProp.JWDMFR_Function_Role_Name = Convert.ToString(dr["JWDMFR_Function_Role_Name"]);
                    if (dr["JWDMFR_Function_Role_Id"] != DBNull.Value)
                        objUserRegistraionProp.JWDMFR_Function_Role_Id = Convert.ToInt16(dr["JWDMFR_Function_Role_Id"]);
                    objUserRegistraionProp.JWDMFR_Function_Role_Description = Convert.ToString(dr["JWDMFR_Function_Role_Description"]);
                    if (dr["JWDMJL_Location_Id"] != DBNull.Value)
                    objUserRegistraionProp.JWDMJL_Location_Id = Convert.ToInt16(dr["JWDMJL_Location_Id"]);
                    objUserRegistraionProp.JWDMJL_Location_Name = Convert.ToString(dr["JWDMJL_Location_Name"]);




                    if (dr["Previous_Work_Id"] != DBNull.Value)
                        objUserRegistraionProp.JPWD_Previous_Work_Id = Convert.ToInt16(dr["Previous_Work_Id"]);
                    objUserRegistraionProp.JPWD_Company_Name = Convert.ToString(dr["JPWD_Company_Name"]);
                    objUserRegistraionProp.JPWD_Work_From_Date = Convert.ToString(dr["JPWD_Work_From_Date"]);
                    objUserRegistraionProp.JPWD_Work_To_Date = Convert.ToString(dr["JPWD_Work_To_Date"]);
                    objUserRegistraionProp.JPWD_Job_Type = Convert.ToString(dr["JPWD_Job_Type"]);
                    objUserRegistraionProp.JPWD_Created_Date = Convert.ToString(dr["JPWDCreated_Date"]);
                    objUserRegistraionProp.JPWD_Updated_Date = Convert.ToString(dr["JPWDUpdated_Date"]);


                    objUserRegistraionProp.MS_Specelization_Name = Convert.ToString(dr["Specelization_Name"]);
                    objUserRegistraionProp.ms_Specelization_Description = Convert.ToString(dr["Specelization_Description"]);
                    if (dr["Specelization_Id"] != DBNull.Value)
                        objUserRegistraionProp.ms_Specelization_Id = Convert.ToInt16(dr["Specelization_Id"]);


                    objUserRegistraionProp.mq_Qualification_Name = Convert.ToString(dr["Qualification_Name"]);
                    if (dr["Qualification_Id"] != DBNull.Value)
                        objUserRegistraionProp.mq_Qualification_Id = Convert.ToInt16(dr["Qualification_Id"]);
                    objUserRegistraionProp.mq_Qualification_Description = Convert.ToString(dr["Qualification_Description"]);


                    objUserRegistraionProp.MI_Institute_Name = Convert.ToString(dr["Institute_Name"]);
                    objUserRegistraionProp.MI_Institute_Description = Convert.ToString(dr["Institute_Description"]);
                    if (dr["Institute_Id"] != DBNull.Value)
                        objUserRegistraionProp.MI_Institute_Id = Convert.ToInt16(dr["Institute_Id"]);


                    if (dr["Institute_Id"] != DBNull.Value)
                        objUserRegistraionProp.MINS_Institute_Id = Convert.ToInt16(dr["Institute_Id"]);
                    objUserRegistraionProp.MINS_Institute_Name = Convert.ToString(dr["MINS_Institute_Name"]);
                    objUserRegistraionProp.MINS_Institute_Description = Convert.ToString(dr["Institute_Description"]);






                    return objUserRegistraionProp;


                }
                else
                {

                    return objUserRegistraionProp;
                }


            }
            catch
            {
                return null;
            }
        }



        public string UpdateQualifcationDetails(UserRegistraionProp objUserRegistraionProp)
        {
            objQPMYDAL = new QPMYDAL();
            try
            {
                if (objUserRegistraionProp.flagUpdate == "UpdateJHQD")
                {
                    sqlParams = new SqlParameter[]
            {
                new SqlParameter("@para_HighQualification_Id", objUserRegistraionProp.JHQD_Highest_Qualification_Id),
                new SqlParameter("@para_Specilization_Id", objUserRegistraionProp.JHQD_Specilization_Id),
                new SqlParameter("@para_Passing_Year", objUserRegistraionProp.JHQD_Passing_Year),
                new SqlParameter("@para_Institute_Id", objUserRegistraionProp.JHQD_Institude_Id),
                new SqlParameter("@para_Course_Type", objUserRegistraionProp.JHQD_Course_Type)

               };

                    ret = objQPMYDAL.QPExecuteNonQuerySP(sqlParams, "job_HighestQualification", out msg, out Message);
                }
                else if (objUserRegistraionProp.flagUpdate == "UpdateJSQD")
                {
                    sqlParams = new SqlParameter[]
            {
                new SqlParameter("@para_SecondHighQualification_Id", objUserRegistraionProp.JSQD_JobSecondHighestQualification),
                new SqlParameter("@para_Specilization_Id", objUserRegistraionProp.JSQD_Specilization_Id),
                new SqlParameter("@para_Passing_Year", objUserRegistraionProp.JSQD_Passing_Year),
                new SqlParameter("@para_Institute_Id", objUserRegistraionProp.JSQD_Institude_Id),
                new SqlParameter("@para_Course_Type", objUserRegistraionProp.JSQD_Course_Type)

               };
                    ret = objQPMYDAL.QPExecuteNonQuerySP(sqlParams, "job_UpdateQualification", out msg, out Message);
                }
                if (ret > 0 && msg == "Success")
                {

                    return msg;
                }
                else
                {
                    return msg = "unSuccess";
                }


            }
            catch
            {
                return Message;
            }
        }


        public string UpdatePersonalDetails(UserRegistraionProp objUserRegistraionProp)
        {
            objQPMYDAL = new QPMYDAL();
            try
            {

                sqlParams = new SqlParameter[]
            {
new SqlParameter("@Personal_Details_Id", objUserRegistraionProp.JPD_Personal_Details_Id),
new SqlParameter("@para_Address", objUserRegistraionProp.jpd_Address),
new SqlParameter("@para_Alternate_Email_Id", objUserRegistraionProp.jpd_Alternate_Email_Id),
new SqlParameter("@para_City_Id", objUserRegistraionProp.JPD_City_Id),
new SqlParameter("@para_Date_Of_Birth", objUserRegistraionProp.jpd_Date_Of_Birth),
new SqlParameter("@para_First_Name", objUserRegistraionProp.jpd_First_Name),
new SqlParameter("@para_Gender", objUserRegistraionProp.jpd_Gender),
new SqlParameter("@para_ImgUrl", objUserRegistraionProp.jpd_ImgUrl),
new SqlParameter("@para_Last_Name", objUserRegistraionProp.JPD_Last_Name),
new SqlParameter("@para_Mobile_No", objUserRegistraionProp.jpd_Mobile_No),
new SqlParameter("@para_Phone_No", objUserRegistraionProp.jpd_Phone_No)



               };

                ret = objQPMYDAL.QPExecuteNonQuerySP(sqlParams, "job_UpdatePersonalDetails", out msg, out Message);


                if (ret > 0 && msg == "Success")
                {

                    return msg;
                }
                else
                {
                    return msg = "unSuccess";
                }


            }
            catch
            {
                return Message;
            }
        }


        public string UpdateCurrentWorkDetails(UserRegistraionProp objUserRegistraionProp)
        {
            objQPMYDAL = new QPMYDAL();
            try
            {
                if (objUserRegistraionProp.flagUpdate == "Update_Current_Details")
                {
                    sqlParams = new SqlParameter[]
            {
                new SqlParameter("@para_Company_Name", objUserRegistraionProp.JCWD_Company_Name),
                new SqlParameter("@para_Current_Salary_InLack", objUserRegistraionProp.JCWD_Current_Salary_InLack),
                new SqlParameter("@para_Current_Salary_InThousand", objUserRegistraionProp.JCWD_Current_Salary_InThousand),
                new SqlParameter("@para_Job_Type", objUserRegistraionProp.JCWD_Job_Type),
                new SqlParameter("@para_Personal_Details_Id", objUserRegistraionProp.JPD_Personal_Details_Id),
                new SqlParameter("@para_Job_Location_Id", objUserRegistraionProp.JCWD_Job_Location_Id),
                new SqlParameter("@para_Work_From_Date", objUserRegistraionProp.JCWD_Work_From_Date),
                new SqlParameter("@para_Work_To_Date", objUserRegistraionProp.JCWD_Work_To_Date)

               };

                    ret = objQPMYDAL.QPExecuteNonQuerySP(sqlParams, "Update_Job_Current_Work_Details", out msg, out Message);
                }
                else if (objUserRegistraionProp.flagUpdate == "Update_Previous_Details")
                {
                    sqlParams = new SqlParameter[]
            {
                new SqlParameter("@para_Company_Name", objUserRegistraionProp.JPWD_Company_Name),
                
                new SqlParameter("@para_Job_Type", objUserRegistraionProp.JPWD_Job_Type),
                new SqlParameter("@para_Personal_Details_Id", objUserRegistraionProp.JPD_Personal_Details_Id),
                
                new SqlParameter("@para_Work_From_Date", objUserRegistraionProp.JPWD_Work_From_Date),
                new SqlParameter("@para_Work_To_Date", objUserRegistraionProp.JPWD_Work_To_Date)

               };

                    ret = objQPMYDAL.QPExecuteNonQuerySP(sqlParams, "Update_Job_Previous_Work_Details", out msg, out Message);
                }

                if (ret > 0 && msg == "Success")
                {

                    return msg;
                }
                else
                {
                    return msg = "unSuccess";
                }


            }
            catch
            {
                return Message;
            }
        }


        public string UpdateWorkDetails(UserRegistraionProp objUserRegistraionProp)
        {
            objQPMYDAL = new QPMYDAL();
            try
            {
                
                    sqlParams = new SqlParameter[]
            {
                new SqlParameter("@para_personal_Details_Id", objUserRegistraionProp.JPD_Personal_Details_Id),
                new SqlParameter("@para_Function_Role_Id", objUserRegistraionProp.JWDMFR_Function_Role_Id),
                new SqlParameter("@para_Job_Prefferd_Location_Id", objUserRegistraionProp.JWDMJL_Location_Id),
                new SqlParameter("@para_Job_Type_Preference", objUserRegistraionProp.JWD_Job_Type_Preference),
                new SqlParameter("@para_Key_Skills", objUserRegistraionProp.JWD_Key_Skills),
                new SqlParameter("@para_Resume_Title", objUserRegistraionProp.JWD_Resume_Title),
                new SqlParameter("@para_Resume_Url", objUserRegistraionProp.JWD_Resume_Url),
                new SqlParameter("@para_Total_Experience_Year", objUserRegistraionProp.JWD_Total_Experience_Year),
                new SqlParameter("@para_Total_Experience_Month", objUserRegistraionProp.JWD_Total_Experience_Month)

               };

                    ret = objQPMYDAL.QPExecuteNonQuerySP(sqlParams, "Job_Update_WorkDetails", out msg, out Message);
               
                

                if (ret > 0 && msg == "Success")
                {

                    return msg;
                }
                else
                {
                    return msg = "unSuccess";
                }


            }
            catch
            {
                return Message;
            }
        }
    }
}