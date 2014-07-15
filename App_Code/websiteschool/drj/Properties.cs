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
namespace SchoolInFormation
{
    public class clsprop
    {
        Int32 _MainLineId;
        string _MainLineType, _MainLine, _SchoolId;
        public string MainLineType
        {
            get { return _MainLineType; }
            set { _MainLineType = value; }
        }
        public string MainLine
        {
            get { return _MainLine; }
            set { _MainLine = value; }
        }
        public string SchoolId
        {
            get { return _SchoolId; }
            set { _SchoolId = value; }
        }

        public Int32 MainLineId
        {
            get { return _MainLineId; }
            set { _MainLineId = value; }
        }
        
        Int32 _contentId;
        string _contentTitle,_contentDetails,_contentImagepath;

        public Int32 contentId
        {
            get { return _contentId; }
            set { _contentId = value; }
        }
        public string contentTitle
        {
            get { return _contentTitle; }
            set { _contentTitle = value; }
        }
        public string contentDetails
        {
            get { return _contentDetails; }
            set { _contentDetails = value; }
        }
        public string contentImagepath
        {
            get { return _contentImagepath; }
            set { _contentImagepath = value; }
        }



        Int32 _imageId;
        string _imageType, _imageTitle, _imagePath;
        public string imageType
        {
            get { return _imageType; }
            set { _imageType = value; }
        }
        public string imageTitle
        {
            get { return _imageTitle; }
            set { _imageTitle = value; }
        }
        public string imagePath
        {
            get { return _imagePath; }
            set { _imagePath = value; }
        }
        public Int32 imageId
        {
            get { return _imageId; }
            set { _imageId = value; }
        }


    }

   
}
