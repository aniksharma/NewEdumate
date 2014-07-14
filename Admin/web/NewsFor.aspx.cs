using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using nmsSetup;
using nmsDropDown;

public partial class Admin_web_NewsFor : System.Web.UI.Page
{
    clsBLSetup obj;
    PRPSetup objprp, objparm;
    //static string Id = "";
    static string Id = "", imgurl = "", imageId = "", fileURL = "", MaxId = "";
    string path = "";
    int expstn;
    protected void Page_Load(object sender, EventArgs e)
    {
       
        lblMsg.Text = "";
        lblMsg.CssClass = "lr";

        if (!Page.IsPostBack)
        {

            bindNewFor();
        }
    }
    //----------------------bind List Box-------------------
  

    #region Bind Country State Dist & City

    //private void bindCountry()
    //{
    //    clsBLdropDown drp = new clsBLdropDown();
    //    clsPRPdropdown drpprp = new clsPRPdropdown();
    //    drpprp.controlList = ddlCountry;
    //    drpprp.spName = "viewCountry";
    //    drp.bindDropDown(drpprp);
      
    //}
    //protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    if (ddlCountry.SelectedIndex != 0)
    //        GetStateName();
    //}
    //private void GetStateName()
    //{
    //    clsBLdropDown objdrp = new clsBLdropDown();
    //    clsPRPdropdown objprpdrp = new clsPRPdropdown();
    //    objprpdrp.controlList = ddlUniversity;
    //    if (ddlCountry.SelectedIndex != 0)
    //        objprpdrp.id = Convert.ToInt32(ddlCountry.SelectedValue);
    //    objprpdrp.spName = "viewState";
    //    objdrp.bindDropDown(objprpdrp);
    //    ddlUniversity.SelectedIndex = -1;
    //}
    //protected void ddlUniversity0_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    bindDist();

    //}
    //private void bindDist()
    //{
    //    clsBLdropDown drp = new clsBLdropDown();
    //    clsPRPdropdown drpprp = new clsPRPdropdown();
    //    drpprp.controlList = ddlDist;

    //    if (ddlUniversity.SelectedIndex != 0)
    //        drpprp.id = Convert.ToInt32(ddlUniversity.SelectedValue);
    //    drpprp.spName = "viewDistrict";
    //    drp.bindDropDown(drpprp);
    //    ddlUniversity0.SelectedIndex = 1;
    //}
    //protected void ddlDist_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    bindCity();
    //}
    //private void bindCity()
    //{
    //    clsBLdropDown drps = new clsBLdropDown();
    //    clsPRPdropdown drpprps = new clsPRPdropdown();
    //    drpprps.controlList = ddlCity;
    //    if (ddlDist.SelectedIndex != 0)
    //        drpprps.id = Convert.ToInt32(ddlDist.SelectedValue);
    //    drpprps.spName = "viewCity";
    //    drps.bindDropDown(drpprps);
    //}

    #endregion




    private void bindNewFor()
    {
        obj = new clsBLSetup();
        Repeater1.DataSource = obj.viewNewsFor();
        Repeater1.DataBind();
    }
    private void BindTextboxes()
    {

        objprp = new PRPSetup();
        objparm = new PRPSetup();
        obj = new clsBLSetup();
        objparm.id = ViewState["id"].ToString(); //lstbox.SelectedValue;
        objprp = obj.SelNewsFor(objparm);
        ViewState["id"] = objprp.id;
        txtUserName.Text = objprp.name;
        ListItem lt;
        lt = rblStatus.Items.FindByValue(objprp.isActive);
        rblStatus.SelectedIndex = rblStatus.Items.IndexOf(lt);        
        txtSubtitle.Text = objprp.title;
        txtdescription.Text = objprp.description;
        imgurl = objprp.urlPath;
       

    }
    private void insertValue()
    {
        objprp = new PRPSetup();
        obj = new clsBLSetup();
        objprp.name = txtUserName.Text;
        objprp.title = txtSubtitle.Text;
        objprp.description = txtdescription.Text;
        uploadfile();
        objprp.urlPath = imgurl;
        objprp.isActive = rblStatus.SelectedValue;
        #region Added new value Country State Dist City
        //objprp.uniID = ddlCountry.SelectedValue;
        //objprp.state = ddlUniversity.SelectedValue;
        //objprp.district = ddlDist.SelectedValue;
        //objprp.city = ddlCity.SelectedValue;
        #endregion
        lblMsg.Text = obj.InsNewsFor(objprp);
    }
    private void updateValue()
    {
        objprp = new PRPSetup();
        obj = new clsBLSetup();
        objprp.id = ViewState["id"].ToString();
        objprp.name = txtUserName.Text;

        objprp.title = txtSubtitle.Text;
        objprp.description = txtdescription.Text;
        uploadfile();
        objprp.urlPath = imgurl;

        objprp.isActive = rblStatus.SelectedValue;
        lblMsg.Text = obj.UpdNewsFor(objprp);
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
           
            bindNewFor();
            txtUserName.Text = "";
            txtSubtitle.Text = "";
            txtdescription.Text = "";
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
        objparm.id = ViewState["id"].ToString();
        lblMsg.Text = obj.DelNewsFor(objparm);
        // bindlist();
        bindNewFor();
        txtUserName.Text = "";
        txtUserName.Focus();
        btnDelete.Visible = false;
    }
    private void checkFileUploadedPath()
    {
        clsDLSetup objprm = new clsDLSetup();
        clsBLSetup obj = new clsBLSetup();
        // objprm.spName = "";
        MaxId = obj.GetMaxFileId();
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
               
                imgurl = "../NewsImages/" + MaxId + FileUpload1.FileName;
                path = Server.MapPath("~/" + MaxId + FileUpload1.FileName);
                FileUpload1.SaveAs(path);

            }

        }
        //  return i;
    }
  
    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        ViewState["id"] = e.CommandArgument.ToString();
        BindTextboxes();
        btnDelete.Visible = true;
    }
}
