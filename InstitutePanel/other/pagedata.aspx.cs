﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using nmsEditor;
using System.Collections.Generic;

public partial class web_website_pageData : System.Web.UI.Page
{
    clsBLEditor obj;
    PRPPImageGellery objprp;
    PRPPImageGellery objprpparam;
    prpImagePlan prp;
    static string imageId = "", fileURL = "";
    string catname;
    string imgurl = "", path = "", MaxId = "";

    string linkid = "", linkName = "";

    string st = "";
    string deletebutton = "", updatebutton = "";
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (Page.RouteData.Values["linkid"] == null)
        {
            Response.Redirect("default.aspx");
        }
        else
        {
            linkid = Page.RouteData.Values["linkid"].ToString();

        }

        if (Page.RouteData.Values["linkname"] != null)
        {
          lblPageName.Text=   lblName2.Text = Page.RouteData.Values["linkname"].ToString();
        }



        lblmsg.Text = "";
        lblInsMsg.Text = "";
        lblMsageNew.Text = "";
        lblmsg.CssClass = "labelMsgRed";
        if (Page.IsPostBack == false)
        {
            lblInsMsg.Text = "";
           
            try
            {
                SelectDatail(1);
                ShowByClass();
                bindcheckbox();
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
        txtDescription.Content = "";
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
            objprp.imageDescription = txtDescription.Content;
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
        txtDescription.Content = objprp.imageDescription;
       // imgShow.ImageUrl = objprp.imagePath;
        lblImgUrl.Text = objprp.imagePath;
        ListItem lt;
        lt = rblCategoryStatus.Items.FindByText(objprp.imageStatus);
        rblCategoryStatus.SelectedIndex = rblCategoryStatus.Items.IndexOf(lt);

        // lt = ddlCaloney.Items.FindByText(objprp.caloneyName);
        //ddlCaloney.SelectedIndex = ddlCaloney.Items.IndexOf(lt);


    }
    private void UpdateCategory()
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
            if (Page.RouteData.Values["linkid"] != null)
            {
                linkid = Page.RouteData.Values["linkid"].ToString();
            }
            
            objprp.imageId = imageId;
            objprp.imageTitle = txtImageName.Text;
            objprp.imageDescription = txtDescription.Content;
            objprp.imageStatus = rblCategoryStatus.SelectedValue;
            objprp.imagePath = imgurl;
            objprp.caloneyId = linkid;

            lblmsg.Text = obj.UpdateImageGallery(objprp);
            lblInsMsg.Text = lblmsg.Text;
            if (lblmsg.Text == "Image Updated Successfully !")
            {
                   lblInsMsg.Text ="Updated Successfully !";
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
            ShowByClass();
        }

    }
           catch (Exception ex)
            {
                lblmsg.Text = ex.Message;
            }


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
                        // imgShow.ImageUrl = imgurl;

                        lblImgUrl.Text = imgurl;
                        SelectDatail(1);
                        ShowByClass();

                        if (btsubmit.Text != "Submit")
                        {
                            btsubmit.Text = "Submit";

                        }

