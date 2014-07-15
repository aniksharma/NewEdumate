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
using nmsOffice;

using System.Collections.Generic;
using nmsDropDown;
using nmsProfile;
using hr;
using System.Net;
using System.Net.Mail;

using System.Data.SqlClient;
using nmsView;
using nmsSetup;


public partial class InstitutePanel_UpdateTutorProfile : System.Web.UI.Page
{
    clsPRPdropdown drpprps;
    clsBLdropDown drps;
    PRPOffice prppram;
    PRPOffice prp;
    BLoffice bl;

    clsBLprofile obj;
    prpLogin prplogin;
    prpLogin prppram1;
    static string kidsid;
    prpLogin objlog = new prpLogin();

    string type = "", memberId = "";
    static string branchId = "", fileURL = "", MailId = "";
    string imgurl = "", path = "", MaxId = "";
    string ToMail, FromMail, BodyMail, HeadMail;
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["OfficeCollege"] == null)
        {
            
        }

        
        if (Page.IsPostBack == false)
        {
            if (Session["OfficeCollege"] != null)
            {
                objlog = (prpLogin)(Session["OfficeCollege"]);
            }
            MailId = objlog.EmployeeId;
            kidsid = objlog.EmployeeId;
           
            BindCountry();
            bindState();
            bindDist();

            bindCity();
            bindTextBox();
            binduniversity();

        }

    }

    private void binduniversity()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddlCourseType;
        drpprp.id = 5;
        drpprp.spName = "crsViewAllMainCategory";
        drp.bindDropDown(drpprp);
        //ddlCourseType.SelectedIndex = 1;
    }

    private void bindTextBox()
    {
        PRPSetup prp = new PRPSetup();
        PRPSetup prppram = new PRPSetup();
        clsBLSetup bl = new clsBLSetup();
        if (Page.RouteData.Values["values"] != null)
        {
            prppram.codeId = Page.RouteData.Values["values"].ToString();

        }
        else
        {

        }
        prp = bl.SelectTutorDetail(prppram);
        txttypename.Text = prp.name;

        if (Session["OfficeCollege"] != null)
        {
            objlog = (prpLogin)(Session["OfficeCollege"]);
        }
        txtpincode.Text = prp.phoneNo;
        ShortDescription.Text = prp.status;
        LongDescription.Text = prp.education;
        txtaddress.Text = prp.state;
        txtmobile.Text = prp.mobNo;
        txtAge.Text = prp.city;
       // txtemail.Text = prp.branchCodeName;
        txtCourseFees.Text = prp.grade;
        if (prp.district == "Female")
        {
            RadioButtonList2.SelectedValue = "2";
        }
        else
        {
            RadioButtonList2.SelectedValue = "1";
        }
        ListItem lt1 = ddlCountry.Items.FindByValue(prp.urlPath);

        ddlCountry.SelectedIndex = ddlCountry.Items.IndexOf(lt1);

        bindState();
        ListItem lt2 = ddlUniversity.Items.FindByValue(prp.mailId);
        ddlUniversity.SelectedIndex = ddlUniversity.Items.IndexOf(lt2);
        bindDist();
        ListItem lt3 = ddlDist.Items.FindByValue(prp.emailID);
        ddlDist.SelectedIndex = ddlDist.Items.IndexOf(lt3);

        bindCity();
        ListItem lt4 = ddlCity.Items.FindByValue(prp.DOJ);
        ddlCity.SelectedIndex = ddlCity.Items.IndexOf(lt4);
       
       
        ddlTutoringStyle.SelectedValue = prp.uniID;
  
        txtBestTimeToCall.Text = prp.address;
      
    }
    #region SubCategoryBind
    private void bindsuniversity()
    {



        //clsBLSetup bl = new clsBLSetup();
        //PRPSetup prppram = new PRPSetup();
        //prppram.name = "crsViewAllSubCategory";
        //if (ddlCourseType.SelectedIndex != 0)
        //    prppram.uniID = ddlCourseType.SelectedValue;
        //prppram.type = ddlCountry.SelectedValue;
        //CheckBoxList1.DataSource = bl.ViewTutorSubcategoryTypeWithParamater(prppram);
        //CheckBoxList1.DataTextField = "name";
        //CheckBoxList1.DataValueField = "id";
        //CheckBoxList1.DataBind();


    }
    #endregion
    protected void ddlUniversity0_SelectedIndexChanged(object sender, EventArgs e)
    {
        bindDist();

    }
    protected void ddlUniversity_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        UpdateBranch();
        
        if (lblMsg.Text == "Update SuccssFully !")
        {
            lblMsg.Visible = true;
        }
    }

    private void UpdateBranch()
    {
        clsBLhr bl1 = new clsBLhr();
        clsprophr prop = new clsprophr();
        if (Page.RouteData.Values["values"] != null)
        {
            prop.email = Page.RouteData.Values["values"].ToString();

        }
        else
        {

        }
     
        prop.Country = ddlCountry.SelectedValue;  //ddlUniversity0.SelectedValue;
        
        prop.state = ddlUniversity.SelectedValue;
        prop.district = ddlDist.SelectedValue;
        if (txtOtherLocation.Text != "")
        {
            prop.Location = txtOtherLocation.Text;
        }
        else
        {
            if (ddlCity.SelectedIndex != 0)
                prop.city = ddlCity.SelectedValue;
            else
            {
                prop.city = null;
            }

        }
        prop.name = txttypename.Text;
        prop.address = txtaddress.Text;
        prop.mob = txtmobile.Text;
        prop.tutionType = ddlTutoringStyle.SelectedItem.Text;
        prop.description = ShortDescription.Text;
        prop.mainLandMark = LongDescription.Text;
        prop.AssociateName = txtBestTimeToCall.Text;
        prop.DOB = txtAge.Text;
        prop.Type = RadioButtonList2.SelectedItem.Text;
        prop.status = ddlCourseType.SelectedItem.Text;//ddlUniType.SelectedItem.Text;
        prop.pinCode = txtpincode.Text;
        prop.phoneNo = txtcode.Text + txtnumber.Text;
        if (txtCourseFees.Text == "")
        {
            prop.Salary = "0";
        }
        else
        {
            prop.Salary = txtCourseFees.Text;
        }

      
        prop.security = ddlFeesType.SelectedValue;
        prop.urlPath = ddlFeesMode.SelectedValue;
      
        if (txtsite.Text != "")
        {
            prop.urlName = txtsite.Text;
        }
        String Query = "";
        lblMsg.Text = bl1.UpTutorProfile(prop);
    }
    private void bindState()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddlUniversity;
        if (ddlCountry.SelectedIndex != 0)
            drpprp.id = Convert.ToInt32(ddlCountry.SelectedValue);
        drpprp.spName = "viewState";
        drp.bindDropDown(drpprp);


    }
    private void bindDist()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddlDist;

        if (ddlUniversity.SelectedIndex != 0)
            drpprp.id = Convert.ToInt32(ddlUniversity.SelectedValue);
        drpprp.spName = "viewDistrict";
        drp.bindDropDown(drpprp);
       
    }
    private void bindCity()
    {
        clsBLdropDown drps = new clsBLdropDown();
        clsPRPdropdown drpprps = new clsPRPdropdown();
        drpprps.controlList = ddlCity;
        if (ddlDist.SelectedIndex != 0)
            drpprps.id = Convert.ToInt32(ddlDist.SelectedValue);
        drpprps.spName = "viewCity";
        drps.bindDropDown(drpprps);
    }
    protected void ddlDist_SelectedIndexChanged(object sender, EventArgs e)
    {
        bindCity();
    }
    private void checkEmailID()
    {
        String st = "";
        obj = new clsBLprofile();
        prppram1 = new prpLogin();
 
        st = obj.forgetPassword(prppram1);
        if (st != "No")
        {
            lblerrorShow.Text = " Thanks! Yout are all ready registered with this email id. We will meet soon";
            LinkButton1_ModalPopupExtender.Show();
        }
    }
    protected void txtemail_TextChanged(object sender, EventArgs e)
    {
        checkEmailID();
    }
    protected void ddlCourseType_SelectedIndexChanged(object sender, EventArgs e)
    {
        bindsuniversity();
    }
    protected void ddlSubCourseCate_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlCity.SelectedIndex != 0)
        {
            txtOtherLocation.Enabled = false;
        }
        else
        {
            txtOtherLocation.Enabled = true;
        }

    }


    #region Country Bind

    private void BindCountry()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddlCountry;
        drpprp.spName = "viewCountry";
        drp.bindDropDown(drpprp);
    }
    #endregion

    protected void ddlCountry_SelectedIndexChanged1(object sender, EventArgs e)
    {
        if (ddlCountry.SelectedIndex != 0)
            bindState();
    }
}
