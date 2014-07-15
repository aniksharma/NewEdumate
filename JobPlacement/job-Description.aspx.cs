using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Services;

public partial class JobPlacement_job_Description : System.Web.UI.Page
{
    string strcon = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
    string sLiteral = "";
    string strsave, strsave1, strsave2, strsave3, strsave4;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
        }  
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(strcon);
        if (ddlFunctional_Area.SelectedItem.Text != " " && ddlCategory.SelectedItem.ToString() == "--Select category--" && txtlocation.Text =="")
        {
            SqlCommand cmd = new SqlCommand("Sp_JobDetails_Search_Bind", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sp_JobDetails_Search_Bind";
            try
            {
                SqlParameter[] paramsToStore =
             new SqlParameter[4];

                paramsToStore[0] = new SqlParameter("@Present_Job_Location", SqlDbType.NVarChar);
                paramsToStore[0].Size = 200;
                cmd.Parameters.Add(paramsToStore[0]).Value = txtlocation.Text;
                paramsToStore[1] = new SqlParameter("@Preferred_Job_Location", SqlDbType.NVarChar);
                paramsToStore[1].Size = 200;
                cmd.Parameters.Add(paramsToStore[1]).Value = txtlocation.Text;
                paramsToStore[2] = new SqlParameter("@Functional_Area", SqlDbType.NVarChar);
                paramsToStore[2].Size = 200;
                cmd.Parameters.Add(paramsToStore[2]).Value = ddlFunctional_Area.SelectedItem.ToString();
                paramsToStore[3] = new SqlParameter("@Category", SqlDbType.NVarChar);
                paramsToStore[3].Size = 200;
                cmd.Parameters.Add(paramsToStore[3]).Value = ddlCategory.SelectedItem.ToString();


            }
            catch (Exception excp)
            {
                lblMsg.ForeColor = System.Drawing.Color.Red;
                lblMsg.Text = excp.Message;
            }
        
            con.Open();
            cmd.Connection = con;
            //SqlDataReader dr = cmd.ExecuteReader();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                sLiteral = " <link href='../render/stylesheetedumate.css' rel='stylesheet' type='text/css' />";

                for (int iPackage = 0; iPackage < dt.Rows.Count; iPackage++)
                {


                    try
                    {
                        sLiteral = sLiteral + "<article class='artcless-middle'>";
                        sLiteral = sLiteral + "<h5 class='hdng-03'>";
                        sLiteral = sLiteral + dt.Rows[iPackage]["Role"].ToString();
                        sLiteral = sLiteral + "</h5>";
                        sLiteral = sLiteral + "<p class='artcless-img-02'>";

                        String sServices = "<img border='0' src='../Advertisement/" + dt.Rows[iPackage]["collegeImage"].ToString() + "' width='141' height='90'/>";
                        sLiteral = sLiteral + sServices;
                        sLiteral = sLiteral + "</p>";

                        sLiteral = sLiteral + "<div class='artcless-container'>";
                        strsave = "<span style='color:#5086BB'>" + "Employer Name : " + "</span>" + "<span style='margin-left:2px;'>" + dt.Rows[iPackage]["collegeName"].ToString() + "</span>";
                        strsave1 = "<span style='color:#5086BB;margin-right: 43px;' class='jobtxtColur'>" + "Location : " + "</span>" + dt.Rows[iPackage]["present_job_Location"].ToString() + " - " + dt.Rows[iPackage]["Preferred_job_Location"].ToString();
                        strsave2 = "<span style='color:#5086BB'>" + "Experience :" + "</span>" + "<span style='margin-left:32px;'>" + dt.Rows[iPackage]["Total_Experience_Year"].ToString() + "<span style='color:#5086BB'>" + " Year" + "</span>" + " - " + dt.Rows[iPackage]["Total_Experience_Month"].ToString() + "<span style='color:#5086BB'>" + " Months" + "</span>" + "</span>";
                        strsave3 = "<span style='color:#5086BB;margin-right:67px;' class='jobtxtColur'>" + "Skill : " + "</span>" + dt.Rows[iPackage]["Skill"].ToString();
                        strsave4 = "<span style='color:#5086BB;margin-right:19px;'>" + "Posted Time : " + "</span>" + dt.Rows[iPackage]["createtime"].ToString();
                        sLiteral = sLiteral + "</div>";

                        sLiteral = sLiteral + strsave + "</br>" + strsave1 + "</br>" + strsave2 + "</br>" + strsave3 + "</br>" + strsave4 + "</br>";
                       
                        sLiteral = sLiteral + "</article>";
                    }
                    catch
                    {
                       
                    }
                    litName.Text = sLiteral;
                }

            }
            else
            {
                litbody.Text = "";
              
                litName.Text = "";
                litPresentLocation.Text = "";
                litPreLocation.Text = "";
            }
            txtlocation.Text = "";
            ddlFunctional_Area.ClearSelection();
            ddlCategory.ClearSelection();
            con.Close();
        }
        else if (ddlCategory.SelectedItem.ToString() != "" && ddlFunctional_Area.SelectedItem.ToString() == "--Select Functional Area--" && txtlocation.Text=="")
        {
             SqlCommand cmd = new SqlCommand("Sp_JobDetails_Search_Bind_Category", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sp_JobDetails_Search_Bind_Category";
            try
               {
               SqlParameter[] paramsToStore = 
            new SqlParameter[1];
 
               paramsToStore[0] = new SqlParameter("@Category", SqlDbType.NVarChar);
               paramsToStore[0].Size=200;
               cmd.Parameters.Add(paramsToStore[0]).Value = ddlCategory.SelectedItem.ToString() ;
 
              
               }
            catch (Exception excp)
            {
                lblMsg.ForeColor = System.Drawing.Color.Red;
                lblMsg.Text = excp.Message;
            }
            con.Open();
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                sLiteral = " <link href='../render/stylesheetedumate.css' rel='stylesheet' type='text/css' />";

                for (int iPackage = 0; iPackage < dt.Rows.Count; iPackage++)
                {


                    try
                    {
                        sLiteral = sLiteral + "<article class='artcless-middle'>";
                        sLiteral = sLiteral + "<h5 class='hdng-03'>";
                        sLiteral = sLiteral + dt.Rows[iPackage]["Role"].ToString();
                        sLiteral = sLiteral + "</h5>";
                        sLiteral = sLiteral + "<p class='artcless-img-02'>";

                        String sServices = "<img border='0' src='../Advertisement/" + dt.Rows[iPackage]["collegeImage"].ToString() + "' width='141' height='90'/>";
                        sLiteral = sLiteral + sServices;
                        sLiteral = sLiteral + "</p>";

                        sLiteral = sLiteral + "<div class='artcless-container'>";
                        strsave = "<span style='color:#5086BB'>" + "Employer Name : " + "</span>" + "<span style='margin-left:2px;'>" + dt.Rows[iPackage]["collegeName"].ToString() + "</span>";
                        strsave1 = "<span style='color:#5086BB;margin-right: 43px;' class='jobtxtColur'>" + "Location : " + "</span>" + dt.Rows[iPackage]["present_job_Location"].ToString() + " - " + dt.Rows[iPackage]["Preferred_job_Location"].ToString();
                        strsave2 = "<span style='color:#5086BB'>" + "Experience :" + "</span>" + "<span style='margin-left:32px;'>" + dt.Rows[iPackage]["Total_Experience_Year"].ToString() + "<span style='color:#5086BB'>" + " Year" + "</span>" + " - " + dt.Rows[iPackage]["Total_Experience_Month"].ToString() + "<span style='color:#5086BB'>" + " Months" + "</span>" + "</span>";
                        strsave3 = "<span style='color:#5086BB;margin-right:67px;' class='jobtxtColur'>" + "Skill : " + "</span>" + dt.Rows[iPackage]["Skill"].ToString();
                        strsave4 = "<span style='color:#5086BB;margin-right:19px;'>" + "Posted Time : " + "</span>" + dt.Rows[iPackage]["createtime"].ToString();
                        sLiteral = sLiteral + "</div>";

                        sLiteral = sLiteral + strsave + "</br>" + strsave1 + "</br>" + strsave2 + "</br>" + strsave3 + "</br>" + strsave4 + "</br>";
                        sLiteral = sLiteral + "</article>";
                    }
                    catch
                    {
                       
                    }
                    litName.Text = sLiteral;
                }

            }
            else
            {
                litbody.Text = "";
                litName.Text = "";
                litPresentLocation.Text = "";
                litPreLocation.Text = "";
            }
            txtlocation.Text = "";
            ddlFunctional_Area.ClearSelection();
            ddlCategory.ClearSelection();
            con.Close();
        }
        else
        {
             SqlCommand cmd = new SqlCommand("Sp_JobDetails_Search_Bind_Location", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sp_JobDetails_Search_Bind_Location";
            try
               {
               SqlParameter[] paramsToStore = 
            new SqlParameter[1];
 
               paramsToStore[0] = new SqlParameter("@Present_Job_Location", SqlDbType.NVarChar);
               paramsToStore[0].Size=200;
               cmd.Parameters.Add(paramsToStore[0]).Value =  txtlocation.Text;
 
              
               }
           catch (Exception excp)
            {
                lblMsg.ForeColor = System.Drawing.Color.Red;
                lblMsg.Text = excp.Message;
            }
            con.Open();
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                sLiteral = " <link href='../render/stylesheetedumate.css' rel='stylesheet' type='text/css' />";

                for (int iPackage = 0; iPackage < dt.Rows.Count; iPackage++)
                {


                    try
                    {
                        sLiteral = sLiteral + "<article class='artcless-middle'>";
                        sLiteral = sLiteral + "<h5 class='hdng-03'>";
                        sLiteral = sLiteral + dt.Rows[iPackage]["Role"].ToString();
                        sLiteral = sLiteral + "</h5>";
                        sLiteral = sLiteral + "<p class='artcless-img-02'>";

                        String sServices = "<img border='0' src='../Advertisement/" + dt.Rows[iPackage]["collegeImage"].ToString() + "' width='141' height='90'/>";
                        sLiteral = sLiteral + sServices;
                        sLiteral = sLiteral + "</p>";

                        sLiteral = sLiteral + "<div class='artcless-container'>";
                        strsave = "<span style='color:#5086BB'>" + "Employer Name : " + "</span>" + "<span style='margin-left:2px;'>" + dt.Rows[iPackage]["collegeName"].ToString() + "</span>";
                        strsave1 = "<span style='color:#5086BB;margin-right: 43px;' class='jobtxtColur'>" + "Location : " + "</span>" + dt.Rows[iPackage]["present_job_Location"].ToString() + " - " + dt.Rows[iPackage]["Preferred_job_Location"].ToString();
                        strsave2 = "<span style='color:#5086BB'>" + "Experience :" + "</span>" + "<span style='margin-left:32px;'>" + dt.Rows[iPackage]["Total_Experience_Year"].ToString() + "<span style='color:#5086BB'>" + " Year" + "</span>" + " - " + dt.Rows[iPackage]["Total_Experience_Month"].ToString() + "<span style='color:#5086BB'>" + " Months" + "</span>" + "</span>";
                        strsave3 = "<span style='color:#5086BB;margin-right:67px;' class='jobtxtColur'>" + "Skill : " + "</span>" + dt.Rows[iPackage]["Skill"].ToString();
                        strsave4 = "<span style='color:#5086BB;margin-right:19px;'>" + "Posted Time : " + "</span>" + dt.Rows[iPackage]["createtime"].ToString();
                        sLiteral = sLiteral + "</div>";

                        sLiteral = sLiteral + strsave + "</br>" + strsave1 + "</br>" + strsave2 + "</br>" + strsave3 + "</br>" + strsave4 + "</br>";
                        sLiteral = sLiteral + "</article>";
                    }
                    catch
                    {
                       
                    }
                    litName.Text = sLiteral;
                }

            }
            else
            {
                litbody.Text = "";
                litName.Text = "";
                litPresentLocation.Text = "";
                litPreLocation.Text = "";
            }
            txtlocation.Text = "";
            ddlFunctional_Area.ClearSelection();
            ddlCategory.ClearSelection();
            con.Close();
        }
    }
 
}



