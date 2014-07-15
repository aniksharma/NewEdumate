﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using nmsSetupI;
using st;

public partial class UserControl_MainTop : System.Web.UI.UserControl
{
    //clsBLSetup obj;
    //PRPSetup objprp, objparm;
    //static string Id = "";
    //string strcon = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
    DataSet ds;
    string name = "";
    string UniNames = "";

    EdumateService.EdumateServiceClient proxy;
    string msg, msg1;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (name != null)
        {
            Session["UniName"] = name;
            UniNames = Session["UniName"].ToString();
        }
        if (!IsPostBack == true)
        {
            BindCountry();
        }
    }

    public void BindCountry()
    {
        proxy = new EdumateService.EdumateServiceClient();
        //SqlConnection con = new SqlConnection(strcon);
        //SqlCommand cmd = new SqlCommand("viewCountryDetails", con);
        //cmd.CommandType = CommandType.StoredProcedure;
        //SqlParameter[] paramsToStore =
        //   new SqlParameter[4];
        //SqlDataAdapter da = new SqlDataAdapter(cmd);
        //da.Fill(ds);
        ds = new DataSet();
        EdumateService.DbPara[] arrObj = new EdumateService.DbPara[0];
        ds = proxy.EdumateGetDataSetSP(out msg, out msg1, arrObj, "viewCountryDetails");
        ddlcountry.DataSource = ds;
        ddlcountry.DataValueField = "id";
        ddlcountry.DataTextField = "name";
        ststics1.ddlname = "Country";
        ddlcountry.DataBind();


    }



}