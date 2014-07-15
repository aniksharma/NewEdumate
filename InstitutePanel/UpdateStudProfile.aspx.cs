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
using nmsProfile;
using hr;
using System.Net;
using System.Net.Mail;
using javax.jws;
using System.Data.SqlClient;




public partial class InstitutePanel_UpdateStudProfile : System.Web.UI.Page
{
    string stringTempDate = "";
    bool checker = true;
    ListItem lt;
    Int32 curretnYear = 0, OldYear = 0;
    PRPprofile objprp;
    DataSet ds = new DataSet();
    DataSet dssec = new DataSet();
    DataSet dsedu = new DataSet();
    DataSet dsedu1 = new DataSet();
    prpLogin objlog = new prpLogin();
    string strcon = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;

    string strcon1 = ConfigurationManager.ConnectionStrings["cnkids"].ConnectionString;
    
    PostBackOptions optionsSubmit;
    string ToMail, FromMail, BodyMail, HeadMail;
    static string memberID, Imgurl = "", Id = "", idss = "", MailId = "", City = "", Dist = "", InstituteCode = "", Images = "",st="";
    string memberDOB = "0", memberAge = "0", Desination = "", Address = "", HostalFees = "", HostalEgibility = "", HostalSeat = "", ShortDes = "", LongDes = "", ContactPerson = "";
    string nomineeDOB = "0", NomineeAge = "0", GirlHostalFees = "", GirlHostalEgibility = "", GirlHostalSeat = "", HostelQuerry = "", InstituteQuerry = "";

    
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
            BindCountry();
            BindState();

            bindTextBox();
        }
    }
    
    private void bindTextBox()
    {
        PRPSetup prp = new PRPSetup();
        PRPSetup prppram = new PRPSetup();
        clsBLSetup bl = new clsBLSetup();
        prppram.codeId = MailId;
        prp = bl.SelectStudDetail(prppram);
         txtKidsname.Text = prp.name;

        if (Session["OfficeCollege"] != null)
        {
            objlog = (prpLogin)(Session["OfficeCollege"]);
        }

        txtaddress.Text = prp.address;
        txtmobile.Text  = prp.mobNo;
        txtemail.Text = prp.branchCodeName;
        txtDob.Text = prp.city;
        RbGender.SelectedValue = prp.district;
       
        Images = prp.urlPath;
 
        int contid = Convert.ToInt32(prp.urlPath);
        
        DropDownList1.SelectedIndex=contid;
        int stateid = Convert.ToInt32 ( prp.mailId);
        DropDownList2.SelectedIndex = stateid;

        var source = Enumerable.Range(1947, 80)
            .Select(i => new { Text = i.ToString(), Value = i.ToString() });
        DropDownList4.DataSource = source;
        DropDownList4.DataTextField = "Text";
        DropDownList4.DataValueField = "Value";
        DropDownList4.DataBind();
        string  study = prp.education;
        rbs.SelectedValue = study;
        BindSubCategory();
        int city = Convert.ToInt32(prp.DOJ);
        ddlCity.SelectedIndex = city;
        bindCity();
    
    }

    public void BindSubCategory()
    {

        DataSet ds3 = new DataSet();

        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand("GetAllCategoryType", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] paramsToStore =
           new SqlParameter[4];
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds3);
        ddlentrest.DataSource = ds3;
        ddlentrest.DataValueField = "id";
        ddlentrest.DataTextField = "name";
        ddlentrest.DataBind();


    }
    private void BindCountry()
    { 
        nmsDropDown.clsBLdropDown drp = new nmsDropDown.clsBLdropDown();
        nmsDropDown.clsPRPdropdown drpprp = new nmsDropDown.clsPRPdropdown();
        drpprp.controlList = DropDownList1;
        drpprp.spName = "viewCountry";
        drp.bindDropDown(drpprp);
    }
    private void BindState()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = DropDownList2;
        if (DropDownList1.SelectedIndex != 0)
            drpprp.id = Convert.ToInt32(DropDownList1.SelectedValue);
        drpprp.spName = "viewState";
        drp.bindDropDown(drpprp);
    }
    private void bindCity()
    {
        nmsDropDown.clsBLdropDown drp = new nmsDropDown.clsBLdropDown();
        nmsDropDown.clsPRPdropdown drpprp = new nmsDropDown.clsPRPdropdown();
        drpprp.controlList = ddlCity;
        if (DropDownList2.SelectedIndex > 0)
        {
            drpprp.id = Convert.ToInt32(DropDownList2.SelectedValue);
        }
        drpprp.spName = "viewDistrict";
        drp.bindDropDown(drpprp);
       
    }
    protected void btnUpdateNominee_Click(object sender, EventArgs e)
    {
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
    private void UpdKidsProfile()
    {

        clsBLhr bl = new clsBLhr();
        clsprophr prop = new clsprophr();
        prop.name = txtKidsname.Text;
        prop.DOB = txtDob.Text;
        prop.email = txtemail.Text;
        prop.Description = txtaddress.Text;
        prop.Country = DropDownList1.SelectedValue;
        prop.City = ddlCity.SelectedValue;
        prop.catid = DropDownList2.SelectedValue;
        prop.mob = txtmobile.Text;
        prop.title = DropDownList4.SelectedValue;
        prop.uniId = DropDownList3.SelectedValue;
        prop.Organiser = ddlentrest.SelectedValue;
        prop.Designation = DropDownList6.SelectedValue;
        prop.Type = RbGender.SelectedValue;
        //--- Start edu
        prop.CurrentStudying = DropDownList1.SelectedValue;
        prop.GraduatingYrs = DropDownList4.SelectedValue;
        prop.EduIntrest = ddlentrest.SelectedValue;
        prop.StudyId = rbs.SelectedValue;
        prop.PrefLocation = ddllocation.SelectedValue;
        prop.WhenStart = DropDownList6.SelectedValue;
        prop.Experience = txtpassword.Text;
        prop.urlName = txtsite.Text;
        //-- end edu
        st = bl.UpdKidsProfile(prop);
    }
    protected void btsubmit_Click(object sender, EventArgs e)
    {
        UpdKidsProfile();
        if (st == "Update SuccssFully !")
        {
            lblMsg.Visible = true;
            lblMsg.ForeColor = System.Drawing.Color.Green;
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindState();
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
    }


    protected void rbs_SelectedIndexChanged(object sender, EventArgs e)
    {
    }
    //<----------- Srikant for Secondary Education Profile--------------->


    [WebMethod]
    public static CountryDetails[] BindDatatoDropdown()
    {
        DataTable dt = new DataTable();
        List<CountryDetails> details = new List<CountryDetails>();
        string strcon = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection con = new SqlConnection(strcon);

        using (SqlCommand cmd = new SqlCommand("viewCountry", con))
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dtrow in dt.Rows)
            {
                CountryDetails country = new CountryDetails();
                country.id = Convert.ToInt32(dtrow["id"].ToString());
                country.name = dtrow["name"].ToString();
                details.Add(country);
            }

        }
        return details.ToArray();
    }
    public class CountryDetails
    {
        public int id { get; set; }
        public string name { get; set; }
    }


  
}
