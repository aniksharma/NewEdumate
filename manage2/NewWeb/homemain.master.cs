using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using nmsProfile;
using nmsSetup;
using nmsSetupWeb;
using nmsEditor;
using System.Collections.Generic;
using System.Data;
using nmsEditor;
using System.Data.SqlClient;
using System.Configuration;
public partial class manage2_NewWeb_homemain : System.Web.UI.MasterPage
{
    clsBLEditor obj;
    PRPPImageGellery objprp;
    PRPPImageGellery objprpparam;
    prpLogin objlogin;
    string name = "", temp = "", page = "", code = "", all = "", title = "", css = "";
    DataSet ds;

    string collageName = "", lastpart = "", stuid = "";
    string websitename = "";
    private void getdatealldaetilforurl()
    {
        if (Page.RouteData.Values["Sname"] != null)
        {
            lastpart = Page.RouteData.Values["Sname"].ToString();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "spuserTempateCheck";
            cmd.Parameters.AddWithValue("@title", lastpart);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            // Code that runs on application startup
            collageName = cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            con.Close();

            if (collageName == "" || collageName == "nill")
            {
                Response.Redirect("default.aspx", false);

            }
            else
            {
                string[] mlog;
                mlog = new string[2];
                mlog = collageName.Split('-');
                name = lastpart;
                code = mlog[0];
                temp = mlog[1];
                css = mlog[2];
                if (Page.RouteData.Values["Pagename"] != null)
                {
                    page = Page.RouteData.Values["Pagename"].ToString();
                }
                else
                {
                    page = "Home";
                }
            }
        }
        else
        {
            Response.Redirect("default.aspx", false);
        }
    }


    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
             if (Page.RouteData.Values["Sname"] != null)
            {
                getdatealldaetilforurl();
                bindCss();
                bindTextBox();
                bindmenuNew();
            }
            else
            {
                Response.Redirect("default.aspx");
            }


        }

    }

    private void bindMenu()
    {
        all = "http://www.edumateworld.com/ch/" + name + "/" + code + "/" + temp;

        linkpabout.NavigateUrl = linktabout.NavigateUrl = linkcabout.NavigateUrl = all + "/2";
        linktcontact.NavigateUrl = linkpcontact.NavigateUrl = linkcContact.NavigateUrl = all + "/3";
        linktcourses.NavigateUrl = linkccourses.NavigateUrl = all + "/18/";
        linktgallery.NavigateUrl = linkpgallery.NavigateUrl = linkcgallery.NavigateUrl = "http://www.edumateworld.com/chg/" + name + "/" + code + "/" + temp + "/4";
        linkthome.NavigateUrl = linkphome.NavigateUrl = linkchome.NavigateUrl = "http://www.edumateworld.com/c/" + name + "/" + code + "/" + temp + "/1";
        linkcinfrastructure.NavigateUrl = all + "/19";
        linktachievement.NavigateUrl = linkpachievements.NavigateUrl = all + "/22";

        linkpblog.NavigateUrl = all + "/28";
        linkcdirector.NavigateUrl = all + "/20";
        linkpportfolio.NavigateUrl = all + "/27";
        linktacademicmodule.NavigateUrl = all + "/26";
        linktactivities.NavigateUrl = all + "/25";

        HyperpAchievement.NavigateUrl = HypercAchievement.NavigateUrl = all + "/22";
        HypercAffiliations.NavigateUrl = all + "/24";
        HyperpDownloads.NavigateUrl = HypercDownloads.NavigateUrl = all + "/8";
        HypercFacilities.NavigateUrl = all + "/23";
        HypertPrivacy.NavigateUrl = HyperpPrivacy.NavigateUrl = HypercPrivacy.NavigateUrl = all + "/20";
        HypertTerms.NavigateUrl = HyperpTerms.NavigateUrl = HypercTerms.NavigateUrl = all + "/21";
    }
 
    private void bindCss()
    {
        if (temp == "10")
        {
           
        }

        if (temp == "11")
        {
            tcss.Href = "~/manage2/NewWeb/css/college2.css";
        }

        else if (temp == "12")
        {
            tcss.Href = "~/manage2/NewWeb/css/college3.css";
        }
        else if (temp == "13")
        {
            tcss.Href = "~/manage2/NewWeb/css/college4.css";
        }
        else if (temp == "14")
        {
            tcss.Href = "~/manage2/NewWeb/css/college5.css";
        }
        else if (temp == "15")
        {
            tcss.Href = "~/manage2/NewWeb/css/institute1.css";
        }
        else if (temp == "16")
        {
            tcss.Href = "~/manage2/NewWeb/css/institute2.css";
        }
        else if (temp == "17")
        {
            tcss.Href = "~/manage2/NewWeb/css/professional1.css";
        }
        else if (temp == "18")
        {
            tcss.Href = "~/manage2/NewWeb/css/professional2.css";
        }
        else if (temp == "19")
        {
            tcss.Href = "~/manage2/NewWeb/css/professional3.css";
        }
        else if (temp == "20")
        {
            tcss.Href = "~/manage2/NewWeb/css/professional4.css";
        }
        else if (temp == "21")
        {
            tcss.Href = "~/manage2/NewWeb/css/professional5.css";
        }
        else if (temp == "22")
        {
            tcss.Href = "~/manage2/NewWeb/css/school1.css";
        }
        else if (temp == "23")
        {
            tcss.Href = "~/manage2/NewWeb/css/school2.css";
        }
        else if (temp == "24")
        {
            tcss.Href = "~/manage2/NewWeb/css/school3.css";
        }
        else if (temp == "25")
        {
            tcss.Href = "~/manage2/NewWeb/css/school4.css";
        }
        else if (temp == "26")
        {
            tcss.Href = "~/manage2/NewWeb/css/teacher1.css";
        }
        else if (temp == "27")
        {
            tcss.Href = "~/manage2/NewWeb/css/teacher2.css";
        }


        else if (temp == "28")
        {
            tcss.Href = "~/manage2/NewWeb/css/teacher3.css";
        }

        else if (temp == "29")
        {
            tcss.Href = "~/manage2/NewWeb/css/teacher4.css";
        }


    }

    private void bindTextBox()
    {
        PRPSetup prp = new PRPSetup();
        PRPSetup prppram = new PRPSetup();
        clsBLSetup bl = new clsBLSetup();

        prppram.codeId = code;
        prppram.name = "";
        DataSet ds = new DataSet();
        ds = bl.SelectCollegeDetail_sal(prppram);
       lblCollegeName.Text = ds.Tables[0].Rows[0]["CollegeName"].ToString();
       imglogo.Src = "http://www.edumateworld.com" + ds.Tables[0].Rows[0]["CollegeImage"].ToString(); ;



    }
    private string getname()
    {
        return "edu";
    }
    public string Quicklink(object Value)
    {
        return "http://www.edumateworld.com/ch/" + name + "/" + code + "/" + temp + "/" + Value.ToString();
    }
    public string gallerylink(object Value)
    {
        return "http://www.edumateworld.com/chg/" + name + "/" + code + "/" + temp + "/" + Value.ToString();
    }

    private void bindmenuNew()
    {
        if (Session["datamenu"] == null)
        {

            PRPEditor prppram = new PRPEditor();
            clsBLEditor bl = new clsBLEditor();

            prppram.Id = code;
            prppram.State = temp;
             ds = new DataSet();
            ds = bl.spMenuForMicro(prppram);
        }
        else
        {
            ds = new DataSet();
            ds = (DataSet)(Session["datamenu"]);
        

        }
        repheadermenu.DataSource = ds.Tables[1];
        repheadermenu.DataBind();

        repfootermenu.DataSource = ds.Tables[2];
        repfootermenu.DataBind();

    }

}
