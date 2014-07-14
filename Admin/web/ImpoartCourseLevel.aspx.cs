using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using nmsSetupWeb;
using System.Data;

public partial class Admin_web_ImpoartCourseLevel : System.Web.UI.Page
{


    OleDbConnection oledbConn;

    clsBLSetupWeb obj;
    PRPSetupWeb objprp, objparm;

    static string Id = "", imgurl = "", imageId = "", fileURL = "", MaxId = "";
    string path = "";
    int expstn;
    string type = "", memberId = "";
    static string branchId = "", collegeTypeId = "";

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private void GenerateExcelData()
    {
        string server = "", fileexns = "";
        int index;
        index = FileUpload1.FileName.LastIndexOf('.');
        fileexns = FileUpload1.FileName.Substring(index + 1);
        if (fileexns == "xlsx")
        { 
            server = Server.MapPath("../../ExeclFile/" + FileUpload1.FileName);
            FileUpload1.SaveAs(server);
           
            string path = server; //Server.MapPath(server);//Already Uploaded File In Web
            ////string path = Path.GetFullPath(uploadExcelFile.PostedFile.FileName);

            /* connection string  to work with excel file. HDR=Yes - indicates 
               that the first row contains columnnames, not data. HDR=No - indicates 
               the opposite. "IMEX=1;" tells the driver to always read "intermixed" 
               (numbers, dates, strings etc) data columns as text. 
            Note that this option might affect excel sheet write access negative. */

            oledbConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
              path + ";Extended Properties='Excel 12.0;HDR=YES;IMEX=1;';");
            oledbConn.Open();
            OleDbCommand cmd = new OleDbCommand(); ;
            OleDbDataAdapter oleda = new OleDbDataAdapter();
            DataSet ds = new DataSet();

            // selecting distict list of Slno 
            cmd.Connection = oledbConn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [Sheet1$]";
            oleda = new OleDbDataAdapter(cmd);
            oleda.Fill(ds, "dsSlno");
            int TotalRow, a;
            TotalRow = ds.Tables[0].Rows.Count;
            for (a = 0; a < TotalRow; a++)
            {    
                objprp = new PRPSetupWeb();
                obj = new clsBLSetupWeb();
                objprp.name = ds.Tables[0].Rows[a][0].ToString();// txtUserName.Text;                
                objprp.uniID = ds.Tables[0].Rows[a][1].ToString();
                objprp.description = ds.Tables[0].Rows[a][0].ToString(); ;          
                objprp.urlPath = "images/CourseLevelLogo.png";
                objprp.sCountry = "1";
                lblMsg.Text = obj.InsCourseLevel(objprp);
            }

            oledbConn.Close();
            cmd.Dispose();
            oleda.Dispose();
        }
        else
        { Warrning.InnerHtml = "<div class='message error'> <h5>error!</h5> <p>Upload Only Excel file</p> </ div>"; }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {
            GenerateExcelData();
          
            if (lblMsg.Text == "Inserted Succssfully..")
            {
                Warrning.InnerHtml = "<div class='message error'> <h5></h5> <p>Submit Successfully !! </p> </ div>";
            }


        }

        catch (Exception ex)
        {
            Warrning.InnerHtml = "<div class='message error'> <h5>error!</h5> <p>" + ex.Message + "</p> </div>";
        }
    }
}