using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using nmsSetup;

using nmsADOjob;
using System.Collections.Generic;
namespace nmsSetup
{
    public class clsDLCompany
    {
        //--------------------------------------------------------
        clsBLado ADO = new clsBLado();
        clsPRPadoBL ADOprp = new clsPRPadoBL();
        clsPRPadoDL ADOprpDL = new clsPRPadoDL();
       //------------------------------------------------
        clsprpADO objadoprp = new clsprpADO();
        clsADO objado = new clsADO();

        //--start--University-------------------
        public string spInsertCompany(PRPcompany objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[17];
            ADOprp.ArrayPram[0] = new SqlParameter("@Company_Name", objprp.Company_Name);
            ADOprp.ArrayPram[1] = new SqlParameter("@Company_Tital_Name", objprp.Company_Tital_Name);
            ADOprp.ArrayPram[2] = new SqlParameter("@Registration_No", objprp.Registration_No);
            ADOprp.ArrayPram[3] = new SqlParameter("@Phone_No", objprp.Phone_No);
            ADOprp.ArrayPram[4] = new SqlParameter("@Company_Address", objprp.Company_Address);
            ADOprp.ArrayPram[5] = new SqlParameter("@City_Id", objprp.City_Id);
            ADOprp.ArrayPram[6] = new SqlParameter("@Company_Email_Id", objprp.Company_Email_Id);
            ADOprp.ArrayPram[7] = new SqlParameter("@Company_Type_Id", objprp.Company_Type_Id);
            ADOprp.ArrayPram[8] = new SqlParameter("@Company_Img_Url", objprp.Company_Img_Url);
            ADOprp.ArrayPram[9] = new SqlParameter("@Employee_Designation", objprp.Employee_Designation);
            ADOprp.ArrayPram[10] = new SqlParameter("@Company_IsActive", objprp.Company_IsActive);
            ADOprp.ArrayPram[11] = new SqlParameter("@company_serviceOffers", objprp.company_serviceOffers);
            ADOprp.ArrayPram[12] = new SqlParameter("@company_Description", objprp.company_Description);
            ADOprp.ArrayPram[13] = new SqlParameter("@company_LogoForHome", objprp.company_LogoForHome);
            ADOprp.ArrayPram[14] = new SqlParameter("@company_phoneNo", objprp.company_phoneNo);
            ADOprp.ArrayPram[15] = new SqlParameter("@company_ContactPerson", objprp.company_ContactPerson);
            ADOprp.ArrayPram[16] = new SqlParameter("@company_website", objprp.company_website);
            ADOprp.SPName = "spInsertCompany";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);

        }
   
      

    }
    
}