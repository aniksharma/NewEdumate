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

public partial class Academy_CreateFolder : System.Web.UI.Page
{
    string strcon = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
    
    string temp = "";
    string filename = "";
    string ShareType = "";
    string sLiteral = "";
    String sLitHyper3 = "";
    string thumbImageclasswork = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack == true)
        {
            Bind_Category();
            clear();
            bindDATA();
            BindEdit();
            BindDelete();
            BindUse();
        }
       
        txt_desc.Visible = true;
    }
    public void BindEdit()
    {
        string service_id = Request.QueryString["CEdit"];
        if (service_id != "0" && service_id != null)
        {
            SqlConnection conn = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("Sp_Bind_Academic_ID", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sp_Bind_Academic_ID";
            try
            {
                SqlParameter[] paramsToStore = new SqlParameter[1];
                paramsToStore[0] = new SqlParameter("@Academic_Id", SqlDbType.NVarChar);
                paramsToStore[0].Size=100;
                cmd.Parameters.Add(paramsToStore[0]).Value = service_id;

            }
            catch (Exception excp)
            {
                lblViewMsg.ForeColor = System.Drawing.Color.Red;
                lblViewMsg.Text = excp.Message;
            }
            conn.Open();
            cmd.Connection = conn;
            //int y = cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                ddlType.ClearSelection();
                ddlType.Items.FindByValue(dt.Rows[0]["Academic_Type"].ToString()).Selected = true;
                ddlCategory.ClearSelection();
               // ddlCategory.Items.FindByText(dt.Rows[0]["Academic_Cat"].ToString()).Selected = true;
               // ddlSubCategory.ClearSelection();


                //ddlSubCategory.Items.FindByValue(dt.Rows[0]["Academic_Sub_Cat"].ToString()).Selected = true;
                txtTitle.Text = dt.Rows[0]["Academic_Title"].ToString();
                txtDescription.Text = dt.Rows[0]["Academic_Desc"].ToString();
                txt_desc.Content = dt.Rows[0]["Academic_Content"].ToString();
               // chkcomments.Checked = true;

              

                String selectedCategory = dt.Rows[0]["Academic_Sub_Cat"].ToString();
               // ListItem listItem = ddlCategory.Items.FindByText(selectedCategory);
                if (selectedCategory != null)
                {
                    ddlSubCategory.DataSource = dt;
                    ddlSubCategory.DataTextField = "Academic_Sub_Cat";
                    ddlSubCategory.DataValueField = "Academic_Id";
                    ddlSubCategory.DataBind();
                    //ddlSubCategory.Items.Insert(0, new ListItem("--Select Category--", "0"));
                    //con.Close();
                }
               
            }
            else
            {
                lblViewMsg.ForeColor = System.Drawing.Color.Red;
                lblViewMsg.Text = "Data Not Available";
            }
        }
        else
        {
            lblViewMsg.ForeColor = System.Drawing.Color.Red;
            lblViewMsg.Text = "Please try again";
        }
    }
    public void BindUse()
    {
        string service_CUse_id = Request.QueryString["CUse"];
        if (service_CUse_id != "0" && service_CUse_id != null)
        {
            SqlConnection conn = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("Sp_Bind_Academic_Use", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sp_Bind_Academic_Use";
             try
               {
               SqlParameter[] paramsToStore = new SqlParameter[2];
 
               paramsToStore[0] = new SqlParameter("@Academic_Id", SqlDbType.NVarChar);
               paramsToStore[0].Size=100;
               cmd.Parameters.Add(paramsToStore[0]).Value = service_CUse_id ;
               paramsToStore[1] = new SqlParameter("@created_Date", SqlDbType.NVarChar);
               paramsToStore[1].Size=100;
               cmd.Parameters.Add(paramsToStore[1]).Value = DateTime.Now.ToString() ;

            }
            catch (Exception excp)
            {
                lblViewMsg.ForeColor = System.Drawing.Color.Red;
                lblViewMsg.Text = excp.Message;
            }
            conn.Open();
            cmd.Connection = conn;
            //int y = cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                lblViewMsg.ForeColor = System.Drawing.Color.Red;
                lblViewMsg.Text = "Updated..";
            }
            else
            {
                lblViewMsg.ForeColor = System.Drawing.Color.Red;
                lblViewMsg.Text = "Updated..";

                //mvAssignment.ActiveViewIndex = 1;

                //Response.Redirect(Request.RawUrl); 
                PropertyInfo isreadonly = typeof(System.Collections.Specialized.NameValueCollection).GetProperty("IsReadOnly", BindingFlags.Instance | BindingFlags.NonPublic);
                // make collection editable
                isreadonly.SetValue(this.Request.QueryString, false, null);
                // remove
                this.Request.QueryString.Remove("CUse");
            }
        }
        else
        {
            lblViewMsg.ForeColor = System.Drawing.Color.Red;
            lblViewMsg.Text = "Updated..";
            PropertyInfo isreadonly = typeof(System.Collections.Specialized.NameValueCollection).GetProperty("IsReadOnly", BindingFlags.Instance | BindingFlags.NonPublic);
            // make collection editable
            isreadonly.SetValue(this.Request.QueryString, false, null);
            // remove
            this.Request.QueryString.Remove("CUse");
        }
    }
    public void BindDelete()
    {
        string service_Delete_id = Request.QueryString["CDelete"];
        if (service_Delete_id != "0" && service_Delete_id != null)
        {
            SqlConnection conn = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("Sp_Bind_Academic_Delete", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sp_Bind_Academic_Delete";
            try
            {
                SqlParameter[] paramsToStore = new SqlParameter[2];

                paramsToStore[0] = new SqlParameter("@Academic_Id", SqlDbType.NVarChar);
                paramsToStore[0].Size = 100;
                cmd.Parameters.Add(paramsToStore[0]).Value = service_Delete_id;
                paramsToStore[1] = new SqlParameter("@created_Date", SqlDbType.NVarChar);
                paramsToStore[1].Size = 100;
                cmd.Parameters.Add(paramsToStore[1]).Value = DateTime.Now.ToString();


            }

            catch (Exception excp)
            {
                lblViewMsg.ForeColor = System.Drawing.Color.Red;
                lblViewMsg.Text = excp.Message;
            }
            conn.Open();
            cmd.Connection = conn;
            //int y = cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                lblViewMsg.ForeColor = System.Drawing.Color.Red;
                lblViewMsg.Text = "Deleted";
            }
            else
            {
                lblViewMsg.ForeColor = System.Drawing.Color.Red;
                lblViewMsg.Text = "Deleted";
                //mvAssignment.ActiveViewIndex = 1;
            }
        }
        else
        {
            lblViewMsg.ForeColor = System.Drawing.Color.Red;
            lblViewMsg.Text = "Try again..";
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
           paramsToStore[0].Size=200;
           cmd.Parameters.Add(paramsToStore[0]).Value =1;
 
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
           paramsToStore[0].Size=200;
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
            //Session.Remove("CatId");
        }
        //Session.Remove("CatId");
    }
    protected void rdbUpload_CheckedChanged(object sender, EventArgs e)
    {
        FileUploadData.Visible = true;
        txt_desc.Visible = false;
    }
    protected void rdbPaste_CheckedChanged(object sender, EventArgs e)
    {
        txt_desc.Visible = true;
        FileUploadData.Visible = false;
    }
    protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        Bind_Sub_Category();
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (rdbUpload.Checked == true)
        {
            if (FileUploadData.HasFile)
            {

                int imageSize = (FileUploadData.PostedFile.ContentLength) / 300;
                string strFileExtention = FileUploadData.FileName.Substring(FileUploadData.PostedFile.FileName.LastIndexOf("."));
                string millisecond = DateTime.Now.Millisecond.ToString();

                if (FileUploadData.PostedFile.ContentLength > 10248576)
                {
                   // lblMsg.Text = " Size greater than 1MB";
                }

                else if (strFileExtention == ".rar" || strFileExtention == ".txt" || strFileExtention == ".xlsx" || strFileExtention == ".docx" || strFileExtention == ".pptx" || strFileExtention == ".pdf" || strFileExtention == ".GIF" || strFileExtention == ".JPG" || strFileExtention == ".JPEG" || strFileExtention == ".jpeg" || strFileExtention == ".jpg" || strFileExtention == ".gif" || strFileExtention == ".PNG" || strFileExtention == ".png")
                {
                    string time = System.DateTime.Now.ToString("ddmmyy");

                    filename = FileUploadData.FileName;
                    string alterText = filename.Substring(0, filename.LastIndexOf("."));
                    thumbImageclasswork = millisecond + filename;

                    string imageType = "Image-" + strFileExtention.Substring(1);
                   
                    FileUploadData.SaveAs(Server.MapPath("UploadData/" + thumbImageclasswork));
                }
                else
                {
                    //lblMsg.Text = "Plz Select rar,txt,xlsx,docx,pptx,pdf,GIF,JPG,JPEG,jpeg,jpg,gif,PNG,png file";

                    //ClassWork = "file not uploaded";
                }
            }
        }
      
        else
        {
            filename=txt_desc.Content;
        }
        if(rdbPublic.Checked == true && rdbPrivate.Checked != true && rdbEdumateCommunity.Checked != true)
        {
            ShareType = "Public";
        }
        else if (rdbPublic.Checked != true && rdbPrivate.Checked == true && rdbEdumateCommunity.Checked != true)
        {
            ShareType = "Private";
        }
        else if(rdbPublic.Checked != true && rdbPrivate.Checked != true && rdbEdumateCommunity.Checked == true)
        {
             ShareType = "EdumateCommunity";
        }
        string service_id = Request.QueryString["CEdit"];
        if (service_id != null)
        {
            temp = service_id;
        }
        else
        {
            temp = "";
        }
          string sLoginId= Session["schoolid"].ToString();

        SqlConnection conn = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand("Sp_Academic_InsertUpdate", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "Sp_Academic_InsertUpdate";
        try
       {
       SqlParameter[] paramsToStore = new SqlParameter[13];
 
       paramsToStore[0] = new SqlParameter("@Academic_Id", SqlDbType.NVarChar);
       paramsToStore[0].Size=100;
       cmd.Parameters.Add(paramsToStore[0]).Value =  temp;
       paramsToStore[1] = new SqlParameter("@Academic_Type", SqlDbType.NVarChar);
       paramsToStore[1].Size=400;
       cmd.Parameters.Add(paramsToStore[1]).Value =  ddlType.SelectedItem.ToString();
       paramsToStore[2] = new SqlParameter("@Academic_Cat", SqlDbType.NVarChar);
       paramsToStore[2].Size=400;
       cmd.Parameters.Add(paramsToStore[2]).Value =  ddlCategory.SelectedItem.ToString();
       paramsToStore[3] = new SqlParameter("@Academic_Sub_Cat", SqlDbType.NVarChar);
       paramsToStore[3].Size=400;
       cmd.Parameters.Add(paramsToStore[3]).Value =  ddlSubCategory.SelectedItem.ToString();
       paramsToStore[4] = new SqlParameter("@Academic_Title", SqlDbType.NVarChar);
       paramsToStore[4].Size=400;
       cmd.Parameters.Add(paramsToStore[4]).Value =  txtTitle.Text;
       paramsToStore[5] = new SqlParameter("@Academic_Desc", SqlDbType.NVarChar);
       paramsToStore[5].Size=-1;
       cmd.Parameters.Add(paramsToStore[5]).Value =  txtDescription.Text;
       paramsToStore[6] = new SqlParameter("@Academic_Content", SqlDbType.NVarChar);
       paramsToStore[6].Size=-1;
       cmd.Parameters.Add(paramsToStore[6]).Value =  filename;
       paramsToStore[7] = new SqlParameter("@Academic_Share", SqlDbType.NVarChar);
       paramsToStore[7].Size = 30;
       cmd.Parameters.Add(paramsToStore[7]).Value = ShareType;
       paramsToStore[8] = new SqlParameter("@Academic_Comment", SqlDbType.NVarChar);
       paramsToStore[8].Size=20;
       cmd.Parameters.Add(paramsToStore[8]).Value =  chkcomments.Checked;
       paramsToStore[9] = new SqlParameter("@ViewStatus", SqlDbType.NVarChar);
       paramsToStore[9].Size=20;
       cmd.Parameters.Add(paramsToStore[9]).Value =  "0";
       paramsToStore[10] = new SqlParameter("@DelStatus", SqlDbType.NVarChar);
       paramsToStore[10].Size=20;
       cmd.Parameters.Add(paramsToStore[10]).Value =  "0";
       paramsToStore[11] = new SqlParameter("@Created_By", SqlDbType.NVarChar);
       paramsToStore[11].Size=100;
       cmd.Parameters.Add(paramsToStore[11]).Value = sLoginId ;
       paramsToStore[12] = new SqlParameter("@created_Date", SqlDbType.NVarChar);
       paramsToStore[12].Size=100;
       cmd.Parameters.Add(paramsToStore[12]).Value = DateTime.Now.ToString();
 
       
       }
    catch(Exception excp)
       {
        string strmsg=excp.Message;
        //Response.Write("<script LANGUAGE='JavaScript' >alert('" + strmsg + "')</script>");
        lblMSg.ForeColor = System.Drawing.Color.Red;
        lblMSg.Text = strmsg;
       }
        conn.Open();
        cmd.Connection = conn;
        int y = cmd.ExecuteNonQuery();
        if (y > 0)
        {
            lblMSg.ForeColor = System.Drawing.Color.Green;
            lblMSg.Text = "Data Inserted...";
            //Response.Write("<script LANGUAGE='JavaScript' >alert('Data Inserted...')</script>");
            clear();
        }
        else
        {
            lblMSg.ForeColor = System.Drawing.Color.Red;
            lblMSg.Text = "Please Try Again...";
           // Response.Write("<script LANGUAGE='JavaScript' >alert('Please Try Again')</script>");
        }
       
    }
    public void clear()
    {
        ddlType.ClearSelection();
        ddlCategory.ClearSelection();
        ddlSubCategory.ClearSelection();
        txtTitle.Text = "";
        txtDescription.Text = "";
        txt_desc.Content = "";
    }
    protected void btnInsert_Click(object sender, EventArgs e)
    {
        mvAssignment.ActiveViewIndex = 0;
        PropertyInfo isreadonly = typeof(System.Collections.Specialized.NameValueCollection).GetProperty("IsReadOnly", BindingFlags.Instance | BindingFlags.NonPublic);
        // make collection editable
        isreadonly.SetValue(this.Request.QueryString, false, null);
        // remove
        this.Request.QueryString.Remove("CEdit");
    }
    protected void btnView_Click(object sender, EventArgs e)
    {
        mvAssignment.ActiveViewIndex = 1;
        bindDATA();
        PropertyInfo isreadonly =  typeof(System.Collections.Specialized.NameValueCollection).GetProperty("IsReadOnly", BindingFlags.Instance | BindingFlags.NonPublic);
        // make collection editable
        isreadonly.SetValue(this.Request.QueryString, false, null);
        // remove
        this.Request.QueryString.Remove("CEdit");
    }
    public void bindDATA()
    {
          SqlConnection conn = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand("Sp_Bind_Academic", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "Sp_Bind_Academic";
        try
       {
       SqlParameter[] paramsToStore = new SqlParameter[1];
 
       paramsToStore[0] = new SqlParameter("@DelStatus", SqlDbType.NVarChar);
       paramsToStore[0].Size=20;
       cmd.Parameters.Add(paramsToStore[0]).Value = 0;
 
       
       }
       catch(Exception excp)
           {
               lblMSg.ForeColor = System.Drawing.Color.Red;
               lblMSg.Text = excp.Message;
           }
         conn.Open();
         cmd.Connection = conn;
         //int y = cmd.ExecuteNonQuery();
         SqlDataAdapter da = new SqlDataAdapter(cmd);
         DataTable dt = new DataTable();
         da.Fill(dt);
         if (dt.Rows.Count > 0)
         {

            for (int iPackage = 0; iPackage < dt.Rows.Count; iPackage++)
                {


                    try
                    {
                       
                        sLiteral = sLiteral + "<div class='blck-sectn'>";
                        sLiteral = sLiteral + "<div class='blck-sectn-innr'>";
                        sLiteral = sLiteral + "<div class='hdng-tab'>";
                        sLiteral = sLiteral + "<div class='hdng-tab-innr'>";

                        String sLitHyper1 = "<a style='color:White;' href='CreateFolder.aspx?CEdit=" + dt.Rows[iPackage]["Academic_Id"] + "'>" + "Edit" + "</a>";
                        sLiteral = sLiteral + sLitHyper1;
                        sLiteral = sLiteral + "</div>";
                        sLiteral = sLiteral + "<div class='hdng-tab-innr'>";
                        String sLitHyper2 = "<a id='aDelete' style='color:White;' href='CreateFolder.aspx?CDelete=" + dt.Rows[iPackage]["Academic_Id"] + "'>" + "Delete" + "</a>";
                        
                        sLiteral = sLiteral + sLitHyper2;
                        sLiteral = sLiteral + "</div>";
                        sLiteral = sLiteral + "<div class='hdng-tab-innr'>";

                        sLitHyper3 = dt.Rows[iPackage]["ViewStatus"].ToString();
                        if (sLitHyper3 != "1")
                        {
                            sLitHyper3 = "<a style='color:White;' href='CreateFolder.aspx?CUse=" + dt.Rows[iPackage]["Academic_Id"] + "'>" + "Use" + "</a>";
                        }
                        else
                        {
                            sLitHyper3 = "<a style='color:White;background-color:Red;' href='CreateFolder.aspx?CUse=" + dt.Rows[iPackage]["Academic_Id"] + "'>" + "Unused" + "</a>";
                        }
                        sLiteral = sLiteral + sLitHyper3;
                        sLiteral = sLiteral + "</div>";
                        sLiteral = sLiteral + "</div>";
                        sLiteral = sLiteral + "<p class='hdng-04'>";
                        sLiteral = sLiteral + dt.Rows[iPackage]["Academic_Type"].ToString();
                        sLiteral = sLiteral + "</p>";
                        sLiteral = sLiteral + "<div class='artcless-img-03'>";
                        String sServices = "<img border='0' src='../images/FolderIcon.png' width='105' height='68'/>";
                        sLiteral = sLiteral + sServices;
                        sLiteral = sLiteral + "</div>";

                        sLiteral = sLiteral + "<p class='hdng-05'>";
                        sLiteral = sLiteral + dt.Rows[iPackage]["Academic_Cat"].ToString();
                        sLiteral = sLiteral + "</p>";
                        sLiteral = sLiteral + "</div>";
                        sLiteral = sLiteral + "</div>";

                       
                    }
                    catch
                    {
                        //litbody.Text = "No Data Found..";
                    }
                    litbinddata.Text = sLiteral;
             }
            
         }
    }

    
}