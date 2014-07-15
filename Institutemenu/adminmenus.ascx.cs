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
using nmsProfile;
using nmsSetupWeb;
using nmsSetup;
using System.Data.SqlClient;
using nmsDropDownKIDS;
public partial class adminWebControl_adminmenu : System.Web.UI.UserControl
{
    prpLogin prppram, objlogin;

    String webname = "";
    static Int32 sts = 0;
   
    String MaxId = "";

    static String Images = "";
    string strcon = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
    string name = "";
    DataSet ds = new DataSet();
    DataSet ds2 = new DataSet();
    DataSet ds3 = new DataSet();
    protected string id = string.Empty;
  static  string ids = "";

  string cont = "";
  string state = "";
  string type = "";
  string edu = "";
   static string VirtualPath;
  protected void Page_Load(object sender, EventArgs e)
    {
        
        
      
        if (Session["OfficeCollege"] == null)
        {
        //    Response.Redirect("Default.aspx");
            Response.Redirect("Default.aspx");
        }
        bindLogin();

        objlogin = new prpLogin();
        if (Session["OfficeCollege"] != null)
        {
            objlogin = (prpLogin)(Session["OfficeCollege"]);
            webname = objlogin.webSite;
            ViewState["codeId"] = objlogin.EmployeeId;
            id = objlogin.webSite;
            Session["Name"] = webname;
          



        }
       if (Page.IsPostBack == false)
        {
           


            VirtualPath = this.Page.AppRelativeVirtualPath;
            Session["virtualpath"] = VirtualPath;

            if (VirtualPath == "~/InstitutePanel/InnerUnivDetails.aspx")
            {
                ddlcountry.Visible = true;
                DropDownList1.Visible = true;
                bindEducationType12();
                ddl.Visible = true;
              
                ddlUniType.Visible = true;


            }

            else if (VirtualPath == "~/InstitutePanel/InnerCollege.aspx")
            {
                ddlcountry.Visible = true;
                DropDownList1.Visible = true;
                ddlUniType.Visible = true;
                ddl.Visible = false;
                Ddledu.Visible = true;
            }
            else if (VirtualPath == "~/InstitutePanel/InnerSchool.aspx")
            {
                ddlcountry.Visible = true;
                DropDownList1.Visible = true;
                ddlUniType.Visible = true;
                ddl.Visible = false;
                Ddledu.Visible = true;
            }
            else if (VirtualPath == "~/InstitutePanel/InnerInstitute.aspx")
            {
                ddlcountry.Visible = true;
                DropDownList1.Visible = true;

                ddl.Visible = false;
                Ddledu.Visible = true;

                ddlUniType.Visible = true;
            }


            else if (VirtualPath == "~/InstitutePanel/InnerTeacher.aspx")
            {
                ddlcountry.Visible = true;
                DropDownList1.Visible = true;

                ddl.Visible = false;
                Ddledu.Visible = true;

                ddlUniType.Visible = true;
            }

            else if (VirtualPath == "~/InstitutePanel/innerEducation.aspx")
            {
                //  ddlUniType.Visible = false;
                ddlcountry.Visible = true;
                ddlUniType.Visible = false;

                DropDownList1.Visible = false;

                ddl.Visible = false;
                ddlexam.Visible = true;
                ddlUniType.Visible = false;
                BindCountryBoard();
            }

            else if (VirtualPath == "~/InstitutePanel/innerExam.aspx")
            {
                ddlcountry.Visible = true;
                ddlUniType.Visible = false;

                DropDownList1.Visible = false;

                ddl.Visible = false;
                ddlexam.Visible = true;
                ddlUniType.Visible = false;
                BindCountryBoard();
            }
            else
            {
                ddlcountry.Visible = false;
                DropDownList1.Visible = false;

                ddl.Visible = false;

                ddlUniType.Visible = false;
            }
        }

  

        Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.Cache.SetNoStore();


        if (Page.IsPostBack == false)
        {

            if (Session["Index"] != null)
            {
                ddlcountry.SelectedIndex = (int)Session["Index"];
                bindState();
                bindUniType();
                bindEducationType12();
            }
            if (Session["Indexcity"] != null)
            {
                DropDownList1.SelectedIndex = (int)Session["Indexcity"];
                bindState();
                bindUniType();
            }
       
            if (Session["indexPrivate"]!=null)
            {
                ddl.SelectedIndex =(int)Session["indexPrivate"];
            }
            if (Session["indexType"] != null)
            {
                ddlUniType.SelectedIndex = (int)Session["indexType"];
            }
            binduniversity();
        }
          
    }
  private void bindEducationType12()
  {
      clsBLdropDown drp = new clsBLdropDown();
      clsPRPdropdown drpprp = new clsPRPdropdown();
      drpprp.controlList = ddlUniType;
      drpprp.spName = "viewEducationType";
      drp.bindDropDown(drpprp);
  }
    private void bindLogin()
    {
        objlogin = new prpLogin();
        if (Session["OfficeCollege"] != null)
        {
            objlogin = (prpLogin)(Session["OfficeCollege"]);
            if (objlogin.loginType == "3")
            {
                //   lblListing.Visible = false;
               // lnkUpdateProfile.PostBackUrl = "../InstitutePanel/updateInstituteFullProfile.aspx";
            }
           
            else
            {
                //  lblListing.Visible = true;
                if (objlogin.loginType == "4" || objlogin.loginType == "2")
                {
                   // lnkUpdateProfile.PostBackUrl = "../InstitutePanel/updateInstituteFullProfile.aspx";
                }
                else if(objlogin.loginType=="5" || objlogin.loginType=="6")
                {
                   // lnkUpdateProfile.PostBackUrl = "../InstitutePanel/UpdateTutorProfile.aspx";
                }
            }

        }
        else
        {
            Response.Redirect("../InstitutePanel/Default.aspx", false);
        }

    }
    protected void lkbmail_Click(object sender, EventArgs e)
    {
            
        
    }

