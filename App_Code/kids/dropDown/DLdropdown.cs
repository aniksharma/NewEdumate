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
using nmsADOkids;
using nmsDropDownKIDS;
namespace nmsDropDownKIDS
{
    public class clsDLdropDown
    {
        clsprpADO objadoprp = new clsprpADO();
        clsADO objado = new clsADO();

        public List<clsPRPdropdown> SelectDropDown( clsPRPdropdown objsp)
        {
            objadoprp.Cmd = new SqlCommand();
            objadoprp.Cmd.CommandText = objsp.spName;
            if (objsp.id != 0)
                objadoprp.Cmd.Parameters.AddWithValue("@id", objsp.id);
            objado.ReaderQuery(objadoprp);

            List<clsPRPdropdown> list = new List<clsPRPdropdown>();
            clsPRPdropdown obj = new clsPRPdropdown();
            obj.id = 0;
            obj.name = "--Select--";
            list.Add(obj);

            if (objadoprp.ReturnMsg == "success")
            {
                if (objadoprp.Dr.HasRows)
                {
                    while (objadoprp.Dr.Read())
                    {
                        obj = new clsPRPdropdown();

                        obj.id = Convert.ToInt32(objadoprp.Dr[0]);
                        obj.name = objadoprp.Dr[1].ToString();
                        list.Add(obj);

                    }

                }

            }

            objado.ReaderClose(objadoprp);

            return list;

        }

        public List<clsPRPdropdown> SelectDropDownII(clsPRPdropdown objsp)
        {
            objadoprp.Cmd = new SqlCommand();
            objadoprp.Cmd.CommandText = objsp.spName;
            if (objsp.id != 0)
                objadoprp.Cmd.Parameters.AddWithValue("@id", objsp.id);
            objado.ReaderQuery(objadoprp);

            List<clsPRPdropdown> list = new List<clsPRPdropdown>();
            clsPRPdropdown obj = new clsPRPdropdown();
            obj.stringId = "0";
            obj.name = "--Select--";
            list.Add(obj);

            if (objadoprp.ReturnMsg == "success")
            {
                if (objadoprp.Dr.HasRows)
                {
                    while (objadoprp.Dr.Read())
                    {
                        obj = new clsPRPdropdown();

                        obj.stringId =objadoprp.Dr[0].ToString();
                        obj.name = objadoprp.Dr[1].ToString();
                        list.Add(obj);

                    }

                }

            }

            objado.ReaderClose(objadoprp);

            return list;

        }


        public List<clsPRPdropdown> SelectControlList(clsPRPdropdown objsp)
        {
            objadoprp.Cmd = new SqlCommand();
            objadoprp.Cmd.CommandText = objsp.spName;
            if (objsp.id != 0)
                objadoprp.Cmd.Parameters.AddWithValue("@id", objsp.id);
            objado.ReaderQuery(objadoprp);

            List<clsPRPdropdown> list = new List<clsPRPdropdown>();
            clsPRPdropdown obj = new clsPRPdropdown();
           // obj.id = 0;
            //obj.name = "--Select--";
           // list.Add(obj);

            if (objadoprp.ReturnMsg == "success")
            {
                if (objadoprp.Dr.HasRows)
                {
                    while (objadoprp.Dr.Read())
                    {
                        obj = new clsPRPdropdown();

                        obj.id = Convert.ToInt32(objadoprp.Dr[0]);
                        obj.name = objadoprp.Dr[1].ToString();
                        list.Add(obj);

                    }

                }

            }

            objado.ReaderClose(objadoprp);

            return list;

        }


        public List<clsPRPdropdown> SelectControlListII(clsPRPdropdown objsp)
        {
            objadoprp.Cmd = new SqlCommand();
            objadoprp.Cmd.CommandText = objsp.spName;
            if (objsp.id != 0)
                objadoprp.Cmd.Parameters.AddWithValue("@id", objsp.id);
            objado.ReaderQuery(objadoprp);

            List<clsPRPdropdown> list = new List<clsPRPdropdown>();
            clsPRPdropdown obj = new clsPRPdropdown();
            // obj.id = 0;
            //obj.name = "--Select--";
            // list.Add(obj);

            if (objadoprp.ReturnMsg == "success")
            {
                if (objadoprp.Dr.HasRows)
                {
                    while (objadoprp.Dr.Read())
                    {
                        obj = new clsPRPdropdown();

                        obj.stringId =objadoprp.Dr[0].ToString();
                        obj.name = objadoprp.Dr[1].ToString();
                        list.Add(obj);

                    }

                }

            }

            objado.ReaderClose(objadoprp);

            return list;

        }
    
        


        public List<clsPRPdropdown> SelectList(clsPRPdropdown objsp)
        {
            objadoprp.Cmd = new SqlCommand();
            objadoprp.Cmd.CommandText = objsp.spName;
            if (objsp.id != 0)
                objadoprp.Cmd.Parameters.AddWithValue("@memberId", objsp.id);
            objado.ReaderQuery(objadoprp);

            List<clsPRPdropdown> list = new List<clsPRPdropdown>();
            clsPRPdropdown obj;
            //= new clsPRPdropdown();
            //obj.id = 0;
            //obj.name = "--Select--";
            //list.Add(obj);

            if (objadoprp.ReturnMsg == "success")
            {
                if (objadoprp.Dr.HasRows)
                {
                    while (objadoprp.Dr.Read())
                    {
                        obj = new clsPRPdropdown();

                        obj.id = Convert.ToInt32(objadoprp.Dr[0]);
                        obj.name = objadoprp.Dr[1].ToString();
                        list.Add(obj);

                    }

                }

            }

            objado.ReaderClose(objadoprp);

            return list;

        }

       
    }
}