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


public partial class JobPlacement_Resume : System.Web.UI.Page
{
    string strcon = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        bindResume();
    }
    public void bindResume()
    {
        SqlConnection con = new SqlConnection(strcon);

          string sLoginId = Session["schoolid"].ToString();

          SqlCommand cmd = new SqlCommand("Sp_BindResume", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "Sp_BindResume";
       try
       {
       SqlParameter[] paramsToStore = new SqlParameter[1];
 
       paramsToStore[0] = new SqlParameter("@Jobdetails_Id", SqlDbType.NVarChar);
       paramsToStore[0].Size=200;
       cmd.Parameters.Add(paramsToStore[0]).Value = sLoginId;
 
   
       }

        catch (Exception excp)
        {
        }
        con.Open();
        cmd.Connection = con;
        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {
           
            String sServices = "<img border='0' src='../Advertisement/" + dr["collegeImage"].ToString() + "' width='170' height='90'/>";
            litImage.Text = sServices;
            litName.Text = "<span style='margin-right: 70px;' class='jobtxtColur'>" + dr["collegeName"].ToString() + "</span>";
            litEmail.Text = "<span style='margin-right: 70px;' class='jobtxtColur'>" + dr["collegeEmailID"].ToString() + "</span>";
            litPresentLocation.Text = "<span style='margin-right: 70px;' class='jobtxtColur'>" + dr["present_job_Location"].ToString() + "</span>";
            
        }
        con.Close();
    }
    
}