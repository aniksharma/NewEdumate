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

namespace SpSchoolProject
{

    public interface InterFaceLogin
    {

        String loginName { get; set; }
        String loginPassword { get; set; }
        String loginIP { get; set; }
        String StaffName { get; set; }
        String LastLoginTime { get; set; }
        String LastLoginIP { get; set; }
        String StudentName { get; set; }
        String FatherName { get; set; }
        String MotherName { get; set; }
        String LoginType { get; set; }

    }

    public class prpLogin : InterFaceLogin
    {
        string _loginName, _loginPassword, _loginIP, _StaffName, _LastLoginTime, _LastLoginIP, _StudentName, _FatherName, _MotherName;
        string _loginType;
        public string loginName { get { return _loginName; } set { _loginName = value; } }
        public string loginPassword { get { return _loginPassword; } set { _loginPassword = value; } }
        public string loginIP { get { return _loginIP; } set { _loginIP = value; } }
        public string StaffName { get { return _StaffName; } set { _StaffName = value; } }
        public string LastLoginTime { get { return _LastLoginTime; } set { _LastLoginTime = value; } }
        public string LastLoginIP { get { return _LastLoginIP; } set { _LastLoginIP = value; } }
        public string StudentName { get { return _StudentName; } set { _StudentName = value; } }
        public string FatherName { get { return _FatherName; } set { _FatherName = value; } }
        public string MotherName { get { return _MotherName; } set { _MotherName = value; } }
        public string LoginType { get { return _loginType; } set { _loginType = value; } }


    }
    public interface InterfaceProfile
    {
        String Id { get; set; }
        String Name { get; set; }
        String Meto { get; set; }
        String Image { get; set; }
        String Address { get; set; }
        String City { get; set; }
        String District { get; set; }
        String Website { get; set; }
        String state { get; set; }
        String PinCode { get; set; }
        String EmailId { get; set; }
        String MobNo { get; set; }
        String PhoneNo { get; set; }
        String FaxNo { get; set; }


    }

    public class prpprofile : InterfaceProfile
    {
        string _Id, _Name, _Meto, _Image, _Address, _City, _District, _Website, _state, _PinCode, _EmailId, _MobNo, _PhoneNo, _FaxNo;
        string _pwd, _webname, _Code;
        string _Type, _SchoolId, _RollNo;
        string _fatherName, _mothnerName;

        public string lastIP{get; set; }
        public string lastTime { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        

        public string fatherName { get { return _fatherName; } set { _fatherName = value; } }
        public string mothnerName { get { return _mothnerName; } set { _mothnerName = value; } }

        public string Type { get { return _Type; } set { _Type = value; } }
        public string SchoolId { get { return _SchoolId; } set { _SchoolId = value; } }
        public string RollNo { get { return _RollNo; } set { _RollNo = value; } }

        public string Id { get { return _Id; } set { _Id = value; } }
        public string Name { get { return _Name; } set { _Name = value; } }
        public string Meto { get { return _Meto; } set { _Meto = value; } }



        public string Image { get { return _Image; } set { _Image = value; } }
        public string Address { get { return _Address; } set { _Address = value; } }
        public string City { get { return _City; } set { _City = value; } }
        public string District { get { return _District; } set { _District = value; } }
        public string Website { get { return _Website; } set { _Website = value; } }
        public string state { get { return _state; } set { _state = value; } }
        public string PinCode { get { return _PinCode; } set { _PinCode = value; } }
        public string EmailId { get { return _EmailId; } set { _EmailId = value; } }
        public string MobNo { get { return _MobNo; } set { _MobNo = value; } }
        public string PhoneNo { get { return _PhoneNo; } set { _PhoneNo = value; } }
        public string FaxNo { get { return _FaxNo; } set { _FaxNo = value; } }

        public string pwd { get { return _pwd; } set { _pwd = value; } }
        public string webname { get { return _webname; } set { _webname = value; } }
        public string Code { get { return _Code; } set { _Code = value; } }


    }
  
}