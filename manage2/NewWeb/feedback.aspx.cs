using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using nmsSetup;
using nmsDropDown;
using nmsView;
using nmsEditor;

public partial class Contactus : System.Web.UI.Page
{

    clsBLEditor obj;
    PRPEditor objprp;
    string name = "", temp = "", page = "", code = "", all = "";

    protected void Page_Load(object sender, EventArgs e)
    {
       

        if (Page.RouteData.Values["code"] != null)
        {
            code = Page.RouteData.Values["code"].ToString();            
        }
        else
        {
            Response.Redirect("default.aspx");

        }


        if (Page.IsPostBack == false)
        {           
            string checkCode = this.CreateRandomCode(6);
            Session["CheckCode"] = checkCode;
            Label2.Text = checkCode;            
        }
    }   
    public string CreateRandomCode(int codeCount)
    {
        string allChar = "0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";
        string[] allCharArray = allChar.Split(',');
        string randomCode = "";
        int temp = -1;

        Random rand = new Random();
        for (int i = 0; i < codeCount; i++)
        {
            if (temp != -1)
            {
                rand = new Random(i * temp * ((int)DateTime.Now.Ticks));
            }
            int t = rand.Next(36);
            if (temp != -1 && temp == t)
            {
                return CreateRandomCode(codeCount);
            }
            temp = t;
            randomCode += allCharArray[t];
        }
        return randomCode;
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        obj = new clsBLEditor();
        objprp = new PRPEditor();
       
        if (Veryfycode.Text == Label2.Text)
        {
            objprp.FistName = txtFirstName.Text;
            objprp.LastName = txtLastName.Text;
            objprp.Email = txtEmailID.Text;
            objprp.mobileNo1 = txtMobileNo.Text;
            objprp.newsDescription = txtRemarks.Text;
          //  objprp.Page = page;
            objprp.SchoolId = code;
            lblMsg.Text = obj.InsertEnquiry(objprp);
           
            if (lblMsg.Text == "Successfully Submitted")
            {
                textblank();
                string checkCode = this.CreateRandomCode(6);
                Session["CheckCode"] = checkCode;
                Label2.Text = checkCode;
            }

        }
        else
        {
            string checkCode = this.CreateRandomCode(6);
            Session["CheckCode"] = checkCode;
            Label2.Text = checkCode;
            Veryfycode.Text = "";
            Label1.Text = "Insert Same Code As Show";
        }
    }

    private void textblank()
    {
        txtFirstName.Text = "";
        txtLastName.Text = "";
        txtEmailID.Text = "";
        txtMobileNo.Text = "";
        txtRemarks.Text = "";
        txtFirstName.Focus();
        Veryfycode.Text = "";
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        string checkCode = this.CreateRandomCode(6);
        Session["CheckCode"] = checkCode;
        Label2.Text = checkCode;
    }   
}