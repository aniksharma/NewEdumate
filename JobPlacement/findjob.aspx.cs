using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class JobPlacement_findjob : System.Web.UI.Page
{
     string strcon = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
     string sLiteral="";
     string strsave, strsave1, strsave2, strsave3, strsave4;
     
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSearch_Click(object sender, EventArgs e)
    { 
        SqlConnection con = new SqlConnection(strcon);

        if (ddlFunctional_Area.SelectedItem.Text != " " && ddlCategory.SelectedItem.ToString() == "--Select category--" && ddlRole.SelectedItem.ToString() == "--Select Role--")
        {
            SqlCommand cmd = new SqlCommand("Sp_JD_Functional_Area", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sp_JD_Functional_Area";
        try
           {
           SqlParameter[] paramsToStore = new SqlParameter[1];
 
           paramsToStore[0] = new SqlParameter("@Functional_Area", SqlDbType.NVarChar);
           paramsToStore[0].Size=200;
           cmd.Parameters.Add(paramsToStore[0]).Value = ddlFunctional_Area.SelectedItem.ToString();
 
           
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
            if (dt.Rows.Count>0)
            {
                sLiteral = " <link href='../render/stylesheetedumate.css' rel='stylesheet' type='text/css' />";
                   
                    for (int iPackage = 0; iPackage < dt.Rows.Count; iPackage++)
                    {

                        try
                        {
                            sLiteral = sLiteral + "<article class='artcless-middle'>";
                            sLiteral = sLiteral + "<h5 class='hdng-03'>";
                          
                            sLiteral = sLiteral + "</h5>";
                            sLiteral = sLiteral + "<p class='artcless-img-02'>";

                            String sServices = "<img border='0' src='../Advertisement/" + dt.Rows[iPackage]["collegeImage"].ToString() + "' width='135' height='70'/>";
                            sLiteral = sLiteral + sServices;
                            sLiteral = sLiteral + "</p>";

                            sLiteral = sLiteral + "<div class='artcless-container'>";
                            strsave = "<span class='lft-sectn-hdng' style='color:#5086BB;'>" + "Organisation Name : " + "</span>" + "<span style='margin-left:2px;'>" + dt.Rows[iPackage]["Organisation_Name"].ToString() + "</span>";
                            strsave1 = "<span style='color:#5086BB;float:left;width:124px;'>" + "Job Description : " + "</span>" + "<span style='float:left;text-align:justify;width: 410px;line-height:22px;'>" + dt.Rows[iPackage]["Job_Description"].ToString() + "....." + "</span>" + "<span style='color:#399d1a;float:right;'>" + "<a class='readmore' target ='_blank' href='ViewJobsDetails.aspx?Id=" + dt.Rows[iPackage]["jdID"].ToString() + "'>ViewDetails...</a>" + "</span>";
                            strsave2 = "<span style='color:#5086BB;float:left;width:124px;'>" + "Skill :" + "</span>" + "<span>" + dt.Rows[iPackage]["Skill"].ToString() + "..." + "</span>";
                            strsave3 = "<span style='bottom:94px;color:#5086BB;float:right;position:relative;right:-66px;'>" + dt.Rows[iPackage]["createdatetime"].ToString() + "</span>";
                            sLiteral = sLiteral + "</div>";

                            sLiteral = sLiteral + strsave + "</br>" + strsave1 + "</br>" + strsave2 + "</br>" + strsave3 + "</br>";
                            sLiteral = sLiteral + "</article>";
                        }
                        catch
                        {
                            litbody.Text = "No Data Found..";
                        }
                    }
                   

                litName.Text = sLiteral;
              
            }
            else
            {
                litbody.Text = "";
                litName.Text = "";
                litPresentLocation.Text = "";
                litPreLocation.Text = "";
            }
            ddlRole.ClearSelection();
            ddlFunctional_Area.ClearSelection();
            ddlCategory.ClearSelection();
            con.Close();
        }
    
        else if (ddlCategory.SelectedItem.ToString() != "" && ddlFunctional_Area.SelectedItem.ToString() == "--Select Functional Area--" && ddlRole.SelectedItem.ToString() == "--Select Role--")
        {
            SqlCommand cmd = new SqlCommand("Sp_JD_Category", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sp_JD_Category";
           try
               {
               SqlParameter[] paramsToStore = new SqlParameter[1];
 
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
            if (dt.Rows.Count>0)
            {
                sLiteral = " <link href='../render/stylesheetedumate.css' rel='stylesheet' type='text/css' />";
                   
                    for (int iPackage = 0; iPackage < dt.Rows.Count; iPackage++)
                    {

                        try
                        {
                            sLiteral = sLiteral + "<article class='artcless-middle'>";
                            sLiteral = sLiteral + "<h5 class='hdng-03'>";
                          
                            sLiteral = sLiteral + "</h5>";
                            sLiteral = sLiteral + "<p class='artcless-img-02'>";

                            String sServices = "<img border='0' src='../Advertisement/" + dt.Rows[iPackage]["collegeImage"].ToString() + "' width='135' height='70'/>";
                            sLiteral = sLiteral + sServices;
                            sLiteral = sLiteral + "</p>";

                            sLiteral = sLiteral + "<div class='artcless-container'>";
                            strsave = "<span class='lft-sectn-hdng' style='color:#5086BB;'>" + "Organisation Name : " + "</span>" + "<span style='margin-left:2px;'>" + dt.Rows[iPackage]["Organisation_Name"].ToString() + "</span>";
                            strsave1 = "<span style='color:#5086BB;float:left;width:124px;'>" + "Job Description : " + "</span>" + "<span style='float:left;text-align:justify;width: 410px;line-height:22px;'>" + dt.Rows[iPackage]["Job_Description"].ToString() + "....." + "</span>" + "<span style='color:#399d1a;float:right;'>" + "<a class='readmore' target ='_blank' href='ViewJobsDetails.aspx?Id=" + dt.Rows[iPackage]["jdID"].ToString() + "'>ViewDetails...</a>" + "</span>";
                            strsave2 = "<span style='color:#5086BB;float:left;width:124px;'>" + "Skill :" + "</span>" + "<span>" + dt.Rows[iPackage]["Skill"].ToString() + "..." + "</span>";
                            strsave3 = "<span style='bottom:94px;color:#5086BB;float:right;position:relative;right:-66px;'>" + dt.Rows[iPackage]["createdatetime"].ToString() + "</span>";
                            sLiteral = sLiteral + "</div>";
                            sLiteral = sLiteral + strsave + "</br>" + strsave1 + "</br>" + strsave2 + "</br>" + strsave3 + "</br>";
                            sLiteral = sLiteral + "</article>";
                        }
                        catch
                        {
                            litbody.Text = "No Data Found..";
                        }
                    }
                   

                litName.Text = sLiteral;
              
            }
            else
            {
                litbody.Text = "";
                litName.Text = "";
                litPresentLocation.Text = "";
                litPreLocation.Text = "";
            }
            ddlRole.ClearSelection();
            ddlFunctional_Area.ClearSelection();
            ddlCategory.ClearSelection();
            con.Close();
        }
            
        else
        {
            SqlCommand cmd = new SqlCommand("Sp_JD_Role", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sp_JD_Role";
           try
               {
               SqlParameter[] paramsToStore = new SqlParameter[1];
 
               paramsToStore[0] = new SqlParameter("@Role", SqlDbType.NVarChar);
               paramsToStore[0].Size=200;
               cmd.Parameters.Add(paramsToStore[0]).Value = ddlRole.SelectedItem.ToString();


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
                       sLiteral = sLiteral + "</h5>";
                       sLiteral = sLiteral + "<p class='artcless-img-02'>";

                       String sServices = "<img border='0' src='../Advertisement/" + dt.Rows[iPackage]["collegeImage"].ToString() + "' width='135' height='70'/>";
                       sLiteral = sLiteral + sServices;
                       sLiteral = sLiteral + "</p>";

                       sLiteral = sLiteral + "<div class='artcless-container'>";
                       strsave = "<span class='lft-sectn-hdng' style='color:#5086BB;'>" + "Organisation Name : " + "</span>" + "<span style='margin-left:2px;'>" + dt.Rows[iPackage]["Organisation_Name"].ToString() + "</span>";
                       strsave1 = "<span style='color:#5086BB;float:left;width:124px;'>" + "Job Description : " + "</span>" + "<span style='float:left;text-align:justify;width: 410px;line-height:22px;'>" + dt.Rows[iPackage]["Job_Description"].ToString() + "....." + "</span>" + "<span style='color:#399d1a;float:right;'>" + "<a class='readmore' target ='_blank' href='ViewJobsDetails.aspx?Id=" + dt.Rows[iPackage]["jdID"].ToString() + "'>ViewDetails...</a>" + "</span>";
                       strsave2 = "<span style='color:#5086BB;float:left;width:124px;'>" + "Skill :" + "</span>" + "<span>" + dt.Rows[iPackage]["Skill"].ToString() + "..." + "</span>";
                       strsave3 = "<span style='bottom:94px;color:#5086BB;float:right;position:relative;right:-66px;'>" + dt.Rows[iPackage]["createdatetime"].ToString() + "</span>";
                       sLiteral = sLiteral + "</div>";
                       sLiteral = sLiteral + strsave + "</br>" + strsave1 + "</br>" + strsave2 + "</br>" + strsave3 + "</br>";
                       sLiteral = sLiteral + "</article>";
                   }
                   catch
                   {
                       litbody.Text = "No Data Found..";
                   }
               }


               litName.Text = sLiteral;

           }
           else
           {
               litbody.Text = "";

               litName.Text = "";
               litPresentLocation.Text = "";
               litPreLocation.Text = "";
           }
           ddlRole.ClearSelection();
           ddlFunctional_Area.ClearSelection();
           ddlCategory.ClearSelection();
           con.Close();
        }
            
    }
}