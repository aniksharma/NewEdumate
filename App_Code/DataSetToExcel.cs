using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using nmsJoining;
using System.Collections.Generic;
using System.IO;namespace ExcelUtility
                {
    /// <summary>
    /// Summary description for DataSetToExcel.
    /// </summary>
    public class DataSetToExcel
    {
        public DataSetToExcel()
        {
            //
            // TODO: Add constructor logic here
            //
        }     
        public static void  Convert( List<PRPprofile> ds, HttpResponse Response)
        {
            Response.Clear();
            Response.Charset="";
            Response.ContentType="application/vnd.ms-excel";   
            System.IO.StringWriter  stringWrite=new System.IO.StringWriter();
            System.Web.UI.HtmlTextWriter  htmlWrite=new System.Web.UI.HtmlTextWriter(stringWrite) ;
            System.Web.UI.WebControls.DataGrid dg=new System.Web.UI.WebControls.DataGrid();
           // dg.DataSource=ds.Tables[0];
            dg.DataSource = ds;
            dg.DataBind();
            dg.RenderControl(htmlWrite);
            Response.Write(stringWrite.ToString());
            Response.End();
        } 

    }
}

