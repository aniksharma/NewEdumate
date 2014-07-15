using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using nmsEditor;
using System.IO;

public partial class web_website_ImageGellary : System.Web.UI.Page
{
    clsBLEditor obj;
    PRPPImageGellery objprp;
    PRPPImageGellery objprpparam;

    static string imageId = "", fileURL = "";
    string catname;
    string imgurl = "", path = "", MaxId = "";

    string linkid = "", linkName = "";
    protected void Page_Load(object sender, EventArgs e)
    {
       

        if (Page.RouteData.Values["linkid"] == null)
        {
            Response.Redirect("htpp://www.edumate.edu.in/default.aspx");
        }
        else
        {
            linkid = Page.RouteData.Values["linkid"].ToString();

        }

        if (Page.RouteData.Values["linkname"] != null)
        {
        lblName2.Text=    lblPageName.Text = Page.RouteData.Values["linkname"].ToString();
        }
        lblmsg.Text = "";
        lblInsMsg.Text = "";
        lblmsg.CssClass = "labelMsgRed";
        if (Page.IsPostBack == false)
        {
            lblInsMsg.Text = "";
            try
            {
                SelectDatail(1);
            }
            catch (Exception ex)
            {
                lblmsg.Text = ex.Message;
            }

        }

    }
    private void EmptyTextBox()
    {

        txtImageName.Text = "";
        txtDescription.Text = "";
        rblCategoryStatus.SelectedIndex = -1;
        // ddlCaloney.SelectedIndex = -1;
        lblmsg.Text = "";

    }

