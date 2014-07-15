using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using dal.Registration;
namespace bal.Registration
{
    public class ManageUserProfileBL
    {
        ManageUserProfileDB objManageUserProfileDB;
        public UserRegistraionProp GetUserFullDetails(UserRegistraionProp objUserRegistraionProp)
        {
            objManageUserProfileDB = new ManageUserProfileDB();
            return objManageUserProfileDB.GetUserFullDetails(objUserRegistraionProp);
        }
        public string UpdateQualifcationDetails(UserRegistraionProp objUserRegistraionProp)
        {
            objManageUserProfileDB = new ManageUserProfileDB();
            return objManageUserProfileDB.UpdateQualifcationDetails(objUserRegistraionProp);
        }
        public string UpdateCurrentWorkDetails(UserRegistraionProp objUserRegistraionProp)
        {
            objManageUserProfileDB = new ManageUserProfileDB();
            return objManageUserProfileDB.UpdateCurrentWorkDetails(objUserRegistraionProp);
        }
        public string UpdateWorkDetails(UserRegistraionProp objUserRegistraionProp)
        {
            objManageUserProfileDB = new ManageUserProfileDB();
            return objManageUserProfileDB.UpdateWorkDetails(objUserRegistraionProp);
        }
        
        public string UpdatePersonalDetails(UserRegistraionProp objUserRegistraionProp)
        {
            objManageUserProfileDB = new ManageUserProfileDB();
            return objManageUserProfileDB.UpdatePersonalDetails(objUserRegistraionProp);
        }
        
    }
}