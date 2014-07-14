using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using nmsSetup;
using nmsDropDown;
using System.IO;

public partial class Admin_web_AddTextDetail : System.Web.UI.Page
{
    clsBLSetup obj;
    PRPSetup objprp, objparm;
    static string Id = "", Imgurl = "";
    string path = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        // checker();
        lblMsg.Text = "";
        lblMsg.CssClass = "lr";

        if (!Page.IsPostBack)
        {
            binduniversity();
            bindtextcategory();
            SelectDatail(1);
        }
    }
    //----------------------bind List Box-------------------
    private void binduniversity()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddlUniversity;
        drpprp.spName = "viwUniversityWeb1";
        drp.bindDropDown(drpprp);
        ddlUniversity.SelectedIndex = 1;
    }
    private void bindtextcategory()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddlTextCategory;
        drpprp.id = Convert.ToInt32(ddlUniversity.SelectedValue);
        drpprp.spName = "viewTextCategoryWeb";
        drp.bindDropDown(drpprp);
    }
    private void BindTextboxes()
    {
        objprp = new PRPSetup();
        objparm = new PRPSetup();
        obj = new clsBLSetup();
        objparm.id = Id;
        objprp = obj.SelTextWeb(objparm);
        Id = objprp.id;
        txt_title.Text = objprp.title;
        txt_desc.Content = objprp.description;
        Imgurl = objprp.urlPath;
        ListItem lt;
        lt = rblStatus.Items.FindByValue(objprp.isActive);
        rblStatus.SelectedIndex = rblStatus.Items.IndexOf(lt);

        lt = ddlUniversity.Items.FindByValue(objprp.uniID);
        ddlUniversity.SelectedIndex = ddlUniversity.Items.IndexOf(lt);

        bindtextcategory();

        lt = ddlTextCategory.Items.FindByValue(objprp.catID);
        ddlTextCategory.SelectedIndex = ddlTextCategory.Items.IndexOf(lt);

    }
    private void insertValue()
    {
        objprp = new PRPSetup();
        obj = new clsBLSetup();
        int sts = 0;
        if (FileUpload1.HasFile)
        {
            sts = uploadfile();
            if (sts != -1)
            {
                objprp.uniID = ddlUniversity.SelectedValue;
                objprp.catID = ddlTextCategory.SelectedValue;
                objprp.title = txt_title.Text;
                objprp.urlPath = Imgurl;
                objprp.description = txt_desc.Content;
                objprp.isActive = rblStatus.SelectedValue;
                lblMsg.Text = obj.InsTextWeb(objprp);

            }
        }

    }
    private void updateValue()
    {
        objprp = new PRPSetup();
        obj = new clsBLSetup();
        int sts = 0;
        if (FileUpload1.HasFile)
        {
            sts = uploadfile();
        }
        if (sts != -1)
        {
            objprp.id = Id;
            objprp.uniID = ddlUniversity.SelectedValue;
            objprp.catID = ddlTextCategory.SelectedValue;
            objprp.title = txt_title.Text;
            objprp.urlPath = Imgurl;
            objprp.description = txt_desc.Content;
            objprp.isActive = rblStatus.SelectedValue;
            lblMsg.Text = obj.UpdTextWeb(objprp);
            if (Imgurl != lblImageUrl.Text && lblImageUrl.Text != "")
            {
                File.Delete(Server.MapPath("../" + lblImageUrl.Text));

            }
        }
    }
    private Int32 uploadfile()
    {
        Int32 i = 1, len, expstn;

        if (FileUpload1.HasFile)
        {
            Imgurl = FileUpload1.FileName;

            len = Imgurl.Length;
            expstn = Imgurl.LastIndexOf(".");

            path = Imgurl.Substring(expstn);
            if (path == ".jpg" || path == ".jpeg" || path == ".bmp" || path == ".gif" || path == ".png" || path == ".JPG" || path == ".JPEG" || path == ".BMP" || path == ".GIF" || path == ".PNG")
            {
                Imgurl = "../UniversityImage/" + FileUpload1.FileName;
                path = Server.MapPath("~/UniversityImage/" + Imgurl);
                FileUpload1.SaveAs(path);

                i = 1;
            }
            else
            {
                lblMsg.Text = "Please Upload a Correct Image File !";
                i = -1;
            }
        }
        return i;
    }
    //----------------------bind repeater with manual pageing-------------------



    private void SelectDatail(Int32 pageIndex)
    {
        obj = new clsBLSetup();
        objparm = new PRPSetup();
        Int32 pageSize = Convert.ToInt32(ddlNopage.SelectedValue);

        objparm.pageIndex = pageIndex.ToString();
        objparm.pageSize = pageSize.ToString();
        List<PRPSetup> lst = new List<PRPSetup>();
        lst = obj.ViewTextWeb(objparm);
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
    //--------------------------------------------------------------------------
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
    protected void btn_submit_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            if (btn_submit.Text != "Save")
            {
                updateValue();
            }
            else
            {
                insertValue();
            }
            if (lblMsg.Text.Substring(0, 11) == "Text Submit")
            {
                lblMsg.CssClass = "lg";

            }
            else
            {
                lblMsg.CssClass = "lr";
            }

            SelectDatail(1);
            btn_submit.Text = "Save";
            txt_desc.Content = "";
        }
    }
    protected void datalist_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "edit")
        {
            Id = e.CommandArgument.ToString();
            binduniversity();
            BindTextboxes();
            btn_submit.Text = "Update";
        }
        else
        {
            objparm = new PRPSetup();
            obj = new clsBLSetup();
            objparm.id = e.CommandArgument.ToString();
            lblMsg.Text = obj.DelTextWeb(objparm);
            if (e.CommandName != "")
            {
                File.Delete(Server.MapPath("../" + e.CommandName.ToString()));
            }

            SelectDatail(1);
        }
    }
    protected void ddlUniversity_SelectedIndexChanged(object sender, EventArgs e)
    {
        bindtextcategory();
    }
}
