using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace BusEntry
{
    public class prp
    {
        string BusID,BusNo,BusAddDate, BusName, BusModel, BusCompany, BusCondition, BusStatus, SchoolID;
        public string PBusID
        {
            get { return BusID; }
            set { BusID = value; }
        }
        public string PBusName
        {
            get { return BusName; }
            set { BusName = value; }
        }
        public string PBusModel
        {
            get { return BusModel; }
            set { BusModel = value; }
        }
        public string PBusCompany
        {
            get { return BusCompany; }
            set { BusCompany = value; }
        }
        public string PBusCondition
        {
            get { return BusCondition; }
            set { BusCondition = value; }
        }
        public string PBusStatus
        {
            get { return BusStatus; }
            set { BusStatus = value; }
        }
        public string PSchoolID
        {
            get { return SchoolID; }
            set { SchoolID = value; }
        }
        public string PBusNO
        {
            get { return BusNo; }
            set { BusNo = value; }
        }
        public string PBusAddDate
        {
            get { return BusAddDate; }
            set { BusAddDate = value; }
        }
        string RouteID, RouteName, StartPoint, EndingPoint, RouteAddDate, RouteStatus;
        public string PRouteName
        {
            get { return RouteName; }
            set { RouteName = value; }
        }
        public string PRouteID
        {
            get { return RouteID; }
            set { RouteID = value; }
        }
        public string PStartPoint
        {
            get { return StartPoint; }
            set { StartPoint = value; }
        }
        public string PEndingPoint
        {
            get { return EndingPoint; }
            set { EndingPoint = value; }
        }
        public string PRouteAddDate
        {
            get { return RouteAddDate; }
            set { RouteAddDate = value; }
        }
        public string PRouteStatus
        {
            get { return RouteStatus; }
            set { RouteStatus = value; }
        }
        string StopesName, Distance,StopesID;
        public string PStopesName
        {
            get { return StopesName; }
            set { StopesName = value; }
        }
        public string PDistance
        {
            get { return Distance; }
            set { Distance = value; }
        }
        public string PRemark
        {
            get { return Remark; }
            set { Remark = value; }
        }

        public string PStopesID
        {
            get { return StopesID; }
            set { StopesID = value; }
        }
        string BusRouteID, StartDate, EndDate, MorngStarttime, MorngEndtime, Evngendtime, Evngstarttime, BusRouteStatus;
        public string PBusRouteID
        {
            get { return BusRouteID; }
            set { BusRouteID = value; }
        }
        public string PStartDate
        {
            get { return StartDate; }
            set { StartDate = value; }
        }
        public string PEndDate
        {
            get { return EndDate; }
            set { EndDate = value; }
        }
        public string PMorngStarttime
        {
            get { return MorngStarttime; }
            set { MorngStarttime = value; }
        }
        public string PMorngEndtime
        {
            get { return MorngEndtime; }
            set { MorngEndtime = value; }
        }
        public string PEvngstarttime
        {
            get { return Evngstarttime; }
            set { Evngstarttime = value; }
        }
        public string PEvngendtime
        {
            get { return Evngendtime; }
            set { Evngendtime = value; }
        }
        public string PBusRouteStatus
        {
            get { return BusRouteStatus; }
            set { BusRouteStatus = value; }
        }
        string BusDriverID, startDate, Enddate, DriverStatus, StaffID, StaffName;
        public string PBusDriverID
        {
            get { return BusDriverID; }
            set { BusDriverID = value; }
        }
        
        public string PstartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        public string PEnddate
        {
            get { return Enddate; }
            set { Enddate = value; }
        }
        public string PDriverStatus
        {
            get { return DriverStatus; }
            set { DriverStatus = value; }
        }
        public string PStaffID
        {
            get { return StaffID; }
            set { StaffID = value; }
        }
        public string PStaffName
        {
            get { return StaffName; }
            set { StaffName = value; }
        }
        string StudentBusID, StudentID, StudentStatus;
        public string PStudentBusID
        {
            get { return StudentBusID; }
            set { StudentBusID = value; }
        }
        public string PStudentID
        {
            get { return StudentID; }
            set { StudentID = value; }
        }
        public string PStudentStatus
        {
            get { return StudentStatus; }
            set { StudentStatus = value; }
        }




        string  SchoolName, CategoryID, CategoryName;
        public string PSchoolName
        {
            get { return SchoolName; }
            set { SchoolName = value; }
        }
        public string PCategoryID
        {
            get { return CategoryID; }
            set { CategoryID = value; }
        }
        public string PCategoryName
        {
            get { return CategoryName; }
            set { CategoryName = value; }
        }
        string ProductID, ProductName, ProductType, ProductDescripation, ProductEntryDate;
        public string PProductID
        {
            get { return ProductID; }
            set { ProductID = value; }
        }
        public string PProductName
        {
            get { return ProductName; }
            set { ProductName = value; }
        }
        public string PProductType
        {
            get { return ProductType; }
            set { ProductType = value; }
        }
        public string PProductDescripation
        {
            get { return ProductDescripation; }
            set { ProductDescripation = value; }
        }
        public string PProductEntryDate
        {
            get { return ProductEntryDate; }
            set { ProductEntryDate = value; }
        }
        string PartyID, PartyName, Location, PartyType, PartyDescripation, ContactNo, EmailID, PartyAddDate;
        public string PPartyID
        {
            get { return PartyID; }
            set { PartyID = value; }
        }

        public string PPartyName
        {
            get { return PartyName; }
            set { PartyName = value; }
        }

        public string PLocation
        {
            get { return Location; }
            set { Location = value; }
        }

        public string PPartyType
        {
            get { return PartyType; }
            set { PartyType = value; }
        }
        public string PPartyDescripation
        {
            get { return PartyDescripation; }
            set { PartyDescripation = value; }
        }
        public string PContactNo
        {
            get { return ContactNo; }
            set { ContactNo = value; }
        }

        public string PEmailID
        {
            get { return EmailID; }
            set { EmailID = value; }
        }

        public string PPartyAddDate
        {
            get { return PartyAddDate; }
            set { PartyAddDate = value; }
        }
        string Remark, PaymentDate, TotalAmount, OrderStatusID, OrderStatus, OrderID, OrderNo, TotalQuantity, PayementType, Amount, Discount, OrderDate;

        
        public string PPaymentDate
        {
            get { return PaymentDate; }
            set { PaymentDate = value; }
        }

        public string PTotalAmount
        {
            get { return TotalAmount; }
            set { TotalAmount = value; }
        }
        public string POrderStatusID
        {
            get { return OrderStatusID; }
            set { OrderStatusID = value; }
        }
        public string POrderStatus
        {
            get { return OrderStatus; }
            set { OrderStatus = value; }
        }
        public string POrderID
        {
            get { return OrderID; }
            set { OrderID = value; }
        }
        public string POrderNo
        {
            get { return OrderNo; }
            set { OrderNo = value; }
        }

        public string PTotalQuantity
        {
            get { return TotalQuantity; }
            set { TotalQuantity = value; }
        }

        public string PPayementType
        {
            get { return PayementType; }
            set { PayementType = value; }
        }


        public string PDiscount
        {
            get { return Discount; }
            set { Discount = value; }
        }
        public string POrderDate
        {
            get { return OrderDate; }
            set { OrderDate = value; }
        }
        string VoucherTypeID, VoucherTypeName;
        public string PVoucherTypeID
        {
            get { return VoucherTypeID; }
            set { VoucherTypeID = value; }
        }
        public string PVoucherTypeName
        {
            get { return VoucherTypeName; }
            set { VoucherTypeName = value; }
        }
        string VoucherID, VoucherNo, PaidTo, ToFor, ReceivedBy, ApprrovedBY, VoucherDate;
        public string PVoucherID
        {
            get { return VoucherID; }
            set { VoucherID = value; }
        }
        public string PVoucherNo
        {
            get { return VoucherNo; }
            set { VoucherNo = value; }
        }
        public string PPaidTo
        {
            get { return PaidTo; }
            set { PaidTo = value; }
        }
        public string PToFor
        {
            get { return ToFor; }
            set { ToFor = value; }
        }
        public string PReceivedBy
        {
            get { return ReceivedBy; }
            set { ReceivedBy = value; }
        }
        public string PApprrovedBY
        {
            get { return ApprrovedBY; }
            set { ApprrovedBY = value; }
        }
        public string PAmount
        {
            get { return Amount; }
            set { Amount = value; }
        }

        public string PVoucherDate
        {
            get { return VoucherDate; }
            set { VoucherDate = value; }
        }

        

        



        
              

       

    }
}