using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using nmsSetupI;
using System.Configuration;

public partial class New_Final : System.Web.UI.Page
{
    protected int TotalCount;
    protected int TotalCount2;
    protected int TotalCount1;
    string NewsId = "";
   
    string comment = "", username = "", pwd = "";
    protected DataSet ds;
    protected DataSet dss;
    
    EdumateService.EdumateServiceClient proxy;
    string msg, msg1;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (RouteData.Values["pps"] != null)
        {
            NewsId = HttpContext.Current.Request.RequestContext.RouteData.Values["pps"].ToString();
        }
        else
        {
            NewsId = Request.QueryString["Id"].ToString();
        }
        SelectDatail(1);
        bindUNI();
    }

    private void SelectDatail(Int32 pageIndex)
    {

        proxy = new EdumateService.EdumateServiceClient();
        EdumateService.DbPara[] arrObj = new EdumateService.DbPara[3];
        arrObj[0] = new EdumateService.DbPara();
        arrObj[0].ParaName = "@pageSize";
        arrObj[0].ParaValue = "10";
        arrObj[1] = new EdumateService.DbPara();
        arrObj[1].ParaName = "@pageIndex";
        arrObj[1].ParaValue = Convert.ToString(pageIndex);
        arrObj[2] = new EdumateService.DbPara();
        arrObj[2].ParaName = "@newsId";
        arrObj[2].ParaValue = NewsId;
        ds = new DataSet();
        ds = proxy.EdumateGetDataSetSP(out msg, out msg1, arrObj, "viewNews_SelectedTitle");
        //----------------------------------------------

        TotalCount = ds.Tables[0].Rows.Count;

    }

    protected void btn1_Click(object sender, EventArgs e)
    {

        // insertComment();
        comment = Request["comment"].ToString();
        username = Request["username"].ToString();
        pwd = Request["password"].ToString();
        insertComment();
        // string cmt = Request["comment"].ToString();
    }
    public void insertComment()
    {
        //SqlConnection con = new SqlConnection(strcon);
        //SqlCommand cmd = new SqlCommand("Sp_insert", con);
        //cmd.CommandType = CommandType.StoredProcedure;
        //cmd.CommandText = "Sp_insert";
        //try
        //{
        //    SqlParameter[] paramsToStore =
        // new SqlParameter[2];

        //    paramsToStore[0] = new SqlParameter("@email", SqlDbType.NVarChar);
        //    paramsToStore[0].Size = 20;
        //    cmd.Parameters.Add(paramsToStore[0]).Value = username;
        //    paramsToStore[1] = new SqlParameter("@comment", SqlDbType.NVarChar);
        //    paramsToStore[1].Size = 100;
        //    cmd.Parameters.Add(paramsToStore[1]).Value = comment;


        //}

        //catch (Exception excp)
        //{
        //    lblMsg.ForeColor = System.Drawing.Color.Red;
        //    lblMsg.Text = excp.Message;
        //}
        //con.Open();
        //cmd.Connection = con;
        //int y = cmd.ExecuteNonQuery();

        //if (y > 0)
        //{
        //    lblMsg.Visible = true;
        //    lblMsg.ForeColor = System.Drawing.Color.Green;
        //    lblMsg.Text = "Insert Successfully...";

        //    bindUNI();
        //}

        //else
        //{
        //    Response.Write("<script>window.alert('Envalid Email or PassWord Plz Register')</script>");
        //}


    }

    public void bindUNI()
    {
        proxy = new EdumateService.EdumateServiceClient();
        EdumateService.DbPara[] arrObj = new EdumateService.DbPara[0];
        dss = new DataSet();
        dss = proxy.EdumateGetDataSetSP(out msg, out msg1, arrObj, "Sp_Commentdetails");
        TotalCount2 = dss.Tables[0].Rows.Count;

    }
}