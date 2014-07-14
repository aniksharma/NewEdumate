using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using nmsSetup;
using System.Data;

public partial class Admin_web_ImportUniversityExcelFile : System.Web.UI.Page
{

    OleDbConnection oledbConn;

    PRPSetup prppram;
    PRPSetup prp;
    clsBLSetup bl;

    public string Id = "", imgurl = "", imageId = "", fileURL = "", MaxId = "", sLogo = "";
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
              path + ";Extended Properties='Excel 12.0;HDR=YES;IMEX=2/';");
            oledbConn.Open();
            OleDbCommand cmd = new OleDbCommand(); ;
            OleDbDataAdapter oleda = new OleDbDataAdapter();
            DataSet ds = new DataSet();
            cmd.Connection = oledbConn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [DSSLNO$]";
            oleda = new OleDbDataAdapter(cmd);
            oleda.Fill(ds);
            int TotalRow, a;
            TotalRow = ds.Tables[0].Rows.Count;
            for (a = 0; a < TotalRow; a++)
            {
                prp = new PRPSetup();
                bl = new clsBLSetup();
                prp.id = ds.Tables[0].Rows[a][0].ToString();
                prp.name = ds.Tables[0].Rows[a][1].ToString();
                prp.city = ds.Tables[0].Rows[a][2].ToString();
                prp.district = ds.Tables[0].Rows[a][3].ToString();
                prp.state = ds.Tables[0].Rows[a][4].ToString();
                prp.uniID = ds.Tables[0].Rows[a][5].ToString();
                prp.catID = ds.Tables[0].Rows[a][6].ToString();
                prp.education = ds.Tables[0].Rows[a][7].ToString();
                prp.rank = ds.Tables[0].Rows[a][8].ToString();
                prp.grade = ds.Tables[0].Rows[a][9].ToString();
                prp.phoneNo = ds.Tables[0].Rows[a][10].ToString();
                prp.emailID = ds.Tables[0].Rows[a][11].ToString();
                prp.mailId = ds.Tables[0].Rows[a][12].ToString();
                prp.address = ds.Tables[0].Rows[a][13].ToString();
                prp.DOJ = ds.Tables[0].Rows[a][14].ToString();
                prp.status = ds.Tables[0].Rows[a][15].ToString();
                prp.mobNo = ds.Tables[0].Rows[a][16].ToString();
                prp.mainLandMark = ds.Tables[0].Rows[a][17].ToString();
                prp.branchCodeName = ds.Tables[0].Rows[a][18].ToString();
                lblMsg.Text = bl.InsertUniversityWeb(prp);

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
            if (lblMsg.Text == "University Submit Successfully !")
            {
                Warrning.InnerHtml = "<div class='message error'> <h5></h5> <p>Your University Details Successfully Uploaded !! </p> </ div>";
            }

        }

        catch (Exception ex)
        { Warrning.InnerHtml = "<div class='message error'> <h5>error!</h5> <p>" + ex.Message + "</p> </div>"; }
    }
}
//University Submit Successfully !
