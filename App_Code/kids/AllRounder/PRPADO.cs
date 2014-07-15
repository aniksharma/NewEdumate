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


namespace nmsADOkids
{
    public class clsPRPadoBL
    {
        private SqlParameter[] _ArrayPram;
        private SqlDataReader _Dr;
        private DataSet _Ds;
        private DataTable _Dtable;

        private string _Message,_Query,_SPName,_ScalarValue;
        
        public string Query
        {
            get
            {

                return _Query;
            }
            set
            {
                _Query = value;
            }
        }
        public string SPName
        {
            get
            {

                return _SPName;
            }
            set
            {
                _SPName = value;
            }
        }
        public string Message
        {
            get
            {

                return _Message;
            }
            set
            {
                _Message = value;
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
 
        public SqlParameter[] ArrayPram
        {
            get
            {
                return _ArrayPram;
            }
            set
            {
                _ArrayPram = value;

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
        public DataSet Ds
        {
            get
            {
                return _Ds;
            }
            set
            {
                _Ds = value;

            }
        }
        public DataTable Dtable
        {
            get
            {
                return _Dtable;
            }
            set
            {
                _Dtable = value;

            }
        }

    }

    public class clsPRPadoDL:clsPRPadoBL
    {
        private SqlConnection _Con = new SqlConnection(ConfigurationManager.ConnectionStrings["cnkids"].ConnectionString);
        private SqlCommand _Cmd;
        private SqlDataAdapter _Adp; 
        private string _RetrunMsg,_CommandType;
        
        public SqlConnection Con
        {
            get
            {
                return _Con;
            }

            //set
            //{
            //    _Con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
            //}
        
        }
        public SqlCommand Cmd
        {
            get
            {
                return _Cmd;
            }
            set
            {
                _Cmd = value;
            }

        }

        public SqlDataAdapter Adp
        {
            get
            {
                return _Adp;
            }
            set
            {
                _Adp = value;
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
        public string CommandType
        {
            get
            {

                return _CommandType;
            }
            set
            {
                _CommandType = value;
            }
        }
        

    }

}