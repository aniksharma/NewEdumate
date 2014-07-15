﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class logout : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session.Abandon();
        Session.Clear();
        Response.ExpiresAbsolute = DateTime.Now.AddDays(-1);
        Response.CacheControl = "no-cache";
        Response.Cache.SetCacheability(HttpCacheability.NoCache);

        if (Session["OfficeCollege"] == null)
        {
            Response.Redirect("Default.aspx");
        }
    }
}