using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.Collections.Generic;
using nmsProfile;
using nmsSetup;
using nmsDropDown;
using nmsView;
using nmsSetupWeb;
using nmsOffice;
using System.Data.SqlClient;

public partial class InstitutePanel_Home : System.Web.UI.MasterPage
{
    prpLogin objlogin;

    clsBLSetup obj;
    clsBLview objview;
    PRPSetup objprp, objparm;

    clsBLprofile obj1;
    prpLogin prppram, prplogin;
    string UniNames = "";
    string strcon = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
    String MaxId = "";

    static String Images = "";

    string name = "";
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        string VirtualPath = this.Page.AppRelativeVirtualPath;
        if (VirtualPath == "~/InstitutePanel/InnerUnivDetails.aspx")
        {
            ddlcountry.Visible = true;
            DropDownList1.Visible = true;
            ddl.Visible = true;
            ddlUniType.Visible = true;

        }

        else if (VirtualPath == "~/InstitutePanel/InnerCollege.aspx")
        {
            ddlcountry.Visible = true;
            DropDownList1.Visible = true;

            ddl.Visible = true;

            ddlUniType.Visible = true;
        }
        else if (VirtualPath == "~/InstitutePanel/InnerSchool.aspx")
        {
            ddlcountry.Visible = true;
            DropDownList1.Visible = true;

            ddl.Visible = true;

            ddlUniType.Visible = true;
        }
        else if (VirtualPath == "~/InstitutePanel/InnerInstitute.aspx")
        {
            ddlcountry.Visible = true;
            DropDownList1.Visible = true;

            ddl.Visible = true;

            ddlUniType.Visible = true;
        }


        else if (VirtualPath == "~/InstitutePanel/InnerTeacher.aspx")
        {
            ddlcountry.Visible = true;
            DropDownList1.Visible = true;

            ddl.Visible = true;

            ddlUniType.Visible = true;
        }
        else
        {
            ddlcountry.Visible = false;
            DropDownList1.Visible = false;

            ddl.Visible = false;

            ddlUniType.Visible = false;
        }

        Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.Cache.SetNoStore();


