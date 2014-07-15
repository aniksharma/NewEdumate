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

public partial class UserControl_LoginLeft : System.Web.UI.UserControl
{
    prpLogin objlogin;

    clsBLSetup obj;
    clsBLview objview;
    PRPSetup objprp, objparm;

    clsBLprofile obj1;
    prpLogin prppram, prplogin;

    String MaxId = "";

    static String Images = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.Cache.SetNoStore();


        if (Page.IsPostBack == false)
        {
            bindLogin();
            ViewStatus();
            getNews();
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
}