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
namespace nmsEditor
{
    public class prpMicroWeb
    {
         public string		webTypeId 		{get; set;}
 public string		webTempId		{get; set;}
 public string		webTypeName 		{get; set;}
 public string		webTypeIsActive  		{get; set;}
 public string		linkId 		{get; set;}
 public string		linkName 		{get; set;}
 public string		linkImagePath 		{get; set;}
 public string		linkUrlPath 		{get; set;}
 public string		linkIsActive  		{get; set;}
 public string		linkSchoolId  		{get; set;}
 public string		linkOrderNo  		{get; set;}
 public string		linkPageType  		{get; set;}
 public string		linkIsDelete		{get; set;}
 public string		typelinkId  		{get; set;}
 public string		typelinkWebId 		{get; set;}
 public string		typelinkLinkId 		{get; set;}
 public string		menuId  		{get; set;}
 public string		menuName 		{get; set;}
 public string		menuPath 		{get; set;}
 public string		menuwebLinks  		{get; set;}
 public string		menuIsActive  		{get; set;}
 public string		menuWebSelectedId  		{get; set;}
 public string		menuWebTypeId 		{get; set;}
 public string		menuwebMenuId  		{get; set;}
 public string		dataId  		{get; set;}
 public string		dataTitle 		{get; set;}
 public string		dataPath 		{get; set;}
 public string		dataDescription 		{get; set;}
 public string		dataIsactive 		{get; set;}
 public string		dataOrderNo 		{get; set;}
 public string		dataLinkId		{get; set;}
 public string		dataSchoolid 		{get; set;}
 public string		    layoutId 		{get; set;}
 public string		layoutName 		{get; set;}
 public string		layoutImagePath		{get; set;}
 public string		layoutDescription		{get; set;}
 public string		layoutIsactive		{get; set;}
 public string		        selectedLayout 		{get; set;}
 public string		selectedLayoutLinkId 		{get; set;}
 public string		selectedLayoutSchoolId 		{get; set;}
 public string		selectedLayoutIsActive 		{get; set;}

    }


    public class prpImagePlan
    {
        private string _imageName, _imagePath, _imageFeature, _imagePlanId, _imageStatus, _imageId, _Name;

        public string imageName { get { return _imageName; } set { _imageName = value; } }
        public string imagePath { get { return _imagePath; } set { _imagePath = value; } }
        public string imageFeature { get { return _imageFeature; } set { _imageFeature = value; } }
        public string imagePlanId { get { return _imagePlanId; } set { _imagePlanId = value; } }
        public string imageStatus { get { return _imageStatus; } set { _imageStatus = value; } }
        public string imageId { get { return _imageId; } set { _imageId = value; } }
        public string Name { get { return _Name; } set { _Name = value; } }
        public string  userId{get;set;}
        public string linkid { get; set; }
        public string layout { get; set; }
    }

    public class PRPPImageGellery
    {
        private string _imageId, _imageTitle, _imagePath, _imageDescription, _imageStatus, _imageOrderNO;
        private string _locationId,_locationName,_locationStatus,_locationTotal;
        private string _id ,_name, _status,_path,_date,_shortPath;
        private string _pageIndex, _pageSize;
        private string _caloneyId, _caloneyName,_total;
        private string  _line1, _line2, _line3, _line4;
        private string _tenantName, _propertyType, _noOfRecord;


        

        private string _schoolid, _Type, _imagepath1,_layout;

        public string layout { get { return _layout; } set { _layout = value; } }

        public string imagepath1 { get { return _imagepath1; } set { _imagepath1 = value; } }

        public string schoolid { get { return _schoolid; } set { _schoolid = value; } }
        public string Type { get { return _Type; } set { _Type = value; } }
        


        public string noOfRecord { get { return _noOfRecord; } set { _noOfRecord = value; } }
        
        public string propertyType { get { return _propertyType; } set { _propertyType = value; } }
        public string tenantName { get { return _tenantName; } set { _tenantName = value; } }
        
