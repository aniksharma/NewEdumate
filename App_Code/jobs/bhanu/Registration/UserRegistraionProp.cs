using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bal.Registration
{
    public class UserRegistraionProp
    {

        public string flagUpdate { get; set; }

        public string JLD_Emial_Id { get; set; }
        public string JLD_password { get; set; }
        public string JLD_New_Password { get; set; }
        public string mobcode { get; set; }

        public int JPD_Personal_Details_Id { get; set; }
        public string jpd_First_Name { get; set; }
        public string JPD_Last_Name { get; set; }
        public int jpd_Role_Id { get; set; }
        public string jpd_Alternate_Email_Id { get; set; }
        public string jpd_Mobile_No { get; set; }
        public string jpd_Date_Of_Birth { get; set; }
        public string jpd_Gender { get; set; }
        public string jpd_Phone_No { get; set; }
        public string jpd_Address { get; set; }
        public int JPD_City_Id { get; set; }
        public string jpd_ImgUrl { get; set; }
        public string jpd_Created_Date { get; set; }
        public string jpd_Updated_Date { get; set; }
        public int JPDJC_City_Id { get; set; }
        public string JPDJC_City_Name { get; set; }
        public int JPDJS_State_Id { get; set; }
        public string JPDJS_State_Name { get; set; }
        public int JPDJCO_Country_Id { get; set; }
        public string JPDJCO_Country_Name { get; set; }



        public int JHQD_Highest_Qualification_Id { get; set; }
        public int JHQD_Specilization_Id { get; set; }
        public int JHQD_Passing_Year { get; set; }
        public int JHQD_Institude_Id { get; set; }
        public string JHQD_Course_Type { get; set; }
        public string JHQD_Created_Date { get; set; }
        public string JHQD_Updated_Date { get; set; }
        public int JHQDMQ_Qualification_Id { get; set; }
        public string JHQDMQ_Qualification_Name { get; set; }
        public string JHQDMINS_Institute_Name { get; set; }
        public string JHQDMS_Specelization_Name { get; set; }
        
        
        public int JSQD_JobSecondHighestQualification { get; set; }
        public int JSQD_Specilization_Id { get; set; }
        public int JSQD_Passing_Year { get; set; }
        public int JSQD_Institude_Id { get; set; }
        public string JSQD_Course_Type { get; set; }
        public string JSQD_Created_Date { get; set; }
        public string JSQD_Updated_Date { get; set; }
        
        
        public int JCWD_Current_Work_Id { get; set; }
        public string JCWD_Company_Name { get; set; }
        public string JCWD_Work_From_Date { get; set; }
        public string JCWD_Work_To_Date { get; set; }
        public string JCWD_Job_Type { get; set; }
        public int JCWD_Current_Salary_InLack { get; set; }
        public int JCWD_Current_Salary_InThousand { get; set; }
        public int JCWD_Job_Location_Id { get; set; }
        public string JCWD_Created_Date { get; set; }
        public string JCWD_Updated_Date { get; set; }
        public string JCWDMJL_Location_Name { get; set; }
        
        
        public int JWD_Work_Details_Id { get; set; }
        public string JWD_Resume_Title { get; set; }
        public string JWD_Resume_Url { get; set; }
        public int JWD_Total_Experience_Year { get; set; }
        public int JWD_Total_Experience_Month { get; set; }
        public string JWD_Key_Skills { get; set; }
        public string JWD_Job_Type_Preference { get; set; }
        public int JWD_Function_Role_Id { get; set; }
        public string JWD_Created_Date { get; set; }
        public string JWD_Updated_Date { get; set; }
        public string JWDMINDUS_Industry_Name { get; set; }
        public string JWDMINDUS_Industry_Description { get; set; }
        public int JWDMINDUS_Industry_Id { get; set; }
        public int JWDMF_Function_Id { get; set; }
        public string JWDMF_Function_Name { get; set; }
        public string JWDMF_Function_Description { get; set; }
        public string JWDMFR_Function_Role_Name { get; set; }
        public int JWDMFR_Function_Role_Id { get; set; }
        public string JWDMFR_Function_Role_Description { get; set; }
        public int JWDMJL_Location_Id { get; set; }
        public string JWDMJL_Location_Name { get; set; }

        public int JPWD_Previous_Work_Id { get; set; }
        public string JPWD_Company_Name { get; set; }
        public string JPWD_Work_From_Date { get; set; }
        public string JPWD_Work_To_Date { get; set; }
        public string JPWD_Job_Type { get; set; }
        public string JPWD_Created_Date { get; set; }
        public string JPWD_Updated_Date { get; set; }
        
        
        public string MS_Specelization_Name { get; set; }
        public string ms_Specelization_Description { get; set; }
        public int ms_Specelization_Id { get; set; }
        
        
        public string mq_Qualification_Name { get; set; }
        public int mq_Qualification_Id { get; set; }
        public string mq_Qualification_Description { get; set; }
        
        
        public string MI_Institute_Name { get; set; }
        public string MI_Institute_Description { get; set; }
        public int MI_Institute_Id { get; set; }

        
        public int MINS_Institute_Id { get; set; }
        public string MINS_Institute_Name { get; set; }
        public string MINS_Institute_Description { get; set; }


        //public int Personal_Details_Id { get; set; }
        //public int Role_Id { get; set; }
        //public string First_Name { get; set; }
        //public string Last_Name { get; set; }
        //public string Emial_Id { get; set; }
        //public string Gender { get; set; }
        //public int City_Id { get; set; }
        //public string password { get; set; }
        //public string Dateofbirth { get; set; }
        //public int Specialization_Id { get; set; }


        //public string Mobile_No { get; set; }


        //public string Phone_No { get; set; }
        //public string Address { get; set; }
        //public string ImgUrl { get; set; }
        //public string personaldetailsCreatedDate { get; set; }
        //public string personaldetailsUpdatedDate { get; set; }
        //public string Course_Type { get; set; }
        //public string HighqualificationCreatedDate { get; set; }
        //public string HighqualificationUpdatedDate { get; set; }
        //public int Highest_Qualification_Id { get; set; }
        //public int Passing_Year { get; set; }

        //public string SecondHighestCourseType { get; set; }
        //public string JSQDCreated_Date { get; set; }
        //public int JobSecondHighestQualification_Id { get; set; }
        //public string JSQDPassing_Year { get; set; }
        //public string JSQDUpdated_Date { get; set; }



        //public string Company_Name { get; set; }
        //public string JCWDCreated_Date { get; set; }
        //public string Current_Salary_InLack { get; set; }
        //public string Current_Salary_InThousand { get; set; }
        //public int Current_Work_Id { get; set; }
        //public string Job_Type { get; set; }
        //public int Preferred_Job_Location_Id { get; set; }
        //public string JCWDUpdated_Date { get; set; }
        //public string JCWDWork_From_Date { get; set; }
        //public string JCWDWork_To_Date { get; set; }





        //public string JWDCreatedDate { get; set; }
        //public string Job_Type_Preference { get; set; }
        //public string Key_Skills { get; set; }
        //public string Resume_Title { get; set; }
        //public string Resume_Url { get; set; }
        //public int Total_Experience_Month { get; set; }
        //public int Total_Experience_Year { get; set; }
        //public string JWDUpdated_Date { get; set; }
        //public int Work_Details_Id { get; set; }
        //public string JPWDCompany_Name { get; set; }
        //public string JPWDCreated_Date { get; set; }
        //public string JPWDJob_Type { get; set; }
        //public string JPWDUpdated_Date { get; set; }
        //public string Work_From_Date { get; set; }
        //public string Work_To_Date { get; set; }
    }
}