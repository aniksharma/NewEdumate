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
using System.Collections.Generic;
namespace hr
{
    public class clsBLhr
    {
        clsprophr prop;
        clsDLhr objdl;
        public string InsRequirment(clsprophr prop)
        {
            objdl = new clsDLhr();
            return objdl.InsRequirment(prop);
        }
        public string InsEmployeeProfile(clsprophr prop)
        {
            objdl = new clsDLhr();
            return objdl.InsEmployeeProfile(prop);
        }
        public DataTable BindType(clsprophr prop)
        {
            objdl = new clsDLhr();
            return objdl.BindType(prop);
        }
        public string InsSalaryReceive(clsprophr prop)
        {
            objdl = new clsDLhr();
            return objdl.InsSalaryReceive(prop);
        }
        public string getmaxid()
        {
            objdl = new clsDLhr();
            return objdl.getmaxid();
        }
        //WorkManagement
        public string InsDailyReport(clsprophr prop)
        {
            objdl = new clsDLhr();
            return objdl.InsDailyReport(prop);
        }
        public string UpdDailyReport(clsprophr prop)
        {
            objdl = new clsDLhr();
            return objdl.UpdDailyReport(prop);
        }
        public DataTable viewEmployeeDailyReport(clsprophr prop)
        {
            objdl = new clsDLhr();
            return objdl.viewEmployeeDailyReport(prop);
        }
        public clsprophr viewEmployeeDailyReportById(clsprophr prop)
        {
            objdl = new clsDLhr();
            return objdl.viewEmployeeDailyReportById(prop);
        }
        public DataTable ViewReportBySr(clsprophr prop)
        {
            objdl = new clsDLhr();
            return objdl.ViewReportBySr(prop);
        }
        public string InsSrReportToJunier(clsprophr prop)
        {
            objdl = new clsDLhr();
            return objdl.InsSrReportToJunier(prop);
        }
        //Liabarary
        public string InsLiabararyBookDetail(clsprophr prop)
        {
            objdl = new clsDLhr();
            return objdl.InsLiabararyBookDetail(prop);
        }
        public List<clsprophr> viewLiabararyBookDetail(clsprophr prop)
        {
            objdl = new clsDLhr();
            return objdl.viewLiabararyBookDetail(prop);
        }
        public clsprophr viewLiabararyBookDetailById(clsprophr prop)
        {
            objdl = new clsDLhr();
            return objdl.viewLiabararyBookDetailById(prop);
        }
        public string UpdLiabararyBookDetail(clsprophr prop)
        {
            objdl = new clsDLhr();
            return objdl.UpdLiabararyBookDetail(prop);
        }

        public string InsKidsProfile(clsprophr prop)
        {
            objdl = new clsDLhr();
            return objdl.InsKidsProfile(prop);
        }

        public string InsTutorProfile(clsprophr prop)
        {
            objdl = new clsDLhr();
            return objdl.InsTutorProfile(prop);
        }
        public string UpTutorProfile(clsprophr prop)
        {
            objdl = new clsDLhr();
            return objdl.UpTutorProfile(prop);
        }
        public string InsTutorProfilesaliman(clsprophr prop)
        {
            objdl = new clsDLhr();
            return objdl.InsTutorProfilesaliman(prop);
        }
        public clsprophr viewKidsProfileprById(clsprophr prop)
        {
            objdl = new clsDLhr();
            return objdl.viewKidsProfileprById(prop);
        }
        public string UpdKidsProfile(clsprophr prop)
        {
            objdl = new clsDLhr();
            return objdl.UpdKidsProfile(prop);
        }

       

       
    }
}
