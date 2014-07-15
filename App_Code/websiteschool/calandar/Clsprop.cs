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


namespace Calander
{
    public class clsprop
    {
        string _name, _Type, _Description, _Location, _EndDate, _StartDate, _EndTime, _StartTime,_Organiser,_RemindingDate,_id;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Type
        {
            get { return _Type; }
            set { _Type = value; }
        }
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        public string Location
        {
            get { return _Location; }
            set { _Location = value; }
        }

        public string EndDate
        {
            get { return _EndDate; }
            set { _EndDate = value; }
        }
        public string StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }
        public string EndTime
        {
            get { return _EndTime; }
            set { _EndTime = value; }
        }
        public string StartTime
        {
            get { return _StartTime; }
            set { _StartTime = value; }
        }
        public string Organiser
        {
            get { return _Organiser; }
            set { _Organiser = value; }
        }
        public string RemindingDate
        {
            get { return _RemindingDate; }
            set { _RemindingDate = value; }
        }
        public string id
        {
            get { return _id; }
            set { _id = value; }
        }
    
    }

}
