using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using nmsSetup;
using nmsDropDown;
using nmsView;

public partial class Admin_web_AddCollegeListing : System.Web.UI.Page
{
    PRPSetup prppram;
    PRPSetup prp;
    clsBLSetup bl;

    public string Id = "", imgurl = "", imageId = "", fileURL = "", MaxId = "", sLogo = "";
    string path = "";
    int expstn;
    string type = "", memberId = "";
    static string branchId = "", collegeTypeId = "";

    protected void Page_Load(object sender, EventArgs e)
    {
       
        lblMsg.Text = "";
        lblMsg.CssClass = "lr";
      
        

        if (!Page.IsPostBack)
        {
            SelectDatail(1);
            bindRankList();
            bindUniType();
            bindEducationType();
            BindCountry();
            bindUniversity();
            bindState();
            bindDistrict();
            bindCity();
            CollegeApprovedBy();

        }

    }
    //----------------------bind repeater with manual pageing-------------------
    private void bindRankList()
    {
        // Int32 lastvalue = ;
        ListItem lt;
        for (int i = 1; i <= 100; i++)
        {
            if (i <= 9)
            {
                lt = new ListItem("0" + i.ToString(), i.ToString());
            }

            else
            {
                lt = new ListItem(i.ToString(), i.ToString());
            }

            ddlRankList.Items.Add(lt);

        }
        ListItem lt1 = new ListItem("Courses Rank", "0");
        ddlRankList.Items.Insert(0, lt1);
    }

