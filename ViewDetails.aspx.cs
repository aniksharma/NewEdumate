﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using nmsSetup;
using nmsDropDownJob;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class ViewDetails : System.Web.UI.Page
{
    PRPSetup prppram;
    PRPSetup prp;
    clsBLSetup bl;

    string type = "", memberId = "";
    static string branchId = "";
    string strcon = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
    protected int TotalCount;
    protected int Totalimage;
    SqlDataAdapter da;

    protected DataSet ds = new DataSet();
    protected DataSet dsImage = new DataSet();
    int contid;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (contid != null)
            {
                SelectDatail(1);
                BindImage();
            }
            else
            {
                SelectDatail(1);
                BindImage();

            }
        }
    }

    private void SelectDatail()
    {

        bl = new clsBLSetup();
        prppram = new PRPSetup();

        List<PRPSetup> lst = new List<PRPSetup>();
        lst = bl.ViewUniversityWeb(prppram);

    }

    private void binduniversity()
    {
        clsBLdropDown drp = new clsBLdropDown();
        clsPRPdropdown drpprp = new clsPRPdropdown();

        drpprp.spName = "viewUniversityWeb";
        drp.bindDropDown(drpprp);

    }

    public void bindUNI()
    {
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand("viewUniversityWeb_srikant", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] paramsToStore =
           new SqlParameter[4];
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        TotalCount = ds.Tables[0].Rows.Count;

    }

    public void BindImage()
    {
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand("viewImageGalleryHome", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] paramsToStore =
           new SqlParameter[4];


        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dsImage);


        Totalimage = dsImage.Tables[0].Rows.Count;

    }

    protected void ddlNopage_SelectedIndexChanged(object sender, EventArgs e)
    {
        SelectDatail(1);
    }

    private void SelectDatail(Int32 pageIndex)
    {

        bl = new clsBLSetup();
        prppram = new PRPSetup();
        Int32 pageSize = Convert.ToInt32(ddlNopage.SelectedValue);
        prppram.pageIndex = pageIndex.ToString();
        prppram.pageSize = pageSize.ToString();
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd = new SqlCommand("viewUniversityWeb_srikant", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter[] paramsToStore =
           new SqlParameter[4];
        paramsToStore[0] = new SqlParameter("@pageSize", SqlDbType.NVarChar);
        paramsToStore[0].Size = 20;
        cmd.Parameters.Add(paramsToStore[0]).Value = ddlNopage.SelectedValue;
        paramsToStore[1] = new SqlParameter("@pageIndex", SqlDbType.NVarChar);
        paramsToStore[1].Size = 100;
        cmd.Parameters.Add(paramsToStore[1]).Value = pageIndex;
        paramsToStore[2] = new SqlParameter("@contid", SqlDbType.Int);
        paramsToStore[2].Size = 60;
        cmd.Parameters.Add(paramsToStore[2]).Value = contid;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);

        //----------------------------------------------

        TotalCount = ds.Tables[0].Rows.Count;

    }
}