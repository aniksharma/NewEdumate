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
using System.Collections.Generic;
namespace SpSchoolProject
{
    public interface ddlptr
    {
        String Pid
        {
            get;
            set;
        }
        String Pname
        {
            get;
            set;
        }
        String PDateOfBirth
        {
            get;
            set;
        }
        String PSex
        {
            get;
            set;
        }
        String PNature
        {
            get;
            set;
        }
        String PLanguage
        {
            get;
            set;
        }
        String PBlood
        {
            get;
            set;
        }
        String PNationality
        {
            get;
            set;
        }
        String Pcode
        {
            get;
            set;
        }
        String Psection
        {
            get;
            set;
        }
        String PDescription
        {
            get;
            set;
        }
        String PPriodStart
        {
            get;
            set;
        }
        String PPriodEnd
        {
            get;
            set;
        }
        String PMotivation
        {
            get;
            set;
        }
        String PImage
        {
            get;
            set;
        }
        String PAddress
        {
            get;
            set;
        }
        String PCity
        {
            get;
            set;
        }
        String PState
        {
            get;
            set;
        }
        String PDist
        {
            get;
            set;
        }
        String PEmail
        {
            get;
            set;
        }
        String PMobile
        {
            get;
            set;
        }
        String PFax
        {
            get;
            set;
        }
        String PPhone
        {
            get;
            set;
        }
        String PWeb
        {
            get;
            set;
        }
        String PLast
        {
            get;
            set;
        }
        String PCatagary
        {
            get;
            set;
        }
        String PStartDat
        {
            get;
            set;
        }
        String PCaste
        {
            get;
            set;
        }
        String PStatus
        {
            get;
            set;
        }
        String PJoinDate
        {
            get;
            set;
        }
        String Puid
        {
            get;
            set;
        }
        String Puname
        {
            get;
            set;
        }
        String PSalary
        {
            get;
            set;
        }
        String PBusCharge
        {
            get;
            set;
        }
        String PTA
        {
            get;
            set;
        }
        String PDA
        {
            get;
            set;
        }
        String PHRA
        {
            get;
            set;
        }
        String PAccount
        {
            get;
            set;
        }
        String PPanNo
        {
            get;
            set;
        }
        String PMedicalAllowance
        {
            get;
            set;
        }
        String POtherAllownce
        {
            get;
            set;
        }
        String PCanteenChrge
        {
            get;
            set;
        }
        String PCasualLeave
        {
            get;
            set;
        }
        String PLeave
        {
            get;
            set;
        }
        String PDepartment
        {
            get;
            set;
        }
        String PExperience
        {
            get;
            set;
        }
        String POtherQualification
        {
            get;
            set;
        }
        String PQualification
        {
            get;
            set;
        }
        String PPf
        {
            get;
            set;
        }
        String PDegination
        {
            get;
            set;
        }
        String PType
        {
            get;
            set;
        }
        String PMedicalLeave
        {
            get;
            set;
        }
        String PSubGroup
        {
            get;
            set;
        }
        String PClass
        {
            get;
            set;
        }
        String PReligious
        {
            get;
            set;
        }
        String PAdmition
        {
            get;
            set;
        }
        String PMedium
        {
            get;
            set;
        }
        String PRoll
        {
            get;
            set;
        }
        String PKnown
        {
            get;
            set;
        }
        String PEnrollment
        {
            get;
            set;
        }
        String PSubject
        {
            get;
            set;
        }
        String PDuration
        {
            get;
            set;
        }
        String PAmount
        {
            get;
            set;
        }
        String PFees
        {
            get;
            set;
        }
        String PEndDate
        {
            get;
            set;
        }
        String PMax
        {
            get;
            set;
        }
        String PMin
        {
            get;
            set;
        }
        String PTotal
        {
            get;
            set;
        }
        String PExaminar
        {
            get;
            set;
        }
        String PStartTime
        {
            get;
            set;
        }
        String PEndTime
        {
            get;
            set;
        }
        String PStartMin
        {
            get;
            set;
        }
        String PEndMin
        {
            get;
            set;
        }
        String PStartJone
        {
            get;
            set;
        }
        String PEndJone
        {
            get;
            set;
        }
        String PLocation
        {
            get;
            set;
        }
        String PReason
        {
            get;
            set;
        }
        String PAproved
        {
            get;
            set;
        }
        String PFname
        {
            get;
            set;
        }
        String PMname
        {
            get;
            set;
        }
        String PFImage
        {
            get;
            set;
        }
        String PFAddress
        {
            get;
            set;
        }
        String PFCity
        {
            get;
            set;
        }
        String PFState
        {
            get;
            set;
        }
        String PFDist
        {
            get;
            set;
        }
        String PFEmail
        {
            get;
            set;
        }
        String PFMobile
        {
            get;
            set;
        }
        String PFFax
        {
            get;
            set;
        }
        String PFPhone
        {
            get;
            set;
        }
        String PMImage
        {
            get;
            set;
        }
        String PMAddress
        {
            get;
            set;
        }
        String PMCity
        {
            get;
            set;
        }
        String PMState
        {
            get;
            set;
        }
        String PMDist
        {
            get;
            set;
        }
        String PMEmail
        {
            get;
            set;
        }
        String PMMobile
        {
            get;
            set;
        }
        String PMFax
        {
            get;
            set;
        }
        String PMPhone
        {
            get;
            set;
        }
        String PMOcupation
        {
            get;
            set;
        }
        String PFOcupation
        {
            get;
            set;
        }
        String POcupation
        {
            get;
            set;
        }
        String PFcode
        {
            get;
            set;
        }
        String PMcode
        {
            get;
            set;
        }
        String PFstate
        {
            get;
            set;
        }
        String PMstate
        {
            get;
            set;
        }


        String PSchoolID
        {
            get;
            set;
        }
        String PPreFix
        {
            get;
            set;
        }
        String PPostFix
        {
            get;
            set;
        }
        String PFor
        {
            get;
            set;
        }
       
       
    }
    public class usprp : ddlptr
    {
        string _fatherName, _mothnerName;

        public string fatherName { get { return _fatherName; } set { _fatherName = value; } }
        public string mothnerName { get { return _mothnerName; } set { _mothnerName = value; } }

        string Mstate,Fstate, Mcode, Fcode, Ocupation, FOcupation, MOcupation, MFax, MMobile, MEmail, MDist, MState, MCity, MAddress, MImage, FFax, FPhone, FMobile, FEmail, FDist, FCity, FImage, FAddress;
        string MPhone,Mname, Fname, Aproved, Reason, Location, EndJone, StartJone, EndMin, StartMin, EndTime, StartTime, Examinar, Total, Min, Max, EndDate, Fees, Amount, Duration, Subject, Known, Enrollment, Roll, Medium, Admition, Religious, Class, SubGroup, MedicalLeave, Type, Degination, Pf, OtherQualification, Qualification, Experience, Department, Leave, CasualLeave, CanteenChrge, OtherAllownce, MedicalAllowance, PanNo, Account, HRA, DA, TA, BusCharge, Salary, uid, uname, name, Web, JoinDate, Last, Caste, Status, StartDate, Catagary, DateOfbirth, Mobile, Email, Fax, Phone, Dist, City, State, sex, Images, Address, nature, language, Nationality, Blood, id, code, section, Description, PriodStart, PriodEnd, Motivation;
        string  groupcode, groupname;

        string For, PreFix, PostFix,SchoolId;

        string _password, _username, _oldPassword;
        #region prptr Members
        public string PMstate
        {
            get
            {
                return Mstate;
            }
            set
            {
                Mstate = value;
            }
        }
        public string PFstate
        {
            get
            {
                return Fstate;
            }
            set
            {
                Fstate = value;
            }
        }
        public string PMcode
        {
            get
            {
                return Mcode;
            }
            set
            {
                Mcode = value;
            }
        }
        public string PFcode
        {
            get
            {
                return Fcode;
            }
            set
            {
                Fcode = value;
            }
        }
        public string PFOcupation
        {
            get
            {
                return FOcupation;
            }
            set
            {
                FOcupation = value;
            }
        }
        public string PMOcupation
        {
            get
            {
                return MOcupation;
            }
            set
            {
                MOcupation = value;
            }
        }
        public string PMFax
        {
            get
            {
                return MFax;
            }
            set
            {
                MFax = value;
            }
        }
        public string PMMobile
        {
            get
            {
                return MMobile;
            }
            set
            {
                MMobile = value;
            }
        }
        public string PMEmail
        {
            get
            {
                return MEmail;
            }
            set
            {
                MEmail = value;
            }
        }
        public string PMDist
        {
            get
            {
                return MDist;
            }
            set
            {
                MDist = value;
            }
        }
        public string PMState
        {
            get
            {
                return MState;
            }
            set
            {
                MState = value;
            }
        }
        public string PMCity
        {
            get
            {
                return MCity;
            }
            set
            {
                MCity = value;
            }
        }
        public string PMAddress
        {
            get
            {
                return MAddress;
            }
            set
            {
                MAddress = value;
            }
        }
        public string PMImage
        {
            get
            {
                return MImage;
            }
            set
            {
                MImage = value;
            }
        }
        public string PFFax
        {
            get
            {
                return FFax;
            }
            set
            {
                FFax = value;
            }
        }
        public string PFPhone
        {
            get
            {
                return FPhone;
            }
            set
            {
                FPhone = value;
            }
        }
        public string PFMobile
        {
            get
            {
                return FMobile;
            }
            set
            {
                FMobile = value;
            }
        }
        public string PFEmail
        {
            get
            {
                return FEmail;
            }
            set
            {
                FEmail = value;
            }
        }
        public string PFDist
        {
            get
            {
                return FDist;
            }
            set
            {
                FDist = value;
            }
        }
        public string PFCity
        {
            get
            {
                return FCity;
            }
            set
            {
                FCity = value;
            }
        }
        public string PFImage
        {
            get
            {
                return FImage;
            }
            set
            {
                FImage = value;
            }
        }
        public string PFAddress
        {
            get
            {
                return FAddress;
            }
            set
            {
                FAddress = value;
            }
        }
        public string PMPhone
        {
            get
            {
                return MPhone;
            }
            set
            {
                MPhone = value;
            }
        }
     public string PMname
        {
            get
            {
                return Mname;
            }
            set
            {
                Mname = value;
            }
        }
        public string PFname
        {
            get
            {
                return Fname;
            }
            set
            {
                Fname = value;
            }
        }
        public string PAproved
        {
            get
            {
                return Aproved;
            }
            set
            {
                Aproved = value;
            }
        }
        public string PReason
        {
            get
            {
                return Reason;
            }
            set
            {
                Reason = value;
            }
        }
        public string PLocation
        {
            get
            {
                return Location;
            }
            set
            {
                Location = value;
            }
        }
        public string PEndJone
        {
            get
            {
                return EndJone;
            }
            set
            {
                EndJone = value;
            }
        }
        public string PStartJone
        {
            get
            {
                return StartJone;
            }
            set
            {
                StartJone = value;
            }
        }
        public string PEndMin
        {
            get
            {
                return EndMin;
            }
            set
            {
                EndMin = value;
            }
        }
        public string PStartMin
        {
            get
            {
                return StartMin;
            }
            set
            {
                StartMin = value;
            }
        }
        public string PEndTime
        {
            get
            {
                return EndTime;
            }
            set
            {
                EndTime = value;
            }
        }
        public string PStartTime
        {
            get
            {
                return StartTime;
            }
            set
            {
                StartTime = value;
            }
        }
        public string PExaminar
        {
            get
            {
                return Examinar;
            }
            set
            {
                Examinar = value;
            }
        }
        public string PTotal
        {
            get
            {
                return Total;
            }
            set
            {
                Total = value;
            }
        }
        public string PMin
        {
            get
            {
                return Min;
            }
            set
            {
                Min = value;
            }
        }
        public string PMax
        {
            get
            {
                return Max;
            }
            set
            {
                Max = value;
            }
        }
        public string PEndDate
        {
            get
            {
                return EndDate;
            }
            set
            {
                EndDate = value;
            }
        }
        public string PAmount
        {
            get
            {
                return Amount;
            }
            set
            {
                Amount = value;
            }
        }
        public string PFees
        {
            get
            {
                return Fees;
            }
            set
            {
                Fees = value;
            }
        }
        public string PDuration
        {
            get
            {
                return Duration;
            }
            set
            {
                Duration = value;
            }
        }
        public string PSubject
        {
            get
            {
                return Subject;
            }
            set
            {
                Subject = value;
            }
        }
        public string PKnown
        {
            get
            {
                return Known;
            }
            set
            {
                Known = value;
            }
        }
        public string PEnrollment
        {
            get
            {
                return Enrollment;
            }
            set
            {
                Enrollment = value;
            }
        }
        public string PRoll
        {
            get
            {
                return Roll;
            }
            set
            {
                Roll = value;
            }
        }
        public string PMedium
        {
            get
            {
                return Medium;
            }
            set
            {
                Medium = value;
            }
        }
        public string PAdmition
        {
            get
            {
                return Admition;
            }
            set
            {
                Admition = value;
            }
        }
        public string PSubGroup
        {
            get
            {
                return SubGroup;
            }
            set
            {
                SubGroup = value;
            }
        }
        public string PClass
        {
            get
            {
                return Class;
            }
            set
            {
                Class = value;
            }
        }
        public string PReligious
        {
            get
            {
                return Religious;
            }
            set
            {
                Religious = value;
            }
        }
        public string PMedicalLeave
        {
            get
            {
                return MedicalLeave;
            }
            set
            {
                MedicalLeave = value;
            }
        }
        public string PExperience
        {
            get
            {
                return Experience;
            }
            set
            {
                Experience = value;
            }
        }
        public string PType
        {
            get
            {
                return Type;
            }
            set
            {
                Type = value;
            }
        }
        public string PDegination
        {
            get
            {
                return Degination;
            }
            set
            {
                Degination = value;
            }
        }
        public string PPf
        {
            get
            {
                return Pf;
            }
            set
            {
                Pf = value;
            }
        }
        public string POtherQualification
        {
            get
            {
                return OtherQualification;
            }
            set
            {
                OtherQualification = value;
            }
        }
        public string PQualification
        {
            get
            {
                return Qualification;
            }
            set
            {
                Qualification = value;
            }
        }
        public string PDepartment
        {
            get
            {
                return Department;
            }
            set
            {
                Department = value;
            }
        }
        public string PCasualLeave
        {
            get
            {
                return CasualLeave;
            }
            set
            {
                CasualLeave = value;
            }
        }
        public string PLeave
        {
            get
            {
                return Leave;
            }
            set
            {
                Leave = value;
            }
        }
        public string PMedicalAllowance
        {
            get
            {
                return MedicalAllowance;
            }
            set
            {
                MedicalAllowance = value;
            }
        }
        public string POtherAllownce
        {
            get
            {
                return OtherAllownce;
            }
            set
            {
                OtherAllownce = value;
            }
        }
        public string PCanteenChrge
        {
            get
            {
                return CanteenChrge;
            }
            set
            {
                CanteenChrge = value;
            }
        }
        public string PPanNo
        {
            get
            {
                return PanNo;
            }
            set
            {
                PanNo = value;
            }
        }
        public string PAccount
        {
            get
            {
                return Account;
            }
            set
            {
                Account = value;
            }
        }
        public string PHRA
        {
            get
            {
                return HRA;
            }
            set
            {
                HRA = value;
            }
        }
        public string PDA
        {
            get
            {
                return DA;
            }
            set
            {
                DA = value;
            }
        }
        public string PTA
        {
            get
            {
                return TA;
            }
            set
            {
                TA = value;
            }
        }
        public string PBusCharge
        {
            get
            {
                return BusCharge;
            }
            set
            {
                BusCharge = value;
            }
        }
        public string PSalary
        {
            get
            {
                return Salary;
            }
            set
            {
                Salary = value;
            }
        }
        public string Puid
        {
            get
            {
                return uid;
            }
            set
            {
                uid = value;
            }
        }

