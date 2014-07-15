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
using nmsView;
using nmsProfile;
namespace nmsView
{
    public class clsBLview
    {
        clsDLView obj = new clsDLView();

        //public List<clsPRPprofileAdvance> BasicProfileByMemId(clsPRPParm objprp)
        //{
        //    return obj.BasicProfileByAdmin(objprp);


        //}        
        public List<clsPRPView> ViewDwonlineByMemid(clsPRPParm objprp)
        {
            return obj.ViewDwonlineByMemid(objprp);
            

        }
        public List<clsPRPView> ViewRewards()
        {
            return obj.ViewRewards();


        }
        public List<clsPRPView> ViewPayout(clsPRPParm objprp)
        {
            return obj.ViewPayout(objprp);


        }
        public string GetMaxFileId( clsPRPParm objprp)
        {
            return obj.GetMaxFileId(objprp);
        }
        public List<clsPRPView> universityName()
        {
            return obj.uniuversityName();
        }
        public string SelUniLogo(clsPRPParm objprp)
        {
            return obj.SelUniLogo(objprp);
        }
        public List<clsPRPView> CourseCategory(clsPRPParm objprp)
        {
            return obj.CourseCategory(objprp);
        }
        public List<clsPRPView> DownloadLink(clsPRPParm objprp)
        {
            return obj.DownloadLink(objprp);
        }
        public string viewVisitorCounter()
        {
            return obj.viewVisitorCounter();
        }       
    }

}
