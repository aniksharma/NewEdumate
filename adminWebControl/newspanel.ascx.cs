using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using nmsSetup;
public partial class adminWebControl_newspanel : System.Web.UI.UserControl
{
     clsBLSetup obj;
    PRPSetup objprp, objparm;


    protected string title1(object name)
    {
        return ((string)name).Replace(" ", "-");
    }


    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            getNewsh1(1);
            getNewsh2(1);
            getNewsh3(1);
        }
    }


public void getNewsh1(Int32 pageIndex)
    {

        obj = new clsBLSetup();
        objprp = new PRPSetup();
        objprp.catID = "7";
        objprp.uniID = "1";

        Int32 pageSize = 4;

        objprp.pageIndex = pageIndex.ToString();
        objprp.pageSize = pageSize.ToString();
        
        List<PRPSetup> lst1 = new List<PRPSetup>();

        lst1 = obj.viewNewsWithPaging1(objprp);

        Int32 noOfRecord = Convert.ToInt32(lst1[lst1.Count - 1].noOfRecord);

        lst1.RemoveAt(lst1.Count - 1);
      

        DataList2.DataSource = lst1;
        DataList2.DataBind();
     
    }
    public void getNewsh2(Int32 pageIndex)
    {

        obj = new clsBLSetup();
        objprp = new PRPSetup();
        objprp.catID = "8";
        objprp.uniID = "1";      
        objprp.pageIndex = pageIndex.ToString();     
        List<PRPSetup> lst1 = new List<PRPSetup>();
        lst1 = obj.viewNewsWithPaging1(objprp);     
        lst1.RemoveAt(lst1.Count - 1);
        ddlAlert.DataSource = lst1;
        ddlAlert.DataBind();  
    }
    public void getNewsh3(Int32 pageIndex)
    {
        obj = new clsBLSetup();
        objprp = new PRPSetup();
        objprp.catID = "9";
        objprp.uniID = "1";
        objprp.pageIndex = pageIndex.ToString();
        List<PRPSetup> lst1 = new List<PRPSetup>();
        lst1 = obj.viewNewsWithPaging1(objprp);
        lst1.RemoveAt(lst1.Count - 1);
        Artical.DataSource = lst1;
        Artical.DataBind();         
    }
}