    private string CheckCod()
    {

        objlogin = new prpLogin();
        if (Session["OfficeCollege"] != null)
        {
            objlogin = (prpLogin)(Session["OfficeCollege"]);
        }
        string str = Session["OfficeCollege"].ToString();
        clsBLSetupWeb obj = new clsBLSetupWeb();
        PRPSetupWeb objparm = new PRPSetupWeb();
        objparm.codeId = objlogin.EmployeeId;
        string st = obj.CheckMailStatus(objparm);
        return st;
    }
    protected void lnkWebsite_Click1(object sender, EventArgs e)
    {

       
    }
    protected void btnSubmit_Click1(object sender, EventArgs e)
    {
    
    }
    protected void btn1_Click(object sender, EventArgs e)
    {
        bindLogin();
    }
    private void binduniversity()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddlcountry;
        drpprp.spName = "viewCountry";
        drp.bindDropDown(drpprp);
       
        
    }
    protected void ddlcountry_SelectedIndexChanged(object sender, EventArgs e)
    { 
        string pageidwws = this.Page.ClientQueryString;
        name = this.Page.ClientQueryString;

        string VirtualPaths = this.Page.AppRelativeVirtualPath;

        if (ddlcountry.SelectedIndex != 0)
        {
            Session["Index"] = ddlcountry.SelectedIndex;
            Session["Indexcity"] = DropDownList1.SelectedIndex;
            if (ddlcountry.SelectedIndex == 0 || ddlcountry.SelectedIndex == -1)
            {
                cont = "All";

            }
            else
            {
                cont = ddlcountry.SelectedItem.ToString(); ;

            }
            if (DropDownList1.SelectedIndex == 0 || DropDownList1.SelectedIndex == -1)
            {
                state = "All";

            }
            else
            {
                state = DropDownList1.SelectedItem.ToString();
            }
            if (ddlUniType.SelectedIndex == 0 || ddlUniType.SelectedIndex == -1)
            {
                type = "All";

            }
            else
            {
                type = ddlUniType.SelectedItem.ToString();
            }
            if (ddl.SelectedIndex == 0 || ddl.SelectedIndex == -1)
            {
                edu = "All";
            }
            else
            {
                edu = ddl.SelectedItem.ToString();
            }
            Response.Redirect("~/UniversityInner/" + cont + "-" + state + "-" + type + "-" + edu);

            string pageidww = this.Page.ClientQueryString;
            name = this.Page.ClientQueryString;

            string VirtualPath = this.Page.AppRelativeVirtualPath;
            if (Session["virtualpath"] != null)
            {
                VirtualPath = Session["virtualpath"].ToString();
            }
             ids = ddlcountry.SelectedValue;
             Session["Index1"] = ddlcountry.SelectedValue;
             Session["Index"] = ddlcountry.SelectedIndex;
             bindState();
             if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/InstitutePanel/InnerUnivDetails.aspx")
            {

                //Response.Redirect("InnerTeacher.aspx?ContId=" + ddlcountry.SelectedValue);

                if (ddlcountry.SelectedIndex == 0 || ddlcountry.SelectedIndex == -1)
                {
                    cont = "All";

                }
                else
                {
                    cont = ddlcountry.SelectedItem.ToString(); ;

                }
                if (DropDownList1.SelectedIndex == 0 || DropDownList1.SelectedIndex == -1)
                {
                    state = "All";

                }
                else
                {
                    state = DropDownList1.SelectedItem.ToString();
                }
                if (ddlUniType.SelectedIndex == 0 || ddlUniType.SelectedIndex == -1)
                {
                    type = "All";

                }
                else
                {
                    type = ddlUniType.SelectedItem.ToString();
                }
                if (ddl.SelectedIndex == 0 || ddlUniType.SelectedIndex == -1)
                {
                    edu = "All";
                }
                else
                {
                    edu = ddl.SelectedItem.ToString();
                }
                Response.Redirect("~/UniversityInner/" + cont + "-" + state + "-" + type + "-" + edu);
            }
             else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/InstitutePanel/InnerCollege.aspx")
            {
                Response.Redirect("~/College1/" + ddlcountry.SelectedItem.Text + "/" + objlogin.EmployeeId + "");
            }
             else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/InstitutePanel/InnerSchool.aspx")
            {
                Response.Redirect("~/School1/" + ddlcountry.SelectedItem.Text + "/" + objlogin.EmployeeId + "");
            }
            else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/InstitutePanel/InnerInstitute.aspx")
            {
                Response.Redirect("~/Inst1/" + ddlcountry.SelectedItem.Text + "/" + objlogin.EmployeeId + "");
            }

            else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/InstitutePanel/InnerTeacher.aspx")
            {
                Response.Redirect("~/Teacher1/" + ddlcountry.SelectedItem.Text + "/" + objlogin.EmployeeId + "");
            }

            else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/SchoolDetails.aspx")
            {

                Response.Redirect("InstitutesMain.aspx?ContId=" + ids + "/" + DropDownList1.SelectedValue + "");
            }

            else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/TeacherDetails.aspx")
            {

                Response.Redirect("InstitutesMain.aspx?ContId=" + ids + "/" + DropDownList1.SelectedValue + "");
            }
            else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/ViewUniDetails.aspx")
            {

                Response.Redirect("InstitutesMain.aspx?ContId=" + ids + "/" + DropDownList1.SelectedValue + "");
            }
            else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/CollegeDetails.aspx")
            {

                Response.Redirect("InstitutesMain.aspx?ContId=" + ids + "/" + DropDownList1.SelectedValue + "");
            }
        }
    }
    private void bindUniType()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddl;
        drpprp.spName = "viewUniversityType";
        drp.bindDropDown(drpprp);
    }
    private void bindEducationType()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddl;
        drpprp.spName = "viewUniversityType";
        drp.bindDropDown(drpprp);
    }
    private void bindEducationType1()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = Ddledu;
        if (ddlcountry.SelectedIndex != 0 && ddlcountry.SelectedIndex == null)
            drpprp.id = Convert.ToInt32(ddlcountry.SelectedValue);
        drpprp.spName = "GetAllCategoryType";
        drp.bindDropDown(drpprp);
        // ddl.SelectedIndex = 1;
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Teacher/" + objlogin.EmployeeId + "");
    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Inst/" + objlogin.EmployeeId + "");
    }

    protected void LinkButton3_Click(object sender, EventArgs e)
    {
      Response.Redirect("~/College/" + objlogin.EmployeeId + "");
    }

    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/School/" + objlogin.EmployeeId + "");
    }

    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Univ/" + objlogin.EmployeeId + "");
    }

    public void BindCountryBoard()
    {

        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand("TitleCareerListExam", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] paramsToStore =
           new SqlParameter[4];
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds2);
        ddlexam.DataSource = ds2;
        ddlexam.DataValueField = "newsTypeID";
        ddlexam.DataTextField = "newsType";
        ddlexam.DataBind();
    }

    private void bindState()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = DropDownList1;
        if (ids == "")
        {
            drpprp.id = 0;
        
        }
        else
        {
            drpprp.id = Convert.ToInt32(ids);
        
        }
        drpprp.spName = "viewState";
        drp.bindDropDown(drpprp);
    }

    public void BindSubCategory()
    {
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand("crsViewAllSubCategory", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] paramsToStore =
           new SqlParameter[4];
        paramsToStore[0] = new SqlParameter("@id", SqlDbType.NVarChar);
        paramsToStore[0].Size = 20;
        cmd.Parameters.Add(paramsToStore[0]).Value = ddl.SelectedValue;
        paramsToStore[1] = new SqlParameter("@Type", SqlDbType.NVarChar);
        paramsToStore[1].Size = 100;
        cmd.Parameters.Add(paramsToStore[1]).Value = ddlcountry.SelectedValue;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds3);
        ddlUniType.DataSource = ds3;
        ddlUniType.DataValueField = "id";
        ddlUniType.DataTextField = "name";
        ddlUniType.DataBind();
    }

    protected void ddl_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (Session["virtualpath"] != null)
        {
            VirtualPath = Session["virtualpath"].ToString();
        }
        Session["indexPrivate"] = ddl.SelectedIndex;
        Session["indexType"] = ddlUniType.SelectedIndex;
         if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/InstitutePanel/InnerUnivDetails.aspx")
            {
                if (ddlcountry.SelectedIndex == 0 || ddlcountry.SelectedIndex == -1)
                {
                    cont = "All";
                }
                else
                {
                    cont = ddlcountry.SelectedItem.ToString(); ;
                }
                if (DropDownList1.SelectedIndex == 0 || DropDownList1.SelectedIndex == -1)
                {
                    state = "All";
                }
                else
                {
                    state = DropDownList1.SelectedItem.ToString();
                }
                if (ddlUniType.SelectedIndex == 0 || ddlUniType.SelectedIndex == -1)
                {
                    type = "All";
                }
                else
                {
                    type = ddlUniType.SelectedItem.ToString();
                }
                if (ddl.SelectedIndex == 0 || ddlUniType.SelectedIndex == -1)
                {
                    edu = "All";
                }
                else
                {
                    edu = ddl.SelectedItem.ToString();
                }
                Response.Redirect("~/UniversityInner/" + cont + "-" + state + "-" + type + "-" + edu);
            }
             else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/InstitutePanel/InnerCollege.aspx")
            {
                Response.Redirect("~/College1/" + ddlcountry.SelectedItem.Text + "/" + objlogin.EmployeeId + "");
            }
             else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/InstitutePanel/InnerSchool.aspx")
            {
                Response.Redirect("~/School1/" + ddlcountry.SelectedItem.Text + "/" + objlogin.EmployeeId + "");
            }
            else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/InstitutePanel/InnerInstitute.aspx")
            {
                Response.Redirect("~/Inst1/" + ddlcountry.SelectedItem.Text + "/" + objlogin.EmployeeId + "");
            }

            else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/InstitutePanel/InnerTeacher.aspx")
            {
                Response.Redirect("~/Teacher1/" + ddlcountry.SelectedItem.Text + "/" + objlogin.EmployeeId + "");
            }

            else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/SchoolDetails.aspx")
            {
                 Response.Redirect("InstitutesMain.aspx?ContId=" + ids + "/" + DropDownList1.SelectedValue + "");
            }

            else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/TeacherDetails.aspx")
            {

                Response.Redirect("InstitutesMain.aspx?ContId=" + ids + "/" + DropDownList1.SelectedValue + "");
            }
            else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/ViewUniDetails.aspx")
            {

                Response.Redirect("InstitutesMain.aspx?ContId=" + ids + "/" + DropDownList1.SelectedValue + "");
            }
            else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/CollegeDetails.aspx")
            {

                Response.Redirect("InstitutesMain.aspx?ContId=" + ids + "/" + DropDownList1.SelectedValue + "");
            }
        

    }

    protected void Ddledu_SelectedIndexChanged(object sender, EventArgs e)
    {
        string VirtualPath = this.Page.AppRelativeVirtualPath;
        if (Session["virtualpath"] != null)
        {
            VirtualPath = Session["virtualpath"].ToString();
        }
        Session["Index"] = ddlcountry.SelectedIndex;
        Session["Index1"] = DropDownList1.SelectedValue;
        Session["Indexcity"] = DropDownList1.SelectedIndex;
        Session["Indexcity1"] = DropDownList1.SelectedValue;
        Session["indexPrivate"] = ddl.SelectedIndex;
        Session["indexType"] = ddlUniType.SelectedIndex;
        int iid = Convert.ToInt32(Session["Indexcity"]);
        Session["CityName"] = DropDownList1.SelectedItem.Text;
        string CityName = Convert.ToString(Session["CityName"]);
        // bindState();

        if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/InstitutePanel/InnerUnivDetails.aspx")
        {
            string cont = "";
            string state = "";
            string type = "";
            string edu = "";
            if (ddlcountry.SelectedIndex == 0 || ddlcountry.SelectedIndex == -1)
            {
                cont = "All";

            }
            else
            {
                cont = ddlcountry.SelectedItem.ToString(); ;

            }
            if (DropDownList1.SelectedIndex == 0 || DropDownList1.SelectedIndex == -1)
            {
                state = "All";

            }
            else
            {
                state = DropDownList1.SelectedItem.ToString();
            }
            if (ddlUniType.SelectedIndex == 0 || ddlUniType.SelectedIndex == -1)
            {
                type = "All";

            }
            else
            {
                type = ddlUniType.SelectedItem.ToString();
            }
            if (ddl.SelectedIndex == 0 || ddlUniType.SelectedIndex == -1)
            {
                edu = "All";
            }
            else
            {
                edu = ddl.SelectedItem.ToString();
            }
            Response.Redirect("~/UniversityInner/" + cont + "-" + state + "-" + type + "-" + edu);
            Response.Redirect(((DropDownList)sender).SelectedValue);
        }

        else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/InstitutePanel/InnerCollege.aspx")
        {

            Response.Redirect("InnerCollege.aspx?ContId=" + ddlcountry.SelectedValue + "/" + iid + "");
        }

        else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/InstitutePanel/InnerSchool.aspx")
        {

            Response.Redirect("InnerSchool.aspx?ContId=" + ddlcountry.SelectedValue + "/" + iid + "");
        }

        else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/InstitutePanel/InnerInstitute.aspx")
        {

            Response.Redirect("InnerInstitute.aspx?ContId=" + ddlcountry.SelectedValue + "/" + iid + "");
        }

        if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/InstitutePanel/InnerTeacher.aspx")
        {
            Response.Redirect("~/Teacher1/" + ddlcountry.SelectedItem.Text + "/" + objlogin.EmployeeId + "");
        }

        else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/SchoolDetails.aspx")
        {

            Response.Redirect("InstitutesMain.aspx?ContId=" + ddlcountry.SelectedValue + "/" + iid + "");
        }

        else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/TeacherDetails.aspx")
        {

            Response.Redirect("InstitutesMain.aspx?ContId=" + ddlcountry.SelectedValue + "/" + iid + "");
        }
        else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/ViewUniDetails.aspx")
        {

            Response.Redirect("InstitutesMain.aspx?ContId=" + ddlcountry.SelectedValue + "/" + iid + "");
        }
        else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/CollegeDetails.aspx")
        {

            Response.Redirect("InstitutesMain.aspx?ContId=" + ddlcountry.SelectedValue + "/" + iid + "");
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string VirtualPath = this.Page.AppRelativeVirtualPath;
        Session["Index"] = ddlcountry.SelectedIndex;
        Session["Index1"] = DropDownList1.SelectedValue;
        Session["Indexcity"] = DropDownList1.SelectedIndex;
        Session["Indexcity1"] = DropDownList1.SelectedValue;
        Session["indexPrivate"] = ddl.SelectedIndex;
        Session["indexType"] = ddlUniType.SelectedIndex;
        int iid = Convert.ToInt32(Session["Indexcity"]);
        Session["CityName"] = DropDownList1.SelectedItem.Text;
        string CityName = Convert.ToString(Session["CityName"]);
       // bindState();
        if (Session["virtualpath"] != null)
        {
            VirtualPath = Session["virtualpath"].ToString();
        }
        if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/InstitutePanel/InnerUnivDetails.aspx")
        {
  string cont = "";
            string state = "";
            string type = "";
            string edu = "";
            if (ddlcountry.SelectedIndex == 0 || ddlcountry.SelectedIndex == -1)
            {
                cont = "All";

            }
            else
            {
                cont = ddlcountry.SelectedItem.ToString(); ;

            }
            if (DropDownList1.SelectedIndex == 0 || DropDownList1.SelectedIndex == -1)
            {
                state = "All";

            }
            else
            {
                state = DropDownList1.SelectedItem.ToString();
            }
            if (ddlUniType.SelectedIndex == 0 || ddlUniType.SelectedIndex == -1)
            {
                type = "All";

            }
            else
            {
                type = ddlUniType.SelectedItem.ToString();
            }
            if (ddl.SelectedIndex == 0 || ddlUniType.SelectedIndex == -1)
            {
                edu = "All";
            }
            else
            {
                edu = ddl.SelectedItem.ToString();
            }
            Response.Redirect("~/UniversityInner/" + cont + "-" + state + "-" + type + "-" + edu);
            Response.Redirect(((DropDownList)sender).SelectedValue);
        }
      
        else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/InstitutePanel/InnerCollege.aspx")
        {

            Response.Redirect("InnerCollege.aspx?ContId=" + ddlcountry.SelectedValue + "/" + iid + "");
        }

        else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/InstitutePanel/InnerSchool.aspx")
        {

            Response.Redirect("InnerSchool.aspx?ContId=" + ddlcountry.SelectedValue + "/" + iid + "");
        }

        else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/InstitutePanel/InnerInstitute.aspx")
        {

            Response.Redirect("InnerInstitute.aspx?ContId=" + ddlcountry.SelectedValue + "/" + iid + "");
        }

        if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/InstitutePanel/InnerTeacher.aspx")
        {
            Response.Redirect("~/Teacher1/" + ddlcountry.SelectedItem.Text + "/" + objlogin.EmployeeId + "");
        }

        else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/SchoolDetails.aspx")
        {

            Response.Redirect("InstitutesMain.aspx?ContId=" + ddlcountry.SelectedValue + "/" + iid + "");
        }

        else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/TeacherDetails.aspx")
        {

            Response.Redirect("InstitutesMain.aspx?ContId=" + ddlcountry.SelectedValue + "/" + iid + "");
        }
        else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/ViewUniDetails.aspx")
        {

            Response.Redirect("InstitutesMain.aspx?ContId=" + ddlcountry.SelectedValue + "/" + iid + "");
        }
        else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/CollegeDetails.aspx")
        {

            Response.Redirect("InstitutesMain.aspx?ContId=" + ddlcountry.SelectedValue + "/" + iid + "");
        }
    }
    protected void ddlUniType_SelectedIndexChanged(object sender, EventArgs e)
    {
        string VirtualPath = this.Page.AppRelativeVirtualPath;
        Session["Index"] = ddlcountry.SelectedIndex;
        Session["Index1"] = DropDownList1.SelectedValue;
        Session["Indexcity"] = DropDownList1.SelectedIndex;
        Session["Indexcity1"] = DropDownList1.SelectedValue;
        Session["indexPrivate"] = ddl.SelectedIndex;
        Session["indexType"] = ddlUniType.SelectedIndex;
        int iid = Convert.ToInt32(Session["Indexcity"]);
        Session["CityName"] = DropDownList1.SelectedItem.Text;
        string CityName = Convert.ToString(Session["CityName"]);
        // bindState();
        if (Session["virtualpath"] != null)
        {
            VirtualPath = Session["virtualpath"].ToString();
        }
        if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/InstitutePanel/InnerUnivDetails.aspx")
        {
            string cont = "";
            string state = "";
            string type = "";
            string edu = "";
            if (ddlcountry.SelectedIndex == 0 || ddlcountry.SelectedIndex == -1)
            {
                cont = "All";

            }
            else
            {
                cont = ddlcountry.SelectedItem.ToString(); ;

            }
            if (DropDownList1.SelectedIndex == 0 || DropDownList1.SelectedIndex == -1)
            {
                state = "All";

            }
            else
            {
                state = DropDownList1.SelectedItem.ToString();
            }
            if (ddlUniType.SelectedIndex == 0 || ddlUniType.SelectedIndex == -1)
            {
                type = "All";

            }
            else
            {
                type = ddlUniType.SelectedItem.ToString();
            }
            if (ddl.SelectedIndex == 0 || ddlUniType.SelectedIndex == -1)
            {
                edu = "All";
            }
            else
            {
                edu = ddl.SelectedItem.ToString();
            }
            Response.Redirect("~/UniversityInner/" + cont + "-" + state + "-" + type + "-" + edu);
            Response.Redirect(((DropDownList)sender).SelectedValue);
        }
       
        else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/InstitutePanel/InnerCollege.aspx")
        {

            Response.Redirect("InnerCollege.aspx?ContId=" + ddlcountry.SelectedValue + "/" + iid + "");
        }

        else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/InstitutePanel/InnerSchool.aspx")
        {

            Response.Redirect("InnerSchool.aspx?ContId=" + ddlcountry.SelectedValue + "/" + iid + "");
        }

        else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/InstitutePanel/InnerInstitute.aspx")
        {

            Response.Redirect("InnerInstitute.aspx?ContId=" + ddlcountry.SelectedValue + "/" + iid + "");
        }

        if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/InstitutePanel/InnerTeacher.aspx")
        {
            Response.Redirect("~/Teacher1/" + ddlcountry.SelectedItem.Text + "/" + objlogin.EmployeeId + "");
        }

        else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/SchoolDetails.aspx")
        {

            Response.Redirect("InstitutesMain.aspx?ContId=" + ddlcountry.SelectedValue + "/" + iid + "");
        }

        else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/TeacherDetails.aspx")
        {

            Response.Redirect("InstitutesMain.aspx?ContId=" + ddlcountry.SelectedValue + "/" + iid + "");
        }
        else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/ViewUniDetails.aspx")
        {

            Response.Redirect("InstitutesMain.aspx?ContId=" + ddlcountry.SelectedValue + "/" + iid + "");
        }
        else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/CollegeDetails.aspx")
        {

            Response.Redirect("InstitutesMain.aspx?ContId=" + ddlcountry.SelectedValue + "/" + iid + "");
        }
    }
}