        public string Puname
        {
            get
            {
                return uname;
            }
            set
            {
                uname = value;
            }
        }
        public string PJoinDate
        {
            get
            {
                return JoinDate;
            }
            set
            {
                JoinDate = value;
            }
        }
        public string PStatus
        {
            get
            {
                return Status;
            }
            set
            {
                Status = value;
            }
        }
        public string PCaste
        {
            get
            {
                return Caste;
            }
            set
            {
                Caste = value;
            }
        }
        public string PStartDat
        {
            get
            {
                return StartDate;
            }
            set
            {
                StartDate = value;
            }
        }
        public string PCatagary
        {
            get
            {
                return StartDate;
            }
            set
            {
                StartDate = value;
            }
        }
        public string PLast
        {
            get
            {
                return Last;
            }
            set
            {
                Last = value;
            }
        }
        public string PWeb
        {
            get
            {
                return Web;
            }
            set
            {
                Web = value;
            }
        }
        public string PEmail
        {
            get
            {
                return Email;
            }
            set
            {
                Email = value;
            }
        }
        public string PMobile
        {
            get
            {
                return Mobile;
            }
            set
            {
                Mobile = value;
            }
        }
        public string PFax
        {
            get
            {
                return Fax;
            }
            set
            {
                Fax = value;
            }
        }
        public string PPhone
        {
            get
            {
                return Phone;
            }
            set
            {
                Phone = value;
            }
        }
        public string PCity
        {
            get
            {
                return City;
            }
            set
            {
                City = value;
            }
        }
        public string PState
        {
            get
            {
                return State;
            }
            set
            {
                State = value;
            }
        }
        public string PDist
        {
            get
            {
                return Dist;
            }
            set
            {
                Dist = value;
            }
        }
        public string PAddress
        {
            get
            {
                return Address;
            }
            set
            {
                Address = value;
            }
        }
        public string PImage
        {
            get
            {
                return Images;
            }
            set
            {
                Images = value;
            }
        }
        public string PMotivation
        {
            get
            {
                return Motivation;
            }
            set
            {
                Motivation = value;
            }
        }
        public string PPriodStart
        {
            get
            {
                return PriodStart;
            }
            set
            {
                PriodStart = value;
            }
        }
        public string PPriodEnd
        {
            get
            {
                return PriodEnd;
            }
            set
            {
                PriodEnd = value;
            }
        }
        public string PDescription
        {
            get
            {
                return Description;
            }
            set
            {
                Description = value;
            }
        }
        public string Psection
        {
            get
            {
                return section;
            }
            set
            {
                section = value;
            }
        }
        public string Pcode
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }
        public string Pid
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Pname
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string PDateOfBirth
        {
            get
            {
                return DateOfbirth;
            }
            set
            {
                DateOfbirth = value;
            }
        }

        public string PSex
        {
            get
            {
                return sex;
            }
            set
            {
                sex = value;
            }
        }

        public string PNature
        {
            get
            {
                return nature;
            }
            set
            {
                nature = value;
            }
        }

        public string PLanguage
        {
            get
            {
                return language;
            }
            set
            {
                language = value;
            }
        }

        public string PNationality
        {
            get
            {
                return Nationality;
            }
            set
            {
                Nationality = value;
            }
        }

        public string PBlood
        {
            get
            {
                return Blood;
            }
            set
            {
                Blood = value;
            }
        }


        public string PPreFix
        {
            get
            {
                return PreFix;
            }
            set
            {
                PreFix = value;
            }
        }
        public string PPostFix
        {
            get
            {
                return PostFix;
            }
            set
            {
                PostFix = value;
            }
        }
        public string PFor
        {
            get
            {
                return For;
            }
            set
            {
                For = value;
            }
        }
        public string PSchoolID
        {
            get
            {
                return SchoolId;
            }
            set
            {
                SchoolId = value;
            }
        }
     



        public string PFState
        {
            get
            {
                return Fstate;
            }
            set
            {
                Fstate = value;
            }
        }
        public string POcupation
        {
            get
            {
                return Ocupation;
            }
            set
            {
                Ocupation = value;
            }
        }
        public string Password { get { return _password; } set { _password = value; } }
        public string UserName { get { return _username; } set { _username = value; } }
        public string oldPassword { get { return _oldPassword; } set { _oldPassword = value; } }
         public string PGroupCode { get { return groupcode; } set { groupcode = value; } }
        public string PGroupName { get { return groupname; } set { groupname = value; } }

