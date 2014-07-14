using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using nmsSetup;
using nmsDropDown;

public partial class Admin_web_AddDistrict : System.Web.UI.Page
{
    clsBLSetup obj;
    PRPSetup objprp, objparm;
    static string Id = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        lblMsg.Text = "";
        lblMsg.CssClass = "lr";

        if (!Page.IsPostBack)
        {
            binduniversity();
            bindState();
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
        ddlUniversity0.SelectedIndex = 1;
    }
    private void bindState()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddlUniversity;
        if (ddlUniversity0.SelectedIndex != 0)
            drpprp.id = Convert.ToInt32(ddlUniversity0.SelectedValue);

        drpprp.spName = "viewState";
        drp.bindDropDown(drpprp);
        
    }
    private void bindlist()
    {
        clsBLdropDown objdrp = new clsBLdropDown();
        clsPRPdropdown objprpdrp = new clsPRPdropdown();

        objprpdrp.controlList = lstbox;
        if (ddlUniversity.SelectedIndex != 0)
            objprpdrp.id = Convert.ToInt32(ddlUniversity.SelectedValue);
        objprpdrp.spName = "viewDistrict";
        objdrp.bindControlList(objprpdrp);
    }
    private void BindTextboxes()
    {
        objprp = new PRPSetup();
        objparm = new PRPSetup();
        obj = new clsBLSetup();
        objparm.id = lstbox.SelectedValue;
        objprp = obj.SelDistrict(objparm);
        Id = objprp.id;
        txtUserName.Text = objprp.name;
        ListItem lt;
        lt = rblStatus.Items.FindByText(objprp.isActive);
        rblStatus.SelectedIndex = rblStatus.Items.IndexOf(lt);
    }
    private void insertValue()
    {
        objprp = new PRPSetup();
        obj = new clsBLSetup();
        objprp.name = txtUserName.Text;
        objprp.uniID = ddlUniversity.SelectedValue;
        lblMsg.Text = obj.InsDistrict(objprp);
    }
    private void updateValue()
    {
        objprp = new PRPSetup();
        obj = new clsBLSetup();
        objprp.id = Id;
        objprp.name = txtUserName.Text;
        objprp.uniID = ddlUniversity.SelectedValue;
        objprp.isActive = rblStatus.SelectedValue;
        lblMsg.Text = obj.UpdDistrict(objprp);
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
        objparm = new PRPSetup();
        obj = new clsBLSetup();
        objparm.id = Id;
        lblMsg.Text = obj.DelDistrict(objparm);
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
    protected void ddlUniversity0_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlUniversity0.SelectedIndex != 0)
            bindState();

    }
}
