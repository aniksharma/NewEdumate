using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using nmsSetup;
using nmsDropDown;
using nmsView;
public partial class Admin_web_AddImage : System.Web.UI.Page
{
   clsBLSetup obj;
    PRPSetup objprp, objparm;
    static string imageId = "", fileURL = "";
    string catname;
    string imgurl = "", path = "", MaxId = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (Page.IsPostBack == false)
        {                        
            binduniversity();
            bindImageCategory();
            SelectDatail();
        }
    }
    private void binduniversity()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = ddlUniversity;
        drpprp.spName = "viwUniversityWeb1";
        drp.bindDropDown(drpprp);
        ddlUniversity.SelectedIndex = 1;
    }
    private void bindImageCategory()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();
        drpprp.controlList = DDLSubCategory;        
        drpprp.id = Convert.ToInt32( ddlUniversity.SelectedValue);
        drpprp.spName = "viewImageCategory";
        drp.bindDropDown(drpprp);
        if(ddlUniversity.SelectedValue!="0")
            DDLSubCategory.SelectedIndex = 1;
    }
    private void EmptyTextBox()
    {

        txtImageName.Text = "";
        txtDescription.Text = "";
        rblCategoryStatus.SelectedIndex = -1;
        txtSubTitle.Text = "";
        lblmsg.Text = "";

    }
    private void insertCategory()
    {
        obj = new clsBLSetup();
        objprp = new PRPSetup();
        int chk = 0;
        if (FileUpload1.HasFile)
        {
            chk = uploadfile();
        }
        if (chk != -1)
        {
            objprp.title = txtImageName.Text;
            objprp.description = txtDescription.Text;
            objprp.urlName = txtSubTitle.Text;
            objprp.isActive = rblCategoryStatus.SelectedValue;
            objprp.urlPath = imgurl;
            objprp.uniID = ddlUniversity.SelectedValue;
            objprp.catID = DDLSubCategory.SelectedValue;

            lblmsg.Text = obj.InsImageGallery(objprp);
            lblInsMsg.Text = lblmsg.Text;
            if (lblmsg.Text == "Image Inserted Successfully !")
            {
                lblmsg.CssClass = "lg";
            }
            else
            {
                lblmsg.CssClass = "lr";
            }
        }        
    }
    private void BindTextboxes()
    {

        obj = new clsBLSetup();
        objprp = new PRPSetup();
        objparm = new PRPSetup();
        objparm.id =imageId;
        objprp = obj.SelImageGallery(objparm);
        txtImageName.Text = objprp.title;
        txtDescription.Text = objprp.description;
        txtSubTitle.Text = objprp.urlName;

        imgShow.ImageUrl ="../"+ objprp.urlPath;
        lblImgUrl.Text = objprp.urlPath;
        ListItem lt;
        lt = rblCategoryStatus.Items.FindByText(objprp.isActive);
        rblCategoryStatus.SelectedIndex = rblCategoryStatus.Items.IndexOf(lt);

        lt = ddlUniversity.Items.FindByValue(objprp.uniID);
        ddlUniversity.SelectedIndex = ddlUniversity.Items.IndexOf(lt);

        lt = DDLSubCategory.Items.FindByValue(objprp.catID);
        DDLSubCategory.SelectedIndex = DDLSubCategory.Items.IndexOf(lt);

    }
    private void UpdateCategory()
    {
        obj = new clsBLSetup();
        objprp = new PRPSetup();
        int chk = 0;
        if (lblImgUrl.Text != "")
            imgurl = lblImgUrl.Text;

        if (FileUpload1.HasFile)
        {
            chk = uploadfile();
        }
        if (chk != -1)
        {
            objprp.id = imageId;
            objprp.title = txtImageName.Text;
            objprp.description = txtDescription.Text;
            objprp.isActive = rblCategoryStatus.SelectedValue;
            objprp.urlPath = imgurl;
            objprp.uniID = ddlUniversity.SelectedValue;
            objprp.catID = DDLSubCategory.SelectedValue;
            objprp.urlName = txtSubTitle.Text;
            lblInsMsg.Text = obj.UpdImageGallery(objprp);
            if (lblmsg.Text == "Image Submit Successfully")
            {
                lblmsg.CssClass = "lg";
            }
            else
            {
                lblmsg.CssClass = "lr";
            }

        }

    }
    //------------------------------------------------------------------------------------------//
    private void SelectDatail()
    {

        obj = new clsBLSetup();
        //objprp = new PRPPImageGellery();
        objparm = new PRPSetup();
        List<PRPSetup> lst = new List<PRPSetup>();
        objparm.uniID = ddlUniversity.SelectedValue.ToString();
        objparm.catID = DDLSubCategory.SelectedValue.ToString();
        lst = obj.ViewImageGallery(objparm);
        if (lst[0].id != "Result Not Find")
        {
            datalist.DataSource = lst;
            datalist.DataBind();
        }
        else
        {
            datalist.DataSource = null;
            datalist.DataBind();
            lblmsg.Text = "Result Not Found";
        }
    }
    //------------------------------------------------------------------------------------------//
    protected void btnAdd_Click(object sender, EventArgs e)
    {

        if (trInsert.Visible == false || btnInsert.Text == "Update")
        {
            trInsert.Visible = true;
            EmptyTextBox();
            btnInsert.Text = "Save";
        }
        else
        {
            trInsert.Visible = false;
        }

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            if (btnInsert.Text == "Save")
            {
                insertCategory();

            }
            else
            {
                UpdateCategory();
            }
            if (lblInsMsg.Text.Length > 7)
            {
                if (lblInsMsg.Text.Substring(0, 5) == "Image")
                {

                    imgShow.ImageUrl = "../" + imgurl;

                    lblImgUrl.Text = imgurl;
                    SelectDatail();
                    EmptyTextBox();
                    if (btnInsert.Text != "Save")
                    {
                        btnInsert.Text = "Save";

                    }

                    ModalMenuExtender1.Show();


                }
                else
                {
                    lblmsg.Text = lblInsMsg.Text;
                }
            }
        }
    }
    protected void btnCancel_Click1(object sender, EventArgs e)
    {
        EmptyTextBox();

    }
    private void checkFileUploadedPath()
    {
        clsPRPParm objprm = new clsPRPParm();
        clsBLview obj = new clsBLview();
        objprm.spName = "viewGetMaxImageId";
        MaxId = obj.GetMaxFileId(objprm);
    }    
    private Int32 uploadfile()
    {
        Int32 i = 1, len, expstn;

        if (FileUpload1.HasFile)
        {
            imgurl = FileUpload1.FileName;

            len = imgurl.Length;
            expstn = imgurl.LastIndexOf(".");

            path = imgurl.Substring(expstn);
            if (path == ".jpg" || path == ".jpeg" || path == ".bmp" || path == ".gif" || path == ".png" || path == ".JPG" || path == ".JPEG" || path == ".BMP" || path == ".GIF" || path == ".PNG")
            {

                if (btnInsert.Text != "Save")
                {
                    MaxId = imageId;
                }
                else
                {
                    checkFileUploadedPath();
                }


                imgurl = "../ImageGallery/" + MaxId + FileUpload1.FileName;
                path = Server.MapPath("~/ImageGallery/" + imgurl);
                FileUpload1.SaveAs(path);


                i = 1;
            }
            else
            {
                lblmsg.Text = "Please Upload a Correct Image File !";
                i = -1;
            }
        }
        return i;
    }
    protected void datalist_ItemCommand1(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "edit")
        {
            imageId = e.CommandArgument.ToString();
            EmptyTextBox();
            BindTextboxes();
            trInsert.Visible = true;

            btnInsert.Text = "Update";
        }


    }
     
    protected void DDLSubCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        SelectDatail();
    }

    protected void ddlUniversity_SelectedIndexChanged(object sender, EventArgs e)
    {
        bindImageCategory();
        SelectDatail();
        imgShow.ImageUrl = "";
    }
}
