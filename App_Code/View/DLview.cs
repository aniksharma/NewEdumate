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
using nmsView;
using nmsADO;
using nmsProfile;
namespace nmsView
{
    public class clsDLView
    {
        clsprpADO objadoprp = new clsprpADO();
        clsADO objado = new clsADO();
        clsBLado ADO = new clsBLado();
        clsPRPadoDL ADOprpDL = new clsPRPadoDL();
        clsPRPadoBL ADOprp = new clsPRPadoBL();

        //public List<clsPRPprofileAdvance> BasicProfileByAdmin(clsPRPParm objprp)
        //{
        //    objadoprp.Cmd = new SqlCommand();
        //    objadoprp.Cmd.CommandText = "spAdminBasicProfile";
            
        //    objadoprp.Cmd.Parameters.AddWithValue("@pageIndex", objprp.PageIndex);
        //    objadoprp.Cmd.Parameters.AddWithValue("@pageSize", objprp.PageSize);
        //    objado.ReaderQuery(objadoprp);

        //    List<clsPRPprofileAdvance> list = new List<clsPRPprofileAdvance>();
        //    clsPRPprofileAdvance obj;

        //    if (objadoprp.ReturnMsg == "success")
        //    {
        //        if (objadoprp.Dr.HasRows)
        //        {
        //            while (objadoprp.Dr.Read())
        //            {

        //                obj = new clsPRPprofileAdvance();
        //                obj.SrNo = objadoprp.Dr["row"].ToString();
        //                obj.profileMemberid = objadoprp.Dr["profileMemid"].ToString();
        //                obj.profileFirstName = objadoprp.Dr["profileFirstName"].ToString();
        //                obj.profileLastName = objadoprp.Dr["profileLastName"].ToString();
        //                obj.profileGender = objadoprp.Dr["profileGender"].ToString();
        //                obj.profileDOB = objadoprp.Dr["profileDOB"].ToString();
        //                obj.profileAddress = objadoprp.Dr["profileAddress"].ToString();
        //                obj.profileCity = objadoprp.Dr["profileCity"].ToString();
        //                obj.profileDistrict = objadoprp.Dr["profileDistrict"].ToString();
        //                obj.profileState = objadoprp.Dr["profileState"].ToString(); ;
        //                obj.profilecountry = objadoprp.Dr["profilecountry"].ToString();
        //                obj.profilePinCode = objadoprp.Dr["profilePinCode"].ToString();
        //                obj.profilePhoneNo = objadoprp.Dr["profilePhoneNo"].ToString();
        //                obj.profileMobileNo = objadoprp.Dr["profileMobileNo"].ToString();
        //                obj.profileEmailID = objadoprp.Dr["profileEmailID"].ToString();
        //                obj.profileOccupation = objadoprp.Dr["profileOccupation"].ToString();

        //                obj.fatherName = objadoprp.Dr["profileFatherName"].ToString();
        //                obj.fatherRelation = objadoprp.Dr["profileRelation"].ToString();
        //                obj.nominee = objadoprp.Dr["profileNominee"].ToString();
        //                obj.nomineeRelation = objadoprp.Dr["profileNomineeRelation"].ToString();

        //                obj.kitName = objadoprp.Dr["kitName"].ToString();
        //                obj.infoPosition = objadoprp.Dr["infoPosition"].ToString();
        //                obj.infoJoiningDate = objadoprp.Dr["infoJoiningDate"].ToString();
        //                obj.infoMemId = objadoprp.Dr["infoMemId"].ToString();
        //                obj.infoKitId = objadoprp.Dr["infoKitId"].ToString();
        //                obj.infoSponsorId = objadoprp.Dr["infoSponsorId"].ToString();
        //                obj.loginPassword = objadoprp.Dr["loginPassword"].ToString();
        //                obj.loginStatus = objadoprp.Dr["loginStatus"].ToString();
        //                obj.grpRightId = objadoprp.Dr["grpRightId"].ToString();
        //                obj.grpLeftId = objadoprp.Dr["grpleftId"].ToString();
        //                obj.sponsorName = objadoprp.Dr["sponsorName"].ToString();
        //                obj.sponsorMob = objadoprp.Dr["sponsorMobileNO"].ToString();
        //                obj.sponsorCity = objadoprp.Dr["sponsorCity"].ToString();
                 
        //                list.Add(obj);


        //            }
        //            if (objadoprp.Dr.NextResult())
        //            {

        //                objadoprp.Dr.Read();
        //                obj = new clsPRPprofileAdvance();
        //                obj.noOfRecord = objadoprp.Dr[0].ToString();
        //                list.Add(obj);
        //            }


        //        }
        //        else
        //        {
        //            obj = new clsPRPprofileAdvance();
        //            obj.SrNo = "Result Not Find";
        //            list.Add(obj);
        //        }

        //    }
        //    else
        //    {
        //        obj = new clsPRPprofileAdvance();
        //        obj.SrNo = "Result Not Find";
        //        list.Add(obj);
        //    }

        //    objado.ReaderClose(objadoprp);

        //    return list;

