using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using bal.Registration;
using QPDataAccessLayer;
using MovieKiran.Common;
using dal.Common;


namespace dal.Registration
{
    public class RegistrationDB
    {
        SqlConnection con;
        SqlCommand cmd;
        QPMYDAL objQPMYDAL;
        SqlDataReader dr;
        SqlParameter[] sqlParams;
        SendEmail objSendEmail;
        Common.Common objCommon;
        string msg, Message, url;
        int LoginId;
        public RegistrationDB()
        {
            //con = new SqlConnection(ConfigurationManager.ConnectionStrings["st"].ConnectionString);
        }
        public string SavePersonalDetails(UserRegistraionProp objUserRegistraionProp)
        {
            objQPMYDAL = new QPMYDAL();
            try
            {

                sqlParams = new SqlParameter[]
            {
                new SqlParameter("@para_Role_Id", objUserRegistraionProp.jpd_Role_Id),
                new SqlParameter("@para_first_name", objUserRegistraionProp.jpd_First_Name),
                new SqlParameter("@para_Last_Name", objUserRegistraionProp.JPD_Last_Name),
                new SqlParameter("@para_Mobile_No", objUserRegistraionProp.jpd_Mobile_No),
                new SqlParameter("@para_Dateofbirth", objUserRegistraionProp.jpd_Date_Of_Birth),
               
                new SqlParameter("@para_Gender", objUserRegistraionProp.jpd_Gender),
                
                            
                new SqlParameter("@para_Specialization_Id",objUserRegistraionProp.JHQD_Specilization_Id),
                new SqlParameter("@para_Total_Experience_Year",objUserRegistraionProp.JWD_Total_Experience_Year),
                new SqlParameter("@para_Total_Experience_Month",objUserRegistraionProp.JWD_Total_Experience_Month),
                new SqlParameter("@para_City_Id",objUserRegistraionProp.JPD_City_Id),
                new SqlParameter("@para_Email_Id", objUserRegistraionProp.JLD_Emial_Id),
                new SqlParameter("@para_Password",objUserRegistraionProp.JLD_password)

               };
                object ret = objQPMYDAL.QPExecuteScalarSP(sqlParams, "job_Insert_PersonalDetails", out msg, out Message);
                if (Convert.ToInt16(ret) > 0 && msg == "Success")
                {
                    objCommon = new Common.Common();
                   // url = "http://localhost:59226/JobPortal/JobSeaker/Default.aspx?";
                    url = "http://demo.movikiran.in/JobSeaker/Default.aspx?";
                    string strURLWithData = url + objCommon.EncryptQueryString(string.Format("LoginId={0}", Convert.ToInt16(ret)));
                    objSendEmail = new SendEmail();
                    objSendEmail.SendMail(objUserRegistraionProp.JLD_Emial_Id, "", "", "New registration information", "New registration information :" + strURLWithData);
                    return msg;
                }
                else
                {
                    return msg = "unSuccess";
                }


            }
            catch
            {
                return Message;
            }
        }
        public string CheckLogins(UserRegistraionProp objUserRegistraionProp)
        {

            objQPMYDAL = new QPMYDAL();
            try
            {

                sqlParams = new SqlParameter[]
            {
                new SqlParameter("@para_Role_Id", objUserRegistraionProp.jpd_Role_Id),
                new SqlParameter("@para_Email_Id", objUserRegistraionProp.JLD_Emial_Id),
                new SqlParameter("@para_Password", objUserRegistraionProp.JLD_password)
               };


                dr = objQPMYDAL.QPGetDataReaderSP(sqlParams, "job_LoginCheck", out msg, out Message);

                if (dr.HasRows)
                {
                    dr.Read();
                    objUserRegistraionProp.JPD_Personal_Details_Id = Convert.ToInt16(dr["Personal_Details_Id"]);
                    objUserRegistraionProp.JLD_Emial_Id = objUserRegistraionProp.JLD_Emial_Id;
                    HttpContext.Current.Session["logindetails"] = objUserRegistraionProp;
                    return Message = "Success";
                }
                else
                {

                    return Message = "unSuccess";
                }



            }
            catch
            {
                return Message;
            }
        }




        public string ChangePassowrd(UserRegistraionProp objUserRegistraionProp)
        {

            objQPMYDAL = new QPMYDAL();
            try
            {

                sqlParams = new SqlParameter[]
            {
                new SqlParameter("@para_personal_Details_Id", objUserRegistraionProp.JPD_Personal_Details_Id),
                new SqlParameter("@para_Current_Password", objUserRegistraionProp.JLD_password),
                new SqlParameter("@para_New_Password", objUserRegistraionProp.JLD_New_Password)
               };


                object objRetVal = objQPMYDAL.QPExecuteScalarSP(sqlParams, "Job_ChangePassword", out msg, out Message);

                if (objRetVal.ToString() == "PasswordChanged")
                {
                    return Message = "Success";
                }
                else
                {

                    return Message = "unSuccess";
                }



            }
            catch
            {
                return Message;
            }
        }



        public string GetPassword(UserRegistraionProp objUserRegistraionProp)
        {

            objQPMYDAL = new QPMYDAL();
            try
            {

                sqlParams = new SqlParameter[]
            {
                new SqlParameter("@para_Email_Id", objUserRegistraionProp.JLD_Emial_Id)
               };


                object objRetVal = objQPMYDAL.QPExecuteScalarSP(sqlParams, "Job_GetPassword", out msg, out Message);
                if (objRetVal.ToString() != "InvalidEmailId")
                {
                    return Message = objRetVal.ToString();
                }
                else
                {
                    objSendEmail = new SendEmail();
                    objSendEmail.SendMail(objUserRegistraionProp.JLD_Emial_Id, "", "", "Get Password", "Your password is :" + objRetVal.ToString());

                    return Message = objRetVal.ToString();
                }
            }
            catch
            {
                return Message;
            }
        }


        public string ActivateAcount(string strReq)
        {
            
            objCommon = new Common.Common();
            objQPMYDAL = new QPMYDAL();
            try
            {
                strReq = objCommon.DecryptQueryString(strReq);

                //Parse the value... this is done is very raw format.. you can add loops or so to get the values out of the query string...
                string[] arrMsgs = strReq.Split('&');
                string[] arrIndMsg;

                arrIndMsg = arrMsgs[0].Split('='); //Get the Name
                LoginId = Convert.ToInt16(arrIndMsg[1].ToString().Trim());








                sqlParams = new SqlParameter[]
            {
                new SqlParameter("@para_LoginId", LoginId)
               };


                object objRetVal = objQPMYDAL.QPExecuteScalarSP(sqlParams, "jobSpActivateAcount", out msg, out Message);
                if (objRetVal.ToString() != "AccountActivated")
                {
                    //objSendEmail = new SendEmail();
                    //objSendEmail.SendMail(objUserRegistraionProp.JLD_Emial_Id, "", "", "Get Password", "Wel Come :");
                    return Message = objRetVal.ToString();
                }
                else
                {


                    return Message = objRetVal.ToString();
                }
            }
            catch
            {
                return Message;
            }
        }


    }
}