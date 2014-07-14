using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using nmsSetup;

public partial class Admin_web_EducationBoardPrev : System.Web.UI.Page
{
    clsBLSetup obj;
    PRPSetup objprp, objparm;
    protected void Page_Load(object sender, EventArgs e)
    {
        getContent();

    }
    public void getContent()
    {
        obj = new clsBLSetup();
        objprp = new PRPSetup();
        objparm = new PRPSetup();
        if (Request.QueryString["uniid"] != null)
        {
            objparm.id = Request.QueryString["uniid"].ToString();
            // objparm.id = "0";
        }

        objprp = obj.SelEducationBoard(objparm);
        string str = "";
        if (objprp.urlPath != "")
        {
            str += "<table style=\"margin-left:6px;\"><tr style='background-image:url(../img/ggd1.png);color:#fff;'><td align=\"left\" colspan='2' ><span style=\"font-size:21px;font-family:Arial;\"><b>" + objprp.title + "</b></span></td></tr>";
            str += " <tr ><td colspan=\"2\" valign=\"top\" style=\"text-align:justify; color:#444444;\"><div style=\"float:right; height:200;width:210;margin-left:7px; border:solid 1px #ffffff;\"><img src=\"../" + objprp.urlPath + "\" height=\"200\" width=\"210\" alt=\"\" style=\"-moz-border-radius: 10px;-webkit-border-radius: 10px;border-radius: 10px;border:solid 1px #ffffff;\" /></div>" + objprp.description + "</td></tr></table>";
            // str += " <div style=\"float:right; height:200px;width:190px\"><img src=\"" + objprp.urlPath + "\" alt=\"\" /></div>";
        }
        else
        {
            str += "<table style=\"margin-left:6px;\"><tr style='background-image:url(../img/ggd1.png);color:#fff;' ><td align=\"left\" colspan='2'><span style=\"font-size:21px;font-family:Arial;\"><b>" + objprp.title + "</b></span></td></tr>";
            str += " <tr ><td colspan=\"2\" valign=\"top\" style=\"text-align:justify; color:#444444;\">" + objprp.description + "</td></tr></table>";
        }

        newsDiv.InnerHtml = str;
    }
}