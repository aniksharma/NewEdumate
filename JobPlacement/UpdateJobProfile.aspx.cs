using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class JobPlacement_UpdateJobProfile : System.Web.UI.Page
{
    string strcon = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
    string temp;
    protected void Page_Load(object sender, EventArgs e)
    {
        bindData();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (FileUploadCV.HasFile)
        {

            int imageSize = (FileUploadCV.PostedFile.ContentLength) / 300;
            string strFileExtention = FileUploadCV.FileName.Substring(FileUploadCV.PostedFile.FileName.LastIndexOf("."));
            string millisecond = DateTime.Now.Millisecond.ToString();

            if (FileUploadCV.PostedFile.ContentLength > 1048576)
            {
                
            }

            string filename = FileUploadCV.FileName;

            
            string thumbImage = "thumb_" + filename;

            string imageType = "Image-" + strFileExtention.Substring(1);
            FileUploadCV.SaveAs(Server.MapPath("CV/" + filename));

            string sLoginId= Session["schoolid"].ToString();

            if (btnSubmit.Text.ToUpper() == "Submit".ToUpper())
            {
                SqlConnection conn = new SqlConnection(strcon);


                string sLoginId1 = Session["schoolid"].ToString();

                SqlCommand cmd1 = new SqlCommand("Sp_jobDetail_bind", conn);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.CommandText = "Sp_jobDetail_bind";
                try
                {
                    SqlParameter[] paramsToStore =
                 new SqlParameter[1];

                    paramsToStore[0] = new SqlParameter("@createby", SqlDbType.NVarChar);
                    paramsToStore[0].Size = 100;
                    cmd1.Parameters.Add(paramsToStore[0]).Value = sLoginId1;


                }
                catch (Exception excp)
                {
                    lblMsg.ForeColor = System.Drawing.Color.Red;
                    lblMsg.Text = excp.Message;
                }
                conn.Open();
                cmd1.Connection = conn;
              
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    lblId.Text = dr["Jobdetails_Id"].ToString();
                   
                }
                else
                {
                    lblId.Text = "";
                }

           
            SqlConnection con = new SqlConnection(strcon);

            SqlCommand cmd = new SqlCommand("sp_JobProfile", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_JobProfile";
            try
            {
                SqlParameter[] paramsToStore = new SqlParameter[23];

                paramsToStore[0] = new SqlParameter("@Jobdetails_Id", SqlDbType.NVarChar);
                paramsToStore[0].Size = 100;
                cmd.Parameters.Add(paramsToStore[0]).Value = lblId.Text;
                paramsToStore[1] = new SqlParameter("@Skill", SqlDbType.NVarChar);
                paramsToStore[1].Size = 100;
                cmd.Parameters.Add(paramsToStore[1]).Value = txtSkills.Text;
                paramsToStore[2] = new SqlParameter("@Industry", SqlDbType.NVarChar);
                paramsToStore[2].Size = 200;
                cmd.Parameters.Add(paramsToStore[2]).Value = txtIndustry.Text;
                paramsToStore[3] = new SqlParameter("@Functional_Area", SqlDbType.NVarChar);
                paramsToStore[3].Size = 200;
                cmd.Parameters.Add(paramsToStore[3]).Value = ddlFunctionalArea.SelectedItem.ToString();
                paramsToStore[4] = new SqlParameter("@Role", SqlDbType.NVarChar);
                paramsToStore[4].Size = 100;
                cmd.Parameters.Add(paramsToStore[4]).Value = ddlRole.SelectedItem.ToString();
                paramsToStore[5] = new SqlParameter("@Category", SqlDbType.NVarChar);
                paramsToStore[5].Size = 100;
                cmd.Parameters.Add(paramsToStore[5]).Value = ddlCategory.SelectedItem.ToString();
                paramsToStore[6] = new SqlParameter("@Current_Employer", SqlDbType.NVarChar);
                paramsToStore[6].Size = 200;
                cmd.Parameters.Add(paramsToStore[6]).Value = txtCurrentEmployer.Text;
                paramsToStore[7] = new SqlParameter("@Current_Salary", SqlDbType.NVarChar);
                paramsToStore[7].Size = 100;
                cmd.Parameters.Add(paramsToStore[7]).Value = ddlcurrentsalary.SelectedItem.ToString();
                paramsToStore[8] = new SqlParameter("@Expected_Salary", SqlDbType.NVarChar);
                paramsToStore[8].Size = 100;
                cmd.Parameters.Add(paramsToStore[8]).Value = ddlExpectedSalary.SelectedItem.ToString();
                paramsToStore[9] = new SqlParameter("@Previous_Employer", SqlDbType.NVarChar);
                paramsToStore[9].Size = 100;
                cmd.Parameters.Add(paramsToStore[9]).Value = txtPreviousEmployer.Text;
                paramsToStore[10] = new SqlParameter("@Present_Job_Location", SqlDbType.NVarChar);
                paramsToStore[10].Size = 100;
                cmd.Parameters.Add(paramsToStore[10]).Value = txtpresentJobLocation.Text;
                paramsToStore[11] = new SqlParameter("@Preferred_Job_Location", SqlDbType.NVarChar);
                paramsToStore[11].Size = 100;
                cmd.Parameters.Add(paramsToStore[11]).Value = ddlCountry.SelectedItem.ToString();
                paramsToStore[12] = new SqlParameter("@Total_Experience_Year", SqlDbType.NVarChar);
                paramsToStore[12].Size = 100;
                cmd.Parameters.Add(paramsToStore[12]).Value = ddltotalexperience.SelectedItem.ToString();
                paramsToStore[13] = new SqlParameter("@Total_Experience_Month", SqlDbType.NVarChar);
                paramsToStore[13].Size = 100;
                cmd.Parameters.Add(paramsToStore[13]).Value = ddlMonths.SelectedItem.ToString();
                paramsToStore[14] = new SqlParameter("@Interested_Job_Type", SqlDbType.NVarChar);
                paramsToStore[14].Size = 100;
                cmd.Parameters.Add(paramsToStore[14]).Value = ddlJobtype.SelectedItem.ToString();
                paramsToStore[15] = new SqlParameter("@Highest_Qualification", SqlDbType.NVarChar);
                paramsToStore[15].Size = 100;
                cmd.Parameters.Add(paramsToStore[15]).Value = ddlhighestQualification.SelectedItem.ToString();
                paramsToStore[16] = new SqlParameter("@Passing_Year", SqlDbType.NVarChar);
                paramsToStore[16].Size = 100;
                cmd.Parameters.Add(paramsToStore[16]).Value = ddlPassingYear.SelectedItem.ToString();
                paramsToStore[17] = new SqlParameter("@Language", SqlDbType.NVarChar);
                paramsToStore[17].Size = 100;
                cmd.Parameters.Add(paramsToStore[17]).Value = txtLanguage.Text;
                paramsToStore[18] = new SqlParameter("@Resume_Title", SqlDbType.NVarChar);
                paramsToStore[18].Size = 100;
                cmd.Parameters.Add(paramsToStore[18]).Value = txtResumeTitle.Text;
                paramsToStore[19] = new SqlParameter("@Upload_Your_Cv", SqlDbType.NVarChar);
                paramsToStore[19].Size = 100;
                cmd.Parameters.Add(paramsToStore[19]).Value = filename;
                paramsToStore[20] = new SqlParameter("@delstatus", SqlDbType.NVarChar);
                paramsToStore[20].Size = 100;
                cmd.Parameters.Add(paramsToStore[20]).Value = "0";
                paramsToStore[21] = new SqlParameter("@createby", SqlDbType.NVarChar);
                paramsToStore[21].Size = 100;
                cmd.Parameters.Add(paramsToStore[21]).Value = sLoginId;
                paramsToStore[22] = new SqlParameter("@createtime", SqlDbType.NVarChar);
                paramsToStore[22].Size = 100;
                cmd.Parameters.Add(paramsToStore[22]).Value = DateTime.Now.ToShortDateString(); 

            }
            catch (Exception excp)
            {
                lblMsg.Visible = true;
                lblMsg.ForeColor = System.Drawing.Color.Green;
                lblMsg.Text = excp.Message;
            }
            con.Open();
            cmd.Connection = con;
            int y = cmd.ExecuteNonQuery();
            if (y > 0)
            {
                lblMsg.Visible = true;
                lblMsg.ForeColor = System.Drawing.Color.Green;
                lblMsg.Text = "Job Profile Updated";
                clear();
            }
            else
            {
                lblMsg.Text = "No File Available";
            }
        }
        //}

        else
        {
            lblMsg.ForeColor = System.Drawing.Color.Red;
            lblMsg.Text = "No File Available";
         
        }
    }
    }

    public void clear()
    {
        txtSkills.Text = " ";
        txtIndustry.Text = "";
        ddlFunctionalArea.ClearSelection();
        ddlRole.ClearSelection();
        ddlCategory.ClearSelection();
        txtCurrentEmployer.Text ="";
        ddlcurrentsalary.ClearSelection();
        ddlExpectedSalary.ClearSelection();
        txtPreviousEmployer.Text = "";
        txtpresentJobLocation.Text ="";
        ddlCountry.ClearSelection();
        ddltotalexperience.ClearSelection();
        ddlMonths.ClearSelection();
        ddlJobtype.ClearSelection();
        ddlhighestQualification.ClearSelection();
        ddlPassingYear.ClearSelection();
        txtLanguage.Text = "";
        txtResumeTitle.Text = "";
    }
    public void bindData()
    {
        SqlConnection con = new SqlConnection(strcon);

         string sLoginId= Session["schoolid"].ToString();

            SqlCommand cmd = new SqlCommand("Sp_jobDetail_bind", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sp_jobDetail_bind";
        try
           {
           SqlParameter[] paramsToStore = 
        new SqlParameter[1];
 
           paramsToStore[0] = new SqlParameter("@createby", SqlDbType.NVarChar);
           paramsToStore[0].Size=100;
           cmd.Parameters.Add(paramsToStore[0]).Value = sLoginId;
 
          
           }
        catch(Exception excp)
           {
               lblMsg.ForeColor = System.Drawing.Color.Red;
               lblMsg.Text = excp.Message;
           }
         con.Open();
         cmd.Connection = con;
        
         SqlDataReader dr = cmd.ExecuteReader();
         if (dr.Read())
         {
             lblId.Text = dr["Jobdetails_Id"].ToString();
             Session["Jobdetails_Id"] = lblId.Text;
             txtSkills.Text = dr["Skill"].ToString();
             txtIndustry.Text = dr["Industry"].ToString();
             ddlFunctionalArea.ClearSelection();
             ddlFunctionalArea.Items.FindByValue(dr["Functional_Area"].ToString()).Selected = true;
             ddlRole.ClearSelection();
             ddlRole.Items.FindByValue(dr["Role"].ToString()).Selected = true;
             ddlCategory.ClearSelection();
             ddlCategory.Items.FindByValue(dr["Category"].ToString()).Selected = true;
             txtCurrentEmployer.Text = dr["Current_Employer"].ToString();
             ddlcurrentsalary.ClearSelection();
             ddlcurrentsalary.Items.FindByValue(dr["Current_Salary"].ToString()).Selected = true;
             ddlExpectedSalary.ClearSelection();
             ddlExpectedSalary.Items.FindByValue(dr["Expected_Salary"].ToString()).Selected = true;
             txtPreviousEmployer.Text = dr["Previous_Employer"].ToString();
             txtpresentJobLocation.Text = dr["Present_Job_Location"].ToString();

             ddlCountry.ClearSelection();
             ddlCountry.Items.FindByValue(dr["Preferred_Job_Location"].ToString()).Selected = true;

             ddltotalexperience.ClearSelection();
             ddltotalexperience.Items.FindByValue(dr["Total_Experience_Year"].ToString()).Selected = true;
             ddlMonths.ClearSelection();
             ddlMonths.Items.FindByValue(dr["Total_Experience_Month"].ToString()).Selected = true;
             ddlJobtype.ClearSelection();
             ddlJobtype.Items.FindByValue(dr["Interested_Job_Type"].ToString()).Selected = true;
             ddlhighestQualification.ClearSelection();
             ddlhighestQualification.Items.FindByValue(dr["Highest_Qualification"].ToString()).Selected = true;
             ddlPassingYear.ClearSelection();
             ddlPassingYear.Items.FindByValue(dr["Passing_Year"].ToString()).Selected = true;
             txtLanguage.Text = dr["Language"].ToString();
             txtResumeTitle.Text = dr["Resume_Title"].ToString();
             lblFileupload.Text = dr["Upload_Your_Cv"].ToString();
             FileUploadCV.SaveAs(Server.MapPath("CV/") + dr["Upload_Your_Cv"].ToString());
         }
         else
         {
             lblMsg.Text = "No File Available";
         }
    }
}