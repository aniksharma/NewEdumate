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
using nmsJoining;
using nmsOffice;
using nmsView;
using nmsSetup;
using System.Collections.Generic;
using nmsDropDown;
//using nmsLogin;
using nmsProfile;
public partial class employee_updateFullProfile : System.Web.UI.Page
{
    string  stringTempDate = "";
    bool checker = true;        
    ListItem lt;
    Int32 curretnYear = 0, OldYear = 0;
    PRPprofile objprp;

    prpLogin objlog = new prpLogin();

    PostBackOptions optionsSubmit;
            
    static string memberID, Imgurl = "", Id = "", MailId = "", City = "", Dist = "", InstituteCode = "", Images="";
    string memberDOB="0", memberAge="0",Desination="",Address="",HostalFees="",HostalEgibility="",HostalSeat="",ShortDes="",LongDes="",ContactPerson="";
    string nomineeDOB = "0", NomineeAge = "0", GirlHostalFees = "", GirlHostalEgibility = "", GirlHostalSeat = "", HostelQuerry = "", InstituteQuerry = "";
    protected void Page_Load(object sender, EventArgs e)
    {

        optionsSubmit = new PostBackOptions(btnUpdateFullProfile);
        btnUpdateFullProfile.OnClientClick = "disableButtonOnClick1(this, 'Please wait...', 'disabled_button1'); ";
        btnUpdateFullProfile.OnClientClick += ClientScript.GetPostBackEventReference(optionsSubmit);


        if (Session["OfficeCollege"] == null)
        {
            Response.Redirect("../Default.aspx");
        }   

        if (Page.IsPostBack == false)
        {
            if (Session["OfficeCollege"] != null)
            {
                objlog = (prpLogin)(Session["OfficeCollege"]);
            }
            MailId = objlog.EmployeeId;
            ddlBoyFeeType.SelectedValue = "INR";
            Placement.Visible = false;
           
            showDetail(objlog.loginType);
                        
            bindTextBox();
          
        }
        if (!Page.IsPostBack)
        {

            CollegeApprovedBy();

        }
        
    
    }
    private void showDetail( String sn )
    {
        if (sn == "3" )
        {
            sAffiliation.Visible = true;
            sType.Visible = true;
            sLevel.Visible = true;
            sCategory.Visible = true;
            place1.Visible = false;
            cAffiliation.Visible = false;
            cApproved.Visible = true;
            SchoolTypes();

        }
        else
        {
            place1.Visible = true;
            sAffiliation.Visible = true;
            sType.Visible = false;
            sLevel.Visible = false;
            sCategory.Visible = false;
            
            cAffiliation.Visible = false;
            cApproved.Visible = true;
           
 
        }

    }

