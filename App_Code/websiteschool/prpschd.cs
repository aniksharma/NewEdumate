using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using nmsADO;
using System.Data.SqlClient;
using System.Data;
namespace nmsShd
{
    public class PrpSchd
    {

    public string    shdId {get;set;}
   public string shdMemId {get;set;}
   public string shdPeriod {get;set;}
   public string shdStartTime {get;set;}
   public string shdEndTime {get;set;}
   public string shdNote {get;set;}
   public string shdSunday {get;set;}
   public string shdMonday {get;set;}
   public string shdTuesday {get;set;}
   public string shdWednesday {get;set;}
   public string shdThursday  {get;set;}
   public string shdFriday  {get;set;}
   public string shdSaturday   {get;set;}
    }


    public class DLSchd
    {
        clsprpADO objadoprp = new clsprpADO();
        clsADO objado = new clsADO();
        clsPRPadoBL adoBL;
        clsBLado ADO;

        public DataTable spScheduleSelect(PrpSchd objprp)
        {
            adoBL = new clsPRPadoBL();
            ADO = new clsBLado();
            adoBL.ArrayPram = new SqlParameter[1];

            adoBL.ArrayPram[0] = new SqlParameter("@accid", objprp.shdMemId);
            adoBL.SPName = "spScheduleSelect";

            return ADO.DataTableWithProceduresAndParam(adoBL);

        }



    }
}