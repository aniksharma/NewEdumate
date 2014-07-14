using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using nmsSetupWeb;
using nmsDropDown;
using nmsView;

public partial class Admin_web_UpdateLogo : System.Web.UI.Page
{
    clsBLSetupWeb obj;
    PRPSetupWeb objprp, objparm;

    static string Id = "", imgurl = "", imageId = "", fileURL = "", MaxId = "";
    string path = "";
    int expstn;
    protected void Page_Load(object sender, EventArgs e)
    {
        // checker();
        lblMsg.Text = "";
        lblMsg.CssClass = "lr";

        if (!Page.IsPostBack)
        {
           


        }
    }
    //----------------------bind List Box-------------------
    protected void rbtType_SelectedIndexChanged(object sender, EventArgs e)
    {

        BindCountry();
        if (ddlCountry.SelectedIndex != 0)
            BindName();
    }

    private void BindName()
    {
        clsBLdropDown objdrp = new clsBLdropDown();
        clsPRPdropdown objprpdrp = new clsPRPdropdown();
        objprpdrp.controlList = ddlName;
        if (ddlName.SelectedIndex != 0)
            objprpdrp.id = Convert.ToInt32(rbtType.SelectedValue);
            objprpdrp.Type = ddlCountry.SelectedValue;        
            objprpdrp.spName = "GetCollegeName";       
            objdrp.bindCategoryControlList(objprpdrp);      
            //BindLogo();
            if (ddlName.SelectedIndex != 0)
            BindCollegeLogo();

    }
    private void BindCollegeLogo()
    {
        objprp = new PRPSetupWeb();
        objparm = new PRPSetupWeb();
        obj = new clsBLSetupWeb();
        objparm.id = ddlName.SelectedValue;
        if (ddlName.SelectedIndex != 0)
        objprp = obj.SelCollegeLogo(objparm);
        Id = objprp.id;       
        imgurl = objprp.urlPath;
       
        this.logo.Src = "../" + imgurl; 

        
        
    }

    private void UpdateLogo()
    {
        objprp = new PRPSetupWeb();
        obj = new clsBLSetupWeb();
        objprp.id = Id;
       
        objprp.sCountry = ddlCountry.SelectedValue;
        objprp.uniID = ddlName.SelectedValue; 
        uploadfile();
        objprp.urlPath = imgurl;

        lblMsg.Text = obj.UpdateCollegeLogo(objprp);
    }
    private void checkFileUploadedPath()
    {
        clsPRPParm objprm = new clsPRPParm();
        clsBLview obj = new clsBLview();        
        objprm.spName = "spGetfieMaxId";
        MaxId = obj.GetMaxFileId(objprm);
    }
    private void uploadfile()
    {
        //Int32 i = 1, len, expstn;

        if (FileUpload1.HasFile)
        {
            imgurl = FileUpload1.FileName;

            //  len = imgurl.Length;
            expstn = imgurl.LastIndexOf(".");

            path = imgurl.Substring(expstn);
            if (path == ".jpg" || path == ".jpeg" || path == ".bmp" || path == ".gif" || path == ".png" || path == ".JPG" || path == ".JPEG" || path == ".BMP" || path == ".GIF" || path == ".PNG")
            {             
                checkFileUploadedPath();
                imgurl = "../Advertisement/" + MaxId + FileUpload1.FileName;
                path = Server.MapPath("../../Advertisement/" + MaxId + FileUpload1.FileName);

                FileUpload1.SaveAs(path);

            }


        }
       
    }

    private void checker()
    {
        if (Session["OfficeAdmin"] == null)
        {
            nmsProfile.prpLogin objlog = new nmsProfile.prpLogin();
            objlog = (nmsProfile.prpLogin)(Session["OfficeAdmin"]);
            if (objlog.loginType != "1")
            {
                Response.Redirect("../Default.aspx?logout=session&path=Admin/Authority.aspx");
            }
        }
    }
   
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            UpdateLogo();
           

            if (lblMsg.Text == "Succssfully Updated..")
            {
                BindCollegeLogo();
            
            }
        }
        else
        {
            lblMsg.Text = "Please select logo!!!";
        }

         
        
    }
   
   
    protected void ddlName_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlName.SelectedIndex != 0)

           BindCollegeLogo();
           
    }

   

    #region Bind Country
    private void BindCountry()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddlCountry;
        drpprp.spName = "viewCountry";
        drp.bindDropDown(drpprp);
        ddlCountry.SelectedIndex = 1;
    }

    #endregion
    protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlCountry.SelectedIndex != 0)
             BindName();
        
    }
}