        public string imageId { get { return _imageId; } set { _imageId = value; } }
        public string imageTitle { get { return _imageTitle; } set { _imageTitle = value; } }
        public string imagePath { get { return _imagePath; } set { _imagePath = value; } }
        public string imageDescription { get { return _imageDescription; } set { _imageDescription = value; } }
        public string imageStatus { get { return _imageStatus; } set { _imageStatus = value; } }
        public string imageOrderNO { get { return _imageOrderNO; } set { _imageOrderNO = value; } }

        public string path { get { return _path; } set { _path = value; } }
        public string date { get { return _date; } set { _date = value; } }
        public string shortPath { get { return _shortPath; } set { _shortPath = value; } }
        
        public string locationId { get { return _locationId; } set { _locationId = value; } }
        public string locationName { get { return _locationName; } set { _locationName = value; } }
        public string locationStatus { get { return _locationStatus; } set { _locationStatus = value; } }
        public string locationTotal { get { return _locationTotal; } set { _locationTotal = value; } }

        public string name { get { return _name; } set { _name = value; } }
        public string status { get { return _status; } set { _status = value; } }
        public string id { get { return _id; } set { _id = value; } }
        public string total { get { return _total; } set { _total = value; } }
        public string line1 { get { return _line1; } set { _line1 = value; } }
        public string line2 { get { return _line2; } set { _line2 = value; } }
        public string line3 { get { return _line3; } set { _line3 = value; } }
        public string line4 { get { return _line4; } set { _line4 = value; } }
        

        public string caloneyId { get { return _caloneyId; } set { _caloneyId = value; } }
        public string caloneyName { get { return _caloneyName; } set { _caloneyName = value; } }

        public string pageIndex { get { return _pageIndex; } set { _pageIndex = value; } }
        public string pageSize { get { return _pageSize; } set { _pageSize = value; } }

     
    }


    public class PRPProfile : PRPPImageGellery
    {
        private string _sellerContactPerson, _sellerContactNo, _sellermailId, _sellerAddress, _sellerCity, _sellerDistrict, _sellerState, _sellerPinCode, _sellerPhoneNo, _sellerWantTo;
   private string _sellerPropertyType,	_sellerBedRoomNo,	_sellerBathRoomNo,	_sellerBHKNo,	_sellerFloorNo,	_sellerPlotSizeLength,	_sellerPlotSizeWidth,	_sellerFurnished,	_sellerCoveredArea,	_sellerCoverAreaType	;
   private string _sellerPropertyDescription,	_sellerPropertyLocation,	_sellerPropertyLandmark,	_sellerPropertyAddress,	_sellerTenanType,	_sellerRentMin,	_sellerRentMax	,_sellerSecuirty	,_sellerAgreement	,_selleravailabilty;	
        private string _sellerMinCoste,	_sellerMaxCoste,	_sellerType,	_SellerStatus,	_Sellerdate	,_SellerRemaark;
        private string _sellerCompanyLease;

        public string sellerCompanyLease { get { return _sellerCompanyLease; } set { _sellerCompanyLease = value; } }
        
