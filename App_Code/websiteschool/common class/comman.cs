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
 namespace nms_commonI
{


    public abstract class cls_con 
    {
       
      public   SqlConnection con;
        public cls_con()
        {
             con = new SqlConnection( ConfigurationManager.ConnectionStrings["cn1"].ConnectionString  );
        }


     
    }
}
