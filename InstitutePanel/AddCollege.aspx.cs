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

using System.Net;
using System.Net.Mail;
using javax.jws;
using System.Data.SqlClient;

public partial class InstitutePanel_Default3 : System.Web.UI.Page
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
    static string memberID, Imgurl = "", Id = "", idss = "", MailId = "", City = "", Dist = "", InstituteCode = "", Images = "",newId="";
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
            Hbinduniversity();
            if (Request.QueryString["edit"] != null)
            {
                newId = Request.QueryString["id"].ToString();
                bindTextBox();
                Hbtn3.Text = "Update";
            }
            else
            {
                Hbtn3.Text = "Save";
            }
            eduDetails();
            eduHigherDetails();

             if (dsedu1.Tables[0].Rows.Count > 0)
        {
            string id = dsedu1.Tables[0].Rows[0]["S_CountryId"].ToString();
            string ids = dsedu1.Tables[0].Rows[0]["S_StateId"].ToString();
            int idd = Convert.ToInt32(dsedu1.Tables[0].Rows[0]["S_College"].ToString());
            string idi = dsedu1.Tables[0].Rows[0]["S_Univ"].ToString();
            HddlCountry.SelectedIndex = Convert.ToInt32(id);
            HbindState();
            HSelectDatail(1);
            Hddlstate.SelectedIndex = Convert.ToInt32(ids);
              
             }
             if (dsedu.Tables[0].Rows.Count > 0)
             {

                 string id = dsedu.Tables[0].Rows[0]["S_CountryId"].ToString();
                 string idss = dsedu.Tables[0].Rows[0]["S_StateId"].ToString();
                 string iddt = dsedu.Tables[0].Rows[0]["S_School"].ToString();
                 string idi = dsedu.Tables[0].Rows[0]["S_GrdYear"].ToString();
                 string idds = dsedu.Tables[0].Rows[0]["S_From"].ToString();
                 string idib = dsedu.Tables[0].Rows[0]["S_To"].ToString();
                 var sourcess = Enumerable.Range(1947, 80)
                 .Select(i => new { Text = i.ToString(), Value = i.ToString() });
                 Hddlgrd.DataSource = sourcess;
                 Hddlgrd.DataTextField = "Text";
                 Hddlgrd.DataValueField = "Value";
                 Hddlgrd.DataBind();
                
             }
        }
    }

            
        

    protected void HddlCountry_SelectedIndexChanged(object sender, EventArgs e)
    {
        HbindState();
    }


    private void Hbinduniversity()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = HddlCountry;
        drpprp.spName = "viewCountry";
        drp.bindDropDown(drpprp);
     
    }

    private void HbindState()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = Hddlstate;
        if (HddlCountry.SelectedIndex != 0)
            drpprp.id = Convert.ToInt32(HddlCountry.SelectedValue);
        drpprp.spName = "viewState";
        drp.bindDropDown(drpprp);
    }
    private void HSelectDatail(Int32 pageIndex)
    {



        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand("sp_College", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] paramsToStore =
           new SqlParameter[2];
        paramsToStore[0] = new SqlParameter("@cityid", SqlDbType.NVarChar);
        paramsToStore[0].Size = 60;
        cmd.Parameters.Add(paramsToStore[0]).Value = Hddlstate.SelectedValue;

        paramsToStore[1] = new SqlParameter("@contid", SqlDbType.NVarChar);
        paramsToStore[1].Size = 60;
        cmd.Parameters.Add(paramsToStore[1]).Value = HddlCountry.SelectedValue;


        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        HddlSchool.DataSource = ds;
        HddlSchool.DataValueField = "id";
        HddlSchool.DataTextField = "name";
        HddlSchool.DataBind();
    }
    protected void Hddlstate_SelectedIndexChanged(object sender, EventArgs e)
    {
          HSelectDatailUniv(1);
    }
    protected void Hbtn3_Click(object sender, EventArgs e)
    {
        insertHigherEduDetails();
    }
    private void insertHigherEduDetails()
    {

            SqlConnection con = new SqlConnection(strcon1);
            SqlCommand cmd = new SqlCommand("Sp_kidsEduDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sp_kidsEduDetails";
            try
            {

                SqlParameter[] paramsToStore =
             new SqlParameter[9];

                paramsToStore[0] = new SqlParameter("@S_Country", SqlDbType.NVarChar);
                paramsToStore[0].Size = 20;
                cmd.Parameters.Add(paramsToStore[0]).Value = HddlCountry.SelectedValue;
                paramsToStore[1] = new SqlParameter("@S_StateId", SqlDbType.NVarChar);
                paramsToStore[1].Size = 100;
                cmd.Parameters.Add(paramsToStore[1]).Value = Hddlstate.SelectedValue;
                paramsToStore[2] = new SqlParameter("@S_from", SqlDbType.NVarChar);
                paramsToStore[2].Size = 20;
                cmd.Parameters.Add(paramsToStore[2]).Value = HddlSchool.SelectedValue;
                paramsToStore[3] = new SqlParameter("@S_to", SqlDbType.NVarChar);
                paramsToStore[3].Size = 100;
                cmd.Parameters.Add(paramsToStore[3]).Value = ddluniv.SelectedValue;
                paramsToStore[4] = new SqlParameter("@S_GrdYear", SqlDbType.NVarChar);
                paramsToStore[4].Size = 100;
                cmd.Parameters.Add(paramsToStore[4]).Value = Hddlgrd.SelectedValue;

                paramsToStore[5] = new SqlParameter("@S_Specilization", SqlDbType.NVarChar);
                paramsToStore[5].Size = 100;
                cmd.Parameters.Add(paramsToStore[5]).Value = Htxtspc.Text;

                paramsToStore[6] = new SqlParameter("@SCode", SqlDbType.NVarChar);
                paramsToStore[6].Size = 100;
                cmd.Parameters.Add(paramsToStore[6]).Value = MailId;
                paramsToStore[7] = new SqlParameter("@type", SqlDbType.NVarChar);
                paramsToStore[7].Size = 100;
                cmd.Parameters.Add(paramsToStore[7]).Value = "Higher";
                paramsToStore[8] = new SqlParameter("@ID", SqlDbType.NVarChar);
                paramsToStore[8].Size = 100;
                cmd.Parameters.Add(paramsToStore[8]).Value = "";

            }
            catch (Exception excp)
            {
              
            }
            con.Open();
            cmd.Connection = con;
             int y = cmd.ExecuteNonQuery();
            if (y>=0)
            {
                msg2.Visible = true;

            }

        }

    
    protected void HddlSchool_SelectedIndexChanged(object sender, EventArgs e)
    {
        var sourcess = Enumerable.Range(1947, 80)
        .Select(i => new { Text = i.ToString(), Value = i.ToString() });
        Hddlgrd.DataSource = sourcess;
        Hddlgrd.DataTextField = "Text";
        Hddlgrd.DataValueField = "Value";
        Hddlgrd.DataBind();
    }
    public void eduDetails()
    {
        SqlConnection con = new SqlConnection(strcon1);
        SqlCommand cmd = new SqlCommand("sp_selectEdu", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] paramsToStore =
           new SqlParameter[4];
        paramsToStore[0] = new SqlParameter("@id", SqlDbType.NVarChar);
        paramsToStore[0].Size = 20;
        cmd.Parameters.Add(paramsToStore[0]).Value = MailId;
        paramsToStore[0] = new SqlParameter("@Qtype", SqlDbType.NVarChar);
        paramsToStore[0].Size = 20;
        cmd.Parameters.Add(paramsToStore[0]).Value = "Secondary";
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dsedu);

    }
    public void eduHigherDetails()
    {
        SqlConnection con = new SqlConnection(strcon1);
        SqlCommand cmd = new SqlCommand("sp_selectEdu", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] paramsToStore =
           new SqlParameter[4];
        paramsToStore[0] = new SqlParameter("@id", SqlDbType.NVarChar);
        paramsToStore[0].Size = 20;
        cmd.Parameters.Add(paramsToStore[0]).Value = MailId;
        paramsToStore[0] = new SqlParameter("@Qtype", SqlDbType.NVarChar);
        paramsToStore[0].Size = 20;
        cmd.Parameters.Add(paramsToStore[0]).Value = "Higher";
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dsedu1);

    }
    private void HSelectDatailUniv(Int32 pageIndex)
    {
        DataSet hds = new DataSet();
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand("sp_univ", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] paramsToStore =
           new SqlParameter[2];
        paramsToStore[0] = new SqlParameter("@cityid", SqlDbType.NVarChar);
        paramsToStore[0].Size = 60;
        cmd.Parameters.Add(paramsToStore[0]).Value = Hddlstate.SelectedValue;

        paramsToStore[1] = new SqlParameter("@contid", SqlDbType.NVarChar);
        paramsToStore[1].Size = 60;
        cmd.Parameters.Add(paramsToStore[1]).Value = HddlCountry.SelectedValue;


        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(hds);
        ddluniv.DataSource = hds;
        ddluniv.DataValueField = "id";
        ddluniv.DataTextField = "name";
        ddluniv.DataBind();
    }

    private void bindTextBox()
    {
        PRPSetup prp = new PRPSetup();
        PRPSetup prppram = new PRPSetup();
        clsBLSetup bl = new clsBLSetup();
        prppram.codeId = MailId;
        prppram.rollNo = Request.QueryString["id"].ToString();
        prppram.type = "Higher";
        prp = bl.SelectStudDetail1(prppram);

        HddlCountry.SelectedValue = prp.urlPath;
        HbindState();
        Hddlstate.SelectedValue = prp.pinCode;
        HSelectDatail(1);
        HddlSchool.SelectedValue = prp.uniID;
        Hddlfrom.SelectedValue = prp.rank;
        Hddlto.SelectedValue = prp.education;
        Hddlgrd.SelectedValue = prp.status;
        Htxtspc.Text = prp.name;

    }
}