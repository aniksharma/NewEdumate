using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using nmsSetup;
using nmsDropDown;
using nmsView;
using nmsSetupTick;
public partial class Admin_web_ViewComment : System.Web.UI.Page
{
    clsBLSetup obj;
    clsBLview objview;
    PRPSetup objprp, objparm;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            binduniversity();
            viewMComment();
        }
    }
    private void viewMComment()
    {
        clsBLSetupTick obj = new clsBLSetupTick();
        PRPSetupTick objprp = new PRPSetupTick();
        if (ddlTitle.SelectedIndex > 0)
        {
            objprp.codeId = ddlTitle.SelectedValue;//ViewState["newsId"].ToString();
        }
        else
        {
            objprp.codeId = "0";
        }
        if (ddlType.SelectedIndex > 0)
        {
            objprp.catID = ddlType.SelectedValue; //ViewState["newsTypeId"].ToString();
        }
        else
        {
            objprp.catID = "0";

        }
        List<PRPSetupTick> prp = new List<PRPSetupTick>();

        objprp.isActive = "1";
        objprp.urlId = "0";
        prp = obj.viewMCommentDetail3(objprp);

        Repeater2.DataSource = prp;
        Repeater2.DataBind();

    }
    public List<PRPSetupTick> GetData(object st)
    {

        clsBLSetupTick obj = new clsBLSetupTick();
        PRPSetupTick objprp = new PRPSetupTick();


        if (ddlType.SelectedIndex > 0)
        {
            objprp.codeId = ddlType.SelectedValue;//ViewState["newsId"].ToString();
        }
        if (ddlTitle.SelectedIndex > 0)
        {
            objprp.catID = ddlTitle.SelectedValue; //ViewState["newsTypeId"].ToString();
        }
        objprp.isActive = "1";
        objprp.urlId = "0";
        if (st != null)
        {
            objprp.id = st.ToString();
        }
        List<PRPSetupTick> lst1 = new List<PRPSetupTick>();
        lst1 = obj.ViewSCommentDetail(objprp);
        return lst1;
    }
    protected void Repeater2_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        e.CommandArgument.ToString();
        clsBLSetupTick obj = new clsBLSetupTick();
        PRPSetupTick objprp = new PRPSetupTick();
        objprp.id = e.CommandArgument.ToString();
        lblMsg.Text = obj.DelCommentDetail(objprp);
        // SelectDatail(1);         
        viewMComment();
    }
    private void binduniversity()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddlType;
        //drpprp.id = Convert.ToInt32(RadioButtonList1.SelectedValue);
        drpprp.spName = "bindNews";
        drp.bindDropDown(drpprp);
        // ddlType.SelectedIndex = 1;
        //viewMComment();
    }
    private void bindNewsType()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddlTitle;
        if (ddlType.SelectedIndex > 0)
        {
            drpprp.id = Convert.ToInt32(ddlType.SelectedValue);
        }
        drpprp.spName = "bindNewsTitle";
        drp.bindDropDown(drpprp);
        ddlTitle.SelectedIndex = 1;
    }
    protected void ddlType_SelectedIndexChanged(object sender, EventArgs e)
    {
        bindNewsType();
    }
    protected void ddlTitle_SelectedIndexChanged(object sender, EventArgs e)
    {
        viewMComment();
    }
    protected void repId_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        e.CommandArgument.ToString();
        clsBLSetupTick obj = new clsBLSetupTick();
        PRPSetupTick objprp = new PRPSetupTick();
        objprp.id = e.CommandArgument.ToString();
        lblMsg.Text = obj.DelCommentDetail(objprp);
        // SelectDatail(1);         
        viewMComment();
    }
}