    private void insertCategory()
    {
        obj = new clsBLEditor();
        objprp = new PRPPImageGellery();
        int chk = 0;
        if (FileUpload1.HasFile)
        {
            chk = uploadfile();
        }
        if (chk != -1)
        {
            if (Page.RouteData.Values["linkid"] != null)
            {
                linkid = Page.RouteData.Values["linkid"].ToString();
            }
            

            objprp.imageTitle = txtImageName.Text;
            objprp.imageDescription = txtDescription.Text;
            objprp.imageStatus = rblCategoryStatus.SelectedValue;

            objprp.imagePath = imgurl;
            objprp.caloneyId = linkid;
            objprp.id = Session["schoolId"].ToString();
            lblmsg.Text = obj.InsertImageGallery(objprp);
            lblInsMsg.Text = lblmsg.Text;
            if (lblmsg.Text == "Image Inserted Successfully !")
            {
                lblInsMsg.Text = "Inserted Successfully !";
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
        obj = new clsBLEditor();
        objprp = new PRPPImageGellery();
        objprpparam = new PRPPImageGellery();
        objprpparam.imageId = imageId;

        objprp = obj.SelectImageGallery(objprpparam);

        txtImageName.Text = objprp.imageTitle;
        txtDescription.Text = objprp.imageDescription;
        imgShow.ImageUrl = objprp.imagePath;
        lblImgUrl.Text = objprp.imagePath;
        ListItem lt;
        lt = rblCategoryStatus.Items.FindByText(objprp.imageStatus);
        rblCategoryStatus.SelectedIndex = rblCategoryStatus.Items.IndexOf(lt);

        // lt = ddlCaloney.Items.FindByText(objprp.caloneyName);
        //ddlCaloney.SelectedIndex = ddlCaloney.Items.IndexOf(lt);


    }
    private void UpdateCategory()
    {
        if (Page.RouteData.Values["linkid"] != null)
        {
            linkid = Page.RouteData.Values["linkid"].ToString();
        }
            
        obj = new clsBLEditor();
        objprp = new PRPPImageGellery();
        int chk = 0;
        if (lblImgUrl.Text != "")
            imgurl = lblImgUrl.Text;

        if (FileUpload1.HasFile)
        {
            chk = uploadfile();
        }
        if (chk != -1)
        {
            objprp.imageId = imageId;
            objprp.imageTitle = txtImageName.Text;
            objprp.imageDescription = txtDescription.Text;
            objprp.imageStatus = rblCategoryStatus.SelectedValue;
            objprp.imagePath = imgurl;
            objprp.caloneyId = linkid;

            lblmsg.Text = obj.UpdateImageGallery(objprp);
            lblInsMsg.Text = lblmsg.Text;
            if (lblmsg.Text == "Image Updated Successfully !")
            {  lblInsMsg.Text= "Updated Successfully !";
                lblmsg.CssClass = "lg";
            }
            else
            {
                lblmsg.CssClass = "lr";
            }

        }

    }


    //------------------------------------------------------------------------------------------//
    private void SelectDatail(Int32 pageIndex)
    {
        if (Page.RouteData.Values["linkid"] != null)
        {
            linkid = Page.RouteData.Values["linkid"].ToString();
        }
            

        obj = new clsBLEditor();
        PRPPImageGellery objparm = new PRPPImageGellery();
        List<PRPPImageGellery> lst = new List<PRPPImageGellery>();
        objparm.caloneyId = linkid;
        objparm.id = Session["schoolid"].ToString();
        lst = obj.viewImageGalleryShowByCaloneyId(objparm);


        if (lst[0].id != "Result Not Find")
        {
            Repeater1.DataSource = lst;
            Repeater1.DataBind();


        }
        else
        {
            Repeater1.DataSource = null;
            Repeater1.DataBind();
            lblmsg.Text = "Result Not Found";

        }
    }
    //------------------------------------------------------------------------------------------//
    private void checkFileUploadedPath()
    {
        MaxId = obj.GetMaxCategoryID();

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
                if (btsubmit.Text != "Save")
                {
                    MaxId = imageId;
                }
                else
                {
                    checkFileUploadedPath();
                }


                imgurl = "../../AdminImage/" + MaxId + FileUpload1.FileName;
                path = Server.MapPath( imgurl);
                FileUpload1.SaveAs(path);
                imgurl = "AdminImage/" + MaxId + FileUpload1.FileName;

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
        try
        {
        imageId = "0";
        if (e.CommandName == "edit")
        {
            imageId = e.CommandArgument.ToString();
            EmptyTextBox();
            BindTextboxes();
            btsubmit.Visible = true;

            btsubmit.Text = "Update";
        }
        else if (e.CommandName == "Delete")
        {
            imageId = e.CommandArgument.ToString();
            DeleteImage();
            SelectDatail(1);
        }
        }
        catch (Exception ex)
        {
            lblmsg.Text = ex.Message;
        }


    }

    private void bindDDL()
    {

    }
    private void DeleteImage()
    {
        obj = new clsBLEditor();
        objprpparam = new PRPPImageGellery();
        objprpparam.imageId = imageId;

        lblmsg.Text = obj.DeleteImageGallery(objprpparam);



    }

    protected void btsubmit_Click(object sender, EventArgs e)
    {
        try
        {
        if (btsubmit.Text == "Submit")
        {
            insertCategory();

        }
        else
        {
            UpdateCategory();
        }
        if (lblmsg.Text.Length > 7)
        {
            if (lblmsg.Text.Substring(0, 5) == "Image")
            {
                EmptyTextBox();
                imgShow.ImageUrl ="http://www.edumate.edu.in/"+ imgurl;

                lblImgUrl.Text = imgurl;
                SelectDatail(1);

                if (btsubmit.Text != "Submit")
                {
                    btsubmit.Text = "Submit";

                }

                ModalMenuExtender1.Show();


            }
            else
            {
                lblmsg.Text = lblInsMsg.Text;
                ModalPopupInsert.Show();
            }
        }
        }
        catch (Exception ex)
        {
            lblmsg.Text = ex.Message;
            ModalPopupInsert.Show();
        }


    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {

        EmptyTextBox();
        ModalPopupInsert.Show();

    }
    
    protected void Repeater1_ItemCommand1(object source, DataListCommandEventArgs e)
    {
        try 
        {
        imageId = "0";
        if (e.CommandName == "edit")
        {
            imageId = e.CommandArgument.ToString();
            EmptyTextBox();
            BindTextboxes();
            // trInsert.Visible = true;

            btsubmit.Text = "Update";
            ModalPopupInsert.Show();
        }
        else if (e.CommandName == "Delete")
        {
            imageId = e.CommandArgument.ToString();
            DeleteImage();
            SelectDatail(1);
        }
        }
        catch (Exception ex)
        {
            lblmsg.Text = ex.Message;
        }
    }
}
