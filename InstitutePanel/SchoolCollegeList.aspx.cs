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

public partial class InstitutePanel_Default4 : System.Web.UI.Page
{

    PRPSetupWeb prppram;
    PRPSetupWeb prp;
    clsBLSetupWeb bl;
    static string type = "", memberId = "", Id = "", newId="";
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
               

                if (objlog.loginType == "8")
                {
                    if (Request.QueryString["sec"] != null)
                    {
                        College.Visible = false;
                        School.Visible = true;
                        ShowList();

                    }
                    else
                    {
                        School.Visible = false;
                        College.Visible = true;
                        ShowList1();
                    }

                }

                else
                { 
                
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
        prp1.courseType = "secondary";
        Repeater3.DataSource = bl.ShowSchoolDetail(prp1);
        Repeater3.DataBind();
    }
    private void ShowList1()
    {
        prp = new PRPSetupWeb();
        bl = new clsBLSetupWeb();
        PRPSetupWeb prp1 = new PRPSetupWeb();
        prp1.id = memberId;
        prp1.courseType = "Higher";
        Repeater1.DataSource = bl.ShowCollegeDetail(prp1);
        Repeater1.DataBind();
    }
    protected void Repeater3_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "Delete")
        {
            prp = new PRPSetupWeb();
            bl = new clsBLSetupWeb();
            prp.id = e.CommandArgument.ToString();
            prp.codeId = memberId;
            bl.DelSchoolDetail(prp);
            ShowList();
        }
        else
        {
           
            Response.Redirect("AddSchool.aspx?edit=yes&&id="+e.CommandArgument.ToString()); 
        }
    }
    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "Delete")
        {
            prp = new PRPSetupWeb();
            bl = new clsBLSetupWeb();
            prp.id = e.CommandArgument.ToString();
            prp.codeId = memberId;
            bl.DelCollegeDetail(prp);
            ShowList1();
        }
        else
        {

            Response.Redirect("AddCollege.aspx?edit=yes&&id="+e.CommandArgument.ToString());
        }
    }
    
   
}