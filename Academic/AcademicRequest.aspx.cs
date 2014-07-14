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
using System.Reflection;

public partial class Academic_AcademicRequest : System.Web.UI.Page
{
    string strcon = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
    string temp = "";
    string sLoginId = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack == true)
        {
            Bind_Category();
        }
    }
    public void Bind_Category()
    {
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand("Sp_Academic_Category", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "Sp_Academic_Category";
        try
        {
            SqlParameter[] paramsToStore = new SqlParameter[1];

            paramsToStore[0] = new SqlParameter("@Country", SqlDbType.NVarChar);
            paramsToStore[0].Size = 200;
            cmd.Parameters.Add(paramsToStore[0]).Value = 1;

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
            ddlCategory.DataTextField = "CatName";
            ddlCategory.DataValueField = "CatId";
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
        SqlCommand cmd = new SqlCommand("Sp_Academic_SubCategory", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "Sp_Academic_SubCategory";
        try
        {
            SqlParameter[] paramsToStore = new SqlParameter[1];

            paramsToStore[0] = new SqlParameter("@sMainCatId", SqlDbType.NVarChar);
            paramsToStore[0].Size = 200;
            cmd.Parameters.Add(paramsToStore[0]).Value = ddlCategory.SelectedValue.ToString();

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
            ddlSubCategory.DataTextField = "sCatName";
            ddlSubCategory.DataValueField = "sCatId";
            ddlSubCategory.DataBind();
            ddlSubCategory.Items.Insert(0, new ListItem("--Select Sub-Category--", "0"));
            con.Close();


        }
        else
        {
            Response.Write("<script LANGUAGE='JavaScript' >alert('Please Try Again')</script>");
          
        }
      
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        

        if (Session["schoolid"] != "0" && Session["schoolid"] != null)
          {
              sLoginId = Session["schoolid"].ToString();
              SqlConnection conn = new SqlConnection(strcon);
              SqlCommand cmd = new SqlCommand("Sp_Academic_Request", conn);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.CommandText = "Sp_Academic_Request";
              try
              {
                  SqlParameter[] paramsToStore = new SqlParameter[10];

                  paramsToStore[0] = new SqlParameter("@AcdRequest_Id", SqlDbType.NVarChar);
                  paramsToStore[0].Size = 100;
                  cmd.Parameters.Add(paramsToStore[0]).Value = temp;
                  paramsToStore[1] = new SqlParameter("@Type", SqlDbType.NVarChar);
                  paramsToStore[1].Size = 200;
                  cmd.Parameters.Add(paramsToStore[1]).Value = ddlType.SelectedItem.ToString();
                  paramsToStore[2] = new SqlParameter("@Category", SqlDbType.NVarChar);
                  paramsToStore[2].Size = 200;
                  cmd.Parameters.Add(paramsToStore[2]).Value = ddlCategory.SelectedItem.ToString();
                  paramsToStore[3] = new SqlParameter("@Sub_Category", SqlDbType.NVarChar);
                  paramsToStore[3].Size = 200;
                  cmd.Parameters.Add(paramsToStore[3]).Value = ddlSubCategory.SelectedItem.ToString();
                  paramsToStore[4] = new SqlParameter("@Title", SqlDbType.NVarChar);
                  paramsToStore[4].Size = -1;
                  cmd.Parameters.Add(paramsToStore[4]).Value = txtTitle.Text;
                  paramsToStore[5] = new SqlParameter("@Request", SqlDbType.NVarChar);
                  paramsToStore[5].Size = -1;
                  cmd.Parameters.Add(paramsToStore[5]).Value = txtDescription.Text;
                  paramsToStore[6] = new SqlParameter("@Status", SqlDbType.BigInt);
                  cmd.Parameters.Add(paramsToStore[6]).Value = 0;
                  paramsToStore[7] = new SqlParameter("@delStatus", SqlDbType.BigInt);
                  cmd.Parameters.Add(paramsToStore[7]).Value = 0;
                  paramsToStore[8] = new SqlParameter("@createdby", SqlDbType.NVarChar);
                  paramsToStore[8].Size = 100;
                  cmd.Parameters.Add(paramsToStore[8]).Value = sLoginId;
                  paramsToStore[9] = new SqlParameter("@createddate", SqlDbType.NVarChar);
                  paramsToStore[9].Size = 100;
                  cmd.Parameters.Add(paramsToStore[9]).Value = DateTime.Now.ToString();


              }
              catch (Exception excp)
              {
                  lblViewMsg.ForeColor = System.Drawing.Color.Red;
                  lblViewMsg.Text = excp.Message;
              }
              conn.Open();
              cmd.Connection = conn;
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              if (dt.Rows.Count > 0)
              {

                  lblViewMsg.ForeColor = System.Drawing.Color.Green;
                  lblViewMsg.Text = "Inserted..";
              }
              else
              {
                  lblViewMsg.ForeColor = System.Drawing.Color.Red;
                  lblViewMsg.Text = "Try Again..";
              }

              }

              else
              {
                  litClickHere.Text = "Click Here";
                  tblAcdRequest.Visible = false;
                  lblViewMsg.Text = "";
              }
        
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
    protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        Bind_Sub_Category();
    }
    protected void btn1_Click(object sender, EventArgs e)
    {

    }
}