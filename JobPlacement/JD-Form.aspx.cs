using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class JobPlacement_JD_Form : System.Web.UI.Page
{
    string strcon = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
    string strid = "";
    string temp = "";
    string temp1 = "";
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            BindGV();
        }
    }
   
    protected void btnSubmitFinally_Click(object sender, EventArgs e)
    {
        if (btnSubmitFinally.Text.ToUpper() == "Update".ToUpper())
        {
            strid = Session["JdID"].ToString();
        }
        else
        {
            strid = "";
        }
         SqlConnection con = new SqlConnection(strcon);
         string sLoginId = Session["schoolid"].ToString();
         SqlCommand cmd = new SqlCommand("Sp_Jd", con);
         cmd.CommandType = CommandType.StoredProcedure;
         cmd.CommandText = "Sp_Jd";
        try
           {
           SqlParameter[] paramsToStore = new SqlParameter[20];
 
           paramsToStore[0] = new SqlParameter("@JdID", SqlDbType.NVarChar);
           paramsToStore[0].Size=100;
           cmd.Parameters.Add(paramsToStore[0]).Value = strid;
           paramsToStore[1] = new SqlParameter("@Title", SqlDbType.NVarChar);
           paramsToStore[1].Size=-1;
           cmd.Parameters.Add(paramsToStore[1]).Value = txtTitle.Text;
           paramsToStore[2] = new SqlParameter("@Salary", SqlDbType.NVarChar);
           paramsToStore[2].Size=100;
           cmd.Parameters.Add(paramsToStore[2]).Value = ddlSalary.SelectedItem.ToString();
           paramsToStore[3] = new SqlParameter("@Category", SqlDbType.NVarChar);
           paramsToStore[3].Size=100;
           cmd.Parameters.Add(paramsToStore[3]).Value =  ddlCategory.SelectedItem.ToString();
           paramsToStore[4] = new SqlParameter("@Functional_Area", SqlDbType.NVarChar);
           paramsToStore[4].Size=200;
           cmd.Parameters.Add(paramsToStore[4]).Value =  ddlFunctionalArea.SelectedItem.ToString();
           paramsToStore[5] = new SqlParameter("@Role", SqlDbType.NVarChar);
           paramsToStore[5].Size=200;
           cmd.Parameters.Add(paramsToStore[5]).Value =  ddlRole.SelectedItem.ToString();
           paramsToStore[6] = new SqlParameter("@Skill", SqlDbType.NVarChar);
           paramsToStore[6].Size=-1;
           cmd.Parameters.Add(paramsToStore[6]).Value =  txtSkill.Text;
           paramsToStore[7] = new SqlParameter("@Required_Qualification", SqlDbType.NVarChar);
           paramsToStore[7].Size=-1;
           cmd.Parameters.Add(paramsToStore[7]).Value =  txtQualification.Text;
           paramsToStore[8] = new SqlParameter("@Job_Description", SqlDbType.NVarChar);
           paramsToStore[8].Size=-1;
           cmd.Parameters.Add(paramsToStore[8]).Value =  txtJobDescription.Text;
           paramsToStore[9] = new SqlParameter("@Employer_Profile", SqlDbType.NVarChar);
           paramsToStore[9].Size=-1;
           cmd.Parameters.Add(paramsToStore[9]).Value =  txtEmployerProfile.Text;
           paramsToStore[10] = new SqlParameter("@Organisation_Name", SqlDbType.NVarChar);
           paramsToStore[10].Size=200;
           cmd.Parameters.Add(paramsToStore[10]).Value =  txtCompanyName.Text;
           paramsToStore[11] = new SqlParameter("@Recruiter_Name", SqlDbType.NVarChar);
           paramsToStore[11].Size=200;
           cmd.Parameters.Add(paramsToStore[11]).Value =  txtRecruiterName.Text;
           paramsToStore[12] = new SqlParameter("@Address", SqlDbType.NVarChar);
           paramsToStore[12].Size=-1;
           cmd.Parameters.Add(paramsToStore[12]).Value =  txtAddress.Text;
           paramsToStore[13] = new SqlParameter("@Email_ID", SqlDbType.NVarChar);
           paramsToStore[13].Size=100;
           cmd.Parameters.Add(paramsToStore[13]).Value =  txtEmail.Text;
           paramsToStore[14] = new SqlParameter("@Mobile", SqlDbType.NVarChar);
           paramsToStore[14].Size=30;
           cmd.Parameters.Add(paramsToStore[14]).Value =  txtMobile.Text;
           paramsToStore[15] = new SqlParameter("@Website", SqlDbType.NVarChar);
           paramsToStore[15].Size=100;
           cmd.Parameters.Add(paramsToStore[15]).Value =  txtWebsite.Text;
           paramsToStore[16] = new SqlParameter("@Status", SqlDbType.NVarChar);
           paramsToStore[16].Size=100;
           cmd.Parameters.Add(paramsToStore[16]).Value =  "1";
           paramsToStore[17] = new SqlParameter("@delstatus", SqlDbType.NVarChar);
           paramsToStore[17].Size=10;
           cmd.Parameters.Add(paramsToStore[17]).Value =  "0";
           paramsToStore[18] = new SqlParameter("@Createby", SqlDbType.NVarChar);
           paramsToStore[18].Size=100;
           cmd.Parameters.Add(paramsToStore[18]).Value = sLoginId;
           paramsToStore[19] = new SqlParameter("@createdatetime", SqlDbType.NVarChar);
           paramsToStore[19].Size=100;
           cmd.Parameters.Add(paramsToStore[19]).Value =  DateTime.Now.ToShortDateString();
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
            lblMsg.Text = "Job Details Inserted Successfully..";
            clear();
            Session.Remove("JdID");
            BindGV();
        }
        else
        {
            lblMsg.Text = "No Details Available.. Try Again";
            Session.Remove("JdID");
            BindGV();
            clear();
        }
    }
    public void clear()
    {
        txtTitle.Text = "";
        txtSkill.Text = "";
        txtQualification.Text = "";
        txtJobDescription.Text = "";
        txtEmployerProfile.Text = "";
        txtCompanyName.Text = "";
        txtRecruiterName.Text = "";
        txtAddress.Text = "";
        txtEmail.Text = "";
        txtMobile.Text = "";
   }
    public void BindGV()
    {
         SqlConnection con = new SqlConnection(strcon);

         string sLoginId = Session["schoolid"].ToString();

         SqlCommand cmd = new SqlCommand("Sp_Jd_bind", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "Sp_Jd_bind";
        try
       {
       SqlParameter[] paramsToStore = 
    new SqlParameter[1];
 
       paramsToStore[0] = new SqlParameter("@Createby", SqlDbType.NVarChar);
       paramsToStore[0].Size=100;
       cmd.Parameters.Add(paramsToStore[0]).Value = sLoginId;
 
      
       }
    catch(Exception excp)
       {
       }
       
        cmd.Connection = con;

        try
        {

            con.Open();

            imgGV.EmptyDataText = "No Records Found";

            imgGV.DataSource = cmd.ExecuteReader();

            imgGV.DataBind();

        }

        catch (Exception ex)
        {
            lblMsg.Text = ex.Message;

        }

        finally
        {

            con.Close();

            con.Dispose();

        }
        con.Close();
    }
    protected void imgGV_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        GridViewRow gvrow = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
        string str = Convert.ToString(e.CommandArgument);
        string i = "";
        i = gvrow.RowIndex.ToString();
        temp1 = ((Label)imgGV.Rows[Convert.ToInt32(i)].FindControl("lblNewsCode")).Text;
         SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand("Sp_Jd_bind_Sln", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "Sp_Jd_bind_Sln";
        try
           {
           SqlParameter[] paramsToStore = 
        new SqlParameter[1];

           paramsToStore[0] = new SqlParameter("@JdID", SqlDbType.NVarChar);
           paramsToStore[0].Size=100;
           cmd.Parameters.Add(paramsToStore[0]).Value = temp1;
 
           
           }
        catch(Exception excp)
           {

           }
        con.Open();
        cmd.Connection = con;
        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {
            try
            {
                if (e.CommandName == "status")
                {
                    if (i.Length > 0)
                    {
                        if (Convert.ToInt32(i) >= 0)
                        {
                            if (((Label)imgGV.Rows[Convert.ToInt32(i)].FindControl("lblStatus")).Text.Equals("InActive"))
                            {
                                ((ImageButton)imgGV.Rows[Convert.ToInt32(i)].FindControl("imgStat")).ImageUrl = "img/icon_tick_circle.png";
                                ((Label)imgGV.Rows[Convert.ToInt32(i)].FindControl("lblStatus")).Text = "Active";
                                ((Label)imgGV.Rows[Convert.ToInt32(i)].FindControl("lblStatus")).Style[HtmlTextWriterStyle.Color] = "green";
                                SqlConnection conn = new SqlConnection(strcon);
                                SqlCommand cmd1 = new SqlCommand("Sp_Jd_Update_Sln", conn);
                                cmd1.CommandType = CommandType.StoredProcedure;
                                cmd1.CommandText = "Sp_Jd_Update_Sln";

                                try
                                {
                                    SqlParameter[] paramsToStore = new SqlParameter[3];

                                    paramsToStore[0] = new SqlParameter("@JdID", SqlDbType.NVarChar);
                                    paramsToStore[0].Size = 100;
                                    cmd1.Parameters.Add(paramsToStore[0]).Value = temp1;
                                    paramsToStore[1] = new SqlParameter("@delstatus", SqlDbType.NVarChar);
                                    paramsToStore[1].Size = 10;
                                    cmd1.Parameters.Add(paramsToStore[1]).Value = "0";
                                    paramsToStore[2] = new SqlParameter("@Status", SqlDbType.NVarChar);
                                    paramsToStore[2].Size = 10;
                                    cmd1.Parameters.Add(paramsToStore[2]).Value = "1";


                                }
                                catch (Exception ex)
                                {
                                    lblMsg.Text = ex.Message;

                                }


                                cmd1.Connection = conn;
                                conn.Open();
                                int X = cmd1.ExecuteNonQuery();
                                conn.Close();
                            }
                            else if (((Label)imgGV.Rows[Convert.ToInt32(i)].FindControl("lblStatus")).Text.Equals("Active"))
                            {
                                ((ImageButton)imgGV.Rows[Convert.ToInt32(i)].FindControl("imgStat")).ImageUrl = "img/icon_remove.png";
                                ((Label)imgGV.Rows[Convert.ToInt32(i)].FindControl("lblStatus")).Text = "InActive";
                                ((Label)imgGV.Rows[Convert.ToInt32(i)].FindControl("lblStatus")).Style[HtmlTextWriterStyle.Color] = "red";
                                SqlConnection conn = new SqlConnection(strcon);
                                SqlCommand cmd1 = new SqlCommand("Sp_Jd_Update_Sln", conn);
                                cmd1.CommandType = CommandType.StoredProcedure;
                                cmd1.CommandText = "Sp_Jd_Update_Sln";
                                try
                                {
                                    SqlParameter[] paramsToStore = new SqlParameter[3];

                                    paramsToStore[0] = new SqlParameter("@JdID", SqlDbType.NVarChar);
                                    paramsToStore[0].Size = 100;
                                    cmd1.Parameters.Add(paramsToStore[0]).Value = temp1;
                                    paramsToStore[1] = new SqlParameter("@delstatus", SqlDbType.NVarChar);
                                    paramsToStore[1].Size = 10;
                                    cmd1.Parameters.Add(paramsToStore[1]).Value = "1";
                                    paramsToStore[2] = new SqlParameter("@Status", SqlDbType.NVarChar);
                                    paramsToStore[2].Size = 10;
                                    cmd1.Parameters.Add(paramsToStore[2]).Value = "1";


                                }
                                catch (Exception excp)
                                {
                                }
                                cmd1.Connection = conn;
                                conn.Open();
                                int X = cmd1.ExecuteNonQuery();
                                conn.Close();
                            }
                        }

                    }
                }
                if (e.CommandName == "del")
                {
                    string id = Convert.ToString(e.CommandArgument);
                    SqlConnection condel = new SqlConnection(strcon);
                    SqlCommand cmddel = new SqlCommand("Sp_Jd_Update_Sln", condel);
                    cmddel.CommandType = CommandType.StoredProcedure;
                    cmddel.CommandText = "Sp_Jd_Update_Sln";
                    try
                    {
                        SqlParameter[] paramsToStore = new SqlParameter[3];

                        paramsToStore[0] = new SqlParameter("@JdID", SqlDbType.NVarChar);
                        paramsToStore[0].Size = 100;
                        cmddel.Parameters.Add(paramsToStore[0]).Value = temp1;
                        paramsToStore[1] = new SqlParameter("@delstatus", SqlDbType.NVarChar);
                        paramsToStore[1].Size = 10;
                        cmddel.Parameters.Add(paramsToStore[1]).Value = "1";
                        paramsToStore[2] = new SqlParameter("@Status", SqlDbType.NVarChar);
                        paramsToStore[2].Size = 10;
                        cmddel.Parameters.Add(paramsToStore[2]).Value = "0";
                              

                    }
                    catch (Exception excp)
                    {

                    }
                    condel.Open();
                    cmddel.Connection = condel;

                    int delQuery = cmddel.ExecuteNonQuery();
                    if (delQuery > 0)
                    {
                        lblMsg.Text = "Deleted";
                       
                    }
                    else
                    {
                        Response.Write("Deleted");
                    }
                    BindGV();
                }
                if (e.CommandName == "edit")
                {
                    SqlConnection conedit = new SqlConnection(strcon);
                    SqlCommand cmdedit = new SqlCommand("Sp_Jd_bind_Sln", conedit);
                    cmdedit.CommandType = CommandType.StoredProcedure;
                    cmdedit.CommandText = "Sp_Jd_bind_Sln";
                    try
                        {
                        SqlParameter[] paramsToStore = 
                    new SqlParameter[1];

                        paramsToStore[0] = new SqlParameter("@JdID", SqlDbType.NVarChar);
                        paramsToStore[0].Size=100;
                        cmdedit.Parameters.Add(paramsToStore[0]).Value = temp1;
 
           
                        }
                    catch(Exception excp)
                        {

                        }
                    conedit.Open();
                    cmdedit.Connection = conedit;
                    SqlDataReader dr1 = cmdedit.ExecuteReader();

                    if (dr1.Read())
                    {
                        mvJobDetails.ActiveViewIndex = 0;
                        Session["JdID"] = dr["JdID"].ToString();
                        txtTitle.Text = dr["Title"].ToString();
                        ddlSalary.ClearSelection();
                        ddlSalary.Items.FindByValue(dr["Salary"].ToString()).Selected = true;
                        ddlCategory.ClearSelection();
                        ddlCategory.Items.FindByValue(dr["Category"].ToString()).Selected = true;
                        ddlFunctionalArea.ClearSelection();
                        ddlFunctionalArea.Items.FindByValue(dr["Functional_Area"].ToString()).Selected = true;
                        ddlRole.ClearSelection();
                        ddlRole.Items.FindByValue(dr["Role"].ToString()).Selected = true;
                        txtSkill.Text = dr["Skill"].ToString();
                        txtQualification.Text = dr["Required_Qualification"].ToString();
                        txtJobDescription.Text = dr["Job_Description"].ToString();
                        txtEmployerProfile.Text = dr["Employer_Profile"].ToString();
                        txtCompanyName.Text = dr["Organisation_Name"].ToString();
                        txtRecruiterName.Text = dr["Recruiter_Name"].ToString();
                        txtAddress.Text = dr["Address"].ToString();
                        txtEmail.Text = dr["Email_ID"].ToString();
                        txtMobile.Text = dr["Mobile"].ToString();
                        txtWebsite.Text = dr["Website"].ToString();
                        
                    }
                    conedit.Close();
                    btnSubmitFinally.Text = "Update";
                }


            }

            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;

            }

            finally
            {

                con.Close();

                con.Dispose();

            }
        }
        else
        {
            lblMsg.Text = "Connection Fail";
        }
        con.Close();
        
    }
    protected void imgGV_RowEditing(object sender, GridViewEditEventArgs e)
    {

    }
    protected void imgGV_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Label lblStatus = (Label)e.Row.FindControl("lblStatus");
            ImageButton imgStat = (ImageButton)e.Row.FindControl("imgStat");
            int i = Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "Status"));
            if (i == 1)
            {
                lblStatus.Text = "Active";
                lblStatus.Style[HtmlTextWriterStyle.Color] = "green";
                lblStatus.Style[HtmlTextWriterStyle.FontWeight] = "bold";
                lblStatus.Style[HtmlTextWriterStyle.FontStyle] = "italic";
                imgStat.ImageUrl = "img/icon_tick_circle.png";
                imgStat.ToolTip = "";
            }
            else
            {
                lblStatus.Text = "InActive";
                lblStatus.Style[HtmlTextWriterStyle.Color] = "red";
                lblStatus.Style[HtmlTextWriterStyle.FontWeight] = "bold";
                lblStatus.Style[HtmlTextWriterStyle.FontStyle] = "italic";
                imgStat.ImageUrl = "img/icon_remove.png";
                imgStat.ToolTip = "";
            }
        }
    }
    protected void btnInsert_Click(object sender, EventArgs e)
    {
        mvJobDetails.ActiveViewIndex = 0;
       
    }
    protected void btnView_Click(object sender, EventArgs e)
    {
        mvJobDetails.ActiveViewIndex = 1;
    }
}