        public string sellerContactPerson { get { return _sellerContactPerson; } set { _sellerContactPerson = value; } }
        public string sellerContactNo { get { return _sellerContactNo; } set { _sellerContactNo = value; } }
        public string sellermailId { get { return _sellermailId; } set { _sellermailId = value; } }
        public string sellerAddress { get { return _sellerAddress; } set { _sellerAddress = value; } }
        public string sellerCity { get { return _sellerCity; } set { _sellerCity = value; } }
        public string sellerDistrict { get { return _sellerDistrict; } set { _sellerDistrict = value; } }
        public string sellerState { get { return _sellerState; } set { _sellerState = value; } }
        public string sellerPinCode { get { return _sellerPinCode; } set { _sellerPinCode = value; } }
        public string sellerPhoneNo { get { return _sellerPhoneNo; } set { _sellerPhoneNo = value; } }
        public string sellerWantTo { get { return _sellerWantTo; } set { _sellerWantTo = value; } }
        public string sellerPropertyType { get { return _sellerPropertyType; } set { _sellerPropertyType = value; } }
        public string sellerBedRoomNo { get { return _sellerBedRoomNo; } set { _sellerBedRoomNo = value; } }
        public string sellerBathRoomNo { get { return _sellerBathRoomNo; } set { _sellerBathRoomNo = value; } }
        public string sellerBHKNo { get { return _sellerBHKNo; } set { _sellerBHKNo = value; } }
        public string sellerFloorNo { get { return _sellerFloorNo; } set { _sellerFloorNo = value; } }
        public string sellerPlotSizeLength { get { return _sellerPlotSizeLength; } set { _sellerPlotSizeLength = value; } }
        public string sellerPlotSizeWidth { get { return _sellerPlotSizeWidth; } set { _sellerPlotSizeWidth = value; } }
        public string sellerFurnished { get { return _sellerFurnished; } set { _sellerFurnished = value; } }
        public string sellerCoveredArea { get { return _sellerCoveredArea; } set { _sellerCoveredArea = value; } }
        public string sellerCoverAreaType { get { return _sellerCoverAreaType; } set { _sellerCoverAreaType = value; } }
        public string sellerPropertyDescription { get { return _sellerPropertyDescription; } set { _sellerPropertyDescription = value; } }
        public string sellerPropertyLocation { get { return _sellerPropertyLocation; } set { _sellerPropertyLocation = value; } }
        public string sellerPropertyLandmark { get { return _sellerPropertyLandmark; } set { _sellerPropertyLandmark = value; } }
        public string sellerPropertyAddress { get { return _sellerPropertyAddress; } set { _sellerPropertyAddress = value; } }
        public string sellerTenanType { get { return _sellerTenanType; } set { _sellerTenanType = value; } }
        public string sellerRentMin { get { return _sellerRentMin; } set { _sellerRentMin = value; } }
        public string sellerRentMax { get { return _sellerRentMax; } set { _sellerRentMax = value; } }
        public string sellerSecuirty { get { return _sellerSecuirty; } set { _sellerSecuirty = value; } }
        public string sellerAgreement { get { return _sellerAgreement; } set { _sellerAgreement = value; } }
        public string selleravailabilty { get { return _selleravailabilty; } set { _selleravailabilty = value; } }
        public string sellerMinCoste { get { return _sellerMinCoste; } set { _sellerMinCoste = value; } }
        public string sellerMaxCoste { get { return _sellerMaxCoste; } set { _sellerMaxCoste = value; } }
        public string sellerType { get { return _sellerType; } set { _sellerType = value; } }
        public string SellerStatus { get { return _SellerStatus; } set { _SellerStatus = value; } }
        public string Sellerdate { get { return _Sellerdate; } set { _Sellerdate = value; } }
        public string SellerRemaark { get { return _SellerRemaark; } set { _SellerRemaark = value; } }


    }
   public class PRPEditor
    {
       private string _Id, _Page, _pagePositin, _date, _content, _mobileNo1, _mobileNo2;
       private string _password, _oldPassword,_name;
       private string _newsTitle, _newsDescription, _newsId, _newsDate;
       private string _FistName, _LastName, _Country, _State, _Email, _Feedback, _Mob;
       private string _pageIndex, _pageSize ,_featuresName;
       private string _subject;
       private string _courseId, _courseName, _courseEligibity, _courseDuration, _courseDescription, _courseDate;
       private string _courseDescriptionfull;
       private string _SchoolId;

       public string SchoolId { get { return _SchoolId; } set { _SchoolId = value; } }
       
