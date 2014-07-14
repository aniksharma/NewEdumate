using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using nmsDropDown;
using nmsView;
using System.IO;
using nmsSetupUniversity;

public partial class Admin_MasterPage_Default : System.Web.UI.Page
{
     OleDbConnection oledbConn;

    clsBLUniversity obj;
    PRPSetupUniversity objprp, objparm;
     

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
                objprp = new PRPSetupUniversity();
                obj = new clsBLUniversity();
                objprp.id = ds.Tables[0].Rows[a][0].ToString();
                objprp.name = ds.Tables[0].Rows[a][1].ToString();
                objprp.isActive = ds.Tables[0].Rows[a][2].ToString();          //txtName.Text;   //University Edumate
                objprp.title = ds.Tables[0].Rows[a][3].ToString();         //ddlUniversity.SelectedValue;  //1      //State
                objprp.description = ds.Tables[0].Rows[a][4].ToString();         // ddlUniversity0.SelectedValue;   //1   //country
                objprp.urlPath = ds.Tables[0].Rows[a][5].ToString();         //ddlUniType.SelectedValue;   //1        //University Type
                objprp.country = ds.Tables[0].Rows[a][6].ToString();       //txtAddress.Text;          //Hisar   //Address 
                objprp.state = ds.Tables[0].Rows[a][7].ToString();                                     //ddlDistrict.SelectedValue;  //1     // Dist
                objprp.district = ds.Tables[0].Rows[a][8].ToString();                                        //ddlCity.SelectedValue;          //2     //City               

                lblMsg.Text = obj.InsUniversityType(objprp);

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
         
            if (lblMsg.Text == "University Submit Successfully !")
            {
                Warrning.InnerHtml = "<div class='message error'> <h5></h5> <p>Your University Details Successfully Uploaded !! </p> </ div>";
            }

        }

        catch (Exception ex)
        { Warrning.InnerHtml = "<div class='message error'> <h5>error!</h5> <p>" + ex.Message + "</p> </div>"; }
    }
    }
