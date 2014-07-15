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
using System.Collections.Generic;
using nmsADO;
using nmsLogin;
//using nmsProfile;

namespace nmsLogin
{
    public class clsDLlogin
    {
        clsprpADO objadoprp = new clsprpADO();
        clsADO objado = new clsADO();





        public string checkLogin(clsPRPLogin objprp)
        {
            objadoprp.Cmd = new SqlCommand();
            objadoprp.Cmd.CommandText = "spCheckLoginAdmin";
            objadoprp.Cmd.Parameters.AddWithValue("@LoginName", objprp.LoginName);
            objadoprp.Cmd.Parameters.AddWithValue("@password", objprp.password);
            objadoprp.Cmd.Parameters.AddWithValue("@IPaddress",objprp.LastLoginIP); 


            objado.ScalarQuery(objadoprp);

            if (objadoprp.ReturnMsg == "success")
            {
                return objadoprp.ScalarValue;
            }
            else
            {
                return objadoprp.ReturnMsg;


            }

        }
        
    }


}