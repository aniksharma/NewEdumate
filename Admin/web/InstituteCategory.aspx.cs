using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using nmsSetupWeb;
using nmsDropDown;
using nmsView;
public partial class Admin_web_InstituteCategory : System.Web.UI.Page
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

        }
    }
    //----------------------bind List Box-------------------
    private void bindlist()
    {
        clsBLdropDown objdrp = new clsBLdropDown();
        clsPRPdropdown objprpdrp = new clsPRPdropdown();
        objprpdrp.controlList = lstbox;
        if (RadioButtonList1.SelectedIndex != -1)
        {
            objprpdrp.id = Convert.ToInt32(RadioButtonList1.SelectedValue);
        }
        objprpdrp.spName = "crsViewAllMainCategory";
        objdrp.bindControlList(objprpdrp);
    }
    private void BindTextboxes()
    {
        objprp = new PRPSetupWeb();
        objparm = new PRPSetupWeb();
        obj = new clsBLSetupWeb();
        objparm.id = lstbox.SelectedValue;
        objprp = obj.SelMainCategory(objparm);
        Id = objprp.id;
        txtUserName.Text = objprp.name;
        txtdescription.Text = objprp.description;
        txtSubtitle.Text = objprp.title;
        imgurl = objprp.urlPath;
        ListItem lt;
        lt = RadioButtonList1.Items.FindByValue(objprp.isActive);
        RadioButtonList1.SelectedIndex = RadioButtonList1.Items.IndexOf(lt);
    }
    private void insertValue()
    {
        objprp = new PRPSetupWeb();
        obj = new clsBLSetupWeb();
        objprp.name = txtUserName.Text;
        objprp.uniID = RadioButtonList1.SelectedValue;
        objprp.title = txtSubtitle.Text;
        objprp.description = txtdescription.Text;
        uploadfile();
        objprp.urlPath = imgurl;
        lblMsg.Text = obj.InsMainCategory(objprp);
    }
    private void checkFileUploadedPath()
    {
        clsPRPParm objprm = new clsPRPParm();
        clsBLview obj = new clsBLview();
        objprm.spName = "spGetMaxMainCategory";
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

                //if (btn_submit.Text != "Save")
                //{
                //    MaxId = imageId;
                //}
                //else
                //{
                checkFileUploadedPath();
                //}


                imgurl = "../CourseImage/" + MaxId + FileUpload1.FileName;
                path = Server.MapPath("~/" + MaxId + FileUpload1.FileName);
                FileUpload1.SaveAs(path);

            }

        }
        //  return i;
    }
    private void updateValue()
    {
        objprp = new PRPSetupWeb();
        obj = new clsBLSetupWeb();
        objprp.id = Id;
        objprp.name = txtUserName.Text;
        objprp.uniID = RadioButtonList1.SelectedValue;
        objprp.title = txtSubtitle.Text;
        objprp.description = txtdescription.Text;
        uploadfile();
        objprp.urlPath = imgurl;
        lblMsg.Text = obj.UpdMainCategory(objprp);
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
            txtdescription.Text = "";
            txtSubtitle.Text = "";
            txtUserName.Focus();
            btnDelete.Visible = false;
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        txtUserName.Text = "";
        txtUserName.Focus();
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        objparm = new PRPSetupWeb();
        obj = new clsBLSetupWeb();
        objparm.id = Id;
        lblMsg.Text = obj.DelMainCategory(objparm);
        bindlist();
        txtUserName.Text = "";
        txtUserName.Focus();
        btnDelete.Visible = false;
    }
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        bindlist();
    }
}
