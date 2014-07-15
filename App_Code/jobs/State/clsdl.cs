using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using nmsMovi;
namespace nmsMovi
{
    public class clsdlMovi
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cnkids"].ConnectionString);
        //SqlConnection con=new SqlConnection(ConfigurationManager.ConnectionStrings["st"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adp;
        DataTable dt;

        //-------------State----------------------------
        public void FunInsert(clsprpMovi prp)
        {
        if(con.State==ConnectionState.Closed)
        {
        con.Open();
        }
            cmd.CommandText="spInsert_JobState";
            //cmd.Parameters.AddWithValue("@Country_Id",prp.CountryId);
            cmd.Parameters.AddWithValue("@State_Name",prp.StateName);
            cmd.Parameters.AddWithValue("@State_Abbreviation",prp.StateDescription);
            cmd.Parameters.AddWithValue("@Is_Active",prp.IsActive);
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();          
            cmd.Dispose();
            con.Close();                    
        }

        public DataTable funBindListBoxByState(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dt = new DataTable();
            adp = new SqlDataAdapter("spState", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            cmd.CommandType = CommandType.StoredProcedure;
            return dt;

        }
        public DataTable spAppliedJob()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dt = new DataTable();
            adp = new SqlDataAdapter("spAppliedJob", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            cmd.CommandType = CommandType.StoredProcedure;
            return dt;

        }


        public DataTable spAppliedJobByUser(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dt = new DataTable();
            adp = new SqlDataAdapter("spAppliedJobByUser", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@userId", prp.JobSeekerID);
            adp.Fill(dt);
            cmd.CommandType = CommandType.StoredProcedure;
            return dt;

        }




        public DataTable spView_JobCityBystate(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dt = new DataTable();
            adp = new SqlDataAdapter("spView_JobCityBystate", con);
            adp.SelectCommand.Parameters.AddWithValue("@stateId",prp.StateId);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            cmd.CommandType = CommandType.StoredProcedure;
            return dt;

        }





          public DataTable funBindListBoxstate()
        {
       if(con.State==ConnectionState.Closed)
       {
       con.Open();
       }
            dt=new DataTable(); 
            adp=new SqlDataAdapter("spView_JobState",con);
            adp.SelectCommand.CommandType=CommandType.StoredProcedure;
            adp.Fill(dt);
            cmd.CommandType = CommandType.StoredProcedure;

            return dt;
        }



         public void FunUpState(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
            cmd.CommandText = "spUpdate_JobState";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@state_Id", prp.StateId);
            cmd.Parameters.AddWithValue("@State_Name",prp.StateName);
            cmd.Parameters.AddWithValue("@State_Abbreviation",prp.StateDescription);
            cmd.Parameters.AddWithValue("@Is_Active",prp.IsActive);
            cmd.Connection=con;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void FunDelState(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
            cmd.CommandText = "spDel_JobState";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@State_Id", prp.StateId);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
       public DataTable funBindLstBoxStateById(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dt = new DataTable();
            adp = new SqlDataAdapter("spView_StateById", con);
            adp.SelectCommand.Parameters.AddWithValue("@State_Id", prp.StateId);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        //------------------------------
        public void FunInsertJob(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
            cmd.CommandText = "spInsert_JobTitle";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Job_Title", prp.JobTitle);
            cmd.Parameters.AddWithValue("@Job_Description", prp.JobDescription);
            cmd.Parameters.AddWithValue("@IsActive", prp.IsActive);
            cmd.Parameters.AddWithValue("@orderby", prp.byOrder);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();            
        }
        public DataTable funBindLstBoxJobById(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dt = new DataTable();
            adp = new SqlDataAdapter("spView_JobTitleBy", con);
            adp.SelectCommand.Parameters.AddWithValue("@id", prp.JobId);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }
        
        public DataTable funBindLstBoxLocById(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dt = new DataTable();
            adp = new SqlDataAdapter("spView_MasterJobLocById", con);
            adp.SelectCommand.Parameters.AddWithValue("@Location_Id", prp.LocationId);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }
    
        public DataTable funBindLstBoxJob()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dt = new DataTable();
            adp = new SqlDataAdapter("spView_JobTitle", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }
        public DataTable funBindLstBoxJobLoc()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dt = new DataTable();
            adp = new SqlDataAdapter("spView_MasterJobLocation", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }
            public void FunUpJob1(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
            cmd.CommandText = "spUpdate_JobTitle";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Job_Id", prp.JobId);
            cmd.Parameters.AddWithValue("@Job_Title", prp.JobTitle);
            cmd.Parameters.AddWithValue("@Job_Description", prp.JobDescription);
            cmd.Parameters.AddWithValue("@IsActive", prp.IsActive);
            cmd.Parameters.AddWithValue("@orderby", prp.byOrder);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        
        }
            public void FunDeleteJob(clsprpMovi prp)
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd = new SqlCommand();
                cmd.CommandText = "spDelete_JobTitle";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Job_Id", prp.JobId);
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();


            }
                     public void FunDeleteJobLoc(clsprpMovi prp)
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd = new SqlCommand();
                cmd.CommandText = "spDel_JobLoc";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Location_Id", prp.LocationId);
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();

            }
//---------------------Institute-------------------------------
                   public void FunDeleteInstitute(clsprpMovi prp)
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd = new SqlCommand();
                cmd.CommandText = "spDel_MasterInstitute";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Institute_Id", prp.InstituteId);
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();

            }
            public void FunUpInstitute(clsprpMovi prp)
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd = new SqlCommand();
                cmd.CommandText = "spUpdate_MasterInstitute";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Institute_Id", prp.InstituteId);
                cmd.Parameters.AddWithValue("@Institute_Name", prp.InstituteName);
                cmd.Parameters.AddWithValue("@Institute_Description", prp.InstituteDes);
                cmd.Parameters.AddWithValue("@IsActive", prp.IsActive);
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            }
            public void FunInsertInstitute(clsprpMovi prp)
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.CommandText = "spInsert_MasterInstitute";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Institute_Name", prp.InstituteName);
                cmd.Parameters.AddWithValue("@Institute_Description", prp.InstituteDes);
                cmd.Parameters.AddWithValue("@IsActive", prp.IsActive);
                cmd.Connection = con;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();

                cmd.Dispose();
                con.Close();
                            }