    #region Bind College Category
    protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlCategory.SelectedIndex != 0)

            BindSubCategory();
    }

    private void bindCategory()
    {
        clsBLdropDown objdrp = new clsBLdropDown();
        clsPRPdropdown objprpdrp = new clsPRPdropdown();
        objprpdrp.controlList = ddlCategory;
        if (ddlUniversity.SelectedIndex != 0)
            objprpdrp.id = 4;// Convert.ToInt32(RadioButtonList1.SelectedValue);  // Edu Type For College
        objprpdrp.spName = "GetAllCategory";
        objdrp.bindDropDown(objprpdrp);
    }



    #endregion
    #region  Bind Country State Dist City
    private void BindCountry()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddlUniversity0;
        drpprp.spName = "viewCountry";
        drp.bindDropDown(drpprp);

    }
    private void bindState()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddlUniversity;
        if (ddlUniversity0.SelectedIndex != 0)
            drpprp.id = Convert.ToInt32(ddlUniversity0.SelectedValue);
        drpprp.spName = "viewState";
        drp.bindDropDown(drpprp);

    }
    private void bindDistrict()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddlDistrict;
        drpprp.id = Convert.ToInt32(ddlUniversity.SelectedValue);
        drpprp.spName = "viewDistrict";
        drp.bindDropDown(drpprp);
     
    }
    private void bindCity()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddlCity;
        if (ddlDistrict.SelectedIndex != 0)
            drpprp.id = Convert.ToInt32(ddlDistrict.SelectedValue);
        drpprp.spName = "viewCity";
        drp.bindDropDown(drpprp);
    }
    #endregion
    private void bindUniversity()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        if (ddlUniversity0.SelectedIndex != 0)
            drpprp.id = Convert.ToInt32(ddlUniversity0.SelectedValue);
        drpprp.controlList = ddlUniversityFinal;
        drpprp.spName = "viwUniversityWeb1";
        drp.bindDropDown(drpprp);
    }
    private void bindUniType()
    {
        bl = new clsBLSetup();
        prppram = new PRPSetup();
        prppram.name = "viewCollegeType";
        List<PRPSetup> lst = new List<PRPSetup>();
        lst = bl.ViewCollegeType(prppram);
        if (lst[0].srNo != "Result Not Find")
        {
            Repeater1.DataSource = lst;
            Repeater1.DataBind();
        }
        else
        {
            Repeater1.DataSource = null;
            Repeater1.DataBind();
        }
    }
    private void bindEducationType()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddl;
        drpprp.spName = "viewEducationType";
        drp.bindDropDown(drpprp);
        ddl.SelectedIndex = 1;
    }
    protected void ddlUniversity_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlUniversity.SelectedIndex != 0)
            bindDistrict();

    }
    protected void ddlDistrict_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlDistrict.SelectedIndex != 0)
            bindCity();
            bindCategory();

    }
    protected void ddlUniversity0_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlUniversity0.SelectedIndex != 0)
        {
                bindState();
                CollegeApprovedBy();
                bindUniversity();
                CollegeCourseLevel();
           
        }

    }
    private void SelectDatail(Int32 pageIndex)
    {

        bl = new clsBLSetup();
        prppram = new PRPSetup();
        Int32 pageSize = Convert.ToInt32(ddlNopage.SelectedValue);

        prppram.pageIndex = pageIndex.ToString();
        prppram.pageSize = pageSize.ToString();
        prppram.LoginType = "4";

        List<PRPSetup> lst = new List<PRPSetup>();
        lst = bl.ViewCollegeDetail(prppram);
        if (lst[0].srNo != "Result Not Find")
        {
            Int32 noOfRecord = Convert.ToInt32(lst[lst.Count - 1].noOfRecord);

            lst.RemoveAt(lst.Count - 1);
            datalist.DataSource = lst;
            datalist.DataBind();
            //---------for page work here
            lblCurrentPage.Text = pageIndex.ToString();
            if ((noOfRecord % pageSize) == 0)
                lblLastPage.Text = Convert.ToInt32(noOfRecord / pageSize).ToString();
            else
                lblLastPage.Text = Convert.ToInt32(noOfRecord / pageSize + 1).ToString();

            lnkfstPage.Enabled = true;
            lnkLastpage.Enabled = true;
            lnkNextpage.Enabled = true;
            lnkPrepage.Enabled = true;
            if (pageIndex == 1)
            {
                lnkfstPage.Enabled = false;
                lnkPrepage.Enabled = false;
            }
            if (pageIndex == Convert.ToInt32(lblLastPage.Text))
            {
                lnkLastpage.Enabled = false;
                lnkNextpage.Enabled = false;
            }
            //----------------------------------------------

        }
        else
        {
            datalist.DataSource = null;
            datalist.DataBind();
            lblMsg.Text = "Result Not Found";

        }
    }
    protected void ddlNopage_SelectedIndexChanged(object sender, EventArgs e)
    {
        SelectDatail(1);
    }
    protected void lnkfstPage_Click(object sender, EventArgs e)
    {
        SelectDatail(1);
    }
    protected void lnkPrepage_Click(object sender, EventArgs e)
    {
        SelectDatail(Convert.ToInt32(lblCurrentPage.Text) - 1);

    }
    protected void lnkNextpage_Click(object sender, EventArgs e)
    {
        SelectDatail(Convert.ToInt32(lblCurrentPage.Text) + 1);
    }
    protected void lnkLastpage_Click(object sender, EventArgs e)
    {
        SelectDatail(Convert.ToInt32(lblLastPage.Text));
    }
    protected void lnkBtnGO_Click(object sender, EventArgs e)
    {
        if (Convert.ToInt32(txtGoPage.Text) >= 0 && Convert.ToInt32(txtGoPage.Text) <= Convert.ToInt32(lblLastPage.Text))
        {
            SelectDatail(Convert.ToInt32(txtGoPage.Text));
        }
        else
        {
            SelectDatail(Convert.ToInt32(lblLastPage.Text));
        }
    }
    //--------------------------------------------------------------------------
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        int i = 0;
        string st = "", ss = "";
        for (i = 0; i < Repeater1.Items.Count; i++)
        {
            CheckBox chk = (CheckBox)(Repeater1.Items[i].FindControl("chk"));

            if (chk.Checked)
            {
                st += "insert tblCollegeTypeDetail values(NULL," + ((Label)Repeater1.Items[i].FindControl("lblId")).Text + ");";
            }

        }
    
        if (btnSubmit.Text == "Save")
        {
            insertBranch(st);

        }
        else
        {
            UpdateBranch(st);

        }
        if (lblMsg.Text.Substring(0, 14) == "College Submit")
        {
            EmptyTextBox();

            if (btnSubmit.Text != "Save")
            {
                EmployeeDiv.Visible = false;
            }
            lblMsg.CssClass = "lg";
        }
        else
        {
            EmployeeDiv.Visible = true;
            lblMsg.CssClass = "lr";
        }


        SelectDatail(1);


    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        EmptyTextBox();
    }
    protected void lnkAdd_Click(object sender, EventArgs e)
    {
        btnSubmit.Text = "Save";
        if (EmployeeDiv.Disabled == true)
        {
            EmployeeDiv.Disabled = false;
        }
        else
        {
            EmployeeDiv.Disabled = true;
        }

        EmptyTextBox();
    }
    protected void datalist_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "edit")
        {
            branchId = e.CommandArgument.ToString();

            BindTextboxes();

            bindUniType();

            bindCollegeType();
            EmployeeDiv.Visible = true;
            btnSubmit.Text = "Update";
        }
        if (e.CommandName == "Delete")
        {
            branchId = e.CommandArgument.ToString();
            BindDelete();
            SelectDatail(1);
        }
    }
    private void BindDelete()
    {
        prp = new PRPSetup();
        bl = new clsBLSetup();
        prp.codeId = branchId;
        lblMsg.Text = bl.DeleteUniversityWeb(prp);
    }
    protected void btnAddNewEmployee_Click(object sender, EventArgs e)
    {
        btnSubmit.Text = "Save";
        
        if (EmployeeDiv.Visible == true)
        {
            EmployeeDiv.Visible = false;
        }
        else
        {
            EmployeeDiv.Visible = true;
        }

        EmptyTextBox();
    }
    private void BindTextboxes()
    {
        prp = new PRPSetup();
        prppram = new PRPSetup();
        bl = new clsBLSetup();
        prppram.codeId = branchId;

        prp = bl.SelectCollegeDetail(prppram);
        txtName.Text = prp.name;
        txtLandMark.Text = prp.mainLandMark;
        txtDate.Text = prp.DOJ;
        txtAddress.Text = prp.address;
        txtPhone.Text = prp.phoneNo;
        txtmobNo.Text = prp.mobNo;
        txtMailId.Text = prp.mailId;
        txtBranchCode.Text = prp.branchCodeName;

        txtWebSite.Text = prp.emailID;

        ListItem lt;
        lt = rblStatus.Items.FindByText(prp.status);
        rblStatus.SelectedIndex = rblStatus.Items.IndexOf(lt);

        lt = ddlUniType.Items.FindByText(prp.status);
        ddlUniType.SelectedIndex = ddlUniType.Items.IndexOf(lt);

        lt = ddl.Items.FindByValue(prp.education);
        ddl.SelectedIndex = ddl.Items.IndexOf(lt);

        lt = ddlRankList.Items.FindByValue(prp.rank);
        ddlRankList.SelectedIndex = ddlRankList.Items.IndexOf(lt);

        lt = ddlGrade.Items.FindByText(prp.rank);
        ddlGrade.SelectedIndex = ddlGrade.Items.IndexOf(lt);

        lt = ddlUniversity0.Items.FindByValue(prp.uniID);
        ddlUniversity0.SelectedIndex = ddlUniversity0.Items.IndexOf(lt);

        lt = ddlUniversityFinal.Items.FindByValue(prp.id);
        ddlUniversityFinal.SelectedIndex = ddlUniversityFinal.Items.IndexOf(lt);

        bindState();

        lt = ddlUniversity.Items.FindByValue(prp.state);
        ddlUniversity.SelectedIndex = ddlUniversity.Items.IndexOf(lt);

        bindDistrict();

        lt = ddlDistrict.Items.FindByValue(prp.district);
        ddlDistrict.SelectedIndex = ddlDistrict.Items.IndexOf(lt);

        bindCity();

        lt = ddlCity.Items.FindByValue(prp.city);
        ddlCity.SelectedIndex = ddlCity.Items.IndexOf(lt);

    }
    private void bindCollegeType()
    {
        prp = new PRPSetup();

        prppram = new PRPSetup();
        bl = new clsBLSetup();

        prppram.id = branchId;

        List<PRPSetup> lst1 = new List<PRPSetup>();

        lst1 = bl.ViewCollegeType1(prppram);

        foreach (PRPSetup p in lst1)
        {
            for (int i = 0; i < Repeater1.Items.Count; i++)
            {
                CheckBox chk = ((CheckBox)(Repeater1.Items[i].FindControl("chk")));
                if (p.name == ((Label)(Repeater1.Items[i].FindControl("lblName"))).Text)
                {

                    chk.Checked = true;
                }

            }

        }



    }
    private void EmptyTextBox()
    {
        txtAddress.Text = "";
        txtWebSite.Text = "";
        //  txtCity.Text = "";
        //  txtDisrict.Text = "";
        txtLandMark.Text = "";
        txtMailId.Text = "";
        txtmobNo.Text = "";
        txtName.Text = "";
        txtPhone.Text = "";
        txtDate.Text = "";
        // txtState.Text = "";
        txtBranchCode.Text = "";
        //  rblStatus.SelectedIndex = 0;
        txtName.Focus();
    }
    private void checkFileUploadedPath()
    {
        clsPRPParm objprm = new clsPRPParm();
        clsBLview obj = new clsBLview();
        objprm.spName = "viewGetMaxImageId";
        MaxId = obj.GetMaxFileId(objprm);
    }

    private void insertBranch(String st)
    {
        prp = new PRPSetup();
        bl = new clsBLSetup();
        prp.uniID = ddlUniversity0.SelectedValue;
        prp.state = ddlUniversity.SelectedValue;
        prp.district = ddlDistrict.SelectedValue;
        prp.city = ddlCity.SelectedValue;
        prp.catID = st;
        prp.education = ddl.SelectedValue;       
        prp.status = ddlUniType.SelectedItem.Text;
        //prp.status = ddlUniType.SelectedItem.Text;  // by Devesh
        prp.name = txtName.Text;
        prp.mainLandMark = txtLandMark.Text;
        prp.isActive = rblStatus.SelectedValue;
        prp.address = txtAddress.Text;
        prp.phoneNo = txtPhone.Text;
        prp.mobNo = txtmobNo.Text;
        prp.mailId = txtMailId.Text;
        prp.DOJ = txtDate.Text;
        prp.pinCode = txtBranchCode.Text;
        //prp.branchCodeName = txtBranchCode.Text;
        prp.emailID = txtWebSite.Text;
        prp.rank = ddlRankList.SelectedItem.Text;
        prp.grade = ddlGrade.SelectedValue;
        prp.id = ddlUniversityFinal.SelectedValue;  // for Univercity        

        prp.sCategory = ddlCategory.SelectedValue;
        prp.subCategory = ddlSubCategory.SelectedValue;
        prp.CourseLevel = ddlCourseLevel.SelectedValue;     
        prp.ApprovedBy = ApprovedBy.SelectedValue;

        if (logoCollege.HasFile)
        {
            checkFileUploadedPath();
            imgurl = "../Advertisement/" + MaxId + logoCollege.FileName;
            path = Server.MapPath("../Advertisement/" + imgurl);
            prp.sCollegeLogo = path;
        }

        else
            prp.sCollegeLogo = "../Advertisement/universityLogo.png";

        prp.nneSMS = "0";
        prp.title = "4";     //Use For College Type Id
        lblMsg.Text = bl.InsertCollegeDetail(prp);
    }
    private void UpdateBranch(string st)
    {

        prp = new PRPSetup();
        bl = new clsBLSetup();
        prp.codeId = branchId;
        prp.uniID = ddlUniversity0.SelectedValue;
        prp.state = ddlUniversity.SelectedValue;
        prp.district = ddlDistrict.SelectedValue;
        prp.city = ddlCity.SelectedValue;
        prp.catID = st;
        prp.education = ddl.SelectedValue;
        prp.status = ddlUniType.SelectedItem.Text;
        prp.id = ddlUniversityFinal.SelectedValue;
        prp.name = txtName.Text;
        prp.mainLandMark = txtLandMark.Text;
        prp.isActive = rblStatus.SelectedValue;
        prp.address = txtAddress.Text;
        prp.phoneNo = txtPhone.Text;
        prp.mobNo = txtmobNo.Text;
        prp.mailId = txtMailId.Text;
        prp.DOJ = txtDate.Text;
        prp.branchCodeName = txtBranchCode.Text;
        prp.emailID = txtWebSite.Text;
        prp.rank = ddlRankList.SelectedValue;
        prp.grade = ddlGrade.SelectedValue;
        lblMsg.Text = bl.UpdateCollegeDetail(prp);
    }
    private void checker()
    {
        if (Session["OfficeAdmin"] == null)
        {
            nmsProfile.prpLogin objlog = new nmsProfile.prpLogin();
            objlog = (nmsProfile.prpLogin)(Session["OfficeAdmin"]);
            if (objlog.loginType != "1")
            {
                Response.Redirect("../../Default.aspx?logout=session&path=Admin/Authority.aspx");
            }
        }
    }
    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        // collegeTypeId +=e.CommandArgument.ToString() + ",";
    }

    private void BindSubCategory()
    {
        clsBLdropDown objdrp = new clsBLdropDown();
        clsPRPdropdown objprpdrp = new clsPRPdropdown();
        objprpdrp.controlList = ddlSubCategory;
        if (ddlCategory.SelectedIndex != 0)
            objprpdrp.id = Convert.ToInt32(ddlCategory.SelectedValue);
        objprpdrp.Type = ddlUniversity0.SelectedValue;
        objprpdrp.spName = "crsViewAllSubCategory";
        objdrp.bindCategoryControlList(objprpdrp);
    }   

    #region Bind College Course Level
    private void CollegeCourseLevel()
    {
        clsBLdropDown objdrp = new clsBLdropDown();
        clsPRPdropdown objprpdrp = new clsPRPdropdown();
        objprpdrp.controlList = ddlCourseLevel;

        objprpdrp.id = Convert.ToInt32(ddlUniversity0.SelectedValue);
        objprpdrp.Type = "CollegeLevel";
        objprpdrp.spName = "SpGetSchoolTypeAndLevelDetails";
        objdrp.bindCategoryControlList(objprpdrp);

    }
    private void CollegeApprovedBy()
    {
        clsBLdropDown objdrp = new clsBLdropDown();
        clsPRPdropdown objprpdrp = new clsPRPdropdown();
        objprpdrp.controlList = ApprovedBy;

        objprpdrp.id = Convert.ToInt32(ddlUniversity0.SelectedValue);
        objprpdrp.Type = "CollegeApprovedBy";
        objprpdrp.spName = "SpGetSchoolTypeAndLevelDetails";
        objdrp.bindCategoryControlList(objprpdrp);

    }
    #endregion
      
    
}
