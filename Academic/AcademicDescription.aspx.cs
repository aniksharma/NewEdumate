using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using org.w3c.dom;
using iTextSharp.text;
using System.IO;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;


public partial class Academic_AcademicDescription : System.Web.UI.Page
{
    string strcon = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
    string sLiteral = "";
    protected string strsave, strsave1, strsave2, strsave3, strsave4, strsave5, strsave6;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        BindData();
    }
    protected void BindData()
    {
        string Academic_Id = Request.QueryString["CDsce"];
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand("Sp_Bind_Academic_Data_Desc", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "Sp_Bind_Academic_Data_Desc";
        try
       {
       SqlParameter[] paramsToStore = new SqlParameter[1];
 
       paramsToStore[0] = new SqlParameter("@Academic_Id", SqlDbType.NVarChar);
       paramsToStore[0].Size=200;
       cmd.Parameters.Add(paramsToStore[0]).Value = Academic_Id;
 
       }
       catch (Exception excp)
        {
            lblMsg.ForeColor = System.Drawing.Color.Red;
            lblMsg.Text = excp.Message;
        }
        con.Open();
        cmd.Connection = con;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();

        da.Fill(dt);
        if (dt.Rows.Count>0)
        {
            strsave = dt.Rows[0]["Academic_Title"].ToString();
            strsave1 = dt.Rows[0]["Academic_Desc"].ToString();
            strsave6 = dt.Rows[0]["Academic_Content"].ToString(); 
            strsave2 = dt.Rows[0]["collegeImage"].ToString();
            strsave3 = dt.Rows[0]["collegeName"].ToString();
            strsave4 = dt.Rows[0]["created_Date_Time"].ToString();
            strsave5 = dt.Rows[0]["created_Date"].ToString();
            
        }
        else
        {

        }
    }
    protected void btnExport_Click(object sender, EventArgs e)
    {
        Response.ContentType = "application/pdf";
        Response.AddHeader("content-disposition", "attachment;filename=EduMate World Academic.pdf");
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        StringWriter sw = new StringWriter();
        HtmlTextWriter hw = new HtmlTextWriter(sw);
        hw.Write("<h1 style='color:#4179B0;margin-left:40px; margin-top: -20px;margin-bottom:20px;'>" + "<b>" + "EduMate World" + "</b>" + "</h1>" + "</br></br></hr>");
        pnlPerson.RenderControl(hw);
        
        StringReader sr = new StringReader(sw.ToString());
        iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A4, 10f, 10f, 100f, 0f);
        HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
        PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
        pdfDoc.Open();
        htmlparser.Parse(sr);
        pdfDoc.Close();
        Response.Write(pdfDoc);
        Response.End();
    }
}