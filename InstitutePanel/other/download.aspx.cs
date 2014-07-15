using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using nmsEditor;
using System.Collections.Generic;


public partial class web_website_downloads : System.Web.UI.Page
{
    clsBLEditor obj;
    PRPPImageGellery objprp;
    PRPPImageGellery objprpparam;

    static string imageId = "", fileURL = "";
    string catname;
    string imgurl = "", path = "", MaxId = "";

    protected void Page_Load(object sender, EventArgs e)
    {

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
        rblCategoryStatus.SelectedIndex = -1;
        lblmsg.Text = "";

    }

    private void insertFileDoc()
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
            objprp.name = txtImageName.Text;
            objprp.status = rblCategoryStatus.SelectedValue;

            objprp.path = imgurl;
            objprp.schoolid = Session["SchoolId"].ToString();
            lblmsg.Text = obj.InsertdocFile(objprp);
            lblInsMsg.Text = lblmsg.Text;
            if (lblmsg.Text == "File Inserted Succefully !")
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
        obj = new clsBLEditor();
        objprp = new PRPPImageGellery();
        objprpparam = new PRPPImageGellery();
        objprpparam.id = imageId;

        objprp = obj.selectdocFile(objprpparam);
        txtImageName.Text = objprp.name;
        //txtDescription.Text = objprp.name;
        lblImgUrl.Text = objprp.path;
        ListItem lt;
        lt = rblCategoryStatus.Items.FindByText(objprp.status);
        rblCategoryStatus.SelectedIndex = rblCategoryStatus.Items.IndexOf(lt);

    }
    private void Updatedocfile()
    {
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
            objprp.id = imageId;
            objprp.name = txtImageName.Text;
            objprp.status = rblCategoryStatus.SelectedValue;
            objprp.path = imgurl;

            lblInsMsg.Text = obj.UpdatedocFile(objprp);
            if (lblmsg.Text == "File Updated Succefully!")
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
    private void SelectDatail(Int32 pageIndex)
    {

        obj = new clsBLEditor();
        PRPPImageGellery objparm = new PRPPImageGellery();
        List<PRPPImageGellery> lst = new List<PRPPImageGellery>();
        objparm.schoolid = Session["SchoolId"].ToString();
        lst = obj.viewdocFile1(objparm);


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
    private void checkFileUploadedPath()
    {
        MaxId = obj.GetMaxFileId();

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
            if (path == ".doc" || path == ".docx"|| path == ".pdf")
            {

                if (btnInsert.Text != "Save")
                {
                    MaxId = imageId;
                }
                else
                {
                    checkFileUploadedPath();
                }


                imgurl = "../docdownload/" + MaxId + FileUpload1.FileName;
                path = Server.MapPath("../docdownload/" + imgurl);
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
    private void DeleteFile()
    {
        obj = new clsBLEditor();
        objprpparam = new PRPPImageGellery();
        objprpparam.id = imageId;
        lblmsg.Text = obj.DeletedocFile(objprpparam);
    }
    protected void btsubmit_Click(object sender, EventArgs e)
    {
        try
        {
            if (btnInsert.Text == "Save")
            {
                insertFileDoc();

            }
            else
            {
                Updatedocfile();
            }
            if (lblInsMsg.Text.Length > 7)
            {
                if (lblInsMsg.Text.Substring(0, 4) == "File")
                {
                    EmptyTextBox();

                    lblImgUrl.Text = imgurl;
                    SelectDatail(1);

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
        catch (Exception ex)
        {
            lblmsg.Text = ex.Message;
        }



    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        EmptyTextBox();
    }
    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        try
        {
            imageId = "0";
            if (e.CommandName == "Edit")
            {
                imageId = e.CommandArgument.ToString();
                EmptyTextBox();
                BindTextboxes();

                btnInsert.Text = "Update";
            }
            else if (e.CommandName == "Delete")
            {
                imageId = e.CommandArgument.ToString();
                DeleteFile();
                SelectDatail(1);
            }

        }
        catch (Exception ex)
        {
            lblmsg.Text = ex.Message;
        }


    }
}