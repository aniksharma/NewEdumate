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
//using nmsSetup;
using nmsProfile;
using nmsADO;
using System.Collections.Generic;
namespace nmsSetupUniversity
{
    public class clsDLUniversity
    {
        //--------------------------------------------------------clsBLUniversity
        clsBLado ADO = new clsBLado();
        clsPRPadoBL ADOprp = new clsPRPadoBL();
        clsPRPadoDL ADOprpDL = new clsPRPadoDL();
       //------------------------------------------------
        clsprpADO objadoprp = new clsprpADO();
        clsADO objado = new clsADO();

//--start--University-------------------

        //--Start UniversityType
        public string InsUniversityType(PRPSetupUniversity objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[9];
            ADOprp.ArrayPram[0] = new SqlParameter("@typeName", objprp.name);
            ADOprp.ArrayPram[1] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.ArrayPram[2] = new SqlParameter("@UniversityDescription", objprp.description);
            ADOprp.ArrayPram[3] = new SqlParameter("@SubTitle", objprp.title);
            ADOprp.ArrayPram[4] = new SqlParameter("@UniversityImage", objprp.urlPath);

            ADOprp.ArrayPram[5] = new SqlParameter("@Country", objprp.country);       //     Modify by Devesh
            ADOprp.ArrayPram[6] = new SqlParameter("@State", objprp.state);       //     Modify by Devesh
            ADOprp.ArrayPram[7] = new SqlParameter("@Dist", objprp.district);
            ADOprp.ArrayPram[8] = new SqlParameter("@DelStatus", "1");
            ADOprp.SPName = "insUniversityType";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public string UpdUniversityType(PRPSetupUniversity objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[6];

            ADOprp.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
            ADOprp.ArrayPram[1] = new SqlParameter("@typeName", objprp.name);
            ADOprp.ArrayPram[2] = new SqlParameter("@isActive", objprp.isActive);
            ADOprp.ArrayPram[3] = new SqlParameter("@UniversityDescription", objprp.description);
            ADOprp.ArrayPram[4] = new SqlParameter("@SubTitle", objprp.title);
            ADOprp.ArrayPram[5] = new SqlParameter("@UniversityImage", objprp.urlPath);
            ADOprp.SPName = "updUniversityType";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);


        }
        public string DelUniversityType(PRPSetupUniversity objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
            ADOprp.SPName = "delUniversityType";

            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public PRPSetupUniversity SelUniversityType(PRPSetupUniversity objprp)
        {

            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@typeID", objprp.id);
            ADOprpDL.SPName = "selUniversityType";
            ADO.ReaderWithProceduresandParam(ADOprpDL);
            PRPSetupUniversity obj = new PRPSetupUniversity(); ;

            if (ADOprpDL.Dr.HasRows)
            {

                while (ADOprpDL.Dr.Read())
                {
                    obj.id = ADOprpDL.Dr["typeID"].ToString();
                    obj.name = ADOprpDL.Dr["typeName"].ToString();
                    obj.isActive = ADOprpDL.Dr["isActive"].ToString();
                    obj.description = ADOprpDL.Dr["UniversityDescription"].ToString();
                    obj.title = ADOprpDL.Dr["SubTitle"].ToString();
                    obj.urlPath = ADOprpDL.Dr["UniversityImage"].ToString();
                    obj.country = ADOprpDL.Dr["cntName"].ToString();
                    obj.state = ADOprpDL.Dr["stateName"].ToString();
                    obj.district = ADOprpDL.Dr["distName"].ToString();
                }
            }
            ADO.ReaderClose(ADOprpDL);
            return obj;
        }
        public List<PRPSetupUniversity> viewUniversityType(PRPSetupUniversity prp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[2];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@stateId", prp.state);
            ADOprpDL.ArrayPram[1] = new SqlParameter("@cityId", prp.city);
            ADOprpDL.SPName = "viewUniversityType";
            ADO.ReaderWithProceduresandParam(ADOprpDL);
            PRPSetupUniversity objprp;
            List<PRPSetupUniversity> lst = new List<PRPSetupUniversity>();
            if (ADOprpDL.Dr.HasRows)
            {
                while (ADOprpDL.Dr.Read())
                {
                    objprp = new PRPSetupUniversity();
                    objprp.id = ADOprpDL.Dr["id"].ToString();
                    objprp.name = ADOprpDL.Dr["name"].ToString();
                    objprp.title = ADOprpDL.Dr["SubTitle"].ToString();
                    objprp.urlPath = ADOprpDL.Dr["UniversityImage"].ToString();
                    #region Add Some Field for Repeater
                    objprp.country = ADOprpDL.Dr["cntName"].ToString();
                    objprp.state = ADOprpDL.Dr["stateName"].ToString();
                    objprp.district = ADOprpDL.Dr["distName"].ToString();
                    #endregion
                    lst.Add(objprp);
                }
            }
            else
            {
                objprp = new PRPSetupUniversity();
                objprp.srNo = "Result Not Find";
                lst.Add(objprp);
            }
            return lst;

        }
        //--End University Type
    }
    
    
}