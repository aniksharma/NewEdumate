using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using nmsSetupI;
using nmsDropDownI;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Web.Services;
using st;
public partial class UserControl_MiddleControl : System.Web.UI.UserControl
{
    clsBLSetup obj;
    PRPSetup objprp, objparm;
    static string Id = "";
    string strcon = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
    string name = "";
    string UniNames = "";
    DataSet dsImage = new DataSet();
    DataSet ds2 = new DataSet();
    DataSet ds3 = new DataSet();
    DataSet ds7 = new DataSet();
    PRPSetup prppram;
    PRPSetup prp;
    clsBLSetup bl;
    protected int TotalCount;
    protected DataSet ds = new DataSet();
    protected DataSet ds5 = new DataSet();
    protected DataSet ds6 = new DataSet();
    string VirtualPathes = "";
    string Schoolid = "";
    string catType = "";
    string type = "";
    string code = "";
    protected void Page_Load(object sender, EventArgs e)
    {

        string pageID = this.Page.ID;
        string pageIDs = this.Page.ClientID;

        string pageidww = this.Page.ClientQueryString;
        name = this.Page.ClientQueryString;
       

        if (Page.IsPostBack == false)
        {
            // bindUNIstate();
            binduniversity();
            // bindUniType();
            //  bindEducationType();
            //  bindState();
            VirtualPathes = this.Page.AppRelativeVirtualPath;
            if (VirtualPathes == "~/EducationBoard.aspx")
            {
                ddl.Visible = false;
                ddlUniType.Visible = true;
                ddlstate1.Visible = false;
                ddlexam.Visible = false;
                //BindCountryBoard();
                bindEducationType();
            }

            else if (VirtualPathes == "~/EntranceExam.aspx")
            {
                // ddlUniType.Visible = false;
                ddl.Visible = false;
                ddlUniType.Visible = false;
                ddlstate1.Visible = false;
                BindCountryBoard();
            }

            // SelectDatail(1);

            // BindImage();


            if (name == "name=Uni")
            {
                if (ddlcountry.SelectedValue == "0")
                {


                    SelectDatail(1);
                    // bindUniType();
                    ddl.Visible = true;
                    college.Visible = false;
                    Univ.Visible = true;
                    ddlexam.Visible = false;
                    ddlstate1.Visible = true;
                    ddl.Visible = true;
                    ddlUniType.Visible = true;
                    // bindState();
                    ddlstate1.Items.Insert(0, "--Select State--");
                    bindUniType();
                    bindEducationType();


                    if (Session["Indexcity"] != null)
                    {
                        ddlstate1.SelectedIndex = (int)Session["Indexcity"];
                        // bindState();
                        //  bindUniType();
                        // bindEducationType1();
                    }



                }
                else
                {
                    SelectDatail(1);
                    bindState();
                    bindUniType();
                    bindEducationType();

                    //SelectDatail(1);
                    college.Visible = false;
                    Univ.Visible = true;
                    ddlexam.Visible = false;
                }

            }
            else if (name == "name=College")
            {
                Schoolid = "4";
                catType = "2";
                ddlstate1.Items.Insert(0, "--Select State--");
                //   bindState();
                bindcategory();
                ddlUniType.Items.Insert(0, "--Select Sub Category--");
                //BindSubCategory();
                ddl.Visible = true;
                ddlUniType.Visible = true;
                ddlstate1.Visible = true;
                college.Visible = true;
                ddlexam.Visible = false;
                SelectDatailnew(1);
                Univ.Visible = false;
            }

            else if (name == "name=School")
            {
                Schoolid = "3";
                catType = "3";
                ddlstate1.Items.Insert(0, "--Select State--");
                //   bindState();
                bindcategory();
                ddlUniType.Items.Insert(0, "--Select Sub Category--");
                //BindSubCategory();
                ddl.Visible = true;
                ddlUniType.Visible = false;
                ddlstate1.Visible = true;
                college.Visible = true;
                ddlexam.Visible = false;
                SelectDatailnew(1);
                Univ.Visible = false;
            }
            else if (name == "name=Inst")
            {
                Schoolid = "2";
                catType = "4";
                ddlstate1.Items.Insert(0, "--Select State--");
                //   bindState();
                bindcategory();
                ddlUniType.Items.Insert(0, "--Select Sub Category--");
                //BindSubCategory();
                ddl.Visible = true;
                ddlUniType.Visible = true;
                ddlstate1.Visible = true;
                college.Visible = true;
                ddlexam.Visible = false;
                SelectDatailnew(1);
                Univ.Visible = false;
            }
            else if (name == "name=Teacher")
            {
                Schoolid = "5";
                catType = "5";
                ddlstate1.Items.Insert(0, "--Select State--");
                //   bindState();
                bindcategory();
                ddlUniType.Items.Insert(0, "--Select Sub Category--");
                //BindSubCategory();
                ddl.Visible = true;
                ddlUniType.Visible = false;
                ddlstate1.Visible = true;
                college.Visible = true;
                ddlexam.Visible = false;
                SelectTeacherDatail(1);
                Univ.Visible = false;
            }



            string VirtualPath = this.Page.AppRelativeVirtualPath;

            if (VirtualPath == "~/ViewUniDetails.aspx")
            {
                college.Visible = false;
                ddlexam.Visible = false;
                ddlcountry.Visible = false;
                ddlNopage.Visible = false;
                ddlstate1.Visible = false;
                ddlUniType.Visible = false;
                ddl.Visible = false;
                btn.Visible = false;

            }

            else if (VirtualPath == "~/CollegeDetails.aspx")
            {
                college.Visible = false;
                ddlexam.Visible = false;
                ddlcountry.Visible = false;
                ddlNopage.Visible = false;
                ddlstate1.Visible = false;
                ddlUniType.Visible = false;
                ddl.Visible = false;
                btn.Visible = false;

            }
            else if (VirtualPath == "~/TeacherDetails.aspx")
            {
                college.Visible = false;
                ddlexam.Visible = false;
                ddlcountry.Visible = false;
                ddlNopage.Visible = false;
                ddlstate1.Visible = false;
                ddlUniType.Visible = false;
                ddl.Visible = false;
                btn.Visible = false;

            }


            else if (VirtualPath == "~/SchoolDetails.aspx")
            {
                college.Visible = false;
                ddlexam.Visible = false;
                ddlcountry.Visible = false;
                ddlNopage.Visible = false;
                ddlstate1.Visible = false;
                ddlUniType.Visible = false;
                ddl.Visible = false;
                btn.Visible = false;

            }

            else if (VirtualPath == "~/InsDetails.aspx")
            {
                college.Visible = false;
                ddlexam.Visible = false;
                ddlcountry.Visible = false;
                ddlNopage.Visible = false;
                ddlstate1.Visible = false;
                ddlUniType.Visible = false;
                ddl.Visible = false;
                btn.Visible = false;

            }
        }



    }

