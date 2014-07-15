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
namespace nmsMicro
{
    public class prpMicroWeb
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
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

}