    private void bindUniversity()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddlAffilitedTo;
        drpprp.spName = "viwUniversityWeb1";
        drp.bindDropDown(drpprp);
    }
    private void SchoolTypes()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();

    //Board         
        drpprp.controlList = ddlAffilitedTo;
        drpprp.id = 1;
        drpprp.spName = "ViewSchoolType";
        drp.bindDropDown(drpprp);
        ddlAffilitedTo.SelectedIndex = 1;

   //Level
        drpprp.controlList = ddlLevel;
        drpprp.id = 2;
        drpprp.spName = "ViewSchoolType";
        drp.bindDropDown(drpprp);
        ddlLevel.SelectedIndex = 1;
   //Type

        drpprp.controlList = ddlType;
        drpprp.id = 3;
        drpprp.spName = "ViewSchoolType";
        drp.bindDropDown(drpprp);
        ddlType.SelectedIndex = 1;
    //Category

        drpprp.controlList = ddlCategory;
        drpprp.id = 4;
        drpprp.spName = "ViewSchoolType";
        drp.bindDropDown(drpprp);
        ddlCategory.SelectedIndex = 1;

    }
    private void CollegeApprovedBy()
    {
        clsBLdropDown objdrp = new clsBLdropDown();
        clsPRPdropdown objprpdrp = new clsPRPdropdown();
        objprpdrp.controlList = ApprovedBy;
        objprpdrp.Type = "CollegeApprovedBy";
        objprpdrp.spName = "SpGetSchoolTypeAndLevelDetails";
        objdrp.bindCategoryControlList(objprpdrp);

    }

    private void updatemember()
    {
        PRPSetup prp = new PRPSetup();
        clsBLSetup bl = new clsBLSetup();

        if (Session["officeCollege"] != null)
        {
            objlog = (prpLogin)(Session["OfficeCollege"]);
        }  
             
        prp.codeId = objlog.EmployeeId;
        InstituteCode = objlog.EmployeeId;
       if (objlog.loginType == "3")
        {
            prp.bord = ddlAffilitedTo.SelectedValue;          
            prp.bord = "insert tblSchoolTypeDetail (SchoolCode, SchoolBoard, SchoolLevel, SchoolType, SchoolCategory ) values ( " + prp.codeId + "," + ddlAffilitedTo.SelectedValue + "," + ddlLevel.SelectedValue + "," + ddlType.SelectedValue + "," + ddlCategory.SelectedValue + ");";   

        }
        else
        {
            prp.branchName = ApprovedBy.SelectedValue;
            prp.urlName = ddlAffilitedTo.SelectedValue;
        }

        prp.name = txtName.Text;
        
        prp.DOJ = txtApprovedDate.Text;

        prp.mailId = txtWebsite.Text;
        //
        prp.address = txtAddress.Text;
        prp.mobNo = txtMobile.Text;
                            
       if (txtboysHostelFees.Text != "")
       {
           HostalFees = txtboysHostelFees.Text;
       }
       else
       {
           HostalFees = "0";
       }
       if (boyHostelEgibility.Text == "")
       {
           HostalEgibility = "null";
       }
       else
       {
           HostalEgibility = boyHostelEgibility.Text;
       }
        if(txtBoysHostelSeats.Text =="")
        {
            HostalSeat="0";
        }
        else
        {
            HostalSeat = txtBoysHostelSeats.Text;
        }
        if (txtGirlHostelFees.Text != "")
        {
            GirlHostalFees = txtGirlHostelFees.Text;
        }
        else
        {
            GirlHostalFees = "0";
        }
        if (txtGirlEgibility.Text == "")
        {
            GirlHostalEgibility = "null";
        }
        else
        {
            GirlHostalEgibility = txtGirlEgibility.Text;
        }

        HostelQuerry += "delete from tblHosteDetail where InstituteCode=" + InstituteCode + ";" + "Insert Into tblHosteDetail (HostelType,HostelFee,FeeType,FeeMode,HostelEligibility,HostelSeat,InstituteCode)values(" + "'Boys'" + "," + HostalFees + ",'" + ddlBoyFeeType.SelectedValue + "','" + ddlBoyFeeMode.SelectedValue + "','" + HostalEgibility + "'," + HostalSeat + "," + InstituteCode + ");";

        if (TxtGirlHostelSeat.Text == "")
        {
            GirlHostalSeat = "0";
        }
        else
        {
            HostalSeat = TxtGirlHostelSeat.Text;
        }
       if (chkGirls.Checked == true)
       {
           HostelQuerry = HostelQuerry + "Insert Into tblHosteDetail (HostelType,HostelFee,FeeType,FeeMode,HostelEligibility,HostelSeat,InstituteCode)values(" + "'Girls'"+"," + HostalFees + ",'" + ddlBoyFeeType.SelectedValue + "','" + ddlBoyFeeMode.SelectedValue + "','" + HostalEgibility + "'," + HostalSeat + "," + InstituteCode+ ");";
       }
       else
       {
           HostelQuerry = HostelQuerry + "Insert Into tblHosteDetail (HostelType,HostelFee,FeeType,FeeMode,HostelEligibility,HostelSeat,InstituteCode)values(" + "'Girls' "+"," + GirlHostalFees + ",'" + ddlGirlFeeType.SelectedValue + "','" + ddlGirlFeeMode.SelectedValue + "','" + GirlHostalEgibility + "'," + HostalSeat + "," + InstituteCode+ ");";
       }
       if (ShortDescription.Text != "")
       {
           ShortDes = ShortDescription.Text;
       }
       else
       {
           ShortDes = "null";
       }
       if (LongDescription.Text == "")
       {
           LongDes = "null";
       }
       else
       {
           LongDes = LongDescription.Text;
       }
       if (txtContactPerson.Text == "")
       {
           ContactPerson = "null";
       }
       else
       {
           ContactPerson = txtContactPerson.Text;
       }

       if (txtDesignation.Text == "")
       {
           Desination = "null";
       }
       else
       {
           Desination = txtDesignation.Text;
       }
       
       InstituteQuerry = "update tblInstituteDescription set ShortDesCription='" + ShortDes + "',LongDesCription='" + LongDes + "',ContactPerson='" + ContactPerson + "',Designation='" + Desination + "'," + "placement='"+ txtplacement.Text + "'" +" " + "where InstCode=" + InstituteCode + ";";
       prp.urlId = "1";
       prp.pageSize = InstituteQuerry;
       prp.Query = HostelQuerry;
       if (txtWebsite.Text != "")
       {
           prp.urlPrntId = txtWebsite.Text;
       }
      lblMsg.Text = bl.UpdateCollegeDetail(prp);
    }
    private void bindTextBox()
    {
        PRPSetup prp = new PRPSetup();
        PRPSetup prppram = new PRPSetup();
        clsBLSetup bl = new clsBLSetup();
        prppram.codeId = MailId;
        prp = bl.SelectCollegeDetail(prppram);
        txtName.Text = prp.name;

        if (Session["OfficeCollege"] != null)
        {
            objlog = (prpLogin)(Session["OfficeCollege"]);
        }
        if (objlog.loginType == "3")
        {

            if (prp.bord != null && prp.bord != "")
            {
                ddlAffilitedTo.ClearSelection();
                ddlAffilitedTo.Items.FindByValue(prp.bord).Selected = true;
            }
            if (prp.level != null && prp.level != "")
            {
                ddlLevel.ClearSelection();
                ddlLevel.Items.FindByValue(prp.level).Selected = true;
            }
            if (prp.type != null && prp.type != "")
            {
                ddlType.ClearSelection();
                ddlType.Items.FindByValue(prp.type).Selected = true;
            }
            if (prp.category != null && prp.category != "")
            {
                ddlCategory.ClearSelection();
                ddlCategory.Items.FindByValue(prp.category).Selected = true;
            }
        }
        else
        {

            CollegeApprovedBy();
            bindUniversity();
            if (prp.urlName != null && prp.urlName != "")
            {
                ddlAffilitedTo.ClearSelection();
                ddlAffilitedTo.Items.FindByText(prp.urlName).Selected = true;
            }
            if (prp.mainLandMark != null && prp.mainLandMark != "")
            {
                ApprovedBy.ClearSelection();
               // ApprovedBy.Items.FindByText(prp.mainLandMark).Selected = true;
            }

            txtAffiliatedTo.Text = prp.urlName;
            txtApprovedBy.Text = prp.mainLandMark;
        }
        
        txtApprovedDate.Text = prp.DOJ;                
        ShortDescription.Text = prp.description;
        LongDescription.Text = prp.courseTime;
        txtAddress.Text = prp.address;
        txtMobile.Text = prp.mobNo;
        txtContactPerson.Text = prp.pv;
        txtDesignation.Text = prp.designationName;
        txtWebsite.Text = prp.emailID;
     
        if (prp.Password != "" && prp.Password != "0")
        {
            ddlBoyFeeType.SelectedValue = prp.Password;
        }
        if (prp.semMode != "" && prp.semMode != "0")
        {
            ddlBoyFeeMode.SelectedValue = prp.semMode;
        }       
        txtboysHostelFees.Text = prp.Salary;
        txtBoysHostelSeats.Text = prp.noOfRecord;
        boyHostelEgibility.Text = prp.eligibility;
       
        if (prp.nneDaily != "" && prp.nneDaily != "0")
        {
            ddlGirlFeeMode.SelectedValue = prp.nneDaily;
        }
        if (prp.sex != "" && prp.sex != "0")
        {
            ddlGirlFeeType.SelectedValue = prp.sex;
        }
        txtGirlHostelFees.Text = prp.examFees;
        TxtGirlHostelSeat.Text = prp.otherFees;
        txtGirlEgibility.Text = prp.nneEmail;
        txtplacement.Text = prp.pageSize;
        Images = prp.urlPath;

        if (prp.urlPrntId != "" )
        {

            txtsite.Text = prp.urlPrntId;
            trwebsite.Visible = false;
        }
        else
        {

            trwebsite.Visible = true;
        }

    }
  
    private bool IsDate(string Date1)
    {
        try
        {
            DateTime d = Convert.ToDateTime(Date1);
            return true;
        }
        catch
        {
            return false;
        }

    }   
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (RadioButtonList1.SelectedValue == "Yes")
        {
            Hostel.Visible = true;
        }
        else
        {
            Hostel.Visible = false;
        }
    }
    protected void chkGirls_CheckedChanged(object sender, EventArgs e)
    {
        if (chkGirls.Checked == true)
        {
            txtGirlHostelFees.Text = txtboysHostelFees.Text;
            TxtGirlHostelSeat.Text = txtBoysHostelSeats.Text;
            ddlGirlFeeMode.SelectedValue = ddlBoyFeeMode.SelectedValue;
            ddlGirlFeeType.SelectedValue = ddlBoyFeeType.SelectedValue;
            txtGirlEgibility.Text = boyHostelEgibility.Text;
            ddlGirlFeeMode.Enabled = false;
            ddlGirlFeeType.Enabled = false;
            txtGirlHostelFees.Enabled = false;
            TxtGirlHostelSeat.Enabled = false;
            txtGirlEgibility.Enabled = false;
        }
        else
        {
            ddlGirlFeeMode.Enabled = true;
            ddlGirlFeeType.Enabled = true;
            txtGirlHostelFees.Enabled = true;
            TxtGirlHostelSeat.Enabled = true;
            txtGirlEgibility.Enabled = true;
            ddlGirlFeeMode.SelectedIndex = 0;
            ddlGirlFeeType.SelectedIndex = 0;
            txtGirlHostelFees.Text = "";
            TxtGirlHostelSeat.Text = "";
            txtGirlEgibility.Text = "";
        }
    }
    
    protected void btnUpdateFullProfile_Click(object sender, EventArgs e)
    {
        updatemember();
        if (lblMsg.Text == "Updated Successfully !")
        {
            objlog = (prpLogin)(Session["OfficeCollege"]);
            objlog.webSite = txtsite.Text;
            Session["OfficeCollege"] = objlog;
        }
    }
    protected void rbplacement_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (rbplacement.SelectedValue == "Yes")
        {
            Placement.Visible = true;
        }
        else
        {
            Placement.Visible = false;
        }
    }
}
