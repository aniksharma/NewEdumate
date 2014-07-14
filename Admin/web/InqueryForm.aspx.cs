using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using nmsSetup;
using nmsDropDown;
using nmsView;
using nmsSetupWeb;
public partial class Admin_web_InqueryForm : System.Web.UI.Page
{
    static Int32 sid;
    clsBLSetup obj;
    clsBLview objview;
    PRPSetup objprp, objparm;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            SelectDatail(1);
        }
    }


    //--Start Pagging.....
    private void SelectDatail(Int32 pageIndex)
    {

        clsBLSetupWeb obj = new clsBLSetupWeb();
        PRPSetupWeb objparm = new PRPSetupWeb();
        Int32 pageSize = Convert.ToInt32(ddlNopage.SelectedValue);

        objparm.pageIndex = pageIndex.ToString();
        objparm.pageSize = pageSize.ToString();

        List<PRPSetupWeb> lst = new List<PRPSetupWeb>();
        objparm.status = "0";
        lst = obj.ViewContactEnquiry(objparm);
        if (lst[0].srNo != "Result Not Find")
        {
            Int32 noOfRecord = Convert.ToInt32(lst[lst.Count - 1].noOfRecord);

            lst.RemoveAt(lst.Count - 1);
            datalist.DataSource = lst;
            datalist.DataBind();
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
            datalist.DataSource = null;
            datalist.DataBind();
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
    protected void datalist_ItemCommand(object source, DataListCommandEventArgs e)
    {
        String st = e.CommandArgument.ToString();
        if (e.CommandName == "Delete")
        {
            PRPSetupWeb objprp = new PRPSetupWeb();
            clsBLSetupWeb obj = new clsBLSetupWeb();
            objprp.id = st;

            lblMsg.Text = obj.DelContactEnquiry(objprp);
            SelectDatail(1);
        }

    }
}
