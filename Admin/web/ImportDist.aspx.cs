using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;
using nmsSetup;
using nmsDropDown;
using nmsView;
using System.IO;
using System;

public partial class Admin_web_ImportDist : System.Web.UI.Page
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
        { 
            server = Server.MapPath("../web/ExeclFile/" + FileUpload1.FileName);
            FileUpload1.SaveAs(server);
            
            string path = server; 

            oledbConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
              path + ";Extended Properties='Excel 12.0;HDR=YES;IMEX=2\';");
            oledbConn.Open();
            OleDbCommand cmd = new OleDbCommand(); ;
            OleDbDataAdapter oleda = new OleDbDataAdapter();
            DataSet ds = new DataSet();

            // selecting distict list of Slno 
            cmd.Connection = oledbConn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT distID,distName,statID FROM [DSSLNO$]";
            oleda = new OleDbDataAdapter(cmd);
            oleda.Fill(ds);
            int TotalRow, a;
            TotalRow = ds.Tables[0].Rows.Count;
            for (a = 0; a < TotalRow; a++)
            {


                objprp = new PRPSetup();
                obj = new clsBLSetup();
                objprp.name = ds.Tables[0].Rows[a][1].ToString();// txtUserName.Text;
                objprp.uniID = ds.Tables[0].Rows[a][2].ToString();// ddlUniversity.SelectedValue;
                objprp.id = ds.Tables[0].Rows[a][0].ToString();
                lblMsg.Text = obj.InsDistrict(objprp);

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
            if (lblMsg.Text == "Submit Successfully")
            {
                Warrning.InnerHtml = "<div class='message error'> <h5>District data</h5> <p>Submit Successfully !! </p> </ div>";
            }


        }

        catch (Exception ex)
        {
            Warrning.InnerHtml = "<div class='message error'> <h5>error!</h5> <p>" + ex.Message + "</p> </div>";
        }
    }
}