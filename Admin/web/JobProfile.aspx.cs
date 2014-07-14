using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using nmsSetup;
using nmsDropDown;
using nmsView;

public partial class Admin_web_JobProfile : System.Web.UI.Page
{
    PRPSetup prppram;
    PRPSetup prp;
    clsBLSetup bl;
    clsBLSetup obj;
    clsBLview objview;
    PRPSetup objprp, objparm;
    static string branchId = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            SelectDatail(1);
        }
    }
    private void SelectDatail(Int32 pageIndex)
    {

        obj = new clsBLSetup();
        objparm = new PRPSetup();
        Int32 pageSize = Convert.ToInt32(ddlNopage.SelectedValue);

        objparm.pageIndex = pageIndex.ToString();
        objparm.pageSize = pageSize.ToString();

        List<PRPSetup> lst = new List<PRPSetup>();

        lst = obj.ViewJobProfile(objparm);
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
    private void BindDelete()
    {
        prp = new PRPSetup();
        bl = new clsBLSetup();
        prp.codeId = branchId;
        lblMsg.Text = bl.DeleteJobDetails(prp);
    }
    protected void Repeater1_ItemCommand1(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "Delete")
        {
            branchId = e.CommandArgument.ToString();
            BindDelete();
            SelectDatail(1);
        }
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
    protected void ddlNopage_SelectedIndexChanged(object sender, EventArgs e)
    {
        SelectDatail(1);
    }
}