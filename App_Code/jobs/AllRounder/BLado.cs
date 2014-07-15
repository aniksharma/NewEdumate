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
    public class clsBLado
    {
        clsPRPadoDL obj = new clsPRPadoDL();
        clsDLado objAdo = new clsDLado(); 
        //------------------NON Query Work ---------------------------------------------//
        public string NonQueryWithQuery(clsPRPadoBL objprp)
        {
            ExcuteQuery(objprp);
            objAdo.NonQuery(obj);
            return obj.ReturnMsg;
            
        }
        public string NonQueryWithQueryandParam(clsPRPadoBL objprp)
        {
            ExcuteQueryWithParam(objprp);
            objAdo.NonQuery(obj);
            return obj.ReturnMsg;
        }
        public string NonQueryWithProcedures(clsPRPadoBL objprp)
        {
            ExcuteProcedures(objprp);
            objAdo.NonQuery(obj);
            return obj.ReturnMsg;    

        }
        public string NonQueryWithProceduresandParam(clsPRPadoBL objprp)
        {
            ExcuteProceduresWithParam(objprp);
            objAdo.NonQuery(obj);
                return obj.ReturnMsg;
        
        }
        //------------------END NON Query Work ---------------------------------------------//


        //------------------Scalar Value Work ---------------------------------------------//
        public string ScalarQueryWithQuery(clsPRPadoBL objprp)
        {
            ExcuteQuery(objprp);
            objAdo.ScalarQuery(obj);
            if (obj.ReturnMsg == "success")
            {
                return obj.ScalarValue;
            }
            else
            {
                return obj.ReturnMsg;
            }  


        }
        public string ScalarQueryWithQueryandParam(clsPRPadoBL objprp)
        {
            ExcuteQueryWithParam(objprp);
            objAdo.ScalarQuery(obj);
            if (obj.ReturnMsg == "success")
            {
                return obj.ScalarValue;
            }
            else
            {
                return obj.ReturnMsg;
            }  
          
        }
        public string ScalarQueryWithProcedures(clsPRPadoBL objprp)
        {
            ExcuteProcedures(objprp);
            objAdo.ScalarQuery(obj);
            if (obj.ReturnMsg == "success")
            {
                return obj.ScalarValue;
            }
            else
            {
                return obj.ReturnMsg;
            }  
        }
        public string ScalarQueryWithProceduresandParam(clsPRPadoBL objprp)
        {
            ExcuteProceduresWithParam(objprp);
            objAdo.ScalarQuery(obj);
            if (obj.ReturnMsg == "success")
            {
                return obj.ScalarValue;
            }
            else
            {
                return obj.ReturnMsg;
            }  
        }
        //------------------END Saclar Value Work ---------------------------------------------//

        //------------------Reader Value Work ---------------------------------------------//
        public void ReaderWithQuery(clsPRPadoDL objprp)
        {
            ExcuteQuery(objprp);
            objAdo.ReaderQuery(obj);
            objprp.Dr = obj.Dr;
         //   objAdo.ReaderClose(obj);
            objprp.Message = obj.ReturnMsg;
          
        }
        public void ReaderWithQueryandParam(clsPRPadoDL objprp)
        {
            ExcuteQueryWithParam(objprp);
            objAdo.ReaderQuery(obj);
            objprp.Dr = obj.Dr;
        //    objAdo.ReaderClose(obj);
            objprp.Message = obj.ReturnMsg;
          
        }
        public void ReaderWithProcedures(clsPRPadoDL objprp)
        {
            ExcuteProcedures(objprp);
            objAdo.ReaderQuery(obj);
            objprp.Dr = obj.Dr;
           // objAdo.ReaderClose(obj);
            objprp.Message = obj.ReturnMsg;
          
        }
        public void ReaderWithProceduresandParam(clsPRPadoDL objprp)
        {
            ExcuteProceduresWithParam(objprp);
            objAdo.ReaderQuery(obj);
            objprp.Dr = obj.Dr;
           // objAdo.ReaderClose(obj);
            objprp.Message = obj.ReturnMsg;
          
        }
        //------------------END Reader Value Work ---------------------------------------------//



        //------------------DataSet Value Work ---------------------------------------------//
        public DataSet DataSetWithQuery(clsPRPadoBL objprp)
        {
            ExcuteQuery(objprp);
            objAdo.DataSetQuery(obj);
             return obj.Ds;
          

        }
        public DataSet DataSetWithQueryandParam(clsPRPadoBL objprp)
        {
            ExcuteQueryWithParam(objprp);
            objAdo.DataSetQuery(obj);
            return obj.Ds;
                
        }
        public DataSet DataSetWithProcedures(clsPRPadoBL objprp)
        {
            ExcuteProcedures(objprp);
            objAdo.DataSetQuery(obj);
            return obj.Ds;
          

        }
        public DataSet DataSetWithProceduresandParam(clsPRPadoBL objprp)
        {
            ExcuteProceduresWithParam(objprp);
            objAdo.DataSetQuery(obj);
            return obj.Ds;
           

        }
        //------------------END DataSet Value Work ---------------------------------------------//


        //------------------DataTable Value Work ---------------------------------------------//
        public DataTable DataTableWithQuery(clsPRPadoBL objprp)
        {
            ExcuteQuery(objprp);
            objAdo.DataTableQuery(obj);
            return obj.Dtable;
            

        }
        public DataTable DataTableWithQueryandParam(clsPRPadoBL objprp)
        {
            ExcuteQueryWithParam(objprp);
            objAdo.DataTableQuery(obj);
            return obj.Dtable;
            
        }
        public DataTable DataTableWithProcedures(clsPRPadoBL objprp)
        {
            ExcuteProcedures(objprp);
            objAdo.DataTableQuery(obj);
            return obj.Dtable;
            
        }
        public DataTable DataTableWithProceduresAndParam(clsPRPadoBL objprp)
        {
            ExcuteProceduresWithParam(objprp);
            objAdo.DataTableQuery(obj);
            return obj.Dtable;
            

        }

        //------------------END DataTable Value Work ---------------------------------------------//

        //------------------Common Values Setting ---------------------------------------------//

        private void ExcuteQuery(clsPRPadoBL objprp)
        {
            obj.Cmd = new SqlCommand();
            obj.ArrayPram = new SqlParameter[0];
            obj.Cmd.CommandText = objprp.Query;
            obj.Cmd.CommandType = CommandType.Text; 

        }
        private void ExcuteQueryWithParam(clsPRPadoBL objprp)
        {
            obj.Cmd = new SqlCommand();
            obj.ArrayPram = new SqlParameter[objprp.ArrayPram.Length];
            obj.ArrayPram = objprp.ArrayPram;
            obj.Cmd.CommandText = objprp.Query;
            obj.Cmd.CommandType = CommandType.Text;

        }
        private void ExcuteProcedures(clsPRPadoBL objprp)
        {
            obj.Cmd = new SqlCommand();
            obj.ArrayPram = new SqlParameter[0]; 
            obj.Cmd.CommandText = objprp.SPName;
            obj.Cmd.CommandType = CommandType.StoredProcedure; 


        }
        private void ExcuteProceduresWithParam(clsPRPadoBL objprp)
        {
            obj.Cmd = new SqlCommand();
            obj.ArrayPram = new SqlParameter[objprp.ArrayPram.Length];
            obj.ArrayPram = objprp.ArrayPram;
            obj.Cmd.CommandText = objprp.SPName;
            obj.Cmd.CommandType = CommandType.StoredProcedure;


        }

        //------------------End Comman Valeus Setting ---------------------------------------------//
        //------------------Common Values Setting ---------------------------------------------//
     
   
        private void ExcuteQuery(clsPRPadoDL objprp)
        {
            obj.Cmd = new SqlCommand();
            obj.ArrayPram = new SqlParameter[0];
            obj.Cmd.CommandText = objprp.Query;
            obj.Cmd.CommandType = CommandType.Text; 

        }
        private void ExcuteQueryWithParam(clsPRPadoDL objprp)
        {
            obj.Cmd = new SqlCommand();
            obj.ArrayPram = new SqlParameter[objprp.ArrayPram.Length];
            obj.ArrayPram = objprp.ArrayPram;
            obj.Cmd.CommandText = objprp.Query;
            obj.Cmd.CommandType = CommandType.Text;

        }
        private void ExcuteProcedures(clsPRPadoDL objprp)
        {
            obj.Cmd = new SqlCommand();
            obj.ArrayPram = new SqlParameter[0]; 
            obj.Cmd.CommandText = objprp.SPName;
            obj.Cmd.CommandType = CommandType.StoredProcedure; 


        }
        private void ExcuteProceduresWithParam(clsPRPadoDL objprp)
        {
            obj.Cmd = new SqlCommand();
            obj.ArrayPram = new SqlParameter[objprp.ArrayPram.Length];
            obj.ArrayPram = objprp.ArrayPram;
            obj.Cmd.CommandText = objprp.SPName;
            obj.Cmd.CommandType = CommandType.StoredProcedure;


        }

        //------------------End Comman Valeus Setting ---------------------------------------------//

        public void ReaderClose(clsPRPadoDL obj)
        {
           // obj.Cmd.Dispose();
       
            obj.Dr.Close();
            obj.Con.Close();
        }


    }


}

