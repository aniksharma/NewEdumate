using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Academic_FindAcademic : System.Web.UI.Page
{
    string strcon = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
    string sLiteral = "";
    string strsave, strsave1, strsave2, strsave3, strsave4;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack == true)
        {
            Bind_Category();
        }
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(strcon);
         SqlCommand cmd = new SqlCommand("Sp_Bind_Academicdata", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sp_Bind_Academicdata";
       try
           {
           SqlParameter[] paramsToStore = new SqlParameter[2];
 
           paramsToStore[0] = new SqlParameter("@Academic_Cat", SqlDbType.NVarChar);
           paramsToStore[0].Size=400;
           cmd.Parameters.Add(paramsToStore[0]).Value =  ddlCategory.SelectedItem.ToString();
           paramsToStore[1] = new SqlParameter("@Academic_Sub_Cat", SqlDbType.NVarChar);
           paramsToStore[1].Size=400;
           cmd.Parameters.Add(paramsToStore[1]).Value = ddlSubCategory.SelectedItem.ToString();
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
                        sLiteral = sLiteral + "<a style='color:#3D76AD;' href='AcademicDescription.aspx?CDsce=" + dt.Rows[iPackage]["Academic_Id"].ToString() + "'>" + dt.Rows[iPackage]["Academic_Title"].ToString() + "</a>";
                        sLiteral = sLiteral + "</h5>";


                        sLiteral = sLiteral + "<p class='hdng-04-deepak'>";
                        sLiteral = sLiteral + dt.Rows[iPackage]["Academic_Type"].ToString();
                        sLiteral = sLiteral + "</p>";
                        sLiteral = sLiteral + "<p class='artcless-img-02'>";

                        String sServices = "<img border='0' src='../Advertisement/" + dt.Rows[iPackage]["collegeImage"].ToString() + "' class='img-size'/>";
                        sLiteral = sLiteral + sServices;
                        sLiteral = sLiteral + "</p>";

                        sLiteral = sLiteral + "<div class='artcless-container'>";
                     
strsave = "<span style='color:#4B4B4B;'>" + dt.Rows[iPackage]["Academic_Desc"].ToString() + "<span>" + 
    "<a style='color:#3D76AD;font-weight:bold;margin-left: 47px;   margin-top:5px;position:absolute;' href='AcademicDescription.aspx?CDsce=" + dt.Rows[iPackage]["Academic_Id"].ToString() + "'>" + "...View More" + "</a>";

                        strsave2 = "<span style='color:#5086BB'>" + "Posted by :" + "</span>" + "<span style='margin-left:7px;'>" + dt.Rows[iPackage]["collegeName"].ToString() + "</span>" + "<span style='color:#5086BB;float:right;'>" + dt.Rows[iPackage]["created_Date"].ToString() + " days ago" + "</span>";
                       
                        sLiteral = sLiteral + "</div>";

                        sLiteral = sLiteral + strsave + "</br>" + strsave1 + "</br>" + strsave2 + "</br>" + strsave3 + "</br>";

                        sLiteral = sLiteral + "</article>";
                    }
                    catch
                    {
                     
                    }

                }


                litName.Text = sLiteral;
            }
        else
            {

            }
    }
    public void Bind_Category()
    {
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand("Sp_Academic_Category_View", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "Sp_Academic_Category_View";
       try
       {
       SqlParameter[] paramsToStore = new SqlParameter[2];
 
       paramsToStore[0] = new SqlParameter("@ViewStatus", SqlDbType.NVarChar);
       paramsToStore[0].Size=20;
       cmd.Parameters.Add(paramsToStore[0]).Value = 0 ;
       paramsToStore[1] = new SqlParameter("@DelStatus", SqlDbType.NVarChar);
       paramsToStore[1].Size=20;
       cmd.Parameters.Add(paramsToStore[1]).Value = 0 ;
 
  
       }

        catch (Exception excp)
        {
            string strMsg = excp.Message;
            Response.Write("<script LANGUAGE='JavaScript' >alert('" + strMsg + "')</script>");
        }
        con.Open();
        cmd.Connection = con;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        if (ds != null && ds.Tables.Count > 0)
        {
            ddlCategory.DataSource = ds;
            ddlCategory.DataTextField = "Academic_Cat";
            ddlCategory.DataValueField = "Academic_Cat";
            ddlCategory.DataBind();
            ddlCategory.Items.Insert(0, new ListItem("--Select Category--", "0"));
            con.Close();

        }
        else
        {
            Response.Write("<script LANGUAGE='JavaScript' >alert('Please Try Again')</script>");
        }

    }
    public void Bind_Sub_Category()
    {
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand("Sp_Academic_SubCategory_View", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "Sp_Academic_SubCategory_View";
       try
           {
           SqlParameter[] paramsToStore = new SqlParameter[1];
 
           paramsToStore[0] = new SqlParameter("@Academic_Cat", SqlDbType.NVarChar);
           paramsToStore[0].Size=400;
           cmd.Parameters.Add(paramsToStore[0]).Value = ddlCategory.SelectedItem.ToString();

        }
        catch (Exception excp)
        {
            string strMsg = excp.Message;
            Response.Write("<script LANGUAGE='JavaScript' >alert('" + strMsg + "')</script>");

        }
        con.Open();
        cmd.Connection = con;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        if (ds != null)
        {
            ddlSubCategory.DataSource = ds;
            ddlSubCategory.DataTextField = "Academic_Sub_Cat";
            ddlSubCategory.DataValueField = "Academic_Sub_Cat";
            ddlSubCategory.DataBind();
            ddlSubCategory.Items.Insert(0, new ListItem("--Select Sub-Category--", "0"));
            con.Close();


        }
        else
        {
            Response.Write("<script LANGUAGE='JavaScript' >alert('Please Try Again')</script>");
       
        }
      
    }

    protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        
            Bind_Sub_Category();
     }
}