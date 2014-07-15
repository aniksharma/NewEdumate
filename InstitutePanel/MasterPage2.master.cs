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
public partial class InstitutePanel_MasterPage2 : System.Web.UI.MasterPage
{    
    prpLogin objlogin;

    clsBLSetup obj;
    clsBLview objview;
    PRPSetup objprp, objparm;

    clsBLprofile obj1;
    prpLogin prppram,prplogin;

    String MaxId = "";

    static String Images="";
    string loginId = "";
    string loginType = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.Cache.SetNoStore();


        if (Page.IsPostBack == false)
        {
            bindLogin();
            getNews();

            loginType = Session["Login"].ToString();
           
        }

        if (loginType == "8" )
        {
            LinkButton5.Visible = true;
            LinkButton1.Visible = false;

        }

        else if (loginType == "5")
        {
            LinkButton5.Visible = true;
            LinkButton1.Visible = false;
        }
        else
        {
            LinkButton1.Visible = true;
            LinkButton5.Visible = false;

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
            imglogo.ImageUrl = "http://www.edumateworld.com" + objlogin.urlPath;
         
            if (objlogin.loginType == "4" || objlogin.loginType == "3" || objlogin.loginType == "2")
            {
                litPlacement.Text = "<a href='../JobPlacement/UpdateJobProfile.aspx'>Placement Cell</a>";
                College.Visible = true;
                Student.Visible = false;
                College1.Visible = false;

            }
            else if (objlogin.loginType == "5")
            {
                litPlacement.Text = "<a href='../JobPlacement/UpdateJobProfile.aspx'>Placement Cell</a>";
                College1.Visible = true;
                College.Visible = false;
                Student.Visible = false;
                }
            else if (objlogin.loginType == "8")
                {
                 College.Visible = false;
                Student.Visible =  true;
                College1.Visible = false;
    
            }
            else
            {
                litPlacement.Text = "<a href='../JobPlacement/JD-Form.aspx'>Job Details Cell</a>";
               
            }
           
        }
        else
        {
            Response.Redirect("../Default.aspx", false);
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
              
            }
            else
            {
               
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

                imagepath = "~/CollegeImage/" + MaxId + FileUpload1.FileName;
                serverpath = Server.MapPath(imagepath);
                FileUpload1.SaveAs(serverpath);
                Images = "/CollegeImage/"+MaxId+FileUpload1.FileName;

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

            objprp.codeId = Session["Login"].ToString();
            objprp.urlId = prplogin.EmployeeId;
            objprp.urlPath = Images;
            if (prplogin.loginType == "8" || prplogin.loginType=="5")
            {
                st = bl.UpStudentLogo(objprp);

            }
            else
            {
                st = bl.updateLogoImage(objprp);
            }
            if (st == "Succssfully Updated..")
            {

                //imglogo.ImageUrl = "http://localhost:58757/edumateNew"+Images;
                imglogo.ImageUrl = "http://www.edumateworld.com" + Images;
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
            lblMsg.Text = ex.Message.ToString();
        }
    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        String webname = "";
        objlogin = (prpLogin)(Session["OfficeCollege"]);
        webname = objlogin.webSite;
        ViewState["codeId"] = objlogin.EmployeeId;
        if (Session["OfficeCollege"] != null)
        {
            objlogin = (prpLogin)(Session["OfficeCollege"]);

            if (objlogin.loginType == "8")
            {
                Response.Redirect("~/Studentprofile/" + objlogin.EmployeeId + "");
            }
        }
     
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        String webname = "";
        objlogin = (prpLogin)(Session["OfficeCollege"]);
        webname = objlogin.webSite;
        ViewState["codeId"] = objlogin.EmployeeId;
         objlogin = new prpLogin();
        if (Session["OfficeCollege"] != null)
        {
            objlogin = (prpLogin)(Session["OfficeCollege"]);

            imglogo.ImageUrl = "http://www.edumateworld.com" + objlogin.urlPath;

            if (objlogin.loginType == "4" || objlogin.loginType == "3"|| objlogin.loginType == "2")
            {
         
                 Response.Redirect("~/Insttituteprofile/" + objlogin.EmployeeId + "");
            }
            else if(objlogin.loginType == "5")
            {
                 Response.Redirect("~/Tutorprofile/" + objlogin.EmployeeId + "");
                
            }
            else if (objlogin.loginType == "8")
            {
                Response.Redirect("~/Studentprofile/" + objlogin.EmployeeId + "");
            }
        }
    }

   
}




