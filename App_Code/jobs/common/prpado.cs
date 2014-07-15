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
namespace nmsADOjob
{
    public class clsprpADO
    {
        private SqlCommand _Cmd;
        private SqlDataReader _Dr;
        private string _RetrunMsg;
        private string _ScalarValue;
        private SqlConnection _Con;

        public SqlConnection Con
        {
            get
            {
                return _Con;
            }
            set
            {
                _Con = value; //new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
            }
        }
        

        public SqlCommand Cmd
        {
            get
            {
                return _Cmd;
            }
            set
            {
                _Cmd =value ;
            }

        }
        public string ReturnMsg
        {
            get
            {
                return _RetrunMsg;
            }
            set
            {
                _RetrunMsg = value;
            }


        }
        public string ScalarValue
        {
            get
            {

                return _ScalarValue;
            }
            set
            {
                _ScalarValue = value;
            }
        }
        public SqlDataReader Dr
        {
            get
            {
                return _Dr;
            }
            set
            {
                _Dr = value;

            }
        }

    }
}

