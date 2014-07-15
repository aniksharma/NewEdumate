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
namespace nmsDropDownI
{
    public class clsPRPdropdown
    {
        private string _name,_spName,_stringId;
        private Int32 _id;
        private ListControl _controlList, _controlList2;
        public string Type;
        
        
        public string name { get { return _name; } set { _name = value; } }
        public Int32 id { get { return _id; } set { _id = value; } }
        public string spName { get { return _spName; } set { _spName = value; } }
        public string stringId { get { return _stringId; } set { _stringId = value; } }

        public ListControl controlList { get { return _controlList; } set { _controlList = value; } }


        public ListControl controlList2 { get { return _controlList2; } set { _controlList2 = value; } }


        
   
    }
    
}