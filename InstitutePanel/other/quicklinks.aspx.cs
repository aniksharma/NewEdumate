using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using nmsEditor;

public partial class web_website_quicklink : System.Web.UI.Page
{
    clsBLEditor obj;
    PRPPImageGellery objprp;
    static string imageId = "", fileURL = "";
    string catname;
    string imgurl = "", path = "", MaxId = "";
    protected void Page_Load(object sender, EventArgs e)
    {


       lblMsg.CssClass = "labelMsgRed";
       lblMsg.Text = "";

       try
       {
           if (!Page.IsPostBack)
           {
               bindList();
           }
       }
       catch(Exception ex)
       {
           lblMsg.Text = ex.Message;
       }

    }
    private void EmtyTextBox()
    {
        txtName.Text = "";
        btsubmit.Text = "Submit";
       
    }
   private void bindList()
    {
        PRPPImageGellery prp = new PRPPImageGellery();
        prp.Type = "Quicklinks";
        prp.schoolid = Session["SchoolId"].ToString();
        obj = new clsBLEditor();
        List<PRPPImageGellery> lst = new List<PRPPImageGellery>();
        lst = obj.viewCaloney1(prp);
        if (lst[0].id != "Result Not Find")
        {
            datalist.DataSource = lst;
            datalist.DataBind();


        }
        else
        {
            datalist.DataSource = null;
            datalist.DataBind();
            lblMsg.Text = "Result Not Found";

        }
        
    }
    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        try
        {
            EmtyTextBox();
            imageId = "0";
             
            imageId= ( (Label)(  e.Item.FindControl("lblId"))).ToolTip;
              txtName.Text = ((Label)(e.Item.FindControl("lblName"))).Text;
             
            if (e.CommandName == "Edit")
            {
                imageId = e.CommandArgument.ToString();
              
                btsubmit.Text = "Update";
            }
            else if (e.CommandName == "Delete")
            {
                imageId = e.CommandArgument.ToString();
                DeleteRecord();
                bindList();
            }
            else if (e.CommandName == "setValue")
            {
                 Response.Redirect("http://www.edumate.edu.in/myweb-page/"+imageId+"/"+txtName.Text);
            }

        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.Message;
        }


    }
    private void InsertRecord()
    {
        PRPPImageGellery prp = new PRPPImageGellery();
        prp.Type = "Quicklinks";
        prp.schoolid = Session["SchoolId"].ToString();
        obj = new clsBLEditor();
        List<PRPPImageGellery> lst = new List<PRPPImageGellery>();
        lst = obj.viewCaloney1(prp);

        if (lst.Count < 5)
        {

            obj = new clsBLEditor();
            objprp = new PRPPImageGellery();
            objprp.name = txtName.Text.Trim();
            objprp.Type = "Quicklinks";
            objprp.schoolid = Session["SchoolId"].ToString();
            lblMsg.Text = obj.InsertCaloney(objprp);

            if (lblMsg.Text == "Inserted  Successfully !")
            {

                lblMsg.CssClass = "labelMsgGreen";

            }
            EmtyTextBox();
            bindList();
        }
        else
        {
            lblMsg.Text = "Only 5 Quick Link Allows !";
        }

    }
    private void UpdateRecord()
    {
        obj = new clsBLEditor();
        objprp = new PRPPImageGellery();
        objprp.name = txtName.Text.Trim(); 
        objprp.id = imageId;
        lblMsg.Text = obj.UpdateCaloney(objprp);
        if (lblMsg.Text == "Updated  Successfully !")
        {

            lblMsg.CssClass = "labelMsgGreen";

        }

    }
    private void DeleteRecord()
    {
        obj = new clsBLEditor();
        objprp = new PRPPImageGellery();
        objprp.id = imageId;
        lblMsg.Text = obj.DeleteCaloney(objprp);
        bindList();
        if (lblMsg.Text == "Deleted  Successfully !")
        {

            lblMsg.CssClass = "labelMsgGreen";

        }
        else
        {
            lblMsg.Text = "Please make sure all data deleted into particular   link page !";
        }


    }

    protected void btsubmit_Click(object sender, EventArgs e)
    {
        try
        {
        if (btsubmit.Text == "Update")
        {

            UpdateRecord();
            EmtyTextBox();
            bindList();
        }
        else
        {
            InsertRecord();
        }
      
         }
       catch(Exception ex)
       {
           lblMsg.Text = ex.Message;
       }

    }
   
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        EmtyTextBox();
        bindList();
    
    }
   
}