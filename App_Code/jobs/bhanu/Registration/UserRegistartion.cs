using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using dal.Registration;
namespace bal.Registration
{

    public class UserRegistartion
    {
        RegistrationDB objRegistrationDB;
        
        public string SavePersonalDetails(UserRegistraionProp objRegistrationProp)
        {
            objRegistrationDB = new RegistrationDB();
            return objRegistrationDB.SavePersonalDetails(objRegistrationProp);
        }
        public string CheckLogins(UserRegistraionProp objRegistrationProp)
        {
            objRegistrationDB = new RegistrationDB();
            return objRegistrationDB.CheckLogins(objRegistrationProp);
        }
        public string ChangePassowrd(UserRegistraionProp objRegistrationProp)
        {
            objRegistrationDB = new RegistrationDB();
            return objRegistrationDB.ChangePassowrd(objRegistrationProp);
        }
        public string GetPassword(UserRegistraionProp objRegistrationProp)
        {
            objRegistrationDB = new RegistrationDB();
            return objRegistrationDB.GetPassword(objRegistrationProp);
        }
        public string ActivateAcount(string strReq)
        {
            objRegistrationDB = new RegistrationDB();
            return objRegistrationDB.ActivateAcount(strReq);
        }
        
    }
}