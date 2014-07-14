using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using nmsSetup;
using System.Data;
using nmsSetupWeb;

public partial class Admin_MasterPage_Default : System.Web.UI.Page
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
        { //FileInfo file = new FileInfo(FileUpload1.FileName);
            // need to pass relative path after deploying on server
            server = Server.MapPath("../web/ExeclFile/" + FileUpload1.FileName);
            FileUpload1.SaveAs(server);
            //if (FileUpload1.SaveAs(server) == true)
            //{ }
            //else
            //{
            string path = server; //Server.MapPath(server);//Already Uploaded File In Web
            ////string path = Path.GetFullPath(uploadExcelFile.PostedFile.FileName);

            /* connection string  to work with excel file. HDR=Yes - indicates 
               that the first row contains columnnames, not data. HDR=No - indicates 
               the opposite. "IMEX=1;" tells the driver to always read "intermixed" 
               (numbers, dates, strings etc) data columns as text. 
            Note that this option might affect excel sheet write access negative. */

            oledbConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
              path + ";Extended Properties='Excel 12.0;HDR=YES;IMEX=2\';");

            if (oledbConn.State == ConnectionState.Closed)
            {
                oledbConn.Open();
            }
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataAdapter oleda = new OleDbDataAdapter();
            DataSet ds = new DataSet();

            // selecting distict list of Slno 
            cmd.Connection = oledbConn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select cntId,cntName from [DSSLNO$]";
            oleda = new OleDbDataAdapter(cmd);
            oleda.Fill(ds);
            int TotalRow, a;
            TotalRow = ds.Tables[0].Rows.Count;
            for (a = 0; a < TotalRow; a++)
            {

                objprp = new PRPSetupWeb();
                obj = new clsBLSetupWeb();
                objprp.id = ds.Tables[0].Rows[a][0].ToString();// txtUserName.Text;
                objprp.name = ds.Tables[0].Rows[a][1].ToString();//RadioButtonList1.SelectedValue;

                lblMsg.Text = obj.InsCountry(objprp);

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
            // NotInsertedData();
            if (lblMsg.Text == "Inserted Succssfully..")
            {
                Warrning.InnerHtml = "<div class='message error'> <h5>Country Data</h5> <p>Submit Successfully !! </p> </ div>";
            }


        }

        catch (Exception ex)
        {
            Warrning.InnerHtml = "<div class='message error'> <h5>error!</h5> <p>" + ex.Message + "</p> </div>";
        }
    }
}