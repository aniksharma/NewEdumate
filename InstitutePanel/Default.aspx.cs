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
using System.Collections.Generic;
using nmsSetup;
using nmsSetupWeb;

public partial class InstitutePanel_Default : System.Web.UI.Page
{
    clsBLSetup obj;
    PRPSetup objprp, objparm;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["OfficeCollege"] == null)
        {
           Response.Redirect("../Default.aspx");
        }

        if (Page.IsPostBack == false)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                
        {
            getNewsh1(1);
            getNewsh2(1);
            getNewsh3(1);
            showNews();
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
    }

    private void showNews()
    {
        PRPSetupWeb prp = new PRPSetupWeb();
        clsBLSetupWeb bl = new clsBLSetupWeb();
        PRPSetupWeb prp1 = new PRPSetupWeb();

        List<PRPSetupWeb> lst1 = new List<PRPSetupWeb>();
        lst1 = bl.ShowTastomony();
        string st = "";
        st += "<ul style=\"overflow: hidden; position: relative; top: 0px; margin: 0px; padding-top:20px; left: 0px; height: 190px; width:673px; \" id=\"scroller\" >";
        foreach (PRPSetupWeb t in lst1)
        {
            st += "<li style='border-collapse: collapse;box-shadow: 5px 5px 10px #CDCDCD; height:140px; border:1px solid #DADADA; margin-right:20px;'>";

            st += "<div style='font-weight: 600; width:300px; height:113px; padding:10px; overflow: hidden;'>" + t.description + "</div>";
            st += "<div style='width:160px; float:right; margin-top:-35px; '>--" + t.name + "</div>";

            st += "</li>";
        }
        st += "</ul>";
    }
}
