using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using nmsSetup;
using nmsDropDown;
using nmsSetupWeb;
using nmsView;
public partial class Admin_web_Category : System.Web.UI.Page
{
    clsBLSetup obj;
    PRPSetup objprp, objparm;

    clsBLSetupWeb objWeb;
    PRPSetupWeb objprpWeb, objparmWeb;



    static string  imgurl = "", imageId = "", fileURL = "", MaxId = ""; //Id = "",
    string path = "";
    int expstn;
    static string Id = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        lblMsg.Text = "";
        lblMsg.CssClass = "lr";

        if (!Page.IsPostBack)
        {
            binduniversity();
            bindlist();
        }
    }
    //----------------------bind List Box-------------------
    private void binduniversity()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddlUniversity0;
        drpprp.spName = "viewCountry";
        drp.bindDropDown(drpprp);
        //ddlUniversity0.SelectedIndex = 1;
    }
    private void bindlist()
    {
        clsBLdropDown objdrp = new clsBLdropDown();
        clsPRPdropdown objprpdrp = new clsPRPdropdown();

        objprpdrp.controlList = lstbox;
        if (ddlUniversity0.SelectedIndex != 0)
            objprpdrp.id = Convert.ToInt32(ddlUniversity0.SelectedValue);
        objprpdrp.Type = RadioButtonList1.SelectedValue;
        objprpdrp.spName = "GetAllCategory";
        objdrp.bindCategoryControlList(objprpdrp);
    }
    

    private void BindTextboxes()
    {
        objprpWeb = new PRPSetupWeb();
        objparmWeb = new PRPSetupWeb();
        objWeb = new clsBLSetupWeb();
        objparmWeb.id = lstbox.SelectedValue;
        objprpWeb = objWeb.SelMainCategory(objparmWeb);
        Id = objprpWeb.id;
        txtUserName.Text = objprpWeb.name;
        txtdescription.Text = objprpWeb.description;
        txtSubtitle.Text = objprpWeb.title;
        imgurl = objprpWeb.urlPath;
       
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
    protected void lstbox_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindTextboxes();
        btnDelete.Visible = true;
    }
    
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        txtUserName.Text = "";
        txtUserName.Focus();
    }
  
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        objparmWeb = new PRPSetupWeb();
        objWeb = new clsBLSetupWeb();
        objparmWeb.id = Id;
        lblMsg.Text = objWeb.DelMainCategory(objparmWeb);
        bindlist();
        txtUserName.Text = "";
        txtUserName.Focus();
        btnDelete.Visible = false;
    }



  
    protected void ddlUniversity0_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlUniversity0.SelectedIndex != 0)
            bindlist();

    }

    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        binduniversity();
        bindlist();
    }

    #region Save Update  checkFileUploadedPath uploadfile

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            if (btnDelete.Visible == true)
            {
                updateValue();
            }
            else
            {
                insertValue();
            }
            bindlist();
            txtUserName.Text = "";
            txtdescription.Text = "";
            txtSubtitle.Text = "";
            txtUserName.Focus();
            btnDelete.Visible = false;
        }
    }


    private void insertValue()
    {
        objprpWeb = new PRPSetupWeb();
        objWeb = new clsBLSetupWeb();
        objprpWeb.sCountry = Convert.ToString(ddlUniversity0.SelectedValue);
        //objprpWeb.state = Convert.ToString(ddlUniversity.SelectedValue);
        objprpWeb.name = txtUserName.Text;
        objprpWeb.uniID = RadioButtonList1.SelectedValue;
        objprpWeb.title = txtSubtitle.Text;
        objprpWeb.description = txtdescription.Text;
        uploadfile();
        objprpWeb.urlPath = imgurl;
            
        lblMsg.Text = objWeb.InsMainCategory(objprpWeb);
    }
    private void updateValue()
    {
        objprpWeb = new PRPSetupWeb();
        objWeb = new clsBLSetupWeb();       
        objprpWeb.id = Id;
        objprpWeb.sCountry = Convert.ToString(ddlUniversity0.SelectedValue);
        //objprpWeb.state = Convert.ToString(ddlUniversity.SelectedValue);
        objprpWeb.name = txtUserName.Text;
        objprpWeb.uniID = RadioButtonList1.SelectedValue;
        objprpWeb.title = txtSubtitle.Text;
        objprpWeb.description = txtdescription.Text;
        uploadfile();
        objprpWeb.urlPath = imgurl;
        lblMsg.Text = objWeb.UpdMainCategory(objprpWeb);
    }

    private void checkFileUploadedPath()
    {
        clsPRPParm newObjprm = new clsPRPParm();
        clsBLview newObj = new clsBLview();
        //newObjprm.spName = "spGetMaxMainCategory";
        newObjprm.spName = "spGetfieMaxId";        
        MaxId = newObj.GetMaxFileId(newObjprm);
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
                imgurl = "../images/CourseImage/" + MaxId + FileUpload1.FileName;
                path = Server.MapPath("~/images/CourseImage/" + MaxId + FileUpload1.FileName);
                FileUpload1.SaveAs(path);

            }

        }
      
    }
    #endregion
}
