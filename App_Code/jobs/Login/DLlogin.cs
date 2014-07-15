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
using nmsADOjob;
using nmsLoginJob;
//using nmsProfile;

namespace nmsLoginJob
{
    public class clsDLlogin
    {
        clsprpADO objadoprp = new clsprpADO();
        clsADO objado = new clsADO();
        clsPRPadoBL adoBL;
        clsBLado ADO;

        public string UpdatePassword(clsPRPLogin objprp)
        {
             adoBL   = new clsPRPadoBL();
              ADO = new clsBLado();
            adoBL.ArrayPram = new SqlParameter[3];

            adoBL.ArrayPram[0] = new SqlParameter("@loginUserId", objprp.UserName);
            adoBL.ArrayPram[1] = new SqlParameter("@loginPassword", objprp.password);
            adoBL.ArrayPram[2] = new SqlParameter("@oldpassword", objprp.oldPassword);



            adoBL.SPName = "spUpdatePassword";

            return ADO.ScalarQueryWithProceduresandParam(adoBL);

        }


      

        public string checkLogin(clsPRPLogin objprp)
        {
            objadoprp.Cmd = new SqlCommand();
            objadoprp.Cmd.CommandText = "spCheckLogin";
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




        public string CheckLoginUser(clsPRPLogin objprp)
        {
            objadoprp.Cmd = new SqlCommand();
            objadoprp.Cmd.CommandText = "spCheckLoginUser";
            objadoprp.Cmd.Parameters.AddWithValue("@LoginName", objprp.LoginName);
            objadoprp.Cmd.Parameters.AddWithValue("@password", objprp.password);
            objadoprp.Cmd.Parameters.AddWithValue("@IPaddress", objprp.LastLoginIP);


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


        public string spInsertForgetPassword(clsPRPLogin objprp)
        {
            objadoprp.Cmd = new SqlCommand();
            objadoprp.Cmd.CommandText = "spInsertForgetPassword";
            objadoprp.Cmd.Parameters.AddWithValue("@userName", objprp.UserName);
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


        public string spResetPassword(clsPRPLogin objprp)
        {
            objadoprp.Cmd = new SqlCommand();
            objadoprp.Cmd.CommandText = "spResetPassword";
            //objadoprp.Cmd.Parameters.AddWithValue("@userName", objprp.memberID);
            objadoprp.Cmd.Parameters.AddWithValue("@forgetPasswordCode", objprp.oldPassword);
            objadoprp.Cmd.Parameters.AddWithValue("@newPassword", objprp.password);
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


        public string spResetPasswordNew(clsPRPLogin objprp)
        {
            objadoprp.Cmd = new SqlCommand();
            objadoprp.Cmd.CommandText = "spResetPasswordNew";
            //objadoprp.Cmd.Parameters.AddWithValue("@userName", objprp.memberID);
            objadoprp.Cmd.Parameters.AddWithValue("@forgetPasswordCode", objprp.oldPassword);
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


        public string spResetPasswordNewKIDS(clsPRPLogin objprp)
        {
            objadoprp.Cmd = new SqlCommand();
            objadoprp.Cmd.CommandText = "spResetPasswordNewKIDS";
            //objadoprp.Cmd.Parameters.AddWithValue("@userName", objprp.memberID);
            objadoprp.Cmd.Parameters.AddWithValue("@forgetPasswordCode", objprp.oldPassword);
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