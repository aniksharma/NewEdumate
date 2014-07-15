using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using nmsSetupWeb;
using nmsProfile;


public partial class InstitutePanel_List : System.Web.UI.Page
{
    PRPSetupWeb prppram;
    PRPSetupWeb prp;
    clsBLSetupWeb bl;
    static string type = "", memberId = "", Id = "";
    prpLogin objlogin;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["OfficeCollege"] == null)
        {
          
        }
        else
        {
            if (Page.IsPostBack == false)
            {
                prpLogin objprp = new prpLogin();
                prpLogin objlog = new prpLogin();
                objlog = (prpLogin)(Session["OfficeCollege"]);
                memberId = objlog.EmployeeId;
                if (objlog.loginType == "4" || objlog.loginType == "2")
                {
                    trCollege.Visible = true;
                    trTutor.Visible = false;
                   
                    ShowList();
                }
              
                else
                {
                    trCollege.Visible = false;
                    trTutor.Visible = true;
                    ShowList1();
                }
            }
        }
       
    }

    private void ShowList()
    {
        prp = new PRPSetupWeb();
        bl = new clsBLSetupWeb();
        PRPSetupWeb prp1 = new PRPSetupWeb();
        prp1.id = memberId;
        Repeater1.DataSource = bl.ShowCrsLinkList(prp1);
        Repeater1.DataBind();
    }

    private void ShowList1()
    {
        prp = new PRPSetupWeb();
        bl = new clsBLSetupWeb();
        PRPSetupWeb prp1 = new PRPSetupWeb();
        prp1.id = memberId;
        Repeater2.DataSource = bl.ShowCrsLinkList(prp1);
        Repeater2.DataBind();
    }

   
    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "Delete")
        {
            prp = new PRPSetupWeb();
            bl = new clsBLSetupWeb();
            prp.id = e.CommandArgument.ToString();
            prp.codeId = memberId;
            bl.DelCrsLinkList(prp);
            ShowList();
        }
        else
        {
            Response.Redirect("AddTutorSubject.aspx?list=" + e.CommandArgument.ToString());
        }
    }
    protected void Repeater2_ItemCommand(object source, RepeaterCommandEventArgs e)
    {

        if (e.CommandName == "Delete")
        {
            prp = new PRPSetupWeb();
            bl = new clsBLSetupWeb();
            prp.id = e.CommandArgument.ToString();
            prp.codeId = memberId;
            bl.DelCrsLinkList(prp);
            ShowList1();
        }
        else
        {
            Response.Redirect("AddCourseList.aspx?list=" + e.CommandArgument.ToString());
        }
    }
    
}