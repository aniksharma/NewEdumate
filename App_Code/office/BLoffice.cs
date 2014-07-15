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
using nmsProfile;
using nmsJoining;
namespace nmsOffice
{
    public class BLoffice
    {
        DLoffice obj = new DLoffice();


//---Start Designation.

        public string spOpenPayment(PRPOffice objprp)
        {
            return obj.spOpenPayment(objprp);
        }


        public string InsertDesignation(PRPOffice objprp)
        {
            return obj.InsertDesignation(objprp);
        }

        public string UpdateDesignation(PRPOffice objprp)
        {
            return obj.UpdateDesignation(objprp);
        }
        public string DeleteDesignation(PRPOffice objprp)
        {
            return obj.DeleteDesignation(objprp);
        }
        public DataTable SelectDesignation(PRPOffice objprp)
        {
            return obj.SelectDesignation(objprp);

        }
        public DataTable ViewDesignation()
        {
            return obj.ViewDesignation();

        }
//---End Designation.
        
        //--------start------branch---------------------------------
        public string InsertBranch(PRPOffice objprp)
        {
            return obj.InsertBranch(objprp);
        }
        public string UpdateBranch(PRPOffice objprp)
        {
            return obj.UpdateBranch(objprp);
        }
        public string DeleteBranch(PRPOffice objprp)
        {
            return obj.DeleteBranch(objprp);
        }
        public PRPOffice SelectBranch(PRPOffice objprp)
        {
            return obj.SelectBranch(objprp);
        }
        public List<PRPOffice> ViewBranch(PRPOffice objprp)
        {
            return obj.ViewBranch(objprp);
        }

        public string ConfirmBranch(PRPOffice objprp)
        {
            return obj.ConfirmBranch(objprp);
        }

       //--------end------branch-----------------------------------



        //--------start------employee----------------------------
        public List<PRPOffice> InsertEmployee(PRPOffice objprp)
        {
            return obj.InsertEmployee(objprp);
        }
        public string UpdateEmployee(PRPOffice objprp)
        {
            return obj.UpdateEmployee(objprp);
        }        
        public PRPOffice SelectEmployee(PRPOffice objprp)
        {
            return obj.SelectEmployee(objprp);
        }
        public List<PRPOffice> ViewEmployee(PRPOffice objprp)
        {
            return obj.ViewEmployee(objprp);
        }

        public string deleteEmployee(PRPOffice objprp)
        {
            return obj.deleteEmployee(objprp);
        }   

        public List<PRPOffice> PrentLinks()
        {
            return obj.PrentLinks();
        }     
        public List<PRPOffice> EmployeePermission(PRPOffice prp)
        {
            return obj.EmployeePermission(prp);
        }
        public string InsertPermission(PRPOffice objprp)
        {
            return obj.InsertPermission(objprp);
        }
        public List<PRPOffice> EmployeeAuthority(PRPOffice prp)
        {
            return obj.EmployeeAuthority(prp);
        }        
        public string InsertAuthority(PRPOffice objprp)
        {
            return obj.InsertAuthority(objprp);
        }
        public List<PRPOffice> EmployeeMenu(PRPOffice prp)
        {
            return obj.EmployeeMenu(prp);
        }
        public List<PRPOffice> EmployeeMenubyUrlID(PRPOffice prp)
        {
            return obj.EmployeeMenubyUrlID(prp);
        }
        public List<PRPOffice> MainMenu(PRPOffice prp)
        {
            return obj.MainMenu(prp);
        }
        public List<PRPOffice> BindMenuNode(PRPOffice prp)
        {
            return obj.BindMenuNode(prp);
        }
        public DataTable BindMainNodeById(PRPOffice objprp)
        {
            return obj.BindMainNodeById(objprp);

        }

        //-------Collage Profile

        public string InsertCollage(PRPOffice objprp)
        {
            return obj.InsertCollage(objprp);
        }
        public string UpdateCollage(PRPOffice objprp)
        {
            return obj.UpdateCollage(objprp);
        }
        public PRPOffice ShowProfile(PRPOffice objprp)
        {
            return obj.ShowProfile(objprp);
        }
        public string updateLogoImage(PRPOffice objprp)
        {
            return obj.updateLogoImage(objprp);
        }
        //------Collage Profile

        public string UpStudentLogo(PRPOffice objprp)
        {
            return obj.UpStudentLogo(objprp);
        }
//Center Detail.
        public PRPOffice ViewCenterProfile(PRPOffice objprp)
        {
            return obj.ViewCenterProfile(objprp);
        }

        public String updateCenterProfile(PRPOffice objprp)
        {
            return obj.updateCenterProfile(objprp);
        }

        //public List<prpUrl> BindMenuNodeALL(PRPOffice prp)
        //{
        //    return obj.BindMenuNodeALL(prp);
        //}       

 //--Start Payment----------
        public string InsertPayment( PRPprofile objprp)
        {
            return obj.InsertPayment(objprp);

        }
        public List<PRPprofile> ViewPayment()
        {
            return obj.ViewPayment();
        }
        public List<PRPprofile> ViewPaidPayment()
        {
            return obj.ViewPaidPayment();
        }
        public string ConfirmPayment(PRPOffice objprp)
        {
            return obj.ConfirmPayment(objprp);

        }
//--End Payment
    }
}