       public string courseDescriptionfull { get { return _courseDescriptionfull; } set { _courseDescriptionfull = value; } }
       public string courseId { get { return _courseId; } set { _courseId = value; } }
       public string courseName { get { return _courseName; } set { _courseName = value; } }
       public string courseEligibity { get { return _courseEligibity; } set { _courseEligibity = value; } }
       public string courseDuration { get { return _courseDuration; } set { _courseDuration = value; } }
       public string courseDate { get { return _courseDate; } set { _courseDate = value; } }
       public string courseDescription { get { return _courseDescription; } set { _courseDescription = value; } }

       
       public string subject { get { return _subject; } set { _subject = value; } }
       
       public string featuresName { get { return _featuresName; } set { _featuresName = value; } }
       public string Id { get { return _Id; } set { _Id = value; } }
        public string Page { get { return _Page; } set { _Page = value; } }
        public string pagePositin { get { return _pagePositin; } set { _pagePositin = value; } }
        public string date { get { return _date; } set { _date = value; } }
        public string content { get { return _content; } set { _content = value; } }

        public string mobileNo1 { get { return _mobileNo1; } set { _mobileNo1 = value; } }
        public string mobileNo2 { get { return _mobileNo2; } set { _mobileNo2 = value; } }

        public string password { get { return _password; } set { _password = value; } }
        public string oldPassword { get { return _oldPassword; } set { _oldPassword = value; } }
        public string name { get { return _name; } set { _name = value; } }


        public string newsId { get { return _newsId; } set { _newsId = value; } }
        public string newsDate { get { return _newsDate; } set { _newsDate = value; } }
        public string newsTitle { get { return _newsTitle; } set { _newsTitle = value; } }
        public string newsDescription { get { return _newsDescription; } set { _newsDescription = value; } }


        public string FistName { get { return _FistName; } set { _FistName = value; } }
        public string LastName { get { return _LastName; } set { _LastName = value; } }
        public string Country { get { return _Country; } set { _Country = value; } }
        public string State { get { return _State; } set { _State = value; } }
        public string Email { get { return _Email; } set { _Email = value; } }
        public string Feedback { get { return _Feedback; } set { _Feedback = value; } }
        public string Mob { get { return _Mob; } set { _Mob = value; } }

        public string pageIndex { get { return _pageIndex; } set { _pageIndex = value; } }
        public string pageSize { get { return _pageSize; } set { _pageSize = value; } }

       
    }
   public class PRPStudent:PRPEditor
   {
       private string  _studentId ,_studentName,_studentFather,_studentGender,_studentMarital,_studentCourse,_studentQualification,_studentCaste;
       private string _studentAddress, _studentCity, _studentDistirct, _studentMoibleNo, _studentPhoneNo, _studentMailId, _studentknowFrom;
       private string _studentDate;
       public string studentId { get { return _studentId; } set { _studentId = value; } }
       public string studentName { get { return _studentName; } set { _studentName = value; } }
       public string studentFather { get { return _studentFather; } set { _studentFather = value; } }
       public string studentGender { get { return _studentGender; } set { _studentGender = value; } }
       public string studentMarital { get { return _studentMarital; } set { _studentMarital = value; } }
       public string studentCourse { get { return _studentCourse; } set { _studentCourse = value; } }
       public string studentQualification { get { return _studentQualification; } set { _studentQualification = value; } }
       public string studentCaste { get { return _studentCaste; } set { _studentCaste = value; } }
       public string studentAddress { get { return _studentAddress; } set { _studentAddress = value; } }
       public string studentCity { get { return _studentCity; } set { _studentCity = value; } }
       public string studentMoibleNo { get { return _studentMoibleNo; } set { _studentMoibleNo = value; } }
       public string studentPhoneNo { get { return _studentPhoneNo; } set { _studentPhoneNo = value; } }
       public string studentMailId { get { return _studentMailId; } set { _studentMailId = value; } }
       public string studentknowFrom { get { return _studentknowFrom; } set { _studentknowFrom = value; } }
       public string studentDistirct { get { return _studentDistirct; } set { _studentDistirct = value; } }

   
  
  }
}
