using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using nmsSetup;
using nmsDropDown;
public partial class Admin_web_SchoolCategory : System.Web.UI.Page
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
            bindlist();

        }
    }
    //----------------------bind List Box-------------------
    private void bindlist()
    {
        clsBLdropDown objdrp = new clsBLdropDown();
        clsPRPdropdown objprpdrp = new clsPRPdropdown();
        objprpdrp.controlList = lstbox;
        objprpdrp.spName = "viewSchoolCategory";
        objdrp.bindControlList(objprpdrp);
    }
    private void BindTextboxes()
    {
        objprp = new PRPSetup();
        objparm = new PRPSetup();
        obj = new clsBLSetup();
        objparm.id = lstbox.SelectedValue;
        objprp = obj.SelSchoolCategory(objparm);
        Id = objprp.id;
        txtUserName.Text = objprp.name;    

        ListItem lt;
        lt = rblStatus.Items.FindByValue(objprp.isActive);
        rblStatus.SelectedIndex = rblStatus.Items.IndexOf(lt);



    }
    private void insertValue()
    {
        objprp = new PRPSetup();
        obj = new clsBLSetup();
        objprp.name = txtUserName.Text;
        objprp.isActive = rblStatus.SelectedValue;
        lblMsg.Text = obj.InsSchoolCategory(objprp);
    }
    private void updateValue()
    {
        objprp = new PRPSetup();
        obj = new clsBLSetup();
        objprp.id = Id;
        objprp.name = txtUserName.Text;
        objprp.isActive = rblStatus.SelectedValue;
        lblMsg.Text = obj.UpdEducationType(objprp);
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
        lblMsg.Text = obj.DelSchoolCategory(objparm);
        bindlist();
        txtUserName.Text = "";
        txtUserName.Focus();
        btnDelete.Visible = false;
    }
}
