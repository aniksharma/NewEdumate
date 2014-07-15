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
using nmsSetupUniversity;
namespace nmsSetupUniversity
{
    public class clsBLUniversity
    {
        clsDLUniversity obj = new clsDLUniversity();
        //--start university.

        //--Start UniversityType
        public string InsUniversityType(PRPSetupUniversity objprp)
        {
            return obj.InsUniversityType(objprp);
        }
        public string UpdUniversityType(PRPSetupUniversity objprp)
        {
            return obj.UpdUniversityType(objprp);
        }
        public string DelUniversityType(PRPSetupUniversity objprp)
        {
            return obj.DelUniversityType(objprp);
        }
        public PRPSetupUniversity SelUniversityType(PRPSetupUniversity objprp)
        {
            return obj.SelUniversityType(objprp);
        }

        public List<PRPSetupUniversity> viewUniversityType(PRPSetupUniversity objprp)
        {
            return obj.viewUniversityType(objprp);
        }
        //--End UniversityType
   
    }
      
}
