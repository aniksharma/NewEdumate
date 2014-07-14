using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using nmsDropDown;
using nmsView;
using System.IO;
using nmsSetupUniversity;

public partial class Admin_web_UniversityType : System.Web.UI.Page
{
    clsBLUniversity obj;
    PRPSetupUniversity objprp, objparm;
    static string Id = "";
    static string imageId = "", fileURL = "";
    string imgurl = "", path = "", MaxId = "";
    protected void Page_Load(object sender, EventArgs e)
    {
      
        if (!Page.IsPostBack)
        {
            bindCountry();

            bindlist();

        }
    }
    //----------------------bind List Box-------------------
    private void bindlist()
    {
        objprp = new PRPSetupUniversity();
        objparm = new PRPSetupUniversity();
        obj = new clsBLUniversity();
        Repeater1.DataSource = obj.viewUniversityType(objprp);
        Repeater1.DataBind();

    }
    private void BindTextboxes()
    {
        objprp = new PRPSetupUniversity();
        objparm = new PRPSetupUniversity();
        obj = new clsBLUniversity();

        ddlCountry.Visible = false;
        ddlUniversity.Visible = false;
        ddlDist.Visible = false;       
        lblCountry.Visible = true;
        lblState.Visible = true;
        lblDist.Visible = true;
       



        objparm.id = ViewState["id"].ToString();
        objprp = obj.SelUniversityType(objparm);
        Id = objprp.id;
        txtUserName.Text = objprp.name;
        Editor1.Text = objprp.description;
        lblImgUrl.Text = objprp.urlPath;
        txtSubTitle.Text = objprp.title;
        lblCountry.Text = objprp.country;
        lblState.Text = objprp.state;
        lblDist.Text = objprp.district;
       
        ListItem lt;
        lt = rblStatus.Items.FindByValue(objprp.isActive);
        rblStatus.SelectedIndex = rblStatus.Items.IndexOf(lt);
    }
    private void insertValue()
    {
        objprp = new PRPSetupUniversity();
        obj = new clsBLUniversity();
        objprp.name = txtUserName.Text;
        objprp.isActive = rblStatus.SelectedValue;
        objprp.description = Editor1.Text;
        objprp.title = txtSubTitle.Text;        
        objprp.urlPath = imgurl;
        objprp.country = ddlCountry.SelectedValue;
        objprp.state = ddlUniversity.SelectedValue;
        objprp.district = ddlDist.SelectedValue;
        lblMsg.Text = obj.InsUniversityType(objprp);
    }
    private void updateValue()
    {
        objprp = new PRPSetupUniversity();
        obj = new clsBLUniversity();
        objprp.id = Id;
        objprp.name = txtUserName.Text;
        objprp.isActive = rblStatus.SelectedValue;
        objprp.description = Editor1.Text;
        objprp.title = txtSubTitle.Text;
        // uploadfile();
        objprp.urlPath = imgurl;
        if (imgurl != lblImgUrl.Text && imgurl != "" && lblImgUrl.Text != "")
        {
            File.Delete(Server.MapPath("../" + lblImgUrl.Text));
        }
        lblMsg.Text = obj.UpdUniversityType(objprp);
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

                int Siz = FileUpload1.PostedFile.ContentLength;
                double size = (Siz) / 1024.00;
                if (size > 14)
                {

                    imgurl = "MoreSize";
                }
                else
                {
                    imgurl = "../UniversityImage/" + MaxId + FileUpload1.FileName;
                    path = Server.MapPath("~/UniversityImage/" + imgurl);
                    FileUpload1.SaveAs(path);

                }
                // i = 1;
            }
            else
            {
                lblMsg.Text = "Please Upload a Correct Image File !";
                // i = -1;
            }
        }
        else
        {
            imgurl = lblImgUrl.Text;
        }
        // return i;
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
        if (Page.IsValid)
        {
            try
            {
                uploadfile();
                if (imgurl != "MoreSize")
                {
                    if (btnSubmit.Text == "Update")
                    {
                        updateValue();
                        btnSubmit.Text = "Submit";
                    }
                    else
                    {
                        insertValue();
                    }
                    bindlist();
                    txtUserName.Text = "";
                    Editor1.Text = "";
                    txtSubTitle.Text = "";
                    txtUserName.Focus();
                    btnDelete.Visible = false;
                }
                else
                {
                    Response.Write(" <script>" + "alert('Please Upload Image Of 14 kb or less then 14kb');" + "</script>");
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
            }
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        txtUserName.Text = "";
        txtUserName.Focus();
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        objparm = new PRPSetupUniversity();
        obj = new clsBLUniversity();
        objparm.id = Id;
        lblMsg.Text = obj.DelUniversityType(objparm);
        bindlist();
        txtUserName.Text = "";
        txtUserName.Focus();
        btnDelete.Visible = false;
    }
    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {

        ViewState["id"] = e.CommandArgument.ToString();
        BindTextboxes();
        btnSubmit.Text = "Update";
    }

    #region Country State by Devesh
    private void bindCountry()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddlCountry;
        drpprp.spName = "viewCountry";
        drp.bindDropDown(drpprp);
        //ddlCountry.SelectedIndex = -1;
    }
    protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlCountry.SelectedIndex != 0)
            GetStateName();
    }
    private void GetStateName()
    {
        clsBLdropDown objdrp = new clsBLdropDown();
        clsPRPdropdown objprpdrp = new clsPRPdropdown();
        objprpdrp.controlList = ddlUniversity;
        if (ddlCountry.SelectedIndex != 0)
            objprpdrp.id = Convert.ToInt32(ddlCountry.SelectedValue);
        objprpdrp.spName = "viewState";
        objdrp.bindDropDown(objprpdrp);
        ddlUniversity.SelectedIndex = -1;
    }

    protected void ddlUniversity0_SelectedIndexChanged(object sender, EventArgs e)
    {
        bindDist();

    }

    private void bindDist()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddlDist;

        if (ddlUniversity.SelectedIndex != 0)
            drpprp.id = Convert.ToInt32(ddlUniversity.SelectedValue);
        drpprp.spName = "viewDistrict";
        drp.bindDropDown(drpprp);
        //ddlUniversity0.SelectedIndex = 1;
    }
    
    #endregion

}
