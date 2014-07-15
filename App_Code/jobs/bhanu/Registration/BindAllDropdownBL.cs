using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using dal.Registration;
using System.Data;

namespace bal.Registration
{

    public class BindAllDropdownBL
    {


        BindCountryStateCityDB objBindCountryStateCityDB;

        public DataSet GetJobLocations()
        {
            objBindCountryStateCityDB = new BindCountryStateCityDB();
            return objBindCountryStateCityDB.GetJobLocations();
        }
        public DataSet  GetCountryList()
        {
            objBindCountryStateCityDB = new BindCountryStateCityDB();
            return objBindCountryStateCityDB.GetCountryList();
        }
        public DataSet BindIndustryList()
        {
            objBindCountryStateCityDB = new BindCountryStateCityDB();
            return objBindCountryStateCityDB.BindIndustryList();
        }
        

        public DataSet GetStateList(int SelectedCountryId)
        {
            objBindCountryStateCityDB = new BindCountryStateCityDB();
            return objBindCountryStateCityDB.GetStateList(SelectedCountryId);
        }
        public DataSet BindFunctionList(int SelectedIndustryId)
        {
            objBindCountryStateCityDB = new BindCountryStateCityDB();
            return objBindCountryStateCityDB.BindFunctionList(SelectedIndustryId);
        }

        public DataSet GetCityList(int SelectedStateId)
        {
            objBindCountryStateCityDB = new BindCountryStateCityDB();
            return objBindCountryStateCityDB.GetCityList(SelectedStateId);
        }
        public DataSet BindFunctionRoleList(int SelectedFunctionId)
        {
            objBindCountryStateCityDB = new BindCountryStateCityDB();
            return objBindCountryStateCityDB.BindFunctionRoleList(SelectedFunctionId);
        }
        public DataSet GetQualificationList()
        {
            objBindCountryStateCityDB = new BindCountryStateCityDB();
            return objBindCountryStateCityDB.GetQualificationList();
        }
        public DataSet GetSpecializationList(int SelectedQualificationId)
        {
            objBindCountryStateCityDB = new BindCountryStateCityDB();
            return objBindCountryStateCityDB.GetSpecializationList(SelectedQualificationId);
        }
        public DataSet GetInstituteList()
        {
            objBindCountryStateCityDB = new BindCountryStateCityDB();
            return objBindCountryStateCityDB.GetInstituteList();
        }
        
    }
}