        #endregion
    }

    public abstract class conn
    {
        protected SqlConnection con = new SqlConnection();
        public conn()
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["cn1"].ConnectionString;
        }
    }
    public class work : conn
    {//class start
        public DataTable TotalClassI(usprp r)//area insert
        {
            SqlDataAdapter adp = new SqlDataAdapter("spTotalClassI", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@schoolId", r.Pid);
            adp.SelectCommand.Parameters.AddWithValue("@totalClass",r.PTotal );
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public string UpdateClassI(usprp prp)
        {
            string msg = "";

            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SpUpdateClass";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@classcode", prp.Pcode);
            cmd.Parameters.AddWithValue("@classname", prp.Pname);
            cmd.Parameters.AddWithValue("@classsection", prp.Psection);
            cmd.Parameters.AddWithValue("@classid", prp.Pid);
            cmd.Parameters.AddWithValue("@schoolid", prp.PAccount);
            msg = cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            con.Close();



            return msg;
        
        }
        public void DisableClass(usprp prp)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SpclassDisable";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@classid", prp.Pid);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }


        public void DisableRoom(usprp prp)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SpRoomDisable";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Roomid", prp.Pid);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }


        public DataTable BindClassI( prpprofile prp)
        {
            SqlDataAdapter adp = new SqlDataAdapter("SpSelectClass", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@schoolId",prp.Id);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }//class end
        // ------****--period start
        public DataTable TotalPeriod(usprp prp)
        {
            SqlDataAdapter adp = new SqlDataAdapter("spTotalperiod", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@PeriodId", 1);
            adp.SelectCommand.Parameters.AddWithValue("@periodtotal ", prp.Pid);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public DataTable UpdatePeriod(usprp prp)
        {
            SqlDataAdapter adp = new SqlDataAdapter("SpUpdatePeriod", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@PeriodTimeStart", prp.PPriodStart);
            adp.SelectCommand.Parameters.AddWithValue("@PeriodTimeName", prp.Pname);
            adp.SelectCommand.Parameters.AddWithValue("@PeriodTimeEnd", prp.PPriodEnd);
            adp.SelectCommand.Parameters.AddWithValue("@periodTimedescription", prp.PDescription);
            adp.SelectCommand.Parameters.AddWithValue("@Periodtimeid", prp.Pid);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }

        public DataTable BindPeriod()
        {
            SqlDataAdapter adp = new SqlDataAdapter("SpSelectPeriod", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }//Period end
        //periority start
        public void Insertperiority(usprp prp)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spStaffSubjectInsert";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@staffSubjectStaffId", prp.Pname);
            cmd.Parameters.AddWithValue("@staffSubjectSubjectId", prp.PSubject);
            cmd.Parameters.AddWithValue("@staffSubjectSubjectPriority", prp.PDegination);
            cmd.Parameters.AddWithValue("@staffSubjectClassPriority", prp.PClass);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public DataTable Bindpriorityu()
        {
            SqlDataAdapter adp = new SqlDataAdapter("SpShowPriority", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        //-**Room Start
        public DataTable TotalRoom(usprp prp)
        {
            SqlDataAdapter adp = new SqlDataAdapter("spTotalRoom", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@schoolId", prp.Pid);
            adp.SelectCommand.Parameters.AddWithValue("@TotalRoom ", prp.PTotal);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public string UpdateRoom(usprp prp)
        {
            string msg = "";

            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SpUpdateRoom";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@RoomCode", prp.Pcode);
            cmd.Parameters.AddWithValue("@Roomname", prp.Pname);
            cmd.Parameters.AddWithValue("@RoomStudentCapacity", prp.Psection);
            cmd.Parameters.AddWithValue("@roomid", prp.Pid);
            cmd.Parameters.AddWithValue("@schoolId", prp.PMstate);
            msg = cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            con.Close();



            return msg;
        }
        public DataTable BindRoom(prpprofile prp)
        {
            SqlDataAdapter adp = new SqlDataAdapter("SpSelectRoom", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@roomId", prp.Id);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        //rooomEnd
        //Bus Start

        public void Insertbus(usprp prp)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SpInsertBus";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BusNumber", prp.PAccount);
            cmd.Parameters.AddWithValue("@Seat", prp.PNationality);
            cmd.Parameters.AddWithValue("@Driver", prp.Pname);
            cmd.Parameters.AddWithValue("@SubDriver", prp.PNature);
            cmd.Parameters.AddWithValue("@BusSchoolId", prp.Pid);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void Updatebus(usprp prp)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SpUpdateBus";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BusNumber", prp.PAccount);
            cmd.Parameters.AddWithValue("@Seat", prp.PNationality);
            cmd.Parameters.AddWithValue("@Driver", prp.Pname);
            cmd.Parameters.AddWithValue("@SubDriver", prp.PNature);
            cmd.Parameters.AddWithValue("@busid", prp.Pid);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public DataTable BindBus()
        {
            SqlDataAdapter adp = new SqlDataAdapter("SpSelectBus", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public DataTable ShowBus()
        {
            SqlDataAdapter adp = new SqlDataAdapter("spShowBusDetail", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public usprp EditBus(usprp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            //usprp prp = new usprp();
            cmd.Connection = con;
            cmd.CommandText = "spEditBusDetail";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@busid", pr.Pid);
            usprp prp = new usprp();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                 prp.PAccount=dr["BusNumber"].ToString();
               prp.PNationality=dr["Seat"].ToString();
               prp.Pname=dr["Driver"].ToString();
               prp.PNature = dr["SubDriver"].ToString();
               prp.Pid = dr["BusId"].ToString();
            }
            dr.Dispose();
            cmd.Dispose();
            con.Close();
            return prp;
           
        }
        //Bus End
        //BusRoot
        public void Insertbusroot(usprp prp)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spRootInsert";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@RootName", prp.Pname);
            cmd.Parameters.AddWithValue("@Description", prp.PDescription);
            cmd.Parameters.AddWithValue("@RootBusId", prp.PRoll);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void Updatebusroot(usprp prp)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spRootUpdate";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@RootName", prp.Pname);
            cmd.Parameters.AddWithValue("@Description", prp.PDescription);
            cmd.Parameters.AddWithValue("@RootBusId", prp.PRoll);
            cmd.Parameters.AddWithValue("@RootId", prp.Pid);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
       //
        public DataTable ShowBusroot()
        {
            SqlDataAdapter adp = new SqlDataAdapter("spRoot", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public usprp EditBusroot(usprp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            //usprp prp = new usprp();
            cmd.Connection = con;
            cmd.CommandText = "spRootSelect";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@RootId", pr.Pid);
            usprp prp = new usprp();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
               prp.Pname=dr["RootName"].ToString();
                prp.PDescription=dr["Description"].ToString();
                prp.PRoll=dr["RootBusId"].ToString();
                prp.Pid = dr["RootId"].ToString();
            }
            dr.Dispose();
            cmd.Dispose();
            con.Close();
            return prp;

        }
        //School Info start
        public usprp SchoolInfoInsert(usprp prp)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            //usprp prp = new usprp();
            cmd.Connection = con;
            cmd.CommandText = "spSchoolInsert";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SchoolName", prp.Pname);
            cmd.Parameters.AddWithValue("@SchoolMoto", prp.PMotivation);
            cmd.Parameters.AddWithValue("@schoolImage", prp.PImage);
            cmd.Parameters.AddWithValue("@schoolAddress", prp.PAddress);
            cmd.Parameters.AddWithValue("@SchoolCity", prp.PCity);
            cmd.Parameters.AddWithValue("@SchoolState", prp.PState);
            cmd.Parameters.AddWithValue("@SchoolDist", prp.PDist);
            cmd.Parameters.AddWithValue("@SchoolPinCode", prp.Pcode);
            cmd.Parameters.AddWithValue("@SchoolEmail", prp.PEmail);
            cmd.Parameters.AddWithValue("@schoolMobile", prp.PMobile);
            cmd.Parameters.AddWithValue("@schoolPhone", prp.PPhone);
            cmd.Parameters.AddWithValue("@SchoolFax", prp.PFax);
            cmd.Parameters.AddWithValue("@SchoolWeb", prp.PWeb);
            usprp pr = new usprp();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                pr.Pid = dr["SchoolId"].ToString();

            } 
            dr.Dispose();
            cmd.Dispose();
            con.Close();
            return pr;
           
        }
        public DataTable BindSchoolInfo()
        {
            SqlDataAdapter adp = new SqlDataAdapter("SpShowSchoolInff", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            //adp.SelectCommand.Parameters.AddWithValue("@schoolid",);
            DataTable dt = new DataTable();
            adp.Fill(dt);
           
            return dt;
        }
        public usprp EditSchoolInfo(usprp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            //usprp prp = new usprp();
            cmd.Connection = con;
            cmd.CommandText = "SpEditSchoolInff";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SchoolId", pr.Pid);
            usprp prp = new usprp();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                prp.Pid = dr["SchoolId"].ToString();
                prp.Pname = dr["SchoolName"].ToString();
                prp.PMotivation = dr["SchoolMeto"].ToString();
                prp.PImage = dr["schoolImage"].ToString();
                prp.PAddress = dr["schoolAddress"].ToString();
                prp.PCity = dr["SchoolCity"].ToString();
                prp.PState = dr["SchoolState"].ToString();
                prp.PDist = dr["SchoolDistrict"].ToString();
                prp.Pcode = dr["SchoolPinCode"].ToString();
                prp.PEmail = dr["SchoolEmailId"].ToString();
                prp.PMobile = dr["schoolMobNo"].ToString();
                prp.PPhone = dr["schoolPhoneNo"].ToString();
                prp.PFax = dr["SchoolFaxNo"].ToString();
                prp.PWeb = dr["SchoolWebsite"].ToString();


            }
            dr.Dispose();
            cmd.Dispose();
            con.Close();
            return prp;
           
        }
        public void UpdateInfoInsert(usprp prp)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UpdatetblSchool";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SchoolName", prp.Pname);
            cmd.Parameters.AddWithValue("@SchoolMoto", prp.PMotivation);
            cmd.Parameters.AddWithValue("@schoolImage", prp.PImage);
            cmd.Parameters.AddWithValue("@schoolAddress", prp.PAddress);
            cmd.Parameters.AddWithValue("@SchoolCity", prp.PCity);
            cmd.Parameters.AddWithValue("@SchoolState", prp.PState);
            cmd.Parameters.AddWithValue("@SchoolDist", prp.PDist);
            cmd.Parameters.AddWithValue("@SchoolPinCode", prp.Pcode);
            cmd.Parameters.AddWithValue("@SchoolEmail", prp.PEmail);
            cmd.Parameters.AddWithValue("@schoolMobile", prp.PMobile);
            cmd.Parameters.AddWithValue("@schoolPhone", prp.PPhone);
            cmd.Parameters.AddWithValue("@SchoolFax", prp.PFax);
            cmd.Parameters.AddWithValue("@SchoolWeb", prp.PWeb);
            cmd.Parameters.AddWithValue("@Schoolid", prp.Pid);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void DeleteInfoInsert(usprp prp)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            //usprp prp = new usprp();
            cmd.Connection = con;
            cmd.CommandText = "SpDeleteSchoolInfo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Schoolid", prp.Pid);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        //school Info End
        //Deginatin Start
        public string InsertDesination(usprp prp)
        {
            string msg = "";
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SpDesinationInsert";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", prp.Pname);
            cmd.Parameters.AddWithValue("@code", prp.Pcode);
            cmd.Parameters.AddWithValue("@schoolId", prp.Pid);
            
            msg= cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            con.Close();
            return msg;
        }
        public string UpdateDesination(usprp prp)
        {
            string msg = "";
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SpUpdateDesignation";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DesignationName", prp.Pname);
            cmd.Parameters.AddWithValue("@designationCode", prp.Pcode);
            cmd.Parameters.AddWithValue("@tblDesignationId", prp.Pid);
            cmd.Parameters.AddWithValue("@schoolId", prp.PRoll);

            msg = cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            con.Close();

            return msg;
            
        }
        public DataTable DeleteDesination(usprp prp)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SpDeleteDesignation";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DesignationId", prp.Pid);
            cmd.Parameters.AddWithValue("@schoolId", prp.PRoll);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            cmd.Dispose();
            dt.Dispose();
            con.Close();
            return dt;
            
        }
        public DataTable BindDesination(prpprofile prp)
        {
            SqlDataAdapter adp = new SqlDataAdapter("spShowDegination", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@schoolId",prp.Id);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        //Degination End
        //Department start
        
        
        public string InsertDepartment(usprp prp)
        {
            string msg = "";
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SpDeparmentInsert";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", prp.Pname);
            cmd.Parameters.AddWithValue("@code", prp.Pcode);
            cmd.Parameters.AddWithValue("@schoolId", prp.Pid);
             msg = cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            con.Close();
            return msg;
        }





        public string UpdateDepartment(usprp prp)
        {
            string st = "";
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SpUpdatedepartment";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@departmentName", prp.Pname);
            cmd.Parameters.AddWithValue("@departmentCode", prp.Pcode);
            cmd.Parameters.AddWithValue("@departmentId", prp.Pid);
            cmd.Parameters.AddWithValue("@schoolId", prp.PRoll);
            st = cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            con.Close();
            return st;
           
        }
        public DataTable DeleteDepartment(usprp prp)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SpDeletedepartment";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@departmentId", prp.Pid);
            cmd.Parameters.AddWithValue("@schoolID", prp.PRoll);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            cmd.Dispose();
            dt.Dispose();
            con.Close();
            return dt;
            
        }
        public DataTable BindDepartment(prpprofile prp)
        {
            SqlDataAdapter adp = new SqlDataAdapter("spShowDepartment", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@schoolid", prp.Id);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        //department end
        //StaffStart
        public void InsertStaffProfile(usprp prp)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SpInsertStaffProfile";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@profile1stName", prp.Pname);
            cmd.Parameters.AddWithValue("@profileLastName", prp.PLast);
            cmd.Parameters.AddWithValue("@profileDoj", prp.PJoinDate);
            cmd.Parameters.AddWithValue("@profileGender", prp.PSex);
            cmd.Parameters.AddWithValue("@profileMarital", prp.PStatus);
            cmd.Parameters.AddWithValue("@profileImagePath", prp.PImage);
            cmd.Parameters.AddWithValue("@profileAddressLineI", prp.PAddress);
            cmd.Parameters.AddWithValue("@profileCity", prp.PCity);
            cmd.Parameters.AddWithValue("@profileDistrict", prp.PDist);
            cmd.Parameters.AddWithValue("@profileState", prp.PState);
            cmd.Parameters.AddWithValue("@profilePinCode", prp.Pcode);
            cmd.Parameters.AddWithValue("@ProfilePhoneNo", prp.PPhone);
            cmd.Parameters.AddWithValue("@profileMobNo", prp.PMobile);
            cmd.Parameters.AddWithValue("@profileFaxNo", prp.PFax);
            cmd.Parameters.AddWithValue("@ProfileEmailId", prp.PEmail);
            cmd.Parameters.AddWithValue("@profileBloodGroup", prp.PBlood);
            cmd.Parameters.AddWithValue("@ProfileCategory", prp.PCatagary);
            cmd.Parameters.AddWithValue("@profileNationally", prp.PNationality);
            cmd.Parameters.AddWithValue("@profileCaste", prp.PCaste);
            cmd.Parameters.AddWithValue("@profileReligion", prp.PNature);
            cmd.Parameters.AddWithValue("@schoolId", prp.Pid);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public DataTable BindStaffInff(prpprofile prp)
        {
            SqlDataAdapter adp = new SqlDataAdapter("SpShowStaffProff", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@schoolId",prp.Id);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public usprp EditStaffInfo(usprp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            //usprp prp = new usprp();
            cmd.Connection = con;
            cmd.CommandText = "SpEditStaffProff";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@profileId", pr.Pid);
            usprp prp = new usprp();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                prp.Pname = dr["profile1stName"].ToString();
                prp.PLast = dr["profileLastName"].ToString();
                prp.PJoinDate = dr["profileDoj"].ToString();
                prp.PSex = dr["profileGender"].ToString();
                prp.PStatus = dr["profileMarital"].ToString();
                prp.PImage = dr["profileImagePath"].ToString();
                prp.PAddress = dr["profileAddressLineI"].ToString();
                prp.PCity = dr["profileCity"].ToString();
                prp.PDist = dr["profileDistrict"].ToString();
                prp.PState = dr["profileState"].ToString();
                prp.Pcode = dr["profilePinCode"].ToString();
                prp.PPhone = dr["ProfilePhoneNo"].ToString();
                prp.PMobile = dr["profileMobNo"].ToString();
                prp.PFax = dr["profileFaxNo"].ToString();
                prp.PEmail = dr["ProfileEmailId"].ToString();
                prp.PBlood = dr["profileBloodGroup"].ToString();
                prp.PCatagary = dr["ProfileCategory"].ToString();
                prp.PNationality = dr["profileNationally"].ToString();
                prp.PCaste = dr["profileCaste"].ToString();
                prp.PNature = dr["profileReligion"].ToString();
                prp.Pid = dr["profileId"].ToString();
            }
            dr.Dispose();
            cmd.Dispose();
            con.Close();
            return prp;
           
        }
        public void UpdateStaffProfile(usprp prp)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SpUpdateStaffInff";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@profile1stName", prp.Pname);
            cmd.Parameters.AddWithValue("@profileLastName", prp.PLast);
            cmd.Parameters.AddWithValue("@profileDoj", prp.PJoinDate);
            cmd.Parameters.AddWithValue("@profileGender", prp.PSex);
            cmd.Parameters.AddWithValue("@profileMarital", prp.PStatus);
            cmd.Parameters.AddWithValue("@profileImagePath", prp.PImage);
            cmd.Parameters.AddWithValue("@profileAddressLineI", prp.PAddress);
            cmd.Parameters.AddWithValue("@profileCity", prp.PCity);
            cmd.Parameters.AddWithValue("@profileDistrict", prp.PDist);
            cmd.Parameters.AddWithValue("@profileState", prp.PState);
            cmd.Parameters.AddWithValue("@profilePinCode", prp.Pcode);
            cmd.Parameters.AddWithValue("@ProfilePhoneNo", prp.PPhone);
            cmd.Parameters.AddWithValue("@profileMobNo", prp.PMobile);
            cmd.Parameters.AddWithValue("@profileFaxNo", prp.PFax);
            cmd.Parameters.AddWithValue("@ProfileEmailId", prp.PEmail);
            cmd.Parameters.AddWithValue("@profileBloodGroup", prp.PBlood);
            cmd.Parameters.AddWithValue("@ProfileCategory", prp.PCatagary);
            cmd.Parameters.AddWithValue("@profileNationally", prp.PNationality);
            cmd.Parameters.AddWithValue("@profileCaste", prp.PCaste);
            cmd.Parameters.AddWithValue("@profileReligion", prp.PNature);
            cmd.Parameters.AddWithValue("@profileId", prp.Pid);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public DataTable DeleteStaffInfo(usprp prp)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SpDeleteStaffInfo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@profileId", prp.Pid);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            cmd.Dispose();
            dt.Dispose();
            con.Close();
            return dt;
            
        }
        //StaffInfo End
        //staff oldschool
        public void UpdateoldSchool(usprp prp)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spStudentOldClassUpdate";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@oldclassid", prp.Pid);
            cmd.Parameters.AddWithValue("@oldclassName", prp.PClass);
            cmd.Parameters.AddWithValue("@oldClassSession", prp.PStartJone);
            cmd.Parameters.AddWithValue("@oldclassGrade", prp.PQualification);
            cmd.Parameters.AddWithValue("@oldclassClassPassStatus", prp.PStatus);
            cmd.Parameters.AddWithValue("@oldGainMark", prp.Pname);
            cmd.Parameters.AddWithValue("@oldTotalMark", prp.PKnown);
            //cmd.Parameters.AddWithValue("@oldPretention", prp.PPf);
            cmd.Parameters.AddWithValue("@oldSchoolName", prp.PLocation);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void InsertoldSchool(usprp prp)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spStudentOldClassInsert";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@oldClassStudentId", prp.Pid);
            cmd.Parameters.AddWithValue("@oldclassName", prp.PClass);
            cmd.Parameters.AddWithValue("@oldClassSession", prp.PStartJone);
            cmd.Parameters.AddWithValue("@oldclassGrade", prp.PQualification);
            cmd.Parameters.AddWithValue("@oldclassClassPassStatus", prp.PStatus);
            cmd.Parameters.AddWithValue("@oldGainMark", prp.Pname);
            cmd.Parameters.AddWithValue("@oldTotalMark", prp.PKnown);
            //cmd.Parameters.AddWithValue("@oldPretention", prp.PPf);
            cmd.Parameters.AddWithValue("@oldSchoolName", prp.PLocation);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
       }
        public usprp Editoldschool(usprp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            //usprp prp = new usprp();
            cmd.Connection = con;
            cmd.CommandText = "spStudentOldClassSelect";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@oldClassId", pr.Pid);
            usprp prp = new usprp();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                prp.Pid = dr["oldClassId"].ToString();
                prp.PClass=dr["oldclassName"].ToString();
               prp.PStartJone=dr["oldClassSession"].ToString();
                prp.PQualification=dr["oldclassGrade"].ToString();
                prp.PStatus=dr["oldclassClassPassStatus"].ToString();
                prp.Pname=dr["oldGainMark"].ToString();
                prp.PKnown=dr["oldTotalMark"].ToString();
                //cmd.Parameters.AddWithValue("@oldPretention", prp.PPf);
                prp.PLocation = dr["oldSchoolName"].ToString();
                
            }
            dr.Dispose();
            cmd.Dispose();
            con.Close();
            return prp;

        }
        public DataTable BindoldSchool(prpprofile prp)
        {
            SqlDataAdapter adp = new SqlDataAdapter("spStudentOldClass", con);
            adp.SelectCommand.Parameters.AddWithValue("@schoolId",prp.Id);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public DataTable BindStaffJobInff()
        {
            SqlDataAdapter adp = new SqlDataAdapter("SpEditStaffJobInfo", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public usprp EditStaffJobInfo(usprp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            //usprp prp = new usprp();
            cmd.Connection = con;
            cmd.CommandText = "SpeditStaffJobInfo1";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@staffId", pr.Pid);
            usprp prp = new usprp();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();

                prp.Pname = dr["staffProfileId"].ToString();
                prp.PDepartment = dr["staffdepartmentId"].ToString();
                prp.PDegination = dr["staffdesignationId"].ToString();
                prp.PSalary = dr["staffBasicSalary"].ToString();
                prp.PMedicalLeave = dr["staffmedicalleaves"].ToString();
                prp.PExperience = dr["staffExperiences"].ToString();
                prp.PPf = dr["staffPF"].ToString();
                prp.PDA = dr["staffDA"].ToString();
                prp.PTA = dr["staffTA"].ToString();
                prp.PHRA = dr["staffHRA"].ToString();
                prp.POtherAllownce = dr["staffOtherallowncess"].ToString();
                prp.POtherQualification = dr["staffOtherdeduction"].ToString();
                prp.PBusCharge = dr["staffBusCharges"].ToString();
                prp.PCanteenChrge = dr["staffCanteenCharges"].ToString();
                prp.Pcode = dr["staffCode"].ToString();
                prp.PType = dr["staffType"].ToString();
                prp.PQualification = dr["staffQualification"].ToString();
                prp.PPanNo = dr["staffPanNo"].ToString();
                prp.PAccount = dr["staffAcNo"].ToString();
                prp.PCasualLeave = dr["staffcasualleaves"].ToString();
                prp.Pid = dr["staffId"].ToString();
            }
            dr.Dispose();
            cmd.Dispose();
            con.Close();
            return prp;
           
        }
        public void UpdateStaffJobInfo(usprp prp)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SpUpdateStaffJobInfo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@staffId", prp.Pname);
            //cmd.Parameters.AddWithValue("@staffProfileId", prp.Pname);
            cmd.Parameters.AddWithValue("@staffdepartmentId", prp.PDepartment);
            cmd.Parameters.AddWithValue("@staffdesignationId", prp.PDegination);
            cmd.Parameters.AddWithValue("@staffBasicSalary", prp.PSalary);
            cmd.Parameters.AddWithValue("@staffmedicalleaves", prp.PMedicalLeave);
            cmd.Parameters.AddWithValue("@staffExperiences", prp.PExperience);
            cmd.Parameters.AddWithValue("@staffPF", prp.PPf);
            cmd.Parameters.AddWithValue("@staffDA", prp.PDA);
            cmd.Parameters.AddWithValue("@staffTA", prp.PTA);
            cmd.Parameters.AddWithValue("@staffHRA", prp.PHRA);
            cmd.Parameters.AddWithValue("@staffOtherallowncess", prp.POtherAllownce);
            cmd.Parameters.AddWithValue("@staffOtherdeduction", prp.POtherQualification);
            cmd.Parameters.AddWithValue("@staffBusCharges", prp.PBusCharge);
            cmd.Parameters.AddWithValue("@staffCanteenCharges", prp.PCanteenChrge);
            cmd.Parameters.AddWithValue("@staffCode", prp.Pcode);
            cmd.Parameters.AddWithValue("@staffType", prp.PType);
            cmd.Parameters.AddWithValue("@staffQualification", prp.PQualification);
            cmd.Parameters.AddWithValue("@staffPanNo", prp.PPanNo);
            cmd.Parameters.AddWithValue("@staffAcNo", prp.PAccount);
            cmd.Parameters.AddWithValue("@staffcasualleaves", prp.PCasualLeave);
            //cmd.Parameters.AddWithValue("@staffSchoolId", 1);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        //Staff Job Info End
        //Fees type Start
        public void FeesTypeInsert(usprp prp)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            //usprp prp = new usprp();
            cmd.Connection = con;
            cmd.CommandText = "SpInsertfeestype";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@feeTypeName", prp.Pname);
            cmd.Parameters.AddWithValue("@feeTypeSchoolId", prp.Pid);

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
        }
        public usprp EditFeesTypes(usprp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            //usprp prp = new usprp();
            cmd.Connection = con;
            cmd.CommandText = "SpEditFeesType";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@feeTypeId", pr.Pid);
            usprp prp = new usprp();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();

                prp.Pname = dr["feeTypeName"].ToString();
                prp.Pid = dr["feeTypeId"].ToString();

            }
            dr.Dispose();
            con.Close();
            return prp;

            
        }
        public DataTable BindFeesType(prpprofile prp)
        {
            SqlDataAdapter adp = new SqlDataAdapter("SpShowFeesType", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@schoolId",prp.Id);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public void FeesTypeUpdate(usprp prp)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            //usprp prp = new usprp();
            cmd.Connection = con;
            cmd.CommandText = "SpupdateFessType";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@feeTypeName", prp.Pname);
            cmd.Parameters.AddWithValue("@feeTypeId", prp.Pid);

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
        }
        //fees type end
        // Student profile start
        public usprp insertStudentProfile(usprp prp)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SpInsertStudentProfile";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@profileDOB", prp.PDateOfBirth);
            cmd.Parameters.AddWithValue("@profile1stName", prp.Pname);
            cmd.Parameters.AddWithValue("@profileLastName", prp.PLast);
            cmd.Parameters.AddWithValue("@profileKnowAs", prp.PKnown);
            cmd.Parameters.AddWithValue("@profileNature", prp.PNature);
            cmd.Parameters.AddWithValue("@profileGender", prp.PSex);
            cmd.Parameters.AddWithValue("@profileCaste", prp.PCaste);
            cmd.Parameters.AddWithValue("@profileBloodGroup", prp.PBlood);
            cmd.Parameters.AddWithValue("@profileCategory", prp.PCatagary);
            cmd.Parameters.AddWithValue("@profileNationally", prp.PNationality);
            cmd.Parameters.AddWithValue("@profileReligion", prp.PReligious);
            // cmd.Parameters.AddWithValue("@studentClassSubjectId", prp.POtherAllownce);//------------
            cmd.Parameters.AddWithValue("@studentAddmitionDate", prp.PAdmition);
        //    cmd.Parameters.AddWithValue("@StudentRollNo", prp.PRoll);
            //cmd.Parameters.AddWithValue("@StudentAccountNo", prp.PAccount);
          //  cmd.Parameters.AddWithValue("@studentCode", prp.PEnrollment);
            cmd.Parameters.AddWithValue("@Studentclass", prp.PClass);
            cmd.Parameters.AddWithValue("@StudentSubjectGroup", prp.PSubGroup);
            cmd.Parameters.AddWithValue("@StudentMedium", prp.PMedium);
            // cmd.Parameters.AddWithValue("@studentProfileId", prp.PAccount);
            cmd.Parameters.AddWithValue("@StudentSchoolId", prp.Pid);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();

                prp.Pname = dr["profile1stname"].ToString();
                prp.Pid = dr["Studentprofileid"].ToString();

            }
            dr.Dispose();
            cmd.Dispose();
            con.Close();
            return prp;

           

        }
        public DataTable BindStudentProfile(prpprofile prp)
        {
            SqlDataAdapter adp = new SqlDataAdapter("SpShowStudentProfile", con);
            adp.SelectCommand.Parameters.AddWithValue("@schoolId",prp.Id);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            con.Close();
            return dt;
        }

        public usprp EditStudentProfile(usprp prp)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spEditStudentProfile";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@profileid", prp.Pid);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.HasRows)
            {
                dr.Read();
             prp.PDateOfBirth= dr["profileDOB"].ToString();
            prp.Pname= dr["profile1stName"].ToString();
            prp.PLast= dr["profileLastName"].ToString();
             prp.PKnown= dr["profileKnowAs"].ToString();
           prp.PNature= dr["profileNature"].ToString();
             prp.PSex= dr["profileGender"].ToString();
            prp.PCaste= dr["profileCaste"].ToString();
            prp.PBlood= dr["profileBloodGroup"].ToString();
            prp.PCatagary= dr["profileCategory"].ToString();
             prp.PNationality= dr["profileNationally"].ToString();
            prp.PReligious= dr["profileReligion"].ToString();
            // cmd.Parameters.AddWithValue("@studentClassSubjectId", prp.POtherAllownce);//------------
            //-- prp.PAdmition= dr["studentAddmitionDate"].ToString();
            prp.PRoll= dr["StudentRollNo"].ToString();
             prp.PAccount= dr["StudentAccountNo"].ToString();
             prp.PEnrollment= dr["studentCode"].ToString();
             prp.PClass= dr["Studentclass"].ToString();
             prp.PSubGroup= dr["StudentSubjectGroup"].ToString();
             prp.PMedium= dr["StudentMedium"].ToString();
            // cmd.Parameters.AddWithValue("@studentProfileId", prp.PAccount);
             prp.Pid = dr["profileid"].ToString();
            //SqlDataReader dr = cmd.ExecuteReader();
            }
           
            dr.Dispose();
            cmd.Dispose();
            con.Close();
            return prp;
        }

        public void UpdateStudentProfile(usprp prp)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SpUpdateStudentProfile";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@profileDOB", prp.PDateOfBirth);
            cmd.Parameters.AddWithValue("@profile1stName", prp.Pname);
            cmd.Parameters.AddWithValue("@profileLastName", prp.PLast);
            cmd.Parameters.AddWithValue("@profileKnowAs", prp.PKnown);
            cmd.Parameters.AddWithValue("@profileNature", prp.PNature);
            cmd.Parameters.AddWithValue("@profileGender", prp.PSex);
            cmd.Parameters.AddWithValue("@profileCaste", prp.PCaste);
            cmd.Parameters.AddWithValue("@profileBloodGroup", prp.PBlood);
            cmd.Parameters.AddWithValue("@profileCategory", prp.PCatagary);
            cmd.Parameters.AddWithValue("@profileNationally", prp.PNationality);
            cmd.Parameters.AddWithValue("@profileReligion", prp.PReligious);
            // cmd.Parameters.AddWithValue("@studentClassSubjectId", prp.POtherAllownce);//------------
            cmd.Parameters.AddWithValue("@studentAddmitionDate", prp.PAdmition);
            cmd.Parameters.AddWithValue("@StudentRollNo", prp.PRoll);
            cmd.Parameters.AddWithValue("@StudentAccountNo", prp.PAccount);
            cmd.Parameters.AddWithValue("@studentCode", prp.PEnrollment);
            cmd.Parameters.AddWithValue("@Studentclass", prp.PClass);
            cmd.Parameters.AddWithValue("@StudentSubjectGroup", prp.PSubGroup);
            cmd.Parameters.AddWithValue("@StudentMedium", prp.PMedium);
            // cmd.Parameters.AddWithValue("@studentProfileId", prp.PAccount);
            cmd.Parameters.AddWithValue("@studentprofileid", prp.Pid);
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
        }
        //Subject Group Start
        public void insertSubjectGroup(usprp prp)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SPInsertSubjectgroup";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@subjectGroupCode", prp.Pcode);
            cmd.Parameters.AddWithValue("@subjectGroupName", prp.Pname);
            cmd.Parameters.AddWithValue("@subjectGroupDescription", prp.PDescription);
            cmd.Parameters.AddWithValue("@subjectGroupSchoolId", prp.Pid);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public DataTable BindSubjectGroup(prpprofile prp)
        {
            SqlDataAdapter adp = new SqlDataAdapter("SpShowSubjectgroup", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@schoolId", prp.Id);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public usprp EditSubjectGroup(usprp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            //usprp prp = new usprp();
            cmd.Connection = con;
            cmd.CommandText = "SpEditSubjectgroup";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@subjectGroupId", pr.Pid);
            usprp prp = new usprp();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();

                prp.Pname = dr["subjectGroupName"].ToString();
                prp.Pcode = dr["subjectGroupCode"].ToString();
                prp.PDescription = dr["subjectGroupDescription"].ToString();
                prp.Pid = dr["subjectGroupId"].ToString();

            }
            dr.Dispose();
            con.Close();
            return prp;

            
        }
        public void UpdateSubjectGroup(usprp prp)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SpUpdateSubjectgroup";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@subjectGroupCode", prp.Pcode);
            cmd.Parameters.AddWithValue("@subjectGroupName", prp.Pname);
            cmd.Parameters.AddWithValue("@subjectGroupDescription", prp.PDescription);
            cmd.Parameters.AddWithValue("@subjectGroupId", prp.Pid);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        //end subject group
        // Subject insert start
        public void insertSubject(usprp prp)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SpInsertSubject";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@subjectCode", prp.Pcode);
            cmd.Parameters.AddWithValue("@subjectName", prp.Pname);
            cmd.Parameters.AddWithValue("@subjectDescription", prp.PDescription);
            cmd.Parameters.AddWithValue("@subjectSchoolId", prp.Pid);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public DataTable BindSubject( prpprofile prp)
        {
            SqlDataAdapter adp = new SqlDataAdapter("SpShowSubject", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@schoolId",prp.Id);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }

        public void UpdateSubject(usprp prp)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SpUpdateSubject";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@subjectCode", prp.Pcode);
            cmd.Parameters.AddWithValue("@subjectName", prp.Pname);
            cmd.Parameters.AddWithValue("@subjectDescription", prp.PDescription);
            cmd.Parameters.AddWithValue("@subjectId", prp.Pid);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        public usprp EditSubject(usprp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            //usprp prp = new usprp();
            cmd.Connection = con;
            cmd.CommandText = "SpEditSubject";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@subjectId", pr.Pid);
            usprp prp = new usprp();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();

                prp.Pname = dr["subjectName"].ToString();
                prp.Pcode = dr["subjectCode"].ToString();
                prp.PDescription = dr["subjectDescription"].ToString();
                prp.Pid = dr["subjectId"].ToString();

            }
            dr.Dispose();
            con.Close();
            return prp;

           
        }
        //subject insert end
        //tbl RelSubjectGroupandClass.aspx  start
        public void InsertRelSubjectGroupandClass(usprp prp)
        {

            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SpInsertRelSubjectGroupandClass";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sbjGrpClsClassId", prp.PClass);
            cmd.Parameters.AddWithValue("@sbjGrpClsSujectGroupId ", prp.PSubGroup);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public DataTable BindRelSubjectGroupandClass()
        {
            SqlDataAdapter adp = new SqlDataAdapter("SpShowRelSubjectGroupandClass", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public usprp EditRelSubjectGroupandClass(usprp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            //usprp prp = new usprp();
            cmd.Connection = con;
            cmd.CommandText = "SpEditRelSubjectGroupandClass";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sbjGrpClsId", pr.Pid);
            usprp prp = new usprp();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();

                prp.PClass = dr["sbjGrpClsClassId"].ToString();
                prp.PSubGroup = dr["sbjGrpClsSujectGroupId"].ToString();
                prp.Pid = dr["sbjGrpClsId"].ToString();

            }
            dr.Dispose();
            con.Close();
            return prp;
        }
        public void UpdateRelSubjectGroupandClass(usprp prp)
        {

            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SpUpdateRelSubjectGroupandClass";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sbjGrpClsClassId", prp.PClass);
            cmd.Parameters.AddWithValue("@sbjGrpClsSujectGroupId", prp.PSubGroup);
            cmd.Parameters.AddWithValue("@sbjGrpClsId", prp.Pid);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }//RelSubjectGroupandClass End
        //ChooseSubjectWithStream.aspx start
        public string InsertChooseSubjectWithStream(usprp prp)
        {
            string msg = "";
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SpInsertClassSubject";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@classSubjectSbjGrpClsId", prp.PSubGroup);
            cmd.Parameters.AddWithValue("@classSubjectSubjectId", prp.PSubject);
            msg = cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            con.Close();
            return msg;


        }
        public DataTable BindChooseSubjectWithStream(prpprofile prp)
        {
            SqlDataAdapter adp = new SqlDataAdapter("SpShowClassSubject", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@schoolId",prp.Id);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public usprp EditChooseSubjectWithStream(usprp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            //usprp prp = new usprp();
            cmd.Connection = con;
            cmd.CommandText = "SpEditClassSubject";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@classSubjectId", pr.Pid);
            usprp prp = new usprp();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();

                prp.PSubject = dr["classSubjectSubjectId"].ToString();
                prp.PSubGroup = dr["classSubjectSbjGrpClsId"].ToString();

                prp.Pid = dr["classSubjectId"].ToString();

            }
            dr.Dispose();
            con.Close();
            return prp;

          
        }
        public string UpdateChooseSubjectWithStream(usprp prp)
        {
            string msg = "";
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SpUpdateClassSubject";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@classSubjectSbjGrpClsId", prp.PSubGroup);
            cmd.Parameters.AddWithValue("@classSubjectSubjectId", prp.PSubject);
            cmd.Parameters.AddWithValue("@classSubjectId", prp.Pid);
            msg =cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            con.Close();

            return msg;
        }//end ChooseSubjectWithStream
        //Fees duration starat
        public void InsertFeesDuration(usprp prp)
        {

            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SpinsertFeesDuration";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@durationMonth", prp.PDuration);
            cmd.Parameters.AddWithValue("@durationName", prp.Pname);
            cmd.Parameters.AddWithValue("@durationSchoolId", prp.Pid);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public DataTable BindFeesDuration(prpprofile prp)
        {
            SqlDataAdapter adp = new SqlDataAdapter("SpShowFeesDuration", con);
            adp.SelectCommand.Parameters.AddWithValue("@schoolId", prp.Id);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public usprp EditFeesDuration(usprp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            //usprp prp = new usprp();
            cmd.Connection = con;
            cmd.CommandText = "SpEditFeesDuration";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@durationId", pr.Pid);
            usprp prp = new usprp();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                prp.PDuration = dr["durationMonth"].ToString();
                prp.Pname = dr["durationName"].ToString();
                prp.Pid = dr["durationId"].ToString();

            }
            dr.Dispose();
            con.Close();
            return prp;

            
        }
        public void UpdateFeesDuration(usprp prp)
        {

            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SpUpdateFeesDuration";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@durationMonth", prp.PDuration);
            cmd.Parameters.AddWithValue("@durationName", prp.Pname);
            cmd.Parameters.AddWithValue("@durationId", prp.Pid);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        //End Duration
        //tblfee start
        public void InsertFees(usprp prp)
        {

            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spinsertFee";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@feeName", prp.Pname);
            cmd.Parameters.AddWithValue("@feeAmount", prp.PAmount);
            cmd.Parameters.AddWithValue("@feeSchoolId", prp.Pid);
            cmd.Parameters.AddWithValue("@feeTypeId", prp.PType);
            cmd.Parameters.AddWithValue("@feeDurationId", prp.PDuration);
            cmd.Parameters.AddWithValue("@feeStartDay", prp.PStartDat);
            cmd.Parameters.AddWithValue("@feeEndDay", prp.PEndDate);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public DataTable BindFees(prpprofile prp)
        {
            SqlDataAdapter adp = new SqlDataAdapter("spShowfees", con);
            adp.SelectCommand.Parameters.AddWithValue("@schoolid", prp.Id);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public usprp EditFees(usprp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            //usprp prp = new usprp();
            cmd.Connection = con;
            cmd.CommandText = "spEditfees";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@feeId", pr.Pid);
            usprp prp = new usprp();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                prp.Pname = dr["feeName"].ToString();
                prp.PAmount = dr["feeAmount"].ToString();
                prp.PDuration = dr["feeDurationId"].ToString();
                prp.PStartDat = dr["feeStartDay"].ToString();
                prp.PEndDate = dr["feeEndDay"].ToString();
                prp.Pid = dr["feeId"].ToString();
                prp.PType = dr["feeTypeId"].ToString();
            }

            dr.Dispose();
            con.Close();
            return prp;

        }
        public void UpdateFees(usprp prp)
        {

            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spUpdateFee";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@feeName", prp.Pname);
            cmd.Parameters.AddWithValue("@feeAmount", prp.PAmount);
            cmd.Parameters.AddWithValue("@feeId", prp.Pid);
            cmd.Parameters.AddWithValue("@feeTypeId", prp.PType);
            cmd.Parameters.AddWithValue("@feeDurationId", prp.PDuration);
            cmd.Parameters.AddWithValue("@feeStartDay", prp.PStartDat);
            cmd.Parameters.AddWithValue("@feeEndDay", prp.PEndDate);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        //Fees End
        // Statrt tblClassFee
        public void InsertClassFee(usprp prp)
        {

            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SpInsertClassFee";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@classFeeClassId", prp.PClass);

            cmd.Parameters.AddWithValue("@classFeeFeeId", prp.Pid);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public DataTable BindClassFee(prpprofile prp)
        {
            SqlDataAdapter adp = new SqlDataAdapter("SpShowClassFee", con);
            adp.SelectCommand.Parameters.AddWithValue("@schoolid", prp.Id);
            adp.SelectCommand.Parameters.AddWithValue("@classId", prp.Code);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }

        public List<usprp> EditClassFee(usprp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            //usprp prp = new usprp();
            cmd.Connection = con;
            cmd.CommandText = "SpEditClassFee";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@classFeeId", pr.Pid);
            List<usprp> lst = new List<usprp>();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    usprp prp = new usprp();
                    prp.PClass = dr["classFeeClassId"].ToString();
                    prp.PFees = dr["classFeeFeeId"].ToString();

                    prp.Pid = dr["classFeeId"].ToString();
                    lst.Add(prp);
                }
            }

            dr.Dispose();
            con.Close();
            return lst;

        }
        public void UpdateClassFee(usprp prp)
        {

            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SpUpdateClassFee";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@classFeeClassId", prp.PClass);
            cmd.Parameters.AddWithValue("@classFeeFeeId", prp.PFees);
            cmd.Parameters.AddWithValue("@classFeeId", prp.Pid);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }//Class Fees End
        //ExamType Start
        public void InsertExamType(usprp prp)
        {

            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SpInsertExameType";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@examTypeSchoolId", prp.Pid);

            cmd.Parameters.AddWithValue("@examTypeName", prp.Pname);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public DataTable BindExamType(prpprofile prp)
        {
            SqlDataAdapter adp = new SqlDataAdapter("SpShowExameType", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@schoolId", prp.Id);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public usprp EditExamType(usprp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SpEditExameType";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@examTypeId", pr.Pid);
            usprp prp = new usprp();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                prp.Pname = dr["examTypeName"].ToString();
                prp.Pid = dr["examTypeId"].ToString();

            }
            dr.Dispose();
            con.Close();
            return prp;

           
        }
        public void UpdateExamType(usprp prp)
        {

            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SpUpdateExameType";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@examTypeId", prp.Pid);

            cmd.Parameters.AddWithValue("@examTypeName", prp.Pname);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }//end
        //Grade Insert SpInsertExamGrade
        public void InsertGrade(usprp prp)
        {

            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SpInsertExamGrade";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@examGradeSchoolId", prp.Pid);
            cmd.Parameters.AddWithValue("@examGradeMaxPer", prp.PMax);
            cmd.Parameters.AddWithValue("@examGradeMinPer", prp.PMin);
            cmd.Parameters.AddWithValue("@examGradeName", prp.Pname);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public DataTable BindGrade(prpprofile prp)
        {
            SqlDataAdapter adp = new SqlDataAdapter("SpShowExamGrade", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@schoolId",prp.Id);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public void UpdateGrade(usprp prp)
        {

            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SpUpdateExamGrade";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@examGradeId", prp.Pid);
            cmd.Parameters.AddWithValue("@examGradeMaxPer", prp.PMax);
            cmd.Parameters.AddWithValue("@examGradeMinPer", prp.PMin);
            cmd.Parameters.AddWithValue("@examGradeName", prp.Pname);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public usprp EditGrade(usprp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SpEditExamGrade";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@examGradeId", pr.Pid);
            usprp prp = new usprp();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                prp.Pname = dr["examGradeName"].ToString();
                prp.PMax = dr["examGradeMaxPer"].ToString();
                prp.PMin = dr["examGradeMinPer"].ToString();
                prp.Pid = dr["examGradeId"].ToString();

            }
            dr.Dispose();
            con.Close();
            return prp;

           
        }//End
        //ExamCreate start
        public void InsertExamCreate(usprp prp)
        {

            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spExamCreateInsert";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@examGradeSchoolId", prp.Pid);
            cmd.Parameters.AddWithValue("@examCreateClass", prp.PClass);
            cmd.Parameters.AddWithValue("@examCreateType", prp.PType);
            cmd.Parameters.AddWithValue("@examCreateSubjectId", prp.PSubject);
            cmd.Parameters.AddWithValue("@examCreateTotalMark", prp.PTotal);
            cmd.Parameters.AddWithValue("@examCreatePassMark", prp.PMin);
            cmd.Parameters.AddWithValue("@examCreateDuration", prp.PDuration);
            cmd.Parameters.AddWithValue("@examDate", prp.PStartDat);
            cmd.Parameters.AddWithValue("@examStartTime", prp.PStartTime);
            cmd.Parameters.AddWithValue("@examEndTime", prp.PEndTime);
            cmd.Parameters.AddWithValue("@examDutyStaff", prp.PExaminar);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public DataTable BindExamCreate()
        {
            SqlDataAdapter adp = new SqlDataAdapter("spExamCreate", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public usprp EditExamCreate(usprp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spExamCreateSelect";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@examCreateId", pr.Pid);
            usprp prp = new usprp();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                prp.PClass = dr["examCreateClass"].ToString();
                //prp.PMax = dr["examGradeMaxPer"].ToString();
                prp.PType = dr["examCreateType"].ToString();
                prp.PSubject = dr["examCreateSubjectId"].ToString();
                prp.PTotal = dr["examCreateTotalMark"].ToString();
                prp.PMin = dr["examCreatePassMark"].ToString();
                prp.PDuration = dr["examCreateDuration"].ToString();
                prp.PStartDat = dr["examDate"].ToString();
                prp.PStartTime = dr["Starthour"].ToString();
                prp.PEndTime = dr["Endhour"].ToString();
                prp.PExaminar = dr["examDutyStaff"].ToString();
                prp.Pid = dr["examCreateId"].ToString();
                prp.PStartMin = dr["StartMins"].ToString();
                prp.PEndMin = dr["EndMins"].ToString();
                prp.PStartJone = dr["Startjone"].ToString();
                prp.PEndJone = dr["Endjone"].ToString();
            }
            dr.Dispose();
            con.Close();
            return prp;
            
        }
        public void UpdateExamCreate(usprp prp)
        {

            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spExamCreateUpdate";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@examCreateId", prp.Pid);
            cmd.Parameters.AddWithValue("@examCreateClass", prp.PClass);
            cmd.Parameters.AddWithValue("@examCreateType", prp.PType);
            cmd.Parameters.AddWithValue("@examCreateSubjectId", prp.PSubject);
            cmd.Parameters.AddWithValue("@examCreateTotalMark", prp.PTotal);
            cmd.Parameters.AddWithValue("@examCreatePassMark", prp.PMin);
            cmd.Parameters.AddWithValue("@examCreateDuration", prp.PDuration);
            cmd.Parameters.AddWithValue("@examDate", prp.PStartDat);
            cmd.Parameters.AddWithValue("@examStartTime", prp.PStartTime);
            cmd.Parameters.AddWithValue("@examEndTime", prp.PEndTime);
            cmd.Parameters.AddWithValue("@examDutyStaff", prp.PExaminar);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        //end
        //Start LeaveType
        public void InsertLeaveType(usprp prp)
        {

            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "speaveTypeInsert";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@leaveTypeSchoolId", prp.Pid);

            cmd.Parameters.AddWithValue("@leaveTypeName", prp.Pname);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public DataTable BindLeaveType(prpprofile prp)
        {
            SqlDataAdapter adp = new SqlDataAdapter("speaveType", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@schoolId",prp.Id);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public usprp EditLeaveType(usprp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "speaveTypeSelect";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@leaveTypeId ", pr.Pid);
            usprp prp = new usprp();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                prp.Pname = dr["leaveTypeName"].ToString();
                prp.Pid = dr["leaveTypeId"].ToString();

            }
            dr.Dispose();
            con.Close();
            return prp;

           
        }
        public void UpdateLeaveType(usprp prp)
        {

            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "speaveTypeUpdate";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@leaveTypeId", prp.Pid);

            cmd.Parameters.AddWithValue("@leaveTypeName", prp.Pname);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }//end
        //Leave Start
        public void InsertLeave(usprp prp)
        {

            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spStaffLeaveInsert";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StaffLeaveStaffId", prp.Pname);
            cmd.Parameters.AddWithValue("@StaffLeaveeaveId", prp.PLeave);
            cmd.Parameters.AddWithValue("@StaffLeaveFrom", prp.PStartDat);
            cmd.Parameters.AddWithValue("@StaffLeaveEnd", prp.PEndDate);
            cmd.Parameters.AddWithValue("@StaffLeaveAskDate", prp.PReason);
            cmd.Parameters.AddWithValue("@StaffLeaveApprovelType", prp.PAproved);
            cmd.Parameters.AddWithValue("@StaffLeaveType", prp.PType);
            cmd.Parameters.AddWithValue("@staffLeaveLocation", prp.PLocation);
            cmd.Parameters.AddWithValue("@staffLeaveContactNo", prp.PMobile);
            
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public DataTable BindStaffleave()
        {
            SqlDataAdapter adp = new SqlDataAdapter("spShowLeavedStaff", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        //End
        //Stock type Start
        public void InsertStockType(usprp prp)
        {

            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spstockCatagaryInsert";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CatSchoolId", prp.Pid);

            cmd.Parameters.AddWithValue("@CatName", prp.Pname);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public DataTable BindStockType()
        {
            SqlDataAdapter adp = new SqlDataAdapter("spstockCatagary", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public usprp EditStockType(usprp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spstockCatagarySelect";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CatId ", pr.Pid);
            usprp prp = new usprp();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                prp.Pname = dr["CatName"].ToString();
               prp.Pid= dr["CatId"].ToString();

            }

            dr.Dispose();
            con.Close();
            return prp;

        }
        public void UpdateStockType(usprp prp)
        {

            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spstockCatagaryUpdate";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CatId", prp.Pid);

            cmd.Parameters.AddWithValue("@CatName", prp.Pname);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        //End
        //Start Product
        public void InsertProduct(usprp prp)
        {

            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spStockProductInsert";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ProductCatid", prp.PCatagary);
            cmd.Parameters.AddWithValue("@ProductName", prp.Pname);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public DataTable BindProduct()
        {
            SqlDataAdapter adp = new SqlDataAdapter("spStockProduct", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public usprp EditProduct(usprp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spStockProductSelect";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Productid ", pr.Pid);
            usprp prp = new usprp();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                prp.Pname = dr["ProductName"].ToString();
                prp.Pid = dr["Productid"].ToString();
                prp.PCatagary = dr["ProductCatid"].ToString();

            }
            dr.Dispose();
            con.Close();
            return prp;

            
        }
        public void UpdateProduct(usprp prp)
        {

            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spStockProductUpdate";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Productid", prp.Pid);
            cmd.Parameters.AddWithValue("@ProductCatid", prp.PCatagary);
            cmd.Parameters.AddWithValue("@ProductName", prp.Pname);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        //End
        //Order insert Start
        public void InsertOrder(usprp prp)
        {

            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spStockOrderInsert";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@OrderProductId", prp.Pname);
            cmd.Parameters.AddWithValue("@OrderProductNumber", prp.Pcode);
            cmd.Parameters.AddWithValue("@OrderProductUnit", prp.PType);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            
        }
        public DataTable BindOrder()
        {
            SqlDataAdapter adp = new SqlDataAdapter("spStockOrder", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public usprp EditOrder(usprp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spStockOrderSelect";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@OrderId ", pr.Pid);
            usprp prp = new usprp();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                prp.Pname = dr["OrderProductId"].ToString();
                prp.Pcode = dr["OrderProductNumber"].ToString();
                prp.PType = dr["OrderProductUnit"].ToString();
                prp.Pid = dr["OrderId"].ToString();

            }
            dr.Dispose();
            con.Close();
            return prp;

           
        }
        public void UpdateOrder(usprp prp)
        {

            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spStockProductUpdate";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@OrderProductId", prp.Pname);
            cmd.Parameters.AddWithValue("@OrderProductNumber", prp.Pcode);
            cmd.Parameters.AddWithValue("@OrderProductUnit", prp.PType);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        //End 
        //Student Adress info start
        public void UpdateStudentAddressInfo(usprp prp)
        {

            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SpUpdateFatherProfile";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fprofileid", prp.PNationality);
            cmd.Parameters.AddWithValue("@mprofileid", prp.POtherAllownce);
            cmd.Parameters.AddWithValue("@fprofile1stName", prp.PFname);
            cmd.Parameters.AddWithValue("@fprofileEmailId", prp.PFEmail);
            cmd.Parameters.AddWithValue("@fprofileOccupation", prp.PFOcupation);
            cmd.Parameters.AddWithValue("@fprofileDistrict", prp.PFDist);
            cmd.Parameters.AddWithValue("@fprofileState", prp.PFstate);
            cmd.Parameters.AddWithValue("@fprofilePinCode", prp.PFcode);
            cmd.Parameters.AddWithValue("@fprofilePhoneNo", prp.PFPhone);
            cmd.Parameters.AddWithValue("@fprofileMobNo", prp.PFMobile);
            cmd.Parameters.AddWithValue("@fprofileFaxNo", prp.PFFax);
            cmd.Parameters.AddWithValue("@fprofileImagePath", prp.PFImage);
            cmd.Parameters.AddWithValue("@fprofileAddressLineI", prp.PFAddress);
            cmd.Parameters.AddWithValue("@fprofileCity", prp.PFCity);//father
            cmd.Parameters.AddWithValue("@mprofile1stName", prp.PMname);
            cmd.Parameters.AddWithValue("@mprofileEmailId", prp.PMEmail);
            cmd.Parameters.AddWithValue("@mprofileOccupation", prp.PMOcupation);
            cmd.Parameters.AddWithValue("@mprofileDistrict", prp.PMDist);
            cmd.Parameters.AddWithValue("@mprofileState", prp.PMstate);
            cmd.Parameters.AddWithValue("@mprofilePinCode", prp.PMcode);
            cmd.Parameters.AddWithValue("@mprofilePhoneNo", prp.PMPhone);
            cmd.Parameters.AddWithValue("@mprofileMobNo", prp.PMMobile);
            cmd.Parameters.AddWithValue("@mprofileFaxNo", prp.PMFax);
            cmd.Parameters.AddWithValue("@mprofileImagePath", prp.PMImage);
            cmd.Parameters.AddWithValue("@mprofileAddressLineI", prp.PMAddress);
            cmd.Parameters.AddWithValue("@mprofileCity", prp.PMCity);//mother
            cmd.Parameters.AddWithValue("@profileEmailId", prp.PEmail);
            cmd.Parameters.AddWithValue("@profileOccupation", prp.POcupation);
            cmd.Parameters.AddWithValue("@profileDistrict", prp.PDist);
            cmd.Parameters.AddWithValue("@profileState", prp.PState);
            cmd.Parameters.AddWithValue("@profilePinCode", prp.Pcode);
            cmd.Parameters.AddWithValue("@profilePhoneNo", prp.PPhone);
            cmd.Parameters.AddWithValue("@profileMobNo", prp.PMobile);
            cmd.Parameters.AddWithValue("@profileFaxNo", prp.PFax);
            cmd.Parameters.AddWithValue("@profileImagePath", prp.PImage);
            cmd.Parameters.AddWithValue("@profileAddressLineI", prp.PAddress);
            cmd.Parameters.AddWithValue("@profileCity", prp.PCity);
            cmd.Parameters.AddWithValue("@profileid", prp.Pid);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }
        public void InsertStudentAddressInfo(usprp prp)
        {

            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SpInsertFatherProfile";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fprofile1stName", prp.PFname);
            cmd.Parameters.AddWithValue("@fprofileEmailId", prp.PFEmail);
            cmd.Parameters.AddWithValue("@fprofileOccupation", prp.PFOcupation);
            cmd.Parameters.AddWithValue("@fprofileDistrict", prp.PFDist);
            cmd.Parameters.AddWithValue("@fprofileState", prp.PFstate);
            cmd.Parameters.AddWithValue("@fprofilePinCode", prp.PFcode);
            cmd.Parameters.AddWithValue("@fprofilePhoneNo", prp.PFPhone);
            cmd.Parameters.AddWithValue("@fprofileMobNo", prp.PFMobile);
            cmd.Parameters.AddWithValue("@fprofileFaxNo", prp.PFFax);
            cmd.Parameters.AddWithValue("@fprofileImagePath", prp.PFImage);
            cmd.Parameters.AddWithValue("@fprofileAddressLineI", prp.PFAddress);
            cmd.Parameters.AddWithValue("@fprofileCity", prp.PFCity);//father
            cmd.Parameters.AddWithValue("@mprofile1stName", prp.PMname);
            cmd.Parameters.AddWithValue("@mprofileEmailId", prp.PMEmail);
            cmd.Parameters.AddWithValue("@mprofileOccupation", prp.PMOcupation);
            cmd.Parameters.AddWithValue("@mprofileDistrict", prp.PMDist);
            cmd.Parameters.AddWithValue("@mprofileState", prp.PMstate);
            cmd.Parameters.AddWithValue("@mprofilePinCode", prp.PMcode);
            cmd.Parameters.AddWithValue("@mprofilePhoneNo", prp.PMPhone);
            cmd.Parameters.AddWithValue("@mprofileMobNo", prp.PMMobile);
            cmd.Parameters.AddWithValue("@mprofileFaxNo", prp.PMFax);
            cmd.Parameters.AddWithValue("@mprofileImagePath", prp.PMImage);
            cmd.Parameters.AddWithValue("@mprofileAddressLineI", prp.PMAddress);
            cmd.Parameters.AddWithValue("@mprofileCity", prp.PMCity);//mother
            cmd.Parameters.AddWithValue("@profileEmailId", prp.PEmail);
            cmd.Parameters.AddWithValue("@profileOccupation", prp.POcupation);
            cmd.Parameters.AddWithValue("@profileDistrict", prp.PDist);
            cmd.Parameters.AddWithValue("@profileState", prp.PState);
            cmd.Parameters.AddWithValue("@profilePinCode", prp.Pcode);
            cmd.Parameters.AddWithValue("@profilePhoneNo", prp.PPhone);
            cmd.Parameters.AddWithValue("@profileMobNo", prp.PMobile);
            cmd.Parameters.AddWithValue("@profileFaxNo", prp.PFax);
            cmd.Parameters.AddWithValue("@profileImagePath", prp.PImage);
            cmd.Parameters.AddWithValue("@profileAddressLineI", prp.PAddress);
            cmd.Parameters.AddWithValue("@profileCity", prp.PCity);
            cmd.Parameters.AddWithValue("@profileid", prp.Pid);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }
        public usprp StudentAddressInfoEdit(usprp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SpEditFatherProfile";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@studentprofileid", pr.Pid);
            usprp prp = new usprp();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                //prp.Pname = dr["OrderProductId"].ToString();
                 prp.PFname= dr["fathername"].ToString();
                 prp.PFEmail= dr["fatheremailid"].ToString();
                prp.PFOcupation= dr["fatherOcupation"].ToString();
                 prp.PFDist= dr["fatherDistrict"].ToString();
                prp.PFstate= dr["fatherState"].ToString();
                prp.PFcode= dr["fatherpincode"].ToString();
                prp.PFPhone= dr["fatherPhone"].ToString();
                prp.PFMobile= dr["fatherMobNo"].ToString();
                prp.PFFax= dr["fatherFaxNo"].ToString();
                 prp.PFImage= dr["fatherImage"].ToString();
                prp.PFAddress= dr["fatherAddress"].ToString();
                 prp.PFCity= dr["fatherCity"].ToString();//father
                prp.PMname= dr["motherName"].ToString();
                prp.PMEmail= dr["motherEmailId"].ToString();
                 prp.PMOcupation= dr["motherOcupation"].ToString();
                 prp.PMDist= dr["motherDistrict"].ToString();
                prp.PMstate= dr["MotherState"].ToString();
                prp.PMcode= dr["motherPincode"].ToString();
                prp.PMPhone= dr["motherPhone"].ToString();
                prp.PMMobile= dr["motherMobno"].ToString();
                prp.PMFax= dr["motherfaxno"].ToString();
                prp.PMImage= dr["motherImage"].ToString();
                 prp.PMAddress= dr["motherAddress"].ToString();
                prp.PMCity= dr["motherCity"].ToString();//mother
                prp.PEmail= dr["profileimagepath"].ToString();
                 prp.POcupation= dr["profileocupation"].ToString();
                prp.PDist= dr["profiledistrict"].ToString();
               prp.PState= dr["profilestate"].ToString();
                 prp.Pcode= dr["profilePinCode"].ToString();
              prp.PPhone= dr["Profilephoneno"].ToString();
                 prp.PMobile= dr["profilemobno"].ToString();
                 prp.PFax= dr["profilefaxno"].ToString();
                 prp.PImage = dr["profileimagepath"].ToString();
                 prp.PAddress= dr["profileAddress"].ToString();
                 prp.PCity= dr["profileCity"].ToString();
                 prp.Pname= dr["profilename"].ToString();
               prp.Pid= dr["profileid"].ToString();
               prp.PNationality = dr["fatherid"].ToString();
                prp.POtherAllownce = dr["matherprofileid"].ToString();

         }
            dr.Dispose();
            con.Close();
            return prp;

            
        }
        public DataTable BindStudentAddressInfo(prpprofile prp)
        {
            SqlDataAdapter adp = new SqlDataAdapter("SpShowFatherProfile", con);
            adp.SelectCommand.Parameters.AddWithValue("@schoolId", prp.Id);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        //end student
       // Sesson start
        //public void Insertseson(usprp prp)
        //{

        //    if (con.State == ConnectionState.Closed)
        //        con.Open();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = con;
        //    cmd.CommandText = "spStockProductInsert";
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@ProductCatid", prp.PCatagary);
        //    cmd.Parameters.AddWithValue("@ProductName", prp.Pname);
        //    cmd.ExecuteNonQuery();
        //    cmd.Dispose();
        //    con.Close();
        //}
        //public DataTable BindProduct()
        //{
        //    SqlDataAdapter adp = new SqlDataAdapter("spStockProduct", con);
        //    adp.SelectCommand.CommandType = CommandType.StoredProcedure;
        //    DataTable dt = new DataTable();
        //    adp.Fill(dt);
        //    return dt;
        //}
        //public usprp EditProduct(usprp pr)
        //{
        //    if (con.State == ConnectionState.Closed)
        //        con.Open();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = con;
        //    cmd.CommandText = "spStockProductSelect";
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@Productid ", pr.Pid);
        //    usprp prp = new usprp();
        //    SqlDataReader dr = cmd.ExecuteReader();

        //    if (dr.HasRows)
        //    {
        //        dr.Read();
        //        prp.Pname = dr["ProductName"].ToString();
        //        prp.Pid = dr["Productid"].ToString();
        //        prp.PCatagary = dr["ProductCatid"].ToString();

        //    }
        //    return prp;

        //    dr.Dispose();
        //    con.Close();
        //}
        //public void UpdateProduct(usprp prp)
        //{

        //    if (con.State == ConnectionState.Closed)
        //        con.Open();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = con;
        //    cmd.CommandText = "spStockProductUpdate";
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@Productid", prp.Pid);
        //    cmd.Parameters.AddWithValue("@ProductCatid", prp.PCatagary);
        //    cmd.Parameters.AddWithValue("@ProductName", prp.Pname);
        //    cmd.ExecuteNonQuery();
        //    cmd.Dispose();
        //    con.Close();
        //}
        //End
        //Order insert Start
        //public void InsertOrder(usprp prp)
        //{

        //    if (con.State == ConnectionState.Closed)
        //        con.Open();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = con;
        //    cmd.CommandText = "spStockOrderInsert";
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@OrderProductId", prp.Pname);
        //    cmd.Parameters.AddWithValue("@OrderProductNumber", prp.Pcode);
        //    cmd.Parameters.AddWithValue("@OrderProductUnit", prp.PType);
        //    cmd.ExecuteNonQuery();
        //    cmd.Dispose();
        //    con.Close();
            
        //}
        //public DataTable BindOrder()
        //{
        //    SqlDataAdapter adp = new SqlDataAdapter("spStockOrder", con);
        //    adp.SelectCommand.CommandType = CommandType.StoredProcedure;
        //    DataTable dt = new DataTable();
        //    adp.Fill(dt);
        //    return dt;
        //}
        //public usprp EditOrder(usprp pr)
        //{
        //    if (con.State == ConnectionState.Closed)
        //        con.Open();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = con;
        //    cmd.CommandText = "spStockOrderSelect";
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@OrderId ", pr.Pid);
        //    usprp prp = new usprp();
        //    SqlDataReader dr = cmd.ExecuteReader();

        //    if (dr.HasRows)
        //    {
        //        dr.Read();
        //        prp.Pname = dr["OrderProductId"].ToString();
        //        prp.Pcode = dr["OrderProductNumber"].ToString();
        //        prp.PType = dr["OrderProductUnit"].ToString();
        //        prp.Pid = dr["OrderId"].ToString();

        //    } 
        //    return prp;

        //    dr.Dispose();
        //    con.Close();
        //}
        //public void UpdateOrder(usprp prp)
        //{

        //    if (con.State == ConnectionState.Closed)
        //        con.Open();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = con;
        //    cmd.CommandText = "spStockProductUpdate";
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@OrderProductId", prp.Pname);
        //    cmd.Parameters.AddWithValue("@OrderProductNumber", prp.Pcode);
        //    cmd.Parameters.AddWithValue("@OrderProductUnit", prp.PType);
        //    cmd.ExecuteNonQuery();
        //    cmd.Dispose();
        //    con.Close();
        //}
        //End 
        //Student Adress info start
        //public void InsertStudentAddressInfo(usprp prp)
        //{

        //    if (con.State == ConnectionState.Closed)
        //        con.Open();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = con;
        //    cmd.CommandText = "SpInsertFatherProfile";
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@fprofile1stName", prp.PFname);
        //    cmd.Parameters.AddWithValue("@fprofileEmailId", prp.PFEmail);
        //    cmd.Parameters.AddWithValue("@fprofileOccupation", prp.PFOcupation);
        //    cmd.Parameters.AddWithValue("@fprofileDistrict", prp.PFDist);
        //    cmd.Parameters.AddWithValue("@fprofileState", prp.PFstate);
        //    cmd.Parameters.AddWithValue("@fprofilePinCode", prp.PFcode);
        //    cmd.Parameters.AddWithValue("@fprofilePhoneNo", prp.PFPhone);
        //    cmd.Parameters.AddWithValue("@fprofileMobNo", prp.PFMobile);
        //    cmd.Parameters.AddWithValue("@fprofileFaxNo", prp.PFFax);
        //    cmd.Parameters.AddWithValue("@fprofileImagePath", prp.PFImage);
        //    cmd.Parameters.AddWithValue("@fprofileAddressLineI", prp.PFAddress);
        //    cmd.Parameters.AddWithValue("@fprofileCity", prp.PFCity);//father
        //    cmd.Parameters.AddWithValue("@mprofile1stName", prp.PMname);
        //    cmd.Parameters.AddWithValue("@mprofileEmailId", prp.PMEmail);
        //    cmd.Parameters.AddWithValue("@mprofileOccupation", prp.PMOcupation);
        //    cmd.Parameters.AddWithValue("@mprofileDistrict", prp.PMDist);
        //    cmd.Parameters.AddWithValue("@mprofileState", prp.PMstate);
        //    cmd.Parameters.AddWithValue("@mprofilePinCode", prp.PMcode);
        //    cmd.Parameters.AddWithValue("@mprofilePhoneNo", prp.PMPhone);
        //    cmd.Parameters.AddWithValue("@mprofileMobNo", prp.PMMobile);
        //    cmd.Parameters.AddWithValue("@mprofileFaxNo", prp.PMFax);
        //    cmd.Parameters.AddWithValue("@mprofileImagePath", prp.PMImage);
        //    cmd.Parameters.AddWithValue("@mprofileAddressLineI", prp.PMAddress);
        //    cmd.Parameters.AddWithValue("@mprofileCity", prp.PMCity);//mother
        //    cmd.Parameters.AddWithValue("@profileEmailId", prp.PEmail);
        //    cmd.Parameters.AddWithValue("@profileOccupation", prp.POcupation);
        //    cmd.Parameters.AddWithValue("@profileDistrict", prp.PDist);
        //    cmd.Parameters.AddWithValue("@profileState", prp.PState);
        //    cmd.Parameters.AddWithValue("@profilePinCode", prp.Pcode);
        //    cmd.Parameters.AddWithValue("@profilePhoneNo", prp.PPhone);
        //    cmd.Parameters.AddWithValue("@profileMobNo", prp.PMobile);
        //    cmd.Parameters.AddWithValue("@profileFaxNo", prp.PFax);
        //    cmd.Parameters.AddWithValue("@profileImagePath", prp.PImage);
        //    cmd.Parameters.AddWithValue("@profileAddressLineI", prp.PAddress);
        //    cmd.Parameters.AddWithValue("@profileCity", prp.PCity);
        //    cmd.Parameters.AddWithValue("@profileid", prp.Pid);
        //    cmd.ExecuteNonQuery();
        //    cmd.Dispose();
        //    con.Close();

        //}
        //public usprp StudentAddressInfo(usprp pr)
        //{
        //    if (con.State == ConnectionState.Closed)
        //        con.Open();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = con;
        //    cmd.CommandText = "SpShowFatherProfile";
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@profileid", pr.Pid);
        //    usprp prp = new usprp();
        //    SqlDataReader dr = cmd.ExecuteReader();

        //    if (dr.HasRows)
        //    {
        //        dr.Read();
        //        //prp.Pname = dr["OrderProductId"].ToString();
        //         prp.PFname= dr["fathername"].ToString();
        //         prp.PFEmail= dr["fatheremailid"].ToString();
        //        prp.PFOcupation= dr["fatherOcupation"].ToString();
        //         prp.PFDist= dr["fatherDistrict"].ToString();
        //        prp.PFstate= dr["fatherState"].ToString();
        //        prp.PFcode= dr["fatherpincode"].ToString();
        //        prp.PFPhone= dr["fatherPhone"].ToString();
        //        prp.PFMobile= dr["fatherMobNo"].ToString();
        //        prp.PFFax= dr["fatherFaxNo"].ToString();
        //         prp.PFImage= dr["fatherImage"].ToString();
        //        prp.PFAddress= dr["fatherAddress"].ToString();
        //         prp.PFCity= dr["fatherCity"].ToString();//father
        //        prp.PMname= dr["motherName"].ToString();
        //        prp.PMEmail= dr["motherEmailId"].ToString();
        //         prp.PMOcupation= dr["motherOcupation"].ToString();
        //         prp.PMDist= dr["motherDistrict"].ToString();
        //        prp.PMstate= dr["MotherState"].ToString();
        //        prp.PMcode= dr["motherPincode"].ToString();
        //        prp.PMPhone= dr["motherPhone"].ToString();
        //        prp.PMMobile= dr["motherMobno"].ToString();
        //        prp.PMFax= dr["motherfaxno"].ToString();
        //        prp.PMImage= dr["motherImage"].ToString();
        //         prp.PMAddress= dr["motherAddress"].ToString();
        //        prp.PMCity= dr["motherCity"].ToString();//mother
        //        prp.PEmail= dr["profileimagepath"].ToString();
        //         prp.POcupation= dr["profileocupation"].ToString();
        //        prp.PDist= dr["profiledistrict"].ToString();
        //       prp.PState= dr["profilestate"].ToString();
        //         prp.Pcode= dr["profilePinCode"].ToString();
        //      prp.PPhone= dr["Profilephoneno"].ToString();
        //         prp.PMobile= dr["profilemobno"].ToString();
        //         prp.PFax= dr["profilefaxno"].ToString();
        //      prp.PImage= dr["OrderProductId"].ToString();
        //         prp.PAddress= dr["profileAddress"].ToString();
        //         prp.PCity= dr["profileCity"].ToString();
        //         prp.Pname= dr["profilename"].ToString();
        //       prp.Pid= dr["profileid"].ToString();
        // }
        //    return prp;

        //    dr.Dispose();
        //    con.Close();
        //}
        //public DataTable BindStudentAddressInfo()
        //{
        //    SqlDataAdapter adp = new SqlDataAdapter("SpShowFatherProfile", con);
        //    adp.SelectCommand.CommandType = CommandType.StoredProcedure;
        //    DataTable dt = new DataTable();
        //    adp.Fill(dt);
        //    return dt;
        //}
        //End student
        //Sesson start
        public void spSessionInsert(usprp prp)
        {

            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spSessionInsert";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sessionName", prp.Pname);
            cmd.Parameters.AddWithValue("@sessionStartDate", prp.PStartDat);
            cmd.Parameters.AddWithValue("@sessionEnddate", prp.Psection);
            cmd.Parameters.AddWithValue("@sessionSummerStartTime", prp.PEndTime);
            cmd.Parameters.AddWithValue("@sesssionWinterStartTime", prp.PStartJone);
            cmd.Parameters.AddWithValue("@sessionSummerEndTime", prp.PStartTime);
            cmd.Parameters.AddWithValue("@sesssionWinterEndTime", prp.PEndJone);
            cmd.Parameters.AddWithValue("@sesssionSchoolId", prp.Pid);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
         }
        public usprp SessonInfo(usprp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spSessionSelect";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sessionId", pr.Pid);
            usprp prp = new usprp();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
               prp.Pname= dr["sessionName"].ToString();
               prp.PStartDat= dr["sessionStartDate"].ToString();
               prp.Psection= dr["sessionEnddate"].ToString();
               prp.PEndTime=   dr["sessionSummerStartTime"].ToString();
               prp.PStartJone= dr["sesssionWinterStartTime"].ToString();
                prp.PStartTime=dr["sessionSummerEndTime"].ToString();
                prp.PEndJone= dr["sesssionWinterEndTime"].ToString();
                prp.Pid = dr["sessionId"].ToString();
            }
            dr.Dispose();
            con.Close();
            return prp;

            
        }
        public DataTable BindSession(prpprofile prp)
        {
            SqlDataAdapter adp = new SqlDataAdapter("spSession", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@schoolId",prp.Id);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public void spSessionUpdate(usprp prp)
        {

            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spSessionUpdate";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sessionName", prp.Pname);
            cmd.Parameters.AddWithValue("@sessionStartDate", prp.PStartDat);
            cmd.Parameters.AddWithValue("@sessionEnddate", prp.Psection);
            cmd.Parameters.AddWithValue("@sessionSummerStartTime", prp.PEndTime);
            cmd.Parameters.AddWithValue("@sesssionWinterStartTime", prp.PStartJone);
            cmd.Parameters.AddWithValue("@sessionSummerEndTime", prp.PStartTime);
            cmd.Parameters.AddWithValue("@sesssionWinterEndTime", prp.PEndJone);
            cmd.Parameters.AddWithValue("@sesssionSchoolId", prp.Pid);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }


        public string Login(usprp prp)
        {
            string ret = "";
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spLogin";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@loginName", prp.UserName);
            cmd.Parameters.AddWithValue("@loginPassword", prp.Password);
            ret = cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            con.Close();
            return ret;
        }

        public string ChangepasswordLogin(usprp prp)
        {
            string ret = "";
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spChangepassword";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@loginName", prp.UserName);
            cmd.Parameters.AddWithValue("@loginPassword", prp.Password);
            cmd.Parameters.AddWithValue("@loginOldPassword", prp.oldPassword);

            ret = cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            con.Close();
            return ret;
        }

        public string SchoolInsert(prpprofile prp)
        {
            string ret = "";
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spSchoolInsert";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SchoolName", prp.Name);
            cmd.Parameters.AddWithValue("@SchoolMoto", prp.Meto);
            cmd.Parameters.AddWithValue("@schoolImage", prp.Image);
            cmd.Parameters.AddWithValue("@schoolAddress", prp.Address);
            cmd.Parameters.AddWithValue("@SchoolCity", prp.City);
            cmd.Parameters.AddWithValue("@SchoolDist", prp.District);
            cmd.Parameters.AddWithValue("@SchoolWeb", prp.Website);
            cmd.Parameters.AddWithValue("@SchoolState", prp.state);
            cmd.Parameters.AddWithValue("@SchoolPinCode", prp.PinCode);
            cmd.Parameters.AddWithValue("@SchoolEmail", prp.EmailId);
            cmd.Parameters.AddWithValue("@schoolMobile", prp.MobNo);
            cmd.Parameters.AddWithValue("@schoolPhone", prp.PhoneNo);
            cmd.Parameters.AddWithValue("@SchoolFax", prp.FaxNo);

            cmd.Parameters.AddWithValue("@schoolCode", prp.Code);
            cmd.Parameters.AddWithValue("@schoolWebName", prp.webname);
            cmd.Parameters.AddWithValue("@mangmentPassword", prp.pwd);
   


            ret = cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            con.Close();
            return ret;
        }


        public string SchoolUpdate(prpprofile prp)
        {
            string ret = "";
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spSchoolUpdate";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@schoolId", prp.Id);
            cmd.Parameters.AddWithValue("@SchoolName", prp.Name);
            cmd.Parameters.AddWithValue("@SchoolMoto", prp.Meto);
            cmd.Parameters.AddWithValue("@schoolImage", prp.Image);
            cmd.Parameters.AddWithValue("@schoolAddress", prp.Address);
            cmd.Parameters.AddWithValue("@SchoolCity", prp.City);
            cmd.Parameters.AddWithValue("@SchoolDist", prp.District);
            cmd.Parameters.AddWithValue("@SchoolWeb", prp.Website);
            cmd.Parameters.AddWithValue("@SchoolState", prp.state);
            cmd.Parameters.AddWithValue("@SchoolPinCode", prp.PinCode);
            cmd.Parameters.AddWithValue("@SchoolEmail", prp.EmailId);
            cmd.Parameters.AddWithValue("@schoolMobile", prp.MobNo);
            cmd.Parameters.AddWithValue("@schoolPhone", prp.PhoneNo);
            cmd.Parameters.AddWithValue("@SchoolFax", prp.FaxNo);

            ret = cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            con.Close();
            return ret;
        }


        public DataTable spschoolProfileById(usprp prp)
        {
            SqlDataAdapter adp = new SqlDataAdapter("spschoolProfileById", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@id", prp.Pid);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }


        public string spLoginCheck(prpprofile prp)
        {
            string msg="";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "spLoginCheck";
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@LoginName", prp.LoginName);
            cmd.Parameters.AddWithValue("@password", prp.Password);
            cmd.Parameters.AddWithValue("@IPaddress", prp.lastIP);

            msg = cmd.ExecuteScalar().ToString();
            return msg;
        }


        public string CodeSetting(usprp prp)
        {
            string ret = "";
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spCodeSettingUpdate";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@for", prp.PFor);
            cmd.Parameters.AddWithValue("@preFix", prp.PPreFix);
            cmd.Parameters.AddWithValue("@postFix", prp.PPostFix);
            cmd.Parameters.AddWithValue("@SchoolId", prp.PSchoolID);
            cmd.Parameters.AddWithValue("@postCode", prp.Pcode);
            cmd.Parameters.AddWithValue("@preCode", prp.Pid);


            ret = cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            con.Close();
            return ret;
        }

        public usprp CodeByType(usprp pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            //usprp prp = new usprp();
            cmd.Connection = con;
            cmd.CommandText = "spCodeByType";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@for", pr.PFor);
            cmd.Parameters.AddWithValue("@SchoolId", pr.PSchoolID);

            usprp prp = new usprp();
                    
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    prp.PPostFix = dr["codeSettingPostFix"].ToString();
                    prp.PPreFix = dr["codeSettingPreFix"].ToString();
                   
                    prp.Pcode = dr["codesettingPostCode"].ToString();
                    prp.Pid = dr["codesettingPreCode"].ToString();

                }
            }

            dr.Dispose();
            con.Close();
            return prp;

        }




        public DataTable spStudentFeeApplybyType(prpprofile prp)
        {
            SqlDataAdapter adp = new SqlDataAdapter("spStudentFeeApplybyType", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@schoolId", prp.SchoolId);
            adp.SelectCommand.Parameters.AddWithValue("@stuentRollNo", prp.RollNo);
            adp.SelectCommand.Parameters.AddWithValue("@feeByType", prp.Type);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }

       //--------------------------------------------------- ---------------------------
        public usprp spStudentDetailByRollNo(prpprofile pr)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            //usprp prp = new usprp();
            cmd.Connection = con;
            cmd.CommandText = "spStudentDetailByRollNo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@rollNo", pr.RollNo);
            cmd.Parameters.AddWithValue("@schoolId", pr.SchoolId);
            usprp prp = new usprp();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                prp.Pid = dr["studentId"].ToString();
                prp.PMobile = dr["mobileno"].ToString();
                prp.PRoll = dr["StudentRollNo"].ToString();
                prp.Pcode = dr["StudentEnrollMentNo"].ToString();
                prp.PClass = dr["Studentclass"].ToString();
                prp.PGroupName = dr["subjectGroupName"].ToString();
                prp.Pname = dr["studentname"].ToString();
                prp.fatherName = dr["FatherName"].ToString();
                prp.mothnerName = dr["MotherName"].ToString();
                prp.PDateOfBirth = dr["profileDOB"].ToString();
               
            }
            dr.Dispose();
            cmd.Dispose();
            con.Close();
            return prp;

        }

        //--------------------------------------------------- ---------------------------
     }
}