        if (Page.IsPostBack == false)
        {
            bindLogin();
            getNews();
            binduniversity();
            bindUNIstate();
            bindUniType();
            bindEducationType();


        }
    }

    public void getNews()
    {
        obj = new clsBLSetup();
        objprp = new PRPSetup();
        objprp.catID = "77";
        objprp.uniID = "7";
        List<PRPSetup> lst1 = new List<PRPSetup>();
    }
    private void bindLogin()
    {
        objlogin = new prpLogin();
        if (Session["OfficeCollege"] != null)
        {
            objlogin = (prpLogin)(Session["OfficeCollege"]);
            imglogo.ImageUrl = objlogin.urlPath;
            litName.Text = objlogin.employeeName;
        }
        else
        {
            imglogo.ImageUrl = "../Advertisement/tutor.png";
        }

    }
    private void ViewStatus()
    {
        clsBLSetupWeb objs = new clsBLSetupWeb();
        PRPSetupWeb objparm = new PRPSetupWeb();

        DataSet dt = new DataSet();

        objlogin = new prpLogin();
        if (Session["OfficeCollege"] != null)
        {
            objlogin = (prpLogin)(Session["OfficeCollege"]);

            objparm.uniID = objlogin.loginType;
            objparm.codeId = objlogin.EmployeeId;
            dt = objs.ViewWebsiteStatus(objparm);
            if (dt.Tables[0].Rows.Count > 0)
            {
                lblViewed.Text = dt.Tables[0].Rows[0][2].ToString();

                lblApplied.Text = dt.Tables[0].Rows[0][1].ToString();
            }
            else
            {
                lblViewed.Text = "0"; //dt.Tables[0].Rows[1][0].ToString();

                lblApplied.Text = "0"; //dt.Tables[0].Rows[0][0].ToString();
            }
        }
    }

    private void checkFileUploadedPath()
    {
        clsDLSetup objprm = new clsDLSetup();
        clsBLSetup obj = new clsBLSetup();
        MaxId = obj.GetMaxFileId();
    }

    private void Imageupload()
    {
        string imagename = "", imagepath = "", serverpath = "";
        Int32 value = 0;

        if (FileUpload1.HasFile)
        {



            int Siz = FileUpload1.PostedFile.ContentLength;
            double size = (Siz) / 1024.00;


            if (size > 50)
            {
                Images = "Please Select Correct Size!";
            }
            else
            {
                imagename = FileUpload1.FileName;

                checkFileUploadedPath();

                imagepath = "../CollegeImage/" + MaxId + FileUpload1.FileName;
                serverpath = Server.MapPath(imagepath);
                FileUpload1.SaveAs(serverpath);
                Images = imagepath;

            }
        }
        else
        {
            Images = Images;
        }

    }
    private void updateImage()
    {
        string st;
        PRPOffice objprp = new PRPOffice();
        BLoffice bl = new BLoffice();


        Imageupload();

        if (Images != "Please Select Correct Size!")
        {

            if (Session["OfficeCollege"] != null)
            {
                prplogin = (prpLogin)(Session["OfficeCollege"]);
            }

            objprp.urlId = prplogin.EmployeeId;
            objprp.urlPath = Images;

            st = bl.updateLogoImage(objprp);
            if (st == "Succssfully Updated..")
            {

                imglogo.ImageUrl = Images;
            }
        }
        else
        {
            lblMsg.Text = "Size should not be more than 50 kb";
            LinkButton2_ModalPopupExtender.Show();
        }
    }

    protected void btupload_Click(object sender, EventArgs e)
    {
        try
        {
            updateImage();
        }

        catch (Exception ex)
        {
            
        }
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
            string pageidww = this.Page.ClientQueryString;
            name = this.Page.ClientQueryString;

            string VirtualPath = this.Page.AppRelativeVirtualPath;



            if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/InstitutePanel/InnerUnivDetails.aspx")
            {
                Response.Redirect("InnerUnivDetails.aspx?ContId=" + ddlcountry.SelectedValue);
            }

            else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/InstitutePanel/InnerCollege.aspx")
            {

                Response.Redirect("InnerCollege.aspx?ContId=" + ddlcountry.SelectedValue);
            }

            else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/InstitutePanel/InnerSchool.aspx")
            {

                Response.Redirect("InnerSchool.aspx?ContId=" + ddlcountry.SelectedValue);
            }

            else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/InstitutePanel/InnerInstitute.aspx")
            {

                Response.Redirect("InnerInstitute.aspx?ContId=" + ddlcountry.SelectedValue);
            }

            else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/InstitutePanel/InnerTeacher.aspx")
            {

                Response.Redirect("InnerTeacher.aspx?ContId=" + ddlcountry.SelectedValue);
            }

            else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/SchoolDetails.aspx")
            {

                Response.Redirect("InstitutesMain.aspx?ContId=" + ddlcountry.SelectedValue);
            }

            else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/TeacherDetails.aspx")
            {

                Response.Redirect("InstitutesMain.aspx?ContId=" + ddlcountry.SelectedValue);
            }
            else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/ViewUniDetails.aspx")
            {

                Response.Redirect("InstitutesMain.aspx?ContId=" + ddlcountry.SelectedValue);
            }
            else if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/CollegeDetails.aspx")
            {

                Response.Redirect("InstitutesMain.aspx?ContId=" + ddlcountry.SelectedValue);
            }
        }


    }
    private void bindUniType()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddlUniType;
        drpprp.spName = "viewUniversityType";
        drp.bindDropDown(drpprp);
        //ddlUniType.SelectedIndex = 1;
    }

    private void bindEducationType()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddl;
        drpprp.spName = "viewEducationType";
        drp.bindDropDown(drpprp);
        // ddl.SelectedIndex = 1;
    }

    public void bindUNIstate()
    {
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand("viewState", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] paramsToStore =
           new SqlParameter[4];
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        DropDownList1.DataSource = ds;
        DropDownList1.DataValueField = "id";
        DropDownList1.DataTextField = "name";
        DropDownList1.DataBind();
    }

}