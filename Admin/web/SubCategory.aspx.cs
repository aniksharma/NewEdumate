using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using nmsSetupWeb;
using nmsDropDown;
using nmsView;
public partial class Admin_web_SubCategory : System.Web.UI.Page
{
    clsBLSetupWeb obj;
    PRPSetupWeb objprp, objparm;

    static string Id = "", imgurl = "", imageId = "", fileURL = "", MaxId = "";
    string path = "";
    int expstn;
    protected void Page_Load(object sender, EventArgs e)
    {
       
        lblMsg.Text = "";
        lblMsg.CssClass = "lr";

        if (!Page.IsPostBack)
        {
             BindCountry();
             binduniversity();
             bindlist();
            

        }
    }
    //----------------------bind List Box-------------------
    private void binduniversity()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddlUniversity;
        drpprp.id = Convert.ToInt32(RadioButtonList1.SelectedValue);
        drpprp.spName = "crsViewAllMainCategory";
        drp.bindDropDown(drpprp);
        ddlUniversity.SelectedIndex = 1;
    }
    private void bindlist()
    {
        clsBLdropDown objdrp = new clsBLdropDown();
        clsPRPdropdown objprpdrp = new clsPRPdropdown();
        objprpdrp.controlList = lstbox;

        if (ddlUniversity.SelectedIndex != 0)
            objprpdrp.id = Convert.ToInt32(ddlUniversity.SelectedValue);
        objprpdrp.Type = ddlCountry.SelectedValue;
        objprpdrp.spName = "crsViewAllSubCategory";
       // objdrp.bindControlList(objprpdrp);
        objdrp.bindCategoryControlList(objprpdrp);
        
    }
    private void BindTextboxes()
    {
        objprp = new PRPSetupWeb();
        objparm = new PRPSetupWeb();
        obj = new clsBLSetupWeb();
        objparm.id = lstbox.SelectedValue;
        objprp = obj.SelSubCategory(objparm);
        Id = objprp.id;
        txtUserName.Text = objprp.name;
        txtSubTitle.Text = objprp.title;
        txtDescription.Text = objprp.description;
        imgurl = objprp.urlPath;
        ListItem lt;
        lt = ddlUniversity.Items.FindByValue(objprp.uniID);
        ddlUniversity.SelectedIndex = ddlUniversity.Items.IndexOf(lt);
        //ddlUniversity.SelectedValue = objprp.uniID;
    }
    private void insertValue()
    {
        objprp = new PRPSetupWeb();
        obj = new clsBLSetupWeb();
        objprp.name = txtUserName.Text;
        objprp.sCountry = ddlCountry.SelectedValue;
        objprp.uniID = ddlUniversity.SelectedValue;        
        // objprp.isActive = rblStatus.SelectedValue;
        objprp.title = txtSubTitle.Text;
        objprp.description = txtDescription.Text;
        uploadfile();
        objprp.urlPath = imgurl;
        lblImage.Text = imgurl; ;
        lblMsg.Text = obj.InsSubCategory(objprp);
    }
    private void updateValue()
    {
        objprp = new PRPSetupWeb();
        obj = new clsBLSetupWeb();
        objprp.id = Id;
        objprp.name = txtUserName.Text;
        objprp.sCountry = ddlCountry.SelectedValue;
        objprp.uniID = ddlUniversity.SelectedValue;
        // objprp.isActive = rblStatus.SelectedValue;
        objprp.title = txtSubTitle.Text;
        objprp.description = txtDescription.Text;
        uploadfile();
        objprp.urlPath = imgurl;
        // objprp.isActive = rblStatus.SelectedValue;
        lblMsg.Text = obj.UpdSubCategory(objprp);
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
                imgurl = "../images/CourseImage/" + MaxId + FileUpload1.FileName;
                path = Server.MapPath("~/images/CourseImage/" + MaxId + FileUpload1.FileName);
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
    protected void lstbox_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindTextboxes();
        btnDelete.Visible = true;
    }
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
            txtSubTitle.Text = "";
            txtDescription.Text = "";
            txtUserName.Focus();
            btnDelete.Visible = false;
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        txtUserName.Text = "";
        txtUserName.Focus();
        btnDelete.Visible = false;
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        objparm = new PRPSetupWeb();
        obj = new clsBLSetupWeb();
        objparm.id = Id;
        lblMsg.Text = obj.DelSubCategory(objparm);
        bindlist();
        txtUserName.Text = "";
        txtUserName.Focus();
        btnDelete.Visible = false;
    }
    protected void ddlUniversity_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlUniversity.SelectedIndex != 0)
            bindlist();
    }
 
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {

        BindCountry();
        binduniversity();
        bindlist();
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
}
