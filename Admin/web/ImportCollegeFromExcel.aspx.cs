using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;


using nmsSetup;
using nmsDropDown;
using nmsView;
using System.IO;

public partial class Admin_web_ImportCollegeFromExcel : System.Web.UI.Page
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
                
                #region New Upload Code from Excel
                prp = new PRPSetup();
                bl = new clsBLSetup();

                prp.srNo = ds.Tables[0].Rows[a][0].ToString();
                prp.name = ds.Tables[0].Rows[a][1].ToString();
                prp.city = ds.Tables[0].Rows[a][2].ToString();     // ddlCity.SelectedValue;
                prp.district = ds.Tables[0].Rows[a][3].ToString(); //ddlDistrict.SelectedValue;   // District
                prp.state = ds.Tables[0].Rows[a][4].ToString(); //ddlUniversity.SelectedValue;   //for State
                prp.uniID = ds.Tables[0].Rows[a][5].ToString(); //ddlUniversity0.SelectedValue; //For Country
                prp.status = ds.Tables[0].Rows[a][6].ToString(); //College Type school,College
                prp.education = ds.Tables[0].Rows[a][7].ToString(); //ddl.SelectedValue; 
                prp.rank = ds.Tables[0].Rows[a][8].ToString();//ddlRankList.SelectedItem.Text;
                prp.grade = ds.Tables[0].Rows[a][9].ToString(); //ddlGrade.SelectedValue; 
                prp.phoneNo = ds.Tables[0].Rows[a][10].ToString();
                prp.mailId = ds.Tables[0].Rows[a][11].ToString(); //txtMailId.Text;
                prp.emailID = ds.Tables[0].Rows[a][12].ToString();//txtWebSite.Text;
                prp.address = ds.Tables[0].Rows[a][13].ToString();
                prp.DOJ = ds.Tables[0].Rows[a][14].ToString(); //txtDate.Text;
                prp.isActive = ds.Tables[0].Rows[a][15].ToString(); //rblStatus.SelectedValue;
                prp.mobNo = ds.Tables[0].Rows[a][16].ToString(); //txtmobNo.Text;
                prp.pinCode = ds.Tables[0].Rows[a][17].ToString();//txtBranchCode.Text;  

                prp.sCollegeLogo = "../Advertisement/universityLogo.png";//image
                prp.id = ds.Tables[0].Rows[a][21].ToString();//ddlUniversityFinal.SelectedValue;  // for Univercity //Approved by//Affiliatedby(University)
                prp.ApprovedBy = ds.Tables[0].Rows[a][22].ToString();   //ApprovedBy.SelectedValue;    //ApproveId (UGC)
                prp.nneSMS = ds.Tables[0].Rows[a][26].ToString();
                prp.sCategory = ds.Tables[0].Rows[a][27].ToString(); //ddlCategory.SelectedValue;
                prp.subCategory = ds.Tables[0].Rows[a][28].ToString();//ddlSubCategory.SelectedValue;

                //prp.CourseLevel = ds.Tables[0].Rows[a][29].ToString(); //ddlCourseLevel.SelectedValue;             

                //prp.status = ds.Tables[0].Rows[a][24].ToString(); //ddlUniType.SelectedItem.Text; //Ownership//private,semi gov,gov
                //prp.mainLandMark = ds.Tables[0].Rows[a][25].ToString(); //txtLandMark.Text;

                lblMsg.Text = bl.InsertCollegeDetail(prp);
                #endregion



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


            if (lblMsg.Text == "Submit Successfully!")
            {
                Warrning.InnerHtml = "<div class='message error'> <h5>College data</h5> <p>Uploaded  Successfully !! </p> </ div>";
            }
      
        }

        catch (Exception ex)
        { Warrning.InnerHtml = "<div class='message error'> <h5>error!</h5> <p>" + ex.Message + "</p> </div>"; }
    }
}