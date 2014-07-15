using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Collections.Generic;
using nmsSetupWeb;
using nmsDropDown;
using nmsProfile;

public partial class InstitutePanel_AddCourseList : System.Web.UI.Page
{

    string strcon = ConfigurationManager.ConnectionStrings["cn"].ConnectionString; 

    PRPSetupWeb prppram;
    PRPSetupWeb prp;
    clsBLSetupWeb bl;
    static string type = "", memberId = "", Id = "";
    ListItem lt;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["OfficeCollege"] == null)
        {
           
        }

        if (Page.IsPostBack == false)
        {
            prpLogin objprp = new prpLogin();
            prpLogin objlog = new prpLogin();
            objlog = (prpLogin)(Session["OfficeCollege"]);
            memberId = objlog.EmployeeId;
            binduniversity();
            if (Request.QueryString["list"] != null)
            {
                BindTextBox();
            }
        }
    }
    private void binduniversity()
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
            ddlCourseType.DataSource = ds;
            ddlCourseType.DataTextField = "CatName";
            ddlCourseType.DataValueField = "CatId";
            ddlCourseType.DataBind();
            ddlCourseType.Items.Insert(0, new ListItem("--Select Category--", "0"));
            con.Close();

        }
        else
        {
            Response.Write("<script LANGUAGE='JavaScript' >alert('Please Try Again')</script>");
        }
    }
    private void bindsuniversity()
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
            cmd.Parameters.Add(paramsToStore[0]).Value = ddlCourseType.SelectedValue.ToString();

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
            ddlSubCourseCate.DataSource = ds;
            ddlSubCourseCate.DataTextField = "sCatName";
            ddlSubCourseCate.DataValueField = "sCatId";
            ddlSubCourseCate.DataBind();
            ddlSubCourseCate.Items.Insert(0, new ListItem("--Select Sub-Category--", "0"));
            con.Close();
        }
        else
        {
            Response.Write("<script LANGUAGE='JavaScript' >alert('Please Try Again')</script>");
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (btnSubmit.Text == "Submit")
        {
            insertCourse();
            ReSet();
        }
        else
        {
            UpdateCourse();
            btnCancel.Visible = false;
            ReSet();
        }
    }
    private void UpdateCourse()
    {
        prp = new PRPSetupWeb();
        bl = new clsBLSetupWeb();
        prp.pageIndex = ddlCourseType.SelectedValue;
        prp.pageSize = ddlSubCourseCate.SelectedValue;
        prp.description = txtCrsLongDescription.Text;
        prp.designationName = txtCrsShortDescription.Text;
        prp.durationMaxTime = ddlDuration.SelectedValue;
        prp.Salary = txtCourseFees.Text;
        prp.security = ddlFeesType.SelectedValue;
        prp.grade = ddlFeesMode.SelectedValue;

        prp.courseTime = rdbCourseTime.SelectedItem.Text;
        prp.id = Id;
        prp.city = memberId;
        lblMsg.Text = bl.UpdateCrsLinkList(prp);
    }
    private void insertCourse()
    {
        prp = new PRPSetupWeb();
        bl = new clsBLSetupWeb();
        prp.pageIndex = ddlCourseType.SelectedValue;
        prp.pageSize = ddlSubCourseCate.SelectedValue;
        prp.description = txtCrsLongDescription.Text;
        prp.designationName = txtCrsShortDescription.Text;
        prp.durationMaxTime = ddlDuration.SelectedValue;
        prp.Salary = txtCourseFees.Text;
        prp.security = ddlFeesType.SelectedValue;
        prp.grade = ddlFeesMode.SelectedValue;
        if (rdbCourseTime.SelectedItem != null)
        {
            prp.courseTime = rdbCourseTime.SelectedItem.Text;
        }

        prp.city = memberId;
        lblMsg.Text = bl.InsertCrsLinkList(prp);
    }
    private void ReSet()
    {
        ddlFeesMode.SelectedIndex = -1;
        ddlFeesType.SelectedIndex = -1;
        txtCourseFees.Text = "";
        txtCrsShortDescription.Text = "";
        ddlDuration.SelectedIndex = -1;
        ddlCourseType.SelectedIndex = -1;
        ddlSubCourseCate.SelectedIndex = -1;
        txtCrsLongDescription.Text = "";
        btnSubmit.Text = "Submit";
    }
    protected void ddlCourseType_SelectedIndexChanged(object sender, EventArgs e)
    {
        bindsuniversity();
    }
   
    protected void BindTextBox()
    {
        prp = new PRPSetupWeb();
        bl = new clsBLSetupWeb();
        PRPSetupWeb prp1 = new PRPSetupWeb();
        prp1.id = Request.QueryString["list"].ToString();
        prp = bl.SelectCrsLinkList(prp1);
        Id = prp.mainLandMark;
        ddlCourseType.SelectedValue = prp.pageIndex;
        bindsuniversity();
        ddlSubCourseCate.SelectedValue = prp.pageSize;
        txtCrsLongDescription.Text = prp.description;
        txtCrsShortDescription.Text = prp.designationName;
        ddlDuration.SelectedValue = prp.durationMaxTime;
        txtCourseFees.Text = prp.Salary;
        ddlFeesType.SelectedValue = prp.security;
        ddlFeesMode.SelectedValue = prp.grade;
        if (prp.courseTime != "")
        {
            rdbCourseTime.Items.FindByText(prp.courseTime).Selected = true;
        }
        memberId = prp.city;
        btnSubmit.Text = "Update";
        btnCancel.Visible = true;

    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        ReSet();
    }
    
}
