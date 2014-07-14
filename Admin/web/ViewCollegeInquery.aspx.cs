using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using nmsSetup;
using nmsView;
using nmsDropDown;

public partial class Admin_web_ViewCollegeInquery : System.Web.UI.Page
{
    clsBLSetup obj;
    clsBLview objview;
    PRPSetup objprp, objparm;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    //--Start Pagging.....
    private void SelectDatail(Int32 pageIndex)
    {

        obj = new clsBLSetup();
        objparm = new PRPSetup();
        Int32 pageSize = Convert.ToInt32(ddlNopage.SelectedValue);

        objparm.pageIndex = pageIndex.ToString();
        objparm.pageSize = pageSize.ToString();
        if (ddlmainStream.SelectedIndex > 0)
        {
            objparm.uniID = ddlmainStream.SelectedValue;
        }
        if (ddlCategory.SelectedIndex > 0)
        {
            objparm.catID = ddlCategory.SelectedValue;
        }
        List<PRPSetup> lst = new List<PRPSetup>();

        lst = obj.ViewCollegeInqueryDetail(objparm);
        if (lst[0].srNo != "Result Not Find")
        {
            Int32 noOfRecord = Convert.ToInt32(lst[lst.Count - 1].noOfRecord);

            lst.RemoveAt(lst.Count - 1);
            Repeater1.DataSource = lst;
            Repeater1.DataBind();
            //---------for page work here
            lblCurrentPage.Text = pageIndex.ToString();
            if ((noOfRecord % pageSize) == 0)
                lblLastPage.Text = Convert.ToInt32(noOfRecord / pageSize).ToString();
            else
                lblLastPage.Text = Convert.ToInt32(noOfRecord / pageSize + 1).ToString();

            lnkfstPage.Enabled = true;
            lnkLastpage.Enabled = true;
            lnkNextpage.Enabled = true;
            lnkPrepage.Enabled = true;
            if (pageIndex == 1)
            {
                lnkfstPage.Enabled = false;
                lnkPrepage.Enabled = false;
            }
            if (pageIndex == Convert.ToInt32(lblLastPage.Text))
            {
                lnkLastpage.Enabled = false;
                lnkNextpage.Enabled = false;
            }
            //----------------------------------------------

        }
        else
        {
            Repeater1.DataSource = null;
            Repeater1.DataBind();
            lblMsg.Text = "Result Not Found";

        }
    }
    protected void ddlNopage_SelectedIndexChanged(object sender, EventArgs e)
    {
        SelectDatail(1);
    }
    protected void lnkfstPage_Click(object sender, EventArgs e)
    {
        SelectDatail(1);
    }
    protected void lnkPrepage_Click(object sender, EventArgs e)
    {
        SelectDatail(Convert.ToInt32(lblCurrentPage.Text) - 1);

    }
    protected void lnkNextpage_Click(object sender, EventArgs e)
    {
        SelectDatail(Convert.ToInt32(lblCurrentPage.Text) + 1);
    }
    protected void lnkLastpage_Click(object sender, EventArgs e)
    {
        SelectDatail(Convert.ToInt32(lblLastPage.Text));
    }
    protected void lnkBtnGO_Click(object sender, EventArgs e)
    {
        if (Convert.ToInt32(txtGoPage.Text) >= 0 && Convert.ToInt32(txtGoPage.Text) <= Convert.ToInt32(lblLastPage.Text))
        {
            SelectDatail(Convert.ToInt32(txtGoPage.Text));
        }
        else
        {
            SelectDatail(Convert.ToInt32(lblLastPage.Text));
        }
    }
    //---------End Pagging...............
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        binduniversity();
    }
    private void binduniversity()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddlmainStream;
        drpprp.id = Convert.ToInt32(RadioButtonList1.SelectedValue);
        drpprp.spName = "crsViewAllMainCategory";
        drp.bindDropDown(drpprp);
        ddlmainStream.SelectedIndex = 1;
    }
    protected void ddlmainStream_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlmainStream.SelectedIndex != 0)
            bindlist();
    }
    private void bindlist()
    {
        clsBLdropDown objdrp = new clsBLdropDown();
        clsPRPdropdown objprpdrp = new clsPRPdropdown();
        objprpdrp.controlList = ddlCategory;

        if (ddlmainStream.SelectedIndex != 0)
            objprpdrp.id = Convert.ToInt32(ddlmainStream.SelectedValue);
        objprpdrp.spName = "crsViewAllSubCategory";
        objdrp.bindDropDown(objprpdrp);
    }
    protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        SelectDatail(1);
    }
    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        string st = e.CommandArgument.ToString();
        if (e.CommandName == "Delete")
        {
            objprp = new PRPSetup();
            obj = new clsBLSetup();
            objprp.id = st;

            lblMsg.Text = obj.DelCollegeInqueryDetail(objprp);
            SelectDatail(1);
        }
    }
}