        //}
        public List<clsPRPView> ViewDwonlineByMemid(clsPRPParm objprp)
        {
            objadoprp.Cmd = new SqlCommand();
            objadoprp.Cmd.CommandText = "spViewDownlineWithBusiness";
            objadoprp.Cmd.Parameters.AddWithValue("@viewType", objprp.ViewType);
            objadoprp.Cmd.Parameters.AddWithValue("@memId", objprp.MemId);
            objadoprp.Cmd.Parameters.AddWithValue("@pageIndex", objprp.PageIndex);
            objadoprp.Cmd.Parameters.AddWithValue("@pageSize", objprp.PageSize);

            if (objprp.ViewType == "search")
            {
                objadoprp.Cmd.Parameters.AddWithValue("@startDate", objprp.StartDate);
                objadoprp.Cmd.Parameters.AddWithValue("@endDate", objprp.EndDate);
            }
            objado.ReaderQuery(objadoprp);

            List<clsPRPView> list = new List<clsPRPView>();
            clsPRPView obj;

            if (objadoprp.ReturnMsg == "success")
            {
                if (objadoprp.Dr.HasRows)
                {
                    while (objadoprp.Dr.Read())
                    {

                        obj = new clsPRPView();
                        obj.SrNo = objadoprp.Dr["row"].ToString();
                        obj.Date = objadoprp.Dr["infoJoiningDate"].ToString();
                        obj.Memid = objadoprp.Dr["infoMemId"].ToString();
                        obj.Sponsorid = objadoprp.Dr["infoSponsorId"].ToString();
                        obj.Name = objadoprp.Dr["profileFirstName"].ToString();
                        obj.Memo = objadoprp.Dr["sponsorName"].ToString();
                        obj.leftBusiness = objadoprp.Dr["LeftBusiness"].ToString();
                        obj.rightBusiness = objadoprp.Dr["RightBusiness"].ToString();
                        
                        list.Add(obj);


                    }
                    if (objadoprp.Dr.NextResult())
                    {

                        objadoprp.Dr.Read();
                        obj = new clsPRPView();
                        obj.noOfRecord = objadoprp.Dr[0].ToString();
                        list.Add(obj);
                    }


                }
                else
                {
                    obj = new clsPRPView();
                    obj.SrNo = "Result Not Find";
                    list.Add(obj);
                }

            }
            else
            {
                obj = new clsPRPView();
                obj.SrNo = "Result Not Find";
                list.Add(obj);
            }

            objado.ReaderClose(objadoprp);

            return list;

        }
        public List<clsPRPView> ViewRewards()
        {
            objadoprp.Cmd = new SqlCommand();
            objadoprp.Cmd.CommandText = "spPayoutRewards";

            objado.ReaderQuery(objadoprp);

            List<clsPRPView> list = new List<clsPRPView>();
            clsPRPView obj;

            if (objadoprp.ReturnMsg == "success")
            {
                if (objadoprp.Dr.HasRows)
                {
                    while (objadoprp.Dr.Read())
                    {

                        obj = new clsPRPView();
                        obj.Level = objadoprp.Dr["pairLevel"].ToString();
                        obj.Pair = objadoprp.Dr["pairTotal"].ToString();
                        obj.Reward = objadoprp.Dr["pairReward"].ToString();
                        obj.SalaryAmount = objadoprp.Dr["pairSalary"].ToString();
                        obj.salaryForMonth = objadoprp.Dr["pairForMonths"].ToString();
                        
                        list.Add(obj);


                    }
                    if (objadoprp.Dr.NextResult())
                    {

                        objadoprp.Dr.Read();
                        obj = new clsPRPView();
                        obj.noOfRecord = objadoprp.Dr[0].ToString();
                        list.Add(obj);
                    }


                }
                else
                {
                    obj = new clsPRPView();
                    obj.SrNo = "Result Not Find";
                    list.Add(obj);
                }

            }
            else
            {
                obj = new clsPRPView();
                obj.SrNo = "Result Not Find";
                list.Add(obj);
            }

            objado.ReaderClose(objadoprp);

            return list;

        }
        public List<clsPRPView> ViewPayout(clsPRPParm objprp)
        {
            objadoprp.Cmd = new SqlCommand();
            objadoprp.Cmd.CommandText = "spPayoutDetail";
            objadoprp.Cmd.Parameters.AddWithValue("@pageIndex", objprp.PageIndex);
            objadoprp.Cmd.Parameters.AddWithValue("@pageSize", objprp.PageSize);

            objado.ReaderQuery(objadoprp);

            List<clsPRPView> list = new List<clsPRPView>();
            clsPRPView obj;

            if (objadoprp.ReturnMsg == "success")
            {
                if (objadoprp.Dr.HasRows)
                {
                    while (objadoprp.Dr.Read())
                    {

                        obj = new clsPRPView();
                        obj.SrNo = objadoprp.Dr["row"].ToString();
                        obj.Date = objadoprp.Dr["payoutdate"].ToString();
                        obj.Memid = objadoprp.Dr["profileMemid"].ToString();
                        obj.MemName = objadoprp.Dr["profileFirstName"].ToString();
                        obj.mobNo = objadoprp.Dr["profileMobileNo"].ToString();
                        obj.Sponsorid = objadoprp.Dr["infoSponsorId"].ToString();
                        obj.SponsorName = objadoprp.Dr["sponsorName"].ToString();
                        obj.Level = objadoprp.Dr["pairLevel"].ToString();
                        obj.Pair = objadoprp.Dr["payoutPair"].ToString();

                        obj.Reward = objadoprp.Dr["pairReward"].ToString();

                        obj.SalaryAmount = objadoprp.Dr["pairSalary"].ToString();
                        obj.rewardStatus = objadoprp.Dr["payoutRewardStatus"].ToString();
                        obj.slaryStatus = objadoprp.Dr["payoutSalaryStatus"].ToString();
                        
                        list.Add(obj);


                    }
                    if (objadoprp.Dr.NextResult())
                    {

                        objadoprp.Dr.Read();
                        obj = new clsPRPView();
                        obj.noOfRecord = objadoprp.Dr[0].ToString();
                        list.Add(obj);
                    }


                }
                else
                {
                    obj = new clsPRPView();
                    obj.SrNo = "Result Not Find";
                    list.Add(obj);
                }

            }
            else
            {
                obj = new clsPRPView();
                obj.SrNo = "Result Not Find";
                list.Add(obj);
            }

            objado.ReaderClose(objadoprp);

            return list;

        }
        public string GetMaxFileId( clsPRPParm objprp )
        {          
            ADOprp.SPName = objprp.spName;
            return ADO.ScalarQueryWithProcedures(ADOprp);            
        }        
        public List<clsPRPView> uniuversityName()
        {
            objadoprp.Cmd = new SqlCommand();
            objadoprp.Cmd.CommandText = "binduniversity1";
            objado.ReaderQuery(objadoprp);
            List<clsPRPView> list = new List<clsPRPView>();
            clsPRPView obj;
            if (objadoprp.ReturnMsg == "success")
            {
                if (objadoprp.Dr.HasRows)
                {
                    while (objadoprp.Dr.Read())
                    {

                        obj = new clsPRPView();
                        obj.BinaryId = objadoprp.Dr["uniID"].ToString();
                        obj.MemName = objadoprp.Dr["uniName"].ToString();
                        obj.ForId = objadoprp.Dr["txtCatID"].ToString();
                        list.Add(obj);
                    }                   

                }
                else
                {
                    obj = new clsPRPView();
                    obj.SrNo = "Result Not Find";
                    list.Add(obj);
                }

            }
            else
            {
                obj = new clsPRPView();
                obj.SrNo = "Result Not Find";
                list.Add(obj);
            }

            objado.ReaderClose(objadoprp);

            return list;


        }
        public string SelUniLogo(clsPRPParm objprp)
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@uniID", objprp.uniID);
            ADOprp.SPName = "selUniLogo";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }
        public List<clsPRPView> CourseCategory(clsPRPParm objprp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@id", objprp.uniID);
            ADOprpDL.SPName = "viewCourseCategory1";
            ADO.ReaderWithProceduresandParam(ADOprpDL);
            
            List<clsPRPView> list = new List<clsPRPView>();
            clsPRPView obj;
             if (ADOprpDL.Dr.HasRows)
                {
                    while (ADOprpDL.Dr.Read())
                    {

                        obj = new clsPRPView();
                        obj.BinaryId = ADOprpDL.Dr["id"].ToString();
                        obj.MemName = ADOprpDL.Dr["name"].ToString();
                        list.Add(obj);
                    }
                    ADO.ReaderClose(ADOprpDL);
                }
                else
                {
                    obj = new clsPRPView();
                    obj.SrNo = "Result Not Find";
                    list.Add(obj);
                }
                

            return list;


        }
        public List<clsPRPView> DownloadLink(clsPRPParm objprp)
        {
            ADOprpDL.ArrayPram = new SqlParameter[1];
            ADOprpDL.ArrayPram[0] = new SqlParameter("@id", objprp.uniID);
            ADOprpDL.SPName = "viewFileDetail1";
            ADO.ReaderWithProceduresandParam(ADOprpDL);
            List<clsPRPView> list = new List<clsPRPView>();
            clsPRPView obj;
            
                if (ADOprpDL.Dr.HasRows)
                {
                    while (ADOprpDL.Dr.Read())
                    {
                        
                        obj = new clsPRPView();
                        obj.BinaryId = ADOprpDL.Dr["id"].ToString();
                        obj.MemName = ADOprpDL.Dr["name"].ToString();
                        obj.Level = ADOprpDL.Dr["Path"].ToString();
                        list.Add(obj);
                    }
                    ADO.ReaderClose(ADOprpDL);
                }
                else
                {
                    obj = new clsPRPView();
                    obj.SrNo = "Result Not Find";
                    list.Add(obj);
                }
                
                      

            return list;


        }
        public string viewVisitorCounter()
        {
            ADOprp.ArrayPram = new SqlParameter[1];
            ADOprp.ArrayPram[0] = new SqlParameter("@visitorID", "1");
            ADOprp.SPName = "viewVisitor";
            return ADO.ScalarQueryWithProceduresandParam(ADOprp);
        }        
    }
}