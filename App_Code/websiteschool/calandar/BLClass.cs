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

namespace Calander
{
    public class clsBL
    {
        clsprop prop;
        clsDL objdl;
        public string InsertEvent(clsprop prop)
        {
            objdl = new clsDL();
            return objdl.InsertEvent(prop);
        }
        public DataTable BindType()
        {
            objdl = new clsDL();
            return objdl.BindType();
        }
        public DataTable viewEvent(clsprop prop)
        {
            objdl = new clsDL();
            return objdl.viewEvent(prop);
        }
    }
}
