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
using System.Data.SqlClient;
using System.Configuration;
public partial class manage2_NewWeb_Home : System.Web.UI.MasterPage
{
    clsBLEditor obj;
    PRPPImageGellery objprp;
    PRPPImageGellery objprpparam;
    prpLogin objlogin;
    string name = "", temp = "", page = "", code = "", all = "", css="";

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

    private string getname()
    {
        return "edu";
    }
    public string Quicklink(object Value)
    {
        return "http://www.edumate.edu.in/ch/" + name + "/" + code + "/" + temp + "/" + Value.ToString();
    }

    public string gallerylink(object Value)
    {
        return "http://www.edumate.edu.in/chg/" + name + "/" + code + "/" + temp + "/" + Value.ToString();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
         if (Page.IsPostBack == false)
        {
            if (Page.RouteData.Values["Sname"] != null)
            {
                getdatealldaetilforurl();
                bindCss();
                bindMenu();
                bindQuickGellary();
                bindQuickLinks();
                bindTextBox();
            }
            else
            {
                Response.Redirect("default.aspx");
            }

           
        }
    
    }

    private void bindCss()
    {
        if (temp == "10")
        {
            tcss.Href = "http://www.edumate.edu.in/manage2/NewWeb/css/college1.css";
        }

        if( temp =="11")
        {
            tcss.Href = "http://www.edumate.edu.in/manage2/NewWeb/css/college2.css";
        }

        else if (temp == "12")
        {
            tcss.Href = "http://www.edumate.edu.in/manage2/NewWeb/css/college3.css";
        }
        else if (temp == "13")
        {
            tcss.Href = "http://www.edumate.edu.in/manage2/NewWeb/css/college4.css";
        }
        else if (temp == "14")
        {
            tcss.Href = "http://www.edumate.edu.in/manage2/NewWeb/css/college5.css";
        }
        else if (temp == "15")
        {
            tcss.Href = "http://www.edumate.edu.in/manage2/NewWeb/css/institute1.css";
        }
        else if (temp == "16")
        {
            tcss.Href = "http://www.edumate.edu.in/manage2/NewWeb/css/institute2.css";
        }
        else if (temp == "17")
        {
            tcss.Href = "http://www.edumate.edu.in/manage2/NewWeb/css/professional1.css";
        }
        else if (temp == "18")
        {
            tcss.Href = "http://www.edumate.edu.in/manage2/NewWeb/css/professional2.css";
        }
        else if (temp == "19")
        {
            tcss.Href = "http://www.edumate.edu.in/manage2/NewWeb/css/professional3.css";
        }
        else if (temp == "20")
        {
            tcss.Href = "http://www.edumate.edu.in/manage2/NewWeb/css/professional4.css";
        }
        else if (temp == "21")
        {
            tcss.Href = "http://www.edumate.edu.in/manage2/NewWeb/css/professional5.css";
        }
        else if (temp == "22")
        {
            tcss.Href = "http://www.edumate.edu.in/manage2/NewWeb/css/school1.css";
        }
        else if (temp == "23")
        {
            tcss.Href = "http://www.edumate.edu.in/manage2/NewWeb/css/school2.css";
        }
        else if (temp == "24")
        {
            tcss.Href = "http://www.edumate.edu.in/manage2/NewWeb/css/school3.css";
        }
        else if (temp == "25")
        {
            tcss.Href = "http://www.edumate.edu.in/manage2/NewWeb/css/school4.css";
        }
        else if (temp == "26")
        {
            tcss.Href = "http://www.edumate.edu.in/manage2/NewWeb/css/teacher1.css";
        }
        else if (temp == "27")
        {
            tcss.Href = "http://www.edumate.edu.in/manage2/NewWeb/css/teacher2.css";
        }


        else if (temp == "28")
        {
            tcss.Href = "http://www.edumate.edu.in/manage2/NewWeb/css/teacher3.css";
        }

        else if (temp == "29")
        {
            tcss.Href = "http://www.edumate.edu.in/manage2/NewWeb/css/teacher4.css";
        }


        if (temp == "17" || temp == "18" || temp == "19" || temp == "20" || temp == "21")
        {
            divmenuCollage.Visible = false;
            divmenuprofessional.Visible = true;
            divmenuTeacher.Visible = false;

            divfooterCollage.Visible = false;
            divfooterprofessional.Visible = true;
            divfooterteacher.Visible = false;


        }
        else if (temp == "26" || temp == "27" || temp == "28" )
        {
            divmenuCollage.Visible = false;
            divmenuprofessional.Visible = false;
            divmenuTeacher.Visible = true;

            divfooterCollage.Visible = false;
            divfooterprofessional.Visible = false;
            divfooterteacher.Visible = true;


        }
        else 
        {
            divmenuCollage.Visible = true;
            divmenuprofessional.Visible = false;
            divmenuTeacher.Visible = false;

            divfooterCollage.Visible = true;
            divfooterprofessional.Visible = false;
            divfooterteacher.Visible = false;

        }

    }
    private void bindMenu()
    {
        all = "http://www.edumate.edu.in/ch/" + name + "/" + code+"/"+temp;

        linkpabout.NavigateUrl = linktabout.NavigateUrl = linkcabout.NavigateUrl = all + "/2";
        linktcontact.NavigateUrl = linkpcontact.NavigateUrl = linkcContact.NavigateUrl = all + "/3";
        linktcourses.NavigateUrl = linkccourses.NavigateUrl = all + "/18/";
        linktgallery.NavigateUrl = linkpgallery.NavigateUrl = linkcgallery.NavigateUrl = "http://www.edumate.edu.in/chg/" + name + "/" + code + "/" + temp + "/4";
        linkthome.NavigateUrl = linkphome.NavigateUrl = linkchome.NavigateUrl = "http://www.edumate.edu.in/c/" + name + "/" + code + "/" + temp + "/1";
        linkcinfrastructure.NavigateUrl = all + "/19";
        linktachievement.NavigateUrl = linkpachievements.NavigateUrl = all + "/22";
        
        linkpblog.NavigateUrl = all + "/28";
        linkcdirector.NavigateUrl = all + "/20"; 
        linkpportfolio.NavigateUrl = all + "/27";
        linktacademicmodule.NavigateUrl = all + "/26";
        linktactivities.NavigateUrl = all + "/25";

        HyperpAchievement.NavigateUrl= HypercAchievement.NavigateUrl= all + "/22";
        HypercAffiliations.NavigateUrl= all + "/24";
        HyperpDownloads.NavigateUrl=HypercDownloads.NavigateUrl= all + "/8";
        HypercFacilities.NavigateUrl= all + "/23";
        HypertPrivacy.NavigateUrl= HyperpPrivacy.NavigateUrl= HypercPrivacy.NavigateUrl= all + "/20";
        HypertTerms.NavigateUrl = HyperpTerms.NavigateUrl = HypercTerms.NavigateUrl = all + "/21";

      
    }
    private void bindTextBox()
    {
        PRPSetup prp = new PRPSetup();
        PRPSetup prppram = new PRPSetup();
        clsBLSetup bl = new clsBLSetup();

        prppram.codeId = code;
        prppram.name = "";
        prp = bl.SelectCollegeDetail(prppram);
        lblCollegeName.Text = prp.name;
        imglogo.Src = "http://www.edumateworld.com/" + prp.urlPath;



    }
    private void bindQuickLinks()
    {
        obj = new clsBLEditor();
        PRPEditor prp = new PRPEditor();
        prp.Id = code;
        prp.pagePositin = "Quicklinks";

        repQuickLinks.DataSource = obj.spQuickBind(prp);
        repQuickLinks.DataBind();

    }
    private void bindQuickGellary()
    {
        obj = new clsBLEditor();
        PRPEditor prp = new PRPEditor();
        prp.Id = code;
        prp.pagePositin = "ImageCategory";

        repQuickGallery.DataSource = obj.spQuickBind(prp);
        repQuickGallery.DataBind();

    }


}
