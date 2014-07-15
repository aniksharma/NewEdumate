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
public partial class mange_NewWeb_Home : System.Web.UI.MasterPage
{
    clsBLEditor obj;
    PRPPImageGellery objprp;
    PRPPImageGellery objprpparam;
    prpLogin objlogin;
   string name = "", temp = "", page = "", code = "",all="";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        
        {
            if (Page.RouteData.Values["name"] != null)
            {
                name = Page.RouteData.Values["name"].ToString();
            }

            if (Page.RouteData.Values["temp"] != null)
            {
                temp = Page.RouteData.Values["temp"].ToString();
            }

            if (Page.RouteData.Values["page"] != null)
            {
                page = Page.RouteData.Values["page"].ToString();
            }

            if (Page.RouteData.Values["code"] != null)
            {
                code = Page.RouteData.Values["code"].ToString();
            }

                BindCss(temp);
               bindTextBox();
                bindMenu();
        }
    }


    public string Quicklink(object Value)
    {
        return "http://www.edumate.edu.in/ch/" + name + "/" + code + "/" + temp + "/" + Value.ToString();
    }

    public string gallerylink(object Value)
    {
        return "http://www.edumate.edu.in/chg/" + name + "/" + code + "/" + temp + "/" + Value.ToString();
    }

    private void bindMenu()
    {
        all = "http://www.edumate.edu.in/ch/" + name + "/" + code+ "/"  + temp;
        linkabout.NavigateUrl = all + "/4/";

        linkachievements.NavigateUrl = all + "/9/";
        linkActivities.NavigateUrl = all + "/10/";
        linkContact.NavigateUrl = all + "/5/";
        linkexperience.NavigateUrl = all + "/37/";
        linkGallery.NavigateUrl = "http://www.edumate.edu.in/chg/"+name +"/"+code +"/"+temp+ "/2/";
        linkhome.NavigateUrl = all + "/3/";

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
        lblStateName.Text = prp.state;
        lblestablish.Text = prp.DOJ;
        imglogo.Src = "http://www.edumate.edu.in/" + prp.urlPath;



    }

    private void BindCss( string cssid)
    {
        if (cssid == "1")
        {
            tcss.Href = "tempcss/artschool.css";
        }
        else if (cssid == "2")
        {
            tcss.Href = "tempcss/business1.css";
        }
        else if (cssid == "3")
        {
            tcss.Href = "tempcss/business2.css";
        }

        else if (cssid == "4")
        {
            tcss.Href = "tempcss/ecollege.css";
        }

        else if (cssid == "5")
        {
            tcss.Href = "tempcss/einstitute.css";
        }

        else if (cssid == "6")
        {
            tcss.Href = "tempcss/eteacher.css";
        }

        else if (cssid == "7")
        {
            tcss.Href = "tempcss/graduation .css";
        }

        else if (cssid == "8")
        {
            tcss.Href = "tempcss/medical.css";
        }

        else if (cssid == "9")
        {
            tcss.Href = "tempcss/teacher.css";
        }









    }

}
