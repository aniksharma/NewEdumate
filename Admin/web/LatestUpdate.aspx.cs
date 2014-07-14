using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using nmsSetupWeb;
using nmsProfile;

public partial class Admin_web_LatestUpdate : System.Web.UI.Page
{
    clsBLSetupWeb obj;
    PRPSetupWeb objprp, objparm;
    static Int32 newsId = 0;
    prpLogin objlog = new prpLogin();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["OfficeAdmin"] == null)
        {
            Response.Redirect("../../web/login.aspx?logout=session&path=Admin/Web/LatestUpdate.aspx");
        }

        if (Page.IsPostBack == false)
        {
            SelectDatail(1);
        }

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (btnSubmit.Text == "Update")
        {
            updateValue();

        }
        else
        {
            insertValue();

        }
    }
    private void updateValue()
    {
        objprp = new PRPSetupWeb();
        obj = new clsBLSetupWeb();
        objprp.id = newsId.ToString();
        objprp.title = txttitle.Text;
        objprp.description = Editor1.Text;
        lblsms.Text = obj.updLatesteUpdate(objprp);
        if (lblsms.Text == "Successfully Updated...!")
        {
            btnSubmit.Text = "Submit";
            txttitle.Text = "";
            Editor1.Text = "";
        }
    }
    private void insertValue()
    {
        objprp = new PRPSetupWeb();
        obj = new clsBLSetupWeb();
        objprp.title = txttitle.Text;
        objprp.description = Editor1.Text;
        objprp.status = "0";
        lblsms.Text = obj.InsLatesteUpdate(objprp);

        if (lblsms.Text == "Succssfully Inserted...!")
        {
            txttitle.Text = "";
            Editor1.Text = "";
        }
    }

    private void SelectDatail(Int32 pageIndex)
    {
        PRPSetupWeb prp = new PRPSetupWeb();
        clsBLSetupWeb bl = new clsBLSetupWeb();
        PRPSetupWeb prp1 = new PRPSetupWeb();

        Int32 pageSize = Convert.ToInt32(ddlNopage.SelectedValue);

        prp1.pageIndex = pageIndex.ToString();
        prp1.pageSize = pageSize.ToString();

        List<PRPSetupWeb> lst = new List<PRPSetupWeb>();
        lst = bl.ShowlatesteUpdate(prp1);
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

    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        Int32 st = Convert.ToInt32(e.CommandArgument);

        PRPSetupWeb prp = new PRPSetupWeb();
        clsBLSetupWeb bl = new clsBLSetupWeb();

        prp.id = st.ToString();

        if (e.CommandName == "Delete")
        {
            bl.delLatesteUpdate(prp);
            SelectDatail(1);
        }
        if (e.CommandName == "Edit")
        {
            objprp = new PRPSetupWeb();
            newsId = st;
            objprp = bl.bindLatestUpdate(prp);
            txttitle.Text = objprp.name;
            Editor1.Text = objprp.description;
            Update.Visible = true;
            btnSubmit.Text = "Update";
            ShowUpdate.Visible = false;
        }
    }
    private void CheckDayUpdate()
    {
        PRPSetupWeb prp = new PRPSetupWeb();
        clsBLSetupWeb bl = new clsBLSetupWeb();
        prp.codeId = lblId.Text;
        bl.CheckDayUpdates(prp);
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
}
