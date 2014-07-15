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
using BusEntry;
namespace BusEntry 
{
    public class Clas1
    {
        DL1 call = new DL1();
        prp prop = new prp();
        public string Insert(prp pr)
        {
            return call.Insert(pr);
        }
        public DataSet ShowData(prp pr)
        {
            return call.ShowData(pr);
        }
        public string Delete(prp pr)
        {
            return call.Delete(pr);
        }
        public prp Select(prp pr)
        {
            return call.Select(pr);
        }
        public string Update(prp pr)
        {
            return call.Update(pr);
        }
        public string RouteInsert(prp pr)
        {
            return call.RouteInsert(pr);
        }
        public DataSet RouteShowData(prp prp)
        {
            return call.RouteShowData( prp);
        }
        public string DeleteRoute(prp pr)
        {
            return call.DeleteRoute(pr);
        }
        public prp RouteSelect(prp pr)
        {
            return call.SelectRoute(pr);
        }
        public string RoutepUpdate(prp pr)
        {
            return call.UpdateRoute(pr);
        }
        public string StopesInsert(prp pr)
        {
            return call.StopsInsert(pr);
        }
        public DataSet StopesShowData( prp prp)
        {
            return call.StopesShowData(prp);
        }
        public DataSet DropListBoundData(prp prp)
        {
            return call.DropListBoundData( prp);
        }
        public string DeleteStopes(prp pr)
        {
            return call.DeleteStopes(pr);
        }
        public prp SelectStopes(prp pr)
        {
            return call.selectStopes(pr);
        }
        public string updatestopes(prp pr)
        {
            return call.updatestopes(pr);
        }
        public DataSet BusRouteShowData(prp prp)
        {
            return call.BusRouteShowData(prp);
        }
        public DataSet DD1BoundData(prp prp)
        {
            return call.DD1BoundData(prp);
        }
        public DataSet DD2BoundData(prp prp)
        {
            return call.DD2BoundData(prp);
        }
        public string BusRouteInsert(prp pr)
        {
            return call.BusRouteInsert(pr);
        }
        public prp SelectBusRoute(prp pr)
        {
            return call.selectBusRoute(pr);
        }
        public string UpdateBusRoute(prp pr)
        {
            return call.updateBusRoute(pr);
        }
        public string DelteBusRoute(prp pr)
        {
            return call.DeleteBusRoute(pr);
        }
        public DataSet DDLBusBoundData()
        {
            return call.DDLBusBoundData();
        }
        public DataSet DDLDriverBoundData()
        {
            return call.DDLDriverBoundData();
        }
        public string BusDriverInsert(prp pr)
        {
            return call.BusDriverInsert(pr);
        }
        public DataSet BusDriverShowData()
        {
            return call.BusDriverShowData();
        }
        public prp BusDriverSelect(prp pr)
        {
            return call.BusDriverSelect(pr);
        }
        public string BusDriverUpdate(prp pr)
        {
            return call.BusDriverUpdate(pr);
        }
        public string DeleteBusDriver(prp pr)
        {
            return call.DeleteBusDriver(pr);

        }
        public DataSet DDLBus()
        {
            return call.DDLBus1();
        }
        public DataSet DDLStops()
        {
            return call.DDLStops1();
        }
        public DataSet BusstudentShowData()
        {
            return call.BusstudentShowData();
        }
        public string BusStudentInsert(prp pr)
        {
            return call.BusStudentInsert(pr);
        }
        public prp BusStudentSelect(prp pr)
        {
            return call.BusStudentSelect(pr);
        }
        public string BusStudentUpdate(prp pr)
        {
            return call.BusStudentUpdate(pr);
        }
        public string DeleteBusStudent(prp pr)
        {
            return call.DeleteBusStudent(pr);
        }

        public string InsertCategory(prp pr)
        {
            return call.InsertCategory(pr);
        }
        public DataSet ShowCategory( string id )
        {
            return call.ShowCategory(id);
        }
        public prp SelectCategory(prp pr)
        {
            return call.SelectCategory(pr);
        }
        public string UpdateCategory(prp pr)
        {
            return call.UpdateCategory(pr);
        }
        public string DeleteCategory(prp pr)
        {
            return call.DeleteCategory(pr);
        }
        public DataSet DDLCategory(string schoolid )
        {
            return call.DDLCategory(schoolid);
        }
        public string InsertProduct(prp pr)
        {
            return call.InsertProduct(pr);
        }
        public DataSet ShowProduct(string schoolid )
        {
            return call.ShowProduct(schoolid);
        }
        public prp SelectProduct(prp pr)
        {
            return call.SelectProduct(pr);
        }
        public string UpdateProduct(prp pr)
        {
            return call.UpdateProduct(pr);
        }
        public string DeleteProduct(prp pr)
        {
            return call.DeleteProduct(pr);
        }
        public string InsertParty(prp pr)
        {
            return call.InsertParty(pr);
        }
        public DataSet ShowParty(string schoolid )
        {
            return call.ShowParty(schoolid);
        }
        public prp SelectParty(prp pr)
        {
            return call.SelectParty(pr);
        }
        public string UpdateParty(prp pr)
        {
            return call.UpdateParty(pr);
        }
        public string DeleteParty(prp pr)
        {
            return call.DeleteParty(pr);
        }
        public string InsertOrder(prp pr)
        {
            return call.InsertOrder(pr);
        }
        public DataSet DDLProduct(string schoolid)
        {
            return call.DDLProduct(schoolid);
        }
        public DataSet DDLParty(string schoolid)
        {
            return call.DDLParty(schoolid);
        }
        public DataSet ShowOrder(string schoolid)
        {
            return call.ShowOrder(schoolid);
        }
        public prp SelectOrder(prp pr)
        {
            return call.SelectOrder(pr);
        }

        public string UpdateOrder(prp pr)
        {
            return call.UpdateOrder(pr);
        }
        public string DeleteOrder(prp pr)
        {
            return call.DeleteOrder(pr);
        }
        public DataSet DDLStatus()
        {
            return call.DDLStatus();
        }
        public DataTable PaymentRecordShow(prp pr)
        {
            return call.PaymentRecordShow(pr);
        }
        public string InsertPaymentDetail(prp pr)
        {
            return call.InsertPaymentDetail(pr);
        }
        public DataSet ShowPaymentDetail(prp pr)
        {
            return call.ShowPaymentDetail(pr);
        }
        public DataSet PartyWiseShow(prp pr)
        {
            return call.PartyWiseShow(pr);
        }
        public DataSet ShorOrderALL(prp pr)
        {
            return call.ShorOrderALL(pr);
        }
        public string InsertVoucherType(prp pr)
        {
            return call.InsertVoucherType(pr);
        }
        public DataSet ShowVocher()
        {
            return call.ShowVocher();
        }
        public prp SelectVocher(prp pr)
        {
            return call.SelectVocher(pr);
        }
        public string UpdateVocher(prp pr)
        {
            return call.UpdateVocher(pr);
        }
        public string DeleteVocher(prp pr)
        {
            return call.DeleteVocher(pr);
        }
        public string InsertVoucher(prp pr)
        {
            return call.InsertVoucher(pr);
        }
        public DataSet ShowVoucher(string schoolid)
        {
            return call.ShowVoucher(schoolid);
        }
        public prp SelectVoucherByID(prp pr)
        {
            return call.SelectVoucherByID(pr);
        }
        public string UpdateVoucher(prp pr)
        {
            return call.UpdateVoucher(pr);
        }
        public string DeleteVoucher(prp pr)
        {
            return call.DeleteVoucher(pr);
        }

                

    }
    


}



