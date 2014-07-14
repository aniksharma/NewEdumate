using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using nmsSetup;
using nmsDropDown;
using nmsView;
using System.IO;

public partial class Admin_web_Educationboard : System.Web.UI.Page
{
    clsBLSetup obj;
    PRPSetup objprp, objparm;
    static string Id = "", imgurl = "", imageId = "", fileURL = "", MaxId = "";
    string path = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        lblMsg.Text = "";
        lblMsg.CssClass = "lr";

        if (!Page.IsPostBack)
        {
            BindCountry();
            BindState();
            bindNewsType();
            SelectDatail(1);
        }
    }
    //----------------------bind List Box-------------------
    private void BindCountry()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddlCountry;
        drpprp.spName = "viewCountry";
        drp.bindDropDown(drpprp);
        // ddlUniversity0.SelectedIndex = 1;
    }

    private void BindState()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddlUniversity;
        drpprp.spName = "viewstate";
        drp.bindDropDown(drpprp);
        ddlUniversity.SelectedIndex = 1;

    }
    private void bindNewsType()
    {
        clsBLdropDown objdrp = new clsBLdropDown();
        clsPRPdropdown objprpdrp = new clsPRPdropdown();
        objprpdrp.controlList = ddlNewsType;
        objprpdrp.spName = "viewboard";
        objdrp.bindDropDown(objprpdrp);
    }
    private void BindTextboxes()
    {
        objprp = new PRPSetup();
        objparm = new PRPSetup();
        obj = new clsBLSetup();
        objparm.id = Id;
        objprp = obj.SelEducationBoard(objparm);
        Id = objprp.id;
        txt_title.Text = objprp.title;
        txtSubTitle.Text = objprp.status;
        txtDate.Text = objprp.DOJ;
        txt_desc.Content = objprp.description;
        lblimage.Text = objprp.urlPath;
        ListItem lt;
        lt = rblStatus.Items.FindByValue(objprp.isActive);
        rblStatus.SelectedIndex = rblStatus.Items.IndexOf(lt);
        BindState();
        lt = ddlUniversity.Items.FindByValue(objprp.uniID);
        ddlUniversity.SelectedIndex = ddlUniversity.Items.IndexOf(lt);
        bindNewsType();
        lt = ddlNewsType.Items.FindByValue(objprp.catID);
        ddlNewsType.SelectedIndex = ddlNewsType.Items.IndexOf(lt);

        lt = ddlEducationType.Items.FindByValue(objprp.srNo);
        ddlEducationType.SelectedIndex = ddlEducationType.Items.IndexOf(lt);

        imgurl = objprp.urlPath;
        //if (objprp.urlPath == "")
        //{
        //   //chkList.Checked = false;
        //}
        //else
        //{
        //   chkList.Checked = true;
        //}

    }
    private void insertValue()
    {
        objprp = new PRPSetup();
        obj = new clsBLSetup();
        objprp.uniID = ddlUniversity.SelectedValue;
        objprp.catID = ddlNewsType.SelectedValue;
        objprp.title = txt_title.Text;
        objprp.status = txtSubTitle.Text;
        objprp.DOJ = txtDate.Text;
        objprp.description = txt_desc.Content;
        objprp.isActive = rblStatus.SelectedValue;
        objprp.srNo = ddlEducationType.SelectedValue;
        uploadfile();
        objprp.urlPath = imgurl;
      
        lblMsg.Text = obj.InsEducationBoard(objprp);
    }
    private void updateValue()
    {
        objprp = new PRPSetup();
        obj = new clsBLSetup();
        objprp.id = Id;
        objprp.uniID = ddlUniversity.SelectedValue;
        objprp.catID = ddlNewsType.SelectedValue;
        objprp.title = txt_title.Text;
        objprp.status = txtSubTitle.Text;
        objprp.DOJ = txtDate.Text;
        objprp.description = txt_desc.Content;
        objprp.isActive = rblStatus.SelectedValue;
        objprp.srNo = ddlEducationType.SelectedValue;
        uploadfile();
        objprp.urlPath = imgurl;
        lblMsg.Text = obj.UpdEducationBoard(objprp);
    }
    //----------------------bind repeater with manual pageing-------------------
    private void SelectDatail(Int32 pageIndex)
    {
        obj = new clsBLSetup();
        objparm = new PRPSetup();
        Int32 pageSize = Convert.ToInt32(ddlNopage.SelectedValue);

        objparm.pageIndex = pageIndex.ToString();
        objparm.pageSize = pageSize.ToString();
        objparm.uniID = ddlUniversity.SelectedValue;

        List<PRPSetup> lst = new List<PRPSetup>();
        lst = obj.ViewEducationBoard(objparm);
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
            if (lblMsg.Text.Substring(0, 11) == "Succssfully")
            {
                lblMsg.CssClass = "lg";

                blanktext();
            }
            else
            {
                lblMsg.CssClass = "lr";
            }

            SelectDatail(1);
            btn_submit.Text = "Save";

        }
    }
    private void checkFileUploadedPath()
    {
        clsPRPParm objprm = new clsPRPParm();
        clsBLview obj = new clsBLview();
        objprm.spName = "viewGetMaxEducationBoardId";
        MaxId = obj.GetMaxFileId(objprm);

    }
    private void uploadfile()
    {
        Int32 i = 1, len, expstn;

        if (FileUpload1.HasFile)
        {
            imgurl = FileUpload1.FileName;

            //  len = imgurl.Length;
            expstn = imgurl.LastIndexOf(".");

            path = imgurl.Substring(expstn);
            if (path == ".jpg" || path == ".jpeg" || path == ".bmp" || path == ".gif" || path == ".png" || path == ".JPG" || path == ".JPEG" || path == ".BMP" || path == ".GIF" || path == ".PNG")
            {

                if (btn_submit.Text != "Save")
                {
                    MaxId = imageId;
                }
                else
                {
                    checkFileUploadedPath();
                }


                imgurl = "../NewsImages/" + MaxId + FileUpload1.FileName;
                path = Server.MapPath("../NewsImages/" + imgurl);
                FileUpload1.SaveAs(path);

            }
        
        }
        else
        {
            imgurl = lblimage.Text;
        }
        //  return i;
    }
    private void blanktext()
    {

        txt_desc.Content = "";
        txtSubTitle.Text = "";
        txt_title.Text = "";
        txtDate.Text = "";


    }
    protected void datalist_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "edit")
        {
            Id = e.CommandArgument.ToString();
            imageId = e.CommandArgument.ToString();
            BindState();
            bindNewsType();
            BindTextboxes();
            btn_submit.Text = "Update";
        }
        else
        {
            objparm = new PRPSetup();
            obj = new clsBLSetup();
            objparm.id = e.CommandArgument.ToString();
            lblMsg.Text = obj.DelEducationBoard(objparm);
            File.Delete(Server.MapPath("../" + e.CommandName.ToString()));
            SelectDatail(1);
        }
    }
   



    protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
    {
        //if (ddlCountry.SelectedIndex != 0)
        //BindState();
    }
    protected void ddlNewsType_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