                        //   de.Visible = true;
                        ModalMenuExtender1.Show();


                    }
                    else
                    {
                        lblmsg.Text = lblInsMsg.Text;
                        // de.Visible = true;
                        ModalPopupInsert.Show();

                    }
                }

            }
            catch (Exception ex)
            {
                lblmsg.Text = ex.Message;
                //  de.Visible = true;
                ModalPopupInsert.Show();
            }
       

    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        EmptyTextBox();
       // de.Visible = true;
        ModalPopupInsert.Show();

    }
    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        imageId = "0";
        if (e.CommandName == "edit")
        {
            imageId = e.CommandArgument.ToString();
            EmptyTextBox();
            BindTextboxes();
           // trInsert.Visible = true;

            btsubmit.Text = "Update";
           // de.Visible = true;
            ModalPopupInsert.Show();

        }
        else if (e.CommandName == "Delete")
        {
            imageId = e.CommandArgument.ToString();
            DeleteImage();
            SelectDatail(1);
            ShowByClass();
        }
    

    }
    protected void btnlayout_Click(object sender, EventArgs e)
    {
        if (Page.RouteData.Values["linkid"] != null)
        {
            linkid = Page.RouteData.Values["linkid"].ToString();
        }

        Response.Redirect("~/myweb-PageLayout/" + linkid + "/select-page-layout");
    }


    private void bindcheckbox()
    {

        if (Page.RouteData.Values["linkid"] != null)
        {
            linkid = Page.RouteData.Values["linkid"].ToString();
        }
        
        string srno;
        obj = new clsBLEditor();
        prp = new prpImagePlan();
        prp.userId = Session["SchoolId"].ToString();
        prp.linkid = linkid;
        srno = obj.userLayout(prp);

        ddpLayout.SelectedValue = srno;


    }

    private void spTempUser(string tempid)
    {

        if (Page.RouteData.Values["linkid"] != null)
        {
            linkid = Page.RouteData.Values["linkid"].ToString();
        }

        string srno;

        obj = new clsBLEditor();
        prp = new prpImagePlan();
        prp.userId = Session["SchoolId"].ToString();
        prp.linkid = linkid;
        prp.layout = tempid;


        srno = obj.spTempLayout(prp);
    }
    protected void ddpLayout_SelectedIndexChanged(object sender, EventArgs e)
    {
        datatop.Visible = true; 
        Button btn = new Button();
       // btn = (Button)(sender);
        spTempUser(ddpLayout.SelectedValue);
        ShowByClass();
    }
    protected void btnInsert_Click(object sender, EventArgs e)
    {
        //de.Visible = true;
        ModalPopupInsert.Show();

    }


    private void deletes(object sender, EventArgs e)
    {
        string id = ((LinkButton)(sender)).ToolTip;
        obj = new clsBLEditor();
        objprpparam = new PRPPImageGellery();
        objprpparam.imageId = id;

        lblmsg.Text = obj.DeleteImageGallery(objprpparam);

        ShowByClass();

    }


    private void updates(object sender, EventArgs e)
    {
        string id = ((LinkButton)(sender)).ToolTip;
        imageId = id;
        EmptyTextBox();
        BindTextboxes();
        // trInsert.Visible = true;

        btsubmit.Text = "Update";
       // de.Visible = true;
        ModalPopupInsert.Show();
    }

    private void ShowByClass()
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
        string title = "Edumate";

        
        if (lst[0].id != "Result Not Find")
        {
            Page.Title = lst[0].imageTitle;


            st += "<table class='pageTable'>";
            if (lst[0].layout == "1" || lst[0].layout == "")
            {
                foreach (PRPPImageGellery prp in lst)
                {
                    
                   
                    title = "<h1>" + prp.imageTitle + "</h1>";
                    st += "<tr></td><td valign='top'> " + title + prp.imageDescription + "</td></tr>";
                  //  st += "<tr><td valign='top'><asp:LinkButton OnClick='deletes' ID='lnkDetete" + prp.imageId + "' runat ='server' ToolTip ='" + prp.imageId + "'>Delete</asp:LinkButton></td>";
                   // st += "<td valign='top'> <asp:Button  runat =\"server\"  ID=\"btnInseraasst\" Text=\"Add New Paragraph\" />   <asp:LinkButton OnClick='updates' ID='lnkUpdate" + prp.imageId + "' runat ='server' ToolTip ='" + prp.imageId + "'>Update</asp:LinkButton></td>";
                   // st += "</tr>";
                
                }
            }
            else if (lst[0].layout == "5")
            {
                string st1 = "";
                st += "<tr><td><table width='100%' cellpadding='0' cellspacing='5px'><tr>";
                foreach (PRPPImageGellery prp in lst)
                {
                    title = "<h1>" + prp.imageTitle + "</h1>";
                    st += "<td><img alt='"+prp.imageTitle+"' src='" + prp.imagePath + "' height=\"150px\" width=\"190px\" alt=\"\" style=\"border:solid 1px #ffffff;\" /></td>";
                    st1 += "<tr></td><td valign='top'>" +title+ prp.imageDescription + "</td></tr>";
                }
                st += "</tr></table></td></tr>";
                st = st + st1;
            }
            else if (lst[0].layout == "6")
            {
                string st1 = "<tr><td><table width='100%' cellpadding='0' cellspacing='5px'><tr>";
                foreach (PRPPImageGellery prp in lst)
                {
                    title = "<h1>" + prp.imageTitle + "</h1>";
                    st1 += "<td><img  alt='" + prp.imageTitle + "' src='" + prp.imagePath + "' height=\"150px\" width=\"210px\" alt=\"\" style=\"border:solid 1px #ffffff;\" /></td>";
                    st += "<tr></td><td valign='top'>" + title +prp.imageDescription + "</td></tr>";
                }
                st1 += "</tr></table></td></tr>";
                st = st + st1;
            }
            else if (lst[0].layout == "2")
            {
                foreach (PRPPImageGellery prp in lst)
                {
                    title = "<h1>" + prp.imageTitle + "</h1>";
                    st += "<tr></td><td valign='top'><div style=\"float:left; height:150px;width:210px;margin-right:7px; border:solid 1px #ffffff;\"><img  alt='" + prp.imageTitle + "' src='" + prp.imagePath + "' height=\"150\" width=\"210\" alt=\"\" style=\"border:solid 1px #ffffff;\" /></div>" + title + prp.imageDescription + "</td></tr>";
                }
            }
            else if (lst[0].layout == "3")
            {
                foreach (PRPPImageGellery prp in lst)
                {
                    title = "<h1>" + prp.imageTitle + "</h1>";
                    st += "<tr><td valign='top'>"+title + prp.imageDescription + "</td><td valign='top'><img  alt='" + prp.imageTitle + "' src='" + prp.imagePath + "' Height='150' Width='200px' /></td></tr>";
                }
            }
            else if (lst[0].layout == "4")
            {
                int a;
                for (a = 0; a < lst.Count; a++)
                {
                    if (a == 0)
                    {
                        st += "<tr></td><td valign='top'><div style=\"float:left; height:150;width:210;margin-right:7px; border:solid 1px #ffffff;\"><img  alt='" + lst[a].imageTitle + "' src='" + lst[a].imagePath + "' height=\"150\" width=\"210\" alt=\"\" style=\"border:solid 1px #ffffff;\" /></div><h1>" + lst[a].imageTitle +"</h1>"+ lst[a].imageDescription + "</td></tr>";
                    }
                    if (a == 1)
                    {
                        st += "<tr></td><td valign='top'><div style=\"float:right; height:150;width:210;margin-left:7px; border:solid 1px #ffffff;\"><img  alt='" + lst[a].imageTitle + "' src='" + lst[a].imagePath + "' height=\"150\" width=\"210\" alt=\"\" style=\"border:solid 1px #ffffff;\" /></div><h1>" + lst[a].imageTitle + "</h1>" + lst[a].imageDescription + "</td></tr>";
                    }
                    if (a == 2)
                    {
                        st += "<tr></td><td valign='top'><div style=\"float:left; height:150;width:210;margin-right:7px; border:solid 1px #ffffff;\"><img  alt='" + lst[a].imageTitle + "' src='" + lst[a].imagePath + "' height=\"150\" width=\"210\" alt=\"\" style=\"border:solid 1px #ffffff;\" /></div><h1>" + lst[a].imageTitle + "</h1>" + lst[a].imageDescription + "</h1>" + "</td></tr>";
                    }
                }

            }
            st += "</table>";
            data.InnerHtml = st;


        }
     



       
    }
    protected void lnkbtn_Click(object sender, EventArgs e)
    {
        datatop.Visible = false; 
    }
}




