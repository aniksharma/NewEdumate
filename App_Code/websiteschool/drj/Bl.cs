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
namespace SchoolInFormation
{
    public class clsBl
    {
        clsprop prop;
        clsDl objdl;
        public string BlMainLineInsert(clsprop prop)
        {
            objdl = new clsDl();
            return objdl.DlMainLineInsert(prop);

        }
        public string BlMainLineUpdate(clsprop prop)
        {
            objdl = new clsDl();
            return objdl.DlMainLineUpdate(prop);
        }
        public string BlMainLineDelete(clsprop prop)
        {
            objdl = new clsDl();
            return objdl.DlMainLineDelete(prop);
        }
        public DataTable BlMainLineAll()
        {
            objdl = new clsDl();
            return objdl.DlMainLineAll();
        }
        public clsprop BlMainLineSelectbyId(clsprop prop)
        {
            objdl = new clsDl();
            return objdl.DlMainLineById(prop);
        }


        public string BlContentInsert(clsprop prop)
        {
            objdl = new clsDl();
            return objdl.DlContentInsert(prop);

        }
        public string BlContentUpdate(clsprop prop)
        {
            objdl = new clsDl();
            return objdl.DlContentUpdate(prop);
        }
        public string BlContentDelete(clsprop prop)
        {
            objdl = new clsDl();
            return objdl.DlContentDelete(prop);
        }
        public DataTable BlContentAll()
        {
            objdl = new clsDl();
            return objdl.DlContentAll();
        }
        public clsprop BlContentbyId(clsprop prop)
        {
            objdl = new clsDl();
            return objdl.DlContentById(prop);
        }


        public string BlImageGallaryInsert(clsprop prop)
        {
            objdl = new clsDl();
            return objdl.DlImageGallaryInsert(prop);

        }
        public string BlImageGallaryUpdate(clsprop prop)
        {
            objdl = new clsDl();
            return objdl.DlImageGallaryUpdate(prop);
        }
        public string BlImageGallaryDelete(clsprop prop)
        {
            objdl = new clsDl();
            return objdl.DlImageGallaryDelete(prop);
        }
        public DataTable BlImageGallaryAll()
        {
            objdl = new clsDl();
            return objdl.DlImageGallaryAll();
        }
        public clsprop BlImageGallarybyId(clsprop prop)
        {
            objdl = new clsDl();
            return objdl.DlImageGallaryById(prop);
        }

        public DataTable DlMainLineByType(clsprop prop)
        {
            objdl = new clsDl();
            return objdl.DlMainLineByType(prop);
      
        }


        public DataSet DlMainLineByTypeAll(clsprop prp)
        {
            objdl = new clsDl();
            return objdl.DlMainLineByTypeAll(prp);

        }



    }
}
