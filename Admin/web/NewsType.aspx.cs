using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Collections.Generic;
using nmsSetup;
using nmsDropDown;
using nmsView;
using System.IO;

public partial class Admin_web_NewsType : System.Web.UI.Page
{
    clsBLSetup obj;
    PRPSetup objprp, objparm;
    static string Id = "";
    static string imageId = "", fileURL = "";
    // string catname;
    string imgurl = "", path = "", MaxId = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        // checker();
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
        drpprp.controlList = ddlUniversity;
        drpprp.spName = "SpBindNewsFor";
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
        objprpdrp.spName = "viewNewsType";
        objdrp.bindControlList(objprpdrp);
    }
    private void BindTextboxes()
    {
        objprp = new PRPSetup();
        objparm = new PRPSetup();
        obj = new clsBLSetup();
        objparm.id = lstbox.SelectedValue;
        objprp = obj.SelNewsType(objparm);
        Id = objprp.id;
        txtdescription.Text = objprp.description;
        txtSubtitle.Text = objprp.title;
        txtUserName.Text = objprp.name;
        ListItem lt;
        lt = rblStatus.Items.FindByValue(objprp.isActive);
        rblStatus.SelectedIndex = rblStatus.Items.IndexOf(lt);
        ddlUniversity.SelectedValue = objprp.uniID;

        lblImgUrl.Text = objprp.urlPath;
    }
    private void insertValue()
    {
        objprp = new PRPSetup();
        obj = new clsBLSetup();
        objprp.name = txtUserName.Text;
        objprp.uniID = ddlUniversity.SelectedValue;
        objprp.isActive = rblStatus.SelectedValue;
        objprp.description = txtdescription.Text;
        objprp.title = txtSubtitle.Text;
        uploadfile();
        objprp.urlPath = imgurl;
        lblMsg.Text = obj.InsNewsType(objprp);
    }
    private void updateValue()
    {
        objprp = new PRPSetup();
        obj = new clsBLSetup();
        objprp.id = Id;
        objprp.name = txtUserName.Text;
        objprp.uniID = ddlUniversity.SelectedValue;
        objprp.isActive = rblStatus.SelectedValue;
        objprp.description = txtdescription.Text;
        objprp.title = txtSubtitle.Text;
        uploadfile();
        objprp.urlPath = imgurl;
        if (imgurl != lblImgUrl.Text && imgurl != "" && lblImgUrl.Text != "")
        {
            File.Delete(Server.MapPath(lblImgUrl.Text));
        }
        lblMsg.Text = obj.UpdNewsType(objprp);
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
        btnDelete.Visible = false;
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        objparm = new PRPSetup();
        obj = new clsBLSetup();
        objparm.id = Id;
        lblMsg.Text = obj.DelNewsType(objparm);
        if (lblImgUrl.Text != "")
        {
            File.Delete(Server.MapPath("../" + lblImgUrl.Text));
        }
        bindlist();
        txtUserName.Text = "";
        txtUserName.Focus();
        btnDelete.Visible = false;
    }

    protected void ddlUniversity_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlUniversity.SelectedIndex != 0)
            bindlist();
        if (ddlUniversity.SelectedIndex == 3 || ddlUniversity.SelectedIndex == 4)
        {
            Image.Visible = true;
        }
        else
        {
            Image.Visible = false;
        }
    }
    private void checkFileUploadedPath()
    {
        clsPRPParm objprm = new clsPRPParm();
        clsBLview obj = new clsBLview();
        objprm.spName = "viewGetMaxNewsTypeId";
        MaxId = obj.GetMaxFileId(objprm);
    }
    private void uploadfile()
    {
        Int32 i = 1, len, expstn;

        if (FileUpload1.HasFile)
        {
            imgurl = FileUpload1.FileName;

            len = imgurl.Length;
            expstn = imgurl.LastIndexOf(".");

            path = imgurl.Substring(expstn);
            if (path == ".jpg" || path == ".jpeg" || path == ".bmp" || path == ".gif" || path == ".png" || path == ".JPG" || path == ".JPEG" || path == ".BMP" || path == ".GIF" || path == ".PNG")
            {

                if (btnDelete.Visible == false)
                {
                    MaxId = imageId;
                }
                else
                {
                    checkFileUploadedPath();
                }


                imgurl = "../CarrierImage/" + MaxId + FileUpload1.FileName;
                path = Server.MapPath("~/CarrierImage/" + imgurl);
                FileUpload1.SaveAs(path);

            }
            else
            {
                lblMsg.Text = "Please Upload a Correct Image File !";
            }
        }
        else
        {
            imgurl = lblImgUrl.Text;
        }

    }
}
