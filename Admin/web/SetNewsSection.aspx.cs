using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using nmsSetup;
using nmsDropDown;

public partial class Admin_web_SetNewsSection : System.Web.UI.Page
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
            binduniversity();
            bindNewsType();
            SelectDatail(1);
        }
    }
    //----------------------bind List Box-------------------
    private void binduniversity()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddlUniversity;
        drpprp.spName = "SpBindNewsFor";
        drp.bindDropDown(drpprp);
        ddlUniversity.SelectedIndex = 1;
    }
    private void bindNewsType()
    {
        clsBLdropDown objdrp = new clsBLdropDown();
        clsPRPdropdown objprpdrp = new clsPRPdropdown();
        objprpdrp.controlList = ddlNewsType;
        if (ddlUniversity.SelectedIndex != 0)
        {
            objprpdrp.id = Convert.ToInt32(ddlUniversity.SelectedValue);
        }
        objprpdrp.spName = "viewNewsType";
        objdrp.bindDropDown(objprpdrp);
    }
    private void BindTextboxes()
    {
        objprp = new PRPSetup();
        objparm = new PRPSetup();
        obj = new clsBLSetup();
        objparm.id = Id;
        objprp = obj.SelNews(objparm);
        Id = objprp.id;
        txt_title.Text = objprp.title;
        txtSubTitle.Text = objprp.status;
        txtDate.Text = objprp.DOB;
        txt_desc.Content = objprp.description;
        ListItem lt;
        lt = rblStatus.Items.FindByValue(objprp.isActive);
        rblStatus.SelectedIndex = rblStatus.Items.IndexOf(lt);

        lt = ddlUniversity.Items.FindByValue(objprp.uniID);
        ddlUniversity.SelectedIndex = ddlUniversity.Items.IndexOf(lt);

        bindNewsType();

        lt = ddlNewsType.Items.FindByValue(objprp.catID);
        ddlNewsType.SelectedIndex = ddlNewsType.Items.IndexOf(lt);


        imgurl = objprp.urlPath;
        lblImgUrl.Text = objprp.urlPath;


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
        if (chkList.Checked == true)
        {
            objprp.urlPath = "../images/new.gif";
            
        }
        else
        {

            objprp.urlPath = imgurl;
        }
        lblMsg.Text = obj.InsNews(objprp);

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
        if (chkList.Checked == true)
        {
            objprp.urlPath = "../images/new.gif";
        }
        else
        {
            uploadfile();
            objprp.urlPath = imgurl;
        }
    
        lblMsg.Text = obj.UpdNews(objprp);
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
        if (ddlNewsType.SelectedIndex > 0)
        {
            objparm.catID = ddlNewsType.SelectedValue;
        }
        List<PRPSetup> lst = new List<PRPSetup>();
        lst = obj.ViewNews(objparm);
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


            PageSetting(pageIndex);

            //----------------------------------------------
        }
        else
        {
            datalist.DataSource = null;
            datalist.DataBind();
            lblMsg.Text = "Result Not Found";

        }
    }

    private void PageSetting(Int32 pageIndex)
    {
        lnkfstPage.Enabled = true;
        lnkLastpage.Enabled = true;
        lnkNextpage.Enabled = true;
        lnkPrepage.Enabled = true;

        lnkfstPage.CssClass = "nextprev";
        lnkLastpage.CssClass = "nextprev";
        lnkNextpage.CssClass = "nextprev";
        lnkPrepage.CssClass = "nextprev";

        if (pageIndex == 1)
        {
            lnkfstPage.Enabled = false;

            lnkPrepage.Enabled = false;
            lnkfstPage.CssClass = "nextprev1";
            lnkPrepage.CssClass = "nextprev1";
        }
        if (pageIndex == Convert.ToInt32(lblLastPage.Text))
        {
            lnkLastpage.Enabled = false;
            lnkNextpage.Enabled = false;

            lnkNextpage.CssClass = "nextprev1";
            lnkLastpage.CssClass = "nextprev1";
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
            try
            {
                uploadfile();
                if (imgurl != "MoreSize")
                {
                    if (btn_submit.Text != "Save")
                    {
                        updateValue();
                    }
                    else
                    {
                        insertValue();
                    }
                    if (lblMsg.Text.Substring(0, 11) == "News Submit")
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
                else
                {
                    Response.Write(" <script>" + "alert('Please Upload Image Of 7 kb or less then 7kb');" + "</script>");
                }
            }
            catch (Exception Ex)
            {
                lblMsg.Text = Ex.Message;
            }
        }
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
            if (btn_submit.Text != "Save")
            {
                MaxId = imageId;
            }
            else
            {
                checkFileUploadedPath();
            }
            int Siz = FileUpload1.PostedFile.ContentLength;
             imgurl = "../images/NewsImages/" + MaxId + FileUpload1.FileName;          
             path = Server.MapPath("../" + imgurl);   // coment by devesh
             FileUpload1.SaveAs(path);                // coment by devesh
        }
       
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
            binduniversity();
            bindNewsType();
            BindTextboxes();
            btn_submit.Text = "Update";
        }
        if (e.CommandName == "Delete")
        {
            objparm = new PRPSetup();
            obj = new clsBLSetup();
            objparm.id = e.CommandArgument.ToString();
            lblMsg.Text = obj.DelNews(objparm);
            SelectDatail(1);
        }
    }
    protected void ddlUniversity_SelectedIndexChanged(object sender, EventArgs e)
    {
        SelectDatail(1);
        bindNewsType();

    }
    protected void ddlNewsType_SelectedIndexChanged(object sender, EventArgs e)
    {
        SelectDatail(1);
    }
}
