using System;
using System.Collections;
using System.Configuration;
using System.Data;
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

public partial class InstitutePanel_AddTutorSubject : System.Web.UI.Page
{
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
            bindsCategory();
            //  BindListBox();
            if (Request.QueryString["list"] != null)
            {
                BindTextBox();
            }
        }


    }
    private void binduniversity()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddlCourseType;
        drpprp.id = 4;
        drpprp.spName = "crsViewAllMainCategory";
        drp.bindDropDown(drpprp);
       
    }
    private void bindsuniversity()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        if (ddlCourseType.SelectedIndex != 0)
            drpprp.id = Convert.ToInt32(ddlCourseType.SelectedValue);
        drpprp.Type = "1";
        drpprp.controlList = ddlSubCourseCate;
        drpprp.spName = "crsViewAllSubCategory";
        drp.SelectCategoryDropDownList(drpprp);
    }
    private void bindsCategory()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddlCollegeType;
        drpprp.spName = "CourseTypeInDrop";
        drp.bindDropDown(drpprp);


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
        prp.name = txtCrsFullname.Text;
        prp.pageIndex = ddlCourseType.SelectedValue;
        prp.pageSize = ddlSubCourseCate.SelectedValue;
        prp.branchName = txtCrsShortName.Text;
        prp.description = txtCrsLongDescription.Text;
        prp.designationName = txtCrsShortDescription.Text;
        prp.durationMaxTime = ddlDuration.SelectedValue;
        prp.codeId = ddlCollegeType.SelectedValue;

        prp.Salary = txtCourseFees.Text;
        prp.security = ddlFeesType.SelectedValue;
        prp.eligibility = txtEligibility.Text;
        prp.grade = ddlFeesMode.SelectedValue;
        prp.noOfRecord = txtNoOfSeat.Text;
        prp.marital = ddlCrsMethod.SelectedValue;
        prp.id = Id;
        prp.specilization = txtscholarship.Text;
        prp.city = memberId;
        lblMsg.Text = bl.UpdateCrsLinkList(prp);
    }
    private void insertCourse()
    {
        prp = new PRPSetupWeb();
        bl = new clsBLSetupWeb();
        prp.name = txtCrsFullname.Text;
        prp.pageIndex = ddlCourseType.SelectedValue;
        prp.pageSize = ddlSubCourseCate.SelectedValue.ToString();
        prp.branchName = txtCrsShortName.Text;
        prp.description = txtCrsLongDescription.Text;
        prp.designationName = txtCrsShortDescription.Text;
        prp.durationMaxTime = ddlDuration.SelectedValue;
        prp.codeId = ddlCollegeType.SelectedValue;

        prp.Salary = txtCourseFees.Text;
        prp.security = ddlFeesType.SelectedValue;
        prp.eligibility = txtEligibility.Text;
        prp.grade = ddlFeesMode.SelectedValue;
        prp.noOfRecord = txtNoOfSeat.Text;
        prp.marital = ddlCrsMethod.SelectedValue;
        prp.courseTime = rdbCourseTime.SelectedItem.Text;
        prp.id = txtscholarship.Text;
        prp.city = memberId;
        lblMsg.Text = bl.InsertCrsLinkList(prp);
    }
    private void ReSet()
    {
        ddlCrsMethod.SelectedIndex = -1;
        txtNoOfSeat.Text = "";
        ddlFeesMode.SelectedIndex = -1;
        txtEligibility.Text = "";
        ddlFeesType.SelectedIndex = -1;
        txtCourseFees.Text = "";
        txtCrsShortDescription.Text = "";
        ddlDuration.SelectedIndex = -1;
        ddlCollegeType.SelectedIndex = -1;
        txtCrsFullname.Text = "";
        ddlCourseType.SelectedIndex = -1;
        ddlSubCourseCate.SelectedIndex = -1;
        txtCrsShortName.Text = "";
        txtCrsLongDescription.Text = "";
        txtscholarship.Text = "";
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
        txtCrsFullname.Text = prp.name;
        ddlCourseType.SelectedValue = prp.pageIndex;
        bindsuniversity();
        ddlSubCourseCate.SelectedValue = prp.pageSize;
        txtCrsShortName.Text = prp.branchName;
        txtCrsLongDescription.Text = prp.description;
        txtCrsShortDescription.Text = prp.designationName;
        ddlDuration.SelectedValue = prp.durationMaxTime;
        ddlCollegeType.SelectedValue = prp.codeId;

        txtCourseFees.Text = prp.salarynum.ToString(); //prp.Salary;
        ddlFeesType.SelectedValue = prp.security;
        txtEligibility.Text = prp.eligibility;
        ddlFeesMode.SelectedValue = prp.grade;
        txtNoOfSeat.Text = prp.noOfRecord;
        ddlCrsMethod.SelectedValue = prp.marital;
        if (prp.courseTime != "" && prp.courseTime != "NULL" && prp.courseTime != null)
        {
            rdbCourseTime.Items.FindByText(prp.courseTime).Selected = true;
        }
        memberId = prp.city;
        txtscholarship.Text = prp.address;
        btnSubmit.Text = "Update";
        btnCancel.Visible = true;

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        ReSet();
    }
    
}
