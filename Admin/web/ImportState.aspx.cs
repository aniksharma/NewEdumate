using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;
using nmsSetup;
using nmsDropDown;
using nmsView;
using System.IO;
using System;

public partial class Admin_web_ImportState : System.Web.UI.Page
{

    OleDbConnection oledbConn;
    clsBLSetup obj;
    PRPSetup objprp, objparm;
    static string Id = "";
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
            oledbConn.Open();
            OleDbCommand cmd = new OleDbCommand(); ;
            OleDbDataAdapter oleda = new OleDbDataAdapter();
            DataSet ds = new DataSet();

            // selecting distict list of Slno 
            cmd.Connection = oledbConn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT stateId,stateName,cntId FROM [DSSLNO$]";
            oleda = new OleDbDataAdapter(cmd);
            oleda.Fill(ds);
            int TotalRow, a;
            TotalRow = ds.Tables[0].Rows.Count;
            for (a = 0; a < TotalRow; a++)
            {
                objprp = new PRPSetup();
                obj = new clsBLSetup();
                objprp.id = ds.Tables[0].Rows[a][0].ToString();
                objprp.name = ds.Tables[0].Rows[a][1].ToString();// txtUserName.Text;
                objprp.uniID = ds.Tables[0].Rows[a][2].ToString();//ddlUniversity.SelectedValue;
                lblMsg.Text = obj.InsState(objprp);

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
            if (lblMsg.Text == "Submit Successfully !")
            {
                Warrning.InnerHtml = "<div class='message error'> <h5>State data</h5> <p>Submit Successfully !! </p> </ div>"; 
            }
            

        }

        catch (Exception ex)
        { 
            Warrning.InnerHtml = "<div class='message error'> <h5>error!</h5> <p>" + ex.Message + "</p> </div>"; 
        }
    }
}