    private void binduniversity()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddlcountry;
        drpprp.spName = "viewCountry";
        ststics1.ddlname = "Country";
        drp.bindDropDown(drpprp);
        //ddlcountry.SelectedIndex = 1;
    }

    //public void BindCountry()
    //{
    //    SqlConnection con = new SqlConnection(strcon);
    //    SqlCommand cmd = new SqlCommand("viewCountryDetails", con);
    //    cmd.CommandType = CommandType.StoredProcedure;
    //    SqlParameter[] paramsToStore =
    //       new SqlParameter[4];


    //    SqlDataAdapter da = new SqlDataAdapter(cmd);
    //    da.Fill(dsImage);
    //    ddlcountry.DataSource = dsImage;
    //    ddlcountry.DataValueField = "Id";
    //    ddlcountry.DataTextField = "name";
    //    ddlcountry.DataBind();



    //}


    protected void ddlcountry_SelectedIndexChanged(object sender, EventArgs e)
    {



        string pageidwws = this.Page.ClientQueryString;
        name = this.Page.ClientQueryString;

        string VirtualPaths = this.Page.AppRelativeVirtualPath;
        if (name == "name=Uni")
        {
            bindState();
            SelectDatail(1);
            bindUniType();
            college.Visible = false;
            Univ.Visible = true;
            ddlexam.Visible = false;
            ddlstate1.Visible = true;
            ddl.Visible = true;
            ddlUniType.Visible = true;



        }
        else if (name == "name=College")
        {
            bindState();
            Schoolid = "4";
            SelectDatailnew(1);
            bindcategory();
            college.Visible = true;
            ddlstate1.Visible = true;
            Univ.Visible = false;
        }

        else if (name == "name=School")
        {
            bindState();
            Schoolid = "3";
            SelectDatailnew(1);
            college.Visible = true;
            ddlstate1.Visible = true;
            Univ.Visible = false;
        }
        else if (name == "name=Inst")
        {
            bindState();
            Schoolid = "2";
            SelectDatailnew(1);
            college.Visible = true;
            ddlstate1.Visible = true;
            Univ.Visible = false;
        }
        else if (name == "name=Teacher")
        {
            bindState();
            Schoolid = "5";
            SelectTeacherDatail(1);
            college.Visible = true;
            ddlstate1.Visible = true;
            Univ.Visible = false;
        }

        // BindCountry();
        //string id = ddlcountry.SelectedValue;
        //string ss = this.ddlcountry.SelectedValue;



        if (VirtualPathes == "~/EntranceExam.aspx")
        {

            Response.Redirect("EntranceExam.aspx?ContId=" + ddlcountry.SelectedValue);
        }

    

    }

    private void bindState()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddlstate1;
        if (ddlcountry.SelectedIndex != 0)
            drpprp.id = Convert.ToInt32(ddlcountry.SelectedValue);
        drpprp.spName = "viewState";
        ststics1.ddlname = "State";
        drp.bindDropDown(drpprp);
        //ddlstate.SelectedIndex = 1;
    }

    protected void ddl_SelectedIndexChanged(object sender, EventArgs e)
    {

        if (name == "name=Uni")
        {

            //  BindSubCategory();
            // bindUniType();
            SelectDatail(1);
            ddlstate1.Visible = true;
            ddl.Visible = true;
            ddlUniType.Visible = true;

        }

        else if (name == "name=College")
        {
            Schoolid = "4";
            //  bindcategory();
            BindSubCategory();
            SelectDatailnew(1);
            college.Visible = true;

            Univ.Visible = false;
        }


        else
        {
            bindEducationType();
        }



    }

    //private void bindUniType()
    //{
    //    clsBLdropDown drp = new clsBLdropDown();
    //    clsPRPdropdown drpprp = new clsPRPdropdown();
    //    drpprp.controlList = ddlUniType;
    //    drpprp.spName = "viewUniversityType";
    //    drp.bindDropDown(drpprp);
    //   //ddlUniType.SelectedIndex = 1;
    //}


    private void bindUniType()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddl;
        drpprp.spName = "viewUniversityType";
        ststics1.ddlname = "University Type";
        drp.bindDropDown(drpprp);
        //ddlUniType.SelectedIndex = 1;
    }

    private void bindEducationType()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddlUniType;
        drpprp.spName = "viewEducationType";
        ststics1.ddlname = "Education Type";
        drp.bindDropDown(drpprp);
        ddl.SelectedIndex = 1;
    }
    public void bindUNIstate()
    {



        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand("viewCountry", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] paramsToStore =
           new SqlParameter[4];
        //paramsToStore[0] = new SqlParameter("@id", SqlDbType.NVarChar);
        //paramsToStore[0].Size = 20;
        //cmd.Parameters.Add(paramsToStore[0]).Value = ddlcountry.SelectedValue ;
        //paramsToStore[1] = new SqlParameter("@class", SqlDbType.NVarChar);
        //paramsToStore[1].Size = 100;
        //cmd.Parameters.Add(paramsToStore[1]).Value = service_id;
        //paramsToStore[2] = new SqlParameter("@topic", SqlDbType.VarChar);
        //paramsToStore[2].Size = 60;
        //cmd.Parameters.Add(paramsToStore[2]).Value = ddlChapter.SelectedValue.ToString();




        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds7);
        DropDownList1.DataSource = ds7;
        DropDownList1.DataValueField = "id";
        DropDownList1.DataTextField = "name";
        DropDownList1.DataBind();


    }
    public void bindcategory()
    {

        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand("GetAllCategoryType", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] paramsToStore =
           new SqlParameter[4];
        paramsToStore[0] = new SqlParameter("@catType", SqlDbType.NVarChar);
        paramsToStore[0].Size = 20;
        cmd.Parameters.Add(paramsToStore[0]).Value = catType;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds7);
        ddl.DataSource = ds7;
        ddl.DataValueField = "id";
        ddl.DataTextField = "name";
        ddl.DataBind();

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
        //paramsToStore[2] = new SqlParameter("@topic", SqlDbType.VarChar);
        //paramsToStore[2].Size = 60;
        //cmd.Parameters.Add(paramsToStore[2]).Value = ddlChapter.SelectedValue.ToString();




        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds3);
        ddlUniType.DataSource = ds3;
        ddlUniType.DataValueField = "id";
        ddlUniType.DataTextField = "name";
        ddlUniType.DataBind();
        ddlUniType.Items.Insert(0, "--Select --");


    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

        // bindstate11();
    }

    protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
    {
        // bindstate11();


        //    string pageidww = this.Page.ClientQueryString;
        //    name = this.Page.ClientQueryString;

        //    string VirtualPath = this.Page.AppRelativeVirtualPath;

        //    //if (DropDownList1.SelectedValue != "0" && VirtualPath == "~/UniversityMain.aspx")
        //    //{
        //    //    // bindState();
        //    //    Response.Redirect("UniversityMain.aspx?ContId=" + DropDownList1.SelectedValue);
        //    //}
    }

    public void bindstate11()
    {



        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand("viewStatenew", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] paramsToStore =
           new SqlParameter[4];
        paramsToStore[0] = new SqlParameter("@id", SqlDbType.NVarChar);
        paramsToStore[0].Size = 20;
        cmd.Parameters.Add(paramsToStore[0]).Value = ddlcountry.SelectedValue;
        //paramsToStore[1] = new SqlParameter("@class", SqlDbType.NVarChar);
        //paramsToStore[1].Size = 100;
        //cmd.Parameters.Add(paramsToStore[1]).Value = service_id;
        //paramsToStore[2] = new SqlParameter("@topic", SqlDbType.VarChar);
        //paramsToStore[2].Size = 60;
        //cmd.Parameters.Add(paramsToStore[2]).Value = ddlChapter.SelectedValue.ToString();




        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        ddlstate1.DataSource = ds;
        ddlstate1.DataValueField = "id";
        ddlstate1.DataTextField = "name";
        ddlstate1.DataBind();


    }

    protected void btn_Click1(object sender, EventArgs e)
    {
        string pageidwws = this.Page.ClientQueryString;
        name = this.Page.ClientQueryString;

        string VirtualPaths = this.Page.AppRelativeVirtualPath;
        if (name == "name=Uni")
        {
            SelectDatail(1);
            college.Visible = false;
            Univ.Visible = true;

        }
        else if (name == "name=College")
        {
            Schoolid = "4";
            SelectDatailnew(1);
            college.Visible = true;

            Univ.Visible = false;
        }

        else if (name == "name=School")
        {
            Schoolid = "3";
            SelectDatailnew(1);
            college.Visible = true;

            Univ.Visible = false;
        }
        else if (name == "name=Inst")
        {
            Schoolid = "2";
            SelectDatailnew(1);
            college.Visible = true;

            Univ.Visible = false;
        }
        else if (name == "name=Teacher")
        {
            Schoolid = "5";
            SelectTeacherDatail(1);
            college.Visible = true;

            Univ.Visible = false;
        }


        //if (ddlcountry.SelectedIndex != 0)
        //{
        //    //  bindUNIstate();
        //    // bindState();

        string pageidww = this.Page.ClientQueryString;
        name = this.Page.ClientQueryString;

        string VirtualPath = this.Page.AppRelativeVirtualPath;

        if (ddlcountry.SelectedValue != "0" && VirtualPath == "~/UniversityMain.aspx")
        {
            // bindState();
            // Response.RedirectToRoute ("UniversityMain.aspx?ContId=" + ddlcountry.SelectedValue + "&State=" + ddlstate1.SelectedValue + "&StateName=" + ddlstate1.SelectedItem.Text);
        }

    }


    [WebMethod]
    public static CountryDetails[] BindDatatoDropdown()
    {
        DataTable dt = new DataTable();
        List<CountryDetails> details = new List<CountryDetails>();
        string strcon1 = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        using (SqlConnection con = new SqlConnection(strcon1))
        {
            using (SqlCommand cmd = new SqlCommand("select cntId ,cntName  from tblCountry", con))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dtrow in dt.Rows)
                {
                    CountryDetails country = new CountryDetails();
                    country.CountryId = Convert.ToInt32(dtrow["cntId"].ToString());
                    country.CountryName = dtrow["cntName"].ToString();
                    details.Add(country);
                }
            }
        }
        return details.ToArray();
    }
    public class CountryDetails
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
    }

    private void SelectDatail(Int32 pageIndex)
    {

        bl = new clsBLSetup();
        prppram = new PRPSetup();
        Int32 pageSize = Convert.ToInt32(ddlNopage.SelectedValue);

        prppram.pageIndex = pageIndex.ToString();
        prppram.pageSize = pageSize.ToString();



        //---------for page work here



        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand("viewUniversityWeb_srikant", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] paramsToStore =
           new SqlParameter[5];
        paramsToStore[0] = new SqlParameter("@pageSize", SqlDbType.NVarChar);
        paramsToStore[0].Size = 20;
        cmd.Parameters.Add(paramsToStore[0]).Value = ddlNopage.SelectedValue;
        paramsToStore[1] = new SqlParameter("@pageIndex", SqlDbType.NVarChar);
        paramsToStore[1].Size = 100;
        cmd.Parameters.Add(paramsToStore[1]).Value = pageIndex;
        paramsToStore[2] = new SqlParameter("@contid", SqlDbType.NVarChar);
        paramsToStore[2].Size = 60;
        cmd.Parameters.Add(paramsToStore[2]).Value = ddlcountry.SelectedValue;

        paramsToStore[3] = new SqlParameter("@stateId", SqlDbType.NVarChar);
        paramsToStore[3].Size = 60;
        if (ddlstate1.SelectedIndex == 0)
        {
            cmd.Parameters.Add(paramsToStore[3]).Value = 0;
        }
        else
        {
            cmd.Parameters.Add(paramsToStore[3]).Value = ddlstate1.SelectedValue;
        }

        paramsToStore[4] = new SqlParameter("@Id", SqlDbType.NVarChar);
        paramsToStore[4].Size = 60;
        cmd.Parameters.Add(paramsToStore[4]).Value = ddl.SelectedValue;


        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);

     

        //----------------------------------------------

        TotalCount = ds.Tables[0].Rows.Count;
        string VirtualPaths = this.Page.AppRelativeVirtualPath;
       
    }

    private void SelectDatailUnv(Int32 pageIndex)
    {

        bl = new clsBLSetup();
        prppram = new PRPSetup();
        Int32 pageSize = Convert.ToInt32(ddlNopage.SelectedValue);

        prppram.pageIndex = pageIndex.ToString();
        prppram.pageSize = pageSize.ToString();


        //---------for page work here



        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand("viewUniversityWeb_srikant", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] paramsToStore =
           new SqlParameter[4];
        paramsToStore[0] = new SqlParameter("@pageSize", SqlDbType.NVarChar);
        paramsToStore[0].Size = 20;
        cmd.Parameters.Add(paramsToStore[0]).Value = ddlNopage.SelectedValue;
        paramsToStore[1] = new SqlParameter("@pageIndex", SqlDbType.NVarChar);
        paramsToStore[1].Size = 100;
        cmd.Parameters.Add(paramsToStore[1]).Value = pageIndex;
        paramsToStore[2] = new SqlParameter("@contid", SqlDbType.NVarChar);
        paramsToStore[2].Size = 60;
        cmd.Parameters.Add(paramsToStore[2]).Value = ddlcountry.SelectedValue;

        paramsToStore[3] = new SqlParameter("@stateId", SqlDbType.NVarChar);
        paramsToStore[3].Size = 60;
        cmd.Parameters.Add(paramsToStore[3]).Value = ddlstate1.SelectedValue;

        paramsToStore[4] = new SqlParameter("@Id", SqlDbType.NVarChar);
        paramsToStore[4].Size = 60;
        cmd.Parameters.Add(paramsToStore[4]).Value = ddl.SelectedValue;



        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);


        //----------------------------------------------

        TotalCount = ds.Tables[0].Rows.Count;
        string VirtualPaths = this.Page.AppRelativeVirtualPath;
      
    }
    private void SelectDatailnew(Int32 pageIndex)
    {

        bl = new clsBLSetup();
        prppram = new PRPSetup();
        Int32 pageSize = Convert.ToInt32(ddlNopage.SelectedValue);

        prppram.pageIndex = pageIndex.ToString();
        prppram.pageSize = pageSize.ToString();

        //---------for page work here
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand("viewCollegeDetail_srikant", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] paramsToStore =
           new SqlParameter[7];
        paramsToStore[0] = new SqlParameter("@pageSize", SqlDbType.NVarChar);
        paramsToStore[0].Size = 20;
        cmd.Parameters.Add(paramsToStore[0]).Value = ddlNopage.SelectedValue;
        paramsToStore[1] = new SqlParameter("@pageIndex", SqlDbType.NVarChar);
        paramsToStore[1].Size = 100;
        cmd.Parameters.Add(paramsToStore[1]).Value = pageIndex;
        paramsToStore[2] = new SqlParameter("@loginType", SqlDbType.NVarChar);
        paramsToStore[2].Size = 60;
        cmd.Parameters.Add(paramsToStore[2]).Value = Schoolid;

        paramsToStore[3] = new SqlParameter("@ContId", SqlDbType.NVarChar);
        paramsToStore[3].Size = 60;
        cmd.Parameters.Add(paramsToStore[3]).Value = ddlcountry.SelectedValue;

        paramsToStore[4] = new SqlParameter("@stateId", SqlDbType.NVarChar);
        paramsToStore[4].Size = 60;

        if (ddlstate1.SelectedIndex == 0)
        {
            cmd.Parameters.Add(paramsToStore[4]).Value = 0;
        }
        else
        {
            cmd.Parameters.Add(paramsToStore[4]).Value = ddlstate1.SelectedValue;
        }

        paramsToStore[5] = new SqlParameter("@category", SqlDbType.NVarChar);
        paramsToStore[5].Size = 60;
        cmd.Parameters.Add(paramsToStore[5]).Value = ddl.SelectedValue;

        paramsToStore[6] = new SqlParameter("@subcategory", SqlDbType.NVarChar);
        paramsToStore[6].Size = 60;
        if (ddlUniType.SelectedIndex == 0)
        {
            cmd.Parameters.Add(paramsToStore[6]).Value = 0;
        }
        else
        {
            cmd.Parameters.Add(paramsToStore[6]).Value = ddlUniType.SelectedValue;
        }
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds5);

        // Country = ds.Tables[0].Rows[0]["cntName"].ToString();

        //----------------------------------------------

        TotalCount = ds5.Tables[0].Rows.Count;

    }

    private void SelectTeacherDatail(Int32 pageIndex)
    {

        bl = new clsBLSetup();
        prppram = new PRPSetup();
        Int32 pageSize = Convert.ToInt32(ddlNopage.SelectedValue);

        prppram.pageIndex = pageIndex.ToString();
        prppram.pageSize = pageSize.ToString();

        //---------for page work here



        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand("spteacherdetails", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] paramsToStore =
           new SqlParameter[7];
        paramsToStore[0] = new SqlParameter("@id", SqlDbType.NVarChar);
        paramsToStore[0].Size = 20;
        cmd.Parameters.Add(paramsToStore[0]).Value = ddlNopage.SelectedValue;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds5);

      

        //----------------------------------------------

        TotalCount = ds5.Tables[0].Rows.Count;

    }

    protected void ddlstate1_SelectedIndexChanged(object sender, EventArgs e)
    {

        if (name == "name=Uni")
        {
            Session["Indexcity"] = ddlstate1.SelectedIndex;
            if (Session["Indexcity"] != null)
            {
                ddlstate1.SelectedIndex = (int)Session["Indexcity"];

              
            }
            SelectDatail(1);
            college.Visible = false;
            Univ.Visible = true;




        }
        else if (name == "name=College")
        {
            Schoolid = "4";

            Session["Indexcity"] = ddlstate1.SelectedIndex;
            int iid = Convert.ToInt32(Session["Indexcity"]);
            SelectDatailnew(1);
            college.Visible = true;

            Univ.Visible = false;
        }

        else if (name == "name=School")
        {
            Schoolid = "3";
            SelectDatailnew(1);
            college.Visible = true;

            Univ.Visible = false;
        }
        else if (name == "name=Inst")
        {
            Schoolid = "2";
            SelectDatailnew(1);
            college.Visible = true;

            Univ.Visible = false;
        }
        else if (name == "name=Teacher")
        {
            Schoolid = "5";
            SelectDatailnew(1);
            college.Visible = true;

            Univ.Visible = false;
        }

        else
        {
            bindEducationType();
        }

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

    protected void ddlUniType_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (name == "name=Uni")
        {
            SelectDatail(1);
            college.Visible = false;
            Univ.Visible = true;

        }
        else if (name == "name=College")
        {
            Schoolid = "4";
            SelectDatailnew(1);
            college.Visible = true;

            Univ.Visible = false;
        }

    }
}