            public DataTable funBindLstBoxInstituteById(clsprpMovi prp)
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dt = new DataTable();
                adp = new SqlDataAdapter("spView_MasterInstituteById", con);
                adp.SelectCommand.Parameters.AddWithValue("@Institute_Id", prp.InstituteId);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.Fill(dt);
                return dt;
            }

            public DataTable funBindLstBoxInstitute()
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dt = new DataTable();
                adp = new SqlDataAdapter("spView_MasterInstitute", con);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.Fill(dt);
                return dt;
            }
//-----------------------State-----------------------
        public void FunUpJobState(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
            cmd.CommandText = "spUpdate_JobState";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Job_Id", prp.JobId);
            cmd.Parameters.AddWithValue("@Job_Title", prp.JobTitle);
            cmd.Parameters.AddWithValue("@Job_Description", prp.JobDescription);
            cmd.Parameters.AddWithValue("@Is_Active", prp.IsActive);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        
        }
        public void FunDelJobState(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
            cmd.CommandText = "spDel_JobState";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@State_Id", prp.JobId);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }

        //------------Company--------------------------------
        public void FunInsertCompany(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.CommandText = "spInsert_MasterCompany";
            cmd.Parameters.AddWithValue("@Company_Name", prp.CompanyName);
            cmd.Parameters.AddWithValue("@Company_Description", prp.CompanyDescription);
            cmd.Parameters.AddWithValue("@IsActive", prp.IsActive);
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }
        public void FunUpCompany(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
            cmd.CommandText = "spUpdate_MasterCompany";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Company_Id", prp.CompanyId);
            cmd.Parameters.AddWithValue("@Company_Name", prp.CompanyName);
            cmd.Parameters.AddWithValue("@Company_Description", prp.CompanyDescription);
            cmd.Parameters.AddWithValue("@IsActive", prp.IsActive);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }
        public void FunDeleteCompany(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
            cmd.CommandText = "spDel_MasterCompany";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Company_Id", prp.CompanyId);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }
        public DataTable funBindLstBoxCompany()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dt = new DataTable();
            adp = new SqlDataAdapter("spView_MasterCompany", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }
        public DataTable funBindLstBoxCompanyById(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dt = new DataTable();
            adp = new SqlDataAdapter("spView_MasterCompanyById", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@Company_Id", prp.CompanyId);
            adp.Fill(dt);
            return dt;
        }
        //----------------Industry----------------------
        public void FunInsertIndustry(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd=new SqlCommand();
            cmd.CommandText = "spInsert_MasterIndustry";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Industry_Name", prp.IndustryName);
            cmd.Parameters.AddWithValue("@Industry_Description", prp.IndustryDescription);
            cmd.Parameters.AddWithValue("@IsActive", prp.IsActive);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }

        public void FunUpIndustry(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
            cmd.CommandText = "spUp_MasterIndustry";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Industry_Id", prp.IndustryId);
            cmd.Parameters.AddWithValue("@Industry_Name", prp.IndustryName);
            cmd.Parameters.AddWithValue("@Industry_Description", prp.IndustryDescription);
            cmd.Parameters.AddWithValue("@IsActive", prp.IsActive);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }

        public DataTable funBindLstBoxIndustry()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dt = new DataTable();
            adp = new SqlDataAdapter("spView_MasterIndustry", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }
        public DataTable funBindLstBoxIndustryById(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dt = new DataTable();
            adp = new SqlDataAdapter("spView_IndustryById", con);
            adp.SelectCommand.Parameters.AddWithValue("@Industry_Id", prp.IndustryId);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        //-------------Skills---------------------------
        public void FunDelSkills(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
            cmd.CommandText = "spDel_MasterSkills";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@skills_Id", prp.SkillsId);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }
           
        public void FunUpSkills(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
            cmd.CommandText = "spUp_MasterSkills";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@skills_Id", prp.SkillsId);
            cmd.Parameters.AddWithValue("@Skills_Name", prp.SkillsName);
            cmd.Parameters.AddWithValue("@Skills_Description", prp.SkillsDes);
            cmd.Parameters.AddWithValue("@Is_Active", prp.IsActive);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }

        public DataTable funBindLstBoxSkillsById(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dt = new DataTable();
            adp = new SqlDataAdapter("spView_MasterSkillsById", con);
            adp.SelectCommand.Parameters.AddWithValue("@Skills_Id", prp.SkillsId);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }
        public DataTable funBindLstBoxSkills()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dt = new DataTable();
            adp = new SqlDataAdapter("spView_MasterSkills", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }
   
        public void FunInsertSkills(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.CommandText = "spInsert_MasterSkills";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Skills_Name", prp.SkillsName);
            cmd.Parameters.AddWithValue("@Skills_Description", prp.SkillsDes);
            cmd.Parameters.AddWithValue("@Is_Active", prp.IsActive);
            cmd.Connection = con;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();


        }
  



        public void FunInsertJOBLocation(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.CommandText = "spInsert_JobLocation";
            cmd.Parameters.AddWithValue("@Location_Name", prp.LocationName);
            cmd.Parameters.AddWithValue("@Location_Description", prp.LocationDes);
            cmd.Parameters.AddWithValue("@IsActive", prp.IsActive);
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();

        }
        public void FunUpJobLoc(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
            cmd.CommandText = "spUpdate_MasterJobLocation";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Location_Id", prp.LocationId);
            cmd.Parameters.AddWithValue("@Location_Name", prp.LocationName);
            cmd.Parameters.AddWithValue("@Location_Description", prp.LocationDes);
            cmd.Parameters.AddWithValue("@IsActive", prp.IsActive);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }
        public void FunDeleteIndustry(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
            cmd.CommandText = "spDel_Industry";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Industry_Id", prp.IndustryId);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }
//---------------------------Language-------------------
        public void FunDelLang(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
            cmd.CommandText = "spDel_MasterLanguage";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Language_Id", prp.LangId);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }

        public void FunUpLang(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
            cmd.CommandText = "spUp_MasterLanguage";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Language_Id", prp.LangId);
            cmd.Parameters.AddWithValue("@Language_Name", prp.LangName);
            cmd.Parameters.AddWithValue("@Language_Description", prp.LangDes);
            cmd.Parameters.AddWithValue("@IsActive", prp.IsActive);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }

        public DataTable funBindLstBoxLangById(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dt = new DataTable();
            adp = new SqlDataAdapter("spView_MasterLanguageById", con);
            adp.SelectCommand.Parameters.AddWithValue("@Language_Id", prp.LangId);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }
        public DataTable funBindLstBoxLang()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dt = new DataTable();
            adp = new SqlDataAdapter("spView_MasterLanguage", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        public void FunInsertLang(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.CommandText = "spInsert_MasterLanguage";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Language_Name", prp.LangName);
            cmd.Parameters.AddWithValue("@Language_Description", prp.LangDes);
            cmd.Parameters.AddWithValue("@IsActive", prp.IsActive);
            cmd.Connection = con;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();


        }
        //---------------Qualification------------------------

        public void FunDelQual(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
            cmd.CommandText = "spDel_MAsterQualification";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Qualification_Id", prp.QualId);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }

        public void FunUpQual(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
            cmd.CommandText = "spUpdate_MasterQualification";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Qualification_Id", prp.QualId);
            cmd.Parameters.AddWithValue("@Qualification_Name", prp.QualificationName);
            cmd.Parameters.AddWithValue("@Qualification_Description", prp.QualificationDes);
            cmd.Parameters.AddWithValue("@IsActive", prp.IsActive);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }

        public DataTable funBindLstBoxQualById(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dt = new DataTable();
            adp = new SqlDataAdapter("spView_MasterQualificationById", con);
            adp.SelectCommand.Parameters.AddWithValue("@Qualification_Id", prp.QualId);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }
        public DataTable funBindLstBoxQual()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dt = new DataTable();
            adp = new SqlDataAdapter("spView_MasterQualification", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        public void FunInsertQual(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.CommandText = "spInsert_MasterQualification";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Qualification_Name", prp.QualificationName);
            cmd.Parameters.AddWithValue("@Qualification_Description", prp.QualificationDes);
            cmd.Parameters.AddWithValue("@IsActive", prp.IsActive);
            cmd.Connection = con;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();


        }

        //------------ city all function here ------------------------

        public void FunInsertCity(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.CommandText = "spInsert_JobCity";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@State_Id", prp.StateId);
            cmd.Parameters.AddWithValue("@City_Name", prp.CityName);
            cmd.Parameters.AddWithValue("@City_Description", prp.CityDescription);
            cmd.Parameters.AddWithValue("@IsActive", prp.IsActive);
            cmd.Connection = con;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();


        }

        public void FunUpCity(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
            cmd.CommandText = "spUpdate_JobCity";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@City_Id", prp.cityID);
            cmd.Parameters.AddWithValue("@State_Id", prp.StateId);
            cmd.Parameters.AddWithValue("@City_Name", prp.CityName);
            cmd.Parameters.AddWithValue("@City_Description", prp.CityDescription);
            cmd.Parameters.AddWithValue("@IsActive", prp.IsActive);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }


        public DataTable funBindListBoxsCity()
        {
            dt = new DataTable(); 
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dt = new DataTable();
            adp = new SqlDataAdapter("Job_GetCityListAll", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            cmd.CommandType = CommandType.StoredProcedure;

            return dt;
        }



        public DataTable funBindLstBoxCityById(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dt = new DataTable();
            adp = new SqlDataAdapter("spView_CityByID", con);
            adp.SelectCommand.Parameters.AddWithValue("@id", prp.cityID);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        public void FunDelCity(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
            cmd.CommandText = "spDel_JobCity";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@City_Id", prp.cityID);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }

  //----------------------------Specialization---------------------
        public void FunInsertSpecialization(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.CommandText = "spInsert_MasterSpecelization";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Qualification_Id", prp.QualId);
            cmd.Parameters.AddWithValue("@Specelization_Name", prp.SpecializationName);
            cmd.Parameters.AddWithValue("@Specelization_Description", prp.SpecializationDescription);
            cmd.Parameters.AddWithValue("@IsActive", prp.IsActive);
            cmd.Connection = con;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();


        }
        public void FunUpSpecialization(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
            cmd.CommandText = "spUp_MasterSpecelization";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Specelization_Id", prp.SpecializationID);
            cmd.Parameters.AddWithValue("@Qualification_Id", prp.QualId);
            cmd.Parameters.AddWithValue("@Specelization_Name", prp.SpecializationName);
            cmd.Parameters.AddWithValue("@Specelization_Description", prp.SpecializationDescription);
            cmd.Parameters.AddWithValue("@IsActive", prp.IsActive);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }

        public void FunDelSpecelization(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
            cmd.CommandText = "spDel_MasterSpecelization";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Specelization_Id", prp.SpecializationID);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }
        public DataTable funBindListBoxsSpecelization()
        {
            dt = new DataTable();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dt = new DataTable();
            adp = new SqlDataAdapter("spView_MasterSpecelization", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            cmd.CommandType = CommandType.StoredProcedure;

            return dt;
        }
        public DataTable funBindLstBoxSpecelizationById(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dt = new DataTable();
            adp = new SqlDataAdapter("spView_MasterSpecelizationById", con);
            adp.SelectCommand.Parameters.AddWithValue("@Specelization_Id", prp.SpecializationID);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }

        //----------------------------Function ------------------

        public void FunInsertFunction(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.CommandText = "spInsert_MasterFunction";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Industry_Id", prp.IndustryId);
            cmd.Parameters.AddWithValue("@Function_Name", prp.FunctionName);
            cmd.Parameters.AddWithValue("@Function_Description", prp.FunctionDescription);
            cmd.Parameters.AddWithValue("@IsActive", prp.IsActive);
            cmd.Connection = con;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();


        }
        public void FunUpFunction(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
            cmd.CommandText = "spUp_MasterFunction";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Function_Id", prp.FunctionId);
            cmd.Parameters.AddWithValue("@Industry_Id", prp.IndustryId);
            cmd.Parameters.AddWithValue("@Function_Name", prp.FunctionName);
            cmd.Parameters.AddWithValue("@Function_Description", prp.FunctionDescription);
            cmd.Parameters.AddWithValue("@IsActive", prp.IsActive);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }

        public void FunDelFunction(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
            cmd.CommandText = "spDel_MasterFunction";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Function_Id", prp.FunctionId);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }
        public DataTable funBindListBoxsFunction()
        {
            dt = new DataTable();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dt = new DataTable();
            adp = new SqlDataAdapter("spView_MasterFunction", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            cmd.CommandType = CommandType.StoredProcedure;

            return dt;
        }
        public DataTable funBindLstBoxFunctionById(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dt = new DataTable();
            adp = new SqlDataAdapter("spView_MasterFunctionById", con);
            adp.SelectCommand.Parameters.AddWithValue("@Function_Id", prp.FunctionId);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }



        //----------------------Function Role-----------------
        public void FunInsertFunctionRole(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.CommandText = "spInsert_MasterFunctionRole";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Function_Id", prp.FunctionId);
            cmd.Parameters.AddWithValue("@Function_Role_Name", prp.FunRole);
            cmd.Parameters.AddWithValue("@Function_Role_Description", prp.FunctionRoleDescription);
            cmd.Parameters.AddWithValue("@IsActive", prp.IsActive);
            cmd.Connection = con;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();


        }
        public void FunUpFunctionRole(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
            cmd.CommandText = "spUp_MasterFunctionRole";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Function_Role_Id", prp.FunRoleId);
            cmd.Parameters.AddWithValue("@Function_Id", prp.FunctionId);
            cmd.Parameters.AddWithValue("@Function_Role_Name", prp.FunRole);
            cmd.Parameters.AddWithValue("@Function_Role_Description", prp.FunctionRoleDescription);
            cmd.Parameters.AddWithValue("@IsActive", prp.IsActive);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }

        public void FunDelFunctionRole(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
            cmd.CommandText = "spDel_MasterFunctionRole";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Function_Role_Id", prp.FunRoleId);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }
        public DataTable funBindListBoxsFunctionRole()
        {
            dt = new DataTable();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dt = new DataTable();
            adp = new SqlDataAdapter("spView_MasterFunctionRole", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            cmd.CommandType = CommandType.StoredProcedure;

            return dt;
        }
        public DataTable funBindLstBoxFunctionRoleById(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dt = new DataTable();
            adp = new SqlDataAdapter("spView_MasterFunctionRoleById", con);
            adp.SelectCommand.Parameters.AddWithValue("@Function_Role_Id", prp.FunRoleId);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }
        public DataTable funBindListBoxCity()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dt = new DataTable();
            adp = new SqlDataAdapter("spView_JobCity", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }
        //-----------------------company Profile----------
        public string FunInsertCmpnyProfile(clsprpMovi prp)
        {
            string msg = "";
        if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        cmd.CommandText = "spInsertCompany";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@Company_Name", prp.Company_Name);
        cmd.Parameters.AddWithValue("@Company_Tital_Name", prp.Company_Tital_Name);
        cmd.Parameters.AddWithValue("@Registration_No", prp.Registration_No);
        cmd.Parameters.AddWithValue("@Phone_No", prp.Phone_No);
        cmd.Parameters.AddWithValue("@Company_Address", prp.Company_Address);
        cmd.Parameters.AddWithValue("@City_Id", prp.cityID);
        cmd.Parameters.AddWithValue("@Company_Email_Id", prp.Company_Email_Id);
        cmd.Parameters.AddWithValue("@Company_Type_Id", prp.Company_Type_Id);
        cmd.Parameters.AddWithValue("@Company_Img_Url", prp.Company_Img_Url);
        cmd.Parameters.AddWithValue("@Employee_Designation", prp.Employee_Designation);
        cmd.Parameters.AddWithValue("@Company_IsActive", prp.Company_IsActive);
        cmd.Parameters.AddWithValue("@company_serviceOffers", prp.company_serviceOffers);
        cmd.Parameters.AddWithValue("@company_Description", prp.company_Description);
        cmd.Parameters.AddWithValue("@company_LogoForHome", prp.company_LogoForHome);
        cmd.Parameters.AddWithValue("@company_phoneNo", prp.company_phoneNo);
        cmd.Parameters.AddWithValue("@company_ContactPerson", prp.company_ContactPerson);
        cmd.Parameters.AddWithValue("@company_website", prp.company_website);
        cmd.Connection = con;

         msg=  cmd.ExecuteScalar().ToString();
        cmd.Dispose();
        con.Close();

        return msg;
        }

        public DataTable FunBindReptr()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataAdapter adp = new SqlDataAdapter("spView_CompanyPrfl", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
         }

        public DataSet  spView_CompanyPrfl4All()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataAdapter adp = new SqlDataAdapter("spView_CompanyPrfl4All", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet dt = new DataSet();
            adp.Fill(dt);
            return dt;
        }
        public DataTable funBindCmpnyProfileText(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dt = new DataTable();
            adp = new SqlDataAdapter("spView_CompnyProfile", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@Company_Id", prp.CompanyId);
           adp.Fill(dt);
            return dt;
        }
        public void FunUpCompanyProfile(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
            cmd.CommandText = "spUp_CompanyProfile";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Company_Id", prp.CompanyId);
            cmd.Parameters.AddWithValue("@Company_Name", prp.Company_Name);
            cmd.Parameters.AddWithValue("@Company_Tital_Name", prp.Company_Tital_Name);
            cmd.Parameters.AddWithValue("@Registration_No", prp.Registration_No);
            cmd.Parameters.AddWithValue("@Phone_No", prp.Phone_No);
            cmd.Parameters.AddWithValue("@Company_Address", prp.Company_Address);
            cmd.Parameters.AddWithValue("@City_Id", prp.cityID);
            cmd.Parameters.AddWithValue("@Company_Email_Id", prp.Company_Email_Id);
            cmd.Parameters.AddWithValue("@Company_Type_Id", prp.Company_Type_Id);
            cmd.Parameters.AddWithValue("@Company_Img_Url", prp.Company_Img_Url);
            cmd.Parameters.AddWithValue("@Employee_Designation", prp.Employee_Designation);
            cmd.Parameters.AddWithValue("@Company_IsActive", prp.Company_IsActive);
            cmd.Parameters.AddWithValue("@company_serviceOffers", prp.company_serviceOffers);
            cmd.Parameters.AddWithValue("@company_Description", prp.company_Description);
            cmd.Parameters.AddWithValue("@company_LogoForHome", prp.company_LogoForHome);
            cmd.Parameters.AddWithValue("@company_phoneNo", prp.company_phoneNo);
            cmd.Parameters.AddWithValue("@company_ContactPerson", prp.company_ContactPerson);
            cmd.Parameters.AddWithValue("@company_website", prp.company_website);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
           
        }

        public DataTable FunBindReptrById( clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataAdapter adp = new SqlDataAdapter("spView_CompanyPrflById", con);
            adp.SelectCommand.Parameters.AddWithValue("@companyId",prp.CompanyId);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
         }


        public string spDel_CompanyProfile(clsprpMovi prp)
        {
            string ms = "";
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
            cmd.CommandText = "spDel_CompanyProfile";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Company_Id", prp.CompanyId);
        

            cmd.Connection = con;
            ms = cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            con.Close();
            return ms;
        }



        //-------------------------


        public void FunInsertJobSeeker(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
            cmd.CommandText = "spInssert_RawJobSeeker";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@JS_Name", prp.JobSeekerName);
            cmd.Parameters.AddWithValue("@JS_dob", prp.JobSeekerDOB);
            cmd.Parameters.AddWithValue("@JS_Company", prp.JobSeekerCompany);
            cmd.Parameters.AddWithValue("@JS_Mobile", prp.JobSeekerMobile);
            cmd.Parameters.AddWithValue("@JS_IsActive", prp.IsActive);
            cmd.Parameters.AddWithValue("@JS_PEmailId", prp.JobSeekerPEmailId);
            cmd.Parameters.AddWithValue("@JS_OEmailId", prp.JobSeekerOEmailId);
            cmd.Parameters.AddWithValue("@JS_Address", prp.JobSeekerAddress);
            cmd.Parameters.AddWithValue("@JS_CityId", prp.cityID);
            cmd.Parameters.AddWithValue("@JS_JobTitle", prp.JobTitleID);
            cmd.Parameters.AddWithValue("@mobileNo2", prp.mobileNoII);

            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        public void FunUpJobSeeker(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
            cmd.CommandText = "spUpdate_RawJobSeeker";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@JS_Id", prp.JobSeekerID);
            cmd.Parameters.AddWithValue("@JS_Name", prp.JobSeekerName);
            cmd.Parameters.AddWithValue("@JS_dob", prp.JobSeekerDOB);
            cmd.Parameters.AddWithValue("@JS_Company", prp.JobSeekerCompany);
            cmd.Parameters.AddWithValue("@JS_JobTitle", prp.JobSeekerCurrentJob);

            cmd.Parameters.AddWithValue("@JS_Mobile", prp.JobSeekerMobile);
            cmd.Parameters.AddWithValue("@JS_IsActive", prp.IsActive);
            cmd.Parameters.AddWithValue("@JS_PEmailId", prp.JobSeekerPEmailId);
            cmd.Parameters.AddWithValue("@JS_OEmailId", prp.JobSeekerOEmailId);
            cmd.Parameters.AddWithValue("@JS_Address", prp.JobSeekerAddress);
            cmd.Parameters.AddWithValue("@JS_CityId", prp.cityID);
            cmd.Parameters.AddWithValue("@mobileNo2", prp.mobileNoII);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void FunDelJobSeeker(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
            cmd.CommandText = "spdel_JobSeeker";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@JS_Id", prp.JobSeekerID);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }




        public void spupdateJobSeekerIsActive(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
            cmd.CommandText = "spupdateJobSeekerIsActive";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", prp.JobSeekerID);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }


        public DataTable spJobseekerDetail()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataAdapter adp = new SqlDataAdapter("spJobseekerDetail", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
       
        
        public DataTable FunBindReptrJs()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataAdapter adp = new SqlDataAdapter("spView_JobSeeker", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public void FunViewJobSeeker()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
            cmd.CommandText = "spView_JobSeeker";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }



        

    public void spRelationCompany(clsprpMovi prp)
    {
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        cmd = new SqlCommand();
        cmd.CommandText = "spRelationCompany";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@companyId", prp.CompanyId);
        cmd.Parameters.AddWithValue("@query", prp.CompanyName);
        cmd.Connection = con;
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        con.Close();
    }

    public DataTable spselectRelationCompanyType(clsprpMovi prp)
    {
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        SqlDataAdapter adp = new SqlDataAdapter("spselectRelationCompanyType", con);
        adp.SelectCommand.Parameters.AddWithValue("@companyId", prp.CompanyId);
        adp.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataTable dt = new DataTable();
        adp.Fill(dt);
        return dt;
    }





    public DataTable funBindLstCityAll()
    {
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        SqlDataAdapter adp = new SqlDataAdapter("spView_JobCity", con);
        adp.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataTable dt = new DataTable();
        adp.Fill(dt);
        return dt;
    }



    public DataTable funBindListBoxsCompany()
    {
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        SqlDataAdapter adp = new SqlDataAdapter("spView_CompanyPrfl", con);
        adp.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataTable dt = new DataTable();
        adp.Fill(dt);
        return dt;
    }





        public void FunInsertJobs(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
            cmd.CommandText = "spIsertJob";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Job_Tital", prp.JobTitle);
            cmd.Parameters.AddWithValue("@Qualification_Id", prp.QualId);
            cmd.Parameters.AddWithValue("@Location_Id", prp.LocationId);
            
            cmd.Parameters.AddWithValue("@Skills_Id", prp.SkillsId);
            cmd.Parameters.AddWithValue("@job_CompanyId", prp.CompanyId);
            cmd.Parameters.AddWithValue("@Post_Date", prp.startDate);
            cmd.Parameters.AddWithValue("@job_TitleId", prp.JobId);

            cmd.Parameters.AddWithValue("@End_Date", prp.EndDate);
            cmd.Parameters.AddWithValue("@job_Profile", prp.profile);
            cmd.Parameters.AddWithValue("@job_Desctiption", prp.Descrption);
            cmd.Parameters.AddWithValue("@job_totalPost", prp.job_totalPost);

            cmd.Parameters.AddWithValue("@Minsalary", prp.Minsalary);
            cmd.Parameters.AddWithValue("@Maxsalary", prp.Maxsalary);
            cmd.Parameters.AddWithValue("@MinExprince", prp.MinExprince);
            cmd.Parameters.AddWithValue("@MaxExprince", prp.MaxExprince);

            cmd.Parameters.AddWithValue("@contactName", prp.contactName);
            cmd.Parameters.AddWithValue("@contactMobileNo", prp.contactMobileNo);
            cmd.Parameters.AddWithValue("@contactEmailId", prp.contactEmailId);
            cmd.Parameters.AddWithValue("@contactDesignation", prp.contactDesignation);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }




        public void spUpdateJob(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
            cmd.CommandText = "spUpdateJob";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@job_list_ID", prp.JobId);
            cmd.Parameters.AddWithValue("@Job_Tital", prp.JobTitle);
            cmd.Parameters.AddWithValue("@Qualification_Id", prp.QualId);
            cmd.Parameters.AddWithValue("@Location_Id", prp.LocationId);

            cmd.Parameters.AddWithValue("@Skills_Id", prp.SkillsId);
            cmd.Parameters.AddWithValue("@job_CompanyId", prp.CompanyId);
            cmd.Parameters.AddWithValue("@Post_Date", prp.startDate);
            cmd.Parameters.AddWithValue("@job_TitleId", prp.JobId);

            cmd.Parameters.AddWithValue("@End_Date", prp.EndDate);
            cmd.Parameters.AddWithValue("@job_Profile", prp.profile);
            cmd.Parameters.AddWithValue("@job_Desctiption", prp.Descrption);
            cmd.Parameters.AddWithValue("@job_totalPost", prp.job_totalPost);
           
            cmd.Parameters.AddWithValue("@Minsalary", prp.Minsalary);
            cmd.Parameters.AddWithValue("@Maxsalary", prp.Maxsalary);
            cmd.Parameters.AddWithValue("@MinExprince", prp.MinExprince);
            cmd.Parameters.AddWithValue("@MaxExprince", prp.MaxExprince);


            cmd.Parameters.AddWithValue("@contactName", prp.contactName);
            cmd.Parameters.AddWithValue("@contactMobileNo", prp.contactMobileNo);
            cmd.Parameters.AddWithValue("@contactEmailId", prp.contactEmailId);
            cmd.Parameters.AddWithValue("@contactDesignation", prp.contactDesignation);
      

            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        public void spDeteleJobs(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
            cmd.CommandText = "spDeteleJobs";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@jobId", prp.JobId);
            

            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }


        public DataTable SpAllJobsByDate()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataAdapter adp = new SqlDataAdapter("SpAllJobsByDate", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }



        public DataTable SpAllJobsByDateTop10()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataAdapter adp = new SqlDataAdapter("SpAllJobsByDateTop10", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }



        


        public DataTable SpJobsById( clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataAdapter adp = new SqlDataAdapter("SpJobsById", con);
            adp.SelectCommand.Parameters.AddWithValue("@jobId",prp.JobId);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }




        public DataTable spView_JobSeekerbyId(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dt = new DataTable();
            adp = new SqlDataAdapter("spView_JobSeekerbyId", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@id", prp.CompanyId);
            adp.Fill(dt);
            return dt;
        }   


        public DataTable spSearchJobByAdvance(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataAdapter adp = new SqlDataAdapter("spSearchJobByAdvance", con);
            adp.SelectCommand.Parameters.AddWithValue("@jobtitleID", prp.JobId);
            adp.SelectCommand.Parameters.AddWithValue("@locationID", prp.LocationId);
            adp.SelectCommand.Parameters.AddWithValue("@CompanyID", prp.CompanyId);
            adp.SelectCommand.Parameters.AddWithValue("@minSalary", prp.Minsalary);
            adp.SelectCommand.Parameters.AddWithValue("@maxSalary", prp.Maxsalary);
            adp.SelectCommand.Parameters.AddWithValue("@minEXprs", prp.MinExprince);
            adp.SelectCommand.Parameters.AddWithValue("@maxExprs", prp.MaxExprince);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }



        public DataTable spSearchJobByBasic(clsprpMovi prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataAdapter adp = new SqlDataAdapter("spSearchJobByBasic", con);
            adp.SelectCommand.Parameters.AddWithValue("@jobtitleID", prp.JobId);
            adp.SelectCommand.Parameters.AddWithValue("@locationID", prp.LocationId);
            adp.SelectCommand.Parameters.AddWithValue("@CompanyID", prp.CompanyId);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }


        public string job_Insert_PersonalDetails(clsprpMovi prp)
        {
            string ms = "";
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
            cmd.CommandText = "job_Insert_PersonalDetails";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@para_first_name", prp.jpd_First_Name);
            cmd.Parameters.AddWithValue("@para_Last_Name", prp.JPD_Last_Name);
            cmd.Parameters.AddWithValue("@para_Mobile_No", prp.jpd_Mobile_No);
            cmd.Parameters.AddWithValue("@para_Dateofbirth", prp.jpd_Date_Of_Birth);
            cmd.Parameters.AddWithValue("@para_Gender", prp.jpd_Gender);
            cmd.Parameters.AddWithValue("@para_Specialization_Id", prp.JHQD_Specilization_Id);
            cmd.Parameters.AddWithValue("@para_Total_Experience_Year", prp.JWD_Total_Experience_Year);
            cmd.Parameters.AddWithValue("@para_Total_Experience_Month", prp.JWD_Total_Experience_Month);
            cmd.Parameters.AddWithValue("@para_City_Id", prp.JPD_City_Id);
            cmd.Parameters.AddWithValue("@para_Email_Id", prp.JLD_Emial_Id);
            cmd.Parameters.AddWithValue("@para_Password", prp.JLD_password);
            cmd.Parameters.AddWithValue("@other_qualification", prp.ms_Specelization_Description);
           
            

            cmd.Connection = con;
          ms=  cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            con.Close();
            return ms;
        }



        public string spApplyJob(clsprpMovi prp)
        {
            string msg = "";
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
            cmd.CommandText = "spApplyJob";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@job_listId", prp.JobId);
            cmd.Parameters.AddWithValue("@appliedJob", prp.cityID);
            cmd.Connection = con;
             msg= cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            con.Close();

            return msg;
        }



        public string spExecuteQuery(clsprpMovi prp)
        {
            string msg = "";
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
            cmd.CommandText = "spExecuteQuery";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@query", prp.profile);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

            return msg;
        }



        public string spInsertMail(clsprpMovi prp)
        {
            string msg = "";
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
            cmd.CommandText = "spInsertMail";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@blastjobid", prp.blastjobid);
            cmd.Parameters.AddWithValue("@blastHeading", prp.blastHeading);
            cmd.Parameters.AddWithValue("@blastBody", prp.blastBody);
            cmd.Connection = con;
            msg = cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            con.Close();

            return msg;
        }
    }

    }   
