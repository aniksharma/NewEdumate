using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
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
using System.Data;
using System.Configuration;

public partial class InstitutePanel_Default3 : System.Web.UI.Page
{
    string stringTempDate = "";
    bool checker = true;
    ListItem lt;
    Int32 curretnYear = 0, OldYear = 0;
    PRPprofile objprp;
    DataSet ds = new DataSet();
    DataSet dssec = new DataSet();
    static DataSet dsedu = new DataSet();
    DataSet dsedu1 = new DataSet();
    prpLogin objlog = new prpLogin();
    string strcon = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;

    string strcon1 = ConfigurationManager.ConnectionStrings["cnkids"].ConnectionString;

    PostBackOptions optionsSubmit;
    string ToMail, FromMail, BodyMail, HeadMail;
    static string kidsid;
    static string memberID, Imgurl = "", Id = "", idss = "", MailId = "", City = "", Dist = "", InstituteCode = "", Images = "", newId="";
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
         
            binduniversity();
            if (Request.QueryString["edit"] != null)
            {
                newId = Request.QueryString["id"].ToString();
                bindTextBox();
                btn3.Text = "Update";
            }
            else
            {
                btn3.Text = "Save";
            }
        }

        eduDetails();

        if (dsedu.Tables[0].Rows.Count > 0)
        {
            string idi = dsedu.Tables[0].Rows[0]["S_GrdYear"].ToString();
            string idds = dsedu.Tables[0].Rows[0]["S_From"].ToString();
            string idib = dsedu.Tables[0].Rows[0]["S_To"].ToString();
            var sourcess = Enumerable.Range(1947, 80)
            .Select(i => new { Text = i.ToString(), Value = i.ToString() });
            ddlgrd.DataSource = sourcess;
            ddlgrd.DataTextField = "Text";
            ddlgrd.DataValueField = "Value";
            ddlgrd.DataBind();
            var source = Enumerable.Range(1947, 80)
            .Select(i => new { Text = i.ToString(), Value = i.ToString() });
            ddlfrom.DataSource = source;
            ddlfrom.DataTextField = "Text";
            ddlfrom.DataValueField = "Value";
            ddlfrom.DataBind();
           
            var sources = Enumerable.Range(1947, 80)
           .Select(i => new { Text = i.ToString(), Value = i.ToString() });
            ddlto.DataSource = sources;
            ddlto.DataTextField = "Text";
            ddlto.DataValueField = "Value";
            ddlto.DataBind();
           
            state.Visible = true;
            School.Visible = true;
            grd.Visible = true;
            from.Visible = true;
            to.Visible = true;

        }

        }

    private void binduniversity()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddlCountry;
        drpprp.spName = "viewCountry";
        drp.bindDropDown(drpprp);
        ddlCountry.SelectedIndex = 1;
    }

    public void eduDetails()
    {


        SqlConnection con = new SqlConnection(strcon1);
        SqlCommand cmd = new SqlCommand("sp_selectEdu", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] paramsToStore =
           new SqlParameter[2];
        paramsToStore[0] = new SqlParameter("@id", SqlDbType.NVarChar);
        paramsToStore[0].Size = 20;
        cmd.Parameters.Add(paramsToStore[0]).Value = MailId;

        paramsToStore[1] = new SqlParameter("@Qtype", SqlDbType.NVarChar);
        paramsToStore[1].Size = 20;
        cmd.Parameters.Add(paramsToStore[1]).Value = "Secondary";


        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dsedu);

    }
    private void bindState()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddlstate;
        if (ddlCountry.SelectedIndex != 0)
            drpprp.id = Convert.ToInt32(ddlCountry.SelectedValue);
        drpprp.spName = "viewState";
        drp.bindDropDown(drpprp);
        
    }
    protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
    {
        bindState();
    }
    protected void ddlstate_SelectedIndexChanged(object sender, EventArgs e)
    {
        SelectDatail(1);
    }
    private void SelectDatail(Int32 pageIndex)
    {
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand("sp_school", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] paramsToStore =
           new SqlParameter[2];
        paramsToStore[0] = new SqlParameter("@cityid", SqlDbType.NVarChar);
        paramsToStore[0].Size = 60;
        cmd.Parameters.Add(paramsToStore[0]).Value = ddlstate.SelectedValue;

        paramsToStore[1] = new SqlParameter("@contid", SqlDbType.NVarChar);
        paramsToStore[1].Size = 60;
        cmd.Parameters.Add(paramsToStore[1]).Value = ddlCountry.SelectedValue;


        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dssec);
        ddlSchool.DataSource = dssec;
        ddlSchool.DataValueField = "id";
        ddlSchool.DataTextField = "name";
        ddlSchool.DataBind();
    }
    protected void ddlSchool_SelectedIndexChanged(object sender, EventArgs e)
    {

        from.Visible = true;
        to.Visible = true;
        grd.Visible = true;
        spc.Visible = true;
        var source = Enumerable.Range(1947, 80).Select(i => new { Text = i.ToString(), Value = i.ToString() });
        ddlfrom.DataSource = source;
        ddlfrom.DataTextField = "Text";
        ddlfrom.DataValueField = "Value";
        ddlfrom.DataBind();

        var sources = Enumerable.Range(1947, 80)
       .Select(i => new { Text = i.ToString(), Value = i.ToString() });
        ddlto.DataSource = sources;
        ddlto.DataTextField = "Text";
        ddlto.DataValueField = "Value";
        ddlto.DataBind();

        var sourcess = Enumerable.Range(1947, 80)
        .Select(i => new { Text = i.ToString(), Value = i.ToString() });
        ddlgrd.DataSource = sourcess;
        ddlgrd.DataTextField = "Text";
        ddlgrd.DataValueField = "Value";
        ddlgrd.DataBind();

       

    }
    private void bindtfrom()
    {
        from.Visible = true;
        to.Visible = true;
        grd.Visible = true;
        spc.Visible = true;
        var source = Enumerable.Range(1947, 80).Select(i => new { Text = i.ToString(), Value = i.ToString() });
        ddlfrom.DataSource = source;
        ddlfrom.DataTextField = "Text";
        ddlfrom.DataValueField = "Value";
        ddlfrom.DataBind();

        var sources = Enumerable.Range(1947, 80)
       .Select(i => new { Text = i.ToString(), Value = i.ToString() });
        ddlto.DataSource = sources;
        ddlto.DataTextField = "Text";
        ddlto.DataValueField = "Value";
        ddlto.DataBind();

        var sourcess = Enumerable.Range(1947, 80)
        .Select(i => new { Text = i.ToString(), Value = i.ToString() });
        ddlgrd.DataSource = sourcess;
        ddlgrd.DataTextField = "Text";
        ddlgrd.DataValueField = "Value";
        ddlgrd.DataBind();


    }
    protected void btn3_Click(object sender, EventArgs e)
    {

        insertSecEduDetails();
    }

    private void insertSecEduDetails()
    {

        if (dsedu.Tables[0].Rows.Count== 0 && btn3.Text=="Save")
        {
            SqlConnection con = new SqlConnection(strcon1);
            SqlCommand cmd = new SqlCommand("Sp_kidsEduDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sp_kidsEduDetails";
            try
            {
                SqlParameter[] paramsToStore =
             new SqlParameter[10];

                paramsToStore[0] = new SqlParameter("@S_Country", SqlDbType.NVarChar);
                paramsToStore[0].Size = 20;
                cmd.Parameters.Add(paramsToStore[0]).Value = ddlCountry.SelectedValue;
                paramsToStore[1] = new SqlParameter("@S_StateId", SqlDbType.NVarChar);
                paramsToStore[1].Size = 100;
                cmd.Parameters.Add(paramsToStore[1]).Value = ddlstate.SelectedValue;
                paramsToStore[2] = new SqlParameter("@S_School", SqlDbType.NVarChar);
                paramsToStore[2].Size = 20;
                cmd.Parameters.Add(paramsToStore[2]).Value = ddlSchool.SelectedValue;
                paramsToStore[3] = new SqlParameter("@S_from", SqlDbType.NVarChar);
                paramsToStore[3].Size = 100;
                cmd.Parameters.Add(paramsToStore[3]).Value = ddlfrom.SelectedValue;

                paramsToStore[4] = new SqlParameter("@S_Specilization", SqlDbType.NVarChar);
                paramsToStore[4].Size = 100;
                cmd.Parameters.Add(paramsToStore[4]).Value = txtspc.Text;
                paramsToStore[5] = new SqlParameter("@S_to", SqlDbType.NVarChar);
                paramsToStore[5].Size = 100;
                cmd.Parameters.Add(paramsToStore[5]).Value = ddlto.SelectedValue;

                paramsToStore[6] = new SqlParameter("@S_GrdYear", SqlDbType.NVarChar);
                paramsToStore[6].Size = 100;
                cmd.Parameters.Add(paramsToStore[6]).Value = ddlgrd.SelectedValue;

                paramsToStore[7] = new SqlParameter("@SCode", SqlDbType.NVarChar);
                paramsToStore[7].Size = 100;
                cmd.Parameters.Add(paramsToStore[7]).Value = MailId;

                paramsToStore[8] = new SqlParameter("@type", SqlDbType.NVarChar);
                paramsToStore[8].Size = 100;
                cmd.Parameters.Add(paramsToStore[8]).Value = "secondary";
                paramsToStore[9] = new SqlParameter("@ID", SqlDbType.NVarChar);
                paramsToStore[9].Size = 100;
                cmd.Parameters.Add(paramsToStore[9]).Value = "";

            }

            catch (Exception excp)
            {
                
            }
            con.Open();
            cmd.Connection = con;
            int y = cmd.ExecuteNonQuery();

            if (y > 0)
            {
                lblmsg1.Visible = true;

            }


        }
        else if( btn3.Text=="Update")
        {

            SqlConnection con = new SqlConnection(strcon1);
            SqlCommand cmd = new SqlCommand("Sp_kidsEduDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Sp_kidsEduDetails";
          
            try
            {
                SqlParameter[] paramsToStore =
             new SqlParameter[10];

                paramsToStore[0] = new SqlParameter("@S_Country", SqlDbType.NVarChar);
                paramsToStore[0].Size = 20;
                cmd.Parameters.Add(paramsToStore[0]).Value = ddlCountry.SelectedValue;
                paramsToStore[1] = new SqlParameter("@S_StateId", SqlDbType.NVarChar);
                paramsToStore[1].Size = 100;
                cmd.Parameters.Add(paramsToStore[1]).Value = ddlstate.SelectedValue;
                paramsToStore[2] = new SqlParameter("@S_School", SqlDbType.NVarChar);
                paramsToStore[2].Size = 20;
                cmd.Parameters.Add(paramsToStore[2]).Value = ddlSchool.SelectedValue;
                paramsToStore[3] = new SqlParameter("@S_from", SqlDbType.NVarChar);
                paramsToStore[3].Size = 100;
                cmd.Parameters.Add(paramsToStore[3]).Value = ddlfrom.SelectedValue;
                paramsToStore[4] = new SqlParameter("@S_Specilization", SqlDbType.NVarChar);
                paramsToStore[4].Size = 100;
                cmd.Parameters.Add(paramsToStore[4]).Value = txtspc.Text;

                paramsToStore[5] = new SqlParameter("@S_to", SqlDbType.NVarChar);
                paramsToStore[5].Size = 100;
                cmd.Parameters.Add(paramsToStore[5]).Value = ddlto.SelectedValue;

                paramsToStore[6] = new SqlParameter("@S_GrdYear", SqlDbType.NVarChar);
                paramsToStore[6].Size = 100;
                cmd.Parameters.Add(paramsToStore[6]).Value = ddlgrd.SelectedValue;

                paramsToStore[7] = new SqlParameter("@SCode", SqlDbType.NVarChar);
                paramsToStore[7].Size = 100;
                cmd.Parameters.Add(paramsToStore[7]).Value = MailId;


                paramsToStore[8] = new SqlParameter("@type", SqlDbType.NVarChar);
                paramsToStore[8].Size = 100;
                cmd.Parameters.Add(paramsToStore[8]).Value = "UpdateSec";

                paramsToStore[9] = new SqlParameter("@ID", SqlDbType.NVarChar);
                paramsToStore[9].Size = 100;
                cmd.Parameters.Add(paramsToStore[9]).Value = newId;
            }

            catch (Exception excp)
            {
            }
            con.Open();
            cmd.Connection = con;
            int y = cmd.ExecuteNonQuery();

            if (y > 0)
            {
                lblmsg1.Visible = true;

            }


        }

    }

    protected void ddlfrom_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void bindTextBox()
    {
        PRPSetup prp = new PRPSetup();
        PRPSetup prppram = new PRPSetup();
        clsBLSetup bl = new clsBLSetup();
        prppram.codeId = MailId;
        prppram.rollNo = Request.QueryString["id"].ToString();
        prppram.type="secondary";
        prp = bl.SelectStudDetail1(prppram);

        ddlCountry.SelectedValue = prp.urlPath;
        bindState();

        ddlstate.SelectedValue = prp.pinCode;
        SelectDatail(1);
        ddlSchool.SelectedValue = prp.uniID;
        bindtfrom();
        ddlfrom.SelectedValue = prp.rank;
        ddlto.SelectedValue = prp.education;
        ddlgrd.SelectedValue = prp.status;
        txtspc.Text = prp.name;
    }
}